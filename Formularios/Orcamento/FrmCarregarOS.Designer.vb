<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarregarOS
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
        Dim OSIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TecRespLabel As System.Windows.Forms.Label
        Dim DataAberturaLabel As System.Windows.Forms.Label
        Dim DataAprovacaoLabel As System.Windows.Forms.Label
        Dim NomeClienteLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim FormaPagamentoLabel1 As System.Windows.Forms.Label
        Dim SituacaoPagamentoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim TipoPagamentoLabel As System.Windows.Forms.Label
        Dim DescontoLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarregarOS))
        Me.btnCarregarOS = New System.Windows.Forms.Button()
        Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSIDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TecRespTextBox = New System.Windows.Forms.TextBox()
        Me.DataAberturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataAprovacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeClienteTextBox = New System.Windows.Forms.TextBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.rdPesquisaOS = New System.Windows.Forms.RadioButton()
        Me.rdPesquisaNomeCliente = New System.Windows.Forms.RadioButton()
        Me.rdDataAbertura = New System.Windows.Forms.RadioButton()
        Me.rdTecResponsavel = New System.Windows.Forms.RadioButton()
        Me.rdDataAprovacao = New System.Windows.Forms.RadioButton()
        Me.TbOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbClientesTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbClientesTableAdapter()
        Me.TbClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbLancamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbLancamentosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbLancamentosTableAdapter()
        Me.TbInicialPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbInicialPagoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbInicialPagoTableAdapter()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.FormaPagamentoTextBox1 = New System.Windows.Forms.TextBox()
        Me.SituacaoPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.DescontoTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CodClienteTextBox = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        OSIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TecRespLabel = New System.Windows.Forms.Label()
        DataAberturaLabel = New System.Windows.Forms.Label()
        DataAprovacaoLabel = New System.Windows.Forms.Label()
        NomeClienteLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        FormaPagamentoLabel1 = New System.Windows.Forms.Label()
        SituacaoPagamentoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        DataVencimentoLabel = New System.Windows.Forms.Label()
        TipoPagamentoLabel = New System.Windows.Forms.Label()
        DescontoLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbLancamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbInicialPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OSIDLabel
        '
        OSIDLabel.AutoSize = True
        OSIDLabel.Location = New System.Drawing.Point(11, 22)
        OSIDLabel.Name = "OSIDLabel"
        OSIDLabel.Size = New System.Drawing.Size(80, 13)
        OSIDLabel.TabIndex = 52
        OSIDLabel.Text = "Número da OS:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(11, 100)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 56
        StatusLabel.Text = "Status:"
        '
        'TecRespLabel
        '
        TecRespLabel.AutoSize = True
        TecRespLabel.Location = New System.Drawing.Point(12, 130)
        TecRespLabel.Name = "TecRespLabel"
        TecRespLabel.Size = New System.Drawing.Size(114, 13)
        TecRespLabel.TabIndex = 58
        TecRespLabel.Text = "Tecnico Responsável:"
        '
        'DataAberturaLabel
        '
        DataAberturaLabel.AutoSize = True
        DataAberturaLabel.Location = New System.Drawing.Point(11, 156)
        DataAberturaLabel.Name = "DataAberturaLabel"
        DataAberturaLabel.Size = New System.Drawing.Size(76, 13)
        DataAberturaLabel.TabIndex = 60
        DataAberturaLabel.Text = "Data Abertura:"
        '
        'DataAprovacaoLabel
        '
        DataAprovacaoLabel.AutoSize = True
        DataAprovacaoLabel.Location = New System.Drawing.Point(11, 181)
        DataAprovacaoLabel.Name = "DataAprovacaoLabel"
        DataAprovacaoLabel.Size = New System.Drawing.Size(88, 13)
        DataAprovacaoLabel.TabIndex = 62
        DataAprovacaoLabel.Text = "Data Aprovacao:"
        '
        'NomeClienteLabel
        '
        NomeClienteLabel.AutoSize = True
        NomeClienteLabel.Location = New System.Drawing.Point(12, 52)
        NomeClienteLabel.Name = "NomeClienteLabel"
        NomeClienteLabel.Size = New System.Drawing.Size(88, 13)
        NomeClienteLabel.TabIndex = 64
        NomeClienteLabel.Text = "Nome do Cliente:"
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.Location = New System.Drawing.Point(12, 234)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(38, 13)
        PrecoLabel.TabIndex = 81
        PrecoLabel.Text = "Preco:"
        '
        'FormaPagamentoLabel1
        '
        FormaPagamentoLabel1.AutoSize = True
        FormaPagamentoLabel1.Location = New System.Drawing.Point(12, 260)
        FormaPagamentoLabel1.Name = "FormaPagamentoLabel1"
        FormaPagamentoLabel1.Size = New System.Drawing.Size(96, 13)
        FormaPagamentoLabel1.TabIndex = 83
        FormaPagamentoLabel1.Text = "Forma Pagamento:"
        '
        'SituacaoPagamentoLabel
        '
        SituacaoPagamentoLabel.AutoSize = True
        SituacaoPagamentoLabel.Location = New System.Drawing.Point(12, 286)
        SituacaoPagamentoLabel.Name = "SituacaoPagamentoLabel"
        SituacaoPagamentoLabel.Size = New System.Drawing.Size(109, 13)
        SituacaoPagamentoLabel.TabIndex = 85
        SituacaoPagamentoLabel.Text = "Situacao Pagamento:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(12, 414)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 87
        ObservacaoLabel.Text = "Observacao:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(12, 205)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(92, 13)
        DataVencimentoLabel.TabIndex = 91
        DataVencimentoLabel.Text = "Data Vencimento:"
        '
        'TipoPagamentoLabel
        '
        TipoPagamentoLabel.AutoSize = True
        TipoPagamentoLabel.Location = New System.Drawing.Point(12, 312)
        TipoPagamentoLabel.Name = "TipoPagamentoLabel"
        TipoPagamentoLabel.Size = New System.Drawing.Size(88, 13)
        TipoPagamentoLabel.TabIndex = 99
        TipoPagamentoLabel.Text = "Tipo Pagamento:"
        '
        'DescontoLabel1
        '
        DescontoLabel1.AutoSize = True
        DescontoLabel1.Location = New System.Drawing.Point(12, 338)
        DescontoLabel1.Name = "DescontoLabel1"
        DescontoLabel1.Size = New System.Drawing.Size(56, 13)
        DescontoLabel1.TabIndex = 101
        DescontoLabel1.Text = "Desconto:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 13)
        Label1.TabIndex = 103
        Label1.Text = "Código do Cliente"
        '
        'btnCarregarOS
        '
        Me.btnCarregarOS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCarregarOS.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCarregarOS.FlatAppearance.BorderSize = 0
        Me.btnCarregarOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCarregarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarregarOS.Image = Global.ControleOS.My.Resources.Resources.Carregar
        Me.btnCarregarOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarregarOS.Location = New System.Drawing.Point(113, 67)
        Me.btnCarregarOS.Name = "btnCarregarOS"
        Me.btnCarregarOS.Size = New System.Drawing.Size(151, 52)
        Me.btnCarregarOS.TabIndex = 34
        Me.btnCarregarOS.Text = "CARREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INFORMAÇÕES"
        Me.btnCarregarOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarregarOS.UseVisualStyleBackColor = False
        '
        'TbOSBindingSource
        '
        Me.TbOSBindingSource.DataMember = "tbOS"
        Me.TbOSBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbOSDataGridView
        '
        Me.TbOSDataGridView.AllowUserToAddRows = False
        Me.TbOSDataGridView.AllowUserToDeleteRows = False
        Me.TbOSDataGridView.AutoGenerateColumns = False
        Me.TbOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbOSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TbOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TbOSDataGridView.DataSource = Me.TbOSBindingSource
        Me.TbOSDataGridView.Location = New System.Drawing.Point(16, 176)
        Me.TbOSDataGridView.MultiSelect = False
        Me.TbOSDataGridView.Name = "TbOSDataGridView"
        Me.TbOSDataGridView.ReadOnly = True
        Me.TbOSDataGridView.RowHeadersVisible = False
        Me.TbOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TbOSDataGridView.Size = New System.Drawing.Size(762, 444)
        Me.TbOSDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OSID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código da OS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NomeCliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nome do Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TecResp"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Técnico Responsável"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataAbertura"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data da Abertura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DataAprovacao"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data da Aprovacao"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'OSIDTextBox
        '
        Me.OSIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "OSID", True))
        Me.OSIDTextBox.Location = New System.Drawing.Point(129, 19)
        Me.OSIDTextBox.Name = "OSIDTextBox"
        Me.OSIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OSIDTextBox.TabIndex = 53
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(129, 97)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 57
        '
        'TecRespTextBox
        '
        Me.TecRespTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "TecResp", True))
        Me.TecRespTextBox.Location = New System.Drawing.Point(129, 123)
        Me.TecRespTextBox.Name = "TecRespTextBox"
        Me.TecRespTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TecRespTextBox.TabIndex = 59
        '
        'DataAberturaDateTimePicker
        '
        Me.DataAberturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbOSBindingSource, "DataAbertura", True))
        Me.DataAberturaDateTimePicker.Location = New System.Drawing.Point(129, 149)
        Me.DataAberturaDateTimePicker.Name = "DataAberturaDateTimePicker"
        Me.DataAberturaDateTimePicker.Size = New System.Drawing.Size(236, 20)
        Me.DataAberturaDateTimePicker.TabIndex = 61
        '
        'DataAprovacaoDateTimePicker
        '
        Me.DataAprovacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbOSBindingSource, "DataAprovacao", True))
        Me.DataAprovacaoDateTimePicker.Location = New System.Drawing.Point(129, 175)
        Me.DataAprovacaoDateTimePicker.Name = "DataAprovacaoDateTimePicker"
        Me.DataAprovacaoDateTimePicker.Size = New System.Drawing.Size(236, 20)
        Me.DataAprovacaoDateTimePicker.TabIndex = 63
        '
        'NomeClienteTextBox
        '
        Me.NomeClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "NomeCliente", True))
        Me.NomeClienteTextBox.Location = New System.Drawing.Point(129, 45)
        Me.NomeClienteTextBox.Name = "NomeClienteTextBox"
        Me.NomeClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeClienteTextBox.TabIndex = 65
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(16, 148)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(295, 20)
        Me.txtPesquisa.TabIndex = 67
        Me.txtPesquisa.Text = "ESCOLHA UMA OPÇÃO ACIMA E PESQUISE"
        '
        'rdPesquisaOS
        '
        Me.rdPesquisaOS.AutoSize = True
        Me.rdPesquisaOS.BackColor = System.Drawing.Color.Transparent
        Me.rdPesquisaOS.Location = New System.Drawing.Point(22, 125)
        Me.rdPesquisaOS.Name = "rdPesquisaOS"
        Me.rdPesquisaOS.Size = New System.Drawing.Size(65, 17)
        Me.rdPesquisaOS.TabIndex = 69
        Me.rdPesquisaOS.TabStop = True
        Me.rdPesquisaOS.Text = "Cód. OS"
        Me.rdPesquisaOS.UseVisualStyleBackColor = False
        '
        'rdPesquisaNomeCliente
        '
        Me.rdPesquisaNomeCliente.AutoSize = True
        Me.rdPesquisaNomeCliente.BackColor = System.Drawing.Color.Transparent
        Me.rdPesquisaNomeCliente.Location = New System.Drawing.Point(93, 125)
        Me.rdPesquisaNomeCliente.Name = "rdPesquisaNomeCliente"
        Me.rdPesquisaNomeCliente.Size = New System.Drawing.Size(103, 17)
        Me.rdPesquisaNomeCliente.TabIndex = 70
        Me.rdPesquisaNomeCliente.TabStop = True
        Me.rdPesquisaNomeCliente.Text = "Nome do Cliente"
        Me.rdPesquisaNomeCliente.UseVisualStyleBackColor = False
        '
        'rdDataAbertura
        '
        Me.rdDataAbertura.AutoSize = True
        Me.rdDataAbertura.BackColor = System.Drawing.Color.Transparent
        Me.rdDataAbertura.Location = New System.Drawing.Point(202, 125)
        Me.rdDataAbertura.Name = "rdDataAbertura"
        Me.rdDataAbertura.Size = New System.Drawing.Size(106, 17)
        Me.rdDataAbertura.TabIndex = 71
        Me.rdDataAbertura.TabStop = True
        Me.rdDataAbertura.Text = "Data de Abertura"
        Me.rdDataAbertura.UseVisualStyleBackColor = False
        '
        'rdTecResponsavel
        '
        Me.rdTecResponsavel.AutoSize = True
        Me.rdTecResponsavel.BackColor = System.Drawing.Color.Transparent
        Me.rdTecResponsavel.Location = New System.Drawing.Point(438, 125)
        Me.rdTecResponsavel.Name = "rdTecResponsavel"
        Me.rdTecResponsavel.Size = New System.Drawing.Size(129, 17)
        Me.rdTecResponsavel.TabIndex = 72
        Me.rdTecResponsavel.TabStop = True
        Me.rdTecResponsavel.Text = "Técnico Responsável"
        Me.rdTecResponsavel.UseVisualStyleBackColor = False
        '
        'rdDataAprovacao
        '
        Me.rdDataAprovacao.AutoSize = True
        Me.rdDataAprovacao.BackColor = System.Drawing.Color.Transparent
        Me.rdDataAprovacao.Location = New System.Drawing.Point(314, 125)
        Me.rdDataAprovacao.Name = "rdDataAprovacao"
        Me.rdDataAprovacao.Size = New System.Drawing.Size(118, 17)
        Me.rdDataAprovacao.TabIndex = 74
        Me.rdDataAprovacao.TabStop = True
        Me.rdDataAprovacao.Text = "Data de Aprovação"
        Me.rdDataAprovacao.UseVisualStyleBackColor = False
        '
        'TbOSTableAdapter
        '
        Me.TbOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbAgendaTableAdapter = Nothing
        Me.TableAdapterManager.tbAndamentoOSTableAdapter = Nothing
        Me.TableAdapterManager.tbAnexosTableAdapter = Nothing
        Me.TableAdapterManager.tbClientes1TableAdapter = Nothing
        Me.TableAdapterManager.tbClientes2TableAdapter = Nothing
        Me.TableAdapterManager.tbClientes3TableAdapter = Nothing
        Me.TableAdapterManager.tbClientesTableAdapter = Me.TbClientesTableAdapter
        Me.TableAdapterManager.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager.tbEndGesseiroTableAdapter = Nothing
        Me.TableAdapterManager.tbEndTableAdapter = Nothing
        Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager.tbFilaProducaoTableAdapter = Nothing
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager.tbFormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.tbGesseirosTableAdapter = Nothing
        Me.TableAdapterManager.tbHistoricoMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbInicialPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbLancarTableAdapter = Nothing
        Me.TableAdapterManager.tbLiberacaoOSTableAdapter = Nothing
        Me.TableAdapterManager.tbMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbObservacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbOSTableAdapter = Me.TbOSTableAdapter
        Me.TableAdapterManager.tbPagamentosRealizadosTableAdapter = Nothing
        Me.TableAdapterManager.tbPagamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbPlanoContaTableAdapter = Nothing
        Me.TableAdapterManager.tbPlanoDespesasTableAdapter = Nothing
        Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoPDVTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutos2TableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVenda1TableAdapter = Nothing
        Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager.tbTipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbClientesTableAdapter
        '
        Me.TbClientesTableAdapter.ClearBeforeFill = True
        '
        'TbClientesBindingSource
        '
        Me.TbClientesBindingSource.DataMember = "tbClientes"
        Me.TbClientesBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbLancamentosBindingSource
        '
        Me.TbLancamentosBindingSource.DataMember = "tbOStbLancamentos"
        Me.TbLancamentosBindingSource.DataSource = Me.TbOSBindingSource
        '
        'TbLancamentosTableAdapter
        '
        Me.TbLancamentosTableAdapter.ClearBeforeFill = True
        '
        'TbInicialPagoBindingSource
        '
        Me.TbInicialPagoBindingSource.DataMember = "tbOStbInicialPago"
        Me.TbInicialPagoBindingSource.DataSource = Me.TbOSBindingSource
        '
        'TbInicialPagoTableAdapter
        '
        Me.TbInicialPagoTableAdapter.ClearBeforeFill = True
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "Preco", True))
        Me.PrecoTextBox.Location = New System.Drawing.Point(129, 227)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(99, 20)
        Me.PrecoTextBox.TabIndex = 82
        '
        'FormaPagamentoTextBox1
        '
        Me.FormaPagamentoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "FormaPagamento", True))
        Me.FormaPagamentoTextBox1.Location = New System.Drawing.Point(129, 257)
        Me.FormaPagamentoTextBox1.Name = "FormaPagamentoTextBox1"
        Me.FormaPagamentoTextBox1.Size = New System.Drawing.Size(99, 20)
        Me.FormaPagamentoTextBox1.TabIndex = 84
        '
        'SituacaoPagamentoTextBox
        '
        Me.SituacaoPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "SituacaoPagamento", True))
        Me.SituacaoPagamentoTextBox.Location = New System.Drawing.Point(129, 283)
        Me.SituacaoPagamentoTextBox.Name = "SituacaoPagamentoTextBox"
        Me.SituacaoPagamentoTextBox.Size = New System.Drawing.Size(99, 20)
        Me.SituacaoPagamentoTextBox.TabIndex = 86
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(129, 411)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(200, 27)
        Me.ObservacaoTextBox.TabIndex = 88
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbInicialPagoBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(129, 201)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(236, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 92
        '
        'TipoPagamentoTextBox
        '
        Me.TipoPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "TipoPagamento", True))
        Me.TipoPagamentoTextBox.Location = New System.Drawing.Point(129, 309)
        Me.TipoPagamentoTextBox.Name = "TipoPagamentoTextBox"
        Me.TipoPagamentoTextBox.Size = New System.Drawing.Size(99, 20)
        Me.TipoPagamentoTextBox.TabIndex = 100
        '
        'DescontoTextBox1
        '
        Me.DescontoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbInicialPagoBindingSource, "Desconto", True))
        Me.DescontoTextBox1.Location = New System.Drawing.Point(129, 335)
        Me.DescontoTextBox1.Name = "DescontoTextBox1"
        Me.DescontoTextBox1.Size = New System.Drawing.Size(99, 20)
        Me.DescontoTextBox1.TabIndex = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CodClienteTextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.NomeClienteTextBox)
        Me.GroupBox1.Controls.Add(NomeClienteLabel)
        Me.GroupBox1.Controls.Add(PrecoLabel)
        Me.GroupBox1.Controls.Add(Me.DataAprovacaoDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.PrecoTextBox)
        Me.GroupBox1.Controls.Add(DataAprovacaoLabel)
        Me.GroupBox1.Controls.Add(FormaPagamentoLabel1)
        Me.GroupBox1.Controls.Add(Me.DataAberturaDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.FormaPagamentoTextBox1)
        Me.GroupBox1.Controls.Add(DataAberturaLabel)
        Me.GroupBox1.Controls.Add(SituacaoPagamentoLabel)
        Me.GroupBox1.Controls.Add(Me.TecRespTextBox)
        Me.GroupBox1.Controls.Add(Me.SituacaoPagamentoTextBox)
        Me.GroupBox1.Controls.Add(TecRespLabel)
        Me.GroupBox1.Controls.Add(ObservacaoLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(Me.ObservacaoTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.OSIDTextBox)
        Me.GroupBox1.Controls.Add(DataVencimentoLabel)
        Me.GroupBox1.Controls.Add(OSIDLabel)
        Me.GroupBox1.Controls.Add(Me.DataVencimentoDateTimePicker)
        Me.GroupBox1.Controls.Add(TipoPagamentoLabel)
        Me.GroupBox1.Controls.Add(Me.TipoPagamentoTextBox)
        Me.GroupBox1.Controls.Add(Me.DescontoTextBox1)
        Me.GroupBox1.Controls.Add(DescontoLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(784, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 444)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes"
        '
        'CodClienteTextBox
        '
        Me.CodClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "CodCliente", True))
        Me.CodClienteTextBox.Location = New System.Drawing.Point(129, 71)
        Me.CodClienteTextBox.Name = "CodClienteTextBox"
        Me.CodClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CodClienteTextBox.TabIndex = 104
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Image = Global.ControleOS.My.Resources.Resources.Voltar2
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoltar.Location = New System.Drawing.Point(12, 67)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(95, 52)
        Me.btnVoltar.TabIndex = 105
        Me.btnVoltar.Text = "VOLTAR"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'FrmCarregarOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.BackGround_Azul_Gradiente
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnCarregarOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdDataAprovacao)
        Me.Controls.Add(Me.rdTecResponsavel)
        Me.Controls.Add(Me.rdDataAbertura)
        Me.Controls.Add(Me.rdPesquisaNomeCliente)
        Me.Controls.Add(Me.rdPesquisaOS)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.TbOSDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCarregarOS"
        Me.Text = "CARREAGAR OS/PEDIDO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbLancamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbInicialPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCarregarOS As Button
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbOSBindingSource As BindingSource
    Friend WithEvents TbOSTableAdapter As SistemaGEDataSetTableAdapters.tbOSTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbOSDataGridView As DataGridView
    Friend WithEvents OSIDTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents TecRespTextBox As TextBox
    Friend WithEvents DataAberturaDateTimePicker As DateTimePicker
    Friend WithEvents DataAprovacaoDateTimePicker As DateTimePicker
    Friend WithEvents NomeClienteTextBox As TextBox
    Friend WithEvents TbClientesTableAdapter As SistemaGEDataSetTableAdapters.tbClientesTableAdapter
    Friend WithEvents TbClientesBindingSource As BindingSource
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents rdPesquisaOS As RadioButton
    Friend WithEvents rdPesquisaNomeCliente As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents rdDataAbertura As RadioButton
    Friend WithEvents rdTecResponsavel As RadioButton
    Friend WithEvents rdDataAprovacao As RadioButton
    Friend WithEvents TbLancamentosBindingSource As BindingSource
    Friend WithEvents TbLancamentosTableAdapter As SistemaGEDataSetTableAdapters.tbLancamentosTableAdapter
    Friend WithEvents TbInicialPagoBindingSource As BindingSource
    Friend WithEvents TbInicialPagoTableAdapter As SistemaGEDataSetTableAdapters.tbInicialPagoTableAdapter
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents FormaPagamentoTextBox1 As TextBox
    Friend WithEvents SituacaoPagamentoTextBox As TextBox
    Friend WithEvents ObservacaoTextBox As TextBox
    Friend WithEvents DataVencimentoDateTimePicker As DateTimePicker
    Friend WithEvents TipoPagamentoTextBox As TextBox
    Friend WithEvents DescontoTextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents CodClienteTextBox As TextBox
End Class
