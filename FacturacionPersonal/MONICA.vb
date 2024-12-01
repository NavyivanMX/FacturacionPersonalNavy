Imports System.Drawing.Printing
Imports System.Security.Principal
Imports System.Threading
Imports Microsoft.Office.Interop

Module MONICA
    Public RESPUESTAMG As String
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = Color.Black
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    If (ctr.Tag Is Nothing Or ctr.Tag <> "") Then
                                    Else
                                        ctr.ForeColor = COLORDEFAULT
                                    End If

                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.ForeColor = COLORDEFAULT
                        End If

                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form, ByVal ColorFuente As System.Drawing.Color)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = ColorFuente
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Function DgvCellFormatoNumerico() As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight
        CS.Format = "###,###,###,##0.00"
        Return CS
    End Function

    Public Function DgvCellFormatoNumerico(ByVal NumeroDecimales As Integer) As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TEXTO As String
        TEXTO = "###,###,###,##0."
        Dim X As Integer
        For X = 0 To NumeroDecimales - 1
            TEXTO = TEXTO.Insert(16 + X, "0")
        Next
        CS.Format = TEXTO
        Return CS
    End Function
    Public Function CadenaVacia(ByVal texto As String) As Boolean
        If String.IsNullOrEmpty(Trim(texto)) Then
            Return True
        End If
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function BDExtraeUnDato(ByVal QUERY As String, ByVal CADENA As String) As String
        Dim REG As String
        REG = ""
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            REG = LEC(0)
        End If
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Return REG
    End Function
    Private Function NumeroAbcedario(ByVal Num As Integer) As String
        Select Case Num
            Case 1
                Return "A"
            Case 2
                Return "B"
            Case 3
                Return "C"
            Case 4
                Return "D"
            Case 5
                Return "E"
            Case 6
                Return "F"
            Case 7
                Return "G"
            Case 8
                Return "H"
            Case 9
                Return "I"
            Case 10
                Return "J"
            Case 11
                Return "K"
            Case 12
                Return "L"
            Case 13
                Return "M"
            Case 14
                Return "N"
            Case 15
                Return "O"
            Case 16
                Return "P"
            Case 17
                Return "Q"
            Case 18
                Return "R"
            Case 19
                Return "S"
            Case 20
                Return "T"
            Case 21
                Return "U"
            Case 22
                Return "V"
            Case 23
                Return "W"
            Case 24
                Return "X"
            Case 25
                Return "Y"
            Case 26
                Return "Z"
        End Select

    End Function
    Private Function RangoExcel(ByVal COLUMNAS As Integer, ByVal RENGLON As Integer, ByVal INICIO As Boolean) As String
        If COLUMNAS > 25 Then
            COLUMNAS = 25
        End If
        If INICIO Then
            Return "A" + RENGLON.ToString
        Else
            Return NumeroAbcedario(COLUMNAS - 1) + RENGLON.ToString
        End If

        Return ""
    End Function
    Public Function InfoEsAdministrador() As Boolean
        Thread.GetDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim currentPrincipal As WindowsPrincipal = TryCast(Thread.CurrentPrincipal, WindowsPrincipal)
        Return currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Public Function ExportarExcel(ByVal DT As DataTable, ByVal NombreArchivo As String, ByVal Abrirlo As Boolean, Optional ConEncabezado As Boolean = False, Optional SubEncabezado As String = "") As Boolean
        If Not InfoEsAdministrador() Then
            MessageBox.Show("Se recomienda correr el sistema modo Administrador (Click en el botón derecho, ejecutar como administrador) en caso de no funcionar correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        Dim SFD As New System.Windows.Forms.SaveFileDialog
        SFD.FileName = NombreArchivo
        SFD.Filter = "Archivos de Excel (*.xls)|*.xls|" + Chr(34) + "All files (*.*)|*.*;"
        If SFD.ShowDialog = DialogResult.OK Then
            Try
                If System.IO.File.Exists(SFD.FileName) = True Then
                    System.IO.File.Delete(SFD.FileName)
                End If
                '' ESTA PARTE MUESTRA UNA VENTANA DE PROGRESO
                Dim FRM As New Windows.Forms.Form
                FRM.Width = 400
                FRM.Height = 250
                FRM.Text = "Procesando..."
                Dim PB As New ProgressBar
                PB.Minimum = 1
                PB.Maximum = DT.Rows.Count
                PB.Value = 1

                Dim PUNTO As System.Drawing.Point
                PUNTO.X = 10
                PUNTO.Y = 100
                PB.Width = 360
                PB.Height = 50
                PB.Location = PUNTO


                Dim LBL As New Label
                LBL.Height = 20
                LBL.Width = 380
                LBL.TextAlign = ContentAlignment.MiddleCenter
                LBL.BackColor = Color.Transparent
                PUNTO.X = 10
                PUNTO.Y = 15
                LBL.Location = PUNTO

                Dim LBL2 As New Label
                LBL2.Height = 20
                LBL2.Width = 380
                LBL2.TextAlign = ContentAlignment.MiddleCenter
                LBL2.BackColor = Color.Transparent
                PUNTO.X = 10
                PUNTO.Y = 40
                LBL2.Location = PUNTO
                LBL2.BringToFront()

                FRM.Controls.Add(LBL)
                FRM.Controls.Add(LBL2)
                FRM.Controls.Add(PB)
                FRM.MinimizeBox = False
                FRM.MaximizeBox = False
                FRM.StartPosition = FormStartPosition.CenterScreen
                FRM.Icon = frmPrincipal.Icon
                OPVisualizacionForm(FRM)
                FRM.Show()
                'Dim xls As New Microsoft.Office.Interop.Excel.
                Dim excel As New Excel.Application()
                Dim wBook As Microsoft.Office.Interop.Excel.Workbook
                Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

                wBook = excel.Workbooks.Add()
                wSheet = wBook.ActiveSheet()

                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0
                Dim NCOL As Integer
                NCOL = DT.Columns.Count
                Dim ESPACIOS As Integer
                ESPACIOS = 0
                If ConEncabezado Then
                    excel.Range(RangoExcel(DT.Columns.Count, 1, True), RangoExcel(DT.Columns.Count, 1, False)).Merge(True)
                    excel.Cells(1, 1) = frmPrincipal.NombreComun
                    excel.Range(RangoExcel(DT.Columns.Count, 1, True), RangoExcel(DT.Columns.Count, 1, False)).Columns.AutoFit()
                    excel.Range(RangoExcel(DT.Columns.Count, 2, True), RangoExcel(DT.Columns.Count, 2, False)).Merge(True)
                    excel.Range(RangoExcel(DT.Columns.Count + 1, 1, False), RangoExcel(DT.Columns.Count + 1, 2, False)).Merge(True)
                    excel.Cells(2, 1) = SubEncabezado
                    excel.Cells(3, 1) = Now.ToShortDateString
                    excel.Cells(3, 2) = Now.ToShortTimeString
                    ESPACIOS = 3

                    'INSERTAR IMAGEN EN EXCEL
                    Dim Celda As Object = excel.Cells(1, DT.Columns.Count)
                    Dim Izquierda As Single
                    Dim Arriba As Single
                    Dim Ancho As Double = Celda.Offset(1, DT.Columns.Count).Left - Celda.Left
                    Izquierda = Celda.Left + Ancho / 2 - 340 / 2.0F
                    Izquierda = Celda.Left
                    If Izquierda < 1 Then Izquierda = 1
                    Dim Alto As Double = Celda.Offset(1, DT.Columns.Count).Top - Celda.Top
                    Arriba = Celda.Top + Alto / 2 - 255 / 2
                    If Arriba < 1 Then Arriba = 1S
                    Dim ImageFileName As String = IO.Path.Combine(Application.StartupPath, "Imagen.JPG")
                    Try
                        System.IO.File.Delete(ImageFileName)
                        ''My.Resources.folder_red.Save(ImageFileName)
                    Catch ex As Exception

                    End Try
                    excel.Sheets(1).Shapes.AddPicture(ImageFileName, False, True, Izquierda, Arriba, 40, 40)
                End If

                For Each dc In DT.Columns
                    colIndex = colIndex + 1
                    excel.Cells(ESPACIOS + 1, colIndex) = dc.ColumnName
                    excel.Cells(ESPACIOS + 1, colIndex).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
                    excel.Cells(ESPACIOS + 1, colIndex).Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
                Next


                For Each dr In DT.Rows

                    rowIndex = rowIndex + 1
                    LBL.Text = rowIndex.ToString + " de " + DT.Rows.Count.ToString
                    LBL2.Text = FormatNumber((rowIndex / DT.Rows.Count * 100), 2).ToString + " %"


                    PB.Value = rowIndex
                    PB.Refresh()
                    colIndex = 0
                    For Each dc In DT.Columns
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex + ESPACIOS + 1, colIndex) = dr(dc.ColumnName)

                    Next
                Next
                FRM.Close()
                'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
                wSheet.Name = "Navysoluciones"
                wSheet.Rows.Item(1).Font.Bold = 1
                wSheet.Rows.Item(1).HorizontalAlignment = 3
                If ConEncabezado Then
                    wSheet.Rows.Item(2).Font.Bold = 1
                    wSheet.Rows.Item(2).HorizontalAlignment = 3
                End If

                wSheet.Rows.Item(ESPACIOS + 1).Font.Bold = 1
                wSheet.Rows.Item(ESPACIOS + 1).HorizontalAlignment = 3
                'wSheet.Rows.Item(ESPACIOS + 1).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gainsboro)
                wSheet.Columns.AutoFit()
                wSheet.Columns.AutoFit()
                Dim strFileName As String = SFD.FileName
                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try

                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If

                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
                excel.Visible = True
                If Abrirlo Then
                    excel.Workbooks.Open(strFileName)
                    excel.Visible = True
                End If

            Catch ex As Exception
                MessageBox.Show("La información No se puede Guardar, Archivo en Uso. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End Try
        End If

    End Function

    Public Function DgvCellEstilo(ByVal FONDO As Color, ByVal FUENTE As Color) As DataGridViewCellStyle
        Dim RDgvCellEstilo As New DataGridViewCellStyle
        RDgvCellEstilo.BackColor = FONDO
        RDgvCellEstilo.ForeColor = FUENTE
        Return RDgvCellEstilo
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        LISTA2.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
            CB.Items.Add(LEC(2))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByRef LISTA3 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        LISTA2.Clear()
        LISTA3.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
            LISTA3.Add(LEC(2))
            CB.Items.Add(LEC(3))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String, ByVal INI As DateTime, ByVal FIN As DateTime) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.CommandTimeout = 300
        Dim DT As New DataTable
        DA.Fill(DT)
        CONX.Close()
        Return DT
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        DA.SelectCommand.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        DA.SelectCommand.CommandTimeout = 600
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NombreColumna As String = "")
        For Each DC As DataGridViewColumn In DGV.Columns
            If DC.Name <> NombreColumna Then
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Else
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NumeroColumna As Integer = -1)
        Dim NC As Integer
        NC = DGV.ColumnCount
        For X = 0 To NC
            If NC = NumeroColumna Then
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Next
    End Sub
    Public Function OPCargaX(ByRef LISTA As List(Of String), ByRef CB As ComboBox, ByVal VALOR As String) As Boolean
        Dim X As Integer
        For X = 0 To LISTA.Count - 1
            If LISTA(X) = VALOR Then
                CB.SelectedIndex = X
                Return True
            End If
        Next
        Try
            CB.SelectedIndex = 0
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Enum MsgsOk

        Corte
        Reporte
        Informacion
        Exportacion
        Importacion
        Finalizado
        Impresion
        Guardado

    End Enum
    Public Function OPMsgOK(ByVal Msg As MsgsOk) As Boolean

        Dim MM As String
        MM = ""
        Select Case Msg
            Case MsgsOk.Corte
                MM = "El corte se ha realizado correctamente"
            Case MsgsOk.Reporte
                MM = "El reporte se ha creado exitosamente"
            Case MsgsOk.Informacion
                MM = "La información ha sido procesada con éxito"
            Case MsgsOk.Exportacion
                MM = "La exportación ha concluido con éxito"
            Case MsgsOk.Importacion
                MM = "La importacion se ha realizado exitosamente"
            Case MsgsOk.Finalizado
                MM = "La tarea ha finalizado con éxito"
            Case MsgsOk.Impresion
                MM = "La impresión se ha realizado con éxito"
            Case MsgsOk.Guardado
                MM = "La información ha sido guardada correctamente"
        End Select
        MessageBox.Show(MM, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True

    End Function

    Public Function OPMsgOK(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgError(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return True
    End Function
    Public Function OPMsgGuardadoOK() As Boolean
        MessageBox.Show("La información ha sido guardada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If ABC = 6 Then
            Return True
        End If
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String, ByVal BtnNoDefault As Boolean) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ABC = 6 Then
            Return True
        End If
        Return False
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As String
        Dim REG As String
        REG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
            SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()
        Catch ex As Exception
            REG = ex.Message.ToString
        End Try

        Return REG
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String) As String

        RESPUESTAMG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()

        Catch ex As Exception
            RESPUESTAMG = ex.Message.ToString
        End Try

        Return RESPUESTAMG
    End Function
End Module
