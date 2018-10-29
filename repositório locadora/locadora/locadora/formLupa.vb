Imports MySql.Data.MySqlClient
Public Class formLupa
    Dim constring As String = "server = localhost; userid = root; password = """"; database = locadora"
    Dim DBCon As New MySqlConnection(constring)
    Dim dr As MySqlDataReader
    Private Sub txtPlaca_TextChanged(sender As Object, e As EventArgs) Handles txtPlaca.TextChanged
        DataGridView1.Rows.Clear()
        Dim strSql As String = "SELECT * FROM carro where placa like '" + txtPlaca.Text + "%'"
        Dim cm As New MySqlCommand(strSql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("PLACA"), dr.Item("MODELO"), dr.Item("VALOR_DIARIA"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK)
        End Try
        DBCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formVeiculos.txtPlaca.Text = txtPlaca.Text
        formVeiculos.Button2.PerformClick()
        formAluguel.txtPlaca.Text = txtPlaca.Text
        formAluguel.Button2.PerformClick()

        Close()
    End Sub

    Private Sub formLupa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPlaca.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtPlaca.Text = DataGridView1.CurrentRow.Cells(0).Value
        GroupBox1.Text = "Placa"
    End Sub
End Class