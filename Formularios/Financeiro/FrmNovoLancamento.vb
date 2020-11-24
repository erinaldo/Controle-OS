Imports System.Data.OleDb
Imports MaterialSkin

Public Class FrmNovoLancamento

        Inherits Controls.MaterialForm

        Public FocoDataInicial As Boolean
        Public FocoDataFinal As Boolean
        Public ConsultaFiltro As String
        Public WhereAdd As Boolean

        Private Sub FrmNovoLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.TbFormaPagamentoTableAdapter.Fill(Me.DataSety.tbFormaPagamento)
                Me.TbPlanoContaTableAdapter.Fill(Me.DataSety.tbPlanoConta)
                'Me.OpcoesTableAdapter.Fill(Me.SistemaGEDataSet.Opcoes)
                If SQL.AddItemPag = False Then
                        '\\MUDAR DEPOIS (MODO TESTE)
                        With cboPeriodo.Items
                                .Add("Este Mês")
                                .Add("Mês Passado")
                                .Add("Mês Antepassado")
                                .Add("Data Personalizada")
                        End With
                        '\\SITUAÇÃO DE PAGAMENTO (PAGO,NÃO PAGO E TODOS)
                        With cboSituacaoPag.Items
                                .Add("Todos")
                                .Add("Foi Pago")
                                .Add("Não Pago")
                        End With
                        '\\TIPO DE PERIODO (LANÇAMENTO,VENCIMENTO)
                        With cboData.Items
                                .Add("Vencimento")
                                .Add("Lançamento")
                        End With
                        With cboTipoLancamento.Items
                                .Add("Todos")
                                .Add("Receita")
                                .Add("Despesa")
                        End With
                        '\\O COMBOBOX PLANO DE CONTAS É PREENCHIDO A PARTIR DO DB (DATAMEMBER-OPÇÕES)
                        cboPlanoContas.Text = "Todos"

                        cboData.Text = "Lançamento"
                        cboTipoLancamento.Text = "Todos"
                End If
                '\\DEFINIR O PRIMEIRO E ULTIMO DIA DO MES ATUAL
                Dim Ano As Integer = Today.Year '\\ANO ATUAL
                Dim MesAtual As Integer = Today.Month '\\MÊS ATUAL
                Dim DiaAtual As Integer = DateTime.DaysInMonth(Ano, MesAtual) '\\ULTIMO DIA DO MÊS
                If cboPeriodo.Text = "Este Mês" Then
                        txtDataInicial.Text = CDate("01/" & MesAtual & "/" & Ano)
                        txtDataFinal.Text = CDate(DiaAtual & "/" & MesAtual & "/" & Ano).ToShortDateString
                End If
                Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
                '\\FILTRO USANDO O MES ATUAL COMO UNICO FILTRO
                Me.TbFinanceiroTableAdapter.FillByDataLoad(Me.DataSetX.tbFinanceiro, New System.Nullable(Of Date)(CType(txtDataInicial.Text, Date)), New System.Nullable(Of Date)(CType(txtDataFinal.Text, Date)))
                LimparFiltros()
                Filtro()
                txtFiltroIdentificacao.Text = 0
                AtualizarRegistro()

                pnDockLeft.BackColor = CorFundo
                With btnAddLancamento
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With
                With btnFechar
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With
                With btnGerarRelatorio
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

        End Sub

        Public Sub AtualizarRegistro()

                lblRecebimentoAtraso.Text = RecebimentoAtraso()
                lblPagamentosAtraso.Text = PagamentoAtraso()

        End Sub

        Private Sub TbFinanceiroDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvFinanceiro.CellFormatting
                If e.ColumnIndex = 2 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo Line1
                        End If
                        If (e.Value.ToString = ("Receita")) Then
                                e.CellStyle.BackColor = Color.White
                                e.CellStyle.ForeColor = Color.Green
                        End If
                End If
Line1:
                If e.ColumnIndex = 2 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo line2
                        End If
                        If (e.Value.ToString = ("Despesa")) Then
                                e.CellStyle.BackColor = Color.White
                                e.CellStyle.ForeColor = Color.Red
                        End If
                End If
