Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmAddUser
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        OpenFormKillParent(Me, frmUsers)

    End Sub

    Public Function Validation() As Boolean

        ' loop through the textboxes and clear them in case they have data in them after a delete
        For Each cntrl As Control In Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.BackColor = Color.White
                If cntrl.Text = String.Empty Then
                    cntrl.BackColor = Color.Yellow
                    cntrl.Focus()
                    Return False
                End If
            End If
        Next

        'every this is good so return true
        Return True

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Validation() = True Then
                Dim Connection As New SqlConnection("Server=itd2.cincinnatistate.edu;" &
                                                      "Database=CPDM-GroupB;" &
                                                      "User ID=" & strConnectionUsername & ";" &
                                                      "Password=" & strConnectionPassword & ";")
                Dim cmdInsert As New SqlCommand
                ' Dim ms As MemoryStream = New MemoryStream()

                'picItemImage.Image.Save(ms, picItemImage.Image.RawFormat)

                cmdInsert.Connection = Connection
                cmdInsert.CommandText = "uspAddUser"
                cmdInsert.CommandType = CommandType.StoredProcedure

                'Dim cmdInsert = New OleDbCommand("INSERT INTO TUsers(strUsername, strPassword, blnCheckout, blnReturns, blnAddItems, blnEditItems, blnDeleteItems, blnMassPricing, blnAddVendors, blnEditVendors) VALUES(?,?,?,?,?,?,?,?,?,?)")
                'cmdInsert.CommandType = CommandType.Text
                'cmdInsert.Connection = m_conAdministrator
                ' Username Password
                cmdInsert.Parameters.AddWithValue("strUsername", txtUsername.Text)
                cmdInsert.Parameters.AddWithValue("strPassword", txtPassword.Text)
                ' Permission
                cmdInsert.Parameters.AddWithValue("blnCheckout", chkCheckout.Checked)
                cmdInsert.Parameters.AddWithValue("blnReturns", chkReturns.Checked)
                cmdInsert.Parameters.AddWithValue("blnAddItems", chkAddItems.Checked)
                cmdInsert.Parameters.AddWithValue("blnEditItems", chkEditItem.Checked)
                cmdInsert.Parameters.AddWithValue("blnDeleteItems", chkDeleteItems.Checked)
                cmdInsert.Parameters.AddWithValue("blnMassPricing", chkMassPricing.Checked)
                cmdInsert.Parameters.AddWithValue("blnAddVendors", chkAddVendors.Checked)
                cmdInsert.Parameters.AddWithValue("blnEditVendors", chkEdiVendors.Checked)
                cmdInsert.Parameters.AddWithValue("blnPayinPayOut", chkPayInPayOut.Checked)
                cmdInsert.Parameters.AddWithValue("blnDeleteVendors", chkDeleteVendors.Checked)

                ' Proceed with the database
                Dim result = cmdInsert.ExecuteNonQuery()
                ' If result is one that means a row is added
                MessageBox.Show(result.ToString + " User Added successfully")
                Connection.Open()

                ' have to let the user know what happened 
                If cmdInsert.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Insert successful. Item " & txtUsername.Text & " has been added.")

                Else
                    MessageBox.Show("Insert failed")

                End If
            End If
        Catch excError As SqlException

            ' Handle SQL errors
            MessageBox.Show(excError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception

            ' Handle General errors
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()

        End Try

    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnAdd, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnExit, Me, btmButtonShortGray, btmButtonShort)

    End Sub
End Class