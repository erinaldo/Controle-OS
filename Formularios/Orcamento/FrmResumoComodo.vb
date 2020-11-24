Imports System.Data.OleDb

Public Class FrmResumoComodo

    Public objConn1, objConn2, objConn3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Empresa\Dev\DataBase\SistemaGE.mdb;Persist Security Info=True;Jet OLEDB:Database Password=AezakmiPdnejoh")

    Public bdr1, bdr2, bdr3 As OleDbDataReader

    Private Sub FrmResumoComodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularLST()
        'tmPopularLST.Start()
    End Sub

    Public Sub PopularLST()

        Dim font As New Font("Times New Roman", 9)
        Dim font2 As New Font("Times New Roman", 9)

        Dim X, Y, Quant As Double

        X = 5
        Y = 5
        Dim Largura As Double = 200
        Dim Altura As Double = 300
        Dim EspacoHorizontal As Double = 5

        Dim dias As New List(Of String)
        Dim ContDia As Double = 1

        Dim drPorAmbiente As OleDbDataReader

        Dim OSID = 384 'FrmCadastroOS.txtOSID.Text

        Dim drLocais As OleDbDataReader = conexao("SELECT LocalServico FROM tbProdutoVenda WHERE OSID=" & OSID & " GROUP BY LocalServico")
        Dim drCompleta As OleDbDataReader = conexao("SELECT * FROM tbProdutoVenda WHERE OSID=" & OSID)

        While drLocais.Read

            drPorAmbiente = conexao("SELECT * FROM tbProdutoVenda WHERE LocalServico='" & drLocais(0) & "' AND OSID=" & OSID)

            Dim lst As New ListView
            lst.View = View.List
            lst.Items.Clear()

            lst.Items.Add(drLocais(0))
            lst.Font = font
            lst.Items.Add("----------------------------------------")

            While drPorAmbiente.Read

                Dim calendario As New MonthCalendar

                With lst
                    .Font = font2
                    .BackColor = Color.LightGray
                    .Width = Largura
                    .Height = Altura

                    .Items.Add(drPorAmbiente("Descricao") & " (" & drPorAmbiente("Status") & ")")
                    '.Items.Add(drPorAmbiente("Status"), My.)

                End With

                Dim drMedicao As OleDbDataReader = conexao("SELECT SUM(Medicao) AS TotalMedicao, ID FROM tbHistoricoMedicao GROUP BY ID HAVING (ID =" & drPorAmbiente("ID") & ")")
                drMedicao.Read()

                Dim drUnidadeMedicao As OleDbDataReader = conexao("SELECT UNIDADE FROM tbHistoricoMedicao WHERE ID=" & drPorAmbiente("ID"))
                drUnidadeMedicao.Read()

                Dim drAreaPlanejada As OleDbDataReader = conexao("SELECT AreaPlanejada FROM tbMedicao WHERE ID=" & drPorAmbiente("ID"))
                drAreaPlanejada.Read()

                If drMedicao.HasRows = True Then

                    lst.Items.Add("Executados " & drMedicao("TotalMedicao") & " " & drUnidadeMedicao("UNIDADE") & " de " & drAreaPlanejada("AreaPlanejada"))
                    lst.Items.Add("")
                Else
                    lst.Items.Add("Medição não encontrada")
                    lst.Items.Add("")
                End If

            End While

            lst.Items(0).ForeColor = Color.Blue

            Me.Controls.Add(lst)

            X = Largura + X + EspacoHorizontal

            lst.Location = (New Point(X, Y))

        End While

        drCompleta.Close()
        drCompleta = Nothing
        drLocais.Close()
        drLocais = Nothing
        drPorAmbiente.Close()
        drPorAmbiente = Nothing

        Desconectar()

    End Sub

    Public Function conexao(sql As String)
        If objConn1.State = ConnectionState.Closed Then
            objConn1.Open()
        End If
        Dim objcmd As New OleDbCommand(sql, objConn1)
        bdr1 = objcmd.ExecuteReader()
        Return bdr1
    End Function

    Public Sub Desconectar()
        bdr1.Close()
        bdr1 = Nothing
        objConn1.Close()
    End Sub

End Class