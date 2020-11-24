<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAndamentoDaOS
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
        Me.dgvAndamentoOS = New System.Windows.Forms.DataGridView()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrcamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimpezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbAndamentoOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbAndamentoOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbAndamentoOSTableAdapter()
        Me.grpVisitas = New System.Windows.Forms.GroupBox()
        CType(Me.dgvAndamentoOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAndamentoOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAndamentoOS
        '
        Me.dgvAndamentoOS.AllowUserToAddRows = False
        Me.dgvAndamentoOS.AllowUserToDeleteRows = False
        Me.dgvAndamentoOS.AutoGenerateColumns = False
        Me.dgvAndamentoOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAndamentoOS.BackgroundColor = System.Drawing.Color.White
        Me.dgvAndamentoOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvAndamentoOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAndamentoOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.VisitaDataGridViewTextBoxColumn, Me.OrcamentoDataGridViewTextBoxColumn, Me.PagamentoDataGridViewTextBoxColumn, Me.InicioDataGridViewTextBoxColumn, Me.LimpezaDataGridViewTextBoxColumn, Me.VistoriaDataGridViewTextBoxColumn, Me.FinalDataGridViewTextBoxColumn})
        Me.dgvAndamentoOS.DataSource = Me.TbAndamentoOSBindingSource
        Me.dgvAndamentoOS.Location = New System.Drawing.Point(12, 43)
        Me.dgvAndamentoOS.Name = "dgvAndamentoOS"
        Me.dgvAndamentoOS.ReadOnly = True
        Me.dgvAndamentoOS.Size = New System.Drawing.Size(1050, 350)
        Me.dgvAndamentoOS.TabIndex = 0
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "N° OS"
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        Me.OSIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VisitaDataGridViewTextBoxColumn
        '
        Me.VisitaDataGridViewTextBoxColumn.DataPropertyName = "Visita"
        Me.VisitaDataGridViewTextBoxColumn.HeaderText = "VISITA"
        Me.VisitaDataGridViewTextBoxColumn.Name = "VisitaDataGridViewTextBoxColumn"
        Me.VisitaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrcamentoDataGridViewTextBoxColumn
        '
        Me.OrcamentoDataGridViewTextBoxColumn.DataPropertyName = "Orcamento"
        Me.OrcamentoDataGridViewTextBoxColumn.HeaderText = "ORÇAMENTO"
        Me.OrcamentoDataGridViewTextBoxColumn.Name = "OrcamentoDataGridViewTextBoxColumn"
        Me.OrcamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagamentoDataGridViewTextBoxColumn
        '
        Me.PagamentoDataGridViewTextBoxColumn.DataPropertyName = "Pagamento"
        Me.PagamentoDataGridViewTextBoxColumn.HeaderText = "PAGAMENTO"
        Me.PagamentoDataGridViewTextBoxColumn.Name = "PagamentoDataGridViewTextBoxColumn"
        Me.PagamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InicioDataGridViewTextBoxColumn
        '
        Me.InicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio"
        Me.InicioDataGridViewTextBoxColumn.HeaderText = "INICIO"
        Me.InicioDataGridViewTextBoxColumn.Name = "InicioDataGridViewTextBoxColumn"
        Me.InicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LimpezaDataGridViewTextBoxColumn
        '
        Me.LimpezaDataGridViewTextBoxColumn.DataPropertyName = "Limpeza"
        Me.LimpezaDataGridViewTextBoxColumn.HeaderText = "LIMPEZA"
        Me.LimpezaDataGridViewTextBoxColumn.Name = "LimpezaDataGridViewTextBoxColumn"
        Me.LimpezaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VistoriaDataGridViewTextBoxColumn
        '
        Me.VistoriaDataGridViewTextBoxColumn.DataPropertyName = "Vistoria"
        Me.VistoriaDataGridViewTextBoxColumn.HeaderText = "VISTORIA"
        Me.VistoriaDataGridViewTextBoxColumn.Name = "VistoriaDataGridViewTextBoxColumn"
        Me.VistoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FinalDataGridViewTextBoxColumn
        '
        Me.FinalDataGridViewTextBoxColumn.DataPropertyName = "Final"
        Me.FinalDataGridViewTextBoxColumn.HeaderText = "FINALIZADA"
        Me.FinalDataGridViewTextBoxColumn.Name = "FinalDataGridViewTextBoxColumn"
        Me.FinalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbAndamentoOSBindingSource
        '
        Me.TbAndamentoOSBindingSource.DataMember = "tbAndamentoOS"
        Me.TbAndamentoOSBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbAndamentoOSTableAdapter
        '
        Me.TbAndamentoOSTableAdapter.ClearBeforeFill = True
        '
        'grpVisitas
        '
        Me.grpVisitas.Location = New System.Drawing.Point(12, 474)
        Me.grpVisitas.Name = "grpVisitas"
        Me.grpVisitas.Size = New System.Drawing.Size(427, 303)
        Me.grpVisitas.TabIndex = 1
        Me.grpVisitas.TabStop = False
        Me.grpVisitas.Text = "VISITAS"
        '
        'FrmAndamentoDaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.grpVisitas)
        Me.Controls.Add(Me.dgvAndamentoOS)
        Me.Name = "FrmAndamentoDaOS"
        Me.Text = "FrmAndamentoDaOS"
        CType(Me.dgvAndamentoOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAndamentoOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAndamentoOS As DataGridView
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbAndamentoOSBindingSource As BindingSource
    Friend WithEvents TbAndamentoOSTableAdapter As SistemaGEDataSetTableAdapters.tbAndamentoOSTableAdapter
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisitaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrcamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimpezaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VistoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents grpVisitas As GroupBox
End Class
