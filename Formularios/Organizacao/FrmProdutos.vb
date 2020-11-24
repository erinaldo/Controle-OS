Public Class FrmProdutos

        Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.TbPrecoTabelaTableAdapter.Fill(Me.DataPdv.tbPrecoTabela)
                Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
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
                        Me.TbPrecoTabelaTableAdapter.Fill(Me.DataPdv.tbPrecoTabela)
                        Me.TbProdutoPDVTableAdapter.Fill(Me.DataPdv.tbProdutoPDV)
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

        Private Sub TbProdutoPDVBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbProdutoPDVBindingNavigatorSaveItem.Click
                Me.Validate()
                Me.TbProdutoPDVBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataPdv)
        End Sub

        Public Sub VerifTabele(textbox As TextBox)
                If textbox.Text = "" Then
                        textbox.Text = 0
                End If
        End Sub

        Private Sub btnMovimentacao_Click(sender As Object, e As EventArgs) Handles btnMovimentacao.Click
                FrmMovProduto.ShowDialog()
        End Sub

        Private Sub TbProdutoPDVDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TbProdutoPDVDataGridView.CellEnter
                dgvCodBarras.DataSource = GetDR_Datagridview("SELECT CodBarraID as ID,CodBarra as Codigo FROM tbCodBarras WHERE ProdutoID=" & GetProdutoID(TbProdutoPDVDataGridView.CurrentRow.Cells(0).Value))
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

        Private Sub TbProdutoPDVDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbProdutoPDVDataGridView.CellContentClick

        End Sub

        Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
                If e.KeyCode = Keys.Enter Then
                        btnAddCodBaras.PerformClick()
                End If
        End Sub
End Class