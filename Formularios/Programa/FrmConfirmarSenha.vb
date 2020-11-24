Public Class FrmConfirmarSenha

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Me.Close()
    End Sub

    Private Sub txtSenhaAdministrador_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtSenhaAdministrador.MaskInputRejected

    End Sub

    Private Sub txtSenhaAdministrador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenhaAdministrador.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirmar.PerformClick()
        End If
    End Sub

End Class