Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FrmPDV

        Public UltimoID As Double
        Public TabelaEnviar As String '\\TABELA DE PEDIDO NORMAL OU VINCULADA
        Public TabelaProduto As String '\\TABELA DE PEDIDO PRODUTO VENDA PDV OU VENDA PDV VINCULADA
        Public NormalPD As Double
        Public VinculadoPD As Double
        Public FaltaEstoque As Boolean = False

        '\\LOAD
        Private Sub FrmPDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load




                FrmSelCaixa.ShowDialog()
                If PedidoVinculado = True Then
                        dgvProdutosVinc.Visible = True
                        dgvProdutos.Visible = False
                        dgvProdutosSemCusto.Visible = False
                End If
                If PedidoVinculado = False Then
                        lblkPedidoVinculado.Visible = False
                Else
                        lblkPedidoVinculado.Visible = True
                End If
                If PedidoVinculado = True Then
                        'btnCancelarVinc.Visible = True
                        'btnAprovarVinc.Visible = True
                        dgvProdutosVinc.Visible = True
                        dgvProdutos.Visible = False
                Else
                        'btnCancelarVinc.Visible = False
                        'btnAprovarVinc.Visible = False
                        dgvProdutosVinc.Visible = False
                        dgvProdutos.Visible = True
                End If
                Dim Texts As New List(Of TextBox)
                With Texts
                        .Clear()
                        .Add(txtCliente)
                        .Add(txtCPFCliente)
                        .Add(txtInscEstadual)
                        .Add(txtEndID)
                        .Add(txtContato)
                        .Add(txtCidade)
                        .Add(txtUF)
                        .Add(txtCidade)
                        .Add(txtBairro)
                        .Add(txtEndNumero)
                        .Add(txtLogradouro)
                        .Add(txtComplemento)
                        .Add(txtTipo)
                End With
                If PedidoVinculado = True Then
                        With lblkPedidoVinculado
                                .Text = "Pedido vinculado a OS: " & FrmCadastroOS.txtOSID.Text
                                .ForeColor = Color.Black
                                .Visible = True
                                For Each item In Texts
                                        item.ReadOnly = True
                                Next
                        End With
                        Me.ControlBox = False
                Else
                        With lblkPedidoVinculado
                                .Visible = False
                        End With
                End If
                If lblNumeroPedido.Text = "" Then
                        btnImprimir.Visible = False
                Else
                        btnImprimir.Visible = True
                End If
                Me.TbPedido2TableAdapter.Fill(Me.DataPdv1.tbPedido2)
                Me.EntregaTableAdapter.Fill(Me.DataPdv.Entrega)
                Me.TbEndTableAdapter.Fill(Me.DataPdv.tbEnd)
                Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
                Me.TbEndTableAdapter.FillByVazio(Me.DataPdv.tbEnd)
                Me.TbProdutoPDVTableAdapter.FillByVazio(Me.DataPdv.tbProdutoPDV)
                txtLogradouro.Text = ""
                txtCPFCliente.Text = ""
                With cboTabela.Items
                        .Clear()
                        .Add("TABELA A")
                        .Add("TABELA B")
                        .Add("TABELA C")
                End With
                With cboTabelaPagamento.Items
                        .Clear()
                        .Add("A VISTA")
                        .Add("FATURADO")
                End With
                With Me.chkRetirar.Items
                        .Clear()
                        .Add("Retirar")
                        .Add("Entregar")
                End With
                txtProduto.Text = ""
                txtSoma.Text = ""


        End Sub

        Public NomeCliente As String
        Public ClienteIDatual As Integer

        '\\PREENCHER CAMPO DO NOME DO CLIENTE AO SELECIONAR NO DATAGRIDVIEW (LISTA)
        Private Sub dgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellClick
                Dim Nome As String = dgvCliente.CurrentRow.Cells(0).Value
                On Error Resume Next
                Dim Sobrenome As String = dgvCliente.CurrentRow.Cells(1).Value
                Dim CPF As Double = dgvCliente.CurrentRow.Cells(2).Value
                Dim ClienteID As Integer = dgvCliente.CurrentRow.Cells(3).Value
                NomeCliente = Nome
                ClienteIDatual = ClienteID
                txtCodCliente.Text = ClienteID
                txtCliente.Text = Nome & " " & Sobrenome
                txtCPFCliente.Text = CPF
                dgvCliente.Visible = False
                'conexao1("SELECT CPF FROM tbClientes WHERE Nome=" & Nome)
                'bdr1.Read()
                'txtCPFCliente.Text = bdr1.Item("")
                'Me.TbClientesTableAdapter.FillByNome(Me.DataPdv.tbClientes, Nome)
        End Sub

        '\\BOTÃO PARA ADICIONAR O PRODUTO A COMPRA
        Private Sub btnAdicionarProduto_Click(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click
                PanelProdutos.BringToFront()
                On Error Resume Next
                Dim SaldoEstoque As Double = CDbl(txtSaldoEstoque.Text)
                On Error Resume Next
                Dim QuantidadeCompra As Double = CDbl(txtQuantidade.Text)
                If CDbl(txtSaldoEstoque.Text) < CDbl(txtQuantidade.Text) Then 'VERIFICA A SE HÁ ESTOQUE SUFICIENTE PARA REALIZAR A COMPRA
                        If txtCategoriaProduto.Text = "Producao" Then
                                lSQL = "INSERTO INTO tbFilaProducao (Origem,ClienteID,ProdutoID,NomeProduto,Quantidade,Unidade,DataOrdemProducao,StatusProducao) " &
                                        "Values (""" & "Venda PDV Pedido: " & lblNumeroPedido.Text & """,""" & ClienteID & """,""" & txtProdutoID.Text & """,""" & txtProduto.Text & """,""" & txtQuantidade.Text &
                                        """,""" & txtUnidade.Text & """,""" & Today.ToShortDateString & """,""" & "Aguardando Fabricação" & """)"
                                SQL.Comando()
                        Else
                                SQL.Notificao("", "NÃO HÁ ESTOQUE SUFICIENTE PARA REALIZAR A VENDA")
                                GoTo prox
                        End If
                Else
                        If txtPrecoFrete.Text = "" Then 'VERIFICA SE FOI COBRADO FRETE
                                txtPrecoFrete.Text = 0
                        End If
                        If txtCliente.Text = "" Then '\\VERIFICA SE O NOME DO CLIENTE FOI PREENCHIDO

                                SQL.Notificao("NOVA LITORAL GESSO", "Preencha os dados do cliente/Selecione um produto")
                        Else
                                If txtProdutoID.Text = "" Then '\\VERIFICA SE FOI ESCOLHIDO UM PRODUTO
                                        SQL.Notificao("NOVA LITORAL GESSO", "Selecione um produto")
                                Else
                                        If txtProduto.Text <> "" Then '\\VERIFICA SE O NOME DO PRODUTO ESTÁ PREENCHIDO
                                                If lblNumeroPedido.Text = "" Then
                                                        If SQL.PodeEditarPedido = False Then
                                                                'GoTo LinePularEndEnt
                                                        End If
                                                        If chkEntDif.Checked = True Then '\\VERIFICA SE A ENTREGA É DIFERENTE DO ENDEREÇO DO CLIENTE
                                                                FrmEnderecoEntrega.ShowDialog()
                                                        End If
                                                        Dim Entrega As String
                                                        If chkEntrega.Checked = True Then
                                                                Entrega = "Sim"
                                                        Else
                                                                Entrega = "Não"
                                                        End If
                                                        Dim EntregaDif As String
                                                        If chkEntDif.Checked = True Then
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
                                                                                """,""" & "Produto para Revenda" & """,""" & SQL.Usuario & """,""" & txtCodCliente.Text & """,""" & txtCliente.Text &
                                                                                """,""" & txtPrecoFrete.Text & """,""" & txtEndID.Text & """,""" & EntregaID & """,""" & Entrega & """,""" &
                                                                                EntregaDif & """,""" & UltimoID & """,""" & 0 & """)"
                                                        Else
                                                                lSQL = "INSERT INTO " & TabelaEnviar & " (OSID,DataAbertura,Empresa,Status,Categoria,Vendedor,ClienteID,Cliente,Frete,EndID,EndEntID ,EntregaB,EntregaDifB,PedidoID,Desconto)" &
                                                                                "VALUES (""" & FrmCadastroOS.txtOSID.Text & """,""" & Today.ToShortDateString &
                                                                                """,""" & "Nova Litoral Gesso" & """,""" & "Não Faturado" &
                                                                                """,""" & "Produto para Revenda" & """,""" & SQL.Usuario & """,""" & txtCodCliente.Text & """,""" & txtCliente.Text &
                                                                                """,""" & txtPrecoFrete.Text & """,""" & txtEndID.Text & """,""" & EntregaID & """,""" & Entrega & """,""" & EntregaDif &
                                                                                """,""" & UltimoID & """,""" & 0 & """)"
                                                        End If
                                                        SQL.Comando()
                                                        Connect.Conectardb("SELECT * FROM " & TabelaEnviar & " ORDER BY PedidoID Desc")
                                                        lblNumeroPedido.Text = cdr.Item("PedidoID")
                                                        SQL.AnexoID = cdr.Item("PedidoID")
                                                        Connect.Desconectardb()
                                                        btnImprimir.Visible = True
                                                        'Log("FOI ABERTO O PEDIDO NÚMERO: " & lblNumeroPedido.Text)
                                                        SaveNoti("UM NOVO PEDIDO N: " & lblNumeroPedido.Text & " FOI ABERTO POR " & SQL.Usuario)
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
                                                "VALUES (""" & txtCodCliente.Text & """,""" & txtCliente.Text & """,""" & txtProdutoID.Text & """,""" & UltimoID & """,""" & txtCategoriaProduto.Text & """,""" & txtProduto.Text & """,""" & txtGenero.Text &
                                                                """,""" & txtCusto.Text & """,""" & txtSaldoEstoque.Text & """,""" & txtCusto.Text & """,""" & txtCustoTotal.Text & """,""" &
                                                                txtQuantidade.Text & """,""" & txtSoma.Text & """,""" & txtValorVendaTotal.Text & """,""" & chkRetirar.Text & """)")
                                                'SQL.Comando()
                                                'Log("VENDA DO PRODUTO " & txtProduto.Text & " (" & cboTabela.Text & ") (" & cboTabelaPagamento.Text & ")")
                                                '\\DEFINE O NOVO ESTOQUE
                                                Dim ProxEstoque As Double = CDbl(txtSaldoEstoque.Text) - CDbl(txtQuantidade.Text)
                                                lSQL = "UPDATE " & TabelaProduto & " SET SaldoEstoque=""" & ProxEstoque & """"
                                                SQL.Comando()

                                                SomarProdutos()
prox:
                                                Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
                                                If lblNumeroPedido.Text <> "" Then
                                                        Me.TbProdutoVendaPDVTableAdapter.FillByPedidoID(Me.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(UltimoID, Integer)))
                                                End If
                                                If PedidoVinculado = True Then
                                                        Me.TbProdutoVendaPDVvincTableAdapter.FillByPedido(Me.DataPdv1.tbProdutoVendaPDVvinc, New System.Nullable(Of Integer)(CType(UltimoID, Integer)))
                                                End If
                                                txtCliente.ReadOnly = True
                                                '\\ALTURA DO DATAGRID EM RELAÇÃO AO NUMERO DE LINHAS
                                                dgvProdutos.Height = 23 + (dgvProdutos.Rows.Count * 23)
                                                dgvProdutosSemCusto.Height = 22 + (dgvProdutosSemCusto.Rows.Count * 23)
                                                dgvProdutosVinc.Height = 23 + (dgvProdutosVinc.Rows.Count * 23)
                                                dgvProdutosVinc.Height = 23 + (dgvProdutosVinc.Rows.Count * 23)
                                        End If
                                End If
                        End If
                End If
                txtCustoTotal.Text = ""
                txtQuantidade.Text = ""
                txtProduto.Text = ""
                txtCategoriaProduto.Text = ""
                txtProdutoID.Text = ""
                txtSoma.Text = ""
                txtValorVendaTotal.Text = ""
                txtCusto.Text = ""
                txtGenero.Text = ""
                txtSaldoEstoque.Text = ""
                txtQuantidade.Text = ""
                If lblNumeroPedido.Text <> "" Then
                End If

                QuantidadeItens()

        End Sub

        Public Sub QuantidadeItens()
                If dgvProdutos.Visible = True Then
                        txtItens.Text = dgvProdutos.Rows.Count.ToString
                End If
                If dgvProdutosVinc.Visible = True Then
                        txtItens.Text = dgvProdutosVinc.Rows.Count.ToString
                End If
        End Sub

        Public Sub SomarProdutos()
                '\\SOMA DOS PRODUTOS
                If PedidoVinculado = False Then
                        Connect.Conectardb("SELECT * FROM tbProdutoPDVSoma WHERE PedidoID=" & lblNumeroPedido.Text)
                        'txtSomaTotal'.Text = "R$ " & FormatNumber(cdr.Item("Total de Soma"), 2)
                        txtSomaTotal.Text = Dinheiro(cdr.Item("Total de Soma"))
                        lSQL = "UPDATE tbPedido2 SET ValorTotal=""" & cdr.Item("Total de Soma") & """ WHERE PedidoID=" & lblNumeroPedido.Text
                        SQL.Comando()
                        Connect.Desconectardb()
                Else
                        Connect.Conectardb("SELECT * FROM tbProdutoVendaPDVSomavinc WHERE PedidoID=" & lblNumeroPedido.Text)
                        ' txtSomaTotal.Text = "R$ " & FormatNumber(cdr.Item("Total de ValorVenda"), 2)
                        txtSomaTotal.Text = Dinheiro(cdr.Item("Total de ValorVenda"))
                        lSQL = "UPDATE tbPedido2vinc SET ValorTotal=""" & cdr.Item("Total de ValorVenda") & """ WHERE PedidoID=" & lblNumeroPedido.Text
                        SQL.Comando()
                        Connect.Desconectardb()
                End If
        End Sub

        '\\CALCULAR VALOR EM RELAÇÃO A QUANTIDADE
        Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
                QuantValor()
        End Sub

        Public Sub QuantValor()
                On Error Resume Next
                txtSoma.Text = "R$ " & FormatNumber(CDbl(txtQuantidade.Text) * CDbl(txtCustoTotal.Text), 2)
                txtValorVendaTotal.Text = "R$ " & FormatNumber(CDbl(txtQuantidade.Text) * CDbl(txtCusto.Text), 2)
                If txtQuantidade.Text = "" Then
                        txtQuantidade.Text = 1
                End If
                If txtCusto.Text = "" Then
                        txtCusto.Text = 1
                End If
                If txtProduto.Text = "" Then
                        txtSoma.Text = ""
                        txtValorVendaTotal.Text = ""
                End If
        End Sub




        '\\FILTRO DO DATAGRID CLIENTE A CADA CARACTER DIGITADO
        Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
                FrmMdiHome.pbStatus.Value = 10
                Dim Consulta As String = "SELECT Nome,Sobrenome,CPF,Código FROM tbClientes WHERE Nome LIKE '" & txtCliente.Text & "%'"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                dgvCliente.DataSource = dsbiblio.Tables("Cliente")
                FrmMdiHome.pbStatus.Value = 100

                'MANTER PROPORÇÃO ENTRE AS COLUNAS NOME E SOBRENOME
                Dim LarguraTotal As Double = dgvCliente.Width
                dgvCliente.Columns(0).Width = (LarguraTotal / 3) * 1
                dgvCliente.Columns(1).Width = (LarguraTotal / 3) * 2
                dgvCliente.Columns(2).Width = 0
                dgvCliente.Columns(3).Width = 0
        End Sub

        Public TextPoup As New TextBox

        '\\MOSTRAR O DATAGRID LISTA DO CLIENTE NO CLICK
        Private Sub txtCliente_Click(sender As Object, e As EventArgs) Handles txtCliente.Click
                dgvCliente.Visible = True
                With TextPoup
                        .Width = 250
                        .Height = 100
                        .Text = "PRESSIONE ENTER PARA CONTINUAR"
                        .BackColor = Color.White
                        .ForeColor = Color.Black
                        .Location = New System.Drawing.Size(150, 190)
                        .BorderStyle = BorderStyle.Fixed3D
                End With
                Me.Controls.Add(TextPoup)
                TextPoup.BringToFront()
        End Sub

        '\\botão para mostra o datagrid com endereço relacionado ao cliente
        Private Sub btnMostraEnd_Click(sender As Object, e As EventArgs) Handles btnMostraEnd.Click
                ' Dim Nome As String = dgvCliente.CurrentRow.Cells(1).Value
                If NomeCliente <> "" Then
                        If txtCliente.Text <> "" Then
                                Me.TbEndTableAdapter.FillByEndID(Me.DataPdv.tbEnd, New System.Nullable(Of Integer)(CType(ClienteIDatual, Integer)))
                                dgvEnd.Visible = True
                        Else
                                SQL.Notificao("", "Não foi encontrado endereços para esse cliente")
                        End If
                End If
        End Sub

        '\\ FECHAR O DATAGRID ENDEREÇO E SELECIONAR ENDEREÇO
        Private Sub dgvEnd_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnd.DoubleClick
                dgvEnd.Visible = False
        End Sub

        '\\FECHAR DAGRID ENDEREÇO AO TIRA O MOUSE DE CIMA
        Private Sub dgvEnd_MouseLeave(sender As Object, e As EventArgs) Handles dgvEnd.MouseLeave
                dgvEnd.Visible = False
        End Sub

        Private Sub txtProduto_TextChanged(sender As Object, e As EventArgs) Handles txtProduto.TextChanged
                'On Error Resume Next
                'Me.TbProdutoPDVTableAdapter.FillByNome(Me.DataPdv.tbProdutoPDV, txtProduto.Text)
        End Sub

        Private Sub txtProduto_Click(sender As Object, e As EventArgs) Handles txtProduto.Click
                dgvListaProduto.Visible = True
                Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
        End Sub

        Private Sub dgvListaProduto_MouseLeave(sender As Object, e As EventArgs) Handles dgvListaProduto.MouseLeave
                'dgvListaProduto.Visible = False
        End Sub

        Private Sub dgvCliente_MouseLeave(sender As Object, e As EventArgs) Handles dgvCliente.MouseLeave
                dgvCliente.Visible = False
        End Sub

        Private Sub txtProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduto.KeyDown
                If e.KeyCode = Keys.Enter Then
                        On Error Resume Next
                        txtProduto.Text = dgvListaProduto.CurrentRow.Cells(0).Value
                        dgvListaProduto.Visible = False
                End If
        End Sub

        Private Sub txtQuantidade_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyDown
                If e.KeyCode = Keys.Enter Then
                        btnAdicionarProduto.PerformClick()
                End If
        End Sub

        Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
                SQL.LockChkPdv = False
                Me.Close()
        End Sub

        Private Sub btnDebitarEstoque_Click(sender As Object, e As EventArgs)
                Dim Lin As Integer = dgvProdutos.Rows.Count
                Dim CodProduto As String
                Dim RetirarEstoque As Double
                Lin = Lin - 1
                Do Until Lin < 0
                        CodProduto = dgvProdutos.Item(0, Lin).Value
                        RetirarEstoque = dgvProdutos.Item(3, Lin).Value
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
                                lSQL = "UPDATE tbProdutoPDV SET SaldoEstoque=""" & NovoValor & """ WHERE ProdutoID=" & CodProduto
                                SQL.Comando()
                        End If
Prox:
                        Lin = Lin - 1
                Loop
        End Sub

        Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
                If PedidoVinculado = False Then
                        If lblNumeroPedido.Text <> "" Then
                                FRMFormaPagamentoPDV.ShowDialog()
                        End If
                Else
                        MsgBox("Não é possivel faturar o pedido no modo vinculado")
                End If
        End Sub

        Private Sub chkEntrega_Click(sender As Object, e As EventArgs) Handles chkEntrega.Click
                If SQL.LockChkPdv = False Then
                        If chkEntrega.Checked = True Then
                                chkEntrega.Checked = True
                                lblPrecoFrete.Visible = True
                                txtPrecoFrete.Visible = True
                                chkEntDif.Visible = True
                                chkRetirar.Text = "Entregar"
                        Else
                                chkEntrega.Checked = False
                                lblPrecoFrete.Visible = False
                                txtPrecoFrete.Visible = False
                                chkEntDif.Checked = False
                                chkEntDif.Visible = False
                                chkRetirar.Text = "Retirar"
                        End If
                Else
                        SQL.Notificao("", "Controle bloqueado para edição no momento")
                        If chkEntrega.Checked = True Then
                                chkEntrega.Checked = False
                        Else
                                chkEntrega.Checked = True
                        End If
                End If
        End Sub

        Private Sub btnSQL_Click(sender As Object, e As EventArgs)
                Dim Repeticao As Integer = 0
                Do Until Repeticao >= 1000
                        Repeticao = Repeticao + 1
                        lSQL = "INSERT INTO tbPedido2 (Status)" & "VALUES (""" & "APAGAR" & """)"
                        SQL.Comando()
                Loop
        End Sub

        Private Sub txtProduto_DoubleClick(sender As Object, e As EventArgs) Handles txtProduto.DoubleClick
                txtProduto.Text = ""
        End Sub

        Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
                If e.KeyCode = Keys.Enter Then
                        On Error Resume Next
                        Dim Nome As String = dgvCliente.CurrentRow.Cells(0).Value
                        Dim Sobrenome As String = dgvCliente.CurrentRow.Cells(1).Value
                        If Nome <> "" Or Sobrenome <> "" Then
                                txtCliente.Text = Nome & " " & Sobrenome
                                dgvCliente.Visible = False
                        Else
                                MsgBox("há um possivel erro com o cadastro dessa pessoa (contante o administrador)")
                        End If
                End If
        End Sub

        Private Sub txtValorVendaTotal_TextChanged(sender As Object, e As EventArgs)
                On Error Resume Next
                txtSoma.Text = "R$ " & FormatNumber(CDbl(txtQuantidade.Text) * CDbl(txtCustoTotal.Text), 2)
                txtValorVendaTotal.Text = "R$ " & FormatNumber(CDbl(txtQuantidade.Text) * CDbl(txtCusto.Text), 2)
                If txtQuantidade.Text = "" Then
                        txtQuantidade.Text = 1
                End If
                If txtCusto.Text = "" Then
                        txtCusto.Text = 1
                End If
                If txtProduto.Text = "" Then
                        txtSoma.Text = ""
                        txtValorVendaTotal.Text = ""
                End If
        End Sub

        Private Sub btnCarregarPedido_Click(sender As Object, e As EventArgs) Handles btnCarregarPedido.Click
                If PedidoVinculado = False Then
                        FrmCarregarPedido.Show()
                        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                Else
                        FrmCarregarPedidoVinc.Show()
                        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                End If
        End Sub

        Private Sub chkEntDif_Click(sender As Object, e As EventArgs) Handles chkEntDif.Click
                If SQL.LockChkPdv = True Then
                        SQL.Notificao("", "Este controle esta bloqueado no momento")
                        If chkEntDif.Checked = True Then
                                chkEntDif.Checked = False
                        Else
                                chkEntDif.Checked = True
                        End If
                End If
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs)
                SQL.adm()
                If AcessoAdm = True Then
                        AcessoAdm = False
                        FrmCarregarPedido.BloqueioTxts(False)
                        btnAdicionarProduto.Visible = True
                        txtLogradouro.ReadOnly = False
                        txtEndNumero.ReadOnly = False
                        txtBairro.ReadOnly = False
                        txtCidade.ReadOnly = False
                        txtUF.ReadOnly = False
                        txtComplemento.ReadOnly = False
                        txtTipo.ReadOnly = False
                        '\\DADOS PESSOAIS DO CLIENTE========
                        txtCliente.ReadOnly = False
                        txtCPFCliente.ReadOnly = False
                        txtInscEstadual.ReadOnly = False
                        txtPrecoFrete.ReadOnly = False
                        txtEndID.ReadOnly = False
                        txtProdutoID.ReadOnly = False
                        txtCategoriaProduto.ReadOnly = False
                        txtProduto.ReadOnly = False
                        txtQuantidade.ReadOnly = False
                        txtCustoTotal.ReadOnly = False
                        txtSoma.ReadOnly = False
                        btnAdicionarProduto.Visible = True
                        chkRetirar.Visible = True
                        lblRetirar.Visible = True
                Else
                        AcessoAdm = False
                        MsgBox("NÃO FOI POSSIVEL ATENDER A SUA SOLICITAÇÃO")
                End If
        End Sub

        Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
                FrmImpPDV.ShowDialog()
        End Sub

        Private Sub dgvProdutos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProdutos.CellFormatting
                dgvProdutos.Columns(5).DefaultCellStyle.Format = "c"
                dgvProdutos.Columns(5).ValueType = GetType(Double)
        End Sub

        Private Sub cboTabela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabela.SelectedIndexChanged
                PrecoTabela()
                QuantValor()
        End Sub

        Private Sub cboTabelaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabelaPagamento.SelectedIndexChanged
                PrecoTabela()
                QuantValor()
        End Sub

        Public Sub PrecoTabela()
                If cboTabela.Text <> "" And cboTabelaPagamento.Text <> "" Then
                        If txtProduto.Text <> "" Then
                                Dim SiglaTabela As String
                                Dim SiglaForma As String
                                Dim SiglaCompleta As String
                                Dim Resposta As Double
                                Select Case cboTabela.Text
                                        Case "TABELA A"
                                                SiglaTabela = "TA"
                                        Case "TABELA B"
                                                SiglaTabela = "TB"
                                        Case "TABELA C"
                                                SiglaTabela = "TC"
                                        Case Else
                                                MsgBox("ERRO")
                                End Select
                                Select Case cboTabelaPagamento.Text
                                        Case "A VISTA"
                                                SiglaForma = "V"
                                        Case "FATURADO"
                                                SiglaForma = "F"
                                        Case Else
                                                MsgBox("ERRO")
                                End Select
                                SiglaCompleta = SiglaTabela & SiglaForma
                                Connect.Conectardb("SELECT * FROM tbPrecoTabela WHERE ProdutoID= " & txtProdutoID.Text)
                                If cdr.HasRows = True Then
                                        Resposta = cdr.Item(SiglaCompleta)
                                Else
                                        MsgBox("esse produto não possui registros")
                                End If
                                If Resposta > 0 Then
                                        txtCustoTotal.Text = Resposta
                                Else
                                        MsgBox("o valor é invalido")
                                End If
                                Connect.Desconectardb()
                        End If
                End If
        End Sub

        Private Sub rdOcultarColCusto_CheckedChanged(sender As Object, e As EventArgs) Handles rdOcultarColCusto.CheckedChanged
                If PedidoVinculado = False Then
                        If rdOcultarColCusto.Checked = False Then
                                dgvProdutos.Visible = True
                                dgvProdutosSemCusto.Visible = False
                        Else
                                dgvProdutosSemCusto.Visible = True
                                dgvProdutos.Visible = False
                        End If
                Else
                        dgvProdutos.Visible = False
                        dgvProdutosSemCusto.Visible = False
                        dgvProdutosVinc.Visible = True
                End If
                VerifEstoque()
        End Sub




        Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
                If txtCodBarras.Text <> "" Then
                        If e.KeyCode = Keys.Enter Then
                                Connect.Conectardb("Select * FROM tbProdutoPDV WHERE CB=" & txtCodBarras.Text)
                                If cdr.HasRows = True Then
                                        txtPesqProduto.Text = cdr.Item("Produto")
                                        txtProduto.Text = cdr.Item("Produto")
                                        txtCodBarras.Text = ""
                                        FrmCodBarras.ShowDialog()

                                        Connect.Desconectardb()

                                End If
                        End If
                End If
        End Sub

        Private Sub btnCancelarVinculo_Click(sender As Object, e As EventArgs)
                Dim resulado As MsgBoxResult = MsgBox("Deseja realmente cancelar", vbYesNo, "Nova Litoral Gesso")
                Select Case resulado
                        Case 6
                                PedidoVinculado = False
                                Me.Close()
                                SQL.Notificao("", "O pedido em modo vinculado foi cancelado pelo usuario")
                End Select
        End Sub

        Private Sub FrmPDV_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
                If PedidoVinculado = True Then
                        FrmCadastroOS.SomaPedido()
                        FrmCadastroOS.TbProdutoAgrupadoAdapter.Fill(FrmCadastroOS.DataPdv1.tbProdutoAgrupado, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
                End If
        End Sub

        Private Sub FrmPDV_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
                If FrmSelCaixa.CaixaAberto = False Then
                        MsgBox("A PAGINA SERA FECHADO PORQUE SEU CAIXA NÃO FOI ABERTO")
                        Me.Close()
                End If
        End Sub

        Public Sub Button1Click(sender As Object, e As EventArgs)
                VerifEstoque()
        End Sub

        Public Sub VerifEstoque()
                Dim A, B, C, D As Integer
                Dim dgvEscolhido As DataGridView
                Dim LinhaAtual As Double = 0
                If rdOcultarColCusto.Checked = True Then
                        dgvEscolhido = dgvProdutosSemCusto
                        A = 0 'index produto id
                        B = 3 'index quantidade vendida
                        C = 2 'index nome do produto
                        D = 6 'index write "indisponivel
                Else
                        dgvEscolhido = dgvProdutos
                        A = 0 'index produto id
                        B = 3 'index quantidade vendida
                        C = 2 'index nome do produto
                        D = 7 'index write "produto indisponivel
                End If
                For Each item In dgvEscolhido.Rows
                        Dim ProdutoID As Integer = item.cells(A).value
                        Dim QuantVenda As Double = item.cells(B).value
                        Dim NomeProduto As String = item.cells(C).value
                        Dim EmEstoque As Double
                        Connect.Conectardb("SELECT * FROM tbProdutoPDV WHERE ProdutoID=" & ProdutoID)
                        If cdr.HasRows = True Then
                                EmEstoque = cdr.Item("SaldoEstoque")
                        End If
                        Connect.Desconectardb()
                        If QuantVenda > EmEstoque Then
                                FaltaEstoque = True
                                dgvEscolhido.Rows(LinhaAtual).Cells(D).Value = "SEM ESTOQUE"
                                dgvEscolhido.Rows(LinhaAtual).DefaultCellStyle.BackColor = Color.Red
                        End If
                        LinhaAtual += 1
                Next
                If FaltaEstoque = True Then
                        MsgBox("ATENÇÃO UM OU MAIS PRODUTOS NÃO ESTÃO MAIS DISPONIVEIS")
                End If
        End Sub

        Private Sub tmAtualizardgv_Tick(sender As Object, e As EventArgs) Handles tmAtualizardgv.Tick
                VerifEstoque()
                tmAtualizardgv.Stop()
        End Sub

        Private Sub DockLeft_MouseEnter(sender As Object, e As EventArgs)
                ' DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub DockLeft_MouseLeave(sender As Object, e As EventArgs)
                'System.Threading.Thread.Sleep(500)
                ' DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnVoltar_MouseEnter(sender As Object, e As EventArgs) Handles btnVoltar.MouseEnter
                ' DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnCarregarPedido_MouseEnter(sender As Object, e As EventArgs) Handles btnCarregarPedido.MouseEnter
                'DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnPagamento_MouseEnter(sender As Object, e As EventArgs) Handles btnPagamento.MouseEnter
                ' DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnImprimir_MouseEnter(sender As Object, e As EventArgs) Handles btnImprimir.MouseEnter
                ' DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnAprovarVinc_MouseEnter(sender As Object, e As EventArgs)
                ' DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnCancelarVinc_MouseEnter(sender As Object, e As EventArgs)
                'DockShowHide("show", DockLeft, 63, 135)
        End Sub

        Private Sub btnVoltar_MouseLeave(sender As Object, e As EventArgs) Handles btnVoltar.MouseLeave
                ' DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnCarregarPedido_MouseLeave(sender As Object, e As EventArgs) Handles btnCarregarPedido.MouseLeave
                ''DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnPagamento_MouseLeave(sender As Object, e As EventArgs) Handles btnPagamento.MouseLeave
                ' DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btnImprimir.MouseLeave
                'DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnAprovarVinc_MouseLeave(sender As Object, e As EventArgs)
                'DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnCancelarVinc_MouseLeave(sender As Object, e As EventArgs)
                ' DockShowHide("hide", DockLeft, 63, 135)
        End Sub

        Private Sub btnshow1_Click(sender As Object, e As EventArgs) Handles btnshow1.Click
                If txtCliente.Text <> "" And txtEndID.Text <> "" Then
                        ' FrmEnderecoEntrega.ShowDialog()
                        Panel1.Visible = True
                        Panel4.Visible = False
                Else
                        SQL.Notificao("", "Conclua as informações do cliente para prosseguir")
                End If
        End Sub

        Private Sub grpshow2_Click(sender As Object, e As EventArgs) Handles grpshow2.Click
                Panel1.Visible = False
                Panel4.Visible = True
        End Sub

        Private Sub dgvListaProduto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProduto.CellEnter
                txtProduto.Text = dgvListaProduto.CurrentRow.Cells(0).Value
                If lblNumeroPedido.Text = "" Then
                        btnMostraEnd.Visible = True
                End If
                txtQuantidade.Text = 1
                txtSoma.Text = txtCustoTotal.Text
        End Sub

        Private Sub btnAddPessoa_Click(sender As Object, e As EventArgs) Handles btnAddPessoa.Click
                FrmAdicionarCliente.ShowDialog()
        End Sub

        Private Sub dgvCliente_VisibleChanged(sender As Object, e As EventArgs) Handles dgvCliente.VisibleChanged
                Select Case dgvCliente.Visible
                        Case True
                                TextPoup.Visible = True
                        Case False
                                TextPoup.Visible = False
                End Select
        End Sub

        Private Sub btnAddQuant_Click(sender As Object, e As EventArgs) Handles btnAddQuant.Click
                If IsNumeric(txtSaldoEstoque.Text) = True And IsNumeric(txtQuantidade.Text) = True Then
                        Dim Estoque As Double = CDbl(txtSaldoEstoque.Text)
                        Dim Quantidade As Double = CDbl(txtQuantidade.Text)
                        If Quantidade < Estoque Then
                                txtQuantidade.Text += 1
                        Else
                                SQL.Notificao("", "Não estoque suficiente para adicionar mais")
                        End If
                End If
        End Sub

        Private Sub btnRetQuant_Click(sender As Object, e As EventArgs) Handles btnRetQuant.Click
                If txtQuantidade.Text > 0 Then
                        txtQuantidade.Text -= 1
                Else
                        txtQuantidade.Text = 0
                End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
                dgvListaProduto.Visible = True
                lblPesquisarProdutos.Visible = True
                lblProduto.Visible = True
                lblEmEstoque.Visible = True
                PanelProdutos.Visible = True
                btnConfirmarEscolha.Visible = True
                Me.TbProdutoPDVTableAdapter.FillByNome(Me.DataPdv.tbProdutoPDV, txtPesqProduto.Text)
        End Sub



        Public Sub btnConfirmarEscolha_Click(sender As Object, e As EventArgs) Handles btnConfirmarEscolha.Click
                'On Error Resume Next
                'MsgBox("Nome do Produto  " & dgvProdutos.CurrentRow.Cells(0).Value)
                dgvListaProduto.Visible = False
                lblPesquisarProdutos.Visible = False
                lblProduto.Visible = False
                lblEmEstoque.Visible = False
                PanelProdutos.Visible = False
                btnConfirmarEscolha.Visible = False
                dgvRE.Visible = False
        End Sub

        Private Sub txtPesqProduto_TextChanged(sender As Object, e As EventArgs) Handles txtPesqProduto.TextChanged
                Me.TbProdutoPDVTableAdapter.FillByNome(Me.DataPdv.tbProdutoPDV, txtPesqProduto.Text)
        End Sub

        Private Sub Label20_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub dgvListaProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProduto.CellContentClick

        End Sub

        Private Sub lblPesq_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged

        End Sub

        Private Sub txtPesqProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesqProduto.KeyDown

        End Sub

        Private Sub TextBox1_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtCodePesq.KeyDown
                If txtCodePesq.Text <> "" Then
                        If e.KeyCode = Keys.Enter Then
                                Connect.Conectardb("Select * FROM tbProdutoPDV WHERE CB=" & txtCodePesq.Text)
                                If cdr.HasRows = True Then
                                        txtPesqProduto.Text = cdr.Item("Produto")
                                End If
                        End If
                End If
        End Sub

        Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtCodePesq.Click
                txtCodePesq.Text = ""
        End Sub

        Private Sub btnAprovarVinc_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub txtAddProduto2_Click(sender As Object, e As EventArgs) Handles txtAddProduto2.Click
                btnAdicionarProduto.PerformClick()
        End Sub

        Private Sub FrmPDV_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
                If e.KeyCode = Keys.F2 Then
                        btnPagamento.PerformClick()
                End If
                If e.KeyCode = Keys.F3 Then
                        btnCarregarPedido.PerformClick()
                End If
                If e.KeyCode = Keys.Subtract Then
                        btnRetQuant.PerformClick()
                End If
                If e.KeyCode = Keys.Add Then
                        btnAddQuant.PerformClick()
                End If
        End Sub

        Private Sub btnVoltar2_Click(sender As Object, e As EventArgs) Handles btnVoltar2.Click
                SQL.LockChkPdv = False
                Me.Close()
        End Sub

        Private Sub btnCarregarPedido2_Click(sender As Object, e As EventArgs) Handles btnCarregarPedido2.Click
                If PedidoVinculado = False Then
                        FrmCarregarPedido.Show()
                        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                Else
                        FrmCarregarPedidoVinc.Show()
                        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                End If
        End Sub

        Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

        End Sub

        Private Sub dgvCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellEnter

        End Sub

        Private Sub btnRE_Click(sender As Object, e As EventArgs) Handles btnRE.Click
                dgvRE.BringToFront()

                'switch visible noVisible
                Select Case dgvRE.Visible
                        Case True
                                dgvRE.Visible = False
                        Case False
                                dgvRE.Visible = True
                        Case Else
                                MsgBox("possivel erro na visibilidade do datagrid de definição retirada/entrega")
                End Select
        End Sub

        Private Sub btnAgendarEntrega_Click(sender As Object, e As EventArgs) Handles btnAgendarEntrega.Click
                FrmAgendaEntrega.Show()
        End Sub

        Private Sub FrmPDV_Shown(sender As Object, e As EventArgs) Handles Me.Shown
                Dim status As String = FrmSelCaixa.CaixaAtual.Status
                If FrmSelCaixa.CaixaAtual.Status = "FECHADO" Then
                        Me.Close()
                End If
        End Sub
End Class