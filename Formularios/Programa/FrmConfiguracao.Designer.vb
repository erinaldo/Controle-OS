<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracao
        ' Inherits System.Windows.Forms.Form

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
	      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracao))
	      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
	      Me.TbFormaPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbFormaPagamentoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbFormaPagamentoTableAdapter()
	      Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
	      Me.TbFormaPagamentoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
	      Me.TbFormaPagamentoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
	      Me.dgvFormaPagamento = New System.Windows.Forms.DataGridView()
	      Me.FormaPagamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.btnSalvar = New System.Windows.Forms.Button()
	      Me.DataSetX = New ControleOS.DataSetX()
	      Me.FormaPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.FormaPagamentoTableAdapter = New ControleOS.DataSetXTableAdapters.FormaPagamentoTableAdapter()
	      Me.TableAdapterManager1 = New ControleOS.DataSetXTableAdapters.TableAdapterManager()
	      Me.TbAgendaTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbAgendaTableAdapter()
	      Me.OpcoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.OpcoesTableAdapter = New ControleOS.DataSetXTableAdapters.OpcoesTableAdapter()
	      Me.btnFrmMedPers = New System.Windows.Forms.Button()
	      Me.Label2 = New System.Windows.Forms.Label()
	      Me.MaxDescontoPDV = New System.Windows.Forms.Label()
	      Me.txtMaxDescontoPDV = New System.Windows.Forms.TextBox()
	      Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
	      Me.TbProdutoPDVTableAdapter1 = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoPDVTableAdapter()
	      Me.gpConfigPDV = New System.Windows.Forms.GroupBox()
	      Me.gpFormaPagamento = New System.Windows.Forms.GroupBox()
	      Me.gpPlanoContas = New System.Windows.Forms.GroupBox()
	      Me.TbPlanoContaDataGridView = New System.Windows.Forms.DataGridView()
	      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TbPlanoContaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataSety = New ControleOS.DataSety()
	      Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
	      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
	      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
	      Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
	      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
	      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
	      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
	      Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
	      Me.TbPlanoContaTableAdapter = New ControleOS.DataSetyTableAdapters.tbPlanoContaTableAdapter()
	      Me.TableAdapterManager2 = New ControleOS.DataSetyTableAdapters.TableAdapterManager()
	      Me.chkShowIEalerta = New System.Windows.Forms.CheckBox()
	      Me.gpConfigIE = New System.Windows.Forms.GroupBox()
	      Me.btnFotoCol = New System.Windows.Forms.Button()
	      Me.PicUsuario = New System.Windows.Forms.PictureBox()
	      Me.ofd = New System.Windows.Forms.OpenFileDialog()
	      Me.cboTema = New System.Windows.Forms.ComboBox()
	      Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
	      CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbFormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbFormaPagamentoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.TbFormaPagamentoBindingNavigator.SuspendLayout()
	      CType(Me.dgvFormaPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.FormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.gpConfigPDV.SuspendLayout()
	      Me.gpFormaPagamento.SuspendLayout()
	      Me.gpPlanoContas.SuspendLayout()
	      CType(Me.TbPlanoContaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbPlanoContaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataSety, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.BindingNavigator3.SuspendLayout()
	      Me.gpConfigIE.SuspendLayout()
	      CType(Me.PicUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'SistemaGEDataSet
	      '
	      Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
	      Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'TbFormaPagamentoBindingSource
	      '
	      Me.TbFormaPagamentoBindingSource.DataMember = "tbFormaPagamento"
	      Me.TbFormaPagamentoBindingSource.DataSource = Me.SistemaGEDataSet
	      '
	      'TbFormaPagamentoTableAdapter
	      '
	      Me.TbFormaPagamentoTableAdapter.ClearBeforeFill = True
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
	      Me.TableAdapterManager.tbEndGesseiroTableAdapter = Nothing
	      Me.TableAdapterManager.tbEndTableAdapter = Nothing
	      Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
	      Me.TableAdapterManager.tbFilaProducaoTableAdapter = Nothing
	      Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
	      Me.TableAdapterManager.tbFormaPagamentoTableAdapter = Me.TbFormaPagamentoTableAdapter
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
	      'TbFormaPagamentoBindingNavigator
	      '
	      Me.TbFormaPagamentoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
	      Me.TbFormaPagamentoBindingNavigator.BindingSource = Me.TbFormaPagamentoBindingSource
	      Me.TbFormaPagamentoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
	      Me.TbFormaPagamentoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
	      Me.TbFormaPagamentoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
	      Me.TbFormaPagamentoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
	      Me.TbFormaPagamentoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbFormaPagamentoBindingNavigatorSaveItem})
	      Me.TbFormaPagamentoBindingNavigator.Location = New System.Drawing.Point(10, 21)
	      Me.TbFormaPagamentoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
	      Me.TbFormaPagamentoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
	      Me.TbFormaPagamentoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
	      Me.TbFormaPagamentoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
	      Me.TbFormaPagamentoBindingNavigator.Name = "TbFormaPagamentoBindingNavigator"
	      Me.TbFormaPagamentoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
	      Me.TbFormaPagamentoBindingNavigator.Size = New System.Drawing.Size(287, 27)
	      Me.TbFormaPagamentoBindingNavigator.TabIndex = 0
	      Me.TbFormaPagamentoBindingNavigator.Text = "BindingNavigator1"
	      '
	      'BindingNavigatorAddNewItem
	      '
	      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
	      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
	      '
	      'BindingNavigatorCountItem
	      '
	      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
	      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
	      Me.BindingNavigatorCountItem.Text = "de {0}"
	      Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
	      '
	      'BindingNavigatorDeleteItem
	      '
	      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
	      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorDeleteItem.Text = "Excluir"
	      '
	      'BindingNavigatorMoveFirstItem
	      '
	      Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
	      Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
	      '
	      'BindingNavigatorMovePreviousItem
	      '
	      Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
	      Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
	      '
	      'BindingNavigatorSeparator
	      '
	      Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
	      Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
	      '
	      'BindingNavigatorPositionItem
	      '
	      Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
	      Me.BindingNavigatorPositionItem.AutoSize = False
	      Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
	      Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
	      Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
	      Me.BindingNavigatorPositionItem.Text = "0"
	      Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
	      '
	      'BindingNavigatorSeparator1
	      '
	      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
	      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
	      '
	      'BindingNavigatorMoveNextItem
	      '
	      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
	      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
	      '
	      'BindingNavigatorMoveLastItem
	      '
	      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
	      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
	      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
	      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
	      Me.BindingNavigatorMoveLastItem.Text = "Mover último"
	      '
	      'BindingNavigatorSeparator2
	      '
	      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
	      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
	      '
	      'TbFormaPagamentoBindingNavigatorSaveItem
	      '
	      Me.TbFormaPagamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.TbFormaPagamentoBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbFormaPagamentoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
	      Me.TbFormaPagamentoBindingNavigatorSaveItem.Name = "TbFormaPagamentoBindingNavigatorSaveItem"
	      Me.TbFormaPagamentoBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
	      Me.TbFormaPagamentoBindingNavigatorSaveItem.Text = "Salvar Dados"
	      '
	      'dgvFormaPagamento
	      '
	      Me.dgvFormaPagamento.AutoGenerateColumns = False
	      Me.dgvFormaPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvFormaPagamento.BackgroundColor = System.Drawing.Color.White
	      Me.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvFormaPagamento.ColumnHeadersVisible = False
	      Me.dgvFormaPagamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormaPagamentoDataGridViewTextBoxColumn})
	      Me.dgvFormaPagamento.DataSource = Me.TbFormaPagamentoBindingSource
	      Me.dgvFormaPagamento.Location = New System.Drawing.Point(9, 49)
	      Me.dgvFormaPagamento.Name = "dgvFormaPagamento"
	      Me.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvFormaPagamento.Size = New System.Drawing.Size(287, 150)
	      Me.dgvFormaPagamento.TabIndex = 2
	      '
	      'FormaPagamentoDataGridViewTextBoxColumn
	      '
	      Me.FormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn.HeaderText = "Formas de Pagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn.Name = "FormaPagamentoDataGridViewTextBoxColumn"
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.Location = New System.Drawing.Point(13, 55)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(0, 13)
	      Me.Label1.TabIndex = 3
	      '
	      'btnSalvar
	      '
	      Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
	      Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnSalvar.FlatAppearance.BorderSize = 0
	      Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnSalvar.Image = Global.ControleOS.My.Resources.Resources.Voltar2
	      Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnSalvar.Location = New System.Drawing.Point(-1, 28)
	      Me.btnSalvar.Name = "btnSalvar"
	      Me.btnSalvar.Size = New System.Drawing.Size(94, 33)
	      Me.btnSalvar.TabIndex = 4
	      Me.btnSalvar.Text = "VOLTAR"
	      Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnSalvar.UseVisualStyleBackColor = False
	      '
	      'DataSetX
	      '
	      Me.DataSetX.DataSetName = "DataSetX"
	      Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'FormaPagamentoBindingSource
	      '
	      Me.FormaPagamentoBindingSource.DataMember = "FormaPagamento"
	      Me.FormaPagamentoBindingSource.DataSource = Me.DataSetX
	      '
	      'FormaPagamentoTableAdapter
	      '
	      Me.FormaPagamentoTableAdapter.ClearBeforeFill = True
	      '
	      'TableAdapterManager1
	      '
	      Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
	      Me.TableAdapterManager1.FormaPagamentoTableAdapter = Me.FormaPagamentoTableAdapter
	      Me.TableAdapterManager1.OpcoesTableAdapter = Nothing
	      Me.TableAdapterManager1.tbAdicionalPagoTableAdapter = Nothing
	      Me.TableAdapterManager1.tbCalendarioTableAdapter = Nothing
	      Me.TableAdapterManager1.tbEntregaTableAdapter = Nothing
	      Me.TableAdapterManager1.tbFinanceiroTableAdapter = Nothing
	      Me.TableAdapterManager1.tbHistoricoMedicaoTableAdapter = Nothing
	      Me.TableAdapterManager1.tbInicialPagoTableAdapter = Nothing
	      Me.TableAdapterManager1.tbLancamentosTableAdapter = Nothing
	      Me.TableAdapterManager1.tbObservacaoTableAdapter = Nothing
	      Me.TableAdapterManager1.tbOSTableAdapter = Nothing
	      Me.TableAdapterManager1.tbProdutoVendaTableAdapter = Nothing
	      Me.TableAdapterManager1.tbRelatorioVisitaTableAdapter = Nothing
	      Me.TableAdapterManager1.UpdateOrder = ControleOS.DataSetXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'TbAgendaTableAdapter
	      '
	      Me.TbAgendaTableAdapter.ClearBeforeFill = True
	      '
	      'OpcoesBindingSource
	      '
	      Me.OpcoesBindingSource.DataMember = "Opcoes"
	      Me.OpcoesBindingSource.DataSource = Me.DataSetX
	      '
	      'OpcoesTableAdapter
	      '
	      Me.OpcoesTableAdapter.ClearBeforeFill = True
	      '
	      'btnFrmMedPers
	      '
	      Me.btnFrmMedPers.Location = New System.Drawing.Point(1037, 38)
	      Me.btnFrmMedPers.Name = "btnFrmMedPers"
	      Me.btnFrmMedPers.Size = New System.Drawing.Size(75, 23)
	      Me.btnFrmMedPers.TabIndex = 8
	      Me.btnFrmMedPers.Text = "Configurar"
	      Me.btnFrmMedPers.UseVisualStyleBackColor = True
	      '
	      'Label2
	      '
	      Me.Label2.AutoSize = True
	      Me.Label2.BackColor = System.Drawing.Color.Transparent
	      Me.Label2.Location = New System.Drawing.Point(976, 70)
	      Me.Label2.Name = "Label2"
	      Me.Label2.Size = New System.Drawing.Size(155, 26)
	      Me.Label2.TabIndex = 9
	      Me.Label2.Text = "Adicionar Forma de Pagamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Personalizada"
	      '
	      'MaxDescontoPDV
	      '
	      Me.MaxDescontoPDV.AutoSize = True
	      Me.MaxDescontoPDV.Location = New System.Drawing.Point(3, 25)
	      Me.MaxDescontoPDV.Name = "MaxDescontoPDV"
	      Me.MaxDescontoPDV.Size = New System.Drawing.Size(53, 26)
	      Me.MaxDescontoPDV.TabIndex = 10
	      Me.MaxDescontoPDV.Text = "Desconto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Max. (%)"
	      '
	      'txtMaxDescontoPDV
	      '
	      Me.txtMaxDescontoPDV.Location = New System.Drawing.Point(6, 54)
	      Me.txtMaxDescontoPDV.Name = "txtMaxDescontoPDV"
	      Me.txtMaxDescontoPDV.Size = New System.Drawing.Size(72, 20)
	      Me.txtMaxDescontoPDV.TabIndex = 11
	      '
	      'TbProdutoPDVTableAdapter1
	      '
	      Me.TbProdutoPDVTableAdapter1.ClearBeforeFill = True
	      '
	      'gpConfigPDV
	      '
	      Me.gpConfigPDV.BackColor = System.Drawing.Color.Transparent
	      Me.gpConfigPDV.Controls.Add(Me.txtMaxDescontoPDV)
	      Me.gpConfigPDV.Controls.Add(Me.MaxDescontoPDV)
	      Me.gpConfigPDV.Location = New System.Drawing.Point(15, 110)
	      Me.gpConfigPDV.Name = "gpConfigPDV"
	      Me.gpConfigPDV.Size = New System.Drawing.Size(305, 17)
	      Me.gpConfigPDV.TabIndex = 12
	      Me.gpConfigPDV.TabStop = False
	      Me.gpConfigPDV.Text = "CONFIGURAÇÕES PDV"
	      '
	      'gpFormaPagamento
	      '
	      Me.gpFormaPagamento.BackColor = System.Drawing.Color.Transparent
	      Me.gpFormaPagamento.Controls.Add(Me.TbFormaPagamentoBindingNavigator)
	      Me.gpFormaPagamento.Controls.Add(Me.dgvFormaPagamento)
	      Me.gpFormaPagamento.Location = New System.Drawing.Point(15, 70)
	      Me.gpFormaPagamento.Name = "gpFormaPagamento"
	      Me.gpFormaPagamento.Size = New System.Drawing.Size(305, 17)
	      Me.gpFormaPagamento.TabIndex = 13
	      Me.gpFormaPagamento.TabStop = False
	      Me.gpFormaPagamento.Text = "FORMAS DE PAGAMENTO"
	      '
	      'gpPlanoContas
	      '
	      Me.gpPlanoContas.BackColor = System.Drawing.Color.Transparent
	      Me.gpPlanoContas.Controls.Add(Me.TbPlanoContaDataGridView)
	      Me.gpPlanoContas.Controls.Add(Me.BindingNavigator3)
	      Me.gpPlanoContas.Location = New System.Drawing.Point(15, 164)
	      Me.gpPlanoContas.Name = "gpPlanoContas"
	      Me.gpPlanoContas.Size = New System.Drawing.Size(305, 20)
	      Me.gpPlanoContas.TabIndex = 14
	      Me.gpPlanoContas.TabStop = False
	      Me.gpPlanoContas.Text = "PLANOS DE CONTA"
	      '
	      'TbPlanoContaDataGridView
	      '
	      Me.TbPlanoContaDataGridView.AutoGenerateColumns = False
	      Me.TbPlanoContaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.TbPlanoContaDataGridView.BackgroundColor = System.Drawing.Color.White
	      Me.TbPlanoContaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.TbPlanoContaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
	      Me.TbPlanoContaDataGridView.DataSource = Me.TbPlanoContaBindingSource
	      Me.TbPlanoContaDataGridView.Location = New System.Drawing.Point(9, 45)
	      Me.TbPlanoContaDataGridView.Name = "TbPlanoContaDataGridView"
	      Me.TbPlanoContaDataGridView.Size = New System.Drawing.Size(287, 122)
	      Me.TbPlanoContaDataGridView.TabIndex = 14
	      '
	      'DataGridViewTextBoxColumn3
	      '
	      Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome"
	      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	      Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
	      Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIÇÃO"
	      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
	      '
	      'TbPlanoContaBindingSource
	      '
	      Me.TbPlanoContaBindingSource.DataMember = "tbPlanoConta"
	      Me.TbPlanoContaBindingSource.DataSource = Me.DataSety
	      '
	      'DataSety
	      '
	      Me.DataSety.DataSetName = "DataSety"
	      Me.DataSety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'BindingNavigator3
	      '
	      Me.BindingNavigator3.AddNewItem = Me.ToolStripButton1
	      Me.BindingNavigator3.BindingSource = Me.TbPlanoContaBindingSource
	      Me.BindingNavigator3.CountItem = Me.ToolStripLabel1
	      Me.BindingNavigator3.DeleteItem = Me.ToolStripButton2
	      Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.None
	      Me.BindingNavigator3.ImageScalingSize = New System.Drawing.Size(20, 20)
	      Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
	      Me.BindingNavigator3.Location = New System.Drawing.Point(10, 19)
	      Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton3
	      Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton6
	      Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton5
	      Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton4
	      Me.BindingNavigator3.Name = "BindingNavigator3"
	      Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox1
	      Me.BindingNavigator3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
	      Me.BindingNavigator3.Size = New System.Drawing.Size(287, 27)
	      Me.BindingNavigator3.TabIndex = 15
	      Me.BindingNavigator3.Text = "BindingNavigator3"
	      '
	      'ToolStripButton1
	      '
	      Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
	      Me.ToolStripButton1.Name = "ToolStripButton1"
	      Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton1.Text = "Adicionar novo"
	      '
	      'ToolStripLabel1
	      '
	      Me.ToolStripLabel1.Name = "ToolStripLabel1"
	      Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 24)
	      Me.ToolStripLabel1.Text = "de {0}"
	      Me.ToolStripLabel1.ToolTipText = "Número total de itens"
	      '
	      'ToolStripButton2
	      '
	      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
	      Me.ToolStripButton2.Name = "ToolStripButton2"
	      Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton2.Text = "Excluir"
	      '
	      'ToolStripButton3
	      '
	      Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
	      Me.ToolStripButton3.Name = "ToolStripButton3"
	      Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton3.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton3.Text = "Mover primeiro"
	      '
	      'ToolStripButton4
	      '
	      Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
	      Me.ToolStripButton4.Name = "ToolStripButton4"
	      Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton4.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton4.Text = "Mover anterior"
	      '
	      'ToolStripSeparator1
	      '
	      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
	      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
	      '
	      'ToolStripTextBox1
	      '
	      Me.ToolStripTextBox1.AccessibleName = "Posição"
	      Me.ToolStripTextBox1.AutoSize = False
	      Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
	      Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
	      Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
	      Me.ToolStripTextBox1.Text = "0"
	      Me.ToolStripTextBox1.ToolTipText = "Posição atual"
	      '
	      'ToolStripSeparator2
	      '
	      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
	      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
	      '
	      'ToolStripButton5
	      '
	      Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
	      Me.ToolStripButton5.Name = "ToolStripButton5"
	      Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton5.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton5.Text = "Mover próximo"
	      '
	      'ToolStripButton6
	      '
	      Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
	      Me.ToolStripButton6.Name = "ToolStripButton6"
	      Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
	      Me.ToolStripButton6.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton6.Text = "Mover último"
	      '
	      'ToolStripSeparator3
	      '
	      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
	      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
	      '
	      'ToolStripButton7
	      '
	      Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
	      Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
	      Me.ToolStripButton7.Name = "ToolStripButton7"
	      Me.ToolStripButton7.Size = New System.Drawing.Size(24, 24)
	      Me.ToolStripButton7.Text = "&Salvar"
	      '
	      'TbPlanoContaTableAdapter
	      '
	      Me.TbPlanoContaTableAdapter.ClearBeforeFill = True
	      '
	      'TableAdapterManager2
	      '
	      Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
	      Me.TableAdapterManager2.tbFormaPagamentoTableAdapter = Nothing
	      Me.TableAdapterManager2.tbHistoricoCaixaTableAdapter = Nothing
	      Me.TableAdapterManager2.tbOSTableAdapter = Nothing
	      Me.TableAdapterManager2.tbPlanoContaTableAdapter = Me.TbPlanoContaTableAdapter
	      Me.TableAdapterManager2.tbProdutoVendaTableAdapter = Nothing
	      Me.TableAdapterManager2.UpdateOrder = ControleOS.DataSetyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'chkShowIEalerta
	      '
	      Me.chkShowIEalerta.AutoSize = True
	      Me.chkShowIEalerta.BackColor = System.Drawing.Color.Transparent
	      Me.chkShowIEalerta.Checked = True
	      Me.chkShowIEalerta.CheckState = System.Windows.Forms.CheckState.Checked
	      Me.chkShowIEalerta.Location = New System.Drawing.Point(18, 29)
	      Me.chkShowIEalerta.Name = "chkShowIEalerta"
	      Me.chkShowIEalerta.Size = New System.Drawing.Size(135, 17)
	      Me.chkShowIEalerta.TabIndex = 15
	      Me.chkShowIEalerta.Text = "Exibir Alerta IE ausente"
	      Me.chkShowIEalerta.UseVisualStyleBackColor = False
	      '
	      'gpConfigIE
	      '
	      Me.gpConfigIE.BackColor = System.Drawing.Color.Transparent
	      Me.gpConfigIE.Controls.Add(Me.chkShowIEalerta)
	      Me.gpConfigIE.Location = New System.Drawing.Point(355, 70)
	      Me.gpConfigIE.Name = "gpConfigIE"
	      Me.gpConfigIE.Size = New System.Drawing.Size(378, 91)
	      Me.gpConfigIE.TabIndex = 16
	      Me.gpConfigIE.TabStop = False
	      Me.gpConfigIE.Text = "CONFIGURAÇÕES PDV"
	      '
	      'btnFotoCol
	      '
	      Me.btnFotoCol.Location = New System.Drawing.Point(856, 184)
	      Me.btnFotoCol.Name = "btnFotoCol"
	      Me.btnFotoCol.Size = New System.Drawing.Size(100, 42)
	      Me.btnFotoCol.TabIndex = 17
	      Me.btnFotoCol.Text = " "
	      Me.btnFotoCol.UseVisualStyleBackColor = True
	      '
	      'PicUsuario
	      '
	      Me.PicUsuario.BackColor = System.Drawing.Color.White
	      Me.PicUsuario.Location = New System.Drawing.Point(856, 70)
	      Me.PicUsuario.Name = "PicUsuario"
	      Me.PicUsuario.Size = New System.Drawing.Size(100, 108)
	      Me.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
	      Me.PicUsuario.TabIndex = 18
	      Me.PicUsuario.TabStop = False
	      '
	      'ofd
	      '
	      Me.ofd.FileName = "OpenFileDialog1"
	      '
	      'cboTema
	      '
	      Me.cboTema.Cursor = System.Windows.Forms.Cursors.Hand
	      Me.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
	      Me.cboTema.FormattingEnabled = True
	      Me.cboTema.Items.AddRange(New Object() {"Light", "Dark"})
	      Me.cboTema.Location = New System.Drawing.Point(355, 213)
	      Me.cboTema.Name = "cboTema"
	      Me.cboTema.Size = New System.Drawing.Size(121, 21)
	      Me.cboTema.TabIndex = 45
	      '
	      'MaterialLabel1
	      '
	      Me.MaterialLabel1.AutoSize = True
	      Me.MaterialLabel1.BackColor = System.Drawing.Color.White
	      Me.MaterialLabel1.Depth = 0
	      Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.MaterialLabel1.Location = New System.Drawing.Point(352, 191)
	      Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
	      Me.MaterialLabel1.Name = "MaterialLabel1"
	      Me.MaterialLabel1.Size = New System.Drawing.Size(96, 19)
	      Me.MaterialLabel1.TabIndex = 46
	      Me.MaterialLabel1.Text = "Estilo de Cor"
	      '
	      'FrmConfiguracao
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.AutoScroll = True
	      Me.BackColor = System.Drawing.Color.LightYellow
	      Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.BackGround_Azul_Gradiente
	      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.ClientSize = New System.Drawing.Size(1132, 747)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.MaterialLabel1)
	      Me.Controls.Add(Me.cboTema)
	      Me.Controls.Add(Me.PicUsuario)
	      Me.Controls.Add(Me.btnFotoCol)
	      Me.Controls.Add(Me.gpConfigIE)
	      Me.Controls.Add(Me.gpPlanoContas)
	      Me.Controls.Add(Me.gpFormaPagamento)
	      Me.Controls.Add(Me.gpConfigPDV)
	      Me.Controls.Add(Me.Label2)
	      Me.Controls.Add(Me.btnFrmMedPers)
	      Me.Controls.Add(Me.btnSalvar)
	      Me.Controls.Add(Me.Label1)
	      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
	      Me.Name = "FrmConfiguracao"
	      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	      Me.Text = " "
	      Me.TransparencyKey = System.Drawing.Color.Transparent
	      CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbFormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbFormaPagamentoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.TbFormaPagamentoBindingNavigator.ResumeLayout(False)
	      Me.TbFormaPagamentoBindingNavigator.PerformLayout()
	      CType(Me.dgvFormaPagamento, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.FormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.gpConfigPDV.ResumeLayout(False)
	      Me.gpConfigPDV.PerformLayout()
	      Me.gpFormaPagamento.ResumeLayout(False)
	      Me.gpFormaPagamento.PerformLayout()
	      Me.gpPlanoContas.ResumeLayout(False)
	      Me.gpPlanoContas.PerformLayout()
	      CType(Me.TbPlanoContaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbPlanoContaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataSety, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.BindingNavigator3.ResumeLayout(False)
	      Me.BindingNavigator3.PerformLayout()
	      Me.gpConfigIE.ResumeLayout(False)
	      Me.gpConfigIE.PerformLayout()
	      CType(Me.PicUsuario, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)
	      Me.PerformLayout()

        End Sub

        Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbFormaPagamentoBindingSource As BindingSource
    Friend WithEvents TbFormaPagamentoTableAdapter As SistemaGEDataSetTableAdapters.tbFormaPagamentoTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbFormaPagamentoBindingNavigator As BindingNavigator
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
    Friend WithEvents TbFormaPagamentoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents dgvFormaPagamento As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents FormaPagamentoBindingSource As BindingSource
    Friend WithEvents FormaPagamentoTableAdapter As DataSetXTableAdapters.FormaPagamentoTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetXTableAdapters.TableAdapterManager
    Friend WithEvents FormaPagamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbAgendaTableAdapter As SistemaGEDataSetTableAdapters.tbAgendaTableAdapter
    Friend WithEvents OpcoesBindingSource As BindingSource
    Friend WithEvents OpcoesTableAdapter As DataSetXTableAdapters.OpcoesTableAdapter
    Friend WithEvents btnFrmMedPers As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MaxDescontoPDV As Label
    Friend WithEvents txtMaxDescontoPDV As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TbProdutoPDVTableAdapter1 As SistemaGEDataSetTableAdapters.tbProdutoPDVTableAdapter
    Friend WithEvents gpConfigPDV As GroupBox
    Friend WithEvents gpFormaPagamento As GroupBox
    Friend WithEvents gpPlanoContas As GroupBox
    Friend WithEvents DataSety As DataSety
    Friend WithEvents TbPlanoContaBindingSource As BindingSource
    Friend WithEvents TbPlanoContaTableAdapter As DataSetyTableAdapters.tbPlanoContaTableAdapter
    Friend WithEvents TableAdapterManager2 As DataSetyTableAdapters.TableAdapterManager
    Friend WithEvents TbPlanoContaDataGridView As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents chkShowIEalerta As CheckBox
    Friend WithEvents gpConfigIE As GroupBox
    Friend WithEvents btnFotoCol As Button
    Friend WithEvents PicUsuario As PictureBox
    Friend WithEvents ofd As OpenFileDialog
	Friend WithEvents cboTema As ComboBox
	Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
