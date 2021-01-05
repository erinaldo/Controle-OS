Imports System.ComponentModel
Imports System.Data.OleDb
Imports MaterialSkin

Public Class FrmPDV

        Inherits Controls.MaterialForm

        '\\LOAD
        Private Sub FrmPDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                LoadPDV()
        End Sub

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
                'dgvCliente.Visible = False
                'FiltroNomesClientes(txtCliente, dgvCliente)
                'conexao1("SELECT CPF FROM tbClientes WHERE Nome=" & Nome)
                'bdr1.Read()
                'txtCPFCliente.Text = bdr1.Item("")
                'Me.TbClientesTableAdapter.FillByNome(Me.DataPdv.tbClientes, Nome)
        End Sub

        '\\BOTÃO PARA ADICIONAR O PRODUTO A COMPRA
        Private Sub btnAdicionarProduto_Click(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click
                AdicionarProduto()
        End Sub

        '\\CALCULAR VALOR EM RELAÇÃO A QUANTIDADE
        Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
                ProdutoxQuantidade()
        End Sub

        '\\FILTRO DO DATAGRID CLIENTE A CADA CARACTER DIGITADO
        Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
                FiltroNomesClientes(txtCliente, dgvCliente)
        End Sub

        '\\MOSTRAR O DATAGRID LISTA DO CLIENTE NO CLICK
        Private Sub txtCliente_Click(sender As Object, e As EventArgs) Handles txtCliente.Click
                dgvCliente.Visible = True
                With TextPoup
                        .Width = 250
                        .Height = 100
                        '.Text = "PRESSIONE ENTER PARA CONTINUAR"
                        .BackColor = Color.White
                        .ForeColor = Color.Black
                        .Location = New System.Drawing.Size(150, 190)
                        .BorderStyle = BorderStyle.Fixed3D
                End With
                '  Me.Controls.Add(TextPoup)
                TextPoup.BringToFront()
        End Sub

        '\\botão para mostra o datagrid com endereço relacionado ao cliente
        Private Sub btnMostraEnd_Click(sender As Object, e As EventArgs) Handles btnMostraEnd.Click
                ' Dim Nome As String = dgvCliente.CurrentRow.Cells(1).Value
                If NomeCliente <> "" Then
                        If txtCliente.Text <> "" Then
                                'Me.TbEndTableAdapter.FillByEndID(Me.DataPdv.tbEnd, New System.Nullable(Of Integer)(CType(ClienteIDatual, Integer)))

                                Dim strConn As String = sConnectionString
                                Dim conexao As New OleDbConnection(strConn)
                                Dim comando As New OleDbCommand("SELECT Logradouro, EndNumero, Bairro, Cidade, UF, Complemento, CEP, Tipo, ID FROM tbEnd WHERE CodEnd=" & ClienteIDatual, conexao)
                                Dim adaptador As New OleDbDataAdapter(comando)
                                Dim dsbiblio As New DataSet()
                                adaptador.Fill(dsbiblio, "Endereco")
                                dgvEnd.DataSource = dsbiblio.Tables("Endereco")

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

        '      Private Sub txtProduto_Click(sender As Object, e As EventArgs) Handles txtProduto.Click
        '               dgvListaProduto.Visible = True
        'Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
        '
        '    Dim strConn As String = sConnectionString
        '    Dim conexao As New OleDbConnection(strConn)
        '    Dim comando As New OleDbCommand("SELECT Produto, SaldoEstoque FROM tbProdutoPDV", conexao)
        '    Dim adaptador As New OleDbDataAdapter(comando)
        '    Dim dsbiblio As New DataSet()
        '    adaptador.Fill(dsbiblio, "Produto")
        '    dgvListaProduto.DataSource = dsbiblio.Tables("Produto")
        '     End Sub

        Private Sub dgvCliente_MouseLeave(sender As Object, e As EventArgs) Handles dgvCliente.MouseLeave
                '  dgvCliente.Visible = False
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
                        AdicionarProduto()
                End If
        End Sub

        Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
                SQL.LockChkPdv = False
                Me.Close()
        End Sub

        ''' <summary>
        ''' Retirar produtos do estoque
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' 
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

        '   Private Sub dgvListaProduto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProduto.CellEnter
        '    txtProduto.Text = dgvListaProduto.CurrentRow.Cells(2).Value
        '    If lblNumeroPedido.Text = "" Then
        '    btnMostraEnd.Visible = True
        '    End If
        '    txtQuantidade.Text = 1
        '    txtSoma.Text = txtCustoTotal.Text
        '
        '               Try
        '              conexao1("SELECT * FROM tbProdutoPDV WHERE Produto='" & dgvListaProduto.CurrentRow.Cells(2).Value)
        '             bdr1.Read()
        '            txtProdutoID.Text = bdr1("ProdutoID")
        '           Catch
        '          SQL.Notificao("", "Erro na consulta de produto pelo nome")
        '         End Try
        ' End Sub

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
                'lblProduto.Visible = True
                'lblEmEstoque.Visible = True
                PanelProdutos.Visible = True
                btnConfirmarEscolha.Visible = True
                '  Me.TbProdutoPDVTableAdapter.FillByNome(Me.DataPdv.tbProdutoPDV, txtPesqProduto.Text)
        End Sub

        Public Sub btnConfirmarEscolha_Click(sender As Object, e As EventArgs) Handles btnConfirmarEscolha.Click
                'On Error Resume Next
                'MsgBox("Nome do Produto  " & dgvProdutos.CurrentRow.Cells(0).Value)
                dgvListaProduto.Visible = False
                lblPesquisarProdutos.Visible = False
                'lblProduto.Visible = False
                ' lblEmEstoque.Visible = False
                PanelProdutos.Visible = False
                btnConfirmarEscolha.Visible = False
                dgvRE.Visible = False
        End Sub

        ''' <summary>
        ''' Pesquisar produtos por palavras chaves
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub txtPesqProduto_TextChanged(sender As Object, e As EventArgs) Handles txtPesqProduto.TextChanged

                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand("SELECT ProdutoID as ID, Produto, SaldoEstoque as Estoque FROM tbProdutoPDV WHERE Produto LIKE '%" & txtPesqProduto.Text & "%'", conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Endereco")
                dgvListaProduto.DataSource = dsbiblio.Tables("Endereco")
                dgvListaProduto.DataSource = dsbiblio.Tables("Endereco")

                With dgvListaProduto
                        .Columns(0).Width = (dgvListaProduto.Width * 10) / 100
                        .Columns(1).Width = (dgvListaProduto.Width * 70) / 100
                        .Columns(2).Width = (dgvListaProduto.Width * 20) / 100
                End With
        End Sub

        ''' <summary>
        ''' Selecionar produtos por codigo de barras (enter usado para informar que o codigo foi inserido)
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' 
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
                AdicionarProduto()
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

        Private Sub btnRE_Click(sender As Object, e As EventArgs)
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

        Private Sub btnAgendarEntrega_Click(sender As Object, e As EventArgs)
                FrmAgendaEntregas.Show()
        End Sub

        Private Sub FrmPDV_Shown(sender As Object, e As EventArgs) Handles Me.Shown
                Dim status As String = FrmSelCaixa.CaixaAtual.Status
                If FrmSelCaixa.CaixaAtual.Status = "FECHADO" Then
                        Me.Close()
                End If
        End Sub

        Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

        End Sub

        Private Sub txtProduto_TextChanged(sender As Object, e As EventArgs) Handles txtProduto.TextChanged
                If txtProduto.Text = "" Then
                        lblProdutoDesc.Visible = True
                Else
                        lblProdutoDesc.Visible = False
                End If
        End Sub

        Private Sub dgvEnd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnd.CellEnter
                txtEndID.Text = dgvEnd.CurrentRow.Cells(0).Value
        End Sub

        Private Sub dgvListaProduto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProduto.CellEnter
                Dim drProduto As OleDbDataReader = GetDR_semRead("SELECT * FROM tbProdutoPDV WHERE ProdutoID=" & dgvListaProduto.CurrentRow.Cells(0).Value)
                drProduto.Read()

                txtProduto.Text = dgvListaProduto.CurrentRow.Cells(1).Value

                On Error Resume Next
                txtProdutoID.Text = drProduto("ProdutoID")
                txtUnidade.Text = drProduto("Unidade")
                txtCusto.Text = Dinheiro(drProduto("Custo"))
                txtCategoriaProduto.Text = drProduto("CategoriaPadrao")
                txtSaldoEstoque.Text = drProduto("SaldoEstoque")
                txtCustoTotal.Text = Dinheiro(drProduto("Custo Total"))
                ProdutoxQuantidade()
        End Sub

        Public Sub ProdutoxQuantidade()
                On Error Resume Next
                txtSoma.Text = Dinheiro(CDbl(txtCustoTotal.Text) * CDbl(txtQuantidade.Text))
        End Sub

        Private Sub dgvListaProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProduto.CellContentClick

        End Sub
End Class