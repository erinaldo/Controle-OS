Imports System.Data.OleDb

Public Class FrmCadastroOS

        Public PorParcela As Double

        '********************************************************************* BOTÕES *****************************************************************************
        Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
                Me.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMunuDown.Click
                ShowMenuAdicionalProduto()
        End Sub

        Private Sub btnMunuUP_Click(sender As Object, e As EventArgs) Handles btnMunuUP.Click
                HideMenuAdicionalProduto()
                '  btnAdicionarProduto.BringToFront()
        End Sub

        '******revisar não existe esse botao
        Private Sub btnGerarOS_Click(sender As Object, e As EventArgs)
                lSQL = "INSERT INTO tbOS (CodCliente,Status,TecResp,DataAbertura,DataAprovacao)" & "VALUES (""" & txtCodCliente.Text & """,""" & txtStatus.Text & """,""" & cboTecResp.Text & """,""" & txtDataAtual.Text & """,""" & txtDataAprovacao.Text & """)"
                SQL.Comando()
                Dim nSQL As String
                nSQL = "Select OSID FROM tbOS Order by OSID DESC"
                objConn.Close()
                objConn.Open()
                Dim objcmd As New OleDbCommand(nSQL, objConn)
                dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
                dr.Read()
                txtOSID.Text = dr.Item("OSID") '\\SELECIONAR UM CAMPO EM ESPECIFICO
                dr.Close()
                dr = Nothing
                objConn.Close()
        End Sub

        Public Sub QuantPedidosVinc()
                Connect.Conectardb("SELECT * FROM tbPedido2Vinc WHERE OSID=" & txtOSID.Text)
                If cdr.HasRows = True Then
                        txtNumeroPedidos.Text = cdr.Item("")
                End If
        End Sub

        '******************************************************************** EVENTOS *****************************************************************************

        Private Sub FrmCadastroOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                CarregarTabelas()
                DefinirAlturaDGV()
                DefinirVisibilidade()
                dgvObservacao.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                limparTexts()
                If IsNumeric(txtOSID.Text) = True Then
                        btnImprimir.Visible = True
                Else
                        btnImprimir.Visible = False
                End If
        End Sub

        Private Sub txtArea_TextChanged(sender As Object, e As EventArgs) Handles txtArea.TextChanged
                If txtArea.Text = "" Then
                        txtTotalMDO.Text = ""
                        txtTotalServico.Text = ""
                Else
                        Try
                                Dim TotalMdo As Double = CDbl(txtUnitMDO.Text) * CDbl(txtArea.Text)
                                txtTotalMDO.Text = Dinheiro(TotalMdo)
                                Dim TotalServico As Double = CDbl(txtServicoUnit.Text) * CDbl(txtArea.Text)
                                txtTotalServico.Text = Dinheiro(TotalServico)
                        Catch
                                MsgBox("Erro no bloco de txtArea")
                        End Try
                End If
        End Sub

        Private Sub txtDescontoDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txtDescontoDinheiro.TextChanged
                If txtTotalServico.Text <> "" Then
                        Dim R, P, Pago As Decimal
                        Try
                                txtTotalServico.Text = (CDec(txtServicoUnit.Text) * CDec(txtArea.Text)) - CDec(txtDescontoDinheiro.Text)
                                Pago = txtDescontoDinheiro.Text
                                P = CDec(txtServicoUnit.Text) * CDec(txtArea.Text)
                                R = P / 100
                                txtDescontoPorcentagem.BackColor = Color.LightBlue
                                txtDescontoDinheiro.BackColor = Color.White
                        Catch
                                MsgBox("erro no bloco de conta do serviço")
                        End Try
                Else
                        txtDescontoDinheiro.Text = ""
                End If
        End Sub

        Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtDescontoPorcentagem.TextChanged
                Dim R, Total As Decimal
                If Me.txtDescontoPorcentagem.Text = "" Then
                        On Error Resume Next
                        txtTotalServico.Text = CDec(txtServicoUnit.Text) * CDec(txtArea.Text)
                Else
                        On Error Resume Next
                        txtTotalServico.Text = (CDec(txtServicoUnit.Text) * CDec(txtArea.Text) * CDec(txtDescontoPorcentagem.Text)) / 100
                End If
        End Sub

        Private Sub cboDescricao_LostFocus(sender As Object, e As EventArgs) Handles cboDescricao.LostFocus
                If cboDescricao.Text = "" Then
                End If
                dgvDescricao.Visible = False
        End Sub

        '//COPIAR VALOR SELECIONADO NO GRIDVIEW DE FILTO DE PRODUTOS
        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescricao.CellContentClick
                Me.cboDescricao.Text = Me.dgvDescricao.SelectedCells(0).Value
                dgvDescricao.Visible = False
        End Sub

        Private Sub txtArea_Click(sender As Object, e As EventArgs) Handles txtArea.Click
                txtArea.BackColor = Color.White
                If cboDescricao.Text = "" Then
                        txtArea.ReadOnly = True
                Else
                        txtArea.ReadOnly = False
                End If
        End Sub

        Private Sub cboDescricao_Click(sender As Object, e As EventArgs) Handles cboDescricao.Click
                txtStatus.BackColor = Color.White
        End Sub

        '*************************************************************** FUNÇÕES E METODOS ************************************************************************

        Private Sub DefinirVisibilidade()
                If txtOSID.Text = "" Then
                        btnImprimir.Visible = False
                Else
                        btnImprimir.Visible = True
                End If
                If txtOSID.Text = "" Then
                        btnMedicoes.Visible = False
                Else
                        btnMedicoes.Visible = True
                End If
        End Sub

        Private Sub DefinirAlturaDGV()
                Me.dgvProdutosAdquiridos.Height = 40 + (Me.dgvProdutosAdquiridos.Rows.Count * 20.5)
                'Me.grpGeral.Location = New Point(25, 390 + (Me.dgvProdutosAdquiridos.Rows.Count * 20.5))
                txtTecResponsavel.Text = cboTecResp.Text
                dgvProdutosAdquiridos.Height = 39
        End Sub

        Private Sub limparTexts()
                cboDescricao.Text = ""
                txtUnidade.Text = ""
                txtArea.Text = ""
                txtServicoUnit.Text = ""
                txtUnitMDO.Text = ""
                cboGesseiro.Text = ""
                txtProdutoID.Text = ""
                cboGesseiro.Text = ""
                txtEndRua.Text = ""
                txtEndNumero.Text = ""
                txtEndBairro.Text = ""
                txtEndCidade.Text = ""
                txtEndUF.Text = ""
                txtEndID.Text = ""
                txtEndCompl.Text = ""
                txtCodCliente.Text = ""
                txtEndContato.Text = ""
                txtCPF.Text = ""
                txtDataAprovacao.Text = ""
                txtIE.Text = ""
                txtTecResponsavel.Text = ""
                txtEndID.Text = ""
        End Sub

        Private Sub CarregarTabelas()
                If txtOSID.Text <> "" Then
                        Dim Para_OSID As New OleDbParameter
                        With Para_OSID
                                .ParameterName = "OSID"
                                .OleDbType = OleDbType.Double
                                .Size = 20
                                .Value = CDbl(txtOSID.Text)
                        End With
                        Dim strConn As String = sConnectionString
                        Dim conexao As New OleDbConnection(strConn)
                        Dim comando As New OleDbCommand("SELECT * FROM tbObservacao WHERE ObservacaoID=?", conexao)
                        comando.Parameters.Add(Para_OSID)
                        Dim adaptador As New OleDbDataAdapter(comando)
                        Dim dsbiblio As New DataSet()
                        adaptador.Fill(dsbiblio, "Cliente")
                        dgvObservacao.DataSource = dsbiblio.Tables("Cliente")
                End If
                Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet1.tbOS)
                Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet.tbGesseiros)
                Me.TbContatoTableAdapter.Fill(Me.SistemaGEDataSet.tbContato)
                Me.TbEndTableAdapter.Fill(Me.SistemaGEDataSet.tbEnd)
                Me.TbProdutos2TableAdapter.Fill(Me.SistemaGEDataSet.tbProdutos2)
                Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
                Me.TbProdutoVendaPDVvincTableAdapter.Fill(Me.DataPdv.tbProdutoVendaPDVvinc)
                Me.TbPedido2vincTableAdapter.Fill(Me.DataPdv.tbPedido2vinc)
                Me.FormaPagamentoTableAdapter.Fill(Me.DataSetX1.FormaPagamento)
                Me.TbFormaPagamentoTableAdapter.Fill(Me.SistemaGEDataSet.tbFormaPagamento)
                If txtOSID.Text <> "" Then
                        Me.DtResumoOSTableAdapter.Fill(Me.DataPdv.dtResumoOS, New System.Nullable(Of Integer)(CType(txtOSID.Text, Integer)))
                End If
        End Sub

        Public Sub ShowMenuAdicionalProduto()
                btnMunuDown.Visible = False
                btnMunuUP.Visible = True
                grpProdutos.Height = 195
        End Sub

        Public Sub HideMenuAdicionalProduto()
                btnMunuDown.Visible = True
                btnMunuUP.Visible = False
                grpProdutos.Height = 77
        End Sub

        Private Sub cboDescricao_GotFocus(sender As Object, e As EventArgs) Handles cboDescricao.GotFocus
                dgvDescricao.Visible = True
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click

                '\\DECLARAÇÕES DE VARIAVEIS********************************************

                Dim ResponsavelItem As String = VerificarResp(cboTecResp, cboGesseiro) '//VARIALVEL NOME DO GESSEIRO RESPONSAVEL PELO ITEM
                Dim nSQL As String 'VARIAVEL PARA COMANDO DO SQL LOCAL

                '//VARIAVEIS PARA STATUS DE ADICIONAL E INICIO
                Dim Produto As String = ProdutoAdicional(txtStatus) ''DEFINIR SE O SERVIÇO NO ORÇAMENTO É ADICIONAL OU INICIAL
                Dim StatusProducao As String = "APROVADO PARA PRODUÇÃO"

                HideMenuAdicionalProduto() 'ESCONDER MENU DE OPÇÃO DO PRODUTO

                '//CONDIÇÃO CASO O PRESTADOR RESPONSÁVEL PELO ITEM ESTEJA VAZIO
                If ContinuarSemGesseiro(cboGesseiro) = False Then
                        GoTo fim
                End If

                '//BLOQUEAR CASO O CAMPO CLIENTE ESTEJA VAZIA
                If cboCliente.Text <> "" Then
                        '//BLOQUEAR CASO O CAMPO STATUS ESTEJA VAZIA
                        Dim Status As String = ""
                        '//BLOQUEAR CASO O CAMPO AREA ESTEJA VAZIA
                        If txtArea.Text <> "" Then
                                '//BLOQUEAR CASO A CAIXA LOCAL ESTEJA VAZIA
                                If txtLocal.Text <> "" Then
                                        '//BLOQUEAR CASO O CAMPO OSID ESTEJA VAZIA
                                        If txtOSID.Text = "" Then
                                                txtDataAtual.Text = Today.ToShortDateString.ToString
                                                With Me.txtStatus
                                                        .Text = "NÃO APROVADO"
                                                        .BackColor = Color.LightYellow
                                                End With
                                                '\\ENVIAR NOTIFICAÇÃO DE ALTERAÇÃO
                                                If txtStatus.Text = "Aprovado" Then
                                                        SaveNoti("A OS número: " & txtOSID.Text & " Foi Alterada")
                                                End If
                                                '//INSERIR INFORMAÇÕES GERAIS DA OS NO BD
                                                lSQL = "INSERT INTO tbOS (CodCliente,Status,TecResp,DataAbertura,NomeCliente,EndCliente)" & "VALUES (""" & txtCodCliente.Text & """,""" &
                                                                txtStatus.Text & """,""" & cboTecResp.Text & """,""" & txtDataAtual.Text & """,""" & cboCliente.Text & """,""" & txtEndID.Text & """)"
                                                SQL.Comando()
                                                '//SELECIONAR NUMERO DE REGISTRO DO ULTIMO REGISTRO SALVO
                                                Connect.Conectardb("SELECT OSID FROM tbOS Order by OSID DESC")
                                                txtOSID.Text = cdr.Item("OSID")
                                                Connect.Desconectardb()
                                                'Log("Abertura da OS " & txtOSID.Text & " do cliente " & cboCliente.Text)
                                                '*******************************************TESTE********************************************************************
                                                '//INSERIR PRODUTOS CASO A OS JÁ ESTEJA ABERTA MAS NÃO APROVADA
                                                If txtStatus.Text = "NÃO APROVADO" Or txtStatus.Text = "" Then
                                                        lSQL = "INSERT INTO tbProdutoVenda (OSID, ProdutoID, Descricao, Quantidade, TotalMDO, TotalServico, Status, Gesseiro, LocalServico, Unidade, Tipo, DataOrdemProducao, StatusProducao)" &
                                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" & Today.ToShortDateString &
                                                                        """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                        SQL.Comando()
                                                End If
                                                '*******************************************TESTE********************************************************************
                                                '\\INSERIR NA TABLELA DE VENDA CASO SEU STATUS SEJA DE "FABRICAÇÃO" e STATUS DA OS SEJA APROVADO
                                                If txtTipoProducao.Text = "FABRICAÇÃO" And txtStatus.Text = "APROVADO" Then
                                                        SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO ADICIONADO COM SUCESSO")

                                                        Connect.Conectardb("SELECT * FROM tbProdutoVenda  WHERE OSID=" & txtOSID.Text & " ORDER BY ID Desc")
                                                        Dim UltimoID = dr.Item("ID")
                                                        Connect.Desconectardb()
                                                        lSQL = "INSERT INTO tbProdutoVenda (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text &
                                                                        """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text & """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text &
                                                                        """,""" & txtTipoProducao.Text & """,""" & Today.ToShortDateString & """,""" & "APROVADO PARA PRODUÇÃO" & """)"
                                                        ' SQL.Comando()
                                                        lSQL = "INSERT INTO tbEntrega (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text &
                                                                        """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text & """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text &
                                                                        """,""" & txtTipoProducao.Text & """,""" & Today.ToShortDateString & """,""" & "APROVADO PARA PRODUÇÃO" & """)"
                                                        'SQL.Comando()
                                                End If
                                                '//INSERIR CASO STATUS DO PRODUTO SEJA FABRICAÇÃO E O DO PRODUTO SEJA NÃO APROVADO
                                                If txtTipoProducao.Text = "FABRICAÇÃO" And txtStatus.Text = "NÃO APROVADO" Then
                                                        lSQL = "INSERT INTO tbProdutoVenda (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                        Today.ToShortDateString.ToString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                        ' SQL.Comando()
                                                End If
                                                '//INSERIR CASO STATUS DO PRODUTO SEJA FABRICAÇÃO E OS SEJA NÃO APROVADO
                                                If txtTipoProducao.Text <> "FABRICAÇÃO" And txtStatus.Text = "NÃO APROVADO" Then
                                                        If txtTipoProducao.Text = "FABRICAÇÃO" And txtStatus.Text = "NÃO APROVADO" Then
                                                                lSQL = "INSERT INTO tbProdutoVenda (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                                "VALUES (""" & txtOSID.Text &
                                                                                """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                                """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                                Today.ToShortDateString.ToString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                                SQL.Comando()
                                                                lSQL = "INSERT INTO tbEntrega (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                                "VALUES (""" & txtOSID.Text &
                                                                                """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                                """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                                Today.ToShortDateString.ToString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                                SQL.Comando()
                                                        End If
                                                        '//DEFINE TODOS OS PRODUTOS COM STATUS "FABRICAÇÃO' COMO "APROVADOS PARA PRODUÇÃO"
                                                        If txtStatus.Text = "Aprovado" Then
                                                                SQL.lSQL = "UPDATE tbProdutoVenda SET StatusProducao= """ & "APROVADO PARA PRODUÇÃO" & """ WHERE OSID=" & txtOSID.Text
                                                                SQL.Comando()
                                                        End If
                                                End If
                                                SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO ADICIONADO COM SUCESSO")
                                                'Log("Produto " & cboDescricao.Text & " ID= " & txtProdutoID.Text & " adicionado")
                                                Dim IDMedicao As Double
                                                '//SELECIONAR NUMERO DE REGISTRO DO ULTIMO REGISTRO SALVO
                                                nSQL = "SELECT ID FROM tbProdutoVenda ORDER by ID Desc"
                                                objConn.Close()
                                                objConn.Open()
                                                Dim objcmdq As New OleDbCommand(nSQL, objConn)
                                                dr = objcmdq.ExecuteReader(CommandBehavior.SingleRow)
                                                dr.Read()
                                                IDMedicao = dr.Item("ID")
                                                'Dim UltimoID = dr.Item("ID")
                                                dr.Close()
                                                dr = Nothing
                                                objConn.Close()
                                                '\\ADICIONAR SERVIÇO PERSONALIZADO A TABELA DE MEDIÇÃO PARA PAGAMENTO
                                                lSQL = "INSERT INTO tbMedicao (OSID,ProdutoID,NomeProduto,NomeGesseiro,LocalExec,AreaPlanejada,TotalMDO,ID,Unidade,TotalServico)" & "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text &
                                                                """,""" & cboDescricao.Text & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtArea.Text & """,""" & txtTotalMDO.Text &
                                                                """,""" & IDMedicao & """,""" & txtUnidade.Text & """,""" & txtTotalServico.Text & """)"
                                                SQL.Comando()
                                                '\\ZERAR CAMPOS APÓS ADICIONAR PRODUTO
                                                txtProdutoID.Text = ""
                                                txtLocal.Text = ""
                                                cboDescricao.Text = ""
                                                txtUnidade.Text = ""
                                                txtArea.Text = ""
                                                txtServicoUnit.Text = ""
                                                txtUnitMDO.Text = ""
                                                txtTotalMDO.Text = ""
                                                txtTotalServico.Text = ""
                                                cboGesseiro.Text = ""
                                        Else
                                                '//INSERIR PRODUTOS CASO A OS JÁ ESTEJA ABERTA E APROVADA
                                                If txtStatus.Text = "APROVADO" Then
                                                        lSQL = "INSERT INTO tbProdutoVenda (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                        Today.ToShortDateString & """,""" & "APROVADO PARA PRODUÇÃO" & """)"
                                                        SQL.Comando()
                                                        lSQL = "INSERT INTO tbEntrega (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                        Today.ToShortDateString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                        SQL.Comando()
                                                End If
                                                '//INSERIR PRODUTOS CASO A OS JÁ ESTEJA ABERTA MAS NÃO APROVADA
                                                If txtStatus.Text = "NÃO APROVADO" Or txtStatus.Text = "" Then
                                                        lSQL = "INSERT INTO tbProdutoVenda (OSID, ProdutoID, Descricao, Quantidade, TotalMDO, TotalServico, Status, Gesseiro, LocalServico, Unidade, Tipo, DataOrdemProducao, StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                        Today.ToShortDateString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                        SQL.Comando()
                                                        '**************************************************************************************************************************
                                                        lSQL = "INSERT INTO tbEntrega (OSID,ProdutoID,Descricao,Quantidade,TotalMDO,TotalServico,Status,Gesseiro,LocalServico,Unidade,Tipo,DataOrdemProducao,StatusProducao)" &
                                                        "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" & cboDescricao.Text & """,""" & txtArea.Text & """ ,""" & txtTotalMDO.Text & """,""" & txtTotalServico.Text &
                                                                        """,""" & Produto & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtUnidade.Text & """,""" & txtTipoProducao.Text & """,""" &
                                                                        Today.ToShortDateString & """,""" & "AGUARDANDO APROVAÇÃO" & """)"
                                                        SQL.Comando()
                                                        '**************************************************************************************************************************
                                                End If
                                                '//SELECIONAR ULTIMO REGISTRO DA OS
                                                SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO ADICIONADO COM SUCESSO")
                                                nSQL = "Select * FROM tbProdutoVenda  WHERE OSID= " & txtOSID.Text & " ORDER BY ID Desc"
                                                objConn.Close()
                                                objConn.Open()
                                                Dim objcmd As New OleDbCommand(nSQL, objConn)
                                                dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
                                                dr.Read()
                                                Dim UltimoID = dr.Item("ID")
                                                dr.Close()
                                                dr = Nothing
                                                objConn.Close()
                                                '\\ADICIONAR PRODUTO PERSONALIZADO A TABELA DE MEDIÇÃO PARA PAGAMENTO
                                                lSQL = "INSERT INTO tbMedicao (OSID,ProdutoID,NomeProduto,NomeGesseiro,LocalExec,AreaPlanejada,TotalMDO,ID,TotalServico)" & "VALUES (""" & txtOSID.Text & """,""" & txtProdutoID.Text & """,""" &
                                                                cboDescricao.Text & """,""" & ResponsavelItem & """,""" & txtLocal.Text & """,""" & txtArea.Text & """,""" & txtTotalMDO.Text & """,""" & UltimoID & """,""" & txtTotalServico.Text & """)"
                                                SQL.Comando()
                                                txtProdutoID.Text = ""
                                                txtLocal.Text = ""
                                                cboDescricao.Text = ""
                                                txtUnidade.Text = ""
                                                txtArea.Text = ""
                                                txtServicoUnit.Text = ""
                                                txtUnitMDO.Text = ""
                                                txtTotalMDO.Text = ""
                                                txtTotalServico.Text = ""
                                                cboGesseiro.Text = ""
                                        End If
                                Else
                                        txtLocal.BackColor = Color.Red
                                        SQL.Notificao("NOVA LITORAL GESSO", "CAMPO (LOCAL) É OBRIGATÓRIO")
                                End If
                        Else
                                SQL.Notificao("NOVA LITORAL GESSO", "O PREENCHIMENTO Do CAMPO (AREA) É OBRIGATÓRIO")
                                txtArea.BackColor = Color.Red
                        End If
                Else
                        SQL.Notificao("NOVA LITORAL GESSO", "O PREENCHIMENTO Do CAMPO (CLIENTE) É OBRIGATÓRIO")
                        cboCliente.BackColor = Color.Red
                End If
                '//TRAZER CONSULTA DE PRODUTOS RELACIONADO A OS "X"
                On Error Resume Next
                Me.TbProdutoVenda1TableAdapter.FillBy(Me.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(txtOSID.Text, Integer)))
                Me.dgvProdutosAdquiridos.Height = 40 + (Me.dgvProdutosAdquiridos.Rows.Count * 20.5)
                '//trazer consulta da soma de MDO e SERVICO
                Me.TbProdutoVenda2TableAdapter.FillByos(Me.SistemaGEDataSet1.tbProdutoVenda2, New System.Nullable(Of Integer)(CType(txtOSID.Text, Integer)))
                dgvProdutosAdquiridos.Height = 40 + (dgvProdutosAdquiridos.Rows.Count * 20.5)
fim:
        End Sub

        'BOTAO
        Private Sub btnPedidoAprovacao_Click(sender As Object, e As EventArgs) Handles btnPedidoAprovacao.Click
                If txtEndRua.Text = "" Then
                        '\\IDENTIFICA SE O CLIENTE SELECIONADO POSSUI ENDEREÇO CADASTRADO CASO NÃO SEJA SELECIONA NO COMBOBOX DE ENDEREÇO
                        SQL.Notificao("NOVA LITORAL GESSO", "NÃO É POSSIVEL APROVAR O ORÇAMENTO SEM SELECIONAR UM ENDEREÇO")
                        Connect.Conectardb("Select * FROM tbEnd WHERE CodEnd=" & txtCodCliente.Text)
                        If cdr.HasRows = False Then
                                Connect.Desconectardb()
                                Dim ResultadoEndereco As DialogResult = MessageBox.Show("O cliente selecionado não possui endereço cadastrado no sistema ,deseja adicionar um agora?", "Nova Litoral Gesso", MessageBoxButtons.YesNo)
                                If ResultadoEndereco = 6 Then
                                        '\\TROCAR BOTÕES DO FORMULARIO DE CADASTRO DE ENDEREÇO
                                        FrmCadastroEndereco.btnCadastroPeloDialogo.Visible = True
                                        FrmCadastroEndereco.btnCadastroPeloFrm.Visible = False
                                        FrmCadastroEndereco.ShowDialog()
                                End If
                                If ResultadoEndereco = 7 Then
                                        SQL.Notificao("NOVA LITORAL GESSO", "NÃO FOI POSSIVEL APROVAR O ORÇAMENTO POR FALTA DE INFORMÇÃO")
                                        GoTo FINAL
                                End If
                        End If
                Else
                        If 1 + 1 = 3 Then
                                SQL.Notificao("NOVA LITORAL GESSO", "NÃO É POSSIVEL APROVAR O ORÇAMENTO SEM SELECIONAR UMA FORMA DE PAGAMENTO")
                                GoTo FINAL
                        Else
                                If txtDataAprovacao.Text = "" Or txtDataAprovacao.Text = "NÃO APROVADO" Then
                                        Dim StatusProducao As String = "APROVADO PARA PRODUÇÃO"
                                        With txtStatus
                                                .Text = "APROVADO"
                                                .BackColor = Color.LightGreen
                                        End With
                                        SQL.Notificao("NOVA LITORAL GESSO", "OS APROVADA COM SUCESSO")
                                        cboCliente.ReadOnly = True
                                        txtDataAprovacao.Text = Today.ToShortDateString
                                        SQL.lSQL = "UPDATE tbOS Set Status=""" & "APROVADO" & """,DataAprovacao=""" & Today.ToShortDateString & """ WHERE OSID=" & txtOSID.Text
                                        SQL.Comando()
                                        SQL.lSQL = "UPDATE tbProdutoVenda Set StatusProducao= """ & StatusProducao & """ WHERE OSID=" & txtOSID.Text & " And StatusProducao=" & """AGUARDANDO APROVAÇÃO"""
                                        SQL.Comando()
                                Else
                                        SQL.Notificao("NOVA LITORAL GESSO", "NÃO É POSSIVEL APROVAR O ORÇAMENTO SEM ADICIONAR UMA FORMA DE PAGAMENTO")
                                End If
                                Me.TbProdutoVenda1TableAdapter.FillBy(Me.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(txtOSID.Text, Integer)))
                                Me.TbProdutos2TableAdapter.Fill(Me.SistemaGEDataSet.tbProdutos2)
                        End If
                End If
FINAL:
        End Sub

        'EVENTO
        Private Sub txtLocal_Click(sender As Object, e As EventArgs) Handles txtLocal.Click
                txtLocal.BackColor = Color.White
        End Sub

        'BOTAO
        Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnCarregarOS.Click
                FrmCarregarOS.ShowDialog()
        End Sub

        '//CARREGAR CONTATO DO CLIENTE SELECIONADO
        Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNomeCliente.CellContentClick
                dgvNomeCliente.Visible = False
        End Sub

        'EVENTO
        Private Sub cboCliente_Click(sender As Object, e As EventArgs) Handles cboCliente.Click
                If txtStatus.Text <> "APROVADO" Then
                        With cboCliente
                                .Text = ""
                                .BackColor = Color.White
                        End With
                        dgvNomeCliente.Visible = True
                Else
                        cboCliente.ReadOnly = True
                End If
        End Sub

        'EVENTO
        Private Sub cboDescricao_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cboDescricao.MouseDoubleClick
                cboDescricao.Text = ""
        End Sub

        'BOTAO
        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
                FrmImpOS.Show()
        End Sub

        '//FILTRAR POR NOME DO PRODUTO
        Private Sub cboDescricao_TextChanged(sender As Object, e As EventArgs) Handles cboDescricao.TextChanged
                Me.TbProdutos2TableAdapter.FillByDescricao(Me.SistemaGEDataSet.tbProdutos2, cboDescricao.Text)
        End Sub

        '//FILTRAR POR NO DO CLIENTE
        Private Sub cboCliente_TextChanged(sender As Object, e As EventArgs) Handles cboCliente.TextChanged
                If txtStatus.Text = "APROVADO" Then
                        cboCliente.ReadOnly = True
                Else
                        Me.TbClientesTableAdapter.FillByNome(Me.SistemaGEDataSet.tbClientes, cboCliente.Text)
                End If
        End Sub

        'EVENTO
        Private Sub TbClientesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbClientesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)
        End Sub

        'EVENTO
        Private Sub txtOSID_TextChanged(sender As Object, e As EventArgs)
                If txtOSID.Text = "" Then
                        btnMedicoes.Visible = False
                        btnImprimir.Visible = False
                Else
                        btnMedicoes.Visible = True
                        btnImprimir.Visible = True
                End If
        End Sub

        'BOTAO
        Private Sub btnMedicoes_Click(sender As Object, e As EventArgs) Handles btnMedicoes.Click
                FrmMedicaoEspecifica.ShowDialog()
                FrmMedicaoEspecifica.WindowState = Windows.Forms.FormWindowState.Maximized
        End Sub

        'EVENTO
        Private Sub FrmCadastroOS_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
                Me.dgvProdutosAdquiridos.Height = 40 + (Me.dgvProdutosAdquiridos.Rows.Count * 20.5)
        End Sub

        'EVENTO
        Private Sub cboTecResp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTecResp.SelectedIndexChanged
                txtTecResponsavel.Text = cboTecResp.Text
        End Sub

        'BOTAO
        Private Sub SalvarToolStripButton1_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbAdicionalPagoBindingSource.EndEdit()
        End Sub

        'BOTAO *************** REVISAR
        Private Sub SalvarTeste_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbOStbInicialPagoBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)
        End Sub

        ' EVENTOS
        Private Sub dgvProdutosAdquiridos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProdutosAdquiridos.CellFormatting
                dgvProdutosAdquiridos.Columns(4).DefaultCellStyle.Format = "c"
                dgvProdutosAdquiridos.Columns(4).ValueType = GetType(Double)
                dgvProdutosAdquiridos.Columns(5).DefaultCellStyle.Format = "c"
                dgvProdutosAdquiridos.Columns(5).ValueType = GetType(Double)
        End Sub

        ' BOTAO
        Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
                FrmEntregaOS.ShowDialog()
        End Sub

        'EVENTO
        Private Sub DataGridView3_MouseLeave(sender As Object, e As EventArgs) Handles dgvNomeCliente.MouseLeave
                dgvNomeCliente.Visible = False
        End Sub

        'EVENTO
        Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNomeCliente.CellClick
                cboCliente.Text = dgvNomeCliente.CurrentRow.Cells(0).Value
                Connect.Conectardb("Select * FROM tbContato WHERE ContatoID=" & txtCodCliente.Text)
                If cdr.HasRows = True Then
                        Me.txtEndContato.Text = cdr.Item("Numero")
                        Connect.Desconectardb()
                Else
                        Me.txtEndContato.Text = ""
                        Connect.Desconectardb()
                End If
        End Sub

        'BOTAO
        Private Sub btnForPagamento_Click(sender As Object, e As EventArgs) Handles btnForPagamento.Click
                If txtOSID.Text <> "" Then
                        FRMFormaPagamentoOS.ShowDialog()
                End If
        End Sub

        'BOTAO
        Private Sub btnVincularPedido_Click(sender As Object, e As EventArgs) Handles btnVincularPedido.Click
                If cboCliente.Text <> "" Then
                        PedidoVinculado = True
                        Dim pac As New PacoteVinculo()
                        pac.Nome = cboCliente.Text
                        pac.CPF = txtCPF.Text
                        If IsNumeric(txtIE.Text) = False Then
                                pac.IE = 0
                        Else
                                pac.IE = txtIE.Text
                        End If
                        If IsNumeric(txtEndContato.Text) Then
                                pac.Contato = txtEndContato.Text
                        Else
                                pac.Contato = 0
                        End If
                        pac.Rua = txtEndRua.Text
                        pac.Numero = txtEndNumero.Text
                        pac.Bairro = txtEndBairro.Text
                        pac.Cidade = txtEndCidade.Text
                        pac.UF = txtEndUF.Text
                        pac.Complemento = txtEndCompl.Text
                        pac.EnderecoId = txtEndID.Text
                        FrmPDV.Show()
                        FrmPDV.WindowState = System.Windows.Forms.FormWindowState.Maximized
                        FrmPDV.txtCliente.Text = pac.Nome
                        FrmPDV.txtCPFCliente.Text = pac.CPF
                        FrmPDV.txtInscEstadual.Text = pac.IE
                        FrmPDV.txtContato.Text = pac.Contato
                        FrmPDV.txtLogradouro.Text = pac.Rua
                        FrmPDV.txtEndNumero.Text = pac.Numero
                        FrmPDV.txtBairro.Text = pac.Bairro
                        FrmPDV.txtCidade.Text = pac.Cidade
                        FrmPDV.txtUF.Text = pac.UF
                        FrmPDV.txtComplemento.Text = pac.Complemento
                        FrmPDV.txtEndID.Text = pac.EnderecoId
                Else
                        MsgBox("É preciso adicionar um cliente antes de vincular um pedido")
                End If
        End Sub

        'EVENTO
        Private Sub dgvProdutosAdquiridos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutosAdquiridos.CellDoubleClick
                On Error Resume Next
                FrmEditProduto.txtProdutoID.Text = dgvProdutosAdquiridos.CurrentRow.Cells(0).Value
                FrmEditProduto.txtLocal.Text = dgvProdutosAdquiridos.CurrentRow.Cells(2).Value
                FrmEditProduto.cboDescricao.Text = dgvProdutosAdquiridos.CurrentRow.Cells(1).Value
                FrmEditProduto.txtUnidade.Text = dgvProdutosAdquiridos.CurrentRow.Cells(8).Value
                FrmEditProduto.txtTotalServico.Text = dgvProdutosAdquiridos.CurrentRow.Cells(5).Value
                FrmEditProduto.txtArea.Text = dgvProdutosAdquiridos.CurrentRow.Cells(3).Value
                FrmEditProduto.txtTotalMDO.Text = dgvProdutosAdquiridos.CurrentRow.Cells(4).Value
                FrmEditProduto.txtTipoProduto.Text = dgvProdutosAdquiridos.CurrentRow.Cells(9).Value
                If dgvProdutosAdquiridos.CurrentRow.Cells(7).Value = "" Then
                        GoTo LINE5
                End If
                FrmEditProduto.cboGesseiro.Text = dgvProdutosAdquiridos.CurrentRow.Cells(6).Value
LINE5:
                FrmEditProduto.txtStatus.Text = dgvProdutosAdquiridos.CurrentRow.Cells(7).Value
                FrmEditProduto.ShowDialog()
        End Sub

        'EVENTO
        Private Sub cboCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCliente.KeyDown
                If e.KeyCode = Keys.Enter Then

                        cboCliente.Text = dgvNomeCliente.CurrentRow.Cells(0).Value
                        dgvNomeCliente.Visible = False
                End If
        End Sub

        'FUNÇÃO
        Private Sub PopularMaterial()
                Dim consulta As String = ""
                Try
                        Connect.Conectardb("SELECT * FROM tbPedido WHERE OSID=" & txtOSID.Text)
                Catch erro As Exception
                        System.Windows.Forms.MessageBox.Show(erro.Message)
                End Try
                Try
                        Me.TbProdutoVendaPDVvinc1TableAdapter.Fill(Me.DataPdv.tbProdutoVendaPDVvinc1, New System.Nullable(Of Integer)(CType(2, Integer)))
                Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
        End Sub

        'BOTAO
        Private Sub Button1_Click_2(sender As Object, e As EventArgs)
                PopularMaterial()
        End Sub

        'EVENTO
        Private Sub cboDescricao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDescricao.KeyDown
                If e.KeyCode = Keys.Enter Then
                        cboDescricao.Text = dgvDescricao.CurrentRow.Cells(0).Value
                        dgvDescricao.Visible = False
                End If
        End Sub

        'FUNÇÃO
        Public Sub SomaPedido()
                Dim soma As Double
                If txtOSID.Text <> "" Then
                        Connect.Conectardb("SELECT SUM(tbProdutoVendaPDVvinc.Soma) AS TotalPedidos FROM (tbProdutoVendaPDVvinc" &
                           " INNER JOIN tbPedido2vinc ON tbProdutoVendaPDVvinc.PedidoID" &
                           " = tbPedido2vinc.PedidoID) GROUP BY tbPedido2vinc.OSID HAVING (tbPedido2vinc.OSID = " & txtOSID.Text & ")")
                        If cdr.HasRows = True Then

                                soma = cdr.Item("TotalPedidos")
                                txtTotalProdutos.Text = ("R$ " & soma)
                        End If
                        Connect.Desconectardb()
                End If
        End Sub

        'BOTAO
        Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Button1.Click
                SomaPedido()
        End Sub

        Private Sub txtLocal_LostFocus(sender As Object, e As EventArgs) Handles txtLocal.LostFocus
                txtLocal.Text = txtLocal.Text.ToUpper
        End Sub

        Private Sub btnResumoDesing_Click(sender As Object, e As EventArgs) Handles btnResumoDesing.Click
                FrmResumoComodo.Show()
        End Sub

        Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
                If txtOSID.Text <> "" Then
                        If txtObservacao.Text <> "" Then
                                InserirObservacao()
                                CarregarTabelas()
                                txtObservacao.Text = ""
                                SQL.Notificao("", "Observação inserida com sucesso")
                        Else
                                SQL.Notificao("", "Campo de Observação pode esta vazio")
                        End If
                Else
                        SQL.Notificao("", "A OS  não foi aberta")
                End If
        End Sub

        Public Sub InserirObservacao()
                Observacao.DescricaoID = txtOSID.Text
                Observacao.Descricao = txtObservacao.Text
                Observacao.Data = Today.ToShortDateString
                Dim Para_DescricaoID As New OleDbParameter
                With Para_DescricaoID
                        .ParameterName = "DescricaoID"
                        .OleDbType = OleDbType.Double
                        .Size = 10
                        .Value = Observacao.DescricaoID
                End With
                Dim para_Descricao As New OleDbParameter
                With para_Descricao
                        .ParameterName = "Descricao"
                        .OleDbType = OleDbType.Char
                        .Size = 200
                        .Value = Observacao.Descricao
                End With
                Dim para_Data As New OleDbParameter
                With para_Data
                        .ParameterName = "DataObservacao"
                        .OleDbType = OleDbType.Date
                        .Size = 20
                        .Value = Today.ToShortDateString
                End With
                Dim consulta As String = "INSERT INTO tbObservacao (ObservacaoID,Observacao,Data)" & "VALUES(?,?,?)"
                Dim objInicio As New OleDbConnection(sConnectionString)
                If objInicio.State = ConnectionState.Closed Then
                        objInicio.Open()
                End If
                Dim objcmd As New OleDbCommand(consulta, objInicio)

                'INSERIR O PAAMETO COM O NOME DO USUARIO e SENHA
                With objcmd.Parameters
                        .Add(Para_DescricaoID)
                        .Add(para_Descricao)
                        .Add(para_Data)
                End With
                Dim cdr As OleDbDataReader = objcmd.ExecuteReader()

                'FECHAR CONEXAO E LIMPAR MEMORIA
                objcmd.Parameters.Clear()
                objcmd = Nothing
                objInicio.Close()
                consulta = ""
                cdr.Close()
        End Sub

        Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
                ExcluirObservacao()
                CarregarTabelas()
        End Sub

        Public Sub ExcluirObservacao()
                If txtOSID.Text <> "" Then
                        If IsNothing(dgvObservacao.CurrentRow.Cells(0).Value) = True Then
                                Dim Para_Observacao As New OleDbParameter
                                With Para_Observacao
                                        .ParameterName = "Para_Observacao"
                                        .OleDbType = OleDbType.Char
                                        .Size = 255
                                        .Value = dgvObservacao.CurrentRow.Cells(0).Value
                                End With
                                Dim consulta As String = "DELETE FROM tbObservacao WHERE Observacao=?"
                                Dim objInicio As New OleDbConnection(sConnectionString)
                                If objInicio.State = ConnectionState.Closed Then
                                        objInicio.Open()
                                End If
                                Dim objcmd As New OleDbCommand(consulta, objInicio)

                                'INSERIR O PAAMETO COM O NOME DO USUARIO e SENHA
                                With objcmd.Parameters
                                        .Add(Para_Observacao)
                                End With
                                Dim cdr As OleDbDataReader = objcmd.ExecuteReader()

                                'FECHAR CONEXAO E LIMPAR MEMORIA
                                objcmd.Parameters.Clear()
                                objcmd = Nothing
                                objInicio.Close()
                                consulta = ""
                                cdr.Close()
                        Else
                                SQL.Notificao("", "Nenhum registro foi selecionado")
                        End If
                Else
                        SQL.Notificao("", "A OS  não foi aberta")
                End If
        End Sub

        Private Sub btnEndCliente_Click(sender As Object, e As EventArgs) Handles btnEndCliente.Click
                If txtStatus.Text <> "APROVADO" Then
                        If txtCodCliente.Text <> "" Then
                                Dim Para_CodEnd As New OleDbParameter
                                With Para_CodEnd
                                        .ParameterName = "CodigoCliente"
                                        .OleDbType = OleDbType.Double
                                        .Size = 20
                                        .Value = txtCodCliente.Text
                                End With
                                Dim strConn As String = sConnectionString
                                Dim conexao As New OleDbConnection(strConn)
                                Dim comando As New OleDbCommand("SELECT Logradouro, EndNumero as Numero, Bairro, Cidade, UF, Complemento, Tipo as Descricao,CodEnd as ID FROM tbEnd WHERE CodEnd=?", conexao)
                                comando.Parameters.Add(Para_CodEnd)
                                Dim adaptador As New OleDbDataAdapter(comando)
                                Dim dsbiblio As New DataSet()
                                adaptador.Fill(dsbiblio, "Cliente")
                                dgvEndCliente.DataSource = dsbiblio.Tables("Cliente")
                                dgvEndCliente.Visible = True
                        End If
                Else
                        SQL.Notificao("", "Não é possivel alterar o endereço pois a OS já foi aprovada")

                End If
        End Sub

        Private Sub dgvEndCliente_MouseLeave(sender As Object, e As EventArgs) Handles dgvEndCliente.MouseLeave
                dgvEndCliente.Visible = False
        End Sub

        Private Sub dgvEndCliente_Click(sender As Object, e As EventArgs) Handles dgvEndCliente.Click
                Dim logradouro, Bairro, Cidade, uf, complemento, tipo, EndDescricao As String
                Dim EndNumero, Numero As Double
                Dim EndID As Integer
                logradouro = dgvEndCliente.CurrentRow.Cells(0).Value
                Numero = dgvEndCliente.CurrentRow.Cells(1).Value
                Bairro = dgvEndCliente.CurrentRow.Cells(2).Value
                Cidade = dgvEndCliente.CurrentRow.Cells(3).Value
                uf = dgvEndCliente.CurrentRow.Cells(4).Value
                On Error Resume Next
                complemento = dgvEndCliente.CurrentRow.Cells(5).Value
                EndID = dgvDescricao.CurrentRow.Cells(7).Value
                txtEndRua.Text = logradouro
                txtEndNumero.Text = Numero
                txtEndBairro.Text = Bairro
                txtEndCidade.Text = Cidade
                txtEndUF.Text = uf
                txtEndCompl.Text = complemento
                txtEndID.Text = EndID
        End Sub

End Class