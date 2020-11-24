Imports System.Data.OleDb

Module Permissao

    Dim nSQL As String '\\DECLARAÇÃO DE STRING DE COMANDO SQL
    Dim dr As OleDbDataReader '\\CRIAR UM NOVO DATAREADER
    Public Nivel As String
    Public Opcao As String

    Private Sub Conectar()
        Dim LoginConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\macks\Documents\Login.mdb;Jet OLEDB:Database Password=granel;" '\\STRING DE CONEXÃO
        Dim Conexaodb As New OleDbConnection(LoginConnectionString) '\\LIGAÇÃO COM O BD
        Dim objcmd As New OleDbCommand(nSQL, Conexaodb) '\\EXECUTAR COMANDO SQL
        'Dim dr As OleDbDataReader '\\CRIAR UM NOVO DATAREADER
        Conexaodb.Open() '\\ABRIR CONEXÃO COM O BANCO DE DADOS
        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow) '\\ COPIAR DDADOS PARA O DATAREADER
        dr.Read() '\\CARREAGAR DADOS COPIADOS DO BD

    End Sub

    Public Sub Acesso(Opcao As String) '\\VERIFICAR ACESSO DO USUARIO LOGADO
        nSQL = "SELECT * FROM tbAcesso WHERE UsuarioID=" & SQL.UsuarioID & " And " & "Opcao=" & Opcao   '\\COMANDO SQL
        Conectar()
        If dr.HasRows = True Then
            SQL.Permissao = dr.Item("Permissao")
        Else
            SQL.Notificao("erro", "não foram encontrados informações sobre cadastro")
        End If
        dr.Close() '\\FECHAR CONEXÃO COM O BD
        dr = Nothing '\\ LIMPA O DATAREADER
    End Sub

    Public Sub ConsultarNivel(ByRef Senha As String)
        nSQL = "SELECT * FROM tbLogin Where UsuarioID=" & SQL.UsuarioID '\\COMANDO SQL
        Conectar()
        Nivel = dr.Item("Nivel")
        dr.Close() '\\FECHAR CONEXÃO COM O BD
        dr = Nothing '\\ LIMPA O DATAREADER
    End Sub

    Public Function FormAcesso(Formulario As Form, FormularioBD As String, TipoOpen As String) As Boolean
        Connect.Conectardb("SELECT * FROM tbUsuario WHERE Nome='" & Usuario.Nome & "'")
        If cdr.HasRows = True Then
            If cdr.Item(FormularioBD) = True Then
                Select Case TipoOpen
                    Case = "mdi"
                        Formulario.MdiParent = FrmMdiHome
                        Formulario.Show()
                        Return True
                    Case = "show"
                        Formulario.Show()
                        Return True
                    Case = "showdialog"
                        Formulario.ShowDialog()
                    Case = "nothing"
                        Return True
                    Case Else
                        MsgBox("O parametro TipoOpen deve ser preenchido com (mdi), (show) ou (showdialog)")
                        Return False
                End Select
            Else
                SQL.Notificao("", "Sem permissao de acesso a pagina")
            End If
        Else
            MsgBox("Não foi possivel encontrar registros desse usuario no banco de dados")
        End If
        Connect.Desconectardb()
    End Function

End Module