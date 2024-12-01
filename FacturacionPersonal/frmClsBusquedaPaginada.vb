Public Class frmClsBusquedaPaginada
    Dim DT As New DataTable
    Dim DA As SqlClient.SqlDataAdapter
    Public TREG As New DataTable
    Dim VTABLA, VCAMPOS, VCAMPOBUS, VLABELREG, VCADENA, VCONDICION As String
    Dim VCOLUMNA, VPAGINA, VRENGLONES As Integer
    Dim CONZ As New SqlClient.SqlConnection
    Dim VQUERY As String
    Dim TP As Integer
    Private Sub frmClsBusquedaPaginada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        frmPrincipal.CHECACONX()
        TXTBUS.SelectAll()
        TXTBUS.Clear()
        TXTBUS.Focus()
    End Sub
    Private Function CONTEOREGISTRO() As Integer
        Dim REN As Integer
        REN = 0
        Dim SQL As New SqlClient.SqlCommand("SELECT COUNT(" + VCAMPOBUS + ") FROM " + VTABLA + " WHERE " + BUSAVAN(True), CONZ)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            REN = LEC(0)
        End If
        LEC.Close()
        SQL.Dispose()
        Return REN
    End Function
    Public Sub BUSCAR(ByVal TABLA As String, ByVal CAMPOS As String, ByVal CAMPOBUS As String, ByVal NOMVEN As String, ByVal LABELBUS As String, ByVal LABELREG As String, ByVal COLFILL As Integer, ByVal CADENA As String, ByVal MOSTRARINFO As Boolean, ByVal RENGLONES As Integer, ByVal PAGINA As Integer, ByVal CONDICIONAND As String)
        VCADENA = CADENA
        VLABELREG = LABELREG
        VCONDICION = CONDICIONAND
        TXTBUS.Focus()
        Try
            CONZ.Close()
        Catch ex As Exception

        End Try
        Me.Text = NOMVEN
        TXTMOSTRAR.Text = RENGLONES.ToString
        CONZ.ConnectionString = VCADENA
        VTABLA = TABLA
        VCAMPOBUS = CAMPOBUS
        VCAMPOS = CAMPOS
        VCOLUMNA = COLFILL
        VPAGINA = PAGINA
        VRENGLONES = RENGLONES
        Try
            CONZ.Open()
        Catch ex As Exception

        End Try
        ACOMODARPAGINA()
        'VQUERY = "SELECT * FROM ( SELECT ROW_NUMBER() OVER(ORDER BY " + VCAMPOBUS + ") AS NUMERO," + VCAMPOS + " FROM " + VTABLA + " WHERE " + CAMPOBUS + " LIKE '%%' ) AS TBL WHERE NUMERO BETWEEN ((" + VPAGINA.ToString + " - 1) * " + VRENGLONES.ToString + " + 1) AND (" + VPAGINA.ToString + " * " + VRENGLONES.ToString + ") ORDER BY " + CAMPOBUS
        'DT = New DataTable
        'DT.Rows.Clear()
        'DT.Columns.Clear()
        'DGV.DataSource = Nothing
        'LBL2.Text = DT.Rows.Count.ToString + " " + VLABELREG
        'TXTBUS.Text = ""
        'Me.Text = NOMVEN
        'If MOSTRARINFO Then
        '    frmPrincipal.CHECACONX()
        '    DA = New SqlClient.SqlDataAdapter(VQUERY, CONZ)
        '    DA.Fill(DT)
        '    DGV.DataSource = DT
        '    DGV.Columns(VCOLUMNA).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        '    LBL2.Text = DT.Rows.Count.ToString + " " + VLABELREG
        'End If
        LBL1.Text = LABELBUS
        TXTBUS.Focus()
        TXTBUS.SelectAll()
        TXTBUS.Clear()
        TXTBUS.Focus()
        TXTBUS.Text = ""
        GB.Focus()
        TXTBUS.Focus()
        Me.ShowDialog()
        ' TXTBUS.Focus()
    End Sub
    Private Sub ACOMODARPAGINA()
        DT = New DataTable
        DT = BDLlenatabla(BUSAVAN(False), VCADENA)
        DGV.DataSource = DT
        DGV.Columns(VCOLUMNA).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        LBL2.Text = DT.Rows.Count.ToString + " " + VLABELREG
        Dim TR As Integer
        TR = CONTEOREGISTRO()
        TP = Math.Ceiling(TR / VRENGLONES)
        If VPAGINA = 1 Then
            BTNRR.Enabled = False
            BTNANT.Enabled = False
        Else
            BTNRR.Enabled = True
            BTNANT.Enabled = True
        End If
        If VPAGINA = TP Then
            BTNFF.Enabled = False
            BTNSIG.Enabled = False
        Else
            BTNFF.Enabled = True
            BTNSIG.Enabled = True
        End If
        LBLNP.Text = "Página " + VPAGINA.ToString + " de " + TP.ToString + " - Registros [" + TR.ToString + "]"
        GB.Focus()
        TXTBUS.Focus()
    End Sub


    Private Sub ACEPTAR(ByVal B As Boolean)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Debes seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXTBUS.SelectAll()
            TXTBUS.Clear()
            TXTBUS.Focus()
            Exit Sub
        Else
            TREG = New DataTable
            TREG.Columns.Clear()
            TREG.Rows.Clear()
            Dim X As Integer
            For X = 0 To DGV.Columns.Count - 1
                TREG.Columns.Add("" + X.ToString)
            Next
            Dim DOW As System.Data.DataRow = TREG.NewRow
            For X = 0 To DGV.Columns.Count - 1
                If B Then
                    DOW(X) = DGV.Item(X, DGV.CurrentRow.Index - 1).Value.ToString
                Else
                    DOW(X) = DGV.Item(X, DGV.CurrentRow.Index).Value.ToString
                End If
            Next
            TREG.Rows.Add(DOW)
            DGV.DataSource = Nothing
            DT = New DataTable
            Try
                CONZ.Close()
            Catch ex As Exception

            End Try
            TXTBUS.SelectAll()
            TXTBUS.Clear()
            TXTBUS.Focus()
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            TXTBUS.Focus()
        End If
    End Sub

    Private Sub DGV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ACEPTAR(False)
    End Sub
    Public Sub ACTIVAR()
        Me.Show()
        TXTBUS.Focus()
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        TXTBUS.Focus()
        Me.Close()
    End Sub
    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        ACEPTAR(False)
    End Sub
    Dim LTENC As New List(Of String)
    Private Function BUSAVAN(ByVal SOLOEXTRA As Boolean) As String
        LTENC.Clear()
        Dim EXTRA As String
        EXTRA = ""

        Dim NEB As Integer
        Dim TIENEWHERE As String
        TIENEWHERE = True



        Dim TBUS As String
        TBUS = TXTBUS.Text
        Do
            NEB = TBUS.IndexOf(" ")
            If NEB >= 0 Then
                LTENC.Add(TBUS.Substring(0, NEB))
                TBUS = TBUS.Substring(NEB + 1, TBUS.Length - (NEB + 1))
            Else
                LTENC.Add(TBUS)
            End If
        Loop While NEB >= 0

        Dim PRIMERO As Boolean
        PRIMERO = True
        For X = 0 To LTENC.Count - 1
            If PRIMERO Then
                EXTRA += VCAMPOBUS + " LIKE '%" + LTENC(X) + "%' "
                PRIMERO = False
            Else
                EXTRA += " AND " + VCAMPOBUS + " LIKE '%" + LTENC(X) + "%' "

            End If
        Next
        If SOLOEXTRA Then
            Return EXTRA + VCONDICION
        End If
        VQUERY = "SELECT * FROM ( SELECT ROW_NUMBER() OVER(ORDER BY " + VCAMPOBUS + ") AS NUMERO," + VCAMPOS + " FROM " + VTABLA + " WHERE " + EXTRA + VCONDICION + ") AS TBL WHERE NUMERO BETWEEN ((" + VPAGINA.ToString + " - 1) * " + VRENGLONES.ToString + " + 1) AND (" + VPAGINA.ToString + " * " + VRENGLONES.ToString + ") ORDER BY " + VCAMPOBUS
        ' VQUERY = "SELECT * FROM ( SELECT ROW_NUMBER() OVER(ORDER BY " + VCAMPOBUS + ") AS NUMERO," + VCAMPOS + " FROM " + VTABLA + " WHERE " + CAMPOBUS + " LIKE '%%' ) AS TBL WHERE NUMERO BETWEEN ((" + VPAGINA.ToString + " - 1) * " + VRENGLONES.ToString + " + 1) AND (" + VPAGINA.ToString + " * " + VRENGLONES.ToString + ") ORDER BY " + CAMPOBUS

        Return VQUERY
    End Function
    Private Sub TXTBUS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTBUS.KeyPress
        If e.KeyChar = Chr(13) Then
            frmPrincipal.CHECACONX()
            If String.IsNullOrEmpty(TXTBUS.Text) Then
                DT = BDLlenatabla(VQUERY, frmPrincipal.CadenaConexion)
                DGV.DataSource = DT
                DGV.Columns(VCOLUMNA).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                LBL2.Text = DT.Rows.Count.ToString + " " + VLABELREG
            Else
                DT = New DataTable
                DT = BDLlenatabla(BUSAVAN(False), VCADENA)
                DGV.Refresh()

                DGV.DataSource = DT
                DGV.Columns(VCOLUMNA).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                LBL2.Text = DT.Rows.Count.ToString + " " + VLABELREG
            End If
            VPAGINA = 1
            ACOMODARPAGINA()
        End If
 
    End Sub

    Private Sub DGV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        If e.KeyChar = Chr(13) Then
            ACEPTAR(True)
        End If
    End Sub

    Private Sub frmClsBusqueda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            ACEPTAR(False)
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNSIG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSIG.Click
        VPAGINA = VPAGINA + 1
        ACOMODARPAGINA()
    End Sub

    Private Sub BTNANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANT.Click
        VPAGINA = VPAGINA - 1
        ACOMODARPAGINA()
    End Sub

    Private Sub BTNRR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRR.Click
        VPAGINA = 1
        ACOMODARPAGINA()
    End Sub

    Private Sub BTNFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNFF.Click
        VPAGINA = TP
        ACOMODARPAGINA()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMOSTRAR.KeyPress
        If e.KeyChar = Chr(13) Then
            VRENGLONES = TXTMOSTRAR.Text
            ACOMODARPAGINA()
        End If

    End Sub

    Private Sub frmClsBusquedaPaginada_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class