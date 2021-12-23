# LocalPrinting
DIC Tutorial on winform printing using local reports

This is the code for the Dream.In.Code tutorial on printing using VB.NET and local reports.

Link to the tutorial:
http://www.dreamincode.net/forums/topic/374426-printing-data-using-local-reports/

=================
dreamincode.net tutorial backup ahead of decommissioning

 Posted 18 April 2015 - 01:32 PM 


[b]How to setup winform printing in 15 minutes [/b]

Printing your form's data can be a confusing adventure if you have not done it before, but when you step through the process it becomes a quick and easy addition to your work flow that it should only take fifteen minutes to setup the report, the report viewer, and have your data interact with the report.  This setup is fairly robust in that updating to the report requires minimal update changes to the main form or vice versa.

[img]http://i.imgur.com/j1f380I.png[/img]

[u]Tools:[/u]
Visual Studios 2013 Community Edition
(Previous VS would need to be on Professional addition or higher)

My design is pretty simple.  
[list][*]I want a form for the user to create data in a grid.  
[*]I want a report to show that data in a similar fashion for printing or exporting to pdf.  
[*]I want to be able to package the data from the user input and send it to the report to be gussied up in a pleasing manner.[/list]

There are four main moving parts we need to be concerned about when making a local RDLC to use in formatted printing.
1.  A data set that holds all the pertinent data for entry and the report.
2.  The main form for data entry into the data set.
3.  The report to format the user's data into a significantly useful hard copy for consumption.
4.  A print viewer to provide all the normal print controls a user is expecting and to show the report.


Create a basic winform project.  

[u][b]Data set[/b][/u]
To this project add a data set 
-> project properties -> add new -> common items -> data -> data set

Add a table for the data you want to display.  In this case I had an integer column, a string column, and a datetime column.

https://i.imgur.com/CxS942M.png

Rebuild for good measure and you should have no errors at this point.  You are now done with your dataset control for the project!  

[u][b]Main Form[/b][/u]
Head to your main form, and let's get the basics snapped down.

For this basic tutorial I just need a data grid to show my inputted data, two textboxes for data entry, a button to add, and some print options.

With my data set compiled I dropped an instance on the form from the tool box.

https://i.imgur.com/9jmi7RN.png

I plunked down a grid and set the data source to the data set object I just added, and the data member to the table name. (in the data grid's properties).

http://i.imgur.com/f9n4FHh.png

I added two text boxes for data entry, and a button to facilitate adding them to the data set.

Lastly I added a textbox for free form text entry for the report, and a button to trigger the report viewer.

https://i.imgur.com/YWUH26C.png 
	
In the code behind the 'add' button does some basic validation to make sure there is some sort of data entered, and when there is this adds it to the data set.  The grid, being just a UI object, is automatically updated.

[code]
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
[/code]

That is as complex as our form will go.


[u][b]The Report[/b][/u]
Let's add the report now to the project and get that hammered out.  My general design is I want the report to show our data from the data set and a bit of free form text.  Nothing crazy, but I need this data printed out!

Right click on your project
add new -> common items -> reporting -> report

https://i.imgur.com/p4sC5od.png


You should be presented with a pretty blank canvas.

http://i.imgur.com/yNYOkm3.png

First we will add a reference to our data set.  In the 'Report Data' panel click new-> data set

http://i.imgur.com/Wk7j7X6.png

In the data source drop down set it to our project's data set, and set the data set's table name.  

http://i.imgur.com/zxbRlUG.png

In the 'Report Data' add a new text parameter.

https://i.imgur.com/tXFA6Wl.png

From the report's toolbox drag a data table to the form.

http://i.imgur.com/rLsQKp1.png

Add a textbox as well to display our free formed text parameter.

Right click on the textbox and set the expression to the report parameter we created

https://i.imgur.com/dzVDVin.png

https://i.imgur.com/Vddkd9t.png

In the grid, in the second row, click the first cell.  A little icon appears and click on that.  This gives a list of available data set columns to fill in.  Click on the lValue, and repeat this for all three rows.

https://i.imgur.com/zPcEW5d.png

This will end up with a link to the column in the second row, and a static header (that you can change) in the first row.

https://i.imgur.com/p9QeBbA.png

This wraps up the report!  There are a plethora of options, formatting, etc that you can change on your report, but for this example we will not get too deep into the fun of report generation.

http://i.imgur.com/9Qt8JrU.png

[u][b]The Report Viewer[/b][/u]

The Report Viewer control is a powerful tool Microsoft has packed with all the expected controls for printing, print previewing, etc.  A small effort in setup, and providing the report parameters, and you can tap into this tool!

Create a new winform, and add a report viewer control to the form.  Set the report viewer's docking to fill.

In the upper right hand corner of the control is a small arrow. Expand that out and select our report we have created.  Now the report viewer knows where to look for a report to display.  You can programmatically change this as well to reuse this report viewer (and form) to take in different reports!

http://i.imgur.com/IzDcSJ6.png

The code is straight forward.  The report needs a copy of the data set that matches its report definition and parameters.

I start by overriding the new to take in these objects.  Using a for loop I can cycle through the parameter list (a dictionary), add those to the local report's "set parameter" method, and bind the data set to the report's data source.

Finally refresh the report so the data is reflected!

[code]
    '-- Create a custom 'new' by requiring a dataset object and parameters to be passed when ever it is created.
    Public Sub New(ByVal data As MyDataSEt, ByVal params As Dictionary(Of String, String))
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        '-- add each parameter to the local report's parameters.
        For Each temp In params
            Me.uxReportViewer.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter(temp.Key, temp.Value))
        Next

        '-- set the report's data source
        CType(uxReportViewer.LocalReport.DataSources(0).Value, System.Windows.Forms.BindingSource).DataSource = data
        '-- Specify the table name for the datasource
        CType(uxReportViewer.LocalReport.DataSources(0).Value, System.Windows.Forms.BindingSource).DataMember = "MyTable"

        '-- refresh the report to have the data take into effect
        Me.uxReportViewer.RefreshReport()
    End Sub
