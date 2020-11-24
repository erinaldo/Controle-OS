<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMedicaoEspecifica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedicaoEspecifica))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AReceber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeGesseiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbHistoricoMedicaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbHistoricoMedicaoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.IDDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.Medicao, Me.UNIDADEDataGridViewTextBoxColumn, Me.AReceber, Me.NomeGesseiro, Me.ObservacaoDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbHistoricoMedicaoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1522, 587)
        Me.DataGridView1.TabIndex = 20
        '
        'Data
        '
        Me.Data.DataPropertyName = "Data"
        Me.Data.HeaderText = "DATA"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Medicao
        '
        Me.Medicao.DataPropertyName = "Medicao"
        Me.Medicao.HeaderText = "MEDIÇÃO"
        Me.Medicao.Name = "Medicao"
        Me.Medicao.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn
        '
        Me.UNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.Name = "UNIDADEDataGridViewTextBoxColumn"
        Me.UNIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AReceber
        '
        Me.AReceber.DataPropertyName = "AReceber"
        Me.AReceber.HeaderText = "A RECEBER"
        Me.AReceber.Name = "AReceber"
        Me.AReceber.ReadOnly = True
        '
        'NomeGesseiro
        '
        Me.NomeGesseiro.DataPropertyName = "NomeGesseiro"
        Me.NomeGesseiro.HeaderText = "GESSEIRO"
        Me.NomeGesseiro.Name = "NomeGesseiro"
        Me.NomeGesseiro.ReadOnly = True
        '
        'ObservacaoDataGridViewTextBoxColumn
        '
        Me.ObservacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao"
        Me.ObservacaoDataGridViewTextBoxColumn.HeaderText = "OBSERVAÇÃO"
        Me.ObservacaoDataGridViewTextBoxColumn.Name = "ObservacaoDataGridViewTextBoxColumn"
        Me.ObservacaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbHistoricoMedicaoBindingSource
        '
        Me.TbHistoricoMedicaoBindingSource.DataMember = "tbHistoricoMedicao"
        Me.TbHistoricoMedicaoBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbHistoricoMedicaoTableAdapter
        '
        Me.TbHistoricoMedicaoTableAdapter.ClearBeforeFill = True
        '
        'FrmMedicaoEspecifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1522, 587)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMedicaoEspecifica"
        Me.Text = "MEDIÇÕES "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbHistoricoMedicaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbHistoricoMedicaoBindingSource As BindingSource
    Friend WithEvents TbHistoricoMedicaoTableAdapter As SistemaGEDataSetTableAdapters.tbHistoricoMedicaoTableAdapter
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Medicao As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AReceber As DataGridViewTextBoxColumn
    Friend WithEvents NomeGesseiro As DataGridViewTextBoxColumn
    Friend WithEvents ObservacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
