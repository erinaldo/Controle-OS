Imports System.Data.OleDb

Public Class FrmNovoOrcamento
        Private Sub FrmNovoOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load


                dgvServicosDis.DataSource = PopularDataGrid("SELECT ServicoID as 'Identificação', Descricao as Descrição, Unidade as 'Un', ValorMDO as Valor, ValorUnitario as 'Valor do Serviço', TempoExecucao as 'Tempo Execução' FROM tbServico")
                '  dgvClientes.DataSource = PopularDataGrid("SELECT Código, Nome FROM tbClientes")


                'criação de colunas no datagrid serviços escolhidos ===============================================

                With dgvServicoEscolhido.Columns
                        .Clear()
                        .Add("Numero", "Número")
                        .Add("Descricao", "Descrição")
                        .Add("Unidade", "Unidade")
                        .Add("ValorMDO", "Valor MDO")
                        .Add("ValorServico", "Valor Serviço")
                        .Add("TempoExecucao", "Tempo de Execução")
                        .Add("Medida", "Medida")
                        .Add("Ambiente", "Ambiente")

                End With

                With dgvParcelas.Columns
                        .Clear()
                        .Add("Parcelas", "Parcelas")
                        .Add("ValorParcela", "Valor da Parcela")
                        .Add("DiasVencer", "Dias de Antecipação")
                        .Add("DataVencimento", "Data de Vencimento")
                End With
        End Sub




        Public LucroAtual As Double

        Private Sub dgvServicoEscolhido_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicoEscolhido.CellValueChanged
                SomaMDO(dgvServicoEscolhido)
                '     SimularParcelamento(dgvParcelamento)
                SomarTempoExecucao(dgvServicoEscolhido)
                SomaOS(dgvServicoEscolhido)

                CalcularLucro()
                LucroAtual = CDbl(lblLucroAtual.Text)

                'coverter hora em dia levando em consideração a jornada de trabalho atual
                On Error Resume Next
                lblTempoExecDia.Text = FormatNumber((CDbl(lblTempoExecucao.Text) / nudJornadaTrabalho.Value), 2)

                PicDataTermino.Value = CalcularDataTermino(picDataInicio.Value)

                Agendamento(CDbl(lblTempoExecDia.Text))

                If PrecisaDiaria() = True Then
                        lblTotalComDiaria.Text = CalculoDiaria(CDbl(lblTotalOS.Text), CDbl(lblTempoExecDia.Text), DiariaGesseiro)
                End If
        End Sub

        Public DiariaGesseiro As Double

        Public Function PrecisaDiaria()


                If chkNeceAjudante.Checked = False Then
                        DiariaGesseiro = 120
                Else
                        DiariaGesseiro = 150
                End If

                If (Math.Ceiling(CDbl(lblTempoExecDia.Text)) * DiariaGesseiro) > (lblTotalMDO.Text) Then
                        MsgBox("considerar o pagamento de diaria")
                        Return True
                Else
                        MsgBox("não considerar o pagamento de diaria")
                        Return False
                End If

        End Function

        Public Function CalculoDiaria(TotalOS As Double, DiasExtimados As Double, ValorDiaria As Double)



                Dim TotalDiaria As Double = (ValorDiaria * Math.Ceiling(DiasExtimados))
                lblTotalDiaria.Text = Dinheiro(TotalDiaria)
                Return Dinheiro(CDbl(lblTotalOS.Text) + TotalDiaria)

        End Function




        Public Sub CalcularLucro()
                lblLucroAtual.Text = Dinheiro(CDbl(ValorTotalOS) - (CDbl(ValorTotalCustoVeiculo) + CDbl(ValorTotalMDO) + CDbl(ValorTotalTaxaAntecipacao) + CDbl(lblTotalAntecipacao.Text)))

        End Sub


        Public ListaDatas As New List(Of Date)


        Public Sub Agendamento(tempoDias As Double)

                ListaDatas.Clear()
                pnCalendario.Controls.Clear()
                Dim DataInicio As Date = picDataInicio.Value.ToString("dd/MM/yyyy")
                Dim dias As Double = tempoDias
                Dim x As Integer = 2
                Dim y As Integer = 0

                Dim ponto As New Point(2.0F, 2.0F)

                While dias > 0
                        Dim nome As String = dias

                        Dim DiaAgenda As New ListView

                        With DiaAgenda
                                .Width = 100
                                .Height = 50
                                .BackColor = Color.Gray
                                .Location = New Point(x, y)
                        End With

                        With DiaAgenda
                                .Items.Clear()
                                .View = View.List
                                .Items.Add(DataInicio.AddDays(dias).ToShortDateString)

                        End With
                        ListaDatas.Add((DataInicio.AddDays(dias).ToShortDateString))
                        pnCalendario.Controls.Add(DiaAgenda)


                        dias -= 1
                        x += 102
                        y += 0
                End While
        End Sub

        Public Function CalcularDataTermino(DataInicio As Date)
                DataInicio = picDataInicio.Value
                Return DataInicio.AddDays(Math.Ceiling(CDbl(lblTempoExecDia.Text)))
        End Function

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
                Application.Exit()
        End Sub



        Public Sub SelecionarItem()
                dgvServicoEscolhido.Rows.Add(dgvServicosDis.CurrentRow.Cells(0).Value, dgvServicosDis.CurrentRow.Cells(1).Value, dgvServicosDis.CurrentRow.Cells(2).Value, dgvServicosDis.CurrentRow.Cells(3).Value, dgvServicosDis.CurrentRow.Cells(4).Value, dgvServicosDis.CurrentRow.Cells(5).Value)
                SomarTempoExecucao(dgvServicoEscolhido)
        End Sub


        Public Sub SomarTempoExecucao(datagrid As DataGridView)
                Dim valor As Double
                Dim ValorSoma As Double

                For Each cell As DataGridViewRow In datagrid.Rows
                        If IsNumeric(cell.Cells(5).Value) = True And IsNumeric(cell.Cells(6).Value) = True Then
                                If IsNumeric(cell.Cells(5).Value) = True Then

                                        valor = cell.Cells(5).Value * cell.Cells(6).Value
                                        ValorSoma = valor + ValorSoma

                                Else

                                        valor = cell.Cells(5).Value
                                        ValorSoma = valor + ValorSoma

                                End If
                        End If
                Next
                TempoTotalExecucao = ValorSoma
                lblTempoExecucao.Text = ValorSoma
        End Sub

        Public ValorTotalMDO As Double
        Public ValorTotalOS As Double
        Public ValorTotalCustoVeiculo As Double
        Public ValorTotalTaxaAntecipacao As Double
        Public TempoTotalExecucao As Double


        Public Sub SomaMDO(datagrid As DataGridView)
                Dim valor As Double
                Dim ValorSoma As Double

                For Each cell As DataGridViewRow In datagrid.Rows
                        If IsNumeric(cell.Cells(3).Value) And IsNumeric(cell.Cells(6).Value) = True Then
                                valor = cell.Cells(3).Value * cell.Cells(6).Value
                                ValorSoma = valor + ValorSoma
                        End If
                Next
                lblTotalMDO.Text = Dinheiro(ValorSoma)
                ValorTotalMDO = ValorSoma
        End Sub

        Public Sub SomaOS(datagrid As DataGridView)
                Dim valor As Double
                Dim ValorSoma As Double

                For Each cell As DataGridViewRow In datagrid.Rows
                        If IsNumeric(cell.Cells(4).Value) And IsNumeric(cell.Cells(6).Value) = True Then
                                valor = cell.Cells(4).Value * cell.Cells(6).Value
                                ValorSoma = valor + ValorSoma
                        End If
                Next
                lblTotalOS.Text = Dinheiro(ValorSoma)
                ValorTotalOS = ValorSoma
        End Sub


        Public Sub SimularTaxaAntecipacao(datagrid As DataGridView, QuantParcelas As Integer, FormaPagamento As String,
        IntervaloParcela As Integer, ValorTotal As Double, ValorEntrada As Double)






                dgvParcelas.Rows.Clear()
                dgvParcelas.Columns.Clear()

                With dgvParcelas.Columns
                        .Add("NumeroParcela", "Número da Parcela")
                        .Add("ValorParcela", "Valor da Parcela")
                End With








        End Sub

        Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudJornadaTrabalho.ValueChanged
                'coverter hora em dia levando em consideração a jornada de trabalho atual
                On Error Resume Next
                lblTempoExecDia.Text = FormatNumber((CDbl(lblTempoExecucao.Text) / nudJornadaTrabalho.Value), 2)
        End Sub

        Private Sub chkEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntrada.CheckedChanged
                If chkEntrada.Checked = True Then
                        txtValorEntrada.Enabled = True
                Else
                        txtValorEntrada.Enabled = False
                End If
        End Sub

        Private Sub cboTipoDeslocamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDeslocamento.SelectedIndexChanged
                If cboTipoDeslocamento.Text = "Outro" Then
                        cboVeiculosEmpresa.Enabled = False
                        txtCustoDiario.Enabled = True
                Else
                        txtCustoDiario.Enabled = False
                End If

                If cboTipoDeslocamento.Text = "Veiculo Próprio" Then
                        cboVeiculosEmpresa.Enabled = False
                        txtCustoDiario.Enabled = True
                        'calculo de combustivel x km
                End If

                If cboTipoDeslocamento.Text = "Veiculo da Empresa" Then
                        cboVeiculosEmpresa.Enabled = True
                        txtCustoDiario.Enabled = False
                        GetDataCombo(cboVeiculosEmpresa, "select Nome from tbVeiculo")
                        'calculo de (combustivel x km) + taxa de manutenção
                End If
        End Sub

        Public Function CustoVeiculo(CustoDiario As Double, TempoExecucao As Double)
                Dim Total As Double = Math.Ceiling(TempoExecucao) * CustoDiario
                Return Total
        End Function

        Private Sub txtCustoDiario_TextChanged(sender As Object, e As EventArgs) Handles txtCustoDiario.TextChanged
                Try
                        ValorTotalCustoVeiculo = Dinheiro(CustoVeiculo(CDbl(txtCustoDiario.Text), CDbl(lblTempoExecDia.Text)))
                        txtCustoTotalVeiculo.Text = Dinheiro(ValorTotalCustoVeiculo)
                        lblLucroAtual.Text = Dinheiro(CDbl(ValorTotalOS) - (CDbl(ValorTotalCustoVeiculo) + CDbl(ValorTotalMDO) + CDbl(ValorTotalTaxaAntecipacao)))
                Catch

                End Try
        End Sub

        Private Sub dgvServicoEscolhido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicoEscolhido.CellContentClick

        End Sub

        Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
                CalculoAntecipacao()
        End Sub

        Public ValorBruto As Double

        Public Sub CalculoAntecipacao()







                Dim TaxaAntecipacao As Double
                Dim TaxaAdministracao As Double


                ' Dim DataInicio As Date = Today.ToString("dd/MM/yyyy")
                Dim DataInicio As Date = picDataInicio.Value

                DataInicio.AddDays(CDbl(txtDiasAntecipar.Text))

                Dim QuantParcelas As Double

                Select Case cboModCred.SelectedIndex
                        Case = 0
                                QuantParcelas = 1
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Debito" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 1
                                QuantParcelas = 1
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Credito" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 2
                                QuantParcelas = 2
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred2" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 3
                                QuantParcelas = 3
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred3" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 4
                                QuantParcelas = 4
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred4" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 5
                                QuantParcelas = 5
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred5" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 6
                                QuantParcelas = 6
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred6" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 7
                                QuantParcelas = 7
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred7" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 8
                                QuantParcelas = 8
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred8" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 9
                                QuantParcelas = 9
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred9" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 10
                                QuantParcelas = 10
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred10" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 11
                                QuantParcelas = 11
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred11" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case = 12
                                QuantParcelas = 12
                                Dim drTaxa As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAntecipacao WHERE ModCred='" & "Cred12" & "'")
                                drTaxa.Read()
                                TaxaAdministracao = drTaxa("TaxaAdm")
                                TaxaAntecipacao = drTaxa("TaxaAntec")

                        Case Else

                End Select









                Dim ContParcelas As Double = 1

                dgvParcelas.Rows.Clear()

                If chkEntrada.Checked = True Then
                        ValorBruto = CDbl(lblTotalOS.Text) - CDbl(txtValorEntrada.Text)
                Else
                        ValorBruto = CDbl(lblTotalOS.Text)
                End If

                ' txtValorParcelaDesconto.Text = ValorBruto - (ValorBruto * CDbl(txtTaxaAdministrativa.Text) / 100)

                Dim CustoPorParcela = (CDbl(TaxaAntecipacao) * CDbl(txtDiasAntecipar.Text)) / 30

                Dim ValorLiquido As Double = ValorBruto - ValorBruto * TaxaAdministracao / 100
                lblValorLiquidoAnteci.Text = Dinheiro(ValorLiquido)

                ValorLiquido = ValorLiquido / QuantParcelas

                While ContParcelas < QuantParcelas + 1

                        Dim SomaDiaAntecipacao As Double = ContParcelas * CDbl(txtDiasAntecipar.Text)

                        Dim DiasAntecipar As Double = ContParcelas * CDbl(txtDiasAntecipar.Text)

                        Dim SomaDataVencimento As Date = DataInicio.AddDays(DiasAntecipar)

                        Dim ValorDaParcela As Double = Math.Round(ValorLiquido - CustoPorParcela * SomaDiaAntecipacao, 4)

                        Dim PrecoLiqParcela As Double = ValorLiquido

                        Dim AnteciparDia As Double = CDbl(txtDiasAntecipar.Text) * ContParcelas
                        Dim ValorParcela As Double = FormatNumber(PrecoLiqParcela - (PrecoLiqParcela * TaxaAntecipacao) / 30 * AnteciparDia, 2)

                        dgvParcelas.Rows.Add(ContParcelas, ValorParcela, DiasAntecipar, SomaDataVencimento.ToShortDateString)

                        ContParcelas += 1
                End While

                Dim LinDgvParcelas As Integer = dgvParcelas.Rows.Count - 1
                Dim TotalAntecipacao As Double

                While LinDgvParcelas > -1
                        TotalAntecipacao = TotalAntecipacao + dgvParcelas.Item(1, LinDgvParcelas).Value
                        LinDgvParcelas -= 1
                End While


                If chkEntrada.Checked = True Then
                        lblTotalAntecipacao.Text = Dinheiro((CDbl(lblTotalOS.Text) - CDbl(txtValorEntrada.Text)) - TotalAntecipacao)
                Else
                        lblTotalAntecipacao.Text = Dinheiro(CDbl(lblTotalOS.Text) - TotalAntecipacao)
                End If


                CalcularLucro()


        End Sub

        Private Sub dgvServicoEscolhido_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicoEscolhido.CellEnter

        End Sub

        Private Sub cboModCred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModCred.SelectedIndexChanged
                CalculoAntecipacao()
        End Sub

        Private Sub lblTotalComDiaria_Click(sender As Object, e As EventArgs) Handles lblTotalComDiaria.Click

        End Sub

        Private Sub lblTotalComDiaria_TextChanged(sender As Object, e As EventArgs) Handles lblTotalComDiaria.TextChanged
                txtTotalConsiderado.Text = Dinheiro(CDbl(lblTotalComDiaria.Text))
        End Sub

        Private Sub btnCriarAgendamento_Click(sender As Object, e As EventArgs) Handles btnCriarAgendamento.Click

                Dim drAgenda As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAgendaObras WHERE NumOS=" & CDbl(txtNumOS.Text))
                drAgenda.Read()

                If drAgenda.HasRows = True Then
                        Dim Resp As DialogResult = MsgBox("Existe um agendamento marcado para essa obra, gostaria de atualizar pelo agendamento atual?", MsgBoxStyle.YesNo)
                        If Resp = DialogResult.Yes Then

                                DeletarAgendamento()
                                InserirAgendamento()


                        End If
                Else

                        InserirAgendamento()

                End If



        End Sub

        Public Sub InserirAgendamento()
                Dim Index As Integer = ListaDatas.Count - 1
                For Each item In ListaDatas
                        conexao1("INSERT INTO tbAgendaObras(UsuarioID,ClienteID,DataPedido,Status,Atividade,HoraMarcada,NumOS,Tipo)" & "VALUES(""" & Usuario.Identificacao & """,""" & 2001 & """,""" & ListaDatas.Item(Index) &
                        """,""" & "N/A" & """,""" & "Obra " & txtNumOS.Text & """,""" & picHoraInicio.Text & """,""" & CDbl(txtNumOS.Text) & """,""" & "Obra" & """)")
                        Index -= 1
                Next
        End Sub

        Public Sub DeletarAgendamento()
                InstrucaoDireta("DELETE FROM tbAgendaObras WHERE NumOS=" & CDbl(txtNumOS.Text))
        End Sub


        Public Sub CriarAgendmento()

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
                FrmAgendaObra.ShowDialog()
        End Sub

        Private Sub btnInserirVisita_Click(sender As Object, e As EventArgs) Handles btnInserirVisita.Click
                InserirVisita()
        End Sub

        Public Sub InserirVisita()

                conexao1("INSERT INTO tbAgendaObras(UsuarioID,ClienteID,DataPedido,Status,Atividade,HoraMarcada,NumOS,Tipo)" & "VALUES(""" & Usuario.Identificacao & """,""" & 2001 & """,""" & picDataVisita.Value.ToString("dd/MM/yyyy") &
                        """,""" & cboStatusVisita.Text & """,""" & "Visita " & txtNumOS.Text & """,""" & picHoraVisita.Value & """,""" & CDbl(txtNumOS.Text) & """,""" & "Visita" & """)")
        End Sub

        Private Sub dgvClientes_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellEnter
                '       dgvEnderecos.DataSource = PopularDataGrid("SELECT * FROM tbEnd WHERE CodEnd=" & dgvClientes.CurrentRow.Cells(0).Value)
        End Sub

        Private Sub btnExCliente_Click(sender As Object, e As EventArgs) Handles btnExCliente.Click
                ' pnInfoCliente.Height = 28
                ' pnInfoCliente.Height = 400
                pnInfoCliente.BringToFront()

                If pnInfoCliente.Height < 30 Then
                        pnInfoCliente.Height = pnPrincipal.Height - 15
                Else
                        pnInfoCliente.Height = 28
                End If

        End Sub

        Private Sub txtPesquisar_Click(sender As Object, e As EventArgs) Handles txtPesquisar.Click
                txtPesquisar.Text = ""
        End Sub

        Private Sub txtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar.TextChanged
                If txtPesquisar.Text = "" Then
                        txtPesquisar.Text = "Digite o nome do item"
                End If
        End Sub



        Private Sub btnExItens_Click(sender As Object, e As EventArgs) Handles btnExItens.Click
                pnItens.BringToFront()

                If pnItens.Height < 30 Then
                        pnItens.Height = pnPrincipal.Height - 50
                Else
                        pnItens.Height = 28
                End If
        End Sub

        Private Sub dgvServicosDis_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicosDis.CellDoubleClick
                SelecionarItem()
        End Sub

        Private Sub btnExPagamento_Click(sender As Object, e As EventArgs) Handles btnExPagamento.Click
                pnPagamento.BringToFront()

                If pnPagamento.Height < 30 Then
                        pnPagamento.Height = pnPrincipal.Height - 80
                Else
                        pnPagamento.Height = 28
                End If
        End Sub

        Private Sub btnExTempo_Click(sender As Object, e As EventArgs) Handles btnExTempo.Click
                pnExTempo.BringToFront()

                If pnExTempo.Height < 30 Then
                        pnExTempo.Height = pnPrincipal.Height - 110
                Else
                        pnExTempo.Height = 28
                End If
        End Sub

        Private Sub btnExCustos_Click(sender As Object, e As EventArgs) Handles btnExCustos.Click
                pnCustos.BringToFront()

                If pnCustos.Height < 30 Then
                        pnCustos.Height = pnPrincipal.Height - 150
                Else
                        pnCustos.Height = 28
                End If
        End Sub

        Private Sub btnVisitas_Click(sender As Object, e As EventArgs) Handles btnVisitas.Click
                pnVisita.BringToFront()

                If pnVisita.Height < 30 Then
                        pnVisita.Height = pnPrincipal.Height - 180
                Else
                        pnVisita.Height = 28
                End If
        End Sub

        Private Sub btnAgendamento_Click(sender As Object, e As EventArgs) Handles btnAgendamento.Click
                pnAgendamento.BringToFront()

                If pnAgendamento.Height < 30 Then
                        pnAgendamento.Height = pnPrincipal.Height - 210
                Else
                        pnAgendamento.Height = 28
                End If
        End Sub

        Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs) Handles btnFinanceiro.Click
                pnFinanceiro.BringToFront()

                If pnFinanceiro.Height < 30 Then
                        pnFinanceiro.Height = pnPrincipal.Height - 240
                Else
                        pnFinanceiro.Height = 28
                End If
        End Sub

        Private Sub btnListaMaterial_Click(sender As Object, e As EventArgs) Handles btnListaMaterial.Click
                pnMaterial.BringToFront()

                If pnMaterial.Height < 30 Then
                        pnMaterial.Height = pnPrincipal.Height - 270
                Else
                        pnMaterial.Height = 28
                End If
        End Sub

        Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
                pnRelatorio.BringToFront()

                If pnRelatorio.Height < 30 Then
                        pnRelatorio.Height = pnPrincipal.Height - 300
                Else
                        pnRelatorio.Height = 28
                End If
        End Sub

        Private Sub btnMedicao_Click(sender As Object, e As EventArgs) Handles btnMedicao.Click
                pnMedicao.BringToFront()

                If pnMedicao.Height < 30 Then
                        pnMedicao.Height = pnPrincipal.Height - 330
                Else
                        pnMedicao.Height = 28
                End If
        End Sub

        Private Sub btnFinalizacao_Click(sender As Object, e As EventArgs) Handles btnFinalizacao.Click
                pnFinalizacao.BringToFront()

                If pnFinalizacao.Height < 30 Then
                        pnFinalizacao.Height = pnPrincipal.Height - 370
                Else
                        pnFinalizacao.Height = 28
                End If
        End Sub

        Private Sub txtPesquisarCliente_TextChanged(sender As Object, e As EventArgs)


        End Sub

        Private Sub txtPesquisarCliente_TextChanged_1(sender As Object, e As EventArgs) Handles txtPesquisarCliente.TextChanged
                Dim NomeFiltro As String = txtPesquisarCliente.Text
                Dim Comando As String
                If IsNumeric(txtPesquisarCliente.Text) = True Then
                        cboTipoPessoa.Text = "Todos"
                End If
                Select Case cboTipoPessoa.Text
                        Case = "Pessoa Fisica"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo FROM tbClientes WHERE Tipo=" & "'Pessoa Fisica'" & " AND Nome Like " & "'%" & NomeFiltro.ToUpper & "%' OR CPF Like '%" & NomeFiltro & "%'"
                                ' GetData(Comando, dgvClientes)
                                dgvClientes.DataSource = PopularDataGrid(Comando)


                        Case = "Pessoa Juridica"
                                Comando = "SELECT Nome,RazaoSocial,CPF as CNPJ,Tipo FROM tbClientes WHERE Tipo=" & "'Pessoa Juridica'" & " AND (RazaoSocial Like " & "'%" & NomeFiltro.ToUpper & "%' OR Nome Like '%" & NomeFiltro.ToUpper & "%' OR CPF Like '%" & NomeFiltro & "%')"
                                'GetData(Comando, dgvClientes)
                                dgvClientes.DataSource = PopularDataGrid(Comando)


                        Case = "Colaborador"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo FROM tbClientes WHERE Tipo=" & "'Colaborador'" & " AND Nome Like " & "'%" & NomeFiltro.ToUpper &
                                        "%' OR CPF Like '%" & NomeFiltro & "%'"
                                ' GetData(Comando, dgvClientes)
                                dgvClientes.DataSource = PopularDataGrid(Comando)


                        Case = "Todos"
                                Comando = "SELECT Nome,Sobrenome,CPF,Tipo,RazaoSocial FROM tbClientes WHERE Nome Like " & "'%" & NomeFiltro.ToUpper &
                                        "%' OR CPF Like '%" & NomeFiltro & "%' OR RazaoSocial like '%" & NomeFiltro.ToUpper & "%'"
                                ' GetData(Comando, dgvClientes)

                                dgvClientes.DataSource = PopularDataGrid(Comando)


                        Case Else

                End Select
        End Sub
End Class