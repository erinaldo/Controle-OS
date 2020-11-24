<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilaProducao
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
        Me.txtDataAprovacao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOSID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtStatusProducao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStatusPediso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TbProdutoVenda1DataGridView = New System.Windows.Forms.DataGridView()
        Me.txtVendaID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FiltroOSeIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FiltroOSeIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TbProdutoVenda1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbProdutoVenda1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProdutoVenda1TableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter()
        Me.TableAdapterManager = New ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager()
        CType(Me.TbProdutoVenda1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltroOSeIDToolStrip.SuspendLayout()
        CType(Me.TbProdutoVenda1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDataAprovacao
        '
        Me.txtDataAprovacao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "DataOrdemProducao", True))
        Me.txtDataAprovacao.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataAprovacao.Location = New System.Drawing.Point(18, 611)
        Me.txtDataAprovacao.Multiline = True
        Me.txtDataAprovacao.Name = "txtDataAprovacao"
        Me.txtDataAprovacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataAprovacao.Size = New System.Drawing.Size(434, 66)
        Me.txtDataAprovacao.TabIndex = 5
        Me.txtDataAprovacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 572)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(361, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DATA DE APROVAÇÃO"
        '
        'txtOSID
        '
        Me.txtOSID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "OSID", True))
        Me.txtOSID.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOSID.Location = New System.Drawing.Point(1273, 198)
        Me.txtOSID.Multiline = True
        Me.txtOSID.Name = "txtOSID"
        Me.txtOSID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOSID.Size = New System.Drawing.Size(207, 69)
        Me.txtOSID.TabIndex = 3
        Me.txtOSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1267, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OS - ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUTO DE PRODUÇÃO ATUAL "
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "Descricao", True))
        Me.txtNomeProduto.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProduto.Location = New System.Drawing.Point(18, 201)
        Me.txtNomeProduto.Multiline = True
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNomeProduto.Size = New System.Drawing.Size(880, 66)
        Me.txtNomeProduto.TabIndex = 0
        Me.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStatusProducao
        '
        Me.txtStatusProducao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "StatusProducao", True))
        Me.txtStatusProducao.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusProducao.Location = New System.Drawing.Point(661, 48)
        Me.txtStatusProducao.Multiline = True
        Me.txtStatusProducao.Name = "txtStatusProducao"
        Me.txtStatusProducao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStatusProducao.Size = New System.Drawing.Size(792, 107)
        Me.txtStatusProducao.TabIndex = 6
        Me.txtStatusProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(655, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "STATUS PRODUÇÃO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "STATUS PEDIDO"
        '
        'txtStatusPediso
        '
        Me.txtStatusPediso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "StatusProducao", True))
        Me.txtStatusPediso.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusPediso.Location = New System.Drawing.Point(18, 50)
        Me.txtStatusPediso.Multiline = True
        Me.txtStatusPediso.Name = "txtStatusPediso"
        Me.txtStatusPediso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStatusPediso.Size = New System.Drawing.Size(637, 105)
        Me.txtStatusPediso.TabIndex = 4
        Me.txtStatusPediso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(685, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 92)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "PRODUTO PRONTO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(685, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 92)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CANCELAR "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(685, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 92)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "EM PRODUÇÃO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(18, 694)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "SAIR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 36)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "QUANTIDADE"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "Quantidade", True))
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(18, 309)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(434, 107)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 36)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "UNIDADE"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "Unidade", True))
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(18, 463)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(434, 107)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbProdutoVenda1DataGridView
        '
        Me.TbProdutoVenda1DataGridView.AutoGenerateColumns = False
        Me.TbProdutoVenda1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbProdutoVenda1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.TbProdutoVenda1DataGridView.DataSource = Me.TbProdutoVenda1BindingSource1
        Me.TbProdutoVenda1DataGridView.Location = New System.Drawing.Point(904, 346)
        Me.TbProdutoVenda1DataGridView.Name = "TbProdutoVenda1DataGridView"
        Me.TbProdutoVenda1DataGridView.Size = New System.Drawing.Size(567, 361)
        Me.TbProdutoVenda1DataGridView.TabIndex = 20
        '
        'txtVendaID
        '
        Me.txtVendaID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoVenda1BindingSource1, "ID", True))
        Me.txtVendaID.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendaID.Location = New System.Drawing.Point(1060, 198)
        Me.txtVendaID.Multiline = True
        Me.txtVendaID.Name = "txtVendaID"
        Me.txtVendaID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVendaID.Size = New System.Drawing.Size(207, 69)
        Me.txtVendaID.TabIndex = 22
        Me.txtVendaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1054, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 36)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "VENDA - ID"
        '
        'FiltroOSeIDToolStrip
        '
        Me.FiltroOSeIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltroOSeIDToolStripButton})
        Me.FiltroOSeIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FiltroOSeIDToolStrip.Name = "FiltroOSeIDToolStrip"
        Me.FiltroOSeIDToolStrip.Size = New System.Drawing.Size(1518, 25)
        Me.FiltroOSeIDToolStrip.TabIndex = 23
        Me.FiltroOSeIDToolStrip.Text = "FiltroOSeIDToolStrip"
        '
        'FiltroOSeIDToolStripButton
        '
        Me.FiltroOSeIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FiltroOSeIDToolStripButton.Name = "FiltroOSeIDToolStripButton"
        Me.FiltroOSeIDToolStripButton.Size = New System.Drawing.Size(70, 22)
        Me.FiltroOSeIDToolStripButton.Text = "FiltroOSeID"
        '
        'TbProdutoVenda1BindingSource1
        '
        Me.TbProdutoVenda1BindingSource1.DataMember = "tbProdutoVenda1"
        Me.TbProdutoVenda1BindingSource1.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Unidade"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unidade"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DataOrdemProducao"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DataOrdemProducao"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "StatusProducao"
        Me.DataGridViewTextBoxColumn14.HeaderText = "StatusProducao"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'TbProdutoVenda1BindingSource
        '
        Me.TbProdutoVenda1BindingSource.DataMember = "tbProdutoVenda1"
        Me.TbProdutoVenda1BindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbProdutoVenda1TableAdapter
        '
        Me.TbProdutoVenda1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClientes1TableAdapter = Nothing
        Me.TableAdapterManager.tbClientes3TableAdapter = Nothing
        Me.TableAdapterManager.tbClientesTableAdapter = Nothing
        Me.TableAdapterManager.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager.tbEndTableAdapter = Nothing
        Me.TableAdapterManager.tbFilaProducaoTableAdapter = Nothing
        Me.TableAdapterManager.tbGesseirosTableAdapter = Nothing
        Me.TableAdapterManager.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbLiberacaoOSTableAdapter = Nothing
        Me.TableAdapterManager.tbMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbOSTableAdapter = Nothing
        Me.TableAdapterManager.tbPagamentosRealizadosTableAdapter = Nothing
        Me.TableAdapterManager.tbPagamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutos2TableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVenda1TableAdapter = Me.TbProdutoVenda1TableAdapter
        Me.TableAdapterManager.tbTipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.SistemaGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmFilaProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1518, 848)
        Me.Controls.Add(Me.FiltroOSeIDToolStrip)
        Me.Controls.Add(Me.txtVendaID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbProdutoVenda1DataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtDataAprovacao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStatusProducao)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtOSID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeProduto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtStatusPediso)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmFilaProducao"
        Me.Text = "FILA DE PRODUÇÃO"
        CType(Me.TbProdutoVenda1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltroOSeIDToolStrip.ResumeLayout(False)
        Me.FiltroOSeIDToolStrip.PerformLayout()
        CType(Me.TbProdutoVenda1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProdutoVenda1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStatusPediso As TextBox
    Friend WithEvents txtOSID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStatusProducao As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtDataAprovacao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbProdutoVenda1BindingSource As BindingSource
    Friend WithEvents TbProdutoVenda1TableAdapter As SistemaGEDataSetTableAdapters.tbProdutoVenda1TableAdapter
    Friend WithEvents TableAdapterManager As SistemaGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbProdutoVenda1DataGridView As DataGridView
    Friend WithEvents TbProdutoVenda1BindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents txtVendaID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FiltroOSeIDToolStrip As ToolStrip
    Friend WithEvents FiltroOSeIDToolStripButton As ToolStripButton
End Class
