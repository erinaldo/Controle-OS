<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaVisita
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
		Me.dgvVisita = New System.Windows.Forms.DataGridView()
		Me.txtIdentificacao = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNomeCliente = New System.Windows.Forms.TextBox()
		Me.PicDataContato = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtTelefone = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtEndOrcamento = New System.Windows.Forms.TextBox()
		Me.dgvServico = New System.Windows.Forms.DataGridView()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.chkNecessitaVisita = New System.Windows.Forms.CheckBox()
		Me.chkVisitaFeita = New System.Windows.Forms.CheckBox()
		Me.chkNeceEletrica = New System.Windows.Forms.CheckBox()
		Me.chkPintura = New System.Windows.Forms.CheckBox()
		Me.chkOrcamentoFeito = New System.Windows.Forms.CheckBox()
		Me.chkEnvCliente = New System.Windows.Forms.CheckBox()
		Me.chkClienteFechou = New System.Windows.Forms.CheckBox()
		Me.chkFoiPreenForms = New System.Windows.Forms.CheckBox()
		Me.chkFoiEnviadoResp = New System.Windows.Forms.CheckBox()
		Me.btnAtualizar = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnInserir = New System.Windows.Forms.Button()
		Me.btnConcluir = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.PicDataVisita = New System.Windows.Forms.DateTimePicker()
		Me.chkConferidoPaulo = New System.Windows.Forms.CheckBox()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnAtualizarcadastro = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.picDataEnvio = New System.Windows.Forms.DateTimePicker()
		Me.dgvEscolha = New System.Windows.Forms.DataGridView()
		Me.cboTipoServico = New System.Windows.Forms.ComboBox()
		Me.btnAddItem = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.dgvVisita, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.dgvEscolha, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvVisita
		'
		Me.dgvVisita.AllowUserToAddRows = False
		Me.dgvVisita.AllowUserToDeleteRows = False
		Me.dgvVisita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvVisita.Location = New System.Drawing.Point(12, 54)
		Me.dgvVisita.Name = "dgvVisita"
		Me.dgvVisita.ReadOnly = True
		Me.dgvVisita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvVisita.Size = New System.Drawing.Size(667, 267)
		Me.dgvVisita.TabIndex = 0
		'
		'txtIdentificacao
		'
		Me.txtIdentificacao.Enabled = False
		Me.txtIdentificacao.Location = New System.Drawing.Point(6, 47)
		Me.txtIdentificacao.Name = "txtIdentificacao"
		Me.txtIdentificacao.Size = New System.Drawing.Size(100, 20)
		Me.txtIdentificacao.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 31)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Identificação"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(109, 31)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Nome"
		'
		'txtNomeCliente
		'
		Me.txtNomeCliente.Location = New System.Drawing.Point(112, 47)
		Me.txtNomeCliente.Name = "txtNomeCliente"
		Me.txtNomeCliente.Size = New System.Drawing.Size(100, 20)
		Me.txtNomeCliente.TabIndex = 3
		'
		'PicDataContato
		'
		Me.PicDataContato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.PicDataContato.Location = New System.Drawing.Point(218, 47)
		Me.PicDataContato.Name = "PicDataContato"
		Me.PicDataContato.Size = New System.Drawing.Size(97, 20)
		Me.PicDataContato.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(215, 31)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(85, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Data do Contato"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(109, 74)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Telefone"
		'
		'txtTelefone
		'
		Me.txtTelefone.Location = New System.Drawing.Point(112, 90)
		Me.txtTelefone.Name = "txtTelefone"
		Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
		Me.txtTelefone.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(4, 74)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(53, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Endereço"
		'
		'txtEndOrcamento
		'
		Me.txtEndOrcamento.Location = New System.Drawing.Point(7, 90)
		Me.txtEndOrcamento.Name = "txtEndOrcamento"
		Me.txtEndOrcamento.Size = New System.Drawing.Size(100, 20)
		Me.txtEndOrcamento.TabIndex = 9
		'
		'dgvServico
		'
		Me.dgvServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvServico.Location = New System.Drawing.Point(706, 54)
		Me.dgvServico.Name = "dgvServico"
		Me.dgvServico.Size = New System.Drawing.Size(546, 267)
		Me.dgvServico.TabIndex = 11
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(703, 38)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(95, 13)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Serviços/Materiais"
		'
		'chkNecessitaVisita
		'
		Me.chkNecessitaVisita.AutoSize = True
		Me.chkNecessitaVisita.Location = New System.Drawing.Point(6, 21)
		Me.chkNecessitaVisita.Name = "chkNecessitaVisita"
		Me.chkNecessitaVisita.Size = New System.Drawing.Size(107, 17)
		Me.chkNecessitaVisita.TabIndex = 13
		Me.chkNecessitaVisita.Text = "Necessita Visita?"
		Me.chkNecessitaVisita.UseVisualStyleBackColor = True
		'
		'chkVisitaFeita
		'
		Me.chkVisitaFeita.AutoSize = True
		Me.chkVisitaFeita.Location = New System.Drawing.Point(6, 44)
		Me.chkVisitaFeita.Name = "chkVisitaFeita"
		Me.chkVisitaFeita.Size = New System.Drawing.Size(94, 17)
		Me.chkVisitaFeita.TabIndex = 14
		Me.chkVisitaFeita.Text = "Visita foi feita?"
		Me.chkVisitaFeita.UseVisualStyleBackColor = True
		'
		'chkNeceEletrica
		'
		Me.chkNeceEletrica.AutoSize = True
		Me.chkNeceEletrica.Location = New System.Drawing.Point(6, 67)
		Me.chkNeceEletrica.Name = "chkNeceEletrica"
		Me.chkNeceEletrica.Size = New System.Drawing.Size(117, 17)
		Me.chkNeceEletrica.TabIndex = 15
		Me.chkNeceEletrica.Text = "Necessita Elétrica?"
		Me.chkNeceEletrica.UseVisualStyleBackColor = True
		'
		'chkPintura
		'
		Me.chkPintura.AutoSize = True
		Me.chkPintura.Location = New System.Drawing.Point(6, 90)
		Me.chkPintura.Name = "chkPintura"
		Me.chkPintura.Size = New System.Drawing.Size(115, 17)
		Me.chkPintura.TabIndex = 16
		Me.chkPintura.Text = "Necessita Pintura?"
		Me.chkPintura.UseVisualStyleBackColor = True
		'
		'chkOrcamentoFeito
		'
		Me.chkOrcamentoFeito.AutoSize = True
		Me.chkOrcamentoFeito.Location = New System.Drawing.Point(6, 113)
		Me.chkOrcamentoFeito.Name = "chkOrcamentoFeito"
		Me.chkOrcamentoFeito.Size = New System.Drawing.Size(130, 17)
		Me.chkOrcamentoFeito.TabIndex = 17
		Me.chkOrcamentoFeito.Text = "O orçamento foi feito?"
		Me.chkOrcamentoFeito.UseVisualStyleBackColor = True
		'
		'chkEnvCliente
		'
		Me.chkEnvCliente.AutoSize = True
		Me.chkEnvCliente.Location = New System.Drawing.Point(6, 143)
		Me.chkEnvCliente.Name = "chkEnvCliente"
		Me.chkEnvCliente.Size = New System.Drawing.Size(136, 17)
		Me.chkEnvCliente.TabIndex = 18
		Me.chkEnvCliente.Text = "Foi enviado ao cliente?"
		Me.chkEnvCliente.UseVisualStyleBackColor = True
		'
		'chkClienteFechou
		'
		Me.chkClienteFechou.AutoSize = True
		Me.chkClienteFechou.Location = New System.Drawing.Point(142, 21)
		Me.chkClienteFechou.Name = "chkClienteFechou"
		Me.chkClienteFechou.Size = New System.Drawing.Size(110, 17)
		Me.chkClienteFechou.TabIndex = 19
		Me.chkClienteFechou.Text = "O cliente fechou?"
		Me.chkClienteFechou.UseVisualStyleBackColor = True
		'
		'chkFoiPreenForms
		'
		Me.chkFoiPreenForms.AutoSize = True
		Me.chkFoiPreenForms.Location = New System.Drawing.Point(142, 44)
		Me.chkFoiPreenForms.Name = "chkFoiPreenForms"
		Me.chkFoiPreenForms.Size = New System.Drawing.Size(139, 17)
		Me.chkFoiPreenForms.TabIndex = 22
		Me.chkFoiPreenForms.Text = "Foi preenchido o forms?"
		Me.chkFoiPreenForms.UseVisualStyleBackColor = True
		'
		'chkFoiEnviadoResp
		'
		Me.chkFoiEnviadoResp.AutoSize = True
		Me.chkFoiEnviadoResp.Location = New System.Drawing.Point(142, 67)
		Me.chkFoiEnviadoResp.Name = "chkFoiEnviadoResp"
		Me.chkFoiEnviadoResp.Size = New System.Drawing.Size(191, 17)
		Me.chkFoiEnviadoResp.TabIndex = 23
		Me.chkFoiEnviadoResp.Text = "Enviado ao resposável (Materiais)?"
		Me.chkFoiEnviadoResp.UseVisualStyleBackColor = True
		'
		'btnAtualizar
		'
		Me.btnAtualizar.Location = New System.Drawing.Point(551, 28)
		Me.btnAtualizar.Name = "btnAtualizar"
		Me.btnAtualizar.Size = New System.Drawing.Size(128, 23)
		Me.btnAtualizar.TabIndex = 24
		Me.btnAtualizar.Text = "Atulizar"
		Me.btnAtualizar.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(7, 146)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(317, 23)
		Me.Button2.TabIndex = 25
		Me.Button2.Text = "Excluir"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(12, 38)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(37, 13)
		Me.Label8.TabIndex = 26
		Me.Label8.Text = "Visitas"
		'
		'btnInserir
		'
		Me.btnInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnInserir.FlatAppearance.BorderSize = 0
		Me.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnInserir.Location = New System.Drawing.Point(7, 178)
		Me.btnInserir.Name = "btnInserir"
		Me.btnInserir.Size = New System.Drawing.Size(317, 23)
		Me.btnInserir.TabIndex = 27
		Me.btnInserir.Text = "Inserir"
		Me.btnInserir.UseVisualStyleBackColor = False
		'
		'btnConcluir
		'
		Me.btnConcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnConcluir.FlatAppearance.BorderSize = 0
		Me.btnConcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnConcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnConcluir.Location = New System.Drawing.Point(6, 178)
		Me.btnConcluir.Name = "btnConcluir"
		Me.btnConcluir.Size = New System.Drawing.Size(319, 23)
		Me.btnConcluir.TabIndex = 28
		Me.btnConcluir.Text = "Concluir"
		Me.btnConcluir.UseVisualStyleBackColor = False
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(215, 74)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 13)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Data da Visita"
		'
		'PicDataVisita
		'
		Me.PicDataVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.PicDataVisita.Location = New System.Drawing.Point(218, 90)
		Me.PicDataVisita.Name = "PicDataVisita"
		Me.PicDataVisita.Size = New System.Drawing.Size(97, 20)
		Me.PicDataVisita.TabIndex = 29
		'
		'chkConferidoPaulo
		'
		Me.chkConferidoPaulo.AutoSize = True
		Me.chkConferidoPaulo.Location = New System.Drawing.Point(142, 90)
		Me.chkConferidoPaulo.Name = "chkConferidoPaulo"
		Me.chkConferidoPaulo.Size = New System.Drawing.Size(139, 17)
		Me.chkConferidoPaulo.TabIndex = 31
		Me.chkConferidoPaulo.Text = "Conferido Paulo/Paula?"
		Me.chkConferidoPaulo.UseVisualStyleBackColor = True
		'
		'btnEditar
		'
		Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnEditar.FlatAppearance.BorderSize = 0
		Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEditar.Location = New System.Drawing.Point(7, 207)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(317, 23)
		Me.btnEditar.TabIndex = 32
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = False
		'
		'btnAtualizarcadastro
		'
		Me.btnAtualizarcadastro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAtualizarcadastro.FlatAppearance.BorderSize = 0
		Me.btnAtualizarcadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAtualizarcadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAtualizarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAtualizarcadastro.Location = New System.Drawing.Point(6, 207)
		Me.btnAtualizarcadastro.Name = "btnAtualizarcadastro"
		Me.btnAtualizarcadastro.Size = New System.Drawing.Size(319, 23)
		Me.btnAtualizarcadastro.TabIndex = 33
		Me.btnAtualizarcadastro.Text = "Atualizar Cadastro"
		Me.btnAtualizarcadastro.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Silver
		Me.GroupBox1.Controls.Add(Me.txtIdentificacao)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtNomeCliente)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.PicDataContato)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.PicDataVisita)
		Me.GroupBox1.Controls.Add(Me.btnEditar)
		Me.GroupBox1.Controls.Add(Me.txtTelefone)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.btnInserir)
		Me.GroupBox1.Controls.Add(Me.txtEndOrcamento)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Location = New System.Drawing.Point(349, 403)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(330, 243)
		Me.GroupBox1.TabIndex = 34
		Me.GroupBox1.TabStop = False
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.Silver
		Me.GroupBox2.Controls.Add(Me.chkNecessitaVisita)
		Me.GroupBox2.Controls.Add(Me.chkVisitaFeita)
		Me.GroupBox2.Controls.Add(Me.chkNeceEletrica)
		Me.GroupBox2.Controls.Add(Me.chkPintura)
		Me.GroupBox2.Controls.Add(Me.chkConferidoPaulo)
		Me.GroupBox2.Controls.Add(Me.chkOrcamentoFeito)
		Me.GroupBox2.Controls.Add(Me.chkEnvCliente)
		Me.GroupBox2.Controls.Add(Me.btnAtualizarcadastro)
		Me.GroupBox2.Controls.Add(Me.chkClienteFechou)
		Me.GroupBox2.Controls.Add(Me.btnConcluir)
		Me.GroupBox2.Controls.Add(Me.chkFoiPreenForms)
		Me.GroupBox2.Controls.Add(Me.chkFoiEnviadoResp)
		Me.GroupBox2.Controls.Add(Me.picDataEnvio)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 403)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(331, 243)
		Me.GroupBox2.TabIndex = 35
		Me.GroupBox2.TabStop = False
		'
		'picDataEnvio
		'
		Me.picDataEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.picDataEnvio.Location = New System.Drawing.Point(143, 140)
		Me.picDataEnvio.Name = "picDataEnvio"
		Me.picDataEnvio.Size = New System.Drawing.Size(97, 20)
		Me.picDataEnvio.TabIndex = 20
		'
		'dgvEscolha
		'
		Me.dgvEscolha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvEscolha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvEscolha.Location = New System.Drawing.Point(706, 403)
		Me.dgvEscolha.Name = "dgvEscolha"
		Me.dgvEscolha.Size = New System.Drawing.Size(546, 267)
		Me.dgvEscolha.TabIndex = 36
		'
		'cboTipoServico
		'
		Me.cboTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoServico.FormattingEnabled = True
		Me.cboTipoServico.Items.AddRange(New Object() {"MATERIAL", "SERVIÇO"})
		Me.cboTipoServico.Location = New System.Drawing.Point(706, 376)
		Me.cboTipoServico.Name = "cboTipoServico"
		Me.cboTipoServico.Size = New System.Drawing.Size(221, 21)
		Me.cboTipoServico.TabIndex = 37
		'
		'btnAddItem
		'
		Me.btnAddItem.BackColor = System.Drawing.Color.White
		Me.btnAddItem.BackgroundImage = Global.ControleOS.My.Resources.Resources.seta_verde
		Me.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnAddItem.FlatAppearance.BorderSize = 0
		Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddItem.Location = New System.Drawing.Point(1223, 327)
		Me.btnAddItem.Name = "btnAddItem"
		Me.btnAddItem.Size = New System.Drawing.Size(29, 21)
		Me.btnAddItem.TabIndex = 38
		Me.btnAddItem.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cancelar
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(1188, 327)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(29, 21)
		Me.Button1.TabIndex = 40
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.White
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(706, 327)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(49, 28)
		Me.Button3.TabIndex = 41
		Me.Button3.Text = "Aplicar"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'FrmListaVisita
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1264, 729)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnAddItem)
		Me.Controls.Add(Me.cboTipoServico)
		Me.Controls.Add(Me.dgvEscolha)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnAtualizar)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.dgvServico)
		Me.Controls.Add(Me.dgvVisita)
		Me.Name = "FrmListaVisita"
		Me.Text = "FrmListaVisita"
		CType(Me.dgvVisita, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.dgvEscolha, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvVisita As DataGridView
    Friend WithEvents txtIdentificacao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents PicDataContato As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEndOrcamento As TextBox
    Friend WithEvents dgvServico As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents chkNecessitaVisita As CheckBox
    Friend WithEvents chkVisitaFeita As CheckBox
    Friend WithEvents chkNeceEletrica As CheckBox
    Friend WithEvents chkPintura As CheckBox
    Friend WithEvents chkOrcamentoFeito As CheckBox
    Friend WithEvents chkEnvCliente As CheckBox
    Friend WithEvents chkClienteFechou As CheckBox
	Friend WithEvents chkFoiPreenForms As CheckBox
	Friend WithEvents chkFoiEnviadoResp As CheckBox
	Friend WithEvents btnAtualizar As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents btnInserir As Button
	Friend WithEvents btnConcluir As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents PicDataVisita As DateTimePicker
	Friend WithEvents chkConferidoPaulo As CheckBox
	Friend WithEvents btnEditar As Button
	Friend WithEvents btnAtualizarcadastro As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents picDataEnvio As DateTimePicker
	Friend WithEvents dgvEscolha As DataGridView
	Friend WithEvents cboTipoServico As ComboBox
	Friend WithEvents btnAddItem As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
End Class
