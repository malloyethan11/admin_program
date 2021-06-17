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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.lblSalesReport = New System.Windows.Forms.Label()
        Me.lblSalesTaxReport = New System.Windows.Forms.Label()
        Me.lblInventoryReport = New System.Windows.Forms.Label()
        Me.lblCashDepositReport = New System.Windows.Forms.Label()
        Me.lblCreditDepositReport = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnExit.Location = New System.Drawing.Point(12, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(284, 42)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(134, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(134, 67)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(134, 94)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox4.TabIndex = 10
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(134, 121)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox5.TabIndex = 10
        '
        'lblSalesReport
        '
        Me.lblSalesReport.Location = New System.Drawing.Point(35, 13)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesReport.TabIndex = 11
        Me.lblSalesReport.Text = "Sales Report"
        Me.lblSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTaxReport
        '
        Me.lblSalesTaxReport.Location = New System.Drawing.Point(35, 40)
        Me.lblSalesTaxReport.Name = "lblSalesTaxReport"
        Me.lblSalesTaxReport.Size = New System.Drawing.Size(93, 18)
        Me.lblSalesTaxReport.TabIndex = 11
        Me.lblSalesTaxReport.Text = "Sales Tax Report"
        Me.lblSalesTaxReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInventoryReport
        '
        Me.lblInventoryReport.Location = New System.Drawing.Point(35, 67)
        Me.lblInventoryReport.Name = "lblInventoryReport"
        Me.lblInventoryReport.Size = New System.Drawing.Size(93, 18)
        Me.lblInventoryReport.TabIndex = 11
        Me.lblInventoryReport.Text = "Inventory Report"
        Me.lblInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashDepositReport
        '
        Me.lblCashDepositReport.Location = New System.Drawing.Point(19, 94)
        Me.lblCashDepositReport.Name = "lblCashDepositReport"
        Me.lblCashDepositReport.Size = New System.Drawing.Size(109, 18)
        Me.lblCashDepositReport.TabIndex = 11
        Me.lblCashDepositReport.Text = "Cash Deposit Report"
        Me.lblCashDepositReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCreditDepositReport
        '
        Me.lblCreditDepositReport.Location = New System.Drawing.Point(9, 121)
        Me.lblCreditDepositReport.Name = "lblCreditDepositReport"
        Me.lblCreditDepositReport.Size = New System.Drawing.Size(119, 18)
        Me.lblCreditDepositReport.TabIndex = 11
        Me.lblCreditDepositReport.Text = "Credit Deposit Report"
        Me.lblCreditDepositReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(305, 204)
        Me.Controls.Add(Me.lblCreditDepositReport)
        Me.Controls.Add(Me.lblCashDepositReport)
        Me.Controls.Add(Me.lblInventoryReport)
        Me.Controls.Add(Me.lblSalesTaxReport)
        Me.Controls.Add(Me.lblSalesReport)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReports"
        Me.Text = "Administration Program - Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents lblSalesReport As Label
    Friend WithEvents lblSalesTaxReport As Label
    Friend WithEvents lblInventoryReport As Label
    Friend WithEvents lblCashDepositReport As Label
    Friend WithEvents lblCreditDepositReport As Label
End Class
