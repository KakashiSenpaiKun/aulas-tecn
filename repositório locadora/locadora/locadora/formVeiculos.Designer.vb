<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVeiculos
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtImg = New System.Windows.Forms.TextBox()
        Me.txtDiaria = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.painel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.painel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(441, 346)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(195, 35)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Sair"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(441, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(195, 35)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Limpar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(441, 226)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(195, 35)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Alterar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(441, 168)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 35)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Excluir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(195, 35)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Incluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.painel)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtImg)
        Me.GroupBox2.Controls.Add(Me.txtDiaria)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.txtAno)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 351)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 217)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Diária"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Imagem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Status da locação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ano"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Modelo"
        '
        'txtImg
        '
        Me.txtImg.Location = New System.Drawing.Point(264, 89)
        Me.txtImg.Name = "txtImg"
        Me.txtImg.Size = New System.Drawing.Size(144, 20)
        Me.txtImg.TabIndex = 4
        '
        'txtDiaria
        '
        Me.txtDiaria.Location = New System.Drawing.Point(254, 52)
        Me.txtDiaria.Name = "txtDiaria"
        Me.txtDiaria.Size = New System.Drawing.Size(154, 20)
        Me.txtDiaria.TabIndex = 3
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(105, 89)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(103, 20)
        Me.txtStatus.TabIndex = 2
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(75, 52)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(133, 20)
        Me.txtAno.TabIndex = 1
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(75, 16)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(333, 20)
        Me.txtModelo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 79)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Placa"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(437, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.locadora.My.Resources.Resources.magnifier1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(372, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(76, 35)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(238, 20)
        Me.txtPlaca.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(441, 408)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(195, 35)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Selecionar carro"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'painel
        '
        Me.painel.BackColor = System.Drawing.Color.NavajoWhite
        Me.painel.Controls.Add(Me.Label7)
        Me.painel.Controls.Add(Me.Label6)
        Me.painel.Location = New System.Drawing.Point(75, 115)
        Me.painel.Name = "painel"
        Me.painel.Size = New System.Drawing.Size(172, 106)
        Me.painel.TabIndex = 20
        Me.painel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "0 - para carro disponível"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "1 - para carro indisponível"
        '
        'formVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 461)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formVeiculos"
        Me.Text = "Veículos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.painel.ResumeLayout(False)
        Me.painel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImg As TextBox
    Friend WithEvents txtDiaria As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents painel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
