<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteFacturas))
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.CBNEG = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CBEMISOR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTHASTA = New System.Windows.Forms.DateTimePicker
        Me.DTDE = New System.Windows.Forms.DateTimePicker
        Me.LBLS = New System.Windows.Forms.Label
        Me.LBLI = New System.Windows.Forms.Label
        Me.LBLT = New System.Windows.Forms.Label
        Me.LBLRISR = New System.Windows.Forms.Label
        Me.LBLRIVA = New System.Windows.Forms.Label
        Me.LBLDE = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LBLIEPS = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LBLS16 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BTNMAIL = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 148)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Size = New System.Drawing.Size(1071, 458)
        Me.DGV.TabIndex = 3
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(95, 76)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(517, 24)
        Me.CBNEG.TabIndex = 121
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Negocio"
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(95, 17)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "RFC Emisor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 1111
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 1110
        Me.Label3.Text = "De:"
        '
        'DTHASTA
        '
        Me.DTHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(473, 116)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(126, 26)
        Me.DTHASTA.TabIndex = 1109
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(194, 116)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1108
        '
        'LBLS
        '
        Me.LBLS.AutoSize = True
        Me.LBLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLS.Location = New System.Drawing.Point(22, 646)
        Me.LBLS.Name = "LBLS"
        Me.LBLS.Size = New System.Drawing.Size(57, 16)
        Me.LBLS.TabIndex = 1114
        Me.LBLS.Text = "TOTAL"
        '
        'LBLI
        '
        Me.LBLI.AutoSize = True
        Me.LBLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLI.Location = New System.Drawing.Point(312, 646)
        Me.LBLI.Name = "LBLI"
        Me.LBLI.Size = New System.Drawing.Size(57, 16)
        Me.LBLI.TabIndex = 1115
        Me.LBLI.Text = "TOTAL"
        '
        'LBLT
        '
        Me.LBLT.AutoSize = True
        Me.LBLT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLT.Location = New System.Drawing.Point(555, 646)
        Me.LBLT.Name = "LBLT"
        Me.LBLT.Size = New System.Drawing.Size(57, 16)
        Me.LBLT.TabIndex = 1116
        Me.LBLT.Text = "TOTAL"
        '
        'LBLRISR
        '
        Me.LBLRISR.AutoSize = True
        Me.LBLRISR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRISR.Location = New System.Drawing.Point(751, 646)
        Me.LBLRISR.Name = "LBLRISR"
        Me.LBLRISR.Size = New System.Drawing.Size(57, 16)
        Me.LBLRISR.TabIndex = 1117
        Me.LBLRISR.Text = "TOTAL"
        '
        'LBLRIVA
        '
        Me.LBLRIVA.AutoSize = True
        Me.LBLRIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRIVA.Location = New System.Drawing.Point(917, 646)
        Me.LBLRIVA.Name = "LBLRIVA"
        Me.LBLRIVA.Size = New System.Drawing.Size(57, 16)
        Me.LBLRIVA.TabIndex = 1118
        Me.LBLRIVA.Text = "TOTAL"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(8, 48)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(604, 22)
        Me.LBLDE.TabIndex = 123
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(747, 618)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1123
        Me.Label1.Text = "Ret ISR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(914, 618)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1122
        Me.Label2.Text = "Ret IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(555, 618)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 1121
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 618)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 1120
        Me.Label6.Text = "IVA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 618)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 1119
        Me.Label8.Text = "SubTotal 0%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(437, 618)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 1126
        Me.Label10.Text = "Ieps"
        '
        'LBLIEPS
        '
        Me.LBLIEPS.AutoSize = True
        Me.LBLIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIEPS.Location = New System.Drawing.Point(437, 646)
        Me.LBLIEPS.Name = "LBLIEPS"
        Me.LBLIEPS.Size = New System.Drawing.Size(57, 16)
        Me.LBLIEPS.TabIndex = 1125
        Me.LBLIEPS.Text = "TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(168, 618)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 1128
        Me.Label11.Text = "SubTotal 16%"
        '
        'LBLS16
        '
        Me.LBLS16.AutoSize = True
        Me.LBLS16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLS16.Location = New System.Drawing.Point(168, 646)
        Me.LBLS16.Name = "LBLS16"
        Me.LBLS16.Size = New System.Drawing.Size(57, 16)
        Me.LBLS16.TabIndex = 1127
        Me.LBLS16.Text = "TOTAL"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.FacturacionPersonal.My.Resources.Resources.DUPLICAR64
        Me.Button3.Location = New System.Drawing.Point(1003, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 1130
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(826, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 1129
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BTNMAIL
        '
        Me.BTNMAIL.BackColor = System.Drawing.SystemColors.Control
        Me.BTNMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAIL.ForeColor = System.Drawing.Color.White
        Me.BTNMAIL.Image = Global.FacturacionPersonal.My.Resources.Resources.EMAIL
        Me.BTNMAIL.Location = New System.Drawing.Point(917, 13)
        Me.BTNMAIL.Name = "BTNMAIL"
        Me.BTNMAIL.Size = New System.Drawing.Size(80, 80)
        Me.BTNMAIL.TabIndex = 1124
        Me.BTNMAIL.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FacturacionPersonal.My.Resources.Resources.xeyes2
        Me.Button1.Location = New System.Drawing.Point(644, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1113
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNIMPRIMIR.Image = CType(resources.GetObject("BTNIMPRIMIR.Image"), System.Drawing.Image)
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(735, 12)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(80, 80)
        Me.BTNIMPRIMIR.TabIndex = 1112
        Me.BTNIMPRIMIR.Text = "Factura"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'frmReporteFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 671)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LBLS16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLIEPS)
        Me.Controls.Add(Me.BTNMAIL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLRIVA)
        Me.Controls.Add(Me.LBLRISR)
        Me.Controls.Add(Me.LBLT)
        Me.Controls.Add(Me.LBLI)
        Me.Controls.Add(Me.LBLS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTHASTA)
        Me.Controls.Add(Me.DTDE)
        Me.Controls.Add(Me.CBNEG)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LBLDE)
        Me.Controls.Add(Me.CBEMISOR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Facturas"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents CBNEG As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTHASTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLS As System.Windows.Forms.Label
    Friend WithEvents LBLI As System.Windows.Forms.Label
    Friend WithEvents LBLT As System.Windows.Forms.Label
    Friend WithEvents LBLRISR As System.Windows.Forms.Label
    Friend WithEvents LBLRIVA As System.Windows.Forms.Label
    Friend WithEvents LBLDE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTNMAIL As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LBLIEPS As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LBLS16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
