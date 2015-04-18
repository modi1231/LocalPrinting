<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.myGrid = New System.Windows.Forms.DataGridView()
        Me.LValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEENTEREDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsData = New LocalPrinting.MyDataSEt()
        Me.uxTextBoxNumber = New System.Windows.Forms.TextBox()
        Me.uxTextboxText = New System.Windows.Forms.TextBox()
        Me.uxLblNumber = New System.Windows.Forms.Label()
        Me.uxLblText = New System.Windows.Forms.Label()
        Me.uxButtonAdd = New System.Windows.Forms.Button()
        Me.uxButtonPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uxTextBoxReportName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uxTextBoxReportSubHeader = New System.Windows.Forms.TextBox()
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myGrid
        '
        Me.myGrid.AutoGenerateColumns = False
        Me.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.myGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LValueDataGridViewTextBoxColumn, Me.SValueDataGridViewTextBoxColumn, Me.DATEENTEREDDataGridViewTextBoxColumn})
        Me.myGrid.DataMember = "MyTable"
        Me.myGrid.DataSource = Me.dsData
        Me.myGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.myGrid.Location = New System.Drawing.Point(0, 0)
        Me.myGrid.Name = "myGrid"
        Me.myGrid.Size = New System.Drawing.Size(487, 166)
        Me.myGrid.TabIndex = 0
        '
        'LValueDataGridViewTextBoxColumn
        '
        Me.LValueDataGridViewTextBoxColumn.DataPropertyName = "lValue"
        Me.LValueDataGridViewTextBoxColumn.HeaderText = "lValue"
        Me.LValueDataGridViewTextBoxColumn.Name = "LValueDataGridViewTextBoxColumn"
        '
        'SValueDataGridViewTextBoxColumn
        '
        Me.SValueDataGridViewTextBoxColumn.DataPropertyName = "sValue"
        Me.SValueDataGridViewTextBoxColumn.HeaderText = "sValue"
        Me.SValueDataGridViewTextBoxColumn.Name = "SValueDataGridViewTextBoxColumn"
        '
        'DATEENTEREDDataGridViewTextBoxColumn
        '
        Me.DATEENTEREDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ENTERED"
        Me.DATEENTEREDDataGridViewTextBoxColumn.HeaderText = "DATE_ENTERED"
        Me.DATEENTEREDDataGridViewTextBoxColumn.Name = "DATEENTEREDDataGridViewTextBoxColumn"
        '
        'dsData
        '
        Me.dsData.DataSetName = "MyDataSEt"
        Me.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uxTextBoxNumber
        '
        Me.uxTextBoxNumber.Location = New System.Drawing.Point(77, 198)
        Me.uxTextBoxNumber.Name = "uxTextBoxNumber"
        Me.uxTextBoxNumber.Size = New System.Drawing.Size(100, 20)
        Me.uxTextBoxNumber.TabIndex = 1
        '
        'uxTextboxText
        '
        Me.uxTextboxText.Location = New System.Drawing.Point(73, 236)
        Me.uxTextboxText.Name = "uxTextboxText"
        Me.uxTextboxText.Size = New System.Drawing.Size(100, 20)
        Me.uxTextboxText.TabIndex = 2
        '
        'uxLblNumber
        '
        Me.uxLblNumber.AutoSize = True
        Me.uxLblNumber.Location = New System.Drawing.Point(12, 202)
        Me.uxLblNumber.Name = "uxLblNumber"
        Me.uxLblNumber.Size = New System.Drawing.Size(44, 13)
        Me.uxLblNumber.TabIndex = 3
        Me.uxLblNumber.Text = "Number"
        '
        'uxLblText
        '
        Me.uxLblText.AutoSize = True
        Me.uxLblText.Location = New System.Drawing.Point(15, 236)
        Me.uxLblText.Name = "uxLblText"
        Me.uxLblText.Size = New System.Drawing.Size(28, 13)
        Me.uxLblText.TabIndex = 4
        Me.uxLblText.Text = "Text"
        '
        'uxButtonAdd
        '
        Me.uxButtonAdd.Location = New System.Drawing.Point(98, 271)
        Me.uxButtonAdd.Name = "uxButtonAdd"
        Me.uxButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.uxButtonAdd.TabIndex = 5
        Me.uxButtonAdd.Text = "Add"
        Me.uxButtonAdd.UseVisualStyleBackColor = True
        '
        'uxButtonPrint
        '
        Me.uxButtonPrint.Location = New System.Drawing.Point(400, 271)
        Me.uxButtonPrint.Name = "uxButtonPrint"
        Me.uxButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.uxButtonPrint.TabIndex = 6
        Me.uxButtonPrint.Text = "Print"
        Me.uxButtonPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Report Name"
        '
        'uxTextBoxReportName
        '
        Me.uxTextBoxReportName.Location = New System.Drawing.Point(322, 199)
        Me.uxTextBoxReportName.Name = "uxTextBoxReportName"
        Me.uxTextBoxReportName.Size = New System.Drawing.Size(153, 20)
        Me.uxTextBoxReportName.TabIndex = 8
        Me.uxTextBoxReportName.Text = "Contoso Data Added Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Report Sub Header"
        '
        'uxTextBoxReportSubHeader
        '
        Me.uxTextBoxReportSubHeader.Location = New System.Drawing.Point(322, 233)
        Me.uxTextBoxReportSubHeader.Name = "uxTextBoxReportSubHeader"
        Me.uxTextBoxReportSubHeader.Size = New System.Drawing.Size(153, 20)
        Me.uxTextBoxReportSubHeader.TabIndex = 10
        Me.uxTextBoxReportSubHeader.Text = "Snazzy Slogan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 325)
        Me.Controls.Add(Me.uxTextBoxReportSubHeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.uxTextBoxReportName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uxButtonPrint)
        Me.Controls.Add(Me.uxButtonAdd)
        Me.Controls.Add(Me.uxLblText)
        Me.Controls.Add(Me.uxLblNumber)
        Me.Controls.Add(Me.uxTextboxText)
        Me.Controls.Add(Me.uxTextBoxNumber)
        Me.Controls.Add(Me.myGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myGrid As System.Windows.Forms.DataGridView
    Friend WithEvents uxTextBoxNumber As System.Windows.Forms.TextBox
    Friend WithEvents uxTextboxText As System.Windows.Forms.TextBox
    Friend WithEvents uxLblNumber As System.Windows.Forms.Label
    Friend WithEvents uxLblText As System.Windows.Forms.Label
    Friend WithEvents uxButtonAdd As System.Windows.Forms.Button
    Friend WithEvents uxButtonPrint As System.Windows.Forms.Button
    Friend WithEvents dsData As LocalPrinting.MyDataSEt
    Friend WithEvents LValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEENTEREDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uxTextBoxReportName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uxTextBoxReportSubHeader As System.Windows.Forms.TextBox

End Class
