Module modRelatorio

    Public Sub RelatorioPediddoVin()

        Dim colaborador As String
        Dim NumeroOS As New ListViewItem(colaborador, 0)

        Connect.Conectardb("SELECT OSID FROM tbOS GROUP BY OSID")

    End Sub

End Module