Imports System.Data.OleDb

Public Class frmUserEditor

    Public intCurrentlyEditingUserPrimaryKey As Integer = -1

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If Not intCurrentlyEditingUserPrimaryKey.CompareTo(-1) Then
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
                ' Need to get userID Dynamically at the end of this sentance
                Dim cmdInsert = New OleDbCommand("SELECT * FROM TUsers WHERE intUserID=" + intCurrentlyEditingUserPrimaryKey.ToString)
                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = m_conAdministrator
                ' Username Password
                Dim result = cmdInsert.ExecuteReader()
                result.Read()

                If result.HasRows Then
                    txtSKU.Text = result.GetString(1)
                    txtDescription.Text = result.GetString(2)
                    chkCheckout.Checked = result.GetBoolean(3)
                    chkReturns.Checked = result.GetBoolean(4)
                    chkAddItems.Checked = result.GetBoolean(5)
                    chkEditItem.Checked = result.GetBoolean(6)
                    CheckBox1.Checked = result.GetBoolean(7)
                    CheckBox2.Checked = result.GetBoolean(8)
                    chkAddVendors.Checked = result.GetBoolean(9)
                    chkEdiVendors.Checked = result.GetBoolean(10)
                End If
                ' If result is one that means a row is added

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        OpenFormKillParent(Me, frmUserLookup)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
            ' Need to get userID Dynamically at the end of this sentance
            Dim cmdInsert = New OleDbCommand("UPDATE TUsers SET strUsername=?, strPassword=?, blnCheckout=?, blnReturns=?, blnAddItems=?, blnEditItems=?, blnDeleteItems=?, blnMassPricing=?, blnAddVendors=?, blnEditVendors=? WHERE intUserID=" + intCurrentlyEditingUserPrimaryKey.ToString)
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
            cmdInsert.Parameters.AddWithValue("blnDeleteItems", CheckBox1.Checked)
            cmdInsert.Parameters.AddWithValue("blnMassPricing", CheckBox2.Checked)
            cmdInsert.Parameters.AddWithValue("blnAddVendors", chkAddVendors.Checked)
            cmdInsert.Parameters.AddWithValue("blnEditVendors", chkEdiVendors.Checked)
            ' Proceed with the database
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
            MessageBox.Show(result.ToString + " User changed successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

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
            ' Need to get userID Dynamically at the end of this sentance
            Dim cmdInsert = New OleDbCommand("DELETE FROM TUsers WHERE intUserID=" + intCurrentlyEditingUserPrimaryKey.ToString)
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = m_conAdministrator
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
            MessageBox.Show(result.ToString + " User deleted successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnDelete, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnExit, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnUpdate, Me, btmButtonDefaultGray, btmButtonDefault)
    End Sub
End Class