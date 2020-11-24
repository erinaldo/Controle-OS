Imports System.Data.OleDb

Public Class FrmCarregarPedido
        Private Sub TbPedido2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbPedido2BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataPdv)
        End Sub
        Private Sub FrmCarregarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.TbEndTableAdapter.Fill(Me.DataPdv.tbEnd)
                Me.TbPedido2TableAdapter.Fill(Me.DataPdv.tbPedido2) '
                With cboStatusFaturamento.Items
                        .Clear()
                        .Add("Todos")
                        .Add("Faturado")
                        .Add("Não Faturado")
                End With
                cboStatusFaturamento.Text = "Todos"
                With cboDataFiltro.Items
                        .Add("Data de Abertura")
                        .Add("Data de Faturamento")
                End With
                cboDataFiltro.Text = ("Data de Abertura")

                '\\DEFINIR O PRIMEIRO E ULTIMO DIA DO MES ATUAL
                Dim Ano As Integer = Today.Year '\\ANO ATUAL
                Dim MesAtual As Integer = Today.Month '\\MÊS ATUAL
                Dim DiaAtual As Integer = DateTime.DaysInMonth(Ano, MesAtual) '\\ULTIMO DIA DO MÊS
                txtDataInicial.Text = CDate("01/" & MesAtual & "/" & Ano)
                txtDataFinal.Text = CDate(DiaAtual & "/" & MesAtual & "/" & Ano).ToShortDateString
                btnAplicarFiltro.PerformClick()
        End Sub
        Private Sub TbPedido2DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
                On Error Resume Next
                txtClienteID.Text = dgvPedidos.CurrentRow.Cells(2).Value
                txtCliente.Text = dgvPedidos.CurrentRow.Cells(1).Value
                txtPedidoID.Text = dgvPedidos.CurrentRow.Cells(0).Value
                FrmMenuContex.Close()
        End Sub
        Private Sub btnCarregarPedido_Click(sender As Object, e As EventArgs) Handles btnCarregarPedido.Click
                CarregarPedido()
        End Sub
        Public ClienteIDCarregar As Double
        Public Sub CarregarPedido()
                If txtPedidoID.Text <> "" Then
                        If dgvPedidos.CurrentRow.Cells(7).Value = "Não Faturado" Then
                                SQL.PodeEditarPedido = True
                                '\\BLOQUEAR CAMPOS
                                Me.BloqueioTxts(True)
                                FrmPDV.btnAdicionarProduto.Visible = True
                        Else
                                SQL.PodeEditarPedido = False
                                '\\BLOQUEAR CAMPOS
                                Me.BloqueioTxts(False)
                                FrmPDV.btnAdicionarProduto.Visible = False
                        End If
                        If txtPedidoID.Text <> "" Then
                                FrmPDV.TbProdutoVendaPDVTableAdapter.FillByPedidoID(FrmPDV.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(txtPedidoID.Text, Integer)))
                                '\\Conexão com o Banco de dados
                                Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & txtPedidoID.Text)
                                Dim ClienteID As Double = cdr.Item("ClienteID")
                                Dim ClienteIDCarregar As Double = cdr.Item("ClienteID")
                                Dim EndClienteID As Double = cdr.Item("EndID")
                                Dim EndEntregaID As Double = cdr.Item("EndEntID")
                                On Error Resume Next
                                Dim EntregaQST As String = cdr.Item("EntregaB")
                                On Error Resume Next
                                Dim EntregaDIF As String = cdr.Item("EntregaDifB")
                                Dim PrecoFrete As Double = cdr.Item("Frete")
                                Dim PrecoTotal As Double = cdr.Item("ValorTotal")
                                '\\CARREGAR PDV DE ACORDO COM O RETORNO DO BANCO DE DADOS=====================================
                                '\\PREENCHENDO CHKBOX SOBRE ENDEREÇO E PREÇO DO FRETE
                                If EntregaQST = "Sim" Then
                                        FrmPDV.chkEntrega.Checked = True
                                        FrmPDV.chkEntDif.Visible = True
                                        FrmPDV.txtPrecoFrete.Visible = True
                                Else
                                        FrmPDV.chkEntrega.Checked = False
                                End If
                                If EntregaDIF = "Sim" Then
                                        FrmPDV.chkEntDif.Checked = True
                                Else
                                        FrmPDV.chkEntDif.Checked = False
                                End If
                                FrmPDV.txtPrecoFrete.Text = "R$ " & FormatNumber(PrecoFrete, 2) '\\PRECO DO FRETE

                                '\\VALOR TOTAL DA COMPRA (FRETE NÃO INCLUIDO)
                                FrmPDV.txtSomaPDV.Text = "R$ " & FormatNumber(PrecoTotal, 2) '\\PRECO DO FRETE

                                '\\NUMERO DO PEDIDO
                                FrmPDV.lblNumeroPedido.Text = txtPedidoID.Text

                                '\\DESCONECTAR CONSULTA PRIMARIA
                                Connect.Desconectardb()

                                '\\CONSULTAR ENDEREÇO DO CLIENTE DE ACORDO COM O RETORNO DA 'ID' DO BANCO DE DADOS
                                Connect.Conectardb("SELECT * FROM tbEnd WHERE ID=" & EndClienteID)

                                '\\VARIAVEIS DE RETORNO DA CONSULTA DE ENDEREÇO DO CLIENTE
                                Dim EnderecoID As Double = EndClienteID
                                Dim Logradouro As String = cdr.Item("Logradouro")
                                Dim EndNumero As Double = cdr.Item("EndNumero")
                                Dim Bairro As String = cdr.Item("Bairro")
                                Dim Cidade As String = cdr.Item("Cidade")
                                Dim UF As String = cdr.Item("UF")
                                Dim Complemento As String = cdr.Item("Complemento")
                                Dim Tipo As String = cdr.Item("Tipo")
                                Connect.Desconectardb()
                                conexao2("SELECT * FROM tbClientes WHERE Código=" & ClienteID)
                                FrmPDV.txtCodCliente.Text = ClienteID
                                bdr2.Read()

                                '\\VARIAVEIS DE RETORNO DA CONSULTA DE ENDEREÇO DO CLIENTE
                                Dim NomeCliente As String = bdr2.Item("Nome")
                                Dim CPF As String = bdr2.Item("CPF")
                                Dim InscEstadual As Double = bdr2.Item("InscricaoEstadual")
                                With FrmPDV
                                        '\\ENDEREÇO =====
                                        .txtEndID.Text = EnderecoID
                                        .txtLogradouro.Text = Logradouro
                                        .txtEndNumero.Text = EndNumero
                                        .txtBairro.Text = Bairro
                                        .txtCidade.Text = Cidade
                                        .txtUF.Text = UF
                                        .txtComplemento.Text = Complemento
                                        .txtTipo.Text = Tipo
                                        '\\DADOS PESSOAIS DO CLIENTE========
                                        .txtCliente.Text = NomeCliente
                                        .txtCPFCliente.Text = CPF
                                        .txtInscEstadual.Text = InscEstadual
                                End With
                                Connect.Desconectardb()

                                '\\DEFINIR CHKBOX DO FRMPDV COMO READONLY VIA FUNÇÃO
                                SQL.LockChkPdv = True
                                With FrmPDV
                                        .chkRetirar.Visible = False
                                        .lblRetirar.Visible = False
                                End With
                                FrmPDV.TbProdutoVendaPDVTableAdapter.FillByPedidoID(FrmPDV.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(txtPedidoID.Text, Integer)))
                                FrmPDV.TbFinanceiroTableAdapter.PorPedidoX(FrmPDV.DataPdv1.tbFinanceiro, txtPedidoID.Text)
                                FrmPDV.TbFinanceiroTableAdapter.PorPedidoX(FrmPDV.DataPdv1.tbFinanceiro, txtPedidoID.Text)
                                FrmPDV.dgvProdutos.Height = 22 + (FrmPDV.dgvProdutos.Rows.Count * 24)
                                FrmPDV.dgvProdutosSemCusto.Height = 22 + (FrmPDV.dgvProdutosSemCusto.Rows.Count * 24)
                                Me.Close()
                        Else
                                SQL.Notificao("", "Nenhum pedido foi selecionado")
                        End If
                        If PedidoVinculado = False Then
                                Connect.Conectardb("SELECT * FROM tbProdutoPDVSoma WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                                FrmPDV.txtSomaPDV.Text = "R$ " & FormatNumber(cdr.Item("Total de Soma"), 2)
                                lSQL = "UPDATE tbPedido2 SET ValorTotal=""" & cdr.Item("Total de Soma") & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text
                                SQL.Comando()
                                Connect.Desconectardb()
                        Else
                                Connect.Conectardb("SELECT * FROM tbProdutoVendaPDVSomavinc WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                                FrmPDV.txtSomaPDV.Text = "R$ " & FormatNumber(cdr.Item("Total de ValorVenda"), 2)
                                lSQL = "UPDATE tbPedido2vinc SET ValorTotal=""" & cdr.Item("Total de ValorVenda") & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text
                                SQL.Comando()
                                Connect.Desconectardb()
                        End If
                        FrmPDV.VerifEstoque()
                        FrmPDV.tmAtualizardgv.Interval = 3000
                        FrmPDV.tmAtualizardgv.Start()
                        FrmPDV.Panel1.Visible = True
                        FrmPDV.Panel4.Visible = False
                        FrmPDV.SomarProdutos()
                        FrmPDV.QuantidadeItens()
                        FrmPDV.btnImprimir.Visible = True
                Else
                        SQL.Notificao("", "Selecione um Pedido")
                End If
        End Sub

        Private Sub dgvPedidos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPedidos.MouseDown
                If e.Button = MouseButtons.Right Then
                        FrmMenuContex.Show()
                End If
        End Sub

        Private Sub FrmCarregarPedido_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
                FrmMenuContex.Close()
        End Sub
        Public Function BloqueioTxts(ByVal OpcaoBloqueio As Boolean)
                With FrmPDV
                        '\\ENDEREÇO =====
                        .txtLogradouro.ReadOnly = OpcaoBloqueio
                        .txtEndNumero.ReadOnly = OpcaoBloqueio
                        .txtBairro.ReadOnly = OpcaoBloqueio
                        .txtCidade.ReadOnly = OpcaoBloqueio
                        .txtUF.ReadOnly = OpcaoBloqueio
                        .txtComplemento.ReadOnly = OpcaoBloqueio
                        .txtTipo.ReadOnly = OpcaoBloqueio
                        '\\DADOS PESSOAIS DO CLIENTE========
                        .txtCliente.ReadOnly = OpcaoBloqueio
                        .txtCPFCliente.ReadOnly = OpcaoBloqueio
                        .txtInscEstadual.ReadOnly = OpcaoBloqueio
                        .txtPrecoFrete.ReadOnly = OpcaoBloqueio
                        '.txtSomaPDV.ReadOnly = OpcaoBloqueio
                        .txtEndID.ReadOnly = OpcaoBloqueio
                        .txtProdutoID.ReadOnly = OpcaoBloqueio
                        .txtCategoriaProduto.ReadOnly = OpcaoBloqueio
                        .txtProduto.ReadOnly = OpcaoBloqueio
                        .txtQuantidade.ReadOnly = OpcaoBloqueio
                        .txtCustoTotal.ReadOnly = OpcaoBloqueio
                        '  .txtSoma.ReadOnly = OpcaoBloqueio
                        .btnAdicionarProduto.Visible = OpcaoBloqueio

                        If FrmPDV.lblNumeroPedido.Text = "" Then
                                FrmPDV.btnImprimir.Visible = False
                        Else
                                FrmPDV.btnImprimir.Visible = True
                        End If
                End With
        End Function
        Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
                Dim I As Date = txtDataInicial.Text
                Dim F As Date = txtDataFinal.Text
                Dim ConsultaFiltro As String = "SELECT PedidoID as Pedido, DataAbertura as Abertura, DataAprovFaturamento as Faturamento, ValorTotal as Valor, Desconto, Frete, Vendedor, Status FROM tbPedido2"
                Select Case cboStatusFaturamento.Text
                        Case = "Todos"
                        Case = "Faturado"
                                ConsultaFiltro = ConsultaFiltro & " WHERE Status='Faturado'"
                        Case = "Não Faturado"
                                ConsultaFiltro = ConsultaFiltro & " WHERE Status='Não Faturado'"
                        Case Else
                                MsgBox("erro no filtro de faturado e não faturado (a aplicação sera reiniciada)")
                                Application.Restart()
                End Select
                If cboStatusFaturamento.Text = "Todos" Then
                        Select Case cboDataFiltro.Text
                                Case = "Data de Abertura"
                                        ConsultaFiltro = ConsultaFiltro & " WHERE DataAbertura BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataAbertura"

                                Case = "Data de Faturamento"
                                        ConsultaFiltro = ConsultaFiltro & " WHERE DataAprovFaturamento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataAprovFaturamento"

                                Case Else
                                        MsgBox("erro no filtro de data (a aplicação sera reiniciada")
                                        Application.Restart()
                        End Select
                Else
                        Select Case cboDataFiltro.Text
                                Case = "Data de Abertura"
                                        ConsultaFiltro = ConsultaFiltro & " And DataAbertura BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataAbertura"

                                Case = "Data de Faturamento"
                                        ConsultaFiltro = ConsultaFiltro & " And DataAprovFaturamento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataAprovFaturamento"

                                Case Else
                                        MsgBox("erro no filtro de data (a aplicação sera reiniciada")
                                        Application.Restart()
                        End Select
                End If
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(ConsultaFiltro, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                dgvPedidos.DataSource = dsbiblio.Tables("Cliente")
        End Sub

        Private Sub dgvPedidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPedidos.CellFormatting
                If e.ColumnIndex = 7 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo Line1
                        End If
                        If (e.Value.ToString = ("Faturado")) Then
                                e.CellStyle.BackColor = Color.DarkGreen
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
Line1:
                If e.ColumnIndex = 7 Or e.ColumnIndex = 1 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo line2
                        End If
                        If (e.Value.ToString = ("Não Faturado")) Then
                                e.CellStyle.BackColor = Color.DarkRed
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
line2:
        End Sub
End Class