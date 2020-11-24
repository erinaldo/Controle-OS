Imports System.IO

Public Class FrmPrestadores

    Public CaminhoImagem As String

    Private Sub TbGesseirosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbGesseirosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbGesseirosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)

    End Sub

    Private Sub FrmPrestadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbAnexos'. Você pode movê-la ou removê-la conforme necessário.
        '   Me.TbAnexosTableAdapter.Fill(Me.SistemaGEDataSet.tbAnexos)
        If txtDescricao.Text = "" Then
            btnAnexoP.Visible = True
            btnAnexoA.Visible = False
        Else
            btnAnexoP.Visible = False
            btnAnexoA.Visible = True
        End If
        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbGesseiros'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbGesseirosTableAdapter.Fill(Me.SistemaGEDataSet.tbGesseiros)

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub btnAnexarImagens_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAnexoA_Click(sender As Object, e As EventArgs) Handles btnAnexoA.Click
        OpenFileDialog1.ShowDialog()
        Connect.Conectardb("SELECT * FROM tbAnexos ORDER BY AnexoID DESC")
        Dim UltimoID As Double = cdr.Item("AnexoID")
        UltimoID = UltimoID + 1
        Dim Caminho As String = OpenFileDialog1.FileName
        Dim fi As New FileInfo(Caminho)
        If Caminho = "OpenFileDialog1" Then
            Connect.Desconectardb()
            GoTo encerrar
        End If
        fi.CopyTo("C:\Users\macks\Documents\ANEXOS\" & UltimoID & ".png")
        pctAnexos.ImageLocation = (Caminho)

        lSQL = "INSERT INTO tbAnexos (PrestadorID,Caminho,Descricao,DataAdicao)" &
            "VALUES (""" & TbGesseirosDataGridView.CurrentRow.Cells(0).Value & """,""" & Caminho & """,""" & txtDescricao.Text & """,""" & Today.ToShortDateString.ToString & """)"
        SQL.Comando()
        Connect.Desconectardb()
encerrar:
        txtDescricao.Text = ""
        Me.TbAnexosTableAdapter.Fill(Me.SistemaGEDataSet.tbAnexos)
    End Sub

    Private Sub btnAnexoP_Click(sender As Object, e As EventArgs) Handles btnAnexoP.Click
        MsgBox("Escreva uma descrição para continuar")
    End Sub

    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged
        If txtDescricao.Text = "" Then
            btnAnexoP.Visible = True
            btnAnexoA.Visible = False
        Else
            btnAnexoP.Visible = False
            btnAnexoA.Visible = True
        End If
    End Sub

    Private Sub TbGesseirosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbGesseirosDataGridView.CellContentClick

    End Sub

    Private Sub TbGesseirosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbGesseirosDataGridView.CellClick
        On Error Resume Next
        If txtAnexoID.Text = "" Then
            pctAnexos.ImageLocation = ""
        End If
        Me.TbAnexosTableAdapter.FillByPrestadorID(Me.SistemaGEDataSet.tbAnexos, New System.Nullable(Of Integer)(CType(TbGesseirosDataGridView.CurrentRow.Cells(0).Value, Integer)))
    End Sub

    Private Sub TbAnexosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbAnexosDataGridView.CellContentClick

    End Sub

    Private Sub TbAnexosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbAnexosDataGridView.CellClick
        Connect.Conectardb("SELECT * FROM tbAnexos WHERE AnexoID=" & txtAnexoID.Text)
        On Error Resume Next
        CaminhoImagem = cdr.Item("Caminho")
        pctAnexos.ImageLocation = (CaminhoImagem)
        Connect.Desconectardb()
    End Sub

End Class