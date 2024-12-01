<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesgloseFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesgloseFacturacion))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTHASTA = New System.Windows.Forms.DateTimePicker
        Me.DTDE = New System.Windows.Forms.DateTimePicker
        Me.CBNEG = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LBLDE = New System.Windows.Forms.Label
        Me.CBEMISOR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.BTNMAIL = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button
        Me.LBLA = New System.Windows.Forms.Label
        Me.LBLB = New System.Windows.Forms.Label
        Me.LBLE = New System.Windows.Forms.Label
        Me.LBLD = New System.Windows.Forms.Label
        Me.LBLF = New System.Windows.Forms.Label
        Me.LBLC = New System.Windows.Forms.Label
        Me.LBLI = New System.Windows.Forms.Label
        Me.LBLH = New System.Windows.Forms.Label
        Me.LBLG = New System.Windows.Forms.Label
        Me.LBLL = New System.Windows.Forms.Label
        Me.LBLK = New System.Windows.Forms.Label
        Me.LBLJ = New System.Windows.Forms.Label
        Me.LBLO = New System.Windows.Forms.Label
        Me.LBLN = New System.Windows.Forms.Label
        Me.LBLM = New System.Windows.Forms.Label
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 1138
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 1137
        Me.Label3.Text = "De:"
        '
        'DTHASTA
        '
        Me.DTHASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHASTA.Location = New System.Drawing.Point(469, 111)
        Me.DTHASTA.Name = "DTHASTA"
        Me.DTHASTA.Size = New System.Drawing.Size(126, 26)
        Me.DTHASTA.TabIndex = 1136
        '
        'DTDE
        '
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(190, 111)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 1135
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(91, 71)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(595, 24)
        Me.CBNEG.TabIndex = 1131
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 1134
        Me.Label9.Text = "Negocio"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(4, 43)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(682, 22)
        Me.LBLDE.TabIndex = 1133
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(91, 12)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(234, 24)
        Me.CBEMISOR.TabIndex = 1130
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1132
        Me.Label7.Text = "RFC Emisor"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(8, 164)
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
        Me.DGV.Size = New System.Drawing.Size(992, 391)
        Me.DGV.TabIndex = 1129
        '
        'BTNMAIL
        '
        Me.BTNMAIL.BackColor = System.Drawing.SystemColors.Control
        Me.BTNMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAIL.ForeColor = System.Drawing.Color.White
        Me.BTNMAIL.Image = Global.FacturacionPersonal.My.Resources.Resources.EMAIL
        Me.BTNMAIL.Location = New System.Drawing.Point(920, 15)
        Me.BTNMAIL.Name = "BTNMAIL"
        Me.BTNMAIL.Size = New System.Drawing.Size(80, 80)
        Me.BTNMAIL.TabIndex = 1151
        Me.BTNMAIL.UseVisualStyleBackColor = False
        Me.BTNMAIL.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FacturacionPersonal.My.Resources.Resources.xeyes2
        Me.Button1.Location = New System.Drawing.Point(716, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 1140
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.White
        Me.BTNIMPRIMIR.Image = CType(resources.GetObject("BTNIMPRIMIR.Image"), System.Drawing.Image)
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(821, 14)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(80, 80)
        Me.BTNIMPRIMIR.TabIndex = 1139
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'LBLA
        '
        Me.LBLA.AutoSize = True
        Me.LBLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLA.Location = New System.Drawing.Point(12, 573)
        Me.LBLA.Name = "LBLA"
        Me.LBLA.Size = New System.Drawing.Size(90, 16)
        Me.LBLA.TabIndex = 1152
        Me.LBLA.Text = "RFC Emisor"
        '
        'LBLB
        '
        Me.LBLB.AutoSize = True
        Me.LBLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLB.Location = New System.Drawing.Point(12, 600)
        Me.LBLB.Name = "LBLB"
        Me.LBLB.Size = New System.Drawing.Size(90, 16)
        Me.LBLB.TabIndex = 1153
        Me.LBLB.Text = "RFC Emisor"
        '
        'LBLE
        '
        Me.LBLE.AutoSize = True
        Me.LBLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLE.Location = New System.Drawing.Point(246, 627)
        Me.LBLE.Name = "LBLE"
        Me.LBLE.Size = New System.Drawing.Size(90, 16)
        Me.LBLE.TabIndex = 1155
        Me.LBLE.Text = "RFC Emisor"
        '
        'LBLD
        '
        Me.LBLD.AutoSize = True
        Me.LBLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLD.Location = New System.Drawing.Point(246, 600)
        Me.LBLD.Name = "LBLD"
        Me.LBLD.Size = New System.Drawing.Size(90, 16)
        Me.LBLD.TabIndex = 1154
        Me.LBLD.Text = "RFC Emisor"
        '
        'LBLF
        '
        Me.LBLF.AutoSize = True
        Me.LBLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLF.Location = New System.Drawing.Point(484, 573)
        Me.LBLF.Name = "LBLF"
        Me.LBLF.Size = New System.Drawing.Size(90, 16)
        Me.LBLF.TabIndex = 1157
        Me.LBLF.Text = "RFC Emisor"
        '
        'LBLC
        '
        Me.LBLC.AutoSize = True
        Me.LBLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLC.Location = New System.Drawing.Point(246, 573)
        Me.LBLC.Name = "LBLC"
        Me.LBLC.Size = New System.Drawing.Size(90, 16)
        Me.LBLC.TabIndex = 1156
        Me.LBLC.Text = "RFC Emisor"
        '
        'LBLI
        '
        Me.LBLI.AutoSize = True
        Me.LBLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLI.Location = New System.Drawing.Point(733, 572)
        Me.LBLI.Name = "LBLI"
        Me.LBLI.Size = New System.Drawing.Size(90, 16)
        Me.LBLI.TabIndex = 1160
        Me.LBLI.Text = "RFC Emisor"
        '
        'LBLH
        '
        Me.LBLH.AutoSize = True
        Me.LBLH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLH.Location = New System.Drawing.Point(484, 627)
        Me.LBLH.Name = "LBLH"
        Me.LBLH.Size = New System.Drawing.Size(90, 16)
        Me.LBLH.TabIndex = 1159
        Me.LBLH.Text = "RFC Emisor"
        '
        'LBLG
        '
        Me.LBLG.AutoSize = True
        Me.LBLG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLG.Location = New System.Drawing.Point(484, 600)
        Me.LBLG.Name = "LBLG"
        Me.LBLG.Size = New System.Drawing.Size(90, 16)
        Me.LBLG.TabIndex = 1158
        Me.LBLG.Text = "RFC Emisor"
        '
        'LBLL
        '
        Me.LBLL.AutoSize = True
        Me.LBLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLL.Location = New System.Drawing.Point(905, 558)
        Me.LBLL.Name = "LBLL"
        Me.LBLL.Size = New System.Drawing.Size(90, 16)
        Me.LBLL.TabIndex = 1163
        Me.LBLL.Text = "RFC Emisor"
        Me.LBLL.Visible = False
        '
        'LBLK
        '
        Me.LBLK.AutoSize = True
        Me.LBLK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLK.Location = New System.Drawing.Point(733, 626)
        Me.LBLK.Name = "LBLK"
        Me.LBLK.Size = New System.Drawing.Size(90, 16)
        Me.LBLK.TabIndex = 1162
        Me.LBLK.Text = "RFC Emisor"
        '
        'LBLJ
        '
        Me.LBLJ.AutoSize = True
        Me.LBLJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJ.Location = New System.Drawing.Point(733, 599)
        Me.LBLJ.Name = "LBLJ"
        Me.LBLJ.Size = New System.Drawing.Size(90, 16)
        Me.LBLJ.TabIndex = 1161
        Me.LBLJ.Text = "RFC Emisor"
        '
        'LBLO
        '
        Me.LBLO.AutoSize = True
        Me.LBLO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLO.Location = New System.Drawing.Point(905, 626)
        Me.LBLO.Name = "LBLO"
        Me.LBLO.Size = New System.Drawing.Size(90, 16)
        Me.LBLO.TabIndex = 1166
        Me.LBLO.Text = "RFC Emisor"
        Me.LBLO.Visible = False
        '
        'LBLN
        '
        Me.LBLN.AutoSize = True
        Me.LBLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLN.Location = New System.Drawing.Point(905, 600)
        Me.LBLN.Name = "LBLN"
        Me.LBLN.Size = New System.Drawing.Size(90, 16)
        Me.LBLN.TabIndex = 1165
        Me.LBLN.Text = "RFC Emisor"
        Me.LBLN.Visible = False
        '
        'LBLM
        '
        Me.LBLM.AutoSize = True
        Me.LBLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLM.Location = New System.Drawing.Point(905, 573)
        Me.LBLM.Name = "LBLM"
        Me.LBLM.Size = New System.Drawing.Size(90, 16)
        Me.LBLM.TabIndex = 1164
        Me.LBLM.Text = "RFC Emisor"
        Me.LBLM.Visible = False
        '
        'frmDesgloseFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 661)
        Me.Controls.Add(Me.LBLO)
        Me.Controls.Add(Me.LBLN)
        Me.Controls.Add(Me.LBLM)
        Me.Controls.Add(Me.LBLL)
        Me.Controls.Add(Me.LBLK)
        Me.Controls.Add(Me.LBLJ)
        Me.Controls.Add(Me.LBLI)
        Me.Controls.Add(Me.LBLH)
        Me.Controls.Add(Me.LBLG)
        Me.Controls.Add(Me.LBLF)
        Me.Controls.Add(Me.LBLC)
        Me.Controls.Add(Me.LBLE)
        Me.Controls.Add(Me.LBLD)
        Me.Controls.Add(Me.LBLB)
        Me.Controls.Add(Me.LBLA)
        Me.Controls.Add(Me.BTNMAIL)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDesgloseFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglose de Facturación"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNMAIL As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTHASTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBNEG As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLDE As System.Windows.Forms.Label
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents LBLA As System.Windows.Forms.Label
    Friend WithEvents LBLB As System.Windows.Forms.Label
    Friend WithEvents LBLE As System.Windows.Forms.Label
    Friend WithEvents LBLD As System.Windows.Forms.Label
    Friend WithEvents LBLF As System.Windows.Forms.Label
    Friend WithEvents LBLC As System.Windows.Forms.Label
    Friend WithEvents LBLI As System.Windows.Forms.Label
    Friend WithEvents LBLH As System.Windows.Forms.Label
    Friend WithEvents LBLG As System.Windows.Forms.Label
    Friend WithEvents LBLL As System.Windows.Forms.Label
    Friend WithEvents LBLK As System.Windows.Forms.Label
    Friend WithEvents LBLJ As System.Windows.Forms.Label
    Friend WithEvents LBLO As System.Windows.Forms.Label
    Friend WithEvents LBLN As System.Windows.Forms.Label
    Friend WithEvents LBLM As System.Windows.Forms.Label
End Class
