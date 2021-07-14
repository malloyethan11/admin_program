Imports System.Data.OleDb

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
        If Validate() Then
            Try
                ' Open the DB
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' The database is not open
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The form will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Close the form/application
                    Me.Close()

                End If
                Dim cmdInsert = New OleDbCommand("INSERT INTO TUsers(strUsername, strPassword, blnCheckout, blnReturns, blnAddItems, blnEditItems, blnDeleteItems, blnMassPricing, blnAddVendors, blnEditVendors) VALUES(?,?,?,?,?,?,?,?,?,?)")
                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = m_conAdministrator
                ' Username Password
                cmdInsert.Parameters.AddWithValue("strUsername", txtSKU.Text)
                cmdInsert.Parameters.AddWithValue("strPassword", txtDescription.Text)
                ' Permission
                cmdInsert.Parameters.AddWithValue("blnCheckout", chkCheckout.Checked)
                cmdInsert.Parameters.AddWithValue("blnReturns", chkReturns.Checked)
                cmdInsert.Parameters.AddWithValue("blnAddItems", chkAddItems.Checked)
                cmdInsert.Parameters.AddWithValue("blnEditItems", chkEditItem.Checked)
                cmdInsert.Parameters.AddWithValue("blnDeleteItems", chkDeleteItems.Checked)
                cmdInsert.Parameters.AddWithValue("blnMassPricing", chkMassPricing.Checked)
                cmdInsert.Parameters.AddWithValue("blnAddVendors", chkAddVendors.Checked)
                cmdInsert.Parameters.AddWithValue("blnEditVendors", chkEdiVendors.Checked)
                ' Proceed with the database
                Dim result = cmdInsert.ExecuteNonQuery()
                ' If result is one that means a row is added
                MessageBox.Show(result.ToString + " User Added successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class