<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserEditor))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkAddItems = New System.Windows.Forms.CheckBox()
        Me.chkEditItem = New System.Windows.Forms.CheckBox()
        Me.chkReturns = New System.Windows.Forms.CheckBox()
        Me.chkCheckout = New System.Windows.Forms.CheckBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPermissions = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkEdiVendors = New System.Windows.Forms.CheckBox()
        Me.chkAddVendors = New System.Windows.Forms.CheckBox()
        Me.StepAction = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnUpdate.Location = New System.Drawing.Point(162, 119)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(278, 42)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(250, 93)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox2.TabIndex = 98
        Me.CheckBox2.Text = "Mass pricing"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(250, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 99
        Me.CheckBox1.Text = "Delete items"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkAddItems
        '
        Me.chkAddItems.AutoSize = True
        Me.chkAddItems.Location = New System.Drawing.Point(174, 93)
        Me.chkAddItems.Name = "chkAddItems"
        Me.chkAddItems.Size = New System.Drawing.Size(72, 17)
        Me.chkAddItems.TabIndex = 97
        Me.chkAddItems.Text = "Add items"
        Me.chkAddItems.UseVisualStyleBackColor = True
        '
        'chkEditItem
        '
        Me.chkEditItem.AutoSize = True
        Me.chkEditItem.Location = New System.Drawing.Point(174, 70)
        Me.chkEditItem.Name = "chkEditItem"
        Me.chkEditItem.Size = New System.Drawing.Size(71, 17)
        Me.chkEditItem.TabIndex = 96
        Me.chkEditItem.Text = "Edit items"
        Me.chkEditItem.UseVisualStyleBackColor = True
        '
        'chkReturns
        '
        Me.chkReturns.AutoSize = True
        Me.chkReturns.Location = New System.Drawing.Point(96, 93)
        Me.chkReturns.Name = "chkReturns"
        Me.chkReturns.Size = New System.Drawing.Size(63, 17)
        Me.chkReturns.TabIndex = 95
        Me.chkReturns.Text = "Returns"
        Me.chkReturns.UseVisualStyleBackColor = True
        '
        'chkCheckout
        '
        Me.chkCheckout.AutoSize = True
        Me.chkCheckout.Location = New System.Drawing.Point(96, 70)
        Me.chkCheckout.Name = "chkCheckout"
        Me.chkCheckout.Size = New System.Drawing.Size(72, 17)
        Me.chkCheckout.TabIndex = 94
        Me.chkCheckout.Text = "Checkout"
        Me.chkCheckout.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.DarkGray
        Me.txtDescription.Location = New System.Drawing.Point(96, 43)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(486, 21)
        Me.txtDescription.TabIndex = 93
        '
        'lblPermissions
        '
        Me.lblPermissions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermissions.Location = New System.Drawing.Point(9, 67)
        Me.lblPermissions.Name = "lblPermissions"
        Me.lblPermissions.Size = New System.Drawing.Size(81, 20)
        Me.lblPermissions.TabIndex = 103
        Me.lblPermissions.Text = "Permissions:"
        Me.lblPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(9, 41)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(81, 20)
        Me.lblDescription.TabIndex = 104
        Me.lblDescription.Text = "Password:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(9, 16)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(81, 20)
        Me.lblUserName.TabIndex = 102
        Me.lblUserName.Text = "Username:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSKU
        '
        Me.txtSKU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSKU.BackColor = System.Drawing.Color.White
        Me.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSKU.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSKU.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSKU.Location = New System.Drawing.Point(96, 16)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.Size = New System.Drawing.Size(486, 21)
        Me.txtSKU.TabIndex = 92
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.AdminFormsDesign.My.Resources.Resources.ButtonShort
        Me.btnDelete.Location = New System.Drawing.Point(469, 119)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 42)
        Me.btnDelete.TabIndex = 101
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        Me.btnExit.TabIndex = 100
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkEdiVendors
        '
        Me.chkEdiVendors.AutoSize = True
        Me.chkEdiVendors.Location = New System.Drawing.Point(340, 70)
        Me.chkEdiVendors.Name = "chkEdiVendors"
        Me.chkEdiVendors.Size = New System.Drawing.Size(85, 17)
        Me.chkEdiVendors.TabIndex = 106
        Me.chkEdiVendors.Text = "Edit vendors"
        Me.chkEdiVendors.UseVisualStyleBackColor = True
        '
        'chkAddVendors
        '
        Me.chkAddVendors.AutoSize = True
        Me.chkAddVendors.Location = New System.Drawing.Point(340, 93)
        Me.chkAddVendors.Name = "chkAddVendors"
        Me.chkAddVendors.Size = New System.Drawing.Size(86, 17)
        Me.chkAddVendors.TabIndex = 105
        Me.chkAddVendors.Text = "Add vendors"
        Me.chkAddVendors.UseVisualStyleBackColor = True
        '
        'StepAction
        '
        Me.StepAction.Enabled = True
        Me.StepAction.Interval = 1
        '
        'frmUserEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 173)
        Me.Controls.Add(Me.chkEdiVendors)
        Me.Controls.Add(Me.chkAddVendors)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkAddItems)
        Me.Controls.Add(Me.chkEditItem)
        Me.Controls.Add(Me.chkReturns)
        Me.Controls.Add(Me.chkCheckout)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblPermissions)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserEditor"
        Me.Text = "Administration Program - User Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chkAddItems As CheckBox
    Friend WithEvents chkEditItem As CheckBox
    Friend WithEvents chkReturns As CheckBox
    Friend WithEvents chkCheckout As CheckBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblPermissions As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkEdiVendors As CheckBox
    Friend WithEvents chkAddVendors As CheckBox
    Friend WithEvents StepAction As Timer
End Class
