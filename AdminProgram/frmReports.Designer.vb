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
        Me.dtmSalesReport = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesReportTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReport = New System.Windows.Forms.DateTimePicker()
        Me.dtmSalesTaxReportTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventory = New System.Windows.Forms.DateTimePicker()
        Me.dtmInventoryTime = New System.Windows.Forms.DateTimePicker()
        Me.dtmDeposit = New System.Windows.Forms.DateTimePicker()
        Me.dtmDepositTime = New System.Windows.Forms.DateTimePicker()
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
        Me.lblSalesReport.Location = New System.Drawing.Point(12, 9)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesReport.TabIndex = 11
        Me.lblSalesReport.Text = "Sales Report"
        Me.lblSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTaxReport
        '
        Me.lblSalesTaxReport.Location = New System.Drawing.Point(12, 36)
        Me.lblSalesTaxReport.Name = "lblSalesTaxReport"
        Me.lblSalesTaxReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesTaxReport.TabIndex = 11
        Me.lblSalesTaxReport.Text = "Sales Tax Report"
        Me.lblSalesTaxReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInventoryReport
        '
        Me.lblInventoryReport.Location = New System.Drawing.Point(12, 63)
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
        Me.chkSalesReportDaily.Location = New System.Drawing.Point(111, 11)
        Me.chkSalesReportDaily.Name = "chkSalesReportDaily"
        Me.chkSalesReportDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSalesReportDaily.TabIndex = 12
        Me.chkSalesReportDaily.Text = "Daily"
        Me.chkSalesReportDaily.UseVisualStyleBackColor = True
        '
        'chkSalesReportWeekly
        '
        Me.chkSalesReportWeekly.AutoSize = True
        Me.chkSalesReportWeekly.Location = New System.Drawing.Point(165, 11)
        Me.chkSalesReportWeekly.Name = "chkSalesReportWeekly"
        Me.chkSalesReportWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSalesReportWeekly.TabIndex = 12
        Me.chkSalesReportWeekly.Text = "Weekly"
        Me.chkSalesReportWeekly.UseVisualStyleBackColor = True
        '
        'chkSalesReportMonthly
        '
        Me.chkSalesReportMonthly.AutoSize = True
        Me.chkSalesReportMonthly.Location = New System.Drawing.Point(233, 11)
        Me.chkSalesReportMonthly.Name = "chkSalesReportMonthly"
        Me.chkSalesReportMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSalesReportMonthly.TabIndex = 12
        Me.chkSalesReportMonthly.Text = "Monthly"
        Me.chkSalesReportMonthly.UseVisualStyleBackColor = True
        '
        'chkSalesReportYearly
        '
        Me.chkSalesReportYearly.AutoSize = True
        Me.chkSalesReportYearly.Location = New System.Drawing.Point(302, 11)
        Me.chkSalesReportYearly.Name = "chkSalesReportYearly"
        Me.chkSalesReportYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSalesReportYearly.TabIndex = 12
        Me.chkSalesReportYearly.Text = "Yearly"
        Me.chkSalesReportYearly.UseVisualStyleBackColor = True
        '
        'chkSTRDaily
        '
        Me.chkSTRDaily.AutoSize = True
        Me.chkSTRDaily.Location = New System.Drawing.Point(111, 38)
        Me.chkSTRDaily.Name = "chkSTRDaily"
        Me.chkSTRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSTRDaily.TabIndex = 12
        Me.chkSTRDaily.Text = "Daily"
        Me.chkSTRDaily.UseVisualStyleBackColor = True
        '
        'chkSTRWeekly
        '
        Me.chkSTRWeekly.AutoSize = True
        Me.chkSTRWeekly.Location = New System.Drawing.Point(165, 38)
        Me.chkSTRWeekly.Name = "chkSTRWeekly"
        Me.chkSTRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSTRWeekly.TabIndex = 12
        Me.chkSTRWeekly.Text = "Weekly"
        Me.chkSTRWeekly.UseVisualStyleBackColor = True
        '
        'chkSTRMonthly
        '
        Me.chkSTRMonthly.AutoSize = True
        Me.chkSTRMonthly.Location = New System.Drawing.Point(233, 38)
        Me.chkSTRMonthly.Name = "chkSTRMonthly"
        Me.chkSTRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSTRMonthly.TabIndex = 12
        Me.chkSTRMonthly.Text = "Monthly"
        Me.chkSTRMonthly.UseVisualStyleBackColor = True
        '
        'chkSTRYearly
        '
        Me.chkSTRYearly.AutoSize = True
        Me.chkSTRYearly.Location = New System.Drawing.Point(302, 38)
        Me.chkSTRYearly.Name = "chkSTRYearly"
        Me.chkSTRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSTRYearly.TabIndex = 12
        Me.chkSTRYearly.Text = "Yearly"
        Me.chkSTRYearly.UseVisualStyleBackColor = True
        '
        'chkIRDaily
        '
        Me.chkIRDaily.AutoSize = True
        Me.chkIRDaily.Location = New System.Drawing.Point(111, 65)
        Me.chkIRDaily.Name = "chkIRDaily"
        Me.chkIRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkIRDaily.TabIndex = 12
        Me.chkIRDaily.Text = "Daily"
        Me.chkIRDaily.UseVisualStyleBackColor = True
        '
        'chkIRWeekly
        '
        Me.chkIRWeekly.AutoSize = True
        Me.chkIRWeekly.Location = New System.Drawing.Point(165, 65)
        Me.chkIRWeekly.Name = "chkIRWeekly"
        Me.chkIRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkIRWeekly.TabIndex = 12
        Me.chkIRWeekly.Text = "Weekly"
        Me.chkIRWeekly.UseVisualStyleBackColor = True
        '
        'chkIRMonthly
        '
        Me.chkIRMonthly.AutoSize = True
        Me.chkIRMonthly.Location = New System.Drawing.Point(233, 65)
        Me.chkIRMonthly.Name = "chkIRMonthly"
        Me.chkIRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkIRMonthly.TabIndex = 12
        Me.chkIRMonthly.Text = "Monthly"
        Me.chkIRMonthly.UseVisualStyleBackColor = True
        '
        'chkIRYearly
        '
        Me.chkIRYearly.AutoSize = True
        Me.chkIRYearly.Location = New System.Drawing.Point(302, 65)
        Me.chkIRYearly.Name = "chkIRYearly"
        Me.chkIRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkIRYearly.TabIndex = 12
        Me.chkIRYearly.Text = "Yearly"
        Me.chkIRYearly.UseVisualStyleBackColor = True
        '
        'chkDRDaily
        '
        Me.chkDRDaily.AutoSize = True
        Me.chkDRDaily.Location = New System.Drawing.Point(111, 92)
        Me.chkDRDaily.Name = "chkDRDaily"
        Me.chkDRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkDRDaily.TabIndex = 12
        Me.chkDRDaily.Text = "Daily"
        Me.chkDRDaily.UseVisualStyleBackColor = True
        '
        'chkDRWeekly
        '
        Me.chkDRWeekly.AutoSize = True
        Me.chkDRWeekly.Location = New System.Drawing.Point(165, 92)
        Me.chkDRWeekly.Name = "chkDRWeekly"
        Me.chkDRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkDRWeekly.TabIndex = 12
        Me.chkDRWeekly.Text = "Weekly"
        Me.chkDRWeekly.UseVisualStyleBackColor = True
        '
        'chkDRMonthly
        '
        Me.chkDRMonthly.AutoSize = True
        Me.chkDRMonthly.Location = New System.Drawing.Point(233, 92)
        Me.chkDRMonthly.Name = "chkDRMonthly"
        Me.chkDRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkDRMonthly.TabIndex = 12
        Me.chkDRMonthly.Text = "Monthly"
        Me.chkDRMonthly.UseVisualStyleBackColor = True
        '
        'chkDRYearly
        '
        Me.chkDRYearly.AutoSize = True
        Me.chkDRYearly.Location = New System.Drawing.Point(302, 92)
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
        Me.txtEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail1.Location = New System.Drawing.Point(697, 7)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(153, 23)
        Me.txtEmail1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(645, 12)
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
        Me.btnSubmit.Location = New System.Drawing.Point(736, 122)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 42)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Update"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(12, 9)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(645, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Email ID"
        '
        'txtEmail2
        '
        Me.txtEmail2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.Location = New System.Drawing.Point(697, 34)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(153, 23)
        Me.txtEmail2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(645, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email ID"
        '
        'txtEmail3
        '
        Me.txtEmail3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail3.Location = New System.Drawing.Point(697, 61)
        Me.txtEmail3.Name = "txtEmail3"
        Me.txtEmail3.Size = New System.Drawing.Size(153, 23)
        Me.txtEmail3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(645, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email ID"
        '
        'txtEmail4
        '
        Me.txtEmail4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail4.Location = New System.Drawing.Point(697, 88)
        Me.txtEmail4.Name = "txtEmail4"
        Me.txtEmail4.Size = New System.Drawing.Size(153, 23)
        Me.txtEmail4.TabIndex = 21
        '
        'StepAction
        '
        Me.StepAction.Enabled = True
        Me.StepAction.Interval = 1
        '
        'dtmSalesReport
        '
        Me.dtmSalesReport.Location = New System.Drawing.Point(364, 9)
        Me.dtmSalesReport.Name = "dtmSalesReport"
        Me.dtmSalesReport.Size = New System.Drawing.Size(129, 20)
        Me.dtmSalesReport.TabIndex = 23
        '
        'dtmSalesReportTime
        '
        Me.dtmSalesReportTime.Location = New System.Drawing.Point(499, 9)
        Me.dtmSalesReportTime.Name = "dtmSalesReportTime"
        Me.dtmSalesReportTime.Size = New System.Drawing.Size(140, 20)
        Me.dtmSalesReportTime.TabIndex = 23
        '
        'dtmSalesTaxReport
        '
        Me.dtmSalesTaxReport.Location = New System.Drawing.Point(364, 36)
        Me.dtmSalesTaxReport.Name = "dtmSalesTaxReport"
        Me.dtmSalesTaxReport.Size = New System.Drawing.Size(129, 20)
        Me.dtmSalesTaxReport.TabIndex = 23
        '
        'dtmSalesTaxReportTime
        '
        Me.dtmSalesTaxReportTime.Location = New System.Drawing.Point(499, 36)
        Me.dtmSalesTaxReportTime.Name = "dtmSalesTaxReportTime"
        Me.dtmSalesTaxReportTime.Size = New System.Drawing.Size(140, 20)
        Me.dtmSalesTaxReportTime.TabIndex = 23
        '
        'dtmInventory
        '
        Me.dtmInventory.Location = New System.Drawing.Point(363, 63)
        Me.dtmInventory.Name = "dtmInventory"
        Me.dtmInventory.Size = New System.Drawing.Size(129, 20)
        Me.dtmInventory.TabIndex = 23
        '
        'dtmInventoryTime
        '
        Me.dtmInventoryTime.Location = New System.Drawing.Point(498, 63)
        Me.dtmInventoryTime.Name = "dtmInventoryTime"
        Me.dtmInventoryTime.Size = New System.Drawing.Size(140, 20)
        Me.dtmInventoryTime.TabIndex = 23
        '
        'dtmDeposit
        '
        Me.dtmDeposit.Location = New System.Drawing.Point(364, 90)
        Me.dtmDeposit.Name = "dtmDeposit"
        Me.dtmDeposit.Size = New System.Drawing.Size(129, 20)
        Me.dtmDeposit.TabIndex = 23
        '
        'dtmDepositTime
        '
        Me.dtmDepositTime.Location = New System.Drawing.Point(499, 90)
        Me.dtmDepositTime.Name = "dtmDepositTime"
        Me.dtmDepositTime.Size = New System.Drawing.Size(140, 20)
        Me.dtmDepositTime.TabIndex = 23
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 176)
        Me.Controls.Add(Me.dtmDepositTime)
        Me.Controls.Add(Me.dtmInventoryTime)
        Me.Controls.Add(Me.dtmSalesTaxReportTime)
        Me.Controls.Add(Me.dtmSalesReportTime)
        Me.Controls.Add(Me.dtmDeposit)
        Me.Controls.Add(Me.dtmInventory)
        Me.Controls.Add(Me.dtmSalesTaxReport)
        Me.Controls.Add(Me.dtmSalesReport)
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
    Friend WithEvents dtmSalesReport As DateTimePicker
    Friend WithEvents dtmSalesReportTime As DateTimePicker
    Friend WithEvents dtmSalesTaxReport As DateTimePicker
    Friend WithEvents dtmSalesTaxReportTime As DateTimePicker
    Friend WithEvents dtmInventory As DateTimePicker
    Friend WithEvents dtmInventoryTime As DateTimePicker
    Friend WithEvents dtmDeposit As DateTimePicker
    Friend WithEvents dtmDepositTime As DateTimePicker
End Class