[/code]

That is all we need for the report viewer! Pretty quick.


Head back to the main form and setup a click event for our 'print' button.  In here we need to create an instance of the report viewer form, provide the data set, and any parameters for the report.  I find it best to use a dictionary(string, string) to hold the report parameter name (copy and paste that from the report RDLC).

[code]
    Private Sub uxButtonPrint_Click(sender As Object, e As EventArgs) Handles uxButtonPrint.Click
        Dim temp As PrintViewForm '-- create an instance of the print view form
        Dim dictParams As New Dictionary(Of String, String) '-- all the parameters the RDLC will need.

        Try
            '-- add the parameters here.. **use the specific parameter name as a key**
            dictParams.Add("ReportName", uxTextBoxReportName.Text.Trim)

            '-- pass the print view the dataset and parameter list
            temp = New PrintViewForm(dsData, dictParams)

            '-- show it on top
            temp.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
[/code]

Assuming everything has gone according to plan we can compile and run this without an issue!

http://i.imgur.com/4s2psGp.png

You can change how the report is viewed with the report viewer controls!

http://i.imgur.com/GoxDpPI.png


In the end printing data from your project should not be an arduous task, but something you are able to build and customize to make an extra polished effort for the client and user. 


[u][b]Advanced Formatting[/b][/u]: 

I am not a fan of the ugly report so I went and cleaned up the report display and added another parameter for a sub report title.

For the grid I cleaned up the grid headers, set them to bold, and aligned them properly.  For the data row I decided I liked to alternate colors and in the row's properties for 'Background Color' I set the expression to: 

[code]=IIF(RowNumber("DataSet1") Mod 2 = 0, "PaleTurquoise", "Transparent")[/code]

This means every other row is either going to be pale turquoise or transparent!  Nifty!

I cleaned up the report name, made it big and bold, and then created a sub report name to be a smaller font, italics, and set to a new report parameter name: ReportSubHeader.

Finally I added a report header (right click in the any white space outside of the report (but in the report designer), add header.  I added a textbox to the far righ, and in the expression set it to display the current page out of thee total number of pages.  The way a report is rendered this will updated automatically for each page we need!

[code]=Globals!PageNumber & " / " & Globals!TotalPages[/code]

https://i.imgur.com/0aG1OB0.png

https://i.imgur.com/0wI663Z.png

With a new report parameter I have to update the main form's "print option", and also collect that data from the user.

All I had to do was add a new textbox and make sure to update the dictionary of parameters!  
[spoiler]
 [code]Private Sub uxButtonPrint_Click(sender As Object, e As EventArgs) Handles uxButtonPrint.Click
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
 [/code]
[/spoiler]

https://i.imgur.com/iKDckfc.png

http://i.imgur.com/j1f380I.png

[u]Additional Fun[/u]
[list][*]bundling reports inside the executable
[*]formatting
[*]different reports on the same control
[*]make a cover sheet for your TPS reports
[/list]

Code repository: https://github.com/modi1231/LocalPrinting
