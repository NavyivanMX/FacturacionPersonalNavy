<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprasTimbres
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprasTimbres))
        Me.CBEMISOR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTDE = New System.Windows.Forms.DateTimePicker
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.TXTOBS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TXTCANT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTFAC = New System.Windows.Forms.TextBox
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(107, 12)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 1128
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1129
        Me.Label7.Text = "RFC Emisor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 1134
        Me.Label3.Text = "Fecha:"
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(382, 56)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1133
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 164)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(817, 289)
        Me.DGV.TabIndex = 1135
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.White
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(610, 13)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1136
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'TXTOBS
        '
        Me.TXTOBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTOBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTOBS.Location = New System.Drawing.Point(125, 118)
        Me.TXTOBS.MaxLength = 100
        Me.TXTOBS.Name = "TXTOBS"
        Me.TXTOBS.Size = New System.Drawing.Size(512, 22)
        Me.TXTOBS.TabIndex = 1137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 1138
        Me.Label5.Text = "Observación:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(41, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 16)
        Me.Label17.TabIndex = 1140
        Me.Label17.Text = "Cantidad:"
        '
        'TXTCANT
        '
        Me.TXTCANT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANT.Location = New System.Drawing.Point(125, 56)
        Me.TXTCANT.MaxLength = 10
        Me.TXTCANT.Name = "TXTCANT"
        Me.TXTCANT.Size = New System.Drawing.Size(139, 22)
        Me.TXTCANT.TabIndex = 1139
        Me.TXTCANT.Text = "0"
        Me.TXTCANT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1142
        Me.Label1.Text = "Factura:"
        '
        'TXTFAC
        '
        Me.TXTFAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTFAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFAC.Location = New System.Drawing.Point(125, 84)
        Me.TXTFAC.MaxLength = 10
        Me.TXTFAC.Name = "TXTFAC"
        Me.TXTFAC.Size = New System.Drawing.Size(139, 22)
        Me.TXTFAC.TabIndex = 1141
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ForeColor = System.Drawing.Color.White
        Me.BTNELIMINAR.Image = CType(resources.GetObject("BTNELIMINAR.Image"), System.Drawing.Image)
        Me.BTNELIMINAR.Location = New System.Drawing.Point(710, 12)
        Me.BTNELIMINAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNELIMINAR.TabIndex = 1143
        '
        'frmComprasTimbres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 465)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTFAC)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TXTCANT)
        Me.Controls.Add(Me.TXTOBS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTDE)
        Me.Controls.Add(Me.CBEMISOR)
        Me.Controls.Add(Me.Label7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComprasTimbres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras de Timbres"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TXTOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXTCANT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTFAC As System.Windows.Forms.TextBox
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
End Class
