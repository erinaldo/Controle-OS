Public Class FrmDesingOS

    Private Sub FrmDesingOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics

        Dim p As Pen

        g.DrawLine(p, 200, 200, 2, 200)

    End Sub

End Class