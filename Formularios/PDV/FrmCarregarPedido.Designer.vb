<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarregarPedido
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
		Me.DataPdv = New ControleOS.DataPdv()
		Me.TbPedido2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TbPedido2TableAdapter = New ControleOS.DataPdvTableAdapters.tbPedido2TableAdapter()
		Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
		Me.TbPedido2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.txtCliente = New System.Windows.Forms.ToolStripTextBox()
		Me.btnCarregarPedido = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
		Me.txtPedidoID = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
		Me.txtClienteID = New System.Windows.Forms.ToolStripTextBox()
		Me.dgvPedidos = New System.Windows.Forms.DataGridView()
		Me.TbEndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TbEndTableAdapter = New ControleOS.DataPdvTableAdapters.tbEndTableAdapter()
		Me.btnAplicarFiltro = New System.Windows.Forms.Button()
		Me.cboStatusFaturamento = New System.Windows.Forms.ComboBox()
		Me.txtDataInicial = New System.Windows.Forms.DateTimePicker()
		Me.txtDataFinal = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cboDataFiltro = New System.Windows.Forms.ComboBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbPedido2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbPedido2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TbPedido2BindingNavigator.SuspendLayout()
		CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataPdv
		'
		Me.DataPdv.DataSetName = "DataPDV"
		Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TbPedido2BindingSource
		'
		Me.TbPedido2BindingSource.DataMember = "tbPedido2"
		Me.TbPedido2BindingSource.DataSource = Me.DataPdv
		'
		'TbPedido2TableAdapter
		'
		Me.TbPedido2TableAdapter.ClearBeforeFill = True
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
		Me.TableAdapterManager.tbPedido2TableAdapter = Me.TbPedido2TableAdapter
		Me.TableAdapterManager.tbPedido2vincTableAdapter = Nothing
		Me.TableAdapterManager.tbPedidosAuxTableAdapter = Nothing
		Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Nothing
		Me.TableAdapterManager.tbProdutoPDVTableAdapter = Nothing
		Me.TableAdapterManager.tbProdutoVendaPDVTableAdapter = Nothing
		Me.TableAdapterManager.tbProdutoVendaPDVvincTableAdapter = Nothing
		Me.TableAdapterManager.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'TbPedido2BindingNavigator
		'
		Me.TbPedido2BindingNavigator.AddNewItem = Nothing
		Me.TbPedido2BindingNavigator.BindingSource = Me.TbPedido2BindingSource
		Me.TbPedido2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.TbPedido2BindingNavigator.DeleteItem = Nothing
		Me.TbPedido2BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.TbPedido2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.txtCliente, Me.btnCarregarPedido, Me.ToolStripLabel2, Me.txtPedidoID, Me.ToolStripLabel3, Me.txtClienteID})
		Me.TbPedido2BindingNavigator.Location = New System.Drawing.Point(0, 0)
		Me.TbPedido2BindingNavigator.MoveFirstItem = Nothing
		Me.TbPedido2BindingNavigator.MoveLastItem = Nothing
		Me.TbPedido2BindingNavigator.MoveNextItem = Nothing
		Me.TbPedido2BindingNavigator.MovePreviousItem = Nothing
		Me.TbPedido2BindingNavigator.Name = "TbPedido2BindingNavigator"
		Me.TbPedido2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.TbPedido2BindingNavigator.Size = New System.Drawing.Size(1345, 25)
		Me.TbPedido2BindingNavigator.TabIndex = 0
		Me.TbPedido2BindingNavigator.Text = "BindingNavigator1"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
		Me.BindingNavigatorCountItem.Text = "de {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
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
		Me.BindingNavigatorPositionItem.ReadOnly = True
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
		Me.ToolStripLabel1.Text = "Cliente:"
		'
		'txtCliente
		'
		Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtCliente.Name = "txtCliente"
		Me.txtCliente.Size = New System.Drawing.Size(200, 25)
		'
		'btnCarregarPedido
		'
		Me.btnCarregarPedido.BackgroundImage = Global.ControleOS.My.Resources.Resources.Carregar
		Me.btnCarregarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnCarregarPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnCarregarPedido.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnCarregarPedido.Name = "btnCarregarPedido"
		Me.btnCarregarPedido.Size = New System.Drawing.Size(23, 22)
		Me.btnCarregarPedido.Text = "Carregar Pedido"
		'
		'ToolStripLabel2
		'
		Me.ToolStripLabel2.Name = "ToolStripLabel2"
		Me.ToolStripLabel2.Size = New System.Drawing.Size(47, 22)
		Me.ToolStripLabel2.Text = "Pedido:"
		'
		'txtPedidoID
		'
		Me.txtPedidoID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtPedidoID.Name = "txtPedidoID"
		Me.txtPedidoID.ReadOnly = True
		Me.txtPedidoID.Size = New System.Drawing.Size(100, 25)
		'
		'ToolStripLabel3
		'
		Me.ToolStripLabel3.Name = "ToolStripLabel3"
		Me.ToolStripLabel3.Size = New System.Drawing.Size(61, 22)
		Me.ToolStripLabel3.Text = "Cliente ID:"
		'
		'txtClienteID
		'
		Me.txtClienteID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtClienteID.Name = "txtClienteID"
		Me.txtClienteID.ReadOnly = True
		Me.txtClienteID.Size = New System.Drawing.Size(100, 25)
		'
		'dgvPedidos
		'
		Me.dgvPedidos.AllowUserToAddRows = False
		Me.dgvPedidos.AllowUserToDeleteRows = False
		Me.dgvPedidos.AllowUserToOrderColumns = True
		Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvPedidos.BackgroundColor = System.Drawing.Color.White
		Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvPedidos.ImeMode = System.Windows.Forms.ImeMode.[On]
		Me.dgvPedidos.Location = New System.Drawing.Point(0, 111)
		Me.dgvPedidos.MultiSelect = False
		Me.dgvPedidos.Name = "dgvPedidos"
		Me.dgvPedidos.ReadOnly = True
		Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvPedidos.Size = New System.Drawing.Size(1345, 631)
		Me.dgvPedidos.TabIndex = 1
		'
		'TbEndBindingSource
		'
		Me.TbEndBindingSource.DataMember = "tbEnd"
		Me.TbEndBindingSource.DataSource = Me.DataPdv
		'
		'TbEndTableAdapter
		'
		Me.TbEndTableAdapter.ClearBeforeFill = True
		'
		'btnAplicarFiltro
		'
		Me.btnAplicarFiltro.Location = New System.Drawing.Point(1240, 62)
		Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
		Me.btnAplicarFiltro.Size = New System.Drawing.Size(93, 43)
		Me.btnAplicarFiltro.TabIndex = 2
		Me.btnAplicarFiltro.Text = "Aplicar Filtro"
		Me.btnAplicarFiltro.UseVisualStyleBackColor = True
		'
		'cboStatusFaturamento
		'
		Me.cboStatusFaturamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStatusFaturamento.FormattingEnabled = True
		Me.cboStatusFaturamento.Location = New System.Drawing.Point(801, 74)
		Me.cboStatusFaturamento.Name = "cboStatusFaturamento"
		Me.cboStatusFaturamento.Size = New System.Drawing.Size(167, 21)
		Me.cboStatusFaturamento.TabIndex = 3
		'
		'txtDataInicial
		'
		Me.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.txtDataInicial.Location = New System.Drawing.Point(6, 46)
		Me.txtDataInicial.Name = "txtDataInicial"
		Me.txtDataInicial.Size = New System.Drawing.Size(102, 20)
		Me.txtDataInicial.TabIndex = 4
		'
		'txtDataFinal
		'
		Me.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.txtDataFinal.Location = New System.Drawing.Point(139, 46)
		Me.txtDataFinal.Name = "txtDataFinal"
		Me.txtDataFinal.Size = New System.Drawing.Size(102, 20)
		Me.txtDataFinal.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(120, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(10, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "-"
		'
		'cboDataFiltro
		'
		Me.cboDataFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDataFiltro.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cboDataFiltro.FormattingEnabled = True
		Me.cboDataFiltro.Location = New System.Drawing.Point(6, 19)
		Me.cboDataFiltro.Name = "cboDataFiltro"
		Me.cboDataFiltro.Size = New System.Drawing.Size(235, 21)
		Me.cboDataFiltro.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboDataFiltro)
		Me.GroupBox1.Controls.Add(Me.txtDataInicial)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtDataFinal)
		Me.GroupBox1.Location = New System.Drawing.Point(987, 28)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(247, 77)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(805, 55)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(114, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Status de Faturamento"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(540, 65)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 10
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'FrmCarregarPedido
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(1345, 742)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.cboStatusFaturamento)
		Me.Controls.Add(Me.btnAplicarFiltro)
		Me.Controls.Add(Me.dgvPedidos)
		Me.Controls.Add(Me.TbPedido2BindingNavigator)
		Me.Name = "FrmCarregarPedido"
		Me.Text = " "
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbPedido2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbPedido2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TbPedido2BindingNavigator.ResumeLayout(False)
		Me.TbPedido2BindingNavigator.PerformLayout()
		CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataPdv As DataPdv
	Friend WithEvents TbPedido2BindingSource As BindingSource
	Friend WithEvents TbPedido2TableAdapter As DataPdvTableAdapters.tbPedido2TableAdapter
	Friend WithEvents TableAdapterManager As DataPdvTableAdapters.TableAdapterManager
	Friend WithEvents TbPedido2BindingNavigator As BindingNavigator
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents txtCliente As ToolStripTextBox
	Friend WithEvents dgvPedidos As DataGridView
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents btnCarregarPedido As ToolStripButton
	Friend WithEvents TbEndBindingSource As BindingSource
	Friend WithEvents TbEndTableAdapter As DataPdvTableAdapters.tbEndTableAdapter
	Friend WithEvents ToolStripLabel2 As ToolStripLabel
	Friend WithEvents txtPedidoID As ToolStripTextBox
	Friend WithEvents ToolStripLabel3 As ToolStripLabel
	Friend WithEvents txtClienteID As ToolStripTextBox
	Friend WithEvents btnAplicarFiltro As Button
	Friend WithEvents cboStatusFaturamento As ComboBox
	Friend WithEvents txtDataInicial As DateTimePicker
	Friend WithEvents txtDataFinal As DateTimePicker
	Friend WithEvents Label1 As Label
	Friend WithEvents cboDataFiltro As ComboBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
End Class
