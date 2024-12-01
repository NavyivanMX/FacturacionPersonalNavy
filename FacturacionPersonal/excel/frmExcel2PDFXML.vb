Imports System.Data.OleDb
Imports System.Net

Public Class frmExcel2PDFXML
    Dim CadenaConexionZ As String

    Dim DTTEMP As New DataTable
    Dim RXML, RPDF As String
    Private Sub frmExcel2PDFXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CadenaConexionZ = "Data Source=187.216.125.213,1433;Network Library=DBMSSOCN;Initial Catalog=FACTURACIONELECTRONICA;User ID=dbaadmin;Password=masterkey"
        RXML = ""
        RPDF = ""
        ACTUALIZALABELS()
        CBREG.SelectedIndex = 0
    End Sub
    Private Sub ACTUALIZALABELS()
        LBLRPDF.Text = "Ruta Pdf: " + RPDF
        LBLRXML.Text = "Ruta Xml: " + RXML
    End Sub
    Private Sub CARGAREXCEL()
        Dim OFD As New OpenFileDialog
        Dim xls_cn As New OleDbConnection
        Dim xls_cmd As New OleDbCommand
        Dim xls_reader As New OleDbDataAdapter
        Dim xlsx As String
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            xlsx = OFD.FileName
            xls_cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + xlsx + ";Extended Properties='Excel 12.0;HDR=No;IMEX=2'"
            xls_cn.Open()
            xls_cmd.CommandText = "SELECT * FROM [" + TXTHOJA.Text + "$]"
            xls_cmd.Connection = xls_cn
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter(xls_cmd)
            Try
                da.Fill(DTTEMP)
                Cursor = Cursors.Default

                DTTEMP.Rows.RemoveAt(0)
                DGV.DataSource = Nothing
                DGV.DataSource = DTTEMP

                DGV.Refresh()
            Catch ex As Exception
                MessageBox.Show("Fallo al cargar información " + ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                xls_cn.Close()
                Cursor = Cursors.Default
            End Try
        End If

    End Sub
    Private Function CopiarArchivos(ByVal RutaOri As String, ByVal RutaDestino As String) As Boolean
        If System.IO.File.Exists(RutaOri) Then
            If Not System.IO.File.Exists(RutaDestino) Then
                Try
                    System.IO.File.Copy(RutaOri, RutaDestino)
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        CARGAREXCEL()
    End Sub
    Private Sub BTNXML_Click(sender As Object, e As EventArgs) Handles BTNXML.Click
        If String.IsNullOrEmpty(RXML) Then
            MessageBox.Show("No se ha especificado la ruta de los xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim QUERY As String
        Dim X As Integer
        If TREG = 0 Then
            TREG = DGV.RowCount - 1
        Else
            If TREG > DGV.RowCount - 1 Then
                TREG = DGV.RowCount - 1
            End If
        End If
        For X = 0 To TREG
            QUERY = "SELECT E.TIPO,C.RUTAXML,F.RFCEMISOR,F.SERIE,F.FOLIO,F.VCFD FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC  INNER JOIN CONFIGURACION C ON E.RFC=C.RFC WHERE F.UUID='" + DGV.Item(3, X).Value.ToString + "'"
            DT = LLENATABLA(QUERY, CadenaConexionZ)
            If DT.Rows.Count >= 1 Then
                If Not CopiarArchivos(RPDF + DT.Rows(0).Item(2).ToString + DT.Rows(0).Item(3).ToString + DT.Rows(0).Item(4).ToString + "PDF.PDF", RPDF + DGV.Item(0, X).Value.ToString + DGV.Item(2, X).Value.ToString + DGV.Item(1, X).Value.ToString + "CFDI.xml") Then
                End If
            End If
        Next
    End Sub
    Private Sub BTNPDF_Click(sender As Object, e As EventArgs) Handles BTNPDF.Click
        If String.IsNullOrEmpty(RPDF) Then
            MessageBox.Show("No se ha especificado la ruta de los pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim QUERY As String
        Dim X As Integer
        If TREG = 0 Then
            TREG = DGV.RowCount - 1
        Else
            If TREG > DGV.RowCount - 1 Then
                TREG = DGV.RowCount - 1
            End If
        End If

        For X = 0 To TREG
            QUERY = "SELECT E.TIPO,C.RUTAPDF,F.RFCEMISOR,F.SERIE,F.FOLIO,F.VCFD FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC  INNER JOIN CONFIGURACION C ON E.RFC=C.RFC WHERE F.UUID='" + DGV.Item(3, X).Value.ToString + "'"
            DT = LLENATABLA(QUERY, CadenaConexionZ)
            If DT.Rows.Count >= 1 Then
                If Not CopiarArchivos(RPDF + DT.Rows(0).Item(2).ToString + DT.Rows(0).Item(3).ToString + DT.Rows(0).Item(4).ToString + "PDF.PDF", RPDF + DGV.Item(0, X).Value.ToString + DGV.Item(2, X).Value.ToString + DGV.Item(1, X).Value.ToString + "PDF.pdf") Then
                    GENERAPDF(DT.Rows(0).Item(0).ToString, DT.Rows(X).Item(1).ToString + DT.Rows(0).Item(2).ToString + DT.Rows(0).Item(3).ToString + DT.Rows(0).Item(4).ToString + "PDF.PDF", DT.Rows(0).Item(2).ToString, DT.Rows(0).Item(3).ToString, DT.Rows(0).Item(4).ToString, DT.Rows(0).Item(5).ToString)
                End If
            End If
        Next
    End Sub
    Private Sub GENERAPDF(ByVal TFAC As Integer, ByVal RUTAARCHIVOPDF As String, ByVal RFCEMISOR As String, ByVal SERIE As String, ByVal FOLIO As Integer, ByVal VERSIONCFD As String)
        Dim QUERY As String
        If VERSIONCFD = "3.3" Then
            QUERY = "SELECT * FROM VRFACTURA33 F where F.RFCEMISOR='" + RFCEMISOR + "' AND F.SERIE='" + SERIE + "' AND F.FOLIO=" + FOLIO.ToString
            'Dim REP As New rptFacturav33
            Dim REP As New rptFEBajamar33
            GUARDARREPORTEDIRECTO(REP, LLENATABLA(QUERY, CadenaConexionZ), CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RUTAARCHIVOPDF, "Enviar a OneNote 2007")
        Else
            QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,DBO.CANTIDADCONLETRATM(F.TOTAL,F.MONEDA) CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,E.LOGOBIDIMENSIONAL CBBEMISOR,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.DESCRIPCION,CONVERT(NUMERIC(15,2),P.VALORUNITARIO,2)VALORUNITARIO,CONVERT(NUMERIC(15,2),P.IMPORTE,2)IMPORTE,F.RETISR,F.RETIVA,F.NOAPROBACION,F.AÑOAPROBACION,F.CBB CBBFACTURA,P.UNIDAD,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.COMENTARIO,P.IEPS,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS),E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO,DBO.APS(F.RFCEMISOR)APS,F.COCINE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + RFCEMISOR + "' AND F.SERIE='" + SERIE + "' AND F.FOLIO=" + FOLIO.ToString
            If TFAC = 1 Then

                Dim REP As New rptFEBajamar33
                GUARDARREPORTEDIRECTO(REP, LLENATABLA(QUERY, CadenaConexionZ), CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RUTAARCHIVOPDF, "Enviar a OneNote 2007")
            Else
                Dim REP As New rptFEBajamar33
                GUARDARREPORTEDIRECTO(REP, LLENATABLA(QUERY, CadenaConexionZ), CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RUTAARCHIVOPDF, "Enviar a OneNote 2007")
            End If
        End If

    End Sub

    Private Sub BTNRUTAXML_Click(sender As Object, e As EventArgs) Handles BTNRUTAXML.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            RXML = Folder.SelectedPath & "\"
        End If
        ACTUALIZALABELS()
    End Sub
    Dim TREG As Integer
    Private Sub CBREG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBREG.SelectedIndexChanged
        If CBREG.SelectedIndex = 0 Then
            TREG = 0
        Else
            TREG = CType(CBREG.Text, Integer)
        End If
    End Sub

    Private Sub BTNRUTAPDF_Click(sender As Object, e As EventArgs) Handles BTNRUTAPDF.Click
        Dim Folder As New FolderBrowserDialog
        If Folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            RPDF = Folder.SelectedPath & "\"
        End If
        ACTUALIZALABELS()
    End Sub


End Class