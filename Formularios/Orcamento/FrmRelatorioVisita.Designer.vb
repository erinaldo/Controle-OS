<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorioVisita
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtRelatorioOS = New System.Windows.Forms.TextBox()
        Me.btnInserirRelatorio = New System.Windows.Forms.Button()
        Me.dgvListaOS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRelatorios = New System.Windows.Forms.DataGridView()
        Me.btnDgvAnterior = New System.Windows.Forms.Button()
        Me.TbOStbRelatorioVisitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
        Me.TbOSTableAdapter = New ControleOS.DataSetXTableAdapters.tbOSTableAdapter()
        Me.TbRelatorioVisitaTableAdapter = New ControleOS.DataSetXTableAdapters.tbRelatorioVisitaTableAdapter()
        Me.OSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecRespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsavelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelatorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListaOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOStbRelatorioVisitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRelatorioOS
        '
        Me.txtRelatorioOS.ForeColor = System.Drawing.Color.Gray
        Me.txtRelatorioOS.Location = New System.Drawing.Point(695, 424)
        Me.txtRelatorioOS.Multiline = True
        Me.txtRelatorioOS.Name = "txtRelatorioOS"
        Me.txtRelatorioOS.Size = New System.Drawing.Size(540, 100)
        Me.txtRelatorioOS.TabIndex = 0
        Me.txtRelatorioOS.Text = "INFORME BREVEMENTE INFORMAÇÕES SOBRE A SITUAÇÃO DO LOCAL DE VISITA"
        '
        'btnInserirRelatorio
        '
        Me.btnInserirRelatorio.Location = New System.Drawing.Point(885, 530)
        Me.btnInserirRelatorio.Name = "btnInserirRelatorio"
        Me.btnInserirRelatorio.Size = New System.Drawing.Size(169, 49)
        Me.btnInserirRelatorio.TabIndex = 1
        Me.btnInserirRelatorio.Text = "CONFIRMAR RELATÓRIO"
        Me.btnInserirRelatorio.UseVisualStyleBackColor = True
        '
        'dgvListaOS
        '
        Me.dgvListaOS.AutoGenerateColumns = False
        Me.dgvListaOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OSIDDataGridViewTextBoxColumn, Me.NomeClienteDataGridViewTextBoxColumn, Me.TecRespDataGridViewTextBoxColumn})
        Me.dgvListaOS.DataSource = Me.TbOSBindingSource
        Me.dgvListaOS.Location = New System.Drawing.Point(16, 60)
        Me.dgvListaOS.Name = "dgvListaOS"
        Me.dgvListaOS.Size = New System.Drawing.Size(645, 519)
        Me.dgvListaOS.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LISTA DE ORÇAMENTOS/OBRAS"
        '
        'dgvRelatorios
        '
        Me.dgvRelatorios.AllowUserToAddRows = False
        Me.dgvRelatorios.AllowUserToDeleteRows = False
        Me.dgvRelatorios.AutoGenerateColumns = False
        Me.dgvRelatorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ResponsavelDataGridViewTextBoxColumn, Me.RelatorioDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn})
        Me.dgvRelatorios.DataSource = Me.TbOStbRelatorioVisitaBindingSource
        Me.dgvRelatorios.Location = New System.Drawing.Point(16, 60)
        Me.dgvRelatorios.Name = "dgvRelatorios"
        Me.dgvRelatorios.ReadOnly = True
        Me.dgvRelatorios.Size = New System.Drawing.Size(645, 519)
        Me.dgvRelatorios.TabIndex = 4
        '
        'btnDgvAnterior
        '
        '   Me.btnDgvAnterior.Image = Global.ControleOS.My.Resources.Resources.ic_back_97586
        Me.btnDgvAnterior.Location = New System.Drawing.Point(16, 60)
        Me.btnDgvAnterior.Name = "btnDgvAnterior"
        Me.btnDgvAnterior.Size = New System.Drawing.Size(40, 20)
        Me.btnDgvAnterior.TabIndex = 5
        Me.btnDgvAnterior.UseVisualStyleBackColor = True
        '
        'TbOStbRelatorioVisitaBindingSource
        '
        Me.TbOStbRelatorioVisitaBindingSource.DataMember = "tbOStbRelatorioVisita"
        Me.TbOStbRelatorioVisitaBindingSource.DataSource = Me.TbOSBindingSource
        '
        'TbOSBindingSource
        '
        Me.TbOSBindingSource.DataMember = "tbOS"
        Me.TbOSBindingSource.DataSource = Me.DataSetX
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbOSTableAdapter
        '
        Me.TbOSTableAdapter.ClearBeforeFill = True
        '
        'TbRelatorioVisitaTableAdapter
        '
        Me.TbRelatorioVisitaTableAdapter.ClearBeforeFill = True
        '
        'OSIDDataGridViewTextBoxColumn
        '
        Me.OSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID"
        Me.OSIDDataGridViewTextBoxColumn.HeaderText = "N° OS"
        Me.OSIDDataGridViewTextBoxColumn.Name = "OSIDDataGridViewTextBoxColumn"
        '
        'NomeClienteDataGridViewTextBoxColumn
        '
        Me.NomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente"
        Me.NomeClienteDataGridViewTextBoxColumn.HeaderText = "NOME DO CLIENTE"
        Me.NomeClienteDataGridViewTextBoxColumn.Name = "NomeClienteDataGridViewTextBoxColumn"
        '
        'TecRespDataGridViewTextBoxColumn
        '
        Me.TecRespDataGridViewTextBoxColumn.DataPropertyName = "TecResp"
        Me.TecRespDataGridViewTextBoxColumn.HeaderText = "TÉCNICO RESPONSÁVEL"
        Me.TecRespDataGridViewTextBoxColumn.Name = "TecRespDataGridViewTextBoxColumn"
        '
        'ResponsavelDataGridViewTextBoxColumn
        '
        Me.ResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel"
        Me.ResponsavelDataGridViewTextBoxColumn.FillWeight = 45.68528!
        Me.ResponsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel"
        Me.ResponsavelDataGridViewTextBoxColumn.Name = "ResponsavelDataGridViewTextBoxColumn"
        Me.ResponsavelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RelatorioDataGridViewTextBoxColumn
        '
        Me.RelatorioDataGridViewTextBoxColumn.DataPropertyName = "Relatorio"
        Me.RelatorioDataGridViewTextBoxColumn.FillWeight = 187.095!
        Me.RelatorioDataGridViewTextBoxColumn.HeaderText = "Relatorio"
        Me.RelatorioDataGridViewTextBoxColumn.Name = "RelatorioDataGridViewTextBoxColumn"
        Me.RelatorioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.FillWeight = 67.21975!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmRelatorioVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvListaOS)
        Me.Controls.Add(Me.btnInserirRelatorio)
        Me.Controls.Add(Me.txtRelatorioOS)
        Me.Controls.Add(Me.btnDgvAnterior)
        Me.Controls.Add(Me.dgvRelatorios)
        Me.Name = "FrmRelatorioVisita"
        Me.Text = "FrmRelatorioVisita"
        CType(Me.dgvListaOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOStbRelatorioVisitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRelatorioOS As TextBox
    Friend WithEvents btnInserirRelatorio As Button
    Friend WithEvents dgvListaOS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRelatorios As DataGridView
    Friend WithEvents btnDgvAnterior As Button
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbOSBindingSource As BindingSource
    Friend WithEvents TbOSTableAdapter As DataSetXTableAdapters.tbOSTableAdapter
    Friend WithEvents TbOStbRelatorioVisitaBindingSource As BindingSource
    Friend WithEvents TbRelatorioVisitaTableAdapter As DataSetXTableAdapters.tbRelatorioVisitaTableAdapter
    Friend WithEvents OSIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TecRespDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsavelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RelatorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
