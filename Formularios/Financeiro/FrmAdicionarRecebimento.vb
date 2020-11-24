Public Class FrmAddRecebimento

    Private Sub FrmAddRecebimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDataRecebimento.Text = MonthCalendar1.TodayDate.ToShortDateString.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtValor_Enter(sender As Object, e As EventArgs) Handles txtValor.Enter
        Me.txtValor.BackColor = Color.White
    End Sub

End Class