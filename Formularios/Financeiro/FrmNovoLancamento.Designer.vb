<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNovoLancamento
        'Inherits System.Windows.Forms.Form

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
	      Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNovoLancamento))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.IdentificaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.JurosAntecipaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VencimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SituacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NumeroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ValorPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvFinanceiro = New System.Windows.Forms.DataGridView()
		Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PlanoContas = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataLancamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnAplicarFiltro = New System.Windows.Forms.Button()
		Me.txtFiltroIdentificacao = New System.Windows.Forms.TextBox()
		Me.mcCalendar = New System.Windows.Forms.MonthCalendar()
		Me.cboSituacaoPag = New System.Windows.Forms.ComboBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtIdentificacao = New System.Windows.Forms.Label()
		Me.txtCliente = New System.Windows.Forms.TextBox()
		Me.cboFormaPagamento = New System.Windows.Forms.ComboBox()
		Me.cboTipoLancamento = New System.Windows.Forms.ComboBox()
		Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
		Me.btnLimparFiltro = New System.Windows.Forms.Button()
		Me.Panel13 = New System.Windows.Forms.Panel()
		Me.Panel12 = New System.Windows.Forms.Panel()
		Me.Panel11 = New System.Windows.Forms.Panel()
		Me.Panel10 = New System.Windows.Forms.Panel()
		Me.Panel9 = New System.Windows.Forms.Panel()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.cboPeriodo = New System.Windows.Forms.ComboBox()
		Me.txtDataInicial = New System.Windows.Forms.TextBox()
		Me.cboData = New System.Windows.Forms.ComboBox()
		Me.txtDataFinal = New System.Windows.Forms.TextBox()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblPagamentosAtraso = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.lblRecebimentoAtraso = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.btnGerarRelatorio = New System.Windows.Forms.Button()
		Me.btnAddLancamento = New System.Windows.Forms.Button()
		Me.btnFechar = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.GerarRelatorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pnDockLeft = New System.Windows.Forms.Panel()
		Me.PnDockTop = New System.Windows.Forms.Panel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnExpDockTop = New System.Windows.Forms.Button()
		Me.tmDockMin = New System.Windows.Forms.Timer(Me.components)
		Me.lblNPago = New System.Windows.Forms.Label()
		Me.lblSomaPago = New System.Windows.Forms.Label()
		Me.chkMovPoup = New System.Windows.Forms.CheckBox()
		Me.grpSoma = New System.Windows.Forms.GroupBox()
		CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel13.SuspendLayout()
		Me.Panel12.SuspendLayout()
		Me.Panel11.SuspendLayout()
		Me.Panel10.SuspendLayout()
		Me.Panel9.SuspendLayout()
		Me.Panel8.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.pnDockLeft.SuspendLayout()
		Me.PnDockTop.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.grpSoma.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(66, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 13)
		Me.Label1.TabIndex = 65
		Me.Label1.Text = "Identificação"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(66, 2)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(121, 13)
		Me.Label5.TabIndex = 75
		Me.Label5.Text = "Situação de Pagamento"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(58, 7)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(85, 13)
		Me.Label7.TabIndex = 77
		Me.Label7.Text = "Nome do Cliente"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(58, 2)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 13)
		Me.Label8.TabIndex = 79
		Me.Label8.Text = "Plano de Contas"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(66, 2)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(90, 13)
		Me.Label9.TabIndex = 81
		Me.Label9.Text = "Tipo Lançamento"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.ForeColor = System.Drawing.Color.White
		Me.Label10.Location = New System.Drawing.Point(66, 1)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(108, 13)
		Me.Label10.TabIndex = 83
		Me.Label10.Text = "Forma de Pagamento"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(96, 7)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 13)
		Me.Label3.TabIndex = 68
		Me.Label3.Text = "Data Inicial:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(173, 5)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 72
		Me.Label4.Text = "Periodo"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(170, 46)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(67, 13)
		Me.Label6.TabIndex = 78
		Me.Label6.Text = "Tipo Periodo"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(98, 46)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(58, 13)
		Me.Label2.TabIndex = 79
		Me.Label2.Text = "Data Final:"
		'
		'IdentificaçãoDataGridViewTextBoxColumn
		'
		Me.IdentificaçãoDataGridViewTextBoxColumn.DataPropertyName = "Identificação"
		Me.IdentificaçãoDataGridViewTextBoxColumn.HeaderText = "Identificação"
		Me.IdentificaçãoDataGridViewTextBoxColumn.Name = "IdentificaçãoDataGridViewTextBoxColumn"
		'
		'ValorDataGridViewTextBoxColumn
		'
		Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
		Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
		Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
		'
		'JurosAntecipaçãoDataGridViewTextBoxColumn
		'
		Me.JurosAntecipaçãoDataGridViewTextBoxColumn.DataPropertyName = "Juros Antecipação"
		Me.JurosAntecipaçãoDataGridViewTextBoxColumn.HeaderText = "Juros Antecipação"
		Me.JurosAntecipaçãoDataGridViewTextBoxColumn.Name = "JurosAntecipaçãoDataGridViewTextBoxColumn"
		'
		'DescricaoDataGridViewTextBoxColumn
		'
		Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
		Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
		Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
		'
		'VencimentoDataGridViewTextBoxColumn
		'
		Me.VencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento"
		Me.VencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento"
		Me.VencimentoDataGridViewTextBoxColumn.Name = "VencimentoDataGridViewTextBoxColumn"
		'
		'SituacaoDataGridViewTextBoxColumn
		'
		Me.SituacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao"
		Me.SituacaoDataGridViewTextBoxColumn.HeaderText = "Situacao"
		Me.SituacaoDataGridViewTextBoxColumn.Name = "SituacaoDataGridViewTextBoxColumn"
		'
		'NumeroDocumentoDataGridViewTextBoxColumn
		'
		Me.NumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento"
		Me.NumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento"
		Me.NumeroDocumentoDataGridViewTextBoxColumn.Name = "NumeroDocumentoDataGridViewTextBoxColumn"
		'
		'BancoDataGridViewTextBoxColumn
		'
		Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
		Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
		Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
		'
		'TipoDataGridViewTextBoxColumn
		'
		Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
		Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
		Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
		'
		'ClienteDataGridViewTextBoxColumn
		'
		Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
		Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
		Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
		'
		'CodigoDataGridViewTextBoxColumn
		'
		Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
		Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
		Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
		'
		'ValorPagoDataGridViewTextBoxColumn
		'
		Me.ValorPagoDataGridViewTextBoxColumn.DataPropertyName = "Valor Pago"
		Me.ValorPagoDataGridViewTextBoxColumn.HeaderText = "Valor Pago"
		Me.ValorPagoDataGridViewTextBoxColumn.Name = "ValorPagoDataGridViewTextBoxColumn"
		'
		'dgvFinanceiro
		'
		Me.dgvFinanceiro.AllowUserToAddRows = False
		Me.dgvFinanceiro.AllowUserToDeleteRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
		Me.dgvFinanceiro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvFinanceiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvFinanceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvFinanceiro.BackgroundColor = System.Drawing.Color.Gray
		Me.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvFinanceiro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.NumeroDocumento, Me.Tipo, Me.Situacao, Me.Vencimento, Me.Valor, Me.PlanoContas, Me.DataLancamento})
		Me.dgvFinanceiro.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.dgvFinanceiro.Location = New System.Drawing.Point(62, 106)
		Me.dgvFinanceiro.Name = "dgvFinanceiro"
		Me.dgvFinanceiro.ReadOnly = True
		Me.dgvFinanceiro.RowHeadersVisible = False
		Me.dgvFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvFinanceiro.Size = New System.Drawing.Size(889, 335)
		Me.dgvFinanceiro.TabIndex = 59
		'
		'Cliente
		'
		Me.Cliente.DataPropertyName = "Cliente"
		Me.Cliente.HeaderText = "Cliente"
		Me.Cliente.Name = "Cliente"
		Me.Cliente.ReadOnly = True
		'
		'NumeroDocumento
		'
		Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
		Me.NumeroDocumento.HeaderText = "Origem"
		Me.NumeroDocumento.Name = "NumeroDocumento"
		Me.NumeroDocumento.ReadOnly = True
		'
		'Tipo
		'
		Me.Tipo.DataPropertyName = "Tipo"
		Me.Tipo.HeaderText = "Tipo"
		Me.Tipo.Name = "Tipo"
		Me.Tipo.ReadOnly = True
		'
		'Situacao
		'
		Me.Situacao.DataPropertyName = "Situacao"
		Me.Situacao.HeaderText = "Situação"
		Me.Situacao.Name = "Situacao"
		Me.Situacao.ReadOnly = True
		'
		'Vencimento
		'
		Me.Vencimento.DataPropertyName = "Vencimento"
		Me.Vencimento.HeaderText = "Vencimento"
		Me.Vencimento.Name = "Vencimento"
		Me.Vencimento.ReadOnly = True
		'
		'Valor
		'
		Me.Valor.DataPropertyName = "Valor"
		DataGridViewCellStyle2.Format = "C2"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.Valor.DefaultCellStyle = DataGridViewCellStyle2
		Me.Valor.HeaderText = "Valor"
		Me.Valor.Name = "Valor"
		Me.Valor.ReadOnly = True
		'
		'PlanoContas
		'
		Me.PlanoContas.DataPropertyName = "PlanoContas"
		Me.PlanoContas.HeaderText = "Plano de Contas"
		Me.PlanoContas.Name = "PlanoContas"
		Me.PlanoContas.ReadOnly = True
		'
		'DataLancamento
		'
		Me.DataLancamento.DataPropertyName = "DataLancamento"
		Me.DataLancamento.HeaderText = "Data do Lançamento"
		Me.DataLancamento.Name = "DataLancamento"
		Me.DataLancamento.ReadOnly = True
		'
		'btnAplicarFiltro
		'
		Me.btnAplicarFiltro.BackColor = System.Drawing.Color.Transparent
		Me.btnAplicarFiltro.FlatAppearance.BorderSize = 0
		Me.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAplicarFiltro.Image = Global.ControleOS.My.Resources.Resources.Confirmar
		Me.btnAplicarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAplicarFiltro.Location = New System.Drawing.Point(512, 121)
		Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
		Me.btnAplicarFiltro.Size = New System.Drawing.Size(140, 46)
		Me.btnAplicarFiltro.TabIndex = 63
		Me.btnAplicarFiltro.Text = "Aplicar Filtro"
		Me.btnAplicarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAplicarFiltro.UseVisualStyleBackColor = False
		'
		'txtFiltroIdentificacao
		'
		Me.txtFiltroIdentificacao.Location = New System.Drawing.Point(68, 19)
		Me.txtFiltroIdentificacao.Name = "txtFiltroIdentificacao"
		Me.txtFiltroIdentificacao.Size = New System.Drawing.Size(152, 20)
		Me.txtFiltroIdentificacao.TabIndex = 64
		'
		'mcCalendar
		'
		Me.mcCalendar.Location = New System.Drawing.Point(673, 15)
		Me.mcCalendar.Name = "mcCalendar"
		Me.mcCalendar.TabIndex = 66
		Me.mcCalendar.Visible = False
		'
		'cboSituacaoPag
		'
		Me.cboSituacaoPag.BackColor = System.Drawing.Color.White
		Me.cboSituacaoPag.FormattingEnabled = True
		Me.cboSituacaoPag.Location = New System.Drawing.Point(68, 15)
		Me.cboSituacaoPag.Name = "cboSituacaoPag"
		Me.cboSituacaoPag.Size = New System.Drawing.Size(152, 21)
		Me.cboSituacaoPag.TabIndex = 74
		Me.cboSituacaoPag.TabStop = False
		Me.cboSituacaoPag.Text = "Todos"
		'
		'Panel3
		'
		Me.Panel3.BackgroundImage = Global.ControleOS.My.Resources.Resources.Banner_status_only
		Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel3.Controls.Add(Me.PictureBox1)
		Me.Panel3.Controls.Add(Me.Label12)
		Me.Panel3.Controls.Add(Me.txtIdentificacao)
		Me.Panel3.Location = New System.Drawing.Point(7, 29)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(171, 54)
		Me.Panel3.TabIndex = 90
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.BackgroundImage = Global.ControleOS.My.Resources.Resources._302997
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(137, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(31, 29)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.Black
		Me.Label12.Location = New System.Drawing.Point(64, 30)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(85, 16)
		Me.Label12.TabIndex = 3
		Me.Label12.Text = "Selecionado"
		'
		'txtIdentificacao
		'
		Me.txtIdentificacao.AutoSize = True
		Me.txtIdentificacao.BackColor = System.Drawing.Color.Transparent
		Me.txtIdentificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIdentificacao.ForeColor = System.Drawing.Color.Black
		Me.txtIdentificacao.Location = New System.Drawing.Point(68, 2)
		Me.txtIdentificacao.Name = "txtIdentificacao"
		Me.txtIdentificacao.Size = New System.Drawing.Size(48, 25)
		Me.txtIdentificacao.TabIndex = 2
		Me.txtIdentificacao.Text = "150"
		'
		'txtCliente
		'
		Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCliente.CausesValidation = False
		Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCliente.Location = New System.Drawing.Point(61, 25)
		Me.txtCliente.Name = "txtCliente"
		Me.txtCliente.Size = New System.Drawing.Size(171, 13)
		Me.txtCliente.TabIndex = 84
		'
		'cboFormaPagamento
		'
		Me.cboFormaPagamento.BackColor = System.Drawing.Color.White
		Me.cboFormaPagamento.FormattingEnabled = True
		Me.cboFormaPagamento.Location = New System.Drawing.Point(68, 15)
		Me.cboFormaPagamento.Name = "cboFormaPagamento"
		Me.cboFormaPagamento.Size = New System.Drawing.Size(164, 21)
		Me.cboFormaPagamento.TabIndex = 82
		Me.cboFormaPagamento.TabStop = False
		'
		'cboTipoLancamento
		'
		Me.cboTipoLancamento.BackColor = System.Drawing.Color.White
		Me.cboTipoLancamento.FormattingEnabled = True
		Me.cboTipoLancamento.Location = New System.Drawing.Point(68, 16)
		Me.cboTipoLancamento.Name = "cboTipoLancamento"
		Me.cboTipoLancamento.Size = New System.Drawing.Size(152, 21)
		Me.cboTipoLancamento.TabIndex = 80
		Me.cboTipoLancamento.TabStop = False
		Me.cboTipoLancamento.Text = "Todos"
		'
		'cboPlanoContas
		'
		Me.cboPlanoContas.BackColor = System.Drawing.Color.White
		Me.cboPlanoContas.FormattingEnabled = True
		Me.cboPlanoContas.Location = New System.Drawing.Point(61, 15)
		Me.cboPlanoContas.Name = "cboPlanoContas"
		Me.cboPlanoContas.Size = New System.Drawing.Size(171, 21)
		Me.cboPlanoContas.TabIndex = 78
		Me.cboPlanoContas.TabStop = False
		'
		'btnLimparFiltro
		'
		Me.btnLimparFiltro.BackColor = System.Drawing.Color.Transparent
		Me.btnLimparFiltro.FlatAppearance.BorderSize = 0
		Me.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimparFiltro.Image = Global.ControleOS.My.Resources.Resources.Borracha_32
		Me.btnLimparFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimparFiltro.Location = New System.Drawing.Point(678, 117)
		Me.btnLimparFiltro.Name = "btnLimparFiltro"
		Me.btnLimparFiltro.Size = New System.Drawing.Size(140, 50)
		Me.btnLimparFiltro.TabIndex = 85
		Me.btnLimparFiltro.Text = "Limpar Filtros"
		Me.btnLimparFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnLimparFiltro.UseVisualStyleBackColor = False
		'
		'Panel13
		'
		Me.Panel13.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_ID
		Me.Panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel13.Controls.Add(Me.txtFiltroIdentificacao)
		Me.Panel13.Controls.Add(Me.Label1)
		Me.Panel13.Location = New System.Drawing.Point(260, 120)
		Me.Panel13.Name = "Panel13"
		Me.Panel13.Size = New System.Drawing.Size(246, 47)
		Me.Panel13.TabIndex = 115
		'
		'Panel12
		'
		Me.Panel12.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_Receita
		Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel12.Controls.Add(Me.cboTipoLancamento)
		Me.Panel12.Controls.Add(Me.Label9)
		Me.Panel12.Location = New System.Drawing.Point(260, 67)
		Me.Panel12.Name = "Panel12"
		Me.Panel12.Size = New System.Drawing.Size(236, 47)
		Me.Panel12.TabIndex = 115
		'
		'Panel11
		'
		Me.Panel11.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_SituacaoPagamento
		Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel11.Controls.Add(Me.Label5)
		Me.Panel11.Controls.Add(Me.cboSituacaoPag)
		Me.Panel11.Location = New System.Drawing.Point(260, 19)
		Me.Panel11.Name = "Panel11"
		Me.Panel11.Size = New System.Drawing.Size(236, 47)
		Me.Panel11.TabIndex = 114
		'
		'Panel10
		'
		Me.Panel10.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_FormaPagamento
		Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel10.Controls.Add(Me.Label10)
		Me.Panel10.Controls.Add(Me.cboFormaPagamento)
		Me.Panel10.Location = New System.Drawing.Point(8, 120)
		Me.Panel10.Name = "Panel10"
		Me.Panel10.Size = New System.Drawing.Size(246, 47)
		Me.Panel10.TabIndex = 113
		'
		'Panel9
		'
		Me.Panel9.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_planoConta
		Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel9.Controls.Add(Me.cboPlanoContas)
		Me.Panel9.Controls.Add(Me.Label8)
		Me.Panel9.Location = New System.Drawing.Point(8, 67)
		Me.Panel9.Name = "Panel9"
		Me.Panel9.Size = New System.Drawing.Size(246, 47)
		Me.Panel9.TabIndex = 113
		'
		'Panel8
		'
		Me.Panel8.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_cliente
		Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel8.Controls.Add(Me.Label7)
		Me.Panel8.Controls.Add(Me.txtCliente)
		Me.Panel8.Location = New System.Drawing.Point(8, 19)
		Me.Panel8.Name = "Panel8"
		Me.Panel8.Size = New System.Drawing.Size(246, 47)
		Me.Panel8.TabIndex = 112
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = Global.ControleOS.My.Resources.Resources.box_p_data
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.Label6)
		Me.Panel7.Controls.Add(Me.Label2)
		Me.Panel7.Controls.Add(Me.cboPeriodo)
		Me.Panel7.Controls.Add(Me.Label4)
		Me.Panel7.Controls.Add(Me.txtDataInicial)
		Me.Panel7.Controls.Add(Me.grpSoma)
		Me.Panel7.Controls.Add(Me.cboData)
		Me.Panel7.Controls.Add(Me.Label3)
		Me.Panel7.Controls.Add(Me.txtDataFinal)
		Me.Panel7.Location = New System.Drawing.Point(502, 19)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(323, 95)
		Me.Panel7.TabIndex = 109
		'
		'cboPeriodo
		'
		Me.cboPeriodo.BackColor = System.Drawing.Color.White
		Me.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboPeriodo.FormattingEnabled = True
		Me.cboPeriodo.Location = New System.Drawing.Point(172, 21)
		Me.cboPeriodo.Name = "cboPeriodo"
		Me.cboPeriodo.Size = New System.Drawing.Size(142, 21)
		Me.cboPeriodo.TabIndex = 71
		Me.cboPeriodo.TabStop = False
		Me.cboPeriodo.Text = "Este Mês"
		'
		'txtDataInicial
		'
		Me.txtDataInicial.Location = New System.Drawing.Point(92, 22)
		Me.txtDataInicial.Name = "txtDataInicial"
		Me.txtDataInicial.Size = New System.Drawing.Size(74, 20)
		Me.txtDataInicial.TabIndex = 67
		'
		'cboData
		'
		Me.cboData.BackColor = System.Drawing.Color.White
		Me.cboData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboData.FormattingEnabled = True
		Me.cboData.Location = New System.Drawing.Point(173, 61)
		Me.cboData.Name = "cboData"
		Me.cboData.Size = New System.Drawing.Size(142, 21)
		Me.cboData.TabIndex = 77
		Me.cboData.TabStop = False
		Me.cboData.Text = "Vencimento"
		'
		'txtDataFinal
		'
		Me.txtDataFinal.Location = New System.Drawing.Point(92, 61)
		Me.txtDataFinal.Name = "txtDataFinal"
		Me.txtDataFinal.Size = New System.Drawing.Size(74, 20)
		Me.txtDataFinal.TabIndex = 69
		'
		'Panel5
		'
		Me.Panel5.BackgroundImage = Global.ControleOS.My.Resources.Resources.Banner_status_only
		Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel5.Controls.Add(Me.PictureBox3)
		Me.Panel5.Controls.Add(Me.Label11)
		Me.Panel5.Controls.Add(Me.lblPagamentosAtraso)
		Me.Panel5.Location = New System.Drawing.Point(398, 29)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(191, 56)
		Me.Panel5.TabIndex = 92
		'
		'PictureBox3
		'
		Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox3.BackgroundImage = Global.ControleOS.My.Resources.Resources.Boleto3
		Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox3.Location = New System.Drawing.Point(158, 2)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(30, 29)
		Me.PictureBox3.TabIndex = 2
		Me.PictureBox3.TabStop = False
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Black
		Me.Label11.Location = New System.Drawing.Point(66, 34)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(100, 16)
		Me.Label11.TabIndex = 3
		Me.Label11.Text = "Pag. em Atraso"
		'
		'lblPagamentosAtraso
		'
		Me.lblPagamentosAtraso.AutoSize = True
		Me.lblPagamentosAtraso.BackColor = System.Drawing.Color.Transparent
		Me.lblPagamentosAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPagamentosAtraso.ForeColor = System.Drawing.Color.Black
		Me.lblPagamentosAtraso.Location = New System.Drawing.Point(99, 3)
		Me.lblPagamentosAtraso.Name = "lblPagamentosAtraso"
		Me.lblPagamentosAtraso.Size = New System.Drawing.Size(48, 25)
		Me.lblPagamentosAtraso.TabIndex = 2
		Me.lblPagamentosAtraso.Text = "150"
		'
		'Panel4
		'
		Me.Panel4.BackgroundImage = Global.ControleOS.My.Resources.Resources.Banner_status_only
		Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel4.Controls.Add(Me.PictureBox2)
		Me.Panel4.Controls.Add(Me.lblRecebimentoAtraso)
		Me.Panel4.Controls.Add(Me.Label13)
		Me.Panel4.Location = New System.Drawing.Point(193, 29)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(190, 56)
		Me.Panel4.TabIndex = 91
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cancelar
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox2.Location = New System.Drawing.Point(160, 3)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(27, 28)
		Me.PictureBox2.TabIndex = 2
		Me.PictureBox2.TabStop = False
		'
		'lblRecebimentoAtraso
		'
		Me.lblRecebimentoAtraso.AutoSize = True
		Me.lblRecebimentoAtraso.BackColor = System.Drawing.Color.Transparent
		Me.lblRecebimentoAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecebimentoAtraso.ForeColor = System.Drawing.Color.Black
		Me.lblRecebimentoAtraso.Location = New System.Drawing.Point(100, 3)
		Me.lblRecebimentoAtraso.Name = "lblRecebimentoAtraso"
		Me.lblRecebimentoAtraso.Size = New System.Drawing.Size(48, 25)
		Me.lblRecebimentoAtraso.TabIndex = 2
		Me.lblRecebimentoAtraso.Text = "150"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.Black
		Me.Label13.Location = New System.Drawing.Point(69, 33)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(108, 16)
		Me.Label13.TabIndex = 3
		Me.Label13.Text = "Recb. em Atraso"
		'
		'btnGerarRelatorio
		'
		Me.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnGerarRelatorio.FlatAppearance.BorderSize = 0
		Me.btnGerarRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
		Me.btnGerarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
		Me.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGerarRelatorio.ForeColor = System.Drawing.Color.White
		Me.btnGerarRelatorio.Image = Global.ControleOS.My.Resources.Resources.Historico
		Me.btnGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnGerarRelatorio.Location = New System.Drawing.Point(5, 2)
		Me.btnGerarRelatorio.Name = "btnGerarRelatorio"
		Me.btnGerarRelatorio.Padding = New System.Windows.Forms.Padding(1)
		Me.btnGerarRelatorio.Size = New System.Drawing.Size(170, 46)
		Me.btnGerarRelatorio.TabIndex = 89
		Me.btnGerarRelatorio.Text = "GERAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RELATÓRIO"
		Me.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnGerarRelatorio.UseVisualStyleBackColor = False
		'
		'btnAddLancamento
		'
		Me.btnAddLancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnAddLancamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAddLancamento.FlatAppearance.BorderSize = 0
		Me.btnAddLancamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
		Me.btnAddLancamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
		Me.btnAddLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddLancamento.ForeColor = System.Drawing.Color.White
		Me.btnAddLancamento.Image = Global.ControleOS.My.Resources.Resources.Adicionar1
		Me.btnAddLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAddLancamento.Location = New System.Drawing.Point(5, 48)
		Me.btnAddLancamento.Name = "btnAddLancamento"
		Me.btnAddLancamento.Size = New System.Drawing.Size(170, 48)
		Me.btnAddLancamento.TabIndex = 85
		Me.btnAddLancamento.Text = "ADICIONAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LANÇAMENTO"
		Me.btnAddLancamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAddLancamento.UseVisualStyleBackColor = False
		'
		'btnFechar
		'
		Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnFechar.FlatAppearance.BorderSize = 0
		Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
		Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
		Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFechar.ForeColor = System.Drawing.Color.White
		Me.btnFechar.Image = Global.ControleOS.My.Resources.Resources.Cancelar
		Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnFechar.Location = New System.Drawing.Point(5, 96)
		Me.btnFechar.Name = "btnFechar"
		Me.btnFechar.Size = New System.Drawing.Size(170, 46)
		Me.btnFechar.TabIndex = 88
		Me.btnFechar.Text = "FECHAR"
		Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnFechar.UseVisualStyleBackColor = False
		'
		'ComboBox1
		'
		Me.ComboBox1.BackColor = System.Drawing.Color.White
		Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(87, 67)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(142, 21)
		Me.ComboBox1.TabIndex = 77
		Me.ComboBox1.TabStop = False
		Me.ComboBox1.Text = "Vencimento"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(2, 24)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(74, 20)
		Me.TextBox1.TabIndex = 67
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(2, 63)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(74, 20)
		Me.TextBox2.TabIndex = 69
		'
		'ComboBox2
		'
		Me.ComboBox2.BackColor = System.Drawing.Color.White
		Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(87, 22)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(142, 21)
		Me.ComboBox2.TabIndex = 71
		Me.ComboBox2.TabStop = False
		Me.ComboBox2.Text = "Este Mês"
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerarRelatorioToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 26)
		'
		'GerarRelatorioToolStripMenuItem
		'
		Me.GerarRelatorioToolStripMenuItem.Name = "GerarRelatorioToolStripMenuItem"
		Me.GerarRelatorioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.GerarRelatorioToolStripMenuItem.Text = "Gerar Relatorio"
		'
		'pnDockLeft
		'
		Me.pnDockLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.pnDockLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.pnDockLeft.Controls.Add(Me.btnGerarRelatorio)
		Me.pnDockLeft.Controls.Add(Me.btnAddLancamento)
		Me.pnDockLeft.Controls.Add(Me.btnFechar)
		Me.pnDockLeft.Location = New System.Drawing.Point(2, 106)
		Me.pnDockLeft.Name = "pnDockLeft"
		Me.pnDockLeft.Size = New System.Drawing.Size(54, 330)
		Me.pnDockLeft.TabIndex = 119
		'
		'PnDockTop
		'
		Me.PnDockTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PnDockTop.BackColor = System.Drawing.Color.Transparent
		Me.PnDockTop.Controls.Add(Me.GroupBox2)
		Me.PnDockTop.Location = New System.Drawing.Point(0, 12)
		Me.PnDockTop.Name = "PnDockTop"
		Me.PnDockTop.Size = New System.Drawing.Size(962, 10)
		Me.PnDockTop.TabIndex = 120
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.White
		Me.GroupBox2.Controls.Add(Me.btnAplicarFiltro)
		Me.GroupBox2.Controls.Add(Me.Panel8)
		Me.GroupBox2.Controls.Add(Me.Panel12)
		Me.GroupBox2.Controls.Add(Me.Panel13)
		Me.GroupBox2.Controls.Add(Me.btnLimparFiltro)
		Me.GroupBox2.Controls.Add(Me.mcCalendar)
		Me.GroupBox2.Controls.Add(Me.Panel11)
		Me.GroupBox2.Controls.Add(Me.Panel10)
		Me.GroupBox2.Controls.Add(Me.Panel7)
		Me.GroupBox2.Controls.Add(Me.Panel9)
		Me.GroupBox2.Location = New System.Drawing.Point(10, 94)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(978, 182)
		Me.GroupBox2.TabIndex = 123
		Me.GroupBox2.TabStop = False
		'
		'btnExpDockTop
		'
		Me.btnExpDockTop.BackColor = System.Drawing.Color.Transparent
		Me.btnExpDockTop.BackgroundImage = Global.ControleOS.My.Resources.Resources.settings_1
		Me.btnExpDockTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnExpDockTop.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnExpDockTop.FlatAppearance.BorderSize = 0
		Me.btnExpDockTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExpDockTop.Location = New System.Drawing.Point(595, 32)
		Me.btnExpDockTop.Name = "btnExpDockTop"
		Me.btnExpDockTop.Size = New System.Drawing.Size(25, 27)
		Me.btnExpDockTop.TabIndex = 121
		Me.btnExpDockTop.UseVisualStyleBackColor = False
		'
		'tmDockMin
		'
		Me.tmDockMin.Interval = 3000
		'
		'lblNPago
		'
		Me.lblNPago.AutoSize = True
		Me.lblNPago.BackColor = System.Drawing.Color.Transparent
		Me.lblNPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNPago.ForeColor = System.Drawing.Color.White
		Me.lblNPago.Location = New System.Drawing.Point(5, 44)
		Me.lblNPago.Name = "lblNPago"
		Me.lblNPago.Size = New System.Drawing.Size(109, 16)
		Me.lblNPago.TabIndex = 118
		Me.lblNPago.Text = "Soma Não Pago"
		'
		'lblSomaPago
		'
		Me.lblSomaPago.AutoSize = True
		Me.lblSomaPago.BackColor = System.Drawing.Color.Transparent
		Me.lblSomaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSomaPago.ForeColor = System.Drawing.Color.White
		Me.lblSomaPago.Location = New System.Drawing.Point(5, 27)
		Me.lblSomaPago.Name = "lblSomaPago"
		Me.lblSomaPago.Size = New System.Drawing.Size(80, 16)
		Me.lblSomaPago.TabIndex = 116
		Me.lblSomaPago.Text = "Soma Pago"
		'
		'chkMovPoup
		'
		Me.chkMovPoup.AutoSize = True
		Me.chkMovPoup.ForeColor = System.Drawing.Color.White
		Me.chkMovPoup.Location = New System.Drawing.Point(6, 12)
		Me.chkMovPoup.Name = "chkMovPoup"
		Me.chkMovPoup.Size = New System.Drawing.Size(56, 17)
		Me.chkMovPoup.TabIndex = 122
		Me.chkMovPoup.Text = "Mover"
		Me.chkMovPoup.UseVisualStyleBackColor = True
		'
		'grpSoma
		'
		Me.grpSoma.Controls.Add(Me.chkMovPoup)
		Me.grpSoma.Controls.Add(Me.lblSomaPago)
		Me.grpSoma.Controls.Add(Me.lblNPago)
		Me.grpSoma.Cursor = System.Windows.Forms.Cursors.Default
		Me.grpSoma.Location = New System.Drawing.Point(135, 87)
		Me.grpSoma.Name = "grpSoma"
		Me.grpSoma.Size = New System.Drawing.Size(117, 65)
		Me.grpSoma.TabIndex = 121
		Me.grpSoma.TabStop = False
		'
		'FrmNovoLancamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScrollMargin = New System.Drawing.Size(0, 150)
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(963, 444)
		Me.ControlBox = False
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.btnExpDockTop)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.PnDockTop)
		Me.Controls.Add(Me.pnDockLeft)
		Me.Controls.Add(Me.dgvFinanceiro)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmNovoLancamento"
		Me.Text = " "
		CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel13.ResumeLayout(False)
		Me.Panel13.PerformLayout()
		Me.Panel12.ResumeLayout(False)
		Me.Panel12.PerformLayout()
		Me.Panel11.ResumeLayout(False)
		Me.Panel11.PerformLayout()
		Me.Panel10.ResumeLayout(False)
		Me.Panel10.PerformLayout()
		Me.Panel9.ResumeLayout(False)
		Me.Panel9.PerformLayout()
		Me.Panel8.ResumeLayout(False)
		Me.Panel8.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.pnDockLeft.ResumeLayout(False)
		Me.PnDockTop.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.grpSoma.ResumeLayout(False)
		Me.grpSoma.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents IdentificaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents JurosAntecipaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
	Friend WithEvents dgvFinanceiro As DataGridView
	Friend WithEvents btnAplicarFiltro As Button
	Friend WithEvents txtFiltroIdentificacao As TextBox
	Friend WithEvents mcCalendar As MonthCalendar
	Friend WithEvents cboSituacaoPag As ComboBox
	Friend WithEvents cboPlanoContas As ComboBox
	Friend WithEvents cboTipoLancamento As ComboBox
	Friend WithEvents cboFormaPagamento As ComboBox
	Friend WithEvents Cliente As DataGridViewTextBoxColumn
	Friend WithEvents NumeroDocumento As DataGridViewTextBoxColumn
        Friend WithEvents Tipo As DataGridViewTextBoxColumn
        Friend WithEvents Situacao As DataGridViewTextBoxColumn
        Friend WithEvents Vencimento As DataGridViewTextBoxColumn
        Friend WithEvents Valor As DataGridViewTextBoxColumn
        Friend WithEvents PlanoContas As DataGridViewTextBoxColumn
        Friend WithEvents DataLancamento As DataGridViewTextBoxColumn
        Friend WithEvents txtCliente As TextBox
        Friend WithEvents btnLimparFiltro As Button
        Friend WithEvents btnAddLancamento As Button
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents Label11 As Label
        Friend WithEvents lblPagamentosAtraso As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label12 As Label
        Friend WithEvents txtIdentificacao As Label
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents Label13 As Label
        Friend WithEvents lblRecebimentoAtraso As Label
        Friend WithEvents btnFechar As Button
        Friend WithEvents cboData As ComboBox
        Friend WithEvents txtDataInicial As TextBox
        Friend WithEvents txtDataFinal As TextBox
        Friend WithEvents cboPeriodo As ComboBox
        Friend WithEvents ComboBox1 As ComboBox
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents ComboBox2 As ComboBox
        Friend WithEvents btnGerarRelatorio As Button
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Panel10 As Panel
        Friend WithEvents Panel9 As Panel
        Friend WithEvents Panel8 As Panel
        Friend WithEvents Panel11 As Panel
        Friend WithEvents Panel12 As Panel
        Friend WithEvents Panel13 As Panel
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents GerarRelatorioToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents Label1 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents pnDockLeft As Panel
        Friend WithEvents PnDockTop As Panel
        Friend WithEvents btnExpDockTop As Button
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents tmDockMin As Timer
        Friend WithEvents lblNPago As Label
        Friend WithEvents lblSomaPago As Label
        Friend WithEvents chkMovPoup As CheckBox
        Friend WithEvents grpSoma As GroupBox
End Class
