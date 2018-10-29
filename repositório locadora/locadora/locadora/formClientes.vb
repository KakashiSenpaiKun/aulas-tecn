Imports MySql.Data.MySqlClient
Public Class formClientes
    Dim constring As String = "server = localhost; userid = root; password = """"; database = locadora"
    Dim DBCon As New MySqlConnection(constring)
    Dim dr As MySqlDataReader
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBinoculos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        sql = "SELECT * From cliente Where rg = '" + txtRG.Text + "'"
        Dim cm As New MySqlCommand(sql, DBCon)
        Try
            DBCon.open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtNome.Text = dr.Item("nome")
                    txtCpf.Text = dr.Item("cpf")
                    txtTel.Text = dr.Item("tel")
                    txtCel.Text = dr.Item("cel")
                    txtCnh.Text = dr.Item("cnh")
                    txtCategoria.Text = dr.Item("categoria")
                    txtValidade.Text = dr.Item("data_validade")
                    txtBairro.Text = dr.Item("bairro")
                    txtEnd.Text = dr.Item("endereco")
                    txtCep.Text = dr.Item("cep")
                    txtEstado.Text = dr.Item("estado")
                    txtCidade.Text = dr.Item("cidade")
                    txtNasc.Text = dr.Item("data_nasc")
                    txtEmail.Text = dr.Item("email")
                End While
            Else
                MessageBox.Show("RG não encontrado", "atenção", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("DEU ERRO PARCEIRO" + ex.Message, "atenção", MessageBoxButtons.OK)
        End Try
        DBCon.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        sql = "insert into cliente (rg,nome,cpf,tel,cel,cnh,categoria,data_validade,bairro,endereco,cep,estado,cidade,data_nasc,email) values 
            (@rg,@nome,@cpf,@tel,@cel,@cnh,@categoria,@data_validade,@bairro,@endereco,@cep,@estado,@cidade,@data_nasc,@email)"
        Dim cm As New MySqlCommand(sql, DBCon)
        cm.Parameters.AddWithValue("@rg", txtRG.Text)
        cm.Parameters.AddWithValue("@nome", txtNome.Text)
        cm.Parameters.AddWithValue("@cpf", txtCpf.Text)
        cm.Parameters.AddWithValue("@tel", txtTel.Text)
        cm.Parameters.AddWithValue("@cel", txtCel.Text)
        cm.Parameters.AddWithValue("@cnh", txtCnh.Text)
        cm.Parameters.AddWithValue("@categoria", txtCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", txtValidade.Text)
        cm.Parameters.AddWithValue("@bairro", txtBairro.Text)
        cm.Parameters.AddWithValue("@endereco", txtEnd.Text)
        cm.Parameters.AddWithValue("@cep", txtCep.Text)
        cm.Parameters.AddWithValue("@estado", txtEstado.Text)
        cm.Parameters.AddWithValue("@cidade", txtCidade.Text)
        cm.Parameters.AddWithValue("@data_nasc", txtNasc.Text)
        cm.Parameters.AddWithValue("@email", txtEmail.Text)
        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            MessageBox.Show("grovou ai mermão", "boagaroto")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erro ao gravar!")
        Finally
            DBCon.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String
        sql = "delete from cliente Where rg = '" + txtRG.Text + "'"
        Try
            Dim cm As New MySqlCommand(sql, DBCon)
            If MessageBox.Show("Confirmar exclusão?", "Permissão para deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DBCon.Open()
                cm.ExecuteNonQuery()
                DBCon.Close()
            Else
                MessageBox.Show("sefudeumano", "boagaroto")
            End If
        Catch ex As Exception
            MessageBox.Show("sefudeumano" + ex.Message, "boagaroto")
        End Try
        DBCon.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String
        sql = "update cliente set rg=@rg, nome=@nome, cpf=@cpf, tel=@tel, cel=@cel, cnh=@cnh, categoria=@categoria, data_validade=@data_validade, bairro=@bairro, endereco=@endereco, cep=@cep, estado=@estado, cidade=@cidade, data_nasc=@data_nasc, email=@email where rg =" + txtRG.Text + ""
        Dim cm As New MySqlCommand(sql, DBCon)
        cm.Parameters.AddWithValue("@rg", txtRG.Text)
        cm.Parameters.AddWithValue("@nome", txtNome.Text)
        cm.Parameters.AddWithValue("@cpf", txtCpf.Text)
        cm.Parameters.AddWithValue("@tel", txtTel.Text)
        cm.Parameters.AddWithValue("@cel", txtCel.Text)
        cm.Parameters.AddWithValue("@cnh", txtCnh.Text)
        cm.Parameters.AddWithValue("@categoria", txtCategoria.Text)
        cm.Parameters.AddWithValue("@data_validade", txtValidade.Text)
        cm.Parameters.AddWithValue("@bairro", txtBairro.Text)
        cm.Parameters.AddWithValue("@endereco", txtEnd.Text)
        cm.Parameters.AddWithValue("@cep", txtCep.Text)
        cm.Parameters.AddWithValue("@estado", txtEstado.Text)
        cm.Parameters.AddWithValue("@cidade", txtCidade.Text)
        cm.Parameters.AddWithValue("@data_nasc", txtNasc.Text)
        cm.Parameters.AddWithValue("@email", txtEmail.Text)
        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            MessageBox.Show("alterou ai mermão", "boagaroto")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erro ao gravar!")
        Finally
            DBCon.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtNome.Clear()
        txtCpf.Clear()
        txtTel.Clear()
        txtCel.Clear()
        txtCnh.Clear()
        txtCategoria.Clear()
        txtValidade.Clear()
        txtBairro.Clear()
        txtEnd.Clear()
        txtCep.Clear()
        txtEstado.Clear()
        txtCidade.Clear()
        txtNasc.Clear()
        txtEmail.Clear()
        txtRG.Clear()
    End Sub
End Class