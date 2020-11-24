Imports System.Data.OleDb

Public Class FrmAndamentoDaOS

    Private Sub FrmAndamentoDaOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbAndamentoOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbAndamentoOSTableAdapter.Fill(Me.SistemaGEDataSet.tbAndamentoOS)
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbAndamentoOS'. Você pode movê-la ou removê-la conforme necessário.
        ' If dgvAndamentoOS.CurrentRow
        '  dgvAndamentoOS.CurrentRow.DefaultCellStyle.BackColor = Color.Red Then

    End Sub

    Private Sub dgvAndamentoOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAndamentoOS.CellClick
        Dim sql As String = "SELECT * FROM tbAndamentoOS WHERE OSID=" & dgvAndamentoOS.CurrentRow.Cells(0).Value

        objConn.Close()
        objConn.Open()
        Dim objcmd As New OleDbCommand(sql, objConn)
        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        If dr.HasRows = True Then
        End If

    End Sub

    Private Sub dgvAndamentoOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAndamentoOS.CellContentClick

    End Sub

    Private Sub dgvAndamentoOS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAndamentoOS.CellFormatting

        Dim ColAtual As Double = e.ColumnIndex

        If (e.Value.ToString <> "") Then

            If e.ColumnIndex = 1 Then
                If (e.Value.ToString = ("VISITA")) Then
                    e.CellStyle.BackColor = Color.Orange
                    e.CellStyle.ForeColor = Color.White
                End If
            End If

            If e.ColumnIndex = 2 Then
                If (e.Value.ToString = ("ORÇAMENTO")) Then
                    e.CellStyle.BackColor = Color.Blue
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 3 Then
                If (e.Value.ToString = ("PAGAMENTO")) Then

                    e.CellStyle.BackColor = Color.Yellow
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 4 Then
                If (e.Value.ToString = ("INICIO")) Then

                    e.CellStyle.BackColor = Color.Purple
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 5 Then
                If (e.Value.ToString = ("LIMPEZA")) Then

                    e.CellStyle.BackColor = Color.Pink
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 6 Then
                If (e.Value.ToString = ("VISTORIA FINAL")) Then

                    e.CellStyle.BackColor = Color.Brown
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 6 Then
                If (e.Value.ToString = ("OBRA FINALIZADA")) Then

                    e.CellStyle.BackColor = Color.Green
                    e.CellStyle.ForeColor = Color.White
                    'e.CellStyle.Font.FontFamily = True

                End If
            End If
        End If

    End Sub

End Class