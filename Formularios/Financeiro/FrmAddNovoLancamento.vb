Imports System.Data.OleDb

Public Class FrmAddNovoLancamento

        Public PeriodoPag As String
        Public SituacaoPag As String
        Public PossuiEntrada As Boolean
        Public ValorEntrada As Double
        Public TipoLancamento As String
        Public NParcela As String
        Public PlanoConta As String
        Public firstTipoLancamento As Boolean = False
        Public focus As String

        Private Sub FrmAddNovoLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                rdColaborador.BringToFront()
                rdFisica.BringToFront()
                CarregarTables()
                cboFormaPag.Items.Clear()
                conexao1("SELECT FormaPagamento FROM tbFormaPagamento")
                While bdr1.Read
                        cboFormaPag.Items.Add(bdr1(0).ToString.ToUpper)
                End While
                lblValorFormat.Text = ""
                txtDataInicial.Text = Today.ToShortDateString
                dtpDataLancamento.Text = Today.ToShortDateString
                dtpDataVencimento.Text = Today.ToShortDateString
                btnParcelado.BackColor = Color.Gray
                btnAvista.BackColor = Color.Gray
                btnSemEntrada.BackColor = Color.Gray
                btnComEntrada.BackColor = Color.Gray
                Limpar()
                'A TABELA "COLABORADOR" NÃO ESTÁ SENDO USADO , UMA UNICA TABELA CONTEM TODAS A PESSOAS
                rdColaborador.Visible = False
                rdFisica.Checked = True
                rdFisica.Visible = False



                GetData("SELECT Nome,Sobrenome,CPF,Tipo FROM tbClientes", dgvListaClientes)
                cboTipoPessoa.Text = "Todos"
        End Sub

        Private Sub btnAvançar_Click(sender As Object, e As EventArgs) Handles btnAvançar1.Click
                If VerInfoCliente(txtNome, txtCPF) = True Then
                        grp1.Visible = False
                        grp2.Visible = True
                        grp2.BringToFront()
                        btnPasso1.BackColor = Color.Green
                        lstResumo.Items.Add("Nome: " & txtNome.Text & " CPF: " & txtCPF.Text)
                        lstResumo.Items.Add("----------------------------------------------")
                Else
                        MsgBox("Revise as informações")
                End If
        End Sub

        Private Sub btnAvançar2_Click(sender As Object, e As EventArgs) Handles btnAvançar2.Click
                If IsNumeric(txtValor.Text) = True Then
                        If txtValor.Text > 0 Then
                                grp2.Visible = False
                                grp3.Visible = True
                                btnPasso2.BackColor = Color.Green
                                ' lstResumo.Items.Add("Valor Total: R$ " & FormatNumber(txtValor.Text, 2))
                                lstResumo.Items.Add("Valor Total: " & Dinheiro(CDbl(txtValor.Text)))
                        Else
                                MsgBox("Valor Invalido")
                        End If
                Else
                        MsgBox("o valor nao é um numero")
                End If
        End Sub

        Private Sub btnAvançar3_Click(sender As Object, e As EventArgs) Handles btnAvançar3.Click
                If cboFormaPag.Text <> "" Then
                        grp3.Visible = False
                        grp4.Visible = True
                        btnPasso3.BackColor = Color.Green
                        lstResumo.Items.Add("Forma de Pagamento: " & cboFormaPag.Text)
                Else
                        MsgBox("Valor Invalido")
                End If
        End Sub

        Private Sub btnbtnAvançar4_Click(sender As Object, e As EventArgs) Handles btnbtnAvançar4.Click
                Select Case PeriodoPag
                        Case "Avista"
                                grpAvista.Visible = True
                        Case "Parcelado"
                                grpParcelado.Visible = True
                End Select
                btnPasso4.BackColor = Color.Green
                grp4.Visible = False
                lstResumo.Items.Add("Periodo de Pagamento: " & PeriodoPag)
        End Sub

        Private Sub btnSemEntrada_Click(sender As Object, e As EventArgs) Handles btnSemEntrada.Click
                btnSemEntrada.BackColor = Color.Green
                btnComEntrada.BackColor = Color.Gray
                lblValorEntrada.Visible = False
                txtValorEntrada.Visible = False
                PossuiEntrada = False
        End Sub

        Private Sub btnComEntrada_Click(sender As Object, e As EventArgs) Handles btnComEntrada.Click
                btnSemEntrada.BackColor = Color.Gray
                btnComEntrada.BackColor = Color.Green
                lblValorEntrada.Visible = True
                txtValorEntrada.Visible = True
                PossuiEntrada = True
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
                If btnSemEntrada.BackColor = Color.Green Then
                        ValorEntrada = 0
                        txtValorEntrada.Text = 0
                End If
                If IsNumeric(txtValorEntrada.Text) = True Then
                        ValorEntrada = txtValorEntrada.Text
                        Dim entrada As String
                        If PossuiEntrada = True Then
                                entrada = "Possui Entrada de "
                        Else
                                ValorEntrada = 0
                                entrada = "Não possui entrada  "
                        End If
                        lstResumo.Items.Add(entrada & FormatNumber(ValorEntrada, 2))
                        lblValorParcelar.Text = "Valor R$ " & FormatNumber(txtValor.Text - ValorEntrada, 2)
                Else
                        MsgBox("Valor de entrada não é valido")
                End If
                grpParcelado.Visible = False
                grpModoParcelamento.Visible = True
        End Sub

        Private Sub btnDespesa_Click(sender As Object, e As EventArgs) Handles btnDespesa.Click
                btnDespesa.BackColor = Color.Green
                btnReceita.BackColor = Color.Gray
                TipoLancamento = "Despesa"
        End Sub

        Private Sub btnReceita_Click(sender As Object, e As EventArgs) Handles btnReceita.Click
                TipoLancamento = "Receita"
                btnDespesa.BackColor = Color.Gray
                btnReceita.BackColor = Color.Green
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
                NParcela = cboNParcelas.Text
                grpModoParcelamento.Visible = False
                grp6.Visible = True
                btnPasso5.BackColor = Color.Green
                btnPasso6.BackColor = Color.Green
                lstResumo.Items.Add("Número de Parcelas: " & cboNParcelas.Text)
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
                btnPasso7.BackColor = Color.Green
                grp6.Visible = False
                grp7.Visible = True
                lstResumo.Items.Add("Tipo de Lançamento: " & TipoLancamento)
        End Sub

        Private Sub cboPlanoConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlanoConta.SelectedIndexChanged
                PlanoConta = cboPlanoConta.Text
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
                grpFinal.Visible = True
                grp7.Visible = False
                btnPasso8.BackColor = Color.Green
                lstResumo.Items.Add("Plano de Contas: " & PlanoConta)
        End Sub

        Private Sub btnDefinirPago_Click(sender As Object, e As EventArgs) Handles btnDefinirPago.Click
                SituacaoPag = "Foi Pago"
                btnDefinirPago.BackColor = Color.Purple
                btnDefinirNPago.BackColor = Color.Gray
        End Sub

        Private Sub btnDefinirNPago_Click(sender As Object, e As EventArgs) Handles btnDefinirNPago.Click
                SituacaoPag = "Não Pago"
                btnDefinirPago.BackColor = Color.Gray
                btnDefinirNPago.BackColor = Color.Purple
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
                lstResumo.Items.Add("Situação de Pagamento: " & SituacaoPag)
                grpAvista.Visible = False
                grp8.Visible = True
                btnPasso5.BackColor = Color.Green
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
                grp8.Visible = False
                grp6.Visible = True
                btnPasso6.BackColor = Color.Green
        End Sub

        Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
                grp2.Visible = False
                grp1.Visible = True
                btnPasso1.BackColor = Color.Gray
                Dim ItensNumber As Double
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Items.RemoveAt(ItensNumber - 2)
                lstResumo.Update()
        End Sub

        Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
                Dim ItensNumber As Double
                grp3.Visible = False
                grp2.Visible = True
                btnPasso2.BackColor = Color.Gray
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
                Dim ItensNumber As Double
                grp4.Visible = False
                grp3.Visible = True
                btnPasso3.BackColor = Color.Gray
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
                Dim ItensNumber As Double
                grpParcelado.Visible = False
                grp4.Visible = True
                btnPasso4.BackColor = Color.Gray

                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next

                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button15.Click
                Dim ItensNumber As Double
                grpModoParcelamento.Visible = False
                grpParcelado.Visible = True
                dgvParcelasValor.Rows.Clear()

                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next

                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
                Dim ItensNumber As Double
                If PeriodoPag = "Parcelado" Then
                        grp6.Visible = False
                        grpModoParcelamento.Visible = True
                        btnPasso5.BackColor = Color.Gray
                        btnPasso6.BackColor = Color.Gray
                Else
                        grp6.Visible = False
                        grp8.Visible = True
                End If

                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next

                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
                btnPasso6.BackColor = Color.Gray
        End Sub

        Private Sub btnVOO_Click(sender As Object, e As EventArgs) Handles btnVOO.Click
                Dim ItensNumber As Double
                grp7.Visible = False
                grp6.Visible = True
                btnPasso7.BackColor = Color.Gray

                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next

                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
                grpFinal.Visible = False
                grp7.Visible = True
                btnPasso8.BackColor = Color.Gray

                Dim ItensNumber As Double
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub cboNParcelas_ValueChanged(sender As Object, e As EventArgs) Handles cboNParcelas.ValueChanged
                Dim NParcelas As Integer = cboNParcelas.Value
                Dim listagem As New DataGridViewComboBoxColumn
                Dim DataInicio As Date = txtDataInicial.Text
                Dim DataVencimento As Date
                Dim l As Integer = NParcelas
                On Error Resume Next
                Dim PrecoPorParcela As Double = (txtValor.Text - ValorEntrada) / NParcelas
                Select Case cboNParcelas.Value
                        Case > 12
                                cboNParcelas.Value = 12
                        Case < 0
                                cboNParcelas.Value = 0
                End Select
                dgvParcelasValor.Rows.Clear()
                dgvParcelasValor.Columns.Clear()
                With listagem
                        .HeaderText = "Situação Pagamento"
                        .DataPropertyName = "bom"
                        .Items.Add("Foi Pago")
                        .Items.Add("Não Pago")
                End With
                With dgvParcelasValor.Columns
                        .Add("Descricao", "Descrição")
                        .Add("Parcela", "Parcela")
                        .Add("Valor", "Valor")
                        .Add("DataVencimento", "Data de Vencimento")
                        .Add(listagem)
                End With
                If PossuiEntrada = True Then
                        dgvParcelasValor.Rows.Add("Sua Descrição", "Entrada", ValorEntrada, txtDataInicial.Text, "Foi Pago")
                End If
                Do Until NParcelas = 0
                        DataVencimento = DataInicio.AddMonths(l)
                        dgvParcelasValor.Rows.Add("Sua Descrição", "Parcela " & NParcelas, PrecoPorParcela, DataVencimento, "Não Pago")
                        NParcelas -= 1
                        l -= 1
                Loop
                dgvParcelasValor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvParcelasValor.Columns("DataVencimento").DefaultCellStyle.Format = "d"
                dgvParcelasValor.Columns("Valor").DefaultCellStyle.Format = "C2"
                dgvParcelasValor.Sort(dgvParcelasValor.Columns("Parcela"), System.ComponentModel.ListSortDirection.Ascending)
        End Sub

        Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
                Dim ItensNumber As Double
                grp8.Visible = False
                grpAvista.Visible = True
                btnPasso5.BackColor = Color.Gray
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
                grpAvista.Visible = False
                grp4.Visible = True
                btnPasso4.BackColor = Color.Gray
                Dim ItensNumber As Double
                For Each item In lstResumo.Items
                        ItensNumber += 1
                Next
                lstResumo.Items.RemoveAt(ItensNumber - 1)
                lstResumo.Update()
        End Sub

        Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
                FinalizarCadastro()
                Me.Close()
                FrmNovoLancamento.btnLimparFiltro.PerformClick()
                Limpar()
        End Sub



        Private Sub dgvClientes_MouseLeave(sender As Object, e As EventArgs) Handles dgvListaClientes.MouseLeave
                '  dgvListaClientes.Visible = False
        End Sub

        Private Sub rdFisica_Click(sender As Object, e As EventArgs) Handles rdFisica.Click
                rdColaborador.Checked = False
        End Sub

        Private Sub txtCliente_Click(sender As Object, e As EventArgs) Handles txtNome.Click
                dgvListaClientes.Visible = True
        End Sub

        Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
                PreencherCliente()
        End Sub

        Private Sub txtNome_DoubleClick(sender As Object, e As EventArgs) Handles txtNome.DoubleClick
                txtNome.Text = ""
        End Sub

        Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
                If IsNumeric(txtValor.Text) = True Then
                        If txtValor.Text <> "" Then
                                If CDbl(txtValor.Text) > 0 Then
                                        lblValorFormat.Text = "R$ " & FormatNumber(CDbl(txtValor.Text), 2)
                                Else
                                        SQL.Notificao("", "Não é possivel inserir números negativos")
                                End If
                        End If
                Else
                        txtValor.Text = ""
                End If
        End Sub

        Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged
                Dim linhas As Double = dgvParcelasValor.Rows.Count - 1

                If cboNParcelas.Value > 0 Then

                        Do Until linhas = 0
                                linhas -= 1
                                dgvParcelasValor.Rows(linhas).Cells(0).Value = txtDescricao.Text
                        Loop
                Else
                        txtDescricao.Text = ""
                        SQL.Notificao("", "Número de Parcelas invalido")
                End If
        End Sub

        Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs)
                PreencherCliente()
        End Sub

        'FUNÇÕES E METODOS
        Public Sub FinalizarCadastro()
                If PeriodoPag = "Parcelado" Then
                        Dim Ldgv As Double = dgvParcelasValor.Rows.Count - 1
                        Do Until Ldgv <= 0
                                Ldgv -= 1
                                Dim lanca As New Financia.Lancamento
                                With lanca
                                        .nome = txtNome.Text
                                        .CPF = txtCPF.Text
                                        .ValorTotal = txtValor.Text
                                        .FormaPagamento = cboFormaPag.Text
                                        .PeriodoPagamento = PeriodoPag
                                        .PossuiEntrada = PossuiEntrada
                                        .ValorEntrada = ValorEntrada
                                        .NParcelas = cboNParcelas.Text
                                        .DataLancamento = CDate(txtDataInicial.Text)
                                        .DescricaoLancamento = dgvParcelasValor.Rows(Ldgv).Cells(0).Value
                                        .Observacao = dgvParcelasValor.Rows(Ldgv).Cells(1).Value
                                        .ValorLancamento = dgvParcelasValor.Rows(Ldgv).Cells(2).Value
                                        .DataVencimento = dgvParcelasValor.Rows(Ldgv).Cells(3).Value
                                        .SituacaoPag = dgvParcelasValor.Rows(Ldgv).Cells(4).Value
                                        .TipoLancamento = TipoLancamento
                                        .PlanoContas = cboPlanoConta.Text
                                End With

                                InstrucaoDireta("INSERT INTO tbFinanceiro (Cliente,Tipo,NumeroDocumento,Situacao,DataLancamento,Vencimento,Descricao,valor,PlanoContas,FormaPagamento,Observacao)" &
                            "VALUES(""" & lanca.nome & """,""" & lanca.TipoLancamento & """,""" & "Lançamento Manual" & """,""" & lanca.SituacaoPag & """,""" & lanca.DataLancamento &
                            """,""" & lanca.DataVencimento & """,""" & lanca.DescricaoLancamento & """,""" & lanca.ValorLancamento & """,""" & lanca.PlanoContas & """,""" &
                            lanca.FormaPagamento & """,""" & lanca.Observacao & """)")
reconect:
                                conexao1("SELECT Identificacao FROM tbFinanceiro ORDER BY Identificacao Desc")
                                bdr1.Read()
                                On Error GoTo reconect
                                Dim UltimaIdent As Double = bdr1.Item("Identificacao")
                                Dim TipoFinan As String
                                Select Case lanca.TipoLancamento
                                        Case "Receita"
                                                TipoFinan = "Entrada"

                                        Case "Despesa"
                                                TipoFinan = "Saída"

                                        Case Else
                                                MsgBox("Problema !!! , tipo lancamento")

                                End Select
                                If lanca.SituacaoPag = "Foi Pago" Then
                                        MovimentaoFinanceira(lanca.DescricaoLancamento, lanca.ValorLancamento, TipoFinan, UltimaIdent)
                                End If
                        Loop
                Else
                        Dim lanca As New Financia.Lancamento

                        With lanca
                                .nome = txtNome.Text
                                .CPF = txtCPF.Text
                                .ValorTotal = txtValor.Text
                                .FormaPagamento = cboFormaPag.Text
                                .PeriodoPagamento = PeriodoPag
                                .PossuiEntrada = PossuiEntrada
                                .ValorEntrada = ValorEntrada
                                .NParcelas = cboNParcelas.Value
                                .DataLancamento = CDate(dtpDataLancamento.Text)
                                .DescricaoLancamento = InputBox("Descreva Seu Lançamento", "Descrição do Lançamento")
                                .ValorLancamento = txtValor.Text
                                .DataVencimento = dtpDataVencimento.Value
                                .SituacaoPag = SituacaoPag
                                .TipoLancamento = TipoLancamento
                                .PlanoContas = cboPlanoConta.Text
                        End With
                        InstrucaoDireta("INSERT INTO tbFinanceiro (Cliente,Tipo,NumeroDocumento,Situacao,DataLancamento,Vencimento,Descricao,valor,PlanoContas,FormaPagamento,Observacao)" &
                        "VALUES(""" & lanca.nome & """,""" & lanca.TipoLancamento & """,""" & "Lançamento Manual" & """,""" & lanca.SituacaoPag & """,""" & lanca.DataLancamento &
                        """,""" & lanca.DataVencimento & """,""" & lanca.DescricaoLancamento & """,""" & lanca.ValorLancamento & """,""" & lanca.PlanoContas & """,""" &
                        lanca.FormaPagamento & """,""" & lanca.Observacao & """)")
                        conexao1("SELECT Identificacao FROM tbFinanceiro ORDER BY Identificacao Desc")
                        bdr1.Read()
                        Dim UltimaIdent As Double = bdr1.Item("Identificacao")
                        Dim TipoFinan As String
                        Select Case lanca.TipoLancamento
                                Case "Receita"
                                        TipoFinan = "Entrada"
                                Case "Despesa"
                                        TipoFinan = "Saída"
                                Case Else
                                        MsgBox("Problema !!! , tipo lancamento")
                        End Select

                        If lanca.SituacaoPag = "Foi Pago" Then
                                MovimentaoFinanceira("Lançamento Manual: " & UltimaIdent, lanca.ValorLancamento, TipoFinan, UltimaIdent)
                        End If
                End If
        End Sub

        Public Sub PreencherCliente()
                Dim Nome As String = dgvListaClientes.CurrentRow.Cells(0).Value
                On Error Resume Next
                Dim Sobrenome As String = dgvListaClientes.CurrentRow.Cells(1).Value
                If rdColaborador.Checked = False Then
                        txtNome.Text = dgvListaClientes.CurrentCell.Value
                Else
                        txtNome.Text = dgvListaClientes.CurrentRow.Cells(0).Value & " " & dgvListaClientes.CurrentRow.Cells(1).Value
                End If
                dgvListaClientes.Visible = False
                If rdFisica.Checked = True Then
                        'Connect.Conectardb("SELECT CPF FROM tbClientes WHERE Nome = " & "'" & Nome & "' OR RazaoSocial='" & Sobrenome & "'")
                        conexao1("SELECT * FROM tbClientes WHERE Nome = " & "'" & Nome & "'") '" & "OR RazaoSocial='" & Sobrenome & "')")
                        bdr1.Read()
                        On Error Resume Next
                        txtCPF.Text = bdr1.Item("CPF")
                End If
                If rdColaborador.Checked = True Then
                        Connect.Conectardb("SELECT CPF FROM tbGesseiros WHERE Nome = " & "'" & Nome & "'")
                        On Error Resume Next
                        txtCPF.Text = cdr.Item("CPF")
                End If
                Connect.Desconectardb()
        End Sub

        Public Sub Limpar()
                grpFinal.Visible = False
                grp1.Visible = True
                rdFisica.Checked = True
                txtNome.Text = ""
                txtCPF.Text = ""
                cboFormaPag.Text = ""
                txtValorEntrada.Text = ""
                txtDescricao.Text = ""
                Valor.Text = ""
                txtValor.Text = ""
                cboPlanoConta.Text = ""
                cboNParcelas.Value = 0
                btnPasso1.BackColor = Color.Gray
                btnPasso2.BackColor = Color.Gray
                btnPasso3.BackColor = Color.Gray
                btnPasso4.BackColor = Color.Gray
                btnPasso5.BackColor = Color.Gray
                btnPasso6.BackColor = Color.Gray
                btnPasso7.BackColor = Color.Gray
                btnPasso8.BackColor = Color.Gray
                btnReceita.BackColor = Color.Gray
                btnDespesa.BackColor = Color.Gray
                btnDefinirPago.BackColor = Color.Gray
                btnDefinirNPago.BackColor = Color.Gray
                btnAvista.BackColor = Color.Gray
                btnParcelado.BackColor = Color.Gray
                btnSemEntrada.BackColor = Color.Gray
                btnComEntrada.BackColor = Color.Gray
                txtValorEntrada.Visible = False
                lblValorEntrada.Visible = False
                lstResumo.Items.Clear()
                dgvParcelasValor.Rows.Clear()
                dgvParcelasValor.Columns.Clear()
                grp1.Visible = True
                grp2.Visible = False
                grp3.Visible = False
                grp4.Visible = False
                grp6.Visible = False
                grp7.Visible = False
                grp8.Visible = False
                grpAvista.Visible = False
                grpFinal.Visible = False
                grpModoParcelamento.Visible = False
                grpParcelado.Visible = False
        End Sub

        Public Sub CarregarTables()
                Me.TbPlanoContaTableAdapter.Fill(Me.DataSety.tbPlanoConta)
        End Sub

        Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
                Limpar()
                Me.Close()
        End Sub

        Private Sub FrmAddNovoLancamento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
                Me.Dispose(True)
        End Sub

        Private Sub btnAvista_Click(sender As Object, e As EventArgs) Handles btnAvista.Click
                PeriodoPag = "Avista"
                btnAvista.BackColor = Color.Purple
                btnParcelado.BackColor = Color.Gray
        End Sub

        Private Sub btnParcelado_Click(sender As Object, e As EventArgs) Handles btnParcelado.Click
                PeriodoPag = "Parcelado"
                btnAvista.BackColor = Color.Gray
                btnParcelado.BackColor = Color.Purple
        End Sub

        Private Sub pctInserirPlanoConta_Click(sender As Object, e As EventArgs) Handles pctInserirPlanoConta.Click
                InstrucaoDireta("INSERT INTO tbPlanoConta (Nome)" & "Values(""" & txtInserirPlanoConta.Text & """)")
                SQL.Notificao("", "Inserirdo com sucesso")
                txtInserirPlanoConta.Text = ""
                Me.TbPlanoContaTableAdapter.Fill(Me.DataSety.tbPlanoConta)
        End Sub

        Private Sub txtInserirPlanoConta_LostFocus(sender As Object, e As EventArgs) Handles txtInserirPlanoConta.LostFocus
                txtInserirPlanoConta.Text = txtInserirPlanoConta.Text.ToUpper
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
                Dim Resp As DialogResult = MsgBox("Os dados desta operação serão perdidos, deseja continuar?", MsgBoxStyle.YesNo, "Lançamento")
                If Resp = DialogResult.Yes Then
                        Me.Close()
                End If
        End Sub

        Private Sub btnAddPessoa_Click(sender As Object, e As EventArgs) Handles btnAddPessoa.Click
                FrmAdicionarCliente.ShowDialog()
        End Sub

        Private Sub dgvClientes_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
                PreencherCliente()
        End Sub

        Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
                'dgvClientes.Visible = False
                'If txtNome.Text = "" Then
                ' txtCPF.Text = ""
                ' End If
        End Sub


        Private Sub txtFiltroNome_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroNome.TextChanged
                Dim NomeFiltro As String = txtFiltroNome.Text
                Dim Comando As String
                If IsNumeric(txtFiltroNome.Text) = True Then
                        cboTipoPessoa.Text = "Todos"
                End If
                Select Case cboTipoPessoa.Text
                        Case = "Pessoa Fisica"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo FROM tbClientes WHERE Tipo=" & "'Pessoa Fisica'" & " AND Nome Like " & "'%" & NomeFiltro.ToUpper & "%' OR CPF Like '%" & NomeFiltro & "%'"
                                GetData(Comando, dgvListaClientes)

                        Case = "Pessoa Juridica"
                                Comando = "SELECT Nome,RazaoSocial,CPF as CNPJ,Tipo FROM tbClientes WHERE Tipo=" & "'Pessoa Juridica'" & " AND (RazaoSocial Like " & "'%" & NomeFiltro.ToUpper & "%' OR Nome Like '%" & NomeFiltro.ToUpper & "%' OR CPF Like '%" & NomeFiltro & "%')"
                                GetData(Comando, dgvListaClientes)

                        Case = "Colaborador"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo FROM tbClientes WHERE Tipo=" & "'Colaborador'" & " AND Nome Like " & "'%" & NomeFiltro.ToUpper &
                                        "%' OR CPF Like '%" & NomeFiltro & "%'"
                                GetData(Comando, dgvListaClientes)

                        Case = "Todos"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo,RazaoSocial FROM tbClientes WHERE Nome Like " & "'%" & NomeFiltro.ToUpper &
                                        "%' OR CPF Like '%" & NomeFiltro & "%' OR RazaoSocial like '%" & NomeFiltro.ToUpper & "%'"
                                GetData(Comando, dgvListaClientes)

                        Case Else

                End Select
        End Sub

        Private Sub txtShowClientes_Click(sender As Object, e As EventArgs) Handles txtShowClientes.Click
                Select Case gpClientes.Visible
                        Case = True
                                gpClientes.Visible = False
                                txtShowClientes.Text = "MOSTRAR CLIENTES"
                        Case = False
                                gpClientes.Visible = True
                                txtShowClientes.Text = "OCULTAR CLIENTES"
                        Case Else

                End Select
        End Sub

        Private Sub dgvListaClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaClientes.CellDoubleClick
                txtNome.Text = dgvListaClientes.CurrentRow.Cells(0).Value
                txtCPF.Text = dgvListaClientes.CurrentRow.Cells(2).Value
        End Sub

        Private Sub txtFiltroNome_Click(sender As Object, e As EventArgs) Handles txtFiltroNome.Click

        End Sub
End Class