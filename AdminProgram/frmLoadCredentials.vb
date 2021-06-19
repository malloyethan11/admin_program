Public Class frmLoadCredentials
    Private Sub frmLoadCredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Prompt for database connection credentials
        strConnectionUsername = InputBox("Please provide database login username: ")
        strConnectionPassword = InputBox("Please provide database login password: ")

        ' Open form
        OpenFormKillParent(Me, frmMain)

    End Sub
End Class