<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLiberacaoMedicao
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
        Dim CodClienteLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TecRespLabel As System.Windows.Forms.Label
        Dim DataAberturaLabel As System.Windows.Forms.Label
        Dim DataAprovacaoLabel As System.Windows.Forms.Label
        Dim NomeClienteLabel As System.Windows.Forms.Label
        Dim TipoEnderecoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvLiberados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeGesseiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GesseiroID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReceber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Liberacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
        Me.dgvPendente = New System.Windows.Forms.DataGridView()
        Me.OSIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbHistoricoMedicaoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCarreagar = New System.Windows.Forms.Button()
        Me.TbOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecRespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataAberturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataAprovacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbObservacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OSIDTextBox = New System.Windows.Forms.TextBox()
        Me.CodClienteTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TecRespTextBox = New System.Windows.Forms.TextBox()
        Me.DataAberturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataAprovacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TipoEnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.TbLancamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.TbObservacaoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOSTableAdapter1 = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
        Me.TbHistoricoMedicaoTableAdapter1 = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter()
        Me.TbFilaProducaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbFilaProducaoTableAdapter()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnLiberarPagamento = New System.Windows.Forms.Button()
        Me.grpDetOS = New System.Windows.Forms.GroupBox()
        Me.btnExpandirDetOS = New System.Windows.Forms.Button()
        Me.btnMinimizarDetOS = New System.Windows.Forms.Button()
        Me.TbClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbClientesTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbClientesTableAdapter()
        Me.TableAdapterManager1 = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        Me.TbOStbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOStbFilaProducaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOStbHistoricoMedicaoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOSTableAdapter = New ControleOS.DataSetXTableAdapters.tbOSTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataSetXTableAdapters.TableAdapterManager()
        Me.TbHistoricoMedicaoTableAdapter = New ControleOS.DataSetXTableAdapters.tbHistoricoMedicaoTableAdapter()
        Me.TbLancamentosTableAdapter = New ControleOS.DataSetXTableAdapters.tbLancamentosTableAdapter()
        Me.TbObservacaoTableAdapter = New ControleOS.DataSetXTableAdapters.tbObservacaoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OSIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeGesseiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GesseiroIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReceberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LiberacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        OSIDLabel = New System.Windows.Forms.Label()
        CodClienteLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TecRespLabel = New System.Windows.Forms.Label()
        DataAberturaLabel = New System.Windows.Forms.Label()
        DataAprovacaoLabel = New System.Windows.Forms.Label()
        NomeClienteLabel = New System.Windows.Forms.Label()
        TipoEnderecoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        CType(Me.dgvLiberados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPendente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbObservacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbLancamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbObservacaoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetOS.SuspendLayout()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOStbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOStbFilaProducaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOStbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OSIDLabel
        '
        OSIDLabel.AutoSize = True
        OSIDLabel.Location = New System.Drawing.Point(13, 73)
        OSIDLabel.Name = "OSIDLabel"
        OSIDLabel.Size = New System.Drawing.Size(37, 13)
        OSIDLabel.TabIndex = 7
        OSIDLabel.Text = "N° OS"
        '
        'CodClienteLabel
        '
        CodClienteLabel.AutoSize = True
        CodClienteLabel.BackColor = System.Drawing.Color.Transparent
        CodClienteLabel.ForeColor = System.Drawing.Color.White
        CodClienteLabel.Location = New System.Drawing.Point(18, 47)
        CodClienteLabel.Name = "CodClienteLabel"
        CodClienteLabel.Size = New System.Drawing.Size(64, 13)
        CodClienteLabel.TabIndex = 9
        CodClienteLabel.Text = "Cod Cliente:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(13, 96)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "Status:"
        '
        'TecRespLabel
        '
        TecRespLabel.AutoSize = True
        TecRespLabel.Location = New System.Drawing.Point(13, 125)
        TecRespLabel.Name = "TecRespLabel"
        TecRespLabel.Size = New System.Drawing.Size(57, 13)
        TecRespLabel.TabIndex = 13
        TecRespLabel.Text = "Tec Resp:"
        '
        'DataAberturaLabel
        '
        DataAberturaLabel.AutoSize = True
        DataAberturaLabel.Location = New System.Drawing.Point(13, 150)
        DataAberturaLabel.Name = "DataAberturaLabel"
        DataAberturaLabel.Size = New System.Drawing.Size(76, 13)
        DataAberturaLabel.TabIndex = 15
        DataAberturaLabel.Text = "Data Abertura:"
        '
        'DataAprovacaoLabel
        '
        DataAprovacaoLabel.AutoSize = True
        DataAprovacaoLabel.Location = New System.Drawing.Point(13, 176)
        DataAprovacaoLabel.Name = "DataAprovacaoLabel"
        DataAprovacaoLabel.Size = New System.Drawing.Size(88, 13)
        DataAprovacaoLabel.TabIndex = 17
        DataAprovacaoLabel.Text = "Data Aprovacao:"
        '
        'NomeClienteLabel
        '
        NomeClienteLabel.AutoSize = True
        NomeClienteLabel.BackColor = System.Drawing.Color.Transparent
        NomeClienteLabel.ForeColor = System.Drawing.Color.White
        NomeClienteLabel.Location = New System.Drawing.Point(6, 17)
        NomeClienteLabel.Name = "NomeClienteLabel"
        NomeClienteLabel.Size = New System.Drawing.Size(73, 13)
        NomeClienteLabel.TabIndex = 19
        NomeClienteLabel.Text = "Nome Cliente:"
        '
        'TipoEnderecoLabel
        '
        TipoEnderecoLabel.AutoSize = True
        TipoEnderecoLabel.Location = New System.Drawing.Point(18, 199)
        TipoEnderecoLabel.Name = "TipoEnderecoLabel"
        TipoEnderecoLabel.Size = New System.Drawing.Size(80, 13)
        TipoEnderecoLabel.TabIndex = 21
        TipoEnderecoLabel.Text = "Tipo Endereco:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(18, 225)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 47
        ObservacaoLabel.Text = "Observacao:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LIBERADOS PARA PAGAMENTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PENDENTES DE LIBERAÇÃO"
        '
        'dgvLiberados
        '
        Me.dgvLiberados.AllowUserToAddRows = False
        Me.dgvLiberados.AllowUserToDeleteRows = False
        Me.dgvLiberados.AutoGenerateColumns = False
        Me.dgvLiberados.BackgroundColor = System.Drawing.Color.White
        Me.dgvLiberados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLiberados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Data, Me.Medicao, Me.Observacao, Me.UNIDADE, Me.NomeGesseiro, Me.Status, Me.GesseiroID, Me.Descricao, Me.AReceber, Me.SubID, Me.Liberacao, Me.OSIDDataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.MedicaoDataGridViewTextBoxColumn, Me.UNIDADEDataGridViewTextBoxColumn, Me.NomeGesseiroDataGridViewTextBoxColumn, Me.ObservacaoDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn1, Me.GesseiroIDDataGridViewTextBoxColumn, Me.AReceberDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.SubIDDataGridViewTextBoxColumn, Me.LiberacaoDataGridViewTextBoxColumn, Me.SelDataGridViewCheckBoxColumn})
        Me.dgvLiberados.DataSource = Me.TbHistoricoMedicaoBindingSource
        Me.dgvLiberados.GridColor = System.Drawing.Color.Silver
        Me.dgvLiberados.Location = New System.Drawing.Point(12, 82)
        Me.dgvLiberados.Name = "dgvLiberados"
        Me.dgvLiberados.ReadOnly = True
        Me.dgvLiberados.Size = New System.Drawing.Size(808, 266)
        Me.dgvLiberados.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "OSID"
        Me.Column1.HeaderText = "Cód. OS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Data
        '
        Me.Data.DataPropertyName = "Data"
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Medicao
        '
        Me.Medicao.DataPropertyName = "Medicao"
        Me.Medicao.HeaderText = "Medicao"
        Me.Medicao.Name = "Medicao"
        Me.Medicao.ReadOnly = True
        '
        'Observacao
        '
        Me.Observacao.DataPropertyName = "Observacao"
        Me.Observacao.HeaderText = "Observacao"
        Me.Observacao.Name = "Observacao"
        Me.Observacao.ReadOnly = True
        '
        'UNIDADE
        '
        Me.UNIDADE.DataPropertyName = "UNIDADE"
        Me.UNIDADE.HeaderText = "UNIDADE"
        Me.UNIDADE.Name = "UNIDADE"
        Me.UNIDADE.ReadOnly = True
        '
        'NomeGesseiro
        '
        Me.NomeGesseiro.DataPropertyName = "NomeGesseiro"
        Me.NomeGesseiro.HeaderText = "NomeGesseiro"
        Me.NomeGesseiro.Name = "NomeGesseiro"
        Me.NomeGesseiro.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'GesseiroID
        '
        Me.GesseiroID.DataPropertyName = "GesseiroID"
        Me.GesseiroID.HeaderText = "GesseiroID"
        Me.GesseiroID.Name = "GesseiroID"
        Me.GesseiroID.ReadOnly = True
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.HeaderText = "Descricao"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        '
        'AReceber
        '
        Me.AReceber.DataPropertyName = "AReceber"
        Me.AReceber.HeaderText = "AReceber"
        Me.AReceber.Name = "AReceber"
        Me.AReceber.ReadOnly = True
        '
        'SubID
        '
        Me.SubID.DataPropertyName = "SubID"
        Me.SubID.HeaderText = "SubID"
        Me.SubID.Name = "SubID"
        Me.SubID.ReadOnly = True
        '
        'Liberacao
        '
        Me.Liberacao.DataPropertyName = "Liberacao"
        Me.Liberacao.HeaderText = "Liberacao"
        Me.Liberacao.Name = "Liberacao"
        Me.Liberacao.ReadOnly = True
        '
        'TbHistoricoMedicaoBindingSource
        '
        Me.TbHistoricoMedicaoBindingSource.DataMember = "tbHistoricoMedicao"
        Me.TbHistoricoMedicaoBindingSource.DataSource = Me.DataSetX
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvPendente
        '
        Me.dgvPendente.AutoGenerateColumns = False
        Me.dgvPendente.BackgroundColor = System.Drawing.Color.White
        Me.dgvPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn2, Me.ID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvPendente.DataSource = Me.TbHistoricoMedicaoBindingSource1
        Me.dgvPendente.Location = New System.Drawing.Point(12, 387)
        Me.dgvPendente.Name = "dgvPendente"
        Me.dgvPendente.Size = New System.Drawing.Size(808, 254)
        Me.dgvPendente.TabIndex = 5
        '
        'OSIDDataGridViewTextBoxColumn2
        '
        Me.OSIDDataGridViewTextBoxColumn2.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn2.HeaderText = "OSID"
        Me.OSIDDataGridViewTextBoxColumn2.Name = "OSIDDataGridViewTextBoxColumn2"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Medicao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Medicao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Observacao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Observacao"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UNIDADE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UNIDADE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NomeGesseiro"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NomeGesseiro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GesseiroID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GesseiroID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "AReceber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "AReceber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Liberacao"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Liberacao"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TbHistoricoMedicaoBindingSource1
        '
        Me.TbHistoricoMedicaoBindingSource1.DataMember = "tbHistoricoMedicao"
        Me.TbHistoricoMedicaoBindingSource1.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbOSBindingSource1
        '
        Me.TbOSBindingSource1.DataMember = "tbOS"
        Me.TbOSBindingSource1.DataSource = Me.SistemaGEDataSet
        '
        'btnCarreagar
        '
        Me.btnCarreagar.BackColor = System.Drawing.Color.Transparent
        Me.btnCarreagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCarreagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnCarreagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCarreagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCarreagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarreagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarreagar.Location = New System.Drawing.Point(130, 12)
        Me.btnCarreagar.Name = "btnCarreagar"
        Me.btnCarreagar.Size = New System.Drawing.Size(147, 51)
        Me.btnCarreagar.TabIndex = 6
        Me.btnCarreagar.Text = "CARREGAR OS"
        Me.btnCarreagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarreagar.UseVisualStyleBackColor = False
        '
        'TbOSDataGridView
        '
        Me.TbOSDataGridView.AutoGenerateColumns = False
        Me.TbOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.CodClienteDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TecRespDataGridViewTextBoxColumn, Me.DataAberturaDataGridViewTextBoxColumn, Me.DataAprovacaoDataGridViewTextBoxColumn, Me.NomeClienteDataGridViewTextBoxColumn, Me.TipoEnderecoDataGridViewTextBoxColumn})
        Me.TbOSDataGridView.DataSource = Me.TbOSBindingSource
        Me.TbOSDataGridView.Location = New System.Drawing.Point(789, 27)
        Me.TbOSDataGridView.Name = "TbOSDataGridView"
        Me.TbOSDataGridView.Size = New System.Drawing.Size(21, 10)
        Me.TbOSDataGridView.TabIndex = 6
        Me.TbOSDataGridView.Visible = False
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        '
        'CodClienteDataGridViewTextBoxColumn
        '
        Me.CodClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.HeaderText = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.Name = "CodClienteDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TecRespDataGridViewTextBoxColumn
        '
        Me.TecRespDataGridViewTextBoxColumn.DataPropertyName = "TecResp"
        Me.TecRespDataGridViewTextBoxColumn.HeaderText = "TecResp"
        Me.TecRespDataGridViewTextBoxColumn.Name = "TecRespDataGridViewTextBoxColumn"
        '
        'DataAberturaDataGridViewTextBoxColumn
        '
        Me.DataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura"
        Me.DataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura"
        Me.DataAberturaDataGridViewTextBoxColumn.Name = "DataAberturaDataGridViewTextBoxColumn"
        '
        'DataAprovacaoDataGridViewTextBoxColumn
        '
        Me.DataAprovacaoDataGridViewTextBoxColumn.DataPropertyName = "DataAprovacao"
        Me.DataAprovacaoDataGridViewTextBoxColumn.HeaderText = "DataAprovacao"
        Me.DataAprovacaoDataGridViewTextBoxColumn.Name = "DataAprovacaoDataGridViewTextBoxColumn"
        '
        'NomeClienteDataGridViewTextBoxColumn
        '
        Me.NomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente"
        Me.NomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente"
        Me.NomeClienteDataGridViewTextBoxColumn.Name = "NomeClienteDataGridViewTextBoxColumn"
        '
        'TipoEnderecoDataGridViewTextBoxColumn
        '
        Me.TipoEnderecoDataGridViewTextBoxColumn.DataPropertyName = "TipoEndereco"
        Me.TipoEnderecoDataGridViewTextBoxColumn.HeaderText = "TipoEndereco"
        Me.TipoEnderecoDataGridViewTextBoxColumn.Name = "TipoEnderecoDataGridViewTextBoxColumn"
        '
        'TbOSBindingSource
        '
        Me.TbOSBindingSource.DataMember = "tbOS"
        Me.TbOSBindingSource.DataSource = Me.DataSetX
        '
        'TbObservacaoBindingSource
        '
        Me.TbObservacaoBindingSource.DataSource = Me.TbOSBindingSource
        '
        'OSIDTextBox
        '
        Me.OSIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "OSID", True))
        Me.OSIDTextBox.Location = New System.Drawing.Point(104, 66)
        Me.OSIDTextBox.Name = "OSIDTextBox"
        Me.OSIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OSIDTextBox.TabIndex = 8
        '
        'CodClienteTextBox
        '
        Me.CodClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "CodCliente", True))
        Me.CodClienteTextBox.Location = New System.Drawing.Point(85, 40)
        Me.CodClienteTextBox.Name = "CodClienteTextBox"
        Me.CodClienteTextBox.Size = New System.Drawing.Size(117, 20)
        Me.CodClienteTextBox.TabIndex = 10
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(104, 92)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 12
        '
        'TecRespTextBox
        '
        Me.TecRespTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "TecResp", True))
        Me.TecRespTextBox.Location = New System.Drawing.Point(104, 118)
        Me.TecRespTextBox.Name = "TecRespTextBox"
        Me.TecRespTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TecRespTextBox.TabIndex = 14
        '
        'DataAberturaDateTimePicker
        '
        Me.DataAberturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbOSBindingSource, "DataAbertura", True))
        Me.DataAberturaDateTimePicker.Location = New System.Drawing.Point(104, 144)
        Me.DataAberturaDateTimePicker.Name = "DataAberturaDateTimePicker"
        Me.DataAberturaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataAberturaDateTimePicker.TabIndex = 16
        '
        'DataAprovacaoDateTimePicker
        '
        Me.DataAprovacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbOSBindingSource, "DataAprovacao", True))
        Me.DataAprovacaoDateTimePicker.Location = New System.Drawing.Point(104, 170)
        Me.DataAprovacaoDateTimePicker.Name = "DataAprovacaoDateTimePicker"
        Me.DataAprovacaoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataAprovacaoDateTimePicker.TabIndex = 18
        '
        'NomeClienteTextBox
        '
        Me.NomeClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "NomeCliente", True))
        Me.NomeClienteTextBox.Location = New System.Drawing.Point(85, 14)
        Me.NomeClienteTextBox.Name = "NomeClienteTextBox"
        Me.NomeClienteTextBox.Size = New System.Drawing.Size(188, 20)
        Me.NomeClienteTextBox.TabIndex = 20
        '
        'TipoEnderecoTextBox
        '
        Me.TipoEnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbOSBindingSource, "TipoEndereco", True))
        Me.TipoEnderecoTextBox.Location = New System.Drawing.Point(104, 196)
        Me.TipoEnderecoTextBox.Name = "TipoEnderecoTextBox"
        Me.TipoEnderecoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TipoEnderecoTextBox.TabIndex = 22
        '
        'TbLancamentosBindingSource
        '
        Me.TbLancamentosBindingSource.DataMember = "tbOStbLancamentos"
        Me.TbLancamentosBindingSource.DataSource = Me.TbOSBindingSource
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbObservacaoBindingSource1, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(104, 222)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(200, 71)
        Me.ObservacaoTextBox.TabIndex = 48
        '
        'TbObservacaoBindingSource1
        '
        Me.TbObservacaoBindingSource1.DataMember = "tbOStbObservacao"
        Me.TbObservacaoBindingSource1.DataSource = Me.TbOSBindingSource
        '
        'TbOSTableAdapter1
        '
        Me.TbOSTableAdapter1.ClearBeforeFill = True
        '
        'TbHistoricoMedicaoTableAdapter1
        '
        Me.TbHistoricoMedicaoTableAdapter1.ClearBeforeFill = True
        '
        'TbFilaProducaoTableAdapter
        '
        Me.TbFilaProducaoTableAdapter.ClearBeforeFill = True
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.Location = New System.Drawing.Point(16, 12)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(108, 48)
        Me.btnFechar.TabIndex = 51
        Me.btnFechar.Text = "VOLTAR"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnLiberarPagamento
        '
        Me.btnLiberarPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnLiberarPagamento.FlatAppearance.BorderSize = 0
        Me.btnLiberarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiberarPagamento.Image = Global.ControleOS.My.Resources.Resources.Confirmar
        Me.btnLiberarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiberarPagamento.Location = New System.Drawing.Point(826, 292)
        Me.btnLiberarPagamento.Name = "btnLiberarPagamento"
        Me.btnLiberarPagamento.Size = New System.Drawing.Size(117, 53)
        Me.btnLiberarPagamento.TabIndex = 52
        Me.btnLiberarPagamento.Text = "Liberar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagamento"
        Me.btnLiberarPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLiberarPagamento.UseVisualStyleBackColor = False
        '
        'grpDetOS
        '
        Me.grpDetOS.BackColor = System.Drawing.Color.Transparent
        Me.grpDetOS.Controls.Add(Me.btnExpandirDetOS)
        Me.grpDetOS.Controls.Add(Me.btnMinimizarDetOS)
        Me.grpDetOS.Controls.Add(Me.OSIDTextBox)
        Me.grpDetOS.Controls.Add(Me.TipoEnderecoTextBox)
        Me.grpDetOS.Controls.Add(TipoEnderecoLabel)
        Me.grpDetOS.Controls.Add(ObservacaoLabel)
        Me.grpDetOS.Controls.Add(Me.DataAprovacaoDateTimePicker)
        Me.grpDetOS.Controls.Add(Me.ObservacaoTextBox)
        Me.grpDetOS.Controls.Add(DataAprovacaoLabel)
        Me.grpDetOS.Controls.Add(Me.DataAberturaDateTimePicker)
        Me.grpDetOS.Controls.Add(DataAberturaLabel)
        Me.grpDetOS.Controls.Add(Me.TecRespTextBox)
        Me.grpDetOS.Controls.Add(TecRespLabel)
        Me.grpDetOS.Controls.Add(Me.StatusTextBox)
        Me.grpDetOS.Controls.Add(StatusLabel)
        Me.grpDetOS.Controls.Add(OSIDLabel)
        Me.grpDetOS.ForeColor = System.Drawing.Color.White
        Me.grpDetOS.Location = New System.Drawing.Point(826, 164)
        Me.grpDetOS.Name = "grpDetOS"
        Me.grpDetOS.Size = New System.Drawing.Size(315, 46)
        Me.grpDetOS.TabIndex = 53
        Me.grpDetOS.TabStop = False
        Me.grpDetOS.Text = "Detalhes da OS"
        '
        'btnExpandirDetOS
        '
        Me.btnExpandirDetOS.Image = Global.ControleOS.My.Resources.Resources.SetaBaixo
        Me.btnExpandirDetOS.Location = New System.Drawing.Point(142, 15)
        Me.btnExpandirDetOS.Name = "btnExpandirDetOS"
        Me.btnExpandirDetOS.Size = New System.Drawing.Size(40, 25)
        Me.btnExpandirDetOS.TabIndex = 49
        Me.btnExpandirDetOS.UseVisualStyleBackColor = True
        '
        'btnMinimizarDetOS
        '
        Me.btnMinimizarDetOS.Image = Global.ControleOS.My.Resources.Resources.SetaCima
        Me.btnMinimizarDetOS.Location = New System.Drawing.Point(142, 15)
        Me.btnMinimizarDetOS.Name = "btnMinimizarDetOS"
        Me.btnMinimizarDetOS.Size = New System.Drawing.Size(40, 25)
        Me.btnMinimizarDetOS.TabIndex = 50
        Me.btnMinimizarDetOS.UseVisualStyleBackColor = True
        '
        'TbClientesBindingSource
        '
        Me.TbClientesBindingSource.DataMember = "tbClientes"
        Me.TbClientesBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbClientesTableAdapter
        '
        Me.TbClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager1.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager1.tbAgendaTableAdapter = Nothing
        Me.TableAdapterManager1.tbAndamentoOSTableAdapter = Nothing
        Me.TableAdapterManager1.tbAnexosTableAdapter = Nothing
        Me.TableAdapterManager1.tbClientes1TableAdapter = Nothing
        Me.TableAdapterManager1.tbClientes2TableAdapter = Nothing
        Me.TableAdapterManager1.tbClientes3TableAdapter = Nothing
        Me.TableAdapterManager1.tbClientesTableAdapter = Me.TbClientesTableAdapter
        Me.TableAdapterManager1.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager1.tbEndGesseiroTableAdapter = Nothing
        Me.TableAdapterManager1.tbEndTableAdapter = Nothing
        Me.TableAdapterManager1.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager1.tbFilaProducaoTableAdapter = Me.TbFilaProducaoTableAdapter
        Me.TableAdapterManager1.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager1.tbFormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager1.tbGesseirosTableAdapter = Nothing
        Me.TableAdapterManager1.tbHistoricoMedicaoTableAdapter = Me.TbHistoricoMedicaoTableAdapter1
        Me.TableAdapterManager1.tbInicialPagoTableAdapter = Nothing
        Me.TableAdapterManager1.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager1.tbLancarTableAdapter = Nothing
        Me.TableAdapterManager1.tbLiberacaoOSTableAdapter = Nothing
        Me.TableAdapterManager1.tbMedicaoTableAdapter = Nothing
        Me.TableAdapterManager1.tbObservacaoTableAdapter = Nothing
        Me.TableAdapterManager1.tbOSTableAdapter = Me.TbOSTableAdapter1
        Me.TableAdapterManager1.tbPagamentosRealizadosTableAdapter = Nothing
        Me.TableAdapterManager1.tbPagamentosTableAdapter = Nothing
        Me.TableAdapterManager1.tbPlanoContaTableAdapter = Nothing
        Me.TableAdapterManager1.tbPlanoDespesasTableAdapter = Nothing
        Me.TableAdapterManager1.tbPrecoTabelaTableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutoPDVTableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutos2TableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutoVenda1TableAdapter = Nothing
        Me.TableAdapterManager1.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager1.tbTipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbOStbHistoricoMedicaoBindingSource
        '
        Me.TbOStbHistoricoMedicaoBindingSource.DataMember = "tbOStbHistoricoMedicao"
        Me.TbOStbHistoricoMedicaoBindingSource.DataSource = Me.TbOSBindingSource1
        '
        'TbOStbFilaProducaoBindingSource
        '
        Me.TbOStbFilaProducaoBindingSource.DataMember = "tbOStbFilaProducao"
        Me.TbOStbFilaProducaoBindingSource.DataSource = Me.TbOSBindingSource1
        '
        'TbOStbHistoricoMedicaoBindingSource1
        '
        Me.TbOStbHistoricoMedicaoBindingSource1.DataMember = "tbOStbHistoricoMedicao"
        Me.TbOStbHistoricoMedicaoBindingSource1.DataSource = Me.TbOSBindingSource1
        '
        'TbOSTableAdapter
        '
        Me.TbOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbCalendarioTableAdapter = Nothing
        Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager.tbHistoricoMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbInicialPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbObservacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbOSTableAdapter = Me.TbOSTableAdapter
        Me.TableAdapterManager.tbProdutoVendaTableAdapter = Nothing
        Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataSetXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbHistoricoMedicaoTableAdapter
        '
        Me.TbHistoricoMedicaoTableAdapter.ClearBeforeFill = True
        '
        'TbLancamentosTableAdapter
        '
        Me.TbLancamentosTableAdapter.ClearBeforeFill = True
        '
        'TbObservacaoTableAdapter
        '
        Me.TbObservacaoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(NomeClienteLabel)
        Me.GroupBox1.Controls.Add(Me.NomeClienteTextBox)
        Me.GroupBox1.Controls.Add(Me.CodClienteTextBox)
        Me.GroupBox1.Controls.Add(CodClienteLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(826, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 77)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'OSIDDataGridViewTextBoxColumn1
        '
        Me.OSIDDataGridViewTextBoxColumn1.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn1.HeaderText = "OSID"
        Me.OSIDDataGridViewTextBoxColumn1.Name = "OSIDDataGridViewTextBoxColumn1"
        Me.OSIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicaoDataGridViewTextBoxColumn
        '
        Me.MedicaoDataGridViewTextBoxColumn.DataPropertyName = "Medicao"
        Me.MedicaoDataGridViewTextBoxColumn.HeaderText = "Medicao"
        Me.MedicaoDataGridViewTextBoxColumn.Name = "MedicaoDataGridViewTextBoxColumn"
        Me.MedicaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn
        '
        Me.UNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.Name = "UNIDADEDataGridViewTextBoxColumn"
        Me.UNIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeGesseiroDataGridViewTextBoxColumn
        '
        Me.NomeGesseiroDataGridViewTextBoxColumn.DataPropertyName = "NomeGesseiro"
        Me.NomeGesseiroDataGridViewTextBoxColumn.HeaderText = "NomeGesseiro"
        Me.NomeGesseiroDataGridViewTextBoxColumn.Name = "NomeGesseiroDataGridViewTextBoxColumn"
        Me.NomeGesseiroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacaoDataGridViewTextBoxColumn
        '
        Me.ObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao"
        Me.ObservacaoDataGridViewTextBoxColumn.HeaderText = "Observacao"
        Me.ObservacaoDataGridViewTextBoxColumn.Name = "ObservacaoDataGridViewTextBoxColumn"
        Me.ObservacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn1
        '
        Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
        Me.StatusDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GesseiroIDDataGridViewTextBoxColumn
        '
        Me.GesseiroIDDataGridViewTextBoxColumn.DataPropertyName = "GesseiroID"
        Me.GesseiroIDDataGridViewTextBoxColumn.HeaderText = "GesseiroID"
        Me.GesseiroIDDataGridViewTextBoxColumn.Name = "GesseiroIDDataGridViewTextBoxColumn"
        Me.GesseiroIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AReceberDataGridViewTextBoxColumn
        '
        Me.AReceberDataGridViewTextBoxColumn.DataPropertyName = "AReceber"
        Me.AReceberDataGridViewTextBoxColumn.HeaderText = "AReceber"
        Me.AReceberDataGridViewTextBoxColumn.Name = "AReceberDataGridViewTextBoxColumn"
        Me.AReceberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubIDDataGridViewTextBoxColumn
        '
        Me.SubIDDataGridViewTextBoxColumn.DataPropertyName = "SubID"
        Me.SubIDDataGridViewTextBoxColumn.HeaderText = "SubID"
        Me.SubIDDataGridViewTextBoxColumn.Name = "SubIDDataGridViewTextBoxColumn"
        Me.SubIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LiberacaoDataGridViewTextBoxColumn
        '
        Me.LiberacaoDataGridViewTextBoxColumn.DataPropertyName = "Liberacao"
        Me.LiberacaoDataGridViewTextBoxColumn.HeaderText = "Liberacao"
        Me.LiberacaoDataGridViewTextBoxColumn.Name = "LiberacaoDataGridViewTextBoxColumn"
        Me.LiberacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SelDataGridViewCheckBoxColumn
        '
        Me.SelDataGridViewCheckBoxColumn.DataPropertyName = "Sel"
        Me.SelDataGridViewCheckBoxColumn.HeaderText = "Sel"
        Me.SelDataGridViewCheckBoxColumn.Name = "SelDataGridViewCheckBoxColumn"
        Me.SelDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FrmLiberacaoMedicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDetOS)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCarreagar)
        Me.Controls.Add(Me.dgvPendente)
        Me.Controls.Add(Me.dgvLiberados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbOSDataGridView)
        Me.Controls.Add(Me.btnLiberarPagamento)
        Me.Name = "FrmLiberacaoMedicao"
        Me.Text = "LIBERAÇÃO DE PAGAMENTO DE MEDIÇÃO"
        CType(Me.dgvLiberados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPendente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbObservacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbLancamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbObservacaoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetOS.ResumeLayout(False)
        Me.grpDetOS.PerformLayout()
        CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOStbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOStbFilaProducaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOStbHistoricoMedicaoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvLiberados As DataGridView
    Friend WithEvents dgvPendente As DataGridView
    Friend WithEvents btnCarreagar As Button
    Friend WithEvents TbOSDataGridView As DataGridView
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbOSBindingSource As BindingSource
    Friend WithEvents TbOSTableAdapter As DataSetXTableAdapters.tbOSTableAdapter
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TecRespDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataAberturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataAprovacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoEnderecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DataSetXTableAdapters.TableAdapterManager
    Friend WithEvents TbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicaoTableAdapter As DataSetXTableAdapters.tbHistoricoMedicaoTableAdapter
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbOSBindingSource1 As BindingSource
    Friend WithEvents TbOSTableAdapter1 As SistemaGEDataSetTableAdapters.tbOSTableAdapter
    Friend WithEvents TbLancamentosBindingSource As BindingSource
    Friend WithEvents TbLancamentosTableAdapter As DataSetXTableAdapters.tbLancamentosTableAdapter
    Friend WithEvents TbObservacaoBindingSource As BindingSource
    Friend WithEvents OSIDTextBox As TextBox
    Friend WithEvents CodClienteTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents TecRespTextBox As TextBox
    Friend WithEvents DataAberturaDateTimePicker As DateTimePicker
    Friend WithEvents DataAprovacaoDateTimePicker As DateTimePicker
    Friend WithEvents NomeClienteTextBox As TextBox
    Friend WithEvents TipoEnderecoTextBox As TextBox
    Friend WithEvents TbObservacaoBindingSource1 As BindingSource
    Friend WithEvents TbObservacaoTableAdapter As DataSetXTableAdapters.tbObservacaoTableAdapter
    Friend WithEvents ObservacaoTextBox As TextBox
    Friend WithEvents TbOStbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicaoTableAdapter1 As SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter
    Friend WithEvents OSIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents TbOStbFilaProducaoBindingSource As BindingSource
    Friend WithEvents TbFilaProducaoTableAdapter As SistemaGEDataSetTableAdapters.tbFilaProducaoTableAdapter
    Friend WithEvents TbOStbHistoricoMedicaoBindingSource1 As BindingSource
    Friend WithEvents TbHistoricoMedicaoBindingSource1 As BindingSource
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnLiberarPagamento As Button
    Friend WithEvents grpDetOS As GroupBox
    Friend WithEvents TbClientesBindingSource As BindingSource
    Friend WithEvents TbClientesTableAdapter As SistemaGEDataSetTableAdapters.tbClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnExpandirDetOS As Button
    Friend WithEvents btnMinimizarDetOS As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Medicao As DataGridViewTextBoxColumn
    Friend WithEvents Observacao As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADE As DataGridViewTextBoxColumn
    Friend WithEvents NomeGesseiro As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents GesseiroID As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents AReceber As DataGridViewTextBoxColumn
    Friend WithEvents SubID As DataGridViewTextBoxColumn
    Friend WithEvents Liberacao As DataGridViewTextBoxColumn
    Friend WithEvents OSIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeGesseiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GesseiroIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AReceberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LiberacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
