Public Class FrmVisita

    Private Sub FrmVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDataAgendamento.Text = Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString
        txtRespAgendamento.Text = SQL.Usuario
    End Sub

    Private Sub CadVisita()
        lSQL = "INSERT INTO tbVisitas(Rua,Numero,Bairro,Cidade,Descricao,DataAgendamento,RespAgendamento,NomeCliente,ContatoCliente,Status,DataVisitaIda)" & "VALUES(""" & txtRua.Text & """,""" & txtNumero.Text & """,""" & txtBairro.Text & """,""" & txtCidade.Text &
                        """,""" & txtDescricao.Text & """,""" & txtDataAgendamento.Text & """,""" & txtRespAgendamento.Text & """,""" & txtNomeCliente.Text &
                        """,""" & txtContatoCliente.Text & """,""" & txtStatus.Text & """,""" & txtDataVisitaIda.Text & """)"
        Comando()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        CadVisita()
    End Sub

End Class