<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImpOS
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpOS))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkPrestador = New System.Windows.Forms.CheckBox()
        Me.chkTotalServiço = New System.Windows.Forms.CheckBox()
        Me.chkTotalMDO = New System.Windows.Forms.CheckBox()
        Me.chkstatus = New System.Windows.Forms.CheckBox()
        Me.btnAplicarFiltros = New System.Windows.Forms.Button()
        Me.chkOcultarPag = New System.Windows.Forms.CheckBox()
        Me.chkOcultarTotais = New System.Windows.Forms.CheckBox()
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbProdutoVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVendaTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoVendaTableAdapter()
        Me.TbProdutoVenda2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVenda2TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoVenda2TableAdapter()
        Me.TbProdutoVenda1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVenda1TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbProdutoVenda1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
        Me.TbProdutoVendaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVendaTableAdapter2 = New ControleOS.DataSetXTableAdapters.tbProdutoVendaTableAdapter()
        Me.TableAdapterManager1 = New ControleOS.DataSetXTableAdapters.TableAdapterManager()
        Me.dgvProdutoInicio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProdutoadicional = New System.Windows.Forms.DataGridView()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalServicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalMDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalServicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GesseiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusProducaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbProdutoVendaBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSety = New ControleOS.DataSety()
        Me.TbProdutoVendaBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVendaBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVendaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVendaTableAdapter1 = New ControleOS.DataSetyTableAdapters.tbProdutoVendaTableAdapter()
        Me.TbProdutoVendaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvFinanceiro = New System.Windows.Forms.DataGridView()
        Me.SituacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataLancamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbFinanceiroTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbFinanceiroTableAdapter()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVenda2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVenda1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutoadicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVendaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkPrestador
        '
        Me.chkPrestador.AutoSize = True
        Me.chkPrestador.BackColor = System.Drawing.Color.Transparent
        Me.chkPrestador.Checked = True
        Me.chkPrestador.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrestador.Location = New System.Drawing.Point(14, 78)
        Me.chkPrestador.Name = "chkPrestador"
        Me.chkPrestador.Size = New System.Drawing.Size(114, 17)
        Me.chkPrestador.TabIndex = 123
        Me.chkPrestador.Text = "Ocultar Prestador?"
        Me.chkPrestador.UseVisualStyleBackColor = False
        '
        'chkTotalServiço
        '
        Me.chkTotalServiço.AutoSize = True
        Me.chkTotalServiço.BackColor = System.Drawing.Color.Transparent
        Me.chkTotalServiço.Checked = True
        Me.chkTotalServiço.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTotalServiço.Location = New System.Drawing.Point(14, 55)
        Me.chkTotalServiço.Name = "chkTotalServiço"
        Me.chkTotalServiço.Size = New System.Drawing.Size(105, 17)
        Me.chkTotalServiço.TabIndex = 122
        Me.chkTotalServiço.Text = "Ocultar Serviço?"
        Me.chkTotalServiço.UseVisualStyleBackColor = False
        '
        'chkTotalMDO
        '
        Me.chkTotalMDO.AutoSize = True
        Me.chkTotalMDO.BackColor = System.Drawing.Color.Transparent
        Me.chkTotalMDO.Checked = True
        Me.chkTotalMDO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTotalMDO.Location = New System.Drawing.Point(14, 32)
        Me.chkTotalMDO.Name = "chkTotalMDO"
        Me.chkTotalMDO.Size = New System.Drawing.Size(94, 17)
        Me.chkTotalMDO.TabIndex = 121
        Me.chkTotalMDO.Text = "Ocultar MDO?"
        Me.chkTotalMDO.UseVisualStyleBackColor = False
        '
        'chkstatus
        '
        Me.chkstatus.AutoSize = True
        Me.chkstatus.BackColor = System.Drawing.Color.Transparent
        Me.chkstatus.Checked = True
        Me.chkstatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkstatus.Location = New System.Drawing.Point(14, 101)
        Me.chkstatus.Name = "chkstatus"
        Me.chkstatus.Size = New System.Drawing.Size(99, 17)
        Me.chkstatus.TabIndex = 124
        Me.chkstatus.Text = "Ocultar Status?"
        Me.chkstatus.UseVisualStyleBackColor = False
        '
        'btnAplicarFiltros
        '
        Me.btnAplicarFiltros.FlatAppearance.BorderSize = 0
        Me.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicarFiltros.Image = Global.ControleOS.My.Resources.Resources.Confirmar
        Me.btnAplicarFiltros.Location = New System.Drawing.Point(14, 176)
        Me.btnAplicarFiltros.Name = "btnAplicarFiltros"
        Me.btnAplicarFiltros.Size = New System.Drawing.Size(74, 43)
        Me.btnAplicarFiltros.TabIndex = 125
        Me.btnAplicarFiltros.Text = "Aplicar"
        Me.btnAplicarFiltros.UseVisualStyleBackColor = True
        '
        'chkOcultarPag
        '
        Me.chkOcultarPag.AutoSize = True
        Me.chkOcultarPag.BackColor = System.Drawing.Color.Transparent
        Me.chkOcultarPag.Checked = True
        Me.chkOcultarPag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOcultarPag.Location = New System.Drawing.Point(14, 124)
        Me.chkOcultarPag.Name = "chkOcultarPag"
        Me.chkOcultarPag.Size = New System.Drawing.Size(123, 17)
        Me.chkOcultarPag.TabIndex = 126
        Me.chkOcultarPag.Text = "Ocultar Pagamento?"
        Me.chkOcultarPag.UseVisualStyleBackColor = False
        '
        'chkOcultarTotais
        '
        Me.chkOcultarTotais.AutoSize = True
        Me.chkOcultarTotais.BackColor = System.Drawing.Color.Transparent
        Me.chkOcultarTotais.Location = New System.Drawing.Point(14, 147)
        Me.chkOcultarTotais.Name = "chkOcultarTotais"
        Me.chkOcultarTotais.Size = New System.Drawing.Size(98, 17)
        Me.chkOcultarTotais.TabIndex = 127
        Me.chkOcultarTotais.Text = "Ocultar Totais?"
        Me.chkOcultarTotais.UseVisualStyleBackColor = False
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProdutoVendaBindingSource
        '
        Me.TbProdutoVendaBindingSource.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbProdutoVendaTableAdapter
        '
        Me.TbProdutoVendaTableAdapter.ClearBeforeFill = True
        '
        'TbProdutoVenda2BindingSource
        '
        Me.TbProdutoVenda2BindingSource.DataMember = "tbProdutoVenda2"
        Me.TbProdutoVenda2BindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbProdutoVenda2TableAdapter
        '
        Me.TbProdutoVenda2TableAdapter.ClearBeforeFill = True
        '
        'TbProdutoVenda1BindingSource
        '
        Me.TbProdutoVenda1BindingSource.DataMember = "tbProdutoVenda1"
        Me.TbProdutoVenda1BindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbProdutoVenda1TableAdapter
        '
        Me.TbProdutoVenda1TableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbOSTableAdapter = Nothing
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
        'TbProdutoVenda1BindingSource1
        '
        Me.TbProdutoVenda1BindingSource1.DataMember = "tbProdutoVenda1"
        Me.TbProdutoVenda1BindingSource1.DataSource = Me.SistemaGEDataSet
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProdutoVendaBindingSource2
        '
        Me.TbProdutoVendaBindingSource2.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource2.DataSource = Me.DataSetX
        '
        'TbProdutoVendaTableAdapter2
        '
        Me.TbProdutoVendaTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FormaPagamentoTableAdapter = Nothing
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
        Me.TableAdapterManager1.tbProdutoVendaTableAdapter = Me.TbProdutoVendaTableAdapter2
        Me.TableAdapterManager1.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ControleOS.DataSetXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvProdutoInicio
        '
        Me.dgvProdutoInicio.AllowUserToAddRows = False
        Me.dgvProdutoInicio.AllowUserToDeleteRows = False
        Me.dgvProdutoInicio.AutoGenerateColumns = False
        Me.dgvProdutoInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutoInicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14})
        Me.dgvProdutoInicio.DataSource = Me.TbProdutoVendaBindingSource2
        Me.dgvProdutoInicio.Location = New System.Drawing.Point(797, 259)
        Me.dgvProdutoInicio.Name = "dgvProdutoInicio"
        Me.dgvProdutoInicio.ReadOnly = True
        Me.dgvProdutoInicio.Size = New System.Drawing.Size(79, 45)
        Me.dgvProdutoInicio.TabIndex = 127
        Me.dgvProdutoInicio.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OSID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CÓD.VENDA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIÇÃO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "LocalServico"
        Me.DataGridViewTextBoxColumn9.HeaderText = "AMBIENTE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AREA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Unidade"
        Me.DataGridViewTextBoxColumn11.HeaderText = "UN."
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TotalMDO"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "TOTAL MDO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalServico"
        DataGridViewCellStyle6.Format = "C2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL SERVIÇO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gesseiro"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PRESTADOR"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "StatusProducao"
        Me.DataGridViewTextBoxColumn14.HeaderText = "STATUS PRODUÇÃO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'dgvProdutoadicional
        '
        Me.dgvProdutoadicional.AllowUserToAddRows = False
        Me.dgvProdutoadicional.AllowUserToDeleteRows = False
        Me.dgvProdutoadicional.AutoGenerateColumns = False
        Me.dgvProdutoadicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutoadicional.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.LocalServicoDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.UnidadeDataGridViewTextBoxColumn, Me.TotalMDODataGridViewTextBoxColumn, Me.TotalServicoDataGridViewTextBoxColumn, Me.GesseiroDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.StatusProducaoDataGridViewTextBoxColumn})
        Me.dgvProdutoadicional.DataSource = Me.TbProdutoVendaBindingSource6
        Me.dgvProdutoadicional.Location = New System.Drawing.Point(797, 205)
        Me.dgvProdutoadicional.Name = "dgvProdutoadicional"
        Me.dgvProdutoadicional.ReadOnly = True
        Me.dgvProdutoadicional.Size = New System.Drawing.Size(79, 48)
        Me.dgvProdutoadicional.TabIndex = 128
        Me.dgvProdutoadicional.Visible = False
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "CÓD. VENDA"
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        Me.OSIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalServicoDataGridViewTextBoxColumn
        '
        Me.LocalServicoDataGridViewTextBoxColumn.DataPropertyName = "LocalServico"
        Me.LocalServicoDataGridViewTextBoxColumn.HeaderText = "AMBIENTE"
        Me.LocalServicoDataGridViewTextBoxColumn.Name = "LocalServicoDataGridViewTextBoxColumn"
        Me.LocalServicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "AREA"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadeDataGridViewTextBoxColumn
        '
        Me.UnidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.HeaderText = "UN."
        Me.UnidadeDataGridViewTextBoxColumn.Name = "UnidadeDataGridViewTextBoxColumn"
        Me.UnidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalMDODataGridViewTextBoxColumn
        '
        Me.TotalMDODataGridViewTextBoxColumn.DataPropertyName = "TotalMDO"
        Me.TotalMDODataGridViewTextBoxColumn.HeaderText = "TOTAL MDO"
        Me.TotalMDODataGridViewTextBoxColumn.Name = "TotalMDODataGridViewTextBoxColumn"
        Me.TotalMDODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalServicoDataGridViewTextBoxColumn
        '
        Me.TotalServicoDataGridViewTextBoxColumn.DataPropertyName = "TotalServico"
        Me.TotalServicoDataGridViewTextBoxColumn.HeaderText = "TOTAL SERVIÇO"
        Me.TotalServicoDataGridViewTextBoxColumn.Name = "TotalServicoDataGridViewTextBoxColumn"
        Me.TotalServicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GesseiroDataGridViewTextBoxColumn
        '
        Me.GesseiroDataGridViewTextBoxColumn.DataPropertyName = "Gesseiro"
        Me.GesseiroDataGridViewTextBoxColumn.HeaderText = "PRESTADOR"
        Me.GesseiroDataGridViewTextBoxColumn.Name = "GesseiroDataGridViewTextBoxColumn"
        Me.GesseiroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusProducaoDataGridViewTextBoxColumn
        '
        Me.StatusProducaoDataGridViewTextBoxColumn.DataPropertyName = "StatusProducao"
        Me.StatusProducaoDataGridViewTextBoxColumn.HeaderText = "STATUS DE PRODUÇÃO"
        Me.StatusProducaoDataGridViewTextBoxColumn.Name = "StatusProducaoDataGridViewTextBoxColumn"
        Me.StatusProducaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbProdutoVendaBindingSource6
        '
        Me.TbProdutoVendaBindingSource6.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource6.DataSource = Me.DataSety
        '
        'DataSety
        '
        Me.DataSety.DataSetName = "DataSety"
        Me.DataSety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProdutoVendaBindingSource4
        '
        Me.TbProdutoVendaBindingSource4.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource4.DataSource = Me.DataSetX
        '
        'TbProdutoVendaBindingSource5
        '
        Me.TbProdutoVendaBindingSource5.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource5.DataSource = Me.DataSetyBindingSource
        '
        'DataSetyBindingSource
        '
        Me.DataSetyBindingSource.DataSource = Me.DataSety
        Me.DataSetyBindingSource.Position = 0
        '
        'TbProdutoVendaBindingSource1
        '
        Me.TbProdutoVendaBindingSource1.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource1.DataSource = Me.DataSety
        '
        'TbProdutoVendaTableAdapter1
        '
        Me.TbProdutoVendaTableAdapter1.ClearBeforeFill = True
        '
        'TbProdutoVendaBindingSource3
        '
        Me.TbProdutoVendaBindingSource3.DataMember = "tbProdutoVenda"
        Me.TbProdutoVendaBindingSource3.DataSource = Me.DataSety
        '
        'dgvFinanceiro
        '
        Me.dgvFinanceiro.AllowUserToAddRows = False
        Me.dgvFinanceiro.AllowUserToDeleteRows = False
        Me.dgvFinanceiro.AutoGenerateColumns = False
        Me.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinanceiro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SituacaoDataGridViewTextBoxColumn, Me.DataLancamentoDataGridViewTextBoxColumn, Me.VencimentoDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.dgvFinanceiro.DataSource = Me.TbFinanceiroBindingSource
        Me.dgvFinanceiro.Location = New System.Drawing.Point(796, 161)
        Me.dgvFinanceiro.Name = "dgvFinanceiro"
        Me.dgvFinanceiro.ReadOnly = True
        Me.dgvFinanceiro.Size = New System.Drawing.Size(65, 38)
        Me.dgvFinanceiro.TabIndex = 129
        Me.dgvFinanceiro.Visible = False
        '
        'SituacaoDataGridViewTextBoxColumn
        '
        Me.SituacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao"
        Me.SituacaoDataGridViewTextBoxColumn.HeaderText = "Situação"
        Me.SituacaoDataGridViewTextBoxColumn.Name = "SituacaoDataGridViewTextBoxColumn"
        Me.SituacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataLancamentoDataGridViewTextBoxColumn
        '
        Me.DataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataLancamentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data de Lançamento"
        Me.DataLancamentoDataGridViewTextBoxColumn.Name = "DataLancamentoDataGridViewTextBoxColumn"
        Me.DataLancamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VencimentoDataGridViewTextBoxColumn
        '
        Me.VencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.Name = "VencimentoDataGridViewTextBoxColumn"
        Me.VencimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ValorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbFinanceiroBindingSource
        '
        Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbFinanceiroTableAdapter
        '
        Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(180, 32)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(305, 327)
        Me.AxAcroPDF1.TabIndex = 130
        '
        'FrmImpOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 629)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.chkOcultarTotais)
        Me.Controls.Add(Me.chkOcultarPag)
        Me.Controls.Add(Me.btnAplicarFiltros)
        Me.Controls.Add(Me.chkstatus)
        Me.Controls.Add(Me.chkPrestador)
        Me.Controls.Add(Me.chkTotalServiço)
        Me.Controls.Add(Me.chkTotalMDO)
        Me.Controls.Add(Me.dgvFinanceiro)
        Me.Controls.Add(Me.dgvProdutoadicional)
        Me.Controls.Add(Me.dgvProdutoInicio)
        Me.Name = "FrmImpOS"
        Me.Text = "FrmImpOS"
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVenda2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVenda1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutoadicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVendaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chkPrestador As CheckBox
    Friend WithEvents chkTotalServiço As CheckBox
    Friend WithEvents chkTotalMDO As CheckBox
    Friend WithEvents chkstatus As CheckBox
    Friend WithEvents btnAplicarFiltros As Button
    Friend WithEvents chkOcultarPag As CheckBox
    Friend WithEvents chkOcultarTotais As CheckBox
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbProdutoVendaBindingSource As BindingSource
    Friend WithEvents DataSety As DataSety
    Friend WithEvents TbProdutoVendaBindingSource1 As BindingSource
    Friend WithEvents TbProdutoVendaTableAdapter1 As DataSetyTableAdapters.tbProdutoVendaTableAdapter
    Friend WithEvents TbProdutoVendaTableAdapter As SistemaGEDataSetTableAdapters.tbProdutoVendaTableAdapter
    Friend WithEvents TbProdutoVenda2BindingSource As BindingSource
    Friend WithEvents TbProdutoVenda2TableAdapter As SistemaGEDataSetTableAdapters.tbProdutoVenda2TableAdapter
    Friend WithEvents TbProdutoVenda1BindingSource As BindingSource
    Friend WithEvents TbProdutoVenda1TableAdapter As SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbProdutoVenda1BindingSource1 As BindingSource
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbProdutoVendaBindingSource2 As BindingSource
    Friend WithEvents TbProdutoVendaTableAdapter2 As DataSetXTableAdapters.tbProdutoVendaTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetXTableAdapters.TableAdapterManager
    Friend WithEvents dgvProdutoInicio As DataGridView
    Friend WithEvents dgvProdutoadicional As DataGridView
    Friend WithEvents TbProdutoVendaBindingSource3 As BindingSource
    Friend WithEvents TbProdutoVendaBindingSource5 As BindingSource
    Friend WithEvents DataSetyBindingSource As BindingSource
    Friend WithEvents TbProdutoVendaBindingSource4 As BindingSource
    Friend WithEvents TbProdutoVendaBindingSource6 As BindingSource
    Friend WithEvents dgvFinanceiro As DataGridView
    Friend WithEvents TbFinanceiroBindingSource As BindingSource
    Friend WithEvents TbFinanceiroTableAdapter As SistemaGEDataSetTableAdapters.tbFinanceiroTableAdapter
    Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataLancamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalServicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalMDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalServicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GesseiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusProducaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
