Imports System.ComponentModel
Imports System.Data.OleDb
Imports MaterialSkin
Imports System.Threading

Public Class FrmLogin

        Inherits Controls.MaterialForm

        Public NivelAcesso As String
        Public ServidorConect As Boolean
        Public conInicio As String
        Public CaminhoBD As String
        Public SenhaBD As String

        '\\*************************************************************** BOTOES ********************************************************************

        '\\VERIFICAR SENHA NO BANCO DE DADOS (BTN)


        '\\LINK DE CADASTRO DE NOVO USUARIO
        Private Sub linkCadastroUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
                tmPressionarEnter.Enabled = False
                GroupBox1.Visible = True
                tmExpandirCadastro.Enabled = True
                ExpandirCadastro()
        End Sub

        Private Sub tmExpandirCadastro_Tick(sender As Object, e As EventArgs) Handles tmExpandirCadastro.Tick
                ExpandirCadastro()
        End Sub

        Private Sub tmMinimizarCadastro_Tick(sender As Object, e As EventArgs) Handles tmMinimizarCadastro.Tick
                MinimizarCadastro()
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
                CancelarCadastro()
        End Sub

        Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
                If txtNomeCadastro.Text <> "" And txtSenhaCadastro.Text <> "" Then
                        CadastrarNovaPessoa()
                End If
        End Sub

        Public Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
                ConectarDB()
        End Sub

        Public Async Sub ConectarDB()
                SenhaBD = txtSenhaBD.Text
                Await ConexaoDB()
        End Sub

        Public Sub btnBuscarBD_Click(sender As Object, e As EventArgs) Handles btnBuscarBD.Click
                BuscaCaminhoBD()
        End Sub

        Private Sub btnExpDoc_Click(sender As Object, e As EventArgs) Handles btnExpDoc.Click
                MaximizarDock()
        End Sub

        Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
                MinimizarDock()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPermissao.Click
                VerificarChavePadrao()
        End Sub

        Private Sub txtNomeCadastro_LostFocus(sender As Object, e As EventArgs) Handles txtNomeCadastro.LostFocus
                txtNomeCadastro.Text = LetraCaixaAlta(txtNomeCadastro.Text)
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
                Me.Close()
        End Sub

        '\\********************************************************* EVENTOS **************************************************************************

        Public Para_NomeUsuario As New OleDbParameter
        Public Para_Senha As New OleDbParameter

        '\\EXIBIR CONTROLES DE SENHA E USUARIO
        Public Sub VisibilidadeControles(senha As Boolean, usuarioControl As Boolean)
                txtSenha.Visible = senha
                txtUsuario.Visible = usuarioControl
        End Sub

        '\\MUDAR COR DA FONTE DA CAIXA DO USUARIO
        Private Sub txtUsuario_MouseClick(sender As Object, e As MouseEventArgs)
                If txtUsuario.ForeColor = Color.Red Then
                        txtUsuario.ForeColor = Color.Black
                        txtUsuario.Text = ""
                End If
        End Sub

        '\\CONTAGEM DE TEMPO PARA EXIBIR A MENSAGEM PARA PRESSIONAR A TECLA "ENTER"
        Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs)
                tmPressionarEnter.Enabled = False
                tmPressionarEnter.Enabled = True
                'lblPressEnter.Visible = False
                If txtSenha.ForeColor = Color.Red Then
                        With txtSenha
                                .ForeColor = Color.Black
                                .Text = ""
                        End With
                End If
        End Sub

        '\\TIMER PARA ATUALIZAR HORA E DATA
        Private Sub tmTempo_Tick(sender As Object, e As EventArgs) Handles tmTempo.Tick
                lblHora.Text = TimeOfDay.ToShortTimeString & "  " & Today.ToShortDateString
        End Sub





        'AO ABRIR FORMULARIO
        Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Dim culturaPtBr = System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
                System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culturaPtBr
                System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = culturaPtBr

                tmTempo.Enabled = True

                txtSenhaBD.Text = ConfigSenhaDB("Select", "")
                txtCaminhoBD.Text = ConfigCaminhoDB("Select", "")
                SenhaBD = ConfigSenhaDB("Select", "")
                CaminhoBD = ConfigCaminhoDB("Select", "")

                ServidorConect = False

                'FONTE USADA NA LISTVIEW(LOG)
                Dim FontPadrao As New Font("Times New Roman", 7)

                'LISTVIEW(LOG)
                With lstStatusConexao
                        .View = View.List
                        .Items.Add("SERVIDOR DESCONECTADO")
                        .Font = FontPadrao
                End With

                If SenhaBD <> "" And CaminhoBD <> "" Then
                        'ConexaoDB()
                End If
                Dim modo As String = My.Settings.Tema
                Select Case modo
                        Case = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                        Case = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                        Case Else
                End Select
                cboTema.Text = My.Settings.Tema
        End Sub

        Private Sub FrmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing 'verificar essa função em caso de erro
                '  sConnectionString = conInicio
        End Sub

        '\\********************************************************* FUNÇÕES E METODOS ********************************************************************

        'INSERIR OU OBTER CAMINHO DO BD
        Public Function ConfigCaminhoDB(Operacao As String, valor As String)
                If Operacao <> "" Then
                        Select Case Operacao
                                Case "Insert"
                                        My.Settings.CaminhoDB = valor
                                Case "Select"
                                        Return My.Settings.CaminhoDB
                                Case Else

                        End Select
                End If
        End Function

        'INSERIR OU OBTER SENHA DO BD
        Public Function ConfigSenhaDB(Operacao As String, valor As String)
                If Operacao <> "" Then
                        Select Case Operacao
                                Case "Insert"
                                        My.Settings.SenhaDB = valor
                                Case "Select"
                                        Return My.Settings.SenhaDB
                                Case Else
                        End Select
                End If
        End Function

        '\\EXPANDIR CADASTROS DE NOVOS USUARIOS
        Public Sub ExpandirCadastro()
                GroupBox1.Visible = True
                If GroupBox1.Width < 320 Then
                        GroupBox1.Width = GroupBox1.Width + 16
                End If
                If GroupBox1.Height < 140 Then
                        GroupBox1.Height = GroupBox1.Height + 10
                End If
                If GroupBox1.Width = 320 And GroupBox1.Height = 140 Then
                        tmExpandirCadastro.Enabled = False
                End If
        End Sub

        '\\CANCELAR CADASTRO
        Public Sub Cancelar()
                txtChavePadrao.Text = ""
                txtNomeCadastro.Text = ""
                txtSenha.Text = ""
                tmMinimizarCadastro.Enabled = True
        End Sub

        '\\MINIMIZAR CADASTRO
        Private Sub MinimizarCadastro()
                GroupBox1.Visible = True
                If GroupBox1.Width > 0 Then
                        GroupBox1.Width = GroupBox1.Width - 16
                End If
                If GroupBox1.Height > 0 Then
                        GroupBox1.Height = GroupBox1.Height - 10
                End If
                If GroupBox1.Width < 6 Or GroupBox1.Height < 10 Then
                        GroupBox1.Height = 0
                        GroupBox1.Width = 0
                        tmMinimizarCadastro.Enabled = False
                End If
        End Sub

        '\\CANCELAR CADASTRO
        Public Sub CancelarCadastro()
                txtChavePadrao.Text = ""
                txtNomeCadastro.Text = ""
                txtSenha.Text = ""
                tmMinimizarCadastro.Enabled = True
        End Sub

        '\\MINIMIZAR DOCK SERVIDOR
        Public Sub MinimizarDock()
                Me.Width = 361
                btnMinimizar.Visible = False
                btnExpDoc.Visible = True
        End Sub

        '\\MAXIMIZAR DOCK SERVIDOR
        Public Sub MaximizarDock()
                Me.Width = 600
                btnExpDoc.Visible = False
                btnMinimizar.Visible = True
        End Sub

        '\\BUSCAR CAMINHO DO BANCO DE DADOS ATRAVES DA CAIXA DE DIALOGO
        Public Sub BuscaCaminhoBD()
                If ofdProcBD.FileName <> "" Then
                        ofdProcBD.ShowDialog()
                        txtCaminhoBD.Text = ofdProcBD.FileName

                        CaminhoBD = ofdProcBD.FileName

                Else
                        MsgBox("Caminho Invalido")
                End If
        End Sub

        'CONEXÃO COM O BANCO DE DADOS
        Public Async Function ConexaoDB() As Task

                lstStatusConexao.Items.Add("VERIFICANDO INFORMAÇÕES")

                Dim cdr As OleDbDataReader
                If txtSenhaBD.Text <> "" Then
                        lstStatusConexao.Items.Add("VERIFICANDO SENHA")
                        conInicio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CaminhoBD & ";Jet OLEDB:Database Password=" & SenhaBD & ";"
                        sConnectionString = conInicio
                        lstStatusConexao.Items.Add("VERIFICANDO " & CaminhoBD & "....")
                        lstStatusConexao.Items.Add("ABRINDO CONEXÃO....")
                        Dim ObjCon As New OleDbConnection(conInicio)
                        Dim cont As Integer = 0
                        ' Thread.Sleep(100)

                        If ObjCon.State = ConnectionState.Closed Then
                                Try
                                        ObjCon.Open()
                                Catch oledb As OleDbException
                                        MsgBox("A senha está incorreta")
                                        cdr = Nothing
                                        ObjCon.Close()
                                        lblStateConn.Text = "Servidor Desconectado"
                                        lblStateConn.ForeColor = Color.Red
                                        GoTo prox
                                End Try
                        End If
                        lstStatusConexao.Items.Add("CONEXÃO ESTABELECIDA COM SUCESSO")
                        sConnectionString = conInicio
                        ConfigSenhaDB("Insert", txtSenhaBD.Text)
                        ConfigCaminhoDB("Insert", txtCaminhoBD.Text)


                        If ObjCon.State = ConnectionState.Open Then
                                lblStateConn.Text = "Servidor Conectado"
                                lblStateConn.ForeColor = Color.Green
                                ServidorConect = True

                                My.MySettings.Default.SistemaGEConnectionString = conInicio

                                My.MySettings.Default.Save()

                                My.Settings.Reload()
                                My.Settings.Upgrade()

                                SQL.sConnectionString = conInicio

                                cdr = Nothing
                                ObjCon.Close()
                        Else
                                cdr = Nothing
                                ObjCon.Close()
                                lstStatusConexao.Items.Add("NÃO FOI POSSIVEL CONECTAR AO BANCO DE DADOS X")
                                lblStateConn.Text = "Servidor Desconectado"
                                lblStateConn.ForeColor = Color.Red
                        End If
