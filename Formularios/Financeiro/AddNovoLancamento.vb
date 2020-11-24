

Public Class AddNovoLancamento

    Public PeriodoPag As String
    Public SituacaoPag As String
    Public PossuiEntrada As Boolean
    Public ValorEntrada As Double
    Public TipoLancamento As String
    Public NParcela As String
    Public PlanoConta As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboFormaPag.Items
            .Add("Credito")
            .Add("Dinheiro")
        End With


        With cboPlanoConta.Items
            .Add("Vale")
            .Add("Pedido")
        End With


        txtDataInicial.Text = Today.ToShortDateString
        txtDataLancamento.Text = Today.ToShortDateString
        txtDataVencimento.Text = Today.ToShortDateString


        txtParcelado.BackColor = Color.Gray
        txtAvista.BackColor = Color.Gray
        btnSemEntrada.BackColor = Color.Gray
        btnComEntrada.BackColor = Color.Gray

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
                lstResumo.Items.Add("Valor Total: R$ " & FormatNumber(txtValor.Text, 2))
            Else
                MsgBox("Valor Invalido")
            End If
        Else
            MsgBox("o valor nao é um numero")
        End If
    End Sub

    Private Sub txtAvista_Click(sender As Object, e As EventArgs) Handles txtAvista.Click

        PeriodoPag = "Avista"
        txtAvista.BackColor = Color.Green
        txtParcelado.BackColor = Color.Gray



    End Sub

    Private Sub txtParcelado_Click(sender As Object, e As EventArgs) Handles txtParcelado.Click

        PeriodoPag = "Parcelado"
        txtAvista.BackColor = Color.Gray
        txtParcelado.BackColor = Color.Green

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

            Case Else

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

    Public firstTipoLancamento As Boolean = False

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


        Dim PackLanca As New List(Of String)

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
                .ValorLancamento = dgvParcelasValor.Rows(Ldgv).Cells(1).Value
                .DataVencimento = dgvParcelasValor.Rows(Ldgv).Cells(2).Value
                .SituacaoPag = dgvParcelasValor.Rows(Ldgv).Cells(3).Value
                .TipoLancamento = TipoLancamento
                .PlanoContas = cboPlanoConta.Text
            End With

            'inserir o comando sql aqui

        Loop




        lstResumo.Items.Add("Plano de Contas: " & PlanoConta)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub btnDefinirPago_Click(sender As Object, e As EventArgs) Handles btnDefinirPago.Click
        SituacaoPag = "Foi Pago"

        btnDefinirPago.BackColor = Color.Green
        btnDefinirNPago.BackColor = Color.Gray

    End Sub

    Private Sub btnDefinirNPago_Click(sender As Object, e As EventArgs) Handles btnDefinirNPago.Click
        SituacaoPag = "Não Pago"
        btnDefinirPago.BackColor = Color.Gray
        btnDefinirNPago.BackColor = Color.Green

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
        grp3.Visible = False
        grp2.Visible = True
        btnPasso2.BackColor = Color.Gray

        Dim ItensNumber As Double
        For Each item In lstResumo.Items
            ItensNumber += 1
        Next
        lstResumo.Items.RemoveAt(ItensNumber - 1)
        lstResumo.Update()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        grp4.Visible = False
        grp3.Visible = True
        btnPasso3.BackColor = Color.Gray

        Dim ItensNumber As Double
        For Each item In lstResumo.Items
            ItensNumber += 1
        Next
        lstResumo.Items.RemoveAt(ItensNumber - 1)
        lstResumo.Update()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        grpParcelado.Visible = False
        grp4.Visible = True
        btnPasso4.BackColor = Color.Gray

        Dim ItensNumber As Double
        For Each item In lstResumo.Items
            ItensNumber += 1
        Next
        lstResumo.Items.RemoveAt(ItensNumber - 1)
        lstResumo.Update()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        grpModoParcelamento.Visible = False
        grpParcelado.Visible = True
        dgvParcelasValor.Rows.Clear()


        Dim ItensNumber As Double
        For Each item In lstResumo.Items
            ItensNumber += 1
        Next
        lstResumo.Items.RemoveAt(ItensNumber - 1)
        lstResumo.Update()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If PeriodoPag = "Parcelado" Then
            grp6.Visible = False
            grpModoParcelamento.Visible = True

            btnPasso5.BackColor = Color.Gray
            btnPasso6.BackColor = Color.Gray

        Else
            'implementar codigo da segunda linha cronologica
            grp6.Visible = False
            grp8.Visible = True
        End If


        btnPasso6.BackColor = Color.Gray
    End Sub

    Private Sub btnVOO_Click(sender As Object, e As EventArgs) Handles btnVOO.Click
        grp7.Visible = False
        grp6.Visible = True
        btnPasso7.BackColor = Color.Gray

        Dim ItensNumber As Double
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
        Select Case cboNParcelas.Value
            Case > 12
                cboNParcelas.Value = 12

            Case < 0
                cboNParcelas.Value = 0

            Case Else

        End Select

        dgvParcelasValor.Rows.Clear()
        dgvParcelasValor.Columns.Clear()

        Dim NParcelas As Integer = cboNParcelas.Text




        Dim listagem As New DataGridViewComboBoxColumn


        With listagem
            .HeaderText = "Situação Pagamento"
            .DataPropertyName = "bom"
            .Items.Add("Foi Pago")
            .Items.Add("Não Pago")
        End With






        With dgvParcelasValor.Columns
            .Add("Parcela", "Parcela")
            .Add("Valor", "Valor")
            .Add("DataVencimento", "Data de Vencimento")
            '.Add("SituacaoPag", "Situação Pagamento")
            .Add(listagem)

        End With

        Dim DataInicio As Date = txtDataInicial.Text
        Dim DataVencimento As Date

        Dim l As Integer = NParcelas

        Dim PrecoPorParcela As Double = (txtValor.Text - ValorEntrada) / NParcelas



        If PossuiEntrada = True Then


            dgvParcelasValor.Rows.Add("Entrada", ValorEntrada, txtDataInicial.Text, "Foi Pago")


        End If



        Do Until NParcelas = 0


            'MsgBox(l)

            DataVencimento = DataInicio.AddMonths(l)

            dgvParcelasValor.Rows.Add("Parcela " & NParcelas, PrecoPorParcela, DataVencimento, "Não Pago")



            NParcelas -= 1

            l -= 1


        Loop

        dgvParcelasValor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvParcelasValor.Columns("DataVencimento").DefaultCellStyle.Format = "d"
        dgvParcelasValor.Columns("Valor").DefaultCellStyle.Format = "C2"
        'dgvParcelasValor.Columns("Valor").
        dgvParcelasValor.Sort(dgvParcelasValor.Columns("Parcela"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        grp8.Visible = False
        grpAvista.Visible = True
        btnPasso5.BackColor = Color.Gray

        Dim ItensNumber As Double
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
End Class
