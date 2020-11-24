<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagamentos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamentos))
        Me.rdGesseiro = New System.Windows.Forms.RadioButton()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SobrenomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbGesseirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TbGesseirostbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtGesseiroID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeGesseiro = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalAreaExecutada = New System.Windows.Forms.TextBox()
        Me.TbHistoricoMedicao1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet1 = New ControleOS.SistemaGEDataSet()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TbMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbGesseirostbHistoricoMedicaoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodOS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbGesseirosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter()
        Me.TbHistoricoMedicaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter()
        Me.TbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbMedicaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbMedicaoTableAdapter()
        Me.TbHistoricoMedicao1TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicao1TableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbHistoricoMedicao1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.TbFormaPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbTipoPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbLancarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbLancarTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbLancarTableAdapter()
        Me.TbTipoPagamentoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbTipoPagamentoTableAdapter()
        Me.TbFormaPagamentoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbFormaPagamentoTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPlanoConta = New System.Windows.Forms.ComboBox()
        Me.TbPlanoDespesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPlanoDespesasTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbPlanoDespesasTableAdapter()
        Me.txtLiberacao = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblmsg = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtLucro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstPagSel = New System.Windows.Forms.ListView()
        Me.btnImprimirPag = New System.Windows.Forms.Button()
        Me.txtSobrenomeGesseiro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaPlanejada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lucro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReceber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Liberacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirostbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicao1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirostbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicao1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbTipoPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbLancarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPlanoDespesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdGesseiro
        '
        Me.rdGesseiro.AutoSize = True
        Me.rdGesseiro.BackColor = System.Drawing.Color.Transparent
        Me.rdGesseiro.Location = New System.Drawing.Point(265, 67)
        Me.rdGesseiro.Name = "rdGesseiro"
        Me.rdGesseiro.Size = New System.Drawing.Size(97, 17)
        Me.rdGesseiro.TabIndex = 3
        Me.rdGesseiro.TabStop = True
        Me.rdGesseiro.Text = "Nome Gesseiro"
        Me.rdGesseiro.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVoltar.Image = Global.ControleOS.My.Resources.Resources.Voltar2
        Me.btnVoltar.Location = New System.Drawing.Point(13, 11)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 47)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 64)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(247, 20)
        Me.txtPesquisa.TabIndex = 2
        Me.txtPesquisa.Text = "PESQUISE AQUI"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeDataGridViewTextBoxColumn, Me.SobrenomeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbGesseirosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(247, 177)
        Me.DataGridView1.TabIndex = 7
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "NOME"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SobrenomeDataGridViewTextBoxColumn
        '
        Me.SobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome"
        Me.SobrenomeDataGridViewTextBoxColumn.HeaderText = "SOBRENOME"
        Me.SobrenomeDataGridViewTextBoxColumn.Name = "SobrenomeDataGridViewTextBoxColumn"
        Me.SobrenomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbGesseirosBindingSource
        '
        Me.TbGesseirosBindingSource.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.SubID, Me.Lucro, Me.AReceber, Me.Descricao, Me.MedicaoDataGridViewTextBoxColumn, Me.UNIDADEDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.Liberacao})
        Me.DataGridView2.DataSource = Me.TbGesseirostbHistoricoMedicaoBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 299)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(791, 225)
        Me.DataGridView2.TabIndex = 8
        '
        'TbGesseirostbHistoricoMedicaoBindingSource
        '
        Me.TbGesseirostbHistoricoMedicaoBindingSource.DataMember = "tbGesseirostbHistoricoMedicao"
        Me.TbGesseirostbHistoricoMedicaoBindingSource.DataSource = Me.TbGesseirosBindingSource
        '
        'txtGesseiroID
        '
        Me.txtGesseiroID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirosBindingSource, "Código", True))
        Me.txtGesseiroID.Location = New System.Drawing.Point(6, 37)
        Me.txtGesseiroID.Name = "txtGesseiroID"
        Me.txtGesseiroID.Size = New System.Drawing.Size(87, 20)
        Me.txtGesseiroID.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Código Prestador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome Gesseiro"
        '
        'txtNomeGesseiro
        '
        Me.txtNomeGesseiro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirosBindingSource, "Nome", True))
        Me.txtNomeGesseiro.Location = New System.Drawing.Point(5, 75)
        Me.txtNomeGesseiro.Name = "txtNomeGesseiro"
        Me.txtNomeGesseiro.Size = New System.Drawing.Size(186, 20)
        Me.txtNomeGesseiro.TabIndex = 13
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.Transparent
        Me.btnPagar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Image = Global.ControleOS.My.Resources.Resources.Pagamento
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(93, 173)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(107, 58)
        Me.btnPagar.TabIndex = 15
        Me.btnPagar.Text = "Realizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagamento"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total Area Executada"
        '
        'txtTotalAreaExecutada
        '
        Me.txtTotalAreaExecutada.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtTotalAreaExecutada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "AReceber", True))
        Me.txtTotalAreaExecutada.Location = New System.Drawing.Point(9, 70)
        Me.txtTotalAreaExecutada.Name = "txtTotalAreaExecutada"
        Me.txtTotalAreaExecutada.Size = New System.Drawing.Size(123, 20)
        Me.txtTotalAreaExecutada.TabIndex = 16
        '
        'TbHistoricoMedicao1BindingSource1
        '
        Me.TbHistoricoMedicao1BindingSource1.DataMember = "tbHistoricoMedicao1"
        Me.TbHistoricoMedicao1BindingSource1.DataSource = Me.SistemaGEDataSet1
        '
        'SistemaGEDataSet1
        '
        Me.SistemaGEDataSet1.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSID, Me.NomeProduto, Me.AreaPlanejada})
        Me.DataGridView3.DataSource = Me.TbMedicaoBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(261, 103)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.Size = New System.Drawing.Size(338, 177)
        Me.DataGridView3.TabIndex = 18
        '
        'TbMedicaoBindingSource
        '
        Me.TbMedicaoBindingSource.DataMember = "tbMedicao"
        Me.TbMedicaoBindingSource.DataSource = Me.SistemaGEDataSet1
        '
        'TbGesseirostbHistoricoMedicaoBindingSource1
        '
        Me.TbGesseirostbHistoricoMedicaoBindingSource1.DataMember = "tbGesseirostbHistoricoMedicao"
        Me.TbGesseirostbHistoricoMedicaoBindingSource1.DataSource = Me.TbGesseirosBindingSource
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(96, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "OSID"
        '
        'txtCodOS
        '
        Me.txtCodOS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "OSID", True))
        Me.txtCodOS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCodOS.Location = New System.Drawing.Point(96, 37)
        Me.txtCodOS.Name = "txtCodOS"
        Me.txtCodOS.Size = New System.Drawing.Size(95, 20)
        Me.txtCodOS.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Prestadores de Serviço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Descrição de Pagamento"
        '
        'TbGesseirosTableAdapter
        '
        Me.TbGesseirosTableAdapter.ClearBeforeFill = True
        '
        'TbHistoricoMedicaoTableAdapter
        '
        Me.TbHistoricoMedicaoTableAdapter.ClearBeforeFill = True
        '
        'TbHistoricoMedicaoBindingSource
        '
        Me.TbHistoricoMedicaoBindingSource.DataMember = "tbHistoricoMedicao"
        Me.TbHistoricoMedicaoBindingSource.DataSource = Me.SistemaGEDataSet1
        '
        'TbMedicaoTableAdapter
        '
        Me.TbMedicaoTableAdapter.ClearBeforeFill = True
        '
        'TbHistoricoMedicao1TableAdapter
        '
        Me.TbHistoricoMedicao1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbAgendaTableAdapter = Nothing
        Me.TableAdapterManager.tbAndamentoOSTableAdapter = Nothing
        Me.TableAdapterManager.tbAnexosTableAdapter = Nothing
        Me.TableAdapterManager.tbClientes1TableAdapter = Nothing
        Me.TableAdapterManager.tbClientes2TableAdapter = Nothing
        Me.TableAdapterManager.tbClientes3TableAdapter = Nothing
        Me.TableAdapterManager.tbClientesTableAdapter = Nothing
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
        Me.TableAdapterManager.tbOSTableAdapter = Nothing
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
        'TbHistoricoMedicao1BindingSource
        '
        Me.TbHistoricoMedicao1BindingSource.DataMember = "tbHistoricoMedicao1"
        Me.TbHistoricoMedicao1BindingSource.DataSource = Me.SistemaGEDataSet
        '
        'txtValor
        '
        Me.txtValor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "AReceber", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtValor.Location = New System.Drawing.Point(171, 111)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(107, 20)
        Me.txtValor.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(168, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Valor a Pagar"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.DataSource = Me.TbFormaPagamentoBindingSource
        Me.cboFormaPagamento.DisplayMember = "FormaPagamento"
        Me.cboFormaPagamento.FormattingEnabled = True
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 111)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Size = New System.Drawing.Size(160, 21)
        Me.cboFormaPagamento.TabIndex = 38
        '
        'TbFormaPagamentoBindingSource
        '
        Me.TbFormaPagamentoBindingSource.DataMember = "tbFormaPagamento"
        Me.TbFormaPagamentoBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbTipoPagamentoBindingSource
        '
        Me.TbTipoPagamentoBindingSource.DataMember = "tbTipoPagamento"
        Me.TbTipoPagamentoBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(10, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Forma de Pagamento"
        '
        'TbLancarBindingSource
        '
        Me.TbLancarBindingSource.DataMember = "tbLancar"
        Me.TbLancarBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbLancarTableAdapter
        '
        Me.TbLancarTableAdapter.ClearBeforeFill = True
        '
        'TbTipoPagamentoTableAdapter
        '
        Me.TbTipoPagamentoTableAdapter.ClearBeforeFill = True
        '
        'TbFormaPagamentoTableAdapter
        '
        Me.TbFormaPagamentoTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(10, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Plano de Contas"
        '
        'cboPlanoConta
        '
        Me.cboPlanoConta.DataSource = Me.TbPlanoDespesasBindingSource
        Me.cboPlanoConta.DisplayMember = "TipoDespesa"
        Me.cboPlanoConta.FormattingEnabled = True
        Me.cboPlanoConta.Location = New System.Drawing.Point(9, 151)
        Me.cboPlanoConta.Name = "cboPlanoConta"
        Me.cboPlanoConta.Size = New System.Drawing.Size(160, 21)
        Me.cboPlanoConta.TabIndex = 40
        '
        'TbPlanoDespesasBindingSource
        '
        Me.TbPlanoDespesasBindingSource.DataMember = "tbPlanoDespesas"
        Me.TbPlanoDespesasBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbPlanoDespesasTableAdapter
        '
        Me.TbPlanoDespesasTableAdapter.ClearBeforeFill = True
        '
        'txtLiberacao
        '
        Me.txtLiberacao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "Liberacao", True))
        Me.txtLiberacao.Location = New System.Drawing.Point(9, 31)
        Me.txtLiberacao.Name = "txtLiberacao"
        Me.txtLiberacao.Size = New System.Drawing.Size(246, 20)
        Me.txtLiberacao.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Liberação para Pagamento"
        '
        'btnLiberar
        '
        Me.btnLiberar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLiberar.Location = New System.Drawing.Point(577, 46)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(90, 23)
        Me.btnLiberar.TabIndex = 45
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(137, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "ID"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(134, 70)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 46
        '
        'lblmsg
        '
        Me.lblmsg.Location = New System.Drawing.Point(13, 875)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(376, 20)
        Me.lblmsg.TabIndex = 50
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtLucro
        '
        Me.txtLucro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirostbHistoricoMedicaoBindingSource, "Lucro", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtLucro.Location = New System.Drawing.Point(170, 152)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Size = New System.Drawing.Size(108, 20)
        Me.txtLucro.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(168, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Valor a Receber"
        '
        'lstPagSel
        '
        Me.lstPagSel.HideSelection = False
        Me.lstPagSel.Location = New System.Drawing.Point(809, 103)
        Me.lstPagSel.Name = "lstPagSel"
        Me.lstPagSel.Size = New System.Drawing.Size(288, 177)
        Me.lstPagSel.TabIndex = 55
        Me.lstPagSel.UseCompatibleStateImageBehavior = False
        Me.lstPagSel.View = System.Windows.Forms.View.List
        '
        'btnImprimirPag
        '
        Me.btnImprimirPag.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimirPag.FlatAppearance.BorderSize = 0
        Me.btnImprimirPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirPag.Image = Global.ControleOS.My.Resources.Resources.Imprimir1
        Me.btnImprimirPag.Location = New System.Drawing.Point(91, 12)
        Me.btnImprimirPag.Name = "btnImprimirPag"
        Me.btnImprimirPag.Size = New System.Drawing.Size(86, 47)
        Me.btnImprimirPag.TabIndex = 57
        Me.btnImprimirPag.UseVisualStyleBackColor = False
        '
        'txtSobrenomeGesseiro
        '
        Me.txtSobrenomeGesseiro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirosBindingSource, "Sobrenome", True))
        Me.txtSobrenomeGesseiro.Location = New System.Drawing.Point(5, 112)
        Me.txtSobrenomeGesseiro.Name = "txtSobrenomeGesseiro"
        Me.txtSobrenomeGesseiro.Size = New System.Drawing.Size(186, 20)
        Me.txtSobrenomeGesseiro.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(4, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Sobrenome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(5, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "CPF"
        '
        'txtCPF
        '
        Me.txtCPF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbGesseirosBindingSource, "CPF", True))
        Me.txtCPF.Location = New System.Drawing.Point(6, 150)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(185, 20)
        Me.txtCPF.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtGesseiroID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNomeGesseiro)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCodOS)
        Me.GroupBox1.Controls.Add(Me.txtSobrenomeGesseiro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(602, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 183)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtTotalAreaExecutada)
        Me.GroupBox2.Controls.Add(Me.btnPagar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.txtLucro)
        Me.GroupBox2.Controls.Add(Me.cboFormaPagamento)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboPlanoConta)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtLiberacao)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(809, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 231)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'OSID
        '
        Me.OSID.DataPropertyName = "OSID"
        Me.OSID.HeaderText = "OSID"
        Me.OSID.Name = "OSID"
        Me.OSID.ReadOnly = True
        '
        'NomeProduto
        '
        Me.NomeProduto.DataPropertyName = "NomeProduto"
        Me.NomeProduto.HeaderText = "DESCRIÇÃO"
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.ReadOnly = True
        '
        'AreaPlanejada
        '
        Me.AreaPlanejada.DataPropertyName = "AreaPlanejada"
        Me.AreaPlanejada.HeaderText = "AREA TOTAL"
        Me.AreaPlanejada.Name = "AreaPlanejada"
        Me.AreaPlanejada.ReadOnly = True
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.FillWeight = 256.8172!
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "CÓD. OS"
        Me.OSIDDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        Me.OSIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OSIDDataGridViewTextBoxColumn.Width = 55
        '
        'SubID
        '
        Me.SubID.DataPropertyName = "SubID"
        Me.SubID.FillWeight = 69.28974!
        Me.SubID.HeaderText = "CÓD. PAGAMENTO"
        Me.SubID.Name = "SubID"
        Me.SubID.ReadOnly = True
        '
        'Lucro
        '
        Me.Lucro.DataPropertyName = "Lucro"
        Me.Lucro.FillWeight = 69.28974!
        Me.Lucro.HeaderText = "A RECEBER"
        Me.Lucro.Name = "Lucro"
        Me.Lucro.ReadOnly = True
        '
        'AReceber
        '
        Me.AReceber.DataPropertyName = "AReceber"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AReceber.DefaultCellStyle = DataGridViewCellStyle1
        Me.AReceber.FillWeight = 69.28974!
        Me.AReceber.HeaderText = "VALOR"
        Me.AReceber.Name = "AReceber"
        Me.AReceber.ReadOnly = True
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.FillWeight = 69.28974!
        Me.Descricao.HeaderText = "DESCRIÇÃO"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'MedicaoDataGridViewTextBoxColumn
        '
        Me.MedicaoDataGridViewTextBoxColumn.DataPropertyName = "Medicao"
        Me.MedicaoDataGridViewTextBoxColumn.FillWeight = 69.28974!
        Me.MedicaoDataGridViewTextBoxColumn.HeaderText = "MEDIÇÃO"
        Me.MedicaoDataGridViewTextBoxColumn.Name = "MedicaoDataGridViewTextBoxColumn"
        Me.MedicaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn
        '
        Me.UNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.FillWeight = 69.28974!
        Me.UNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.Name = "UNIDADEDataGridViewTextBoxColumn"
        Me.UNIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataDataGridViewTextBoxColumn.FillWeight = 69.28974!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "DATA MEDIÇÃO"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.FillWeight = 69.28974!
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Liberacao
        '
        Me.Liberacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Liberacao.DataPropertyName = "Liberacao"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Liberacao.DefaultCellStyle = DataGridViewCellStyle3
        Me.Liberacao.FillWeight = 274.2415!
        Me.Liberacao.HeaderText = "Liberacao"
        Me.Liberacao.Name = "Liberacao"
        Me.Liberacao.ReadOnly = True
        Me.Liberacao.Visible = False
        Me.Liberacao.Width = 47
        '
        'FrmPagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1285, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimirPag)
        Me.Controls.Add(Me.lstPagSel)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.rdGesseiro)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.btnLiberar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPagamentos"
        Me.Text = "PAGAMENTO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirostbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicao1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirostbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicao1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbTipoPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbLancarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPlanoDespesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdGesseiro As RadioButton
    Friend WithEvents btnVoltar As Button
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtGesseiroID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeGesseiro As TextBox
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbGesseirosBindingSource As BindingSource
    Friend WithEvents TbGesseirosTableAdapter As SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter
    Friend WithEvents TbGesseirostbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicaoTableAdapter As SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnPagar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalAreaExecutada As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TbGesseirostbHistoricoMedicaoBindingSource1 As BindingSource
    Friend WithEvents SistemaGEDataSet1 As SistemaGEDataSet
    Friend WithEvents TbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbMedicaoBindingSource As BindingSource
    Friend WithEvents TbMedicaoTableAdapter As SistemaGEDataSetTableAdapters.tbMedicaoTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodOS As TextBox
    Friend WithEvents TbHistoricoMedicao1TableAdapter As SistemaGEDataSetTableAdapters.tbHistoricoMedicao1TableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SobrenomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbHistoricoMedicao1BindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicao1BindingSource1 As BindingSource
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboFormaPagamento As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbLancarBindingSource As BindingSource
    Friend WithEvents TbLancarTableAdapter As SistemaGEDataSetTableAdapters.tbLancarTableAdapter
    Friend WithEvents TbTipoPagamentoBindingSource As BindingSource
    Friend WithEvents TbTipoPagamentoTableAdapter As SistemaGEDataSetTableAdapters.tbTipoPagamentoTableAdapter
    Friend WithEvents TbFormaPagamentoBindingSource As BindingSource
    Friend WithEvents TbFormaPagamentoTableAdapter As SistemaGEDataSetTableAdapters.tbFormaPagamentoTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPlanoConta As ComboBox
    Friend WithEvents TbPlanoDespesasBindingSource As BindingSource
    Friend WithEvents TbPlanoDespesasTableAdapter As SistemaGEDataSetTableAdapters.tbPlanoDespesasTableAdapter
    Friend WithEvents txtLiberacao As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnLiberar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblmsg As TextBox
    Friend WithEvents lbSelecao As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtLucro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lstPagSel As ListView
    Friend WithEvents btnImprimirPag As Button
    Friend WithEvents txtSobrenomeGesseiro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OSID As DataGridViewTextBoxColumn
    Friend WithEvents NomeProduto As DataGridViewTextBoxColumn
    Friend WithEvents AreaPlanejada As DataGridViewTextBoxColumn
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubID As DataGridViewTextBoxColumn
    Friend WithEvents Lucro As DataGridViewTextBoxColumn
    Friend WithEvents AReceber As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents MedicaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Liberacao As DataGridViewTextBoxColumn
End Class