prox:
                Else
                        lblStateConn.Text = "Servidor Desconectado"
                        lblStateConn.ForeColor = Color.Red
                        tmCarregamento.Enabled = False
                        MsgBox("Insira uma senha para continuar")
                        lstStatusConexao.Items.Add("VERIFICANDO SENHA....")
                        lstStatusConexao.Items.Add("SENHA INVALIDA!!!")
                End If
        End Function

        'Castrar um novo usuario
        Private Sub CadastrarNovaPessoa()
                If txtNomeCadastro.Text <> "" And txtSenhaCadastro.Text <> "" Then
                        Dim Resp1 As String = InputBox("Digite o nome da sua música favorita. (Essa reposta sera necessaria para recuperar sua senha)")
                        Dim Resp2 As String = InputBox("Digite o nome do seu primeiro animal de estimação. (Essa reposta sera necessaria para recuperar sua senha)")
                        lSQL = "INSERT INTO tbUsuario (Nivel,Nome,Senha,Resposta1,Resposta2)" & "Values(""" & "Padrao" & """,""" & txtNomeCadastro.Text &
                        """,""" & txtSenhaCadastro.Text & """,""" & Resp1 & """,""" & Resp2 & """)"
                        SQL.Comando()
                        SQL.Notificao("NOVA LITORAL GESSO", "Usuario cadastrado com sucesso")
                        txtUsuario.Text = txtNomeCadastro.Text
                        txtNomeCadastro.Text = ""
                        txtSenhaCadastro.Text = ""
                        btnPermissao.BackgroundImage = My.Resources.Cadeado_Bloqueado
                        txtChavePadrao.Text = ""
                        btnCadastrar.Visible = False
                        btnCancelar.PerformClick()
                        tmPressionarEnter.Enabled = True
                Else
                        SQL.Notificao("NOVA LITORAL GESSO", "Um ou mais campos estão em branco")
                End If
        End Sub


        'VERIFICA SE A CHAVE DE ACESSO ESTACORRETA (revisar essa função)
        Private Sub VerificarChavePadrao()
                If txtChavePadrao.Text <> "" Then
                        Connect.Conectardb("SELECT * FROM tbChave")
                        If cdr.HasRows = True Then
                                If txtChavePadrao.Text = cdr.Item("Chave") Then
                                        txtNomeCadastro.ReadOnly = False
                                        txtSenhaCadastro.ReadOnly = False
                                        btnCadastrar.Visible = True
                                        SQL.Notificao("NOVA LITORAL GESSO", "Acesso Liberado")
                                        btnPermissao.BackgroundImage = My.Resources.Cadeado_Desbloquado
                                Else
                                        SQL.Notificao("NOVA LITORAL GESSO", "Acesso Negado, revise sua senha ou entre em contato com o administrador")
                                End If
                        Else
                                SQL.Notificao("NOVA LITORAL GESSO", "Chave Invalida")
                        End If
                Else
                        SQL.Notificao("NOVA LITORAL GESSO", "chave está em branco")
                End If
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
                If cboTema.Text = "Light" Then
                        CorFundo = Color.White
                        CorTexto = Color.Black
                Else
                        CorFundo = Color.FromArgb(51, 51, 51)
                        CorTexto = Color.White
                End If
                BlocoLogin()
        End Sub

        '========================================================================================================================
        ''' <summary>
        '''       METODO DE LOGIN COM DESEMPENHO
        ''' </summary>
        Public Async Sub BlocoLogin()
                Await VerConnDB()

                'verifica se o banco de dados está conectado
                If ServidorConect = True Then

                        'verifica se o campo com o nome do usuario esta preenchido
                        If txtUsuario.Text <> "" Then

                                'verifica o campo da senha do usuario
                                If txtSenha.Text <> "" Then

                                        Await RealizarLoginAsync()
                                Else
                                        txtSenha.BackColor = Color.Red
                                        SQL.Notificao("", "Campo Obrigatório")
                                End If
                        Else
                                SQL.Notificao("", "Campo Obrigatório")
                                txtUsuario.BackColor = Color.Red
                        End If
                Else
                        txtSenha.Text = ""
                        MsgBox("Servidor Desconectado", vbOK, "AIO")
                End If

        End Sub

        ''' <summary>
        '''   verifica se os campos de caminho do banco de dados e de senha estão preenchidos
        ''' </summary>
        ''' <returns></returns>
        Public Async Function VerConnDB() As Task
                If txtCaminhoBD.Text <> "" Or txtSenhaBD.Text <> "" Then
                        ConectarDB()
                End If
        End Function

        ''' <summary>
        '''     REALIZAR LOGIN VERIFICANDO A SENHA NO BANCO DE DADOS
        ''' </summary>
        ''' <returns></returns>
        Public Async Function RealizarLoginAsync() As Task
                'PARAMETRO COM O NOME DO USUARIO
                With Para_NomeUsuario
                        .ParameterName = "NomeUsuario"
                        .OleDbType = OleDbType.Char
                        .Size = 10
                        .Value = txtUsuario.Text
                End With

                With Para_Senha
                        .ParameterName = "SenhaUsuario"
                        .OleDbType = OleDbType.Char
                        .Size = 10
                        .Value = txtSenha.Text
                End With

                Dim consulta As String = "SELECT * FROM tbUsuario WHERE Nome=? AND Senha=?"  'CONSULTA SQL PARA OBTER O USUARIO (PARAMETRO Nome)
                Dim objInicio As New OleDbConnection(sConnectionString)   'CRIAR OBJETO DE CONEXAO

                If objInicio.State = ConnectionState.Closed Then   'ABRIR CONEXAO CASO ESTEJA FECHADA
                        objInicio.Open()
                End If
                Dim objcmd As New OleDbCommand(consulta, objInicio)

                objcmd.Parameters.Clear()    'LIMPAR PARAMETROS PARA EVITAR COMFLITO

                'INSERIR O PARAMETO COM O NOME DO USUARIO e SENHA
                objcmd.Parameters.Add(Para_NomeUsuario)
                objcmd.Parameters.Add(Para_Senha)

                Dim cdr As OleDbDataReader = objcmd.ExecuteReader()    'PREENCHER DATAREADER COM RETORNO DO BANCO DE DADOS

                cdr.Read()    'EXECUTAR LEITURA DO BANCO DE DADOS

                If cdr.HasRows = True Then     'VERIRICAR SE A CONSULTA OBTEVE RETORNO
                        If cdr.Item("Nome") = Para_NomeUsuario.Value And cdr.Item("Senha") = Para_Senha.Value Then
                                Usuario.Nome = cdr.Item("Nome")
                                Usuario.Identificacao = cdr.Item("Código")
                                '   On Error Resume Next
                                Usuario.Cargo = cdr.Item("Cargo") '"Generico" '
                                Usuario.NivelAcesso = cdr.Item("Nivel")
                                FrmMenu.lblNomeUsuario.Text = Usuario.Nome
                                sConnectionString = conInicio
                                FrmMdiHome.Show()
                                SQL.Notificao("NOVA LITORAL GESSO", "bem vindo,  " & Usuario.Nome)
                                txtUsuario.Text = "Usuário"
                                txtSenha.Text = "Senha"
                                FrmAdicionarProduto.dgvCodBarras.Columns.Add("Barras", "Barras")
                                Me.Close()

                        End If
                Else
                        txtUsuario.Text = ""
                        txtSenha.Text = ""
                        SQL.Notificao("NOVA LITORAL GESSO", "NÃO FOI POSSIVEL ENCONTRAR O USUARIO COM OS DADOS INFORMADOS")
                End If
                objcmd.Parameters.Clear()
                objcmd = Nothing
                objInicio.Close()
                consulta = ""
                cdr.Close()
        End Function

        '========================================================================================================================

        Private Sub txtUsuario_Click(sender As Object, e As EventArgs)
                txtUsuario.Text = ""
        End Sub

        Private Sub txtSenha_Click(sender As Object, e As EventArgs)
                txtSenha.Text = ""
        End Sub

        Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs)
                If txtUsuario.Text = "" Then
                        txtUsuario.Text = "Usuário"
                End If
        End Sub

        Private Sub txtSenha_LostFocus(sender As Object, e As EventArgs)
                If txtSenha.Text = "" Then
                        txtSenha.Text = "Senha"
                End If
        End Sub

        Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs)

        End Sub

        Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
                If e.KeyCode = Keys.Enter Then
                        BlocoLogin()
                End If
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs)
                FrmAddLembrete.Show()
        End Sub

        Private Sub cboTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTema.SelectedIndexChanged
                Select Case cboTema.Text
                        Case = "Light"
                                My.Settings.Tema = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                CorFundo = Color.White
                                CorTexto = Color.Black

                        Case = "Dark"
                                My.Settings.Tema = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                CorFundo = Color.FromArgb(51, 51, 51)
                                CorTexto = Color.White

                        Case Else

                End Select
        End Sub

End Class