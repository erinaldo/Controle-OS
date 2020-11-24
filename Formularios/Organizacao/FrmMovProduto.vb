Imports System.Data.OleDb

Public Class FrmMovProduto

    Public Ident As Double

    Public Sub PopularDataMov()
        Dim Consulta As String = "SELECT ProdutoID,Produto,SaldoEstoque,Unidade From tbProdutoPDV"
        Dim strConn As String = sConnectionString
        Dim conexao As New OleDbConnection(strConn)
        Dim comando As New OleDbCommand(Consulta, conexao)
        Dim adaptador As New OleDbDataAdapter(comando)
        Dim dsbiblio As New DataSet()
        adaptador.Fill(dsbiblio, "Cliente")
        dgvMovProduto.DataSource = dsbiblio.Tables("Cliente")
    End Sub

    Public Sub PopularDataMovCriterios(ByVal Produto As String)
        Dim Consulta As String = "SELECT ProdutoID,Produto,SaldoEstoque,Unidade FROM tbProdutoPDV WHERE Produto LIKE '%" & Produto & "%'"
        Dim strConn As String = sConnectionString
        Dim conexao As New OleDbConnection(strConn)
        Dim comando As New OleDbCommand(Consulta, conexao)
        Dim adaptador As New OleDbDataAdapter(comando)
        Dim dsbiblio As New DataSet()
        adaptador.Fill(dsbiblio, "Cliente")
        dgvMovProduto.DataSource = dsbiblio.Tables("Cliente")
    End Sub


    Private Sub dgvMovProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovProduto.CellContentClick

    End Sub

    Private Sub FrmMovProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataPdv.tbProdutoPDV'. Você pode movê-la ou removê-la conforme necessário.
        'Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)

        PopularDataMov()


    End Sub

    Private Sub btnSumProd_Click(sender As Object, e As EventArgs) Handles btnSumProd.Click
        If IsNumeric(txtQuanProd.Text) = True Then
            txtQuanProd.Text = txtQuanProd.Text + 1
        Else
            txtQuanProd.Text = 1
        End If
    End Sub

    Private Sub btnDimProd_Click(sender As Object, e As EventArgs) Handles btnDimProd.Click
        If IsNumeric(txtQuanProd.Text) = True Then
            txtQuanProd.Text = txtQuanProd.Text - 1
        Else
            txtQuanProd.Text = -1
        End If
    End Sub

    Private Sub dgvMovProduto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovProduto.CellEnter
        Ident = dgvMovProduto.CurrentRow.Cells(0).Value
        txtNomeProd.Text = dgvMovProduto.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnMov_Click(sender As Object, e As EventArgs) Handles btnMov.Click

        If txtQuanProd.Text <> 0 Then

            conexao1("SELECT * FROM tbProdutoPDV WHERE ProdutoID=" & Ident)

            bdr1.Read()
            Dim EstoqueAtual As Double = bdr1.Item("SaldoEstoque")
            Dim NovoEstoque As Double
            Dim ValorInserir As Double = txtQuanProd.Text
            Dim Operacao As String

            Select Case ValorInserir
                Case > 0
                    Operacao = "Entrada"
                Case < 0
                    Operacao = "Saída"
                Case Else

            End Select


            NovoEstoque = EstoqueAtual + ValorInserir

            InstrucaoDireta("UPDATE tbProdutoPDV SET SaldoEstoque=""" & NovoEstoque & """ WHERE ProdutoID=" & Ident)

            InstrucaoDireta("INSERT INTO tbMovEstoque (ProdutoID,Produto,Quantidade,Operacao,Origem,Usuario)" & "VALUES(""" & Ident & """,""" & txtNomeProd.Text & """,""" & txtQuanProd.Text & """,""" &
                            Operacao & """,""" & "Movimentação Manual" & """,""" & Usuario.Nome & """)")

            Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
            Desconexao1()
            txtQuanProd.Text = 0
            If chkMultiMov.Checked = False Then
                Me.Close()
            End If
        End If
        PopularDataMovCriterios(Pesquisa)


    End Sub

    Private Sub txtNomeProd_TextChanged(sender As Object, e As EventArgs) Handles txtNomeProd.TextChanged

    End Sub

    Private Sub btnBorracha_Click(sender As Object, e As EventArgs) Handles btnBorracha.Click
        txtNomeProd.Text = ""
        PopularDataMov()
        Pesquisa = ""
    End Sub

    Public Pesquisa As String
    Private Sub sadf_Click(sender As Object, e As EventArgs) Handles sadf.Click
        Pesquisa = txtNomeProd.Text
        PopularDataMovCriterios(Pesquisa)

    End Sub

    Private Sub txtNomeProd_DoubleClick(sender As Object, e As EventArgs) Handles txtNomeProd.DoubleClick
        txtNomeProd.Text = ""
    End Sub
End Class