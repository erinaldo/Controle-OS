<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrestadores
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
        Dim AnexoIDLabel As System.Windows.Forms.Label
        Dim CaminhoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrestadores))
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbGesseirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbGesseirosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbGesseirosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbGesseirosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TbGesseirosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAnexosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbAnexosTableAdapter()
        Me.TbAnexosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pctAnexos = New System.Windows.Forms.PictureBox()
        Me.btnTelaCheia = New System.Windows.Forms.Button()
        Me.txtAnexoID = New System.Windows.Forms.TextBox()
        Me.CaminhoTextBox = New System.Windows.Forms.TextBox()
        Me.btnFecharTela = New System.Windows.Forms.Button()
        Me.btnAnexoA = New System.Windows.Forms.Button()
        Me.btnAnexoP = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        AnexoIDLabel = New System.Windows.Forms.Label()
        CaminhoLabel = New System.Windows.Forms.Label()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbGesseirosBindingNavigator.SuspendLayout()
        CType(Me.TbGesseirosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAnexosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnexoIDLabel
        '
        AnexoIDLabel.AutoSize = True
        AnexoIDLabel.Location = New System.Drawing.Point(1132, 174)
        AnexoIDLabel.Name = "AnexoIDLabel"
        AnexoIDLabel.Size = New System.Drawing.Size(54, 13)
        AnexoIDLabel.TabIndex = 11
        AnexoIDLabel.Text = "Anexo ID:"
        '
        'CaminhoLabel
        '
        CaminhoLabel.AutoSize = True
        CaminhoLabel.Location = New System.Drawing.Point(1132, 200)
        CaminhoLabel.Name = "CaminhoLabel"
        CaminhoLabel.Size = New System.Drawing.Size(51, 13)
        CaminhoLabel.TabIndex = 13
        CaminhoLabel.Text = "Caminho:"
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbGesseirosBindingSource
        '
        Me.TbGesseirosBindingSource.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbGesseirosTableAdapter
        '
        Me.TbGesseirosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbClientesTableAdapter = Nothing
        Me.TableAdapterManager.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager.tbEndTableAdapter = Nothing
        Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager.tbFilaProducaoTableAdapter = Nothing
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager.tbFormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.tbGesseirosTableAdapter = Me.TbGesseirosTableAdapter
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
        Me.TableAdapterManager.tbPlanoDespesasTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutos2TableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVenda1TableAdapter = Nothing
        Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager.tbTipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbGesseirosBindingNavigator
        '
        Me.TbGesseirosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbGesseirosBindingNavigator.BindingSource = Me.TbGesseirosBindingSource
        Me.TbGesseirosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbGesseirosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbGesseirosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TbGesseirosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbGesseirosBindingNavigatorSaveItem})
        Me.TbGesseirosBindingNavigator.Location = New System.Drawing.Point(9, 93)
        Me.TbGesseirosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbGesseirosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbGesseirosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbGesseirosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbGesseirosBindingNavigator.Name = "TbGesseirosBindingNavigator"
        Me.TbGesseirosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbGesseirosBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.TbGesseirosBindingNavigator.TabIndex = 0
        Me.TbGesseirosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TbGesseirosBindingNavigatorSaveItem
        '
        Me.TbGesseirosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbGesseirosBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbGesseirosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbGesseirosBindingNavigatorSaveItem.Name = "TbGesseirosBindingNavigatorSaveItem"
        Me.TbGesseirosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TbGesseirosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TbGesseirosDataGridView
        '
        Me.TbGesseirosDataGridView.AutoGenerateColumns = False
        Me.TbGesseirosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbGesseirosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TbGesseirosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbGesseirosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TbGesseirosDataGridView.DataSource = Me.TbGesseirosBindingSource
        Me.TbGesseirosDataGridView.Location = New System.Drawing.Point(9, 61)
        Me.TbGesseirosDataGridView.Name = "TbGesseirosDataGridView"
        Me.TbGesseirosDataGridView.RowHeadersVisible = False
        Me.TbGesseirosDataGridView.Size = New System.Drawing.Size(734, 231)
        Me.TbGesseirosDataGridView.TabIndex = 1
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "N° Prestador"
        Me.Código.Name = "Código"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RG"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RG"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EstadoCivil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado Civil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nacionalidade"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nacionalidade"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(752, 148)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(141, 20)
        Me.txtDescricao.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(749, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Anexar arquivo"
        '
        'TbAnexosBindingSource
        '
        Me.TbAnexosBindingSource.DataMember = "tbAnexos"
        Me.TbAnexosBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbAnexosTableAdapter
        '
        Me.TbAnexosTableAdapter.ClearBeforeFill = True
        '
        'TbAnexosDataGridView
        '
        Me.TbAnexosDataGridView.AutoGenerateColumns = False
        Me.TbAnexosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbAnexosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TbAnexosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbAnexosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TbAnexosDataGridView.DataSource = Me.TbAnexosBindingSource
        Me.TbAnexosDataGridView.Location = New System.Drawing.Point(752, 174)
        Me.TbAnexosDataGridView.Name = "TbAnexosDataGridView"
        Me.TbAnexosDataGridView.RowHeadersVisible = False
        Me.TbAnexosDataGridView.Size = New System.Drawing.Size(374, 118)
        Me.TbAnexosDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DataAdicao"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Data de Cadastro"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pctAnexos)
        Me.GroupBox1.Controls.Add(Me.btnTelaCheia)
        Me.GroupBox1.Location = New System.Drawing.Point(752, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 391)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'pctAnexos
        '
        Me.pctAnexos.Location = New System.Drawing.Point(6, 19)
        Me.pctAnexos.Name = "pctAnexos"
        Me.pctAnexos.Size = New System.Drawing.Size(492, 352)
        Me.pctAnexos.TabIndex = 4
        Me.pctAnexos.TabStop = False
        '
        'btnTelaCheia
        '
        Me.btnTelaCheia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTelaCheia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTelaCheia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTelaCheia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ' Me.btnTelaCheia.Image = Global.ControleOS.My.Resources.Resources.fullscreendisplay_full_pantallacompleta_1899
        Me.btnTelaCheia.Location = New System.Drawing.Point(504, 19)
        Me.btnTelaCheia.Name = "btnTelaCheia"
        Me.btnTelaCheia.Size = New System.Drawing.Size(57, 53)
        Me.btnTelaCheia.TabIndex = 9
        Me.btnTelaCheia.UseVisualStyleBackColor = True
        '
        'txtAnexoID
        '
        Me.txtAnexoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAnexosBindingSource, "AnexoID", True))
        Me.txtAnexoID.Location = New System.Drawing.Point(1192, 171)
        Me.txtAnexoID.Name = "txtAnexoID"
        Me.txtAnexoID.ReadOnly = True
        Me.txtAnexoID.Size = New System.Drawing.Size(58, 20)
        Me.txtAnexoID.TabIndex = 12
        '
        'CaminhoTextBox
        '
        Me.CaminhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAnexosBindingSource, "Caminho", True))
        Me.CaminhoTextBox.Location = New System.Drawing.Point(1192, 197)
        Me.CaminhoTextBox.Multiline = True
        Me.CaminhoTextBox.Name = "CaminhoTextBox"
        Me.CaminhoTextBox.ReadOnly = True
        Me.CaminhoTextBox.Size = New System.Drawing.Size(146, 47)
        Me.CaminhoTextBox.TabIndex = 14
        '
        'btnFecharTela
        '
        Me.btnFecharTela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFecharTela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFecharTela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        '  Me.btnFecharTela.Image = Global.ControleOS.My.Resources.Resources.Exitfullscreen_screen_output_1900
        Me.btnFecharTela.Location = New System.Drawing.Point(1262, 12)
        Me.btnFecharTela.Name = "btnFecharTela"
        Me.btnFecharTela.Size = New System.Drawing.Size(76, 77)
        Me.btnFecharTela.TabIndex = 16
        Me.btnFecharTela.UseVisualStyleBackColor = True
        Me.btnFecharTela.Visible = False
        '
        'btnAnexoA
        '
        '    Me.btnAnexoA.Image = Global.ControleOS.My.Resources.Resources._3592867_attach_attachment_clip_clipping_general_office_paperclip_107757
        Me.btnAnexoA.Location = New System.Drawing.Point(899, 124)
        Me.btnAnexoA.Name = "btnAnexoA"
        Me.btnAnexoA.Size = New System.Drawing.Size(33, 44)
        Me.btnAnexoA.TabIndex = 7
        Me.btnAnexoA.UseVisualStyleBackColor = True
        '
        'btnAnexoP
        '
        '     Me.btnAnexoP.Image = Global.ControleOS.My.Resources.Resources.attachment_icon_icons_com_73315
        Me.btnAnexoP.Location = New System.Drawing.Point(899, 124)
        Me.btnAnexoP.Name = "btnAnexoP"
        Me.btnAnexoP.Size = New System.Drawing.Size(33, 44)
        Me.btnAnexoP.TabIndex = 6
        Me.btnAnexoP.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        '    Me.btnVoltar.Image = Global.ControleOS.My.Resources.Resources.custom_icon_design_flatastic_8_go_back
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoltar.Location = New System.Drawing.Point(9, 12)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(92, 43)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "VOLTAR"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'FrmPrestadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnFecharTela)
        Me.Controls.Add(AnexoIDLabel)
        Me.Controls.Add(Me.txtAnexoID)
        Me.Controls.Add(CaminhoLabel)
        Me.Controls.Add(Me.CaminhoTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TbAnexosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnexoA)
        Me.Controls.Add(Me.btnAnexoP)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.TbGesseirosDataGridView)
        Me.Controls.Add(Me.TbGesseirosBindingNavigator)
        Me.Name = "FrmPrestadores"
        Me.Text = "FrmPrestadores"
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbGesseirosBindingNavigator.ResumeLayout(False)
        Me.TbGesseirosBindingNavigator.PerformLayout()
        CType(Me.TbGesseirosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAnexosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pctAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbGesseirosBindingSource As BindingSource
    Friend WithEvents TbGesseirosTableAdapter As SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbGesseirosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TbGesseirosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TbGesseirosDataGridView As DataGridView
    Friend WithEvents btnVoltar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pctAnexos As PictureBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnAnexoP As Button
    Friend WithEvents btnAnexoA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbAnexosBindingSource As BindingSource
    Friend WithEvents TbAnexosTableAdapter As SistemaGEDataSetTableAdapters.tbAnexosTableAdapter
    Friend WithEvents TbAnexosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents btnTelaCheia As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents txtAnexoID As TextBox
    Friend WithEvents CaminhoTextBox As TextBox
    Friend WithEvents btnFecharTela As Button
End Class
