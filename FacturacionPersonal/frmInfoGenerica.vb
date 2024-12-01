Public Class frmInfoGenerica
    Dim PDT As DataTable
    Dim Titulo As String
    Private Sub frmInfoGenerica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
    End Sub
    Public Sub MOSTRAR(ByVal vTitulo As String, ByVal vLeyenda As String, ByVal vDT As DataTable)
        Titulo = vTitulo
        Me.Text = Titulo
        Label5.Text = vLeyenda
        PDT = vDT
        DGV.DataSource = vDT

        Dim x As Integer
        For x = 0 To vDT.Columns.Count - 1
            DGV.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next
        Me.WindowState = FormWindowState.Maximized
        Me.ShowDialog()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        ExportarExcel(PDT, Titulo, True, True, Label5.Text)
    End Sub
End Class