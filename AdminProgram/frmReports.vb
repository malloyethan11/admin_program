Imports System.Data.OleDb
Imports System.Net.Mail

Public Class frmReports

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ' Citation for formatting:
        ' https://stackoverflow.com/questions/93472/datetimepicker-pick-both-date-and-time
        dtmSalesReport.Format = DateTimePickerFormat.Custom
        dtmSalesReport.CustomFormat = "dd MMMM yyyy"
        dtmSalesReportTime.Format = DateTimePickerFormat.Time
        dtmSalesReportTime.ShowUpDown = True

        dtmSalesTaxReport.Format = DateTimePickerFormat.Custom
        dtmSalesTaxReport.CustomFormat = "dd MMMM yyyy"
        dtmSalesTaxReportTime.Format = DateTimePickerFormat.Time
        dtmSalesTaxReportTime.ShowUpDown = True

        dtmDeposit.Format = DateTimePickerFormat.Custom
        dtmDeposit.CustomFormat = "dd MMMM yyyy"
        dtmDepositTime.Format = DateTimePickerFormat.Time
        dtmDepositTime.ShowUpDown = True

        dtmInventory.Format = DateTimePickerFormat.Custom
        dtmInventory.CustomFormat = "dd MMMM yyyy"
        dtmInventoryTime.Format = DateTimePickerFormat.Time
        dtmInventoryTime.ShowUpDown = True

        ' Get configs
        LoadData()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        OpenFormKillParent(Me, frmMain)

    End Sub
    Private Function toDB(strReportType As String, blnDaily As Boolean, blnWeekly As Boolean,
                          blnMonthly As Boolean, blnYearly As Boolean, strTargetEmail As String, dtmDateTime As DateTime) As Integer

        ' Start of function to add report to database
        'If blnDaily Or blnMonthly Or blnWeekly Or blnYearly Then
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
            Dim cmdInsert = New OleDbCommand("UPDATE TReports SET blnDaily=?, blnWeekly=?, blnMonthly=?, blnYearly=?, dtDailyReportDate=?, dtWeeklyReportDate=?, dtMonthlyReportDate=?, dtYearlyReportDate=?, strTargetEmail=? WHERE strReportType='" + strReportType + "'")
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = m_conAdministrator

            ' Username Password
            'cmdInsert.Parameters.AddWithValue("strReportType", strReportType)
            ' Time of Report
            cmdInsert.Parameters.AddWithValue("blnDaily", blnDaily)
            cmdInsert.Parameters.AddWithValue("blnWeekly", blnWeekly)
            cmdInsert.Parameters.AddWithValue("blnMonthly", blnMonthly)
            cmdInsert.Parameters.AddWithValue("blnYearly", blnYearly)
            ' When
            cmdInsert.Parameters.AddWithValue("dtDailyReportDate", dtmDateTime)
            cmdInsert.Parameters.AddWithValue("dtWeeklyReportDate", dtmDateTime)
            cmdInsert.Parameters.AddWithValue("dtMonthlyReportDate", dtmDateTime)
            cmdInsert.Parameters.AddWithValue("dtYearlyReportDate", dtmDateTime)
            cmdInsert.Parameters.AddWithValue("strTargetEmail", strTargetEmail)
            ' Proceed with the database
            Dim result = cmdInsert.ExecuteNonQuery()
            ' If result is one that means a row is added
            Return result

            CloseDatabaseConnection()

        'End If
        Return 0
    End Function


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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Validation() Then
            Try
                Dim result As Integer = 0
                lblProgress.Text = "Initializing"
                lblProgress.Text = "Adding Sales Report"
                result += toDB("Sales Report", chkSalesReportDaily.Checked, chkSalesReportWeekly.Checked, chkSalesReportMonthly.Checked, chkSalesReportYearly.Checked, txtEmail1.Text, dtmSalesReport.Value.Date + dtmSalesReportTime.Value.TimeOfDay)
                lblProgress.Text = "Adding Tax Report"
                result += toDB("Tax Report", chkSTRDaily.Checked, chkSTRWeekly.Checked, chkSTRMonthly.Checked, chkSTRYearly.Checked, txtEmail2.Text, dtmSalesTaxReport.Value.Date + dtmSalesTaxReportTime.Value.TimeOfDay)
                lblProgress.Text = "Adding Inventory Report"
                result += toDB("Inventory Report", chkIRDaily.Checked, chkIRWeekly.Checked, chkDRMonthly.Checked, chkDRYearly.Checked, txtEmail3.Text, dtmInventory.Value.Date + dtmInventoryTime.Value.TimeOfDay)
                lblProgress.Text = "Adding Deposit Report"
                result += toDB("Deposit Report", chkDRDaily.Checked, chkDRWeekly.Checked, chkDRMonthly.Checked, chkDRYearly.Checked, txtEmail4.Text, dtmDeposit.Value.Date + dtmDepositTime.Value.TimeOfDay)
                'lblProgress.Text = "Sending Mail"
                lblProgress.Text = ""

                MessageBox.Show(result.ToString + " reports updated successfully")
            Catch ex As Exception
                lblProgress.Text = ""
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub StepAction_Tick(sender As Object, e As EventArgs) Handles StepAction.Tick

        ButtonColor(MousePosition, btnSubmit, Me, btmButtonShortGray, btmButtonShort)
        ButtonColor(MousePosition, btnExit, Me, btmButtonShortGray, btmButtonShort)

    End Sub

    Private Sub LoadData()

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

            ' Init select statement string
            Dim strSelect As String = ""
            ' Init select statement Db command
            Dim cmdSelect As OleDb.OleDbCommand
            ' Init data reader
            Dim drSourceTable As OleDb.OleDbDataReader
            ' Init data table
            Dim dt As DataTable = New DataTable

            ' Build the select statement
            strSelect = "SELECT * FROM TReports"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            ' Get data
            dt.Load(drSourceTable)

            ' Load
            lblSalesReport.Text = dt(0)("strReportType").ToString
            lblSalesTaxReport.Text = dt(1)("strReportType").ToString
            lblInventoryReport.Text = dt(2)("strReportType").ToString
            lblCashDepositReport.Text = dt(3)("strReportType").ToString

            txtEmail1.Text = dt(0)("strTargetEmail").ToString
            txtEmail2.Text = dt(1)("strTargetEmail").ToString
            txtEmail3.Text = dt(2)("strTargetEmail").ToString
            txtEmail4.Text = dt(3)("strTargetEmail").ToString

            chkSalesReportDaily.Checked = dt(0)("blnDaily").ToString
            chkSalesReportMonthly.Checked = dt(0)("blnMonthly").ToString
            chkSalesReportWeekly.Checked = dt(0)("blnWeekly").ToString
            chkSalesReportYearly.Checked = dt(0)("blnYearly").ToString

            chkIRDaily.Checked = dt(1)("blnDaily").ToString
            chkIRMonthly.Checked = dt(1)("blnMonthly").ToString
            chkIRWeekly.Checked = dt(1)("blnWeekly").ToString
            chkIRYearly.Checked = dt(1)("blnYearly").ToString

            chkSTRDaily.Checked = dt(2)("blnDaily").ToString
            chkSTRMonthly.Checked = dt(2)("blnMonthly").ToString
            chkSTRWeekly.Checked = dt(2)("blnWeekly").ToString
            chkSTRYearly.Checked = dt(2)("blnYearly").ToString

            chkDRDaily.Checked = dt(3)("blnDaily").ToString
            chkDRMonthly.Checked = dt(3)("blnMonthly").ToString
            chkDRWeekly.Checked = dt(3)("blnWeekly").ToString
            chkDRYearly.Checked = dt(3)("blnYearly").ToString

            dtmSalesReport.Value = Convert.ToDateTime(dt(0)("dtDailyReportDate").ToString())
            dtmSalesReportTime.Value = Convert.ToDateTime(dt(0)("dtDailyReportDate").ToString())

            dtmSalesTaxReport.Value = Convert.ToDateTime(dt(1)("dtDailyReportDate").ToString())
            dtmSalesTaxReportTime.Value = Convert.ToDateTime(dt(1)("dtDailyReportDate").ToString())

            dtmInventory.Value = Convert.ToDateTime(dt(2)("dtDailyReportDate").ToString())
            dtmInventoryTime.Value = Convert.ToDateTime(dt(2)("dtDailyReportDate").ToString())

            dtmDeposit.Value = Convert.ToDateTime(dt(3)("dtDailyReportDate").ToString())
            dtmDepositTime.Value = Convert.ToDateTime(dt(3)("dtDailyReportDate").ToString())

            ' Close the db
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

End Class