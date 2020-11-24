Imports System.Data.OleDb

Public Class ConDB
        Public da As OleDbDataReader

        ''' <summary>
        ''' Obter dados do banco de dados (Possui Read())
        ''' </summary>
        ''' <param name="InstrucaoSQL"> Instrução em sql</param>
        ''' <returns>Retorna um OledbDataReader</returns>
        Public Function GetData(ByRef InstrucaoSQL As String)
                Dim objconnection As New OleDbConnection(sConnectionString)
                Dim Resp As New ListView
                objconnection.Open()
                Dim objcmd As New OleDbCommand(InstrucaoSQL, objconnection)
                da = objcmd.ExecuteReader()
                da.Read()
                Return da
                da.Close()
                If objconnection.State = ConnectionState.Open Then
                        objconnection.Close()
                End If
        End Function
End Class