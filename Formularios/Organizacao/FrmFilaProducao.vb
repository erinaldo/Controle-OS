Public Class FrmFilaProducao

    Private Sub FrmFilaProducao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbProdutoVenda1TableAdapter.FiltroOSeID(Me.SistemaGEDataSet.tbProdutoVenda1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TbProdutoVenda1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProdutoVenda1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lSQL = "UPDATE tbProdutoVenda SET StatusProducao=""" & "EM PRODUÇÃO" & """ WHERE OSID=" & txtOSID.Text & "and ID=" & txtVendaID.Text
        SQL.Comando()
        Me.TbProdutoVenda1TableAdapter.FiltroOSeID(Me.SistemaGEDataSet.tbProdutoVenda1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lSQL = "UPDATE tbProdutoVenda SET StatusProducao=""" & "PRODUTO CONCLUIDO" & """ WHERE OSID=" & txtOSID.Text & "and ID=" & txtVendaID.Text
        SQL.Comando()
        Me.TbProdutoVenda1TableAdapter.FiltroOSeID(Me.SistemaGEDataSet.tbProdutoVenda1)
    End Sub

End Class