Imports MaterialSkin
Imports System.Data.OleDb

Public Class FrmProdutos

        Inherits Controls.MaterialForm
        Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                GetDataCombo(cboEstoques, "SELECT Nome from tbEstoque")
                cboEstoques.Text = cboEstoques.Items(0).ToString
                Dim Instrucao As String = "SELECT Produto as PRODUTO,Unidade AS UNIDADE,Custo AS CUSTO,ValorVenda as VENDA,SaldoCritico as ESTOQUE_CRITICO,SaldoEstoque as SALDO_ESTOQUE FROM tbProdutoPDV"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Instrucao, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                TbProdutoPDVDataGridView.DataSource = dsbiblio.Tables("Cliente")
                lblStatus.Text = "Exibindo todos os produtos"
                Label35.Text = ""
                Label35.Text = "N° Itens : " + TbProdutoPDVDataGridView.Rows.Count.ToString
                With TbProdutoPDVDataGridView
                        .Columns(0).Width = 60%
                End With
        End Sub

        Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
                Me.Close()
        End Sub

        Private Sub btnAddPagRealizado_Click(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click
                FrmAdicionarProduto.ShowDialog()
        End Sub

        Private Sub btnExcluirProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirProduto.Click

                Dim resp As DialogResult = MsgBox("Essa operação não poderá ser desfeita, continuar operação?", vbYesNo, "NOVA LITORAL GESSO")
                If resp = DialogResult.Yes Then
                        lSQL = "DELETE FROM tbProdutoPDV WHERE ProdutoID=" & txtProdutoID.Text
                        SQL.Comando()
                        SQL.Notificao("NOVA LITORAL GESSO", "DELETADO COM SUCESSO")
                        ' Me.TbPrecoTabelaTableAdapter.Fill(Me.DataPdv.tbPrecoTabela)
                        ' Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
                Else
                        SQL.Notificao("NOVA LITORAL GESSO", "Operação cancelada pelo usuario")
                End If

        End Sub

        Private Sub btnEditPagRealizado_Click(sender As Object, e As EventArgs) Handles btnEditPagRealizado.Click
                lSQL = "UPDATE tbProdutoPDV SET Produto=""" & ProdutoTextBox.Text & """,Custo=""" & CustoTextBox.Text &
                                """,SaldoEstoque=""" & SaldoEstoqueTextBox.Text & """ WHERE ProdutoID=" & txtProdutoID.Text
                SQL.Comando()
                SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO EDITADO COM SUCESSO")
                Me.TbPrecoTabelaTableAdapter.Fill(Me.DataPdv.tbPrecoTabela)
                Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
                SQL.lSQL = ""
                SQL.Comando()
        End Sub

        Private Sub TbProdutoPDVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbProdutoPDVBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataPdv)
        End Sub

        Public Sub VerifTabele(textbox As TextBox)
                If textbox.Text = "" Then
                        textbox.Text = 0
                End If
        End Sub

        Private Sub btnMovimentacao_Click(sender As Object, e As EventArgs)
                FrmMovProduto.ShowDialog()
        End Sub

        Private Sub TbProdutoPDVDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TbProdutoPDVDataGridView.CellEnter
                Try
                        dgvCodBarras.DataSource = GetDR_Datagridview("SELECT CodBarraID as ID,CodBarra as Codigo FROM tbCodBarras WHERE ProdutoID=" & GetProdutoID(TbProdutoPDVDataGridView.CurrentRow.Cells(0).Value))
                Catch
                        MsgBox("erro " & TbProdutoPDVDataGridView.CurrentRow.Cells(0).Value)
                End Try



        End Sub

        Private Sub btnAddCodBaras_Click(sender As Object, e As EventArgs) Handles btnAddCodBaras.Click
                If IsNumeric(txtCodBarras.Text) = True And txtProdutoID.Text <> "" Then
                        InstrucaoDireta("INSERT INTO tbCodBarras(ProdutoID,CodBarra)" & "VALUES(""" & txtProdutoID.Text & """,""" & txtCodBarras.Text & """)")
                        txtCodBarras.Text = ""

                        System.Threading.Thread.Sleep(3000)
                        dgvCodBarras.DataSource = GetDR_Datagridview("SELECT CodBarraID as ID,CodBarra as Codigo FROM tbCodBarras WHERE ProdutoID=" & txtProdutoID.Text)
                End If
        End Sub

        Private Sub btnRemCodBarra_Click(sender As Object, e As EventArgs) Handles btnRemCodBarra.Click
                pbCodBarra.Value = 10
                Dim ID As Double = dgvCodBarras.CurrentRow.Cells(0).Value
                pbCodBarra.Value = 30
                If ID > 0 Then
                        InstrucaoDireta("DELETE * FROM tbCodBarras WHERE CodBarraID=" & ID)
                        pbCodBarra.Value = 60
                        System.Threading.Thread.Sleep(3000)
                        pbCodBarra.Value = 60
                        dgvCodBarras.DataSource = GetDR_Datagridview("SELECT CodBarraID as ID,CodBarra as Codigo FROM tbCodBarras WHERE ProdutoID=" & txtProdutoID.Text)
                        pbCodBarra.Value = 80
                End If
                pbCodBarra.Value = 100
        End Sub

        Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
                If e.KeyCode = Keys.Enter Then
                        btnAddCodBaras.PerformClick()
                End If
        End Sub

        Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
                Me.Close()
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click
                Application.Exit()
        End Sub

        Public Sub FiltroPorIncial(label As Label)
                Dim Letra As String = label.Text
                Dim Instrucao As String = "SELECT Produto as PRODUTO,Unidade AS UNIDADE,Custo AS CUSTO,ValorVenda as VENDA,SaldoCritico as ESTOQUE_CRITICO,SaldoEstoque as SALDO_ESTOQUE FROM tbProdutoPDV WHERE Estoque=" & EstoqueSelecionado & " AND Produto Like '" & Letra & "%'"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Instrucao, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                TbProdutoPDVDataGridView.DataSource = dsbiblio.Tables("Cliente")

                lblStatus.Text = "Filtrando por produtos que iniciam com a letra " & Letra

        End Sub

        Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
                FiltroPorIncial(Label8)
        End Sub

        Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
                FiltroPorIncial(Label9)
        End Sub

        Private Sub TbProdutoPDVDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbProdutoPDVDataGridView.CellContentClick

        End Sub

        Private Sub TbProdutoPDVDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TbProdutoPDVDataGridView.RowsRemoved
                Label35.Text = ""
                Label35.Text = "N° Itens: " + TbProdutoPDVDataGridView.Rows.Count.ToString
        End Sub

        Private Sub TbProdutoPDVDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TbProdutoPDVDataGridView.RowsAdded
                Label35.Text = ""
                Label35.Text = "N° Itens: " + TbProdutoPDVDataGridView.Rows.Count.ToString
        End Sub

        Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
                FiltroPorIncial(Label11)
        End Sub

        Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
                FiltroPorIncial(Label10)
        End Sub

        Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
                FiltroPorIncial(Label15)
        End Sub

        Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
                FiltroPorIncial(Label14)
        End Sub

        Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
                FiltroPorIncial(Label13)
        End Sub

        Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
                FiltroPorIncial(Label12)
        End Sub

        Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
                FiltroPorIncial(Label19)
        End Sub

        Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
                FiltroPorIncial(Label18)
        End Sub

        Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
                FiltroPorIncial(Label17)
        End Sub

        Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
                FiltroPorIncial(Label16)
        End Sub

        Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
                FiltroPorIncial(Label17)
        End Sub

        Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
                FiltroPorIncial(Label30)
        End Sub

        Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
                FiltroPorIncial(Label29)
        End Sub

        Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
                FiltroPorIncial(Label28)
        End Sub

        Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
                FiltroPorIncial(Label27)
        End Sub

        Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
                FiltroPorIncial(Label26)
        End Sub

        Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
                FiltroPorIncial(Label25)
        End Sub

        Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
                FiltroPorIncial(Label24)
        End Sub

        Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
                FiltroPorIncial(Label23)
        End Sub

        Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
                FiltroPorIncial(Label22)
        End Sub

        Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
                FiltroPorIncial(Label21)
        End Sub

        Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
                FiltroPorIncial(Label20)
        End Sub

        Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
                FiltroPorIncial(Label34)
        End Sub

        Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
                FiltroPorIncial(Label33)
        End Sub

        Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
                Dim Instrucao As String = "SELECT Produto as PRODUTO,Unidade AS UNIDADE,Custo AS CUSTO,ValorVenda as VENDA,SaldoCritico as ESTOQUE_CRITICO,SaldoEstoque as SALDO_ESTOQUE FROM tbProdutoPDV"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Instrucao, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                TbProdutoPDVDataGridView.DataSource = dsbiblio.Tables("Cliente")
                lblStatus.Text = "Exibindo todos os produtos"
                With TbProdutoPDVDataGridView
                        .Columns(0).Width = 60%
                End With
        End Sub

        Public EstoqueSelecionado As Double

        Private Sub cboEstoques_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstoques.SelectedIndexChanged
                Try
                        conexao1("SELECT * FROM tbEstoque WHERE Nome='" & cboEstoques.Text & "'")
                        bdr1.Read()
                        EstoqueSelecionado = bdr1(0)
                Catch ex As Exception
                        MsgBox(ex.ToString)
                End Try

                Dim Instrucao As String = "SELECT Produto as PRODUTO,Unidade AS UNIDADE,Custo AS CUSTO,ValorVenda as VENDA,SaldoCritico as ESTOQUE_CRITICO,SaldoEstoque as SALDO_ESTOQUE FROM tbProdutoPDV WHERE Estoque=" & EstoqueSelecionado
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Instrucao, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                TbProdutoPDVDataGridView.DataSource = dsbiblio.Tables("Cliente")

        End Sub

        Private Sub Button1_Click_2(sender As Object, e As EventArgs)
                conexao1("UPDATE tbProdutoPDV SET SaldoEstoque=""" & 10 & """")
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub TbProdutoPDVDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TbProdutoPDVDataGridView.CellFormatting
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
        End Sub
End Class