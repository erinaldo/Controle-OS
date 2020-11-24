Public Class FrmVisualizadorAnexos

    Private Sub FrmVisualizadorAnexos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataPdv.tbAnexoPDV'. Você pode movê-la ou removê-la conforme necessário.
        'Me.TbAnexoPDVTableAdapter.Fill(Me.DataPdv.tbAnexoPDV)
        Me.TbAnexoPDVTableAdapter.FillBySqlID(Me.DataPdv.tbAnexoPDV, New System.Nullable(Of Integer)(CType(SQL.AnexoID, Integer)))
    End Sub

End Class