<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
	      Dim Label11 As System.Windows.Forms.Label
	      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
	      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Me.TbProdutoVenda1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
	      Me.TbProdutoVenda1TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter()
	      Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
	      Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
	      Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
	      Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
	      Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
	      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
	      Me.ORÇAMENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CRIARNOVAOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.MEDIÇÕESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.INSERIRAGENDAMENTODEVISITAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.FINANCEIROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.LANÇAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.PAGAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.LIBERAÇÃOEMLOTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.PAGAMENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.VENDASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.PDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.VENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.RELATÓRIODEVENDASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CADASTROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.LISTADECLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.RELATÓRIOSDECLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.OPÇÕESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CONFIGURARAÇÃOBASICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CONFIGURAÇÕESAVANÇADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.PRODUTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.ESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.RELATÓRIOENTSAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.FILADEPRODUÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CALENDARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.AGENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.LEMBRETERAPIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.FERRAMENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.CONSULTACNPJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
	      Me.btnVisita = New System.Windows.Forms.ToolStripMenuItem()
	      Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	      Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
	      Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
	      Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
	      Me.lblPesquisaFilaProducao = New System.Windows.Forms.Label()
	      Me.Label2 = New System.Windows.Forms.Label()
	      Me.Label8 = New System.Windows.Forms.Label()
	      Me.Label7 = New System.Windows.Forms.Label()
	      Me.Label6 = New System.Windows.Forms.Label()
	      Me.Label5 = New System.Windows.Forms.Label()
	      Me.Label4 = New System.Windows.Forms.Label()
	      Me.Label3 = New System.Windows.Forms.Label()
	      Me.lblSaldoCritico = New System.Windows.Forms.Label()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.lblQuantClientes = New System.Windows.Forms.Label()
	      Me.tmAtualizarRelatorio = New System.Windows.Forms.Timer(Me.components)
	      Me.atividadeSegundoPlano = New System.ComponentModel.BackgroundWorker()
	      Me.tmAtualizar = New System.Windows.Forms.Timer(Me.components)
	      Me.hora = New System.Windows.Forms.Timer(Me.components)
	      Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
	      Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
	      Me.pnDockPrincipal = New System.Windows.Forms.Panel()
	      Me.btnNavegador = New System.Windows.Forms.Button()
	      Me.btnFinanceiro = New System.Windows.Forms.Button()
	      Me.btnAbrirPDV = New System.Windows.Forms.Button()
	      Me.btnOrcamento = New System.Windows.Forms.Button()
	      Me.Button1 = New System.Windows.Forms.Button()
	      Me.Panel3 = New System.Windows.Forms.Panel()
	      Me.PictureBox7 = New System.Windows.Forms.PictureBox()
	      Me.Panel4 = New System.Windows.Forms.Panel()
	      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
	      Me.Panel5 = New System.Windows.Forms.Panel()
	      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
	      Me.Panel2 = New System.Windows.Forms.Panel()
	      Me.PictureBox5 = New System.Windows.Forms.PictureBox()
	      Me.Panel6 = New System.Windows.Forms.Panel()
	      Me.PictureBox6 = New System.Windows.Forms.PictureBox()
	      Me.tmMinDock = New System.Windows.Forms.Timer(Me.components)
	      Me.Panel1 = New System.Windows.Forms.Panel()
	      Me.PictureBox12 = New System.Windows.Forms.PictureBox()
	      Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
	      Me.dgvEntrega = New System.Windows.Forms.DataGridView()
	      Me.PictureBox8 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
	      Me.pctSair = New System.Windows.Forms.PictureBox()
	      Me.PicColaborador = New System.Windows.Forms.PictureBox()
	      Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
	      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox9 = New System.Windows.Forms.PictureBox()
	      Me.lblHora = New MaterialSkin.Controls.MaterialLabel()
	      Me.lblData = New MaterialSkin.Controls.MaterialLabel()
	      Me.lblNomeUsuario = New MaterialSkin.Controls.MaterialLabel()
	      Me.lblCargo = New MaterialSkin.Controls.MaterialLabel()
	      Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
	      Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
	      Me.btnLogout = New MaterialSkin.Controls.MaterialFlatButton()
	      Me.btnVisitas = New System.Windows.Forms.Button()
	      Me.Button2 = New System.Windows.Forms.Button()
	      Label11 = New System.Windows.Forms.Label()
	      CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.MenuStrip1.SuspendLayout()
	      Me.pnDockPrincipal.SuspendLayout()
	      Me.Panel3.SuspendLayout()
	      CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel4.SuspendLayout()
	      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel5.SuspendLayout()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel2.SuspendLayout()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel6.SuspendLayout()
	      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel1.SuspendLayout()
	      CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.pctSair, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PicColaborador, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'Label11
	      '
	      Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Label11.AutoSize = True
	      Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
	      Label11.Location = New System.Drawing.Point(-770, 301)
	      Label11.Name = "Label11"
	      Label11.Size = New System.Drawing.Size(43, 26)
	      Label11.TabIndex = 43
	      Label11.Text = "Trocar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuário"
	      '
	      'TbProdutoVenda1BindingSource
	      '
	      Me.TbProdutoVenda1BindingSource.DataMember = "tbProdutoVenda1"
	      Me.TbProdutoVenda1BindingSource.DataSource = Me.SistemaGEDataSet
	      '
	      'SistemaGEDataSet
	      '
	      Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
	      Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'TbProdutoVenda1TableAdapter
	      '
	      Me.TbProdutoVenda1TableAdapter.ClearBeforeFill = True
	      '
	      'TbOSBindingSource
	      '
	      Me.TbOSBindingSource.DataMember = "tbOS"
	      Me.TbOSBindingSource.DataSource = Me.SistemaGEDataSet
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
	      Me.TableAdapterManager.tbOSTableAdapter = Me.TbOSTableAdapter
	      Me.TableAdapterManager.tbPagamentosRealizadosTableAdapter = Nothing
	      Me.TableAdapterManager.tbPagamentosTableAdapter = Nothing
	      Me.TableAdapterManager.tbPlanoContaTableAdapter = Nothing
	      Me.TableAdapterManager.tbPlanoDespesasTableAdapter = Nothing
	      Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutoPDVTableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutos2TableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutoVenda1TableAdapter = Me.TbProdutoVenda1TableAdapter
	      Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
	      Me.TableAdapterManager.tbTipoPagamentoTableAdapter = Nothing
	      Me.TableAdapterManager.UpdateOrder = ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'ContextMenuStrip1
	      '
	      Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
	      Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
	      Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
	      '
	      'BottomToolStripPanel
	      '
	      Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
	      Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
	      Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
	      Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
	      Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
	      '
	      'TopToolStripPanel
	      '
	      Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
	      Me.TopToolStripPanel.Name = "TopToolStripPanel"
	      Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
	      Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
	      Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
	      '
	      'MenuStrip1
	      '
	      Me.MenuStrip1.BackColor = System.Drawing.Color.Black
	      Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
	      Me.MenuStrip1.Enabled = False
	      Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
	      Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
	      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORÇAMENTOToolStripMenuItem, Me.FINANCEIROToolStripMenuItem, Me.VENDASToolStripMenuItem, Me.CADASTROSToolStripMenuItem, Me.OPÇÕESToolStripMenuItem, Me.PRODUTOSToolStripMenuItem, Me.FILADEPRODUÇÃOToolStripMenuItem, Me.CALENDARIOToolStripMenuItem, Me.FERRAMENTASToolStripMenuItem, Me.ToolStripMenuItem1})
	      Me.MenuStrip1.Location = New System.Drawing.Point(151, 475)
	      Me.MenuStrip1.Name = "MenuStrip1"
	      Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
	      Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
	      Me.MenuStrip1.TabIndex = 40
	      Me.MenuStrip1.Text = "MenuStrip1"
	      Me.MenuStrip1.Visible = False
	      '
	      'ORÇAMENTOToolStripMenuItem
	      '
	      Me.ORÇAMENTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRIARNOVAOSToolStripMenuItem, Me.MEDIÇÕESToolStripMenuItem, Me.INSERIRAGENDAMENTODEVISITAToolStripMenuItem})
	      Me.ORÇAMENTOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.ORÇAMENTOToolStripMenuItem.Name = "ORÇAMENTOToolStripMenuItem"
	      Me.ORÇAMENTOToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
	      Me.ORÇAMENTOToolStripMenuItem.Text = "ORÇAMENTO"
	      '
	      'CRIARNOVAOSToolStripMenuItem
	      '
	      Me.CRIARNOVAOSToolStripMenuItem.Name = "CRIARNOVAOSToolStripMenuItem"
	      Me.CRIARNOVAOSToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
	      Me.CRIARNOVAOSToolStripMenuItem.Text = "CRIAR/CARREAGAR OS"
	      '
	      'MEDIÇÕESToolStripMenuItem
	      '
	      Me.MEDIÇÕESToolStripMenuItem.Name = "MEDIÇÕESToolStripMenuItem"
	      Me.MEDIÇÕESToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
	      Me.MEDIÇÕESToolStripMenuItem.Text = "MEDIÇÕES"
	      '
	      'INSERIRAGENDAMENTODEVISITAToolStripMenuItem
	      '
	      Me.INSERIRAGENDAMENTODEVISITAToolStripMenuItem.Name = "INSERIRAGENDAMENTODEVISITAToolStripMenuItem"
	      Me.INSERIRAGENDAMENTODEVISITAToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
	      Me.INSERIRAGENDAMENTODEVISITAToolStripMenuItem.Text = "INSERIR AGENDAMENTO DE VISITA"
	      '
	      'FINANCEIROToolStripMenuItem
	      '
	      Me.FINANCEIROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LANÇAMENTOSToolStripMenuItem, Me.PAGAMENTOSToolStripMenuItem})
	      Me.FINANCEIROToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.FINANCEIROToolStripMenuItem.Name = "FINANCEIROToolStripMenuItem"
	      Me.FINANCEIROToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
	      Me.FINANCEIROToolStripMenuItem.Text = "FINANCEIRO"
	      '
	      'LANÇAMENTOSToolStripMenuItem
	      '
	      Me.LANÇAMENTOSToolStripMenuItem.Name = "LANÇAMENTOSToolStripMenuItem"
	      Me.LANÇAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
	      Me.LANÇAMENTOSToolStripMenuItem.Text = "LANÇAMENTOS"
	      '
	      'PAGAMENTOSToolStripMenuItem
	      '
	      Me.PAGAMENTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIBERAÇÃOEMLOTEToolStripMenuItem, Me.PAGAMENTOToolStripMenuItem})
	      Me.PAGAMENTOSToolStripMenuItem.Name = "PAGAMENTOSToolStripMenuItem"
	      Me.PAGAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
	      Me.PAGAMENTOSToolStripMenuItem.Text = "PAGAMENTOS"
	      '
	      'LIBERAÇÃOEMLOTEToolStripMenuItem
	      '
	      Me.LIBERAÇÃOEMLOTEToolStripMenuItem.Name = "LIBERAÇÃOEMLOTEToolStripMenuItem"
	      Me.LIBERAÇÃOEMLOTEToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
	      Me.LIBERAÇÃOEMLOTEToolStripMenuItem.Text = "LIBERAÇÃO EM LOTE"
	      '
	      'PAGAMENTOToolStripMenuItem
	      '
	      Me.PAGAMENTOToolStripMenuItem.Name = "PAGAMENTOToolStripMenuItem"
	      Me.PAGAMENTOToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
	      Me.PAGAMENTOToolStripMenuItem.Text = "PAGAMENTO"
	      '
	      'VENDASToolStripMenuItem
	      '
	      Me.VENDASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDVToolStripMenuItem})
	      Me.VENDASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.VENDASToolStripMenuItem.Name = "VENDASToolStripMenuItem"
	      Me.VENDASToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
	      Me.VENDASToolStripMenuItem.Text = "VENDAS"
	      '
	      'PDVToolStripMenuItem
	      '
	      Me.PDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VENDAToolStripMenuItem, Me.RELATÓRIODEVENDASToolStripMenuItem})
	      Me.PDVToolStripMenuItem.Name = "PDVToolStripMenuItem"
	      Me.PDVToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
	      Me.PDVToolStripMenuItem.Text = "PDV"
	      '
	      'VENDAToolStripMenuItem
	      '
	      Me.VENDAToolStripMenuItem.Name = "VENDAToolStripMenuItem"
	      Me.VENDAToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
	      Me.VENDAToolStripMenuItem.Text = "VENDA"
	      '
	      'RELATÓRIODEVENDASToolStripMenuItem
	      '
	      Me.RELATÓRIODEVENDASToolStripMenuItem.Name = "RELATÓRIODEVENDASToolStripMenuItem"
	      Me.RELATÓRIODEVENDASToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
	      Me.RELATÓRIODEVENDASToolStripMenuItem.Text = "RELATÓRIO DE VENDAS"
	      '
	      'CADASTROSToolStripMenuItem
	      '
	      Me.CADASTROSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTESToolStripMenuItem})
	      Me.CADASTROSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.CADASTROSToolStripMenuItem.Name = "CADASTROSToolStripMenuItem"
	      Me.CADASTROSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
	      Me.CADASTROSToolStripMenuItem.Text = "CADASTROS"
	      '
	      'CLIENTESToolStripMenuItem
	      '
	      Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LISTADECLIENTESToolStripMenuItem, Me.RELATÓRIOSDECLIENTESToolStripMenuItem})
	      Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
	      Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
	      Me.CLIENTESToolStripMenuItem.Text = "PESSOAS"
	      '
	      'LISTADECLIENTESToolStripMenuItem
	      '
	      Me.LISTADECLIENTESToolStripMenuItem.Name = "LISTADECLIENTESToolStripMenuItem"
	      Me.LISTADECLIENTESToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
	      Me.LISTADECLIENTESToolStripMenuItem.Text = "LISTA DE PESSOAS"
	      '
	      'RELATÓRIOSDECLIENTESToolStripMenuItem
	      '
	      Me.RELATÓRIOSDECLIENTESToolStripMenuItem.Name = "RELATÓRIOSDECLIENTESToolStripMenuItem"
	      Me.RELATÓRIOSDECLIENTESToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
	      Me.RELATÓRIOSDECLIENTESToolStripMenuItem.Text = "RELATÓRIOS DE CLIENTES"
	      '
	      'OPÇÕESToolStripMenuItem
	      '
	      Me.OPÇÕESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONFIGURARAÇÃOBASICAToolStripMenuItem, Me.CONFIGURAÇÕESAVANÇADASToolStripMenuItem})
	      Me.OPÇÕESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.OPÇÕESToolStripMenuItem.Name = "OPÇÕESToolStripMenuItem"
	      Me.OPÇÕESToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
	      Me.OPÇÕESToolStripMenuItem.Text = "OPÇÕES"
	      '
	      'CONFIGURARAÇÃOBASICAToolStripMenuItem
	      '
	      Me.CONFIGURARAÇÃOBASICAToolStripMenuItem.Name = "CONFIGURARAÇÃOBASICAToolStripMenuItem"
	      Me.CONFIGURARAÇÃOBASICAToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
	      Me.CONFIGURARAÇÃOBASICAToolStripMenuItem.Text = "CONFIGURAÇÕES BASICAS"
	      '
	      'CONFIGURAÇÕESAVANÇADASToolStripMenuItem
	      '
	      Me.CONFIGURAÇÕESAVANÇADASToolStripMenuItem.Name = "CONFIGURAÇÕESAVANÇADASToolStripMenuItem"
	      Me.CONFIGURAÇÕESAVANÇADASToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
	      Me.CONFIGURAÇÕESAVANÇADASToolStripMenuItem.Text = "CONFIGURAÇÕES AVANÇADAS"
	      '
	      'PRODUTOSToolStripMenuItem
	      '
	      Me.PRODUTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTOQUEToolStripMenuItem, Me.RELATÓRIOENTSAIToolStripMenuItem})
	      Me.PRODUTOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.PRODUTOSToolStripMenuItem.Name = "PRODUTOSToolStripMenuItem"
	      Me.PRODUTOSToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
	      Me.PRODUTOSToolStripMenuItem.Text = "PRODUTOS"
	      '
	      'ESTOQUEToolStripMenuItem
	      '
	      Me.ESTOQUEToolStripMenuItem.Name = "ESTOQUEToolStripMenuItem"
	      Me.ESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
	      Me.ESTOQUEToolStripMenuItem.Text = "ESTOQUE"
	      '
	      'RELATÓRIOENTSAIToolStripMenuItem
	      '
	      Me.RELATÓRIOENTSAIToolStripMenuItem.Name = "RELATÓRIOENTSAIToolStripMenuItem"
	      Me.RELATÓRIOENTSAIToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
	      Me.RELATÓRIOENTSAIToolStripMenuItem.Text = "RELATÓRIO ENT./SAI."
	      '
	      'FILADEPRODUÇÃOToolStripMenuItem
	      '
	      Me.FILADEPRODUÇÃOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.FILADEPRODUÇÃOToolStripMenuItem.Name = "FILADEPRODUÇÃOToolStripMenuItem"
	      Me.FILADEPRODUÇÃOToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
	      Me.FILADEPRODUÇÃOToolStripMenuItem.Text = "FILA DE PRODUÇÃO"
	      '
	      'CALENDARIOToolStripMenuItem
	      '
	      Me.CALENDARIOToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
	      Me.CALENDARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGENDAToolStripMenuItem, Me.LEMBRETERAPIDOToolStripMenuItem})
	      Me.CALENDARIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.CALENDARIOToolStripMenuItem.Name = "CALENDARIOToolStripMenuItem"
	      Me.CALENDARIOToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
	      Me.CALENDARIOToolStripMenuItem.Text = "HORARIOS"
	      '
	      'AGENDAToolStripMenuItem
	      '
	      Me.AGENDAToolStripMenuItem.Name = "AGENDAToolStripMenuItem"
	      Me.AGENDAToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
	      Me.AGENDAToolStripMenuItem.Text = "AGENDA"
	      '
	      'LEMBRETERAPIDOToolStripMenuItem
	      '
	      Me.LEMBRETERAPIDOToolStripMenuItem.Name = "LEMBRETERAPIDOToolStripMenuItem"
	      Me.LEMBRETERAPIDOToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
	      Me.LEMBRETERAPIDOToolStripMenuItem.Text = "+ LEMBRETE RAPIDO"
	      '
	      'FERRAMENTASToolStripMenuItem
	      '
	      Me.FERRAMENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTACNPJToolStripMenuItem, Me.btnVisita})
	      Me.FERRAMENTASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
	      Me.FERRAMENTASToolStripMenuItem.Name = "FERRAMENTASToolStripMenuItem"
	      Me.FERRAMENTASToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
	      Me.FERRAMENTASToolStripMenuItem.Text = "FERRAMENTAS"
	      '
	      'CONSULTACNPJToolStripMenuItem
	      '
	      Me.CONSULTACNPJToolStripMenuItem.Name = "CONSULTACNPJToolStripMenuItem"
	      Me.CONSULTACNPJToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
	      Me.CONSULTACNPJToolStripMenuItem.Text = "CONSULTA CNPJ"
	      '
	      'btnVisita
	      '

	      '
	      'ToolStripMenuItem1
	      '
	      Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
	      Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
	      '
	      'RightToolStripPanel
	      '
	      Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
	      Me.RightToolStripPanel.Name = "RightToolStripPanel"
	      Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
	      Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
	      Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
	      '
	      'LeftToolStripPanel
	      '
	      Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
	      Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
	      Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
	      Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
	      Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
	      '
	      'ContentPanel
	      '
	      Me.ContentPanel.AutoScroll = True
	      Me.ContentPanel.Size = New System.Drawing.Size(1068, 614)
	      '
	      'lblPesquisaFilaProducao
	      '
	      Me.lblPesquisaFilaProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
	      Me.lblPesquisaFilaProducao.AutoSize = True
	      Me.lblPesquisaFilaProducao.Location = New System.Drawing.Point(649, 161)
	      Me.lblPesquisaFilaProducao.Name = "lblPesquisaFilaProducao"
	      Me.lblPesquisaFilaProducao.Size = New System.Drawing.Size(0, 13)
	      Me.lblPesquisaFilaProducao.TabIndex = 21
	      '
	      'Label2
	      '
	      Me.Label2.AutoSize = True
	      Me.Label2.BackColor = System.Drawing.Color.Transparent
	      Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label2.ForeColor = System.Drawing.Color.Black
	      Me.Label2.Location = New System.Drawing.Point(158, 5)
	      Me.Label2.Name = "Label2"
	      Me.Label2.Size = New System.Drawing.Size(245, 22)
	      Me.Label2.TabIndex = 2
	      Me.Label2.Text = "Movimentações Financeiras"
	      '
	      'Label8
	      '
	      Me.Label8.AutoSize = True
	      Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label8.ForeColor = System.Drawing.Color.Black
	      Me.Label8.Location = New System.Drawing.Point(36, 8)
	      Me.Label8.Name = "Label8"
	      Me.Label8.Size = New System.Drawing.Size(206, 19)
	      Me.Label8.TabIndex = 4
	      Me.Label8.Text = "Resumo Geral do Sistema"
	      '
	      'Label7
	      '
	      Me.Label7.AutoSize = True
	      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label7.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label7.Location = New System.Drawing.Point(11, 40)
	      Me.Label7.Name = "Label7"
	      Me.Label7.Size = New System.Drawing.Size(126, 16)
	      Me.Label7.TabIndex = 6
	      Me.Label7.Text = "Faturamento do Dia"
	      '
	      'Label6
	      '
	      Me.Label6.AutoSize = True
	      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label6.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label6.Location = New System.Drawing.Point(3, 9)
	      Me.Label6.Name = "Label6"
	      Me.Label6.Size = New System.Drawing.Size(129, 25)
	      Me.Label6.TabIndex = 6
	      Me.Label6.Text = "R$ 0.000,00"
	      '
	      'Label5
	      '
	      Me.Label5.AutoSize = True
	      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label5.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label5.Location = New System.Drawing.Point(3, 9)
	      Me.Label5.Name = "Label5"
	      Me.Label5.Size = New System.Drawing.Size(129, 25)
	      Me.Label5.TabIndex = 5
	      Me.Label5.Text = "R$ 0.000,00"
	      '
	      'Label4
	      '
	      Me.Label4.AutoSize = True
	      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label4.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label4.Location = New System.Drawing.Point(5, 40)
	      Me.Label4.Name = "Label4"
	      Me.Label4.Size = New System.Drawing.Size(131, 32)
	      Me.Label4.TabIndex = 5
	      Me.Label4.Text = "Faturamento do Mês" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atual"
	      '
	      'Label3
	      '
	      Me.Label3.AutoSize = True
	      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label3.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label3.Location = New System.Drawing.Point(3, 42)
	      Me.Label3.Name = "Label3"
	      Me.Label3.Size = New System.Drawing.Size(144, 32)
	      Me.Label3.TabIndex = 4
	      Me.Label3.Text = "Produtos com Estoque" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Baixo"
	      '
	      'lblSaldoCritico
	      '
	      Me.lblSaldoCritico.AutoSize = True
	      Me.lblSaldoCritico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblSaldoCritico.ForeColor = System.Drawing.Color.DarkGray
	      Me.lblSaldoCritico.Location = New System.Drawing.Point(5, 5)
	      Me.lblSaldoCritico.Name = "lblSaldoCritico"
	      Me.lblSaldoCritico.Size = New System.Drawing.Size(24, 25)
	      Me.lblSaldoCritico.TabIndex = 4
	      Me.lblSaldoCritico.Text = "0"
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.BackColor = System.Drawing.Color.Transparent
	      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label1.ForeColor = System.Drawing.Color.DarkGray
	      Me.Label1.Location = New System.Drawing.Point(19, 51)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(109, 16)
	      Me.Label1.TabIndex = 3
	      Me.Label1.Text = "Total de Clientes"
	      '
	      'lblQuantClientes
	      '
	      Me.lblQuantClientes.AutoSize = True
	      Me.lblQuantClientes.BackColor = System.Drawing.Color.Transparent
	      Me.lblQuantClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblQuantClientes.ForeColor = System.Drawing.Color.DarkGray
	      Me.lblQuantClientes.Location = New System.Drawing.Point(6, 4)
	      Me.lblQuantClientes.Name = "lblQuantClientes"
	      Me.lblQuantClientes.Size = New System.Drawing.Size(24, 25)
	      Me.lblQuantClientes.TabIndex = 2
	      Me.lblQuantClientes.Text = "0"
	      Me.lblQuantClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'tmAtualizarRelatorio
	      '
	      Me.tmAtualizarRelatorio.Enabled = True
	      Me.tmAtualizarRelatorio.Interval = 5000
	      '
	      'atividadeSegundoPlano
	      '
	      Me.atividadeSegundoPlano.WorkerReportsProgress = True
	      Me.atividadeSegundoPlano.WorkerSupportsCancellation = True
	      '
	      'tmAtualizar
	      '
	      Me.tmAtualizar.Interval = 5000
	      '
	      'hora
	      '
	      Me.hora.Enabled = True
	      Me.hora.Interval = 1000
	      '
	      'ContextMenuStrip2
	      '
	      Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
	      Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
	      '
	      'ContextMenuStrip3
	      '
	      Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
	      Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
	      '
	      'pnDockPrincipal
	      '
	      Me.pnDockPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
		      Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
	      Me.pnDockPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.pnDockPrincipal.Controls.Add(Me.btnNavegador)
	      Me.pnDockPrincipal.Controls.Add(Me.btnFinanceiro)
	      Me.pnDockPrincipal.Controls.Add(Me.btnAbrirPDV)
	      Me.pnDockPrincipal.Controls.Add(Me.btnOrcamento)
	      Me.pnDockPrincipal.Controls.Add(Me.Button1)
	      Me.pnDockPrincipal.Location = New System.Drawing.Point(11, 130)
	      Me.pnDockPrincipal.Name = "pnDockPrincipal"
	      Me.pnDockPrincipal.Size = New System.Drawing.Size(63, 637)
	      Me.pnDockPrincipal.TabIndex = 47
	      '
	      'btnNavegador
	      '
	      Me.btnNavegador.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.btnNavegador.FlatAppearance.BorderColor = System.Drawing.Color.White
	      Me.btnNavegador.FlatAppearance.BorderSize = 0
	      Me.btnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnNavegador.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnNavegador.ForeColor = System.Drawing.Color.White
	      Me.btnNavegador.Image = Global.ControleOS.My.Resources.Resources.friends_link_send_share_icon_123609
	      Me.btnNavegador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnNavegador.Location = New System.Drawing.Point(3, 219)
	      Me.btnNavegador.Name = "btnNavegador"
	      Me.btnNavegador.Size = New System.Drawing.Size(168, 54)
	      Me.btnNavegador.TabIndex = 2
	      Me.btnNavegador.Text = "Navegador"
	      Me.btnNavegador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnNavegador.UseVisualStyleBackColor = False
	      '
	      'btnFinanceiro
	      '
	      Me.btnFinanceiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.btnFinanceiro.FlatAppearance.BorderColor = System.Drawing.Color.White
	      Me.btnFinanceiro.FlatAppearance.BorderSize = 0
	      Me.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnFinanceiro.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnFinanceiro.ForeColor = System.Drawing.Color.White
	      Me.btnFinanceiro.Image = Global.ControleOS.My.Resources.Resources.Faturar2
	      Me.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnFinanceiro.Location = New System.Drawing.Point(3, 111)
	      Me.btnFinanceiro.Name = "btnFinanceiro"
	      Me.btnFinanceiro.Size = New System.Drawing.Size(168, 54)
	      Me.btnFinanceiro.TabIndex = 6
	      Me.btnFinanceiro.Text = "Lançamentos"
	      Me.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnFinanceiro.UseVisualStyleBackColor = False
	      '
	      'btnAbrirPDV
	      '
	      Me.btnAbrirPDV.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.btnAbrirPDV.DialogResult = System.Windows.Forms.DialogResult.Cancel
	      Me.btnAbrirPDV.FlatAppearance.BorderColor = System.Drawing.Color.White
	      Me.btnAbrirPDV.FlatAppearance.BorderSize = 0
	      Me.btnAbrirPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAbrirPDV.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnAbrirPDV.ForeColor = System.Drawing.Color.White
	      Me.btnAbrirPDV.Image = Global.ControleOS.My.Resources.Resources.Pagamento
	      Me.btnAbrirPDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnAbrirPDV.Location = New System.Drawing.Point(3, 3)
	      Me.btnAbrirPDV.Name = "btnAbrirPDV"
	      Me.btnAbrirPDV.Size = New System.Drawing.Size(168, 54)
	      Me.btnAbrirPDV.TabIndex = 4
	      Me.btnAbrirPDV.Text = "PDV"
	      Me.btnAbrirPDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnAbrirPDV.UseVisualStyleBackColor = False
	      '
	      'btnOrcamento
	      '
	      Me.btnOrcamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.btnOrcamento.FlatAppearance.BorderColor = System.Drawing.Color.White
	      Me.btnOrcamento.FlatAppearance.BorderSize = 0
	      Me.btnOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnOrcamento.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnOrcamento.ForeColor = System.Drawing.Color.White
	      Me.btnOrcamento.Image = Global.ControleOS.My.Resources.Resources.desenho
	      Me.btnOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnOrcamento.Location = New System.Drawing.Point(3, 57)
	      Me.btnOrcamento.Name = "btnOrcamento"
	      Me.btnOrcamento.Size = New System.Drawing.Size(168, 54)
	      Me.btnOrcamento.TabIndex = 5
	      Me.btnOrcamento.Text = "Orçamento"
	      Me.btnOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnOrcamento.UseVisualStyleBackColor = False
	      '
	      'Button1
	      '
	      Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
	      Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
	      Me.Button1.FlatAppearance.BorderSize = 0
	      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Button1.ForeColor = System.Drawing.Color.White
	      Me.Button1.Image = Global.ControleOS.My.Resources.Resources.setas
	      Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.Button1.Location = New System.Drawing.Point(3, 165)
	      Me.Button1.Name = "Button1"
	      Me.Button1.Size = New System.Drawing.Size(168, 54)
	      Me.Button1.TabIndex = 7
	      Me.Button1.Text = "Mov. Financeira"
	      Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.Button1.UseVisualStyleBackColor = False
	      '
	      'Panel3
	      '
	      Me.Panel3.BackColor = System.Drawing.Color.White
	      Me.Panel3.Controls.Add(Me.Label8)
	      Me.Panel3.Controls.Add(Me.PictureBox7)
	      Me.Panel3.Location = New System.Drawing.Point(93, 130)
	      Me.Panel3.Name = "Panel3"
	      Me.Panel3.Size = New System.Drawing.Size(305, 32)
	      Me.Panel3.TabIndex = 49
	      '
	      'PictureBox7
	      '
	      Me.PictureBox7.BackgroundImage = Global.ControleOS.My.Resources.Resources.house
	      Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox7.Location = New System.Drawing.Point(3, 3)
	      Me.PictureBox7.Name = "PictureBox7"
	      Me.PictureBox7.Size = New System.Drawing.Size(27, 24)
	      Me.PictureBox7.TabIndex = 4
	      Me.PictureBox7.TabStop = False
	      '
	      'Panel4
	      '
	      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel4.Controls.Add(Me.PictureBox3)
	      Me.Panel4.Controls.Add(Me.Label1)
	      Me.Panel4.Controls.Add(Me.lblQuantClientes)
	      Me.Panel4.Location = New System.Drawing.Point(93, 163)
	      Me.Panel4.Name = "Panel4"
	      Me.Panel4.Size = New System.Drawing.Size(152, 77)
	      Me.Panel4.TabIndex = 50
	      '
	      'PictureBox3
	      '
	      Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox3.BackgroundImage = Global.ControleOS.My.Resources.Resources.Usuarios
	      Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox3.Location = New System.Drawing.Point(110, 4)
	      Me.PictureBox3.Name = "PictureBox3"
	      Me.PictureBox3.Size = New System.Drawing.Size(36, 27)
	      Me.PictureBox3.TabIndex = 2
	      Me.PictureBox3.TabStop = False
	      '
	      'Panel5
	      '
	      Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel5.Controls.Add(Me.PictureBox4)
	      Me.Panel5.Controls.Add(Me.lblSaldoCritico)
	      Me.Panel5.Controls.Add(Me.Label3)
	      Me.Panel5.Location = New System.Drawing.Point(246, 163)
	      Me.Panel5.Name = "Panel5"
	      Me.Panel5.Size = New System.Drawing.Size(152, 77)
	      Me.Panel5.TabIndex = 51
	      '
	      'PictureBox4
	      '
	      Me.PictureBox4.BackgroundImage = Global.ControleOS.My.Resources.Resources._024_shopping_cart
	      Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox4.Location = New System.Drawing.Point(106, 12)
	      Me.PictureBox4.Name = "PictureBox4"
	      Me.PictureBox4.Size = New System.Drawing.Size(32, 27)
	      Me.PictureBox4.TabIndex = 4
	      Me.PictureBox4.TabStop = False
	      '
	      'Panel2
	      '
	      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel2.Controls.Add(Me.PictureBox5)
	      Me.Panel2.Controls.Add(Me.Label5)
	      Me.Panel2.Controls.Add(Me.Label4)
	      Me.Panel2.Location = New System.Drawing.Point(93, 246)
	      Me.Panel2.Name = "Panel2"
	      Me.Panel2.Size = New System.Drawing.Size(305, 77)
	      Me.Panel2.TabIndex = 52
	      '
	      'PictureBox5
	      '
	      Me.PictureBox5.BackgroundImage = Global.ControleOS.My.Resources.Resources.Grafico
	      Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox5.Location = New System.Drawing.Point(257, 3)
	      Me.PictureBox5.Name = "PictureBox5"
	      Me.PictureBox5.Size = New System.Drawing.Size(43, 35)
	      Me.PictureBox5.TabIndex = 5
	      Me.PictureBox5.TabStop = False
	      '
	      'Panel6
	      '
	      Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel6.Controls.Add(Me.Label7)
	      Me.Panel6.Controls.Add(Me.Label6)
	      Me.Panel6.Controls.Add(Me.PictureBox6)
	      Me.Panel6.Location = New System.Drawing.Point(93, 329)
	      Me.Panel6.Name = "Panel6"
	      Me.Panel6.Size = New System.Drawing.Size(305, 77)
	      Me.Panel6.TabIndex = 53
	      '
	      'PictureBox6
	      '
	      Me.PictureBox6.BackgroundImage = Global.ControleOS.My.Resources.Resources.grafico2
	      Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox6.Location = New System.Drawing.Point(257, 3)
	      Me.PictureBox6.Name = "PictureBox6"
	      Me.PictureBox6.Size = New System.Drawing.Size(43, 42)
	      Me.PictureBox6.TabIndex = 6
	      Me.PictureBox6.TabStop = False
	      '
	      'tmMinDock
	      '
	      '
	      'Panel1
	      '
	      Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
		      Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.Panel1.BackColor = System.Drawing.Color.White
	      Me.Panel1.Controls.Add(Me.PictureBox12)
	      Me.Panel1.Controls.Add(Me.Label2)
	      Me.Panel1.Location = New System.Drawing.Point(404, 130)
	      Me.Panel1.Name = "Panel1"
	      Me.Panel1.Size = New System.Drawing.Size(864, 32)
	      Me.Panel1.TabIndex = 50
	      '
	      'PictureBox12
	      '
	      Me.PictureBox12.BackColor = System.Drawing.Color.White
	      Me.PictureBox12.BackgroundImage = Global.ControleOS.My.Resources.Resources.Entrega
	      Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox12.Location = New System.Drawing.Point(3, 2)
	      Me.PictureBox12.Name = "PictureBox12"
	      Me.PictureBox12.Size = New System.Drawing.Size(28, 27)
	      Me.PictureBox12.TabIndex = 2
	      Me.PictureBox12.TabStop = False
	      '
	      'ImageList1
	      '
	      Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
	      Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
	      Me.ImageList1.Images.SetKeyName(0, "Cancelar.ico")
	      Me.ImageList1.Images.SetKeyName(1, "mim.jpg")
	      Me.ImageList1.Images.SetKeyName(2, "miniimizar23.png")
	      '
	      'dgvEntrega
	      '
	      Me.dgvEntrega.AllowUserToAddRows = False
	      Me.dgvEntrega.AllowUserToResizeRows = False
	      Me.dgvEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
		      Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvEntrega.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
	      Me.dgvEntrega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
	      Me.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
	      DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
	      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvEntrega.DefaultCellStyle = DataGridViewCellStyle3
	      Me.dgvEntrega.GridColor = System.Drawing.Color.Silver
	      Me.dgvEntrega.Location = New System.Drawing.Point(404, 163)
	      Me.dgvEntrega.Name = "dgvEntrega"
	      Me.dgvEntrega.RowHeadersVisible = False
	      Me.dgvEntrega.RowHeadersWidth = 33
	      Me.dgvEntrega.RowTemplate.Height = 33
	      Me.dgvEntrega.ShowCellErrors = False
	      Me.dgvEntrega.ShowCellToolTips = False
	      Me.dgvEntrega.ShowEditingIcon = False
	      Me.dgvEntrega.ShowRowErrors = False
	      Me.dgvEntrega.Size = New System.Drawing.Size(864, 243)
	      Me.dgvEntrega.TabIndex = 54
	      '
	      'PictureBox8
	      '
	      Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox8.BackgroundImage = Global.ControleOS.My.Resources.Resources.seta_verde_esquerda
	      Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox8.Location = New System.Drawing.Point(1154, 102)
	      Me.PictureBox8.Name = "PictureBox8"
	      Me.PictureBox8.Size = New System.Drawing.Size(23, 22)
	      Me.PictureBox8.TabIndex = 55
	      Me.PictureBox8.TabStop = False
	      '
	      'PictureBox2
	      '
	      Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox2.BackgroundImage = Global.ControleOS.My.Resources.Resources.seta_vermelha
	      Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox2.Location = New System.Drawing.Point(1069, 102)
	      Me.PictureBox2.Name = "PictureBox2"
	      Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
	      Me.PictureBox2.TabIndex = 6
	      Me.PictureBox2.TabStop = False
	      '
	      'pctSair
	      '
	      Me.pctSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.pctSair.BackgroundImage = Global.ControleOS.My.Resources.Resources.Desligar
	      Me.pctSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.pctSair.Location = New System.Drawing.Point(-721, 290)
	      Me.pctSair.Name = "pctSair"
	      Me.pctSair.Size = New System.Drawing.Size(43, 35)
	      Me.pctSair.TabIndex = 42
	      Me.pctSair.TabStop = False
	      '
	      'PicColaborador
	      '
	      Me.PicColaborador.BackgroundImage = Global.ControleOS.My.Resources.Resources.usuario3
	      Me.PicColaborador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PicColaborador.Location = New System.Drawing.Point(93, 71)
	      Me.PicColaborador.Name = "PicColaborador"
	      Me.PicColaborador.Size = New System.Drawing.Size(48, 50)
	      Me.PicColaborador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
	      Me.PicColaborador.TabIndex = 0
	      Me.PicColaborador.TabStop = False
	      '
	      'DataGridViewImageColumn1
	      '
	      Me.DataGridViewImageColumn1.Description = "s"
	      Me.DataGridViewImageColumn1.HeaderText = "Column1"
	      Me.DataGridViewImageColumn1.Image = Global.ControleOS.My.Resources.Resources.mim
	      Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
	      Me.DataGridViewImageColumn1.ToolTipText = "ww"
	      '
	      'PictureBox1
	      '
	      Me.PictureBox1.BackgroundImage = Global.ControleOS.My.Resources.Resources.usuario3
	      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
	      Me.PictureBox1.Name = "PictureBox1"
	      Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
	      Me.PictureBox1.TabIndex = 0
	      Me.PictureBox1.TabStop = False
	      '
	      'PictureBox9
	      '
	      Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox9.BackgroundImage = Global.ControleOS.My.Resources.Resources.Atualizar
	      Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox9.Location = New System.Drawing.Point(1233, 71)
	      Me.PictureBox9.Name = "PictureBox9"
	      Me.PictureBox9.Size = New System.Drawing.Size(35, 27)
	      Me.PictureBox9.TabIndex = 58
	      Me.PictureBox9.TabStop = False
	      '
	      'lblHora
	      '
	      Me.lblHora.AutoSize = True
	      Me.lblHora.BackColor = System.Drawing.Color.Transparent
	      Me.lblHora.Depth = 0
	      Me.lblHora.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.lblHora.Location = New System.Drawing.Point(7, 33)
	      Me.lblHora.MouseState = MaterialSkin.MouseState.HOVER
	      Me.lblHora.Name = "lblHora"
	      Me.lblHora.Size = New System.Drawing.Size(65, 19)
	      Me.lblHora.TabIndex = 61
	      Me.lblHora.Text = "00:00:00"
	      '
	      'lblData
	      '
	      Me.lblData.AutoSize = True
	      Me.lblData.BackColor = System.Drawing.Color.Transparent
	      Me.lblData.Depth = 0
	      Me.lblData.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.lblData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.lblData.Location = New System.Drawing.Point(98, 33)
	      Me.lblData.MouseState = MaterialSkin.MouseState.HOVER
	      Me.lblData.Name = "lblData"
	      Me.lblData.Size = New System.Drawing.Size(65, 19)
	      Me.lblData.TabIndex = 62
	      Me.lblData.Text = "00:00:00"
	      '
	      'lblNomeUsuario
	      '
	      Me.lblNomeUsuario.AutoSize = True
	      Me.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent
	      Me.lblNomeUsuario.Depth = 0
	      Me.lblNomeUsuario.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.lblNomeUsuario.Location = New System.Drawing.Point(147, 71)
	      Me.lblNomeUsuario.MouseState = MaterialSkin.MouseState.HOVER
	      Me.lblNomeUsuario.Name = "lblNomeUsuario"
	      Me.lblNomeUsuario.Size = New System.Drawing.Size(126, 19)
	      Me.lblNomeUsuario.TabIndex = 63
	      Me.lblNomeUsuario.Text = "Nome de Usuario"
	      '
	      'lblCargo
	      '
	      Me.lblCargo.AutoSize = True
	      Me.lblCargo.BackColor = System.Drawing.Color.Transparent
	      Me.lblCargo.Depth = 0
	      Me.lblCargo.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.lblCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.lblCargo.Location = New System.Drawing.Point(147, 90)
	      Me.lblCargo.MouseState = MaterialSkin.MouseState.HOVER
	      Me.lblCargo.Name = "lblCargo"
	      Me.lblCargo.Size = New System.Drawing.Size(49, 19)
	      Me.lblCargo.TabIndex = 64
	      Me.lblCargo.Text = "Cargo"
	      '
	      'MaterialLabel1
	      '
	      Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.MaterialLabel1.AutoSize = True
	      Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
	      Me.MaterialLabel1.Depth = 0
	      Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.MaterialLabel1.Location = New System.Drawing.Point(1098, 106)
	      Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
	      Me.MaterialLabel1.Name = "MaterialLabel1"
	      Me.MaterialLabel1.Size = New System.Drawing.Size(46, 19)
	      Me.MaterialLabel1.TabIndex = 65
	      Me.MaterialLabel1.Text = "Saída"
	      '
	      'MaterialLabel3
	      '
	      Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.MaterialLabel3.AutoSize = True
	      Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
	      Me.MaterialLabel3.Depth = 0
	      Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
	      Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
	      Me.MaterialLabel3.Location = New System.Drawing.Point(1183, 106)
	      Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
	      Me.MaterialLabel3.Name = "MaterialLabel3"
	      Me.MaterialLabel3.Size = New System.Drawing.Size(60, 19)
	      Me.MaterialLabel3.TabIndex = 67
	      Me.MaterialLabel3.Text = "Entrada"
	      '
	      'btnLogout
	      '
	      Me.btnLogout.AutoSize = True
	      Me.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
	      Me.btnLogout.Depth = 0
	      Me.btnLogout.Location = New System.Drawing.Point(959, 90)
	      Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
	      Me.btnLogout.MouseState = MaterialSkin.MouseState.HOVER
	      Me.btnLogout.Name = "btnLogout"
	      Me.btnLogout.Primary = False
	      Me.btnLogout.Size = New System.Drawing.Size(65, 36)
	      Me.btnLogout.TabIndex = 68
	      Me.btnLogout.Text = "Logout"
	      Me.btnLogout.UseVisualStyleBackColor = True
	      '
	      'Button2
	      '
	      Me.Button2.Location = New System.Drawing.Point(627, 99)
	      Me.Button2.Name = "Button2"
	      Me.Button2.Size = New System.Drawing.Size(75, 23)
	      Me.Button2.TabIndex = 69
	      Me.Button2.Text = "Button2"
	      Me.Button2.UseVisualStyleBackColor = True
	      '
	      'Button3
	      '

	      'Button2
	      '
	      Me.Button2.Location = New System.Drawing.Point(314, 91)
	      Me.Button2.Name = "Button2"
	      Me.Button2.Size = New System.Drawing.Size(75, 23)
	      Me.Button2.TabIndex = 70
	      Me.Button2.Text = "Button2"
	      Me.Button2.UseVisualStyleBackColor = True
	      '
	      'FrmMenu
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
	      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
	      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.CausesValidation = False
	      Me.ClientSize = New System.Drawing.Size(1280, 768)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.Button2)
	      Me.Controls.Add(Me.btnVisitas)
	      Me.Controls.Add(Me.btnLogout)
	      Me.Controls.Add(Me.MaterialLabel3)
	      Me.Controls.Add(Me.MaterialLabel1)
	      Me.Controls.Add(Me.lblCargo)
	      Me.Controls.Add(Me.lblNomeUsuario)
	      Me.Controls.Add(Me.lblData)
	      Me.Controls.Add(Me.lblHora)
	      Me.Controls.Add(Me.PictureBox9)
	      Me.Controls.Add(Me.PictureBox8)
	      Me.Controls.Add(Me.PictureBox2)
	      Me.Controls.Add(Me.dgvEntrega)
	      Me.Controls.Add(Me.Panel1)
	      Me.Controls.Add(Me.pnDockPrincipal)
	      Me.Controls.Add(Me.Panel6)
	      Me.Controls.Add(Me.Panel2)
	      Me.Controls.Add(Me.Panel5)
	      Me.Controls.Add(Label11)
	      Me.Controls.Add(Me.pctSair)
	      Me.Controls.Add(Me.Panel3)
	      Me.Controls.Add(Me.PicColaborador)
	      Me.Controls.Add(Me.lblPesquisaFilaProducao)
	      Me.Controls.Add(Me.Panel4)
	      Me.Controls.Add(Me.MenuStrip1)
	      Me.ForeColor = System.Drawing.Color.White
	      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
	      Me.MaximizeBox = False
	      Me.Name = "FrmMenu"
	      Me.Text = " "
	      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
	      CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.MenuStrip1.ResumeLayout(False)
	      Me.MenuStrip1.PerformLayout()
	      Me.pnDockPrincipal.ResumeLayout(False)
	      Me.Panel3.ResumeLayout(False)
	      Me.Panel3.PerformLayout()
	      CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel4.ResumeLayout(False)
	      Me.Panel4.PerformLayout()
	      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel5.ResumeLayout(False)
	      Me.Panel5.PerformLayout()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel2.ResumeLayout(False)
	      Me.Panel2.PerformLayout()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel6.ResumeLayout(False)
	      Me.Panel6.PerformLayout()
	      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel1.ResumeLayout(False)
	      Me.Panel1.PerformLayout()
	      CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvEntrega, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.pctSair, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PicColaborador, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)
	      Me.PerformLayout()

        End Sub
        Friend WithEvents TbProdutoVenda1BindingSource As BindingSource
        Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
        Friend WithEvents TbProdutoVenda1TableAdapter As SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter
        Friend WithEvents TbOSBindingSource As BindingSource
        Friend WithEvents TbOSTableAdapter As SistemaGEDataSetTableAdapters.tbOSTableAdapter
        Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents ORÇAMENTOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CRIARNOVAOSToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents MEDIÇÕESToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents FINANCEIROToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LANÇAMENTOSToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PAGAMENTOSToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LIBERAÇÃOEMLOTEToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PAGAMENTOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents VENDASToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PDVToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents VENDAToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents RELATÓRIODEVENDASToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CADASTROSToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LISTADECLIENTESToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents RELATÓRIOSDECLIENTESToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents OPÇÕESToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CONFIGURARAÇÃOBASICAToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CONFIGURAÇÕESAVANÇADASToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PRODUTOSToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ESTOQUEToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents RELATÓRIOENTSAIToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents FILADEPRODUÇÃOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CALENDARIOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents AGENDAToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LEMBRETERAPIDOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents lblPesquisaFilaProducao As Label
        Friend WithEvents PicColaborador As PictureBox
        Friend WithEvents lblQuantClientes As Label
        Friend WithEvents PictureBox4 As PictureBox
        Friend WithEvents Label3 As Label
        Friend WithEvents lblSaldoCritico As Label
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents Label1 As Label
        Friend WithEvents PictureBox5 As PictureBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents PictureBox6 As PictureBox
        Friend WithEvents PictureBox7 As PictureBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents btnNavegador As Button
        Friend WithEvents pctSair As PictureBox
        Friend WithEvents tmAtualizarRelatorio As Timer
        Friend WithEvents INSERIRAGENDAMENTODEVISITAToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PictureBox12 As PictureBox
        Friend WithEvents Label2 As Label
        Friend WithEvents btnAbrirPDV As Button
        Friend WithEvents btnOrcamento As Button
        Friend WithEvents btnFinanceiro As Button
        Friend WithEvents Button1 As Button
        Friend WithEvents atividadeSegundoPlano As System.ComponentModel.BackgroundWorker
        Friend WithEvents tmAtualizar As Timer
        Friend WithEvents hora As Timer
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
        Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
        Friend WithEvents pnDockPrincipal As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents BottomToolStripPanel As ToolStripPanel
        Friend WithEvents TopToolStripPanel As ToolStripPanel
        Friend WithEvents RightToolStripPanel As ToolStripPanel
        Friend WithEvents LeftToolStripPanel As ToolStripPanel
        Friend WithEvents ContentPanel As ToolStripContentPanel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel6 As Panel
        Friend WithEvents tmMinDock As Timer
        Friend WithEvents Panel1 As Panel
        Friend WithEvents ImageList1 As ImageList
        Friend WithEvents dgvEntrega As DataGridView
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents PictureBox8 As PictureBox
        Friend WithEvents PictureBox9 As PictureBox
        Friend WithEvents FERRAMENTASToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CONSULTACNPJToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents lblHora As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents lblData As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents lblNomeUsuario As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents lblCargo As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
        Friend WithEvents btnLogout As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents btnVisitas As Button
        Friend WithEvents Button2 As Button
End Class
