<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkCheckout = New System.Windows.Forms.CheckBox()
        Me.chkReturns = New System.Windows.Forms.CheckBox()
        Me.lblPermissions = New System.Windows.Forms.Label()
        Me.chkEditItem = New System.Windows.Forms.CheckBox()
        Me.chkAddItems = New System.Windows.Forms.CheckBox()
        Me.chkDeleteItems = New System.Windows.Forms.CheckBox()
        Me.chkMassPricing = New System.Windows.Forms.CheckBox()
        Me.chkAddVendors = New System.Windows.Forms.CheckBox()
        Me.chkEdiVendors = New System.Windows.Forms.CheckBox()
        Me.chkPayInPayOut = New System.Windows.Forms.CheckBox()
        Me.chkDeleteVendors = New System.Windows.Forms.CheckBox()
        Me.StepAction = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(96, 43)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(486, 20)
        Me.txtPassword.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(9, 41)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(81, 20)
        Me.lblDescription.TabIndex = 91
        Me.lblDescription.Text = "Password:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(9, 16)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(81, 20)
        Me.lblUserName.TabIndex = 88
        Me.lblUserName.Text = "Username:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(96, 16)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(486, 20)
        Me.txtUsername.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.AdminFormsDesign.My.Resources.Resources.ButtonShort
        Me.btnAdd.Location = New System.Drawing.Point(469, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 42)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.AdminFormsDesign.My.Resources.Resources.ButtonShort
        Me.btnExit.Location = New System.Drawing.Point(12, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 42)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkCheckout
        '
        Me.chkCheckout.AutoSize = True
        Me.chkCheckout.Location = New System.Drawing.Point(96, 70)
        Me.chkCheckout.Name = "chkCheckout"
        Me.chkCheckout.Size = New System.Drawing.Size(72, 17)
        Me.chkCheckout.TabIndex = 3
        Me.chkCheckout.Text = "Checkout"
        Me.chkCheckout.UseVisualStyleBackColor = True
        '
        'chkReturns
        '
        Me.chkReturns.AutoSize = True
        Me.chkReturns.Location = New System.Drawing.Point(96, 93)
        Me.chkReturns.Name = "chkReturns"
        Me.chkReturns.Size = New System.Drawing.Size(63, 17)
        Me.chkReturns.TabIndex = 4
        Me.chkReturns.Text = "Returns"
        Me.chkReturns.UseVisualStyleBackColor = True
        '
        'lblPermissions
        '
        Me.lblPermissions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermissions.Location = New System.Drawing.Point(9, 67)
        Me.lblPermissions.Name = "lblPermissions"
        Me.lblPermissions.Size = New System.Drawing.Size(81, 20)
        Me.lblPermissions.TabIndex = 91
        Me.lblPermissions.Text = "Permissions:"
        Me.lblPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEditItem
        '
        Me.chkEditItem.AutoSize = True
        Me.chkEditItem.Location = New System.Drawing.Point(174, 70)
        Me.chkEditItem.Name = "chkEditItem"
        Me.chkEditItem.Size = New System.Drawing.Size(71, 17)
        Me.chkEditItem.TabIndex = 5
        Me.chkEditItem.Text = "Edit items"
        Me.chkEditItem.UseVisualStyleBackColor = True
        '
        'chkAddItems
        '
        Me.chkAddItems.AutoSize = True
        Me.chkAddItems.Location = New System.Drawing.Point(174, 93)
        Me.chkAddItems.Name = "chkAddItems"
        Me.chkAddItems.Size = New System.Drawing.Size(72, 17)
        Me.chkAddItems.TabIndex = 6
        Me.chkAddItems.Text = "Add items"
        Me.chkAddItems.UseVisualStyleBackColor = True
        '
        'chkDeleteItems
        '
        Me.chkDeleteItems.AutoSize = True
        Me.chkDeleteItems.Location = New System.Drawing.Point(250, 70)
        Me.chkDeleteItems.Name = "chkDeleteItems"
        Me.chkDeleteItems.Size = New System.Drawing.Size(84, 17)
        Me.chkDeleteItems.TabIndex = 7
        Me.chkDeleteItems.Text = "Delete items"
        Me.chkDeleteItems.UseVisualStyleBackColor = True
        '
        'chkMassPricing
        '
        Me.chkMassPricing.AutoSize = True
        Me.chkMassPricing.Location = New System.Drawing.Point(250, 93)
        Me.chkMassPricing.Name = "chkMassPricing"
        Me.chkMassPricing.Size = New System.Drawing.Size(85, 17)
        Me.chkMassPricing.TabIndex = 7
        Me.chkMassPricing.Text = "Mass pricing"
        Me.chkMassPricing.UseVisualStyleBackColor = True
        '
        'chkAddVendors
        '
        Me.chkAddVendors.AutoSize = True
        Me.chkAddVendors.Location = New System.Drawing.Point(340, 93)
        Me.chkAddVendors.Name = "chkAddVendors"
        Me.chkAddVendors.Size = New System.Drawing.Size(86, 17)
        Me.chkAddVendors.TabIndex = 9
        Me.chkAddVendors.Text = "Add vendors"
        Me.chkAddVendors.UseVisualStyleBackColor = True
        '
        'chkEdiVendors
        '
        Me.chkEdiVendors.AutoSize = True
        Me.chkEdiVendors.Location = New System.Drawing.Point(340, 70)
        Me.chkEdiVendors.Name = "chkEdiVendors"
        Me.chkEdiVendors.Size = New System.Drawing.Size(85, 17)
        Me.chkEdiVendors.TabIndex = 8
        Me.chkEdiVendors.Text = "Edit vendors"
        Me.chkEdiVendors.UseVisualStyleBackColor = True
        '
        'chkPayInPayOut
        '
        Me.chkPayInPayOut.AutoSize = True
        Me.chkPayInPayOut.Location = New System.Drawing.Point(431, 93)
        Me.chkPayInPayOut.Name = "chkPayInPayOut"
        Me.chkPayInPayOut.Size = New System.Drawing.Size(125, 17)
        Me.chkPayInPayOut.TabIndex = 11
        Me.chkPayInPayOut.Text = "Pay-ins and Pay-outs"
        Me.chkPayInPayOut.UseVisualStyleBackColor = True
        '
        'chkDeleteVendors
        '
        Me.chkDeleteVendors.AutoSize = True
        Me.chkDeleteVendors.Location = New System.Drawing.Point(431, 70)
        Me.chkDeleteVendors.Name = "chkDeleteVendors"
        Me.chkDeleteVendors.Size = New System.Drawing.Size(98, 17)
        Me.chkDeleteVendors.TabIndex = 10
        Me.chkDeleteVendors.Text = "Delete vendors"
        Me.chkDeleteVendors.UseVisualStyleBackColor = True
        '
        'StepAction
        '
        Me.StepAction.Enabled = True
        Me.StepAction.Interval = 1
        '
        'frmAddUser
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 173)
        Me.Controls.Add(Me.chkMassPricing)
        Me.Controls.Add(Me.chkDeleteItems)
        Me.Controls.Add(Me.chkDeleteVendors)
        Me.Controls.Add(Me.chkEdiVendors)
        Me.Controls.Add(Me.chkPayInPayOut)
        Me.Controls.Add(Me.chkAddItems)
        Me.Controls.Add(Me.chkAddVendors)
        Me.Controls.Add(Me.chkEditItem)
        Me.Controls.Add(Me.chkReturns)
        Me.Controls.Add(Me.chkCheckout)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPermissions)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddUser"
        Me.Text = "Administration Program - Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkCheckout As CheckBox
    Friend WithEvents chkReturns As CheckBox
    Friend WithEvents lblPermissions As Label
    Friend WithEvents chkEditItem As CheckBox
    Friend WithEvents chkAddItems As CheckBox
    Friend WithEvents chkDeleteItems As CheckBox
    Friend WithEvents chkMassPricing As CheckBox
    Friend WithEvents chkAddVendors As CheckBox
    Friend WithEvents chkEdiVendors As CheckBox
    Friend WithEvents chkPayInPayOut As CheckBox
    Friend WithEvents chkDeleteVendors As CheckBox
    Friend WithEvents StepAction As Timer
End Class
