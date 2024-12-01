Public Class frmDesgloseFacturacion
    Dim LNEG As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmDesgloseFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        OPLlenaCombobox(CBEMISOR, LDE, LTIPO, "SELECT NOMBRE,TIPO,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + "", frmPrincipal.CadenaConexion)
        CHECATABLA()
    End Sub

    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        OPLlenaCombobox(CBNEG, LNEG, "SELECT CLAVE,NOMBRE FROM NEGOCIOS WHERE RFC='" + CBEMISOR.Text + "' ORDER BY NOMBRE", frmPrincipal.CadenaConexion, "Todos los Negocios", "")
        LBLDE.Text = LDE(CBEMISOR.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGADATOS()
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,F.RFCCLIENTE,F.NOMBRE CLIENTE,CONVERT(VARCHAR(10),F.FECHA,103)FECHA,DBO.SUB0(F.RFCEMISOR,F.SERIE,F.FOLIO) [Subtotal 0%],DBO.[SUB16](F.RFCEMISOR,F.SERIE,F.FOLIO)[Subtotal 16%],DBO.[TIEPST8](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8%],DBO.[TIEPST8I0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8% IVA 0%],DBO.[TIEPST8I16](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8% IVA 16%],DBO.[TIEPST0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT],DBO.[TIEPST0I0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT IVA 0%],DBO.[TIEPST0I16](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT IVA 16%],DBO.[IEPSFACTURA](F.RFCEMISOR,F.SERIE,F.FOLIO) [TOTAL IEPS],F.IVA,F.TOTAL,E.NOMBRE [Estado Factura] FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE   WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"
        DGV.DataSource = BDLlenatabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()
        Dim S0, S16, I, T, RISR, RIVA, IEPS0, IEPS8, IEPS0I0, IEPS0I16, IEPS8I0, IEPS8I16 As Double
        S0 = 0
        S16 = 0
        I = 0
        T = 0
        IEPS0 = 0
        IEPS8 = 0
        RISR = 0
        RIVA = 0
        IEPS0I0 = 0
        IEPS0I16 = 0
        IEPS8I0 = 0
        IEPS8I16 = 0
        Dim X As Integer
        If DGV.Rows.Count <= 0 Then
            BTNIMPRIMIR.Enabled = False
            BTNMAIL.Enabled = False
        Else
            BTNIMPRIMIR.Enabled = True
            BTNMAIL.Enabled = True
            For X = 0 To DGV.Rows.Count - 1
                If DGV.Item(17, X).Value = "Timbrada" Then
                    S0 += DGV.Item(6, X).Value
                    S16 += DGV.Item(7, X).Value
                    IEPS8 += DGV.Item(8, X).Value
                    IEPS8I0 += DGV.Item(9, X).Value
                    IEPS8I16 += DGV.Item(10, X).Value
                    IEPS0 += DGV.Item(11, X).Value
                    IEPS0I0 += DGV.Item(12, X).Value
                    IEPS0I16 += DGV.Item(13, X).Value
                    I += DGV.Item(15, X).Value
                    T += DGV.Item(16, X).Value
                End If
            Next
        End If

        LBLA.Text = "Sub 0: " + FormatNumber(S0, 2).ToString
        LBLB.Text = "Sub 16: " + FormatNumber(S16, 2).ToString
        LBLC.Text = "Ieps 8: " + FormatNumber(IEPS8, 2).ToString
        LBLD.Text = "Ieps 8 SI: " + FormatNumber(IEPS8I0, 2).ToString
        LBLE.Text = "Ieps 8 CI: " + FormatNumber(IEPS8I16, 2).ToString
        LBLF.Text = "Ieps 0: " + FormatNumber(IEPS0, 2).ToString
        LBLG.Text = "Ieps 0 SI: " + FormatNumber(IEPS0I0, 2).ToString
        LBLH.Text = "Ieps 0 CI: " + FormatNumber(IEPS0I16, 2).ToString
        LBLI.Text = "Tot Ieps: " + FormatNumber(IEPS8 + IEPS0, 2).ToString
        LBLJ.Text = "IVA: " + FormatNumber(I, 2).ToString
        LBLK.Text = "Total: " + FormatNumber(T, 2).ToString

        'LBLL.Text = "Sub 0: " + FormatNumber(S0, 2).ToString
        'LBLM.Text = "Sub 0: " + FormatNumber(S0, 2).ToString
        'LBLN.Text = "Sub 0: " + FormatNumber(S0, 2).ToString
        'LBLO.Text = "Sub 0: " + FormatNumber(S0, 2).ToString
    End Sub

    Private Sub BTNIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIMPRIMIR.Click
        MOSTRAR()
    End Sub
    Private Sub MOSTRAR()
        Dim QUERY, QUERY2 As String
        QUERY = "SELECT F.RFCEMISOR,EM.NOMBRE EMISOR,F.SERIE,F.FOLIO,F.RFCCLIENTE,F.NOMBRE CLIENTE,CONVERT(VARCHAR(10),F.FECHA,103)FECHA,DBO.SUB0(F.RFCEMISOR,F.SERIE,F.FOLIO) [Subtotal 0%],DBO.[SUB16](F.RFCEMISOR,F.SERIE,F.FOLIO)[Subtotal 16%],DBO.[TIEPST8](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8%],DBO.[TIEPST8I0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8% IVA 0%],DBO.[TIEPST8I16](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS TASA 8% IVA 16%],DBO.[TIEPST0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT],DBO.[TIEPST0I0](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT IVA 0%],DBO.[TIEPST0I16](F.RFCEMISOR,F.SERIE,F.FOLIO)[IEPS 1 X LT IVA 16%],DBO.[IEPSFACTURA](F.RFCEMISOR,F.SERIE,F.FOLIO) [TOTAL IEPS],F.IVA,F.TOTAL,E.NOMBRE [Estado Factura],INI=@INI,FIN=DATEADD(dd,-1,@FIN) FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE  INNER JOIN EMISORES EM ON F.RFCEMISOR=EM.RFC WHERE F.ESTADO=2 AND F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        QUERY2 = "SELECT G.NOMBRE GRUPOIEPS,SUM(D.IEPS)IEPS FROM FACTURAS F INNER JOIN DETALLEFACTURAS D ON F.RFCEMISOR=D.RFCEMISOR AND F.SERIE=D.SERIE AND F.FOLIO=D.FOLIO INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN GRUPOIEPS G ON D.GRUPOIEPS=G.CLAVE WHERE F.ESTADO=2 AND F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND N.CLAVE='" + LNEG(CBNEG.SelectedIndex) + "'"
            QUERY2 += " AND N.CLAVE='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"
        QUERY2 += " GROUP BY G.NOMBRE"
        Dim LDT As New List(Of DataTable)
        LDT.Add(BDLlenatabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1)))
        LDT.Add(BDLlenatabla(QUERY2, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1)))

        Dim REP As New rptDesgloseIepsJunto
        MOSTRARMULTIREPORTE(REP, "Concentrado de Ieps", 2, LDT, "")
        'MOSTRARREPORTE(REP, "Desglose de IEPS", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1)), "")
    End Sub
    Private Sub ENVIARCORREO()
        If DGV.Item(22, DGV.CurrentRow.Index).Value = 3 Then
            MessageBox.Show("La factura no esta activada para Enviarse (Cancelada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim VCC As New frmCorreosClientesFacturas
        VCC.MOSTRARYENVIAR(DGV.Item(0, DGV.CurrentRow.Index).Value.ToString, DGV.Item(1, DGV.CurrentRow.Index).Value.ToString, DGV.Item(2, DGV.CurrentRow.Index).Value)
    End Sub
    Private Sub BTNMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMAIL.Click
        ENVIARCORREO()
    End Sub
End Class