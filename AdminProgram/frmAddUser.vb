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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
            Dim cmdInsert = New OleDbCommand("INSERT INTO TUsers VALUES(?,?,?,?,?,?,?,?,?,?)")
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = m_conAdministrator
            ' Username Password
            cmdInsert.Parameters.AddWithValue("strUsername", txtSKU)
            cmdInsert.Parameters.AddWithValue("strPassword", txtDescription)
            ' Permission
            cmdInsert.Parameters.AddWithValue("blnCheckout", chkCheckout)
            cmdInsert.Parameters.AddWithValue("blnReturns", chkReturns)
            cmdInsert.Parameters.AddWithValue("blnAddItems", chkAddItems)
            cmdInsert.Parameters.AddWithValue("blnEditItems", chkEditItem)
            cmdInsert.Parameters.AddWithValue("blnDeleteItems", chkDeleteItems)
            cmdInsert.Parameters.AddWithValue("blnMassPricing", chkMassPricing)
            cmdInsert.Parameters.AddWithValue("blnAddVendors", chkAddVendors)
            cmdInsert.Parameters.AddWithValue("blnEditVendors", chkEdiVendors)
            ' Proceed with the database
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class