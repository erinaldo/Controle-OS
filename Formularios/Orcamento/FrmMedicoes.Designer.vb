<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMedicoes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMestre = New System.Windows.Forms.DataGridView()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecRespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataAberturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataAprovacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.dgvEscravo = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeGesseiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbOStbMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpDetalhamento = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalServico = New System.Windows.Forms.TextBox()
        Me.txtGesseiro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorPagar = New System.Windows.Forms.TextBox()
        Me.TbMedicaotbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtCodGesseiro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOSID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMDOFechado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAreaExecutada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAreaPlanejada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtMedicao = New System.Windows.Forms.TextBox()
        Me.btnInserirMedicao = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Medicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReceber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvGesseiros = New System.Windows.Forms.DataGridView()
        Me.NomeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CódigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbGesseirosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet2 = New ControleOS.SistemaGEDataSet()
        Me.dgvAuxiliar = New System.Windows.Forms.DataGridView()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SobrenomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NacionalidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbGesseirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbGesseirosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet1 = New ControleOS.SistemaGEDataSet()
        Me.TbOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
        Me.TbMedicaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbMedicaoTableAdapter()
        Me.TbHistoricoMedicaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter()
        Me.TbHistoricoMedicao1TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicao1TableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbGesseirosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbGesseirostbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvMestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEscravo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOStbMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetalhamento.SuspendLayout()
        CType(Me.TbMedicaotbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGesseiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbGesseirostbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMestre
        '
        Me.dgvMestre.AllowUserToAddRows = False
        Me.dgvMestre.AllowUserToDeleteRows = False
        Me.dgvMestre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMestre.AutoGenerateColumns = False
        Me.dgvMestre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMestre.BackgroundColor = System.Drawing.Color.White
        Me.dgvMestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMestre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.CodClienteDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TecRespDataGridViewTextBoxColumn, Me.DataAberturaDataGridViewTextBoxColumn, Me.DataAprovacaoDataGridViewTextBoxColumn, Me.NomeClienteDataGridViewTextBoxColumn})
        Me.dgvMestre.DataSource = Me.TbOSBindingSource
        Me.dgvMestre.Location = New System.Drawing.Point(12, 50)
        Me.dgvMestre.Name = "dgvMestre"
        Me.dgvMestre.ReadOnly = True
        Me.dgvMestre.Size = New System.Drawing.Size(871, 225)
        Me.dgvMestre.TabIndex = 5
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        Me.OSIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodClienteDataGridViewTextBoxColumn
        '
        Me.CodClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.HeaderText = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.Name = "CodClienteDataGridViewTextBoxColumn"
        Me.CodClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TecRespDataGridViewTextBoxColumn
        '
        Me.TecRespDataGridViewTextBoxColumn.DataPropertyName = "TecResp"
        Me.TecRespDataGridViewTextBoxColumn.HeaderText = "TecResp"
        Me.TecRespDataGridViewTextBoxColumn.Name = "TecRespDataGridViewTextBoxColumn"
        Me.TecRespDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataAberturaDataGridViewTextBoxColumn
        '
        Me.DataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura"
        Me.DataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura"
        Me.DataAberturaDataGridViewTextBoxColumn.Name = "DataAberturaDataGridViewTextBoxColumn"
        Me.DataAberturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataAprovacaoDataGridViewTextBoxColumn
        '
        Me.DataAprovacaoDataGridViewTextBoxColumn.DataPropertyName = "DataAprovacao"
        Me.DataAprovacaoDataGridViewTextBoxColumn.HeaderText = "DataAprovacao"
        Me.DataAprovacaoDataGridViewTextBoxColumn.Name = "DataAprovacaoDataGridViewTextBoxColumn"
        Me.DataAprovacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeClienteDataGridViewTextBoxColumn
        '
        Me.NomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente"
        Me.NomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente"
        Me.NomeClienteDataGridViewTextBoxColumn.Name = "NomeClienteDataGridViewTextBoxColumn"
        Me.NomeClienteDataGridViewTextBoxColumn.ReadOnly = True
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
        'dgvEscravo
        '
        Me.dgvEscravo.AllowUserToAddRows = False
        Me.dgvEscravo.AllowUserToDeleteRows = False
        Me.dgvEscravo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEscravo.AutoGenerateColumns = False
        Me.dgvEscravo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEscravo.BackgroundColor = System.Drawing.Color.White
        Me.dgvEscravo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEscravo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NomeProdutoDataGridViewTextBoxColumn, Me.NomeGesseiroDataGridViewTextBoxColumn})
        Me.dgvEscravo.DataSource = Me.TbOStbMedicaoBindingSource
        Me.dgvEscravo.Location = New System.Drawing.Point(12, 50)
        Me.dgvEscravo.Name = "dgvEscravo"
        Me.dgvEscravo.ReadOnly = True
        Me.dgvEscravo.Size = New System.Drawing.Size(871, 225)
        Me.dgvEscravo.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeProdutoDataGridViewTextBoxColumn
        '
        Me.NomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto"
        Me.NomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto"
        Me.NomeProdutoDataGridViewTextBoxColumn.Name = "NomeProdutoDataGridViewTextBoxColumn"
        Me.NomeProdutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeGesseiroDataGridViewTextBoxColumn
        '
        Me.NomeGesseiroDataGridViewTextBoxColumn.DataPropertyName = "NomeGesseiro"
        Me.NomeGesseiroDataGridViewTextBoxColumn.HeaderText = "NomeGesseiro"
        Me.NomeGesseiroDataGridViewTextBoxColumn.Name = "NomeGesseiroDataGridViewTextBoxColumn"
        Me.NomeGesseiroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbOStbMedicaoBindingSource
        '
        Me.TbOStbMedicaoBindingSource.DataMember = "tbOStbMedicao"
        Me.TbOStbMedicaoBindingSource.DataSource = Me.TbOSBindingSource
        '
        'grpDetalhamento
        '
        Me.grpDetalhamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetalhamento.BackColor = System.Drawing.Color.Transparent
        Me.grpDetalhamento.Controls.Add(Me.Label14)
        Me.grpDetalhamento.Controls.Add(Me.txtTotalServico)
        Me.grpDetalhamento.Controls.Add(Me.txtGesseiro)
        Me.grpDetalhamento.Controls.Add(Me.Label12)
        Me.grpDetalhamento.Controls.Add(Me.txtValorPagar)
        Me.grpDetalhamento.Controls.Add(Me.Label13)
        Me.grpDetalhamento.Controls.Add(Me.Label9)
        Me.grpDetalhamento.Controls.Add(Me.txtStatus)
        Me.grpDetalhamento.Controls.Add(Me.txtCodGesseiro)
        Me.grpDetalhamento.Controls.Add(Me.Label11)
        Me.grpDetalhamento.Controls.Add(Me.txtObservacao)
        Me.grpDetalhamento.Controls.Add(Me.Label10)
        Me.grpDetalhamento.Controls.Add(Me.txtOSID)
        Me.grpDetalhamento.Controls.Add(Me.Label8)
        Me.grpDetalhamento.Controls.Add(Me.Label7)
        Me.grpDetalhamento.Controls.Add(Me.txtID)
        Me.grpDetalhamento.Controls.Add(Me.Label6)
        Me.grpDetalhamento.Controls.Add(Me.txtMDOFechado)
        Me.grpDetalhamento.Controls.Add(Me.Label5)
        Me.grpDetalhamento.Controls.Add(Me.txtUnidade)
        Me.grpDetalhamento.Controls.Add(Me.Label4)
        Me.grpDetalhamento.Controls.Add(Me.txtAreaExecutada)
        Me.grpDetalhamento.Controls.Add(Me.Label3)
        Me.grpDetalhamento.Controls.Add(Me.txtAreaPlanejada)
        Me.grpDetalhamento.Controls.Add(Me.Label2)
        Me.grpDetalhamento.Controls.Add(Me.txtLocal)
        Me.grpDetalhamento.Controls.Add(Me.Label1)
        Me.grpDetalhamento.Controls.Add(Me.txtNomeProduto)
        Me.grpDetalhamento.ForeColor = System.Drawing.Color.White
        Me.grpDetalhamento.Location = New System.Drawing.Point(889, 44)
        Me.grpDetalhamento.Name = "grpDetalhamento"
        Me.grpDetalhamento.Size = New System.Drawing.Size(234, 381)
        Me.grpDetalhamento.TabIndex = 7
        Me.grpDetalhamento.TabStop = False
        Me.grpDetalhamento.Text = "Detalhamento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(124, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Total Serviço"
        '
        'txtTotalServico
        '
        Me.txtTotalServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalServico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "TotalServico", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtTotalServico.Location = New System.Drawing.Point(124, 200)
        Me.txtTotalServico.Name = "txtTotalServico"
        Me.txtTotalServico.ReadOnly = True
        Me.txtTotalServico.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalServico.TabIndex = 34
        '
        'txtGesseiro
        '
        Me.txtGesseiro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "NomeGesseiro", True))
        Me.txtGesseiro.Location = New System.Drawing.Point(93, 81)
        Me.txtGesseiro.Name = "txtGesseiro"
        Me.txtGesseiro.ReadOnly = True
        Me.txtGesseiro.Size = New System.Drawing.Size(132, 20)
        Me.txtGesseiro.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(116, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Valor pagar"
        '
        'txtValorPagar
        '
        Me.txtValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbMedicaotbHistoricoMedicaoBindingSource, "Status", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtValorPagar.Location = New System.Drawing.Point(116, 277)
        Me.txtValorPagar.Name = "txtValorPagar"
        Me.txtValorPagar.ReadOnly = True
        Me.txtValorPagar.Size = New System.Drawing.Size(109, 20)
        Me.txtValorPagar.TabIndex = 28
        '
        'TbMedicaotbHistoricoMedicaoBindingSource
        '
        Me.TbMedicaotbHistoricoMedicaoBindingSource.DataMember = "tbMedicaotbHistoricoMedicao"
        Me.TbMedicaotbHistoricoMedicaoBindingSource.DataSource = Me.TbOStbMedicaoBindingSource
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Código Gesseiro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(5, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbMedicaotbHistoricoMedicaoBindingSource, "Status", True))
        Me.txtStatus.Location = New System.Drawing.Point(6, 277)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(104, 20)
        Me.txtStatus.TabIndex = 26
        '
        'txtCodGesseiro
        '
        Me.txtCodGesseiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodGesseiro.Location = New System.Drawing.Point(6, 81)
        Me.txtCodGesseiro.Name = "txtCodGesseiro"
        Me.txtCodGesseiro.ReadOnly = True
        Me.txtCodGesseiro.Size = New System.Drawing.Size(81, 20)
        Me.txtCodGesseiro.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Observação"
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(6, 315)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(219, 50)
        Me.txtObservacao.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(129, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "OS - ID"
        '
        'txtOSID
        '
        Me.txtOSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOSID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "OSID", True))
        Me.txtOSID.Location = New System.Drawing.Point(129, 41)
        Me.txtOSID.Name = "txtOSID"
        Me.txtOSID.ReadOnly = True
        Me.txtOSID.Size = New System.Drawing.Size(96, 20)
        Me.txtOSID.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Identificação da Venda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(93, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nome do Gesseiro"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "ID", True))
        Me.txtID.Location = New System.Drawing.Point(6, 41)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(117, 20)
        Me.txtID.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total MDO Fechado"
        '
        'txtMDOFechado
        '
        Me.txtMDOFechado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMDOFechado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "TotalMDO", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMDOFechado.Location = New System.Drawing.Point(7, 200)
        Me.txtMDOFechado.Name = "txtMDOFechado"
        Me.txtMDOFechado.ReadOnly = True
        Me.txtMDOFechado.Size = New System.Drawing.Size(111, 20)
        Me.txtMDOFechado.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(170, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Unidade"
        '
        'txtUnidade
        '
        Me.txtUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "Unidade", True))
        Me.txtUnidade.Location = New System.Drawing.Point(173, 157)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.ReadOnly = True
        Me.txtUnidade.Size = New System.Drawing.Size(52, 20)
        Me.txtUnidade.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(113, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Area Executada"
        '
        'txtAreaExecutada
        '
        Me.txtAreaExecutada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaExecutada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "AreaExecutada", True))
        Me.txtAreaExecutada.Location = New System.Drawing.Point(113, 237)
        Me.txtAreaExecutada.Name = "txtAreaExecutada"
        Me.txtAreaExecutada.ReadOnly = True
        Me.txtAreaExecutada.Size = New System.Drawing.Size(112, 20)
        Me.txtAreaExecutada.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Area Planejada"
        '
        'txtAreaPlanejada
        '
        Me.txtAreaPlanejada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaPlanejada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "AreaPlanejada", True))
        Me.txtAreaPlanejada.Location = New System.Drawing.Point(7, 237)
        Me.txtAreaPlanejada.Name = "txtAreaPlanejada"
        Me.txtAreaPlanejada.ReadOnly = True
        Me.txtAreaPlanejada.Size = New System.Drawing.Size(104, 20)
        Me.txtAreaPlanejada.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Local"
        '
        'txtLocal
        '
        Me.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "LocalExec", True))
        Me.txtLocal.Location = New System.Drawing.Point(7, 157)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.ReadOnly = True
        Me.txtLocal.Size = New System.Drawing.Size(164, 20)
        Me.txtLocal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome do Produto"
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomeProduto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOStbMedicaoBindingSource, "NomeProduto", True))
        Me.txtNomeProduto.Location = New System.Drawing.Point(6, 118)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.ReadOnly = True
        Me.txtNomeProduto.Size = New System.Drawing.Size(219, 20)
        Me.txtNomeProduto.TabIndex = 1
        '
        'txtMedicao
        '
        Me.txtMedicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicao.Location = New System.Drawing.Point(113, 26)
        Me.txtMedicao.Name = "txtMedicao"
        Me.txtMedicao.Size = New System.Drawing.Size(112, 26)
        Me.txtMedicao.TabIndex = 21
        '
        'btnInserirMedicao
        '
        Me.btnInserirMedicao.BackColor = System.Drawing.Color.Transparent
        Me.btnInserirMedicao.FlatAppearance.BorderSize = 0
        Me.btnInserirMedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserirMedicao.ForeColor = System.Drawing.Color.Transparent
        Me.btnInserirMedicao.Image = Global.ControleOS.My.Resources.Resources.Medicao1
        Me.btnInserirMedicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInserirMedicao.Location = New System.Drawing.Point(4, 10)
        Me.btnInserirMedicao.Name = "btnInserirMedicao"
        Me.btnInserirMedicao.Size = New System.Drawing.Size(106, 58)
        Me.btnInserirMedicao.TabIndex = 20
        Me.btnInserirMedicao.Text = "INSERIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MEDIÇÃO"
        Me.btnInserirMedicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserirMedicao.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Medicao, Me.AReceber, Me.Data, Me.UNIDADEDataGridViewTextBoxColumn, Me.ObservacaoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbMedicaotbHistoricoMedicaoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(871, 227)
        Me.DataGridView1.TabIndex = 19
        '
        'Medicao
        '
        Me.Medicao.DataPropertyName = "Medicao"
        Me.Medicao.HeaderText = "MEDIÇÃO"
        Me.Medicao.Name = "Medicao"
        Me.Medicao.ReadOnly = True
        '
        'AReceber
        '
        Me.AReceber.DataPropertyName = "AReceber"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AReceber.DefaultCellStyle = DataGridViewCellStyle2
        Me.AReceber.HeaderText = "TOTAL"
        Me.AReceber.Name = "AReceber"
        Me.AReceber.ReadOnly = True
        '
        'Data
        '
        Me.Data.DataPropertyName = "Data"
        Me.Data.HeaderText = "DATA"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn
        '
        Me.UNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.Name = "UNIDADEDataGridViewTextBoxColumn"
        Me.UNIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacaoDataGridViewTextBoxColumn
        '
        Me.ObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao"
        Me.ObservacaoDataGridViewTextBoxColumn.HeaderText = "OBSERVAÇÃO"
        Me.ObservacaoDataGridViewTextBoxColumn.Name = "ObservacaoDataGridViewTextBoxColumn"
        Me.ObservacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ControleOS.My.Resources.Resources.Voltar2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "voltar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvGesseiros
        '
        Me.dgvGesseiros.AllowUserToAddRows = False
        Me.dgvGesseiros.AllowUserToDeleteRows = False
        Me.dgvGesseiros.AllowUserToResizeColumns = False
        Me.dgvGesseiros.AllowUserToResizeRows = False
        Me.dgvGesseiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGesseiros.AutoGenerateColumns = False
        Me.dgvGesseiros.BackgroundColor = System.Drawing.Color.White
        Me.dgvGesseiros.CausesValidation = False
        Me.dgvGesseiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesseiros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeDataGridViewTextBoxColumn1, Me.CódigoDataGridViewTextBoxColumn1})
        Me.dgvGesseiros.DataSource = Me.TbGesseirosBindingSource2
        Me.dgvGesseiros.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGesseiros.Location = New System.Drawing.Point(134, 108)
        Me.dgvGesseiros.Name = "dgvGesseiros"
        Me.dgvGesseiros.ReadOnly = True
        Me.dgvGesseiros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGesseiros.RowHeadersVisible = False
        Me.dgvGesseiros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGesseiros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvGesseiros.Size = New System.Drawing.Size(122, 74)
        Me.dgvGesseiros.TabIndex = 33
        '
        'NomeDataGridViewTextBoxColumn1
        '
        Me.NomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn1.HeaderText = ""
        Me.NomeDataGridViewTextBoxColumn1.Name = "NomeDataGridViewTextBoxColumn1"
        Me.NomeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NomeDataGridViewTextBoxColumn1.Width = 120
        '
        'CódigoDataGridViewTextBoxColumn1
        '
        Me.CódigoDataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn1.HeaderText = ""
        Me.CódigoDataGridViewTextBoxColumn1.Name = "CódigoDataGridViewTextBoxColumn1"
        Me.CódigoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CódigoDataGridViewTextBoxColumn1.Width = 58
        '
        'TbGesseirosBindingSource2
        '
        Me.TbGesseirosBindingSource2.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource2.DataSource = Me.SistemaGEDataSet2
        '
        'SistemaGEDataSet2
        '
        Me.SistemaGEDataSet2.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvAuxiliar
        '
        Me.dgvAuxiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAuxiliar.AutoGenerateColumns = False
        Me.dgvAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuxiliar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.SobrenomeDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn, Me.RGDataGridViewTextBoxColumn, Me.EstadoCivilDataGridViewTextBoxColumn, Me.NacionalidadeDataGridViewTextBoxColumn, Me.IDOSDataGridViewTextBoxColumn})
        Me.dgvAuxiliar.DataSource = Me.TbGesseirosBindingSource
        Me.dgvAuxiliar.Location = New System.Drawing.Point(68, 67)
        Me.dgvAuxiliar.Name = "dgvAuxiliar"
        Me.dgvAuxiliar.Size = New System.Drawing.Size(247, 74)
        Me.dgvAuxiliar.TabIndex = 32
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'SobrenomeDataGridViewTextBoxColumn
        '
        Me.SobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome"
        Me.SobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome"
        Me.SobrenomeDataGridViewTextBoxColumn.Name = "SobrenomeDataGridViewTextBoxColumn"
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        '
        'RGDataGridViewTextBoxColumn
        '
        Me.RGDataGridViewTextBoxColumn.DataPropertyName = "RG"
        Me.RGDataGridViewTextBoxColumn.HeaderText = "RG"
        Me.RGDataGridViewTextBoxColumn.Name = "RGDataGridViewTextBoxColumn"
        '
        'EstadoCivilDataGridViewTextBoxColumn
        '
        Me.EstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.HeaderText = "EstadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.Name = "EstadoCivilDataGridViewTextBoxColumn"
        '
        'NacionalidadeDataGridViewTextBoxColumn
        '
        Me.NacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade"
        Me.NacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade"
        Me.NacionalidadeDataGridViewTextBoxColumn.Name = "NacionalidadeDataGridViewTextBoxColumn"
        '
        'IDOSDataGridViewTextBoxColumn
        '
        Me.IDOSDataGridViewTextBoxColumn.DataPropertyName = "IDOS"
        Me.IDOSDataGridViewTextBoxColumn.HeaderText = "IDOS"
        Me.IDOSDataGridViewTextBoxColumn.Name = "IDOSDataGridViewTextBoxColumn"
        '
        'TbGesseirosBindingSource
        '
        Me.TbGesseirosBindingSource.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbGesseirosBindingSource1
        '
        Me.TbGesseirosBindingSource1.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource1.DataSource = Me.SistemaGEDataSet1
        '
        'SistemaGEDataSet1
        '
        Me.SistemaGEDataSet1.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbOSTableAdapter
        '
        Me.TbOSTableAdapter.ClearBeforeFill = True
        '
        'TbMedicaoTableAdapter
        '
        Me.TbMedicaoTableAdapter.ClearBeforeFill = True
        '
        'TbHistoricoMedicaoTableAdapter
        '
        Me.TbHistoricoMedicaoTableAdapter.ClearBeforeFill = True
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
        'TbGesseirosTableAdapter
        '
        Me.TbGesseirosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ControleOS.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TbGesseirostbOSBindingSource
        '
        Me.TbGesseirostbOSBindingSource.DataMember = "tbGesseirostbOS"
        Me.TbGesseirostbOSBindingSource.DataSource = Me.TbGesseirosBindingSource1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnInserirMedicao)
        Me.GroupBox1.Controls.Add(Me.txtMedicao)
        Me.GroupBox1.Location = New System.Drawing.Point(889, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 90)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'FrmMedicoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvMestre)
        Me.Controls.Add(Me.dgvEscravo)
        Me.Controls.Add(Me.grpDetalhamento)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvAuxiliar)
        Me.Controls.Add(Me.dgvGesseiros)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmMedicoes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "MEDIÇÕES"
        CType(Me.dgvMestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEscravo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOStbMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetalhamento.ResumeLayout(False)
        Me.grpDetalhamento.PerformLayout()
        CType(Me.TbMedicaotbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGesseiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbGesseirostbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvMestre As DataGridView
    Friend WithEvents dgvEscravo As DataGridView
    Friend WithEvents grpDetalhamento As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMDOFechado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAreaExecutada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAreaPlanejada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbOSBindingSource As BindingSource
    Friend WithEvents TbOSTableAdapter As SistemaGEDataSetTableAdapters.tbOSTableAdapter
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TecRespDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataAberturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataAprovacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbOStbMedicaoBindingSource As BindingSource
    Friend WithEvents TbMedicaoTableAdapter As SistemaGEDataSetTableAdapters.tbMedicaoTableAdapter
    Friend WithEvents TbMedicaotbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicaoTableAdapter As SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeProdutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeGesseiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnInserirMedicao As Button
    Friend WithEvents txtMedicao As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOSID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents TbHistoricoMedicao1TableAdapter As SistemaGEDataSetTableAdapters.tbHistoricoMedicao1TableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtValorPagar As TextBox
    Friend WithEvents TbGesseirosBindingSource As BindingSource
    Friend WithEvents TbGesseirosTableAdapter As SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCodGesseiro As TextBox
    Friend WithEvents SistemaGEDataSet1 As SistemaGEDataSet
    Friend WithEvents TbGesseirosBindingSource1 As BindingSource
    Friend WithEvents dgvAuxiliar As DataGridView
    Friend WithEvents TbGesseirostbOSBindingSource As BindingSource
    Friend WithEvents SistemaGEDataSet2 As SistemaGEDataSet
    Friend WithEvents TbGesseirosBindingSource2 As BindingSource
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SobrenomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NacionalidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtGesseiro As TextBox
    Friend WithEvents dgvGesseiros As DataGridView
    Friend WithEvents NomeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CódigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalServico As TextBox
    Friend WithEvents Medicao As DataGridViewTextBoxColumn
    Friend WithEvents AReceber As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
