Public Class FrmRelatorioVisita

    Private Sub FrmRelatorioVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbRelatorioVisitaTableAdapter.Fill(Me.DataSetX.tbRelatorioVisita)
        Me.TbOSTableAdapter.Fill(Me.DataSetX.tbOS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInserirRelatorio.Click
        If txtRelatorioOS.Text <> "" Then
            lSQL = "INSERT INTO tbRelatorioVisita (OSID,Responsavel,Relatorio,Data)" & "VALUES (""" & dgvListaOS.CurrentRow.Cells(0).Value &
            """,""" & SQL.Usuario & """,""" & txtRelatorioOS.Text & """,""" & Today.ToShortDateString.ToString & """)"
            SQL.Comando()
            Me.TbRelatorioVisitaTableAdapter.Fill(Me.DataSetX.tbRelatorioVisita)
            SQL.Notificao("NOVA LITORAL GESSO", "RELATÓRIO REFERENTE A OS N° " & dgvListaOS.CurrentRow.Cells(0).Value & " CADASTRADO COM SUCESSO")
        Else
            SQL.Notificao("NOVA LITORAL GESSO", "O CAMPO SE ENCONTRA EM BRANCO")
        End If

    End Sub

    Private Sub dgvListaOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaOS.CellClick
        dgvListaOS.Visible = False
    End Sub

    Private Sub btnDgvAnterior_Click(sender As Object, e As EventArgs) Handles btnDgvAnterior.Click
        dgvListaOS.Visible = True
    End Sub

    Private Sub txtRelatorioOS_Click(sender As Object, e As EventArgs) Handles txtRelatorioOS.Click
        txtRelatorioOS.Text = ""
    End Sub

    Private Sub txtRelatorioOS_LostFocus(sender As Object, e As EventArgs) Handles txtRelatorioOS.LostFocus
        If txtRelatorioOS.Text = "" Then
            txtRelatorioOS.Text = "INFORME BREVEMENTE INFORMAÇÕES SOBRE A SITUAÇÃO DO LOCAL DE VISITA "
        End If
    End Sub

End Class