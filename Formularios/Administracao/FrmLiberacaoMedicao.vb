Imports System.Data.OleDb

Public Class FrmLiberacaoMedicao

    Private Sub FrmLiberacaoMedicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
        Me.TbFilaProducaoTableAdapter.Fill(Me.SistemaGEDataSet.tbFilaProducao)
        Me.TbHistoricoMedicaoTableAdapter1.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbObservacaoTableAdapter.Fill(Me.DataSetX.tbObservacao)
        Me.TbLancamentosTableAdapter.Fill(Me.DataSetX.tbLancamentos)
        Me.TbOSTableAdapter1.Fill(Me.SistemaGEDataSet.tbOS)
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.DataSetX.tbHistoricoMedicao)
        Me.TbHistoricoMedicaoTableAdapter1.FillByNaoLiberados(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbHistoricoMedicaoTableAdapter.FillBylIBERADOS1(Me.DataSetX.tbHistoricoMedicao)
    End Sub

    Private Sub dgvLiberados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLiberados.CellClick
        Me.TbOSTableAdapter.FillByOSID(Me.DataSetX.tbOS, CType(dgvLiberados.CurrentRow.Cells(0).Value, Integer))
    End Sub

    Private Sub dgvPendente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendente.CellClick
        On Error Resume Next
        Me.TbOSTableAdapter.FillByOSID(Me.DataSetX.tbOS, CType(dgvPendente.CurrentRow.Cells(0).Value, Integer))
    End Sub

    Private Sub btnCarreagar_Click(sender As Object, e As EventArgs) Handles btnCarreagar.Click

        FrmCadastroOS.TbProdutoVenda2TableAdapter.FillByos(FrmCadastroOS.SistemaGEDataSet1.tbProdutoVenda2, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))

        '//SELECIONAR QUAL FOI A FORMA DE PAGAMENTO DA OS CARREGADA

        '//CARREGA AS INFORMAÇÕES GERAIS DA OS
        'FrmCadastroOS.ComboBox1.Text = TipoEnderecoTextBox.Text
        FrmCadastroOS.txtOSID.Text = OSIDTextBox.Text

        FrmCadastroOS.txtStatus.Text = StatusTextBox.Text

        'FrmCadastroOS.ComboBox1.Text = TipoEnderecoTextBox.Text

        '//DEFINE A COR DO CAMPO DE STATUS DA OS
        If StatusTextBox.Text = "NÃO APROVADO" Then
            FrmCadastroOS.txtStatus.BackColor = Color.LightYellow
        End If
        If StatusTextBox.Text = "APROVADO" Then
            FrmCadastroOS.txtStatus.BackColor = Color.LightGreen
        End If

        '//CARREGA A PARTIR DO BD, UTILIZANDO O ID DO CONTATO
        FrmCadastroOS.cboCliente.Text = NomeClienteTextBox.Text
        lSQL = "SELECT * FROM tbContato WHERE ContatoID=" & CodClienteTextBox.Text
        objConn.Close()
        objConn.Open()
        Dim objcmd As New OleDbCommand(lSQL, objConn)
        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        FrmCadastroOS.txtEndContato.Text = dr.Item("Numero")
        dr.Close()
        dr = Nothing
        objConn.Close()

        '//PREENCHE A TABELA DE OBSERVAÇÕES SOBRE A OS
        FrmCadastroOS.TbObservacaoTableAdapter.ObservacaoPorOS(Me.SistemaGEDataSet.tbObservacao, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))
        FrmCadastroOS.TbObservacaoTableAdapter.FillBy(FrmCadastroOS.SistemaGEDataSet.tbObservacao, New System.Nullable(Of Integer)(CType(Me.OSIDTextBox.Text, Integer)))
        '//PREENCHE A TABELA QUE SERA APRESENTADA AO USUARIO
        FrmCadastroOS.TbProdutoVenda1TableAdapter.FillBy(FrmCadastroOS.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(Me.OSIDTextBox.Text, Integer)))

        '//DEFINE A ALTURA DO DATAGRID VIEW DINAMICAMENTE
        FrmCadastroOS.Show()
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        FrmCadastroOS.dgvProdutosAdquiridos.Height = 40 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20.5)
        'FrmCadastroOS.grpGeral.Location = New Point(25, 390 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20.5))
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub dgvLiberados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLiberados.CellFormatting
        'Dim val As DataGridViewColumn = dgvLiberado
        'Val = dgvLiberados.Columns(e.ColumnIndex)
        If e.ColumnIndex = 0 Then
            If (e.Value = ("319")) Then
                e.CellStyle.BackColor = Color.Green
                e.CellStyle.ForeColor = Color.Black
            Else
                dgvLiberados.RowsDefaultCellStyle.BackColor = Color.White
                dgvLiberados.RowsDefaultCellStyle.ForeColor = Color.Black
            End If
        Else
        End If
    End Sub

    Private Sub btnLiberarPagamento_Click(sender As Object, e As EventArgs) Handles btnLiberarPagamento.Click
        If OSIDTextBox.Text <> "" Then
            Dim OSID As Double = OSIDTextBox.Text
            lSQL = "UPDATE tbHistoricoMedicao SET Liberacao=""" & "LIBERAÇÃO APROVADA" & """ WHERE ID=" & dgvPendente.CurrentRow.Cells(1).Value
            SQL.Comando()
            Me.TbHistoricoMedicaoTableAdapter1.FillByNaoLiberados(Me.SistemaGEDataSet.tbHistoricoMedicao)
            Me.TbHistoricoMedicaoTableAdapter.FillBylIBERADOS1(Me.DataSetX.tbHistoricoMedicao)
        Else
            SQL.Notificao("", "Nenhuma medição foi selecionada ")
        End If
    End Sub

    Private Sub btnExpandirDetOS_Click(sender As Object, e As EventArgs) Handles btnExpandirDetOS.Click
        grpDetOS.Height = 360
        btnExpandirDetOS.Visible = False
        btnMinimizarDetOS.Visible = True
    End Sub

    Private Sub btnMinimizarDetOS_Click(sender As Object, e As EventArgs) Handles btnMinimizarDetOS.Click
        grpDetOS.Height = 60
        btnMinimizarDetOS.Visible = False
        btnExpandirDetOS.Visible = True
    End Sub

    Private Sub dgvPendente_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPendente.CellFormatting
        dgvPendente.Columns(8).DefaultCellStyle.Format = "c"
        dgvPendente.Columns(8).ValueType = GetType(Double)
    End Sub

End Class