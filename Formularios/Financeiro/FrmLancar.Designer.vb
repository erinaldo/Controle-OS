<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLancar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLancar))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpcoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX1 = New ControleOS.DataSetX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TbFinanceiroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
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
        Me.TbFinanceiroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TbFinanceiroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurosAntecipaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.TbFinanceiroOpcoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdFiltroTodos = New System.Windows.Forms.RadioButton()
        Me.rdPago = New System.Windows.Forms.RadioButton()
        Me.rdNaoPago = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TbFinanceiroTableAdapter = New ControleOS.DataSetXTableAdapters.tbFinanceiroTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataSetXTableAdapters.TableAdapterManager()
        Me.OpcoesTableAdapter = New ControleOS.DataSetXTableAdapters.OpcoesTableAdapter()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbFinanceiroDataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbFinanceiroBindingNavigator.SuspendLayout()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroOpcoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFinanceiroDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(176, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor (R$)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data do Lançamento"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(335, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(153, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cliente / Fornecedor"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(494, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(153, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(650, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Forma de Pagamento"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(653, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(153, 20)
        Me.TextBox4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data do Vencimento"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(172, 111)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(153, 20)
        Me.TextBox5.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OpcoesBindingSource
        Me.ComboBox1.DisplayMember = "PlanoDeContas"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'OpcoesBindingSource
        '
        Me.OpcoesBindingSource.DataMember = "Opcoes"
        Me.OpcoesBindingSource.DataSource = Me.DataSetX1
        '
        'DataSetX1
        '
        Me.DataSetX1.DataSetName = "DataSetX"
        Me.DataSetX1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Plano de Conta"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(937, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.Text = "Foi Quitado?"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(487, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Juros de Antecipação"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(490, 110)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(153, 20)
        Me.TextBox6.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Juros de Antecipação"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(331, 111)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(153, 20)
        Me.TextBox7.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Descrição"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(13, 150)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(471, 42)
        Me.TextBox8.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Salvar Lançamento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Cancelar Cadastro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TbFinanceiroBindingNavigator
        '
        Me.TbFinanceiroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbFinanceiroBindingNavigator.BindingSource = Me.TbFinanceiroBindingSource
        Me.TbFinanceiroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbFinanceiroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbFinanceiroBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TbFinanceiroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbFinanceiroBindingNavigatorSaveItem})
        Me.TbFinanceiroBindingNavigator.Location = New System.Drawing.Point(798, 235)
        Me.TbFinanceiroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbFinanceiroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbFinanceiroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbFinanceiroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbFinanceiroBindingNavigator.Name = "TbFinanceiroBindingNavigator"
        Me.TbFinanceiroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbFinanceiroBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.TbFinanceiroBindingNavigator.TabIndex = 0
        Me.TbFinanceiroBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'TbFinanceiroBindingSource
        '
        Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource.DataSource = Me.DataSetX
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TbFinanceiroBindingNavigatorSaveItem
        '
        Me.TbFinanceiroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbFinanceiroBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbFinanceiroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbFinanceiroBindingNavigatorSaveItem.Name = "TbFinanceiroBindingNavigatorSaveItem"
        Me.TbFinanceiroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TbFinanceiroBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TbFinanceiroDataGridView
        '
        Me.TbFinanceiroDataGridView.AutoGenerateColumns = False
        Me.TbFinanceiroDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbFinanceiroDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.TbFinanceiroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbFinanceiroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12})
        Me.TbFinanceiroDataGridView.DataSource = Me.TbFinanceiroBindingSource
        Me.TbFinanceiroDataGridView.Location = New System.Drawing.Point(3, 263)
        Me.TbFinanceiroDataGridView.Name = "TbFinanceiroDataGridView"
        Me.TbFinanceiroDataGridView.Size = New System.Drawing.Size(1106, 454)
        Me.TbFinanceiroDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Identificação"
        Me.DataGridViewTextBoxColumn11.FillWeight = 99.8503!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Identificação Interna"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.FillWeight = 99.83627!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo (SIGE)"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn2.FillWeight = 99.81996!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn3.FillWeight = 99.80217!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn5.FillWeight = 99.85947!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Numero do Documento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Situacao"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.OpcoesBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "SituacaoPagamento"
        Me.DataGridViewTextBoxColumn6.FillWeight = 99.84529!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Situação"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Vencimento"
        Me.DataGridViewTextBoxColumn7.FillWeight = 99.82979!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Vencimento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn8.FillWeight = 99.8129!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Juros Antecipação"
        Me.DataGridViewTextBoxColumn9.FillWeight = 99.79446!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Juros Antecipação"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn10.FillWeight = 100.8528!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Valor Pago"
        Me.DataGridViewTextBoxColumn12.FillWeight = 99.83526!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Valor Pago"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        '
        'NumeroDocumentoDataGridViewTextBoxColumn
        '
        Me.NumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.Name = "NumeroDocumentoDataGridViewTextBoxColumn"
        '
        'SituacaoDataGridViewTextBoxColumn
        '
        Me.SituacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao"
        Me.SituacaoDataGridViewTextBoxColumn.HeaderText = "Situacao"
        Me.SituacaoDataGridViewTextBoxColumn.Name = "SituacaoDataGridViewTextBoxColumn"
        '
        'VencimentoDataGridViewTextBoxColumn
        '
        Me.VencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento"
        Me.VencimentoDataGridViewTextBoxColumn.Name = "VencimentoDataGridViewTextBoxColumn"
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        '
        'JurosAntecipaçãoDataGridViewTextBoxColumn
        '
        Me.JurosAntecipaçãoDataGridViewTextBoxColumn.DataPropertyName = "Juros Antecipação"
        Me.JurosAntecipaçãoDataGridViewTextBoxColumn.HeaderText = "Juros Antecipação"
        Me.JurosAntecipaçãoDataGridViewTextBoxColumn.Name = "JurosAntecipaçãoDataGridViewTextBoxColumn"
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        '
        'IdentificaçãoDataGridViewTextBoxColumn
        '
        Me.IdentificaçãoDataGridViewTextBoxColumn.DataPropertyName = "Identificação"
        Me.IdentificaçãoDataGridViewTextBoxColumn.HeaderText = "Identificação"
        Me.IdentificaçãoDataGridViewTextBoxColumn.Name = "IdentificaçãoDataGridViewTextBoxColumn"
        '
        'ValorPagoDataGridViewTextBoxColumn
        '
        Me.ValorPagoDataGridViewTextBoxColumn.DataPropertyName = "Valor Pago"
        Me.ValorPagoDataGridViewTextBoxColumn.HeaderText = "Valor Pago"
        Me.ValorPagoDataGridViewTextBoxColumn.Name = "ValorPagoDataGridViewTextBoxColumn"
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(13, 65)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 23
        Me.btnVoltar.Text = "VOLTAR"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'TbFinanceiroOpcoesBindingSource
        '
        Me.TbFinanceiroOpcoesBindingSource.DataMember = "tbFinanceiro_Opcoes"
        Me.TbFinanceiroOpcoesBindingSource.DataSource = Me.TbFinanceiroBindingSource
        '
        'rdFiltroTodos
        '
        Me.rdFiltroTodos.AutoSize = True
        Me.rdFiltroTodos.Checked = True
        Me.rdFiltroTodos.Location = New System.Drawing.Point(3, 235)
        Me.rdFiltroTodos.Name = "rdFiltroTodos"
        Me.rdFiltroTodos.Size = New System.Drawing.Size(55, 17)
        Me.rdFiltroTodos.TabIndex = 24
        Me.rdFiltroTodos.TabStop = True
        Me.rdFiltroTodos.Text = "Todos"
        Me.rdFiltroTodos.UseVisualStyleBackColor = True
        '
        'rdPago
        '
        Me.rdPago.AutoSize = True
        Me.rdPago.Location = New System.Drawing.Point(65, 235)
        Me.rdPago.Name = "rdPago"
        Me.rdPago.Size = New System.Drawing.Size(50, 17)
        Me.rdPago.TabIndex = 25
        Me.rdPago.TabStop = True
        Me.rdPago.Text = "Pago"
        Me.rdPago.UseVisualStyleBackColor = True
        '
        'rdNaoPago
        '
        Me.rdNaoPago.AutoSize = True
        Me.rdNaoPago.Location = New System.Drawing.Point(121, 235)
        Me.rdNaoPago.Name = "rdNaoPago"
        Me.rdNaoPago.Size = New System.Drawing.Size(73, 17)
        Me.rdNaoPago.TabIndex = 26
        Me.rdNaoPago.TabStop = True
        Me.rdNaoPago.Text = "Não Pago"
        Me.rdNaoPago.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Cliente"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(12, 28)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(317, 20)
        Me.TextBox9.TabIndex = 27
        '
        'TbFinanceiroTableAdapter
        '
        Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Me.TbFinanceiroTableAdapter
        Me.TableAdapterManager.tbHistoricoMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbInicialPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbObservacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbOSTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVendaTableAdapter = Nothing
        Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataSetXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpcoesTableAdapter
        '
        Me.OpcoesTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Valor Pago"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Valor Pago"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Identificação"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Identificação"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Juros Antecipação"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Juros Antecipação"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Vencimento"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Vencimento"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Situacao"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Situacao"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn17.HeaderText = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'TbFinanceiroDataGridView1
        '
        Me.TbFinanceiroDataGridView1.AutoGenerateColumns = False
        Me.TbFinanceiroDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbFinanceiroDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.TbFinanceiroDataGridView1.DataSource = Me.TbFinanceiroBindingSource
        Me.TbFinanceiroDataGridView1.Location = New System.Drawing.Point(856, 1)
        Me.TbFinanceiroDataGridView1.Name = "TbFinanceiroDataGridView1"
        Me.TbFinanceiroDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.TbFinanceiroDataGridView1.TabIndex = 29
        '
        'FrmLancar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 150)
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1350, 737)
        Me.Controls.Add(Me.TbFinanceiroDataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.rdNaoPago)
        Me.Controls.Add(Me.rdPago)
        Me.Controls.Add(Me.rdFiltroTodos)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.TbFinanceiroDataGridView)
        Me.Controls.Add(Me.TbFinanceiroBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FrmLancar"
        Me.Text = "FrmLancar"
        CType(Me.OpcoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbFinanceiroBindingNavigator.ResumeLayout(False)
        Me.TbFinanceiroBindingNavigator.PerformLayout()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroOpcoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFinanceiroDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbFinanceiroBindingSource As BindingSource
    Friend WithEvents TbFinanceiroTableAdapter As DataSetXTableAdapters.tbFinanceiroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetXTableAdapters.TableAdapterManager
    Friend WithEvents TbFinanceiroBindingNavigator As BindingNavigator
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
    Friend WithEvents TbFinanceiroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TbFinanceiroDataGridView As DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JurosAntecipaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnVoltar As Button
    Friend WithEvents DataSetX1 As DataSetX
    Friend WithEvents OpcoesBindingSource As BindingSource
    Friend WithEvents OpcoesTableAdapter As DataSetXTableAdapters.OpcoesTableAdapter
    Friend WithEvents TbFinanceiroOpcoesBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents rdFiltroTodos As RadioButton
    Friend WithEvents rdPago As RadioButton
    Friend WithEvents rdNaoPago As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents TbFinanceiroDataGridView1 As DataGridView
End Class
