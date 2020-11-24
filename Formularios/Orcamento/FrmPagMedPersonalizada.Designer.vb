<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagMedPersonalizada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagMedPersonalizada))
        Me.rdDiaSemana = New System.Windows.Forms.RadioButton()
        Me.rdDiaMes = New System.Windows.Forms.RadioButton()
        Me.cboDiaSemana = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDiaSemana = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiasAposFechamento = New System.Windows.Forms.ComboBox()
        Me.cboDiaEsp1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiaMesApos = New System.Windows.Forms.TextBox()
        Me.lblVencimento = New System.Windows.Forms.Label()
        Me.btnSelCliente = New System.Windows.Forms.Button()
        Me.txtIE = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdDiaSemana
        '
        Me.rdDiaSemana.AutoSize = True
        Me.rdDiaSemana.ForeColor = System.Drawing.Color.White
        Me.rdDiaSemana.Location = New System.Drawing.Point(9, 43)
        Me.rdDiaSemana.Name = "rdDiaSemana"
        Me.rdDiaSemana.Size = New System.Drawing.Size(83, 17)
        Me.rdDiaSemana.TabIndex = 0
        Me.rdDiaSemana.TabStop = True
        Me.rdDiaSemana.Text = "Dia Semana"
        Me.rdDiaSemana.UseVisualStyleBackColor = True
        '
        'rdDiaMes
        '
        Me.rdDiaMes.AutoSize = True
        Me.rdDiaMes.ForeColor = System.Drawing.Color.White
        Me.rdDiaMes.Location = New System.Drawing.Point(9, 61)
        Me.rdDiaMes.Name = "rdDiaMes"
        Me.rdDiaMes.Size = New System.Drawing.Size(64, 17)
        Me.rdDiaMes.TabIndex = 1
        Me.rdDiaMes.TabStop = True
        Me.rdDiaMes.Text = "Dia Mês"
        Me.rdDiaMes.UseVisualStyleBackColor = True
        '
        'cboDiaSemana
        '
        Me.cboDiaSemana.FormattingEnabled = True
        Me.cboDiaSemana.Location = New System.Drawing.Point(98, 61)
        Me.cboDiaSemana.Name = "cboDiaSemana"
        Me.cboDiaSemana.Size = New System.Drawing.Size(122, 21)
        Me.cboDiaSemana.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(98, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fechamento da Medição" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Dia)"
        '
        'btnDiaSemana
        '
        Me.btnDiaSemana.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDiaSemana.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDiaSemana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDiaSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDiaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiaSemana.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiaSemana.ForeColor = System.Drawing.Color.White
        Me.btnDiaSemana.Location = New System.Drawing.Point(26, 287)
        Me.btnDiaSemana.Name = "btnDiaSemana"
        Me.btnDiaSemana.Size = New System.Drawing.Size(91, 56)
        Me.btnDiaSemana.TabIndex = 4
        Me.btnDiaSemana.Text = "Simular Proximo Pagamento"
        Me.btnDiaSemana.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(229, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Periodo Pagamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Dia)"
        '
        'txtDiasAposFechamento
        '
        Me.txtDiasAposFechamento.FormattingEnabled = True
        Me.txtDiasAposFechamento.Location = New System.Drawing.Point(229, 61)
        Me.txtDiasAposFechamento.Name = "txtDiasAposFechamento"
        Me.txtDiasAposFechamento.Size = New System.Drawing.Size(100, 21)
        Me.txtDiasAposFechamento.TabIndex = 7
        '
        'cboDiaEsp1
        '
        Me.cboDiaEsp1.Location = New System.Drawing.Point(101, 61)
        Me.cboDiaEsp1.Name = "cboDiaEsp1"
        Me.cboDiaEsp1.Size = New System.Drawing.Size(100, 20)
        Me.cboDiaEsp1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(98, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dia Especifico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(204, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Vencimento Dias" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Opcional)"
        '
        'txtDiaMesApos
        '
        Me.txtDiaMesApos.Location = New System.Drawing.Point(207, 60)
        Me.txtDiaMesApos.Name = "txtDiaMesApos"
        Me.txtDiaMesApos.Size = New System.Drawing.Size(100, 20)
        Me.txtDiaMesApos.TabIndex = 10
        '
        'lblVencimento
        '
        Me.lblVencimento.AutoSize = True
        Me.lblVencimento.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimento.ForeColor = System.Drawing.Color.White
        Me.lblVencimento.Location = New System.Drawing.Point(23, 365)
        Me.lblVencimento.Name = "lblVencimento"
        Me.lblVencimento.Size = New System.Drawing.Size(185, 19)
        Me.lblVencimento.TabIndex = 12
        Me.lblVencimento.Text = "Proxima Data de Vencimento"
        '
        'btnSelCliente
        '
        Me.btnSelCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSelCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSelCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnSelCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelCliente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelCliente.ForeColor = System.Drawing.Color.White
        Me.btnSelCliente.Location = New System.Drawing.Point(145, 287)
        Me.btnSelCliente.Name = "btnSelCliente"
        Me.btnSelCliente.Size = New System.Drawing.Size(91, 56)
        Me.btnSelCliente.TabIndex = 13
        Me.btnSelCliente.Text = "Selecionar Cliente"
        Me.btnSelCliente.UseVisualStyleBackColor = True
        '
        'txtIE
        '
        Me.txtIE.Location = New System.Drawing.Point(18, 215)
        Me.txtIE.Name = "txtIE"
        Me.txtIE.ReadOnly = True
        Me.txtIE.Size = New System.Drawing.Size(315, 20)
        Me.txtIE.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(15, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Inscrição Estadual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nome Fantasia"
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.Location = New System.Drawing.Point(18, 91)
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.ReadOnly = True
        Me.txtNomeFantasia.Size = New System.Drawing.Size(315, 20)
        Me.txtNomeFantasia.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Razão Social"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Location = New System.Drawing.Point(18, 133)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.ReadOnly = True
        Me.txtRazaoSocial.Size = New System.Drawing.Size(315, 20)
        Me.txtRazaoSocial.TabIndex = 20
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(18, 173)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.ReadOnly = True
        Me.txtCPF.Size = New System.Drawing.Size(315, 20)
        Me.txtCPF.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "CPF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "CÓD. CLIENTE"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(18, 49)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdDiaMes)
        Me.GroupBox1.Controls.Add(Me.cboDiaEsp1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDiaMesApos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(387, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 115)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCodCliente)
        Me.GroupBox2.Controls.Add(Me.txtIE)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtCPF)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtRazaoSocial)
        Me.GroupBox2.Controls.Add(Me.txtNomeFantasia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 257)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdDiaSemana)
        Me.GroupBox3.Controls.Add(Me.txtDiasAposFechamento)
        Me.GroupBox3.Controls.Add(Me.cboDiaSemana)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(387, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(341, 121)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.InfoText
        Me.MonthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.White
        Me.MonthCalendar1.Location = New System.Drawing.Point(740, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 30
        '
        'FrmPagMedPersonalizada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1052, 453)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSelCliente)
        Me.Controls.Add(Me.lblVencimento)
        Me.Controls.Add(Me.btnDiaSemana)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPagMedPersonalizada"
        Me.Text = "Pagamento de Medição Personalizada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdDiaSemana As RadioButton
    Friend WithEvents rdDiaMes As RadioButton
    Friend WithEvents cboDiaSemana As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDiaSemana As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiasAposFechamento As ComboBox
    Friend WithEvents cboDiaEsp1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiaMesApos As TextBox
    Friend WithEvents lblVencimento As Label
    Friend WithEvents btnSelCliente As Button
    Friend WithEvents txtIE As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeFantasia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
