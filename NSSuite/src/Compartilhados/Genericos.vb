Imports System.IO

Public Class Genericos
    Public Shared Sub salvarXML(ByVal xml As String, ByVal caminho As String, ByVal nome As String, ByVal Optional tpEvento As String = "", ByVal Optional nSeqEvento As String = "")
        Dim localParaSalvar As String = caminho & tpEvento & nome & nSeqEvento & ".xml"
        Dim ConteudoSalvar As String = ""
        ConteudoSalvar = xml.Replace("\""", "")
        File.WriteAllText(localParaSalvar, ConteudoSalvar)
    End Sub

    Public Shared Sub salvarJSON(ByVal json As String, ByVal caminho As String, ByVal nome As String, ByVal Optional tpEvento As String = "", ByVal Optional nSeqEvento As String = "")
        Dim localParaSalvar As String = caminho & tpEvento & nome & nSeqEvento & ".json"
        File.WriteAllText(localParaSalvar, json)
    End Sub

    Public Shared Sub salvarPDF(ByVal pdf As String, ByVal caminho As String, ByVal nome As String, ByVal Optional tpEvento As String = "", ByVal Optional nSeqEvento As String = "")
        Dim localParaSalvar As String = caminho & tpEvento & nome & nSeqEvento & ".pdf"
        Dim bytes As Byte() = Convert.FromBase64String(pdf)
        If File.Exists(localParaSalvar) Then File.Delete(localParaSalvar)
        Dim stream As FileStream = New FileStream(localParaSalvar, FileMode.CreateNew)
        Dim writer As BinaryWriter = New BinaryWriter(stream)
        writer.Write(bytes, 0, bytes.Length)
        writer.Close()
    End Sub

    Public Shared Sub gravarLinhaLog(ByVal modelo As String, ByVal conteudo As String)
        Dim caminho As String = Application.StartupPath & "\log\"
        Console.Write(caminho)

        If Not Directory.Exists(caminho) Then
            Directory.CreateDirectory(caminho)
        End If

        Dim data As String = DateTime.Now.ToShortDateString()
        Dim hora As String = DateTime.Now.ToShortTimeString()
        Dim nomeArq As String = data.Replace("/", "") + "_" + modelo

        Using outputFile As StreamWriter = New StreamWriter(caminho & nomeArq & ".txt", True)
            outputFile.WriteLine(data & " " & hora & " - " & conteudo)
        End Using
    End Sub
End Class
