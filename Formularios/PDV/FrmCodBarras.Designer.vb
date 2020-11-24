<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodBarras
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
		Dim Label5 As System.Windows.Forms.Label
		Dim Label2 As System.Windows.Forms.Label
		Me.btnRetQuant = New System.Windows.Forms.Button()
		Me.btnAddQuant = New System.Windows.Forms.Button()
		Me.txtQuantidade = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnConfirmarEscolha = New System.Windows.Forms.Button()
		Me.txtNomeProduto = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TxtEmEstoque = New System.Windows.Forms.TextBox()
		Label5 = New System.Windows.Forms.Label()
		Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnRetQuant
		'
		Me.btnRetQuant.BackColor = System.Drawing.Color.Indigo
		Me.btnRetQuant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnRetQuant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnRetQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRetQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRetQuant.Location = New System.Drawing.Point(145, 152)
		Me.btnRetQuant.Name = "btnRetQuant"
		Me.btnRetQuant.Size = New System.Drawing.Size(25, 23)
		Me.btnRetQuant.TabIndex = 111
		Me.btnRetQuant.Text = "-"
		Me.btnRetQuant.UseVisualStyleBackColor = False
		'
		'btnAddQuant
		'
		Me.btnAddQuant.BackColor = System.Drawing.Color.Indigo
		Me.btnAddQuant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnAddQuant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnAddQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddQuant.Location = New System.Drawing.Point(145, 129)
		Me.btnAddQuant.Name = "btnAddQuant"
		Me.btnAddQuant.Size = New System.Drawing.Size(25, 23)
		Me.btnAddQuant.TabIndex = 110
		Me.btnAddQuant.Text = "+"
		Me.btnAddQuant.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Label5.AutoSize = True
		Label5.BackColor = System.Drawing.Color.Transparent
		Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label5.ForeColor = System.Drawing.Color.White
		Label5.Location = New System.Drawing.Point(13, 108)
		Label5.Name = "Label5"
		Label5.Size = New System.Drawing.Size(86, 16)
		Label5.TabIndex = 108
		Label5.Text = "Quantidade:"
		'
		'txtQuantidade
		'
		Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtQuantidade.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQuantidade.Location = New System.Drawing.Point(16, 127)
		Me.txtQuantidade.Name = "txtQuantidade"
		Me.txtQuantidade.Size = New System.Drawing.Size(123, 48)
		Me.txtQuantidade.TabIndex = 109
		Me.txtQuantidade.Text = "1"
		Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Silver
		Me.Panel1.Controls.Add(Me.TxtEmEstoque)
		Me.Panel1.Controls.Add(Label2)
		Me.Panel1.Controls.Add(Me.txtNomeProduto)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.txtQuantidade)
		Me.Panel1.Controls.Add(Me.btnRetQuant)
		Me.Panel1.Controls.Add(Label5)
		Me.Panel1.Controls.Add(Me.btnAddQuant)
		Me.Panel1.Location = New System.Drawing.Point(12, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(328, 195)
		Me.Panel1.TabIndex = 112
		'
		'btnConfirmarEscolha
		'
		Me.btnConfirmarEscolha.BackColor = System.Drawing.Color.Indigo
		Me.btnConfirmarEscolha.FlatAppearance.BorderSize = 0
		Me.btnConfirmarEscolha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
		Me.btnConfirmarEscolha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
		Me.btnConfirmarEscolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnConfirmarEscolha.ForeColor = System.Drawing.Color.White
		Me.btnConfirmarEscolha.Location = New System.Drawing.Point(12, 213)
		Me.btnConfirmarEscolha.Name = "btnConfirmarEscolha"
		Me.btnConfirmarEscolha.Size = New System.Drawing.Size(114, 32)
		Me.btnConfirmarEscolha.TabIndex = 113
		Me.btnConfirmarEscolha.Text = "&Confirmar"
		Me.btnConfirmarEscolha.UseVisualStyleBackColor = False
		'
		'txtNomeProduto
		'
		Me.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNomeProduto.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNomeProduto.Location = New System.Drawing.Point(16, 28)
		Me.txtNomeProduto.Multiline = True
		Me.txtNomeProduto.Name = "txtNomeProduto"
		Me.txtNomeProduto.Size = New System.Drawing.Size(291, 77)
		Me.txtNomeProduto.TabIndex = 110
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 16)
		Me.Label1.TabIndex = 111
		Me.Label1.Text = "Produto:"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.ControleOS.My.Resources.Resources.trena
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.ImageLocation = ""
		Me.PictureBox1.Location = New System.Drawing.Point(356, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(136, 141)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Label2
		'
		Label2.AutoSize = True
		Label2.BackColor = System.Drawing.Color.Transparent
		Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Label2.ForeColor = System.Drawing.Color.White
		Label2.Location = New System.Drawing.Point(186, 108)
		Label2.Name = "Label2"
		Label2.Size = New System.Drawing.Size(82, 16)
		Label2.TabIndex = 112
		Label2.Text = "Em Estoque"
		'
		'TxtEmEstoque
		'
		Me.TxtEmEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtEmEstoque.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtEmEstoque.Location = New System.Drawing.Point(189, 127)
		Me.TxtEmEstoque.Name = "TxtEmEstoque"
		Me.TxtEmEstoque.ReadOnly = True
		Me.TxtEmEstoque.Size = New System.Drawing.Size(123, 48)
		Me.TxtEmEstoque.TabIndex = 113
		Me.TxtEmEstoque.Text = "0"
		Me.TxtEmEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'FrmCodBarras
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(505, 257)
		Me.Controls.Add(Me.btnConfirmarEscolha)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "FrmCodBarras"
		Me.Text = "FrmCodBarras"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnRetQuant As Button
	Friend WithEvents btnAddQuant As Button
	Friend WithEvents txtQuantidade As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnConfirmarEscolha As Button
	Friend WithEvents txtNomeProduto As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TxtEmEstoque As TextBox
End Class
