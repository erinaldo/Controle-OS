Public Class FrmCodBarras
        Private Sub btnConfirmarEscolha_Click(sender As Object, e As EventArgs) Handles btnConfirmarEscolha.Click
                FrmPDV.txtQuantidade.Text = txtQuantidade.Text
                FrmPDV.btnAdicionarProduto.PerformClick()
	      Me.Close()
        End Sub

        Private Sub FrmCodBarras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                'txtNomeProduto.Text = FrmPDV.txtProduto.Text
                TxtEmEstoque.Text = FrmPDV.txtSaldoEstoque.Text
                txtNomeProduto.Text = cdr.Item("Produto")

        End Sub

        Private Sub btnAddQuant_Click(sender As Object, e As EventArgs) Handles btnAddQuant.Click
                If IsNumeric(TxtEmEstoque.Text) = True And IsNumeric(txtQuantidade.Text) = True Then
                        Dim Estoque As Double = CDbl(TxtEmEstoque.Text)
                        Dim Quantidade As Double = CDbl(txtQuantidade.Text)
                        If Quantidade < Estoque Then
                                txtQuantidade.Text += 1
                        Else
                                SQL.Notificao("", "Não estoque suficiente para adicionar mais")
                        End If
                End If
        End Sub

        Private Sub btnRetQuant_Click(sender As Object, e As EventArgs) Handles btnRetQuant.Click
                If txtQuantidade.Text > 0 Then
                        txtQuantidade.Text -= 1
                Else
                        txtQuantidade.Text = 0
                End If
        End Sub
End Class