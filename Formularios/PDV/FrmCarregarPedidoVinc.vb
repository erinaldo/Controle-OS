Imports System.Data.OleDb

Public Class FrmCarregarPedidoVinc

    Private Sub FrmCarregarPedidoVinc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbPedido2vincTableAdapter.PorOS(Me.DataPdv.tbPedido2vinc, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  CarregarPedido()

        Dim Para_PedidoID As New OleDbParameter
        With Para_PedidoID
            .ParameterName = "PedidoID"
            .DbType = DbType.String
            .Size = 10
            .Value = txtPedidoID.Text
        End With

        Dim strConn As String = sConnectionString
        Dim conexao As New OleDbConnection(strConn)
        Dim comando As New OleDbCommand("SELECT * FROM tbProdutoVendaPDVvinc WHERE PedidoID=?", conexao)
        comando.Parameters.Add(Para_PedidoID)
        Dim adaptador As New OleDbDataAdapter(comando)
        Dim dsbiblio As New DataSet()
        adaptador.Fill(dsbiblio, "Cliente")
        FrmPDV.dgvProdutosVinc.DataSource = dsbiblio.Tables("Cliente")
        SQL.Notificao("", "Sua Pesquisa Retornou " & FrmPDV.dgvProdutosVinc.Rows.Count.ToString & " resultados")

        FrmPDV.dgvProdutosVinc.Visible = True

        FrmPDV.dgvProdutosVinc.Height = 22 + (FrmPDV.dgvProdutosVinc.Rows.Count * 24)
        FrmPDV.dgvProdutosVinc.Height = 22 + (FrmPDV.dgvProdutosVinc.Rows.Count * 24)

        Me.Close()

    End Sub

    Public Sub CarregarPedido()

        If txtPedidoID.Text <> "" Then
            FrmPDV.TbProdutoVendaPDVTableAdapter.FillByPedidoID(FrmPDV.DataPdv1.tbProdutoVendaPDV, New System.Nullable(Of Integer)(CType(txtPedidoID.Text, Integer)))
            '\\Conexão com o Banco de dados
            Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & txtPedidoID.Text)

            '\\RECUPERAR INFORMAÇÕES DIRETAS SOBRE O PEDIDO
            On Error Resume Next
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

            Dim Logradouro As String = cdr.Item("Logradouro")
            Dim EndNumero As Double = cdr.Item("EndNumero")
            Dim Bairro As String = cdr.Item("Bairro")
            Dim Cidade As String = cdr.Item("Cidade")
            Dim UF As String = cdr.Item("UF")
            Dim Complemento As String = cdr.Item("Complemento")
            Dim Tipo As String = cdr.Item("Tipo")
            Connect.Desconectardb()

            Connect.Conectardb("SELECT * FROM tbClientes WHERE Código=" & txtClienteID.Text)

            '\\VARIAVEIS DE RETORNO DA CONSULTA DE ENDEREÇO DO CLIENTE

            Dim NomeCliente As String = cdr.Item("Nome")
            Dim CPF As String = cdr.Item("CPF")
            Dim InscEstadual As Double = cdr.Item("InscricaoEstadual")

            With FrmPDV
                '\\ENDEREÇO =====
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

            'Log("Carregado o Pedido " & txtPedidoID.Text)

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

    End Sub

    Private Sub TbPedido2vincDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbPedido2vincDataGridView.CellContentClick

    End Sub

    Private Sub TbPedido2vincDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbPedido2vincDataGridView.CellClick
        txtPedidoID.Text = TbPedido2vincDataGridView.CurrentRow.Cells(0).Value
        txtClienteID.Text = TbPedido2vincDataGridView.CurrentRow.Cells(1).Value
    End Sub

End Class