<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.uxReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MyDataSEt = New LocalPrinting.MyDataSEt()
        Me.MyTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MyDataSEt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxReportViewer
        '
        Me.uxReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MyTableBindingSource
        Me.uxReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.uxReportViewer.LocalReport.ReportEmbeddedResource = "LocalPrinting.MyReport.rdlc"
        Me.uxReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.uxReportViewer.Name = "uxReportViewer"
        Me.uxReportViewer.Size = New System.Drawing.Size(649, 419)
        Me.uxReportViewer.TabIndex = 0
        '
        'MyDataSEt
        '
        Me.MyDataSEt.DataSetName = "MyDataSEt"
        Me.MyDataSEt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyTableBindingSource
        '
        Me.MyTableBindingSource.DataMember = "MyTable"
        Me.MyTableBindingSource.DataSource = Me.MyDataSEt
        '
        'PrintViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 419)
        Me.Controls.Add(Me.uxReportViewer)
        Me.Name = "PrintViewForm"
        Me.Text = "PrintViewForm"
        CType(Me.MyDataSEt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uxReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MyTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MyDataSEt As LocalPrinting.MyDataSEt
End Class
