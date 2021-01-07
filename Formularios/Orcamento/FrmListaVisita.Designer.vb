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
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.picDataEnvio = New System.Windows.Forms.DateTimePicker()
		Me.sfdExcel = New System.Windows.Forms.SaveFileDialog()
		Me.btnAnexarExcel = New System.Windows.Forms.Button()
		Me.ofdPlanilha = New System.Windows.Forms.OpenFileDialog()
		Me.btnLocAnexo = New System.Windows.Forms.Button()
		Me.btnAbrirAnexo = New System.Windows.Forms.Button()
		Me.webFormsGoogle = New System.Windows.Forms.WebBrowser()
		Me.btnGoogleForms = New System.Windows.Forms.Button()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		CType(Me.dgvVisita, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvVisita
		'
		Me.dgvVisita.AllowUserToAddRows = False
		Me.dgvVisita.AllowUserToDeleteRows = False
		Me.dgvVisita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvVisita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvVisita.BackgroundColor = System.Drawing.Color.White
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvVisita.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2)
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvVisita.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvVisita.Location = New System.Drawing.Point(5, 31)
		Me.dgvVisita.Name = "dgvVisita"
		Me.dgvVisita.ReadOnly = True
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvVisita.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvVisita.RowHeadersVisible = False
		Me.dgvVisita.RowTemplate.Height = 40
		Me.dgvVisita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvVisita.Size = New System.Drawing.Size(671, 358)
		Me.dgvVisita.TabIndex = 0
		'
		'txtIdentificacao
		'
		Me.txtIdentificacao.Enabled = False
		Me.txtIdentificacao.Location = New System.Drawing.Point(6, 187)
		Me.txtIdentificacao.Name = "txtIdentificacao"
		Me.txtIdentificacao.Size = New System.Drawing.Size(100, 20)
		Me.txtIdentificacao.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 171)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Identificação"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(109, 171)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Nome"
		'
		'txtNomeCliente
		'
		Me.txtNomeCliente.Location = New System.Drawing.Point(112, 187)
		Me.txtNomeCliente.Name = "txtNomeCliente"
		Me.txtNomeCliente.Size = New System.Drawing.Size(100, 20)
		Me.txtNomeCliente.TabIndex = 3
		'
		'PicDataContato
		'
		Me.PicDataContato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.PicDataContato.Location = New System.Drawing.Point(218, 187)
		Me.PicDataContato.Name = "PicDataContato"
		Me.PicDataContato.Size = New System.Drawing.Size(97, 20)
		Me.PicDataContato.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(215, 171)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(85, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Data do Contato"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 213)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Telefone"
		'
		'txtTelefone
		'
		Me.txtTelefone.Location = New System.Drawing.Point(6, 229)
		Me.txtTelefone.Name = "txtTelefone"
		Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
		Me.txtTelefone.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 258)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(53, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Endereço"
		'
		'txtEndOrcamento
		'
		Me.txtEndOrcamento.Location = New System.Drawing.Point(6, 274)
		Me.txtEndOrcamento.Name = "txtEndOrcamento"
		Me.txtEndOrcamento.Size = New System.Drawing.Size(309, 20)
		Me.txtEndOrcamento.TabIndex = 9
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
		Me.chkFoiEnviadoResp.Size = New System.Drawing.Size(144, 17)
		Me.chkFoiEnviadoResp.TabIndex = 23
		Me.chkFoiEnviadoResp.Text = "Enviado para a Roxane?"
		Me.chkFoiEnviadoResp.UseVisualStyleBackColor = True
		'
		'btnAtualizar
		'
		Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAtualizar.Location = New System.Drawing.Point(609, 5)
		Me.btnAtualizar.Name = "btnAtualizar"
		Me.btnAtualizar.Size = New System.Drawing.Size(67, 23)
		Me.btnAtualizar.TabIndex = 24
		Me.btnAtualizar.Text = "Atulizar"
		Me.btnAtualizar.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.Button2.Location = New System.Drawing.Point(544, 275)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 23)
		Me.Button2.TabIndex = 25
		Me.Button2.Text = "Excluir"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(12, 11)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(37, 13)
		Me.Label8.TabIndex = 26
		Me.Label8.Text = "Visitas"
		'
		'btnInserir
		'
		Me.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnInserir.FlatAppearance.BorderSize = 0
		Me.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnInserir.Location = New System.Drawing.Point(434, 245)
		Me.btnInserir.Name = "btnInserir"
		Me.btnInserir.Size = New System.Drawing.Size(94, 23)
		Me.btnInserir.TabIndex = 27
		Me.btnInserir.Text = "Inserir"
		Me.btnInserir.UseVisualStyleBackColor = False
		'
		'btnConcluir
		'
		Me.btnConcluir.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnConcluir.FlatAppearance.BorderSize = 0
		Me.btnConcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnConcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnConcluir.Location = New System.Drawing.Point(321, 245)
		Me.btnConcluir.Name = "btnConcluir"
		Me.btnConcluir.Size = New System.Drawing.Size(94, 23)
		Me.btnConcluir.TabIndex = 28
		Me.btnConcluir.Text = "Concluir"
		Me.btnConcluir.UseVisualStyleBackColor = False
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(109, 213)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 13)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Data da Visita"
		'
		'PicDataVisita
		'
		Me.PicDataVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.PicDataVisita.Location = New System.Drawing.Point(112, 229)
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
		Me.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnEditar.FlatAppearance.BorderSize = 0
		Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnEditar.Location = New System.Drawing.Point(544, 245)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(94, 23)
		Me.btnEditar.TabIndex = 32
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = False
		'
		'btnAtualizarcadastro
		'
		Me.btnAtualizarcadastro.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnAtualizarcadastro.FlatAppearance.BorderSize = 0
		Me.btnAtualizarcadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAtualizarcadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAtualizarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAtualizarcadastro.Location = New System.Drawing.Point(321, 274)
		Me.btnAtualizarcadastro.Name = "btnAtualizarcadastro"
		Me.btnAtualizarcadastro.Size = New System.Drawing.Size(206, 23)
		Me.btnAtualizarcadastro.TabIndex = 33
		Me.btnAtualizarcadastro.Text = "Atualizar Cadastro"
		Me.btnAtualizarcadastro.UseVisualStyleBackColor = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.GroupBox2.Controls.Add(Me.btnGoogleForms)
		Me.GroupBox2.Controls.Add(Me.btnAtualizarcadastro)
		Me.GroupBox2.Controls.Add(Me.btnAnexarExcel)
		Me.GroupBox2.Controls.Add(Me.btnAbrirAnexo)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.txtIdentificacao)
		Me.GroupBox2.Controls.Add(Me.btnEditar)
		Me.GroupBox2.Controls.Add(Me.PicDataVisita)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.btnConcluir)
		Me.GroupBox2.Controls.Add(Me.btnInserir)
		Me.GroupBox2.Controls.Add(Me.txtTelefone)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Button2)
		Me.GroupBox2.Controls.Add(Me.chkNecessitaVisita)
		Me.GroupBox2.Controls.Add(Me.txtEndOrcamento)
		Me.GroupBox2.Controls.Add(Me.txtNomeCliente)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.chkVisitaFeita)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.chkNeceEletrica)
		Me.GroupBox2.Controls.Add(Me.PicDataContato)
		Me.GroupBox2.Controls.Add(Me.chkPintura)
		Me.GroupBox2.Controls.Add(Me.chkConferidoPaulo)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.chkOrcamentoFeito)
		Me.GroupBox2.Controls.Add(Me.chkEnvCliente)
		Me.GroupBox2.Controls.Add(Me.chkClienteFechou)
		Me.GroupBox2.Controls.Add(Me.chkFoiPreenForms)
		Me.GroupBox2.Controls.Add(Me.chkFoiEnviadoResp)
		Me.GroupBox2.Controls.Add(Me.picDataEnvio)
		Me.GroupBox2.Location = New System.Drawing.Point(5, 407)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(671, 310)
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
		'sfdExcel
		'
		Me.sfdExcel.FileName = " "
		'
		'btnAnexarExcel
		'
		Me.btnAnexarExcel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnAnexarExcel.FlatAppearance.BorderSize = 0
		Me.btnAnexarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAnexarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAnexarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAnexarExcel.Location = New System.Drawing.Point(434, 216)
		Me.btnAnexarExcel.Name = "btnAnexarExcel"
		Me.btnAnexarExcel.Size = New System.Drawing.Size(94, 23)
		Me.btnAnexarExcel.TabIndex = 34
		Me.btnAnexarExcel.Text = "Anexar Planilha"
		Me.btnAnexarExcel.UseVisualStyleBackColor = False
		'
		'ofdPlanilha
		'
		Me.ofdPlanilha.FileName = "OpenFileDialog1"
		'
		'btnLocAnexo
		'
		Me.btnLocAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLocAnexo.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnLocAnexo.FlatAppearance.BorderSize = 0
		Me.btnLocAnexo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnLocAnexo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnLocAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnLocAnexo.Location = New System.Drawing.Point(445, 5)
		Me.btnLocAnexo.Name = "btnLocAnexo"
		Me.btnLocAnexo.Size = New System.Drawing.Size(158, 23)
		Me.btnLocAnexo.TabIndex = 36
		Me.btnLocAnexo.Text = " Mudar Caminho de Anexos"
		Me.btnLocAnexo.UseVisualStyleBackColor = False
		'
		'btnAbrirAnexo
		'
		Me.btnAbrirAnexo.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnAbrirAnexo.FlatAppearance.BorderSize = 0
		Me.btnAbrirAnexo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAbrirAnexo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAbrirAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAbrirAnexo.Location = New System.Drawing.Point(321, 216)
		Me.btnAbrirAnexo.Name = "btnAbrirAnexo"
		Me.btnAbrirAnexo.Size = New System.Drawing.Size(94, 23)
		Me.btnAbrirAnexo.TabIndex = 37
		Me.btnAbrirAnexo.Text = " Abrir Anexo"
		Me.btnAbrirAnexo.UseVisualStyleBackColor = False
		'
		'webFormsGoogle
		'
		Me.webFormsGoogle.Location = New System.Drawing.Point(682, 31)
		Me.webFormsGoogle.MinimumSize = New System.Drawing.Size(20, 20)
		Me.webFormsGoogle.Name = "webFormsGoogle"
		Me.webFormsGoogle.ScriptErrorsSuppressed = True
		Me.webFormsGoogle.Size = New System.Drawing.Size(518, 686)
		Me.webFormsGoogle.TabIndex = 37
		'
		'btnGoogleForms
		'
		Me.btnGoogleForms.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnGoogleForms.FlatAppearance.BorderSize = 0
		Me.btnGoogleForms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnGoogleForms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnGoogleForms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnGoogleForms.Location = New System.Drawing.Point(544, 216)
		Me.btnGoogleForms.Name = "btnGoogleForms"
		Me.btnGoogleForms.Size = New System.Drawing.Size(94, 23)
		Me.btnGoogleForms.TabIndex = 38
		Me.btnGoogleForms.Text = "Google Forms"
		Me.btnGoogleForms.UseVisualStyleBackColor = False
		'
		'FrmListaVisita
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1212, 729)
		Me.Controls.Add(Me.webFormsGoogle)
		Me.Controls.Add(Me.btnLocAnexo)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnAtualizar)
		Me.Controls.Add(Me.dgvVisita)
		Me.Name = "FrmListaVisita"
		Me.Text = " "
		CType(Me.dgvVisita, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
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
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents picDataEnvio As DateTimePicker
	Friend WithEvents sfdExcel As SaveFileDialog
	Friend WithEvents btnAnexarExcel As Button
	Friend WithEvents ofdPlanilha As OpenFileDialog
	Friend WithEvents btnLocAnexo As Button
	Friend WithEvents btnAbrirAnexo As Button
	Friend WithEvents btnGoogleForms As Button
	Friend WithEvents webFormsGoogle As WebBrowser
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
