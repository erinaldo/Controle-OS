Imports System.Data.OleDb
Imports Tulpep.NotificationWindow
Imports Tulpep
Imports MaterialSkin


Module SQL
        Public UsuarioID As Integer
        Public Usuario As String
        Public Cargo As String
        Public Permissao As Double
        Public sConnectionString As String
        Public objConn, objConn2 As New OleDbConnection(sConnectionString)
        Public lSQL As String
        Public dr, dr2 As OleDbDataReader
        Public table As OleDbDataAdapter
        Public CaminhoPCTColaborador As String
        Public CaminhoDB As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CaminhoDB '\\ANALISAR
        Public objConexao As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DataInterno.mdb" & ";Jet OLEDB:Database Password=AezakmiPdnejoh;")
        Public NivelAcesso As String
        Public AnexoID As Integer
        Public EntregaID As Integer
        Public AddItemPag As Boolean
        Public LockChkPdv As Boolean
        Public AcessoAdm As Boolean
        Public SenhaAdm As String
        Public UsuarioAdm As String
        Public PodeEditarPedido As Boolean
        Public PedidoVinculado As Boolean
        Public hdr As OleDbDataReader
        Public Ident As Double
        Public Valor As Double
        Public CorFundo As Color
        Public CorTexto As Color

        Public Sub Comando()
                If lSQL <> "" Then
                        If objConn.State = ConnectionState.Closed Then
                                objConn.ConnectionString = sConnectionString
                                objConn.Open()
                        End If
                        Dim objcmd As New OleDbCommand(lSQL, objConn)
                        On Error Resume Next
                        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
                        dr.Read()
                        Dim linha As String = dr.HasRows
                        Debug.Print(linha)
                        'OBEJETO.dr.item() '\\SERVE PARA SELECIONAR UM CAMPO EM ESPECIFICO
                        dr.Close()
                        dr = Nothing
                        objConn.Close()
                End If
        End Sub

        Public Sub Notificao(ByVal Titulo As String, ByVal Mensagem As String)
                Dim notificacao = New PopupNotifier() '\\NOTIFICAÇÃO CASO OS DADOS SEJAM EXCLUIDOS DO BD
                notificacao.TitleText = Titulo
                notificacao.ContentText = Mensagem
                notificacao.IsRightToLeft = False
                notificacao.ShowCloseButton = True
                notificacao.ContentColor = Color.Black
                ' notificacao.Image.from "C:\Users\macks\Desktop\ControleOS\Resources\NLG2.png"
                'notificacao.Image = Image.FromFile("c:\dados\img\macnet.png", True)
                notificacao.Popup()
        End Sub

        Public Sub Popup(ByVal Titulo As String, ByVal Mensagem As String)
                Dim notificacao = New PopupNotifier() '\\NOTIFICAÇÃO CASO OS DADOS SEJAM EXCLUIDOS DO BD
                notificacao.TitleText = Titulo
                notificacao.ContentText = Mensagem
                notificacao.IsRightToLeft = False
                notificacao.ShowCloseButton = True
                notificacao.ContentColor = Color.Black
                notificacao.BorderColor = Color.Blue
                'notificacao.Image = Image.FromFile("c:\dados\img\macnet.png", True)
                notificacao.Popup()
        End Sub

        Public Sub CadastroEnderecoCliente(ByRef CD As String)
                objConn.Close()
                objConn.Open()
                Dim objcmd As New OleDbCommand(CD, objConn)
                dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
                dr.Read()
                'OBEJETO.dr.item() '\\SERVE PARA SELECIONAR UM CAMPO EM ESPECIFICO
                dr.Close()
                dr = Nothing
                objConn.Close()
                SQL.Notificao("NOVA LITORAL GESSO", "ENDEREÇO CADASTRO COM SUCESSO")
        End Sub

        Public Sub Registro(ByVal Usuario As String, ByVal Alterecao As String)
                lSQL = "INSERT INTO tbLogs (Usuario,Alteracao,Data,Hora)" & "VALUES (""" & Usuario & """,""" & Alterecao & """,""" & Today.ToShortDateString.ToString &
                    """,""" & TimeOfDay.ToShortTimeString & """)"
                SQL.Comando()
        End Sub

        Public Sub FecharLogin()
                FrmLogin.Close()
        End Sub

        Public Sub NegarNotificacao()
                Notificao("NOVA LITORAL GESSO", "ESTE USUARIO NÃO TEM PERMISSÃO PARA EXECUTAR ESSA AÇÃO")
        End Sub

        Public Sub adm()

                UsuarioAdm = InputBox("Insira o nome de usuario 'Administrador'", "BLOQUEIO",)
                If IsNothing(Usuario) Then
                Else
                        Connect.Conectardb("SELECT * FROM tbUsuario WHERE Nome='" & Usuario & "'")
                        If cdr.HasRows = True Then
                                Connect.Desconectardb()
                                Connect.Conectardb("SELECT * FROM tbUsuario Where Nome='" & Usuario & "'")
                                SenhaAdm = InputBox("Insira a senha do usario " & Usuario & " para continuar", "BLOQUEIO",)
                                If cdr.Item("Senha") = SenhaAdm Then
                                        AcessoAdm = True
                                        SQL.Notificao("", "Acesso Liberado")
                                Else
                                        SQL.Notificao("", "Usuario e senha não conferem")
                                End If
                        Else
                                Connect.Desconectardb()
                                SQL.Notificao("", "Não foi possivel encontrar esse usuario")
                                Return
                        End If

                End If
        End Sub

        Public Function SaveNoti(descricao As String)
                Dim comando As String = "SELECT * FROM tbUsuario"
                objConnection.Close()
                objConnection.Open()
                Dim objcmd As New OleDbCommand(comando, objConnection)
                cdr = objcmd.ExecuteReader(CommandBehavior.Default)

                While cdr.Read
                        lSQL = "INSERT INTO tbNotificacao(Descricao,Status,Usuario)" & "VALUES(""" & descricao & """,""" & "Não Lido" & """,""" & cdr.Item(0) & """)"
                        SQL.Comando()
                End While

                cdr.Close()
                cdr = Nothing
                objConn.Close()
        End Function

        Public Sub InstrucaoDireta(Instrucao As String)
                If objConn2.State = ConnectionState.Closed Then
                        objConn2.ConnectionString = sConnectionString
                        objConn2.Open()
                End If
                Dim objcmd2 As New OleDbCommand(Instrucao, objConn2)
                On Error Resume Next
                dr2 = objcmd2.ExecuteReader()
                dr2.Read()
                dr2.Close()
                dr2 = Nothing
                objConn2.Close()
        End Sub

        Public Sub ConectarBaseInterna(Comando As String)

                My.Settings.StringDataInterno = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DataInterno.mdb" & ";Jet OLEDB:Database Password=AezakmiPdnejoh;"

                If objConexao.State = ConnectionState.Closed Then
                        objConexao.Open()
                End If
                Dim objcmd As New OleDbCommand(Comando, objConexao)
                hdr = objcmd.ExecuteReader()

        End Sub

        Public Sub DesconectarBaseInterna()

                hdr = Nothing
                objConexao.Close()
        End Sub

        Public Function LetraCaixaAlta(texto As String)
                texto = texto.ToUpper
                Return texto
        End Function

        Public Function LetraCaixaBaixa(texto As String)
                texto = texto.ToUpper
                Return texto
        End Function
        ''' <summary>
        ''' 
        ''' 
        ''' </summary>
        ''' <param name="formulario">formulario para aplicar o tema</param>
        ''' <param name="modo">Dark para tema escuro ou Light para tema claro</param>
        Public Sub DefinirTema(formulario As Form, modo As String)
                Select Case modo
                        Case = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(formulario)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                        Case = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(formulario)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.BLACK)
                        Case Else

                End Select
        End Sub

End Module