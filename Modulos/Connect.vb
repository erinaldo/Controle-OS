Imports System.Data.OleDb

Module Connect

        Public objConnection As New OleDbConnection(sConnectionString)
        Public connObj As New OleDbConnection(sConnectionString)
        Public csql As String
        Public cdr As OleDbDataReader
        Public mdr As OleDbDataReader
        Public table As OleDbDataAdapter
        Public da As OleDbDataReader

        ''' <summary>
        ''' Obter dados do banco de dados. Utiliza o cdr como datareader (possui Read())
        ''' </summary>
        ''' <param name="sql">Instrução SQL</param>
        Public Sub Conectardb(sql As String)
                Dim PARA As OleDbParameter
                If objConnection.State = ConnectionState.Closed Then
                        objConnection.ConnectionString = sConnectionString
                        objConnection.Open()
                End If
                Dim objcmd As New OleDbCommand(sql, objConnection)
                On Error Resume Next
                cdr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
                cdr.Read()
        End Sub

        Public Sub Desconectardb()
                cdr = Nothing
                objConnection.Close()
        End Sub

        '    Public Sub MultiConectardb(sql As String)
        '             If objConnection.State = ConnectionState.Closed Then
        '                      objConnection.Open()
        '               End If
        '                Dim objcmd As New OleDbCommand(sql, objConnection)
        '
        '        mdr = objcmd.ExecuteReader()
        'End Sub

        'Public Sub MultiDesconectardb()
        '        mdr.Close()
        '        mdr = Nothing
        '        objConnection.Close()
        'End Sub

        'POPULAR DATAGRID analizar para ver se funciona
        Public Sub GetData(ByVal InstrucaoSQL As String, ByVal DataGrid As DataGridView)
                Dim conexao As New OleDbConnection(sConnectionString)
                Dim comando As New OleDbCommand(InstrucaoSQL, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                DataGrid.DataSource = dsbiblio.Tables("Cliente")
                conexao.Dispose()
                conexao.Close()
                comando = Nothing
                adaptador.Dispose()
                adaptador = Nothing
                dsbiblio.Dispose()
                dsbiblio = Nothing
        End Sub



End Module