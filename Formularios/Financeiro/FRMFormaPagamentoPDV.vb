Public Class FRMFormaPagamentoPDV

        Public NumeroPedido As Double = CDbl(FrmPDV.lblNumeroPedido.Text)
        Public TotalPago As Double
        Public TotalReceber As Double
        Public Desconto As Double
        Public Restante As Double
        Public ValorPedido As Double
        Public Pedido As Integer = FrmPDV.lblNumeroPedido.Text
        Public Pago As Double
        Public TotalPedido As Double


        Private Sub FRMFormaPagamentoPDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                Dim DescConfig As Double

                Dim DescMax As Double

                Connect.Conectardb("SELECT * FROM tbConfigUni WHERE Config='MaxDescontoPDV'")
                DescConfig = cdr.Item("Selecao")
                Connect.Desconectardb()

                Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                ValorPedido = cdr.Item("ValorTotal")
                Desconto = cdr.Item("Desconto")
                Connect.Desconectardb()

                Restante = ValorPedido - Desconto
                DescMax = (ValorPedido * DescConfig) / 100

                txtDesMaxPermitido.Text = Dinheiro(DescMax)

                Dim PrecoProdutos As Double = CDbl(FrmPDV.txtSomaPDV.Text)
                Dim PrecoFrete As Double = CDbl(FrmPDV.txtPrecoFrete.Text)
                Dim Total As Double = PrecoFrete + PrecoProdutos

                With cboPlanoContas.Items
                        .Clear()
                        .Add("Receita Pedido")
                        .Add("Investimentos")
                End With

                cboPlanoContas.Text = "Receita Pedido"

                If FrmPDV.txtPrecoFrete.Text > 0 Then

                        Me.lblTotal.Text = "Valor Total:R$ " & PrecoProdutos & " em materiais + R$ " & Dinheiro(PrecoFrete) & " de frete)"
                        ' txtValorReceber.Text = "R$ " & FormatNumber(Total, 2)
                        txtValorReceber.Text = txtValorReceber.Text
                Else
                        Me.lblTotal.Text = "Valor Total: " & PrecoProdutos
                        ' txtValorReceber.Text = "R$ " & FormatNumber(PrecoProdutos, 2)
                        txtValorReceber.Text = txtValorReceber.Text
                End If
                Me.lblNomeCliente.Text = FrmPDV.txtCliente.Text
                Me.TbFinanceiroTableAdapter.PorPedidoX(Me.DataPdv.tbFinanceiro, FrmPDV.lblNumeroPedido.Text)
                lblData.Text = Today.ToShortDateString

                Connect.Conectardb("SELECT * FROM tbClientes WHERE Código=" & FrmPDV.txtCodCliente.Text)

                On Error Resume Next
                lblCPF.Text = cdr.Item("CPF")

                On Error Resume Next
                lblInscricaoEstadual.Text = cdr.Item("InscricaoEstadual")

                On Error Resume Next
                lblRazaoSocial.Text = cdr.Item("RazaoSocial")
                lblNumeroPedido.Text = "Pedido " & FrmPDV.lblNumeroPedido.Text
                cboSituacao.Items.Clear()
                cboSituacao.Items.Add("Foi Pago")
                cboSituacao.Items.Add("Não Pago")
                Connect.Conectardb("SELECT * FROM tbAnexoPDV WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                If cdr.HasRows Then
                        SQL.Notificao("", "Este Pedido Contem Anexos Armazenados")
                        btnAbrirAnexo.Visible = True
                End If

                DebitosPedido()

                txtValorReceber.Text = Dinheiro(Restante)

                cboSituacao.Text = "Foi Pago"
        End Sub

        Public Sub DebitosPedido()
                Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                ValorPedido = cdr.Item("ValorTotal")
                Desconto = cdr.Item("Desconto")
                Connect.Desconectardb()

                '\\BUSCAR TOTAL PAGO E A RECEBER*********************************************************************************************
                Connect.Conectardb("Select * FROM tbFinanceiroSoma WHERE NumeroDocumento='Pedido " & FrmPDV.lblNumeroPedido.Text & "'")
                If cdr.HasRows = True Then
                        On Error Resume Next
                        Pago = cdr.Item("Foi Pago")
                        'TotalReceber = cdr.Item("Não Pago")
                        txtTotalPago.Text = "R$ " & FormatNumber(Pago, 2)
                        txtaReceber.Text = "R$ " & FormatNumber(Restante - Pago, 2)
                        Connect.Desconectardb()
                Else
                        Connect.Desconectardb()
                End If
                txtTotal.Text = "R$ " & FormatNumber(ValorPedido, 2)
        End Sub


        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDinheiro.Click
                btnDinheiro.BackColor = Color.LightBlue
                btnBoleto.BackColor = Color.Blue
                btnCartao.BackColor = Color.Blue
                btnCartaoDebito.BackColor = Color.Blue
                lblFormaSelecionada.Text = "Dinheiro"
        End Sub

        Private Sub btnBoleto_Click(sender As Object, e As EventArgs) Handles btnBoleto.Click
                btnDinheiro.BackColor = Color.Blue
                btnBoleto.BackColor = Color.LightBlue
                btnCartao.BackColor = Color.Blue
                btnCartaoDebito.BackColor = Color.Blue
                lblFormaSelecionada.Text = "Boleto"
        End Sub

        Private Sub btnCartao_Click(sender As Object, e As EventArgs) Handles btnCartao.Click
                btnDinheiro.BackColor = Color.Blue
                btnBoleto.BackColor = Color.Blue
                btnCartaoDebito.BackColor = Color.Blue
                btnCartao.BackColor = Color.LightBlue
                lblFormaSelecionada.Text = "Crédito"
        End Sub

        Private Sub btnCartaoDebito_Click(sender As Object, e As EventArgs) Handles btnCartaoDebito.Click
                btnCartaoDebito.BackColor = Color.LightBlue
                btnDinheiro.BackColor = Color.Blue
                btnBoleto.BackColor = Color.Blue
                btnCartao.BackColor = Color.Blue
                lblFormaSelecionada.Text = "Débito"
        End Sub

        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagamento.CellContentClick

        End Sub

        Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPagamento.CellFormatting
                dgvPagamento.Columns(3).DefaultCellStyle.Format = "c"
                dgvPagamento.Columns(3).ValueType = GetType(Double)

                If e.ColumnIndex = 0 Then
                        If (e.Value.ToString = ("Foi Pago")) Then
                                ' e.CellStyle.BackColor = Color.White
                                e.CellStyle.ForeColor = Color.Green
                        End If
                End If
                If e.ColumnIndex = 0 Then
                        If (e.Value.ToString = ("Não Pago")) Then
                                ' e.CellStyle.BackColor = Color.White
                                e.CellStyle.ForeColor = Color.Red
                        End If
                End If
        End Sub

        Private Sub btnAddLancamento_Click(sender As Object, e As EventArgs) Handles btnAddLancamento.Click
                Dim StatusPedido As String
                'INSERIR FATURAMENTO NA TABELA FINANCEIRA
                If lblFormaSelecionada.Text <> "Selecione uma Forma" Then
                        InstrucaoDireta("INSERT INTO tbFinanceiro (Cliente,Tipo,NumeroDocumento,Situacao,Vencimento,DataLancamento,Descricao,Valor,PlanoContas,FormaPagamento)" &
                        "Values (""" & lblNomeCliente.Text & """,""" & "Receita" & """,""" & "Pedido " & FrmPDV.lblNumeroPedido.Text &
                        """,""" & cboSituacao.Text & """,""" & txtVencimento.Text & """,""" & Today.ToShortDateString & """,""" & "Lançamento referente ao pedido " & FrmPDV.lblNumeroPedido.Text &
                        """,""" & txtValorReceber.Text & """,""" & cboPlanoContas.Text & """,""" &
                        lblFormaSelecionada.Text & """)")

                        'ACRESCENTAR NO FUNDO DE CAIXA CASO SEJA PAGO EM DINHEIRO
                        If lblFormaSelecionada.Text = "Dinheiro" Then
                                If cboSituacao.Text = "Foi Pago" Then
                                        InstrucaoDireta("UPDATE tbCaixaPDV SET Fundo=""" & FrmSelCaixa.CaixaAtual.Fundo + txtValorReceber.Text & """ WHERE CaixaID=" & FrmSelCaixa.CaixaAtual.CaixaID)
                                        Dim caixaid As Double = FrmSelCaixa.CaixaAtual.CaixaID
                                End If
                        End If
                        SQL.Notificao("", "LANÇAMENTO EFETUADO COM SUCESSO E PEDIDO FATURADO")
                        ' Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                        'Connect.Desconectardb()
                        If StatusPedido <> "Faturado" Then
                                Dim Lin As Integer = FrmPDV.dgvProdutos.Rows.Count
                                Dim CodProduto As String
                                Dim RetirarEstoque As Double

                                Lin = Lin - 1
                                Do Until Lin < 0

                                        CodProduto = FrmPDV.dgvProdutos.Item(0, Lin).Value
                                        RetirarEstoque = FrmPDV.dgvProdutos.Item(3, Lin).Value

                                        '\\RETIRAR QUANTIDADE DO ESTOQUE
                                        Connect.Conectardb("SELECT * FROM tbProdutoPDV WHERE ProdutoID=" & CodProduto)
                                        Dim ValorAtual As Double = cdr.Item("SaldoEstoque")
                                        Connect.Desconectardb()
                                        Dim NovoValor As Double = ValorAtual - RetirarEstoque

                                        '\\VERIFICAR SE O VALOR DE ESTOQUE SERA MAIOR QUE 0 AO DEBITAR QUANTIDADE DEMANDADA PELA VENDA
                                        If NovoValor < 0 Then
                                                SQL.Notificao("", "NÃO HÁ ESTOQUE SUFICIENTE PARA REALIZAR ESSA VENDA")
                                                GoTo Prox
                                        Else
                                                InstrucaoDireta("UPDATE tbProdutoPDV SET SaldoEstoque=""" & NovoValor & """ WHERE ProdutoID=" & CodProduto)
                                        End If
Prox:
                                        Lin = Lin - 1
                                Loop

                                InstrucaoDireta("UPDATE tbPedido2 SET Status=""" & "Faturado" & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text) 'DEFINIR STATUS COMO "FATURADO"
                        End If
                        FrmPDV.TbFinanceiroTableAdapter.PorPedidoX(FrmPDV.DataPdv1.tbFinanceiro, FrmPDV.lblNumeroPedido.Text)
                        Me.TbFinanceiroTableAdapter.PorPedidoX(Me.DataPdv.tbFinanceiro, FrmPDV.lblNumeroPedido.Text)
                Else
                        MsgBox("Selecione uma Forma de Pagamento")
                End If
                DebitosPedido()
        End Sub

        Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtVencimento.Click
                mcVencimento.Visible = True
        End Sub

        Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcVencimento.DateChanged
                txtVencimento.Text = mcVencimento.SelectionStart.ToShortDateString
        End Sub

        Private Sub mcVencimento_MouseLeave(sender As Object, e As EventArgs) Handles mcVencimento.MouseLeave
                mcVencimento.Visible = False
        End Sub

        Private Sub btnAddAnexo_Click(sender As Object, e As EventArgs) Handles btnAddAnexo.Click
                If txtDescricaoAnexo.Text <> "" Then
                        ofdAnexo.ShowDialog()

                        Dim caminho As String = ofdAnexo.FileName
                        Dim Destino As String = "C:\Users\Mackson\Documents\AxPagamentoPDV\AxPagamentoPDV\" & txtDescricaoAnexo.Text & ".png"

                        If caminho <> "" Then
                                My.Computer.FileSystem.CopyFile(caminho, Destino)
                                InstrucaoDireta("INSERT INTO tbAnexoPDV (Identificacao,Caminho,DataCadastro,Descricao)" &
                    "VALUES (""" & SQL.AnexoID & """,""" & Destino & """,""" & Today.ToShortDateString & """,""" & txtDescricaoAnexo.Text & """)")
                                SQL.Notificao("", "Anexo arquivado com sucesso no caminho (" & Destino & ")")
                                txtDescricaoAnexo.Text = ""
                        End If
                Else
                        SQL.Notificao("", "Digite a descrição do Anexo")
                End If
        End Sub

        Private Sub btnAbrirAnexo_Click(sender As Object, e As EventArgs) Handles btnAbrirAnexo.Click
                FrmVisualizadorAnexos.ShowDialog()
        End Sub

        Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtValorReceber.Click

        End Sub

        Private Sub dgvPagamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagamento.CellClick
                btnAddAnexo.Text = "Anexar Doc. para o lançamento " & dgvPagamento.CurrentRow.Cells(5).Value & ")"

        End Sub

        Private Sub dgvPagamento_DoubleClick(sender As Object, e As EventArgs) Handles dgvPagamento.DoubleClick
                btnAddAnexo.PerformClick()
        End Sub

        Private Sub btnRealizarDesc_Click(sender As Object, e As EventArgs) Handles btnRealizarDesc.Click
                Dim ValorDesconto As Double = CDbl(txtDesconto.Text)
                Dim ValorPedido As Double
                Dim CustoTotal As Double
                Dim DescMax As Double
                Dim DescConfig As Double

                Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                ValorPedido = cdr.Item("ValorTotal")

                If cdr.Item("Desconto") > 0 And cdr.Item("Status") = "Faturado" Then
                        MsgBox("O pedido já possui um desconto cadastrado")
                        GoTo Final
                Else
                        Connect.Desconectardb()

                        Connect.Conectardb("SELECT * FROM tbSomaCustoPDV WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                        CustoTotal = cdr.Item("Total de ValorCustoTotal")
                        Connect.Desconectardb()

                        Connect.Conectardb("SELECT * FROM tbConfigUni WHERE Config='MaxDescontoPDV'")
                        DescConfig = cdr.Item("Selecao")
                        Connect.Desconectardb()

                        DescMax = (ValorPedido * DescConfig) / 100

                        If ValorDesconto > DescMax Then
                                MsgBox("o valor ultrapassa o maximo permitido")
                        Else
                                Dim ValorRestante As Double = ValorPedido - ValorDesconto
                                lSQL = "UPDATE tbPedido2 SET ValorTotal=""" & CDbl(ValorRestante) & """,Desconto= """ & CDbl(ValorDesconto) & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text
                                SQL.Comando()

                                MsgBox("Desconto realizado")
                        End If

                End If
Final:
                FrmPDV.TbProdutoVendaPDVTableAdapter.FillByPedidoID(FrmPDV.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(FrmPDV.lblNumeroPedido.Text, Integer)))
                TbFinanceiroTableAdapter.PorPedidoX(FrmPDV.DataPdv1.tbFinanceiro, FrmCarregarPedido.txtPedidoID.Text)
                TbFinanceiroTableAdapter.PorPedidoX(FrmPDV.DataPdv1.tbFinanceiro, FrmCarregarPedido.txtPedidoID.Text)
        End Sub

End Class