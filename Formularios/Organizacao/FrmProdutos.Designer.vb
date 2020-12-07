<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProdutos
	' Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdutos))
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
		Me.TbProdutoPDVDataGridView = New System.Windows.Forms.DataGridView()
		Me.TbProdutoPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoPDVTableAdapter()
		Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
		Me.TbPrecoTabelaTableAdapter = New ControleOS.DataPdvTableAdapters.tbPrecoTabelaTableAdapter()
		Me.btnVoltar = New System.Windows.Forms.Button()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.pbCodBarra = New System.Windows.Forms.ProgressBar()
		Me.btnRemCodBarra = New System.Windows.Forms.Button()
		Me.txtCodBarras = New System.Windows.Forms.TextBox()
		Me.btnAddCodBaras = New System.Windows.Forms.Button()
		Me.dgvCodBarras = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.cboEstoques = New System.Windows.Forms.ComboBox()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.btnSair = New System.Windows.Forms.Button()
		Me.btnFechar = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnEditPagRealizado = New System.Windows.Forms.Button()
		Me.btnAdicionarProduto = New System.Windows.Forms.Button()
		Me.btnExcluirProduto = New System.Windows.Forms.Button()
		Me.btnAtualizar = New System.Windows.Forms.Button()
		Me.TbPrecoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.lblEstoqueID = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbProdutoPDVDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbPrecoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(16, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "CÓDIGO"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.White
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
		Me.GroupBox1.Location = New System.Drawing.Point(104, 68)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(437, 172)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		'
		'Categoria_PadrãoTextBox
		'
		Me.Categoria_PadrãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo Total", True))
		Me.Categoria_PadrãoTextBox.Location = New System.Drawing.Point(16, 83)
		Me.Categoria_PadrãoTextBox.Name = "Categoria_PadrãoTextBox"
		Me.Categoria_PadrãoTextBox.Size = New System.Drawing.Size(78, 21)
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
		Me.ProdutoTextBox.Location = New System.Drawing.Point(16, 122)
		Me.ProdutoTextBox.Multiline = True
		Me.ProdutoTextBox.Name = "ProdutoTextBox"
		Me.ProdutoTextBox.Size = New System.Drawing.Size(414, 20)
		Me.ProdutoTextBox.TabIndex = 39
		'
		'txtTipo
		'
		Me.txtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Gênero", True))
		Me.txtTipo.Location = New System.Drawing.Point(290, 83)
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.Size = New System.Drawing.Size(140, 21)
		Me.txtTipo.TabIndex = 41
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(295, 67)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(31, 13)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "TIPO"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(100, 69)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 13)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "CUSTO"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(122, 24)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "VALOR UNITÁRIO"
		'
		'CustoTextBox
		'
		Me.CustoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
		Me.CustoTextBox.Location = New System.Drawing.Point(100, 83)
		Me.CustoTextBox.Name = "CustoTextBox"
		Me.CustoTextBox.Size = New System.Drawing.Size(100, 21)
		Me.CustoTextBox.TabIndex = 43
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(206, 69)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 13)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "QUANTIDADE"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(14, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "UNIDADE"
		'
		'txtProdutoID
		'
		Me.txtProdutoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "ProdutoID", True))
		Me.txtProdutoID.Location = New System.Drawing.Point(16, 40)
		Me.txtProdutoID.Name = "txtProdutoID"
		Me.txtProdutoID.Size = New System.Drawing.Size(100, 21)
		Me.txtProdutoID.TabIndex = 51
		'
		'Valor_VendaTextBox
		'
		Me.Valor_VendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Valor Venda", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
		Me.Valor_VendaTextBox.Location = New System.Drawing.Point(122, 40)
		Me.Valor_VendaTextBox.Name = "Valor_VendaTextBox"
		Me.Valor_VendaTextBox.Size = New System.Drawing.Size(140, 21)
		Me.Valor_VendaTextBox.TabIndex = 47
		'
		'SaldoEstoqueTextBox
		'
		Me.SaldoEstoqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "SaldoEstoque", True))
		Me.SaldoEstoqueTextBox.Location = New System.Drawing.Point(206, 83)
		Me.SaldoEstoqueTextBox.Name = "SaldoEstoqueTextBox"
		Me.SaldoEstoqueTextBox.ReadOnly = True
		Me.SaldoEstoqueTextBox.Size = New System.Drawing.Size(78, 21)
		Me.SaldoEstoqueTextBox.TabIndex = 53
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 107)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "DESCRIÇÃO"
		'
		'TbProdutoPDVDataGridView
		'
		Me.TbProdutoPDVDataGridView.AllowUserToAddRows = False
		Me.TbProdutoPDVDataGridView.AllowUserToDeleteRows = False
		Me.TbProdutoPDVDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TbProdutoPDVDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.TbProdutoPDVDataGridView.BackgroundColor = System.Drawing.Color.White
		Me.TbProdutoPDVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.TbProdutoPDVDataGridView.DefaultCellStyle = DataGridViewCellStyle2
		Me.TbProdutoPDVDataGridView.Location = New System.Drawing.Point(7, 19)
		Me.TbProdutoPDVDataGridView.Name = "TbProdutoPDVDataGridView"
		Me.TbProdutoPDVDataGridView.ReadOnly = True
		Me.TbProdutoPDVDataGridView.RowHeadersVisible = False
		Me.TbProdutoPDVDataGridView.RowHeadersWidth = 62
		Me.TbProdutoPDVDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.TbProdutoPDVDataGridView.Size = New System.Drawing.Size(1141, 329)
		Me.TbProdutoPDVDataGridView.TabIndex = 23
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
		'btnVoltar
		'
		Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVoltar.Location = New System.Drawing.Point(1690, 47)
		Me.btnVoltar.Name = "btnVoltar"
		Me.btnVoltar.Size = New System.Drawing.Size(110, 42)
		Me.btnVoltar.TabIndex = 2
		Me.btnVoltar.Text = "VOLTAR"
		Me.btnVoltar.UseVisualStyleBackColor = True
		'
		'Panel4
		'
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel4.Controls.Add(Me.pbCodBarra)
		Me.Panel4.Controls.Add(Me.btnRemCodBarra)
		Me.Panel4.Controls.Add(Me.txtCodBarras)
		Me.Panel4.Controls.Add(Me.btnAddCodBaras)
		Me.Panel4.Controls.Add(Me.dgvCodBarras)
		Me.Panel4.Location = New System.Drawing.Point(711, 522)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(164, 104)
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
		Me.txtCodBarras.Size = New System.Drawing.Size(242, 21)
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
		Me.dgvCodBarras.Location = New System.Drawing.Point(8, 3)
		Me.dgvCodBarras.Name = "dgvCodBarras"
		Me.dgvCodBarras.ReadOnly = True
		Me.dgvCodBarras.RowHeadersVisible = False
		Me.dgvCodBarras.RowHeadersWidth = 62
		Me.dgvCodBarras.Size = New System.Drawing.Size(240, 95)
		Me.dgvCodBarras.TabIndex = 31
		Me.dgvCodBarras.Visible = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.BackColor = System.Drawing.Color.White
		Me.GroupBox2.Controls.Add(Me.lblStatus)
		Me.GroupBox2.Controls.Add(Me.Label35)
		Me.GroupBox2.Controls.Add(Me.TbProdutoPDVDataGridView)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 279)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(1154, 382)
		Me.GroupBox2.TabIndex = 38
		Me.GroupBox2.TabStop = False
		'
		'lblStatus
		'
		Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.lblStatus.AutoSize = True
		Me.lblStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblStatus.Location = New System.Drawing.Point(84, 355)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(65, 13)
		Me.lblStatus.TabIndex = 70
		Me.lblStatus.Text = "Status Filtro"
		'
		'Label35
		'
		Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label35.AutoSize = True
		Me.Label35.BackColor = System.Drawing.Color.Transparent
		Me.Label35.Location = New System.Drawing.Point(9, 355)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(57, 13)
		Me.Label35.TabIndex = 69
		Me.Label35.Text = "N º Itens :"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(6, 17)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(14, 13)
		Me.Label8.TabIndex = 41
		Me.Label8.Text = "A"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(26, 17)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(14, 13)
		Me.Label9.TabIndex = 42
		Me.Label9.Text = "B"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(66, 17)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(15, 13)
		Me.Label10.TabIndex = 44
		Me.Label10.Text = "D"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(46, 17)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(14, 13)
		Me.Label11.TabIndex = 43
		Me.Label11.Text = "C"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(146, 16)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(15, 13)
		Me.Label12.TabIndex = 48
		Me.Label12.Text = "H"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(126, 16)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(15, 13)
		Me.Label13.TabIndex = 47
		Me.Label13.Text = "G"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(106, 16)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(13, 13)
		Me.Label14.TabIndex = 46
		Me.Label14.Text = "F"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = System.Drawing.Color.Transparent
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(86, 16)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(14, 13)
		Me.Label15.TabIndex = 45
		Me.Label15.Text = "E"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.BackColor = System.Drawing.Color.Transparent
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(226, 16)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(13, 13)
		Me.Label16.TabIndex = 52
		Me.Label16.Text = "L"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.BackColor = System.Drawing.Color.Transparent
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(206, 16)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(14, 13)
		Me.Label17.TabIndex = 51
		Me.Label17.Text = "K"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.BackColor = System.Drawing.Color.Transparent
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(186, 16)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(12, 13)
		Me.Label18.TabIndex = 50
		Me.Label18.Text = "J"
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.BackColor = System.Drawing.Color.Transparent
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(166, 16)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(10, 13)
		Me.Label19.TabIndex = 49
		Me.Label19.Text = "I"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.BackColor = System.Drawing.Color.Transparent
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(468, 15)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(14, 13)
		Me.Label20.TabIndex = 64
		Me.Label20.Text = "X"
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.BackColor = System.Drawing.Color.Transparent
		Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.Location = New System.Drawing.Point(446, 15)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(18, 13)
		Me.Label21.TabIndex = 63
		Me.Label21.Text = "W"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.BackColor = System.Drawing.Color.Transparent
		Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.Location = New System.Drawing.Point(426, 15)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(14, 13)
		Me.Label22.TabIndex = 62
		Me.Label22.Text = "V"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.BackColor = System.Drawing.Color.Transparent
		Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.Location = New System.Drawing.Point(406, 15)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(15, 13)
		Me.Label23.TabIndex = 61
		Me.Label23.Text = "U"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.BackColor = System.Drawing.Color.Transparent
		Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.Location = New System.Drawing.Point(386, 15)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(14, 13)
		Me.Label24.TabIndex = 60
		Me.Label24.Text = "T"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.BackColor = System.Drawing.Color.Transparent
		Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.Location = New System.Drawing.Point(366, 15)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(14, 13)
		Me.Label25.TabIndex = 59
		Me.Label25.Text = "S"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.BackColor = System.Drawing.Color.Transparent
		Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.Location = New System.Drawing.Point(346, 15)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(15, 13)
		Me.Label26.TabIndex = 58
		Me.Label26.Text = "R"
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.BackColor = System.Drawing.Color.Transparent
		Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label27.Location = New System.Drawing.Point(326, 15)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(15, 13)
		Me.Label27.TabIndex = 57
		Me.Label27.Text = "Q"
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.BackColor = System.Drawing.Color.Transparent
		Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.Location = New System.Drawing.Point(306, 16)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(14, 13)
		Me.Label28.TabIndex = 56
		Me.Label28.Text = "P"
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.BackColor = System.Drawing.Color.Transparent
		Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label29.Location = New System.Drawing.Point(286, 16)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(15, 13)
		Me.Label29.TabIndex = 55
		Me.Label29.Text = "O"
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.BackColor = System.Drawing.Color.Transparent
		Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label30.Location = New System.Drawing.Point(266, 16)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(15, 13)
		Me.Label30.TabIndex = 54
		Me.Label30.Text = "N"
		'
		'Label31
		'
		Me.Label31.AutoSize = True
		Me.Label31.BackColor = System.Drawing.Color.Transparent
		Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label31.Location = New System.Drawing.Point(246, 16)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(16, 13)
		Me.Label31.TabIndex = 53
		Me.Label31.Text = "M"
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.BackColor = System.Drawing.Color.Transparent
		Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label33.Location = New System.Drawing.Point(510, 15)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(14, 13)
		Me.Label33.TabIndex = 66
		Me.Label33.Text = "Z"
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.BackColor = System.Drawing.Color.Transparent
		Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label34.Location = New System.Drawing.Point(490, 15)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(14, 13)
		Me.Label34.TabIndex = 65
		Me.Label34.Text = "Y"
		'
		'cboEstoques
		'
		Me.cboEstoques.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cboEstoques.BackColor = System.Drawing.Color.MintCream
		Me.cboEstoques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEstoques.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.cboEstoques.FormattingEnabled = True
		Me.cboEstoques.Location = New System.Drawing.Point(1040, 236)
		Me.cboEstoques.Name = "cboEstoques"
		Me.cboEstoques.Size = New System.Drawing.Size(126, 21)
		Me.cboEstoques.Sorted = True
		Me.cboEstoques.TabIndex = 68
		Me.cboEstoques.TabStop = False
		'
		'Label32
		'
		Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label32.AutoSize = True
		Me.Label32.BackColor = System.Drawing.Color.Transparent
		Me.Label32.Location = New System.Drawing.Point(1039, 214)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(51, 13)
		Me.Label32.TabIndex = 54
		Me.Label32.Text = "Estoques"
		'
		'btnSair
		'
		Me.btnSair.AccessibleDescription = "SAIR"
		Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSair.BackColor = System.Drawing.Color.Transparent
		Me.btnSair.BackgroundImage = Global.ControleOS.My.Resources.Resources.Desligar
		Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSair.FlatAppearance.BorderSize = 0
		Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnSair.Location = New System.Drawing.Point(1134, 28)
		Me.btnSair.Name = "btnSair"
		Me.btnSair.Size = New System.Drawing.Size(32, 32)
		Me.btnSair.TabIndex = 69
		Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSair.UseVisualStyleBackColor = False
		'
		'btnFechar
		'
		Me.btnFechar.AccessibleDescription = "VOLTAR"
		Me.btnFechar.BackColor = System.Drawing.Color.White
		Me.btnFechar.BackgroundImage = Global.ControleOS.My.Resources.Resources.Voltar
		Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnFechar.Location = New System.Drawing.Point(12, 200)
		Me.btnFechar.Name = "btnFechar"
		Me.btnFechar.Size = New System.Drawing.Size(42, 40)
		Me.btnFechar.TabIndex = 40
		Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnFechar.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.Image = Global.ControleOS.My.Resources.Resources.NLG
		Me.PictureBox1.Location = New System.Drawing.Point(1698, 105)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(102, 83)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 10
		Me.PictureBox1.TabStop = False
		'
		'btnEditPagRealizado
		'
		Me.btnEditPagRealizado.BackColor = System.Drawing.Color.White
		Me.btnEditPagRealizado.BackgroundImage = Global.ControleOS.My.Resources.Resources.editar3
		Me.btnEditPagRealizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnEditPagRealizado.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnEditPagRealizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnEditPagRealizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnEditPagRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEditPagRealizado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnEditPagRealizado.Location = New System.Drawing.Point(12, 118)
		Me.btnEditPagRealizado.Name = "btnEditPagRealizado"
		Me.btnEditPagRealizado.Size = New System.Drawing.Size(42, 40)
		Me.btnEditPagRealizado.TabIndex = 9
		Me.btnEditPagRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEditPagRealizado.UseVisualStyleBackColor = False
		'
		'btnAdicionarProduto
		'
		Me.btnAdicionarProduto.BackColor = System.Drawing.Color.White
		Me.btnAdicionarProduto.BackgroundImage = Global.ControleOS.My.Resources.Resources.Adicionar1
		Me.btnAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnAdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAdicionarProduto.Location = New System.Drawing.Point(12, 76)
		Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
		Me.btnAdicionarProduto.Size = New System.Drawing.Size(42, 40)
		Me.btnAdicionarProduto.TabIndex = 7
		Me.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAdicionarProduto.UseVisualStyleBackColor = False
		'
		'btnExcluirProduto
		'
		Me.btnExcluirProduto.BackColor = System.Drawing.Color.White
		Me.btnExcluirProduto.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cancelar
		Me.btnExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnExcluirProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnExcluirProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnExcluirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnExcluirProduto.Location = New System.Drawing.Point(12, 159)
		Me.btnExcluirProduto.Name = "btnExcluirProduto"
		Me.btnExcluirProduto.Size = New System.Drawing.Size(42, 40)
		Me.btnExcluirProduto.TabIndex = 8
		Me.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnExcluirProduto.UseVisualStyleBackColor = False
		'
		'btnAtualizar
		'
		Me.btnAtualizar.BackColor = System.Drawing.Color.White
		Me.btnAtualizar.BackgroundImage = Global.ControleOS.My.Resources.Resources.Atualizar
		Me.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAtualizar.Location = New System.Drawing.Point(56, 76)
		Me.btnAtualizar.Name = "btnAtualizar"
		Me.btnAtualizar.Size = New System.Drawing.Size(42, 40)
		Me.btnAtualizar.TabIndex = 5
		Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAtualizar.UseVisualStyleBackColor = False
		'
		'TbPrecoTabelaBindingSource
		'
		Me.TbPrecoTabelaBindingSource.DataMember = "tbPrecoTabelatbProdutoPDV"
		Me.TbPrecoTabelaBindingSource.DataSource = Me.TbProdutoPDVBindingSource
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.Color.White
		Me.GroupBox3.Controls.Add(Me.Label36)
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Controls.Add(Me.Label9)
		Me.GroupBox3.Controls.Add(Me.Label11)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.Label33)
		Me.GroupBox3.Controls.Add(Me.Label15)
		Me.GroupBox3.Controls.Add(Me.Label34)
		Me.GroupBox3.Controls.Add(Me.Label14)
		Me.GroupBox3.Controls.Add(Me.Label20)
		Me.GroupBox3.Controls.Add(Me.Label13)
		Me.GroupBox3.Controls.Add(Me.Label21)
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.Label22)
		Me.GroupBox3.Controls.Add(Me.Label19)
		Me.GroupBox3.Controls.Add(Me.Label23)
		Me.GroupBox3.Controls.Add(Me.Label18)
		Me.GroupBox3.Controls.Add(Me.Label24)
		Me.GroupBox3.Controls.Add(Me.Label17)
		Me.GroupBox3.Controls.Add(Me.Label25)
		Me.GroupBox3.Controls.Add(Me.Label16)
		Me.GroupBox3.Controls.Add(Me.Label26)
		Me.GroupBox3.Controls.Add(Me.Label31)
		Me.GroupBox3.Controls.Add(Me.Label27)
		Me.GroupBox3.Controls.Add(Me.Label30)
		Me.GroupBox3.Controls.Add(Me.Label28)
		Me.GroupBox3.Controls.Add(Me.Label29)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 243)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(596, 37)
		Me.GroupBox3.TabIndex = 70
		Me.GroupBox3.TabStop = False
		'
		'Label36
		'
		Me.Label36.AutoSize = True
		Me.Label36.BackColor = System.Drawing.Color.Transparent
		Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label36.Location = New System.Drawing.Point(530, 15)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(37, 13)
		Me.Label36.TabIndex = 67
		Me.Label36.Text = "Todos"
		'
		'lblEstoqueID
		'
		Me.lblEstoqueID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblEstoqueID.AutoSize = True
		Me.lblEstoqueID.BackColor = System.Drawing.Color.Transparent
		Me.lblEstoqueID.Location = New System.Drawing.Point(977, 239)
		Me.lblEstoqueID.Name = "lblEstoqueID"
		Me.lblEstoqueID.Size = New System.Drawing.Size(57, 13)
		Me.lblEstoqueID.TabIndex = 71
		Me.lblEstoqueID.Text = "estoque id"
		'
		'FrmProdutos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.SystemColors.MenuBar
		Me.ClientSize = New System.Drawing.Size(1178, 698)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblEstoqueID)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnSair)
		Me.Controls.Add(Me.Label32)
		Me.Controls.Add(Me.cboEstoques)
		Me.Controls.Add(Me.btnFechar)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnEditPagRealizado)
		Me.Controls.Add(Me.btnAdicionarProduto)
		Me.Controls.Add(Me.btnExcluirProduto)
		Me.Controls.Add(Me.btnVoltar)
		Me.Controls.Add(Me.btnAtualizar)
		Me.Controls.Add(Me.Panel4)
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmProdutos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " PRODUTOS"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbProdutoPDVDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbPrecoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
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
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Panel4 As Panel
	Friend WithEvents btnRemCodBarra As Button
	Friend WithEvents btnAddCodBaras As Button
	Friend WithEvents dgvCodBarras As DataGridView
	Friend WithEvents txtCodBarras As TextBox
	Friend WithEvents pbCodBarra As ProgressBar
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnFechar As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents Label20 As Label
	Friend WithEvents Label21 As Label
	Friend WithEvents Label22 As Label
	Friend WithEvents Label23 As Label
	Friend WithEvents Label24 As Label
	Friend WithEvents Label25 As Label
	Friend WithEvents Label26 As Label
	Friend WithEvents Label27 As Label
	Friend WithEvents Label28 As Label
	Friend WithEvents Label29 As Label
	Friend WithEvents Label30 As Label
	Friend WithEvents Label31 As Label
	Friend WithEvents Label33 As Label
	Friend WithEvents Label34 As Label
	Friend WithEvents cboEstoques As ComboBox
	Friend WithEvents Label32 As Label
	Friend WithEvents Label35 As Label
	Friend WithEvents btnSair As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label36 As Label
	Friend WithEvents lblStatus As Label
	Friend WithEvents lblEstoqueID As Label
End Class
