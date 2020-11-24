Imports System.Data.OleDb

Module Module3
    Public con As New OleDbConnection

    Private Sub taoketnoi()
        Dim strKetnoi As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\macks\Documents\SistemaGE.mdb"
        con.ConnectionString = strKetnoi
    End Sub

    '===============================================================================================================================

    Private Sub dongketnoi()
        con.Close()
    End Sub

    '===============================================================================================================================

    Public Function _Laydulieu(query As String) As DataTable
        taoketnoi()
        Dim datatable As New DataTable
        Dim da As New OleDbDataAdapter
        da.SelectCommand = New OleDbCommand(query, con)
        da.Fill(datatable)
        dongketnoi()
        Return datatable
    End Function

End Module