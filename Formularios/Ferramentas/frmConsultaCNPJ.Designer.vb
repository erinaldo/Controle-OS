<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaCNPJ
	'Inherits System.Windows.Forms.Form

	'Descartar substituições de formulário para limpar a lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.txtCap = New System.Windows.Forms.TextBox()
		Me.txtCnpj = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
		Me.picCap = New System.Windows.Forms.PictureBox()
		Me.btnAtualizarCap = New MaterialSkin.Controls.MaterialFlatButton()
		Me.btnConsultarCNPJ = New MaterialSkin.Controls.MaterialFlatButton()
		Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
		Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
		Me.sdf = New System.Windows.Forms.Label()
		Me.txtTipoEmpresa = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtAtividadePrimaria = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtAtividadeSecundaria = New System.Windows.Forms.TextBox()
		CType(Me.picCap, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtCap
		'
		Me.txtCap.Location = New System.Drawing.Point(6, 121)
		Me.txtCap.Name = "txtCap"
		Me.txtCap.Size = New System.Drawing.Size(151, 20)
		Me.txtCap.TabIndex = 2
		'
		'txtCnpj
		'
		Me.txtCnpj.Location = New System.Drawing.Point(165, 121)
		Me.txtCnpj.Name = "txtCnpj"
		Me.txtCnpj.Size = New System.Drawing.Size(172, 20)
		Me.txtCnpj.TabIndex = 3
		Me.txtCnpj.Text = "18.939.018/0001-19"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(366, 112)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Nome Fantasia"
		'
		'txtNomeFantasia
		'
		Me.txtNomeFantasia.Location = New System.Drawing.Point(366, 124)
		Me.txtNomeFantasia.Name = "txtNomeFantasia"
		Me.txtNomeFantasia.ReadOnly = True
		Me.txtNomeFantasia.Size = New System.Drawing.Size(328, 20)
		Me.txtNomeFantasia.TabIndex = 6
		'
		'picCap
		'
		Me.picCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picCap.Location = New System.Drawing.Point(6, 19)
		Me.picCap.Name = "picCap"
		Me.picCap.Size = New System.Drawing.Size(228, 73)
		Me.picCap.TabIndex = 10
		Me.picCap.TabStop = False
		'
		'btnAtualizarCap
		'
		Me.btnAtualizarCap.AutoSize = True
		Me.btnAtualizarCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnAtualizarCap.Depth = 0
		Me.btnAtualizarCap.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAtualizarCap.Location = New System.Drawing.Point(6, 147)
		Me.btnAtualizarCap.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.btnAtualizarCap.MouseState = MaterialSkin.MouseState.HOVER
		Me.btnAtualizarCap.Name = "btnAtualizarCap"
		Me.btnAtualizarCap.Primary = False
		Me.btnAtualizarCap.Size = New System.Drawing.Size(151, 36)
		Me.btnAtualizarCap.TabIndex = 11
		Me.btnAtualizarCap.Text = "Atualizar Captcha"
		Me.btnAtualizarCap.UseVisualStyleBackColor = True
		'
		'btnConsultarCNPJ
		'
		Me.btnConsultarCNPJ.AutoSize = True
		Me.btnConsultarCNPJ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnConsultarCNPJ.Depth = 0
		Me.btnConsultarCNPJ.Location = New System.Drawing.Point(197, 147)
		Me.btnConsultarCNPJ.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.btnConsultarCNPJ.MouseState = MaterialSkin.MouseState.HOVER
		Me.btnConsultarCNPJ.Name = "btnConsultarCNPJ"
		Me.btnConsultarCNPJ.Primary = False
		Me.btnConsultarCNPJ.Size = New System.Drawing.Size(129, 36)
		Me.btnConsultarCNPJ.TabIndex = 12
		Me.btnConsultarCNPJ.Text = "Consultar CNPJ"
		Me.btnConsultarCNPJ.UseVisualStyleBackColor = True
		'
		'MaterialLabel1
		'
		Me.MaterialLabel1.AutoSize = True
		Me.MaterialLabel1.Depth = 0
		Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
		Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.MaterialLabel1.Location = New System.Drawing.Point(6, 103)
		Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
		Me.MaterialLabel1.Name = "MaterialLabel1"
		Me.MaterialLabel1.Size = New System.Drawing.Size(64, 19)
		Me.MaterialLabel1.TabIndex = 13
		Me.MaterialLabel1.Text = "Captcha"
		'
		'MaterialLabel2
		'
		Me.MaterialLabel2.AutoSize = True
		Me.MaterialLabel2.Depth = 0
		Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
		Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.MaterialLabel2.Location = New System.Drawing.Point(162, 103)
		Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
		Me.MaterialLabel2.Name = "MaterialLabel2"
		Me.MaterialLabel2.Size = New System.Drawing.Size(47, 19)
		Me.MaterialLabel2.TabIndex = 14
		Me.MaterialLabel2.Text = "CNPJ"
		'
		'sdf
		'
		Me.sdf.AutoSize = True
		Me.sdf.Location = New System.Drawing.Point(366, 72)
		Me.sdf.Name = "sdf"
		Me.sdf.Size = New System.Drawing.Size(66, 13)
		Me.sdf.TabIndex = 15
		Me.sdf.Text = "Matriz / Filial"
		'
		'txtTipoEmpresa
		'
		Me.txtTipoEmpresa.Location = New System.Drawing.Point(366, 84)
		Me.txtTipoEmpresa.Name = "txtTipoEmpresa"
		Me.txtTipoEmpresa.ReadOnly = True
		Me.txtTipoEmpresa.Size = New System.Drawing.Size(112, 20)
		Me.txtTipoEmpresa.TabIndex = 16
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(366, 155)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 13)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Razão Social"
		'
		'txtRazaoSocial
		'
		Me.txtRazaoSocial.Location = New System.Drawing.Point(366, 167)
		Me.txtRazaoSocial.Name = "txtRazaoSocial"
		Me.txtRazaoSocial.ReadOnly = True
		Me.txtRazaoSocial.Size = New System.Drawing.Size(328, 20)
		Me.txtRazaoSocial.TabIndex = 18
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.picCap)
		Me.GroupBox1.Controls.Add(Me.txtCap)
		Me.GroupBox1.Controls.Add(Me.txtCnpj)
		Me.GroupBox1.Controls.Add(Me.btnAtualizarCap)
		Me.GroupBox1.Controls.Add(Me.btnConsultarCNPJ)
		Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
		Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(344, 192)
		Me.GroupBox1.TabIndex = 19
		Me.GroupBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(366, 197)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 13)
		Me.Label3.TabIndex = 20
		Me.Label3.Text = "Razão Social"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(366, 209)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(328, 20)
		Me.TextBox1.TabIndex = 21
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 271)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 13)
		Me.Label4.TabIndex = 22
		Me.Label4.Text = "Atividade Primária"
		'
		'txtAtividadePrimaria
		'
		Me.txtAtividadePrimaria.Location = New System.Drawing.Point(12, 283)
		Me.txtAtividadePrimaria.Multiline = True
		Me.txtAtividadePrimaria.Name = "txtAtividadePrimaria"
		Me.txtAtividadePrimaria.ReadOnly = True
		Me.txtAtividadePrimaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtAtividadePrimaria.Size = New System.Drawing.Size(344, 72)
		Me.txtAtividadePrimaria.TabIndex = 23
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 364)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(108, 13)
		Me.Label5.TabIndex = 24
		Me.Label5.Text = "Atividade Secundária"
		'
		'txtAtividadeSecundaria
		'
		Me.txtAtividadeSecundaria.Location = New System.Drawing.Point(12, 376)
		Me.txtAtividadeSecundaria.Multiline = True
		Me.txtAtividadeSecundaria.Name = "txtAtividadeSecundaria"
		Me.txtAtividadeSecundaria.ReadOnly = True
		Me.txtAtividadeSecundaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtAtividadeSecundaria.Size = New System.Drawing.Size(344, 72)
		Me.txtAtividadeSecundaria.TabIndex = 25
		'
		'frmConsultaCNPJ
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 486)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtAtividadeSecundaria)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtAtividadePrimaria)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtRazaoSocial)
		Me.Controls.Add(Me.sdf)
		Me.Controls.Add(Me.txtTipoEmpresa)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtNomeFantasia)
		Me.Name = "frmConsultaCNPJ"
		Me.Text = "Consulta de CNPJ"
		CType(Me.picCap, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtCap As TextBox
	Friend WithEvents txtCnpj As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtNomeFantasia As TextBox
	Friend WithEvents picCap As PictureBox
	Friend WithEvents btnAtualizarCap As MaterialSkin.Controls.MaterialFlatButton
	Friend WithEvents btnConsultarCNPJ As MaterialSkin.Controls.MaterialFlatButton
	Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
	Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
	Friend WithEvents sdf As Label
	Friend WithEvents txtTipoEmpresa As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtRazaoSocial As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtAtividadePrimaria As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtAtividadeSecundaria As TextBox
End Class
