﻿Public Class frmUserLookup

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Control In Controls
            If Control.GetType() = GetType(Button) Then
                Control.FlatStyle = FlatStyle.Flat
                Control.ForeColor = BackColor
                Control.FlatAppearance.BorderColor = BackColor
                Control.FlatAppearance.MouseOverBackColor = BackColor
                Control.FlatAppearance.MouseDownBackColor = BackColor
            End If
        Next

        LoadUsers()

    End Sub

    ' Code in this procedure adapted from the GolfAThon program in Programming 2
    Private Sub LoadUsers()

        Try

            ' Init select statement string
            Dim strSelect As String = ""
            ' Init select statement Db command
            Dim cmdSelect As OleDb.OleDbCommand
            ' Init data reader
            Dim drSourceTable As OleDb.OleDbDataReader
            ' Init data table
            Dim dt As DataTable = New DataTable

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

            ' Build the select statement
            strSelect = "SELECT intUserID, strUsername FROM TUsers"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the user ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the user data.
            ' We are binding the column name to the combo box display and value members. 
            cboUsers.ValueMember = "intUserID"
            cboUsers.DisplayMember = "strUsername"
            cboUsers.DataSource = dt

            ' Select the first item in the list by default
            If cboUsers.Items.Count > 0 Then cboUsers.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim frmNewUserEditor As New frmUserEditor
        frmNewUserEditor.intCurrentlyEditingUserPrimaryKey = cboUsers.SelectedValue

        OpenFormKillParent(Me, frmNewUserEditor)

    End Sub
End Class