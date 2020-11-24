<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnderecoEntrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnderecoEntrega))
        Dim CodEndLabel As System.Windows.Forms.Label
        Dim LogradouroLabel As System.Windows.Forms.Label
        Dim EndNumeroLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim UFLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataPdv = New ControleOS.DataPdv()
        Me.TbEndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbEndTableAdapter = New ControleOS.DataPdvTableAdapters.tbEndTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
        Me.TbEndBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbEndDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TbEndBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtEntregaID = New System.Windows.Forms.TextBox()
        Me.LogradouroTextBox = New System.Windows.Forms.TextBox()
        Me.EndNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.UFTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodEndLabel = New System.Windows.Forms.Label()
        LogradouroLabel = New System.Windows.Forms.Label()
        EndNumeroLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        UFLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEndBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbEndBindingNavigator.SuspendLayout()
        CType(Me.TbEndDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAnexoPDVTableAdapter = Nothing
        Me.TableAdapterManager.tbClientesTableAdapter = Nothing
        Me.TableAdapterManager.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager.tbEndTableAdapter = Me.TbEndTableAdapter
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager.tbPedido2TableAdapter = Nothing
        Me.TableAdapterManager.tbPedidosAuxTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoPDVTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVendaPDVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbEndBindingNavigator
        '
        Me.TbEndBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbEndBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TbEndBindingNavigator.BindingSource = Me.TbEndBindingSource
        Me.TbEndBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbEndBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbEndBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbEndBindingNavigatorSaveItem})
        Me.TbEndBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TbEndBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbEndBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbEndBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbEndBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbEndBindingNavigator.Name = "TbEndBindingNavigator"
        Me.TbEndBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbEndBindingNavigator.Size = New System.Drawing.Size(1061, 25)
        Me.TbEndBindingNavigator.TabIndex = 0
        Me.TbEndBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TbEndDataGridView
        '
        Me.TbEndDataGridView.AllowUserToAddRows = False
        Me.TbEndDataGridView.AllowUserToDeleteRows = False
        Me.TbEndDataGridView.AutoGenerateColumns = False
        Me.TbEndDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TbEndDataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.TbEndDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbEndDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8})
        Me.TbEndDataGridView.DataSource = Me.TbEndBindingSource
        Me.TbEndDataGridView.Location = New System.Drawing.Point(12, 122)
        Me.TbEndDataGridView.Name = "TbEndDataGridView"
        Me.TbEndDataGridView.ReadOnly = True
        Me.TbEndDataGridView.RowHeadersVisible = False
        Me.TbEndDataGridView.Size = New System.Drawing.Size(243, 228)
        Me.TbEndDataGridView.TabIndex = 1
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
        'TbEndBindingNavigatorSaveItem
        '
        Me.TbEndBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbEndBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbEndBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbEndBindingNavigatorSaveItem.Name = "TbEndBindingNavigatorSaveItem"
        Me.TbEndBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TbEndBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CodEndLabel
        '
        CodEndLabel.AutoSize = True
        CodEndLabel.Location = New System.Drawing.Point(264, 125)
        CodEndLabel.Name = "CodEndLabel"
        CodEndLabel.Size = New System.Drawing.Size(51, 13)
        CodEndLabel.TabIndex = 2
        CodEndLabel.Text = "Cod End:"
        '
        'txtEntregaID
        '
        Me.txtEntregaID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "CodEnd", True))
        Me.txtEntregaID.Location = New System.Drawing.Point(344, 122)
        Me.txtEntregaID.Name = "txtEntregaID"
        Me.txtEntregaID.Size = New System.Drawing.Size(276, 20)
        Me.txtEntregaID.TabIndex = 3
        '
        'LogradouroLabel
        '
        LogradouroLabel.AutoSize = True
        LogradouroLabel.Location = New System.Drawing.Point(264, 151)
        LogradouroLabel.Name = "LogradouroLabel"
        LogradouroLabel.Size = New System.Drawing.Size(64, 13)
        LogradouroLabel.TabIndex = 4
        LogradouroLabel.Text = "Logradouro:"
        '
        'LogradouroTextBox
        '
        Me.LogradouroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Logradouro", True))
        Me.LogradouroTextBox.Location = New System.Drawing.Point(344, 148)
        Me.LogradouroTextBox.Name = "LogradouroTextBox"
        Me.LogradouroTextBox.Size = New System.Drawing.Size(276, 20)
        Me.LogradouroTextBox.TabIndex = 5
        '
        'EndNumeroLabel
        '
        EndNumeroLabel.AutoSize = True
        EndNumeroLabel.Location = New System.Drawing.Point(264, 177)
        EndNumeroLabel.Name = "EndNumeroLabel"
        EndNumeroLabel.Size = New System.Drawing.Size(69, 13)
        EndNumeroLabel.TabIndex = 6
        EndNumeroLabel.Text = "End Numero:"
        '
        'EndNumeroTextBox
        '
        Me.EndNumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "EndNumero", True))
        Me.EndNumeroTextBox.Location = New System.Drawing.Point(344, 174)
        Me.EndNumeroTextBox.Name = "EndNumeroTextBox"
        Me.EndNumeroTextBox.Size = New System.Drawing.Size(276, 20)
        Me.EndNumeroTextBox.TabIndex = 7
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(264, 203)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 8
        BairroLabel.Text = "Bairro:"
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(344, 200)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(276, 20)
        Me.BairroTextBox.TabIndex = 9
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(264, 229)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 10
        CidadeLabel.Text = "Cidade:"
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(344, 226)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(276, 20)
        Me.CidadeTextBox.TabIndex = 11
        '
        'UFLabel
        '
        UFLabel.AutoSize = True
        UFLabel.Location = New System.Drawing.Point(264, 255)
        UFLabel.Name = "UFLabel"
        UFLabel.Size = New System.Drawing.Size(24, 13)
        UFLabel.TabIndex = 12
        UFLabel.Text = "UF:"
        '
        'UFTextBox
        '
        Me.UFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "UF", True))
        Me.UFTextBox.Location = New System.Drawing.Point(344, 252)
        Me.UFTextBox.Name = "UFTextBox"
        Me.UFTextBox.Size = New System.Drawing.Size(276, 20)
        Me.UFTextBox.TabIndex = 13
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(264, 281)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(74, 13)
        ComplementoLabel.TabIndex = 14
        ComplementoLabel.Text = "Complemento:"
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(344, 278)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(276, 20)
        Me.ComplementoTextBox.TabIndex = 15
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(264, 307)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 16
        TipoLabel.Text = "Tipo:"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(344, 304)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(276, 20)
        Me.TipoTextBox.TabIndex = 17
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(264, 333)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 18
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(344, 330)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(276, 20)
        Me.IDTextBox.TabIndex = 19
        '
        'Button1
        '
        ' Me.Button1.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 53)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Confirmar Endereço" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Entrega"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        ' Me.Button2.Image = Global.ControleOS.My.Resources.Resources.insert_new_add_21481
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(182, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 53)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Adicionar Novo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Endereço"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.Location = New System.Drawing.Point(8, 39)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(303, 23)
        Me.lblDescricao.TabIndex = 22
        Me.lblDescricao.Text = "Endereços Relacionados ao Cliente"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Tipo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn8.HeaderText = "TIPO DE ENDEREÇO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'FrmEnderecoEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1061, 447)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CodEndLabel)
        Me.Controls.Add(Me.txtEntregaID)
        Me.Controls.Add(LogradouroLabel)
        Me.Controls.Add(Me.LogradouroTextBox)
        Me.Controls.Add(EndNumeroLabel)
        Me.Controls.Add(Me.EndNumeroTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(UFLabel)
        Me.Controls.Add(Me.UFTextBox)
        Me.Controls.Add(ComplementoLabel)
        Me.Controls.Add(Me.ComplementoTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TbEndDataGridView)
        Me.Controls.Add(Me.TbEndBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmEnderecoEntrega"
        Me.Text = "FrmEnderecoEntrega"
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEndBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbEndBindingNavigator.ResumeLayout(False)
        Me.TbEndBindingNavigator.PerformLayout()
        CType(Me.TbEndDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents TbEndBindingSource As BindingSource
    Friend WithEvents TbEndTableAdapter As DataPdvTableAdapters.tbEndTableAdapter
    Friend WithEvents TableAdapterManager As DataPdvTableAdapters.TableAdapterManager
    Friend WithEvents TbEndBindingNavigator As BindingNavigator
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
    Friend WithEvents TbEndBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TbEndDataGridView As DataGridView
    Friend WithEvents txtEntregaID As TextBox
    Friend WithEvents LogradouroTextBox As TextBox
    Friend WithEvents EndNumeroTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents UFTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents lblDescricao As Label
End Class
