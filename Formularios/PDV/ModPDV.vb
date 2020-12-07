Imports System.Data.OleDb

Module ModPDV

        Public UltimoID As Double
        Public TabelaEnviar As String '\\TABELA DE PEDIDO NORMAL OU VINCULADA
        Public TabelaProduto As String '\\TABELA DE PEDIDO PRODUTO VENDA PDV OU VENDA PDV VINCULADA
        Public NormalPD As Double
        Public VinculadoPD As Double
        Public FaltaEstoque As Boolean = False
        Public NomeCliente As String
        Public ClienteIDatual As Integer
        Public TextPoup As New TextBox

        Public Sub LoadPDV()
                FrmSelCaixa.ShowDialog()
                If PedidoVinculado = True Then
                        FrmPDV.dgvProdutosVinc.Visible = True
                        FrmPDV.dgvProdutos.Visible = False
                        FrmPDV.dgvProdutosSemCusto.Visible = False
                End If
                If PedidoVinculado = False Then
                        FrmPDV.lblkPedidoVinculado.Visible = False
                Else
                        FrmPDV.lblkPedidoVinculado.Visible = True
                End If
                If PedidoVinculado = True Then
                        'btnCancelarVinc.Visible = True
                        'btnAprovarVinc.Visible = True
                        FrmPDV.dgvProdutosVinc.Visible = True
                        FrmPDV.dgvProdutos.Visible = False
                Else
                        'btnCancelarVinc.Visible = False
                        'btnAprovarVinc.Visible = False
                        FrmPDV.dgvProdutosVinc.Visible = False
                        FrmPDV.dgvProdutos.Visible = True
                End If
                Dim Texts As New List(Of TextBox)
                With Texts
                        .Clear()
                        .Add(FrmPDV.txtCliente)
                        .Add(FrmPDV.txtCPFCliente)
                        .Add(FrmPDV.txtInscEstadual)
                        .Add(FrmPDV.txtEndID)
                        .Add(FrmPDV.txtContato)
                        .Add(FrmPDV.txtCidade)
                        .Add(FrmPDV.txtUF)
                        .Add(FrmPDV.txtCidade)
                        .Add(FrmPDV.txtBairro)
                        .Add(FrmPDV.txtEndNumero)
                        .Add(FrmPDV.txtLogradouro)
                        .Add(FrmPDV.txtComplemento)
                        .Add(FrmPDV.txtTipo)
                End With
                If PedidoVinculado = True Then
                        With FrmPDV.lblkPedidoVinculado
                                .Text = "Pedido vinculado a OS: " & FrmCadastroOS.txtOSID.Text
                                .ForeColor = Color.Black
                                .Visible = True
                                For Each item In Texts
                                        item.ReadOnly = True
                                Next
                        End With
                        FrmPDV.ControlBox = False
                Else
                        With FrmPDV.lblkPedidoVinculado
                                .Visible = False
                        End With
                End If
                If FrmPDV.lblNumeroPedido.Text = "" Then
                        FrmPDV.btnImprimir.Visible = False
                Else
                        FrmPDV.btnImprimir.Visible = True
                End If
                FrmPDV.TbPedido2TableAdapter.Fill(FrmPDV.DataPdv1.tbPedido2)
                FrmPDV.EntregaTableAdapter.Fill(FrmPDV.DataPdv.Entrega)
                FrmPDV.TbEndTableAdapter.Fill(FrmPDV.DataPdv.tbEnd)
                '            FrmPDV.TbProdutoPDVTableAdapter.Fill(FrmPDV.DataPdv.tbProdutoPDV)
                FrmPDV.TbEndTableAdapter.FillByVazio(FrmPDV.DataPdv.tbEnd)
                '      FrmPDV.TbProdutoPDVTableAdapter.FillByVazio(FrmPDV.DataPdv.tbProdutoPDV)
                FrmPDV.txtLogradouro.Text = ""
                FrmPDV.txtCPFCliente.Text = ""
                With FrmPDV.cboTabela.Items
                        .Clear()
                        .Add("TABELA A")
                        .Add("TABELA B")
                        .Add("TABELA C")
                End With
                With FrmPDV.cboTabelaPagamento.Items
                        .Clear()
                        .Add("A VISTA")
                        .Add("FATURADO")
                End With
                With FrmPDV.chkRetirar.Items
                        .Clear()
                        .Add("Retirar")
                        .Add("Entregar")
                End With
                FrmPDV.txtProduto.Text = ""
                FrmPDV.txtSoma.Text = ""
        End Sub

        Public Sub AdicionarProduto()
                FrmPDV.PanelProdutos.BringToFront()
                On Error Resume Next
                Dim SaldoEstoque As Double = CDbl(FrmPDV.txtSaldoEstoque.Text)
                On Error Resume Next
                Dim QuantidadeCompra As Double = CDbl(FrmPDV.txtQuantidade.Text)
                If CDbl(FrmPDV.txtSaldoEstoque.Text) < CDbl(FrmPDV.txtQuantidade.Text) Then 'VERIFICA A SE HÁ ESTOQUE SUFICIENTE PARA REALIZAR A COMPRA
                        If FrmPDV.txtCategoriaProduto.Text = "Producao" Then
                                lSQL = "INSERTO INTO tbFilaProducao (Origem,ClienteID,ProdutoID,NomeProduto,Quantidade,Unidade,DataOrdemProducao,StatusProducao) " &
                                        "Values (""" & "Venda PDV Pedido: " & FrmPDV.lblNumeroPedido.Text & """,""" & ClienteID & """,""" & FrmPDV.txtProdutoID.Text & """,""" & FrmPDV.txtProduto.Text & """,""" & FrmPDV.txtQuantidade.Text &
                                        """,""" & FrmPDV.txtUnidade.Text & """,""" & Today.ToShortDateString & """,""" & "Aguardando Fabricação" & """)"
                                SQL.Comando()
                        Else
                                SQL.Notificao("", "NÃO HÁ ESTOQUE SUFICIENTE PARA REALIZAR A VENDA")
                                GoTo prox
                        End If
                Else
                        If FrmPDV.txtPrecoFrete.Text = "" Then 'VERIFICA SE FOI COBRADO FRETE
                                FrmPDV.txtPrecoFrete.Text = 0
                        End If
                        If FrmPDV.txtCliente.Text = "" Then '\\VERIFICA SE O NOME DO CLIENTE FOI PREENCHIDO

                                SQL.Notificao("NOVA LITORAL GESSO", "Preencha os dados do cliente/Selecione um produto")
                        Else
                                If FrmPDV.txtProdutoID.Text = "" Then '\\VERIFICA SE FOI ESCOLHIDO UM PRODUTO
                                        SQL.Notificao("NOVA LITORAL GESSO", "Selecione um produto")
                                Else
                                        If FrmPDV.txtProduto.Text <> "" Then '\\VERIFICA SE O NOME DO PRODUTO ESTÁ PREENCHIDO
                                                If FrmPDV.lblNumeroPedido.Text = "" Then
                                                        If SQL.PodeEditarPedido = False Then
                                                                'GoTo LinePularEndEnt
                                                        End If
                                                        If FrmPDV.chkEntDif.Checked = True Then '\\VERIFICA SE A ENTREGA É DIFERENTE DO ENDEREÇO DO CLIENTE
                                                                FrmEnderecoEntrega.ShowDialog()
                                                        End If
                                                        Dim Entrega As String
                                                        If FrmPDV.chkEntrega.Checked = True Then
                                                                Entrega = "Sim"
                                                        Else
                                                                Entrega = "Não"
                                                        End If
                                                        Dim EntregaDif As String
                                                        If FrmPDV.chkEntDif.Checked = True Then
                                                                EntregaDif = "Sim"
                                                        Else
                                                                EntregaDif = "Não"
                                                        End If
                                                        Connect.Conectardb("SELECT * FROM tbPedido2 ORDER BY PedidoID Desc")
                                                        NormalPD = cdr.Item("PedidoID")
                                                        Connect.Desconectardb()
                                                        Connect.Conectardb("SELECT * FROM tbPedido2vinc ORDER BY PedidoID Desc")
                                                        VinculadoPD = cdr.Item("PedidoID")
                                                        Connect.Desconectardb()
                                                        If NormalPD > VinculadoPD Then
                                                                UltimoID = NormalPD
                                                        Else
                                                                UltimoID = VinculadoPD
                                                        End If
                                                        UltimoID += 1
                                                        If PedidoVinculado = False Then
                                                                TabelaEnviar = "tbPedido2"
                                                                TabelaProduto = "tbProdutoVendaPDV"
                                                        Else
                                                                TabelaEnviar = "tbPedido2vinc"
                                                                TabelaProduto = "tbProdutoVendaPDVvinc"
                                                        End If
                                                        If PedidoVinculado = False Then
                                                                lSQL = "INSERT INTO " & TabelaEnviar & " (DataAbertura,Empresa,Status,Categoria,Vendedor,ClienteID,Cliente,Frete,EndID,EndEntID,EntregaB,EntregaDifB,PedidoID,Desconto)" &
                                                                                "VALUES (""" & Today.ToShortDateString & """,""" & "Nova Litoral Gesso" & """,""" & "Não Faturado" &
                                                                                """,""" & "Produto para Revenda" & """,""" & SQL.Usuario & """,""" & FrmPDV.txtCodCliente.Text & """,""" & FrmPDV.txtCliente.Text &
                                                                                """,""" & FrmPDV.txtPrecoFrete.Text & """,""" & FrmPDV.txtEndID.Text & """,""" & EntregaID & """,""" & Entrega & """,""" &
                                                                                EntregaDif & """,""" & UltimoID & """,""" & 0 & """)"
                                                        Else
                                                                lSQL = "INSERT INTO " & TabelaEnviar & " (OSID,DataAbertura,Empresa,Status,Categoria,Vendedor,ClienteID,Cliente,Frete,EndID,EndEntID ,EntregaB,EntregaDifB,PedidoID,Desconto)" &
                                                                                "VALUES (""" & FrmCadastroOS.txtOSID.Text & """,""" & Today.ToShortDateString &
                                                                                """,""" & "Nova Litoral Gesso" & """,""" & "Não Faturado" &
                                                                                """,""" & "Produto para Revenda" & """,""" & SQL.Usuario & """,""" & FrmPDV.txtCodCliente.Text & """,""" & FrmPDV.txtCliente.Text &
                                                                                """,""" & FrmPDV.txtPrecoFrete.Text & """,""" & FrmPDV.txtEndID.Text & """,""" & EntregaID & """,""" & Entrega & """,""" & EntregaDif &
                                                                                """,""" & UltimoID & """,""" & 0 & """)"
                                                        End If
                                                        SQL.Comando()
                                                        Connect.Conectardb("SELECT * FROM " & TabelaEnviar & " ORDER BY PedidoID Desc")
                                                        FrmPDV.lblNumeroPedido.Text = cdr.Item("PedidoID")
                                                        SQL.AnexoID = cdr.Item("PedidoID")
                                                        Connect.Desconectardb()
                                                        FrmPDV.btnImprimir.Visible = True
                                                        SaveNoti("UM NOVO PEDIDO N: " & FrmPDV.lblNumeroPedido.Text & " FOI ABERTO POR " & SQL.Usuario)
                                                End If
LinePularEndEnt:
                                                Connect.Conectardb("SELECT * FROM tbPedido2 ORDER BY PedidoID Desc")
                                                NormalPD = cdr.Item("PedidoID")
                                                Connect.Desconectardb()
                                                Connect.Conectardb("SELECT * FROM tbPedido2vinc ORDER BY PedidoID Desc")
                                                VinculadoPD = cdr.Item("PedidoID")
                                                Connect.Desconectardb()
                                                If NormalPD > VinculadoPD Then
                                                        UltimoID = NormalPD
                                                Else
                                                        UltimoID = VinculadoPD
                                                End If
                                                ' UltimoID
                                                If PedidoVinculado = False Then
                                                        TabelaEnviar = "tbPedido2"
                                                        TabelaProduto = "tbProdutoVendaPDV"
                                                Else
                                                        TabelaEnviar = "tbPedido2vinc"
                                                        TabelaProduto = "tbProdutoVendaPDVvinc"
                                                End If
                                                InstrucaoDireta("INSERT INTO " & TabelaProduto & " (ClienteID,NomeCliente,ProdutoID,PedidoID,CategoriaPadrao,Produto,Genero,Custo,SaldoEstoque,CustoTotal,ValorVenda,Quantidade,Soma,ValorCustoTotal,Retirado)" &
                                                "VALUES (""" & FrmPDV.txtCodCliente.Text & """,""" & FrmPDV.txtCliente.Text & """,""" & FrmPDV.txtProdutoID.Text & """,""" & UltimoID & """,""" & FrmPDV.txtCategoriaProduto.Text & """,""" & FrmPDV.txtProduto.Text & """,""" & FrmPDV.txtGenero.Text &
                                                                """,""" & FrmPDV.txtCusto.Text & """,""" & FrmPDV.txtSaldoEstoque.Text & """,""" & FrmPDV.txtCusto.Text & """,""" & FrmPDV.txtCustoTotal.Text & """,""" &
                                                                FrmPDV.txtQuantidade.Text & """,""" & FrmPDV.txtSoma.Text & """,""" & FrmPDV.txtValorVendaTotal.Text & """,""" & FrmPDV.chkRetirar.Text & """)")

                                                Dim ProxEstoque As Double = CDbl(FrmPDV.txtSaldoEstoque.Text) - CDbl(FrmPDV.txtQuantidade.Text)
                                                lSQL = "UPDATE " & TabelaProduto & " SET SaldoEstoque=""" & ProxEstoque & """"
                                                SQL.Comando()
                                                SomarProdutos(FrmPDV)
prox:
                                                FrmPDV.TbProdutoPDVTableAdapter.Fill(FrmPDV.DataPdv.tbProdutoPDV)
                                                If FrmPDV.lblNumeroPedido.Text <> "" Then
                                                        FrmPDV.TbProdutoVendaPDVTableAdapter.FillByPedidoID(FrmPDV.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(UltimoID, Integer)))
                                                End If
                                                If PedidoVinculado = True Then
                                                        FrmPDV.TbProdutoVendaPDVvincTableAdapter.FillByPedido(FrmPDV.DataPdv1.tbProdutoVendaPDVvinc, New System.Nullable(Of Integer)(CType(UltimoID, Integer)))
                                                End If
                                                FrmPDV.txtCliente.ReadOnly = True
                                                '\\ALTURA DO DATAGRID EM RELAÇÃO AO NUMERO DE LINHAS
                                                FrmPDV.dgvProdutos.Height = 23 + (FrmPDV.dgvProdutos.Rows.Count * 23)
                                                FrmPDV.dgvProdutosSemCusto.Height = 22 + (FrmPDV.dgvProdutosSemCusto.Rows.Count * 23)
                                                FrmPDV.dgvProdutosVinc.Height = 23 + (FrmPDV.dgvProdutosVinc.Rows.Count * 23)
                                                FrmPDV.dgvProdutosVinc.Height = 23 + (FrmPDV.dgvProdutosVinc.Rows.Count * 23)
                                        End If
                                End If
                        End If
                End If
                FrmPDV.txtCustoTotal.Text = ""
                FrmPDV.txtQuantidade.Text = ""
                FrmPDV.txtProduto.Text = ""
                FrmPDV.txtCategoriaProduto.Text = ""
                FrmPDV.txtProdutoID.Text = ""
                FrmPDV.txtSoma.Text = ""
                FrmPDV.txtValorVendaTotal.Text = ""
                FrmPDV.txtCusto.Text = ""
                FrmPDV.txtGenero.Text = ""
                FrmPDV.txtSaldoEstoque.Text = ""
                FrmPDV.txtQuantidade.Text = ""
                If FrmPDV.lblNumeroPedido.Text <> "" Then
                End If
                QuantItens()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="datagrid">grid para realizar a contagem de itens</param>
        Public Sub QuantItens()
                If FrmPDV.dgvProdutos.Visible = True Then
                        FrmPDV.txtItens.Text = FrmPDV.dgvProdutos.Rows.Count.ToString
                End If
                If FrmPDV.dgvProdutosVinc.Visible = True Then
                        FrmPDV.txtItens.Text = FrmPDV.dgvProdutosVinc.Rows.Count.ToString
                End If
        End Sub

        Public Sub SomarProdutos(form As Form)
                '\\SOMA DOS PRODUTOS
                If PedidoVinculado = False Then
                        Connect.Conectardb("SELECT * FROM tbProdutoPDVSoma WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                        FrmPDV.txtSomaTotal.Text = Dinheiro(cdr.Item("Total de Soma"))
                        lSQL = "UPDATE tbPedido2 SET ValorTotal=""" & cdr.Item("Total de Soma") & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text
                        SQL.Comando()
                        Connect.Desconectardb()
                Else
                        Connect.Conectardb("SELECT * FROM tbProdutoVendaPDVSomavinc WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                        FrmPDV.txtSomaTotal.Text = Dinheiro(cdr.Item("Total de ValorVenda"))
                        lSQL = "UPDATE tbPedido2vinc SET ValorTotal=""" & cdr.Item("Total de ValorVenda") & """ WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text
                        SQL.Comando()
                        Connect.Desconectardb()
                End If
        End Sub

        Public Sub QuantValor()
                On Error Resume Next
                FrmPDV.txtSoma.Text = "R$ " & FormatNumber(CDbl(FrmPDV.txtQuantidade.Text) * CDbl(FrmPDV.txtCustoTotal.Text), 2)
                FrmPDV.txtValorVendaTotal.Text = "R$ " & FormatNumber(CDbl(FrmPDV.txtQuantidade.Text) * CDbl(FrmPDV.txtCusto.Text), 2)
                If FrmPDV.txtQuantidade.Text = "" Then
                        FrmPDV.txtQuantidade.Text = 1
                End If
                If FrmPDV.txtCusto.Text = "" Then
                        FrmPDV.txtCusto.Text = 1
                End If
                If FrmPDV.txtProduto.Text = "" Then
                        FrmPDV.txtSoma.Text = ""
                        FrmPDV.txtValorVendaTotal.Text = ""
                End If
        End Sub

        ''' <summary>
        ''' filtro pra mostrar o cliente em um datagridview
        ''' </summary>
        ''' <param name="textbox">text de entrada para o filtro</param>
        ''' <param name="dgv">saida do resultado da consulta</param>
        ''' 

        Public Sub FiltroNomesClientes(textbox As TextBox, dgv As DataGridView)
                FrmMdiHome.pbStatus.Value = 10
                Dim Consulta As String = "SELECT Nome,Sobrenome,CPF,Código FROM tbClientes WHERE Nome LIKE '" & textbox.Text & "%'"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                dgv.DataSource = dsbiblio.Tables("Cliente")
                FrmMdiHome.pbStatus.Value = 100
                'MANTER PROPORÇÃO ENTRE AS COLUNAS NOME E SOBRENOME
                Dim LarguraTotal As Double = dgv.Width
                dgv.Columns(0).Width = (LarguraTotal / 3) * 1
                dgv.Columns(1).Width = (LarguraTotal / 3) * 2
                dgv.Columns(2).Width = 0
                dgv.Columns(3).Width = 0
        End Sub



End Module
