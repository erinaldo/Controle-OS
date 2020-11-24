Imports System.Data.OleDb

Public Class FrmContexLancamento

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If FrmNovoLancamento.dgvFinanceiro.SelectedRows.Count > 1 Then

            Dim Resp As DialogResult = MsgBox("Você está prestes a excluir " & FrmNovoLancamento.dgvFinanceiro.SelectedRows.Count.ToString & " lançamentos , Deseja continuar com a operação?", MsgBoxStyle.YesNo, "Multi-Exclusão")

            If Resp = DialogResult.Yes Then
                btnPegarLinhas("delete")
                modGeral.AtualizarGDVfinanceiro()
                Me.Close()
            Else
                SQL.Notificao("", "A operação foi cancela pelo usuario")
            End If
        Else
            If FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells("Identificação").Value > 0 Then
                Dim Resp As DialogResult = MsgBox("Deseja realmente excluir esse lançamento, o opereção não podera ser desfeita", MsgBoxStyle.YesNo, "All-In-One")
                If Resp = DialogResult.Yes Then
                    Dim Para_ID As New OleDbParameter
                    With Para_ID
                        .ParameterName = "SenhaUsuario"
                        .OleDbType = OleDbType.Char
                        .Size = 10
                        .Value = FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells("Identificação").Value
                    End With
                    Dim consulta As String = "DELETE FROM tbFinanceiro WHERE Identificacao=?"
                    Dim objInicio As New OleDbConnection(sConnectionString)
                    If objInicio.State = ConnectionState.Closed Then
                        objInicio.Open()
                    End If
                    Dim objcmd As New OleDbCommand(consulta, objInicio)
                    objcmd.Parameters.Add(Para_ID)
                    Dim cdr As OleDbDataReader = objcmd.ExecuteReader()
                    cdr.Read()

                    '================================================

                    lSQL = "UPDATE tbMovFinan SET ValorMov=""" & "0" & """,Descricao=""" & "O Lançamento referente a essa movimentação foi excluido" & """ WHERE LancaID= " & Para_ID.Value

                    SQL.Comando()

                    '================================================

                    objcmd.Parameters.Clear()
                    objcmd.Dispose()
                    objInicio.Dispose()
                    consulta = ""
                    cdr.Close()
                    Me.Close()

                    modGeral.AtualizarGDVfinanceiro()

                    SQL.Notificao("", "Lançamento excluido com sucesso")
                Else
                    SQL.Notificao("", "Não foi possivel localizar o lançamento desejado")
                End If
            Else
                SQL.Notificao("", "Operação cacelada pelo usuario")
            End If
        End If
        FrmNovoLancamento.SomaPago()
    End Sub

    Private Sub btnDetalhar_Click(sender As Object, e As EventArgs) Handles btnDetalhar.Click
        FrmDetLan.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FrmContexLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(MousePosition.X - 15, MousePosition.Y - 5)
    End Sub

    Private Sub FrmContexLancamento_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs)

        If FrmNovoLancamento.dgvFinanceiro.SelectedRows.Count > 1 Then

            Dim Resp As DialogResult = MsgBox("Você definira " & FrmNovoLancamento.dgvFinanceiro.SelectedRows.Count.ToString & " lançamentos como pago , Deseja continuar?", MsgBoxStyle.YesNo, "Multi-Pagamentos")

            If Resp = DialogResult.Yes Then

                btnPegarLinhas("update")

                modGeral.AtualizarGDVfinanceiro()

                FrmNovoLancamento.SomaPago()

                Me.Close()
            End If
        Else
            Dim Resp As DialogResult = MsgBox("Deseja definir como lançamento ID: " & FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells(0).Value & " como pago?", MsgBoxStyle.YesNo, "Definir como Pago")

            If Resp = DialogResult.Yes Then

                If FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells(4).Value = "Não Pago" Then

                    On Error Resume Next

                    Ident = FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells(0).Value

                    'Ident = FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells(4).Value
                    lSQL = "UPDATE tbFinanceiro SET Situacao=""" & "Foi Pago" & """ WHERE Identificacao=" & Ident
                    SQL.Comando()
                    AtualizarGDVfinanceiro()
                    SQL.Notificao("", "Pagamento Realizao com Sucesso")
                    FrmNovoLancamento.SomaPago()

                    conexao1("SELECT Descricao FROM tbFinanceiro WHERE Identificacao=" & Ident)
                    bdr1.Read()

                    Dim Desc As String = bdr1.Item("Descricao")
                    Valor = FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells(7).Value
                    Dim TipoFinan As String = FrmNovoLancamento.dgvFinanceiro.CurrentRow.Cells("Tipo").Value

                    Select Case TipoFinan
                        Case "Receita"
                            TipoFinan = "Entrada"

                        Case "Despesa"
                            TipoFinan = "Saída"

                        Case Else
                            MsgBox("Problema !!! , tipo lancamento")

                    End Select

                    MovimentaoFinanceira(Desc, Valor, TipoFinan, Ident)

                    Me.Close()
                Else
                    SQL.Notificao("", "O lançamento já está definido como pago")
                    Me.Close()
                End If
            Else
                SQL.Notificao("", "Operação cancelada pelo usuario")
            End If
        End If
    End Sub

    Public Sub btnPegarLinhas(operacao As String)
        Try
            For Each item In GetLinhasSelecionadas()

                Select Case operacao
                    Case "update"
                        lSQL = "UPDATE tbFinanceiro SET Situacao=""" & "Foi Pago" & """ WHERE Identificacao=" & item
                        SQL.Comando()

                        '==========================================================================

                        conexao1("SELECT Identificacao,Tipo,Valor,Descricao FROM tbFinanceiro ORDER BY Identificacao Desc")

                        bdr1.Read()

                        Dim UltimaIdent As Double = bdr1.Item("Identificacao")
                        Dim TipoFinan As String = bdr1.Item("Tipo")
                        Dim Desc As String = bdr1.Item("Descricao")

                        conexao2("SELECT Identificacao,Tipo,Valor,Descricao FROM tbFinanceiro WHERE Identificacao = " & item)

                        bdr2.Read()

                        Valor = bdr2.Item("Valor")

                        Select Case TipoFinan
                            Case "Receita"
                                TipoFinan = "Entrada"

                            Case "Despesa"
                                TipoFinan = "Saída"

                            Case Else
                                MsgBox("Problema !!! , tipo lancamento")

                        End Select

                        MovimentaoFinanceira(Desc, Valor, TipoFinan, item)

                '==========================================================================

                    Case "delete"
                        lSQL = "DELETE FROM tbFinanceiro WHERE Identificacao=" & item
                        SQL.Comando()

                        lSQL = "UPDATE tbMovFinan SET ValorMov=""" & "0" & """,Descricao=""" & "O Lançamento referente a essa movimentação foi excluido" & """ WHERE LancaID= " & item
                        SQL.Comando()

                    Case Else

                End Select

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Function GetLinhasSelecionadas() As List(Of String)
        If FrmNovoLancamento.dgvFinanceiro.SelectedRows.Count > 0 Then
            Dim dgvColecaoLinhasSelecionadas As DataGridViewSelectedRowCollection = FrmNovoLancamento.dgvFinanceiro.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To dgvColecaoLinhasSelecionadas.Count - 1
                Dim id As Integer = dgvColecaoLinhasSelecionadas(i).Cells(0).Value
                ids.Add(id.ToString)
            Next
            Return ids
        Else
            Throw New Exception("Não existem linhas selecionadas !!")
        End If

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

End Class