Public Class FrmEntregaOS

    Private Sub FrmEntregaOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetX.tbEntrega'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbEntregaTableAdapter.Fill(Me.DataSetX.tbEntrega)
        On Error Resume Next
        Me.TbEntregaTableAdapter.FillByOS(Me.DataSetX.tbEntrega, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))

    End Sub

    Private Sub TbEntregaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbEntregaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbEntregaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetX)
    End Sub

End Class