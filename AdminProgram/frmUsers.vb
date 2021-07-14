Public Class frmUsers

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        For Each Control In Controls
            If Control.GetType() = GetType(Button) Then
                Control.FlatStyle = FlatStyle.Flat
                Control.ForeColor = BackColor
                Control.FlatAppearance.BorderColor = BackColor
                Control.FlatAppearance.MouseOverBackColor = BackColor
                Control.FlatAppearance.MouseDownBackColor = BackColor
            End If
        Next

    End Sub

    Private Sub btnUserLookup_Click(sender As Object, e As EventArgs) Handles btnUserLookup.Click

        ' open frmUserLookup
        OpenFormKillParent(Me, frmUserLookup)

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        ' open frmAddUser
        OpenFormKillParent(Me, frmAddUser)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' close frmUsers, open frmMain
        OpenFormKillParent(Me, frmMain)

    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnExit, Me, btmButtonDefaultGray, btmButtonDefault)
        ButtonColor(MousePosition, btnAddUser, Me, btmButtonDefaultGray, btmButtonDefault)
        ButtonColor(MousePosition, btnUserLookup, Me, btmButtonDefaultGray, btmButtonDefault)

    End Sub
End Class
