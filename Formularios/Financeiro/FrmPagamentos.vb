Public Class FrmPagamentos

    Public OSselecionada As New List(Of String)
    Public OSselecionadaCab As New List(Of String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub FrmPagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbPlanoDespesas'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbPlanoDespesasTableAdapter.Fill(Me.SistemaGEDataSet.tbPlanoDespesas)
        Me.TbFormaPagamentoTableAdapter.Fill(Me.SistemaGEDataSet.tbFormaPagamento)
        'Me.TbLancarTableAdapter.Fill(Me.SistemaGEDataSet.tbLancar)
        Me.TbMedicaoTableAdapter.Fill(Me.SistemaGEDataSet1.tbMedicao)
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet1.tbHistoricoMedicao)
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet.tbGesseiros)
        ' With lstPagSel
        '.MultiSelect = True
        '.View = View.Details
        ' End With

        ' With lstPagSel
        '.LabelEdit = False
        ' .FullRowSelect = False

        '        End With

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        Me.TbMedicaoTableAdapter.FiltroItemsNaoIniciados(Me.SistemaGEDataSet1.tbMedicao, txtNomeGesseiro.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        RealizarPagamento()

    End Sub

    Private Sub FillByLiberadosToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TbHistoricoMedicaoTableAdapter.FillByLiberados(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '=======================================================================================================

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        lstPagSel.Items.Clear()
        GetlinhasSelecionadas()
        LinhaSelecionada()
        On Error Resume Next

        txtTotalAreaExecutada.Text = DataGridView2.CurrentRow.Cells(4).Value
    End Sub

    Public PermImprimir As Boolean = True

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click

        If FormAcesso(Me, "ConfigLiberPag", "nothing") = True Then
            If txtLiberacao.Text = "AGUARDANDO LIBERAÇÃO" Then
                lSQL = "UPDATE tbHistoricoMedicao SET Liberacao=""" & "LIBERAÇÃO APROVADA" & """ WHERE ID=" & txtID.Text
                SQL.Comando()
                Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet1.tbHistoricoMedicao)
                Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
                Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
                SQL.Notificao("NOVA LITORAL GESSO", "MEDIÇÃO LIBERADA COM SUCESSO")
            Else
                SQL.Notificao("NOVA LITORAL GESSO", "ESSE PAGAMENTO JÁ FOI LIBERADO")
            End If

        End If
    End Sub

    Public Soma As Double

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        DataGridView2.Columns(3).DefaultCellStyle.Format = "c"
        DataGridView2.Columns(3).ValueType = GetType(Double)
    End Sub

    Private Sub LinhaSelecionada()
        Soma = 0
        ' lstPagSel.Items.Clear()
        Try
            lblmsg.Text = "Linhas Selecionadas : " + DataGridView2.SelectedRows.Count.ToString
            For Each item In obt()
                lstPagSel.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        ' MsgBox(Soma)
    End Sub

    Public Function obt() As List(Of String)
        Dim j As Integer
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim dgvColecaoLinhasSelecionadas As DataGridViewSelectedRowCollection = DataGridView2.SelectedRows
            Dim ids As New List(Of String)

            OSselecionadaCab.Clear()
            OSselecionada.Clear()

            OSselecionadaCab.Add("CÓDIGO OS")
            OSselecionadaCab.Add("CÓDIGO PAGAMENTO")
            OSselecionadaCab.Add("DESCRIÇÃO")
            OSselecionadaCab.Add("MEDIÇÃO")
            OSselecionadaCab.Add("UN.")
            OSselecionadaCab.Add("VALOR")
            OSselecionadaCab.Add("DATA DA MEDIÇÃO")

            For i As Integer = 0 To dgvColecaoLinhasSelecionadas.Count - 1

                Dim OSID As Integer = dgvColecaoLinhasSelecionadas(i).Cells(0).Value
                Dim CodPagamento As Integer = dgvColecaoLinhasSelecionadas(i).Cells(1).Value
                Dim Pagar As String = dgvColecaoLinhasSelecionadas(i).Cells(3).Value
                Dim Descricao As String = dgvColecaoLinhasSelecionadas(i).Cells(4).Value
                Dim Medicao As String = dgvColecaoLinhasSelecionadas(i).Cells(5).Value
                Dim Unidade As String = dgvColecaoLinhasSelecionadas(i).Cells(6).Value
                Dim DataMedicao As String = dgvColecaoLinhasSelecionadas(i).Cells(7).Value
                Dim Status As String = dgvColecaoLinhasSelecionadas(i).Cells(8).Value

                Soma = Soma + dgvColecaoLinhasSelecionadas(i).Cells(3).Value

                OSselecionada.Add(OSID)
                OSselecionada.Add(CodPagamento)
                OSselecionada.Add(Descricao)
                OSselecionada.Add(Medicao)
                OSselecionada.Add(Unidade)
                OSselecionada.Add(Pagar)
                OSselecionada.Add(DataMedicao)

                If Status = "PAGO" Then

                    MsgBox("Atenção uma ou mais medição estão marcadas como paga")

                    lstPagSel.Clear()

                    OSselecionada.Clear()

                    OSselecionadaCab.Clear()

                    GoTo encerrar

                End If

                '   ids.Add("Total: " & Soma)

            Next

            '  For Each cabecalho In DataGridView2.SelectedRows.Item(0).Cells

            'DataGridView2.

            'Next

            ids.Add("_____________________________________________________")

            ids.Add("Total a Pagar " & Soma)

            Return ids
        Else
            Throw New Exception("Não existem linhas selecionadas !!")
        End If

encerrar:

    End Function

    Private Sub btnImprimirPag_Click(sender As Object, e As EventArgs) Handles btnImprimirPag.Click
        FrmImpPagamento.Show()
    End Sub

    Private Function GetlinhasSelecionadas() As List(Of String)
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim dgvColecaoLinhasSelecionadas As DataGridViewSelectedRowCollection = DataGridView2.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To dgvColecaoLinhasSelecionadas.Count - 1
                Dim OSID As Integer = dgvColecaoLinhasSelecionadas(i).Cells(0).Value
                '  Dim ID As Integer = dgvColecaoLinhasSelecionadas(i).Cells(10).Value
                Dim Receber As Double = dgvColecaoLinhasSelecionadas(i).Cells(2).Value
                Dim Descricao As String = dgvColecaoLinhasSelecionadas(i).Cells(4).Value
                Dim Pagar As Double = dgvColecaoLinhasSelecionadas(i).Cells(3).Value
                Dim Medicao As Double = dgvColecaoLinhasSelecionadas(i).Cells(5).Value
                Dim Unidade As String = dgvColecaoLinhasSelecionadas(i).Cells(6).Value
                Dim Liberacao As String = dgvColecaoLinhasSelecionadas(i).Cells(9).Value

                lstPagSel.Items.Add("OS " & OSID & ", Valor R$ " & Pagar & ", Medição " & Medicao & " " & Unidade & ", Descrição " & Descricao)

            Next
            Return ids
        Else
            Throw New Exception("Não existem linhas selecionadas !!")
        End If
    End Function

    Public Function RealizarPagamento()

        If txtLiberacao.Text = "AGUARDANDO LIBERAÇÃO" Then
            SQL.Notificao("NOVA LITORAL GESSO", "ESSE PAGAMENTO NÃO ESTA LIBERADO")
            GoTo ENCERRAR
        Else
            If DataGridView2.CurrentRow.Cells(8).Value <> "PAGO" Then
                If cboFormaPagamento.Text <> "" Then
                    lSQL = "INSERT INTO tbPagamentosRealizados (PagamentoID,DataPagamento,Valor,Destinatario,Observacao)" & "VALUES (""" & txtCodOS.Text & """,""" &
                    Today.ToShortDateString.ToString & """,""" & txtValor.Text & """,""" & txtNomeGesseiro.Text & """,""" & DataGridView2.CurrentRow.Cells(8).Value & """)"
                    SQL.Comando()
                    lSQL = "UPDATE tbHistoricoMedicao SET Status=""" & "PAGO" & """ WHERE SubID=" & DataGridView2.CurrentRow.Cells(1).Value
                    SQL.Comando()

                    Dim DataVencimentoPagamento As Date
                    Dim Ano As Integer = Today.Year '\\ANO ATUAL
                    Dim MesAtual As Integer = Today.Month '\\MÊS ATUAL
                    Dim DiaAtual As Integer = DateTime.DaysInMonth(Ano, MesAtual) '\\ULTIMO DIA DO MÊS

                    If DiaAtual >= 1 And DiaAtual <= 15 Then
                        MsgBox("sera pago no dia 15 essa medição")
                        DataVencimentoPagamento = "15/" & MesAtual & "/" & Ano
                    End If

                    If DiaAtual >= 16 And DiaAtual <= 31 Then
                        MsgBox("sera pago no dia 30 essa medição")
                        DataVencimentoPagamento = "30/" & MesAtual & "/" & Ano
                    End If

                    '//INSERIR O QUE SERÁ PAGO PARA O GESSEIRO
                    InstrucaoDireta("INSERT INTO tbFinanceiro(Cliente,Tipo,NumeroDocumento,Situacao,DataLancamento,Vencimento,Descricao,Valor,PlanoContas,FormaPagamento)" &
                    "VALUES (""" & txtNomeGesseiro.Text & """,""" & "Despesa" & """,""" & "Medição " & txtID.Text & """,""" & "Foi Pago" & """,""" & Today.ToShortDateString &
                    """,""" & DataVencimentoPagamento & """,""" & "Pagamento da medição ( " & txtID.Text & " ) relacionada a OS ( " & txtCodOS.Text &
                    " ) para o prestador " & txtNomeGesseiro.Text &
                    """,""" & txtValor.Text & """,""" & "Pagamento de Prestador" & """,""" & cboFormaPagamento.Text & """)")

                    SQL.Notificao("NOVA LITORAL GESSO", "NOVO PAGAMENTO REALIZADO COM SUCESSO")
                    Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet1.tbHistoricoMedicao)
                    Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
                    Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
                Else
                    SQL.Notificao("NOVA LITORAL GESSO", "ESCOLHA UM FORMA DE PAGAMENTO")
                End If
            Else
                SQL.Notificao("NOVA LITORAL GESSO", "ESSE PAGAMENTO JÁ FOI EFETUADO")
            End If
        End If
ENCERRAR:
    End Function

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtSobrenomeGesseiro_TextChanged(sender As Object, e As EventArgs) Handles txtSobrenomeGesseiro.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

End Class