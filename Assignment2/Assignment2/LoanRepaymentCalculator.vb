
Public Class LoanRepaymentCalculator
    Dim LoanScheduleData As New DataTable

    Private Sub LnAmountTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LnAmountTxtBox.TextChanged
        'Validate Loan Amount Value
        If IsNumeric(LnAmountTxtBox.Text.Trim()) Or LnAmountTxtBox.Text.Trim() Is Nothing Then
            LnAmountTxtBox.WithError = False
        Else
            LnAmountTxtBox.WithError = True
        End If
    End Sub

    Private Sub AnInterestRateTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AnnualInterestRateTxtBox.TextChanged
        'Validate Interest Rate Value
        If IsNumeric(AnnualInterestRateTxtBox.Text.Trim()) Or AnnualInterestRateTxtBox.Text.Trim() Is Nothing Then
            AnnualInterestRateTxtBox.WithError = False
        Else
            AnnualInterestRateTxtBox.WithError = True
        End If
    End Sub

    Private Sub LoanPeriodTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LoanPeriodTxtBox.TextChanged
        'Validate Loan Period Value
        If IsNumeric(LoanPeriodTxtBox.Text.Trim()) Or LoanPeriodTxtBox.Text.Trim() Is Nothing Then
            LoanPeriodTxtBox.WithError = False
        Else
            LoanPeriodTxtBox.WithError = True
        End If
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim LoanAmount As Double = 0
        Dim InterestRate As Double = 0
        Dim LoanPeriod As Integer = 0

        Dim IsError As Boolean = False
        'Validate the Loan Amount Input Value
        If Not LnAmountTxtBox.Text.Trim() Is Nothing And LnAmountTxtBox.Text.Trim() <> "" Then
            If IsNumeric(LnAmountTxtBox.Text.Trim()) Then
                LnAmountTxtBox.WithError = False
            Else
                IsError = True
                LnAmountTxtBox.WithError = True
            End If
        Else
            IsError = True
            LnAmountTxtBox.WithError = True
        End If
        'Validate the Annual Interest Input Value
        If Not AnnualInterestRateTxtBox.Text.Trim() Is Nothing And AnnualInterestRateTxtBox.Text.Trim() <> "" Then
            If IsNumeric(AnnualInterestRateTxtBox.Text.Trim()) Then
                AnnualInterestRateTxtBox.WithError = False
            Else
                IsError = True
                AnnualInterestRateTxtBox.WithError = True
            End If
        Else
            IsError = True
            AnnualInterestRateTxtBox.WithError = True
        End If
        'Validate the Loan Period Input Value
        If Not LoanPeriodTxtBox.Text.Trim() Is Nothing And LoanPeriodTxtBox.Text.Trim() <> "" Then
            If IsNumeric(LoanPeriodTxtBox.Text.Trim()) Then
                LoanPeriodTxtBox.WithError = False
            Else
                IsError = True
                LoanPeriodTxtBox.WithError = True
            End If
        Else
            IsError = True
            LoanPeriodTxtBox.WithError = True
        End If

        If IsError Then
            Exit Sub
        End If

        Dim PaymentAmount As Double = 0
        Dim PrincipalAmount As Double = 0
        Dim InterestAmount As Double = 0
        Dim OutstandingAmount As Double = 0

        Dim RoundedPaymentAmount As Double = 0
        Dim RoundedPrincipalAmount As Double = 0
        Dim RoundedInterestAmount As Double = 0

        'Assign Values to the local variables
        LoanAmount = LnAmountTxtBox.Text.Trim()
        InterestRate = AnnualInterestRateTxtBox.Text.Trim()
        LoanPeriod = LoanPeriodTxtBox.Text.Trim()

        If YearsRadioBtn.Checked = True Then
            LoanPeriod = LoanPeriod * 12
        End If

        'Clear LoanScheduleData DataTable
        ClearLoanScheduleData()

        'Create Columns and 
        CreateLoanScheduleData()

        Try
            'InterestRate for each period
            InterestRate = InterestRate / 1200

            'Calculate Equal Payment Value
            PaymentAmount = (LoanAmount * InterestRate) / (1 - ((1 + InterestRate) ^ -LoanPeriod))

            For i As Integer = 1 To LoanPeriod

                PrincipalAmount = PaymentAmount * ((1 + InterestRate) ^ -(1 + LoanPeriod - i))

                InterestAmount = PaymentAmount - PrincipalAmount

                LoanAmount = LoanAmount - PrincipalAmount

                'Round to nearest two digits
                RoundedPaymentAmount = Math.Round(PaymentAmount, 2)
                'Round to nearest two digits
                RoundedInterestAmount = Math.Round(InterestAmount, 2)
                'Round to nearest two digits
                RoundedPrincipalAmount = Math.Round(PrincipalAmount, 2)
                'Round to nearest two digits
                OutstandingAmount = Math.Round(LoanAmount, 2)

                'Add Each Payment to the loanScheduleData Table
                LoanScheduleData.Rows.Add(i, RoundedPaymentAmount, RoundedPrincipalAmount, RoundedInterestAmount, OutstandingAmount)
            Next

            If LoanScheduleData.Rows.Count > 0 Then
                MainPicture.Visible = False
                LoanScheduleLbl.Visible = True
                ScheduleGrid.Visible = True
                'Assign LoanScheduleData to GridView to Show in Frontend
                ScheduleGrid.DataSource = LoanScheduleData
            Else
                MessageBox.Show("Couldnt able to populate the payment details. Please try with valid Inputs")
            End If

        Catch ex As Exception
            MessageBox.Show("Calculation Error!! Please try with valid Inputs")
        End Try


    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        LnAmountTxtBox.Text = Nothing
        AnnualInterestRateTxtBox.Text = Nothing
        LoanPeriodTxtBox.Text = Nothing
        LnAmountTxtBox.WithError = False
        AnnualInterestRateTxtBox.WithError = False
        LoanPeriodTxtBox.WithError = False
        LoanScheduleLbl.Visible = False
        ScheduleGrid.Visible = False
        MainPicture.Visible = True
        YearsRadioBtn.Checked = False
        MonthsRaidoBtn.Checked = True
        ClearLoanScheduleData()
    End Sub


    Public Sub CreateLoanScheduleData()
        'declaring new columns
        Dim PaymentNoColumn As New DataColumn("Payment No", System.Type.GetType("System.Int32"))
        Dim PaymentAmountColumn As New DataColumn("Payment Amount", System.Type.GetType("System.Decimal"))
        Dim PrincipalAmountColumn As New DataColumn("Principal Amount Paid", System.Type.GetType("System.Decimal"))
        Dim InterestAmountColumn As New DataColumn("Interest Amount Paid", System.Type.GetType("System.Decimal"))
        Dim LoanBalanceColumn As New DataColumn("Loan Outstanding Balance", System.Type.GetType("System.Decimal"))

        'adding columns to the data table
        LoanScheduleData.Columns.Add(PaymentNoColumn)
        LoanScheduleData.Columns.Add(PaymentAmountColumn)
        LoanScheduleData.Columns.Add(PrincipalAmountColumn)
        LoanScheduleData.Columns.Add(InterestAmountColumn)
        LoanScheduleData.Columns.Add(LoanBalanceColumn)
    End Sub

    Public Sub ClearLoanScheduleData()
        Try
            'Clear Data in the DataTable
            LoanScheduleData.Clear()
            'Clear the Columns in the DataTable
            LoanScheduleData.Columns.Clear()
        Catch ex As Exception

        End Try

    End Sub


End Class
