Public Class FrmAdicionarPagamento

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        lSQL = "INSERT INTO tbPagamentosRealizados (PagamentoID,DataPagamento,Valor,Destinatário,Observacao)" & "VALUES (""" & txtPagamentoID.Text & """,""" & txtDataPagamento.Text &
            """,""" & txtValor.Text & """,""" & txtDestinatario.Text & """,""" & txtObs.Text & """)"
        SQL.Comando()

        SQL.Notificao("NOVA LITORAL GESSO", "PAGAMENTO CADASTRADO COM SUCESSO")
        Me.Close()
    End Sub

End Class