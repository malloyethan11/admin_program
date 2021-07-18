<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSalesReport = New System.Windows.Forms.Label()
        Me.lblSalesTaxReport = New System.Windows.Forms.Label()
        Me.lblInventoryReport = New System.Windows.Forms.Label()
        Me.lblCashDepositReport = New System.Windows.Forms.Label()
        Me.chkSalesReportDaily = New System.Windows.Forms.CheckBox()
        Me.chkSalesReportWeekly = New System.Windows.Forms.CheckBox()
        Me.chkSalesReportMonthly = New System.Windows.Forms.CheckBox()
        Me.chkSalesReportYearly = New System.Windows.Forms.CheckBox()
        Me.chkSTRDaily = New System.Windows.Forms.CheckBox()
        Me.chkSTRWeekly = New System.Windows.Forms.CheckBox()
        Me.chkSTRMonthly = New System.Windows.Forms.CheckBox()
        Me.chkSTRYearly = New System.Windows.Forms.CheckBox()
        Me.chkIRDaily = New System.Windows.Forms.CheckBox()
        Me.chkIRWeekly = New System.Windows.Forms.CheckBox()
        Me.chkIRMonthly = New System.Windows.Forms.CheckBox()
        Me.chkIRYearly = New System.Windows.Forms.CheckBox()
        Me.chkDRDaily = New System.Windows.Forms.CheckBox()
        Me.chkDRWeekly = New System.Windows.Forms.CheckBox()
        Me.chkDRMonthly = New System.Windows.Forms.CheckBox()
        Me.chkDRYearly = New System.Windows.Forms.CheckBox()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail4 = New System.Windows.Forms.TextBox()
        Me.StepAction = New System.Windows.Forms.Timer(Me.components)
        Me.dtmSalesReportTimeDaily = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportWeekly = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportTimeDaily = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryWeekly = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryTimeDaily = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositWeekly = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositTimeDaily = New System.Windows.Forms.DateTimePicker()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dtmSalesReportWeekly = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtmSalesReportWeeklyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportWeeklyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryWeeklyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositWeeklyTime = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtmSalesReportMonthly = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportMonthly = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryMonthly = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositMonthly = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesReportMonthlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportMonthlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryMonthlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositMonthlyTime = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtmSalesReportYearly = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportYearly = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryYearly = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositYearly = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesReportYearlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportYearlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryYearlyTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositYearlyTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.AdminFormsDesign.My.Resources.Resources.ButtonShort
        Me.btnExit.Location = New System.Drawing.Point(12, 122)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 42)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSalesReport
        '
        Me.lblSalesReport.Location = New System.Drawing.Point(12, 11)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesReport.TabIndex = 11
        Me.lblSalesReport.Text = "Sales Report"
        Me.lblSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTaxReport
        '
        Me.lblSalesTaxReport.Location = New System.Drawing.Point(12, 64)
        Me.lblSalesTaxReport.Name = "lblSalesTaxReport"
        Me.lblSalesTaxReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesTaxReport.TabIndex = 11
        Me.lblSalesTaxReport.Text = "Sales Tax Report"
        Me.lblSalesTaxReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInventoryReport
        '
        Me.lblInventoryReport.Location = New System.Drawing.Point(12, 38)
        Me.lblInventoryReport.Name = "lblInventoryReport"
        Me.lblInventoryReport.Size = New System.Drawing.Size(93, 18)
        Me.lblInventoryReport.TabIndex = 11
        Me.lblInventoryReport.Text = "Inventory Report"
        Me.lblInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashDepositReport
        '
        Me.lblCashDepositReport.Location = New System.Drawing.Point(15, 90)
        Me.lblCashDepositReport.Name = "lblCashDepositReport"
        Me.lblCashDepositReport.Size = New System.Drawing.Size(90, 18)
        Me.lblCashDepositReport.TabIndex = 11
        Me.lblCashDepositReport.Text = "Deposit Report"
        Me.lblCashDepositReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSalesReportDaily
        '
        Me.chkSalesReportDaily.AutoSize = True
        Me.chkSalesReportDaily.Location = New System.Drawing.Point(111, 12)
        Me.chkSalesReportDaily.Name = "chkSalesReportDaily"
        Me.chkSalesReportDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSalesReportDaily.TabIndex = 12
        Me.chkSalesReportDaily.Text = "Daily"
        Me.chkSalesReportDaily.UseVisualStyleBackColor = True
        '
        'chkSalesReportWeekly
        '
        Me.chkSalesReportWeekly.AutoSize = True
        Me.chkSalesReportWeekly.Location = New System.Drawing.Point(165, 12)
        Me.chkSalesReportWeekly.Name = "chkSalesReportWeekly"
        Me.chkSalesReportWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSalesReportWeekly.TabIndex = 12
        Me.chkSalesReportWeekly.Text = "Weekly"
        Me.chkSalesReportWeekly.UseVisualStyleBackColor = True
        '
        'chkSalesReportMonthly
        '
        Me.chkSalesReportMonthly.AutoSize = True
        Me.chkSalesReportMonthly.Location = New System.Drawing.Point(233, 12)
        Me.chkSalesReportMonthly.Name = "chkSalesReportMonthly"
        Me.chkSalesReportMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSalesReportMonthly.TabIndex = 12
        Me.chkSalesReportMonthly.Text = "Monthly"
        Me.chkSalesReportMonthly.UseVisualStyleBackColor = True
        '
        'chkSalesReportYearly
        '
        Me.chkSalesReportYearly.AutoSize = True
        Me.chkSalesReportYearly.Location = New System.Drawing.Point(302, 12)
        Me.chkSalesReportYearly.Name = "chkSalesReportYearly"
        Me.chkSalesReportYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSalesReportYearly.TabIndex = 12
        Me.chkSalesReportYearly.Text = "Yearly"
        Me.chkSalesReportYearly.UseVisualStyleBackColor = True
        '
        'chkSTRDaily
        '
        Me.chkSTRDaily.AutoSize = True
        Me.chkSTRDaily.Location = New System.Drawing.Point(111, 66)
        Me.chkSTRDaily.Name = "chkSTRDaily"
        Me.chkSTRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSTRDaily.TabIndex = 12
        Me.chkSTRDaily.Text = "Daily"
        Me.chkSTRDaily.UseVisualStyleBackColor = True
        '
        'chkSTRWeekly
        '
        Me.chkSTRWeekly.AutoSize = True
        Me.chkSTRWeekly.Location = New System.Drawing.Point(165, 66)
        Me.chkSTRWeekly.Name = "chkSTRWeekly"
        Me.chkSTRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSTRWeekly.TabIndex = 12
        Me.chkSTRWeekly.Text = "Weekly"
        Me.chkSTRWeekly.UseVisualStyleBackColor = True
        '
        'chkSTRMonthly
        '
        Me.chkSTRMonthly.AutoSize = True
        Me.chkSTRMonthly.Location = New System.Drawing.Point(233, 66)
        Me.chkSTRMonthly.Name = "chkSTRMonthly"
        Me.chkSTRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSTRMonthly.TabIndex = 12
        Me.chkSTRMonthly.Text = "Monthly"
        Me.chkSTRMonthly.UseVisualStyleBackColor = True
        '
        'chkSTRYearly
        '
        Me.chkSTRYearly.AutoSize = True
        Me.chkSTRYearly.Location = New System.Drawing.Point(302, 66)
        Me.chkSTRYearly.Name = "chkSTRYearly"
        Me.chkSTRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSTRYearly.TabIndex = 12
        Me.chkSTRYearly.Text = "Yearly"
        Me.chkSTRYearly.UseVisualStyleBackColor = True
        '
        'chkIRDaily
        '
        Me.chkIRDaily.AutoSize = True
        Me.chkIRDaily.Location = New System.Drawing.Point(111, 39)
        Me.chkIRDaily.Name = "chkIRDaily"
        Me.chkIRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkIRDaily.TabIndex = 12
        Me.chkIRDaily.Text = "Daily"
        Me.chkIRDaily.UseVisualStyleBackColor = True
        '
        'chkIRWeekly
        '
        Me.chkIRWeekly.AutoSize = True
        Me.chkIRWeekly.Location = New System.Drawing.Point(165, 39)
        Me.chkIRWeekly.Name = "chkIRWeekly"
        Me.chkIRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkIRWeekly.TabIndex = 12
        Me.chkIRWeekly.Text = "Weekly"
        Me.chkIRWeekly.UseVisualStyleBackColor = True
        '
        'chkIRMonthly
        '
        Me.chkIRMonthly.AutoSize = True
        Me.chkIRMonthly.Location = New System.Drawing.Point(233, 39)
        Me.chkIRMonthly.Name = "chkIRMonthly"
        Me.chkIRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkIRMonthly.TabIndex = 12
        Me.chkIRMonthly.Text = "Monthly"
        Me.chkIRMonthly.UseVisualStyleBackColor = True
        '
        'chkIRYearly
        '
        Me.chkIRYearly.AutoSize = True
        Me.chkIRYearly.Location = New System.Drawing.Point(302, 39)
        Me.chkIRYearly.Name = "chkIRYearly"
        Me.chkIRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkIRYearly.TabIndex = 12
        Me.chkIRYearly.Text = "Yearly"
        Me.chkIRYearly.UseVisualStyleBackColor = True
        '
        'chkDRDaily
        '
        Me.chkDRDaily.AutoSize = True
        Me.chkDRDaily.Location = New System.Drawing.Point(111, 93)
        Me.chkDRDaily.Name = "chkDRDaily"
        Me.chkDRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkDRDaily.TabIndex = 12
        Me.chkDRDaily.Text = "Daily"
        Me.chkDRDaily.UseVisualStyleBackColor = True
        '
        'chkDRWeekly
        '
        Me.chkDRWeekly.AutoSize = True
        Me.chkDRWeekly.Location = New System.Drawing.Point(165, 93)
        Me.chkDRWeekly.Name = "chkDRWeekly"
        Me.chkDRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkDRWeekly.TabIndex = 12
        Me.chkDRWeekly.Text = "Weekly"
        Me.chkDRWeekly.UseVisualStyleBackColor = True
        '
        'chkDRMonthly
        '
        Me.chkDRMonthly.AutoSize = True
        Me.chkDRMonthly.Location = New System.Drawing.Point(233, 93)
        Me.chkDRMonthly.Name = "chkDRMonthly"
        Me.chkDRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkDRMonthly.TabIndex = 12
        Me.chkDRMonthly.Text = "Monthly"
        Me.chkDRMonthly.UseVisualStyleBackColor = True
        '
        'chkDRYearly
        '
        Me.chkDRYearly.AutoSize = True
        Me.chkDRYearly.Location = New System.Drawing.Point(302, 93)
        Me.chkDRYearly.Name = "chkDRYearly"
        Me.chkDRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkDRYearly.TabIndex = 12
        Me.chkDRYearly.Text = "Yearly"
        Me.chkDRYearly.UseVisualStyleBackColor = True
        '
        'txtEmail1
        '
        Me.txtEmail1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail1.Location = New System.Drawing.Point(1438, 9)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(341, 20)
        Me.txtEmail1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1386, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Email ID"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.AdminFormsDesign.My.Resources.Resources.ButtonShort
        Me.btnSubmit.Location = New System.Drawing.Point(1665, 122)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 42)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Update"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(12, 14)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1386, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Email ID"
        '
        'txtEmail2
        '
        Me.txtEmail2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.Location = New System.Drawing.Point(1438, 36)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(341, 20)
        Me.txtEmail2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1386, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email ID"
        '
        'txtEmail3
        '
        Me.txtEmail3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail3.Location = New System.Drawing.Point(1438, 63)
        Me.txtEmail3.Name = "txtEmail3"
        Me.txtEmail3.Size = New System.Drawing.Size(341, 20)
        Me.txtEmail3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1386, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email ID"
        '
        'txtEmail4
        '
        Me.txtEmail4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail4.Location = New System.Drawing.Point(1438, 90)
        Me.txtEmail4.Name = "txtEmail4"
        Me.txtEmail4.Size = New System.Drawing.Size(341, 20)
        Me.txtEmail4.TabIndex = 21
        '
        'StepAction
        '
        Me.StepAction.Enabled = True
        Me.StepAction.Interval = 1
        '
        'dtmSalesReportTimeDaily
        '
        Me.dtmSalesReportTimeDaily.Location = New System.Drawing.Point(442, 10)
        Me.dtmSalesReportTimeDaily.Name = "dtmSalesReportTimeDaily"
        Me.dtmSalesReportTimeDaily.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportTimeDaily.TabIndex = 23
        '
        'dtmSalesTaxReportWeekly
        '
        Me.dtmSalesTaxReportWeekly.Location = New System.Drawing.Point(620, 63)
        Me.dtmSalesTaxReportWeekly.Name = "dtmSalesTaxReportWeekly"
        Me.dtmSalesTaxReportWeekly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportWeekly.TabIndex = 23
        '
        'dtmSalesTaxReportTimeDaily
        '
        Me.dtmSalesTaxReportTimeDaily.Location = New System.Drawing.Point(442, 63)
        Me.dtmSalesTaxReportTimeDaily.Name = "dtmSalesTaxReportTimeDaily"
        Me.dtmSalesTaxReportTimeDaily.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportTimeDaily.TabIndex = 23
        '
        'dtmInventoryWeekly
        '
        Me.dtmInventoryWeekly.Location = New System.Drawing.Point(620, 36)
        Me.dtmInventoryWeekly.Name = "dtmInventoryWeekly"
        Me.dtmInventoryWeekly.Size = New System.Drawing.Size(90, 20)
        Me.dtmInventoryWeekly.TabIndex = 23
        '
        'dtmInventoryTimeDaily
        '
        Me.dtmInventoryTimeDaily.Location = New System.Drawing.Point(442, 36)
        Me.dtmInventoryTimeDaily.Name = "dtmInventoryTimeDaily"
        Me.dtmInventoryTimeDaily.Size = New System.Drawing.Size(89, 20)
        Me.dtmInventoryTimeDaily.TabIndex = 23
        '
        'dtmDepositWeekly
        '
        Me.dtmDepositWeekly.Location = New System.Drawing.Point(620, 91)
        Me.dtmDepositWeekly.Name = "dtmDepositWeekly"
        Me.dtmDepositWeekly.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositWeekly.TabIndex = 23
        '
        'dtmDepositTimeDaily
        '
        Me.dtmDepositTimeDaily.Location = New System.Drawing.Point(442, 91)
        Me.dtmDepositTimeDaily.Name = "dtmDepositTimeDaily"
        Me.dtmDepositTimeDaily.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositTimeDaily.TabIndex = 23
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(366, 11)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(70, 18)
        Me.label5.TabIndex = 11
        Me.label5.Text = "Daily Time"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmSalesReportWeekly
        '
        Me.dtmSalesReportWeekly.Location = New System.Drawing.Point(620, 10)
        Me.dtmSalesReportWeekly.Name = "dtmSalesReportWeekly"
        Me.dtmSalesReportWeekly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportWeekly.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(366, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Daily Time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(366, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Daily Time"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(366, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Daily Time"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(538, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Weekly Time"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmSalesReportWeeklyTime
        '
        Me.dtmSalesReportWeeklyTime.Location = New System.Drawing.Point(716, 10)
        Me.dtmSalesReportWeeklyTime.Name = "dtmSalesReportWeeklyTime"
        Me.dtmSalesReportWeeklyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportWeeklyTime.TabIndex = 23
        '
        'dtmSalesTaxReportWeeklyTime
        '
        Me.dtmSalesTaxReportWeeklyTime.Location = New System.Drawing.Point(716, 63)
        Me.dtmSalesTaxReportWeeklyTime.Name = "dtmSalesTaxReportWeeklyTime"
        Me.dtmSalesTaxReportWeeklyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportWeeklyTime.TabIndex = 23
        '
        'dtmInventoryWeeklyTime
        '
        Me.dtmInventoryWeeklyTime.Location = New System.Drawing.Point(716, 36)
        Me.dtmInventoryWeeklyTime.Name = "dtmInventoryWeeklyTime"
        Me.dtmInventoryWeeklyTime.Size = New System.Drawing.Size(89, 20)
        Me.dtmInventoryWeeklyTime.TabIndex = 23
        '
        'dtmDepositWeeklyTime
        '
        Me.dtmDepositWeeklyTime.Location = New System.Drawing.Point(716, 91)
        Me.dtmDepositWeeklyTime.Name = "dtmDepositWeeklyTime"
        Me.dtmDepositWeeklyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositWeeklyTime.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(538, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Weekly Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(538, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Weekly Time"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(538, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Weekly Time"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(812, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 18)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Monthly Time"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(812, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 18)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Monthly Time"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(812, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 18)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Monthly Time"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(812, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 18)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Monthly Time"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmSalesReportMonthly
        '
        Me.dtmSalesReportMonthly.Location = New System.Drawing.Point(894, 10)
        Me.dtmSalesReportMonthly.Name = "dtmSalesReportMonthly"
        Me.dtmSalesReportMonthly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportMonthly.TabIndex = 23
        '
        'dtmSalesTaxReportMonthly
        '
        Me.dtmSalesTaxReportMonthly.Location = New System.Drawing.Point(894, 63)
        Me.dtmSalesTaxReportMonthly.Name = "dtmSalesTaxReportMonthly"
        Me.dtmSalesTaxReportMonthly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportMonthly.TabIndex = 23
        '
        'dtmInventoryMonthly
        '
        Me.dtmInventoryMonthly.Location = New System.Drawing.Point(894, 36)
        Me.dtmInventoryMonthly.Name = "dtmInventoryMonthly"
        Me.dtmInventoryMonthly.Size = New System.Drawing.Size(89, 20)
        Me.dtmInventoryMonthly.TabIndex = 23
        '
        'dtmDepositMonthly
        '
        Me.dtmDepositMonthly.Location = New System.Drawing.Point(894, 91)
        Me.dtmDepositMonthly.Name = "dtmDepositMonthly"
        Me.dtmDepositMonthly.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositMonthly.TabIndex = 23
        '
        'dtmSalesReportMonthlyTime
        '
        Me.dtmSalesReportMonthlyTime.Location = New System.Drawing.Point(990, 10)
        Me.dtmSalesReportMonthlyTime.Name = "dtmSalesReportMonthlyTime"
        Me.dtmSalesReportMonthlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportMonthlyTime.TabIndex = 23
        '
        'dtmSalesTaxReportMonthlyTime
        '
        Me.dtmSalesTaxReportMonthlyTime.Location = New System.Drawing.Point(990, 63)
        Me.dtmSalesTaxReportMonthlyTime.Name = "dtmSalesTaxReportMonthlyTime"
        Me.dtmSalesTaxReportMonthlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportMonthlyTime.TabIndex = 23
        '
        'dtmInventoryMonthlyTime
        '
        Me.dtmInventoryMonthlyTime.Location = New System.Drawing.Point(990, 36)
        Me.dtmInventoryMonthlyTime.Name = "dtmInventoryMonthlyTime"
        Me.dtmInventoryMonthlyTime.Size = New System.Drawing.Size(89, 20)
        Me.dtmInventoryMonthlyTime.TabIndex = 23
        '
        'dtmDepositMonthlyTime
        '
        Me.dtmDepositMonthlyTime.Location = New System.Drawing.Point(990, 91)
        Me.dtmDepositMonthlyTime.Name = "dtmDepositMonthlyTime"
        Me.dtmDepositMonthlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositMonthlyTime.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(1086, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 18)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Yearly Time"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(1086, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 18)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Yearly Time"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(1086, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 18)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Yearly Time"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(1086, 92)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 18)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Yearly Time"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmSalesReportYearly
        '
        Me.dtmSalesReportYearly.Location = New System.Drawing.Point(1168, 10)
        Me.dtmSalesReportYearly.Name = "dtmSalesReportYearly"
        Me.dtmSalesReportYearly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportYearly.TabIndex = 23
        '
        'dtmSalesTaxReportYearly
        '
        Me.dtmSalesTaxReportYearly.Location = New System.Drawing.Point(1168, 63)
        Me.dtmSalesTaxReportYearly.Name = "dtmSalesTaxReportYearly"
        Me.dtmSalesTaxReportYearly.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportYearly.TabIndex = 23
        '
        'dtmInventoryYearly
        '
        Me.dtmInventoryYearly.Location = New System.Drawing.Point(1168, 36)
        Me.dtmInventoryYearly.Name = "dtmInventoryYearly"
        Me.dtmInventoryYearly.Size = New System.Drawing.Size(90, 20)
        Me.dtmInventoryYearly.TabIndex = 23
        '
        'dtmDepositYearly
        '
        Me.dtmDepositYearly.Location = New System.Drawing.Point(1168, 91)
        Me.dtmDepositYearly.Name = "dtmDepositYearly"
        Me.dtmDepositYearly.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositYearly.TabIndex = 23
        '
        'dtmSalesReportYearlyTime
        '
        Me.dtmSalesReportYearlyTime.Location = New System.Drawing.Point(1264, 10)
        Me.dtmSalesReportYearlyTime.Name = "dtmSalesReportYearlyTime"
        Me.dtmSalesReportYearlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesReportYearlyTime.TabIndex = 23
        '
        'dtmSalesTaxReportYearlyTime
        '
        Me.dtmSalesTaxReportYearlyTime.Location = New System.Drawing.Point(1264, 63)
        Me.dtmSalesTaxReportYearlyTime.Name = "dtmSalesTaxReportYearlyTime"
        Me.dtmSalesTaxReportYearlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmSalesTaxReportYearlyTime.TabIndex = 23
        '
        'dtmInventoryYearlyTime
        '
        Me.dtmInventoryYearlyTime.Location = New System.Drawing.Point(1264, 36)
        Me.dtmInventoryYearlyTime.Name = "dtmInventoryYearlyTime"
        Me.dtmInventoryYearlyTime.Size = New System.Drawing.Size(89, 20)
        Me.dtmInventoryYearlyTime.TabIndex = 23
        '
        'dtmDepositYearlyTime
        '
        Me.dtmDepositYearlyTime.Location = New System.Drawing.Point(1264, 91)
        Me.dtmDepositYearlyTime.Name = "dtmDepositYearlyTime"
        Me.dtmDepositYearlyTime.Size = New System.Drawing.Size(90, 20)
        Me.dtmDepositYearlyTime.TabIndex = 23
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1791, 176)
        Me.Controls.Add(Me.dtmDepositYearlyTime)
        Me.Controls.Add(Me.dtmDepositMonthlyTime)
        Me.Controls.Add(Me.dtmDepositWeeklyTime)
        Me.Controls.Add(Me.dtmDepositTimeDaily)
        Me.Controls.Add(Me.dtmInventoryYearlyTime)
        Me.Controls.Add(Me.dtmInventoryMonthlyTime)
        Me.Controls.Add(Me.dtmInventoryWeeklyTime)
        Me.Controls.Add(Me.dtmInventoryTimeDaily)
        Me.Controls.Add(Me.dtmSalesTaxReportYearlyTime)
        Me.Controls.Add(Me.dtmSalesTaxReportMonthlyTime)
        Me.Controls.Add(Me.dtmSalesTaxReportWeeklyTime)
        Me.Controls.Add(Me.dtmSalesTaxReportTimeDaily)
        Me.Controls.Add(Me.dtmSalesReportYearlyTime)
        Me.Controls.Add(Me.dtmSalesReportMonthlyTime)
        Me.Controls.Add(Me.dtmSalesReportWeeklyTime)
        Me.Controls.Add(Me.dtmSalesReportTimeDaily)
        Me.Controls.Add(Me.dtmDepositYearly)
        Me.Controls.Add(Me.dtmDepositMonthly)
        Me.Controls.Add(Me.dtmDepositWeekly)
        Me.Controls.Add(Me.dtmInventoryYearly)
        Me.Controls.Add(Me.dtmInventoryMonthly)
        Me.Controls.Add(Me.dtmInventoryWeekly)
        Me.Controls.Add(Me.dtmSalesTaxReportYearly)
        Me.Controls.Add(Me.dtmSalesTaxReportMonthly)
        Me.Controls.Add(Me.dtmSalesTaxReportWeekly)
        Me.Controls.Add(Me.dtmSalesReportYearly)
        Me.Controls.Add(Me.dtmSalesReportMonthly)
        Me.Controls.Add(Me.dtmSalesReportWeekly)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail2)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail1)
        Me.Controls.Add(Me.chkDRYearly)
        Me.Controls.Add(Me.chkIRYearly)
        Me.Controls.Add(Me.chkSTRYearly)
        Me.Controls.Add(Me.chkSalesReportYearly)
        Me.Controls.Add(Me.chkDRMonthly)
        Me.Controls.Add(Me.chkIRMonthly)
        Me.Controls.Add(Me.chkSTRMonthly)
        Me.Controls.Add(Me.chkSalesReportMonthly)
        Me.Controls.Add(Me.chkDRWeekly)
        Me.Controls.Add(Me.chkIRWeekly)
        Me.Controls.Add(Me.chkSTRWeekly)
        Me.Controls.Add(Me.chkSalesReportWeekly)
        Me.Controls.Add(Me.chkDRDaily)
        Me.Controls.Add(Me.chkIRDaily)
        Me.Controls.Add(Me.chkSTRDaily)
        Me.Controls.Add(Me.chkSalesReportDaily)
        Me.Controls.Add(Me.lblCashDepositReport)
        Me.Controls.Add(Me.lblInventoryReport)
        Me.Controls.Add(Me.lblSalesTaxReport)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.lblSalesReport)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReports"
        Me.Text = "Administration Program - Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSalesReport As Label
    Friend WithEvents lblSalesTaxReport As Label
    Friend WithEvents lblInventoryReport As Label
    Friend WithEvents lblCashDepositReport As Label
    Friend WithEvents chkSalesReportDaily As CheckBox
    Friend WithEvents chkSalesReportWeekly As CheckBox
    Friend WithEvents chkSalesReportMonthly As CheckBox
    Friend WithEvents chkSalesReportYearly As CheckBox
    Friend WithEvents chkSTRDaily As CheckBox
    Friend WithEvents chkSTRWeekly As CheckBox
    Friend WithEvents chkSTRMonthly As CheckBox
    Friend WithEvents chkSTRYearly As CheckBox
    Friend WithEvents chkIRDaily As CheckBox
    Friend WithEvents chkIRWeekly As CheckBox
    Friend WithEvents chkIRMonthly As CheckBox
    Friend WithEvents chkIRYearly As CheckBox
    Friend WithEvents chkDRDaily As CheckBox
    Friend WithEvents chkDRWeekly As CheckBox
    Friend WithEvents chkDRMonthly As CheckBox
    Friend WithEvents chkDRYearly As CheckBox
    Friend WithEvents txtEmail1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail4 As TextBox
    Friend WithEvents StepAction As Timer
    Friend WithEvents dtmSalesReportTimeDaily As DateTimePicker
    Friend WithEvents dtmSalesTaxReportWeekly As DateTimePicker
    Friend WithEvents dtmSalesTaxReportTimeDaily As DateTimePicker
    Friend WithEvents dtmInventoryWeekly As DateTimePicker
    Friend WithEvents dtmInventoryTimeDaily As DateTimePicker
    Friend WithEvents dtmDepositWeekly As DateTimePicker
    Friend WithEvents dtmDepositTimeDaily As DateTimePicker
    Friend WithEvents label5 As Label
    Friend WithEvents dtmSalesReportWeekly As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtmSalesReportWeeklyTime As DateTimePicker
    Friend WithEvents dtmSalesTaxReportWeeklyTime As DateTimePicker
    Friend WithEvents dtmInventoryWeeklyTime As DateTimePicker
    Friend WithEvents dtmDepositWeeklyTime As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dtmSalesReportMonthly As DateTimePicker
    Friend WithEvents dtmSalesTaxReportMonthly As DateTimePicker
    Friend WithEvents dtmInventoryMonthly As DateTimePicker
    Friend WithEvents dtmDepositMonthly As DateTimePicker
    Friend WithEvents dtmSalesReportMonthlyTime As DateTimePicker
    Friend WithEvents dtmSalesTaxReportMonthlyTime As DateTimePicker
    Friend WithEvents dtmInventoryMonthlyTime As DateTimePicker
    Friend WithEvents dtmDepositMonthlyTime As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dtmSalesReportYearly As DateTimePicker
    Friend WithEvents dtmSalesTaxReportYearly As DateTimePicker
    Friend WithEvents dtmInventoryYearly As DateTimePicker
    Friend WithEvents dtmDepositYearly As DateTimePicker
    Friend WithEvents dtmSalesReportYearlyTime As DateTimePicker
    Friend WithEvents dtmSalesTaxReportYearlyTime As DateTimePicker
    Friend WithEvents dtmInventoryYearlyTime As DateTimePicker
    Friend WithEvents dtmDepositYearlyTime As DateTimePicker
End Class
