<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcel2PDFXML
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTNPDF = New System.Windows.Forms.Button()
        Me.BTNXML = New System.Windows.Forms.Button()
        Me.TXTHOJA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTNRUTAXML = New System.Windows.Forms.Button()
        Me.BTNRUTAPDF = New System.Windows.Forms.Button()
        Me.LBLRXML = New System.Windows.Forms.Label()
        Me.LBLRPDF = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBREG = New System.Windows.Forms.ComboBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNPDF
        '
        Me.BTNPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNPDF.BackColor = System.Drawing.Color.White
        Me.BTNPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPDF.ForeColor = System.Drawing.Color.White
        Me.BTNPDF.Location = New System.Drawing.Point(967, 13)
        Me.BTNPDF.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNPDF.Name = "BTNPDF"
        Me.BTNPDF.Size = New System.Drawing.Size(107, 98)
        Me.BTNPDF.TabIndex = 1506
        Me.BTNPDF.UseVisualStyleBackColor = False
        '
        'BTNXML
        '
        Me.BTNXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNXML.BackColor = System.Drawing.Color.White
        Me.BTNXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNXML.ForeColor = System.Drawing.Color.White
        Me.BTNXML.Location = New System.Drawing.Point(840, 12)
        Me.BTNXML.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNXML.Name = "BTNXML"
        Me.BTNXML.Size = New System.Drawing.Size(107, 98)
        Me.BTNXML.TabIndex = 1505
        Me.BTNXML.UseVisualStyleBackColor = False
        '
        'TXTHOJA
        '
        Me.TXTHOJA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHOJA.Location = New System.Drawing.Point(76, 20)
        Me.TXTHOJA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTHOJA.MaxLength = 50
        Me.TXTHOJA.Name = "TXTHOJA"
        Me.TXTHOJA.Size = New System.Drawing.Size(267, 29)
        Me.TXTHOJA.TabIndex = 1503
        Me.TXTHOJA.Text = "Hoja1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 22)
        Me.Label1.TabIndex = 1504
        Me.Label1.Text = "Hoja"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.White
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.ForeColor = System.Drawing.Color.White
        Me.BTNBUSCAR.Location = New System.Drawing.Point(663, 13)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(107, 98)
        Me.BTNBUSCAR.TabIndex = 1502
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.Location = New System.Drawing.Point(13, 138)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.Size = New System.Drawing.Size(1061, 524)
        Me.DGV.TabIndex = 1501
        '
        'BTNRUTAXML
        '
        Me.BTNRUTAXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNRUTAXML.BackColor = System.Drawing.Color.White
        Me.BTNRUTAXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRUTAXML.ForeColor = System.Drawing.Color.White
        Me.BTNRUTAXML.Location = New System.Drawing.Point(17, 58)
        Me.BTNRUTAXML.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNRUTAXML.Name = "BTNRUTAXML"
        Me.BTNRUTAXML.Size = New System.Drawing.Size(69, 32)
        Me.BTNRUTAXML.TabIndex = 1507
        Me.BTNRUTAXML.UseVisualStyleBackColor = False
        '
        'BTNRUTAPDF
        '
        Me.BTNRUTAPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNRUTAPDF.BackColor = System.Drawing.Color.White
        Me.BTNRUTAPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRUTAPDF.ForeColor = System.Drawing.Color.White
        Me.BTNRUTAPDF.Location = New System.Drawing.Point(17, 98)
        Me.BTNRUTAPDF.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNRUTAPDF.Name = "BTNRUTAPDF"
        Me.BTNRUTAPDF.Size = New System.Drawing.Size(69, 32)
        Me.BTNRUTAPDF.TabIndex = 1508
        Me.BTNRUTAPDF.UseVisualStyleBackColor = False
        '
        'LBLRXML
        '
        Me.LBLRXML.AutoSize = True
        Me.LBLRXML.BackColor = System.Drawing.Color.Transparent
        Me.LBLRXML.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRXML.Location = New System.Drawing.Point(104, 64)
        Me.LBLRXML.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLRXML.Name = "LBLRXML"
        Me.LBLRXML.Size = New System.Drawing.Size(96, 22)
        Me.LBLRXML.TabIndex = 1509
        Me.LBLRXML.Text = "Ruta XML"
        '
        'LBLRPDF
        '
        Me.LBLRPDF.AutoSize = True
        Me.LBLRPDF.BackColor = System.Drawing.Color.Transparent
        Me.LBLRPDF.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRPDF.Location = New System.Drawing.Point(104, 104)
        Me.LBLRPDF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLRPDF.Name = "LBLRPDF"
        Me.LBLRPDF.Size = New System.Drawing.Size(96, 22)
        Me.LBLRPDF.TabIndex = 1510
        Me.LBLRPDF.Text = "Ruta PDF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 1511
        Me.Label2.Text = "Renglones"
        '
        'CBREG
        '
        Me.CBREG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBREG.FormattingEnabled = True
        Me.CBREG.Items.AddRange(New Object() {"Todos", "5", "10", "50", "100"})
        Me.CBREG.Location = New System.Drawing.Point(499, 24)
        Me.CBREG.Name = "CBREG"
        Me.CBREG.Size = New System.Drawing.Size(121, 24)
        Me.CBREG.TabIndex = 1512
        '
        'frmExcel2PDFXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 675)
        Me.Controls.Add(Me.CBREG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLRPDF)
        Me.Controls.Add(Me.LBLRXML)
        Me.Controls.Add(Me.BTNRUTAPDF)
        Me.Controls.Add(Me.BTNRUTAXML)
        Me.Controls.Add(Me.BTNPDF)
        Me.Controls.Add(Me.BTNXML)
        Me.Controls.Add(Me.TXTHOJA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.DGV)
        Me.Name = "frmExcel2PDFXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excel a PDF y XML"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNPDF As Button
    Friend WithEvents BTNXML As Button
    Friend WithEvents TXTHOJA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNBUSCAR As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BTNRUTAXML As Button
    Friend WithEvents BTNRUTAPDF As Button
    Friend WithEvents LBLRXML As Label
    Friend WithEvents LBLRPDF As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBREG As ComboBox
End Class
