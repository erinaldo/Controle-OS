Imports System.Data.OleDb

Public Class FrmEditProduto

    Private Sub FrmEditProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbGesseiros'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet.tbGesseiros)
        On Error Resume Next
        Me.cboGesseiro.Text = FrmCadastroOS.dgvProdutosAdquiridos.CurrentRow.Cells(6).Value
        If FrmCadastroOS.dgvProdutosAdquiridos.CurrentRow.Cells(6).Value = "" Then
            MsgBox("Esse item não possui responsável, esta sendo atribuido ao Responsável Técnico pela O.S. podendo ser editado conforme necessidade")
            Me.cboGesseiro.Text = FrmCadastroOS.cboTecResp.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub cboGesseiro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGesseiro.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        'objConn.Close()
        'objConn.Open()
        'Dim objcmd As New OleDbCommand(lSQL, objConn)
        'dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        'dr.Read()
        'txtTipoProduto.Text = dr.Item("") '\\SERVE PARA SELECIONAR UM CAMPO EM ESPECIFICO
        'dr.Close()
        'dr = Nothing
        'objConn.Close()
        Dim Resultado As DialogResult = MessageBox.Show("Você esta prestes a excluir o produto/serviço " & cboDescricao.Text & " ID= " & txtProdutoID.Text &
                                                        " . Esta ação não podera ser desfeita, Deseja Continuar?", "Aviso de Exclusão", MessageBoxButtons.YesNo)
        If Resultado = 6 Then
            lSQL = "DELETE FROM tbProdutoVenda WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            SQL.Registro("Usuario", "PRODUTO " & cboDescricao.Text & " ID=" & txtProdutoID.Text & " EXCLUIDO")
            lSQL = "DELETE FROM tbFilaProducao WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            lSQL = "DELETE FROM tbMedicao WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            lSQL = "DELETE FROM tbHistoricoMedicao WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            SQL.Notificao("NOVA LITORAL GESSO", "PRODUTO EXCLUIDO COM SUCESSO")
        Else
            SQL.Notificao("NOVA LITORAL GESSO", "OPERAÇÃO CANCELADA PELO USUÁRIO")
        End If
        FrmCadastroOS.TbProdutoVenda1TableAdapter.FillBy(FrmCadastroOS.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
        FrmCadastroOS.dgvProdutosAdquiridos.Height = 300 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20)
        '  FrmCadastroOS.grpGeral.Location = New Point(25, 390 + (FrmCadastroOS.dgvProdutosAdquiridos.Rows.Count * 20))
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditarProduto.Click
        Dim Prestador As String
        '\\IDENTIFICA SE O PRESTADOR JÁ INICIOU O SERVIÇO EM QUESTÃO
        lSQL = "SELECT NomeGesseiro FROM tbMedicao WHERE ID=" & txtProdutoID.Text
        objConn.Close()
        objConn.Open()
        Dim objcmd As New OleDbCommand(lSQL, objConn)
        SQL.dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        Prestador = dr.Item("NomeGesseiro")
        If Prestador = "" Then
            MsgBox("Pode editar")
            lSQL = "UPDATE tbMedicao SET NomeGesseiro=""" & cboGesseiro.Text & """WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            lSQL = "UPDATE tbProdutoVenda SET Gesseiro=""" & cboGesseiro.Text & """WHERE ID=" & txtProdutoID.Text
            SQL.Comando()
            lSQL = "INSERT INTO tbObservacao (ObservacaoID,Observacao)" & "VALUES(""" & FrmCadastroOS.txtOSID.Text & """,""" & "" & """)"
            SQL.Comando()
        Else
            If Prestador <> cboGesseiro.Text Then
                MsgBox("Este serviço já foi iniciado pelo prestador " & Prestador & ", ao selecionar continuar será anexado ao campo de observação o nome do novo responsável " &
                       " (" & cboGesseiro.Text & ") " & " pelo item " & cboDescricao.Text & " - ID:" &
                   txtProdutoID.Text)
                Dim Justificativa As String
                FrmJustificativa.ShowDialog()
                Justificativa = FrmJustificativa.txtJustificativa.Text
                lSQL = "UPDATE tbMedicao SET NomeGesseiro=""" & cboGesseiro.Text & """WHERE ID=" & txtProdutoID.Text
                SQL.Comando()
                lSQL = "UPDATE tbProdutoVenda SET Gesseiro=""" & cboGesseiro.Text & """WHERE ID=" & txtProdutoID.Text
                SQL.Comando()
                Dim Observacao As String = "O serviço " & cboDescricao.Text & " referênte ao ID " & txtProdutoID.Text & " foi iniciado pele prestador " &
                    Prestador & " sendo repassado pelo mesmo ao prestador " & cboGesseiro.Text & " com a justificativa:" & Justificativa
                lSQL = "INSERT INTO tbObservacao (ObservacaoID,Observacao)" & "VALUES(""" & FrmCadastroOS.txtOSID.Text & """,""" & Observacao & """)"
                SQL.Comando()
            End If
        End If
        FrmCadastroOS.TbProdutoVenda1TableAdapter.FillBy(Me.SistemaGEDataSet.tbProdutoVenda1, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
        FrmCadastroOS.TbProdutoVenda2TableAdapter.FillByos(FrmCadastroOS.SistemaGEDataSet1.tbProdutoVenda2, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
        Me.Close()
    End Sub

End Class