Imports MySql.Data.MySqlClient
Public Class formBinoculos
    Dim constring As String = "server = localhost; userid = root; password = """"; database = locadora"
    Dim DBCon As New MySqlConnection(constring)
    Dim dr As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formClientes.txtRG.Text = txtNome.Text
        formClientes.Button2.PerformClick()
        formAluguel.txtRG.Text = txtNome.Text
        formAluguel.btnBuscar.PerformClick()

        Close()
    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        DataGridView1.Rows.Clear()
        Dim strSql As String = "SELECT * FROM cliente where nome like '" + txtNome.Text + "%'"
        Dim cm As New MySqlCommand(strSql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("RG"), dr.Item("NOME"), dr.Item("CPF"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK)
        End Try
        DBCon.Close()

    End Sub

    Private Sub txtLimpar_Click(sender As Object, e As EventArgs) Handles txtLimpar.Click
        txtNome.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtNome.Text = DataGridView1.CurrentRow.Cells(0).Value
        GroupBox1.Text = "RG"
    End Sub

    Private Sub formBinoculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Clear()
        DataGridView1.Rows.Clear()
    End Sub
End Class