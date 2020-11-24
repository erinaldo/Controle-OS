<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovProduto
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMovProduto = New System.Windows.Forms.DataGridView()
        Me.ProdutoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoEstoqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbProdutoPDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataPdv = New ControleOS.DataPdv()
        Me.TbProdutoPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoPDVTableAdapter()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.btnSumProd = New System.Windows.Forms.Button()
        Me.btnDimProd = New System.Windows.Forms.Button()
        Me.txtQuanProd = New System.Windows.Forms.TextBox()
        Me.btnMov = New System.Windows.Forms.Button()
        Me.chkMultiMov = New System.Windows.Forms.CheckBox()
        Me.btnBorracha = New System.Windows.Forms.Button()
        Me.sadf = New System.Windows.Forms.Button()
        CType(Me.dgvMovProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMovProduto
        '
        Me.dgvMovProduto.AllowUserToAddRows = False
        Me.dgvMovProduto.AllowUserToDeleteRows = False
        Me.dgvMovProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMovProduto.AutoGenerateColumns = False
        Me.dgvMovProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovProduto.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovProduto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMovProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdutoIDDataGridViewTextBoxColumn, Me.ProdutoDataGridViewTextBoxColumn, Me.SaldoEstoqueDataGridViewTextBoxColumn, Me.UnidadeDataGridViewTextBoxColumn})
        Me.dgvMovProduto.DataSource = Me.TbProdutoPDVBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovProduto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMovProduto.GridColor = System.Drawing.Color.DimGray
        Me.dgvMovProduto.Location = New System.Drawing.Point(12, 112)
        Me.dgvMovProduto.Name = "dgvMovProduto"
        Me.dgvMovProduto.ReadOnly = True
        Me.dgvMovProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvMovProduto.RowHeadersVisible = False
        Me.dgvMovProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovProduto.Size = New System.Drawing.Size(776, 335)
        Me.dgvMovProduto.TabIndex = 0
        '
        'ProdutoIDDataGridViewTextBoxColumn
        '
        Me.ProdutoIDDataGridViewTextBoxColumn.DataPropertyName = "ProdutoID"
        Me.ProdutoIDDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.ProdutoIDDataGridViewTextBoxColumn.HeaderText = "Identificação"
        Me.ProdutoIDDataGridViewTextBoxColumn.Name = "ProdutoIDDataGridViewTextBoxColumn"
        Me.ProdutoIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdutoDataGridViewTextBoxColumn
        '
        Me.ProdutoDataGridViewTextBoxColumn.DataPropertyName = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.FillWeight = 220.0!
        Me.ProdutoDataGridViewTextBoxColumn.HeaderText = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.Name = "ProdutoDataGridViewTextBoxColumn"
        Me.ProdutoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoEstoqueDataGridViewTextBoxColumn
        '
        Me.SaldoEstoqueDataGridViewTextBoxColumn.DataPropertyName = "SaldoEstoque"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SaldoEstoqueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaldoEstoqueDataGridViewTextBoxColumn.FillWeight = 99.49239!
        Me.SaldoEstoqueDataGridViewTextBoxColumn.HeaderText = "SaldoEstoque"
        Me.SaldoEstoqueDataGridViewTextBoxColumn.Name = "SaldoEstoqueDataGridViewTextBoxColumn"
        Me.SaldoEstoqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadeDataGridViewTextBoxColumn
        '
        Me.UnidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.UnidadeDataGridViewTextBoxColumn.HeaderText = "Unidade"
        Me.UnidadeDataGridViewTextBoxColumn.Name = "UnidadeDataGridViewTextBoxColumn"
        Me.UnidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbProdutoPDVBindingSource
        '
        Me.TbProdutoPDVBindingSource.DataMember = "tbProdutoPDV"
        Me.TbProdutoPDVBindingSource.DataSource = Me.DataPdv
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProdutoPDVTableAdapter
        '
        Me.TbProdutoPDVTableAdapter.ClearBeforeFill = True
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProd.Location = New System.Drawing.Point(12, 67)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(608, 38)
        Me.txtNomeProd.TabIndex = 1
        '
        'btnSumProd
        '
        Me.btnSumProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSumProd.BackColor = System.Drawing.Color.Transparent
        Me.btnSumProd.BackgroundImage = Global.ControleOS.My.Resources.Resources.Add
        Me.btnSumProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSumProd.FlatAppearance.BorderSize = 0
        Me.btnSumProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumProd.Location = New System.Drawing.Point(681, 62)
        Me.btnSumProd.Name = "btnSumProd"
        Me.btnSumProd.Size = New System.Drawing.Size(27, 20)
        Me.btnSumProd.TabIndex = 3
        Me.btnSumProd.UseVisualStyleBackColor = False
        '
        'btnDimProd
        '
        Me.btnDimProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDimProd.BackColor = System.Drawing.Color.Transparent
        Me.btnDimProd.BackgroundImage = Global.ControleOS.My.Resources.Resources._Sub
        Me.btnDimProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDimProd.FlatAppearance.BorderSize = 0
        Me.btnDimProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDimProd.Location = New System.Drawing.Point(681, 86)
        Me.btnDimProd.Name = "btnDimProd"
        Me.btnDimProd.Size = New System.Drawing.Size(27, 20)
        Me.btnDimProd.TabIndex = 2
        Me.btnDimProd.UseVisualStyleBackColor = False
        '
        'txtQuanProd
        '
        Me.txtQuanProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuanProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuanProd.Location = New System.Drawing.Point(626, 67)
        Me.txtQuanProd.Name = "txtQuanProd"
        Me.txtQuanProd.Size = New System.Drawing.Size(49, 38)
        Me.txtQuanProd.TabIndex = 4
        Me.txtQuanProd.Text = "0"
        Me.txtQuanProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMov
        '
        Me.btnMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMov.BackColor = System.Drawing.Color.Transparent
        Me.btnMov.BackgroundImage = Global.ControleOS.My.Resources.Resources.Confirmar
        Me.btnMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMov.FlatAppearance.BorderSize = 0
        Me.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMov.Location = New System.Drawing.Point(735, 63)
        Me.btnMov.Name = "btnMov"
        Me.btnMov.Size = New System.Drawing.Size(53, 43)
        Me.btnMov.TabIndex = 5
        Me.btnMov.UseVisualStyleBackColor = False
        '
        'chkMultiMov
        '
        Me.chkMultiMov.AutoSize = True
        Me.chkMultiMov.Location = New System.Drawing.Point(12, 12)
        Me.chkMultiMov.Name = "chkMultiMov"
        Me.chkMultiMov.Size = New System.Drawing.Size(121, 17)
        Me.chkMultiMov.TabIndex = 6
        Me.chkMultiMov.Text = "Multi-Movimentação"
        Me.chkMultiMov.UseVisualStyleBackColor = True
        '
        'btnBorracha
        '
        Me.btnBorracha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorracha.BackColor = System.Drawing.Color.Transparent
        Me.btnBorracha.BackgroundImage = Global.ControleOS.My.Resources.Resources.Borracha_32
        Me.btnBorracha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorracha.FlatAppearance.BorderSize = 0
        Me.btnBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorracha.Location = New System.Drawing.Point(12, 41)
        Me.btnBorracha.Name = "btnBorracha"
        Me.btnBorracha.Size = New System.Drawing.Size(27, 20)
        Me.btnBorracha.TabIndex = 7
        Me.btnBorracha.UseVisualStyleBackColor = False
        '
        'sadf
        '
        Me.sadf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sadf.BackColor = System.Drawing.Color.Transparent
        Me.sadf.BackgroundImage = Global.ControleOS.My.Resources.Resources.Confirmar
        Me.sadf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sadf.FlatAppearance.BorderSize = 0
        Me.sadf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sadf.Location = New System.Drawing.Point(55, 41)
        Me.sadf.Name = "sadf"
        Me.sadf.Size = New System.Drawing.Size(27, 20)
        Me.sadf.TabIndex = 8
        Me.sadf.UseVisualStyleBackColor = False
        '
        'FrmMovProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sadf)
        Me.Controls.Add(Me.btnBorracha)
        Me.Controls.Add(Me.chkMultiMov)
        Me.Controls.Add(Me.btnMov)
        Me.Controls.Add(Me.txtQuanProd)
        Me.Controls.Add(Me.btnSumProd)
        Me.Controls.Add(Me.btnDimProd)
        Me.Controls.Add(Me.txtNomeProd)
        Me.Controls.Add(Me.dgvMovProduto)
        Me.Name = "FrmMovProduto"
        Me.Text = "FrmMovProduto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMovProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMovProduto As DataGridView
    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents TbProdutoPDVBindingSource As BindingSource
    Friend WithEvents TbProdutoPDVTableAdapter As DataPdvTableAdapters.tbProdutoPDVTableAdapter
    Friend WithEvents txtNomeProd As TextBox
    Friend WithEvents btnDimProd As Button
    Friend WithEvents btnSumProd As Button
    Friend WithEvents txtQuanProd As TextBox
    Friend WithEvents btnMov As Button
    Friend WithEvents ProdutoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents chkMultiMov As CheckBox
    Friend WithEvents btnBorracha As Button
    Friend WithEvents sadf As Button
End Class
