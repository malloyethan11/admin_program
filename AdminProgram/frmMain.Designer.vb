<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picLogo.BackgroundImage = Global.AdminFormsDesign.My.Resources.Resources.Logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.InitialImage = Global.AdminFormsDesign.My.Resources.Resources.Logo
        Me.picLogo.Location = New System.Drawing.Point(71, -8)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(674, 190)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'btnUsers
        '
        Me.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnUsers.Location = New System.Drawing.Point(266, 280)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(284, 42)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnReports.Location = New System.Drawing.Point(266, 328)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(284, 42)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.AdminFormsDesign.My.Resources.Resources.Button
        Me.btnExit.Location = New System.Drawing.Point(266, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(284, 42)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Administration Program - Main Menu"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents picLogo As PictureBox
End Class
