<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.SB = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompraDeTimbresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReImprimirMultiplesFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimbresGastadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoliosUtilizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturaciónDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DesgloseDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMLPDFExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SB
        '
        Me.SB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.SB.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel1})
        Me.SB.Location = New System.Drawing.Point(0, 679)
        Me.SB.Name = "SB"
        Me.SB.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SB.Size = New System.Drawing.Size(1260, 25)
        Me.SB.TabIndex = 45
        Me.SB.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(138, 20)
        Me.ToolStripStatusLabel7.Text = "Los Mochis, Sinaloa"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(198, 20)
        Me.ToolStripStatusLabel8.Text = "Narciso Iván Cisneros Acosta"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 20)
        Me.ToolStripStatusLabel1.Text = "Navysoluciones"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.ToolStripMenuItem40})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 31)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.NegociosToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClientesToolStripMenuItem, Me.ModificarClientesToolStripMenuItem, Me.ToolStripMenuItem2, Me.FacturarToolStripMenuItem, Me.ToolStripMenuItem4, Me.CompraDeTimbresToolStripMenuItem})
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripMenuItem7.Text = "&Archivo"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(245, 28)
        Me.ToolStripMenuItem8.Text = "Em&presa"
        '
        'NegociosToolStripMenuItem
        '
        Me.NegociosToolStripMenuItem.Name = "NegociosToolStripMenuItem"
        Me.NegociosToolStripMenuItem.Size = New System.Drawing.Size(245, 28)
        Me.NegociosToolStripMenuItem.Text = "Negocios"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(242, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(245, 28)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ModificarClientesToolStripMenuItem
        '
        Me.ModificarClientesToolStripMenuItem.Name = "ModificarClientesToolStripMenuItem"
        Me.ModificarClientesToolStripMenuItem.Size = New System.Drawing.Size(245, 28)
        Me.ModificarClientesToolStripMenuItem.Text = "Modificar Clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(242, 6)
        '
        'FacturarToolStripMenuItem
        '
        Me.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        Me.FacturarToolStripMenuItem.Size = New System.Drawing.Size(245, 28)
        Me.FacturarToolStripMenuItem.Text = "Facturar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(242, 6)
        '
        'CompraDeTimbresToolStripMenuItem
        '
        Me.CompraDeTimbresToolStripMenuItem.Name = "CompraDeTimbresToolStripMenuItem"
        Me.CompraDeTimbresToolStripMenuItem.Size = New System.Drawing.Size(245, 28)
        Me.CompraDeTimbresToolStripMenuItem.Text = "Compra de Timbres"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelarFacturaToolStripMenuItem, Me.ReImprimirMultiplesFacturaToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(126, 27)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'CancelarFacturaToolStripMenuItem
        '
        Me.CancelarFacturaToolStripMenuItem.Name = "CancelarFacturaToolStripMenuItem"
        Me.CancelarFacturaToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.CancelarFacturaToolStripMenuItem.Text = "Cancelar Factura"
        '
        'ReImprimirMultiplesFacturaToolStripMenuItem
        '
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Name = "ReImprimirMultiplesFacturaToolStripMenuItem"
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Size = New System.Drawing.Size(326, 28)
        Me.ReImprimirMultiplesFacturaToolStripMenuItem.Text = "Re Imprimir Multiples Factura"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasRealizadasToolStripMenuItem, Me.TimbresGastadosToolStripMenuItem, Me.FoliosUtilizadosToolStripMenuItem, Me.ToolStripMenuItem3, Me.FacturaciónDeClientesToolStripMenuItem, Me.ToolStripMenuItem5, Me.DesgloseDeFacturasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'FacturasRealizadasToolStripMenuItem
        '
        Me.FacturasRealizadasToolStripMenuItem.Name = "FacturasRealizadasToolStripMenuItem"
        Me.FacturasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(270, 28)
        Me.FacturasRealizadasToolStripMenuItem.Text = "Facturas Realizadas"
        '
        'TimbresGastadosToolStripMenuItem
        '
        Me.TimbresGastadosToolStripMenuItem.Name = "TimbresGastadosToolStripMenuItem"
        Me.TimbresGastadosToolStripMenuItem.Size = New System.Drawing.Size(270, 28)
        Me.TimbresGastadosToolStripMenuItem.Text = "Timbres Gastados"
        '
        'FoliosUtilizadosToolStripMenuItem
        '
        Me.FoliosUtilizadosToolStripMenuItem.Name = "FoliosUtilizadosToolStripMenuItem"
        Me.FoliosUtilizadosToolStripMenuItem.Size = New System.Drawing.Size(270, 28)
        Me.FoliosUtilizadosToolStripMenuItem.Text = "Folios Utilizados"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(267, 6)
        '
        'FacturaciónDeClientesToolStripMenuItem
        '
        Me.FacturaciónDeClientesToolStripMenuItem.Name = "FacturaciónDeClientesToolStripMenuItem"
        Me.FacturaciónDeClientesToolStripMenuItem.Size = New System.Drawing.Size(270, 28)
        Me.FacturaciónDeClientesToolStripMenuItem.Text = "Facturación de Clientes"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(267, 6)
        '
        'DesgloseDeFacturasToolStripMenuItem
        '
        Me.DesgloseDeFacturasToolStripMenuItem.Name = "DesgloseDeFacturasToolStripMenuItem"
        Me.DesgloseDeFacturasToolStripMenuItem.Size = New System.Drawing.Size(270, 28)
        Me.DesgloseDeFacturasToolStripMenuItem.Text = "Desglose de Facturas"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CierreFiscalToolStripMenuItem, Me.CorteMensualToolStripMenuItem, Me.XMLPDFExcelToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(70, 27)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'CierreFiscalToolStripMenuItem
        '
        Me.CierreFiscalToolStripMenuItem.Name = "CierreFiscalToolStripMenuItem"
        Me.CierreFiscalToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.CierreFiscalToolStripMenuItem.Text = "Cierre Fiscal"
        '
        'CorteMensualToolStripMenuItem
        '
        Me.CorteMensualToolStripMenuItem.Name = "CorteMensualToolStripMenuItem"
        Me.CorteMensualToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.CorteMensualToolStripMenuItem.Text = "Corte Mensual"
        '
        'XMLPDFExcelToolStripMenuItem
        '
        Me.XMLPDFExcelToolStripMenuItem.Name = "XMLPDFExcelToolStripMenuItem"
        Me.XMLPDFExcelToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.XMLPDFExcelToolStripMenuItem.Text = "XML PDF Excel"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1})
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(73, 27)
        Me.ToolStripMenuItem40.Text = "&Ayuda"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(123, 28)
        Me.AyudaToolStripMenuItem1.Text = "&DeIP"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FacturacionPersonal.My.Resources.Resources.FondoForms
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1260, 704)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación Electrónica Personal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SB.ResumeLayout(False)
        Me.SB.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SB As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NegociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompraDeTimbresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReImprimirMultiplesFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimbresGastadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoliosUtilizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturaciónDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DesgloseDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreFiscalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorteMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XMLPDFExcelToolStripMenuItem As ToolStripMenuItem
End Class
