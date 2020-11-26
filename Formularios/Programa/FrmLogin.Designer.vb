<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin


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
	      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
	      Me.tmTempo = New System.Windows.Forms.Timer(Me.components)
	      Me.lblHora = New System.Windows.Forms.Label()
	      Me.tmExpandirCadastro = New System.Windows.Forms.Timer(Me.components)
	      Me.tmMinimizarCadastro = New System.Windows.Forms.Timer(Me.components)
	      Me.tmPressionarEnter = New System.Windows.Forms.Timer(Me.components)
	      Me.btnConectar = New System.Windows.Forms.Button()
	      Me.Label5 = New System.Windows.Forms.Label()
	      Me.txtCaminhoBD = New System.Windows.Forms.TextBox()
	      Me.lblStateConn = New System.Windows.Forms.Label()
	      Me.ofdProcBD = New System.Windows.Forms.OpenFileDialog()
	      Me.btnBuscarBD = New System.Windows.Forms.Button()
	      Me.txtSenhaBD = New System.Windows.Forms.TextBox()
	      Me.Label6 = New System.Windows.Forms.Label()
	      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
	      Me.tmCarregamento = New System.Windows.Forms.Timer(Me.components)
	      Me.lstStatusConexao = New System.Windows.Forms.ListView()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.Label7 = New System.Windows.Forms.Label()
	      Me.PictureBox6 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox5 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox3 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
	      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
	      Me.btnExpDoc = New System.Windows.Forms.Button()
	      Me.btnClose = New System.Windows.Forms.Button()
	      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
	      Me.btnCancelar = New System.Windows.Forms.Button()
	      Me.btnPermissao = New System.Windows.Forms.Button()
	      Me.txtChavePadrao = New System.Windows.Forms.TextBox()
	      Me.Label4 = New System.Windows.Forms.Label()
	      Me.txtSenhaCadastro = New System.Windows.Forms.TextBox()
	      Me.Label3 = New System.Windows.Forms.Label()
	      Me.txtNomeCadastro = New System.Windows.Forms.TextBox()
	      Me.btnCadastrar = New System.Windows.Forms.Button()
	      Me.Label2 = New System.Windows.Forms.Label()
	      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
	      Me.btnMinimizar = New System.Windows.Forms.Button()
	      Me.pbLogin = New System.Windows.Forms.ProgressBar()
	      Me.cboTema = New System.Windows.Forms.ComboBox()
	      Me.txtSenha = New MaterialSkin.Controls.MaterialSingleLineTextField()
	      Me.btnLogin = New MaterialSkin.Controls.MaterialFlatButton()
	      Me.txtUsuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
	      Me.GroupBox2.SuspendLayout()
	      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.GroupBox1.SuspendLayout()
	      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'tmTempo
	      '
	      Me.tmTempo.Enabled = True
	      '
	      'lblHora
	      '
	      Me.lblHora.AutoSize = True
	      Me.lblHora.BackColor = System.Drawing.Color.Transparent
	      Me.lblHora.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblHora.ForeColor = System.Drawing.Color.White
	      Me.lblHora.Location = New System.Drawing.Point(12, 9)
	      Me.lblHora.Name = "lblHora"
	      Me.lblHora.Size = New System.Drawing.Size(34, 15)
	      Me.lblHora.TabIndex = 10
	      Me.lblHora.Text = "00:00"
	      '
	      'tmExpandirCadastro
	      '
	      Me.tmExpandirCadastro.Interval = 50
	      '
	      'tmMinimizarCadastro
	      '
	      Me.tmMinimizarCadastro.Interval = 50
	      '
	      'tmPressionarEnter
	      '
	      Me.tmPressionarEnter.Interval = 10000
	      '
	      'btnConectar
	      '
	      Me.btnConectar.BackColor = System.Drawing.Color.LightSkyBlue
	      Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnConectar.Location = New System.Drawing.Point(9, 140)
	      Me.btnConectar.Name = "btnConectar"
	      Me.btnConectar.Size = New System.Drawing.Size(188, 27)
	      Me.btnConectar.TabIndex = 16
	      Me.btnConectar.Text = "&CONECTAR"
	      Me.btnConectar.UseVisualStyleBackColor = False
	      '
	      'Label5
	      '
	      Me.Label5.AutoSize = True
	      Me.Label5.BackColor = System.Drawing.Color.Transparent
	      Me.Label5.Location = New System.Drawing.Point(65, 20)
	      Me.Label5.Name = "Label5"
	      Me.Label5.Size = New System.Drawing.Size(82, 15)
	      Me.Label5.TabIndex = 17
	      Me.Label5.Text = "Banco de Dados"
	      '
	      'txtCaminhoBD
	      '
	      Me.txtCaminhoBD.Location = New System.Drawing.Point(9, 38)
	      Me.txtCaminhoBD.Name = "txtCaminhoBD"
	      Me.txtCaminhoBD.Size = New System.Drawing.Size(188, 20)
	      Me.txtCaminhoBD.TabIndex = 18
	      '
	      'lblStateConn
	      '
	      Me.lblStateConn.AutoSize = True
	      Me.lblStateConn.BackColor = System.Drawing.Color.Transparent
	      Me.lblStateConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblStateConn.ForeColor = System.Drawing.Color.Red
	      Me.lblStateConn.Location = New System.Drawing.Point(359, 10)
	      Me.lblStateConn.Name = "lblStateConn"
	      Me.lblStateConn.Size = New System.Drawing.Size(207, 24)
	      Me.lblStateConn.TabIndex = 19
	      Me.lblStateConn.Text = "Servidor Desconectado"
	      '
	      'ofdProcBD
	      '
	      Me.ofdProcBD.FileName = "OpenFileDialog1"
	      '
	      'btnBuscarBD
	      '
	      Me.btnBuscarBD.BackColor = System.Drawing.Color.LightSkyBlue
	      Me.btnBuscarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnBuscarBD.Location = New System.Drawing.Point(9, 110)
	      Me.btnBuscarBD.Name = "btnBuscarBD"
	      Me.btnBuscarBD.Size = New System.Drawing.Size(188, 27)
	      Me.btnBuscarBD.TabIndex = 20
	      Me.btnBuscarBD.Text = "&PROCURAR"
	      Me.btnBuscarBD.UseVisualStyleBackColor = False
	      '
	      'txtSenhaBD
	      '
	      Me.txtSenhaBD.Location = New System.Drawing.Point(9, 82)
	      Me.txtSenhaBD.Name = "txtSenhaBD"
	      Me.txtSenhaBD.Size = New System.Drawing.Size(188, 20)
	      Me.txtSenhaBD.TabIndex = 22
	      Me.txtSenhaBD.UseSystemPasswordChar = True
	      '
	      'Label6
	      '
	      Me.Label6.AutoSize = True
	      Me.Label6.BackColor = System.Drawing.Color.Transparent
	      Me.Label6.Location = New System.Drawing.Point(85, 65)
	      Me.Label6.Name = "Label6"
	      Me.Label6.Size = New System.Drawing.Size(35, 15)
	      Me.Label6.TabIndex = 21
	      Me.Label6.Text = "Senha"
	      '
	      'GroupBox2
	      '
	      Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
	      Me.GroupBox2.Controls.Add(Me.Label5)
	      Me.GroupBox2.Controls.Add(Me.btnBuscarBD)
	      Me.GroupBox2.Controls.Add(Me.txtSenhaBD)
	      Me.GroupBox2.Controls.Add(Me.btnConectar)
	      Me.GroupBox2.Controls.Add(Me.txtCaminhoBD)
	      Me.GroupBox2.Controls.Add(Me.Label6)
	      Me.GroupBox2.Location = New System.Drawing.Point(363, 225)
	      Me.GroupBox2.Name = "GroupBox2"
	      Me.GroupBox2.Size = New System.Drawing.Size(203, 178)
	      Me.GroupBox2.TabIndex = 23
	      Me.GroupBox2.TabStop = False
	      '
	      'tmCarregamento
	      '
	      Me.tmCarregamento.Interval = 10000
	      '
	      'lstStatusConexao
	      '
	      Me.lstStatusConexao.HideSelection = False
	      Me.lstStatusConexao.Location = New System.Drawing.Point(363, 42)
	      Me.lstStatusConexao.Name = "lstStatusConexao"
	      Me.lstStatusConexao.Size = New System.Drawing.Size(203, 177)
	      Me.lstStatusConexao.TabIndex = 24
	      Me.lstStatusConexao.UseCompatibleStateImageBehavior = False
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.BackColor = System.Drawing.Color.Transparent
	      Me.Label1.ForeColor = System.Drawing.Color.White
	      Me.Label1.Location = New System.Drawing.Point(300, 440)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(38, 17)
	      Me.Label1.TabIndex = 29
	      Me.Label1.Text = "v 1.1.26"
	      Me.Label1.UseCompatibleTextRendering = True
	      Me.Label1.Visible = False
	      '
	      'Label7
	      '
	      Me.Label7.AutoSize = True
	      Me.Label7.BackColor = System.Drawing.Color.Transparent
	      Me.Label7.ForeColor = System.Drawing.Color.White
	      Me.Label7.Location = New System.Drawing.Point(15, 436)
	      Me.Label7.Name = "Label7"
	      Me.Label7.Size = New System.Drawing.Size(89, 17)
	      Me.Label7.TabIndex = 39
	      Me.Label7.Text = "Nova Litoral Gesso"
	      Me.Label7.UseCompatibleTextRendering = True
	      Me.Label7.Visible = False
	      '
	      'PictureBox6
	      '
	      Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox6.BackgroundImage = Global.ControleOS.My.Resources.Resources._1491579542_yumminkysocialmedia22_83078
	      Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox6.Location = New System.Drawing.Point(262, 284)
	      Me.PictureBox6.Name = "PictureBox6"
	      Me.PictureBox6.Size = New System.Drawing.Size(42, 40)
	      Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox6.TabIndex = 38
	      Me.PictureBox6.TabStop = False
	      '
	      'PictureBox5
	      '
	      Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox5.BackgroundImage = Global.ControleOS.My.Resources.Resources.Google_Mail_Icon_icon_icons_com_52847
	      Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox5.Location = New System.Drawing.Point(153, 284)
	      Me.PictureBox5.Name = "PictureBox5"
	      Me.PictureBox5.Size = New System.Drawing.Size(42, 40)
	      Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox5.TabIndex = 37
	      Me.PictureBox5.TabStop = False
	      '
	      'PictureBox3
	      '
	      Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox3.BackgroundImage = Global.ControleOS.My.Resources.Resources._1490889652_facebook_82510
	      Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox3.Location = New System.Drawing.Point(50, 284)
	      Me.PictureBox3.Name = "PictureBox3"
	      Me.PictureBox3.Size = New System.Drawing.Size(42, 40)
	      Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox3.TabIndex = 36
	      Me.PictureBox3.TabStop = False
	      '
	      'PictureBox4
	      '
	      Me.PictureBox4.BackColor = System.Drawing.Color.Gray
	      Me.PictureBox4.BackgroundImage = Global.ControleOS.My.Resources.Resources.locked_padlock_rounded_black_tool_security_interface_symbol_icon_icons1
	      Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox4.Location = New System.Drawing.Point(50, 186)
	      Me.PictureBox4.Name = "PictureBox4"
	      Me.PictureBox4.Size = New System.Drawing.Size(35, 39)
	      Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox4.TabIndex = 34
	      Me.PictureBox4.TabStop = False
	      '
	      'PictureBox1
	      '
	      Me.PictureBox1.BackColor = System.Drawing.Color.Gray
	      Me.PictureBox1.BackgroundImage = Global.ControleOS.My.Resources.Resources.user_blue_253251
	      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox1.Location = New System.Drawing.Point(50, 130)
	      Me.PictureBox1.Name = "PictureBox1"
	      Me.PictureBox1.Size = New System.Drawing.Size(35, 33)
	      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox1.TabIndex = 30
	      Me.PictureBox1.TabStop = False
	      '
	      'btnExpDoc
	      '
	      Me.btnExpDoc.BackColor = System.Drawing.Color.Transparent
	      Me.btnExpDoc.BackgroundImage = Global.ControleOS.My.Resources.Resources.next_1
	      Me.btnExpDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnExpDoc.FlatAppearance.BorderSize = 0
	      Me.btnExpDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnExpDoc.Location = New System.Drawing.Point(342, 186)
	      Me.btnExpDoc.Name = "btnExpDoc"
	      Me.btnExpDoc.Size = New System.Drawing.Size(16, 74)
	      Me.btnExpDoc.TabIndex = 26
	      Me.btnExpDoc.UseVisualStyleBackColor = False
	      '
	      'btnClose
	      '
	      Me.btnClose.BackgroundImage = Global.ControleOS.My.Resources.Resources._302669
	      Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnClose.FlatAppearance.BorderSize = 0
	      Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnClose.Location = New System.Drawing.Point(330, 2)
	      Me.btnClose.Name = "btnClose"
	      Me.btnClose.Size = New System.Drawing.Size(28, 28)
	      Me.btnClose.TabIndex = 26
	      Me.btnClose.UseVisualStyleBackColor = True
	      '
	      'GroupBox1
	      '
	      Me.GroupBox1.BackgroundImage = Global.ControleOS.My.Resources.Resources.BackGround_Azul_Gradiente
	      Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.GroupBox1.Controls.Add(Me.btnCancelar)
	      Me.GroupBox1.Controls.Add(Me.btnPermissao)
	      Me.GroupBox1.Controls.Add(Me.txtChavePadrao)
	      Me.GroupBox1.Controls.Add(Me.Label4)
	      Me.GroupBox1.Controls.Add(Me.txtSenhaCadastro)
	      Me.GroupBox1.Controls.Add(Me.Label3)
	      Me.GroupBox1.Controls.Add(Me.txtNomeCadastro)
	      Me.GroupBox1.Controls.Add(Me.btnCadastrar)
	      Me.GroupBox1.Controls.Add(Me.Label2)
	      Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.GroupBox1.Location = New System.Drawing.Point(630, 234)
	      Me.GroupBox1.Name = "GroupBox1"
	      Me.GroupBox1.Size = New System.Drawing.Size(0, 0)
	      Me.GroupBox1.TabIndex = 14
	      Me.GroupBox1.TabStop = False
	      Me.GroupBox1.Text = "Cadastrar Novo Usuario"
	      Me.GroupBox1.Visible = False
	      '
	      'btnCancelar
	      '
	      Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
	      Me.btnCancelar.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cancelar
	      Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnCancelar.FlatAppearance.BorderSize = 0
	      Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnCancelar.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnCancelar.Location = New System.Drawing.Point(292, 122)
	      Me.btnCancelar.Name = "btnCancelar"
	      Me.btnCancelar.Size = New System.Drawing.Size(24, 33)
	      Me.btnCancelar.TabIndex = 8
	      Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
	      Me.btnCancelar.UseVisualStyleBackColor = False
	      '
	      'btnPermissao
	      '
	      Me.btnPermissao.BackColor = System.Drawing.Color.Transparent
	      Me.btnPermissao.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cadeado_Bloqueado
	      Me.btnPermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnPermissao.FlatAppearance.BorderSize = 0
	      Me.btnPermissao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnPermissao.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnPermissao.Location = New System.Drawing.Point(203, 78)
	      Me.btnPermissao.Name = "btnPermissao"
	      Me.btnPermissao.Size = New System.Drawing.Size(42, 46)
	      Me.btnPermissao.TabIndex = 7
	      Me.btnPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter
	      Me.btnPermissao.UseVisualStyleBackColor = False
	      '
	      'txtChavePadrao
	      '
	      Me.txtChavePadrao.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtChavePadrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtChavePadrao.Location = New System.Drawing.Point(170, 50)
	      Me.txtChavePadrao.Name = "txtChavePadrao"
	      Me.txtChavePadrao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
	      Me.txtChavePadrao.Size = New System.Drawing.Size(120, 15)
	      Me.txtChavePadrao.TabIndex = 6
	      Me.txtChavePadrao.UseSystemPasswordChar = True
	      '
	      'Label4
	      '
	      Me.Label4.AutoSize = True
	      Me.Label4.BackColor = System.Drawing.Color.Transparent
	      Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label4.Location = New System.Drawing.Point(180, 23)
	      Me.Label4.Name = "Label4"
	      Me.Label4.Size = New System.Drawing.Size(95, 23)
	      Me.Label4.TabIndex = 5
	      Me.Label4.Text = "Chave Padrão"
	      '
	      'txtSenhaCadastro
	      '
	      Me.txtSenhaCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtSenhaCadastro.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtSenhaCadastro.Location = New System.Drawing.Point(17, 95)
	      Me.txtSenhaCadastro.Name = "txtSenhaCadastro"
	      Me.txtSenhaCadastro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
	      Me.txtSenhaCadastro.ReadOnly = True
	      Me.txtSenhaCadastro.Size = New System.Drawing.Size(90, 22)
	      Me.txtSenhaCadastro.TabIndex = 4
	      Me.txtSenhaCadastro.UseSystemPasswordChar = True
	      '
	      'Label3
	      '
	      Me.Label3.AutoSize = True
	      Me.Label3.BackColor = System.Drawing.Color.Transparent
	      Me.Label3.Location = New System.Drawing.Point(16, 74)
	      Me.Label3.Name = "Label3"
	      Me.Label3.Size = New System.Drawing.Size(56, 20)
	      Me.Label3.TabIndex = 3
	      Me.Label3.Text = "Senha"
	      '
	      'txtNomeCadastro
	      '
	      Me.txtNomeCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtNomeCadastro.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtNomeCadastro.Location = New System.Drawing.Point(17, 50)
	      Me.txtNomeCadastro.Name = "txtNomeCadastro"
	      Me.txtNomeCadastro.ReadOnly = True
	      Me.txtNomeCadastro.Size = New System.Drawing.Size(90, 22)
	      Me.txtNomeCadastro.TabIndex = 2
	      '
	      'btnCadastrar
	      '
	      Me.btnCadastrar.BackColor = System.Drawing.Color.Transparent
	      Me.btnCadastrar.FlatAppearance.BorderSize = 0
	      Me.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnCadastrar.Location = New System.Drawing.Point(17, 122)
	      Me.btnCadastrar.Name = "btnCadastrar"
	      Me.btnCadastrar.Size = New System.Drawing.Size(75, 27)
	      Me.btnCadastrar.TabIndex = 1
	      Me.btnCadastrar.Text = "Cadastrar"
	      Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnCadastrar.UseVisualStyleBackColor = False
	      Me.btnCadastrar.Visible = False
	      '
	      'Label2
	      '
	      Me.Label2.AutoSize = True
	      Me.Label2.BackColor = System.Drawing.Color.Transparent
	      Me.Label2.Location = New System.Drawing.Point(16, 29)
	      Me.Label2.Name = "Label2"
	      Me.Label2.Size = New System.Drawing.Size(51, 20)
	      Me.Label2.TabIndex = 0
	      Me.Label2.Text = "Nome"
	      '
	      'PictureBox2
	      '
	      Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
	      Me.PictureBox2.BackgroundImage = Global.ControleOS.My.Resources.Resources.friends_link_send_share_icon_123609__1_
	      Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox2.Location = New System.Drawing.Point(143, 31)
	      Me.PictureBox2.Name = "PictureBox2"
	      Me.PictureBox2.Size = New System.Drawing.Size(62, 68)
	      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
	      Me.PictureBox2.TabIndex = 9
	      Me.PictureBox2.TabStop = False
	      '
	      'btnMinimizar
	      '
	      Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
	      Me.btnMinimizar.BackgroundImage = Global.ControleOS.My.Resources.Resources.back1
	      Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnMinimizar.FlatAppearance.BorderSize = 0
	      Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnMinimizar.Location = New System.Drawing.Point(342, 186)
	      Me.btnMinimizar.Name = "btnMinimizar"
	      Me.btnMinimizar.Size = New System.Drawing.Size(16, 74)
	      Me.btnMinimizar.TabIndex = 27
	      Me.btnMinimizar.UseVisualStyleBackColor = False
	      '
	      'pbLogin
	      '
	      Me.pbLogin.Location = New System.Drawing.Point(7, 422)
	      Me.pbLogin.Name = "pbLogin"
	      Me.pbLogin.Size = New System.Drawing.Size(346, 11)
	      Me.pbLogin.TabIndex = 40
	      '
	      'cboTema
	      '
	      Me.cboTema.Cursor = System.Windows.Forms.Cursors.Hand
	      Me.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
	      Me.cboTema.FormattingEnabled = True
	      Me.cboTema.Items.AddRange(New Object() {"Light", "Dark"})
	      Me.cboTema.Location = New System.Drawing.Point(2, 448)
	      Me.cboTema.Name = "cboTema"
	      Me.cboTema.Size = New System.Drawing.Size(121, 23)
	      Me.cboTema.TabIndex = 44
	      '
	      'txtSenha
	      '
	      Me.txtSenha.Depth = 0
	      Me.txtSenha.Hint = ""
	      Me.txtSenha.Location = New System.Drawing.Point(91, 198)
	      Me.txtSenha.MouseState = MaterialSkin.MouseState.HOVER
	      Me.txtSenha.Name = "txtSenha"
	      Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	      Me.txtSenha.SelectedText = ""
	      Me.txtSenha.SelectionLength = 0
	      Me.txtSenha.SelectionStart = 0
	      Me.txtSenha.Size = New System.Drawing.Size(156, 23)
	      Me.txtSenha.TabIndex = 1
	      Me.txtSenha.UseSystemPasswordChar = False
	      '
	      'btnLogin
	      '
	      Me.btnLogin.AutoSize = True
	      Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
	      Me.btnLogin.BackgroundImage = Global.ControleOS.My.Resources.Resources.Confirmar
	      Me.btnLogin.Depth = 0
	      Me.btnLogin.Location = New System.Drawing.Point(262, 195)
	      Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
	      Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
	      Me.btnLogin.Name = "btnLogin"
	      Me.btnLogin.Primary = False
	      Me.btnLogin.Size = New System.Drawing.Size(52, 36)
	      Me.btnLogin.TabIndex = 47
	      Me.btnLogin.Text = "Login"
	      Me.btnLogin.UseVisualStyleBackColor = True
	      '
	      'txtUsuario
	      '
	      Me.txtUsuario.Depth = 0
	      Me.txtUsuario.Hint = ""
	      Me.txtUsuario.Location = New System.Drawing.Point(91, 135)
	      Me.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER
	      Me.txtUsuario.Name = "txtUsuario"
	      Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	      Me.txtUsuario.SelectedText = ""
	      Me.txtUsuario.SelectionLength = 0
	      Me.txtUsuario.SelectionStart = 0
	      Me.txtUsuario.Size = New System.Drawing.Size(156, 23)
	      Me.txtUsuario.TabIndex = 0
	      Me.txtUsuario.UseSystemPasswordChar = False
	      '
	      'FrmLogin
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
	      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.ClientSize = New System.Drawing.Size(362, 476)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.txtUsuario)
	      Me.Controls.Add(Me.btnLogin)
	      Me.Controls.Add(Me.txtSenha)
	      Me.Controls.Add(Me.cboTema)
	      Me.Controls.Add(Me.pbLogin)
	      Me.Controls.Add(Me.Label7)
	      Me.Controls.Add(Me.PictureBox6)
	      Me.Controls.Add(Me.PictureBox5)
	      Me.Controls.Add(Me.PictureBox3)
	      Me.Controls.Add(Me.PictureBox4)
	      Me.Controls.Add(Me.PictureBox1)
	      Me.Controls.Add(Me.Label1)
	      Me.Controls.Add(Me.btnExpDoc)
	      Me.Controls.Add(Me.btnClose)
	      Me.Controls.Add(Me.lstStatusConexao)
	      Me.Controls.Add(Me.GroupBox2)
	      Me.Controls.Add(Me.lblStateConn)
	      Me.Controls.Add(Me.GroupBox1)
	      Me.Controls.Add(Me.lblHora)
	      Me.Controls.Add(Me.PictureBox2)
	      Me.Controls.Add(Me.btnMinimizar)
	      Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.HelpButton = True
	      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
	      Me.Name = "FrmLogin"
	      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	      Me.Text = " "
	      Me.GroupBox2.ResumeLayout(False)
	      Me.GroupBox2.PerformLayout()
	      CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.GroupBox1.ResumeLayout(False)
	      Me.GroupBox1.PerformLayout()
	      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)
	      Me.PerformLayout()

        End Sub
        Friend WithEvents tmTempo As Timer
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents lblHora As Label
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents tmExpandirCadastro As Timer
        Friend WithEvents txtSenhaCadastro As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtNomeCadastro As TextBox
        Friend WithEvents btnCadastrar As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents btnPermissao As Button
        Friend WithEvents txtChavePadrao As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents btnCancelar As Button
        Friend WithEvents tmMinimizarCadastro As Timer
        Friend WithEvents tmPressionarEnter As Timer
        Friend WithEvents btnConectar As Button
        Friend WithEvents Label5 As Label
        Friend WithEvents txtCaminhoBD As TextBox
        Friend WithEvents lblStateConn As Label
        Friend WithEvents ofdProcBD As OpenFileDialog
        Friend WithEvents btnBuscarBD As Button
        Friend WithEvents txtSenhaBD As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents tmCarregamento As Timer
        Friend WithEvents lstStatusConexao As ListView
        Friend WithEvents btnClose As Button
        Friend WithEvents btnMinimizar As Button
        Friend WithEvents btnExpDoc As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents PictureBox4 As PictureBox
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents PictureBox5 As PictureBox
        Friend WithEvents PictureBox6 As PictureBox
        Friend WithEvents Label7 As Label
        Friend WithEvents pbLogin As ProgressBar
        Friend WithEvents cboTema As ComboBox
        Friend WithEvents txtSenha As MaterialSkin.Controls.MaterialSingleLineTextField
        Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents txtUsuario As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
