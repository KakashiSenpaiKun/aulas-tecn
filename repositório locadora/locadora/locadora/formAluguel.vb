Imports MySql.Data.MySqlClient
Public Class formAluguel
    Dim constring As String = "server = localhost; userid = root; password = """"; database = locadora"
    Dim DBCon As New MySqlConnection(constring)
    Dim dr As MySqlDataReader
    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        If (txtStatus.Text = False) Then
            Dim sql, sqll As String
            sql = "insert into movimento (placa, rg, data_retira, data_dev, diarias) values 
            (@placa, @rg, @data_retira, @data_dev, @diarias) 
            update carro set status=1 where placa =" + txtPlaca.Text + ""
            Dim cm As New MySqlCommand(sql, DBCon)
            cm.Parameters.AddWithValue("@placa", txtPlaca.Text)
            cm.Parameters.AddWithValue("@rg", txtRG.Text)
            cm.Parameters.AddWithValue("@data_retira", DateTimePicker1.Value)
            cm.Parameters.AddWithValue("@data_dev", DateTimePicker2.Value)
            cm.Parameters.AddWithValue("@diarias", Label21.Text)
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
        Else
            MessageBox.Show("Escolha outro carro!", "Atenção")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        sql = "SELECT * From carro Where placa = '" + txtPlaca.Text + "'"
        Dim cm As New MySqlCommand(sql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtPlaca.Text = dr.Item("placa")
                    txtModelo.Text = dr.Item("modelo")
                    txtAno.Text = dr.Item("ano_fabri")
                    txtDiaria.Text = dr.Item("valor_diaria")
                    txtStatus.Text = dr.Item("status")
                End While
            Else
                MessageBox.Show("sefudeumano", "boagaroto")
            End If
        Catch ex As Exception
            MessageBox.Show("sefudeumano" + ex.Message, "boagaroto")
        End Try
        DBCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formLupa.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String
        sql = "SELECT * From cliente Where rg = '" + txtRG.Text + "'"
        Dim cm As New MySqlCommand(sql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtRG.Text = dr.Item("rg")
                    txtNome.Text = dr.Item("nome")
                    txtCpf.Text = dr.Item("cpf")
                    txtCel.Text = dr.Item("cel")
                    txtCnh.Text = dr.Item("cnh")
                    txtCategoria.Text = dr.Item("categoria")
                    txtValidade.Text = dr.Item("data_validade")
                End While
            Else
                MessageBox.Show("RG não encontrado", "atenção", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("DEU ERRO PARCEIRO" + ex.Message, "atenção", MessageBoxButtons.OK)
        End Try
        DBCon.Close()
    End Sub

    Private Sub formAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDiaria_TextChanged(sender As Object, e As EventArgs) Handles txtDiaria.TextChanged
        Label25.Text = txtDiaria.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value < DateTimePicker1.Value Then
            MessageBox.Show("Datas Inválidas", "Erro")
            Return
        End If

        Try
            Label21.Text = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) + 1
            Label25.Text = "R$ " & Format((txtDiaria.Text * Label21.Text), "###,###.00")
        Catch ex As Exception
            MessageBox.Show("Entre em contato com o suporte")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formBinoculos.Show()
    End Sub
End Class