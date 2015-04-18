Public Class Form1

    Private Sub uxButtonAdd_Click(sender As Object, e As EventArgs) Handles uxButtonAdd.Click
        Dim lTemp As Int32 = 0

        '-- 1.0 Validation of data.  Make sure it is there or do not insert it.
        If uxTextBoxNumber.Text.Trim = String.Empty OrElse uxTextboxText.Text.Trim = String.Empty Then
            MsgBox("Please fill in Number and Text") '-- Let the user know there is a problem.
            Exit Sub '-- stop processing the click event.
        End If

        '-- 2.0 Add values to the dataset
        Try
            '-- convert the string into a number variable. (validation)
            Int32.TryParse(uxTextBoxNumber.Text.Trim, lTemp)

            '-- add both to the dataset's row
            dsData.MyTable.AddMyTableRow(lTemp, uxTextboxText.Text.Trim, DateTime.Now)

            '--clear the text
            ClearFields()

            '-- reset the focus.
            uxTextBoxNumber.Focus()
        Catch ex As Exception
            '-- if there is a problem notify the user
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub uxButtonPrint_Click(sender As Object, e As EventArgs) Handles uxButtonPrint.Click
        Dim temp As PrintViewForm '-- create an instance of the print view form
        Dim dictParams As New Dictionary(Of String, String) '-- all the parameters the RDLC will need.

        Try
            '-- add the parameters here.. **use the specific paraemter name as a key**
            dictParams.Add("ReportName", uxTextBoxReportName.Text.Trim)

            '--!! new parameter !!
            dictParams.Add("ReportSubHeader", uxTextBoxReportSubHeader.Text.Trim)

            '-- pass the print view the dataset and parameter list
            temp = New PrintViewForm(dsData, dictParams)

            '-- show it on top
            temp.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        uxTextBoxNumber.Text = String.Empty
        uxTextboxText.Text = String.Empty
    End Sub
End Class
