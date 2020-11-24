Imports DllConsultaCNPJ.ConsultaCNPJReceita

Public Class frmConsultaCNPJ
        Private Sub frmConsultaCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      GetCaptcha(picCaptcha)
        End Sub

        Private Sub btnAtualizarCap_Click(sender As Object, e As EventArgs) Handles btnAtualizarCap.Click
	      GetCaptcha(picCaptcha)
        End Sub

        Private Sub btnConsultarCNPJ_Click(sender As Object, e As EventArgs) Handles btnConsultarCNPJ.Click
	      ValidaCampos(txtCnpj.Text, txtCap.Text)
	      Consulta(txtCnpj.Text, txtCap.Text)
	      txtNomeFantasia.Text = Empresa.NomeFantasia
        End Sub
End Class