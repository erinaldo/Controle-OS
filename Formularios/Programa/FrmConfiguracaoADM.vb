Public Class FrmConfiguracaoADM

    Private Sub FrmConfiguracaoADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect.Conectardb("SELECT * FROM tbUsuario WHERE Nome='" & Usuario.Nome & "'")
        chkFrmCadastroOS.Checked = cdr.Item("FrmCadastroOS")
        Connect.Desconectardb()
    End Sub

    Private Sub AlterarConfigCHK(Controle As CheckBox, NomeConfig As String)
        Select Case Controle.Checked
            Case True
                InstrucaoDireta("UPDATE tbUsuario SET " & NomeConfig & " = True WHERE (Nome = '" & Usuario.Nome & "')")
            Case False
                InstrucaoDireta("UPDATE tbUsuario SET " & NomeConfig & " = False WHERE (Nome = '" & Usuario.Nome & "')")
        End Select
    End Sub

    Private Sub chkFrmCadastroOS_CheckedChanged(sender As Object, e As EventArgs) Handles chkFrmCadastroOS.CheckedChanged

    End Sub

    Private Sub chkFrmCadastroOS_Click(sender As Object, e As EventArgs) Handles chkFrmCadastroOS.Click
        AlterarConfigCHK(chkFrmCadastroOS, "chkFrmCadastroOS")
    End Sub

End Class