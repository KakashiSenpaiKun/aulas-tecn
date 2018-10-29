Imports MySql.Data.MySqlClient
Public Class formVeiculos
    Dim constring As String = "server = localhost; userid = root; password = """"; database = locadora"
    Dim DBCon As New MySqlConnection(constring)
    Dim dr As MySqlDataReader
    Private Sub formVeiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formLupa.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        sql = "insert into carro (placa, modelo, ano_fabri, valor_diaria, status, imagem) values (@PLACA, @MODELO, @ANO_FABRI, @VALOR_DIARIA, @STATUS, @IMAGEM)"
        Dim cm As New MySqlCommand(sql, DBCon)
        cm.Parameters.AddWithValue("@PLACA", txtPlaca.Text)
        cm.Parameters.AddWithValue("@MODELO", txtModelo.Text)
        cm.Parameters.AddWithValue("@ANO_FABRI", txtAno.Text)
        cm.Parameters.AddWithValue("@VALOR_DIARIA", txtDiaria.Text)
        cm.Parameters.AddWithValue("@STATUS", txtStatus.Text)
        cm.Parameters.AddWithValue("@IMAGEM", txtImg.Text)
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String
        sql = "update carro set placa=@PLACA, modelo=@MODELO, ano_fabri=@ANO_FABRI, valor_diaria=@VALOR_DIARIA, status=@STATUS, imagem=@IMAGEM where placa='" + txtPlaca.Text + "'"
        Dim cm As New MySqlCommand(sql, DBCon)
        cm.Parameters.AddWithValue("@PLACA", txtPlaca.Text)
        cm.Parameters.AddWithValue("@MODELO", txtModelo.Text)
        cm.Parameters.AddWithValue("@ANO_FABRI", txtAno.Text)
        cm.Parameters.AddWithValue("@VALOR_DIARIA", txtDiaria.Text)
        cm.Parameters.AddWithValue("@STATUS", txtStatus.Text)
        cm.Parameters.AddWithValue("@IMAGEM", txtImg.Text)
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
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
                    txtImg.Text = dr.Item("imagem")
                End While
            Else
                MessageBox.Show("sefudeumano", "boagaroto")
            End If
        Catch ex As Exception
            MessageBox.Show("sefudeumano" + ex.Message, "boagaroto")
        End Try
        DBCon.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String
        sql = "delete from carro Where placa = '" + txtPlaca.Text + "'"
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtPlaca.Clear()
        txtModelo.Clear()
        txtAno.Clear()
        txtDiaria.Clear()
        txtStatus.Clear()
        txtImg.Clear()

        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\imagens\"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            PictureBox1.Load(OpenFileDialog1.FileName)
            txtImg.Text = OpenFileDialog1.SafeFileName

        End If
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged

    End Sub

    Private Sub txtStatus_GotFocus(sender As Object, e As EventArgs) Handles txtStatus.GotFocus
        painel.Visible = True
    End Sub

    Private Sub txtStatus_LostFocus(sender As Object, e As EventArgs) Handles txtStatus.LostFocus
        painel.Visible = False
    End Sub

    Private Sub painel_Paint(sender As Object, e As PaintEventArgs) Handles painel.Paint

    End Sub
End Class