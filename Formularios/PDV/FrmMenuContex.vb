Public Class FrmMenuContex

    Private Sub FrmMenuContex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        If FrmCarregarPedido.txtCliente.Text <> "" Then
            FrmCarregarPedido.CarregarPedido()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmMenuContex_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

End Class