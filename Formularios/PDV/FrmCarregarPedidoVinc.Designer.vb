<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarregarPedidoVinc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataPdv = New ControleOS.DataPdv()
        Me.TbPedido2vincBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPedido2vincTableAdapter = New ControleOS.DataPdvTableAdapters.tbPedido2vincTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
        Me.TbPedido2vincBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbPedido2vincDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPedidoID = New System.Windows.Forms.Label()
        Me.txtClienteID = New System.Windows.Forms.Label()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPedido2vincBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPedido2vincBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbPedido2vincBindingNavigator.SuspendLayout()
        CType(Me.TbPedido2vincDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbPedido2vincBindingSource
        '
        Me.TbPedido2vincBindingSource.DataMember = "tbPedido2vinc"
        Me.TbPedido2vincBindingSource.DataSource = Me.DataPdv
        '
        'TbPedido2vincTableAdapter
        '
        Me.TbPedido2vincTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbPedido2vincTableAdapter = Me.TbPedido2vincTableAdapter
        Me.TableAdapterManager.tbPedidosAuxTableAdapter = Nothing
        Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoPDVTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVendaPDVTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVendaPDVvincTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbPedido2vincBindingNavigator
        '
        Me.TbPedido2vincBindingNavigator.AddNewItem = Nothing
        Me.TbPedido2vincBindingNavigator.BindingSource = Me.TbPedido2vincBindingSource
        Me.TbPedido2vincBindingNavigator.CountItem = Nothing
        Me.TbPedido2vincBindingNavigator.DeleteItem = Nothing
        Me.TbPedido2vincBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2})
        Me.TbPedido2vincBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TbPedido2vincBindingNavigator.MoveFirstItem = Nothing
        Me.TbPedido2vincBindingNavigator.MoveLastItem = Nothing
        Me.TbPedido2vincBindingNavigator.MoveNextItem = Nothing
        Me.TbPedido2vincBindingNavigator.MovePreviousItem = Nothing
        Me.TbPedido2vincBindingNavigator.Name = "TbPedido2vincBindingNavigator"
        Me.TbPedido2vincBindingNavigator.PositionItem = Nothing
        Me.TbPedido2vincBindingNavigator.Size = New System.Drawing.Size(1035, 25)
        Me.TbPedido2vincBindingNavigator.TabIndex = 0
        Me.TbPedido2vincBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        'TbPedido2vincDataGridView
        '
        Me.TbPedido2vincDataGridView.AllowUserToAddRows = False
        Me.TbPedido2vincDataGridView.AllowUserToDeleteRows = False
        Me.TbPedido2vincDataGridView.AutoGenerateColumns = False
        Me.TbPedido2vincDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbPedido2vincDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbPedido2vincDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.ClienteID, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14})
        Me.TbPedido2vincDataGridView.DataSource = Me.TbPedido2vincBindingSource
        Me.TbPedido2vincDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbPedido2vincDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TbPedido2vincDataGridView.MultiSelect = False
        Me.TbPedido2vincDataGridView.Name = "TbPedido2vincDataGridView"
        Me.TbPedido2vincDataGridView.ReadOnly = True
        Me.TbPedido2vincDataGridView.RowHeadersVisible = False
        Me.TbPedido2vincDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TbPedido2vincDataGridView.Size = New System.Drawing.Size(1035, 516)
        Me.TbPedido2vincDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PedidoID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Número do Pedido"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'ClienteID
        '
        Me.ClienteID.DataPropertyName = "ClienteID"
        Me.ClienteID.HeaderText = "Nº Cliente"
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ValorTotal"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn16.HeaderText = "Valor Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DataAbertura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data de Abertura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataAprovPedido"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data de Aprovação"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Vendedor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Frete"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "Frete"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Desconto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Desconto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPedidoID
        '
        Me.txtPedidoID.AutoSize = True
        Me.txtPedidoID.Location = New System.Drawing.Point(458, 9)
        Me.txtPedidoID.Name = "txtPedidoID"
        Me.txtPedidoID.Size = New System.Drawing.Size(39, 13)
        Me.txtPedidoID.TabIndex = 3
        Me.txtPedidoID.Text = "Label1"
        '
        'txtClienteID
        '
        Me.txtClienteID.AutoSize = True
        Me.txtClienteID.Location = New System.Drawing.Point(601, 10)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(39, 13)
        Me.txtClienteID.TabIndex = 4
        Me.txtClienteID.Text = "Label1"
        '
        'FrmCarregarPedidoVinc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 541)
        Me.Controls.Add(Me.txtClienteID)
        Me.Controls.Add(Me.txtPedidoID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbPedido2vincDataGridView)
        Me.Controls.Add(Me.TbPedido2vincBindingNavigator)
        Me.Name = "FrmCarregarPedidoVinc"
        Me.Text = "FrmCarregarPedidoVinc"
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPedido2vincBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPedido2vincBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbPedido2vincBindingNavigator.ResumeLayout(False)
        Me.TbPedido2vincBindingNavigator.PerformLayout()
        CType(Me.TbPedido2vincDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents TbPedido2vincBindingSource As BindingSource
    Friend WithEvents TbPedido2vincTableAdapter As DataPdvTableAdapters.tbPedido2vincTableAdapter
    Friend WithEvents TableAdapterManager As DataPdvTableAdapters.TableAdapterManager
    Friend WithEvents TbPedido2vincBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TbPedido2vincDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPedidoID As Label
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents txtClienteID As Label
End Class
