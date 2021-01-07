<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNovoOrcamento
	Inherits System.Windows.Forms.Form

	'Descartar substituições de formulário para limpar a lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgvClientes = New System.Windows.Forms.DataGridView()
		Me.dgvEnderecos = New System.Windows.Forms.DataGridView()
		Me.dgvServicoEscolhido = New System.Windows.Forms.DataGridView()
		Me.dgvServicosDis = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblTempoExecucao = New System.Windows.Forms.Label()
		Me.lblTotalMDO = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.dgvParcelas = New System.Windows.Forms.DataGridView()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblTotalOS = New System.Windows.Forms.Label()
		Me.chkEntrada = New System.Windows.Forms.CheckBox()
		Me.txtValorEntrada = New System.Windows.Forms.TextBox()
		Me.nudJornadaTrabalho = New System.Windows.Forms.NumericUpDown()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblTempoExecDia = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cboTipoDeslocamento = New System.Windows.Forms.ComboBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtCustoDiario = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.cboVeiculosEmpresa = New System.Windows.Forms.ComboBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.l6 = New System.Windows.Forms.ListBox()
		Me.l5 = New System.Windows.Forms.ListBox()
		Me.txtCustoTotalVeiculo = New System.Windows.Forms.Label()
		Me.lblTotalAntecipacao = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.l7 = New System.Windows.Forms.ListBox()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.l8 = New System.Windows.Forms.ListBox()
		Me.l9 = New System.Windows.Forms.ListBox()
		Me.lblLucroAtual = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.l10 = New System.Windows.Forms.ListBox()
		Me.picDataInicio = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.pnCalendario = New System.Windows.Forms.Panel()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.PicDataTermino = New System.Windows.Forms.DateTimePicker()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.cboModCred = New System.Windows.Forms.ComboBox()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.lblTotalComDiaria = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.l11 = New System.Windows.Forms.ListBox()
		Me.chkNeceAjudante = New System.Windows.Forms.CheckBox()
		Me.lblTotalDiaria = New System.Windows.Forms.Label()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.l12 = New System.Windows.Forms.ListBox()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.txtDiasAntecipar = New System.Windows.Forms.TextBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblValorLiquidoAnteci = New System.Windows.Forms.Label()
		Me.l13 = New System.Windows.Forms.ListBox()
		Me.btnCriarAgendamento = New System.Windows.Forms.Button()
		Me.txtNumOS = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.picDataVisita = New System.Windows.Forms.DateTimePicker()
		Me.btnInserirVisita = New System.Windows.Forms.Button()
		Me.cboOrcamentista = New System.Windows.Forms.ComboBox()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.cboStatusVisita = New System.Windows.Forms.ComboBox()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.picHoraVisita = New System.Windows.Forms.DateTimePicker()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.pnPrincipal = New System.Windows.Forms.Panel()
		Me.pnInfoCliente = New System.Windows.Forms.Panel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.btnExCliente = New System.Windows.Forms.Button()
		Me.pnMaterial = New System.Windows.Forms.Panel()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.btnListaMaterial = New System.Windows.Forms.Button()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.pnItens = New System.Windows.Forms.Panel()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.txtPesquisar = New MaterialSkin.Controls.MaterialSingleLineTextField()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.btnExItens = New System.Windows.Forms.Button()
		Me.pnCustos = New System.Windows.Forms.Panel()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.btnExCustos = New System.Windows.Forms.Button()
		Me.pnAgendamento = New System.Windows.Forms.Panel()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.picHoraInicio = New System.Windows.Forms.DateTimePicker()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.btnAgendamento = New System.Windows.Forms.Button()
		Me.pnVisita = New System.Windows.Forms.Panel()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.btnVisitas = New System.Windows.Forms.Button()
		Me.pnMedicao = New System.Windows.Forms.Panel()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label44 = New System.Windows.Forms.Label()
		Me.btnMedicao = New System.Windows.Forms.Button()
		Me.Label45 = New System.Windows.Forms.Label()
		Me.pnRelatorio = New System.Windows.Forms.Panel()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.btnRelatorio = New System.Windows.Forms.Button()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.pnFinalizacao = New System.Windows.Forms.Panel()
		Me.txtTotalConsiderado = New System.Windows.Forms.TextBox()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.btnFinalizacao = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.pnFinanceiro = New System.Windows.Forms.Panel()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.btnFinanceiro = New System.Windows.Forms.Button()
		Me.pnExTempo = New System.Windows.Forms.Panel()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.btnExTempo = New System.Windows.Forms.Button()
		Me.pnPagamento = New System.Windows.Forms.Panel()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.btnExPagamento = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
		Me.txtPesquisarCliente = New System.Windows.Forms.TextBox()
		CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvEnderecos, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvServicoEscolhido, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvServicosDis, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudJornadaTrabalho, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.pnPrincipal.SuspendLayout()
		Me.pnInfoCliente.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.pnMaterial.SuspendLayout()
		Me.pnItens.SuspendLayout()
		Me.pnCustos.SuspendLayout()
		Me.pnAgendamento.SuspendLayout()
		Me.pnVisita.SuspendLayout()
		Me.pnMedicao.SuspendLayout()
		Me.pnRelatorio.SuspendLayout()
		Me.pnFinalizacao.SuspendLayout()
		Me.pnFinanceiro.SuspendLayout()
		Me.pnExTempo.SuspendLayout()
		Me.pnPagamento.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvClientes
		'
		Me.dgvClientes.AllowUserToAddRows = False
		Me.dgvClientes.AllowUserToDeleteRows = False
		Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
		Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle7
		Me.dgvClientes.Location = New System.Drawing.Point(5, 35)
		Me.dgvClientes.Name = "dgvClientes"
		Me.dgvClientes.ReadOnly = True
		Me.dgvClientes.RowHeadersVisible = False
		Me.dgvClientes.RowTemplate.Height = 35
		Me.dgvClientes.Size = New System.Drawing.Size(1179, 225)
		Me.dgvClientes.TabIndex = 0
		'
		'dgvEnderecos
		'
		Me.dgvEnderecos.AllowUserToAddRows = False
		Me.dgvEnderecos.AllowUserToDeleteRows = False
		Me.dgvEnderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvEnderecos.BackgroundColor = System.Drawing.Color.White
		Me.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvEnderecos.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvEnderecos.Location = New System.Drawing.Point(4, 279)
		Me.dgvEnderecos.Name = "dgvEnderecos"
		Me.dgvEnderecos.ReadOnly = True
		Me.dgvEnderecos.RowHeadersVisible = False
		Me.dgvEnderecos.RowTemplate.Height = 35
		Me.dgvEnderecos.Size = New System.Drawing.Size(1180, 223)
		Me.dgvEnderecos.TabIndex = 1
		'
		'dgvServicoEscolhido
		'
		Me.dgvServicoEscolhido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvServicoEscolhido.Location = New System.Drawing.Point(6, 317)
		Me.dgvServicoEscolhido.Name = "dgvServicoEscolhido"
		Me.dgvServicoEscolhido.Size = New System.Drawing.Size(1245, 225)
		Me.dgvServicoEscolhido.TabIndex = 2
		'
		'dgvServicosDis
		'
		Me.dgvServicosDis.AllowUserToAddRows = False
		Me.dgvServicosDis.AllowUserToDeleteRows = False
		Me.dgvServicosDis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvServicosDis.BackgroundColor = System.Drawing.Color.White
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvServicosDis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvServicosDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GrayText
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvServicosDis.DefaultCellStyle = DataGridViewCellStyle10
		Me.dgvServicosDis.Location = New System.Drawing.Point(6, 102)
		Me.dgvServicosDis.MultiSelect = False
		Me.dgvServicosDis.Name = "dgvServicosDis"
		Me.dgvServicosDis.ReadOnly = True
		Me.dgvServicosDis.RowHeadersVisible = False
		Me.dgvServicosDis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvServicosDis.RowTemplate.Height = 35
		Me.dgvServicosDis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvServicosDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvServicosDis.Size = New System.Drawing.Size(1245, 191)
		Me.dgvServicosDis.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(4, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(43, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "clientes"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(2, 263)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "endereços"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 304)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(66, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "itens serviço"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(6, 85)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(124, 13)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "itens serviço disponiveirs"
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.Location = New System.Drawing.Point(1147, 35)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 17
		Me.Button1.Text = "fechar app"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(46, 50)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(143, 13)
		Me.Label9.TabIndex = 19
		Me.Label9.Text = "Tempo de Execução (Horas)"
		'
		'lblTempoExecucao
		'
		Me.lblTempoExecucao.AutoSize = True
		Me.lblTempoExecucao.Location = New System.Drawing.Point(97, 69)
		Me.lblTempoExecucao.Name = "lblTempoExecucao"
		Me.lblTempoExecucao.Size = New System.Drawing.Size(13, 13)
		Me.lblTempoExecucao.TabIndex = 20
		Me.lblTempoExecucao.Text = "0"
		'
		'lblTotalMDO
		'
		Me.lblTotalMDO.AutoSize = True
		Me.lblTotalMDO.Location = New System.Drawing.Point(58, 81)
		Me.lblTotalMDO.Name = "lblTotalMDO"
		Me.lblTotalMDO.Size = New System.Drawing.Size(13, 13)
		Me.lblTotalMDO.TabIndex = 22
		Me.lblTotalMDO.Text = "0"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(31, 50)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(66, 26)
		Me.Label11.TabIndex = 21
		Me.Label11.Text = "Total de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mão de obra"
		'
		'dgvParcelas
		'
		Me.dgvParcelas.AllowUserToAddRows = False
		Me.dgvParcelas.AllowUserToDeleteRows = False
		Me.dgvParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvParcelas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
		Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvParcelas.DefaultCellStyle = DataGridViewCellStyle12
		Me.dgvParcelas.Location = New System.Drawing.Point(9, 115)
		Me.dgvParcelas.Name = "dgvParcelas"
		Me.dgvParcelas.ReadOnly = True
		Me.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvParcelas.RowHeadersVisible = False
		Me.dgvParcelas.Size = New System.Drawing.Size(478, 353)
		Me.dgvParcelas.TabIndex = 23
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(58, 192)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(13, 13)
		Me.Label10.TabIndex = 31
		Me.Label10.Text = "0"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(26, 174)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(80, 13)
		Me.Label12.TabIndex = 30
		Me.Label12.Text = "Total Desconto"
		'
		'lblTotalOS
		'
		Me.lblTotalOS.AutoSize = True
		Me.lblTotalOS.Location = New System.Drawing.Point(155, 138)
		Me.lblTotalOS.Name = "lblTotalOS"
		Me.lblTotalOS.Size = New System.Drawing.Size(13, 13)
		Me.lblTotalOS.TabIndex = 27
		Me.lblTotalOS.Text = "0"
		'
		'chkEntrada
		'
		Me.chkEntrada.AutoSize = True
		Me.chkEntrada.Location = New System.Drawing.Point(9, 50)
		Me.chkEntrada.Name = "chkEntrada"
		Me.chkEntrada.Size = New System.Drawing.Size(103, 17)
		Me.chkEntrada.TabIndex = 26
		Me.chkEntrada.Text = "Possui Entrada?"
		Me.chkEntrada.UseVisualStyleBackColor = True
		'
		'txtValorEntrada
		'
		Me.txtValorEntrada.Enabled = False
		Me.txtValorEntrada.Location = New System.Drawing.Point(9, 90)
		Me.txtValorEntrada.Name = "txtValorEntrada"
		Me.txtValorEntrada.Size = New System.Drawing.Size(153, 20)
		Me.txtValorEntrada.TabIndex = 27
		'
		'nudJornadaTrabalho
		'
		Me.nudJornadaTrabalho.Location = New System.Drawing.Point(287, 66)
		Me.nudJornadaTrabalho.Name = "nudJornadaTrabalho"
		Me.nudJornadaTrabalho.Size = New System.Drawing.Size(81, 20)
		Me.nudJornadaTrabalho.TabIndex = 28
		Me.nudJornadaTrabalho.Value = New Decimal(New Integer() {9, 0, 0, 0})
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(288, 50)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(90, 13)
		Me.Label13.TabIndex = 29
		Me.Label13.Text = "Jornada Trabalho"
		'
		'lblTempoExecDia
		'
		Me.lblTempoExecDia.AutoSize = True
		Me.lblTempoExecDia.Location = New System.Drawing.Point(104, 156)
		Me.lblTempoExecDia.Name = "lblTempoExecDia"
		Me.lblTempoExecDia.Size = New System.Drawing.Size(13, 13)
		Me.lblTempoExecDia.TabIndex = 30
		Me.lblTempoExecDia.Text = "0"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(53, 139)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(136, 13)
		Me.Label14.TabIndex = 34
		Me.Label14.Text = "Tempo de Execução (Dias)"
		'
		'cboTipoDeslocamento
		'
		Me.cboTipoDeslocamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoDeslocamento.FormattingEnabled = True
		Me.cboTipoDeslocamento.Items.AddRange(New Object() {"Veiculo da Empresa", "Veiculo Próprio", "Outro"})
		Me.cboTipoDeslocamento.Location = New System.Drawing.Point(6, 33)
		Me.cboTipoDeslocamento.Name = "cboTipoDeslocamento"
		Me.cboTipoDeslocamento.Size = New System.Drawing.Size(121, 21)
		Me.cboTipoDeslocamento.TabIndex = 36
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(3, 17)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(116, 13)
		Me.Label15.TabIndex = 37
		Me.Label15.Text = "Meio de Deslocamento"
		'
		'txtCustoDiario
		'
		Me.txtCustoDiario.Enabled = False
		Me.txtCustoDiario.Location = New System.Drawing.Point(6, 88)
		Me.txtCustoDiario.Name = "txtCustoDiario"
		Me.txtCustoDiario.Size = New System.Drawing.Size(121, 20)
		Me.txtCustoDiario.TabIndex = 38
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(3, 71)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(87, 13)
		Me.Label16.TabIndex = 39
		Me.Label16.Text = "Custo Diario (R$)"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(152, 17)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(106, 13)
		Me.Label17.TabIndex = 41
		Me.Label17.Text = "Veiculos da Empresa"
		'
		'cboVeiculosEmpresa
		'
		Me.cboVeiculosEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboVeiculosEmpresa.Enabled = False
		Me.cboVeiculosEmpresa.FormattingEnabled = True
		Me.cboVeiculosEmpresa.Location = New System.Drawing.Point(155, 33)
		Me.cboVeiculosEmpresa.Name = "cboVeiculosEmpresa"
		Me.cboVeiculosEmpresa.Size = New System.Drawing.Size(121, 21)
		Me.cboVeiculosEmpresa.TabIndex = 40
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(130, 50)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(68, 26)
		Me.Label18.TabIndex = 43
		Me.Label18.Text = "Custo Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "com Veiculo "
		'
		'l6
		'
		Me.l6.FormattingEnabled = True
		Me.l6.Location = New System.Drawing.Point(117, 44)
		Me.l6.Name = "l6"
		Me.l6.Size = New System.Drawing.Size(95, 56)
		Me.l6.TabIndex = 46
		'
		'l5
		'
		Me.l5.FormattingEnabled = True
		Me.l5.Location = New System.Drawing.Point(20, 44)
		Me.l5.Name = "l5"
		Me.l5.Size = New System.Drawing.Size(95, 56)
		Me.l5.TabIndex = 44
		'
		'txtCustoTotalVeiculo
		'
		Me.txtCustoTotalVeiculo.AutoSize = True
		Me.txtCustoTotalVeiculo.Location = New System.Drawing.Point(159, 81)
		Me.txtCustoTotalVeiculo.Name = "txtCustoTotalVeiculo"
		Me.txtCustoTotalVeiculo.Size = New System.Drawing.Size(13, 13)
		Me.txtCustoTotalVeiculo.TabIndex = 47
		Me.txtCustoTotalVeiculo.Text = "0"
		'
		'lblTotalAntecipacao
		'
		Me.lblTotalAntecipacao.AutoSize = True
		Me.lblTotalAntecipacao.Location = New System.Drawing.Point(62, 138)
		Me.lblTotalAntecipacao.Name = "lblTotalAntecipacao"
		Me.lblTotalAntecipacao.Size = New System.Drawing.Size(13, 13)
		Me.lblTotalAntecipacao.TabIndex = 50
		Me.lblTotalAntecipacao.Text = "0"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(26, 108)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(82, 26)
		Me.Label20.TabIndex = 48
		Me.Label20.Text = "Total Taxa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Antecipação"
		'
		'l7
		'
		Me.l7.FormattingEnabled = True
		Me.l7.Location = New System.Drawing.Point(20, 102)
		Me.l7.Name = "l7"
		Me.l7.Size = New System.Drawing.Size(95, 56)
		Me.l7.TabIndex = 49
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(120, 108)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(89, 26)
		Me.Label22.TabIndex = 51
		Me.Label22.Text = "Total Orçamento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "com serviços" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'l8
		'
		Me.l8.FormattingEnabled = True
		Me.l8.Location = New System.Drawing.Point(117, 102)
		Me.l8.Name = "l8"
		Me.l8.Size = New System.Drawing.Size(95, 56)
		Me.l8.TabIndex = 52
		'
		'l9
		'
		Me.l9.FormattingEnabled = True
		Me.l9.Location = New System.Drawing.Point(20, 160)
		Me.l9.Name = "l9"
		Me.l9.Size = New System.Drawing.Size(95, 56)
		Me.l9.TabIndex = 55
		'
		'lblLucroAtual
		'
		Me.lblLucroAtual.AutoSize = True
		Me.lblLucroAtual.Location = New System.Drawing.Point(354, 138)
		Me.lblLucroAtual.Name = "lblLucroAtual"
		Me.lblLucroAtual.Size = New System.Drawing.Size(13, 13)
		Me.lblLucroAtual.TabIndex = 57
		Me.lblLucroAtual.Text = "0"
		Me.lblLucroAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(317, 116)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(61, 13)
		Me.Label21.TabIndex = 56
		Me.Label21.Text = "Lucro Atual"
		'
		'l10
		'
		Me.l10.FormattingEnabled = True
		Me.l10.Location = New System.Drawing.Point(311, 102)
		Me.l10.Name = "l10"
		Me.l10.Size = New System.Drawing.Size(95, 56)
		Me.l10.TabIndex = 58
		'
		'picDataInicio
		'
		Me.picDataInicio.Location = New System.Drawing.Point(34, 62)
		Me.picDataInicio.Name = "picDataInicio"
		Me.picDataInicio.Size = New System.Drawing.Size(0, 20)
		Me.picDataInicio.TabIndex = 59
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(34, 46)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(91, 13)
		Me.Label7.TabIndex = 60
		Me.Label7.Text = "Previsao de Inicio"
		'
		'pnCalendario
		'
		Me.pnCalendario.AutoScroll = True
		Me.pnCalendario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnCalendario.Location = New System.Drawing.Point(21, 147)
		Me.pnCalendario.Name = "pnCalendario"
		Me.pnCalendario.Size = New System.Drawing.Size(293, 109)
		Me.pnCalendario.TabIndex = 61
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(34, 105)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(104, 13)
		Me.Label23.TabIndex = 63
		Me.Label23.Text = "Previsao de Término"
		'
		'PicDataTermino
		'
		Me.PicDataTermino.Location = New System.Drawing.Point(34, 121)
		Me.PicDataTermino.Name = "PicDataTermino"
		Me.PicDataTermino.Size = New System.Drawing.Size(245, 20)
		Me.PicDataTermino.TabIndex = 62
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(175, 77)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(93, 13)
		Me.Label35.TabIndex = 86
		Me.Label35.Text = "Modelo de Crédito"
		'
		'cboModCred
		'
		Me.cboModCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboModCred.FormattingEnabled = True
		Me.cboModCred.Items.AddRange(New Object() {"Debito", "Credito a Vista", "Cred. em 2x", "Cred. em 3x", "Cred. em 4x", "Cred. em 5x", "Cred. em 6x", "Cred. em 7x", "Cred. em 8x", "Cred. em 9x", "Cred. em 10x", "Cred. em 11x", "Cred. em 12x"})
		Me.cboModCred.Location = New System.Drawing.Point(178, 91)
		Me.cboModCred.Name = "cboModCred"
		Me.cboModCred.Size = New System.Drawing.Size(176, 21)
		Me.cboModCred.TabIndex = 85
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(49, 308)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(161, 46)
		Me.btnCalcular.TabIndex = 87
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = True
		'
		'lblTotalComDiaria
		'
		Me.lblTotalComDiaria.AutoSize = True
		Me.lblTotalComDiaria.Location = New System.Drawing.Point(254, 81)
		Me.lblTotalComDiaria.Name = "lblTotalComDiaria"
		Me.lblTotalComDiaria.Size = New System.Drawing.Size(13, 13)
		Me.lblTotalComDiaria.TabIndex = 88
		Me.lblTotalComDiaria.Text = "0"
		'
		'Label36
		'
		Me.Label36.AutoSize = True
		Me.Label36.Location = New System.Drawing.Point(219, 50)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(86, 26)
		Me.Label36.TabIndex = 89
		Me.Label36.Text = "Total Orçamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "com Diarias"
		'
		'l11
		'
		Me.l11.FormattingEnabled = True
		Me.l11.Location = New System.Drawing.Point(214, 44)
		Me.l11.Name = "l11"
		Me.l11.Size = New System.Drawing.Size(95, 56)
		Me.l11.TabIndex = 90
		'
		'chkNeceAjudante
		'
		Me.chkNeceAjudante.AutoSize = True
		Me.chkNeceAjudante.Location = New System.Drawing.Point(46, 227)
		Me.chkNeceAjudante.Name = "chkNeceAjudante"
		Me.chkNeceAjudante.Size = New System.Drawing.Size(76, 30)
		Me.chkNeceAjudante.TabIndex = 91
		Me.chkNeceAjudante.Text = "Considerar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ajudante?"
		Me.chkNeceAjudante.UseVisualStyleBackColor = True
		'
		'lblTotalDiaria
		'
		Me.lblTotalDiaria.AutoSize = True
		Me.lblTotalDiaria.Location = New System.Drawing.Point(254, 138)
		Me.lblTotalDiaria.Name = "lblTotalDiaria"
		Me.lblTotalDiaria.Size = New System.Drawing.Size(13, 13)
		Me.lblTotalDiaria.TabIndex = 92
		Me.lblTotalDiaria.Text = "0"
		'
		'Label37
		'
		Me.Label37.AutoSize = True
		Me.Label37.Location = New System.Drawing.Point(220, 108)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(66, 26)
		Me.Label37.TabIndex = 93
		Me.Label37.Text = "Total Diarias" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (R$)"
		'
		'l12
		'
		Me.l12.FormattingEnabled = True
		Me.l12.Location = New System.Drawing.Point(214, 102)
		Me.l12.Name = "l12"
		Me.l12.Size = New System.Drawing.Size(95, 56)
		Me.l12.TabIndex = 94
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(384, 77)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(84, 13)
		Me.Label28.TabIndex = 72
		Me.Label28.Text = "Dias a antecipar"
		'
		'txtDiasAntecipar
		'
		Me.txtDiasAntecipar.Location = New System.Drawing.Point(387, 93)
		Me.txtDiasAntecipar.Name = "txtDiasAntecipar"
		Me.txtDiasAntecipar.Size = New System.Drawing.Size(100, 20)
		Me.txtDiasAntecipar.TabIndex = 71
		Me.txtDiasAntecipar.Text = "5"
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
		Me.GroupBox3.Controls.Add(Me.cboTipoDeslocamento)
		Me.GroupBox3.Controls.Add(Me.Label15)
		Me.GroupBox3.Controls.Add(Me.txtCustoDiario)
		Me.GroupBox3.Controls.Add(Me.Label16)
		Me.GroupBox3.Controls.Add(Me.cboVeiculosEmpresa)
		Me.GroupBox3.Controls.Add(Me.Label17)
		Me.GroupBox3.Location = New System.Drawing.Point(39, 57)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(293, 120)
		Me.GroupBox3.TabIndex = 95
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Custo com Veiculo"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(315, 50)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(87, 26)
		Me.Label5.TabIndex = 101
		Me.Label5.Text = "Valor Liquido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pós Antecipação"
		'
		'lblValorLiquidoAnteci
		'
		Me.lblValorLiquidoAnteci.AutoSize = True
		Me.lblValorLiquidoAnteci.Location = New System.Drawing.Point(359, 86)
		Me.lblValorLiquidoAnteci.Name = "lblValorLiquidoAnteci"
		Me.lblValorLiquidoAnteci.Size = New System.Drawing.Size(13, 13)
		Me.lblValorLiquidoAnteci.TabIndex = 100
		Me.lblValorLiquidoAnteci.Text = "0"
		'
		'l13
		'
		Me.l13.FormattingEnabled = True
		Me.l13.Location = New System.Drawing.Point(311, 44)
		Me.l13.Name = "l13"
		Me.l13.Size = New System.Drawing.Size(95, 56)
		Me.l13.TabIndex = 102
		'
		'btnCriarAgendamento
		'
		Me.btnCriarAgendamento.Location = New System.Drawing.Point(21, 262)
		Me.btnCriarAgendamento.Name = "btnCriarAgendamento"
		Me.btnCriarAgendamento.Size = New System.Drawing.Size(127, 46)
		Me.btnCriarAgendamento.TabIndex = 103
		Me.btnCriarAgendamento.Text = "Criar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Agendamento"
		Me.btnCriarAgendamento.UseVisualStyleBackColor = True
		'
		'txtNumOS
		'
		Me.txtNumOS.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumOS.Location = New System.Drawing.Point(8, 23)
		Me.txtNumOS.Name = "txtNumOS"
		Me.txtNumOS.Size = New System.Drawing.Size(240, 38)
		Me.txtNumOS.TabIndex = 104
		Me.txtNumOS.Text = "0001"
		Me.txtNumOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(5, 6)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(114, 13)
		Me.Label8.TabIndex = 105
		Me.Label8.Text = "Número do Orçamento"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(187, 263)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(127, 46)
		Me.Button2.TabIndex = 106
		Me.Button2.Text = "Visualisar Agendamento"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(33, 43)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(76, 13)
		Me.Label26.TabIndex = 113
		Me.Label26.Text = "Previsão Visita"
		'
		'picDataVisita
		'
		Me.picDataVisita.Location = New System.Drawing.Point(23, 59)
		Me.picDataVisita.Name = "picDataVisita"
		Me.picDataVisita.Size = New System.Drawing.Size(245, 20)
		Me.picDataVisita.TabIndex = 112
		'
		'btnInserirVisita
		'
		Me.btnInserirVisita.Location = New System.Drawing.Point(23, 225)
		Me.btnInserirVisita.Name = "btnInserirVisita"
		Me.btnInserirVisita.Size = New System.Drawing.Size(127, 46)
		Me.btnInserirVisita.TabIndex = 114
		Me.btnInserirVisita.Text = "Inserir Visita"
		Me.btnInserirVisita.UseVisualStyleBackColor = True
		'
		'cboOrcamentista
		'
		Me.cboOrcamentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOrcamentista.FormattingEnabled = True
		Me.cboOrcamentista.Items.AddRange(New Object() {"N/A", "Diego", "Paulo"})
		Me.cboOrcamentista.Location = New System.Drawing.Point(23, 140)
		Me.cboOrcamentista.Name = "cboOrcamentista"
		Me.cboOrcamentista.Size = New System.Drawing.Size(127, 21)
		Me.cboOrcamentista.TabIndex = 42
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(24, 124)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(120, 13)
		Me.Label27.TabIndex = 43
		Me.Label27.Text = "Orçamentista de Campo"
		'
		'cboStatusVisita
		'
		Me.cboStatusVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStatusVisita.FormattingEnabled = True
		Me.cboStatusVisita.Items.AddRange(New Object() {"Em Espera", "Concluida"})
		Me.cboStatusVisita.Location = New System.Drawing.Point(182, 140)
		Me.cboStatusVisita.Name = "cboStatusVisita"
		Me.cboStatusVisita.Size = New System.Drawing.Size(127, 21)
		Me.cboStatusVisita.TabIndex = 115
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(183, 124)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(37, 13)
		Me.Label29.TabIndex = 116
		Me.Label29.Text = "Status"
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Location = New System.Drawing.Point(23, 171)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(58, 13)
		Me.Label30.TabIndex = 118
		Me.Label30.Text = "Hora Visita"
		'
		'picHoraVisita
		'
		Me.picHoraVisita.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.picHoraVisita.Location = New System.Drawing.Point(23, 187)
		Me.picHoraVisita.Name = "picHoraVisita"
		Me.picHoraVisita.Size = New System.Drawing.Size(81, 20)
		Me.picHoraVisita.TabIndex = 117
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1251.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.pnPrincipal, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1251, 702)
		Me.TableLayoutPanel1.TabIndex = 119
		'
		'pnPrincipal
		'
		Me.pnPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.pnPrincipal.Controls.Add(Me.pnInfoCliente)
		Me.pnPrincipal.Controls.Add(Me.pnMaterial)
		Me.pnPrincipal.Controls.Add(Me.pnItens)
		Me.pnPrincipal.Controls.Add(Me.pnCustos)
		Me.pnPrincipal.Controls.Add(Me.pnAgendamento)
		Me.pnPrincipal.Controls.Add(Me.pnVisita)
		Me.pnPrincipal.Controls.Add(Me.pnMedicao)
		Me.pnPrincipal.Controls.Add(Me.pnRelatorio)
		Me.pnPrincipal.Controls.Add(Me.pnFinalizacao)
		Me.pnPrincipal.Controls.Add(Me.pnFinanceiro)
		Me.pnPrincipal.Controls.Add(Me.pnExTempo)
		Me.pnPrincipal.Controls.Add(Me.pnPagamento)
		Me.pnPrincipal.Location = New System.Drawing.Point(3, 79)
		Me.pnPrincipal.Name = "pnPrincipal"
		Me.pnPrincipal.Size = New System.Drawing.Size(1245, 620)
		Me.pnPrincipal.TabIndex = 120
		'
		'pnInfoCliente
		'
		Me.pnInfoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnInfoCliente.BackColor = System.Drawing.Color.White
		Me.pnInfoCliente.Controls.Add(Me.Panel1)
		Me.pnInfoCliente.Controls.Add(Me.Label31)
		Me.pnInfoCliente.Controls.Add(Me.btnExCliente)
		Me.pnInfoCliente.Location = New System.Drawing.Point(4, 6)
		Me.pnInfoCliente.Name = "pnInfoCliente"
		Me.pnInfoCliente.Size = New System.Drawing.Size(1218, 607)
		Me.pnInfoCliente.TabIndex = 120
		'
		'Panel1
		'
		Me.Panel1.AutoScroll = True
		Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(0, 20)
		Me.Panel1.BackColor = System.Drawing.Color.Silver
		Me.Panel1.Controls.Add(Me.txtPesquisarCliente)
		Me.Panel1.Controls.Add(Me.cboTipoPessoa)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.dgvClientes)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.dgvEnderecos)
		Me.Panel1.Location = New System.Drawing.Point(6, 62)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1209, 512)
		Me.Panel1.TabIndex = 121
		'
		'Label31
		'
		Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label31.AutoSize = True
		Me.Label31.Location = New System.Drawing.Point(36, 587)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(137, 13)
		Me.Label31.TabIndex = 120
		Me.Label31.Text = "Informações sobre o cliente"
		'
		'btnExCliente
		'
		Me.btnExCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExCliente.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnExCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExCliente.Location = New System.Drawing.Point(6, 582)
		Me.btnExCliente.Name = "btnExCliente"
		Me.btnExCliente.Size = New System.Drawing.Size(24, 23)
		Me.btnExCliente.TabIndex = 120
		Me.btnExCliente.UseVisualStyleBackColor = True
		'
		'pnMaterial
		'
		Me.pnMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnMaterial.BackColor = System.Drawing.Color.White
		Me.pnMaterial.Controls.Add(Me.TextBox3)
		Me.pnMaterial.Controls.Add(Me.Label47)
		Me.pnMaterial.Controls.Add(Me.btnListaMaterial)
		Me.pnMaterial.Controls.Add(Me.Label48)
		Me.pnMaterial.Location = New System.Drawing.Point(4, 263)
		Me.pnMaterial.Name = "pnMaterial"
		Me.pnMaterial.Size = New System.Drawing.Size(1218, 29)
		Me.pnMaterial.TabIndex = 130
		'
		'TextBox3
		'
		Me.TextBox3.Enabled = False
		Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(21, 108)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(240, 38)
		Me.TextBox3.TabIndex = 120
		'
		'Label47
		'
		Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label47.AutoSize = True
		Me.Label47.Location = New System.Drawing.Point(36, 7)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(196, 13)
		Me.Label47.TabIndex = 120
		Me.Label47.Text = "Listas de Materiais (Pedidos Vinculados)"
		'
		'btnListaMaterial
		'
		Me.btnListaMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnListaMaterial.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnListaMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnListaMaterial.Location = New System.Drawing.Point(6, 3)
		Me.btnListaMaterial.Name = "btnListaMaterial"
		Me.btnListaMaterial.Size = New System.Drawing.Size(24, 23)
		Me.btnListaMaterial.TabIndex = 120
		Me.btnListaMaterial.UseVisualStyleBackColor = True
		'
		'Label48
		'
		Me.Label48.AutoSize = True
		Me.Label48.Location = New System.Drawing.Point(26, 91)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(93, 13)
		Me.Label48.TabIndex = 121
		Me.Label48.Text = "Total Considerado"
		'
		'pnItens
		'
		Me.pnItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnItens.BackColor = System.Drawing.Color.White
		Me.pnItens.Controls.Add(Me.Label33)
		Me.pnItens.Controls.Add(Me.txtPesquisar)
		Me.pnItens.Controls.Add(Me.Label32)
		Me.pnItens.Controls.Add(Me.btnExItens)
		Me.pnItens.Controls.Add(Me.dgvServicosDis)
		Me.pnItens.Controls.Add(Me.Label4)
		Me.pnItens.Controls.Add(Me.dgvServicoEscolhido)
		Me.pnItens.Controls.Add(Me.Label3)
		Me.pnItens.Location = New System.Drawing.Point(4, 40)
		Me.pnItens.Name = "pnItens"
		Me.pnItens.Size = New System.Drawing.Size(1218, 28)
		Me.pnItens.TabIndex = 121
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Location = New System.Drawing.Point(6, 36)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(47, 13)
		Me.Label33.TabIndex = 122
		Me.Label33.Text = "Procurar"
		'
		'txtPesquisar
		'
		Me.txtPesquisar.Depth = 0
		Me.txtPesquisar.Hint = ""
		Me.txtPesquisar.Location = New System.Drawing.Point(9, 52)
		Me.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER
		Me.txtPesquisar.Name = "txtPesquisar"
		Me.txtPesquisar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtPesquisar.SelectedText = ""
		Me.txtPesquisar.SelectionLength = 0
		Me.txtPesquisar.SelectionStart = 0
		Me.txtPesquisar.Size = New System.Drawing.Size(286, 23)
		Me.txtPesquisar.TabIndex = 121
		Me.txtPesquisar.Text = "Digite o nome do item"
		Me.txtPesquisar.UseSystemPasswordChar = False
		'
		'Label32
		'
		Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label32.AutoSize = True
		Me.Label32.Location = New System.Drawing.Point(36, 8)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(95, 13)
		Me.Label32.TabIndex = 120
		Me.Label32.Text = "Itens selecionados"
		'
		'btnExItens
		'
		Me.btnExItens.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExItens.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnExItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExItens.Location = New System.Drawing.Point(6, 3)
		Me.btnExItens.Name = "btnExItens"
		Me.btnExItens.Size = New System.Drawing.Size(24, 23)
		Me.btnExItens.TabIndex = 120
		Me.btnExItens.UseVisualStyleBackColor = True
		'
		'pnCustos
		'
		Me.pnCustos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnCustos.BackColor = System.Drawing.Color.White
		Me.pnCustos.Controls.Add(Me.Label39)
		Me.pnCustos.Controls.Add(Me.btnExCustos)
		Me.pnCustos.Controls.Add(Me.GroupBox3)
		Me.pnCustos.Location = New System.Drawing.Point(4, 135)
		Me.pnCustos.Name = "pnCustos"
		Me.pnCustos.Size = New System.Drawing.Size(1218, 28)
		Me.pnCustos.TabIndex = 125
		'
		'Label39
		'
		Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label39.AutoSize = True
		Me.Label39.Location = New System.Drawing.Point(36, 8)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(39, 13)
		Me.Label39.TabIndex = 120
		Me.Label39.Text = "Custos"
		'
		'btnExCustos
		'
		Me.btnExCustos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExCustos.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnExCustos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExCustos.Location = New System.Drawing.Point(6, 3)
		Me.btnExCustos.Name = "btnExCustos"
		Me.btnExCustos.Size = New System.Drawing.Size(24, 23)
		Me.btnExCustos.TabIndex = 120
		Me.btnExCustos.UseVisualStyleBackColor = True
		'
		'pnAgendamento
		'
		Me.pnAgendamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnAgendamento.BackColor = System.Drawing.Color.White
		Me.pnAgendamento.Controls.Add(Me.Label46)
		Me.pnAgendamento.Controls.Add(Me.picHoraInicio)
		Me.pnAgendamento.Controls.Add(Me.Button7)
		Me.pnAgendamento.Controls.Add(Me.Label19)
		Me.pnAgendamento.Controls.Add(Me.Button2)
		Me.pnAgendamento.Controls.Add(Me.btnAgendamento)
		Me.pnAgendamento.Controls.Add(Me.btnCriarAgendamento)
		Me.pnAgendamento.Controls.Add(Me.picDataInicio)
		Me.pnAgendamento.Controls.Add(Me.Label7)
		Me.pnAgendamento.Controls.Add(Me.pnCalendario)
		Me.pnAgendamento.Controls.Add(Me.PicDataTermino)
		Me.pnAgendamento.Controls.Add(Me.Label23)
		Me.pnAgendamento.Location = New System.Drawing.Point(4, 199)
		Me.pnAgendamento.Name = "pnAgendamento"
		Me.pnAgendamento.Size = New System.Drawing.Size(1218, 28)
		Me.pnAgendamento.TabIndex = 127
		'
		'Label46
		'
		Me.Label46.AutoSize = True
		Me.Label46.Location = New System.Drawing.Point(311, 40)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(96, 13)
		Me.Label46.TabIndex = 123
		Me.Label46.Text = "Horario de Entrada"
		Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'picHoraInicio
		'
		Me.picHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.picHoraInicio.Location = New System.Drawing.Point(321, 56)
		Me.picHoraInicio.Name = "picHoraInicio"
		Me.picHoraInicio.Size = New System.Drawing.Size(76, 20)
		Me.picHoraInicio.TabIndex = 122
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(321, 93)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(94, 48)
		Me.Button7.TabIndex = 121
		Me.Button7.Text = "Auto Calcular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Termino"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Label19
		'
		Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(36, 8)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(73, 13)
		Me.Label19.TabIndex = 120
		Me.Label19.Text = "Agendamento"
		'
		'btnAgendamento
		'
		Me.btnAgendamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnAgendamento.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnAgendamento.Location = New System.Drawing.Point(6, 3)
		Me.btnAgendamento.Name = "btnAgendamento"
		Me.btnAgendamento.Size = New System.Drawing.Size(24, 23)
		Me.btnAgendamento.TabIndex = 120
		Me.btnAgendamento.UseVisualStyleBackColor = True
		'
		'pnVisita
		'
		Me.pnVisita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnVisita.BackColor = System.Drawing.Color.White
		Me.pnVisita.Controls.Add(Me.Label40)
		Me.pnVisita.Controls.Add(Me.Label30)
		Me.pnVisita.Controls.Add(Me.btnVisitas)
		Me.pnVisita.Controls.Add(Me.picHoraVisita)
		Me.pnVisita.Controls.Add(Me.picDataVisita)
		Me.pnVisita.Controls.Add(Me.cboStatusVisita)
		Me.pnVisita.Controls.Add(Me.Label26)
		Me.pnVisita.Controls.Add(Me.Label29)
		Me.pnVisita.Controls.Add(Me.btnInserirVisita)
		Me.pnVisita.Controls.Add(Me.cboOrcamentista)
		Me.pnVisita.Controls.Add(Me.Label27)
		Me.pnVisita.Location = New System.Drawing.Point(4, 167)
		Me.pnVisita.Name = "pnVisita"
		Me.pnVisita.Size = New System.Drawing.Size(1218, 28)
		Me.pnVisita.TabIndex = 126
		'
		'Label40
		'
		Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label40.AutoSize = True
		Me.Label40.Location = New System.Drawing.Point(36, 8)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(37, 13)
		Me.Label40.TabIndex = 120
		Me.Label40.Text = "Visitas"
		'
		'btnVisitas
		'
		Me.btnVisitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnVisitas.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnVisitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnVisitas.Location = New System.Drawing.Point(6, 3)
		Me.btnVisitas.Name = "btnVisitas"
		Me.btnVisitas.Size = New System.Drawing.Size(24, 23)
		Me.btnVisitas.TabIndex = 120
		Me.btnVisitas.UseVisualStyleBackColor = True
		'
		'pnMedicao
		'
		Me.pnMedicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnMedicao.BackColor = System.Drawing.Color.White
		Me.pnMedicao.Controls.Add(Me.TextBox2)
		Me.pnMedicao.Controls.Add(Me.Label44)
		Me.pnMedicao.Controls.Add(Me.btnMedicao)
		Me.pnMedicao.Controls.Add(Me.Label45)
		Me.pnMedicao.Location = New System.Drawing.Point(4, 327)
		Me.pnMedicao.Name = "pnMedicao"
		Me.pnMedicao.Size = New System.Drawing.Size(1218, 28)
		Me.pnMedicao.TabIndex = 130
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(21, 108)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(240, 38)
		Me.TextBox2.TabIndex = 120
		'
		'Label44
		'
		Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label44.AutoSize = True
		Me.Label44.Location = New System.Drawing.Point(36, 8)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(53, 13)
		Me.Label44.TabIndex = 120
		Me.Label44.Text = "Medições"
		'
		'btnMedicao
		'
		Me.btnMedicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnMedicao.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnMedicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnMedicao.Location = New System.Drawing.Point(6, 3)
		Me.btnMedicao.Name = "btnMedicao"
		Me.btnMedicao.Size = New System.Drawing.Size(24, 23)
		Me.btnMedicao.TabIndex = 120
		Me.btnMedicao.UseVisualStyleBackColor = True
		'
		'Label45
		'
		Me.Label45.AutoSize = True
		Me.Label45.Location = New System.Drawing.Point(26, 91)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(93, 13)
		Me.Label45.TabIndex = 121
		Me.Label45.Text = "Total Considerado"
		'
		'pnRelatorio
		'
		Me.pnRelatorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnRelatorio.BackColor = System.Drawing.Color.White
		Me.pnRelatorio.Controls.Add(Me.TextBox1)
		Me.pnRelatorio.Controls.Add(Me.Label41)
		Me.pnRelatorio.Controls.Add(Me.btnRelatorio)
		Me.pnRelatorio.Controls.Add(Me.Label43)
		Me.pnRelatorio.Location = New System.Drawing.Point(4, 295)
		Me.pnRelatorio.Name = "pnRelatorio"
		Me.pnRelatorio.Size = New System.Drawing.Size(1218, 28)
		Me.pnRelatorio.TabIndex = 130
		'
		'TextBox1
		'
		Me.TextBox1.Enabled = False
		Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(21, 108)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(240, 38)
		Me.TextBox1.TabIndex = 120
		'
		'Label41
		'
		Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label41.AutoSize = True
		Me.Label41.Location = New System.Drawing.Point(36, 8)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(132, 13)
		Me.Label41.TabIndex = 120
		Me.Label41.Text = "Relatórios  e Observações"
		'
		'btnRelatorio
		'
		Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnRelatorio.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnRelatorio.Location = New System.Drawing.Point(6, 3)
		Me.btnRelatorio.Name = "btnRelatorio"
		Me.btnRelatorio.Size = New System.Drawing.Size(24, 23)
		Me.btnRelatorio.TabIndex = 120
		Me.btnRelatorio.UseVisualStyleBackColor = True
		'
		'Label43
		'
		Me.Label43.AutoSize = True
		Me.Label43.Location = New System.Drawing.Point(26, 91)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(93, 13)
		Me.Label43.TabIndex = 121
		Me.Label43.Text = "Total Considerado"
		'
		'pnFinalizacao
		'
		Me.pnFinalizacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnFinalizacao.BackColor = System.Drawing.Color.White
		Me.pnFinalizacao.Controls.Add(Me.txtTotalConsiderado)
		Me.pnFinalizacao.Controls.Add(Me.Label25)
		Me.pnFinalizacao.Controls.Add(Me.btnFinalizacao)
		Me.pnFinalizacao.Controls.Add(Me.Label6)
		Me.pnFinalizacao.Location = New System.Drawing.Point(4, 360)
		Me.pnFinalizacao.Name = "pnFinalizacao"
		Me.pnFinalizacao.Size = New System.Drawing.Size(1218, 28)
		Me.pnFinalizacao.TabIndex = 129
		'
		'txtTotalConsiderado
		'
		Me.txtTotalConsiderado.Enabled = False
		Me.txtTotalConsiderado.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalConsiderado.Location = New System.Drawing.Point(21, 108)
		Me.txtTotalConsiderado.Name = "txtTotalConsiderado"
		Me.txtTotalConsiderado.Size = New System.Drawing.Size(240, 38)
		Me.txtTotalConsiderado.TabIndex = 120
		'
		'Label25
		'
		Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label25.AutoSize = True
		Me.Label25.Location = New System.Drawing.Point(36, 8)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(63, 13)
		Me.Label25.TabIndex = 120
		Me.Label25.Text = "Finalizarção"
		'
		'btnFinalizacao
		'
		Me.btnFinalizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnFinalizacao.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnFinalizacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnFinalizacao.Location = New System.Drawing.Point(6, 3)
		Me.btnFinalizacao.Name = "btnFinalizacao"
		Me.btnFinalizacao.Size = New System.Drawing.Size(24, 23)
		Me.btnFinalizacao.TabIndex = 120
		Me.btnFinalizacao.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(26, 91)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(93, 13)
		Me.Label6.TabIndex = 121
		Me.Label6.Text = "Total Considerado"
		'
		'pnFinanceiro
		'
		Me.pnFinanceiro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnFinanceiro.BackColor = System.Drawing.Color.White
		Me.pnFinanceiro.Controls.Add(Me.Label24)
		Me.pnFinanceiro.Controls.Add(Me.btnFinanceiro)
		Me.pnFinanceiro.Controls.Add(Me.Label11)
		Me.pnFinanceiro.Controls.Add(Me.Label5)
		Me.pnFinanceiro.Controls.Add(Me.lblValorLiquidoAnteci)
		Me.pnFinanceiro.Controls.Add(Me.l13)
		Me.pnFinanceiro.Controls.Add(Me.lblTotalComDiaria)
		Me.pnFinanceiro.Controls.Add(Me.Label37)
		Me.pnFinanceiro.Controls.Add(Me.lblTotalDiaria)
		Me.pnFinanceiro.Controls.Add(Me.Label36)
		Me.pnFinanceiro.Controls.Add(Me.l5)
		Me.pnFinanceiro.Controls.Add(Me.lblLucroAtual)
		Me.pnFinanceiro.Controls.Add(Me.Label21)
		Me.pnFinanceiro.Controls.Add(Me.lblTotalMDO)
		Me.pnFinanceiro.Controls.Add(Me.l10)
		Me.pnFinanceiro.Controls.Add(Me.Label18)
		Me.pnFinanceiro.Controls.Add(Me.Label10)
		Me.pnFinanceiro.Controls.Add(Me.txtCustoTotalVeiculo)
		Me.pnFinanceiro.Controls.Add(Me.Label12)
		Me.pnFinanceiro.Controls.Add(Me.l9)
		Me.pnFinanceiro.Controls.Add(Me.Label20)
		Me.pnFinanceiro.Controls.Add(Me.lblTotalOS)
		Me.pnFinanceiro.Controls.Add(Me.lblTotalAntecipacao)
		Me.pnFinanceiro.Controls.Add(Me.Label22)
		Me.pnFinanceiro.Controls.Add(Me.l8)
		Me.pnFinanceiro.Controls.Add(Me.l11)
		Me.pnFinanceiro.Controls.Add(Me.l6)
		Me.pnFinanceiro.Controls.Add(Me.l12)
		Me.pnFinanceiro.Controls.Add(Me.l7)
		Me.pnFinanceiro.Location = New System.Drawing.Point(4, 231)
		Me.pnFinanceiro.Name = "pnFinanceiro"
		Me.pnFinanceiro.Size = New System.Drawing.Size(1218, 28)
		Me.pnFinanceiro.TabIndex = 128
		'
		'Label24
		'
		Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(36, 8)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(98, 13)
		Me.Label24.TabIndex = 120
		Me.Label24.Text = "Resumo Financeiro"
		'
		'btnFinanceiro
		'
		Me.btnFinanceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnFinanceiro.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnFinanceiro.Location = New System.Drawing.Point(6, 3)
		Me.btnFinanceiro.Name = "btnFinanceiro"
		Me.btnFinanceiro.Size = New System.Drawing.Size(24, 23)
		Me.btnFinanceiro.TabIndex = 120
		Me.btnFinanceiro.UseVisualStyleBackColor = True
		'
		'pnExTempo
		'
		Me.pnExTempo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnExTempo.BackColor = System.Drawing.Color.White
		Me.pnExTempo.Controls.Add(Me.Label42)
		Me.pnExTempo.Controls.Add(Me.btnExTempo)
		Me.pnExTempo.Controls.Add(Me.Label9)
		Me.pnExTempo.Controls.Add(Me.lblTempoExecucao)
		Me.pnExTempo.Controls.Add(Me.Label13)
		Me.pnExTempo.Controls.Add(Me.nudJornadaTrabalho)
		Me.pnExTempo.Controls.Add(Me.Label14)
		Me.pnExTempo.Controls.Add(Me.lblTempoExecDia)
		Me.pnExTempo.Controls.Add(Me.chkNeceAjudante)
		Me.pnExTempo.Controls.Add(Me.btnCalcular)
		Me.pnExTempo.Location = New System.Drawing.Point(4, 104)
		Me.pnExTempo.Name = "pnExTempo"
		Me.pnExTempo.Size = New System.Drawing.Size(1218, 28)
		Me.pnExTempo.TabIndex = 124
		'
		'Label42
		'
		Me.Label42.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label42.AutoSize = True
		Me.Label42.Location = New System.Drawing.Point(36, 8)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(86, 13)
		Me.Label42.TabIndex = 120
		Me.Label42.Text = "Tempo Extimado"
		'
		'btnExTempo
		'
		Me.btnExTempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExTempo.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnExTempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExTempo.Location = New System.Drawing.Point(6, 3)
		Me.btnExTempo.Name = "btnExTempo"
		Me.btnExTempo.Size = New System.Drawing.Size(24, 23)
		Me.btnExTempo.TabIndex = 120
		Me.btnExTempo.UseVisualStyleBackColor = True
		'
		'pnPagamento
		'
		Me.pnPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnPagamento.BackColor = System.Drawing.Color.White
		Me.pnPagamento.Controls.Add(Me.Label34)
		Me.pnPagamento.Controls.Add(Me.Label28)
		Me.pnPagamento.Controls.Add(Me.chkEntrada)
		Me.pnPagamento.Controls.Add(Me.Label35)
		Me.pnPagamento.Controls.Add(Me.txtValorEntrada)
		Me.pnPagamento.Controls.Add(Me.dgvParcelas)
		Me.pnPagamento.Controls.Add(Me.txtDiasAntecipar)
		Me.pnPagamento.Controls.Add(Me.Label38)
		Me.pnPagamento.Controls.Add(Me.btnExPagamento)
		Me.pnPagamento.Controls.Add(Me.cboModCred)
		Me.pnPagamento.Location = New System.Drawing.Point(4, 72)
		Me.pnPagamento.Name = "pnPagamento"
		Me.pnPagamento.Size = New System.Drawing.Size(1218, 28)
		Me.pnPagamento.TabIndex = 123
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(6, 76)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(44, 13)
		Me.Label34.TabIndex = 121
		Me.Label34.Text = "Entrada"
		'
		'Label38
		'
		Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label38.AutoSize = True
		Me.Label38.Location = New System.Drawing.Point(36, 8)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(116, 13)
		Me.Label38.TabIndex = 120
		Me.Label38.Text = "Opções de Pagamento"
		'
		'btnExPagamento
		'
		Me.btnExPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExPagamento.BackgroundImage = Global.ControleOS.My.Resources.Resources.Info
		Me.btnExPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExPagamento.Location = New System.Drawing.Point(6, 3)
		Me.btnExPagamento.Name = "btnExPagamento"
		Me.btnExPagamento.Size = New System.Drawing.Size(24, 23)
		Me.btnExPagamento.TabIndex = 120
		Me.btnExPagamento.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
		Me.Panel2.Controls.Add(Me.Button1)
		Me.Panel2.Controls.Add(Me.txtNumOS)
		Me.Panel2.Controls.Add(Me.Label8)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(3, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1245, 70)
		Me.Panel2.TabIndex = 120
		'
		'cboTipoPessoa
		'
		Me.cboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoPessoa.FormattingEnabled = True
		Me.cboTipoPessoa.Items.AddRange(New Object() {"Todos", "Pessoa Fisica", "Pessoa Juridica", "Colaborador"})
		Me.cboTipoPessoa.Location = New System.Drawing.Point(742, 9)
		Me.cboTipoPessoa.Name = "cboTipoPessoa"
		Me.cboTipoPessoa.Size = New System.Drawing.Size(152, 21)
		Me.cboTipoPessoa.TabIndex = 123
		'
		'txtPesquisarCliente
		'
		Me.txtPesquisarCliente.Location = New System.Drawing.Point(900, 9)
		Me.txtPesquisarCliente.Name = "txtPesquisarCliente"
		Me.txtPesquisarCliente.Size = New System.Drawing.Size(284, 20)
		Me.txtPesquisarCliente.TabIndex = 124
		Me.txtPesquisarCliente.Text = " "
		'
		'FrmNovoOrcamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
		Me.AutoScrollMinSize = New System.Drawing.Size(0, 50)
		Me.ClientSize = New System.Drawing.Size(1254, 704)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "FrmNovoOrcamento"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvEnderecos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvServicoEscolhido, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvServicosDis, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudJornadaTrabalho, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.pnPrincipal.ResumeLayout(False)
		Me.pnInfoCliente.ResumeLayout(False)
		Me.pnInfoCliente.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.pnMaterial.ResumeLayout(False)
		Me.pnMaterial.PerformLayout()
		Me.pnItens.ResumeLayout(False)
		Me.pnItens.PerformLayout()
		Me.pnCustos.ResumeLayout(False)
		Me.pnCustos.PerformLayout()
		Me.pnAgendamento.ResumeLayout(False)
		Me.pnAgendamento.PerformLayout()
		Me.pnVisita.ResumeLayout(False)
		Me.pnVisita.PerformLayout()
		Me.pnMedicao.ResumeLayout(False)
		Me.pnMedicao.PerformLayout()
		Me.pnRelatorio.ResumeLayout(False)
		Me.pnRelatorio.PerformLayout()
		Me.pnFinalizacao.ResumeLayout(False)
		Me.pnFinalizacao.PerformLayout()
		Me.pnFinanceiro.ResumeLayout(False)
		Me.pnFinanceiro.PerformLayout()
		Me.pnExTempo.ResumeLayout(False)
		Me.pnExTempo.PerformLayout()
		Me.pnPagamento.ResumeLayout(False)
		Me.pnPagamento.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents dgvClientes As DataGridView
	Friend WithEvents dgvEnderecos As DataGridView
	Friend WithEvents dgvServicoEscolhido As DataGridView
	Friend WithEvents dgvServicosDis As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents lblTempoExecucao As Label
	Friend WithEvents lblTotalMDO As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents dgvParcelas As DataGridView
	Friend WithEvents Label10 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents lblTotalOS As Label
	Friend WithEvents chkEntrada As CheckBox
	Friend WithEvents txtValorEntrada As TextBox
	Friend WithEvents nudJornadaTrabalho As NumericUpDown
	Friend WithEvents Label13 As Label
	Friend WithEvents lblTempoExecDia As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents cboTipoDeslocamento As ComboBox
	Friend WithEvents Label15 As Label
	Friend WithEvents txtCustoDiario As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents cboVeiculosEmpresa As ComboBox
	Friend WithEvents Label18 As Label
	Friend WithEvents l6 As ListBox
	Friend WithEvents l5 As ListBox
	Friend WithEvents txtCustoTotalVeiculo As Label
	Friend WithEvents lblTotalAntecipacao As Label
	Friend WithEvents Label20 As Label
	Friend WithEvents l7 As ListBox
	Friend WithEvents Label22 As Label
	Friend WithEvents l8 As ListBox
	Friend WithEvents l9 As ListBox
	Friend WithEvents lblLucroAtual As Label
	Friend WithEvents Label21 As Label
	Friend WithEvents l10 As ListBox
	Friend WithEvents picDataInicio As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents pnCalendario As Panel
	Friend WithEvents Label23 As Label
	Friend WithEvents PicDataTermino As DateTimePicker
	Friend WithEvents Label35 As Label
	Friend WithEvents cboModCred As ComboBox
	Friend WithEvents btnCalcular As Button
	Friend WithEvents lblTotalComDiaria As Label
	Friend WithEvents Label36 As Label
	Friend WithEvents l11 As ListBox
	Friend WithEvents chkNeceAjudante As CheckBox
	Friend WithEvents lblTotalDiaria As Label
	Friend WithEvents Label37 As Label
	Friend WithEvents l12 As ListBox
	Friend WithEvents Label28 As Label
	Friend WithEvents txtDiasAntecipar As TextBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label5 As Label
	Friend WithEvents lblValorLiquidoAnteci As Label
	Friend WithEvents l13 As ListBox
	Friend WithEvents btnCriarAgendamento As Button
	Friend WithEvents txtNumOS As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Label26 As Label
	Friend WithEvents picDataVisita As DateTimePicker
	Friend WithEvents btnInserirVisita As Button
	Friend WithEvents cboOrcamentista As ComboBox
	Friend WithEvents Label27 As Label
	Friend WithEvents cboStatusVisita As ComboBox
	Friend WithEvents Label29 As Label
	Friend WithEvents Label30 As Label
	Friend WithEvents picHoraVisita As DateTimePicker
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents pnPrincipal As Panel
	Friend WithEvents pnInfoCliente As Panel
	Friend WithEvents Label31 As Label
	Friend WithEvents btnExCliente As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents pnItens As Panel
	Friend WithEvents Label32 As Label
	Friend WithEvents btnExItens As Button
	Friend WithEvents Label33 As Label
	Friend WithEvents txtPesquisar As MaterialSkin.Controls.MaterialSingleLineTextField
	Friend WithEvents pnPagamento As Panel
	Friend WithEvents Label38 As Label
	Friend WithEvents btnExPagamento As Button
	Friend WithEvents pnMedicao As Panel
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label44 As Label
	Friend WithEvents btnMedicao As Button
	Friend WithEvents Label45 As Label
	Friend WithEvents pnRelatorio As Panel
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label41 As Label
	Friend WithEvents btnRelatorio As Button
	Friend WithEvents Label43 As Label
	Friend WithEvents pnFinalizacao As Panel
	Friend WithEvents txtTotalConsiderado As TextBox
	Friend WithEvents Label25 As Label
	Friend WithEvents btnFinalizacao As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents pnFinanceiro As Panel
	Friend WithEvents Label24 As Label
	Friend WithEvents btnFinanceiro As Button
	Friend WithEvents pnAgendamento As Panel
	Friend WithEvents Button7 As Button
	Friend WithEvents Label19 As Label
	Friend WithEvents btnAgendamento As Button
	Friend WithEvents pnVisita As Panel
	Friend WithEvents Label40 As Label
	Friend WithEvents btnVisitas As Button
	Friend WithEvents pnCustos As Panel
	Friend WithEvents Label39 As Label
	Friend WithEvents btnExCustos As Button
	Friend WithEvents pnExTempo As Panel
	Friend WithEvents Label42 As Label
	Friend WithEvents btnExTempo As Button
	Friend WithEvents Label34 As Label
	Friend WithEvents Label46 As Label
	Friend WithEvents picHoraInicio As DateTimePicker
	Friend WithEvents pnMaterial As Panel
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label47 As Label
	Friend WithEvents btnListaMaterial As Button
	Friend WithEvents Label48 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents cboTipoPessoa As ComboBox
	Friend WithEvents txtPesquisarCliente As TextBox
End Class
