<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.modCliente = New System.Windows.Forms.Button()
        Me.modCarro = New System.Windows.Forms.Button()
        Me.locacao = New System.Windows.Forms.Button()
        Me.sair = New System.Windows.Forms.Button()
        Me.gerencial = New System.Windows.Forms.Button()
        Me.devolucao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerencialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'modCliente
        '
        Me.modCliente.BackColor = System.Drawing.Color.Turquoise
        Me.modCliente.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modCliente.Location = New System.Drawing.Point(12, 29)
        Me.modCliente.Name = "modCliente"
        Me.modCliente.Size = New System.Drawing.Size(135, 123)
        Me.modCliente.TabIndex = 0
        Me.modCliente.Text = "Módulo Cliente"
        Me.modCliente.UseVisualStyleBackColor = False
        '
        'modCarro
        '
        Me.modCarro.BackColor = System.Drawing.Color.Turquoise
        Me.modCarro.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modCarro.Location = New System.Drawing.Point(210, 29)
        Me.modCarro.Name = "modCarro"
        Me.modCarro.Size = New System.Drawing.Size(135, 123)
        Me.modCarro.TabIndex = 1
        Me.modCarro.Text = "Módulo Carro"
        Me.modCarro.UseVisualStyleBackColor = False
        '
        'locacao
        '
        Me.locacao.BackColor = System.Drawing.Color.Turquoise
        Me.locacao.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locacao.Location = New System.Drawing.Point(411, 29)
        Me.locacao.Name = "locacao"
        Me.locacao.Size = New System.Drawing.Size(135, 123)
        Me.locacao.TabIndex = 2
        Me.locacao.Text = "Locação"
        Me.locacao.UseVisualStyleBackColor = False
        '
        'sair
        '
        Me.sair.BackColor = System.Drawing.Color.Red
        Me.sair.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sair.Location = New System.Drawing.Point(411, 176)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(135, 123)
        Me.sair.TabIndex = 5
        Me.sair.Text = "Sair"
        Me.sair.UseVisualStyleBackColor = False
        '
        'gerencial
        '
        Me.gerencial.BackColor = System.Drawing.Color.Turquoise
        Me.gerencial.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerencial.Location = New System.Drawing.Point(210, 176)
        Me.gerencial.Name = "gerencial"
        Me.gerencial.Size = New System.Drawing.Size(135, 123)
        Me.gerencial.TabIndex = 4
        Me.gerencial.Text = "Gerencial"
        Me.gerencial.UseVisualStyleBackColor = False
        '
        'devolucao
        '
        Me.devolucao.BackColor = System.Drawing.Color.Turquoise
        Me.devolucao.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devolucao.Location = New System.Drawing.Point(12, 176)
        Me.devolucao.Name = "devolucao"
        Me.devolucao.Size = New System.Drawing.Size(135, 123)
        Me.devolucao.TabIndex = 3
        Me.devolucao.Text = "Devolução"
        Me.devolucao.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Image = Global.locadora.My.Resources.Resources.a_pé_é_pior
        Me.Label1.Location = New System.Drawing.Point(12, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 279)
        Me.Label1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem, Me.GerencialToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(558, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.CarroToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'CarroToolStripMenuItem
        '
        Me.CarroToolStripMenuItem.Name = "CarroToolStripMenuItem"
        Me.CarroToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CarroToolStripMenuItem.Text = "Carro"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AluguelToolStripMenuItem, Me.DevoluçãoToolStripMenuItem})
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'AluguelToolStripMenuItem
        '
        Me.AluguelToolStripMenuItem.Name = "AluguelToolStripMenuItem"
        Me.AluguelToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AluguelToolStripMenuItem.Text = "Aluguel"
        '
        'DevoluçãoToolStripMenuItem
        '
        Me.DevoluçãoToolStripMenuItem.Name = "DevoluçãoToolStripMenuItem"
        Me.DevoluçãoToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DevoluçãoToolStripMenuItem.Text = "Devolução"
        '
        'GerencialToolStripMenuItem
        '
        Me.GerencialToolStripMenuItem.Name = "GerencialToolStripMenuItem"
        Me.GerencialToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.GerencialToolStripMenuItem.Text = "Gerencial"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(558, 611)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.gerencial)
        Me.Controls.Add(Me.devolucao)
        Me.Controls.Add(Me.locacao)
        Me.Controls.Add(Me.modCarro)
        Me.Controls.Add(Me.modCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 650)
        Me.MinimumSize = New System.Drawing.Size(574, 650)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modCliente As Button
    Friend WithEvents modCarro As Button
    Friend WithEvents locacao As Button
    Friend WithEvents sair As Button
    Friend WithEvents gerencial As Button
    Friend WithEvents devolucao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerencialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AluguelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevoluçãoToolStripMenuItem As ToolStripMenuItem
End Class
