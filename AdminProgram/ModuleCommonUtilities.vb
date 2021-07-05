Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.Net.Mail

Module ModuleCommonUtilities

    Sub CreateWordDocument()

        ' START CITATION-----------------------
        ' CITE: https://support.microsoft.com/en-us/topic/how-to-automate-word-from-visual-basic-net-to-create-a-new-document-b954608e-2fb5-06d1-d747-e44724762417

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = False
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "Heading 1"
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Heading 2"
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim r As Integer, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 3
            For c = 1 To 5
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter()
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.InsertParagraphBefore()
        oPara4.Range.Text = "And here's another table:"
        oPara4.Format.SpaceAfter = 24
        oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 5
            For c = 1 To 2
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        Pos = oWord.InchesToPoints(7)
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        Do
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng.ParagraphFormat.SpaceAfter = 6
            oRng.InsertAfter("A line of text")
            oRng.InsertParagraphAfter()
        Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertAfter("We're now on page 2. Here's my chart:")
        oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject(
            ClassType:="MSGraph.Chart.8", FileName _
            :="", LinkToFile:=False, DisplayAsIcon:=False)
        oChart = oShape.OLEFormat.Object
        oChart.charttype = 4 'xlLine = 4
        oChart.Application.Update()
        oChart.Application.Quit()
        'If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        oShape.Width = oWord.InchesToPoints(6.25)
        oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.InsertAfter("THE END.")

        'All done. Close this form.
        'MsgBox(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\Form.docx")
        oDoc.SaveAs2(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\Form.docx")
        oDoc.Close()
        oWord.Quit()

        'Me.Close()

        ' END CITATION-----------------------

    End Sub

    ' Open a form and close the current form
    Public Function OpenFormKillParent(ByRef frmSelf As Form, ByVal frmToOpen As Form) As DialogResult

        ' Init variables
        Dim dlgResult As DialogResult

        ' Make new form
        frmToOpen.Show()

        ' Kill self
        frmSelf.Close()

        ' Return result
        Return dlgResult

    End Function

    ' Send Mail Function copied from: http://vb.net-informations.com/communications/vb.net_smtp_mail.htm
    Public Function SendMail(strTO As String, strFrom As String, strSubject As String, strBody As String, strUsername As String, strPassword As String, strAttachmentPath As String)
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()

            ' Add Email ID and Password of gmail account.
            ' This will be used to send the email from
            ' In this GMail account one need to  turn on from setting -> Allow less Secure App

            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            ' Citation start: https://stackoverflow.com/questions/13424096/contact-form-is-not-sending-email-to-my-gmail-acount
            SmtpServer.EnableSsl = True
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New Net.NetworkCredential(strUsername, strPassword)
            ' Citation end.
            mail = New MailMessage()
            mail.From = New MailAddress(strFrom)
            mail.To.Add(strTO)
            mail.Subject = strSubject
            mail.Body = strBody
            ' Add Attachment
            ' Code from: http://vb.net-informations.com/communications/vb-email-attachment.htm
            ' Reference for excel: https://www.tutorialspoint.com/vb.net/vb.net_excel_sheet.htm
            ' Reference for PDF And Easy Report RDLC: https://www.youtube.com/watch?v=HX8hG29s3r8
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(strAttachmentPath)
            mail.Attachments.Add(attachment)

            SmtpServer.Send(mail)
            MsgBox("mail send")
            Return 0
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.Message.Length
        End Try
    End Function

End Module
