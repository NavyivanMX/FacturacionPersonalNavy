Public Class frmReporteFacturas
    Dim LNEG As New List(Of String)
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmReporteFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        QUERY = "SELECT F.RFCEMISOR,F.SERIE,F.FOLIO,N.CENTROCOSTO [CENTRO DE COSTO],N.NOMBRE NEGOCIO,F.RFCCLIENTE,F.NOMBRE CLIENTE,dbo.FNMETODOPAGO(F.FORMAPAGO,F.NFORMAPAGO )[FORMA PAGO],CONVERT(VARCHAR(10),F.FECHA,103)FECHA,DBO.RPOLIZA(F.FECHA)POLIZA,DBO.SUB0(F.RFCEMISOR,F.SERIE,F.FOLIO) [Subtotal 0%],DBO.SUB16(F.RFCEMISOR,F.SERIE,F.FOLIO) [Subtotal 16%],[Subtotal General]=DBO.SUB0(F.RFCEMISOR,F.SERIE,F.FOLIO)+DBO.SUB16(F.RFCEMISOR,F.SERIE,F.FOLIO),[Subtotal IEPS 0%]=DBO.SUBIEPS0(F.RFCEMISOR,F.SERIE,F.FOLIO),[Subtotal IEPS 16%]=DBO.SUBIEPS16(F.RFCEMISOR,F.SERIE,F.FOLIO),[Suma SubTotal Ieps]=DBO.SUBIEPS0(F.RFCEMISOR,F.SERIE,F.FOLIO)+DBO.SUBIEPS16(F.RFCEMISOR,F.SERIE,F.FOLIO),[IEPS 0%]=DBO.IEPS0(F.RFCEMISOR,F.SERIE,F.FOLIO),[IEPS 16%]=DBO.IEPS16(F.RFCEMISOR,F.SERIE,F.FOLIO),DBO.IEPSFACTURA(F.RFCEMISOR,F.SERIE,F.FOLIO) [IEPS Total],F.IVA,F.TOTAL,F.RETISR RETENCIONISR,F.RETIVA RETENCIONIVA,F.ESTADO,E.NOMBRE NOMESTADO,F.VCFD [Versión],DBO.NOTAFACTURA(F.RFCEMISOR,F.SERIE,F.FOLIO)[NOTA/CREDITO],F.TIPOCOMPROBANTE FROM FACTURAS F INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE  WHERE F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.FECHA>=@INI AND F.FECHA<@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUERY += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        QUERY += " ORDER BY F.FECHA"

        DGV.DataSource = BDLlenatabla(QUERY, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1))
        DGV.Columns(27).Visible = False
        DGV.Columns(0).Frozen = True
        DGV.Columns(1).Frozen = True
        DGV.Columns(2).Frozen = True
        DGV.Columns(3).Frozen = True
        DGV.Columns(4).Frozen = True
        DGV.Columns(5).Frozen = True
        DGV.Columns(6).Frozen = True
        DGV.Columns(10).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(11).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(12).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(13).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(14).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(15).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(16).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(17).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(18).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(19).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(20).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(21).DefaultCellStyle = DgvCellFormatoNumerico()
        DGV.Columns(22).DefaultCellStyle = DgvCellFormatoNumerico()

        CHECATABLA()
    End Sub
    Private Sub CHECATABLA()
        Dim S0, S16, I, T, RISR, RIVA, IEPS0, IEPS16 As Double
        S0 = 0
        S16 = 0
        I = 0
        T = 0
        IEPS0 = 0
        IEPS16 = 0
        RISR = 0
        RIVA = 0
        Dim X As Integer
        If DGV.Rows.Count <= 0 Then
            BTNIMPRIMIR.Enabled = False
            Button2.Enabled = False
            BTNMAIL.Enabled = False
        Else
            BTNIMPRIMIR.Enabled = True
            Button2.Enabled = True
            BTNMAIL.Enabled = True
            For X = 0 To DGV.Rows.Count - 1
                If DGV.Item(23, X).Value = 2 Then
                    If DGV.Item(27, X).Value = 2 Then

                        DGV.Rows(X).DefaultCellStyle = DgvCellEstilo(Color.Salmon, Color.Red)

                        S0 -= DGV.Item(10, X).Value
                        S16 -= DGV.Item(11, X).Value
                        IEPS0 -= DGV.Item(15, X).Value
                        IEPS16 -= DGV.Item(16, X).Value
                        I -= DGV.Item(19, X).Value
                        T -= DGV.Item(20, X).Value
                        RISR -= DGV.Item(21, X).Value
                        RIVA -= DGV.Item(22, X).Value
                    Else
                        S0 += DGV.Item(10, X).Value
                        S16 += DGV.Item(11, X).Value
                        IEPS0 += DGV.Item(15, X).Value
                        IEPS16 += DGV.Item(16, X).Value
                        I += DGV.Item(19, X).Value
                        T += DGV.Item(20, X).Value
                        RISR += DGV.Item(21, X).Value
                        RIVA += DGV.Item(22, X).Value
                    End If


                End If
            Next
        End If

        LBLS.Text = FormatNumber(S0, 2).ToString
        LBLS16.Text = FormatNumber(S16, 2).ToString
        LBLI.Text = FormatNumber(I, 2).ToString
        LBLT.Text = FormatNumber(T, 2).ToString
        LBLIEPS.Text = FormatNumber(IEPS0 + IEPS16, 2).ToString
        LBLRISR.Text = FormatNumber(RISR, 2).ToString
        LBLRIVA.Text = FormatNumber(RIVA, 2).ToString
    End Sub

    Private Sub BTNIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNIMPRIMIR.Click
        MOSTRAR()
    End Sub
    Private Sub MOSTRAR()
        If DGV.Item(23, DGV.CurrentRow.Index).Value <> 2 Then
            Dim xyz As Short
            xyz = MessageBox.Show("La Factura se encuentra Cancelada, o sin Timbrar ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If xyz <> 6 Then
                Exit Sub
            End If
        End If
        Dim QUERY As String

        'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,C.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
        'MOSTRARREPORTE(REP, "Factura Electronica", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "Enviar a OneNote 2007")
        Dim ESTADO As String
        ESTADO = DGV.Item(24, DGV.CurrentRow.Index).Value.ToString
        If DGV.Item(25, DGV.CurrentRow.Index).Value = "3.3" Then
            QUERY = "SELECT * FROM VRFACTURA33 F where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
            If ESTADO = "Cancelada" Then
                Dim REP As New rptFEBajamar33CANC
                MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
            Else
                Dim REP As New rptFEBajamar33
                MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
            End If

        Else
            If LTIPO(CBEMISOR.SelectedIndex) = 2 Then
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT,F.UUID,P.CODIGO,P.CANTIDAD,P.UNIDAD, P.DESCRIPCION,P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                QUERY = "SELECT * FROM VRFACTURA F where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                If CType(DGV.Item(21, DGV.CurrentRow.Index).Value, Double) > 0 Or CType(DGV.Item(22, DGV.CurrentRow.Index).Value, Double) > 0 Or CBEMISOR.Text = "COVM930214167" Or CBEMISOR.Text = "VEAA6508272F2" Then
                    If DGV.Item(24, DGV.CurrentRow.Index).Value = "3.2" Then
                        Dim REP As New rptFEBAJAMARISR
                        MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMARISR
                        MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                Else
                    If DGV.Item(24, DGV.CurrentRow.Index).Value = "3.2" Then
                        If DGV.Item(23, DGV.CurrentRow.Index).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        Else
                            Dim REP As New rptFEBAJAMAR4
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        End If
                    Else
                        If DGV.Item(23, DGV.CurrentRow.Index).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        Else
                            Dim REP As New rptFEBAJAMAR4
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        End If
                    End If
                End If
            Else
                QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,F.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,F.CERTIFICADOUSA NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO,T.DESCRIPCION TIPOCOMPROBANTE,MD.NOMBRE MOTIVO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE INNER JOIN TIPOSCOMPROBANTES T ON F.TIPOCOMPROBANTE=T.CLAVE INNER JOIN MOTIVODOCTO MD ON F.TIPO=MD.CLAVE where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                QUERY = "SELECT * FROM VRFACTURA F where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString

                'QUERY = "SELECT F.RFCEMISOR,E.NOMBRE NOMBREFISCAL,F.FECHA,F.SERIE,F.SUBTOTAL,.IVA,F.DESCUENTO,F.TOTAL,F.CCLETRA CANTIDADCONLETRA,CON.NOCERTIFICADO,F.FOLIO,DBO.DOMICILIOMATRIZ(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOMATRIZ,DBO.DOMICILIOEXPEDICION(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICILIOEXPEDICION,E.LOGOTIPO,E.LOGORFC,F.RFCCLIENTE,F.NOMBRE NOMBRECLIENTE,DBO.DIRECCIONCLI1(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI1,DBO.DIRECCIONCLI2(F.RFCEMISOR,F.SERIE,F.FOLIO)DOMICLIOCLI2,M.NOMBRE METODOPAGO,FP.NOMBRE FORMAPAGO,F.CADENAORIGINAL,F.SELLO SELLODIGITAL,F.SELLOSAT, F.UUID, P.CODIGO, P.CANTIDAD,P.UNIDAD, P.DESCRIPCION, P.VALORUNITARIO,P.IMPORTE,F.DIGITOSTC,E.REGIMEN,TXTPAGARE=DBO.TXTPAGARE(F.RFCEMISOR,F.SERIE,F.FOLIO),F.CBB CBBFACTURA,P.IEPS,F.COMENTARIO,P.IVA DIVA,IMPORTELIC=(P.IMPORTE+P.IVA+P.IEPS-P.DESCUENTO),F.RETISR,F.RETIVA,E.CURP,F.COCSAT,P.DESCUENTO DESCUENTOD,CP.NOMBRE CONDICIONESDEPAGO FROM FACTURAS F INNER JOIN EMISORES E ON F.RFCEMISOR=E.RFC INNER JOIN FORMASPAGO FP ON F.FORMAPAGO=FP.CLAVE INNER JOIN METODOSPAGOS M ON F.METODOPAGO=M.CLAVE INNER JOIN CONFIGURACION CON ON E.RFC=CON.RFC INNER JOIN NEGOCIOS N ON F.RFCEMISOR=N.RFC AND F.NEGOCIO=N.CLAVE INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN DOMICILIOSCLIENTES D ON F.RFCCLIENTE=D.RFC AND F.DOMICILIOCLIENTE=D.REGISTRO INNER JOIN DETALLEFACTURAS P ON F.RFCEMISOR=P.RFCEMISOR AND F.SERIE=P.SERIE AND F.FOLIO=P.FOLIO INNER JOIN CONDICIONESDEPAGO CP ON F.CONDICIONESDEPAGO=CP.CLAVE where F.RFCEMISOR='" + CBEMISOR.Text + "' AND F.SERIE='" + DGV.Item(1, DGV.CurrentRow.Index).Value.ToString + "' AND F.FOLIO=" + DGV.Item(2, DGV.CurrentRow.Index).Value.ToString
                If CType(DGV.Item(21, DGV.CurrentRow.Index).Value, Double) > 0 Or CType(DGV.Item(22, DGV.CurrentRow.Index).Value, Double) > 0 Or CBEMISOR.Text = "COVM930214167" Or CBEMISOR.Text = "VEAA6508272F2" Then
                    If DGV.Item(24, DGV.CurrentRow.Index).Value = "3.2" Then
                        Dim REP As New rptFEBAJAMARISR
                        MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                    Else
                        Dim REP As New rptFEBAJAMARISR
                        MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                    End If
                Else
                    If DGV.Item(18, DGV.CurrentRow.Index).Value = "3.2" Then
                        If DGV.Item(23, DGV.CurrentRow.Index).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        Else
                            Dim REP As New rptFEBAJAMAR4
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        End If
                    Else
                        If DGV.Item(23, DGV.CurrentRow.Index).Value = 3 Then
                            Dim REP As New rptFEBAJAMARCANC
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        Else
                            Dim REP As New rptFEBAJAMAR4
                            MOSTRARREPORTE(REP, "Factura", BDLlenatabla(QUERY, frmPrincipal.CadenaConexion), "")
                        End If
                    End If
                End If
            End If
        End If


    End Sub
    Private Sub ENVIARCORREO()
        If DGV.Item(22, DGV.CurrentRow.Index).Value = 3 Then
            MessageBox.Show("La factura no esta activada para Enviarse (Cancelada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim VCC As New frmCorreosClientesFacturas
        VCC.MOSTRARYENVIAR(DGV.Item(0, DGV.CurrentRow.Index).Value.ToString, DGV.Item(1, DGV.CurrentRow.Index).Value.ToString, DGV.Item(2, DGV.CurrentRow.Index).Value)
    End Sub
    Private Sub ENVIARWHATSAPP()
        If DGV.Item(22, DGV.CurrentRow.Index).Value = 3 Then
            MessageBox.Show("La factura no esta activada para Enviarse (Cancelada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Dim VCC As New frmTelefonosWaClientesFacturas
        VCC.MOSTRARYENVIAR(DGV.Item(0, DGV.CurrentRow.Index).Value.ToString, DGV.Item(1, DGV.CurrentRow.Index).Value.ToString, DGV.Item(2, DGV.CurrentRow.Index).Value)
    End Sub
    Private Sub BTNMAIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMAIL.Click
        ENVIARCORREO()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim QUER As String
        QUER = "SELECT F.SERIE,F.FOLIO,C.NOMBRE CLIENTE,F.TOTAL,E.NOMBRE ESTADO,F.RFCEMISOR,EM.NOMBRE,NEGOCIO='" + CBNEG.Text + "',INI=@INI,FIN=DATEADD(DD,-1,@FIN) FROM FACTURAS F INNER JOIN CLIENTES C ON F.RFCCLIENTE=C.RFC INNER JOIN ESTADOSFACTURA E ON F.ESTADO=E.CLAVE INNER JOIN EMISORES EM ON F.RFCEMISOR=EM.RFC WHERE RFCEMISOR='" + CBEMISOR.Text + "' AND FECHA>=@INI AND FECHA<@FIN"
        If CBNEG.SelectedIndex <> 0 Then
            QUER += " AND F.NEGOCIO='" + LNEG(CBNEG.SelectedIndex) + "'"
        End If
        Dim REPI As New rptFacturasRealizadas
        MOSTRARREPORTE(REPI, "Reporte de Facturas", BDLlenatabla(QUER, frmPrincipal.CadenaConexion, DTDE.Value.Date, DTHASTA.Value.Date.AddDays(1)), "")
    End Sub

    Private Sub BTNWA_Click(sender As Object, e As EventArgs) Handles BTNWA.Click
        ENVIARWHATSAPP()
    End Sub
End Class