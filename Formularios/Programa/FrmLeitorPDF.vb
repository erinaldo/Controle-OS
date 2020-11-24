Public Class FrmLeitorPDF

    Public NomeDocumento As String

    Private Sub ABRIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABRIRToolStripMenuItem.Click
        AbrirPDF()
    End Sub

    Private Sub AbrirPDF()
        ofdAbrirPDF.ShowDialog()
        AxAcroPDF1.src = ofdAbrirPDF.FileName
    End Sub

End Class