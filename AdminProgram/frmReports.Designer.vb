<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnExit.Location = New System.Drawing.Point(145, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(185, 42)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSalesReport
        '
        Me.lblSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSalesReport.Location = New System.Drawing.Point(30, 34)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesReport.TabIndex = 11
        Me.lblSalesReport.Text = "Sales Report"
        Me.lblSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTaxReport
        '
        Me.lblSalesTaxReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSalesTaxReport.Location = New System.Drawing.Point(30, 61)
        Me.lblSalesTaxReport.Name = "lblSalesTaxReport"
        Me.lblSalesTaxReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesTaxReport.TabIndex = 11
        Me.lblSalesTaxReport.Text = "Sales Tax Report"
        Me.lblSalesTaxReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInventoryReport
        '
        Me.lblInventoryReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInventoryReport.Location = New System.Drawing.Point(30, 88)
        Me.lblInventoryReport.Name = "lblInventoryReport"
        Me.lblInventoryReport.Size = New System.Drawing.Size(93, 18)
        Me.lblInventoryReport.TabIndex = 11
        Me.lblInventoryReport.Text = "Inventory Report"
        Me.lblInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashDepositReport
        '
        Me.lblCashDepositReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCashDepositReport.Location = New System.Drawing.Point(33, 115)
        Me.lblCashDepositReport.Name = "lblCashDepositReport"
        Me.lblCashDepositReport.Size = New System.Drawing.Size(90, 18)
        Me.lblCashDepositReport.TabIndex = 11
        Me.lblCashDepositReport.Text = "Deposit Report"
        Me.lblCashDepositReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSalesReportDaily
        '
        Me.chkSalesReportDaily.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSalesReportDaily.AutoSize = True
        Me.chkSalesReportDaily.Location = New System.Drawing.Point(129, 36)
        Me.chkSalesReportDaily.Name = "chkSalesReportDaily"
        Me.chkSalesReportDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSalesReportDaily.TabIndex = 12
        Me.chkSalesReportDaily.Text = "Daily"
        Me.chkSalesReportDaily.UseVisualStyleBackColor = True
        '
        'chkSalesReportWeekly
        '
        Me.chkSalesReportWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSalesReportWeekly.AutoSize = True
        Me.chkSalesReportWeekly.Location = New System.Drawing.Point(183, 36)
        Me.chkSalesReportWeekly.Name = "chkSalesReportWeekly"
        Me.chkSalesReportWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSalesReportWeekly.TabIndex = 12
        Me.chkSalesReportWeekly.Text = "Weekly"
        Me.chkSalesReportWeekly.UseVisualStyleBackColor = True
        '
        'chkSalesReportMonthly
        '
        Me.chkSalesReportMonthly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSalesReportMonthly.AutoSize = True
        Me.chkSalesReportMonthly.Location = New System.Drawing.Point(251, 36)
        Me.chkSalesReportMonthly.Name = "chkSalesReportMonthly"
        Me.chkSalesReportMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSalesReportMonthly.TabIndex = 12
        Me.chkSalesReportMonthly.Text = "Monthly"
        Me.chkSalesReportMonthly.UseVisualStyleBackColor = True
        '
        'chkSalesReportYearly
        '
        Me.chkSalesReportYearly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSalesReportYearly.AutoSize = True
        Me.chkSalesReportYearly.Location = New System.Drawing.Point(320, 36)
        Me.chkSalesReportYearly.Name = "chkSalesReportYearly"
        Me.chkSalesReportYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSalesReportYearly.TabIndex = 12
        Me.chkSalesReportYearly.Text = "Yearly"
        Me.chkSalesReportYearly.UseVisualStyleBackColor = True
        '
        'chkSTRDaily
        '
        Me.chkSTRDaily.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSTRDaily.AutoSize = True
        Me.chkSTRDaily.Location = New System.Drawing.Point(129, 63)
        Me.chkSTRDaily.Name = "chkSTRDaily"
        Me.chkSTRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkSTRDaily.TabIndex = 12
        Me.chkSTRDaily.Text = "Daily"
        Me.chkSTRDaily.UseVisualStyleBackColor = True
        '
        'chkSTRWeekly
        '
        Me.chkSTRWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSTRWeekly.AutoSize = True
        Me.chkSTRWeekly.Location = New System.Drawing.Point(183, 63)
        Me.chkSTRWeekly.Name = "chkSTRWeekly"
        Me.chkSTRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkSTRWeekly.TabIndex = 12
        Me.chkSTRWeekly.Text = "Weekly"
        Me.chkSTRWeekly.UseVisualStyleBackColor = True
        '
        'chkSTRMonthly
        '
        Me.chkSTRMonthly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSTRMonthly.AutoSize = True
        Me.chkSTRMonthly.Location = New System.Drawing.Point(251, 63)
        Me.chkSTRMonthly.Name = "chkSTRMonthly"
        Me.chkSTRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkSTRMonthly.TabIndex = 12
        Me.chkSTRMonthly.Text = "Monthly"
        Me.chkSTRMonthly.UseVisualStyleBackColor = True
        '
        'chkSTRYearly
        '
        Me.chkSTRYearly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSTRYearly.AutoSize = True
        Me.chkSTRYearly.Location = New System.Drawing.Point(320, 63)
        Me.chkSTRYearly.Name = "chkSTRYearly"
        Me.chkSTRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkSTRYearly.TabIndex = 12
        Me.chkSTRYearly.Text = "Yearly"
        Me.chkSTRYearly.UseVisualStyleBackColor = True
        '
        'chkIRDaily
        '
        Me.chkIRDaily.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkIRDaily.AutoSize = True
        Me.chkIRDaily.Location = New System.Drawing.Point(129, 90)
        Me.chkIRDaily.Name = "chkIRDaily"
        Me.chkIRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkIRDaily.TabIndex = 12
        Me.chkIRDaily.Text = "Daily"
        Me.chkIRDaily.UseVisualStyleBackColor = True
        '
        'chkIRWeekly
        '
        Me.chkIRWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkIRWeekly.AutoSize = True
        Me.chkIRWeekly.Location = New System.Drawing.Point(183, 90)
        Me.chkIRWeekly.Name = "chkIRWeekly"
        Me.chkIRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkIRWeekly.TabIndex = 12
        Me.chkIRWeekly.Text = "Weekly"
        Me.chkIRWeekly.UseVisualStyleBackColor = True
        '
        'chkIRMonthly
        '
        Me.chkIRMonthly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkIRMonthly.AutoSize = True
        Me.chkIRMonthly.Location = New System.Drawing.Point(251, 90)
        Me.chkIRMonthly.Name = "chkIRMonthly"
        Me.chkIRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkIRMonthly.TabIndex = 12
        Me.chkIRMonthly.Text = "Monthly"
        Me.chkIRMonthly.UseVisualStyleBackColor = True
        '
        'chkIRYearly
        '
        Me.chkIRYearly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkIRYearly.AutoSize = True
        Me.chkIRYearly.Location = New System.Drawing.Point(320, 90)
        Me.chkIRYearly.Name = "chkIRYearly"
        Me.chkIRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkIRYearly.TabIndex = 12
        Me.chkIRYearly.Text = "Yearly"
        Me.chkIRYearly.UseVisualStyleBackColor = True
        '
        'chkDRDaily
        '
        Me.chkDRDaily.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDRDaily.AutoSize = True
        Me.chkDRDaily.Location = New System.Drawing.Point(129, 117)
        Me.chkDRDaily.Name = "chkDRDaily"
        Me.chkDRDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkDRDaily.TabIndex = 12
        Me.chkDRDaily.Text = "Daily"
        Me.chkDRDaily.UseVisualStyleBackColor = True
        '
        'chkDRWeekly
        '
        Me.chkDRWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDRWeekly.AutoSize = True
        Me.chkDRWeekly.Location = New System.Drawing.Point(183, 117)
        Me.chkDRWeekly.Name = "chkDRWeekly"
        Me.chkDRWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkDRWeekly.TabIndex = 12
        Me.chkDRWeekly.Text = "Weekly"
        Me.chkDRWeekly.UseVisualStyleBackColor = True
        '
        'chkDRMonthly
        '
        Me.chkDRMonthly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDRMonthly.AutoSize = True
        Me.chkDRMonthly.Location = New System.Drawing.Point(251, 117)
        Me.chkDRMonthly.Name = "chkDRMonthly"
        Me.chkDRMonthly.Size = New System.Drawing.Size(63, 17)
        Me.chkDRMonthly.TabIndex = 12
        Me.chkDRMonthly.Text = "Monthly"
        Me.chkDRMonthly.UseVisualStyleBackColor = True
        '
        'chkDRYearly
        '
        Me.chkDRYearly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDRYearly.AutoSize = True
        Me.chkDRYearly.Location = New System.Drawing.Point(320, 117)
        Me.chkDRYearly.Name = "chkDRYearly"
        Me.chkDRYearly.Size = New System.Drawing.Size(55, 17)
        Me.chkDRYearly.TabIndex = 12
        Me.chkDRYearly.Text = "Yearly"
        Me.chkDRYearly.UseVisualStyleBackColor = True
        '
        'txtEmail1
        '
        Me.txtEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail1.Location = New System.Drawing.Point(433, 32)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(147, 23)
        Me.txtEmail1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Email ID"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnSubmit.Location = New System.Drawing.Point(336, 183)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(185, 42)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Add"
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
        Me.Label2.Location = New System.Drawing.Point(381, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Email ID"
        '
        'txtEmail2
        '
        Me.txtEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.Location = New System.Drawing.Point(433, 59)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(147, 23)
        Me.txtEmail2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email ID"
        '
        'txtEmail3
        '
        Me.txtEmail3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail3.Location = New System.Drawing.Point(433, 86)
        Me.txtEmail3.Name = "txtEmail3"
        Me.txtEmail3.Size = New System.Drawing.Size(147, 23)
        Me.txtEmail3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(381, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email ID"
        '
        'txtEmail4
        '
        Me.txtEmail4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail4.Location = New System.Drawing.Point(433, 113)
        Me.txtEmail4.Name = "txtEmail4"
        Me.txtEmail4.Size = New System.Drawing.Size(147, 23)
        Me.txtEmail4.TabIndex = 21
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 237)
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
End Class
