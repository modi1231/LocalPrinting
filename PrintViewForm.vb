Public Class PrintViewForm

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

    Private Sub PrintViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uxReportViewer.RefreshReport()
    End Sub
End Class