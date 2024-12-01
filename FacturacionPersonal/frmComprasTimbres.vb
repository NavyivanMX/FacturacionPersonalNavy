Public Class frmComprasTimbres
    Dim LDE As New List(Of String)
    Dim LTIPO As New List(Of String)
    Private Sub frmComprasTimbres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        OPLlenaCombobox(CBEMISOR, LDE, LTIPO, "SELECT NOMBRE,TIPO,RFC FROM EMISORES WHERE EMPRESA=" + frmPrincipal.CORPORATIVO.ToString + " AND TIPO=1", frmPrincipal.CadenaConexion)
    End Sub
    Private Sub LIMPIAR()
        TXTCANT.Text = "0"
        TXTFAC.Text = ""
        TXTOBS.Text = ""
        DTDE.Value = Now
    End Sub
    Private Sub CARGADATOS()
        Dim QUERY As String
        QUERY = "SELECT * FROM dbo.CONTRATOSDETIMBRES WHERE RFC='" + CBEMISOR.Text + "'"
        DGV.DataSource = BDLlenatabla(QUERY, frmPrincipal.CadenaConexion)
        DGV.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub CBEMISOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEMISOR.SelectedIndexChanged
        CARGADATOS()
    End Sub
    Private Sub GUARDAR()
        If Not frmPrincipal.CHECACONX Then
            Exit Sub
        End If
        Dim SQL As New SqlClient.SqlCommand("SPCONTRATOTIMBRES", frmPrincipal.CONX)
        SQL.CommandType = CommandType.StoredProcedure
        SQL.CommandTimeout = 300
        SQL.Parameters.Add("@CANT", SqlDbType.Int).Value = TXTCANT.Text
        SQL.Parameters.Add("@FEC", SqlDbType.DateTime).Value = DTDE.Value.Date
        SQL.Parameters.Add("@RFC", SqlDbType.VarChar).Value = CBEMISOR.Text
        SQL.Parameters.Add("@FAC", SqlDbType.VarChar).Value = TXTFAC.Text
        SQL.Parameters.Add("@OBS", SqlDbType.VarChar).Value = TXTOBS.Text
        SQL.Parameters.Add("@USU", SqlDbType.VarChar).Value = frmPrincipal.Usuario
        SQL.ExecuteNonQuery()
        MessageBox.Show("La Información ha sido Guardada Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        LIMPIAR()
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim xyz As Short
        xyz = MessageBox.Show("¿Esta seguro que desea Eliminar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xyz = 6 Then
            Try
                If Not frmPrincipal.CHECACONX Then
                    Exit Sub
                End If
                Dim SQLELIMINAR As New SqlClient.SqlCommand
                SQLELIMINAR.Connection = frmPrincipal.CONX
                SQLELIMINAR.CommandText = "DELETE FROM CONTRATOSDETIMBRES WHERE RFC='" + DGV.Item(0, DGV.CurrentRow.Index).Value.ToString + "' AND REGISTRO=" + DGV.Item(3, DGV.CurrentRow.Index).Value.ToString
                SQLELIMINAR.ExecuteNonQuery()
                MessageBox.Show("La Información ha sido Eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            CARGADATOS()
        End If
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        GUARDAR()
        CARGADATOS()
    End Sub
End Class