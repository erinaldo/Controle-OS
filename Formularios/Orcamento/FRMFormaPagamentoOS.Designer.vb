<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMFormaPagamentoOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMFormaPagamentoOS))
        Me.lblData = New System.Windows.Forms.Label()
        Me.mcVencimento = New System.Windows.Forms.MonthCalendar()
        Me.ofdAnexo = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtaReceber = New System.Windows.Forms.TextBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNumeroOS = New System.Windows.Forms.Label()
        Me.txtDescricaoAnexo = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TbFinanceiroTableAdapter = New ControleOS.DataPdvTableAdapters.tbFinanceiroTableAdapter()
        Me.DataPdv = New ControleOS.DataPdv()
        Me.grpDinheiro = New System.Windows.Forms.GroupBox()
        Me.gpDesconto = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDesMaxPermitido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRealizarDesc = New System.Windows.Forms.Button()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
        Me.TbPlanoContaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
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
        Me.TbFinanceiroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
        Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPlanoDespesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpcoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbrirAnexo = New System.Windows.Forms.Button()
        Me.btnAddAnexo = New System.Windows.Forms.Button()
        Me.btnCartao = New System.Windows.Forms.Button()
        Me.btnDinheiro = New System.Windows.Forms.Button()
        Me.btnBoleto = New System.Windows.Forms.Button()
        Me.OpcoesTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.OpcoesTableAdapter()
        Me.OpcoesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPlanoDespesasTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbPlanoDespesasTableAdapter()
        Me.TbPlanoContaTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbPlanoContaTableAdapter()
        Me.TbFinanceiroTableAdapter1 = New ControleOS.DataSetXTableAdapters.tbFinanceiroTableAdapter()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDinheiro.SuspendLayout()
        Me.gpDesconto.SuspendLayout()
        CType(Me.TbPlanoContaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPlanoDespesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpcoesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'mcVencimento
        '
        Me.mcVencimento.Location = New System.Drawing.Point(603, 159)
        Me.mcVencimento.Name = "mcVencimento"
        Me.mcVencimento.TabIndex = 46
        Me.mcVencimento.Visible = False
        '
        'ofdAnexo
        '
        Me.ofdAnexo.FileName = "OpenFileDialog1"
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
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(976, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 25)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "RESTANTE"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(976, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 25)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "PAGO"
        '
        'txtaReceber
        '
        Me.txtaReceber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaReceber.ForeColor = System.Drawing.Color.Red
        Me.txtaReceber.Location = New System.Drawing.Point(979, 255)
        Me.txtaReceber.Name = "txtaReceber"
        Me.txtaReceber.Size = New System.Drawing.Size(197, 31)
        Me.txtaReceber.TabIndex = 52
        Me.txtaReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPago.ForeColor = System.Drawing.Color.Green
        Me.txtTotalPago.Location = New System.Drawing.Point(979, 196)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.Size = New System.Drawing.Size(197, 31)
        Me.txtTotalPago.TabIndex = 51
        Me.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(1075, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Descrição do Anexo"
        Me.Label12.Visible = False
        '
        'lblNumeroOS
        '
        Me.lblNumeroOS.AutoSize = True
        Me.lblNumeroOS.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroOS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroOS.Location = New System.Drawing.Point(12, 25)
        Me.lblNumeroOS.Name = "lblNumeroOS"
        Me.lblNumeroOS.Size = New System.Drawing.Size(103, 19)
        Me.lblNumeroOS.TabIndex = 47
        Me.lblNumeroOS.Text = "Numero da OS"
        '
        'txtDescricaoAnexo
        '
        Me.txtDescricaoAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoAnexo.Location = New System.Drawing.Point(1082, 67)
        Me.txtDescricaoAnexo.Name = "txtDescricaoAnexo"
        Me.txtDescricaoAnexo.Size = New System.Drawing.Size(96, 20)
        Me.txtDescricaoAnexo.TabIndex = 48
        Me.txtDescricaoAnexo.Visible = False
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.BackColor = System.Drawing.Color.Transparent
        Me.lblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(12, 120)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(31, 16)
        Me.lblCPF.TabIndex = 40
        Me.lblCPF.Text = "N/A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "CPF"
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.AutoSize = True
        Me.lblNomeCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeCliente.Location = New System.Drawing.Point(12, 78)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(108, 16)
        Me.lblNomeCliente.TabIndex = 38
        Me.lblNomeCliente.Text = "Nome do Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cliente"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblTotal.Location = New System.Drawing.Point(11, 320)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(180, 27)
        Me.lblTotal.TabIndex = 33
        Me.lblTotal.Text = "Valor Total da OS"
        '
        'TbFinanceiroTableAdapter
        '
        Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.grpDinheiro.Location = New System.Drawing.Point(14, 350)
        Me.grpDinheiro.Name = "grpDinheiro"
        Me.grpDinheiro.Size = New System.Drawing.Size(1175, 359)
        Me.grpDinheiro.TabIndex = 36
        Me.grpDinheiro.TabStop = False
        '
        'gpDesconto
        '
        Me.gpDesconto.Controls.Add(Me.Label16)
        Me.gpDesconto.Controls.Add(Me.txtDesMaxPermitido)
        Me.gpDesconto.Controls.Add(Me.Label15)
        Me.gpDesconto.Controls.Add(Me.btnRealizarDesc)
        Me.gpDesconto.Controls.Add(Me.txtDesconto)
        Me.gpDesconto.Location = New System.Drawing.Point(819, 19)
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
        Me.txtDesMaxPermitido.Text = "Em Implementação"
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
        Me.txtDesconto.Text = "Em Implementação"
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
        Me.cboPlanoContas.DataSource = Me.TbPlanoContaBindingSource
        Me.cboPlanoContas.DisplayMember = "Nome"
        Me.cboPlanoContas.FormattingEnabled = True
        Me.cboPlanoContas.Location = New System.Drawing.Point(555, 51)
        Me.cboPlanoContas.Name = "cboPlanoContas"
        Me.cboPlanoContas.Size = New System.Drawing.Size(121, 21)
        Me.cboPlanoContas.TabIndex = 22
        '
        'TbPlanoContaBindingSource
        '
        Me.TbPlanoContaBindingSource.DataMember = "tbPlanoConta"
        Me.TbPlanoContaBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnAddLancamento.FlatAppearance.BorderSize = 0
        Me.btnAddLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLancamento.Image = Global.ControleOS.My.Resources.Resources.Adicionar1
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
        Me.dgvPagamento.DataSource = Me.TbFinanceiroBindingSource1
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
        Me.dgvPagamento.Size = New System.Drawing.Size(1163, 236)
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
        'TbFinanceiroBindingSource1
        '
        Me.TbFinanceiroBindingSource1.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource1.DataSource = Me.DataSetX
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbFinanceiroBindingSource
        '
        Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource.DataSource = Me.DataPdv
        '
        'TbPlanoDespesasBindingSource
        '
        Me.TbPlanoDespesasBindingSource.DataMember = "tbPlanoDespesas"
        Me.TbPlanoDespesasBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'OpcoesBindingSource
        '
        Me.OpcoesBindingSource.DataMember = "Opcoes"
        Me.OpcoesBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Forma de Pagamento"
        '
        'btnAbrirAnexo
        '
        Me.btnAbrirAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirAnexo.BackColor = System.Drawing.Color.Transparent
        Me.btnAbrirAnexo.FlatAppearance.BorderSize = 0
        Me.btnAbrirAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirAnexo.Image = Global.ControleOS.My.Resources.Resources.Carregar
        Me.btnAbrirAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirAnexo.Location = New System.Drawing.Point(998, 3)
        Me.btnAbrirAnexo.Name = "btnAbrirAnexo"
        Me.btnAbrirAnexo.Size = New System.Drawing.Size(96, 41)
        Me.btnAbrirAnexo.TabIndex = 50
        Me.btnAbrirAnexo.Text = "Abrir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anexo"
        Me.btnAbrirAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrirAnexo.UseVisualStyleBackColor = False
        Me.btnAbrirAnexo.Visible = False
        '
        'btnAddAnexo
        '
        Me.btnAddAnexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAnexo.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAnexo.FlatAppearance.BorderSize = 0
        Me.btnAddAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAnexo.Image = Global.ControleOS.My.Resources.Resources.Vinculo2
        Me.btnAddAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAnexo.Location = New System.Drawing.Point(1100, -3)
        Me.btnAddAnexo.Name = "btnAddAnexo"
        Me.btnAddAnexo.Size = New System.Drawing.Size(76, 47)
        Me.btnAddAnexo.TabIndex = 45
        Me.btnAddAnexo.Text = "Anexo"
        Me.btnAddAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAnexo.UseVisualStyleBackColor = False
        Me.btnAddAnexo.Visible = False
        '
        'btnCartao
        '
        Me.btnCartao.BackColor = System.Drawing.Color.Transparent
        Me.btnCartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCartao.FlatAppearance.BorderSize = 0
        Me.btnCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartao.Image = Global.ControleOS.My.Resources.Resources.Cartao1
        Me.btnCartao.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCartao.Location = New System.Drawing.Point(178, 201)
        Me.btnCartao.Name = "btnCartao"
        Me.btnCartao.Size = New System.Drawing.Size(75, 85)
        Me.btnCartao.TabIndex = 35
        Me.btnCartao.TabStop = False
        Me.btnCartao.Text = "Cartão"
        Me.btnCartao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCartao.UseVisualStyleBackColor = False
        '
        'btnDinheiro
        '
        Me.btnDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.btnDinheiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDinheiro.FlatAppearance.BorderSize = 0
        Me.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinheiro.Image = Global.ControleOS.My.Resources.Resources.Faturar
        Me.btnDinheiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDinheiro.Location = New System.Drawing.Point(16, 201)
        Me.btnDinheiro.Name = "btnDinheiro"
        Me.btnDinheiro.Size = New System.Drawing.Size(75, 85)
        Me.btnDinheiro.TabIndex = 32
        Me.btnDinheiro.TabStop = False
        Me.btnDinheiro.Text = "Dinheiro"
        Me.btnDinheiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDinheiro.UseVisualStyleBackColor = False
        '
        'btnBoleto
        '
        Me.btnBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnBoleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBoleto.FlatAppearance.BorderSize = 0
        Me.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoleto.Image = Global.ControleOS.My.Resources.Resources.Barras
        Me.btnBoleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBoleto.Location = New System.Drawing.Point(97, 199)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(75, 87)
        Me.btnBoleto.TabIndex = 34
        Me.btnBoleto.TabStop = False
        Me.btnBoleto.Text = "Boleto"
        Me.btnBoleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBoleto.UseVisualStyleBackColor = False
        '
        'OpcoesTableAdapter
        '
        Me.OpcoesTableAdapter.ClearBeforeFill = True
        '
        'OpcoesBindingSource1
        '
        Me.OpcoesBindingSource1.DataMember = "Opcoes"
        Me.OpcoesBindingSource1.DataSource = Me.SistemaGEDataSet
        '
        'TbPlanoDespesasTableAdapter
        '
        Me.TbPlanoDespesasTableAdapter.ClearBeforeFill = True
        '
        'TbPlanoContaTableAdapter
        '
        Me.TbPlanoContaTableAdapter.ClearBeforeFill = True
        '
        'TbFinanceiroTableAdapter1
        '
        Me.TbFinanceiroTableAdapter1.ClearBeforeFill = True
        '
        'FRMFormaPagamentoOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1198, 749)
        Me.Controls.Add(Me.mcVencimento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtaReceber)
        Me.Controls.Add(Me.txtTotalPago)
        Me.Controls.Add(Me.btnAbrirAnexo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblNumeroOS)
        Me.Controls.Add(Me.txtDescricaoAnexo)
        Me.Controls.Add(Me.btnAddAnexo)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNomeCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCartao)
        Me.Controls.Add(Me.btnDinheiro)
        Me.Controls.Add(Me.grpDinheiro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBoleto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMFormaPagamentoOS"
        Me.Text = "FRMFormaPagamentoOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDinheiro.ResumeLayout(False)
        Me.grpDinheiro.PerformLayout()
        Me.gpDesconto.ResumeLayout(False)
        Me.gpDesconto.PerformLayout()
        CType(Me.TbPlanoContaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPlanoDespesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpcoesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblData As Label
    Friend WithEvents mcVencimento As MonthCalendar
    Friend WithEvents ofdAnexo As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtaReceber As TextBox
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents btnAbrirAnexo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNumeroOS As Label
    Friend WithEvents txtDescricaoAnexo As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAddAnexo As Button
    Friend WithEvents btnAddLancamento As Button
    Friend WithEvents lblCPF As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCartao As Button
    Friend WithEvents TbFinanceiroTableAdapter As DataPdvTableAdapters.tbFinanceiroTableAdapter
    Friend WithEvents btnDinheiro As Button
    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents grpDinheiro As GroupBox
    Friend WithEvents gpDesconto As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDesMaxPermitido As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnRealizarDesc As Button
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPlanoContas As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVencimento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSituacao As ComboBox
    Friend WithEvents lblFormaSelecionada As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorReceber As TextBox
    Friend WithEvents dgvPagamento As DataGridView
    Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataLancamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagamento As DataGridViewTextBoxColumn
    Friend WithEvents Identificacao As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents TbFinanceiroBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBoleto As Button
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents OpcoesBindingSource As BindingSource
    Friend WithEvents OpcoesTableAdapter As SistemaGEDataSetTableAdapters.OpcoesTableAdapter
    Friend WithEvents OpcoesBindingSource1 As BindingSource
    Friend WithEvents TbPlanoDespesasBindingSource As BindingSource
    Friend WithEvents TbPlanoDespesasTableAdapter As SistemaGEDataSetTableAdapters.tbPlanoDespesasTableAdapter
    Friend WithEvents TbPlanoContaBindingSource As BindingSource
    Friend WithEvents TbPlanoContaTableAdapter As SistemaGEDataSetTableAdapters.tbPlanoContaTableAdapter
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbFinanceiroBindingSource1 As BindingSource
    Friend WithEvents TbFinanceiroTableAdapter1 As DataSetXTableAdapters.tbFinanceiroTableAdapter
End Class
