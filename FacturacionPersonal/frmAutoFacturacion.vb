Imports System.Xml
Imports System.Data.OleDb
Imports System.Net

Public Class frmAutoFacturacion

    Private Sub frmAutoFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon

        OPVisualizacionForm(Me)
    End Sub
    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function
    Public Function ObtieneClientesNS(ByVal user As String, ByVal pass As String)
        Cursor = Cursors.WaitCursor

        Dim rfc = "" 'textbox3.text
        Try
            'Dim lista As New WSCLIENTE.get
            'lista.reseller_username = user
            'lista.reseller_password = pass
            'lista.taxpayer_id = rfc

            'Dim LRU As WSCLIENTE.ResellerUser

            'Dim response As New WSCLIENTE.getResponse
            'Dim agrega As New WSCLIENTE.RegistrationSOAP
            'response = agrega.get(lista)
            Dim url As String
            Dim usuario As String
            usuario = Environment.UserName
            url = "C:\Users\" & usuario & "\Documents\"

            Dim xDoc As XmlDocument
            xDoc = New XmlDocument
            xDoc.Load(url & "lista.xml")

            Dim m_xmlr As XmlTextReader
            'Creamos el TextReader
            m_xmlr = New XmlTextReader(url & "lista.xml")

            'Desabilitamos las lineas en blanco, 
            'ya no las necesitamos
            m_xmlr.WhitespaceHandling = WhitespaceHandling.None

            'Leemos el archivo y avanzamos al tag de usuarios
            m_xmlr.Read()

            'Leemos el tag usuarios
            m_xmlr.Read()

            'Creamos la secuancia que nos permite 
            'leer el archivo
            While Not m_xmlr.EOF
                'Avanzamos al siguiente tag
                m_xmlr.Read()

                'si no tenemos el elemento inicial 
                'debemos salir del ciclo
                If Not m_xmlr.IsStartElement() Then
                    Exit While
                End If

                'Obtenemos el elemento codigo
                'Dim mCodigo = m_xmlr.GetAttribute("codigo")
                'Read elements firstname and lastname

                m_xmlr.Read()
                'Obtenemos el elemento del Nombre del Usuario
                Dim mNombre = m_xmlr.ReadElementString("status")

                'Obtenemos el elemento del Apellido del Usuario
                Dim mApellido = m_xmlr.ReadElementString("taxpayer_id")
                Dim SQL As New SqlClient.SqlCommand("SPAUTOFACTURACION", frmPrincipal.CONX)
                SQL.CommandType = CommandType.StoredProcedure
                SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = mApellido
                SQL.ExecuteNonQuery()
                'Escribimos el resultado en la consola, 
                'pero tambien podriamos utilizarlos en
                'donde deseemos    
                'Console.WriteLine("Codigo usuario: " & mCodigo _
                '  & " Nombre: " & mNombre _
                '  & " Apellido: " & mApellido)
                'Console.Write(vbCrLf)
            End While

            'Cerramos la lactura del archivo
            m_xmlr.Close()
        Catch ex As Exception
            MsgBox("No se genero la lista porque " & ex.Message)
            Cursor = Cursors.Default
            Return 0
        End Try
        Cursor = Cursors.Default
        Return 0
    End Function
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObtieneClientesNS(My.Settings.USUNS, My.Settings.PWDNS)
    End Sub
    Private Sub CARGACSV()
        Dim OFD As New OpenFileDialog
        Dim PATH As String
        Dim ARCHIVO As String
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim QUITA As Integer
            QUITA = OFD.FileName.LastIndexOfAny("\")
            PATH = OFD.FileName.Remove(QUITA)
            ARCHIVO = OFD.FileName.Substring(QUITA + 1)
        Else
            Exit Sub
        End If
        Dim TABLAPRIN As New DataTable
        Dim DTABLA As New DataTable
        Dim DS As New DataSet
        Dim connectionString As String
        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + PATH + ";" + "Extended Properties=""text;HDR=NO;FMT=Delimited"""
        Dim CONN As New OleDbConnection(connectionString)
        Try
            DS.Tables.Clear()
            Dim DA As New OleDbDataAdapter("SELECT * FROM " + "[" + ARCHIVO + "]", CONN)
            DA.Fill(DS, "TABLA")
            DA.Fill(DS, "TablaTemp")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        DGV.DataSource = Nothing

        TABLAPRIN = New DataTable
        DTABLA = New DataTable
        DTABLA = DS.Tables("TablaTemp")
        TABLAPRIN = DS.Tables("TABLA")
        TABLAPRIN.Rows.RemoveAt(0)
        'TABLAPRIN.Rows.RemoveAt(0)
        'TABLAPRIN.Rows.RemoveAt(0)
        'TABLAPRIN.Rows.RemoveAt(0)
        'TABLAPRIN.Rows.RemoveAt(0)
        DGV.DataSource = TABLAPRIN
        DTABLA.Rows.RemoveAt(0)
        'DTABLA.Rows.RemoveAt(0)
        'DTABLA.Rows.RemoveAt(0)
        'DTABLA.Rows.RemoveAt(0)
        'DTABLA.Rows.RemoveAt(0)
        DGV.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DGV.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DGV.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        'DGV.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        'DGV.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        'DGV.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DGV.Refresh()
        CONN.Close()
        GUARDACSV()
        'AGREGARLOCALIDAD()
    End Sub
    Private Sub GUARDACSV()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SPCOBRANZANS", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.Parameters.Add("@AÑO", SqlDbType.Int).Value = DTDE.Value.Year
        SQL.Parameters.Add("@MES", SqlDbType.Int).Value = DTDE.Value.Month
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar)
        SQL.Parameters.Add("@TIMB", SqlDbType.Int)
        SQL.Parameters.Add("@CANC", SqlDbType.Int)

        Dim X As Integer
        For X = 0 To DGV.Rows.Count - 1
            SQL.Parameters("@RFC").Value = DGV.Item(0, X).Value
            SQL.Parameters("@TIMB").Value = DGV.Item(1, X).Value
            SQL.Parameters("@CANC").Value = DGV.Item(2, X).Value
            SQL.ExecuteNonQuery()
        Next
        DGV.DataSource = Nothing
        DGV.Refresh()
        CARGADATOS()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CARGACSV()
    End Sub
    Private Sub CARGADATOS()
        DGV.DataSource = BDLlenatabla("SELECT RFC,TIMBRES,CANCELADOS FROM COBRANZANS WHERE AÑO='" + DTDE.Value.Year.ToString + "' AND MES='" + DTDE.Value.Month.ToString + "'", frmPrincipal.CadenaConexion)
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns(1).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(2).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        DGV2.DataSource = BDLlenatabla("SELECT RFC,TIMBRES,CANCELADOS FROM COBRANZANS WHERE AÑO='" + DTDE.Value.Year.ToString + "' AND MES='" + DTDE.Value.Month.ToString + "' AND RFC NOT IN (SELECT RFCEMISOR FROM AUTOFACTURACION)", frmPrincipal.CadenaConexion)
        DGV2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV2.Columns(1).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV2.Columns(2).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV2.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        DGV3.DataSource = BDLlenatabla("SELECT N.RFCFACTURAR [RFC FACTURAR],SUM(D.TIMBRES)TIMBRES,SUM(D.TIMBRES * N.COSTO) TOTAL,MAX(N.CUOTA)CUOTA,N.FACTURAR,N.TIMBRESCONCEPTO,N.DOMICILIO FROM COBRANZANS D INNER JOIN AUTOFACTURACION N ON D.RFC=N.RFCEMISOR WHERE D.AÑO='" + DTDE.Value.Year.ToString + "' AND D.MES='" + DTDE.Value.Month.ToString + "'  GROUP BY N.RFCFACTURAR,N.FACTURAR,N.TIMBRESCONCEPTO,N.DOMICILIO", frmPrincipal.CadenaConexion)
        DGV3.Columns(6).Visible = False
        DGV3.Columns(1).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV3.Columns(2).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV3.Columns(3).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV3.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV3.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGV3.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CARGADATOS()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GUARDAR()
    End Sub
    Private Function FOLIO(ByVal SERIE As String) As Integer
        If Not frmPrincipal.CHECACONX Then
            Exit Function
        End If
        Dim SQL As New SqlClient.SqlCommand("SELECT DBO.SIGFOLIO('CIAN801029NPA','" + SERIE + "')", frmPrincipal.CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        Dim REG As Integer
        REG = 1
        If LEC.Read Then
            If LEC(0) Is DBNull.Value Then
                REG = 1
            Else
                REG = LEC(0)
            End If
        End If
        LEC.Close()
        Return REG
    End Function

    Private Sub DGV3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DGV3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If DGV.RowCount <= 0 Then
            Exit Sub
        End If
        Dim QUERY As String
        QUERY = "select D.AÑO,D.MES,D.RFC,D.TIMBRES,D.CANCELADOS
from COBRANZANS D INNER JOIN AUTOFACTURACION N
ON N.RFCEMISOR =D.RFC 
WHERE AÑO=" + DTDE.Value.Year.ToString + " AND MES=" + (DTDE.Value.Month).ToString + "
AND N.RFCFACTURAR ='" + DGV3.Item(0, DGV3.CurrentRow.Index).Value.ToString + "'"
        frmInfoGenerica.MOSTRAR("Relación de timbres de " + DGV3.Item(0, DGV3.CurrentRow.Index).Value.ToString, "Timbres Realizados en Periodo  AÑO:" + DTDE.Value.Year.ToString + " Y MES=" + (DTDE.Value.Month).ToString, BDLlenatabla(QUERY, frmPrincipal.CadenaConexion))
    End Sub
    Private Sub ExtraeConsumos(ByVal Inicio As DateTime, ByVal Fin As DateTime)
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        Dim CUSTOM As New WSCLIENTE.customers
        CUSTOM.username = My.Settings.USUNS
        CUSTOM.password = My.Settings.PWDNS

        Dim NP As Integer
        NP = 1
        Dim RESP As New WSCLIENTE.customersResponse()
        Dim LCLIENTES As New List(Of String)
        LCLIENTES.Clear()

        Dim SoapCustomer As New WSCLIENTE.RegistrationSOAP
        Dim Mensaje As String

        Do
            CUSTOM.page = NP
            NP += 1
            RESP = SoapCustomer.customers(CUSTOM)
            Mensaje = RESP.customersResult.message
            For Each ITEM As WSCLIENTE.ResellerUser In RESP.customersResult.users
                LCLIENTES.Add(ITEM.taxpayer_id)
            Next
        Loop While (Mensaje <> "Nothing found")


        Dim DT As New DataTable
        DT.Columns.Add("RFC")
        DT.Columns.Add("TIMBRES")
        DT.Columns.Add("Cancelados")

        For Each Emisor As String In LCLIENTES
            Dim reporte As New WSNavyUtilerias.report_total
            reporte.username = My.Settings.USUNS
            reporte.password = My.Settings.PWDNS
            reporte.taxpayer_id = Emisor
            reporte.date_from = Inicio
            reporte.date_to = Fin
            Dim response As New WSNavyUtilerias.report_totalResponse
            Dim soap As New WSNavyUtilerias.UtilitiesSOAP
            response = soap.report_total(reporte)
            If response.report_totalResult.error = "" Then
                If response.report_totalResult.result.Length <> 0 Then
                    Dim total_uuid As Array
                    total_uuid = response.report_totalResult.result
                    If Not total_uuid(0).total Is Nothing Then
                        Dim Row As DataRow = DT.NewRow()
                        Row(0) = Emisor
                        Row(1) = total_uuid(0).total
                        Row(2) = 0
                        DT.Rows.Add(Row)
                    End If

                End If
            End If
        Next
        DGVCONSUMOS.DataSource = DT
        DGVCONSUMOS.Refresh()


        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SPCOBRANZANS", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.Parameters.Add("@AÑO", SqlDbType.Int).Value = DTDE.Value.Year
        SQL.Parameters.Add("@MES", SqlDbType.Int).Value = DTDE.Value.Month
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar)
        SQL.Parameters.Add("@TIMB", SqlDbType.Int)
        SQL.Parameters.Add("@CANC", SqlDbType.Int)

        Dim X As Integer
        For X = 0 To DT.Rows.Count - 1
            SQL.Parameters("@RFC").Value = DT.Rows(X).Item(0).ToString
            SQL.Parameters("@TIMB").Value = DT.Rows(X).Item(1).ToString
            SQL.Parameters("@CANC").Value = DT.Rows(X).Item(2).ToString
            SQL.ExecuteNonQuery()
        Next
        DGV.DataSource = Nothing
        DGV.Refresh()
        CARGADATOS()


        OPMsgOK(MsgsOk.Finalizado)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim inicio, fin As DateTime
        inicio = DTDE.Value.AddMonths(-1)
        inicio = DateSerial(inicio.Year, inicio.Month, 1)
        fin = DateSerial(inicio.Year, inicio.Month + 1, 0)
        fin = fin.Date.AddDays(1)
        ExtraeConsumos(inicio, fin)


    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


    'Private Sub GUARDAR()
    '    If Not frmPrincipal.CHECACONX Then
    '        Exit Sub
    '    End If

    '    Dim ELFOLIO As Integer
    '    ELFOLIO = FOLIO("GRAL")
    '    Dim SQL As New SqlClient.SqlCommand("INSERT INTO FACTURAS (RFCEMISOR,SERIE,FOLIO,NEGOCIO,RFCCLIENTE,DOMICILIOCLIENTE,TIPOCOMPROBANTE,METODOPAGO,FORMAPAGO,REFNOTA,SUBTOTAL,IVA,TOTAL,CCLETRA,RETISR,RETIVA,FECHA,TIPOFACTURA,NOMBRE,DIGITOSTC,COMENTARIO,CONDICIONESDEPAGO,MONEDA,TIPOCAMBIO,NMONEDA,NFORMAPAGO,NMETODOPAGO,NTIPOCOMPROBANTE,NUSOCFDI,VCFD) VALUES ('CIAN801029NPA','NAVY'," + ELFOLIO.ToString + ",'GRAL','" + TXTRFC.Text + "','" + LREG(CBCALLE.SelectedIndex).ToString + "','0','0','0','0'," + S.ToString + "," + I.ToString + "," + T.ToString + ",'" + LBLCCL.Text + "','0','0',@FEC,'1','" + TXTNOM.Text + "','No Aplica','" + TXTCOM.Text + "','1','1','1','MXN','" + LFP(CBFP.SelectedIndex) + "','" + LMP(CBMP.SelectedIndex) + "','" + LTC(CBTC.SelectedIndex) + "','G03','3.3')", frmPrincipal.CONX)
    '    SQL.Parameters.Add("@FEC", SqlDbType.DateTime).Value = Now
    '    SQL.ExecuteNonQuery()
    '    Dim SQLD As New SqlClient.SqlCommand("INSERT INTO DETALLEFACTURAS (RFCEMISOR,SERIE,FOLIO,REFNOTA,CODIGO,CANTIDAD,DESCRIPCION,VALORUNITARIO,IMPORTE,REGISTRO,UNIDAD,IEPS,TASAIEPS,IVA,TASAIVA,TIPOFACTORIVA,TIPOFACTORIEPS,ISR,TASAISR,TIPOFACTORISR,PYSSAT,UNISAT,TASAIVAR,TIPOFACTORIVAR,TASAIEPSR,TIPOFACTORIEPSR,ISRR,TASAISRR,TIPOFACTORISRR,IVAR,IEPSR) VALUES ('" + CBEMISOR.Text + "','" + LASERIE + "','" + ELFOLIO.ToString + "','0',@COD,@CANT,@DES,@PRE,@IMP,@REG,@UNI,@IEPS,@TIEPS,@IVA,@TIVA,@FIVA,@FIEPS,@ISR,@TISR,@FISR,@PYSSAT,@UNISAT,@TIVAR,@FIVAR,@TIEPSR,@FIEPSR,@ISRR,@TISRR,@FISRR,@IVAR,@IEPSR)", frmPrincipal.CONX)
    '    SQLD.Parameters.Add("@COD", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@CANT", SqlDbType.Float)
    '    SQLD.Parameters.Add("@DES", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@UNI", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@PRE", SqlDbType.Float)
    '    SQLD.Parameters.Add("@IMP", SqlDbType.Float)
    '    SQLD.Parameters.Add("@REG", SqlDbType.Int)
    '    SQLD.Parameters.Add("@IEPS", SqlDbType.Float)
    '    SQLD.Parameters.Add("@IVA", SqlDbType.Float)

    '    SQLD.Parameters.Add("@TIVA", SqlDbType.Float)
    '    SQLD.Parameters.Add("@FIVA", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@FIEPS", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@TIEPS", SqlDbType.Float)
    '    SQLD.Parameters.Add("@ISR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@TISR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@FISR", SqlDbType.VarChar)


    '    '@PYSSAT,@UNISAT,@TIVAR,@FIVAR,@TIEPSR,@FIEPSR,@ISRR,@TISRR,@FISRR,@IVAR,@IEPSR

    '    SQLD.Parameters.Add("@PYSSAT", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@UNISAT", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@TIVAR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@FIVAR", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@TIEPSR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@FIEPSR", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@ISRR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@TISRR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@FISRR", SqlDbType.VarChar)
    '    SQLD.Parameters.Add("@IVAR", SqlDbType.Float)
    '    SQLD.Parameters.Add("@IEPSR", SqlDbType.Float)



    '    Dim X As Integer
    '    For X = 0 To DGV.Rows.Count - 1
    '        SQLD.Parameters("@COD").Value = DGV.Item(0, X).Value.ToString
    '        SQLD.Parameters("@CANT").Value = DGV.Item(1, X).Value
    '        SQLD.Parameters("@DES").Value = DGV.Item(2, X).Value.ToString
    '        SQLD.Parameters("@UNI").Value = DGV.Item(3, X).Value.ToString
    '        SQLD.Parameters("@PRE").Value = DGV.Item(4, X).Value
    '        SQLD.Parameters("@IMP").Value = DGV.Item(5, X).Value
    '        SQLD.Parameters("@IVA").Value = DGV.Item(6, X).Value
    '        SQLD.Parameters("@IEPS").Value = DGV.Item(7, X).Value
    '        SQLD.Parameters("@IVAR").Value = DGV.Item(8, X).Value
    '        SQLD.Parameters("@ISRR").Value = DGV.Item(9, X).Value


    '        SQLD.Parameters("@REG").Value = X.ToString



    '        SQLD.Parameters("@FIVA").Value = DGV.Item(11, X).Value
    '        SQLD.Parameters("@TIVA").Value = DGV.Item(12, X).Value
    '        SQLD.Parameters("@FIEPS").Value = DGV.Item(13, X).Value
    '        SQLD.Parameters("@TIEPS").Value = DGV.Item(14, X).Value
    '        If CHKCE.Checked Then
    '            SQLD.Parameters("@UNISAT").Value = "KGM"
    '        Else
    '            SQLD.Parameters("@UNISAT").Value = DGV.Item(15, X).Value.ToString
    '        End If

    '        SQLD.Parameters("@PYSSAT").Value = DGV.Item(16, X).Value.ToString

    '        SQLD.Parameters("@TIVAR").Value = DGV.Item(17, X).Value
    '        SQLD.Parameters("@FIVAR").Value = DGV.Item(18, X).Value

    '        SQLD.Parameters("@TISRR").Value = DGV.Item(22, X).Value
    '        SQLD.Parameters("@FISRR").Value = DGV.Item(23, X).Value


    '        SQLD.Parameters("@ISR").Value = DGV.Item(19, X).Value
    '        SQLD.Parameters("@TISR").Value = DGV.Item(20, X).Value
    '        SQLD.Parameters("@FISR").Value = DGV.Item(21, X).Value

    '        SQLD.Parameters("@IEPSR").Value = "0"
    '        SQLD.Parameters("@TIEPSR").Value = "0"
    '        SQLD.Parameters("@FIEPSR").Value = "3"

    '        SQLD.ExecuteNonQuery()
    '    Next
    '    SQL.Dispose()
    '    SQLD.Dispose()

    'End Sub
End Class