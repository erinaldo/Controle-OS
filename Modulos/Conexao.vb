Imports System.Data.OleDb

Module Conexao

        Public objConn1, objConn2, objConn3 As New OleDbConnection(sConnectionString)

        Public bdr1, bdr2, bdr3 As OleDbDataReader

        ''' <summary>
        ''' Conexão com o banco de dados (Não possui Read()). Usa o datareader bdr1
        ''' </summary>
        ''' <param name="sql">Instrução em SQL</param>
        Public Sub conexao1(sql As String)
                If objConn1.State = ConnectionState.Closed Then
                        objConn1.Open()
                End If
                Dim objcmd As New OleDbCommand(sql, objConn1)
                bdr1 = objcmd.ExecuteReader()
        End Sub

        Public Sub Desconexao1()
                '        bdr1.Close()
                bdr1 = Nothing
        End Sub

        ''' <summary>
        ''' Conexão com o banco de dados (Não possui Read()). Usa o datareader bdr2
        ''' </summary>
        ''' <param name="sql">Instrução em SQL</param>
        Public Sub conexao2(sql As String)
                'objConnection.Close()
                If objConn2.State = ConnectionState.Closed Then
                        objConn2.Open()
                End If
                Dim objcmd As New OleDbCommand(sql, objConn2)
                bdr2 = objcmd.ExecuteReader()
        End Sub

        Public Sub Desconexao2()
                'bdr2.Close()
                bdr2 = Nothing
                'objConn2.Close()
        End Sub

        ''' <summary>
        ''' Conexão com o banco de dados (Não possui Read()). Usa o datareader bdr3
        ''' </summary>
        ''' <param name="sql">Instrução em SQL</param>
        Public Sub conexao3(sql As String)
                'objConnection.Close()
                If objConn3.State = ConnectionState.Closed Then
                        objConn3.Open()
                End If
                Dim objcmd As New OleDbCommand(sql, objConn3)
                bdr3 = objcmd.ExecuteReader()
        End Sub

        Public Sub Desconexao3()
                'bdr3.Close()
                bdr3 = Nothing
                'objConn3.Close()
        End Sub
End Module