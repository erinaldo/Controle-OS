Imports System.Data.OleDb

Public Class FrmMedicoes

    Private Sub FrmMedicoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet2.tbGesseiros)
        Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet1.tbOS)
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet1.tbGesseiros)
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet.tbGesseiros)
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbMedicao)
        Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet.tbOS)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, dgvMestre.CellClick
        Me.TbGesseirosTableAdapter.FillByGesseiro(Me.SistemaGEDataSet.tbGesseiros, txtGesseiro.Text)
        dgvMestre.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvMestre.Visible = True
        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
        Me.TbMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbMedicao)
        Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet.tbOS)
    End Sub

    Private Sub btnInserirMedicao_Click(sender As Object, e As EventArgs) Handles btnInserirMedicao.Click

        Connect.Conectardb("SELECT * FROM tbOS WHERE OSID=" & txtOSID.Text)
        If cdr.Item("Status") = "NÃO APROVADO" Then
            SQL.Notificao("", "OS não aprovada")
            GoTo fim
            Connect.Desconectardb()
        Else
            Connect.Desconectardb()
        End If

        If txtMedicao.Text <> "" Then

            Connect.Conectardb("SELECT * FROM csHistoricoMedicao WHERE ID=" & txtID.Text)
            If cdr.HasRows = True Then
                txtAreaExecutada.Text = cdr.Item("Total de Medicao")
                Dim Soma As Double = CDbl(txtAreaExecutada.Text) + CDbl(txtMedicao.Text)
                Connect.Desconectardb()
                If Soma > CDbl(txtAreaPlanejada.Text) Then
                    MsgBox("Atenção, area planejada não pode ser menor do que a area executada")
                    GoTo fim
                Else
                    GoTo proxima
                End If
            Else
                Connect.Desconectardb()
proxima:
                If CDbl(txtMedicao.Text) > CDbl(txtAreaPlanejada.Text) Then
                    MsgBox("Atenção, area planejada não pode ser menor do que a area executada")
                    GoTo fim
                Else
                    Dim Lucro As Double = (txtTotalServico.Text / txtAreaPlanejada.Text) * txtMedicao.Text
                    txtValorPagar.Text = (txtMDOFechado.Text / txtAreaPlanejada.Text) * txtMedicao.Text
                    lSQL = "INSERT INTO tbHistoricoMedicao (OSID,ID,Data,Medicao,UNIDADE,NomeGesseiro,Observacao,Status,GesseiroID,AReceber,Descricao,Liberacao,Lucro)" &
                        "Values (""" & txtOSID.Text & """,""" & txtID.Text & """,""" & Today.ToShortDateString.ToString & """,""" &
                        txtMedicao.Text & """,""" & txtUnidade.Text & """,""" & txtGesseiro.Text & """,""" & txtObservacao.Text & """,""" & "NÃO PAGO" &
                        """,""" & txtCodGesseiro.Text & """,""" & txtValorPagar.Text & """,""" & txtNomeProduto.Text & """,""" & "AGUARDANDO LIBERAÇÃO" & """,""" & Lucro & """)"
                    SQL.Comando()
                    'lSQL = "SELECT * FROM csHistoricoMedicao WHERE ID=" & txtID.Text
                    Connect.Conectardb("SELECT * FROM csHistoricoMedicao WHERE ID=" & txtID.Text)
                    'objConn.Close()
                    'objConn.Open()
                    'Dim objcmd2 As New OleDbCommand(lSQL, objConn)
                    'dr = objcmd2.ExecuteReader(CommandBehavior.SingleRow)
                    'dr.Read()
                    txtAreaExecutada.Text = cdr.Item("Total de Medicao")
                    If CDbl(txtAreaExecutada.Text) > CDbl(txtAreaPlanejada.Text) Then
                        MsgBox("Atenção, area planejada não pode ser menor do que a area executada")
                        Connect.Desconectardb()
                    Else
                        SQL.Notificao("NOVA LITORAL GESSO", "MEDIÇÃO ADICIONADA COM SUCESSO")
                        Me.TbHistoricoMedicaoTableAdapter.Fill(Me.SistemaGEDataSet.tbHistoricoMedicao)
                        txtMedicao.Text = ""
                        Connect.Desconectardb()
                    End If
                End If
            End If
fim:
        Else
            SQL.Notificao("", "Preencha corretamente o campo de medição")
        End If
    End Sub

    Private Sub dgvEscravo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEscravo.CellClick
        lSQL = "SELECT * FROM csHistoricoMedicao WHERE ID=" & txtID.Text
        objConn.Close()
        objConn.ConnectionString = SQL.sConnectionString
        objConn.Open()
        Dim objcmd As New OleDbCommand(lSQL, objConn)
        dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
        dr.Read()
        If dr.HasRows = False Then
            GoTo Final
        Else
            txtAreaExecutada.Text = dr.Item("Total de Medicao")
Final:
            dr.Close()
            dr = Nothing
            objConn.Close()
        End If
        Me.TbGesseirosTableAdapter.FillByGesseiro(Me.SistemaGEDataSet.tbGesseiros, txtGesseiro.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtGesseiro_TextChanged(sender As Object, e As EventArgs)
        Me.TbGesseirosTableAdapter.FillByGesseiro(Me.SistemaGEDataSet.tbGesseiros, txtGesseiro.Text)
        On Error Resume Next
        txtCodGesseiro.Text = dgvAuxiliar.CurrentRow.Cells(0).Value
    End Sub

    Private Sub txtGesseiro_SelectedIndexChanged(sender As Object, e As EventArgs)
        If txtGesseiro.Text <> "" Then
            lSQL = "SELECT * FROM tbGesseiros WHERE Nome=" & txtGesseiro.Text
            objConn.Close()
            objConn.Open()
            Dim objcmd As New OleDbCommand(lSQL, objConn)
            dr = objcmd.ExecuteReader(CommandBehavior.SingleRow)
            dr.Read()
            txtCodGesseiro.Text = dr.Item("ID")
            dr.Close()
            dr = Nothing
            objConn.Close()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGesseiros.CellClick
        txtGesseiro.Text = dgvGesseiros.CurrentRow.Cells(0).Value
        txtCodGesseiro.Text = dgvGesseiros.CurrentRow.Cells(1).Value
    End Sub

    Private Sub dgvAuxiliar_TextChanged(sender As Object, e As EventArgs) Handles dgvAuxiliar.TextChanged
        On Error Resume Next
        txtCodGesseiro.Text = dgvAuxiliar.CurrentRow.Cells(0).Value
    End Sub

    Private Sub dgvAuxiliar_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAuxiliar.SelectionChanged
        On Error Resume Next
        txtCodGesseiro.Text = dgvAuxiliar.CurrentRow.Cells(0).Value
    End Sub

    Private Sub txtGesseiro_Click(sender As Object, e As EventArgs) Handles txtGesseiro.Click
        dgvGesseiros.Visible = True
    End Sub

    Private Sub txtGesseiro_LostFocus(sender As Object, e As EventArgs) Handles txtGesseiro.LostFocus
        dgvGesseiros.Visible = False
    End Sub

    Private Sub txtMedicao_TextChanged(sender As Object, e As EventArgs) Handles txtMedicao.TextChanged
        If txtMedicao.Text = "" Then
            txtMedicao.Text = 0
        End If
    End Sub

End Class