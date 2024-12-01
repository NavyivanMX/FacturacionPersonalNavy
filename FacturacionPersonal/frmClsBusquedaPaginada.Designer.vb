<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClsBusquedaPaginada
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.LBL2 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.LBL1 = New System.Windows.Forms.Label
        Me.TXTBUS = New System.Windows.Forms.TextBox
        Me.TXTMOSTRAR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBLNP = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.BTNFF = New System.Windows.Forms.Button
        Me.BTNSIG = New System.Windows.Forms.Button
        Me.BTNANT = New System.Windows.Forms.Button
        Me.BTNRR = New System.Windows.Forms.Button
        Me.BTNACEPTAR = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL2.Location = New System.Drawing.Point(14, 437)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(101, 20)
        Me.LBL2.TabIndex = 433
        Me.LBL2.Text = "0 Registros"
        Me.LBL2.Visible = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Location = New System.Drawing.Point(12, 102)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.Size = New System.Drawing.Size(896, 355)
        Me.DGV.TabIndex = 432
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.Location = New System.Drawing.Point(6, 20)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(453, 20)
        Me.LBL1.TabIndex = 430
        Me.LBL1.Text = "ESCRIBA EL NOMBRE PARA INICIAR LA BUSQUEDA"
        '
        'TXTBUS
        '
        Me.TXTBUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUS.Location = New System.Drawing.Point(6, 43)
        Me.TXTBUS.Name = "TXTBUS"
        Me.TXTBUS.Size = New System.Drawing.Size(796, 22)
        Me.TXTBUS.TabIndex = 429
        '
        'TXTMOSTRAR
        '
        Me.TXTMOSTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOSTRAR.Location = New System.Drawing.Point(824, 43)
        Me.TXTMOSTRAR.Name = "TXTMOSTRAR"
        Me.TXTMOSTRAR.Size = New System.Drawing.Size(66, 22)
        Me.TXTMOSTRAR.TabIndex = 434
        Me.TXTMOSTRAR.Text = "50"
        Me.TXTMOSTRAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(820, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 435
        Me.Label1.Text = "Mostrar"
        '
        'LBLNP
        '
        Me.LBLNP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNP.Location = New System.Drawing.Point(287, 537)
        Me.LBLNP.Name = "LBLNP"
        Me.LBLNP.Size = New System.Drawing.Size(300, 20)
        Me.LBLNP.TabIndex = 1302
        Me.LBLNP.Text = "0 Registros"
        Me.LBLNP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GB
        '
        Me.GB.Controls.Add(Me.TXTMOSTRAR)
        Me.GB.Controls.Add(Me.TXTBUS)
        Me.GB.Controls.Add(Me.LBL1)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB.Location = New System.Drawing.Point(12, 12)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(896, 84)
        Me.GB.TabIndex = 1303
        Me.GB.TabStop = False
        '
        'BTNFF
        '
        Me.BTNFF.BackColor = System.Drawing.SystemColors.Control
        Me.BTNFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFF.ForeColor = System.Drawing.Color.White
        Me.BTNFF.Image = Global.FacturacionPersonal.My.Resources.Resources.LAST
        Me.BTNFF.Location = New System.Drawing.Point(534, 474)
        Me.BTNFF.Name = "BTNFF"
        Me.BTNFF.Size = New System.Drawing.Size(57, 55)
        Me.BTNFF.TabIndex = 1300
        Me.BTNFF.Tag = "4"
        Me.BTNFF.UseVisualStyleBackColor = False
        '
        'BTNSIG
        '
        Me.BTNSIG.BackColor = System.Drawing.SystemColors.Control
        Me.BTNSIG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIG.ForeColor = System.Drawing.Color.White
        Me.BTNSIG.Image = Global.FacturacionPersonal.My.Resources.Resources._NEXT
        Me.BTNSIG.Location = New System.Drawing.Point(453, 474)
        Me.BTNSIG.Name = "BTNSIG"
        Me.BTNSIG.Size = New System.Drawing.Size(57, 55)
        Me.BTNSIG.TabIndex = 1299
        Me.BTNSIG.Tag = "3"
        Me.BTNSIG.UseVisualStyleBackColor = False
        '
        'BTNANT
        '
        Me.BTNANT.BackColor = System.Drawing.SystemColors.Control
        Me.BTNANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNANT.ForeColor = System.Drawing.Color.White
        Me.BTNANT.Image = Global.FacturacionPersonal.My.Resources.Resources.PREVIOUS
        Me.BTNANT.Location = New System.Drawing.Point(372, 474)
        Me.BTNANT.Name = "BTNANT"
        Me.BTNANT.Size = New System.Drawing.Size(57, 55)
        Me.BTNANT.TabIndex = 1298
        Me.BTNANT.Tag = "2"
        Me.BTNANT.UseVisualStyleBackColor = False
        '
        'BTNRR
        '
        Me.BTNRR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNRR.Enabled = False
        Me.BTNRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRR.ForeColor = System.Drawing.Color.White
        Me.BTNRR.Image = Global.FacturacionPersonal.My.Resources.Resources.FIRST
        Me.BTNRR.Location = New System.Drawing.Point(291, 474)
        Me.BTNRR.Name = "BTNRR"
        Me.BTNRR.Size = New System.Drawing.Size(57, 55)
        Me.BTNRR.TabIndex = 1297
        Me.BTNRR.Tag = "1"
        Me.BTNRR.UseVisualStyleBackColor = False
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Image = Global.FacturacionPersonal.My.Resources.Resources.OK
        Me.BTNACEPTAR.Location = New System.Drawing.Point(828, 474)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(80, 77)
        Me.BTNACEPTAR.TabIndex = 431
        '
        'frmClsBusquedaPaginada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(921, 566)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.LBLNP)
        Me.Controls.Add(Me.BTNFF)
        Me.Controls.Add(Me.BTNSIG)
        Me.Controls.Add(Me.BTNANT)
        Me.Controls.Add(Me.BTNRR)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.LBL2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClsBusquedaPaginada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Paginada"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL2 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents LBL1 As System.Windows.Forms.Label
    Friend WithEvents TXTBUS As System.Windows.Forms.TextBox
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents TXTMOSTRAR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNFF As System.Windows.Forms.Button
    Friend WithEvents BTNSIG As System.Windows.Forms.Button
    Friend WithEvents BTNANT As System.Windows.Forms.Button
    Friend WithEvents BTNRR As System.Windows.Forms.Button
    Friend WithEvents LBLNP As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
End Class
