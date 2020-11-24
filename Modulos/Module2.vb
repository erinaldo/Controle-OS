Imports System.Data.OleDb

Module Valores

    Sub Valores()
        Dim PriSQL As String = "SELECT * FROM FinaceiroOS WHERE OSID=" & FrmCadastroOS.txtOSID.Text
        objConn.Close()
        objConn.Open()
        Dim objcmd As New OleDbCommand(PriSQL, objConn)
        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()

        dr.Close()
        dr = Nothing
        objConn.Close()
    End Sub

    Sub Inicializacao()
        FrmMdiHome.Show()
        FrmLogin.Close()
        SQL.Notificao("NOVA LITORAL GESSO", "BEM VINDO " & FrmLogin.txtUsuario.Text & " !")
    End Sub

End Module