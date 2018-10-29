Public Class form1
    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        Close()
    End Sub

    Private Sub devolucao_Click(sender As Object, e As EventArgs) Handles devolucao.Click
        formDevolucao.Show()
    End Sub

    Private Sub locacao_Click(sender As Object, e As EventArgs) Handles locacao.Click
        formAluguel.Show()
    End Sub

    Private Sub modCliente_Click(sender As Object, e As EventArgs) Handles modCliente.Click
        formClientes.Show()
    End Sub

    Private Sub modCarro_Click(sender As Object, e As EventArgs) Handles modCarro.Click
        formVeiculos.Show()
    End Sub

    Private Sub gerencial_Click(sender As Object, e As EventArgs) Handles gerencial.Click
        MessageBox.Show("Ainda não tá pronto, pera ae")
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click

    End Sub

    Private Sub MovimentaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçõesToolStripMenuItem.Click


    End Sub

    Private Sub AluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AluguelToolStripMenuItem.Click
        formAluguel.Show()
    End Sub

    Private Sub DevoluçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        formDevolucao.Show()
    End Sub

    Private Sub GerencialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerencialToolStripMenuItem.Click
        MessageBox.Show("Ainda não tá pronto mano, pera ae")
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        formClientes.Show()
    End Sub

    Private Sub CarroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarroToolStripMenuItem.Click
        formVeiculos.Show()
    End Sub
End Class
