﻿Imports MaterialSkin



Public Class frmConsultaCNPJ



        Inherits MaterialSkin.Controls.MaterialForm

        ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '       Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
        '		    MaterialSkinManeger.AddFormToManage(Me)
        '		    MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
        '		    MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        '        End Sub


        Private Sub frmConsultaCNPJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
	      MaterialSkinManeger.AddFormToManage(Me)
	      MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
	      MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        End Sub

        Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
	      Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
	      MaterialSkinManeger.AddFormToManage(Me)
	      MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
	      MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        End Sub
End Class

