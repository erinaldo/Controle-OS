<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TbClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.TbClientestbEndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label11 = New System.Windows.Forms.Label()
		Me.cboTipo = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.cboUF = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.btnConfirmar = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.TbClientestbContatoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.DataGridView3 = New System.Windows.Forms.DataGridView()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.cboTipoContato = New System.Windows.Forms.ComboBox()
		Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TbOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
		Me.TbClientesTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbClientesTableAdapter()
		Me.TbContatoTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbContatoTableAdapter()
		Me.TbEndTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbEndTableAdapter()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.btnAddRecebimento = New System.Windows.Forms.Button()
		Me.btnFechar = New System.Windows.Forms.Button()
		Me.PicPessoa = New System.Windows.Forms.PictureBox()
		Me.btnAtualizar = New System.Windows.Forms.Button()
		Me.txtRSstatus = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtFantasiaStatus = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnEditarEndereco = New System.Windows.Forms.Button()
		Me.TbClientestbContatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.pbColNacionalidade = New System.Windows.Forms.ProgressBar()
		Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
		Me.txtCodCliente = New System.Windows.Forms.TextBox()
		Me.pbColSobrenome = New System.Windows.Forms.ProgressBar()
		Me.pbColNaturalidade = New System.Windows.Forms.ProgressBar()
		Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
		Me.txtIE = New System.Windows.Forms.TextBox()
		Me.pbColNome = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.txtCidade = New System.Windows.Forms.TextBox()
		Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
		Me.txtCPF = New System.Windows.Forms.TextBox()
		Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
		Me.txtCodEnd = New System.Windows.Forms.TextBox()
		Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
		Me.txtComplemento = New System.Windows.Forms.TextBox()
		Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
		Me.txtNumero = New System.Windows.Forms.TextBox()
		Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
		Me.txtBairro = New System.Windows.Forms.TextBox()
		Me.ProgressBar7 = New System.Windows.Forms.ProgressBar()
		Me.txtLogradouro = New System.Windows.Forms.TextBox()
		Me.ProgressBar8 = New System.Windows.Forms.ProgressBar()
		Me.txtNumeroContato = New System.Windows.Forms.TextBox()
		Me.ProgressBar9 = New System.Windows.Forms.ProgressBar()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.ProgressBar10 = New System.Windows.Forms.ProgressBar()
		Me.txtDDD = New System.Windows.Forms.TextBox()
		Me.ProgressBar11 = New System.Windows.Forms.ProgressBar()
		Me.txtCodContato = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnExcRecebimento = New System.Windows.Forms.Button()
		Me.btnEditRecebimento = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.pbPesquisar = New System.Windows.Forms.ProgressBar()
		Me.txtPesquisa = New System.Windows.Forms.TextBox()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.txtCEP = New System.Windows.Forms.TextBox()
		Me.ProgressBar12 = New System.Windows.Forms.ProgressBar()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbClientestbEndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbClientestbContatoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PicPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbClientestbContatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(80, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
		Me.DataGridView1.Location = New System.Drawing.Point(97, 3)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(404, 129)
		Me.DataGridView1.TabIndex = 0
		'
		'TbClientesBindingSource
		'
		Me.TbClientesBindingSource.DataMember = "tbClientes"
		Me.TbClientesBindingSource.DataSource = Me.SistemaGEDataSet
		'
		'SistemaGEDataSet
		'
		Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
		Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(504, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 15)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nome Fantasia"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(631, 12)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 15)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Razão Social"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(504, 49)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 15)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "CPF / CNPJ"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(504, 84)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(74, 15)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "CÓD. CLIENTE"
		'
		'DataGridView2
		'
		Me.DataGridView2.AllowUserToAddRows = False
		Me.DataGridView2.AllowUserToDeleteRows = False
		Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(96, 2)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.ReadOnly = True
		Me.DataGridView2.RowHeadersVisible = False
		Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView2.Size = New System.Drawing.Size(405, 131)
		Me.DataGridView2.TabIndex = 15
		'
		'TbClientestbEndBindingSource
		'
		Me.TbClientestbEndBindingSource.DataMember = "tbClientestbEnd"
		Me.TbClientestbEndBindingSource.DataSource = Me.TbClientesBindingSource
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.White
		Me.Label11.Location = New System.Drawing.Point(722, 80)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(28, 15)
		Me.Label11.TabIndex = 51
		Me.Label11.Text = "TIPO"
		'
		'cboTipo
		'
		Me.cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.cboTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClientestbEndBindingSource, "Tipo", True))
		Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboTipo.ForeColor = System.Drawing.Color.White
		Me.cboTipo.FormattingEnabled = True
		Me.cboTipo.Location = New System.Drawing.Point(725, 97)
		Me.cboTipo.Name = "cboTipo"
		Me.cboTipo.Size = New System.Drawing.Size(99, 21)
		Me.cboTipo.TabIndex = 6
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.White
		Me.Label10.Location = New System.Drawing.Point(507, 82)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(80, 15)
		Me.Label10.TabIndex = 48
		Me.Label10.Text = "COMPLEMENTO"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(765, 42)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(20, 15)
		Me.Label9.TabIndex = 47
		Me.Label9.Text = "UF"
		'
		'cboUF
		'
		Me.cboUF.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.cboUF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClientestbEndBindingSource, "UF", True))
		Me.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboUF.ForeColor = System.Drawing.Color.White
		Me.cboUF.FormattingEnabled = True
		Me.cboUF.Location = New System.Drawing.Point(768, 56)
		Me.cboUF.Name = "cboUF"
		Me.cboUF.Size = New System.Drawing.Size(51, 21)
		Me.cboUF.TabIndex = 46
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(636, 42)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(44, 15)
		Me.Label8.TabIndex = 44
		Me.Label8.Text = "CIDADE"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(504, 42)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(45, 15)
		Me.Label7.TabIndex = 42
		Me.Label7.Text = "BAIRRO"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(687, 1)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(49, 15)
		Me.Label6.TabIndex = 40
		Me.Label6.Text = "NUMERO"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(504, 4)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 15)
		Me.Label5.TabIndex = 38
		Me.Label5.Text = "LOGRADOURO"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.White
		Me.Label12.Location = New System.Drawing.Point(636, 80)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(34, 15)
		Me.Label12.TabIndex = 55
		Me.Label12.Text = "CÓD. "
		'
		'btnConfirmar
		'
		Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.btnConfirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
		Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnConfirmar.ForeColor = System.Drawing.Color.White
		Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnConfirmar.Location = New System.Drawing.Point(538, 56)
		Me.btnConfirmar.Name = "btnConfirmar"
		Me.btnConfirmar.Size = New System.Drawing.Size(56, 38)
		Me.btnConfirmar.TabIndex = 7
		Me.btnConfirmar.Text = "CONFIRMAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESCOLHA"
		Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnConfirmar.UseVisualStyleBackColor = True
		Me.btnConfirmar.Visible = False
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.White
		Me.Label15.Location = New System.Drawing.Point(631, 49)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(91, 15)
		Me.Label15.TabIndex = 15
		Me.Label15.Text = "Inscrição Estadual"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.White
		Me.Label16.Location = New System.Drawing.Point(674, 68)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(53, 15)
		Me.Label16.TabIndex = 61
		Me.Label16.Text = "NÚMERO*"
		'
		'TbClientestbContatoBindingSource1
		'
		Me.TbClientestbContatoBindingSource1.DataMember = "tbClientestbContato"
		Me.TbClientestbContatoBindingSource1.DataSource = Me.TbClientesBindingSource
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.ForeColor = System.Drawing.Color.White
		Me.Label14.Location = New System.Drawing.Point(619, 68)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(32, 15)
		Me.Label14.TabIndex = 59
		Me.Label14.Text = "DDD*"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.ForeColor = System.Drawing.Color.White
		Me.Label18.Location = New System.Drawing.Point(504, 12)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(32, 15)
		Me.Label18.TabIndex = 63
		Me.Label18.Text = "TIPO*"
		'
		'DataGridView3
		'
		Me.DataGridView3.AllowUserToAddRows = False
		Me.DataGridView3.AllowUserToDeleteRows = False
		Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView3.Location = New System.Drawing.Point(96, 3)
		Me.DataGridView3.Name = "DataGridView3"
		Me.DataGridView3.ReadOnly = True
		Me.DataGridView3.RowHeadersVisible = False
		Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView3.Size = New System.Drawing.Size(405, 129)
		Me.DataGridView3.TabIndex = 0
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.White
		Me.Label13.Location = New System.Drawing.Point(504, 68)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(79, 15)
		Me.Label13.TabIndex = 57
		Me.Label13.Text = "CÓD. CONTATO"
		'
		'cboTipoContato
		'
		Me.cboTipoContato.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.cboTipoContato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClientestbContatoBindingSource1, "Tipo", True))
		Me.cboTipoContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboTipoContato.FormattingEnabled = True
		Me.cboTipoContato.Location = New System.Drawing.Point(507, 28)
		Me.cboTipoContato.Name = "cboTipoContato"
		Me.cboTipoContato.Size = New System.Drawing.Size(142, 21)
		Me.cboTipoContato.TabIndex = 0
		'
		'TbOSBindingSource
		'
		Me.TbOSBindingSource.DataMember = "tbOS"
		Me.TbOSBindingSource.DataSource = Me.SistemaGEDataSet
		'
		'TbOSTableAdapter
		'
		Me.TbOSTableAdapter.ClearBeforeFill = True
		'
		'TbClientesTableAdapter
		'
		Me.TbClientesTableAdapter.ClearBeforeFill = True
		'
		'TbContatoTableAdapter
		'
		Me.TbContatoTableAdapter.ClearBeforeFill = True
		'
		'TbEndTableAdapter
		'
		Me.TbEndTableAdapter.ClearBeforeFill = True
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.ForeColor = System.Drawing.Color.White
		Me.Label20.Location = New System.Drawing.Point(132, 81)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(69, 13)
		Me.Label20.TabIndex = 16
		Me.Label20.Text = "PESQUISAR"
		'
		'btnAddRecebimento
		'
		Me.btnAddRecebimento.BackColor = System.Drawing.Color.Indigo
		Me.btnAddRecebimento.FlatAppearance.BorderSize = 0
		Me.btnAddRecebimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnAddRecebimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnAddRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddRecebimento.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddRecebimento.ForeColor = System.Drawing.Color.White
		Me.btnAddRecebimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnAddRecebimento.Location = New System.Drawing.Point(610, 57)
		Me.btnAddRecebimento.Name = "btnAddRecebimento"
		Me.btnAddRecebimento.Size = New System.Drawing.Size(87, 39)
		Me.btnAddRecebimento.TabIndex = 7
		Me.btnAddRecebimento.Text = "ADICIONAR PESSOA"
		Me.btnAddRecebimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnAddRecebimento.UseVisualStyleBackColor = False
		'
		'btnFechar
		'
		Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.btnFechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
		Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnFechar.Image = Global.ControleOS.My.Resources.Resources.Voltar
		Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnFechar.Location = New System.Drawing.Point(719, 65)
		Me.btnFechar.Name = "btnFechar"
		Me.btnFechar.Size = New System.Drawing.Size(124, 31)
		Me.btnFechar.TabIndex = 11
		Me.btnFechar.Text = "VOLTAR"
		Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnFechar.UseVisualStyleBackColor = False
		'
		'PicPessoa
		'
		Me.PicPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PicPessoa.Image = Global.ControleOS.My.Resources.Resources.Usuarios
		Me.PicPessoa.Location = New System.Drawing.Point(12, 12)
		Me.PicPessoa.Name = "PicPessoa"
		Me.PicPessoa.Size = New System.Drawing.Size(105, 92)
		Me.PicPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PicPessoa.TabIndex = 11
		Me.PicPessoa.TabStop = False
		'
		'btnAtualizar
		'
		Me.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.btnAtualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
		Me.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnAtualizar.Image = Global.ControleOS.My.Resources.Resources.Atualizar
		Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAtualizar.Location = New System.Drawing.Point(719, 30)
		Me.btnAtualizar.Name = "btnAtualizar"
		Me.btnAtualizar.Size = New System.Drawing.Size(124, 31)
		Me.btnAtualizar.TabIndex = 10
		Me.btnAtualizar.Text = "ATUALIZAR"
		Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAtualizar.UseVisualStyleBackColor = False
		'
		'txtRSstatus
		'
		Me.txtRSstatus.Location = New System.Drawing.Point(207, 53)
		Me.txtRSstatus.Name = "txtRSstatus"
		Me.txtRSstatus.ReadOnly = True
		Me.txtRSstatus.Size = New System.Drawing.Size(167, 20)
		Me.txtRSstatus.TabIndex = 1
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.ForeColor = System.Drawing.Color.White
		Me.Label19.Location = New System.Drawing.Point(135, 56)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(70, 13)
		Me.Label19.TabIndex = 61
		Me.Label19.Text = "Razão Social"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.ForeColor = System.Drawing.Color.White
		Me.Label17.Location = New System.Drawing.Point(123, 30)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(78, 13)
		Me.Label17.TabIndex = 61
		Me.Label17.Text = "Nome Fantasia"
		'
		'txtFantasiaStatus
		'
		Me.txtFantasiaStatus.Location = New System.Drawing.Point(207, 27)
		Me.txtFantasiaStatus.Name = "txtFantasiaStatus"
		Me.txtFantasiaStatus.ReadOnly = True
		Me.txtFantasiaStatus.Size = New System.Drawing.Size(167, 20)
		Me.txtFantasiaStatus.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Indigo
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button1.Location = New System.Drawing.Point(3, 89)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(87, 36)
		Me.Button1.TabIndex = 59
		Me.Button1.Text = "EDITAR CONTATO"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Indigo
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button4.Location = New System.Drawing.Point(3, 46)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(87, 36)
		Me.Button4.TabIndex = 58
		Me.Button4.Text = "EXCLUIR CONTATO"
		Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.Indigo
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.ForeColor = System.Drawing.Color.White
		Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button5.Location = New System.Drawing.Point(3, 4)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(87, 36)
		Me.Button5.TabIndex = 57
		Me.Button5.Text = "ADICIONAR CONTATO"
		Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Indigo
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button3.Location = New System.Drawing.Point(3, 49)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(87, 39)
		Me.Button3.TabIndex = 52
		Me.Button3.Text = "ADICIONAR ENDEREÇO"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Indigo
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button2.Location = New System.Drawing.Point(3, 4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(87, 39)
		Me.Button2.TabIndex = 53
		Me.Button2.Text = "EXCLUIR ENDEREÇO"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = False
		'
		'btnEditarEndereco
		'
		Me.btnEditarEndereco.BackColor = System.Drawing.Color.Indigo
		Me.btnEditarEndereco.FlatAppearance.BorderSize = 0
		Me.btnEditarEndereco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnEditarEndereco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnEditarEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEditarEndereco.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEditarEndereco.ForeColor = System.Drawing.Color.White
		Me.btnEditarEndereco.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnEditarEndereco.Location = New System.Drawing.Point(3, 94)
		Me.btnEditarEndereco.Name = "btnEditarEndereco"
		Me.btnEditarEndereco.Size = New System.Drawing.Size(87, 39)
		Me.btnEditarEndereco.TabIndex = 54
		Me.btnEditarEndereco.Text = "EDITAR ENDEREÇO"
		Me.btnEditarEndereco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnEditarEndereco.UseVisualStyleBackColor = False
		'
		'TbClientestbContatoBindingSource
		'
		Me.TbClientestbContatoBindingSource.DataMember = "tbClientestbContato"
		Me.TbClientestbContatoBindingSource.DataSource = Me.TbClientesBindingSource
		'
		'pbColNacionalidade
		'
		Me.pbColNacionalidade.ForeColor = System.Drawing.Color.Red
		Me.pbColNacionalidade.Location = New System.Drawing.Point(507, 115)
		Me.pbColNacionalidade.Name = "pbColNacionalidade"
		Me.pbColNacionalidade.Size = New System.Drawing.Size(121, 1)
		Me.pbColNacionalidade.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbColNacionalidade.TabIndex = 151
		'
		'txtRazaoSocial
		'
		Me.txtRazaoSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtRazaoSocial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRazaoSocial.ForeColor = System.Drawing.Color.White
		Me.txtRazaoSocial.Location = New System.Drawing.Point(634, 24)
		Me.txtRazaoSocial.Name = "txtRazaoSocial"
		Me.txtRazaoSocial.Size = New System.Drawing.Size(123, 13)
		Me.txtRazaoSocial.TabIndex = 1
		'
		'txtCodCliente
		'
		Me.txtCodCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCodCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCodCliente.ForeColor = System.Drawing.Color.White
		Me.txtCodCliente.Location = New System.Drawing.Point(507, 100)
		Me.txtCodCliente.Name = "txtCodCliente"
		Me.txtCodCliente.Size = New System.Drawing.Size(121, 13)
		Me.txtCodCliente.TabIndex = 4
		'
		'pbColSobrenome
		'
		Me.pbColSobrenome.ForeColor = System.Drawing.Color.Red
		Me.pbColSobrenome.Location = New System.Drawing.Point(634, 39)
		Me.pbColSobrenome.Name = "pbColSobrenome"
		Me.pbColSobrenome.Size = New System.Drawing.Size(123, 1)
		Me.pbColSobrenome.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbColSobrenome.TabIndex = 148
		'
		'pbColNaturalidade
		'
		Me.pbColNaturalidade.ForeColor = System.Drawing.Color.Red
		Me.pbColNaturalidade.Location = New System.Drawing.Point(634, 79)
		Me.pbColNaturalidade.Name = "pbColNaturalidade"
		Me.pbColNaturalidade.Size = New System.Drawing.Size(123, 1)
		Me.pbColNaturalidade.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbColNaturalidade.TabIndex = 150
		'
		'txtNomeFantasia
		'
		Me.txtNomeFantasia.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNomeFantasia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNomeFantasia.ForeColor = System.Drawing.Color.White
		Me.txtNomeFantasia.Location = New System.Drawing.Point(507, 24)
		Me.txtNomeFantasia.Name = "txtNomeFantasia"
		Me.txtNomeFantasia.Size = New System.Drawing.Size(121, 13)
		Me.txtNomeFantasia.TabIndex = 0
		'
		'txtIE
		'
		Me.txtIE.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtIE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtIE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIE.ForeColor = System.Drawing.Color.White
		Me.txtIE.Location = New System.Drawing.Point(634, 64)
		Me.txtIE.Name = "txtIE"
		Me.txtIE.Size = New System.Drawing.Size(123, 13)
		Me.txtIE.TabIndex = 3
		'
		'pbColNome
		'
		Me.pbColNome.ForeColor = System.Drawing.Color.Red
		Me.pbColNome.Location = New System.Drawing.Point(507, 39)
		Me.pbColNome.Name = "pbColNome"
		Me.pbColNome.Size = New System.Drawing.Size(121, 1)
		Me.pbColNome.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbColNome.TabIndex = 149
		'
		'ProgressBar1
		'
		Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar1.Location = New System.Drawing.Point(639, 74)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar1.TabIndex = 153
		'
		'txtCidade
		'
		Me.txtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCidade.ForeColor = System.Drawing.Color.White
		Me.txtCidade.Location = New System.Drawing.Point(639, 59)
		Me.txtCidade.Name = "txtCidade"
		Me.txtCidade.Size = New System.Drawing.Size(123, 13)
		Me.txtCidade.TabIndex = 2
		'
		'ProgressBar2
		'
		Me.ProgressBar2.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar2.Location = New System.Drawing.Point(507, 79)
		Me.ProgressBar2.Name = "ProgressBar2"
		Me.ProgressBar2.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar2.TabIndex = 155
		'
		'txtCPF
		'
		Me.txtCPF.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCPF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCPF.ForeColor = System.Drawing.Color.White
		Me.txtCPF.Location = New System.Drawing.Point(507, 64)
		Me.txtCPF.Name = "txtCPF"
		Me.txtCPF.Size = New System.Drawing.Size(123, 13)
		Me.txtCPF.TabIndex = 2
		'
		'ProgressBar3
		'
		Me.ProgressBar3.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar3.Location = New System.Drawing.Point(636, 117)
		Me.ProgressBar3.Name = "ProgressBar3"
		Me.ProgressBar3.Size = New System.Drawing.Size(83, 1)
		Me.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar3.TabIndex = 157
		'
		'txtCodEnd
		'
		Me.txtCodEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCodEnd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCodEnd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCodEnd.ForeColor = System.Drawing.Color.White
		Me.txtCodEnd.Location = New System.Drawing.Point(636, 102)
		Me.txtCodEnd.Name = "txtCodEnd"
		Me.txtCodEnd.Size = New System.Drawing.Size(83, 13)
		Me.txtCodEnd.TabIndex = 5
		'
		'ProgressBar4
		'
		Me.ProgressBar4.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar4.Location = New System.Drawing.Point(507, 117)
		Me.ProgressBar4.Name = "ProgressBar4"
		Me.ProgressBar4.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar4.TabIndex = 159
		'
		'txtComplemento
		'
		Me.txtComplemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtComplemento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtComplemento.ForeColor = System.Drawing.Color.White
		Me.txtComplemento.Location = New System.Drawing.Point(507, 102)
		Me.txtComplemento.Name = "txtComplemento"
		Me.txtComplemento.Size = New System.Drawing.Size(123, 13)
		Me.txtComplemento.TabIndex = 4
		'
		'ProgressBar5
		'
		Me.ProgressBar5.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar5.Location = New System.Drawing.Point(689, 35)
		Me.ProgressBar5.Name = "ProgressBar5"
		Me.ProgressBar5.Size = New System.Drawing.Size(73, 1)
		Me.ProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar5.TabIndex = 161
		'
		'txtNumero
		'
		Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumero.ForeColor = System.Drawing.Color.White
		Me.txtNumero.Location = New System.Drawing.Point(689, 20)
		Me.txtNumero.Name = "txtNumero"
		Me.txtNumero.Size = New System.Drawing.Size(73, 13)
		Me.txtNumero.TabIndex = 1
		'
		'ProgressBar6
		'
		Me.ProgressBar6.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar6.Location = New System.Drawing.Point(507, 74)
		Me.ProgressBar6.Name = "ProgressBar6"
		Me.ProgressBar6.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar6.TabIndex = 163
		'
		'txtBairro
		'
		Me.txtBairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtBairro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBairro.ForeColor = System.Drawing.Color.White
		Me.txtBairro.Location = New System.Drawing.Point(507, 59)
		Me.txtBairro.Name = "txtBairro"
		Me.txtBairro.Size = New System.Drawing.Size(123, 13)
		Me.txtBairro.TabIndex = 3
		'
		'ProgressBar7
		'
		Me.ProgressBar7.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar7.Location = New System.Drawing.Point(507, 35)
		Me.ProgressBar7.Name = "ProgressBar7"
		Me.ProgressBar7.Size = New System.Drawing.Size(176, 1)
		Me.ProgressBar7.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar7.TabIndex = 165
		'
		'txtLogradouro
		'
		Me.txtLogradouro.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtLogradouro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLogradouro.ForeColor = System.Drawing.Color.White
		Me.txtLogradouro.Location = New System.Drawing.Point(507, 20)
		Me.txtLogradouro.Name = "txtLogradouro"
		Me.txtLogradouro.Size = New System.Drawing.Size(176, 13)
		Me.txtLogradouro.TabIndex = 0
		Me.txtLogradouro.Text = " "
		'
		'ProgressBar8
		'
		Me.ProgressBar8.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar8.Location = New System.Drawing.Point(674, 102)
		Me.ProgressBar8.Name = "ProgressBar8"
		Me.ProgressBar8.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar8.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar8.TabIndex = 167
		'
		'txtNumeroContato
		'
		Me.txtNumeroContato.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtNumeroContato.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNumeroContato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumeroContato.ForeColor = System.Drawing.Color.White
		Me.txtNumeroContato.Location = New System.Drawing.Point(674, 87)
		Me.txtNumeroContato.Name = "txtNumeroContato"
		Me.txtNumeroContato.Size = New System.Drawing.Size(123, 13)
		Me.txtNumeroContato.TabIndex = 2
		'
		'ProgressBar9
		'
		Me.ProgressBar9.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar9.Location = New System.Drawing.Point(570, 42)
		Me.ProgressBar9.Name = "ProgressBar9"
		Me.ProgressBar9.Size = New System.Drawing.Size(123, 1)
		Me.ProgressBar9.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar9.TabIndex = 169
		Me.ProgressBar9.Visible = False
		'
		'TextBox5
		'
		Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox5.ForeColor = System.Drawing.Color.White
		Me.TextBox5.Location = New System.Drawing.Point(570, 27)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(123, 13)
		Me.TextBox5.TabIndex = 168
		Me.TextBox5.Visible = False
		'
		'ProgressBar10
		'
		Me.ProgressBar10.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar10.Location = New System.Drawing.Point(619, 102)
		Me.ProgressBar10.Name = "ProgressBar10"
		Me.ProgressBar10.Size = New System.Drawing.Size(49, 1)
		Me.ProgressBar10.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar10.TabIndex = 171
		'
		'txtDDD
		'
		Me.txtDDD.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDDD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDDD.ForeColor = System.Drawing.Color.White
		Me.txtDDD.Location = New System.Drawing.Point(619, 87)
		Me.txtDDD.Name = "txtDDD"
		Me.txtDDD.Size = New System.Drawing.Size(49, 13)
		Me.txtDDD.TabIndex = 170
		'
		'ProgressBar11
		'
		Me.ProgressBar11.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar11.Location = New System.Drawing.Point(507, 102)
		Me.ProgressBar11.Name = "ProgressBar11"
		Me.ProgressBar11.Size = New System.Drawing.Size(106, 1)
		Me.ProgressBar11.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar11.TabIndex = 173
		'
		'txtCodContato
		'
		Me.txtCodContato.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCodContato.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCodContato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCodContato.ForeColor = System.Drawing.Color.White
		Me.txtCodContato.Location = New System.Drawing.Point(507, 87)
		Me.txtCodContato.Name = "txtCodContato"
		Me.txtCodContato.Size = New System.Drawing.Size(106, 13)
		Me.txtCodContato.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.btnExcRecebimento)
		Me.Panel1.Controls.Add(Me.btnEditRecebimento)
		Me.Panel1.Controls.Add(Me.DataGridView1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Label15)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.pbColNome)
		Me.Panel1.Controls.Add(Me.txtIE)
		Me.Panel1.Controls.Add(Me.txtNomeFantasia)
		Me.Panel1.Controls.Add(Me.pbColNaturalidade)
		Me.Panel1.Controls.Add(Me.pbColSobrenome)
		Me.Panel1.Controls.Add(Me.txtCodCliente)
		Me.Panel1.Controls.Add(Me.txtRazaoSocial)
		Me.Panel1.Controls.Add(Me.pbColNacionalidade)
		Me.Panel1.Controls.Add(Me.txtCPF)
		Me.Panel1.Controls.Add(Me.ProgressBar2)
		Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.Panel1.Location = New System.Drawing.Point(13, 110)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(862, 137)
		Me.Panel1.TabIndex = 174
		'
		'btnExcRecebimento
		'
		Me.btnExcRecebimento.BackColor = System.Drawing.Color.Indigo
		Me.btnExcRecebimento.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnExcRecebimento.FlatAppearance.BorderSize = 0
		Me.btnExcRecebimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnExcRecebimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnExcRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExcRecebimento.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExcRecebimento.ForeColor = System.Drawing.Color.White
		Me.btnExcRecebimento.Location = New System.Drawing.Point(4, 64)
		Me.btnExcRecebimento.Name = "btnExcRecebimento"
		Me.btnExcRecebimento.Size = New System.Drawing.Size(87, 39)
		Me.btnExcRecebimento.TabIndex = 157
		Me.btnExcRecebimento.Text = "EXCLUIR PESSOA"
		Me.btnExcRecebimento.UseVisualStyleBackColor = False
		'
		'btnEditRecebimento
		'
		Me.btnEditRecebimento.BackColor = System.Drawing.Color.Indigo
		Me.btnEditRecebimento.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnEditRecebimento.FlatAppearance.BorderSize = 0
		Me.btnEditRecebimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnEditRecebimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnEditRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEditRecebimento.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEditRecebimento.ForeColor = System.Drawing.Color.White
		Me.btnEditRecebimento.Location = New System.Drawing.Point(4, 19)
		Me.btnEditRecebimento.Name = "btnEditRecebimento"
		Me.btnEditRecebimento.Size = New System.Drawing.Size(87, 39)
		Me.btnEditRecebimento.TabIndex = 156
		Me.btnEditRecebimento.Text = "EDITAR PESSOA"
		Me.btnEditRecebimento.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.Label21)
		Me.Panel2.Controls.Add(Me.txtCEP)
		Me.Panel2.Controls.Add(Me.ProgressBar12)
		Me.Panel2.Controls.Add(Me.txtBairro)
		Me.Panel2.Controls.Add(Me.Label7)
		Me.Panel2.Controls.Add(Me.ProgressBar6)
		Me.Panel2.Controls.Add(Me.Button2)
		Me.Panel2.Controls.Add(Me.btnEditarEndereco)
		Me.Panel2.Controls.Add(Me.Button3)
		Me.Panel2.Controls.Add(Me.DataGridView2)
		Me.Panel2.Controls.Add(Me.Label6)
		Me.Panel2.Controls.Add(Me.txtNumero)
		Me.Panel2.Controls.Add(Me.ProgressBar5)
		Me.Panel2.Controls.Add(Me.txtLogradouro)
		Me.Panel2.Controls.Add(Me.Label5)
		Me.Panel2.Controls.Add(Me.ProgressBar7)
		Me.Panel2.Controls.Add(Me.ProgressBar3)
		Me.Panel2.Controls.Add(Me.ProgressBar4)
		Me.Panel2.Controls.Add(Me.txtCodEnd)
		Me.Panel2.Controls.Add(Me.txtComplemento)
		Me.Panel2.Controls.Add(Me.txtCidade)
		Me.Panel2.Controls.Add(Me.Label8)
		Me.Panel2.Controls.Add(Me.ProgressBar1)
		Me.Panel2.Controls.Add(Me.Label10)
		Me.Panel2.Controls.Add(Me.Label12)
		Me.Panel2.Controls.Add(Me.cboUF)
		Me.Panel2.Controls.Add(Me.cboTipo)
		Me.Panel2.Controls.Add(Me.Label9)
		Me.Panel2.Controls.Add(Me.Label11)
		Me.Panel2.Location = New System.Drawing.Point(13, 250)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(862, 137)
		Me.Panel2.TabIndex = 175
		'
		'Panel3
		'
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.Button5)
		Me.Panel3.Controls.Add(Me.Button4)
		Me.Panel3.Controls.Add(Me.Button1)
		Me.Panel3.Controls.Add(Me.ProgressBar11)
		Me.Panel3.Controls.Add(Me.DataGridView3)
		Me.Panel3.Controls.Add(Me.txtCodContato)
		Me.Panel3.Controls.Add(Me.cboTipoContato)
		Me.Panel3.Controls.Add(Me.ProgressBar10)
		Me.Panel3.Controls.Add(Me.Label16)
		Me.Panel3.Controls.Add(Me.txtDDD)
		Me.Panel3.Controls.Add(Me.Label18)
		Me.Panel3.Controls.Add(Me.Label13)
		Me.Panel3.Controls.Add(Me.Label14)
		Me.Panel3.Controls.Add(Me.ProgressBar8)
		Me.Panel3.Controls.Add(Me.txtNumeroContato)
		Me.Panel3.Location = New System.Drawing.Point(13, 390)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(862, 137)
		Me.Panel3.TabIndex = 176
		'
		'pbPesquisar
		'
		Me.pbPesquisar.ForeColor = System.Drawing.Color.Red
		Me.pbPesquisar.Location = New System.Drawing.Point(207, 93)
		Me.pbPesquisar.Name = "pbPesquisar"
		Me.pbPesquisar.Size = New System.Drawing.Size(308, 1)
		Me.pbPesquisar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbPesquisar.TabIndex = 178
		'
		'txtPesquisa
		'
		Me.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPesquisa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPesquisa.ForeColor = System.Drawing.Color.White
		Me.txtPesquisa.Location = New System.Drawing.Point(207, 78)
		Me.txtPesquisa.Name = "txtPesquisa"
		Me.txtPesquisa.Size = New System.Drawing.Size(308, 13)
		Me.txtPesquisa.TabIndex = 177
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.ForeColor = System.Drawing.Color.White
		Me.Label21.Location = New System.Drawing.Point(764, 1)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(26, 15)
		Me.Label21.TabIndex = 167
		Me.Label21.Text = "CEP"
		'
		'txtCEP
		'
		Me.txtCEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtCEP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCEP.ForeColor = System.Drawing.Color.White
		Me.txtCEP.Location = New System.Drawing.Point(767, 20)
		Me.txtCEP.Name = "txtCEP"
		Me.txtCEP.Size = New System.Drawing.Size(73, 13)
		Me.txtCEP.TabIndex = 166
		'
		'ProgressBar12
		'
		Me.ProgressBar12.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar12.Location = New System.Drawing.Point(767, 35)
		Me.ProgressBar12.Name = "ProgressBar12"
		Me.ProgressBar12.Size = New System.Drawing.Size(73, 1)
		Me.ProgressBar12.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.ProgressBar12.TabIndex = 168
		'
		'FrmClientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(936, 545)
		Me.ControlBox = False
		Me.Controls.Add(Me.pbPesquisar)
		Me.Controls.Add(Me.txtPesquisa)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.btnAddRecebimento)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.ProgressBar9)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.btnFechar)
		Me.Controls.Add(Me.btnAtualizar)
		Me.Controls.Add(Me.PicPessoa)
		Me.Controls.Add(Me.txtFantasiaStatus)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.txtRSstatus)
		Me.Controls.Add(Me.btnConfirmar)
		Me.Controls.Add(Me.Label19)
		Me.Name = "FrmClientes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " "
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbClientestbEndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbClientestbContatoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PicPessoa, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbClientestbContatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents btnFechar As Button
	Friend WithEvents btnAtualizar As Button
	Friend WithEvents EnderecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents btnAddRecebimento As Button
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents Label11 As Label
	Friend WithEvents cboTipo As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents cboUF As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents btnEditarEndereco As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents SobrenomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Label16 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents DataGridView3 As DataGridView
	Friend WithEvents Button5 As Button
	Friend WithEvents Label13 As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents cboTipoContato As ComboBox
	Friend WithEvents Label15 As Label
	Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
	Friend WithEvents TbOSBindingSource As BindingSource
	Friend WithEvents TbOSTableAdapter As SistemaGEDataSetTableAdapters.tbOSTableAdapter
	Friend WithEvents TbClientesBindingSource As BindingSource
	Friend WithEvents TbClientesTableAdapter As SistemaGEDataSetTableAdapters.tbClientesTableAdapter
	Friend WithEvents TbClientestbContatoBindingSource As BindingSource
	Friend WithEvents TbContatoTableAdapter As SistemaGEDataSetTableAdapters.tbContatoTableAdapter
	Friend WithEvents TbClientestbContatoBindingSource1 As BindingSource
	Friend WithEvents TbClientestbEndBindingSource As BindingSource
	Friend WithEvents TbEndTableAdapter As SistemaGEDataSetTableAdapters.tbEndTableAdapter
	Friend WithEvents btnConfirmar As Button
	Friend WithEvents txtRSstatus As TextBox
	Friend WithEvents Label19 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents txtFantasiaStatus As TextBox
	Friend WithEvents PicPessoa As PictureBox
	Friend WithEvents Label20 As Label
	Friend WithEvents pbColNacionalidade As ProgressBar
	Friend WithEvents txtRazaoSocial As TextBox
	Friend WithEvents txtCodCliente As TextBox
	Friend WithEvents pbColSobrenome As ProgressBar
	Friend WithEvents pbColNaturalidade As ProgressBar
	Friend WithEvents txtNomeFantasia As TextBox
	Friend WithEvents txtIE As TextBox
	Friend WithEvents pbColNome As ProgressBar
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents txtCidade As TextBox
	Friend WithEvents ProgressBar2 As ProgressBar
	Friend WithEvents txtCPF As TextBox
	Friend WithEvents ProgressBar3 As ProgressBar
	Friend WithEvents txtCodEnd As TextBox
	Friend WithEvents ProgressBar4 As ProgressBar
	Friend WithEvents txtComplemento As TextBox
	Friend WithEvents ProgressBar5 As ProgressBar
	Friend WithEvents txtNumero As TextBox
	Friend WithEvents ProgressBar6 As ProgressBar
	Friend WithEvents txtBairro As TextBox
	Friend WithEvents ProgressBar7 As ProgressBar
	Friend WithEvents txtLogradouro As TextBox
	Friend WithEvents ProgressBar8 As ProgressBar
	Friend WithEvents txtNumeroContato As TextBox
	Friend WithEvents ProgressBar9 As ProgressBar
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents ProgressBar10 As ProgressBar
	Friend WithEvents txtDDD As TextBox
	Friend WithEvents ProgressBar11 As ProgressBar
	Friend WithEvents txtCodContato As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnExcRecebimento As Button
	Friend WithEvents btnEditRecebimento As Button
	Friend WithEvents pbPesquisar As ProgressBar
	Friend WithEvents txtPesquisa As TextBox
	Friend WithEvents Label21 As Label
	Friend WithEvents txtCEP As TextBox
	Friend WithEvents ProgressBar12 As ProgressBar
End Class
