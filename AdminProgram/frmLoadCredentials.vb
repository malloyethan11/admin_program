Public Class frmLoadCredentials
    Private Sub frmLoadCredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Prompt for database connection credentials
        strConnectionUsername = InputBox("Please provide database login username: ")
        strConnectionPassword = InputBox("Please provide database login password: ")

        ' Set button images
        SetImages()

        ' Open form
        OpenFormKillParent(Me, frmMain)

    End Sub

    Private Sub SetImages()

        ' Change color - Cite: https://www.daniweb.com/programming/software-development/threads/486625/convert-color-image-to-grayscale
        Dim x As Integer = btmButtonDefault.Width
        Dim y As Integer = btmButtonDefault.Height
        btmButtonDefaultGray = New Bitmap(btmButtonDefault.Width, btmButtonDefault.Height)

        For x = 0 To (btmButtonDefault.Width) - 1
            For y = 0 To (btmButtonDefault.Height) - 1
                Dim c As Color = btmButtonDefault.GetPixel(x, y)
                Dim r As Integer = c.R
                Dim g As Integer = c.G
                Dim b As Integer = c.B
                Dim a As Integer = c.A
                Dim d As Integer = (r + g + b) \ 3
                btmButtonDefaultGray.SetPixel(x, y, Color.FromArgb(a, d, d, d))
            Next
        Next

        x = btmButtonShort.Width
        y = btmButtonShort.Height
        btmButtonShortGray = New Bitmap(btmButtonShort.Width, btmButtonShort.Height)

        For x = 0 To (btmButtonShort.Width) - 1
            For y = 0 To (btmButtonShort.Height) - 1
                Dim c As Color = btmButtonShort.GetPixel(x, y)
                Dim r As Integer = c.R
                Dim g As Integer = c.G
                Dim b As Integer = c.B
                Dim a As Integer = c.A
                Dim d As Integer = (r + g + b) \ 3
                btmButtonShortGray.SetPixel(x, y, Color.FromArgb(a, d, d, d))
            Next
        Next

    End Sub
End Class