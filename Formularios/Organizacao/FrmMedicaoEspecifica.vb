Public Class FrmMedicaoEspecifica

    Private Sub FrmMedicaoEspecifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbHistoricoMedicaoTableAdapter.FillByOSID(Me.SistemaGEDataSet.tbHistoricoMedicao, CType(FrmCadastroOS.txtOSID.Text, Integer))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Columns(5).DefaultCellStyle.Format = "c"
        DataGridView1.Columns(5).ValueType = GetType(Double)
    End Sub

End Class