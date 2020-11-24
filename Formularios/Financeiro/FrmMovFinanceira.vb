Imports System.Data.OleDb

Public Class FrmMovFinanceira

    Private Sub FrmMovFinanceira_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim consulta As String = "SELECT MovFinanID as ID, Data, Hora, Usuario, Descricao, ValorMov as Valor, TipoMov as Tipo ,LancaID as lancamento FROM tbMovFinan ORDER BY Hora Desc"
        Dim strConn As String = sConnectionString
        Dim conexao As New OleDbConnection(strConn)
        Dim comando As New OleDbCommand(consulta, conexao)
        Dim adaptador As New OleDbDataAdapter(comando)
        Dim dsbiblio As New DataSet()
        adaptador.Fill(dsbiblio, "Cliente")
        dgvMov.DataSource = dsbiblio.Tables("Cliente")

    End Sub

    Private Sub dgvMov_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMov.CellContentClick

    End Sub

    Private Sub dgvMov_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMov.CellFormatting
        If e.ColumnIndex = 6 Then
            If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                GoTo line1
            End If
            If (e.Value.ToString = ("Entrada")) Then
                ' e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Green
            End If
        End If
line1:
        If e.ColumnIndex = 6 Then
            If IsNothing(e.Value) Or IsDBNull(e.Value) Then
                GoTo line2
            End If
            If (e.Value.ToString = ("Saída")) Then
                ' e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
line2:
        dgvMov.Columns("Valor").DefaultCellStyle.Format = "C2"
        dgvMov.Columns("Hora").DefaultCellStyle.Format = "t"
    End Sub

End Class