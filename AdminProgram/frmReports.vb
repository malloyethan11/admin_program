﻿Imports System.Data.OleDb
Imports System.Net.Mail

Public Class frmReports

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        OpenFormKillParent(Me, frmMain)

    End Sub
    Private Function toDB(strReportType As String, blnDaily As Boolean, blnWeekly As Boolean,
                          blnMonthly As Boolean, blnYearly As Boolean, strTargetEmail As String) As Integer

        ' Start of function to add report to database
        If blnDaily Or blnMonthly Or blnWeekly Or blnYearly Then
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
            Dim cmdInsert = New OleDbCommand("INSERT INTO TReports(strReportType, blnDaily, blnWeekly, blnMonthly, blnYearly, dtDailyReportDate, dtWeeklyReportDate, dtMonthlyReportDate, dtYearlyReportDate, strTargetEmail) VALUES(?,?,?,?,?,GETDATE(),GETDATE(),GETDATE(),GETDATE(),?)")
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = m_conAdministrator

            ' Username Password
            cmdInsert.Parameters.AddWithValue("strReportType", strReportType)
            ' Time of Report
            cmdInsert.Parameters.AddWithValue("blnDaily", blnDaily)
            cmdInsert.Parameters.AddWithValue("blnWeekly", blnWeekly)
            cmdInsert.Parameters.AddWithValue("blnMonthly", blnMonthly)
            cmdInsert.Parameters.AddWithValue("blnYearly", blnYearly)
            cmdInsert.Parameters.AddWithValue("strTargetEmail", strTargetEmail)
            ' Proceed with the database
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
            Return result
        End If
        Return 0
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim result As Integer = 0
            lblProgress.Text = "Initializing"
            lblProgress.Text = "Adding Sales Report"
            result += toDB("Sales Report", chkSalesReportDaily.Checked, chkSalesReportWeekly.Checked, chkSalesReportMonthly.Checked, chkSalesReportYearly.Checked, txtEmail.Text)
            lblProgress.Text = "Adding Tax Report"
            result += toDB("Tax Report", chkSTRDaily.Checked, chkSTRWeekly.Checked, chkSTRMonthly.Checked, chkSTRYearly.Checked, txtEmail.Text)
            lblProgress.Text = "Adding Inventory Report"
            result += toDB("Inventory Report", chkIRDaily.Checked, chkIRWeekly.Checked, chkDRMonthly.Checked, chkDRYearly.Checked, txtEmail.Text)
            lblProgress.Text = "Adding Deposit Report"
            result += toDB("Deposit Report", chkDRDaily.Checked, chkDRWeekly.Checked, chkDRMonthly.Checked, chkDRYearly.Checked, txtEmail.Text)
            'lblProgress.Text = "Sending Mail"
            lblProgress.Text = ""

            MessageBox.Show(result.ToString + " Reports Added successfully")
        Catch ex As Exception
            lblProgress.Text = ""
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnSubmit, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnExit, Me, btmButtonShortGray, btmButtonShort)

    End Sub
End Class