<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMFormaPagamentoPDV
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMFormaPagamentoPDV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDinheiro = New System.Windows.Forms.GroupBox()
        Me.gpDesconto = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDesMaxPermitido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRealizarDesc = New System.Windows.Forms.Button()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.lblFormaSelecionada = New System.Windows.Forms.Label()
        Me.btnAddLancamento = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValorReceber = New System.Windows.Forms.TextBox()
        Me.dgvPagamento = New System.Windows.Forms.DataGridView()
        Me.SituacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataLancamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataPdv = New ControleOS.DataPdv()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mcVencimento = New System.Windows.Forms.MonthCalendar()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCartao = New System.Windows.Forms.Button()
        Me.btnBoleto = New System.Windows.Forms.Button()
        Me.btnDinheiro = New System.Windows.Forms.Button()
        Me.btnAddAnexo = New System.Windows.Forms.Button()
        Me.ofdAnexo = New System.Windows.Forms.OpenFileDialog()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescricaoAnexo = New System.Windows.Forms.TextBox()
        Me.btnAbrirAnexo = New System.Windows.Forms.Button()
        Me.TbFinanceiroTableAdapter = New ControleOS.DataPdvTableAdapters.tbFinanceiroTableAdapter()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.txtaReceber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCartaoDebito = New System.Windows.Forms.Button()
        Me.grpDinheiro.SuspendLayout()
        Me.gpDesconto.SuspendLayout()
        CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formas de Pagamento"
        '
        'grpDinheiro
        '
        Me.grpDinheiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.grpDinheiro.Controls.Add(Me.gpDesconto)
        Me.grpDinheiro.Controls.Add(Me.Label11)
        Me.grpDinheiro.Controls.Add(Me.cboPlanoContas)
        Me.grpDinheiro.Controls.Add(Me.Label10)
        Me.grpDinheiro.Controls.Add(Me.txtVencimento)
        Me.grpDinheiro.Controls.Add(Me.Label4)
        Me.grpDinheiro.Controls.Add(Me.cboSituacao)
        Me.grpDinheiro.Controls.Add(Me.lblFormaSelecionada)
        Me.grpDinheiro.Controls.Add(Me.btnAddLancamento)
        Me.grpDinheiro.Controls.Add(Me.Label2)
        Me.grpDinheiro.Controls.Add(Me.Label5)
        Me.grpDinheiro.Controls.Add(Me.txtValorReceber)
        Me.grpDinheiro.Controls.Add(Me.dgvPagamento)
        Me.grpDinheiro.Controls.Add(Me.lblData)
        Me.grpDinheiro.Controls.Add(Me.Label3)
        Me.grpDinheiro.Location = New System.Drawing.Point(14, 365)
        Me.grpDinheiro.Name = "grpDinheiro"
        Me.grpDinheiro.Size = New System.Drawing.Size(1165, 242)
        Me.grpDinheiro.TabIndex = 5
        Me.grpDinheiro.TabStop = False
        '
        'gpDesconto
        '
        Me.gpDesconto.Controls.Add(Me.Label16)
        Me.gpDesconto.Controls.Add(Me.txtDesMaxPermitido)
        Me.gpDesconto.Controls.Add(Me.Label15)
        Me.gpDesconto.Controls.Add(Me.btnRealizarDesc)
        Me.gpDesconto.Controls.Add(Me.txtDesconto)
        Me.gpDesconto.Location = New System.Drawing.Point(822, 19)
        Me.gpDesconto.Name = "gpDesconto"
        Me.gpDesconto.Size = New System.Drawing.Size(337, 68)
        Me.gpDesconto.TabIndex = 24
        Me.gpDesconto.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(202, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Max Pemitido"
        '
        'txtDesMaxPermitido
        '
        Me.txtDesMaxPermitido.ForeColor = System.Drawing.Color.Green
        Me.txtDesMaxPermitido.Location = New System.Drawing.Point(202, 35)
        Me.txtDesMaxPermitido.Name = "txtDesMaxPermitido"
        Me.txtDesMaxPermitido.ReadOnly = True
        Me.txtDesMaxPermitido.Size = New System.Drawing.Size(100, 20)
        Me.txtDesMaxPermitido.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(85, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Desconto (R$)"
        '
        'btnRealizarDesc
        '
        Me.btnRealizarDesc.Location = New System.Drawing.Point(6, 17)
        Me.btnRealizarDesc.Name = "btnRealizarDesc"
        Me.btnRealizarDesc.Size = New System.Drawing.Size(75, 41)
        Me.btnRealizarDesc.TabIndex = 31
        Me.btnRealizarDesc.Text = "Realizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desconto"
        Me.btnRealizarDesc.UseVisualStyleBackColor = True
        '
        'txtDesconto
        '
        Me.txtDesconto.ForeColor = System.Drawing.Color.Green
        Me.txtDesconto.Location = New System.Drawing.Point(87, 35)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtDesconto.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(555, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Plano de Contas"
        '
        'cboPlanoContas
        '
        Me.cboPlanoContas.FormattingEnabled = True
        Me.cboPlanoContas.Location = New System.Drawing.Point(555, 51)
        Me.cboPlanoContas.Name = "cboPlanoContas"
        Me.cboPlanoContas.Size = New System.Drawing.Size(121, 21)
        Me.cboPlanoContas.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(679, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Vencimento:"
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(682, 51)
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.ReadOnly = True
        Me.txtVencimento.Size = New System.Drawing.Size(101, 20)
        Me.txtVencimento.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(428, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Situação:"
        '
        'cboSituacao
        '
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Location = New System.Drawing.Point(428, 51)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(121, 21)
        Me.cboSituacao.TabIndex = 18
        '
        'lblFormaSelecionada
        '
        Me.lblFormaSelecionada.AutoSize = True
        Me.lblFormaSelecionada.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaSelecionada.ForeColor = System.Drawing.Color.White
        Me.lblFormaSelecionada.Location = New System.Drawing.Point(57, 53)
        Me.lblFormaSelecionada.Name = "lblFormaSelecionada"
        Me.lblFormaSelecionada.Size = New System.Drawing.Size(140, 19)
        Me.lblFormaSelecionada.TabIndex = 9
        Me.lblFormaSelecionada.Text = "Selecione uma Forma"
        '
        'btnAddLancamento
        '
        Me.btnAddLancamento.BackgroundImage = Global.ControleOS.My.Resources.Resources.Adicionar1
        Me.btnAddLancamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddLancamento.FlatAppearance.BorderSize = 0
        Me.btnAddLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLancamento.Location = New System.Drawing.Point(8, 39)
        Me.btnAddLancamento.Name = "btnAddLancamento"
        Me.btnAddLancamento.Size = New System.Drawing.Size(44, 36)
        Me.btnAddLancamento.TabIndex = 7
        Me.btnAddLancamento.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Forma Selecionada"
        '
        'txtValorReceber
        '
        Me.txtValorReceber.Location = New System.Drawing.Point(295, 52)
        Me.txtValorReceber.Name = "txtValorReceber"
        Me.txtValorReceber.Size = New System.Drawing.Size(127, 20)
        Me.txtValorReceber.TabIndex = 2
        '
        'dgvPagamento
        '
        Me.dgvPagamento.AllowUserToAddRows = False
        Me.dgvPagamento.AllowUserToDeleteRows = False
        Me.dgvPagamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagamento.AutoGenerateColumns = False
        Me.dgvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagamento.BackgroundColor = System.Drawing.Color.White
        Me.dgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagamento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SituacaoDataGridViewTextBoxColumn, Me.DataLancamentoDataGridViewTextBoxColumn, Me.VencimentoDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn, Me.FormaPagamento, Me.Identificacao, Me.Column1})
        Me.dgvPagamento.DataSource = Me.TbFinanceiroBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPagamento.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPagamento.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPagamento.Location = New System.Drawing.Point(6, 93)
        Me.dgvPagamento.MultiSelect = False
        Me.dgvPagamento.Name = "dgvPagamento"
        Me.dgvPagamento.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagamento.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPagamento.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPagamento.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagamento.Size = New System.Drawing.Size(1153, 143)
        Me.dgvPagamento.TabIndex = 1
        '
        'SituacaoDataGridViewTextBoxColumn
        '
        Me.SituacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao"
        Me.SituacaoDataGridViewTextBoxColumn.FillWeight = 104.8223!
        Me.SituacaoDataGridViewTextBoxColumn.HeaderText = "Situação"
        Me.SituacaoDataGridViewTextBoxColumn.Name = "SituacaoDataGridViewTextBoxColumn"
        Me.SituacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataLancamentoDataGridViewTextBoxColumn
        '
        Me.DataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento"
        Me.DataLancamentoDataGridViewTextBoxColumn.FillWeight = 104.8223!
        Me.DataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data de Lançamento"
        Me.DataLancamentoDataGridViewTextBoxColumn.Name = "DataLancamentoDataGridViewTextBoxColumn"
        Me.DataLancamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VencimentoDataGridViewTextBoxColumn
        '
        Me.VencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.FillWeight = 104.8223!
        Me.VencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.Name = "VencimentoDataGridViewTextBoxColumn"
        Me.VencimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.FillWeight = 104.8223!
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaPagamento
        '
        Me.FormaPagamento.DataPropertyName = "FormaPagamento"
        Me.FormaPagamento.FillWeight = 104.8223!
        Me.FormaPagamento.HeaderText = "Forma de Pagamento"
        Me.FormaPagamento.Name = "FormaPagamento"
        Me.FormaPagamento.ReadOnly = True
        '
        'Identificacao
        '
        Me.Identificacao.DataPropertyName = "Identificacao"
        Me.Identificacao.FillWeight = 104.8223!
        Me.Identificacao.HeaderText = "Identificação"
        Me.Identificacao.Name = "Identificacao"
        Me.Identificacao.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 71.06599!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Text = "Anexar Doc."
        '
        'TbFinanceiroBindingSource
        '
        Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource.DataSource = Me.DataPdv
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.White
        Me.lblData.Location = New System.Drawing.Point(203, 53)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(73, 19)
        Me.lblData.TabIndex = 6
        Me.lblData.Text = "Data Atual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(204, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data:"
        '
        'mcVencimento
        '
        Me.mcVencimento.Location = New System.Drawing.Point(626, 237)
        Me.mcVencimento.Name = "mcVencimento"
        Me.mcVencimento.TabIndex = 18
        Me.mcVencimento.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTotal.Location = New System.Drawing.Point(11, 335)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(219, 27)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Valor Total do Pedido"
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.AutoSize = True
        Me.lblNomeCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeCliente.Location = New System.Drawing.Point(26, 66)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(126, 20)
        Me.lblNomeCliente.TabIndex = 11
        Me.lblNomeCliente.Text = "Nome do Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cliente"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.BackColor = System.Drawing.Color.Transparent
        Me.lblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(26, 109)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(35, 20)
        Me.lblCPF.TabIndex = 13
        Me.lblCPF.Text = "N/A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CPF"
        '
        'lblInscricaoEstadual
        '
        Me.lblInscricaoEstadual.AutoSize = True
        Me.lblInscricaoEstadual.BackColor = System.Drawing.Color.Transparent
        Me.lblInscricaoEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscricaoEstadual.Location = New System.Drawing.Point(26, 195)
        Me.lblInscricaoEstadual.Name = "lblInscricaoEstadual"
        Me.lblInscricaoEstadual.Size = New System.Drawing.Size(35, 20)
        Me.lblInscricaoEstadual.TabIndex = 15
        Me.lblInscricaoEstadual.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Inscrição Estadual"
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent
        Me.lblRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoSocial.Location = New System.Drawing.Point(26, 150)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(35, 20)
        Me.lblRazaoSocial.TabIndex = 17
        Me.lblRazaoSocial.Text = "N/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Razão Social"
        '
        'btnCartao
        '
        Me.btnCartao.BackColor = System.Drawing.Color.Transparent
        Me.btnCartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCartao.FlatAppearance.BorderSize = 0
        Me.btnCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartao.Image = Global.ControleOS.My.Resources.Resources.Cartao5
        Me.btnCartao.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCartao.Location = New System.Drawing.Point(178, 247)
        Me.btnCartao.Name = "btnCartao"
        Me.btnCartao.Size = New System.Drawing.Size(75, 77)
        Me.btnCartao.TabIndex = 4
        Me.btnCartao.TabStop = False
        Me.btnCartao.Text = "Crédito"
        Me.btnCartao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCartao.UseVisualStyleBackColor = False
        '
        'btnBoleto
        '
        Me.btnBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnBoleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBoleto.FlatAppearance.BorderSize = 0
        Me.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoleto.Image = Global.ControleOS.My.Resources.Resources.Barras2
        Me.btnBoleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBoleto.Location = New System.Drawing.Point(97, 247)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(75, 77)
        Me.btnBoleto.TabIndex = 3
        Me.btnBoleto.TabStop = False
        Me.btnBoleto.Text = "Boleto"
        Me.btnBoleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBoleto.UseVisualStyleBackColor = False
        '
        'btnDinheiro
        '
        Me.btnDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.btnDinheiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDinheiro.FlatAppearance.BorderSize = 0
        Me.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinheiro.Image = Global.ControleOS.My.Resources.Resources.Faturar2
        Me.btnDinheiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDinheiro.Location = New System.Drawing.Point(16, 247)
        Me.btnDinheiro.Name = "btnDinheiro"
        Me.btnDinheiro.Size = New System.Drawing.Size(75, 77)
        Me.btnDinheiro.TabIndex = 2
        Me.btnDinheiro.TabStop = False
        Me.btnDinheiro.Text = "Dinheiro"
        Me.btnDinheiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDinheiro.UseVisualStyleBackColor = False
        '
        'btnAddAnexo
        '
        Me.btnAddAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAnexo.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAnexo.FlatAppearance.BorderSize = 0
        Me.btnAddAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAnexo.Location = New System.Drawing.Point(984, 12)
        Me.btnAddAnexo.Name = "btnAddAnexo"
        Me.btnAddAnexo.Size = New System.Drawing.Size(82, 47)
        Me.btnAddAnexo.TabIndex = 18
        Me.btnAddAnexo.Text = "Anexo"
        Me.btnAddAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAnexo.UseVisualStyleBackColor = False
        Me.btnAddAnexo.Visible = False
        '
        'ofdAnexo
        '
        Me.ofdAnexo.FileName = "OpenFileDialog1"
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(12, 9)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(193, 27)
        Me.lblNumeroPedido.TabIndex = 19
        Me.lblNumeroPedido.Text = "Numero do Pedido"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(1082, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Descrição do Anexo"
        Me.Label12.Visible = False
        '
        'txtDescricaoAnexo
        '
        Me.txtDescricaoAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoAnexo.Location = New System.Drawing.Point(1085, 89)
        Me.txtDescricaoAnexo.Name = "txtDescricaoAnexo"
        Me.txtDescricaoAnexo.Size = New System.Drawing.Size(96, 20)
        Me.txtDescricaoAnexo.TabIndex = 24
        Me.txtDescricaoAnexo.Visible = False
        '
        'btnAbrirAnexo
        '
        Me.btnAbrirAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirAnexo.BackColor = System.Drawing.Color.Transparent
        Me.btnAbrirAnexo.FlatAppearance.BorderSize = 0
        Me.btnAbrirAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirAnexo.Location = New System.Drawing.Point(1075, 12)
        Me.btnAbrirAnexo.Name = "btnAbrirAnexo"
        Me.btnAbrirAnexo.Size = New System.Drawing.Size(104, 47)
        Me.btnAbrirAnexo.TabIndex = 26
        Me.btnAbrirAnexo.Text = "Abrir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anexo"
        Me.btnAbrirAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrirAnexo.UseVisualStyleBackColor = False
        Me.btnAbrirAnexo.Visible = False
        '
        'TbFinanceiroTableAdapter
        '
        Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPago.ForeColor = System.Drawing.Color.Green
        Me.txtTotalPago.Location = New System.Drawing.Point(1010, 265)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.Size = New System.Drawing.Size(171, 31)
        Me.txtTotalPago.TabIndex = 27
        '
        'txtaReceber
        '
        Me.txtaReceber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaReceber.ForeColor = System.Drawing.Color.Red
        Me.txtaReceber.Location = New System.Drawing.Point(1010, 327)
        Me.txtaReceber.Name = "txtaReceber"
        Me.txtaReceber.Size = New System.Drawing.Size(171, 31)
        Me.txtaReceber.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1015, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Pago"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1015, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 25)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Restante"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1005, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 25)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(1010, 203)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(171, 31)
        Me.txtTotal.TabIndex = 31
        '
        'btnCartaoDebito
        '
        Me.btnCartaoDebito.BackColor = System.Drawing.Color.Transparent
        Me.btnCartaoDebito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCartaoDebito.FlatAppearance.BorderSize = 0
        Me.btnCartaoDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartaoDebito.Image = Global.ControleOS.My.Resources.Resources.Cartao3
        Me.btnCartaoDebito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCartaoDebito.Location = New System.Drawing.Point(259, 247)
        Me.btnCartaoDebito.Name = "btnCartaoDebito"
        Me.btnCartaoDebito.Size = New System.Drawing.Size(75, 77)
        Me.btnCartaoDebito.TabIndex = 33
        Me.btnCartaoDebito.TabStop = False
        Me.btnCartaoDebito.Text = "Débito"
        Me.btnCartaoDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCartaoDebito.UseVisualStyleBackColor = False
        '
        'FRMFormaPagamentoPDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1197, 619)
        Me.Controls.Add(Me.btnCartaoDebito)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtaReceber)
        Me.Controls.Add(Me.txtTotalPago)
        Me.Controls.Add(Me.btnAbrirAnexo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mcVencimento)
        Me.Controls.Add(Me.lblNumeroPedido)
        Me.Controls.Add(Me.txtDescricaoAnexo)
        Me.Controls.Add(Me.btnAddAnexo)
        Me.Controls.Add(Me.lblRazaoSocial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblInscricaoEstadual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNomeCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpDinheiro)
        Me.Controls.Add(Me.btnCartao)
        Me.Controls.Add(Me.btnBoleto)
        Me.Controls.Add(Me.btnDinheiro)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMFormaPagamentoPDV"
        Me.Text = "FATURAMENTO"
        Me.grpDinheiro.ResumeLayout(False)
        Me.grpDinheiro.PerformLayout()
        Me.gpDesconto.ResumeLayout(False)
        Me.gpDesconto.PerformLayout()
        CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDinheiro As Button
    Friend WithEvents btnBoleto As Button
    Friend WithEvents btnCartao As Button
    Friend WithEvents grpDinheiro As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblData As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorReceber As TextBox
    Friend WithEvents dgvPagamento As DataGridView
    Friend WithEvents btnAddLancamento As Button
    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents TbFinanceiroBindingSource As BindingSource
    Friend WithEvents TbFinanceiroTableAdapter As DataPdvTableAdapters.tbFinanceiroTableAdapter
    Friend WithEvents lblFormaSelecionada As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblInscricaoEstadual As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRazaoSocial As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSituacao As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVencimento As TextBox
    Friend WithEvents mcVencimento As MonthCalendar
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPlanoContas As ComboBox
    Friend WithEvents btnAddAnexo As Button
    Friend WithEvents ofdAnexo As OpenFileDialog
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDescricaoAnexo As TextBox
    Friend WithEvents btnAbrirAnexo As Button
    Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataLancamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagamento As DataGridViewTextBoxColumn
    Friend WithEvents Identificacao As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents txtaReceber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gpDesconto As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnRealizarDesc As Button
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDesMaxPermitido As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCartaoDebito As Button
End Class