line2:
                If e.ColumnIndex = 6 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo Line3
                        End If
                        If (e.Value.ToString > (Today)) Then
                                e.CellStyle.BackColor = Color.Green
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
Line3:
                If e.ColumnIndex = 6 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo line4
                        End If
                        If (e.Value.ToString < (Today)) Then
                                e.CellStyle.BackColor = Color.Red
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
line4:
                If e.ColumnIndex = 4 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo line5
                        End If
                        If (e.Value.ToString = ("Foi Pago")) Then
                                e.CellStyle.BackColor = Color.Green
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
line5:
                If e.ColumnIndex = 4 Then
                        If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                                GoTo line6
                        End If
                        If (e.Value.ToString = ("Não Pago")) Then
                                e.CellStyle.BackColor = Color.Red
                                e.CellStyle.ForeColor = Color.White
                        End If
                End If
line6:
        End Sub

        Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
                Filtro()
                SomaPago()
        End Sub

        Private Sub Filtro()
                Progresso(10)
                ConsultaFiltro = "SELECT Identificacao as Identificação, Cliente, Tipo, NumeroDocumento, Situacao, DataLancamento, Vencimento, Valor, PlanoContas, FormaPagamento as Pagamento FROM tbFinanceiro"
                Dim NomeCliente As String = "" & txtCliente.Text
                Dim Tipo As String = cboTipoLancamento.Text
                Dim FormaPag As String = cboFormaPagamento.Text
                WhereAdd = False
                Dim Situacao As String = cboSituacaoPag.Text
                Progresso(20)
                If txtDataInicial.Text = "" Or txtDataFinal.Text = "" Or txtDataInicial.Text = "*" Or txtDataFinal.Text = "*" Then
                        With txtDataInicial
                                .Text = "*"
                                .BackColor = Color.Red
                                .ForeColor = Color.Yellow
                        End With
                        With txtDataFinal
                                .Text = "*"
                                .BackColor = Color.Red
                                .ForeColor = Color.Yellow
                        End With
                        With txtDataInicial
                                .Text = "*"
                                .BackColor = Color.Red
                                .ForeColor = Color.Yellow
                        End With
                        SQL.Notificao("", "Preencha os campos marcados em vermelho com (*)")
                Else
                        Dim I As Date = txtDataInicial.Text
                        Dim F As Date = txtDataFinal.Text
                        '\\CASO O CAIXA "IDENTIFICAÇÃO ESTEJA VAZIA"
                        If txtFiltroIdentificacao.Text = "" Then
                                txtFiltroIdentificacao.Text = 0
                        End If
                        Progresso(30)
                        Dim ID As Double = txtFiltroIdentificacao.Text
                        '\\ FORMAÇÃO DA STRING DE CONSULTA ===========================================================
                        If NomeCliente <> "" Then
                                If WhereAdd = False Then
                                        WhereAdd = True
                                        ConsultaFiltro = ConsultaFiltro & " WHERE Cliente Like " & "'" & NomeCliente & "%'"
                                Else
                                        ConsultaFiltro = ConsultaFiltro & " Cliente LIKE " & "'" & NomeCliente & "%'"
                                End If
                        End If
                        Progresso(40)
                        If Situacao <> "Todos" Then
                                If Situacao <> "" Then
                                        If WhereAdd = False Then
                                                WhereAdd = True
                                                ConsultaFiltro = ConsultaFiltro & " WHERE Situacao=" & "'" & Situacao & "'"
                                        Else
                                                ConsultaFiltro = ConsultaFiltro & " And Situacao=" & "'" & Situacao & "'"
                                        End If
                                End If
                        End If
                        Progresso(50)
                        '===================================

                        If cboPlanoContas.Text <> "Todos" Then
                                If WhereAdd = False Then
                                        WhereAdd = True
                                        ConsultaFiltro = ConsultaFiltro & " WHERE PlanoContas = '" & cboPlanoContas.Text & "'"
                                Else
                                        ConsultaFiltro = ConsultaFiltro & "And PlanoContas = '" & cboPlanoContas.Text & "'"
                                End If
                        End If

                        '===================================

                        If txtFiltroIdentificacao.Text <> 0 Then
                                If WhereAdd = False Then
                                        WhereAdd = True
                                        ConsultaFiltro = ConsultaFiltro & " WHERE Identificacao LIKE " & "'" & ID & "%'"
                                Else
                                        ConsultaFiltro = ConsultaFiltro & " And Identificacao LIKE " & "'" & ID & "%'"
                                End If
                        End If
                        If Tipo <> "Todos" Then
                                If Tipo <> "" Then
                                        If WhereAdd = False Then
                                                WhereAdd = True
                                                ConsultaFiltro = ConsultaFiltro & " WHERE Tipo=" & "'" & Tipo & "'"
                                        Else
                                                ConsultaFiltro = ConsultaFiltro & " And Tipo=" & "'" & Tipo & "'"
                                        End If
                                End If
                        End If
                        Progresso(80)
                        If FormaPag <> "Todos" Then
                                If FormaPag <> "" Then
                                        If WhereAdd = False Then
                                                WhereAdd = True
                                                ConsultaFiltro = ConsultaFiltro & " WHERE FormaPagamento=" & "'" & FormaPag & "'"
                                        Else
                                                ConsultaFiltro = ConsultaFiltro & " And FormaPagamento=" & "'" & FormaPag & "'"
                                        End If
                                End If
                        End If
                        If cboData.Text = "Vencimento" Then
                                If WhereAdd = False Then
                                        WhereAdd = True
                                        ConsultaFiltro = ConsultaFiltro & " WHERE Vencimento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY Vencimento"
                                Else
                                        ConsultaFiltro = ConsultaFiltro & " And Vencimento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                        F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY Vencimento"
                                End If
                        End If
                        If cboData.Text = "Lançamento" Then
                                If WhereAdd = False Then
                                        WhereAdd = True
                                        ConsultaFiltro = ConsultaFiltro & " WHERE DataLancamento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                      F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataLancamento"
                                Else
                                        ConsultaFiltro = ConsultaFiltro & " And DataLancamento BETWEEN " & "# " & I.ToString("MM'/'dd'/'yyyy") & " # And # " &
                      F.ToString("MM'/'dd'/'yyyy") & " # ORDER BY DataLancamento"
                                End If
                        End If
                        Progresso(90)
                        'FIM DA FORMAÇÃO DA STRING DE CONSULTA=================================================
                        Dim strConn As String = sConnectionString
                        Dim conexao As New OleDbConnection(strConn)
                        Dim comando As New OleDbCommand(ConsultaFiltro, conexao)
                        Dim adaptador As New OleDbDataAdapter(comando)
                        Dim dsbiblio As New DataSet()
                        adaptador.Fill(dsbiblio, "Cliente")
                        dgvFinanceiro.DataSource = dsbiblio.Tables("Cliente")
                End If
                Progresso(100)
        End Sub

        Private Sub cboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodo.SelectedIndexChanged
                Dim Ano As Integer = Today.Year '\\ANO ATUAL
                Dim MesAtual As Integer = Today.Month '\\MÊS ATUAL
                Dim DiaAtual As Integer = DateTime.DaysInMonth(Ano, MesAtual) '\\ULTIMO DIA DO MÊS
                Dim MesAnterior As Integer = MesAtual - 1
                Dim DiaAnterior As Integer = DateTime.DaysInMonth(Ano, MesAnterior)
                Dim MesAntepassado As Integer = MesAtual - 2
                If MesAntepassado < 0 Then
                        MesAntepassado = 12 - MesAntepassado
                End If
                Dim DiaAntepassado As Integer = DateTime.DaysInMonth(Ano, MesAntepassado) '\\ULTIMO DIA DO MÊS
                '\\DATA INICIAL E FINAL DO MÊS ATUAL
                If cboPeriodo.Text = "Este Mês" Then
                        txtDataInicial.Text = CDate("01/" & MesAtual & "/" & Ano)
                        txtDataFinal.Text = CDate(DiaAtual & "/" & MesAtual & "/" & Ano)
                End If
                '\\DATA INICIAL E FINAL DO MÊS ANTERIOR
                If cboPeriodo.Text = "Mês Passado" Then
                        txtDataInicial.Text = CDate("01/" & MesAnterior & "/" & Ano)
                        txtDataFinal.Text = CDate(DiaAnterior & "/" & MesAnterior & "/" & Ano)
                End If
                '\\DATA INICIAL E FINAL DO MÊS ANTEPASSADO
                If cboPeriodo.Text = "Mês Antepassado" Then
                        txtDataInicial.Text = CDate("01/" & MesAntepassado & "/" & Ano)
                        txtDataFinal.Text = CDate(DiaAntepassado & "/" & MesAntepassado & "/" & Ano)
                End If
                '\\DATA INICIAL E FINAL PERSONALIZADA
                If cboPeriodo.Text = "Data Personalizada" Then
                        txtDataInicial.Text = ""
                        txtDataInicial.ReadOnly = True
                        txtDataFinal.Text = ""
                        txtDataFinal.ReadOnly = True
                End If
        End Sub

        Private Sub txtDataInicial_Click(sender As Object, e As EventArgs) Handles txtDataInicial.Click
                FocoDataInicial = True
                FocoDataFinal = False
                If cboPeriodo.Text = "Data Personalizada" Then
                        mcCalendar.Visible = True
                End If
                ' SQL.Notificao("inicial = " & FocoDataInicial, "final = " & FocoDataFinal)
        End Sub

        Private Sub txtDataFinal_Click(sender As Object, e As EventArgs) Handles txtDataFinal.Click
                FocoDataInicial = False
                FocoDataFinal = True
                If cboPeriodo.Text = "Data Personalizada" Then
                        mcCalendar.Visible = True
                End If
                '  SQL.Notificao("inicial = " & FocoDataInicial, "final = " & FocoDataFinal)
        End Sub

        Private Sub mcCalendar_MouseLeave(sender As Object, e As EventArgs) Handles mcCalendar.MouseLeave
                mcCalendar.Visible = False
        End Sub

        Private Sub mcCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcCalendar.DateChanged
                If FocoDataInicial = True And cboPeriodo.Text = "Data Personalizada" Then
                        txtDataInicial.ReadOnly = False
                        txtDataInicial.Text = mcCalendar.SelectionStart.ToShortDateString
                        txtDataInicial.ReadOnly = True
                End If
                If FocoDataFinal = True And cboPeriodo.Text = "Data Personalizada" Then
                        txtDataFinal.ReadOnly = False
                        txtDataFinal.Text = mcCalendar.SelectionStart.ToShortDateString
                        txtDataFinal.ReadOnly = True
                End If
        End Sub

        Public Sub LimparFiltros()
                txtFiltroIdentificacao.Text = 0
                cboSituacaoPag.Text = "Todos"
                cboPlanoContas.Text = "Todos"
                cboFormaPagamento.Text = "Todos"
                cboTipoLancamento.Text = "Todos"
                txtIdentificacao.Text = 0
                txtCliente.Text = ""
                cboPeriodo.Text = "Este Mês"
                WhereAdd = False
                ConsultaFiltro = "SELECT * FROM tbFinanceiro"
                btnAplicarFiltro.PerformClick()
        End Sub

        Private Sub txtDataInicial_TextChanged(sender As Object, e As EventArgs) Handles txtDataInicial.TextChanged
                txtDataInicial.BackColor = Color.White
                txtDataFinal.BackColor = Color.White
                txtDataInicial.ForeColor = Color.Black
                txtDataFinal.ForeColor = Color.Black
        End Sub

        Private Sub txtDataFinal_TextChanged(sender As Object, e As EventArgs) Handles txtDataFinal.TextChanged
                txtDataInicial.BackColor = Color.White
                txtDataFinal.BackColor = Color.White
                txtDataInicial.ForeColor = Color.Black
                txtDataFinal.ForeColor = Color.Black
        End Sub

        Private Sub dgvFinanceiro_DoubleClick(sender As Object, e As EventArgs) Handles dgvFinanceiro.DoubleClick
                '
        End Sub

        Private Sub dgvFinanceiro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinanceiro.CellClick
                On Error Resume Next
                txtIdentificacao.Text = dgvFinanceiro.CurrentRow.Cells(0).Value
        End Sub

        Private Sub ADICIONARLANÇAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs)
                'FrmAddLancamento.ShowDialog()
        End Sub

        Private Sub VOLTARToolStripMenuItem_Click(sender As Object, e As EventArgs)
                Me.Close()
        End Sub

        Private Sub btnLimparFiltro_Click(sender As Object, e As EventArgs) Handles btnLimparFiltro.Click
                LimparFiltros()
                SomaPago()
        End Sub

        Private Sub dgvFinanceiro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinanceiro.CellContentClick

        End Sub

        Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

        End Sub

        Private Sub btnAddLancamento_Click(sender As Object, e As EventArgs) Handles btnAddLancamento.Click
                FrmAddNovoLancamento.ShowDialog()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
                Me.Close()
        End Sub

        Private Sub lblHoraAtual_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub dgvFinanceiro_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvFinanceiro.MouseDown
                If e.Button = MouseButtons.Right Then
                        FrmContexLancamento.Show()
                End If
        End Sub

        Private Sub dgvFinanceiro_Click(sender As Object, e As EventArgs) Handles dgvFinanceiro.Click
                FrmContexLancamento.Close()
        End Sub

        Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        End Sub

        Private Sub btnGerarRelatorio_Click(sender As Object, e As EventArgs) Handles btnGerarRelatorio.Click
                FrmRelatorioFinanceiro.Show()
        End Sub

        Public Sub SomaPago()
                Dim linhas As Double = dgvFinanceiro.Rows.Count - 1
                Dim SomaPago, SomaNpago As Double
                If linhas > -1 Then
                        Do Until linhas <= -1
                                If dgvFinanceiro.Rows(linhas).Cells(4).Value = "Foi Pago" Then
                                        SomaPago = SomaPago + dgvFinanceiro.Rows(linhas).Cells(7).Value
                                End If
                                If dgvFinanceiro.Rows(linhas).Cells(4).Value = "Não Pago" Then
                                        SomaNpago = SomaNpago + dgvFinanceiro.Rows(linhas).Cells(7).Value
                                End If
                                lblNPago.Text = "Não Pago: " & Dinheiro(SomaNpago)
                                lblNPago.ForeColor = Color.Red
                                lblSomaPago.Text = "Foi Pago: " & Dinheiro(SomaPago)
                                lblSomaPago.ForeColor = Color.Green
                                linhas -= 1
                        Loop
                Else
                        lblNPago.Text = ""
                        lblSomaPago.Text = ""
                End If
        End Sub

        Private Sub btnSelAll_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub FrmNovoLancamento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
                Me.Dispose(True)
        End Sub

        Private Sub PnDockTop_Paint(sender As Object, e As PaintEventArgs) Handles PnDockTop.Paint

        End Sub

        Private Sub btnExpDockTop_Click(sender As Object, e As EventArgs) Handles btnExpDockTop.Click
                ExpDockTop()
        End Sub

        Public Sub ExpDockTop()
                Select Case PnDockTop.Height
                        Case > 200
                                PnDockTop.Height = 5
                        Case < 150
                                PnDockTop.Height = 350
                        Case Else

                End Select
        End Sub

        Public Sub DockLeftMax()
                pnDockLeft.Width = 200
        End Sub

        Public Sub DockLeftMin()
                tmDockMin.Start()
        End Sub

        Private Sub pnDockLeft_MouseEnter(sender As Object, e As EventArgs) Handles pnDockLeft.MouseEnter
                DockLeftMax()
        End Sub

        Private Sub btnFechar_MouseEnter(sender As Object, e As EventArgs) Handles btnFechar.MouseEnter
                DockLeftMax()
        End Sub

        Private Sub btnAddLancamento_MouseEnter(sender As Object, e As EventArgs) Handles btnAddLancamento.MouseEnter
                DockLeftMax()
        End Sub

        Private Sub pnDockLeft_MouseLeave(sender As Object, e As EventArgs) Handles pnDockLeft.MouseLeave
                DockLeftMin()
        End Sub

        Private Sub btnGerarRelatorio_MouseLeave(sender As Object, e As EventArgs) Handles btnGerarRelatorio.MouseLeave
                DockLeftMin()
        End Sub

        Private Sub btnAddLancamento_MouseLeave(sender As Object, e As EventArgs) Handles btnAddLancamento.MouseLeave
                DockLeftMin()
        End Sub

        Private Sub btnFechar_MouseLeave(sender As Object, e As EventArgs) Handles btnFechar.MouseLeave
                DockLeftMin()
        End Sub

        Private Sub btnGerarRelatorio_MouseEnter(sender As Object, e As EventArgs) Handles btnGerarRelatorio.MouseEnter
                DockLeftMax()
        End Sub

        Private Sub tmDockMin_Tick(sender As Object, e As EventArgs) Handles tmDockMin.Tick
                pnDockLeft.Width = 45
                tmDockMin.Stop()
        End Sub

        Private Sub dgvFinanceiro_MouseEnter(sender As Object, e As EventArgs) Handles dgvFinanceiro.MouseEnter
                PnDockTop.Height = 10
        End Sub

        Private Sub FrmNovoLancamento_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
                MovPoup()
        End Sub

        Public Sub MovPoup()
                If chkMovPoup.Checked = True Then
                        grpSoma.Location = MousePosition

                        grpSoma.Location = New Point(MousePosition.X - 10, MousePosition.Y - 83)



                End If
        End Sub

        Private Sub dgvFinanceiro_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvFinanceiro.MouseMove
                MovPoup()
        End Sub

        Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

        End Sub

        Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs)
                MovPoup()
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        End Sub

        Private Sub txtIdentificacao_Click(sender As Object, e As EventArgs) Handles txtIdentificacao.Click

        End Sub

        Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        End Sub
End Class