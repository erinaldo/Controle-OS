Imports System.Data.OleDb

Public Class FrmCarregarOS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCarregarOS.Click

        If OSIDTextBox.Text <> "" Then

            FrmCadastroOS.TbAdicionalPagoTableAdapter1.FillByteste(FrmCadastroOS.DataSetX1.tbAdicionalPago, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))
            FrmCadastroOS.TbProdutoVenda2TableAdapter.FillByos(FrmCadastroOS.SistemaGEDataSet1.tbProdutoVenda2, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))
            FrmCadastroOS.TbInicialPagoTableAdapter.FillByOSID(FrmCadastroOS.SistemaGEDataSet.tbInicialPago, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))

            '//CARREGA AS INFORMAÇÕES GERAIS DA OS
            FrmCadastroOS.txtOSID.Text = OSIDTextBox.Text
            FrmCadastroOS.txtStatus.Text = StatusTextBox.Text

            '//DEFINE A COR DO CAMPO DE STATUS DA OS
            If StatusTextBox.Text = "NÃO APROVADO" Then
                FrmCadastroOS.txtStatus.BackColor = Color.LightYellow
            End If
            If StatusTextBox.Text = "APROVADO" Then
                FrmCadastroOS.txtStatus.BackColor = Color.LightGreen
            End If

            '//CARREGA A PARTIR DO BD, UTILIZANDO O ID DO CONTATO

            FrmCadastroOS.cboCliente.Text = NomeClienteTextBox.Text
            Connect.Conectardb("SELECT * FROM tbContato")
            FrmCadastroOS.txtEndContato.Text = cdr.Item("Numero")
            Connect.Desconectardb()
            '//PREENCHE A TABELA DE OBSERVAÇÕES SOBRE A OS
            FrmCadastroOS.TbObservacaoTableAdapter.FillBy(FrmCadastroOS.SistemaGEDataSet.tbObservacao, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))

            '//PREENCHE A TABELA QUE SERA APRESENTADA AO USUARIO
            FrmCadastroOS.TbProdutoVenda1TableAdapter.FillBy(FrmCadastroOS.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))

            '//DEFINE A ALTURA DO DATAGRID VIEW DINAMICAMENTE
            FrmCadastroOS.dgvProdutosAdquiridos.Height = 40 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20.5)
            'FrmCadastroOS.grpGeral.Location = New Point(25, 500 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20.5))

            'CARREGAR PAGO E RESTANTE
            If OSIDTextBox.Text > 0 Then '\\VERIFICAR SE O NUMERO DA OS É VALIDO

                Connect.Conectardb("SELECT OSID, SUM(TotalServico) AS Total FROM tbProdutoVenda GROUP BY OSID HAVING (OSID =" & OSIDTextBox.Text & ")")

                If cdr.HasRows = True Then '\\VERIFICAR SE EXISTE DADOS RELACIONADO A OS NO BANCO DE DADOS

                    Dim ValorReceber As Double = cdr.Item("Total")
                    FrmCadastroOS.txtTotalOS.Text = Dinheiro(ValorReceber)
                    ' FrmCadastroOS.txtTotalOS.Text = ValorReceber

                End If
                Connect.Desconectardb()
            End If

            '//PREENCHER DATAGRID DE ADICIONAIS
            FrmCadastroOS.TbAdicionalPagoTableAdapter1.FillByOSS(FrmCadastroOS.DataSetX.tbAdicionalPago, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))
            FrmCadastroOS.DtResumoOSTableAdapter.Fill(FrmCadastroOS.DataPdv.dtResumoOS, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))
            Connect.Conectardb("SELECT * FROM SSomaAdicionalPago WHERE OSID=" & OSIDTextBox.Text)
            If cdr.HasRows = True Then
                On Error Resume Next
                Connect.Desconectardb()
            Else
                Connect.Desconectardb()
            End If
            FrmCadastroOS.txtDataAtual.Text = TbOSDataGridView.CurrentRow.Cells(4).Value
            If IsDBNull(TbOSDataGridView.CurrentRow.Cells(5).Value) Then
            Else
                FrmCadastroOS.txtDataAprovacao.Text = TbOSDataGridView.CurrentRow.Cells(5).Value
            End If
            FrmCadastroOS.txtCodCliente.Text = Me.CodClienteTextBox.Text
            Connect.Conectardb("SELECT * FROM tbClientes WHERE Código=" & CInt(Me.CodClienteTextBox.Text))
            If cdr.Item("CPF") <> Nothing Then
                FrmCadastroOS.txtCPF.Text = cdr.Item("CPF")
            Else
                MsgBox("CPF não cadastrado")
            End If

            '   If FrmConfiguracao.chkShowIEalerta.Checked = True Then
            '   If cdr.Item("InscricaoEstadual") <> DBNull Then
            '   FrmCadastroOS.txtProdutoID.Text = cdr.Item("InscricaoEstudal")
            ' Else
            '     MsgBox("Inscrição Estadual não cadastrado")
            ' End If
            ' End If
            Connect.Desconectardb()

            FrmCadastroOS.TbProdutoAgrupadoAdapter.Fill(FrmCadastroOS.DataPdv1.tbProdutoAgrupado, New System.Nullable(Of Integer)(CType(OSIDTextBox.Text, Integer)))

            FrmCadastroOS.SomaPedido()
            Me.Close()
        Else
            SQL.Notificao("", "Nenhuma OS  foi selecionada")
        End If

        If CodClienteTextBox.Text <> "" Then

            Dim objconn2 As New OleDbConnection(sConnectionString)
            Dim DataReader As OleDbDataReader

            Dim Para_CodEnd As New OleDbParameter
            With Para_CodEnd
                .ParameterName = "CodigoCliente"
                .OleDbType = OleDbType.Double
                .Size = 20
                .Value = CodClienteTextBox.Text
            End With

            ' Dim comando As New OleDbCommand("SELECT Logradouro, EndNumero as Numero, Bairro, Cidade, UF, Complemento, Tipo as Descricao,CodEnd as ID FROM tbEnd WHERE CodEnd=?", Conexao)

            'objConnection.Close()
            If objconn2.State = ConnectionState.Closed Then
                objconn2.Open()
            End If

            Dim objcmd As New OleDbCommand("SELECT Logradouro, EndNumero as Numero, Bairro, Cidade, UF, Complemento, Tipo as Descricao,CodEnd as ID FROM tbEnd WHERE CodEnd=?", objconn2)

            objcmd.Parameters.Add(Para_CodEnd)

            DataReader = objcmd.ExecuteReader()

            DataReader.Read()

            With FrmCadastroOS
                .txtEndRua.Text = DataReader(0).ToString
                .txtEndNumero.Text = DataReader(1).ToString
                .txtEndBairro.Text = DataReader(2).ToString
                .txtEndCidade.Text = DataReader(3).ToString
                .txtEndUF.Text = DataReader(4).ToString
                .lblComplemento.Text = DataReader(5).ToString
                .txtTipo.Text = DataReader(6).ToString
                .txtEndID.Text = DataReader(7).ToString

            End With

            DataReader.Close()
            DataReader = Nothing
            objconn2.Close()

        End If
    End Sub

    Private Sub TbOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs)
        Me.btnCarregarOS.PerformClick()
    End Sub

    Private Sub TbOSBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)
    End Sub

    Private Sub FrmCarregarOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbInicialPagoTableAdapter.Fill(Me.SistemaGEDataSet.tbInicialPago)
        Me.TbLancamentosTableAdapter.Fill(Me.SistemaGEDataSet.tbLancamentos)
        Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
        Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet.tbOS)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
        If rdPesquisaOS.Checked = True Then
            On Error Resume Next
            Me.TbOSTableAdapter.Filtro_OSID(Me.SistemaGEDataSet.tbOS, CType(txtPesquisa.Text, Integer))
        End If
        If rdPesquisaNomeCliente.Checked = True Then
            On Error Resume Next
            Me.TbOSTableAdapter.Fitro_Nome_Cliente(Me.SistemaGEDataSet.tbOS, txtPesquisa.Text)
        End If
        If rdDataAbertura.Checked = True Then
            On Error Resume Next
            Me.TbOSTableAdapter.FiltroDataAbertura(Me.SistemaGEDataSet.tbOS, New System.Nullable(Of Date)(CType(txtPesquisa.Text, Date)))
        End If
        If rdDataAbertura.Checked = True Then
            On Error Resume Next
            Me.TbOSTableAdapter.FitroDataAprovacao(Me.SistemaGEDataSet.tbOS, New System.Nullable(Of Date)(CType(txtPesquisa.Text, Date)))
        End If
        If rdTecResponsavel.Checked = True Then
            On Error Resume Next
            Me.TbOSTableAdapter.FiltroResponsavel(Me.SistemaGEDataSet.tbOS)
        End If
    End Sub

    Private Sub txtPesquisa_Click(sender As Object, e As EventArgs) Handles txtPesquisa.Click
        txtPesquisa.Text = ""
    End Sub

    Private Sub txtPesquisa_LostFocus(sender As Object, e As EventArgs) Handles txtPesquisa.LostFocus
        If txtPesquisa.Text = "" Then
            txtPesquisa.Text = "PESQUISE AQUI"
        End If
    End Sub

    Private Sub StatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles StatusTextBox.TextChanged
        If StatusTextBox.Text = "APROVADO" Then
            StatusTextBox.BackColor = Color.LightGreen
        End If
        If StatusTextBox.Text = "NÃO APROVADO" Then
            StatusTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub TbOSDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles TbOSDataGridView.DoubleClick
        btnCarregarOS.PerformClick()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub TbOSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbOSDataGridView.CellContentClick

    End Sub

End Class