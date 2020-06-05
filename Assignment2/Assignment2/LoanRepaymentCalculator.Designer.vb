<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanRepaymentCalculator

    'Using Metro framework
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LnAmountLbl = New MetroFramework.Controls.MetroLabel()
        Me.AnnualInterestRateLbl = New MetroFramework.Controls.MetroLabel()
        Me.LoanPeriodLbl = New MetroFramework.Controls.MetroLabel()
        Me.LnAmountTxtBox = New MetroFramework.Controls.MetroTextBox()
        Me.AnnualInterestRateTxtBox = New MetroFramework.Controls.MetroTextBox()
        Me.LoanPeriodTxtBox = New MetroFramework.Controls.MetroTextBox()
        Me.CalculateBtn = New MetroFramework.Controls.MetroButton()
        Me.ClearBtn = New MetroFramework.Controls.MetroButton()
        Me.ScheduleGrid = New MetroFramework.Controls.MetroGrid()
        Me.MainPicture = New System.Windows.Forms.PictureBox()
        Me.LoanScheduleLbl = New MetroFramework.Controls.MetroLabel()
        Me.HeaderTile = New MetroFramework.Controls.MetroTile()
        Me.HeaderLabel = New MetroFramework.Controls.MetroLabel()
        Me.YearsRadioBtn = New MetroFramework.Controls.MetroRadioButton()
        Me.MonthsRaidoBtn = New MetroFramework.Controls.MetroRadioButton()
        CType(Me.ScheduleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderTile.SuspendLayout()
        Me.SuspendLayout()
        '
        'LnAmountLbl
        '
        Me.LnAmountLbl.AutoSize = True
        Me.LnAmountLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LnAmountLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LnAmountLbl.Location = New System.Drawing.Point(85, 110)
        Me.LnAmountLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LnAmountLbl.Name = "LnAmountLbl"
        Me.LnAmountLbl.Size = New System.Drawing.Size(124, 25)
        Me.LnAmountLbl.TabIndex = 0
        Me.LnAmountLbl.Text = "Loan Amount:"
        '
        'AnnualInterestRateLbl
        '
        Me.AnnualInterestRateLbl.AutoSize = True
        Me.AnnualInterestRateLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.AnnualInterestRateLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.AnnualInterestRateLbl.Location = New System.Drawing.Point(34, 157)
        Me.AnnualInterestRateLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AnnualInterestRateLbl.Name = "AnnualInterestRateLbl"
        Me.AnnualInterestRateLbl.Size = New System.Drawing.Size(175, 25)
        Me.AnnualInterestRateLbl.TabIndex = 1
        Me.AnnualInterestRateLbl.Text = "Annual Interest Rate:"
        '
        'LoanPeriodLbl
        '
        Me.LoanPeriodLbl.AutoSize = True
        Me.LoanPeriodLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LoanPeriodLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LoanPeriodLbl.Location = New System.Drawing.Point(28, 211)
        Me.LoanPeriodLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LoanPeriodLbl.Name = "LoanPeriodLbl"
        Me.LoanPeriodLbl.Size = New System.Drawing.Size(109, 25)
        Me.LoanPeriodLbl.TabIndex = 2
        Me.LoanPeriodLbl.Text = "Loan Period:"
        '
        'LnAmountTxtBox
        '
        '
        '
        '
        Me.LnAmountTxtBox.CustomButton.Image = Nothing
        Me.LnAmountTxtBox.CustomButton.Location = New System.Drawing.Point(105, 2)
        Me.LnAmountTxtBox.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LnAmountTxtBox.CustomButton.Name = ""
        Me.LnAmountTxtBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.LnAmountTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LnAmountTxtBox.CustomButton.TabIndex = 1
        Me.LnAmountTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LnAmountTxtBox.CustomButton.UseSelectable = True
        Me.LnAmountTxtBox.CustomButton.Visible = False
        Me.LnAmountTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LnAmountTxtBox.Lines = New String(-1) {}
        Me.LnAmountTxtBox.Location = New System.Drawing.Point(217, 105)
        Me.LnAmountTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LnAmountTxtBox.MaxLength = 32767
        Me.LnAmountTxtBox.Name = "LnAmountTxtBox"
        Me.LnAmountTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LnAmountTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LnAmountTxtBox.SelectedText = ""
        Me.LnAmountTxtBox.SelectionLength = 0
        Me.LnAmountTxtBox.SelectionStart = 0
        Me.LnAmountTxtBox.ShortcutsEnabled = True
        Me.LnAmountTxtBox.Size = New System.Drawing.Size(133, 30)
        Me.LnAmountTxtBox.TabIndex = 3
        Me.LnAmountTxtBox.UseSelectable = True
        Me.LnAmountTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LnAmountTxtBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AnnualInterestRateTxtBox
        '
        '
        '
        '
        Me.AnnualInterestRateTxtBox.CustomButton.Image = Nothing
        Me.AnnualInterestRateTxtBox.CustomButton.Location = New System.Drawing.Point(105, 2)
        Me.AnnualInterestRateTxtBox.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AnnualInterestRateTxtBox.CustomButton.Name = ""
        Me.AnnualInterestRateTxtBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.AnnualInterestRateTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AnnualInterestRateTxtBox.CustomButton.TabIndex = 1
        Me.AnnualInterestRateTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AnnualInterestRateTxtBox.CustomButton.UseSelectable = True
        Me.AnnualInterestRateTxtBox.CustomButton.Visible = False
        Me.AnnualInterestRateTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.AnnualInterestRateTxtBox.Lines = New String(-1) {}
        Me.AnnualInterestRateTxtBox.Location = New System.Drawing.Point(217, 157)
        Me.AnnualInterestRateTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AnnualInterestRateTxtBox.MaxLength = 32767
        Me.AnnualInterestRateTxtBox.Name = "AnnualInterestRateTxtBox"
        Me.AnnualInterestRateTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AnnualInterestRateTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AnnualInterestRateTxtBox.SelectedText = ""
        Me.AnnualInterestRateTxtBox.SelectionLength = 0
        Me.AnnualInterestRateTxtBox.SelectionStart = 0
        Me.AnnualInterestRateTxtBox.ShortcutsEnabled = True
        Me.AnnualInterestRateTxtBox.Size = New System.Drawing.Size(133, 30)
        Me.AnnualInterestRateTxtBox.TabIndex = 4
        Me.AnnualInterestRateTxtBox.UseSelectable = True
        Me.AnnualInterestRateTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AnnualInterestRateTxtBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LoanPeriodTxtBox
        '
        '
        '
        '
        Me.LoanPeriodTxtBox.CustomButton.Image = Nothing
        Me.LoanPeriodTxtBox.CustomButton.Location = New System.Drawing.Point(105, 2)
        Me.LoanPeriodTxtBox.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoanPeriodTxtBox.CustomButton.Name = ""
        Me.LoanPeriodTxtBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.LoanPeriodTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LoanPeriodTxtBox.CustomButton.TabIndex = 1
        Me.LoanPeriodTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LoanPeriodTxtBox.CustomButton.UseSelectable = True
        Me.LoanPeriodTxtBox.CustomButton.Visible = False
        Me.LoanPeriodTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LoanPeriodTxtBox.Lines = New String(-1) {}
        Me.LoanPeriodTxtBox.Location = New System.Drawing.Point(217, 210)
        Me.LoanPeriodTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LoanPeriodTxtBox.MaxLength = 32767
        Me.LoanPeriodTxtBox.Name = "LoanPeriodTxtBox"
        Me.LoanPeriodTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoanPeriodTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LoanPeriodTxtBox.SelectedText = ""
        Me.LoanPeriodTxtBox.SelectionLength = 0
        Me.LoanPeriodTxtBox.SelectionStart = 0
        Me.LoanPeriodTxtBox.ShortcutsEnabled = True
        Me.LoanPeriodTxtBox.Size = New System.Drawing.Size(133, 30)
        Me.LoanPeriodTxtBox.TabIndex = 5
        Me.LoanPeriodTxtBox.UseSelectable = True
        Me.LoanPeriodTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LoanPeriodTxtBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CalculateBtn
        '
        Me.CalculateBtn.BackColor = System.Drawing.Color.White
        Me.CalculateBtn.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.CalculateBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.CalculateBtn.Location = New System.Drawing.Point(217, 269)
        Me.CalculateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(125, 34)
        Me.CalculateBtn.Style = MetroFramework.MetroColorStyle.Blue
        Me.CalculateBtn.TabIndex = 6
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseCustomBackColor = True
        Me.CalculateBtn.UseSelectable = True
        Me.CalculateBtn.UseStyleColors = True
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.White
        Me.ClearBtn.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.ClearBtn.Location = New System.Drawing.Point(66, 269)
        Me.ClearBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(125, 34)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseCustomBackColor = True
        Me.ClearBtn.UseSelectable = True
        Me.ClearBtn.UseStyleColors = True
        '
        'ScheduleGrid
        '
        Me.ScheduleGrid.AllowUserToAddRows = False
        Me.ScheduleGrid.AllowUserToDeleteRows = False
        Me.ScheduleGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ScheduleGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ScheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.ScheduleGrid.BackgroundColor = System.Drawing.Color.White
        Me.ScheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ScheduleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ScheduleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScheduleGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ScheduleGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.ScheduleGrid.EnableHeadersVisualStyles = False
        Me.ScheduleGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ScheduleGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ScheduleGrid.Location = New System.Drawing.Point(373, 81)
        Me.ScheduleGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.ScheduleGrid.Name = "ScheduleGrid"
        Me.ScheduleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScheduleGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.ScheduleGrid.RowHeadersVisible = False
        Me.ScheduleGrid.RowHeadersWidth = 62
        Me.ScheduleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ScheduleGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ScheduleGrid.RowTemplate.Height = 28
        Me.ScheduleGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ScheduleGrid.Size = New System.Drawing.Size(911, 559)
        Me.ScheduleGrid.TabIndex = 8
        Me.ScheduleGrid.Visible = False
        '
        'MainPicture
        '
        Me.MainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MainPicture.Image = Global.Assignment2.My.Resources.Resources.Calc
        Me.MainPicture.Location = New System.Drawing.Point(400, 81)
        Me.MainPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPicture.Name = "MainPicture"
        Me.MainPicture.Size = New System.Drawing.Size(856, 588)
        Me.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainPicture.TabIndex = 9
        Me.MainPicture.TabStop = False
        '
        'LoanScheduleLbl
        '
        Me.LoanScheduleLbl.AutoSize = True
        Me.LoanScheduleLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LoanScheduleLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LoanScheduleLbl.Location = New System.Drawing.Point(373, 54)
        Me.LoanScheduleLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LoanScheduleLbl.Name = "LoanScheduleLbl"
        Me.LoanScheduleLbl.Size = New System.Drawing.Size(253, 25)
        Me.LoanScheduleLbl.TabIndex = 10
        Me.LoanScheduleLbl.Text = "Loan Amortization Schedule"
        Me.LoanScheduleLbl.Visible = False
        '
        'HeaderTile
        '
        Me.HeaderTile.ActiveControl = Nothing
        Me.HeaderTile.Controls.Add(Me.HeaderLabel)
        Me.HeaderTile.Location = New System.Drawing.Point(0, -1)
        Me.HeaderTile.Name = "HeaderTile"
        Me.HeaderTile.Size = New System.Drawing.Size(1307, 46)
        Me.HeaderTile.TabIndex = 11
        Me.HeaderTile.UseSelectable = True
        Me.HeaderTile.UseStyleColors = True
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.HeaderLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.HeaderLabel.Location = New System.Drawing.Point(10, 11)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(246, 25)
        Me.HeaderLabel.TabIndex = 1
        Me.HeaderLabel.Text = "Loan Repayment Calculator"
        Me.HeaderLabel.UseStyleColors = True
        '
        'YearsRadioBtn
        '
        Me.YearsRadioBtn.AutoSize = True
        Me.YearsRadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.YearsRadioBtn.Location = New System.Drawing.Point(142, 205)
        Me.YearsRadioBtn.Name = "YearsRadioBtn"
        Me.YearsRadioBtn.Size = New System.Drawing.Size(57, 19)
        Me.YearsRadioBtn.TabIndex = 12
        Me.YearsRadioBtn.Text = "Years"
        Me.YearsRadioBtn.UseSelectable = True
        '
        'MonthsRaidoBtn
        '
        Me.MonthsRaidoBtn.AutoSize = True
        Me.MonthsRaidoBtn.Checked = True
        Me.MonthsRaidoBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MonthsRaidoBtn.Location = New System.Drawing.Point(142, 226)
        Me.MonthsRaidoBtn.Name = "MonthsRaidoBtn"
        Me.MonthsRaidoBtn.Size = New System.Drawing.Size(73, 19)
        Me.MonthsRaidoBtn.TabIndex = 13
        Me.MonthsRaidoBtn.TabStop = True
        Me.MonthsRaidoBtn.Text = "Months"
        Me.MonthsRaidoBtn.UseSelectable = True
        '
        'LoanRepaymentCalculator
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1307, 696)
        Me.Controls.Add(Me.MonthsRaidoBtn)
        Me.Controls.Add(Me.YearsRadioBtn)
        Me.Controls.Add(Me.HeaderTile)
        Me.Controls.Add(Me.LoanScheduleLbl)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.LoanPeriodTxtBox)
        Me.Controls.Add(Me.AnnualInterestRateTxtBox)
        Me.Controls.Add(Me.LnAmountTxtBox)
        Me.Controls.Add(Me.LoanPeriodLbl)
        Me.Controls.Add(Me.AnnualInterestRateLbl)
        Me.Controls.Add(Me.LnAmountLbl)
        Me.Controls.Add(Me.MainPicture)
        Me.Controls.Add(Me.ScheduleGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.MaximizeBox = False
        Me.Name = "LoanRepaymentCalculator"
        Me.Padding = New System.Windows.Forms.Padding(26, 75, 26, 25)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Repayment Calculator"
        CType(Me.ScheduleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderTile.ResumeLayout(False)
        Me.HeaderTile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LnAmountLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents AnnualInterestRateLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoanPeriodLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents LnAmountTxtBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AnnualInterestRateTxtBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoanPeriodTxtBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CalculateBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents ClearBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents MainPicture As PictureBox
    Friend WithEvents LoanScheduleLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ScheduleGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents HeaderTile As MetroFramework.Controls.MetroTile
    Friend WithEvents HeaderLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents YearsRadioBtn As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MonthsRaidoBtn As MetroFramework.Controls.MetroRadioButton
End Class
