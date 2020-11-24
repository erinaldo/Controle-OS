Public Class FrmCalendario

    Public DataInicio As Date
    Public Dias As Integer

    Public DataRef As Date

    Private Sub FrmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetAgenda.tbAgenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbAgendaTableAdapter.Fill(Me.DataSetAgenda.tbAgenda)
        'TODO: esta linha de código carrega dados na tabela 'DataSetAgenda.tbAgenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbAgendaTableAdapter.Fill(Me.DataSetAgenda.tbAgenda)
        'TODO: esta linha de código carrega dados na tabela 'DataSetX.tbCalendario'. Você pode movê-la ou removê-la conforme necessário.
        lstSegunda.Items.Add("Clóvis")

    End Sub

    Private Sub btnAddDia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubDia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TbAgendaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbAgendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAgenda)

    End Sub

End Class