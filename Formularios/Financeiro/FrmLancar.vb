Public Class FrmLancar

    Private Sub FrmLancar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetX1.Opcoes'. Você pode movê-la ou removê-la conforme necessário.
        Me.OpcoesTableAdapter.Fill(Me.DataSetX1.Opcoes)
        'TODO: esta linha de código carrega dados na tabela 'DataSetX.tbFinanceiro'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbFinanceiroTableAdapter.Fill(Me.DataSetX.tbFinanceiro)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TbFinanceiroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbFinanceiroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbFinanceiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetX)

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub TbFinanceiroDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbFinanceiroDataGridView.CellContentClick

    End Sub

    Private Sub rdFiltroTodos_Click(sender As Object, e As EventArgs) Handles rdFiltroTodos.Click
        rdFiltroTodos.Checked = True
        rdNaoPago.Checked = False
        rdPago.Checked = False
        Me.TbFinanceiroTableAdapter.Fill(Me.DataSetX.tbFinanceiro)
    End Sub

    Private Sub rdPago_Click(sender As Object, e As EventArgs) Handles rdPago.Click
        rdFiltroTodos.Checked = False
        rdNaoPago.Checked = False
        rdPago.Checked = True
        Me.TbFinanceiroTableAdapter.FillByPago(Me.DataSetX.tbFinanceiro)
    End Sub

    Private Sub rdNaoPago_CheckedChanged(sender As Object, e As EventArgs) Handles rdNaoPago.CheckedChanged

    End Sub

    Private Sub rdNaoPago_Click(sender As Object, e As EventArgs) Handles rdNaoPago.Click
        rdFiltroTodos.Checked = False
        rdNaoPago.Checked = True
        rdPago.Checked = False
        Me.TbFinanceiroTableAdapter.FillByNaoPago(Me.DataSetX.tbFinanceiro)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub TbFinanceiroDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles TbFinanceiroDataGridView.DataBindingComplete
        SQL.Notificao("", "Foram encotrados  " & TbFinanceiroDataGridView.Rows.Count & " registros")
    End Sub

    Private Sub TbFinanceiroDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbFinanceiroDataGridView1.CellContentClick

    End Sub

    Private Sub TbFinanceiroDataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TbFinanceiroDataGridView1.CellFormatting
        'If (e.Value.ToString <> "") Then
        '  Dim ColAtual As Double = e.ColumnIndex
        'If e.ColumnIndex = 3 Then
        '   If (e.Value.ToString = ("Despesa")) Then
        '  e.CellStyle.BackColor = Color.Red
        ' e.CellStyle.ForeColor = Color.Red
        'End If
        'End If
        '  End If
    End Sub

    'If e.ColumnIndex = 2 Then
    ' If (e.Value.ToString = ("Receita")) Then
    '     e.CellStyle.BackColor = Color.Green
    '      e.CellStyle.ForeColor = Color.Green
    '   End If
    'End If
    'If e.ColumnIndex = 8 Then
    ' If (e.Value.ToString < (Today.ToShortDateString)) Then
    '     e.CellStyle.BackColor = Color.Green
    '      e.CellStyle.ForeColor = Color.White
    '   End If
    'End If
    ' If e.ColumnIndex = 8 Then
    ' If (e.Value.ToString > (Today.ToShortDateString)) Then
    '     e.CellStyle.BackColor = Color.Red
    '      e.CellStyle.ForeColor = Color.White
    '   End If
    ' End If
    'End If
    'End Sub

    Private Sub TbFinanceiroDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TbFinanceiroDataGridView.CellFormatting
        TbFinanceiroDataGridView.Columns(10).DefaultCellStyle.Format = "c"
        TbFinanceiroDataGridView.Columns(10).ValueType = GetType(Double)
        TbFinanceiroDataGridView.Columns(11).DefaultCellStyle.Format = "c"
        TbFinanceiroDataGridView.Columns(11).ValueType = GetType(Double)
        If (e.Value.ToString <> "") Then
            Me.TbFinanceiroTableAdapter.Fill(Me.DataSetX.tbFinanceiro)

            '   If (e.Value.ToString <> "") Then

            If e.ColumnIndex = 3 Then
                If (e.Value.ToString = ("Receita")) Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.Red
                End If
            End If
            If e.ColumnIndex = 3 Then
                If (e.Value.ToString = ("Despesa")) Then
                    e.CellStyle.BackColor = Color.Green
                    e.CellStyle.ForeColor = Color.Green
                End If
            End If
            If e.ColumnIndex = 8 Then
                If (e.Value.ToString < (Today.ToShortDateString)) Then
                    e.CellStyle.BackColor = Color.Green
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
            If e.ColumnIndex = 8 Then
                If (e.Value.ToString > (Today.ToShortDateString)) Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
        End If
        ' End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

End Class