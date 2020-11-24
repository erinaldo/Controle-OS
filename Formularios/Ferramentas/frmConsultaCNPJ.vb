Imports MaterialSkin
Imports DllConsultaCNPJ.ConsultaCNPJReceita



Public Class frmConsultaCNPJ



        Inherits MaterialSkin.Controls.MaterialForm

        ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '       Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
        '		    MaterialSkinManeger.AddFormToManage(Me)
        '		    MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
        '		    MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        '        End Sub


        Private Sub frmConsultaCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

                Dim modo As String = My.Settings.Tema
                Select Case modo
                        Case = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                        Case = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.BLACK)
                        Case Else
                End Select

                GetCaptcha(picCap)
        End Sub




        Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)
                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                MaterialSkinManeger.AddFormToManage(Me)
                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        End Sub

        Private Sub btnAtualizarCap_Click(sender As Object, e As EventArgs) Handles btnAtualizarCap.Click
                GetCaptcha(picCap)
        End Sub

        Private Sub btnConsultarCNPJ_Click(sender As Object, e As EventArgs) Handles btnConsultarCNPJ.Click
                Consulta(txtCnpj.Text, txtCap.Text)
                txtNomeFantasia.Text = Empresa.NomeFantasia
                txtTipoEmpresa.Text = Empresa.MatrizFilial
                txtRazaoSocial.Text = Empresa.RazaoSocial
                txtAtividadePrimaria.Text = Empresa.AtividadeEconomicaPrimaria
                txtAtividadeSecundaria.Text = Empresa.AtividadeEconomicaSecundaria
        End Sub

        Private Sub txtCap_LostFocus(sender As Object, e As EventArgs) Handles txtCap.LostFocus
                txtCap.Text = txtCap.Text.ToUpper
        End Sub
End Class

