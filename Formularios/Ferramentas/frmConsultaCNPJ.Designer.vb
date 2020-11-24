<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCNPJ
        Inherits System.Windows.Forms.Form

        'Descartar substituições de formulário para limpar a lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
		Me.picCaptcha = New System.Windows.Forms.PictureBox()
		Me.btnAtualizarCap = New System.Windows.Forms.Button()
		Me.txtCap = New System.Windows.Forms.TextBox()
		Me.txtCnpj = New System.Windows.Forms.TextBox()
		Me.btnConsultarCNPJ = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
		CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picCaptcha
		'
		Me.picCaptcha.Location = New System.Drawing.Point(12, 12)
		Me.picCaptcha.Name = "picCaptcha"
		Me.picCaptcha.Size = New System.Drawing.Size(238, 130)
		Me.picCaptcha.TabIndex = 0
		Me.picCaptcha.TabStop = False
		'
		'btnAtualizarCap
		'
		Me.btnAtualizarCap.Location = New System.Drawing.Point(12, 179)
		Me.btnAtualizarCap.Name = "btnAtualizarCap"
		Me.btnAtualizarCap.Size = New System.Drawing.Size(133, 23)
		Me.btnAtualizarCap.TabIndex = 1
		Me.btnAtualizarCap.Text = "Atulizar Captcha"
		Me.btnAtualizarCap.UseVisualStyleBackColor = True
		'
		'txtCap
		'
		Me.txtCap.Location = New System.Drawing.Point(12, 153)
		Me.txtCap.Name = "txtCap"
		Me.txtCap.Size = New System.Drawing.Size(133, 20)
		Me.txtCap.TabIndex = 2
		'
		'txtCnpj
		'
		Me.txtCnpj.Location = New System.Drawing.Point(256, 12)
		Me.txtCnpj.Name = "txtCnpj"
		Me.txtCnpj.Size = New System.Drawing.Size(133, 20)
		Me.txtCnpj.TabIndex = 3
		'
		'btnConsultarCNPJ
		'
		Me.btnConsultarCNPJ.Location = New System.Drawing.Point(256, 38)
		Me.btnConsultarCNPJ.Name = "btnConsultarCNPJ"
		Me.btnConsultarCNPJ.Size = New System.Drawing.Size(133, 23)
		Me.btnConsultarCNPJ.TabIndex = 4
		Me.btnConsultarCNPJ.Text = "Iniciar Consulta"
		Me.btnConsultarCNPJ.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 226)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Nome Fantasia"
		'
		'txtNomeFantasia
		'
		Me.txtNomeFantasia.Location = New System.Drawing.Point(15, 242)
		Me.txtNomeFantasia.Name = "txtNomeFantasia"
		Me.txtNomeFantasia.ReadOnly = True
		Me.txtNomeFantasia.Size = New System.Drawing.Size(133, 20)
		Me.txtNomeFantasia.TabIndex = 6
		'
		'frmConsultaCNPJ
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.txtNomeFantasia)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnConsultarCNPJ)
		Me.Controls.Add(Me.txtCnpj)
		Me.Controls.Add(Me.txtCap)
		Me.Controls.Add(Me.btnAtualizarCap)
		Me.Controls.Add(Me.picCaptcha)
		Me.Name = "frmConsultaCNPJ"
		Me.Text = "frmConsultaCNPJ"
		CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picCaptcha As PictureBox
	Friend WithEvents btnAtualizarCap As Button
	Friend WithEvents txtCap As TextBox
	Friend WithEvents txtCnpj As TextBox
	Friend WithEvents btnConsultarCNPJ As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents txtNomeFantasia As TextBox
End Class
