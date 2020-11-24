<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendaEntrega
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaEntrega))
		Me.l1 = New System.Windows.Forms.ListView()
		Me.ilFig = New System.Windows.Forms.ImageList(Me.components)
		Me.l2 = New System.Windows.Forms.ListView()
		Me.l3 = New System.Windows.Forms.ListView()
		Me.l4 = New System.Windows.Forms.ListView()
		Me.l5 = New System.Windows.Forms.ListView()
		Me.l6 = New System.Windows.Forms.ListView()
		Me.l7 = New System.Windows.Forms.ListView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.tbData = New System.Windows.Forms.TrackBar()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.sem7 = New System.Windows.Forms.Label()
		Me.sem6 = New System.Windows.Forms.Label()
		Me.sem5 = New System.Windows.Forms.Label()
		Me.sem4 = New System.Windows.Forms.Label()
		Me.sem3 = New System.Windows.Forms.Label()
		Me.sem2 = New System.Windows.Forms.Label()
		Me.sem1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnSomar = New System.Windows.Forms.Button()
		Me.btnSubtrair = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.pbCalen = New System.Windows.Forms.ProgressBar()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.txtEntregaID = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtUsuarioID = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtNomeCliente = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtStatus = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtAtividade = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtData = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.txtVeiculoID = New System.Windows.Forms.TextBox()
		Me.txtVeiculo = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.mcRef = New System.Windows.Forms.MonthCalendar()
		Me.Panel10 = New System.Windows.Forms.Panel()
		Me.btnRegistrarSaida = New System.Windows.Forms.Button()
		Me.btnRegistrarVolta = New System.Windows.Forms.Button()
		Me.btnAddLembrete = New System.Windows.Forms.Button()
		Me.btnExcluirAgendamento = New System.Windows.Forms.Button()
		Me.btnShowItens = New System.Windows.Forms.Button()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.txtPedidoID = New System.Windows.Forms.TextBox()
		Me.Panel9 = New System.Windows.Forms.Panel()
		Me.txtPlaca = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.dgvItensPedido = New System.Windows.Forms.DataGridView()
		Me.pnItens = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.tmPopularCalendario = New System.Windows.Forms.Timer(Me.components)
		Me.cboMotorista = New System.Windows.Forms.ComboBox()
		Me.Label20 = New System.Windows.Forms.Label()
		CType(Me.tbData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel10.SuspendLayout()
		Me.Panel9.SuspendLayout()
		Me.Panel8.SuspendLayout()
		Me.Panel7.SuspendLayout()
		CType(Me.dgvItensPedido, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnItens.SuspendLayout()
		Me.SuspendLayout()
		'
		'l1
		'
		Me.l1.HideSelection = False
		Me.l1.Location = New System.Drawing.Point(7, 133)
		Me.l1.Name = "l1"
		Me.l1.Size = New System.Drawing.Size(140, 316)
		Me.l1.SmallImageList = Me.ilFig
		Me.l1.StateImageList = Me.ilFig
		Me.l1.TabIndex = 0
		Me.l1.UseCompatibleStateImageBehavior = False
		Me.l1.View = System.Windows.Forms.View.Tile
		'
		'ilFig
		'
		Me.ilFig.ImageStream = CType(resources.GetObject("ilFig.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilFig.TransparentColor = System.Drawing.Color.Black
		Me.ilFig.Images.SetKeyName(0, "friends_link_send_share_icon_123609 (1).ico")
		Me.ilFig.Images.SetKeyName(1, "friends_link_send_share_icon_123609.ico")
		'
		'l2
		'
		Me.l2.HideSelection = False
		Me.l2.Location = New System.Drawing.Point(149, 133)
		Me.l2.Name = "l2"
		Me.l2.Size = New System.Drawing.Size(140, 316)
		Me.l2.TabIndex = 1
		Me.l2.UseCompatibleStateImageBehavior = False
		Me.l2.View = System.Windows.Forms.View.Tile
		'
		'l3
		'
		Me.l3.HideSelection = False
		Me.l3.Location = New System.Drawing.Point(291, 133)
		Me.l3.Name = "l3"
		Me.l3.Size = New System.Drawing.Size(140, 316)
		Me.l3.TabIndex = 2
		Me.l3.UseCompatibleStateImageBehavior = False
		Me.l3.View = System.Windows.Forms.View.Tile
		'
		'l4
		'
		Me.l4.HideSelection = False
		Me.l4.Location = New System.Drawing.Point(433, 133)
		Me.l4.Name = "l4"
		Me.l4.Size = New System.Drawing.Size(140, 316)
		Me.l4.TabIndex = 3
		Me.l4.UseCompatibleStateImageBehavior = False
		Me.l4.View = System.Windows.Forms.View.Tile
		'
		'l5
		'
		Me.l5.HideSelection = False
		Me.l5.Location = New System.Drawing.Point(575, 133)
		Me.l5.Name = "l5"
		Me.l5.Size = New System.Drawing.Size(140, 316)
		Me.l5.TabIndex = 4
		Me.l5.UseCompatibleStateImageBehavior = False
		Me.l5.View = System.Windows.Forms.View.Tile
		'
		'l6
		'
		Me.l6.HideSelection = False
		Me.l6.Location = New System.Drawing.Point(718, 133)
		Me.l6.Name = "l6"
		Me.l6.Size = New System.Drawing.Size(140, 316)
		Me.l6.TabIndex = 5
		Me.l6.UseCompatibleStateImageBehavior = False
		Me.l6.View = System.Windows.Forms.View.Tile
		'
		'l7
		'
		Me.l7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l7.HideSelection = False
		Me.l7.Location = New System.Drawing.Point(861, 133)
		Me.l7.Name = "l7"
		Me.l7.Size = New System.Drawing.Size(140, 316)
		Me.l7.TabIndex = 6
		Me.l7.UseCompatibleStateImageBehavior = False
		Me.l7.View = System.Windows.Forms.View.Tile
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(67, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 20)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Data"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(204, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 20)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Data"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(358, 8)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(35, 20)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Data"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(494, 8)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(35, 20)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Data"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(631, 8)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 20)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Data"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(770, 8)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(35, 20)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Data"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(918, 8)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 20)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Data"
		'
		'tbData
		'
		Me.tbData.AutoSize = False
		Me.tbData.LargeChange = 1
		Me.tbData.Location = New System.Drawing.Point(-1, 2)
		Me.tbData.Maximum = 500
		Me.tbData.Name = "tbData"
		Me.tbData.Size = New System.Drawing.Size(994, 33)
		Me.tbData.TabIndex = 15
		Me.tbData.TickFrequency = 5
		Me.tbData.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tbData.Value = 250
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(376, 18)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(288, 31)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "CONTROLE DE ENTREGA"
		'
		'sem7
		'
		Me.sem7.AutoSize = True
		Me.sem7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem7.Location = New System.Drawing.Point(871, 29)
		Me.sem7.Name = "sem7"
		Me.sem7.Size = New System.Drawing.Size(78, 20)
		Me.sem7.TabIndex = 23
		Me.sem7.Text = "Dia Semana"
		'
		'sem6
		'
		Me.sem6.AutoSize = True
		Me.sem6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem6.Location = New System.Drawing.Point(724, 29)
		Me.sem6.Name = "sem6"
		Me.sem6.Size = New System.Drawing.Size(78, 20)
		Me.sem6.TabIndex = 22
		Me.sem6.Text = "Dia Semana"
		'
		'sem5
		'
		Me.sem5.AutoSize = True
		Me.sem5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem5.Location = New System.Drawing.Point(584, 29)
		Me.sem5.Name = "sem5"
		Me.sem5.Size = New System.Drawing.Size(78, 20)
		Me.sem5.TabIndex = 21
		Me.sem5.Text = "Dia Semana"
		'
		'sem4
		'
		Me.sem4.AutoSize = True
		Me.sem4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem4.Location = New System.Drawing.Point(447, 29)
		Me.sem4.Name = "sem4"
		Me.sem4.Size = New System.Drawing.Size(78, 20)
		Me.sem4.TabIndex = 20
		Me.sem4.Text = "Dia Semana"
		'
		'sem3
		'
		Me.sem3.AutoSize = True
		Me.sem3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem3.Location = New System.Drawing.Point(311, 29)
		Me.sem3.Name = "sem3"
		Me.sem3.Size = New System.Drawing.Size(78, 20)
		Me.sem3.TabIndex = 19
		Me.sem3.Text = "Dia Semana"
		'
		'sem2
		'
		Me.sem2.AutoSize = True
		Me.sem2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem2.Location = New System.Drawing.Point(158, 29)
		Me.sem2.Name = "sem2"
		Me.sem2.Size = New System.Drawing.Size(78, 20)
		Me.sem2.TabIndex = 18
		Me.sem2.Text = "Dia Semana"
		'
		'sem1
		'
		Me.sem1.AutoSize = True
		Me.sem1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem1.Location = New System.Drawing.Point(20, 29)
		Me.sem1.Name = "sem1"
		Me.sem1.Size = New System.Drawing.Size(78, 20)
		Me.sem1.TabIndex = 17
		Me.sem1.Text = "Dia Semana"
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.tbData)
		Me.Panel1.Controls.Add(Me.btnSomar)
		Me.Panel1.Controls.Add(Me.btnSubtrair)
		Me.Panel1.Location = New System.Drawing.Point(7, 455)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1474, 71)
		Me.Panel1.TabIndex = 24
		'
		'btnSomar
		'
		Me.btnSomar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnSomar.FlatAppearance.BorderSize = 0
		Me.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSomar.Location = New System.Drawing.Point(961, 41)
		Me.btnSomar.Name = "btnSomar"
		Me.btnSomar.Size = New System.Drawing.Size(27, 23)
		Me.btnSomar.TabIndex = 27
		Me.btnSomar.Text = "+"
		Me.btnSomar.UseVisualStyleBackColor = False
		'
		'btnSubtrair
		'
		Me.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnSubtrair.FlatAppearance.BorderSize = 0
		Me.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubtrair.Location = New System.Drawing.Point(928, 41)
		Me.btnSubtrair.Name = "btnSubtrair"
		Me.btnSubtrair.Size = New System.Drawing.Size(27, 23)
		Me.btnSubtrair.TabIndex = 28
		Me.btnSubtrair.Text = "-"
		Me.btnSubtrair.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel2.Controls.Add(Me.Label20)
		Me.Panel2.Controls.Add(Me.cboMotorista)
		Me.Panel2.Controls.Add(Me.lblStatus)
		Me.Panel2.Controls.Add(Me.pbCalen)
		Me.Panel2.Controls.Add(Me.Label8)
		Me.Panel2.Location = New System.Drawing.Point(-1, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1010, 103)
		Me.Panel2.TabIndex = 25
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Location = New System.Drawing.Point(20, 27)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(91, 31)
		Me.lblStatus.TabIndex = 132
		Me.lblStatus.Text = "Label20"
		'
		'pbCalen
		'
		Me.pbCalen.ForeColor = System.Drawing.Color.Transparent
		Me.pbCalen.Location = New System.Drawing.Point(460, 45)
		Me.pbCalen.Name = "pbCalen"
		Me.pbCalen.Size = New System.Drawing.Size(103, 23)
		Me.pbCalen.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbCalen.TabIndex = 17
		Me.pbCalen.Visible = False
		'
		'Panel3
		'
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.Label1)
		Me.Panel3.Controls.Add(Me.sem1)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.sem7)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Controls.Add(Me.sem6)
		Me.Panel3.Controls.Add(Me.Label5)
		Me.Panel3.Controls.Add(Me.sem5)
		Me.Panel3.Controls.Add(Me.Label6)
		Me.Panel3.Controls.Add(Me.sem4)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Controls.Add(Me.sem3)
		Me.Panel3.Controls.Add(Me.sem2)
		Me.Panel3.Location = New System.Drawing.Point(7, 72)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(994, 55)
		Me.Panel3.TabIndex = 26
		'
		'txtEntregaID
		'
		Me.txtEntregaID.Location = New System.Drawing.Point(3, 25)
		Me.txtEntregaID.Name = "txtEntregaID"
		Me.txtEntregaID.Size = New System.Drawing.Size(100, 20)
		Me.txtEntregaID.TabIndex = 30
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(3, 2)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(59, 16)
		Me.Label9.TabIndex = 31
		Me.Label9.Text = "Entrega ID"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(9, 3)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(110, 16)
		Me.Label10.TabIndex = 33
		Me.Label10.Text = "Usuário Responsável"
		'
		'txtUsuarioID
		'
		Me.txtUsuarioID.Location = New System.Drawing.Point(6, 21)
		Me.txtUsuarioID.Name = "txtUsuarioID"
		Me.txtUsuarioID.Size = New System.Drawing.Size(232, 20)
		Me.txtUsuarioID.TabIndex = 32
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(9, 42)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(86, 16)
		Me.Label11.TabIndex = 35
		Me.Label11.Text = "Nome do Cliente"
		'
		'txtNomeCliente
		'
		Me.txtNomeCliente.Location = New System.Drawing.Point(7, 59)
		Me.txtNomeCliente.Name = "txtNomeCliente"
		Me.txtNomeCliente.Size = New System.Drawing.Size(231, 20)
		Me.txtNomeCliente.TabIndex = 34
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(8, 82)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(36, 16)
		Me.Label12.TabIndex = 37
		Me.Label12.Text = "Status"
		'
		'txtStatus
		'
		Me.txtStatus.Location = New System.Drawing.Point(11, 97)
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Size = New System.Drawing.Size(100, 20)
		Me.txtStatus.TabIndex = 36
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(6, 80)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(51, 16)
		Me.Label13.TabIndex = 39
		Me.Label13.Text = "Atividade"
		'
		'txtAtividade
		'
		Me.txtAtividade.Location = New System.Drawing.Point(6, 97)
		Me.txtAtividade.Multiline = True
		Me.txtAtividade.Name = "txtAtividade"
		Me.txtAtividade.Size = New System.Drawing.Size(232, 55)
		Me.txtAtividade.TabIndex = 38
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(8, 42)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(44, 16)
		Me.Label14.TabIndex = 41
		Me.Label14.Text = "Horario"
		'
		'txtHora
		'
		Me.txtHora.Location = New System.Drawing.Point(11, 59)
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(100, 20)
		Me.txtHora.TabIndex = 40
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = System.Drawing.Color.Transparent
		Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(8, 2)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(30, 16)
		Me.Label15.TabIndex = 43
		Me.Label15.Text = "Data"
		'
		'txtData
		'
		Me.txtData.Location = New System.Drawing.Point(11, 20)
		Me.txtData.Name = "txtData"
		Me.txtData.Size = New System.Drawing.Size(100, 20)
		Me.txtData.TabIndex = 42
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.BackColor = System.Drawing.Color.Transparent
		Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(3, 3)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(56, 16)
		Me.Label16.TabIndex = 45
		Me.Label16.Text = "Veiculo ID"
		'
		'txtVeiculoID
		'
		Me.txtVeiculoID.Location = New System.Drawing.Point(6, 20)
		Me.txtVeiculoID.Name = "txtVeiculoID"
		Me.txtVeiculoID.Size = New System.Drawing.Size(100, 20)
		Me.txtVeiculoID.TabIndex = 44
		'
		'txtVeiculo
		'
		Me.txtVeiculo.Location = New System.Drawing.Point(6, 59)
		Me.txtVeiculo.Name = "txtVeiculo"
		Me.txtVeiculo.Size = New System.Drawing.Size(100, 20)
		Me.txtVeiculo.TabIndex = 46
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.BackColor = System.Drawing.Color.Transparent
		Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(3, 42)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(42, 16)
		Me.Label17.TabIndex = 47
		Me.Label17.Text = "Veiculo"
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel5.Location = New System.Drawing.Point(-1, 103)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(1010, 199)
		Me.Panel5.TabIndex = 26
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel6.Controls.Add(Me.mcRef)
		Me.Panel6.Controls.Add(Me.Panel10)
		Me.Panel6.Controls.Add(Me.Panel9)
		Me.Panel6.Controls.Add(Me.Panel8)
		Me.Panel6.Controls.Add(Me.Panel7)
		Me.Panel6.Location = New System.Drawing.Point(-1, 300)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(1010, 431)
		Me.Panel6.TabIndex = 27
		'
		'mcRef
		'
		Me.mcRef.Cursor = System.Windows.Forms.Cursors.Hand
		Me.mcRef.Location = New System.Drawing.Point(738, 229)
		Me.mcRef.Name = "mcRef"
		Me.mcRef.ShowWeekNumbers = True
		Me.mcRef.TabIndex = 0
		Me.mcRef.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		'
		'Panel10
		'
		Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel10.Controls.Add(Me.btnRegistrarSaida)
		Me.Panel10.Controls.Add(Me.btnRegistrarVolta)
		Me.Panel10.Controls.Add(Me.btnAddLembrete)
		Me.Panel10.Controls.Add(Me.btnExcluirAgendamento)
		Me.Panel10.Controls.Add(Me.txtEntregaID)
		Me.Panel10.Controls.Add(Me.btnShowItens)
		Me.Panel10.Controls.Add(Me.Label19)
		Me.Panel10.Controls.Add(Me.Label9)
		Me.Panel10.Controls.Add(Me.txtPedidoID)
		Me.Panel10.Location = New System.Drawing.Point(510, 234)
		Me.Panel10.Name = "Panel10"
		Me.Panel10.Size = New System.Drawing.Size(216, 157)
		Me.Panel10.TabIndex = 51
		'
		'btnRegistrarSaida
		'
		Me.btnRegistrarSaida.BackColor = System.Drawing.Color.Indigo
		Me.btnRegistrarSaida.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnRegistrarSaida.FlatAppearance.BorderSize = 0
		Me.btnRegistrarSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnRegistrarSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnRegistrarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRegistrarSaida.ForeColor = System.Drawing.Color.White
		Me.btnRegistrarSaida.Location = New System.Drawing.Point(8, 51)
		Me.btnRegistrarSaida.Name = "btnRegistrarSaida"
		Me.btnRegistrarSaida.Size = New System.Drawing.Size(97, 23)
		Me.btnRegistrarSaida.TabIndex = 133
		Me.btnRegistrarSaida.Text = "Reg. Saída"
		Me.btnRegistrarSaida.UseVisualStyleBackColor = False
		'
		'btnRegistrarVolta
		'
		Me.btnRegistrarVolta.BackColor = System.Drawing.Color.Indigo
		Me.btnRegistrarVolta.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnRegistrarVolta.FlatAppearance.BorderSize = 0
		Me.btnRegistrarVolta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnRegistrarVolta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnRegistrarVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRegistrarVolta.ForeColor = System.Drawing.Color.White
		Me.btnRegistrarVolta.Location = New System.Drawing.Point(8, 80)
		Me.btnRegistrarVolta.Name = "btnRegistrarVolta"
		Me.btnRegistrarVolta.Size = New System.Drawing.Size(97, 23)
		Me.btnRegistrarVolta.TabIndex = 132
		Me.btnRegistrarVolta.Text = "Reg. Volta"
		Me.btnRegistrarVolta.UseVisualStyleBackColor = False
		'
		'btnAddLembrete
		'
		Me.btnAddLembrete.BackColor = System.Drawing.Color.Indigo
		Me.btnAddLembrete.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnAddLembrete.FlatAppearance.BorderSize = 0
		Me.btnAddLembrete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnAddLembrete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnAddLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddLembrete.ForeColor = System.Drawing.Color.White
		Me.btnAddLembrete.Location = New System.Drawing.Point(112, 51)
		Me.btnAddLembrete.Name = "btnAddLembrete"
		Me.btnAddLembrete.Size = New System.Drawing.Size(97, 23)
		Me.btnAddLembrete.TabIndex = 131
		Me.btnAddLembrete.Text = "ADICIONAR"
		Me.btnAddLembrete.UseVisualStyleBackColor = False
		'
		'btnExcluirAgendamento
		'
		Me.btnExcluirAgendamento.BackColor = System.Drawing.Color.Indigo
		Me.btnExcluirAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnExcluirAgendamento.FlatAppearance.BorderSize = 0
		Me.btnExcluirAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnExcluirAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnExcluirAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExcluirAgendamento.ForeColor = System.Drawing.Color.White
		Me.btnExcluirAgendamento.Location = New System.Drawing.Point(112, 80)
		Me.btnExcluirAgendamento.Name = "btnExcluirAgendamento"
		Me.btnExcluirAgendamento.Size = New System.Drawing.Size(97, 23)
		Me.btnExcluirAgendamento.TabIndex = 129
		Me.btnExcluirAgendamento.Text = "EXCLUIR"
		Me.btnExcluirAgendamento.UseVisualStyleBackColor = False
		'
		'btnShowItens
		'
		Me.btnShowItens.BackColor = System.Drawing.Color.Indigo
		Me.btnShowItens.FlatAppearance.BorderColor = System.Drawing.Color.Purple
		Me.btnShowItens.FlatAppearance.BorderSize = 0
		Me.btnShowItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnShowItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnShowItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnShowItens.ForeColor = System.Drawing.Color.White
		Me.btnShowItens.Location = New System.Drawing.Point(112, 109)
		Me.btnShowItens.Name = "btnShowItens"
		Me.btnShowItens.Size = New System.Drawing.Size(97, 23)
		Me.btnShowItens.TabIndex = 128
		Me.btnShowItens.Text = "ITENS"
		Me.btnShowItens.UseVisualStyleBackColor = False
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.BackColor = System.Drawing.Color.Transparent
		Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(106, 7)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(67, 16)
		Me.Label19.TabIndex = 51
		Me.Label19.Text = "Cód. Pedido"
		'
		'txtPedidoID
		'
		Me.txtPedidoID.Location = New System.Drawing.Point(109, 25)
		Me.txtPedidoID.Name = "txtPedidoID"
		Me.txtPedidoID.Size = New System.Drawing.Size(100, 20)
		Me.txtPedidoID.TabIndex = 50
		'
		'Panel9
		'
		Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel9.Controls.Add(Me.txtPlaca)
		Me.Panel9.Controls.Add(Me.Label18)
		Me.Panel9.Controls.Add(Me.txtVeiculo)
		Me.Panel9.Controls.Add(Me.Label16)
		Me.Panel9.Controls.Add(Me.txtVeiculoID)
		Me.Panel9.Controls.Add(Me.Label17)
		Me.Panel9.Location = New System.Drawing.Point(389, 234)
		Me.Panel9.Name = "Panel9"
		Me.Panel9.Size = New System.Drawing.Size(115, 157)
		Me.Panel9.TabIndex = 50
		'
		'txtPlaca
		'
		Me.txtPlaca.Location = New System.Drawing.Point(6, 97)
		Me.txtPlaca.Name = "txtPlaca"
		Me.txtPlaca.Size = New System.Drawing.Size(100, 20)
		Me.txtPlaca.TabIndex = 48
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.BackColor = System.Drawing.Color.Transparent
		Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(3, 82)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(34, 16)
		Me.Label18.TabIndex = 49
		Me.Label18.Text = "Placa"
		'
		'Panel8
		'
		Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel8.Controls.Add(Me.Label15)
		Me.Panel8.Controls.Add(Me.Label14)
		Me.Panel8.Controls.Add(Me.Label12)
		Me.Panel8.Controls.Add(Me.txtData)
		Me.Panel8.Controls.Add(Me.txtStatus)
		Me.Panel8.Controls.Add(Me.txtHora)
		Me.Panel8.Location = New System.Drawing.Point(257, 234)
		Me.Panel8.Name = "Panel8"
		Me.Panel8.Size = New System.Drawing.Size(126, 157)
		Me.Panel8.TabIndex = 49
		'
		'Panel7
		'
		Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel7.Controls.Add(Me.Label10)
		Me.Panel7.Controls.Add(Me.Label13)
		Me.Panel7.Controls.Add(Me.txtAtividade)
		Me.Panel7.Controls.Add(Me.Label11)
		Me.Panel7.Controls.Add(Me.txtNomeCliente)
		Me.Panel7.Controls.Add(Me.txtUsuarioID)
		Me.Panel7.Location = New System.Drawing.Point(8, 234)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(243, 157)
		Me.Panel7.TabIndex = 48
		'
		'dgvItensPedido
		'
		Me.dgvItensPedido.AllowUserToAddRows = False
		Me.dgvItensPedido.AllowUserToDeleteRows = False
		Me.dgvItensPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvItensPedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvItensPedido.Location = New System.Drawing.Point(6, 11)
		Me.dgvItensPedido.Name = "dgvItensPedido"
		Me.dgvItensPedido.ReadOnly = True
		Me.dgvItensPedido.RowHeadersVisible = False
		Me.dgvItensPedido.Size = New System.Drawing.Size(269, 268)
		Me.dgvItensPedido.TabIndex = 28
		Me.dgvItensPedido.Visible = False
		'
		'pnItens
		'
		Me.pnItens.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.pnItens.Controls.Add(Me.Button1)
		Me.pnItens.Controls.Add(Me.dgvItensPedido)
		Me.pnItens.Location = New System.Drawing.Point(1089, 18)
		Me.pnItens.Name = "pnItens"
		Me.pnItens.Size = New System.Drawing.Size(278, 316)
		Me.pnItens.TabIndex = 28
		Me.pnItens.Visible = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(225, 285)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(50, 23)
		Me.Button1.TabIndex = 29
		Me.Button1.Text = "Fechar"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'tmPopularCalendario
		'
		Me.tmPopularCalendario.Enabled = True
		Me.tmPopularCalendario.Interval = 10000
		'
		'cboMotorista
		'
		Me.cboMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboMotorista.FormattingEnabled = True
		Me.cboMotorista.Location = New System.Drawing.Point(881, 45)
		Me.cboMotorista.Name = "cboMotorista"
		Me.cboMotorista.Size = New System.Drawing.Size(121, 21)
		Me.cboMotorista.TabIndex = 134
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(881, 27)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(50, 13)
		Me.Label20.TabIndex = 135
		Me.Label20.Text = "Motorista"
		'
		'FrmAgendaEntrega
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1488, 729)
		Me.Controls.Add(Me.pnItens)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.l7)
		Me.Controls.Add(Me.l6)
		Me.Controls.Add(Me.l5)
		Me.Controls.Add(Me.l4)
		Me.Controls.Add(Me.l3)
		Me.Controls.Add(Me.l2)
		Me.Controls.Add(Me.l1)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel6)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmAgendaEntrega"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " "
		CType(Me.tbData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel10.ResumeLayout(False)
		Me.Panel10.PerformLayout()
		Me.Panel9.ResumeLayout(False)
		Me.Panel9.PerformLayout()
		Me.Panel8.ResumeLayout(False)
		Me.Panel8.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		CType(Me.dgvItensPedido, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnItens.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents l1 As ListView
	Friend WithEvents l2 As ListView
	Friend WithEvents l3 As ListView
	Friend WithEvents l4 As ListView
	Friend WithEvents l5 As ListView
	Friend WithEvents l6 As ListView
	Friend WithEvents l7 As ListView
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents tbData As TrackBar
	Friend WithEvents Label8 As Label
	Friend WithEvents sem7 As Label
	Friend WithEvents sem6 As Label
	Friend WithEvents sem5 As Label
	Friend WithEvents sem4 As Label
	Friend WithEvents sem3 As Label
	Friend WithEvents sem2 As Label
	Friend WithEvents sem1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnSomar As Button
	Friend WithEvents btnSubtrair As Button
	Friend WithEvents txtEntregaID As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents txtUsuarioID As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtNomeCliente As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtStatus As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents txtAtividade As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents txtHora As TextBox
	Friend WithEvents Label15 As Label
	Friend WithEvents txtData As TextBox
	Friend WithEvents Label16 As Label
	Friend WithEvents txtVeiculoID As TextBox
	Friend WithEvents txtVeiculo As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel6 As Panel
	Friend WithEvents Panel9 As Panel
	Friend WithEvents Panel8 As Panel
	Friend WithEvents Panel7 As Panel
	Friend WithEvents Panel10 As Panel
	Friend WithEvents txtPlaca As TextBox
	Friend WithEvents Label18 As Label
	Friend WithEvents btnShowItens As Button
	Friend WithEvents Label19 As Label
	Friend WithEvents txtPedidoID As TextBox
	Friend WithEvents dgvItensPedido As DataGridView
	Friend WithEvents pnItens As Panel
	Friend WithEvents Button1 As Button
	Friend WithEvents btnExcluirAgendamento As Button
	Friend WithEvents pbCalen As ProgressBar
	Friend WithEvents tmPopularCalendario As Timer
	Friend WithEvents mcRef As MonthCalendar
	Public WithEvents ilFig As ImageList
	Friend WithEvents btnAddLembrete As Button
	Friend WithEvents lblStatus As Label
	Friend WithEvents btnRegistrarSaida As Button
	Friend WithEvents btnRegistrarVolta As Button
	Friend WithEvents Label20 As Label
	Friend WithEvents cboMotorista As ComboBox
End Class
