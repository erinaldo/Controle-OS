Public Class frmNavSintegra
        Private Sub wbSintegra_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbSintegra.DocumentCompleted

        End Sub

        Private Sub frmNavSintegra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      wbSintegra.Url = New Uri("http://www.google.com.br//")
        End Sub
End Class