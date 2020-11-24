Imports System.Data.OleDb

Public Class FrmRelatorios

    Public cdr1 As OleDbDataReader
    Public cdr2 As OleDbDataReader
    Public cdr3 As OleDbDataReader
    Public connObj1 As New OleDbConnection(sConnectionString)
    Public connObj2 As New OleDbConnection(sConnectionString)
    Public connObj3 As New OleDbConnection(sConnectionString)

    '==============================================CONEXÕES=============================================================================
    Public Sub ConnItem1(sql1)

        connObj1.Open()
        Dim objcmd As New OleDbCommand(sql1, connObj1)
        cdr1 = objcmd.ExecuteReader()
        'cdr1.Read()

    End Sub

    Public Sub DesItem1()
        cdr1.Close()
        cdr1 = Nothing
        connObj.Close()
    End Sub

    Public Sub ConnItem2(sql2)

        If connObj.State = ConnectionState.Closed Then
            connObj.Open()
        End If
        Dim objcmd As New OleDbCommand(sql2, connObj)
        cdr2 = objcmd.ExecuteReader()
        'cdr2.Read()

    End Sub

    Public Sub DesItem2()
        cdr2.Close()
        cdr2 = Nothing
        connObj.Close()
    End Sub

    Public Sub ConnItem3(sql3)

        connObj.Open()
        Dim objcmd As New OleDbCommand(sql3, connObj)
        cdr1 = objcmd.ExecuteReader()
        cdr1.Read()

    End Sub

    Public Sub DesItem3()
        cdr3.Close()
        cdr3 = Nothing
        connObj.Close()
    End Sub

    Public NoRaiz As TreeNode = Nothing
    Public NoPrincipal As TreeNode = Nothing
    Public NoFilho As TreeNode = Nothing
    Public Pedido As String
    Public nodeDetalhe = New TreeNode()
    Public nodeCliente = New TreeNode()
    Public nodePedido = New TreeNode()

    Private Sub Exibir_Click(sender As Object, e As EventArgs) Handles Exibir.Click

        tvOS.Nodes.Clear()

        ConnItem1("SELECT * FROM tbOS ORDER by OSID Desc")
        Dim linhaNo As Integer = 0

        While cdr1.Read()

            Dim no As String = cdr1(0).ToString
            ' tvOS.Nodes.Add(no)

            With nodeDetalhe

                .ImageIndex = 3

                .Tag = "detalhe"

                .Text = no

            End With

            ConnItem2("SELECT * FROM tbPedido2vinc WHERE OSID =" & no)

            While cdr2.Read()

                Pedido = cdr2(14).ToString
                '  tvOS.Nodes.Add(pedido)

            End While
            Dim index = 1

            tvOS.Nodes(nodeCliente.Index).Nodes(nodePedido.Index).Nodes.Add(nodeDetalhe)

        End While

                ' MultiDesconectardb()

        End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandir.Click

    End Sub

    '=========================================================================

    'nodeDetalhe = New TreeNode()

    'Atualizamos suas propriedades para armazenar o registro com os detalhes do pedido

    'With nodeDetalhe
    '
    ' .ImageIndex = 3
    '
    '  .Tag = "detalhe"

    '        .Text = drClientes("Quantidade") & " - " & drClientes("NomeDoProduto") & " - " & "R$ " & FormatNumber(drClientes("PreçoUnitário"), 2)

    'End With

    '  tvOS.Nodes(nodeCliente.Index).Nodes(nodePedido.Index).Nodes.Add(nodeDetalhe)

End Class