Imports System.Data.OleDb
Module modGeral

        ''' <summary>
        ''' FECHAR FORMULARIO (POSSIVELMENTE ADICONAR CONFIRMAÇÃO)
        ''' </summary>
        ''' <param name="Formulario"></param>
        Public Sub FecharFrmConfirmacao(Formulario As Form)
                Dim Resp As DialogResult = MsgBox("Deseja realmente fechar?", MsgBoxStyle.YesNo, "CONFIRMAR FECHAMENTO")
                If Resp = DialogResult.Yes Then
                        Formulario.Close()
                End If
        End Sub
        ''' <summary>
        ''' FUNÇÃO PARA TRANSFORMAR VALOR PARA DINHEIRO COM (R$)
        ''' </summary>
        ''' <param name="valor">Valor as ser convertido</param>
        ''' <returns>R$ 0,00</returns>
        Public Function Dinheiro(valor As String)
                If IsNumeric(valor) = True Then
                        Return "R$ " & FormatNumber(valor, 2)
                Else
                        SQL.Notificao("", "O valor Inserido não é numerico")
                        Return 0
                End If
        End Function
        ''' <summary>
        ''' DEFINIR QUE SERA O RESPONSAVEL INICIAL PELO SERVICO ABERTO NO ORÇAMENTO
        ''' </summary>
        ''' <param name="txtResponsavel"></param>
        ''' <param name="txtGesseiro"></param>
        ''' <returns></returns>
        Public Function VerificarResp(txtResponsavel As ComboBox, txtGesseiro As ComboBox) ' retirar essa função
                Select Case txtGesseiro.Text
                        Case = ""
                                Return txtResponsavel.Text

                        Case <> ""
                                Return txtGesseiro.Text

                        Case Else
                                MsgBox("Ha um possivel erro ")
                End Select
        End Function
        'DEFINIR SE O SERVIÇO NO ORÇAMENTO É ADICIONAL OU INICIAL
        Public Function ProdutoAdicional(Status As TextBox)  ' retirar essa função
                Select Case Status.Text
                        Case = "APROVADO"
                                Return "Adicional"

                        Case = "NÃO APROVADO"
                                Return "Inicio"

                        Case Else
                                MsgBox("POSSIVEL ERRO NO NOME DO STATUS DO ORÇAMENTO")
                End Select
        End Function
        Public Function ContinuarSemGesseiro(gesseiro As ComboBox)  ' retirar essa função
                Dim Resposta As DialogResult
                Select Case gesseiro.Text
                        Case = ""
                                Resposta = (MsgBox("Não foi definido um responsável para o serviço. Deseja Continuar com o nome do responsável pela " &
                                "OS?", vbYesNo, "Nome do programa"))
                                Select Case Resposta
                                        Case = 7
                                                Return False
                                        Case Else
                                                Return True
                                End Select
                        Case <> ""
                                Return True
                        Case Else
                End Select
        End Function
        Public Sub Caixa(DesCaixa As String, Valor As Double, Operacao As String) ' ver pra que serve essa função
                Dim ValorAtual As Double
                Dim NovoValor As Double
                Connect.Conectardb("SELECT * FROM tbCaixa WHERE DescCaixa='" & DesCaixa & "'")
                ValorAtual = cdr.Item("Valor")
                Connect.Desconectardb()
                Select Case Operacao
                        Case "Receita"
                                NovoValor = ValorAtual + Valor
                        Case "Despesa"
                                NovoValor = ValorAtual - Valor
                        Case Else
                                MsgBox("Operação não reconhecida (Receita/Despesa")
                End Select
                InstrucaoDireta("UPDATE tbCaixa SET Valor = """ & NovoValor & """ WHERE (DescCaixa = '" & DesCaixa & "')")
        End Sub
        ''' <summary>
        ''' TOTAL DE CONTAS A RECEBER QUE ESTÃO EM ATRASO
        ''' </summary>
        ''' <returns></returns>
        Public Function RecebimentoAtraso() ' mudar para outro modulo
                Dim RecebAtraso As Double = 0
                Dim Hoje As Date = Today
                Dim HojeConver = Hoje.ToString("dd'/'MM'/'yyyy")
                conexao1("SELECT * FROM tbFinanceiro WHERE Tipo='Receita' And Situacao='Não Pago' And Vencimento>" & HojeConver)
                While bdr1.Read
                        RecebAtraso += 1
                End While
                Return RecebAtraso
        End Function
        ''' <summary>
        ''' TOTAL DE CONTAS A PAGAR QUE ESTÃO EM ATRASO
        ''' </summary>
        ''' <returns></returns>
        Public Function PagamentoAtraso()  ' mudar para outro modulo
                Dim RecebAtraso As Double = 0
                Dim Hoje As Date = Today
                Dim HojeConver = Hoje.ToString("dd'/'MM'/'yyyy")
                Dim PagAtraso As Double = 0
                conexao1("SELECT * FROM tbFinanceiro WHERE Tipo='Despesa' AND Situacao='Não Pago' AND Vencimento<#" & Today & "#")
                If bdr1.HasRows = True Then
                        While bdr1.Read
                                ' MsgBox(bdr1("Identificacao"))
                                PagAtraso += 1
                        End While
                        Return PagAtraso
                Else
                        Return 0
                End If
        End Function
        Public Sub AtualizarGDVfinanceiro() ' mudar para outro modulo
                'ATUALIZAR DGV DOS LANÇAMENTOS
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(FrmNovoLancamento.ConsultaFiltro, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                FrmNovoLancamento.dgvFinanceiro.DataSource = dsbiblio.Tables("Cliente")
                'SQL.Notificao("", "Sua Pesquisa Retornou " & FrmNovoLancamento.dgvFinanceiro.Rows.Count.ToString & " resultados")
                comando.Dispose()
                conexao.Dispose()
                adaptador.Dispose()
                dsbiblio.Dispose()
        End Sub
        ''' <summary>
        ''' Movimentação Financeira
        ''' </summary>
        ''' <param name="Descricao"></param>
        ''' <param name="Valor"></param>
        ''' <param name="TipoMov"></param>
        ''' <param name="LancamentoID"></param>
        ''' <returns></returns>
        Public Sub MovimentaoFinanceira(ByVal Descricao As String, ByVal Valor As Double, ByVal TipoMov As String, ByVal LancamentoID As Double)
                Dim objconnection As New OleDbConnection(sConnectionString)
                If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                End If
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim InstrucaoSQL As String = "INSERT INTO tbMovFinan(Data,Hora,Usuario,Descricao,ValorMov,TipoMov,LancaID)" & " VALUES(""" & Today.ToShortDateString & """,""" & TimeOfDay.ToShortTimeString & """,""" & Usuario.Nome &
                                        """,""" & Descricao & """,""" & Valor & """,""" & TipoMov & """,""" & LancamentoID & """)"
                Dim objcmd As New OleDbCommand(InstrucaoSQL, objconnection)
                da = objcmd.ExecuteReader()
                da.Read()
                da.Close()
                objcmd.Dispose()
                objconnection.Dispose()
                InstrucaoSQL = Nothing
                conexao.Dispose()
        End Sub
        ''' <summary>
        '''  Obter dados DR diretamente no datagrid
        ''' </summary>
        ''' <param name="ContatoID">Número de identificação do cliente</param>
        ''' <returns></returns>
        Public Function GetContatos(ByVal ContatoID As Double)
                Dim consulta As String = "SELECT * FROM tbContato WHERE ContatoID=" & ContatoID
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                Return dsbiblio.Tables("Cliente")
        End Function

        ''' <summary>
        ''' Obter dados DR diretamento para o datagrid
        ''' </summary>
        ''' <param name="Instrucao"></param>
        ''' <returns></returns>
        Public Function GetDR_Datagridview(ByVal Instrucao As String)
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Instrucao, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                Return dsbiblio.Tables("Cliente")
                conexao.Close()
                adaptador.Dispose()
                conexao.Dispose()
        End Function
        ''' <summary>
        '''  DEFINIR TEXTBOX COM LETRA MAIUSCULA
        ''' </summary>
        ''' <param name="Textbox"></param>
        ''' <returns></returns>
        Public Function Maiuscula(ByVal Textbox As TextBox)
                Textbox.Text = Textbox.Text.ToUpper
                Return Textbox.Text
        End Function
        ''' <summary>
        ''' MUDAR MOUSE ATUAL ENQUANTO CARREGA A BARRA
        ''' </summary>
        ''' <param name="Valor"></param>
        Public Sub Progresso(ByVal Valor As Double)
                FrmMdiHome.UseWaitCursor = True
                FrmMdiHome.pbStatus.Value = Valor
                FrmMdiHome.UseWaitCursor = False
        End Sub
        ''' <summary>
        ''' ANIMAÇÃO DAS TEXTBOX's
        ''' </summary>
        ''' <param name="Progresso"></param>
        Public Sub AnimarText(ByVal Progresso As ProgressBar)
                Dim C As Integer
                While C <= 90
                        C += 5
                        Progresso.Value = C
                        System.Threading.Thread.Sleep(10)
                End While
                Progresso.Value = 100
        End Sub
        ''' <summary>
        ''' ANIMAÇÃO DO DOCKPANEL
        ''' </summary>
        ''' <param name="acao"></param>
        ''' <param name="Dock"></param>
        ''' <param name="min"></param>
        ''' <param name="max"></param>
        ''' <returns></returns>
        Public Function DockShowHide(ByVal acao As String, ByVal Dock As Panel, ByVal min As Double, ByVal max As Double)
                Select Case acao
                        Case "show"
                                Dock.Width = max
                        Case "hide"
                                Dock.Width = min
                        Case Else
                End Select
        End Function
        ''' <summary>
        ''' PREENCHER COMBOBOX
        ''' </summary>
        ''' <param name="Combobox"></param>
        ''' <param name="Instrucao"></param>
        ''' <returns></returns>
        Public Function GetDataCombo(Combobox As ComboBox, Instrucao As String)
                Combobox.Items.Clear()
                conexao1(Instrucao)
                While bdr1.Read
                        Combobox.Items.Add(bdr1.Item(0))
                End While
                Desconexao1()
        End Function

        'VERIFICAR O ID DO ESTOQUE
        Public Function GetEstoqueID(NomeEstoque As String)
                If NomeEstoque <> "" Then
                        conexao1("SELECT EstoqueID,Nome FROM tbEstoque WHERE Nome='" & NomeEstoque & "'")
                        bdr1.Read()
                        If bdr1.HasRows = True Then
                                Return bdr1.Item("EstoqueID")
                        Else
                                MsgBox("Esse estoque não está Cadastrado")
                        End If
                End If
        End Function

        'VERIFICAR O ID DO ESTOQUE
        Public Function GetProdutoID(NomeProduto As String)
                If NomeProduto <> "" Then
                        conexao1("SELECT ProdutoID FROM tbProdutoPDV WHERE Produto='" & NomeProduto & "'")
                        bdr1.Read()
                        If bdr1.HasRows = True Then
                                Return bdr1.Item("ProdutoID")
                        Else
                                MsgBox("Esse estoque não está Cadastrado")
                        End If
                End If
        End Function

        'INSERIR PRODUTO PDV
        Public Function PutProdutoPDV(NomeProduto As String, Unidade As String, SaldoEstoque As Double, Custo As Double, ValorMDO As Double, CategoriaPadrao As String, Estoque As String)
                Dim EstoqueID As Integer = GetEstoqueID(Estoque)
                InstrucaoDireta("INSERT INTO tbProdutoPDV (Produto,Unidade,SaldoEstoque,Custo,ValorMDO,CategoriaPadrao,Estoque)" & "VALUES (""" & NomeProduto & """,""" & Unidade &
                """,""" & SaldoEstoque & """,""" & Custo & """,""" & ValorMDO &
                """,""" & CategoriaPadrao & """,""" & EstoqueID & """)")
        End Function

        'INSERIR CODIGO DE BARRAS PARA UM PRODUTO
        Public Function PutCodBarras(lista As List(Of Double), ProdutoID As Integer)
                For Each item In lista
                        InstrucaoDireta("INSERT INTO tbCodBarras(ProdutoID,CodBarra)" & "VALUES(""" &
                        ProdutoID & """,""" & item & """)")
                Next
        End Function

        'RETORNAR UM DR SEM READ()
        Public Function GetDR_semRead(Instrucao As String)
                conexao1(Instrucao)
                Return bdr1
                '' Desconexao2()
        End Function

        'RETORNAR UM DR COM READ()
        Public Function GetDR_comRead(Instrucao As String)
                conexao2(Instrucao)
                bdr1.Read()
                Return bdr1
                '         Desconexao1()
        End Function
End Module