Imports System.Data.OleDb

Public Class FrmDesenhoOS

    Private Sub FrmDesenhoOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet.tbOS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn("SELECT * FROM tbPedido2vinc")

        While cdr.Read

            lstPedidos.Items.Add(cdr(14))

        End While

    End Sub

    Private Sub conn(ByVal comando As String)

        If objConnection.State = ConnectionState.Closed Then
            objConnection.Open()
        End If

        Dim objcmd As New OleDbCommand(comando, objConnection)

        cdr = objcmd.ExecuteReader()

    End Sub

    Private Sub Desc()

        cdr = Nothing
        objConnection.Close()

    End Sub

End Class