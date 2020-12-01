<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProdutos
        ' Inherits System.Windows.Forms.Form

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
	      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdutos))
	      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
	      Me.Categoria_PadrãoTextBox = New System.Windows.Forms.TextBox()
	      Me.TbProdutoPDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataPdv = New ControleOS.DataPdv()
	      Me.ProdutoTextBox = New System.Windows.Forms.TextBox()
	      Me.txtTipo = New System.Windows.Forms.TextBox()
	      Me.Label7 = New System.Windows.Forms.Label()
	      Me.Label6 = New System.Windows.Forms.Label()
	      Me.Label5 = New System.Windows.Forms.Label()
	      Me.CustoTextBox = New System.Windows.Forms.TextBox()
	      Me.Label4 = New System.Windows.Forms.Label()
	      Me.Label3 = New System.Windows.Forms.Label()
	      Me.txtProdutoID = New System.Windows.Forms.TextBox()
	      Me.Valor_VendaTextBox = New System.Windows.Forms.TextBox()
	      Me.SaldoEstoqueTextBox = New System.Windows.Forms.TextBox()
	      Me.Label2 = New System.Windows.Forms.Label()
	      Me.TbPrecoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbProdutoPDVBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
	      Me.TbProdutoPDVBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
	      Me.btnMovimentacao = New System.Windows.Forms.ToolStripButton()
	      Me.TbProdutoPDVDataGridView = New System.Windows.Forms.DataGridView()
	      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TbProdutoPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoPDVTableAdapter()
	      Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
	      Me.TbPrecoTabelaTableAdapter = New ControleOS.DataPdvTableAdapters.tbPrecoTabelaTableAdapter()
	      Me.btnExcluirProduto = New System.Windows.Forms.Button()
	      Me.btnEditPagRealizado = New System.Windows.Forms.Button()
	      Me.btnAdicionarProduto = New System.Windows.Forms.Button()
	      Me.btnAtualizar = New System.Windows.Forms.Button()
	      Me.btnVoltar = New System.Windows.Forms.Button()
	      Me.Panel3 = New System.Windows.Forms.Panel()
	      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
	      Me.Panel4 = New System.Windows.Forms.Panel()
	      Me.pbCodBarra = New System.Windows.Forms.ProgressBar()
	      Me.btnRemCodBarra = New System.Windows.Forms.Button()
	      Me.txtCodBarras = New System.Windows.Forms.TextBox()
	      Me.btnAddCodBaras = New System.Windows.Forms.Button()
	      Me.dgvCodBarras = New System.Windows.Forms.DataGridView()
	      Me.GroupBox1.SuspendLayout()
	      CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbPrecoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbProdutoPDVBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.TbProdutoPDVBindingNavigator.SuspendLayout()
	      CType(Me.TbProdutoPDVDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel3.SuspendLayout()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel4.SuspendLayout()
	      CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.Location = New System.Drawing.Point(246, 27)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(49, 13)
	      Me.Label1.TabIndex = 3
	      Me.Label1.Text = "CÓDIGO"
	      '
	      'GroupBox1
	      '
	      Me.GroupBox1.BackColor = System.Drawing.Color.Gray
	      Me.GroupBox1.Controls.Add(Me.Categoria_PadrãoTextBox)
	      Me.GroupBox1.Controls.Add(Me.ProdutoTextBox)
	      Me.GroupBox1.Controls.Add(Me.txtTipo)
	      Me.GroupBox1.Controls.Add(Me.Label7)
	      Me.GroupBox1.Controls.Add(Me.Label6)
	      Me.GroupBox1.Controls.Add(Me.Label5)
	      Me.GroupBox1.Controls.Add(Me.CustoTextBox)
	      Me.GroupBox1.Controls.Add(Me.Label4)
	      Me.GroupBox1.Controls.Add(Me.Label3)
	      Me.GroupBox1.Controls.Add(Me.txtProdutoID)
	      Me.GroupBox1.Controls.Add(Me.Valor_VendaTextBox)
	      Me.GroupBox1.Controls.Add(Me.SaldoEstoqueTextBox)
	      Me.GroupBox1.Controls.Add(Me.Label2)
	      Me.GroupBox1.Controls.Add(Me.Label1)
	      Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
	      Me.GroupBox1.Name = "GroupBox1"
	      Me.GroupBox1.Size = New System.Drawing.Size(387, 156)
	      Me.GroupBox1.TabIndex = 4
	      Me.GroupBox1.TabStop = False
	      Me.GroupBox1.Text = "DETALHES"
	      '
	      'Categoria_PadrãoTextBox
	      '
	      Me.Categoria_PadrãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo Total", True))
	      Me.Categoria_PadrãoTextBox.Location = New System.Drawing.Point(16, 79)
	      Me.Categoria_PadrãoTextBox.Name = "Categoria_PadrãoTextBox"
	      Me.Categoria_PadrãoTextBox.Size = New System.Drawing.Size(78, 20)
	      Me.Categoria_PadrãoTextBox.TabIndex = 37
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
	      'ProdutoTextBox
	      '
	      Me.ProdutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Produto", True))
	      Me.ProdutoTextBox.Location = New System.Drawing.Point(15, 40)
	      Me.ProdutoTextBox.Multiline = True
	      Me.ProdutoTextBox.Name = "ProdutoTextBox"
	      Me.ProdutoTextBox.Size = New System.Drawing.Size(225, 20)
	      Me.ProdutoTextBox.TabIndex = 39
	      '
	      'txtTipo
	      '
	      Me.txtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Gênero", True))
	      Me.txtTipo.Location = New System.Drawing.Point(100, 123)
	      Me.txtTipo.Name = "txtTipo"
	      Me.txtTipo.Size = New System.Drawing.Size(140, 20)
	      Me.txtTipo.TabIndex = 41
	      '
	      'Label7
	      '
	      Me.Label7.AutoSize = True
	      Me.Label7.Location = New System.Drawing.Point(105, 107)
	      Me.Label7.Name = "Label7"
	      Me.Label7.Size = New System.Drawing.Size(32, 13)
	      Me.Label7.TabIndex = 15
	      Me.Label7.Text = "TIPO"
	      '
	      'Label6
	      '
	      Me.Label6.AutoSize = True
	      Me.Label6.Location = New System.Drawing.Point(251, 65)
	      Me.Label6.Name = "Label6"
	      Me.Label6.Size = New System.Drawing.Size(44, 13)
	      Me.Label6.TabIndex = 13
	      Me.Label6.Text = "CUSTO"
	      '
	      'Label5
	      '
	      Me.Label5.AutoSize = True
	      Me.Label5.Location = New System.Drawing.Point(106, 63)
	      Me.Label5.Name = "Label5"
	      Me.Label5.Size = New System.Drawing.Size(98, 13)
	      Me.Label5.TabIndex = 11
	      Me.Label5.Text = "VALOR UNITÁRIO"
	      '
	      'CustoTextBox
	      '
	      Me.CustoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
	      Me.CustoTextBox.Location = New System.Drawing.Point(246, 79)
	      Me.CustoTextBox.Name = "CustoTextBox"
	      Me.CustoTextBox.Size = New System.Drawing.Size(100, 20)
	      Me.CustoTextBox.TabIndex = 43
	      '
	      'Label4
	      '
	      Me.Label4.AutoSize = True
	      Me.Label4.Location = New System.Drawing.Point(16, 107)
	      Me.Label4.Name = "Label4"
	      Me.Label4.Size = New System.Drawing.Size(78, 13)
	      Me.Label4.TabIndex = 9
	      Me.Label4.Text = "QUANTIDADE"
	      '
	      'Label3
	      '
	      Me.Label3.AutoSize = True
	      Me.Label3.Location = New System.Drawing.Point(16, 63)
	      Me.Label3.Name = "Label3"
	      Me.Label3.Size = New System.Drawing.Size(56, 13)
	      Me.Label3.TabIndex = 7
	      Me.Label3.Text = "UNIDADE"
	      '
	      'txtProdutoID
	      '
	      Me.txtProdutoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "ProdutoID", True))
	      Me.txtProdutoID.Location = New System.Drawing.Point(246, 41)
	      Me.txtProdutoID.Name = "txtProdutoID"
	      Me.txtProdutoID.Size = New System.Drawing.Size(100, 20)
	      Me.txtProdutoID.TabIndex = 51
	      '
	      'Valor_VendaTextBox
	      '
	      Me.Valor_VendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Valor Venda", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
	      Me.Valor_VendaTextBox.Location = New System.Drawing.Point(100, 79)
	      Me.Valor_VendaTextBox.Name = "Valor_VendaTextBox"
	      Me.Valor_VendaTextBox.Size = New System.Drawing.Size(140, 20)
	      Me.Valor_VendaTextBox.TabIndex = 47
	      '
	      'SaldoEstoqueTextBox
	      '
	      Me.SaldoEstoqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "SaldoEstoque", True))
	      Me.SaldoEstoqueTextBox.Location = New System.Drawing.Point(16, 123)
	      Me.SaldoEstoqueTextBox.Name = "SaldoEstoqueTextBox"
	      Me.SaldoEstoqueTextBox.ReadOnly = True
	      Me.SaldoEstoqueTextBox.Size = New System.Drawing.Size(78, 20)
	      Me.SaldoEstoqueTextBox.TabIndex = 53
	      '
	      'Label2
	      '
	      Me.Label2.AutoSize = True
	      Me.Label2.Location = New System.Drawing.Point(12, 27)
	      Me.Label2.Name = "Label2"
	      Me.Label2.Size = New System.Drawing.Size(69, 13)
	      Me.Label2.TabIndex = 5
	      Me.Label2.Text = "DESCRIÇÃO"
	      '
	      'TbPrecoTabelaBindingSource
	      '
	      Me.TbPrecoTabelaBindingSource.DataMember = "tbPrecoTabelatbProdutoPDV"
	      Me.TbPrecoTabelaBindingSource.DataSource = Me.TbProdutoPDVBindingSource
	      '
	      'TbProdutoPDVBindingNavigator
	      '
	      Me.TbProdutoPDVBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
	      Me.TbProdutoPDVBindingNavigator.BindingSource = Me.TbProdutoPDVBindingSource
	      Me.TbProdutoPDVBindingNavigator.CountItem = Me.BindingNavigatorCountItem
	      Me.TbProdutoPDVBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
	      Me.TbProdutoPDVBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
	      Me.TbProdutoPDVBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
	      Me.TbProdutoPDVBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbProdutoPDVBindingNavigatorSaveItem, Me.btnMovimentacao})
	      Me.TbProdutoPDVBindingNavigator.Location = New System.Drawing.Point(568, 229)
	      Me.TbProdutoPDVBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
	      Me.TbProdutoPDVBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
	      Me.TbProdutoPDVBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
	      Me.TbProdutoPDVBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
	      Me.TbProdutoPDVBindingNavigator.Name = "TbProdutoPDVBindingNavigator"
	      Me.TbProdutoPDVBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
	      Me.TbProdutoPDVBindingNavigator.Size = New System.Drawing.Size(311, 27)
	      Me.TbProdutoPDVBindingNavigator.TabIndex = 23
	      Me.TbProdutoPDVBindingNavigator.Text = "BindingNavigator1"
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
	      'TbProdutoPDVBindingNavigatorSaveItem
	      '
	      Me.TbProdutoPDVBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.TbProdutoPDVBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbProdutoPDVBindingNavigatorSaveItem.Image"), System.Drawing.Image)
	      Me.TbProdutoPDVBindingNavigatorSaveItem.Name = "TbProdutoPDVBindingNavigatorSaveItem"
	      Me.TbProdutoPDVBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
	      Me.TbProdutoPDVBindingNavigatorSaveItem.Text = "Salvar Dados"
	      '
	      'btnMovimentacao
	      '
	      Me.btnMovimentacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	      Me.btnMovimentacao.Image = Global.ControleOS.My.Resources.Resources.setas
	      Me.btnMovimentacao.ImageTransparentColor = System.Drawing.Color.Magenta
	      Me.btnMovimentacao.Name = "btnMovimentacao"
	      Me.btnMovimentacao.Size = New System.Drawing.Size(24, 24)
	      Me.btnMovimentacao.Text = "ToolStripButton2"
	      '
	      'TbProdutoPDVDataGridView
	      '
	      Me.TbProdutoPDVDataGridView.AllowUserToAddRows = False
	      Me.TbProdutoPDVDataGridView.AllowUserToDeleteRows = False
	      Me.TbProdutoPDVDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
	  Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.TbProdutoPDVDataGridView.AutoGenerateColumns = False
	      Me.TbProdutoPDVDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.TbProdutoPDVDataGridView.BackgroundColor = System.Drawing.Color.Gray
	      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
	      DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
	      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
	      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
	      Me.TbProdutoPDVDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
	      Me.TbProdutoPDVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.TbProdutoPDVDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9})
	      Me.TbProdutoPDVDataGridView.DataSource = Me.TbProdutoPDVBindingSource
	      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
	      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.TbProdutoPDVDataGridView.DefaultCellStyle = DataGridViewCellStyle5
	      Me.TbProdutoPDVDataGridView.Location = New System.Drawing.Point(12, 262)
	      Me.TbProdutoPDVDataGridView.Name = "TbProdutoPDVDataGridView"
	      Me.TbProdutoPDVDataGridView.ReadOnly = True
	      DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
	      DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
	      DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
	      DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
	      Me.TbProdutoPDVDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
	      Me.TbProdutoPDVDataGridView.RowHeadersVisible = False
	      Me.TbProdutoPDVDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.TbProdutoPDVDataGridView.Size = New System.Drawing.Size(1256, 438)
	      Me.TbProdutoPDVDataGridView.TabIndex = 23
	      '
	      'DataGridViewTextBoxColumn2
	      '
	      Me.DataGridViewTextBoxColumn2.DataPropertyName = "Produto"
	      Me.DataGridViewTextBoxColumn2.HeaderText = "Produto"
	      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
	      Me.DataGridViewTextBoxColumn2.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn4
	      '
	      Me.DataGridViewTextBoxColumn4.DataPropertyName = "Custo"
	      DataGridViewCellStyle2.Format = "C2"
	      DataGridViewCellStyle2.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
	      Me.DataGridViewTextBoxColumn4.HeaderText = "Custo"
	      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
	      Me.DataGridViewTextBoxColumn4.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn5
	      '
	      Me.DataGridViewTextBoxColumn5.DataPropertyName = "Custo Total"
	      DataGridViewCellStyle3.Format = "C2"
	      DataGridViewCellStyle3.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
	      Me.DataGridViewTextBoxColumn5.HeaderText = "Custo Total"
	      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
	      Me.DataGridViewTextBoxColumn5.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn6
	      '
	      Me.DataGridViewTextBoxColumn6.DataPropertyName = "Valor Venda"
	      DataGridViewCellStyle4.Format = "C2"
	      DataGridViewCellStyle4.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
	      Me.DataGridViewTextBoxColumn6.HeaderText = "Valor Venda"
	      Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
	      Me.DataGridViewTextBoxColumn6.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn9
	      '
	      Me.DataGridViewTextBoxColumn9.DataPropertyName = "SaldoEstoque"
	      Me.DataGridViewTextBoxColumn9.HeaderText = "SaldoEstoque"
	      Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
	      Me.DataGridViewTextBoxColumn9.ReadOnly = True
	      '
	      'TbProdutoPDVTableAdapter
	      '
	      Me.TbProdutoPDVTableAdapter.ClearBeforeFill = True
	      '
	      'TableAdapterManager
	      '
	      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
	      Me.TableAdapterManager.EntregaTableAdapter = Nothing
	      Me.TableAdapterManager.tbAnexoPDVTableAdapter = Nothing
	      Me.TableAdapterManager.tbClientesTableAdapter = Nothing
	      Me.TableAdapterManager.tbContatoTableAdapter = Nothing
	      Me.TableAdapterManager.tbEndTableAdapter = Nothing
	      Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
	      Me.TableAdapterManager.tbPedido2TableAdapter = Nothing
	      Me.TableAdapterManager.tbPedido2vincTableAdapter = Nothing
	      Me.TableAdapterManager.tbPedidosAuxTableAdapter = Nothing
	      Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Me.TbPrecoTabelaTableAdapter
	      Me.TableAdapterManager.tbProdutoPDVTableAdapter = Me.TbProdutoPDVTableAdapter
	      Me.TableAdapterManager.tbProdutoVendaPDVTableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutoVendaPDVvincTableAdapter = Nothing
	      Me.TableAdapterManager.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'TbPrecoTabelaTableAdapter
	      '
	      Me.TbPrecoTabelaTableAdapter.ClearBeforeFill = True
	      '
	      'btnExcluirProduto
	      '
	      Me.btnExcluirProduto.BackColor = System.Drawing.Color.White
	      Me.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
	      Me.btnExcluirProduto.Location = New System.Drawing.Point(12, 219)
	      Me.btnExcluirProduto.Name = "btnExcluirProduto"
	      Me.btnExcluirProduto.Size = New System.Drawing.Size(134, 37)
	      Me.btnExcluirProduto.TabIndex = 8
	      Me.btnExcluirProduto.Text = "EXCLUIR PRODUTO"
	      Me.btnExcluirProduto.UseVisualStyleBackColor = False
	      '
	      'btnEditPagRealizado
	      '
	      Me.btnEditPagRealizado.BackColor = System.Drawing.Color.White
	      Me.btnEditPagRealizado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
	      Me.btnEditPagRealizado.Location = New System.Drawing.Point(12, 167)
	      Me.btnEditPagRealizado.Name = "btnEditPagRealizado"
	      Me.btnEditPagRealizado.Size = New System.Drawing.Size(134, 43)
	      Me.btnEditPagRealizado.TabIndex = 9
	      Me.btnEditPagRealizado.Text = "EDITAR PRODUTO"
	      Me.btnEditPagRealizado.UseVisualStyleBackColor = False
	      '
	      'btnAdicionarProduto
	      '
	      Me.btnAdicionarProduto.BackColor = System.Drawing.Color.White
	      Me.btnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
	      Me.btnAdicionarProduto.Location = New System.Drawing.Point(12, 71)
	      Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
	      Me.btnAdicionarProduto.Size = New System.Drawing.Size(134, 40)
	      Me.btnAdicionarProduto.TabIndex = 7
	      Me.btnAdicionarProduto.Text = "ADICIONAR PRODUTO"
	      Me.btnAdicionarProduto.UseVisualStyleBackColor = False
	      '
	      'btnAtualizar
	      '
	      Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnAtualizar.Location = New System.Drawing.Point(12, 117)
	      Me.btnAtualizar.Name = "btnAtualizar"
	      Me.btnAtualizar.Size = New System.Drawing.Size(134, 40)
	      Me.btnAtualizar.TabIndex = 5
	      Me.btnAtualizar.Text = "ATUALIZAR"
	      Me.btnAtualizar.UseVisualStyleBackColor = True
	      '
	      'btnVoltar
	      '
	      Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnVoltar.Location = New System.Drawing.Point(1195, 31)
	      Me.btnVoltar.Name = "btnVoltar"
	      Me.btnVoltar.Size = New System.Drawing.Size(73, 28)
	      Me.btnVoltar.TabIndex = 2
	      Me.btnVoltar.Text = "VOLTAR"
	      Me.btnVoltar.UseVisualStyleBackColor = True
	      '
	      'Panel3
	      '
	      Me.Panel3.AutoScroll = True
	      Me.Panel3.Controls.Add(Me.GroupBox1)
	      Me.Panel3.Location = New System.Drawing.Point(160, 71)
	      Me.Panel3.Name = "Panel3"
	      Me.Panel3.Size = New System.Drawing.Size(405, 185)
	      Me.Panel3.TabIndex = 25
	      '
	      'PictureBox1
	      '
	      Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.PictureBox1.Image = Global.ControleOS.My.Resources.Resources.NLG
	      Me.PictureBox1.Location = New System.Drawing.Point(1200, 70)
	      Me.PictureBox1.Name = "PictureBox1"
	      Me.PictureBox1.Size = New System.Drawing.Size(68, 55)
	      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
	      Me.PictureBox1.TabIndex = 10
	      Me.PictureBox1.TabStop = False
	      '
	      'Panel4
	      '
	      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel4.Controls.Add(Me.pbCodBarra)
	      Me.Panel4.Controls.Add(Me.btnRemCodBarra)
	      Me.Panel4.Controls.Add(Me.txtCodBarras)
	      Me.Panel4.Controls.Add(Me.btnAddCodBaras)
	      Me.Panel4.Controls.Add(Me.dgvCodBarras)
	      Me.Panel4.Location = New System.Drawing.Point(597, 395)
	      Me.Panel4.Name = "Panel4"
	      Me.Panel4.Size = New System.Drawing.Size(246, 156)
	      Me.Panel4.TabIndex = 37
	      '
	      'pbCodBarra
	      '
	      Me.pbCodBarra.Location = New System.Drawing.Point(-1, 145)
	      Me.pbCodBarra.Name = "pbCodBarra"
	      Me.pbCodBarra.Size = New System.Drawing.Size(246, 10)
	      Me.pbCodBarra.TabIndex = 38
	      '
	      'btnRemCodBarra
	      '
	      Me.btnRemCodBarra.BackgroundImage = Global.ControleOS.My.Resources.Resources._Sub
	      Me.btnRemCodBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnRemCodBarra.FlatAppearance.BorderSize = 0
	      Me.btnRemCodBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnRemCodBarra.Location = New System.Drawing.Point(37, 124)
	      Me.btnRemCodBarra.Name = "btnRemCodBarra"
	      Me.btnRemCodBarra.Size = New System.Drawing.Size(21, 15)
	      Me.btnRemCodBarra.TabIndex = 35
	      Me.btnRemCodBarra.UseVisualStyleBackColor = True
	      '
	      'txtCodBarras
	      '
	      Me.txtCodBarras.Location = New System.Drawing.Point(3, 100)
	      Me.txtCodBarras.Name = "txtCodBarras"
	      Me.txtCodBarras.Size = New System.Drawing.Size(242, 20)
	      Me.txtCodBarras.TabIndex = 32
	      '
	      'btnAddCodBaras
	      '
	      Me.btnAddCodBaras.BackgroundImage = Global.ControleOS.My.Resources.Resources.Add
	      Me.btnAddCodBaras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnAddCodBaras.FlatAppearance.BorderSize = 0
	      Me.btnAddCodBaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAddCodBaras.Location = New System.Drawing.Point(8, 124)
	      Me.btnAddCodBaras.Name = "btnAddCodBaras"
	      Me.btnAddCodBaras.Size = New System.Drawing.Size(23, 15)
	      Me.btnAddCodBaras.TabIndex = 34
	      Me.btnAddCodBaras.UseVisualStyleBackColor = True
	      '
	      'dgvCodBarras
	      '
	      Me.dgvCodBarras.AllowUserToAddRows = False
	      Me.dgvCodBarras.AllowUserToDeleteRows = False
	      Me.dgvCodBarras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvCodBarras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvCodBarras.Location = New System.Drawing.Point(3, -1)
	      Me.dgvCodBarras.Name = "dgvCodBarras"
	      Me.dgvCodBarras.ReadOnly = True
	      Me.dgvCodBarras.RowHeadersVisible = False
	      Me.dgvCodBarras.Size = New System.Drawing.Size(240, 95)
	      Me.dgvCodBarras.TabIndex = 31
	      Me.dgvCodBarras.Visible = False
	      '
	      'FrmProdutos
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.AutoScroll = True
	      Me.BackColor = System.Drawing.SystemColors.MenuBar
	      Me.ClientSize = New System.Drawing.Size(1280, 768)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.PictureBox1)
	      Me.Controls.Add(Me.btnEditPagRealizado)
	      Me.Controls.Add(Me.TbProdutoPDVBindingNavigator)
	      Me.Controls.Add(Me.btnAdicionarProduto)
	      Me.Controls.Add(Me.Panel3)
	      Me.Controls.Add(Me.btnExcluirProduto)
	      Me.Controls.Add(Me.btnVoltar)
	      Me.Controls.Add(Me.btnAtualizar)
	      Me.Controls.Add(Me.TbProdutoPDVDataGridView)
	      Me.Controls.Add(Me.Panel4)
	      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
	      Me.Name = "FrmProdutos"
	      Me.Text = "PRODUTOS"
	      Me.GroupBox1.ResumeLayout(False)
	      Me.GroupBox1.PerformLayout()
	      CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbPrecoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbProdutoPDVBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.TbProdutoPDVBindingNavigator.ResumeLayout(False)
	      Me.TbProdutoPDVBindingNavigator.PerformLayout()
	      CType(Me.TbProdutoPDVDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel3.ResumeLayout(False)
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel4.ResumeLayout(False)
	      Me.Panel4.PerformLayout()
	      CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)
	      Me.PerformLayout()

        End Sub
        Friend WithEvents btnVoltar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExcluirProduto As Button
    Friend WithEvents btnEditPagRealizado As Button
    Friend WithEvents btnAdicionarProduto As Button
    Friend WithEvents btnAtualizar As Button
	Friend WithEvents DataPdv As DataPdv
	Friend WithEvents TbProdutoPDVBindingSource As BindingSource
	Friend WithEvents TbProdutoPDVTableAdapter As DataPdvTableAdapters.tbProdutoPDVTableAdapter
	Friend WithEvents TableAdapterManager As DataPdvTableAdapters.TableAdapterManager
	Friend WithEvents TbProdutoPDVBindingNavigator As BindingNavigator
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
	Friend WithEvents TbProdutoPDVBindingNavigatorSaveItem As ToolStripButton
	Friend WithEvents TbPrecoTabelaTableAdapter As DataPdvTableAdapters.tbPrecoTabelaTableAdapter
	Friend WithEvents TbProdutoPDVDataGridView As DataGridView
	Friend WithEvents TbPrecoTabelaBindingSource As BindingSource
	Friend WithEvents ProdutoTextBox As TextBox
	Friend WithEvents txtProdutoID As TextBox
	Friend WithEvents SaldoEstoqueTextBox As TextBox
	Friend WithEvents txtTipo As TextBox
	Friend WithEvents CustoTextBox As TextBox
	Friend WithEvents Valor_VendaTextBox As TextBox
	Friend WithEvents Categoria_PadrãoTextBox As TextBox
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents Panel3 As Panel
        Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnMovimentacao As ToolStripButton
	Friend WithEvents Panel4 As Panel
	Friend WithEvents btnRemCodBarra As Button
	Friend WithEvents btnAddCodBaras As Button
	Friend WithEvents dgvCodBarras As DataGridView
	Friend WithEvents txtCodBarras As TextBox
	Friend WithEvents pbCodBarra As ProgressBar
End Class
