Public Class FrmDetLan

    Private Sub TbFinanceiroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbFinanceiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetX)

        Me.TbAnexoPDVTableAdapter.FillByPedidoID(Me.DataPdv.tbAnexoPDV, New System.Nullable(Of Integer)(CType(FrmNovoLancamento.txtIdentificacao.Text, Integer)))
    End Sub

    Private Sub FrmDetLan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TbAnexoPDVTableAdapter.Fill(Me.DataPdv.tbAnexoPDV)
        If FrmNovoLancamento.txtIdentificacao.Text <> "" Then
            Me.TbFinanceiroTableAdapter.FillByIdentificacao(Me.DataSetX.tbFinanceiro, CType(FrmNovoLancamento.txtIdentificacao.Text, Integer))
            Me.TbAnexoPDVTableAdapter.FillByPedidoID(Me.DataPdv.tbAnexoPDV, New System.Nullable(Of Integer)(CType(CInt(FrmNovoLancamento.txtIdentificacao.Text), Integer)))
        End If

        CorFontBoxSituacao(SituacaoTextBox)

    End Sub




    Private Sub btnDefinirPago_Click(sender As Object, e As EventArgs) Handles btnDefinirPago.Click
        FrmMenu.MovFinan()
        Ident = txtIdentificacao.Text
        Valor = ValorPagoTextBox.Text

        If SituacaoTextBox.Text = "Não Pago" Then
            AtualizarSituacaoPagamento("Foi Pago")
            AtualizarFonteDados()
            FrmNovoLancamento.LimparFiltros()
            FrmNovoLancamento.AtualizarRegistro()
            FrmNovoLancamento.SomaPago()


            conexao1("SELECT Identificacao FROM tbFinanceiro ORDER BY Identificacao Desc")

            bdr1.Read()

            Dim UltimaIdent As Double = bdr1.Item("Identificacao")
            Dim TipoFinan As String

            Select Case TipoTextBox.Text
                Case "Receita"
                    TipoFinan = "Entrada"

                Case "Despesa"
                    TipoFinan = "Saída"

                Case Else
                    MsgBox("Problema !!! , tipo lancamento")

            End Select


            MovimentaoFinanceira(DescricaoTextBox.Text, Valor, TipoFinan, UltimaIdent)
        Else
            Notificao("", "Esse Lançamento já esta Pago")
        End If

        CorFontBoxSituacao(SituacaoTextBox)
    End Sub




    Public Sub AtualizarSituacaoPagamento(Situacao As String)
        lSQL = "UPDATE tbFinanceiro SET Situacao=""" & Situacao & """,ValorPago=""" & ValorPagoTextBox.Text & """ WHERE Identificacao=" & txtIdentificacao.Text
        SQL.Comando()
        'SituacaoTextBox.ForeColor = Color.Green
        SQL.Notificao("", "Pagamento Realizao com Sucesso")
    End Sub

    Public Sub AtualizarFonteDados()
        Me.TbFinanceiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetX)
        Me.TbAnexoPDVTableAdapter.FillByPedidoID(Me.DataPdv.tbAnexoPDV, New System.Nullable(Of Integer)(CType(FrmNovoLancamento.txtIdentificacao.Text, Integer)))
        Me.TbFinanceiroTableAdapter.FillByIdentificacao(Me.DataSetX.tbFinanceiro, CType(FrmNovoLancamento.txtIdentificacao.Text, Integer))
        Me.Validate()
    End Sub

    Private Sub SituacaoTextBox_TextChanged(sender As Object, e As EventArgs) Handles SituacaoTextBox.TextChanged

    End Sub

    Public Function CorFontBoxSituacao(TXT As TextBox)
        TXT.ReadOnly = False
        Select Case TXT.Text
            Case "Foi Pago"
                TXT.ForeColor = Color.White
                TXT.BackColor = Color.DarkGreen
            Case "Não Pago"
                TXT.ForeColor = Color.White
                TXT.BackColor = Color.Red
        End Select
        TXT.ReadOnly = True
    End Function

    Private Sub btnDefinirNPago_Click(sender As Object, e As EventArgs) Handles btnDefinirNPago.Click

        FrmMenu.MovFinan()
        Ident = txtIdentificacao.Text
        Valor = ValorPagoTextBox.Text

        If SituacaoTextBox.Text = "Foi Pago" Then
            AtualizarSituacaoPagamento("Não Pago")
            AtualizarFonteDados()
            FrmNovoLancamento.LimparFiltros()
            FrmNovoLancamento.AtualizarRegistro()
            FrmNovoLancamento.SomaPago()

            If TipoTextBox.Text = "Receita" Then
                MovimentaoFinanceira(DescricaoTextBox.Text, Valor, "Saída", CDbl(txtIdentificacao.Text))
            Else
                MovimentaoFinanceira(DescricaoTextBox.Text, Valor, "Entrada", CDbl(txtIdentificacao.Text))
            End If

        End If

        CorFontBoxSituacao(SituacaoTextBox)

    End Sub

    Private Sub CodigoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoTextBox.TextChanged

    End Sub
End Class