<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXTNCOM = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXTNOM = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CBCALLE = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LBLDD = New System.Windows.Forms.Label
        Me.CBEMISOR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBLDE = New System.Windows.Forms.Label
        Me.LBLDN = New System.Windows.Forms.Label
        Me.CBNEG = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTDE = New System.Windows.Forms.DateTimePicker
        Me.TXTRFC = New System.Windows.Forms.TextBox
        Me.CBTC = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TABC = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CHKINE = New System.Windows.Forms.CheckBox
        Me.CHKCE = New System.Windows.Forms.CheckBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNBUSCAR = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.CODINT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ieps = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RetIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RetIsr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalNeto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FactorIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TasaIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FactorIeps = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TasaIeps = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UniSat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PYSSAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TASAIVAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPOFACTORIVAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TASAIEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPOFACTORIEPSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TASAISRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPOFACTORISRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label74 = New System.Windows.Forms.Label
        Me.TXTIEPS = New System.Windows.Forms.TextBox
        Me.CHKIR = New System.Windows.Forms.CheckBox
        Me.CHKIT = New System.Windows.Forms.CheckBox
        Me.GBRET = New System.Windows.Forms.GroupBox
        Me.TXTIVAR = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.TXTISRR = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.CBFIVAR = New System.Windows.Forms.ComboBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.CBFISRR = New System.Windows.Forms.ComboBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.GBTRAS = New System.Windows.Forms.GroupBox
        Me.TXTTIVA = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TXTTCIEPS = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.CBFIVA = New System.Windows.Forms.ComboBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.CBFIEPS = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.TXTCODINT = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.CBUNI = New System.Windows.Forms.ComboBox
        Me.CBPYS = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.LBLTOT = New System.Windows.Forms.Label
        Me.LBLSUB = New System.Windows.Forms.Label
        Me.LBLIVA = New System.Windows.Forms.Label
        Me.TXTTOT = New System.Windows.Forms.TextBox
        Me.LBLCCL = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TXTRIVA = New System.Windows.Forms.TextBox
        Me.TXTISR = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TXTSUB = New System.Windows.Forms.TextBox
        Me.TXTIVA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTIMP = New System.Windows.Forms.TextBox
        Me.TXTCANT = New System.Windows.Forms.TextBox
        Me.TXTVU = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXTDES = New System.Windows.Forms.TextBox
        Me.TXTUNI = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BTNQUITAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label17 = New System.Windows.Forms.Label
        Me.TXTCOM = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.CBUSO = New System.Windows.Forms.ComboBox
        Me.LLBLP = New System.Windows.Forms.LinkLabel
        Me.LLBLD = New System.Windows.Forms.LinkLabel
        Me.LLBLF = New System.Windows.Forms.LinkLabel
        Me.LBLTC = New System.Windows.Forms.LinkLabel
        Me.TXTTC = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.CBMON = New System.Windows.Forms.ComboBox
        Me.CBCP = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXTTAR = New System.Windows.Forms.TextBox
        Me.CBFP = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CBMP = New System.Windows.Forms.ComboBox
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.RB7 = New System.Windows.Forms.RadioButton
        Me.RB1 = New System.Windows.Forms.RadioButton
        Me.RB2 = New System.Windows.Forms.RadioButton
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.BTNQC = New System.Windows.Forms.Button
        Me.BTNAC = New System.Windows.Forms.Button
        Me.LBC = New System.Windows.Forms.ListBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TXTCC = New System.Windows.Forms.TextBox
        Me.CBEC = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.RB5 = New System.Windows.Forms.RadioButton
        Me.RB6 = New System.Windows.Forms.RadioButton
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.BTNQO = New System.Windows.Forms.Button
        Me.BTNAO = New System.Windows.Forms.Button
        Me.LBO = New System.Windows.Forms.ListBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TXTCO = New System.Windows.Forms.TextBox
        Me.CBEO = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.RB3 = New System.Windows.Forms.RadioButton
        Me.RB4 = New System.Windows.Forms.RadioButton
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.TXTCEOBS = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.GBCEDES = New System.Windows.Forms.GroupBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.CBCEPAIS = New System.Windows.Forms.ComboBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.CBCEEDO = New System.Windows.Forms.ComboBox
        Me.TXTCEREF = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.TXTCENOINT = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.TXTCENOEXT = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.TXTCEMUN = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.TXTCELOC = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.TXTCECP = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.TXTCECALLE = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.TXTCEDDNOM = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.TXTCEDDCURP = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.TXTCERFC = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.CBCEINCO = New System.Windows.Forms.ComboBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.TXTCETUSD = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.TXTCETC = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.CBCESUB = New System.Windows.Forms.ComboBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.TXTCECURP = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.TXTCERFP = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.TXTCENCO = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.TXTCECO = New System.Windows.Forms.TextBox
        Me.CHKCEDD = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.TXTCECPED = New System.Windows.Forms.TextBox
        Me.CBCETO = New System.Windows.Forms.ComboBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Button5 = New System.Windows.Forms.Button
        Me.BTNCRPAGREGAR = New System.Windows.Forms.Button
        Me.BTNBCER = New System.Windows.Forms.Button
        Me.CBCRPTCP = New System.Windows.Forms.ComboBox
        Me.DGVCRP = New System.Windows.Forms.DataGridView
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumParcialidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NuevoSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label92 = New System.Windows.Forms.Label
        Me.TXTCRPSELLO = New System.Windows.Forms.TextBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.TXTCRPCAD = New System.Windows.Forms.TextBox
        Me.Label86 = New System.Windows.Forms.Label
        Me.TXTCRPCER = New System.Windows.Forms.TextBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.TXTCRPCB = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.TXTCRPRFCCB = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.TXTCRPCO = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.TXTCRPNBCO = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.TXTCRPRFCCO = New System.Windows.Forms.TextBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.TXTCRPNOPE = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.TXTCRPTC = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.CBCRPMON = New System.Windows.Forms.ComboBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.CBCRPFP = New System.Windows.Forms.ComboBox
        Me.DTPCRPFP = New System.Windows.Forms.DateTimePicker
        Me.BGW = New System.ComponentModel.BackgroundWorker
        Me.TTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TABC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRET.SuspendLayout()
        Me.GBTRAS.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GBCEDES.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DGVCRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTNCOM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXTNOM)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 251)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 70)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'TXTNCOM
        '
        Me.TXTNCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNCOM.Location = New System.Drawing.Point(156, 42)
        Me.TXTNCOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNCOM.MaxLength = 100
        Me.TXTNCOM.Name = "TXTNCOM"
        Me.TXTNCOM.Size = New System.Drawing.Size(512, 22)
        Me.TXTNCOM.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nombre Comercial:"
        '
        'TXTNOM
        '
        Me.TXTNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOM.Location = New System.Drawing.Point(156, 12)
        Me.TXTNOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNOM.MaxLength = 100
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(512, 22)
        Me.TXTNOM.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre Fiscal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "RFC Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Calle:"
        '
        'CBCALLE
        '
        Me.CBCALLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCALLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCALLE.FormattingEnabled = True
        Me.CBCALLE.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCALLE.Location = New System.Drawing.Point(175, 344)
        Me.CBCALLE.Name = "CBCALLE"
        Me.CBCALLE.Size = New System.Drawing.Size(565, 24)
        Me.CBCALLE.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBLDD)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 375)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(733, 70)
        Me.GroupBox2.TabIndex = 104
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Domicilio"
        '
        'LBLDD
        '
        Me.LBLDD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDD.Location = New System.Drawing.Point(9, 17)
        Me.LBLDD.Name = "LBLDD"
        Me.LBLDD.Size = New System.Drawing.Size(718, 49)
        Me.LBLDD.TabIndex = 95
        '
        'CBEMISOR
        '
        Me.CBEMISOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEMISOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEMISOR.FormattingEnabled = True
        Me.CBEMISOR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBEMISOR.Location = New System.Drawing.Point(123, 25)
        Me.CBEMISOR.Name = "CBEMISOR"
        Me.CBEMISOR.Size = New System.Drawing.Size(221, 24)
        Me.CBEMISOR.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "RFC Emisor"
        '
        'LBLDE
        '
        Me.LBLDE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDE.Location = New System.Drawing.Point(21, 61)
        Me.LBLDE.Name = "LBLDE"
        Me.LBLDE.Size = New System.Drawing.Size(321, 52)
        Me.LBLDE.TabIndex = 116
        Me.LBLDE.Text = "Domicilio Emisor"
        '
        'LBLDN
        '
        Me.LBLDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDN.Location = New System.Drawing.Point(479, 61)
        Me.LBLDN.Name = "LBLDN"
        Me.LBLDN.Size = New System.Drawing.Size(488, 52)
        Me.LBLDN.TabIndex = 119
        Me.LBLDN.Text = "Lugar de Expedición"
        '
        'CBNEG
        '
        Me.CBNEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNEG.FormattingEnabled = True
        Me.CBNEG.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBNEG.Location = New System.Drawing.Point(479, 25)
        Me.CBNEG.Name = "CBNEG"
        Me.CBNEG.Size = New System.Drawing.Size(488, 24)
        Me.CBNEG.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Negocio"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(422, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nuevo Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTDE
        '
        Me.DTDE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDE.Location = New System.Drawing.Point(404, 170)
        Me.DTDE.Name = "DTDE"
        Me.DTDE.Size = New System.Drawing.Size(126, 26)
        Me.DTDE.TabIndex = 19
        '
        'TXTRFC
        '
        Me.TXTRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRFC.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRFC.Location = New System.Drawing.Point(120, 219)
        Me.TXTRFC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTRFC.MaxLength = 13
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(224, 26)
        Me.TXTRFC.TabIndex = 2
        Me.TXTRFC.Text = "1IL6G2Z0OQ95S"
        '
        'CBTC
        '
        Me.CBTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTC.FormattingEnabled = True
        Me.CBTC.Location = New System.Drawing.Point(21, 172)
        Me.CBTC.Name = "CBTC"
        Me.CBTC.Size = New System.Drawing.Size(321, 24)
        Me.CBTC.TabIndex = 1121
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 153)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(159, 16)
        Me.Label20.TabIndex = 1122
        Me.Label20.Text = "Tipo de Comprobante"
        '
        'TABC
        '
        Me.TABC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TABC.Controls.Add(Me.TabPage1)
        Me.TABC.Controls.Add(Me.TabPage3)
        Me.TABC.Controls.Add(Me.TabPage5)
        Me.TABC.Controls.Add(Me.TabPage2)
        Me.TABC.Controls.Add(Me.TabPage4)
        Me.TABC.Controls.Add(Me.TabPage6)
        Me.TABC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABC.Location = New System.Drawing.Point(2, 12)
        Me.TABC.Name = "TABC"
        Me.TABC.SelectedIndex = 0
        Me.TABC.Size = New System.Drawing.Size(999, 732)
        Me.TABC.TabIndex = 1123
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.CBEMISOR)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CBTC)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BTNCANCELAR)
        Me.TabPage1.Controls.Add(Me.BTNBUSCAR)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CBCALLE)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.TXTRFC)
        Me.TabPage1.Controls.Add(Me.DTDE)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.LBLDE)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.CBNEG)
        Me.TabPage1.Controls.Add(Me.LBLDN)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(991, 703)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comprobante"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CHKINE)
        Me.GroupBox3.Controls.Add(Me.CHKCE)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 553)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(730, 125)
        Me.GroupBox3.TabIndex = 1173
        Me.GroupBox3.TabStop = False
        '
        'CHKINE
        '
        Me.CHKINE.AutoSize = True
        Me.CHKINE.Checked = True
        Me.CHKINE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKINE.Location = New System.Drawing.Point(37, 21)
        Me.CHKINE.Name = "CHKINE"
        Me.CHKINE.Size = New System.Drawing.Size(151, 20)
        Me.CHKINE.TabIndex = 1168
        Me.CHKINE.Text = "Complemento INE"
        Me.CHKINE.UseVisualStyleBackColor = True
        '
        'CHKCE
        '
        Me.CHKCE.AutoSize = True
        Me.CHKCE.Checked = True
        Me.CHKCE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCE.Location = New System.Drawing.Point(495, 21)
        Me.CHKCE.Name = "CHKCE"
        Me.CHKCE.Size = New System.Drawing.Size(150, 20)
        Me.CHKCE.TabIndex = 1170
        Me.CHKCE.Text = "Comercio Exterior"
        Me.CHKCE.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(21, 525)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(115, 16)
        Me.Label30.TabIndex = 1169
        Me.Label30.Text = "Complementos:"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.Location = New System.Drawing.Point(887, 230)
        Me.BTNCANCELAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNCANCELAR.TabIndex = 5
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Image = CType(resources.GetObject("BTNBUSCAR.Image"), System.Drawing.Image)
        Me.BTNBUSCAR.Location = New System.Drawing.Point(775, 230)
        Me.BTNBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNBUSCAR.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.DGV)
        Me.TabPage3.Controls.Add(Me.Label74)
        Me.TabPage3.Controls.Add(Me.TXTIEPS)
        Me.TabPage3.Controls.Add(Me.CHKIR)
        Me.TabPage3.Controls.Add(Me.CHKIT)
        Me.TabPage3.Controls.Add(Me.GBRET)
        Me.TabPage3.Controls.Add(Me.GBTRAS)
        Me.TabPage3.Controls.Add(Me.Label67)
        Me.TabPage3.Controls.Add(Me.TXTCODINT)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.CBUNI)
        Me.TabPage3.Controls.Add(Me.CBPYS)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.LBLTOT)
        Me.TabPage3.Controls.Add(Me.LBLSUB)
        Me.TabPage3.Controls.Add(Me.LBLIVA)
        Me.TabPage3.Controls.Add(Me.TXTTOT)
        Me.TabPage3.Controls.Add(Me.LBLCCL)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TXTRIVA)
        Me.TabPage3.Controls.Add(Me.TXTISR)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TXTSUB)
        Me.TabPage3.Controls.Add(Me.TXTIVA)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TXTIMP)
        Me.TabPage3.Controls.Add(Me.TXTCANT)
        Me.TabPage3.Controls.Add(Me.TXTVU)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TXTDES)
        Me.TabPage3.Controls.Add(Me.TXTUNI)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.BTNQUITAR)
        Me.TabPage3.Controls.Add(Me.BTNAGREGAR)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(991, 703)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle Factura"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(946, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 25)
        Me.Button4.TabIndex = 1503
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODINT, Me.Cantidad, Me.Descripcion, Me.Unidad, Me.ValorUnitario, Me.Subtotal, Me.Iva, Me.Ieps, Me.RetIva, Me.RetIsr, Me.TotalNeto, Me.FactorIva, Me.TasaIva, Me.FactorIeps, Me.TasaIeps, Me.UniSat, Me.PYSSAT, Me.TASAIVAR, Me.TIPOFACTORIVAR, Me.IEPSR, Me.TASAIEPSR, Me.TIPOFACTORIEPSR, Me.TASAISRR, Me.TIPOFACTORISRR})
        Me.DGV.Location = New System.Drawing.Point(22, 352)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(868, 210)
        Me.DGV.TabIndex = 1502
        '
        'CODINT
        '
        Me.CODINT.HeaderText = "Cod. Int"
        Me.CODINT.Name = "CODINT"
        Me.CODINT.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'ValorUnitario
        '
        Me.ValorUnitario.HeaderText = "Valor Unitario"
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Sub Total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        '
        'Ieps
        '
        Me.Ieps.HeaderText = "Ieps"
        Me.Ieps.Name = "Ieps"
        Me.Ieps.ReadOnly = True
        '
        'RetIva
        '
        Me.RetIva.HeaderText = "Ret. Iva"
        Me.RetIva.Name = "RetIva"
        Me.RetIva.ReadOnly = True
        '
        'RetIsr
        '
        Me.RetIsr.HeaderText = "Ret. Isr"
        Me.RetIsr.Name = "RetIsr"
        Me.RetIsr.ReadOnly = True
        '
        'TotalNeto
        '
        Me.TotalNeto.HeaderText = "Total Neto"
        Me.TotalNeto.Name = "TotalNeto"
        Me.TotalNeto.ReadOnly = True
        '
        'FactorIva
        '
        Me.FactorIva.HeaderText = "Factor Iva"
        Me.FactorIva.Name = "FactorIva"
        Me.FactorIva.ReadOnly = True
        Me.FactorIva.Visible = False
        '
        'TasaIva
        '
        Me.TasaIva.HeaderText = "Tasa Iva"
        Me.TasaIva.Name = "TasaIva"
        Me.TasaIva.ReadOnly = True
        Me.TasaIva.Visible = False
        '
        'FactorIeps
        '
        Me.FactorIeps.HeaderText = "Factor Ieps"
        Me.FactorIeps.Name = "FactorIeps"
        Me.FactorIeps.ReadOnly = True
        Me.FactorIeps.Visible = False
        '
        'TasaIeps
        '
        Me.TasaIeps.HeaderText = "Tasa Ieps"
        Me.TasaIeps.Name = "TasaIeps"
        Me.TasaIeps.ReadOnly = True
        Me.TasaIeps.Visible = False
        '
        'UniSat
        '
        Me.UniSat.HeaderText = "UniSat"
        Me.UniSat.Name = "UniSat"
        Me.UniSat.ReadOnly = True
        Me.UniSat.Visible = False
        '
        'PYSSAT
        '
        Me.PYSSAT.HeaderText = "PYSSAT"
        Me.PYSSAT.Name = "PYSSAT"
        Me.PYSSAT.ReadOnly = True
        Me.PYSSAT.Visible = False
        '
        'TASAIVAR
        '
        Me.TASAIVAR.HeaderText = "TASAIVAR"
        Me.TASAIVAR.Name = "TASAIVAR"
        Me.TASAIVAR.ReadOnly = True
        Me.TASAIVAR.Visible = False
        '
        'TIPOFACTORIVAR
        '
        Me.TIPOFACTORIVAR.HeaderText = "TIPOFACTORIVAR"
        Me.TIPOFACTORIVAR.Name = "TIPOFACTORIVAR"
        Me.TIPOFACTORIVAR.ReadOnly = True
        Me.TIPOFACTORIVAR.Visible = False
        '
        'IEPSR
        '
        Me.IEPSR.HeaderText = "IEPSR"
        Me.IEPSR.Name = "IEPSR"
        Me.IEPSR.ReadOnly = True
        Me.IEPSR.Visible = False
        '
        'TASAIEPSR
        '
        Me.TASAIEPSR.HeaderText = "TASAIEPSR"
        Me.TASAIEPSR.Name = "TASAIEPSR"
        Me.TASAIEPSR.ReadOnly = True
        Me.TASAIEPSR.Visible = False
        '
        'TIPOFACTORIEPSR
        '
        Me.TIPOFACTORIEPSR.HeaderText = "TIPOFACTORIEPSR"
        Me.TIPOFACTORIEPSR.Name = "TIPOFACTORIEPSR"
        Me.TIPOFACTORIEPSR.ReadOnly = True
        Me.TIPOFACTORIEPSR.Visible = False
        '
        'TASAISRR
        '
        Me.TASAISRR.HeaderText = "TASAISRR"
        Me.TASAISRR.Name = "TASAISRR"
        Me.TASAISRR.ReadOnly = True
        Me.TASAISRR.Visible = False
        '
        'TIPOFACTORISRR
        '
        Me.TIPOFACTORISRR.HeaderText = "TIPOFACTORISRR"
        Me.TIPOFACTORISRR.Name = "TIPOFACTORISRR"
        Me.TIPOFACTORISRR.ReadOnly = True
        Me.TIPOFACTORISRR.Visible = False
        '
        'Label74
        '
        Me.Label74.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(526, 602)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(44, 20)
        Me.Label74.TabIndex = 1501
        Me.Label74.Text = "Ieps"
        '
        'TXTIEPS
        '
        Me.TXTIEPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIEPS.Location = New System.Drawing.Point(573, 601)
        Me.TXTIEPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTIEPS.MaxLength = 20
        Me.TXTIEPS.Name = "TXTIEPS"
        Me.TXTIEPS.ReadOnly = True
        Me.TXTIEPS.Size = New System.Drawing.Size(171, 22)
        Me.TXTIEPS.TabIndex = 1500
        Me.TXTIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CHKIR
        '
        Me.CHKIR.AutoSize = True
        Me.CHKIR.Location = New System.Drawing.Point(568, 164)
        Me.CHKIR.Name = "CHKIR"
        Me.CHKIR.Size = New System.Drawing.Size(189, 20)
        Me.CHKIR.TabIndex = 1499
        Me.CHKIR.Text = "Impuestos Retenciones"
        Me.CHKIR.UseVisualStyleBackColor = True
        '
        'CHKIT
        '
        Me.CHKIT.AutoSize = True
        Me.CHKIT.Location = New System.Drawing.Point(29, 164)
        Me.CHKIT.Name = "CHKIT"
        Me.CHKIT.Size = New System.Drawing.Size(191, 20)
        Me.CHKIT.TabIndex = 1498
        Me.CHKIT.Text = "Impuestos Trasladados"
        Me.CHKIT.UseVisualStyleBackColor = True
        '
        'GBRET
        '
        Me.GBRET.Controls.Add(Me.TXTIVAR)
        Me.GBRET.Controls.Add(Me.Label68)
        Me.GBRET.Controls.Add(Me.TXTISRR)
        Me.GBRET.Controls.Add(Me.Label69)
        Me.GBRET.Controls.Add(Me.CBFIVAR)
        Me.GBRET.Controls.Add(Me.Label70)
        Me.GBRET.Controls.Add(Me.CBFISRR)
        Me.GBRET.Controls.Add(Me.Label71)
        Me.GBRET.Controls.Add(Me.Label72)
        Me.GBRET.Controls.Add(Me.Label73)
        Me.GBRET.Location = New System.Drawing.Point(564, 190)
        Me.GBRET.Name = "GBRET"
        Me.GBRET.Size = New System.Drawing.Size(310, 156)
        Me.GBRET.TabIndex = 1497
        Me.GBRET.TabStop = False
        '
        'TXTIVAR
        '
        Me.TXTIVAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVAR.Location = New System.Drawing.Point(184, 35)
        Me.TXTIVAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTIVAR.MaxLength = 20
        Me.TXTIVAR.Name = "TXTIVAR"
        Me.TXTIVAR.Size = New System.Drawing.Size(97, 22)
        Me.TXTIVAR.TabIndex = 1236
        Me.TXTIVAR.Text = "0"
        Me.TXTIVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(181, 16)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(69, 16)
        Me.Label68.TabIndex = 1215
        Me.Label68.Text = "Tasa Iva"
        '
        'TXTISRR
        '
        Me.TXTISRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTISRR.Location = New System.Drawing.Point(184, 105)
        Me.TXTISRR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTISRR.MaxLength = 20
        Me.TXTISRR.Name = "TXTISRR"
        Me.TXTISRR.Size = New System.Drawing.Size(97, 22)
        Me.TXTISRR.TabIndex = 1183
        Me.TXTISRR.Text = "0"
        Me.TXTISRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(48, 132)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(151, 16)
        Me.Label69.TabIndex = 1493
        Me.Label69.Text = "Tasa del 0.00 al 0.35"
        '
        'CBFIVAR
        '
        Me.CBFIVAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIVAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIVAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIVAR.FormattingEnabled = True
        Me.CBFIVAR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIVAR.Location = New System.Drawing.Point(28, 33)
        Me.CBFIVAR.Name = "CBFIVAR"
        Me.CBFIVAR.Size = New System.Drawing.Size(117, 24)
        Me.CBFIVAR.TabIndex = 1232
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Red
        Me.Label70.Location = New System.Drawing.Point(48, 61)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(151, 16)
        Me.Label70.TabIndex = 1492
        Me.Label70.Text = "Tasa del 0.00 al 0.16"
        '
        'CBFISRR
        '
        Me.CBFISRR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFISRR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFISRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFISRR.FormattingEnabled = True
        Me.CBFISRR.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFISRR.Location = New System.Drawing.Point(28, 105)
        Me.CBFISRR.Name = "CBFISRR"
        Me.CBFISRR.Size = New System.Drawing.Size(117, 24)
        Me.CBFISRR.TabIndex = 1234
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(34, 16)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(77, 16)
        Me.Label71.TabIndex = 1233
        Me.Label71.Text = "Iva Factor"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(35, 84)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(73, 16)
        Me.Label72.TabIndex = 1235
        Me.Label72.Text = "Isr Factor"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(181, 84)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(65, 16)
        Me.Label73.TabIndex = 1237
        Me.Label73.Text = "Tasa Isr"
        '
        'GBTRAS
        '
        Me.GBTRAS.Controls.Add(Me.TXTTIVA)
        Me.GBTRAS.Controls.Add(Me.Label18)
        Me.GBTRAS.Controls.Add(Me.TXTTCIEPS)
        Me.GBTRAS.Controls.Add(Me.Label65)
        Me.GBTRAS.Controls.Add(Me.CBFIVA)
        Me.GBTRAS.Controls.Add(Me.Label66)
        Me.GBTRAS.Controls.Add(Me.CBFIEPS)
        Me.GBTRAS.Controls.Add(Me.Label35)
        Me.GBTRAS.Controls.Add(Me.Label36)
        Me.GBTRAS.Controls.Add(Me.Label37)
        Me.GBTRAS.Location = New System.Drawing.Point(29, 190)
        Me.GBTRAS.Name = "GBTRAS"
        Me.GBTRAS.Size = New System.Drawing.Size(327, 156)
        Me.GBTRAS.TabIndex = 1496
        Me.GBTRAS.TabStop = False
        '
        'TXTTIVA
        '
        Me.TXTTIVA.Enabled = False
        Me.TXTTIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIVA.Location = New System.Drawing.Point(179, 35)
        Me.TXTTIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTTIVA.MaxLength = 20
        Me.TXTTIVA.Name = "TXTTIVA"
        Me.TXTTIVA.Size = New System.Drawing.Size(97, 22)
        Me.TXTTIVA.TabIndex = 1236
        Me.TXTTIVA.Text = "0"
        Me.TXTTIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(176, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 1215
        Me.Label18.Text = "Tasa Iva"
        '
        'TXTTCIEPS
        '
        Me.TXTTCIEPS.Enabled = False
        Me.TXTTCIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTCIEPS.Location = New System.Drawing.Point(179, 105)
        Me.TXTTCIEPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTTCIEPS.MaxLength = 20
        Me.TXTTCIEPS.Name = "TXTTCIEPS"
        Me.TXTTCIEPS.Size = New System.Drawing.Size(97, 22)
        Me.TXTTCIEPS.TabIndex = 1183
        Me.TXTTCIEPS.Text = "0"
        Me.TXTTCIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(5, 132)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(311, 16)
        Me.Label65.TabIndex = 1493
        Me.Label65.Text = "Tasa del 0.00 al 1.6 / Cuota del 0.00 al 43.77"
        '
        'CBFIVA
        '
        Me.CBFIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIVA.FormattingEnabled = True
        Me.CBFIVA.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIVA.Location = New System.Drawing.Point(28, 33)
        Me.CBFIVA.Name = "CBFIVA"
        Me.CBFIVA.Size = New System.Drawing.Size(117, 24)
        Me.CBFIVA.TabIndex = 1232
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(48, 61)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(151, 16)
        Me.Label66.TabIndex = 1492
        Me.Label66.Text = "Tasa del 0.00 al 0.16"
        '
        'CBFIEPS
        '
        Me.CBFIEPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFIEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFIEPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFIEPS.FormattingEnabled = True
        Me.CBFIEPS.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFIEPS.Location = New System.Drawing.Point(28, 105)
        Me.CBFIEPS.Name = "CBFIEPS"
        Me.CBFIEPS.Size = New System.Drawing.Size(117, 24)
        Me.CBFIEPS.TabIndex = 1234
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(34, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 16)
        Me.Label35.TabIndex = 1233
        Me.Label35.Text = "Iva Factor"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(35, 84)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 16)
        Me.Label36.TabIndex = 1235
        Me.Label36.Text = "Ieps Factor"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(176, 84)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(123, 16)
        Me.Label37.TabIndex = 1237
        Me.Label37.Text = "Tasa/Cuota Ieps"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(8, 50)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(91, 16)
        Me.Label67.TabIndex = 1495
        Me.Label67.Text = "Cod. Interno"
        '
        'TXTCODINT
        '
        Me.TXTCODINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCODINT.Location = New System.Drawing.Point(105, 44)
        Me.TXTCODINT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCODINT.MaxLength = 5000
        Me.TXTCODINT.Name = "TXTCODINT"
        Me.TXTCODINT.Size = New System.Drawing.Size(148, 22)
        Me.TXTCODINT.TabIndex = 1494
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(131, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 25)
        Me.Button3.TabIndex = 1239
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 25)
        Me.Button2.TabIndex = 1238
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 82)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 16)
        Me.Label34.TabIndex = 1231
        Me.Label34.Text = "Unidad"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(173, 4)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(76, 37)
        Me.Label33.TabIndex = 1230
        Me.Label33.Text = "Clave Producto"
        '
        'CBUNI
        '
        Me.CBUNI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBUNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUNI.FormattingEnabled = True
        Me.CBUNI.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBUNI.Location = New System.Drawing.Point(8, 100)
        Me.CBUNI.Name = "CBUNI"
        Me.CBUNI.Size = New System.Drawing.Size(117, 24)
        Me.CBUNI.TabIndex = 1229
        '
        'CBPYS
        '
        Me.CBPYS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBPYS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPYS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPYS.FormattingEnabled = True
        Me.CBPYS.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBPYS.Location = New System.Drawing.Point(255, 13)
        Me.CBPYS.Name = "CBPYS"
        Me.CBPYS.Size = New System.Drawing.Size(173, 24)
        Me.CBPYS.TabIndex = 1228
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(8, 127)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(91, 16)
        Me.Label32.TabIndex = 1227
        Me.Label32.Text = "Descripción"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(494, 4)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(490, 37)
        Me.Label31.TabIndex = 1226
        Me.Label31.Text = "Descripción"
        '
        'LBLTOT
        '
        Me.LBLTOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTOT.AutoSize = True
        Me.LBLTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOT.Location = New System.Drawing.Point(279, 602)
        Me.LBLTOT.Name = "LBLTOT"
        Me.LBLTOT.Size = New System.Drawing.Size(67, 20)
        Me.LBLTOT.TabIndex = 1193
        Me.LBLTOT.Text = "Ret Iva"
        '
        'LBLSUB
        '
        Me.LBLSUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLSUB.AutoSize = True
        Me.LBLSUB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUB.Location = New System.Drawing.Point(718, 571)
        Me.LBLSUB.Name = "LBLSUB"
        Me.LBLSUB.Size = New System.Drawing.Size(81, 20)
        Me.LBLSUB.TabIndex = 1194
        Me.LBLSUB.Text = "SubTotal"
        '
        'LBLIVA
        '
        Me.LBLIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLIVA.AutoSize = True
        Me.LBLIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIVA.Location = New System.Drawing.Point(21, 602)
        Me.LBLIVA.Name = "LBLIVA"
        Me.LBLIVA.Size = New System.Drawing.Size(64, 20)
        Me.LBLIVA.TabIndex = 1195
        Me.LBLIVA.Text = "Ret Isr"
        '
        'TXTTOT
        '
        Me.TXTTOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOT.Location = New System.Drawing.Point(805, 599)
        Me.TXTTOT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTTOT.MaxLength = 20
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.ReadOnly = True
        Me.TXTTOT.Size = New System.Drawing.Size(171, 22)
        Me.TXTTOT.TabIndex = 1209
        Me.TXTTOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLCCL
        '
        Me.LBLCCL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLCCL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCCL.Location = New System.Drawing.Point(6, 635)
        Me.LBLCCL.Name = "LBLCCL"
        Me.LBLCCL.Size = New System.Drawing.Size(950, 59)
        Me.LBLCCL.TabIndex = 1196
        Me.LBLCCL.Text = "Cantidad con Letra"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(750, 601)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 20)
        Me.Label15.TabIndex = 1208
        Me.Label15.Text = "Total"
        '
        'TXTRIVA
        '
        Me.TXTRIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTRIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRIVA.Location = New System.Drawing.Point(352, 600)
        Me.TXTRIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTRIVA.MaxLength = 20
        Me.TXTRIVA.Name = "TXTRIVA"
        Me.TXTRIVA.ReadOnly = True
        Me.TXTRIVA.Size = New System.Drawing.Size(171, 22)
        Me.TXTRIVA.TabIndex = 1207
        Me.TXTRIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTISR
        '
        Me.TXTISR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTISR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTISR.Location = New System.Drawing.Point(91, 600)
        Me.TXTISR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTISR.MaxLength = 20
        Me.TXTISR.Name = "TXTISR"
        Me.TXTISR.ReadOnly = True
        Me.TXTISR.Size = New System.Drawing.Size(171, 22)
        Me.TXTISR.TabIndex = 1206
        Me.TXTISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(307, 571)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 20)
        Me.Label13.TabIndex = 1205
        Me.Label13.Text = "IVA"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 572)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 1204
        Me.Label12.Text = "Importe"
        '
        'TXTSUB
        '
        Me.TXTSUB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTSUB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSUB.Location = New System.Drawing.Point(805, 569)
        Me.TXTSUB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSUB.MaxLength = 20
        Me.TXTSUB.Name = "TXTSUB"
        Me.TXTSUB.ReadOnly = True
        Me.TXTSUB.Size = New System.Drawing.Size(171, 22)
        Me.TXTSUB.TabIndex = 1203
        Me.TXTSUB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTIVA
        '
        Me.TXTIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVA.Location = New System.Drawing.Point(352, 570)
        Me.TXTIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTIVA.MaxLength = 20
        Me.TXTIVA.Name = "TXTIVA"
        Me.TXTIVA.ReadOnly = True
        Me.TXTIVA.Size = New System.Drawing.Size(171, 22)
        Me.TXTIVA.TabIndex = 1202
        Me.TXTIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 1197
        Me.Label1.Text = "Cantidad"
        '
        'TXTIMP
        '
        Me.TXTIMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIMP.Location = New System.Drawing.Point(91, 572)
        Me.TXTIMP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTIMP.MaxLength = 20
        Me.TXTIMP.Name = "TXTIMP"
        Me.TXTIMP.ReadOnly = True
        Me.TXTIMP.Size = New System.Drawing.Size(171, 22)
        Me.TXTIMP.TabIndex = 1201
        Me.TXTIMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTCANT
        '
        Me.TXTCANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANT.Location = New System.Drawing.Point(90, 13)
        Me.TXTCANT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCANT.MaxLength = 20
        Me.TXTCANT.Name = "TXTCANT"
        Me.TXTCANT.Size = New System.Drawing.Size(70, 22)
        Me.TXTCANT.TabIndex = 1179
        '
        'TXTVU
        '
        Me.TXTVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTVU.Location = New System.Drawing.Point(357, 104)
        Me.TXTVU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTVU.MaxLength = 20
        Me.TXTVU.Name = "TXTVU"
        Me.TXTVU.Size = New System.Drawing.Size(145, 22)
        Me.TXTVU.TabIndex = 1182
        Me.TXTVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(260, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 1198
        Me.Label8.Text = "Descripción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(399, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 1200
        Me.Label11.Text = "Valor Unitario"
        '
        'TXTDES
        '
        Me.TXTDES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDES.Location = New System.Drawing.Point(357, 44)
        Me.TXTDES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTDES.MaxLength = 5000
        Me.TXTDES.Name = "TXTDES"
        Me.TXTDES.Size = New System.Drawing.Size(583, 22)
        Me.TXTDES.TabIndex = 1180
        '
        'TXTUNI
        '
        Me.TXTUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNI.Location = New System.Drawing.Point(208, 104)
        Me.TXTUNI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTUNI.MaxLength = 20
        Me.TXTUNI.Name = "TXTUNI"
        Me.TXTUNI.Size = New System.Drawing.Size(97, 22)
        Me.TXTUNI.TabIndex = 1181
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(226, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 1199
        Me.Label10.Text = "Unidad"
        '
        'BTNQUITAR
        '
        Me.BTNQUITAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNQUITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQUITAR.Image = CType(resources.GetObject("BTNQUITAR.Image"), System.Drawing.Image)
        Me.BTNQUITAR.Location = New System.Drawing.Point(896, 483)
        Me.BTNQUITAR.Name = "BTNQUITAR"
        Me.BTNQUITAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNQUITAR.TabIndex = 1185
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.ForeColor = System.Drawing.Color.White
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(896, 352)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(80, 78)
        Me.BTNAGREGAR.TabIndex = 1184
        Me.BTNAGREGAR.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.TXTCOM)
        Me.TabPage5.Controls.Add(Me.Label38)
        Me.TabPage5.Controls.Add(Me.CBUSO)
        Me.TabPage5.Controls.Add(Me.LLBLP)
        Me.TabPage5.Controls.Add(Me.LLBLD)
        Me.TabPage5.Controls.Add(Me.LLBLF)
        Me.TabPage5.Controls.Add(Me.LBLTC)
        Me.TabPage5.Controls.Add(Me.TXTTC)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.CBMON)
        Me.TabPage5.Controls.Add(Me.CBCP)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.TXTTAR)
        Me.TabPage5.Controls.Add(Me.CBFP)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.CBMP)
        Me.TabPage5.Controls.Add(Me.BTNGUARDAR)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(991, 703)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Finalizar Comprobante"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(73, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 16)
        Me.Label17.TabIndex = 1246
        Me.Label17.Text = "Comentario"
        '
        'TXTCOM
        '
        Me.TXTCOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOM.Location = New System.Drawing.Point(78, 132)
        Me.TXTCOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCOM.MaxLength = 1000
        Me.TXTCOM.Multiline = True
        Me.TXTCOM.Name = "TXTCOM"
        Me.TXTCOM.Size = New System.Drawing.Size(835, 46)
        Me.TXTCOM.TabIndex = 1245
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(127, 245)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(71, 16)
        Me.Label38.TabIndex = 1244
        Me.Label38.Text = "Uso Cfdi:"
        '
        'CBUSO
        '
        Me.CBUSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUSO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUSO.FormattingEnabled = True
        Me.CBUSO.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBUSO.Location = New System.Drawing.Point(203, 237)
        Me.CBUSO.Name = "CBUSO"
        Me.CBUSO.Size = New System.Drawing.Size(565, 24)
        Me.CBUSO.TabIndex = 1243
        '
        'LLBLP
        '
        Me.LLBLP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLP.AutoSize = True
        Me.LLBLP.Location = New System.Drawing.Point(473, 466)
        Me.LLBLP.Name = "LLBLP"
        Me.LLBLP.Size = New System.Drawing.Size(78, 16)
        Me.LLBLP.TabIndex = 1242
        Me.LLBLP.TabStop = True
        Me.LLBLP.Text = "Dólar Hoy"
        '
        'LLBLD
        '
        Me.LLBLD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLD.AutoSize = True
        Me.LLBLD.Location = New System.Drawing.Point(347, 466)
        Me.LLBLD.Name = "LLBLD"
        Me.LLBLD.Size = New System.Drawing.Size(78, 16)
        Me.LLBLD.TabIndex = 1241
        Me.LLBLD.TabStop = True
        Me.LLBLD.Text = "Dólar Hoy"
        '
        'LLBLF
        '
        Me.LLBLF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LLBLF.AutoSize = True
        Me.LLBLF.Location = New System.Drawing.Point(213, 466)
        Me.LLBLF.Name = "LLBLF"
        Me.LLBLF.Size = New System.Drawing.Size(78, 16)
        Me.LLBLF.TabIndex = 1240
        Me.LLBLF.TabStop = True
        Me.LLBLF.Text = "Dólar Hoy"
        '
        'LBLTC
        '
        Me.LBLTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLTC.AutoSize = True
        Me.LBLTC.Location = New System.Drawing.Point(45, 466)
        Me.LBLTC.Name = "LBLTC"
        Me.LBLTC.Size = New System.Drawing.Size(78, 16)
        Me.LBLTC.TabIndex = 1239
        Me.LBLTC.TabStop = True
        Me.LBLTC.Text = "Dólar Hoy"
        '
        'TXTTC
        '
        Me.TXTTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTC.Location = New System.Drawing.Point(715, 460)
        Me.TXTTC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTTC.MaxLength = 15
        Me.TXTTC.Name = "TXTTC"
        Me.TXTTC.Size = New System.Drawing.Size(97, 22)
        Me.TXTTC.TabIndex = 1237
        Me.TXTTC.Text = "1.0"
        Me.TXTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(603, 466)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 16)
        Me.Label29.TabIndex = 1238
        Me.Label29.Text = "Tipo Cambio"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(723, 411)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 16)
        Me.Label28.TabIndex = 1236
        Me.Label28.Text = "Moneda"
        '
        'CBMON
        '
        Me.CBMON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBMON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMON.FormattingEnabled = True
        Me.CBMON.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBMON.Location = New System.Drawing.Point(715, 430)
        Me.CBMON.Name = "CBMON"
        Me.CBMON.Size = New System.Drawing.Size(198, 24)
        Me.CBMON.TabIndex = 1235
        '
        'CBCP
        '
        Me.CBCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCP.FormattingEnabled = True
        Me.CBCP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCP.Location = New System.Drawing.Point(203, 314)
        Me.CBCP.Name = "CBCP"
        Me.CBCP.Size = New System.Drawing.Size(256, 24)
        Me.CBCP.TabIndex = 1234
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 322)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(161, 16)
        Me.Label19.TabIndex = 1233
        Me.Label19.Text = "Condiciones de Pago:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 1230
        Me.Label4.Text = "Forma de Pago"
        '
        'TXTTAR
        '
        Me.TXTTAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTAR.Location = New System.Drawing.Point(603, 432)
        Me.TXTTAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTTAR.MaxLength = 4
        Me.TXTTAR.Name = "TXTTAR"
        Me.TXTTAR.Size = New System.Drawing.Size(97, 22)
        Me.TXTTAR.TabIndex = 1228
        '
        'CBFP
        '
        Me.CBFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFP.FormattingEnabled = True
        Me.CBFP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBFP.Location = New System.Drawing.Point(271, 430)
        Me.CBFP.Name = "CBFP"
        Me.CBFP.Size = New System.Drawing.Size(303, 24)
        Me.CBFP.TabIndex = 1227
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(603, 372)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 55)
        Me.Label16.TabIndex = 1232
        Me.Label16.Text = "4 dígitos Tarjeta o Cheque"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 1231
        Me.Label6.Text = "Método de Pago"
        '
        'CBMP
        '
        Me.CBMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMP.FormattingEnabled = True
        Me.CBMP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBMP.Location = New System.Drawing.Point(45, 430)
        Me.CBMP.Name = "CBMP"
        Me.CBMP.Size = New System.Drawing.Size(204, 24)
        Me.CBMP.TabIndex = 1226
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ForeColor = System.Drawing.Color.White
        Me.BTNGUARDAR.Image = CType(resources.GetObject("BTNGUARDAR.Image"), System.Drawing.Image)
        Me.BTNGUARDAR.Location = New System.Drawing.Point(447, 602)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 80)
        Me.BTNGUARDAR.TabIndex = 1229
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.RB7)
        Me.TabPage2.Controls.Add(Me.RB1)
        Me.TabPage2.Controls.Add(Me.RB2)
        Me.TabPage2.Controls.Add(Me.GB2)
        Me.TabPage2.Controls.Add(Me.GB1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(991, 703)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complemento INE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(38, 617)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(193, 16)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://sif.ine.mx/loginUTF/"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(37, 590)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(397, 16)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Lugar donde el cliente puede obtener el Id Contabilidad "
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(539, 433)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(427, 145)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = resources.GetString("Label22.Text")
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(37, 433)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(479, 145)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = resources.GetString("Label23.Text")
        '
        'RB7
        '
        Me.RB7.AutoSize = True
        Me.RB7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB7.Location = New System.Drawing.Point(775, 49)
        Me.RB7.Name = "RB7"
        Me.RB7.Size = New System.Drawing.Size(120, 20)
        Me.RB7.TabIndex = 24
        Me.RB7.Text = "Pre Campaña"
        Me.RB7.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(37, 49)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(90, 20)
        Me.RB1.TabIndex = 23
        Me.RB1.Text = "Ordinario"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Checked = True
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(545, 49)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(92, 20)
        Me.RB2.TabIndex = 22
        Me.RB2.TabStop = True
        Me.RB2.Text = "Campaña"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.BTNQC)
        Me.GB2.Controls.Add(Me.BTNAC)
        Me.GB2.Controls.Add(Me.LBC)
        Me.GB2.Controls.Add(Me.Label24)
        Me.GB2.Controls.Add(Me.TXTCC)
        Me.GB2.Controls.Add(Me.CBEC)
        Me.GB2.Controls.Add(Me.Label25)
        Me.GB2.Controls.Add(Me.RB5)
        Me.GB2.Controls.Add(Me.RB6)
        Me.GB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB2.Location = New System.Drawing.Point(539, 66)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(427, 355)
        Me.GB2.TabIndex = 21
        Me.GB2.TabStop = False
        '
        'BTNQC
        '
        Me.BTNQC.BackColor = System.Drawing.SystemColors.Control
        Me.BTNQC.Image = CType(resources.GetObject("BTNQC.Image"), System.Drawing.Image)
        Me.BTNQC.Location = New System.Drawing.Point(217, 20)
        Me.BTNQC.Name = "BTNQC"
        Me.BTNQC.Size = New System.Drawing.Size(75, 75)
        Me.BTNQC.TabIndex = 19
        Me.BTNQC.UseVisualStyleBackColor = False
        '
        'BTNAC
        '
        Me.BTNAC.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAC.Image = CType(resources.GetObject("BTNAC.Image"), System.Drawing.Image)
        Me.BTNAC.Location = New System.Drawing.Point(125, 20)
        Me.BTNAC.Name = "BTNAC"
        Me.BTNAC.Size = New System.Drawing.Size(75, 75)
        Me.BTNAC.TabIndex = 18
        Me.BTNAC.UseVisualStyleBackColor = False
        '
        'LBC
        '
        Me.LBC.FormattingEnabled = True
        Me.LBC.ItemHeight = 16
        Me.LBC.Location = New System.Drawing.Point(6, 144)
        Me.LBC.Name = "LBC"
        Me.LBC.Size = New System.Drawing.Size(415, 196)
        Me.LBC.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 54)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 16)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Id Contabilidad"
        '
        'TXTCC
        '
        Me.TXTCC.Location = New System.Drawing.Point(6, 73)
        Me.TXTCC.MaxLength = 6
        Me.TXTCC.Name = "TXTCC"
        Me.TXTCC.Size = New System.Drawing.Size(113, 22)
        Me.TXTCC.TabIndex = 15
        '
        'CBEC
        '
        Me.CBEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEC.FormattingEnabled = True
        Me.CBEC.Location = New System.Drawing.Point(6, 103)
        Me.CBEC.Name = "CBEC"
        Me.CBEC.Size = New System.Drawing.Size(415, 24)
        Me.CBEC.TabIndex = 14
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(315, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Ámbito"
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Location = New System.Drawing.Point(318, 47)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(64, 20)
        Me.RB5.TabIndex = 12
        Me.RB5.TabStop = True
        Me.RB5.Text = "Local"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB6
        '
        Me.RB6.AutoSize = True
        Me.RB6.Location = New System.Drawing.Point(318, 73)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(80, 20)
        Me.RB6.TabIndex = 11
        Me.RB6.TabStop = True
        Me.RB6.Text = "Federal"
        Me.RB6.UseVisualStyleBackColor = True
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.BTNQO)
        Me.GB1.Controls.Add(Me.BTNAO)
        Me.GB1.Controls.Add(Me.LBO)
        Me.GB1.Controls.Add(Me.Label26)
        Me.GB1.Controls.Add(Me.TXTCO)
        Me.GB1.Controls.Add(Me.CBEO)
        Me.GB1.Controls.Add(Me.Label27)
        Me.GB1.Controls.Add(Me.RB3)
        Me.GB1.Controls.Add(Me.RB4)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(31, 66)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(485, 355)
        Me.GB1.TabIndex = 20
        Me.GB1.TabStop = False
        '
        'BTNQO
        '
        Me.BTNQO.BackColor = System.Drawing.SystemColors.Control
        Me.BTNQO.Image = CType(resources.GetObject("BTNQO.Image"), System.Drawing.Image)
        Me.BTNQO.Location = New System.Drawing.Point(217, 22)
        Me.BTNQO.Name = "BTNQO"
        Me.BTNQO.Size = New System.Drawing.Size(75, 75)
        Me.BTNQO.TabIndex = 10
        Me.BTNQO.UseVisualStyleBackColor = False
        '
        'BTNAO
        '
        Me.BTNAO.BackColor = System.Drawing.SystemColors.Control
        Me.BTNAO.Image = CType(resources.GetObject("BTNAO.Image"), System.Drawing.Image)
        Me.BTNAO.Location = New System.Drawing.Point(125, 22)
        Me.BTNAO.Name = "BTNAO"
        Me.BTNAO.Size = New System.Drawing.Size(75, 75)
        Me.BTNAO.TabIndex = 9
        Me.BTNAO.UseVisualStyleBackColor = False
        '
        'LBO
        '
        Me.LBO.FormattingEnabled = True
        Me.LBO.ItemHeight = 16
        Me.LBO.Location = New System.Drawing.Point(6, 144)
        Me.LBO.Name = "LBO"
        Me.LBO.Size = New System.Drawing.Size(468, 196)
        Me.LBO.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 16)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Id Contabilidad"
        '
        'TXTCO
        '
        Me.TXTCO.Location = New System.Drawing.Point(6, 75)
        Me.TXTCO.MaxLength = 6
        Me.TXTCO.Name = "TXTCO"
        Me.TXTCO.Size = New System.Drawing.Size(113, 22)
        Me.TXTCO.TabIndex = 6
        '
        'CBEO
        '
        Me.CBEO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEO.FormattingEnabled = True
        Me.CBEO.Location = New System.Drawing.Point(6, 103)
        Me.CBEO.Name = "CBEO"
        Me.CBEO.Size = New System.Drawing.Size(468, 24)
        Me.CBEO.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(315, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 16)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Tipo Comité"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(318, 49)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(142, 20)
        Me.RB3.TabIndex = 1
        Me.RB3.TabStop = True
        Me.RB3.Text = "Ejecutivo Estatal"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Location = New System.Drawing.Point(318, 75)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(156, 20)
        Me.RB4.TabIndex = 0
        Me.RB4.TabStop = True
        Me.RB4.Text = "Ejecutivo Nacional"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label88)
        Me.TabPage4.Controls.Add(Me.Label64)
        Me.TabPage4.Controls.Add(Me.TXTCEOBS)
        Me.TabPage4.Controls.Add(Me.Label63)
        Me.TabPage4.Controls.Add(Me.GBCEDES)
        Me.TabPage4.Controls.Add(Me.CBCEINCO)
        Me.TabPage4.Controls.Add(Me.Label49)
        Me.TabPage4.Controls.Add(Me.Label48)
        Me.TabPage4.Controls.Add(Me.TXTCETUSD)
        Me.TabPage4.Controls.Add(Me.Label47)
        Me.TabPage4.Controls.Add(Me.TXTCETC)
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.CBCESUB)
        Me.TabPage4.Controls.Add(Me.Label45)
        Me.TabPage4.Controls.Add(Me.Label44)
        Me.TabPage4.Controls.Add(Me.TXTCECURP)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.TXTCERFP)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.Label41)
        Me.TabPage4.Controls.Add(Me.TXTCENCO)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.TXTCECO)
        Me.TabPage4.Controls.Add(Me.CHKCEDD)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.TXTCECPED)
        Me.TabPage4.Controls.Add(Me.CBCETO)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(991, 703)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Complemento Comercio Exterior"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(520, 60)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(169, 16)
        Me.Label88.TabIndex = 1216
        Me.Label88.Text = "* 20-5718444 (Meridian)"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(270, 514)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(113, 16)
        Me.Label64.TabIndex = 1215
        Me.Label64.Text = "Observaciones"
        '
        'TXTCEOBS
        '
        Me.TXTCEOBS.Location = New System.Drawing.Point(273, 533)
        Me.TXTCEOBS.MaxLength = 5000
        Me.TXTCEOBS.Multiline = True
        Me.TXTCEOBS.Name = "TXTCEOBS"
        Me.TXTCEOBS.Size = New System.Drawing.Size(688, 138)
        Me.TXTCEOBS.TabIndex = 1214
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(273, 462)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(77, 16)
        Me.Label63.TabIndex = 1213
        Me.Label63.Text = "Incoterm *"
        '
        'GBCEDES
        '
        Me.GBCEDES.Controls.Add(Me.Label62)
        Me.GBCEDES.Controls.Add(Me.CBCEPAIS)
        Me.GBCEDES.Controls.Add(Me.Label61)
        Me.GBCEDES.Controls.Add(Me.CBCEEDO)
        Me.GBCEDES.Controls.Add(Me.TXTCEREF)
        Me.GBCEDES.Controls.Add(Me.Label60)
        Me.GBCEDES.Controls.Add(Me.TXTCENOINT)
        Me.GBCEDES.Controls.Add(Me.Label59)
        Me.GBCEDES.Controls.Add(Me.TXTCENOEXT)
        Me.GBCEDES.Controls.Add(Me.Label58)
        Me.GBCEDES.Controls.Add(Me.TXTCEMUN)
        Me.GBCEDES.Controls.Add(Me.Label57)
        Me.GBCEDES.Controls.Add(Me.TXTCELOC)
        Me.GBCEDES.Controls.Add(Me.Label56)
        Me.GBCEDES.Controls.Add(Me.TXTCECP)
        Me.GBCEDES.Controls.Add(Me.Label55)
        Me.GBCEDES.Controls.Add(Me.TextBox14)
        Me.GBCEDES.Controls.Add(Me.Label54)
        Me.GBCEDES.Controls.Add(Me.TXTCECALLE)
        Me.GBCEDES.Controls.Add(Me.Label53)
        Me.GBCEDES.Controls.Add(Me.TXTCEDDNOM)
        Me.GBCEDES.Controls.Add(Me.Label52)
        Me.GBCEDES.Controls.Add(Me.TXTCEDDCURP)
        Me.GBCEDES.Controls.Add(Me.Label51)
        Me.GBCEDES.Controls.Add(Me.TXTCERFC)
        Me.GBCEDES.Controls.Add(Me.Label50)
        Me.GBCEDES.Enabled = False
        Me.GBCEDES.Location = New System.Drawing.Point(273, 157)
        Me.GBCEDES.Name = "GBCEDES"
        Me.GBCEDES.Size = New System.Drawing.Size(688, 295)
        Me.GBCEDES.TabIndex = 1188
        Me.GBCEDES.TabStop = False
        Me.GBCEDES.Text = "Destinatario"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(354, 238)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(53, 16)
        Me.Label62.TabIndex = 1211
        Me.Label62.Text = "* País:"
        '
        'CBCEPAIS
        '
        Me.CBCEPAIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEPAIS.FormattingEnabled = True
        Me.CBCEPAIS.Location = New System.Drawing.Point(413, 233)
        Me.CBCEPAIS.Name = "CBCEPAIS"
        Me.CBCEPAIS.Size = New System.Drawing.Size(239, 24)
        Me.CBCEPAIS.TabIndex = 1210
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(37, 238)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(71, 16)
        Me.Label61.TabIndex = 1209
        Me.Label61.Text = "* Estado:"
        '
        'CBCEEDO
        '
        Me.CBCEEDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEEDO.FormattingEnabled = True
        Me.CBCEEDO.Location = New System.Drawing.Point(114, 233)
        Me.CBCEEDO.Name = "CBCEEDO"
        Me.CBCEEDO.Size = New System.Drawing.Size(202, 24)
        Me.CBCEEDO.TabIndex = 1208
        '
        'TXTCEREF
        '
        Me.TXTCEREF.Location = New System.Drawing.Point(114, 263)
        Me.TXTCEREF.MaxLength = 200
        Me.TXTCEREF.Name = "TXTCEREF"
        Me.TXTCEREF.Size = New System.Drawing.Size(538, 22)
        Me.TXTCEREF.TabIndex = 1207
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(20, 263)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(88, 16)
        Me.Label60.TabIndex = 1206
        Me.Label60.Text = "Referencia:"
        '
        'TXTCENOINT
        '
        Me.TXTCENOINT.Location = New System.Drawing.Point(413, 204)
        Me.TXTCENOINT.MaxLength = 200
        Me.TXTCENOINT.Name = "TXTCENOINT"
        Me.TXTCENOINT.Size = New System.Drawing.Size(239, 22)
        Me.TXTCENOINT.TabIndex = 1205
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(319, 207)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(88, 16)
        Me.Label59.TabIndex = 1204
        Me.Label59.Text = "No. Interior:"
        '
        'TXTCENOEXT
        '
        Me.TXTCENOEXT.Location = New System.Drawing.Point(114, 204)
        Me.TXTCENOEXT.MaxLength = 200
        Me.TXTCENOEXT.Name = "TXTCENOEXT"
        Me.TXTCENOEXT.Size = New System.Drawing.Size(199, 22)
        Me.TXTCENOEXT.TabIndex = 1203
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(15, 207)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(93, 16)
        Me.Label58.TabIndex = 1202
        Me.Label58.Text = "No. Exterior:"
        '
        'TXTCEMUN
        '
        Me.TXTCEMUN.Location = New System.Drawing.Point(413, 176)
        Me.TXTCEMUN.MaxLength = 200
        Me.TXTCEMUN.Name = "TXTCEMUN"
        Me.TXTCEMUN.Size = New System.Drawing.Size(239, 22)
        Me.TXTCEMUN.TabIndex = 1201
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(329, 179)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(78, 16)
        Me.Label57.TabIndex = 1200
        Me.Label57.Text = "Municipio:"
        '
        'TXTCELOC
        '
        Me.TXTCELOC.Location = New System.Drawing.Point(114, 176)
        Me.TXTCELOC.MaxLength = 200
        Me.TXTCELOC.Name = "TXTCELOC"
        Me.TXTCELOC.Size = New System.Drawing.Size(199, 22)
        Me.TXTCELOC.TabIndex = 1199
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(27, 179)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(81, 16)
        Me.Label56.TabIndex = 1198
        Me.Label56.Text = "Localidad:"
        '
        'TXTCECP
        '
        Me.TXTCECP.Location = New System.Drawing.Point(413, 148)
        Me.TXTCECP.MaxLength = 200
        Me.TXTCECP.Name = "TXTCECP"
        Me.TXTCECP.Size = New System.Drawing.Size(239, 22)
        Me.TXTCECP.TabIndex = 1197
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(361, 151)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(46, 16)
        Me.Label55.TabIndex = 1196
        Me.Label55.Text = "*C.P.:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(114, 148)
        Me.TextBox14.MaxLength = 200
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(199, 22)
        Me.TextBox14.TabIndex = 1195
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(43, 151)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(65, 16)
        Me.Label54.TabIndex = 1194
        Me.Label54.Text = "Colonia:"
        '
        'TXTCECALLE
        '
        Me.TXTCECALLE.Location = New System.Drawing.Point(114, 120)
        Me.TXTCECALLE.MaxLength = 200
        Me.TXTCECALLE.Name = "TXTCECALLE"
        Me.TXTCECALLE.Size = New System.Drawing.Size(538, 22)
        Me.TXTCECALLE.TabIndex = 1193
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(54, 123)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(54, 16)
        Me.Label53.TabIndex = 1192
        Me.Label53.Text = "*Calle:"
        '
        'TXTCEDDNOM
        '
        Me.TXTCEDDNOM.Location = New System.Drawing.Point(114, 82)
        Me.TXTCEDDNOM.MaxLength = 200
        Me.TXTCEDDNOM.Name = "TXTCEDDNOM"
        Me.TXTCEDDNOM.Size = New System.Drawing.Size(538, 22)
        Me.TXTCEDDNOM.TabIndex = 1191
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(41, 85)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(67, 16)
        Me.Label52.TabIndex = 1190
        Me.Label52.Text = "Nombre:"
        '
        'TXTCEDDCURP
        '
        Me.TXTCEDDCURP.Location = New System.Drawing.Point(114, 53)
        Me.TXTCEDDCURP.MaxLength = 200
        Me.TXTCEDDCURP.Name = "TXTCEDDCURP"
        Me.TXTCEDDCURP.Size = New System.Drawing.Size(538, 22)
        Me.TXTCEDDCURP.TabIndex = 1189
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(54, 56)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(54, 16)
        Me.Label51.TabIndex = 1188
        Me.Label51.Text = "CURP:"
        '
        'TXTCERFC
        '
        Me.TXTCERFC.Location = New System.Drawing.Point(114, 21)
        Me.TXTCERFC.MaxLength = 200
        Me.TXTCERFC.Name = "TXTCERFC"
        Me.TXTCERFC.Size = New System.Drawing.Size(538, 22)
        Me.TXTCERFC.TabIndex = 1187
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(66, 24)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(42, 16)
        Me.Label50.TabIndex = 1186
        Me.Label50.Text = "RFC:"
        '
        'CBCEINCO
        '
        Me.CBCEINCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCEINCO.FormattingEnabled = True
        Me.CBCEINCO.Location = New System.Drawing.Point(273, 481)
        Me.CBCEINCO.Name = "CBCEINCO"
        Me.CBCEINCO.Size = New System.Drawing.Size(688, 24)
        Me.CBCEINCO.TabIndex = 1212
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(22, 605)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(155, 16)
        Me.Label49.TabIndex = 1187
        Me.Label49.Text = "* Campos Requiridos"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(22, 505)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(90, 16)
        Me.Label48.TabIndex = 1186
        Me.Label48.Text = "Total USD *"
        '
        'TXTCETUSD
        '
        Me.TXTCETUSD.Enabled = False
        Me.TXTCETUSD.Location = New System.Drawing.Point(22, 524)
        Me.TXTCETUSD.MaxLength = 50
        Me.TXTCETUSD.Name = "TXTCETUSD"
        Me.TXTCETUSD.ReadOnly = True
        Me.TXTCETUSD.Size = New System.Drawing.Size(208, 22)
        Me.TXTCETUSD.TabIndex = 1185
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(22, 450)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(143, 16)
        Me.Label47.TabIndex = 1184
        Me.Label47.Text = "Tipo Cambio USD *"
        '
        'TXTCETC
        '
        Me.TXTCETC.Enabled = False
        Me.TXTCETC.Location = New System.Drawing.Point(22, 469)
        Me.TXTCETC.MaxLength = 50
        Me.TXTCETC.Name = "TXTCETC"
        Me.TXTCETC.ReadOnly = True
        Me.TXTCETC.Size = New System.Drawing.Size(208, 22)
        Me.TXTCETC.TabIndex = 1183
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(22, 337)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(105, 16)
        Me.Label46.TabIndex = 1182
        Me.Label46.Text = "Sub División *"
        '
        'CBCESUB
        '
        Me.CBCESUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCESUB.FormattingEnabled = True
        Me.CBCESUB.Items.AddRange(New Object() {"0 - No tiene", "1 - Si tiene"})
        Me.CBCESUB.Location = New System.Drawing.Point(22, 356)
        Me.CBCESUB.Name = "CBCESUB"
        Me.CBCESUB.Size = New System.Drawing.Size(208, 24)
        Me.CBCESUB.TabIndex = 1181
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(22, 33)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 16)
        Me.Label45.TabIndex = 1180
        Me.Label45.Text = "Tipo Operación *"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(303, 83)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(266, 16)
        Me.Label44.TabIndex = 1179
        Me.Label44.Text = "CURP Receptor (Solo persona física)"
        '
        'TXTCECURP
        '
        Me.TXTCECURP.Location = New System.Drawing.Point(303, 102)
        Me.TXTCECURP.MaxLength = 50
        Me.TXTCECURP.Name = "TXTCECURP"
        Me.TXTCECURP.Size = New System.Drawing.Size(211, 22)
        Me.TXTCECURP.TabIndex = 1178
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(303, 35)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(277, 16)
        Me.Label43.TabIndex = 1177
        Me.Label43.Text = "Identificación o Registro fiscal del país"
        '
        'TXTCERFP
        '
        Me.TXTCERFP.Location = New System.Drawing.Point(303, 54)
        Me.TXTCERFP.MaxLength = 50
        Me.TXTCERFP.Name = "TXTCERFP"
        Me.TXTCERFP.Size = New System.Drawing.Size(211, 22)
        Me.TXTCERFP.TabIndex = 1176
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(22, 244)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(212, 16)
        Me.Label42.TabIndex = 1175
        Me.Label42.Text = "Número Exportador Confiable"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(22, 263)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(208, 22)
        Me.TextBox5.TabIndex = 1174
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(22, 196)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(191, 16)
        Me.Label41.TabIndex = 1173
        Me.Label41.Text = "Número Certificado Origen"
        '
        'TXTCENCO
        '
        Me.TXTCENCO.Location = New System.Drawing.Point(22, 215)
        Me.TXTCENCO.MaxLength = 50
        Me.TXTCENCO.Name = "TXTCENCO"
        Me.TXTCENCO.Size = New System.Drawing.Size(208, 22)
        Me.TXTCENCO.TabIndex = 1172
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(22, 146)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(143, 16)
        Me.Label40.TabIndex = 1171
        Me.Label40.Text = "Certificado Origen *"
        '
        'TXTCECO
        '
        Me.TXTCECO.Location = New System.Drawing.Point(22, 165)
        Me.TXTCECO.MaxLength = 50
        Me.TXTCECO.Name = "TXTCECO"
        Me.TXTCECO.Size = New System.Drawing.Size(208, 22)
        Me.TXTCECO.TabIndex = 1170
        Me.TXTCECO.Text = "0"
        '
        'CHKCEDD
        '
        Me.CHKCEDD.AutoSize = True
        Me.CHKCEDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCEDD.Location = New System.Drawing.Point(738, 54)
        Me.CHKCEDD.Name = "CHKCEDD"
        Me.CHKCEDD.Size = New System.Drawing.Size(178, 20)
        Me.CHKCEDD.TabIndex = 1169
        Me.CHKCEDD.Text = "Destinatario Diferente"
        Me.CHKCEDD.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(22, 95)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 16)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Clave Pedimento *"
        '
        'TXTCECPED
        '
        Me.TXTCECPED.Location = New System.Drawing.Point(22, 114)
        Me.TXTCECPED.MaxLength = 50
        Me.TXTCECPED.Name = "TXTCECPED"
        Me.TXTCECPED.Size = New System.Drawing.Size(208, 22)
        Me.TXTCECPED.TabIndex = 17
        Me.TXTCECPED.Text = "A1"
        '
        'CBCETO
        '
        Me.CBCETO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCETO.FormattingEnabled = True
        Me.CBCETO.Items.AddRange(New Object() {"Exportación", "Exportación de servicios"})
        Me.CBCETO.Location = New System.Drawing.Point(22, 52)
        Me.CBCETO.Name = "CBCETO"
        Me.CBCETO.Size = New System.Drawing.Size(208, 24)
        Me.CBCETO.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.BTNCRPAGREGAR)
        Me.TabPage6.Controls.Add(Me.BTNBCER)
        Me.TabPage6.Controls.Add(Me.CBCRPTCP)
        Me.TabPage6.Controls.Add(Me.DGVCRP)
        Me.TabPage6.Controls.Add(Me.Label92)
        Me.TabPage6.Controls.Add(Me.TXTCRPSELLO)
        Me.TabPage6.Controls.Add(Me.Label87)
        Me.TabPage6.Controls.Add(Me.TXTCRPCAD)
        Me.TabPage6.Controls.Add(Me.Label86)
        Me.TabPage6.Controls.Add(Me.TXTCRPCER)
        Me.TabPage6.Controls.Add(Me.Label85)
        Me.TabPage6.Controls.Add(Me.Label84)
        Me.TabPage6.Controls.Add(Me.TXTCRPCB)
        Me.TabPage6.Controls.Add(Me.Label83)
        Me.TabPage6.Controls.Add(Me.TXTCRPRFCCB)
        Me.TabPage6.Controls.Add(Me.Label82)
        Me.TabPage6.Controls.Add(Me.TXTCRPCO)
        Me.TabPage6.Controls.Add(Me.Label81)
        Me.TabPage6.Controls.Add(Me.TXTCRPNBCO)
        Me.TabPage6.Controls.Add(Me.Label80)
        Me.TabPage6.Controls.Add(Me.TXTCRPRFCCO)
        Me.TabPage6.Controls.Add(Me.Label79)
        Me.TabPage6.Controls.Add(Me.TXTCRPNOPE)
        Me.TabPage6.Controls.Add(Me.Label78)
        Me.TabPage6.Controls.Add(Me.TXTCRPTC)
        Me.TabPage6.Controls.Add(Me.Label77)
        Me.TabPage6.Controls.Add(Me.Label76)
        Me.TabPage6.Controls.Add(Me.CBCRPMON)
        Me.TabPage6.Controls.Add(Me.Label75)
        Me.TabPage6.Controls.Add(Me.CBCRPFP)
        Me.TabPage6.Controls.Add(Me.DTPCRPFP)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(991, 703)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Complemento Recepción Pagos"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(877, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 80)
        Me.Button5.TabIndex = 1507
        '
        'BTNCRPAGREGAR
        '
        Me.BTNCRPAGREGAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCRPAGREGAR.BackColor = System.Drawing.SystemColors.Control
        Me.BTNCRPAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCRPAGREGAR.ForeColor = System.Drawing.Color.White
        Me.BTNCRPAGREGAR.Image = CType(resources.GetObject("BTNCRPAGREGAR.Image"), System.Drawing.Image)
        Me.BTNCRPAGREGAR.Location = New System.Drawing.Point(753, 362)
        Me.BTNCRPAGREGAR.Name = "BTNCRPAGREGAR"
        Me.BTNCRPAGREGAR.Size = New System.Drawing.Size(80, 78)
        Me.BTNCRPAGREGAR.TabIndex = 1506
        Me.BTNCRPAGREGAR.UseVisualStyleBackColor = False
        '
        'BTNBCER
        '
        Me.BTNBCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBCER.Location = New System.Drawing.Point(930, 249)
        Me.BTNBCER.Name = "BTNBCER"
        Me.BTNBCER.Size = New System.Drawing.Size(54, 33)
        Me.BTNBCER.TabIndex = 1505
        Me.BTNBCER.Text = "..."
        Me.BTNBCER.UseVisualStyleBackColor = True
        '
        'CBCRPTCP
        '
        Me.CBCRPTCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPTCP.FormattingEnabled = True
        Me.CBCRPTCP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPTCP.Location = New System.Drawing.Point(644, 192)
        Me.CBCRPTCP.Name = "CBCRPTCP"
        Me.CBCRPTCP.Size = New System.Drawing.Size(282, 24)
        Me.CBCRPTCP.TabIndex = 1504
        '
        'DGVCRP
        '
        Me.DGVCRP.AllowUserToAddRows = False
        Me.DGVCRP.AllowUserToDeleteRows = False
        Me.DGVCRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serie, Me.CFolio, Me.UUID, Me.TotalComprobante, Me.SaldoAnterior, Me.NumParcialidad, Me.Importe, Me.NuevoSaldo})
        Me.DGVCRP.Location = New System.Drawing.Point(6, 459)
        Me.DGVCRP.Name = "DGVCRP"
        Me.DGVCRP.Size = New System.Drawing.Size(978, 239)
        Me.DGVCRP.TabIndex = 1503
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'CFolio
        '
        Me.CFolio.HeaderText = "CFolio"
        Me.CFolio.Name = "CFolio"
        Me.CFolio.ReadOnly = True
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        '
        'TotalComprobante
        '
        Me.TotalComprobante.HeaderText = "Total Comprobante"
        Me.TotalComprobante.Name = "TotalComprobante"
        Me.TotalComprobante.ReadOnly = True
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.HeaderText = "Saldo Anterior"
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.ReadOnly = True
        '
        'NumParcialidad
        '
        Me.NumParcialidad.HeaderText = "Num Parcialidad"
        Me.NumParcialidad.Name = "NumParcialidad"
        Me.NumParcialidad.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'NuevoSaldo
        '
        Me.NuevoSaldo.HeaderText = "Nuevo Saldo"
        Me.NuevoSaldo.Name = "NuevoSaldo"
        Me.NuevoSaldo.ReadOnly = True
        '
        'Label92
        '
        Me.Label92.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(328, 32)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(124, 16)
        Me.Label92.TabIndex = 1269
        Me.Label92.Text = "* Fecha de Pago"
        '
        'TXTCRPSELLO
        '
        Me.TXTCRPSELLO.Enabled = False
        Me.TXTCRPSELLO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPSELLO.Location = New System.Drawing.Point(153, 321)
        Me.TXTCRPSELLO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPSELLO.MaxLength = 20
        Me.TXTCRPSELLO.Name = "TXTCRPSELLO"
        Me.TXTCRPSELLO.ReadOnly = True
        Me.TXTCRPSELLO.Size = New System.Drawing.Size(772, 22)
        Me.TXTCRPSELLO.TabIndex = 1259
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(61, 323)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(85, 16)
        Me.Label87.TabIndex = 1260
        Me.Label87.Text = "Sello Pago"
        '
        'TXTCRPCAD
        '
        Me.TXTCRPCAD.Enabled = False
        Me.TXTCRPCAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCAD.Location = New System.Drawing.Point(153, 291)
        Me.TXTCRPCAD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPCAD.MaxLength = 20
        Me.TXTCRPCAD.Name = "TXTCRPCAD"
        Me.TXTCRPCAD.ReadOnly = True
        Me.TXTCRPCAD.Size = New System.Drawing.Size(772, 22)
        Me.TXTCRPCAD.TabIndex = 1257
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(43, 292)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(103, 16)
        Me.Label86.TabIndex = 1258
        Me.Label86.Text = "Cadena Pago"
        '
        'TXTCRPCER
        '
        Me.TXTCRPCER.Enabled = False
        Me.TXTCRPCER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCER.Location = New System.Drawing.Point(153, 260)
        Me.TXTCRPCER.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPCER.MaxLength = 20
        Me.TXTCRPCER.Name = "TXTCRPCER"
        Me.TXTCRPCER.ReadOnly = True
        Me.TXTCRPCER.Size = New System.Drawing.Size(772, 22)
        Me.TXTCRPCER.TabIndex = 1255
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(22, 263)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(124, 16)
        Me.Label85.TabIndex = 1256
        Me.Label85.Text = "Certificado Pago"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(497, 195)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(139, 16)
        Me.Label84.TabIndex = 1254
        Me.Label84.Text = "Tipo Cadena Pago"
        '
        'TXTCRPCB
        '
        Me.TXTCRPCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCB.Location = New System.Drawing.Point(644, 162)
        Me.TXTCRPCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPCB.MaxLength = 20
        Me.TXTCRPCB.Name = "TXTCRPCB"
        Me.TXTCRPCB.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPCB.TabIndex = 1251
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(518, 166)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(118, 16)
        Me.Label83.TabIndex = 1252
        Me.Label83.Text = "Cta Beneficiario"
        '
        'TXTCRPRFCCB
        '
        Me.TXTCRPRFCCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPRFCCB.Location = New System.Drawing.Point(644, 132)
        Me.TXTCRPRFCCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPRFCCB.MaxLength = 20
        Me.TXTCRPRFCCB.Name = "TXTCRPRFCCB"
        Me.TXTCRPRFCCB.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPRFCCB.TabIndex = 1249
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(495, 135)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(141, 16)
        Me.Label82.TabIndex = 1250
        Me.Label82.Text = "Rfc Emisor Cta Ben"
        '
        'TXTCRPCO
        '
        Me.TXTCRPCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPCO.Location = New System.Drawing.Point(188, 216)
        Me.TXTCRPCO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPCO.MaxLength = 20
        Me.TXTCRPCO.Name = "TXTCRPCO"
        Me.TXTCRPCO.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPCO.TabIndex = 1247
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(75, 219)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(107, 16)
        Me.Label81.TabIndex = 1248
        Me.Label81.Text = "Cta Ordenante"
        '
        'TXTCRPNBCO
        '
        Me.TXTCRPNBCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPNBCO.Location = New System.Drawing.Point(188, 188)
        Me.TXTCRPNBCO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPNBCO.MaxLength = 20
        Me.TXTCRPNBCO.Name = "TXTCRPNBCO"
        Me.TXTCRPNBCO.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPNBCO.TabIndex = 1245
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(40, 190)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(142, 16)
        Me.Label80.TabIndex = 1246
        Me.Label80.Text = "Nom Banco Ord Ext"
        '
        'TXTCRPRFCCO
        '
        Me.TXTCRPRFCCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPRFCCO.Location = New System.Drawing.Point(188, 160)
        Me.TXTCRPRFCCO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPRFCCO.MaxLength = 20
        Me.TXTCRPRFCCO.Name = "TXTCRPRFCCO"
        Me.TXTCRPRFCCO.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPRFCCO.TabIndex = 1243
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(43, 161)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(139, 16)
        Me.Label79.TabIndex = 1244
        Me.Label79.Text = "Rfc Emisor Cta Ord"
        '
        'TXTCRPNOPE
        '
        Me.TXTCRPNOPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPNOPE.Location = New System.Drawing.Point(188, 132)
        Me.TXTCRPNOPE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPNOPE.MaxLength = 20
        Me.TXTCRPNOPE.Name = "TXTCRPNOPE"
        Me.TXTCRPNOPE.Size = New System.Drawing.Size(282, 22)
        Me.TXTCRPNOPE.TabIndex = 1241
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(22, 132)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(160, 16)
        Me.Label78.TabIndex = 1242
        Me.Label78.Text = "Número de Operación"
        '
        'TXTCRPTC
        '
        Me.TXTCRPTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXTCRPTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCRPTC.Location = New System.Drawing.Point(792, 90)
        Me.TXTCRPTC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCRPTC.MaxLength = 15
        Me.TXTCRPTC.Name = "TXTCRPTC"
        Me.TXTCRPTC.Size = New System.Drawing.Size(97, 22)
        Me.TXTCRPTC.TabIndex = 1239
        Me.TXTCRPTC.Text = "1.0"
        Me.TXTCRPTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label77
        '
        Me.Label77.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(680, 96)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(97, 16)
        Me.Label77.TabIndex = 1240
        Me.Label77.Text = "Tipo Cambio"
        '
        'Label76
        '
        Me.Label76.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(406, 71)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(74, 16)
        Me.Label76.TabIndex = 1238
        Me.Label76.Text = "* Moneda"
        '
        'CBCRPMON
        '
        Me.CBCRPMON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPMON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPMON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPMON.FormattingEnabled = True
        Me.CBCRPMON.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPMON.Location = New System.Drawing.Point(406, 90)
        Me.CBCRPMON.Name = "CBCRPMON"
        Me.CBCRPMON.Size = New System.Drawing.Size(230, 24)
        Me.CBCRPMON.TabIndex = 1237
        '
        'Label75
        '
        Me.Label75.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(33, 71)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(125, 16)
        Me.Label75.TabIndex = 1232
        Me.Label75.Text = "* Forma de Pago"
        '
        'CBCRPFP
        '
        Me.CBCRPFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCRPFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCRPFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCRPFP.FormattingEnabled = True
        Me.CBCRPFP.Items.AddRange(New Object() {"Aguascalientes ", "Baja California ", "Baja California Sur ", "Campeche ", "Chiapas ", "Chihuahua ", "Coahuila ", "Colima ", "Distrito Federal ", "Durango ", "Estado de México ", "Guanajuato ", "Guerrero ", "Hidalgo ", "Jalisco ", "Michoacán ", "Morelos ", "Nayarit ", "Nuevo León ", "Oaxaca ", "Puebla ", "Querétaro ", "Quintana Roo ", "San Luis Potosí ", "Sinaloa ", "Sonora ", "Tabasco ", "Tamaulipas ", "Tlaxcala ", "Veracruz ", "Yucatán ", "Zacatecas "})
        Me.CBCRPFP.Location = New System.Drawing.Point(33, 90)
        Me.CBCRPFP.Name = "CBCRPFP"
        Me.CBCRPFP.Size = New System.Drawing.Size(303, 24)
        Me.CBCRPFP.TabIndex = 1231
        '
        'DTPCRPFP
        '
        Me.DTPCRPFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPCRPFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPCRPFP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPCRPFP.Location = New System.Drawing.Point(459, 24)
        Me.DTPCRPFP.Name = "DTPCRPFP"
        Me.DTPCRPFP.Size = New System.Drawing.Size(126, 26)
        Me.DTPCRPFP.TabIndex = 20
        '
        'BGW
        '
        '
        'TTT
        '
        Me.TTT.BackColor = System.Drawing.Color.Blue
        Me.TTT.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TTT.IsBalloon = True
        Me.TTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTT.ToolTipTitle = "Información"
        '
        'frmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 747)
        Me.Controls.Add(Me.TABC)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1018, 786)
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TABC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRET.ResumeLayout(False)
        Me.GBRET.PerformLayout()
        Me.GBTRAS.ResumeLayout(False)
        Me.GBTRAS.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GBCEDES.ResumeLayout(False)
        Me.GBCEDES.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.DGVCRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Private WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTNCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBCALLE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLDD As System.Windows.Forms.Label
    Friend WithEvents CBEMISOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLDE As System.Windows.Forms.Label
    Friend WithEvents LBLDN As System.Windows.Forms.Label
    Friend WithEvents CBNEG As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTDE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTRFC As System.Windows.Forms.TextBox
    Friend WithEvents CBTC As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TABC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RB7 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNQC As System.Windows.Forms.Button
    Friend WithEvents BTNAC As System.Windows.Forms.Button
    Friend WithEvents LBC As System.Windows.Forms.ListBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TXTCC As System.Windows.Forms.TextBox
    Friend WithEvents CBEC As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents RB5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB6 As System.Windows.Forms.RadioButton
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNQO As System.Windows.Forms.Button
    Friend WithEvents BTNAO As System.Windows.Forms.Button
    Friend WithEvents LBO As System.Windows.Forms.ListBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TXTCO As System.Windows.Forms.TextBox
    Friend WithEvents CBEO As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB4 As System.Windows.Forms.RadioButton
    Friend WithEvents CHKINE As System.Windows.Forms.CheckBox
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents CHKCE As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TXTTCIEPS As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LBLTOT As System.Windows.Forms.Label
    Private WithEvents BTNQUITAR As System.Windows.Forms.Button
    Friend WithEvents LBLSUB As System.Windows.Forms.Label
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents LBLIVA As System.Windows.Forms.Label
    Friend WithEvents TXTTOT As System.Windows.Forms.TextBox
    Friend WithEvents LBLCCL As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTRIVA As System.Windows.Forms.TextBox
    Friend WithEvents TXTISR As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTSUB As System.Windows.Forms.TextBox
    Friend WithEvents TXTIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTIMP As System.Windows.Forms.TextBox
    Friend WithEvents TXTCANT As System.Windows.Forms.TextBox
    Friend WithEvents TXTVU As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTDES As System.Windows.Forms.TextBox
    Friend WithEvents TXTUNI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CBPYS As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CBUNI As System.Windows.Forms.ComboBox
    Friend WithEvents TXTTIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CBFIEPS As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents CBFIVA As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TXTCETUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TXTCETC As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents CBCESUB As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TXTCECURP As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TXTCERFP As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TXTCENCO As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TXTCECO As System.Windows.Forms.TextBox
    Friend WithEvents CHKCEDD As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TXTCECPED As System.Windows.Forms.TextBox
    Friend WithEvents CBCETO As System.Windows.Forms.ComboBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents TXTCEOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GBCEDES As System.Windows.Forms.GroupBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents CBCEPAIS As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents CBCEEDO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCEREF As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents TXTCENOINT As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents TXTCENOEXT As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents TXTCEMUN As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TXTCELOC As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TXTCECP As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TXTCECALLE As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TXTCEDDNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TXTCEDDCURP As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TXTCERFC As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents CBCEINCO As System.Windows.Forms.ComboBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CBUSO As System.Windows.Forms.ComboBox
    Friend WithEvents LLBLP As System.Windows.Forms.LinkLabel
    Friend WithEvents LLBLD As System.Windows.Forms.LinkLabel
    Friend WithEvents LLBLF As System.Windows.Forms.LinkLabel
    Friend WithEvents LBLTC As System.Windows.Forms.LinkLabel
    Friend WithEvents TXTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CBMON As System.Windows.Forms.ComboBox
    Friend WithEvents CBCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTTAR As System.Windows.Forms.TextBox
    Friend WithEvents CBFP As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBMP As System.Windows.Forms.ComboBox
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXTCOM As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents TXTCODINT As System.Windows.Forms.TextBox
    Friend WithEvents GBRET As System.Windows.Forms.GroupBox
    Friend WithEvents TXTIVAR As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents TXTISRR As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents CBFIVAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents CBFISRR As System.Windows.Forms.ComboBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents GBTRAS As System.Windows.Forms.GroupBox
    Friend WithEvents CHKIR As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIT As System.Windows.Forms.CheckBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents TXTIEPS As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents CODINT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetIsr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorIeps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaIeps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UniSat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PYSSAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TASAIVAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORIVAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IEPSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TASAIEPSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORIEPSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TASAISRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOFACTORISRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TXTCRPTC As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents CBCRPMON As System.Windows.Forms.ComboBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents CBCRPFP As System.Windows.Forms.ComboBox
    Friend WithEvents DTPCRPFP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTCRPNOPE As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TTT As System.Windows.Forms.ToolTip
    Friend WithEvents TXTCRPCO As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPNBCO As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPRFCCO As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPRFCCB As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCB As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPSELLO As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCAD As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TXTCRPCER As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents DGVCRP As System.Windows.Forms.DataGridView
    Friend WithEvents CBCRPTCP As System.Windows.Forms.ComboBox
    Friend WithEvents BTNBCER As System.Windows.Forms.Button
    Friend WithEvents BTNCRPAGREGAR As System.Windows.Forms.Button
    Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumParcialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NuevoSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label88 As System.Windows.Forms.Label
End Class
