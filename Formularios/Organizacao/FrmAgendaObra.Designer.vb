<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendaObra
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaObra))
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtData = New System.Windows.Forms.TextBox()
		Me.txtStatus = New System.Windows.Forms.TextBox()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.l6 = New System.Windows.Forms.ListView()
		Me.ilFig = New System.Windows.Forms.ImageList(Me.components)
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.mcRef = New System.Windows.Forms.MonthCalendar()
		Me.pbCalen = New System.Windows.Forms.ProgressBar()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtAtividade = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtNomeCliente = New System.Windows.Forms.TextBox()
		Me.txtUsuarioID = New System.Windows.Forms.TextBox()
		Me.tmPopularCalendario = New System.Windows.Forms.Timer(Me.components)
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.sem1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.sem7 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.sem6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.sem5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.sem4 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.sem3 = New System.Windows.Forms.Label()
		Me.sem2 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbData = New System.Windows.Forms.TrackBar()
		Me.l7 = New System.Windows.Forms.ListView()
		Me.l4 = New System.Windows.Forms.ListView()
		Me.l3 = New System.Windows.Forms.ListView()
		Me.l5 = New System.Windows.Forms.ListView()
		Me.l1 = New System.Windows.Forms.ListView()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnSubtrair = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnSomar = New System.Windows.Forms.Button()
		Me.l2 = New System.Windows.Forms.ListView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Panel5.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel8.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.tbData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = System.Drawing.Color.Transparent
		Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(15, 2)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(30, 16)
		Me.Label15.TabIndex = 43
		Me.Label15.Text = "Data"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(15, 42)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(44, 16)
		Me.Label14.TabIndex = 41
		Me.Label14.Text = "Horario"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(15, 82)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(36, 16)
		Me.Label12.TabIndex = 37
		Me.Label12.Text = "Status"
		'
		'txtData
		'
		Me.txtData.Location = New System.Drawing.Point(18, 20)
		Me.txtData.Name = "txtData"
		Me.txtData.Size = New System.Drawing.Size(100, 20)
		Me.txtData.TabIndex = 42
		'
		'txtStatus
		'
		Me.txtStatus.Location = New System.Drawing.Point(18, 97)
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.Size = New System.Drawing.Size(100, 20)
		Me.txtStatus.TabIndex = 36
		'
		'txtHora
		'
		Me.txtHora.Location = New System.Drawing.Point(18, 59)
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(100, 20)
		Me.txtHora.TabIndex = 40
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel5.Controls.Add(Me.l6)
		Me.Panel5.Location = New System.Drawing.Point(29, 115)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(1010, 199)
		Me.Panel5.TabIndex = 38
		'
		'l6
		'
		Me.l6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l6.GridLines = True
		Me.l6.HideSelection = False
		Me.l6.Location = New System.Drawing.Point(1230, 46)
		Me.l6.MultiSelect = False
		Me.l6.Name = "l6"
		Me.l6.ShowGroups = False
		Me.l6.Size = New System.Drawing.Size(140, 316)
		Me.l6.SmallImageList = Me.ilFig
		Me.l6.StateImageList = Me.ilFig
		Me.l6.TabIndex = 34
		Me.l6.UseCompatibleStateImageBehavior = False
		Me.l6.View = System.Windows.Forms.View.List
		'
		'ilFig
		'
		Me.ilFig.ImageStream = CType(resources.GetObject("ilFig.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilFig.TransparentColor = System.Drawing.Color.Black
		Me.ilFig.Images.SetKeyName(0, "friends_link_send_share_icon_123609 (1).ico")
		Me.ilFig.Images.SetKeyName(1, "pa.ico")
		Me.ilFig.Images.SetKeyName(2, "carro.ico")
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel6.Controls.Add(Me.mcRef)
		Me.Panel6.Controls.Add(Me.pbCalen)
		Me.Panel6.Controls.Add(Me.Panel8)
		Me.Panel6.Controls.Add(Me.Panel7)
		Me.Panel6.Location = New System.Drawing.Point(29, 312)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(1010, 431)
		Me.Panel6.TabIndex = 40
		'
		'mcRef
		'
		Me.mcRef.Cursor = System.Windows.Forms.Cursors.Hand
		Me.mcRef.Location = New System.Drawing.Point(750, 229)
		Me.mcRef.Name = "mcRef"
		Me.mcRef.ShowWeekNumbers = True
		Me.mcRef.TabIndex = 0
		Me.mcRef.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		'
		'pbCalen
		'
		Me.pbCalen.ForeColor = System.Drawing.Color.Transparent
		Me.pbCalen.Location = New System.Drawing.Point(15, 393)
		Me.pbCalen.Name = "pbCalen"
		Me.pbCalen.Size = New System.Drawing.Size(375, 23)
		Me.pbCalen.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.pbCalen.TabIndex = 17
		Me.pbCalen.Visible = False
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
		Me.Panel8.Location = New System.Drawing.Point(264, 234)
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
		Me.Panel7.Location = New System.Drawing.Point(15, 234)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(243, 157)
		Me.Panel7.TabIndex = 48
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(16, 3)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(110, 16)
		Me.Label10.TabIndex = 33
		Me.Label10.Text = "Usuário Responsável"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(13, 80)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(51, 16)
		Me.Label13.TabIndex = 39
		Me.Label13.Text = "Atividade"
		'
		'txtAtividade
		'
		Me.txtAtividade.Location = New System.Drawing.Point(13, 97)
		Me.txtAtividade.Multiline = True
		Me.txtAtividade.Name = "txtAtividade"
		Me.txtAtividade.Size = New System.Drawing.Size(232, 55)
		Me.txtAtividade.TabIndex = 38
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(16, 42)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(86, 16)
		Me.Label11.TabIndex = 35
		Me.Label11.Text = "Nome do Cliente"
		'
		'txtNomeCliente
		'
		Me.txtNomeCliente.Location = New System.Drawing.Point(14, 59)
		Me.txtNomeCliente.Name = "txtNomeCliente"
		Me.txtNomeCliente.Size = New System.Drawing.Size(231, 20)
		Me.txtNomeCliente.TabIndex = 34
		'
		'txtUsuarioID
		'
		Me.txtUsuarioID.Location = New System.Drawing.Point(13, 21)
		Me.txtUsuarioID.Name = "txtUsuarioID"
		Me.txtUsuarioID.Size = New System.Drawing.Size(232, 20)
		Me.txtUsuarioID.TabIndex = 32
		'
		'tmPopularCalendario
		'
		Me.tmPopularCalendario.Enabled = True
		Me.tmPopularCalendario.Interval = 10000
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
		Me.Panel3.Location = New System.Drawing.Point(37, 84)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(994, 55)
		Me.Panel3.TabIndex = 39
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(74, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 20)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Data"
		'
		'sem1
		'
		Me.sem1.AutoSize = True
		Me.sem1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem1.Location = New System.Drawing.Point(27, 29)
		Me.sem1.Name = "sem1"
		Me.sem1.Size = New System.Drawing.Size(78, 20)
		Me.sem1.TabIndex = 17
		Me.sem1.Text = "Dia Semana"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(211, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 20)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Data"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(365, 8)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(35, 20)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Data"
		'
		'sem7
		'
		Me.sem7.AutoSize = True
		Me.sem7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem7.Location = New System.Drawing.Point(878, 29)
		Me.sem7.Name = "sem7"
		Me.sem7.Size = New System.Drawing.Size(78, 20)
		Me.sem7.TabIndex = 23
		Me.sem7.Text = "Dia Semana"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(501, 8)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(35, 20)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Data"
		'
		'sem6
		'
		Me.sem6.AutoSize = True
		Me.sem6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem6.Location = New System.Drawing.Point(731, 29)
		Me.sem6.Name = "sem6"
		Me.sem6.Size = New System.Drawing.Size(78, 20)
		Me.sem6.TabIndex = 22
		Me.sem6.Text = "Dia Semana"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(638, 8)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 20)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Data"
		'
		'sem5
		'
		Me.sem5.AutoSize = True
		Me.sem5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem5.Location = New System.Drawing.Point(591, 29)
		Me.sem5.Name = "sem5"
		Me.sem5.Size = New System.Drawing.Size(78, 20)
		Me.sem5.TabIndex = 21
		Me.sem5.Text = "Dia Semana"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(777, 8)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(35, 20)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Data"
		'
		'sem4
		'
		Me.sem4.AutoSize = True
		Me.sem4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem4.Location = New System.Drawing.Point(454, 29)
		Me.sem4.Name = "sem4"
		Me.sem4.Size = New System.Drawing.Size(78, 20)
		Me.sem4.TabIndex = 20
		Me.sem4.Text = "Dia Semana"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(925, 8)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 20)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Data"
		'
		'sem3
		'
		Me.sem3.AutoSize = True
		Me.sem3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem3.Location = New System.Drawing.Point(318, 29)
		Me.sem3.Name = "sem3"
		Me.sem3.Size = New System.Drawing.Size(78, 20)
		Me.sem3.TabIndex = 19
		Me.sem3.Text = "Dia Semana"
		'
		'sem2
		'
		Me.sem2.AutoSize = True
		Me.sem2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sem2.Location = New System.Drawing.Point(165, 29)
		Me.sem2.Name = "sem2"
		Me.sem2.Size = New System.Drawing.Size(78, 20)
		Me.sem2.TabIndex = 18
		Me.sem2.Text = "Dia Semana"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(383, 18)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(288, 31)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "CONTROLE DE ENTREGA"
		'
		'tbData
		'
		Me.tbData.AutoSize = False
		Me.tbData.LargeChange = 1
		Me.tbData.Location = New System.Drawing.Point(6, 2)
		Me.tbData.Maximum = 500
		Me.tbData.Name = "tbData"
		Me.tbData.Size = New System.Drawing.Size(994, 33)
		Me.tbData.TabIndex = 15
		Me.tbData.TickFrequency = 30
		Me.tbData.TickStyle = System.Windows.Forms.TickStyle.TopLeft
		Me.tbData.Value = 250
		'
		'l7
		'
		Me.l7.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
		Me.l7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l7.GridLines = True
		Me.l7.HideSelection = False
		Me.l7.Location = New System.Drawing.Point(891, 145)
		Me.l7.MultiSelect = False
		Me.l7.Name = "l7"
		Me.l7.ShowGroups = False
		Me.l7.Size = New System.Drawing.Size(140, 316)
		Me.l7.SmallImageList = Me.ilFig
		Me.l7.StateImageList = Me.ilFig
		Me.l7.TabIndex = 35
		Me.l7.UseCompatibleStateImageBehavior = False
		Me.l7.View = System.Windows.Forms.View.List
		'
		'l4
		'
		Me.l4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l4.GridLines = True
		Me.l4.HideSelection = False
		Me.l4.Location = New System.Drawing.Point(465, 145)
		Me.l4.MultiSelect = False
		Me.l4.Name = "l4"
		Me.l4.ShowGroups = False
		Me.l4.Size = New System.Drawing.Size(140, 316)
		Me.l4.SmallImageList = Me.ilFig
		Me.l4.StateImageList = Me.ilFig
		Me.l4.TabIndex = 32
		Me.l4.UseCompatibleStateImageBehavior = False
		Me.l4.View = System.Windows.Forms.View.List
		'
		'l3
		'
		Me.l3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l3.GridLines = True
		Me.l3.HideSelection = False
		Me.l3.Location = New System.Drawing.Point(323, 145)
		Me.l3.MultiSelect = False
		Me.l3.Name = "l3"
		Me.l3.ShowGroups = False
		Me.l3.Size = New System.Drawing.Size(140, 316)
		Me.l3.SmallImageList = Me.ilFig
		Me.l3.StateImageList = Me.ilFig
		Me.l3.TabIndex = 31
		Me.l3.UseCompatibleStateImageBehavior = False
		Me.l3.View = System.Windows.Forms.View.List
		'
		'l5
		'
		Me.l5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l5.GridLines = True
		Me.l5.HideSelection = False
		Me.l5.Location = New System.Drawing.Point(607, 145)
		Me.l5.MultiSelect = False
		Me.l5.Name = "l5"
		Me.l5.ShowGroups = False
		Me.l5.Size = New System.Drawing.Size(140, 316)
		Me.l5.SmallImageList = Me.ilFig
		Me.l5.StateImageList = Me.ilFig
		Me.l5.TabIndex = 33
		Me.l5.UseCompatibleStateImageBehavior = False
		Me.l5.View = System.Windows.Forms.View.List
		'
		'l1
		'
		Me.l1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
		Me.l1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l1.GridLines = True
		Me.l1.HideSelection = False
		Me.l1.Location = New System.Drawing.Point(39, 145)
		Me.l1.MultiSelect = False
		Me.l1.Name = "l1"
		Me.l1.ShowGroups = False
		Me.l1.Size = New System.Drawing.Size(140, 316)
		Me.l1.SmallImageList = Me.ilFig
		Me.l1.StateImageList = Me.ilFig
		Me.l1.TabIndex = 29
		Me.l1.UseCompatibleStateImageBehavior = False
		Me.l1.View = System.Windows.Forms.View.List
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Location = New System.Drawing.Point(27, 27)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(91, 31)
		Me.lblStatus.TabIndex = 132
		Me.lblStatus.Text = "Label20"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Panel2.Controls.Add(Me.lblStatus)
		Me.Panel2.Controls.Add(Me.Label8)
		Me.Panel2.Location = New System.Drawing.Point(29, 12)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1010, 103)
		Me.Panel2.TabIndex = 37
		'
		'btnSubtrair
		'
		Me.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnSubtrair.FlatAppearance.BorderSize = 0
		Me.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubtrair.Location = New System.Drawing.Point(925, 41)
		Me.btnSubtrair.Name = "btnSubtrair"
		Me.btnSubtrair.Size = New System.Drawing.Size(27, 23)
		Me.btnSubtrair.TabIndex = 28
		Me.btnSubtrair.Text = "-"
		Me.btnSubtrair.UseVisualStyleBackColor = False
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
		Me.Panel1.Location = New System.Drawing.Point(37, 454)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(994, 71)
		Me.Panel1.TabIndex = 36
		'
		'btnSomar
		'
		Me.btnSomar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnSomar.FlatAppearance.BorderSize = 0
		Me.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSomar.Location = New System.Drawing.Point(958, 41)
		Me.btnSomar.Name = "btnSomar"
		Me.btnSomar.Size = New System.Drawing.Size(27, 23)
		Me.btnSomar.TabIndex = 27
		Me.btnSomar.Text = "+"
		Me.btnSomar.UseVisualStyleBackColor = False
		'
		'l2
		'
		Me.l2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.l2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.l2.GridLines = True
		Me.l2.HideSelection = False
		Me.l2.Location = New System.Drawing.Point(181, 145)
		Me.l2.MultiSelect = False
		Me.l2.Name = "l2"
		Me.l2.ShowGroups = False
		Me.l2.Size = New System.Drawing.Size(140, 316)
		Me.l2.SmallImageList = Me.ilFig
		Me.l2.StateImageList = Me.ilFig
		Me.l2.TabIndex = 41
		Me.l2.UseCompatibleStateImageBehavior = False
		Me.l2.View = System.Windows.Forms.View.List
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(1094, 312)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(53, 57)
		Me.Button1.TabIndex = 42
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'FrmAgendaObra
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1183, 749)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.l2)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.l7)
		Me.Controls.Add(Me.l4)
		Me.Controls.Add(Me.l3)
		Me.Controls.Add(Me.l5)
		Me.Controls.Add(Me.l1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel6)
		Me.Name = "FrmAgendaObra"
		Me.Text = "FrmAgendaObra"
		Me.Panel5.ResumeLayout(False)
		Me.Panel6.ResumeLayout(False)
		Me.Panel8.ResumeLayout(False)
		Me.Panel8.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.tbData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents txtData As TextBox
	Friend WithEvents txtStatus As TextBox
	Friend WithEvents txtHora As TextBox
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel6 As Panel
	Friend WithEvents mcRef As MonthCalendar
	Friend WithEvents Panel8 As Panel
	Friend WithEvents Panel7 As Panel
	Friend WithEvents Label10 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents txtAtividade As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtNomeCliente As TextBox
	Friend WithEvents txtUsuarioID As TextBox
	Friend WithEvents tmPopularCalendario As Timer
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents sem1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents sem7 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents sem6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents sem5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents sem4 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents sem3 As Label
	Friend WithEvents sem2 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents tbData As TrackBar
	Friend WithEvents l7 As ListView
	Friend WithEvents l6 As ListView
	Friend WithEvents l4 As ListView
	Friend WithEvents l3 As ListView
	Public WithEvents ilFig As ImageList
	Friend WithEvents l5 As ListView
	Friend WithEvents l1 As ListView
	Friend WithEvents lblStatus As Label
	Friend WithEvents pbCalen As ProgressBar
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnSubtrair As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnSomar As Button
	Friend WithEvents l2 As ListView
	Friend WithEvents Button1 As Button
End Class
