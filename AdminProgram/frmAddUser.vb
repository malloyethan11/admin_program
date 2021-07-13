﻿Imports System.Data.OleDb

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
            Dim cmdInsert = New OleDbCommand("INSERT INTO TUsers(strUsername, strPassword, blnCheckout, blnReturns, blnAddItems, blnEditItems, blnDeleteItems, blnMassPricing, blnAddVendors, blnEditVendors, blnPayInPayOut, blnDeleteVendors) VALUES(?,?,?,?,?,?,?,?,?,?,?,?)")
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = m_conAdministrator
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
            cmdInsert.Parameters.AddWithValue("blnPayInPayOut", chkPayInPayOut.Checked)
            cmdInsert.Parameters.AddWithValue("blnDeleteVendors", chkDeleteVendors.Checked)
            ' Proceed with the database
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
            MessageBox.Show(result.ToString + " User Added successfully")
        Catch excError As System.Data.SqlClient.SqlException

            ' Handle SQL errors
            MessageBox.Show(excError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception

            ' Handle general errors
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnAdd, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnExit, Me, btmButtonShortGray, btmButtonShort)

    End Sub
End Class