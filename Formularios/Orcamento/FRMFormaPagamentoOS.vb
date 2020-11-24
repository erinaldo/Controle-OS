Public Class FRMFormaPagamentoOS

    Public OSID As Integer = FrmCadastroOS.txtOSID.Text
    Public ValorReceber

    Private Sub FRMFormaPagamentoOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TbFinanceiroTableAdapter1.Fill(Me.DataSetX.tbFinanceiro)
        Me.TbPlanoContaTableAdapter.Fill(Me.SistemaGEDataSet.tbPlanoConta)
        Me.TbPlanoDespesasTableAdapter.Fill(Me.SistemaGEDataSet.tbPlanoDespesas)
        ' Me.OpcoesTableAdapter.Fill(Me.SistemaGEDataSet.Opcoes)
        lblNumeroOS.Text = "OS Número: " & FrmCadastroOS.txtOSID.Text
        lblNomeCliente.Text = FrmCadastroOS.cboCliente.Text
        lblCPF.Text = FrmCadastroOS.txtCPF.Text
        lblData.Text = Today.ToShortDateString
        txtVencimento.Text = Today.ToShortDateString

        If FrmCadastroOS.txtOSID.Text <> "" Then

            Me.TbFinanceiroTableAdapter1.PorOSx(Me.DataSetX.tbFinanceiro, "OS " & FrmCadastroOS.txtOSID.Text)

        End If

        With cboSituacao
            .Items.Clear()
            .Items.Add("Foi Pago")
            .Items.Add("Não Pago")
        End With

        If OSID > 0 Then '\\VERIFICAR SE O NUMERO DA OS É VALIDO

            Connect.Conectardb("SELECT OSID, SUM(TotalServico) AS Total FROM tbProdutoVenda GROUP BY OSID HAVING (OSID =" & OSID & ")")

            If cdr.HasRows = True Then '\\VERIFICAR SE EXISTE DADOS RELACIONADO A OS NO BANCO DE DADOS

                ValorReceber = cdr.Item("Total")
                lblTotal.Text = "Total " & Dinheiro(ValorReceber)
                txtValorReceber.Text = ValorReceber
                Connect.Desconectardb()
            Else

                SQL.Notificao("", "NÃO EXISTE DADOS RELACIONADO A ESSA OS")
            End If
        Else

            SQL.Notificao("", "O NÚMERO DA OS NÃO É VALIDO")

        End If

        txtaReceber.Text = Dinheiro(ValorReceber - ValorRestante())
        txtTotalPago.Text = Dinheiro(ValorRestante)
        txtValorReceber.Text = Dinheiro(ValorReceber - ValorRestante())

    End Sub

    Public Function ValorRestante()
        Dim Consulta As String = "'OS " & OSID & "'"
        Connect.Conectardb("SELECT NumeroDocumento, SUM(Valor) AS Restante, Situacao FROM tbFinanceiro GROUP BY NumeroDocumento, Situacao HAVING (Situacao = 'Foi Pago') AND (NumeroDocumento = " & Consulta & ")")
        If cdr.HasRows = True Then
            Return cdr.Item("Restante")
        Else
            Return 0
        End If
        Connect.Desconectardb()
    End Function

    Public Function ValorPago()
        Dim Consulta As String = "'OS " & OSID & "'"
        Connect.Conectardb("SELECT NumeroDocumento, SUM(Valor) AS Restante, Situacao FROM tbFinanceiro GROUP BY NumeroDocumento, Situacao HAVING (Situacao = 'Não Pago') AND (NumeroDocumento = " & Consulta & ")")
        If cdr.HasRows = True Then
            Return cdr.Item("Restante")
        Else
            Return 0
        End If
        Connect.Desconectardb()
    End Function

    Private Sub btnDinheiro_Click(sender As Object, e As EventArgs) Handles btnDinheiro.Click
        lblFormaSelecionada.Text = "Dinheiro"
    End Sub

    Private Sub btnBoleto_Click(sender As Object, e As EventArgs) Handles btnBoleto.Click
        lblFormaSelecionada.Text = "Boleto"
    End Sub

    Private Sub btnCartao_Click(sender As Object, e As EventArgs) Handles btnCartao.Click
        lblFormaSelecionada.Text = "Cartão"
    End Sub

    Private Sub btnAddLancamento_Click(sender As Object, e As EventArgs) Handles btnAddLancamento.Click

        lSQL = "INSERT INTO tbFinanceiro (Cliente,Tipo,NumeroDocumento,Situacao,Vencimento,DataLancamento,Descricao,Valor,PlanoContas,FormaPagamento)" &
           "Values (""" & lblNomeCliente.Text & """,""" & "Receita" & """,""" & "OS " & FrmCadastroOS.txtOSID.Text &
           """,""" & cboSituacao.Text & """,""" & txtVencimento.Text & """,""" & Today.ToShortDateString & """,""" & "Lançamento referente a OS " & FrmCadastroOS.txtOSID.Text &
           """,""" & txtValorReceber.Text & """,""" & cboPlanoContas.Text & """,""" &
           lblFormaSelecionada.Text & """)"

        SQL.Comando()

        Me.TbFinanceiroTableAdapter1.PorOSx(Me.DataSetX.tbFinanceiro, "OS " & FrmCadastroOS.txtOSID.Text)
        'txtaReceber.Text = "R$ " & FormatNumber(ValorReceber - ValorRestante(), 2)

        txtaReceber.Text = Dinheiro(ValorReceber - ValorRestante())

        txtTotalPago.Text = Dinheiro(ValorRestante)

        txtValorReceber.Text = ValorReceber - ValorRestante()

    End Sub

End Class