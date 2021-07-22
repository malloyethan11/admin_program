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
        dtmSalesReportTimeDaily.Format = DateTimePickerFormat.Time
        dtmSalesReportTimeDaily.ShowUpDown = True
        dtmSalesTaxReportTimeDaily.Format = DateTimePickerFormat.Time
        dtmSalesTaxReportTimeDaily.ShowUpDown = True
        dtmDepositTimeDaily.Format = DateTimePickerFormat.Time
        dtmDepositTimeDaily.ShowUpDown = True
        dtmInventoryTimeDaily.Format = DateTimePickerFormat.Time
        dtmInventoryTimeDaily.ShowUpDown = True

        dtmSalesReportWeekly.Format = DateTimePickerFormat.Custom
        dtmSalesReportWeekly.CustomFormat = "dddd"
        dtmSalesTaxReportWeekly.Format = DateTimePickerFormat.Custom
        dtmSalesTaxReportWeekly.CustomFormat = "dddd"
        dtmDepositWeekly.Format = DateTimePickerFormat.Custom
        dtmDepositWeekly.CustomFormat = "dddd"
        dtmInventoryWeekly.Format = DateTimePickerFormat.Custom
        dtmInventoryWeekly.CustomFormat = "dddd"

        dtmSalesReportWeeklyTime.Format = DateTimePickerFormat.Time
        dtmSalesReportWeeklyTime.ShowUpDown = True
        dtmSalesTaxReportWeeklyTime.Format = DateTimePickerFormat.Time
        dtmSalesTaxReportWeeklyTime.ShowUpDown = True
        dtmDepositWeeklyTime.Format = DateTimePickerFormat.Time
        dtmDepositWeeklyTime.ShowUpDown = True
        dtmInventoryWeeklyTime.Format = DateTimePickerFormat.Time
        dtmInventoryWeeklyTime.ShowUpDown = True

        dtmSalesReportMonthly.Format = DateTimePickerFormat.Custom
        dtmSalesReportMonthly.CustomFormat = "dd"
        dtmSalesTaxReportMonthly.Format = DateTimePickerFormat.Custom
        dtmSalesTaxReportMonthly.CustomFormat = "dd"
        dtmDepositMonthly.Format = DateTimePickerFormat.Custom
        dtmDepositMonthly.CustomFormat = "dd"
        dtmInventoryMonthly.Format = DateTimePickerFormat.Custom
        dtmInventoryMonthly.CustomFormat = "dd"

        dtmSalesReportMonthlyTime.Format = DateTimePickerFormat.Time
        dtmSalesReportMonthlyTime.ShowUpDown = True
        dtmSalesTaxReportMonthlyTime.Format = DateTimePickerFormat.Time
        dtmSalesTaxReportMonthlyTime.ShowUpDown = True
        dtmDepositMonthlyTime.Format = DateTimePickerFormat.Time
        dtmDepositMonthlyTime.ShowUpDown = True
        dtmInventoryMonthlyTime.Format = DateTimePickerFormat.Time
        dtmInventoryMonthlyTime.ShowUpDown = True

        dtmSalesReportYearly.Format = DateTimePickerFormat.Custom
        dtmSalesReportYearly.CustomFormat = "MM/dd"
        dtmSalesTaxReportYearly.Format = DateTimePickerFormat.Custom
        dtmSalesTaxReportYearly.CustomFormat = "MM/dd"
        dtmDepositYearly.Format = DateTimePickerFormat.Custom
        dtmDepositYearly.CustomFormat = "MM/dd"
        dtmInventoryYearly.Format = DateTimePickerFormat.Custom
        dtmInventoryYearly.CustomFormat = "MM/dd"

        dtmSalesReportYearlyTime.Format = DateTimePickerFormat.Time
        dtmSalesReportYearlyTime.ShowUpDown = True
        dtmSalesTaxReportYearlyTime.Format = DateTimePickerFormat.Time
        dtmSalesTaxReportYearlyTime.ShowUpDown = True
        dtmDepositYearlyTime.Format = DateTimePickerFormat.Time
        dtmDepositYearlyTime.ShowUpDown = True
        dtmInventoryYearlyTime.Format = DateTimePickerFormat.Time
        dtmInventoryYearlyTime.ShowUpDown = True

        ' Get configs
        LoadData()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        OpenFormKillParent(Me, frmMain)

    End Sub
    Private Function toDB(strReportType As String, blnDaily As Boolean, blnWeekly As Boolean,
                          blnMonthly As Boolean, blnYearly As Boolean, strTargetEmail As String, dtmDailyDateTime As DateTime, dtmWeeklyDateTime As DateTime, dtmMonthlyDateTime As DateTime, dtmYearlyDateTime As DateTime) As Integer

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
        cmdInsert.Parameters.AddWithValue("dtDailyReportDate", dtmDailyDateTime)
        cmdInsert.Parameters.AddWithValue("dtWeeklyReportDate", dtmWeeklyDateTime)
        cmdInsert.Parameters.AddWithValue("dtMonthlyReportDate", dtmMonthlyDateTime)
        cmdInsert.Parameters.AddWithValue("dtYearlyReportDate", dtmYearlyDateTime)
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
                result += toDB("Sales Report", chkSalesReportDaily.Checked, chkSalesReportWeekly.Checked, chkSalesReportMonthly.Checked, chkSalesReportYearly.Checked, txtEmail1.Text,
                               dtmSalesReportTimeDaily.Value.Date + dtmSalesReportTimeDaily.Value.TimeOfDay,
                               dtmSalesReportWeekly.Value.Date + dtmSalesReportWeeklyTime.Value.TimeOfDay,
                               dtmSalesReportMonthly.Value.Date + dtmSalesReportMonthlyTime.Value.TimeOfDay,
                               dtmSalesReportYearly.Value.Date + dtmSalesReportYearlyTime.Value.TimeOfDay)

                lblProgress.Text = "Adding Tax Report"
                result += toDB("Tax Report", chkSTRDaily.Checked, chkSTRWeekly.Checked, chkSTRMonthly.Checked, chkSTRYearly.Checked, txtEmail3.Text,
                               dtmSalesTaxReportTimeDaily.Value.Date + dtmSalesTaxReportTimeDaily.Value.TimeOfDay,
                               dtmSalesTaxReportWeekly.Value.Date + dtmSalesTaxReportWeeklyTime.Value.TimeOfDay,
                               dtmSalesTaxReportMonthly.Value.Date + dtmSalesTaxReportMonthlyTime.Value.TimeOfDay,
                               dtmSalesTaxReportYearly.Value.Date + dtmSalesTaxReportYearlyTime.Value.TimeOfDay)
                lblProgress.Text = "Adding Inventory Report"
                result += toDB("Inventory Report", chkIRDaily.Checked, chkIRWeekly.Checked, chkIRMonthly.Checked, chkIRYearly.Checked, txtEmail2.Text,
                               dtmInventoryTimeDaily.Value.Date + dtmInventoryTimeDaily.Value.TimeOfDay,
                               dtmInventoryWeekly.Value.Date + dtmInventoryWeeklyTime.Value.TimeOfDay,
                               dtmInventoryMonthly.Value.Date + dtmInventoryMonthlyTime.Value.TimeOfDay,
                               dtmInventoryYearly.Value.Date + dtmInventoryYearlyTime.Value.TimeOfDay)
                lblProgress.Text = "Adding Deposit Report"
                result += toDB("Deposit Report", chkDRDaily.Checked, chkDRWeekly.Checked, chkDRMonthly.Checked, chkDRYearly.Checked, txtEmail4.Text,
                               dtmDepositTimeDaily.Value.Date + dtmDepositTimeDaily.Value.TimeOfDay,
                               dtmDepositWeekly.Value.Date + dtmDepositWeeklyTime.Value.TimeOfDay,
                               dtmDepositMonthly.Value.Date + dtmDepositMonthlyTime.Value.TimeOfDay,
                               dtmDepositYearly.Value.Date + dtmDepositYearlyTime.Value.TimeOfDay)
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
            lblInventoryReport.Text = dt(1)("strReportType").ToString
            lblSalesTaxReport.Text = dt(2)("strReportType").ToString
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

            dtmSalesReportTimeDaily.Value = Convert.ToDateTime(dt(0)("dtDailyReportDate").ToString())
            dtmSalesTaxReportTimeDaily.Value = Convert.ToDateTime(dt(2)("dtDailyReportDate").ToString())
            dtmInventoryTimeDaily.Value = Convert.ToDateTime(dt(1)("dtDailyReportDate").ToString())
            dtmDepositTimeDaily.Value = Convert.ToDateTime(dt(3)("dtDailyReportDate").ToString())

            dtmSalesReportWeekly.Value = Convert.ToDateTime(dt(0)("dtWeeklyReportDate").ToString())
            dtmSalesTaxReportWeekly.Value = Convert.ToDateTime(dt(2)("dtWeeklyReportDate").ToString())
            dtmInventoryWeekly.Value = Convert.ToDateTime(dt(1)("dtWeeklyReportDate").ToString())
            dtmDepositWeekly.Value = Convert.ToDateTime(dt(3)("dtWeeklyReportDate").ToString())
            dtmSalesReportWeeklyTime.Value = Convert.ToDateTime(dt(0)("dtWeeklyReportDate").ToString())
            dtmSalesTaxReportWeeklyTime.Value = Convert.ToDateTime(dt(2)("dtWeeklyReportDate").ToString())
            dtmInventoryWeeklyTime.Value = Convert.ToDateTime(dt(1)("dtWeeklyReportDate").ToString())
            dtmDepositWeeklyTime.Value = Convert.ToDateTime(dt(3)("dtWeeklyReportDate").ToString())

            dtmSalesReportMonthly.Value = Convert.ToDateTime(dt(0)("dtMonthlyReportDate").ToString())
            dtmSalesTaxReportMonthly.Value = Convert.ToDateTime(dt(2)("dtMonthlyReportDate").ToString())
            dtmInventoryMonthly.Value = Convert.ToDateTime(dt(1)("dtMonthlyReportDate").ToString())
            dtmDepositMonthly.Value = Convert.ToDateTime(dt(3)("dtMonthlyReportDate").ToString())
            dtmSalesReportMonthlyTime.Value = Convert.ToDateTime(dt(0)("dtMonthlyReportDate").ToString())
            dtmSalesTaxReportMonthlyTime.Value = Convert.ToDateTime(dt(2)("dtMonthlyReportDate").ToString())
            dtmInventoryMonthlyTime.Value = Convert.ToDateTime(dt(1)("dtMonthlyReportDate").ToString())
            dtmDepositMonthlyTime.Value = Convert.ToDateTime(dt(3)("dtMonthlyReportDate").ToString())

            dtmSalesReportYearly.Value = Convert.ToDateTime(dt(0)("dtYearlyReportDate").ToString())
            dtmSalesTaxReportYearly.Value = Convert.ToDateTime(dt(2)("dtYearlyReportDate").ToString())
            dtmInventoryYearly.Value = Convert.ToDateTime(dt(1)("dtYearlyReportDate").ToString())
            dtmDepositYearly.Value = Convert.ToDateTime(dt(3)("dtYearlyReportDate").ToString())
            dtmSalesReportYearlyTime.Value = Convert.ToDateTime(dt(0)("dtYearlyReportDate").ToString())
            dtmSalesTaxReportYearlyTime.Value = Convert.ToDateTime(dt(2)("dtYearlyReportDate").ToString())
            dtmInventoryYearlyTime.Value = Convert.ToDateTime(dt(1)("dtYearlyReportDate").ToString())
            dtmDepositYearlyTime.Value = Convert.ToDateTime(dt(3)("dtYearlyReportDate").ToString())

            ' Close the db
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub
End Class