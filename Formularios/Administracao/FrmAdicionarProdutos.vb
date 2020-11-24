Imports System.Data.OleDb

Public Class FrmAdicionarProduto

        Private Sub btnAddPagRealizado_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
                'VERIFICAR O ID DO ESTOQUE
                Dim EstoqueID As Integer = GetEstoqueID(cboEscolhaEstoque.Text)

                'INSERIR PRODUTO PDV
                PutProdutoPDV(txtProduto.Text, txtUnidade.Text, txtQuantidade.Text, txtValorUnitario.Text, txtCustoMDO.Text, cboTipoProduto.Text, cboEscolhaEstoque.Text)

                'OBTER ULTIMO PRODUTOID
                Dim ProdutoID As Double = GetProdutoID(txtProduto.Text)

                Dim CodBarraList As New List(Of Double)
                Dim l As Integer = dgvCodBarras.Rows.Count - 1

                Do Until l < 0
                        CodBarraList.Add(dgvCodBarras.Item(0, l).Value)
                        l -= 1
                Loop

                PutCodBarras(CodBarraList, ProdutoID)

                FrmProdutos.TbPrecoTabelaTableAdapter.Fill(FrmProdutos.DataPdv.tbPrecoTabela)
                FrmProdutos.TbProdutoPDVTableAdapter.Fill(FrmProdutos.DataPdv.tbProdutoPDV)

                SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO ADICIONADO COM SUCESSO")

                'MULTI CADASTRO
                If chkMultiCadastro.Checked = False Then
                        Me.Close()
                End If

        End Sub

        Private Sub FrmAdicionarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                With cboTipoProduto.Items
                        .Add("REVENDA")
                        .Add("FABRICAÇÃO")
                        .Add("SERVIÇO")
                End With
                GetDataCombo(cboEscolhaEstoque, "SELECT Nome FROM tbEstoque")
                'dgvCodBarras.Dispose()

        End Sub

        Private Sub btnAddCodBaras_Click(sender As Object, e As EventArgs) Handles btnAddCodBaras.Click

                If IsNumeric(txtCodBarras.Text) = True Then
                        With dgvCodBarras
                                .Rows.Add(txtCodBarras.Text)
                        End With
                        txtCodBarras.Text = ""
                End If
        End Sub

        Private Sub btnRemCodBarra_Click(sender As Object, e As EventArgs) Handles btnRemCodBarra.Click
                dgvCodBarras.Rows.Remove(dgvCodBarras.CurrentRow)
        End Sub
End Class