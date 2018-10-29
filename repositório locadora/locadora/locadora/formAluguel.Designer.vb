<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAluguel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiaria = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtValidade = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtCnh = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 86)
        Me.GroupBox1.TabIndex = 8
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
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(76, 35)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(238, 20)
        Me.txtPlaca.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDiaria)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.txtAno)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 124)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados do veículo"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 91)
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
        'txtDiaria
        '
        Me.txtDiaria.Location = New System.Drawing.Point(254, 52)
        Me.txtDiaria.Name = "txtDiaria"
        Me.txtDiaria.Size = New System.Drawing.Size(154, 20)
        Me.txtDiaria.TabIndex = 3
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(207, 88)
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
        Me.txtModelo.Location = New System.Drawing.Point(75, 15)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(333, 20)
        Me.txtModelo.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtRG)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtValidade)
        Me.GroupBox3.Controls.Add(Me.txtCategoria)
        Me.GroupBox3.Controls.Add(Me.txtCnh)
        Me.GroupBox3.Controls.Add(Me.txtCel)
        Me.GroupBox3.Controls.Add(Me.txtCpf)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 241)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados do cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "RG"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(81, 31)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(119, 20)
        Me.txtRG.TabIndex = 22
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(149, 169)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(191, 38)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar RG"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Celular"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(227, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Validade"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(227, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Nº CNH"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(213, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "CPF"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Nome"
        '
        'txtValidade
        '
        Me.txtValidade.Location = New System.Drawing.Point(295, 134)
        Me.txtValidade.Name = "txtValidade"
        Me.txtValidade.Size = New System.Drawing.Size(119, 20)
        Me.txtValidade.TabIndex = 6
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(81, 134)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(133, 20)
        Me.txtCategoria.TabIndex = 5
        '
        'txtCnh
        '
        Me.txtCnh.Location = New System.Drawing.Point(295, 99)
        Me.txtCnh.Name = "txtCnh"
        Me.txtCnh.Size = New System.Drawing.Size(119, 20)
        Me.txtCnh.TabIndex = 4
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(81, 99)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(133, 20)
        Me.txtCel.TabIndex = 3
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(253, 31)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(161, 20)
        Me.txtCpf.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(81, 65)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(333, 20)
        Me.txtNome.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.btnImprimir)
        Me.GroupBox4.Controls.Add(Me.btnConf)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Location = New System.Drawing.Point(451, 325)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(348, 181)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datas"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(174, 124)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(157, 40)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(17, 124)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(151, 40)
        Me.btnConf.TabIndex = 21
        Me.btnConf.Text = "Confirmar locação"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(102, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(238, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(111, 93)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(190, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 13)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Diárias"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(299, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Valor total R$"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Devolver"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Retira"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(451, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 215)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        'Button3
        '
        Me.Button3.BackgroundImage = Global.locadora.My.Resources.Resources.Opera_Glasses_icon_icons_com_54155
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(81, 167)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 51)
        Me.Button3.TabIndex = 24
        Me.Button3.UseVisualStyleBackColor = True
        '
        'formAluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 519)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formAluguel"
        Me.Text = "formAluguel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiaria As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtValidade As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtCnh As TextBox
    Friend WithEvents txtCel As TextBox
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRG As TextBox
    Friend WithEvents Button3 As Button
End Class
