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
	      Me.picCaptcha = New System.Windows.Forms.PictureBox()
	      Me.btnAtualizarCap = New System.Windows.Forms.Button()
	      Me.txtCap = New System.Windows.Forms.TextBox()
	      Me.txtCnpj = New System.Windows.Forms.TextBox()
	      Me.btnConsultarCNPJ = New System.Windows.Forms.Button()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
	      Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
	      Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
	      Me.picCap = New System.Windows.Forms.PictureBox()
	      CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.picCap, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'picCaptcha
	      '
	      Me.picCaptcha.Location = New System.Drawing.Point(495, 179)
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
	      Me.txtCnpj.Location = New System.Drawing.Point(203, 242)
	      Me.txtCnpj.Name = "txtCnpj"
	      Me.txtCnpj.Size = New System.Drawing.Size(133, 20)
	      Me.txtCnpj.TabIndex = 3
	      '
	      'btnConsultarCNPJ
	      '
	      Me.btnConsultarCNPJ.Location = New System.Drawing.Point(288, 286)
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
	      'MaterialSingleLineTextField1
	      '
	      Me.MaterialSingleLineTextField1.Depth = 0
	      Me.MaterialSingleLineTextField1.Hint = ""
	      Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(37, 308)
	      Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
	      Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
	      Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	      Me.MaterialSingleLineTextField1.SelectedText = ""
	      Me.MaterialSingleLineTextField1.SelectionLength = 0
	      Me.MaterialSingleLineTextField1.SelectionStart = 0
	      Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(222, 23)
	      Me.MaterialSingleLineTextField1.TabIndex = 8
	      Me.MaterialSingleLineTextField1.Text = "MaterialSingleLineTextField1"
	      Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
	      '
	      'MaterialFlatButton1
	      '
	      Me.MaterialFlatButton1.AutoSize = True
	      Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
	      Me.MaterialFlatButton1.Depth = 0
	      Me.MaterialFlatButton1.Location = New System.Drawing.Point(288, 348)
	      Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
	      Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
	      Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
	      Me.MaterialFlatButton1.Primary = False
	      Me.MaterialFlatButton1.Size = New System.Drawing.Size(172, 36)
	      Me.MaterialFlatButton1.TabIndex = 9
	      Me.MaterialFlatButton1.Text = "MaterialFlatButton1"
	      Me.MaterialFlatButton1.UseVisualStyleBackColor = True
	      '
	      'picCap
	      '
	      Me.picCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.picCap.Location = New System.Drawing.Point(12, 69)
	      Me.picCap.Name = "picCap"
	      Me.picCap.Size = New System.Drawing.Size(168, 50)
	      Me.picCap.TabIndex = 10
	      Me.picCap.TabStop = False
	      '
	      'frmConsultaCNPJ
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.ClientSize = New System.Drawing.Size(800, 450)
	      Me.Controls.Add(Me.picCap)
	      Me.Controls.Add(Me.MaterialFlatButton1)
	      Me.Controls.Add(Me.MaterialSingleLineTextField1)
	      Me.Controls.Add(Me.txtNomeFantasia)
	      Me.Controls.Add(Me.Label1)
	      Me.Controls.Add(Me.btnConsultarCNPJ)
	      Me.Controls.Add(Me.txtCnpj)
	      Me.Controls.Add(Me.txtCap)
	      Me.Controls.Add(Me.btnAtualizarCap)
	      Me.Controls.Add(Me.picCaptcha)
	      Me.Name = "frmConsultaCNPJ"
	      Me.Text = "Consulta de CNPJ"
	      CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.picCap, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
        Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
        Friend WithEvents picCap As PictureBox
End Class
