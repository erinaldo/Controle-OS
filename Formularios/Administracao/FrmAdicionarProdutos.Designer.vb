<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdicionarProduto
	Inherits System.Windows.Forms.Form

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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnRemCodBarra = New System.Windows.Forms.Button()
		Me.btnAddCodBaras = New System.Windows.Forms.Button()
		Me.txtCodBarras = New System.Windows.Forms.TextBox()
		Me.dgvCodBarras = New System.Windows.Forms.DataGridView()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cboEscolhaEstoque = New System.Windows.Forms.ComboBox()
		Me.chkMultiCadastro = New System.Windows.Forms.CheckBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtGenero = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtCategoriaPadrao = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtTempoProducao = New System.Windows.Forms.TextBox()
		Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtCustoMDO = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtValorUnitario = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtQuantidade = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtUnidade = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtProduto = New System.Windows.Forms.TextBox()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Panel1)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.cboEscolhaEstoque)
		Me.GroupBox1.Controls.Add(Me.chkMultiCadastro)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.txtGenero)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.txtCategoriaPadrao)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtTempoProducao)
		Me.GroupBox1.Controls.Add(Me.cboTipoProduto)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.txtCustoMDO)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.txtValorUnitario)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtQuantidade)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtUnidade)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtProduto)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(872, 440)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = " "
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Controls.Add(Me.txtCodBarras)
		Me.Panel1.Controls.Add(Me.dgvCodBarras)
		Me.Panel1.Location = New System.Drawing.Point(620, 128)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(246, 232)
		Me.Panel1.TabIndex = 36
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.btnRemCodBarra)
		Me.Panel2.Controls.Add(Me.btnAddCodBaras)
		Me.Panel2.Location = New System.Drawing.Point(3, 185)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(238, 38)
		Me.Panel2.TabIndex = 9
		'
		'btnRemCodBarra
		'
		Me.btnRemCodBarra.BackgroundImage = Global.ControleOS.My.Resources.Resources._Sub
		Me.btnRemCodBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnRemCodBarra.FlatAppearance.BorderSize = 0
		Me.btnRemCodBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRemCodBarra.Location = New System.Drawing.Point(58, 3)
		Me.btnRemCodBarra.Name = "btnRemCodBarra"
		Me.btnRemCodBarra.Size = New System.Drawing.Size(36, 26)
		Me.btnRemCodBarra.TabIndex = 35
		Me.btnRemCodBarra.UseVisualStyleBackColor = True
		'
		'btnAddCodBaras
		'
		Me.btnAddCodBaras.BackgroundImage = Global.ControleOS.My.Resources.Resources.Add
		Me.btnAddCodBaras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnAddCodBaras.FlatAppearance.BorderSize = 0
		Me.btnAddCodBaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddCodBaras.Location = New System.Drawing.Point(3, 3)
		Me.btnAddCodBaras.Name = "btnAddCodBaras"
		Me.btnAddCodBaras.Size = New System.Drawing.Size(36, 26)
		Me.btnAddCodBaras.TabIndex = 34
		Me.btnAddCodBaras.UseVisualStyleBackColor = True
		'
		'txtCodBarras
		'
		Me.txtCodBarras.Location = New System.Drawing.Point(3, 159)
		Me.txtCodBarras.Name = "txtCodBarras"
		Me.txtCodBarras.Size = New System.Drawing.Size(242, 20)
		Me.txtCodBarras.TabIndex = 32
		'
		'dgvCodBarras
		'
		Me.dgvCodBarras.AllowUserToAddRows = False
		Me.dgvCodBarras.AllowUserToDeleteRows = False
		Me.dgvCodBarras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvCodBarras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCodBarras.Location = New System.Drawing.Point(3, 3)
		Me.dgvCodBarras.Name = "dgvCodBarras"
		Me.dgvCodBarras.ReadOnly = True
		Me.dgvCodBarras.RowHeadersVisible = False
		Me.dgvCodBarras.Size = New System.Drawing.Size(240, 150)
		Me.dgvCodBarras.TabIndex = 31
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(6, 112)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(153, 13)
		Me.Label8.TabIndex = 30
		Me.Label8.Text = "ESTOQUE PARA CADASTRO"
		'
		'cboEscolhaEstoque
		'
		Me.cboEscolhaEstoque.FormattingEnabled = True
		Me.cboEscolhaEstoque.Location = New System.Drawing.Point(9, 128)
		Me.cboEscolhaEstoque.Name = "cboEscolhaEstoque"
		Me.cboEscolhaEstoque.Size = New System.Drawing.Size(150, 21)
		Me.cboEscolhaEstoque.TabIndex = 29
		'
		'chkMultiCadastro
		'
		Me.chkMultiCadastro.AutoSize = True
		Me.chkMultiCadastro.Location = New System.Drawing.Point(773, 38)
		Me.chkMultiCadastro.Name = "chkMultiCadastro"
		Me.chkMultiCadastro.Size = New System.Drawing.Size(93, 17)
		Me.chkMultiCadastro.TabIndex = 28
		Me.chkMultiCadastro.Text = "Multi-Cadastro"
		Me.chkMultiCadastro.UseVisualStyleBackColor = True
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(491, 63)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(42, 13)
		Me.Label13.TabIndex = 27
		Me.Label13.Text = "Gênero"
		'
		'txtGenero
		'
		Me.txtGenero.Location = New System.Drawing.Point(493, 77)
		Me.txtGenero.Name = "txtGenero"
		Me.txtGenero.Size = New System.Drawing.Size(98, 20)
		Me.txtGenero.TabIndex = 26
		Me.txtGenero.Text = "4"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(594, 24)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(89, 13)
		Me.Label12.TabIndex = 25
		Me.Label12.Text = "Categoria Padrão"
		'
		'txtCategoriaPadrao
		'
		Me.txtCategoriaPadrao.Location = New System.Drawing.Point(597, 38)
		Me.txtCategoriaPadrao.Name = "txtCategoriaPadrao"
		Me.txtCategoriaPadrao.Size = New System.Drawing.Size(120, 20)
		Me.txtCategoriaPadrao.TabIndex = 24
		Me.txtCategoriaPadrao.Text = "4"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 61)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 13)
		Me.Label1.TabIndex = 18
		Me.Label1.Text = "TEMPO PRODUÇÃO (DIAS)"
		'
		'txtTempoProducao
		'
		Me.txtTempoProducao.Location = New System.Drawing.Point(9, 77)
		Me.txtTempoProducao.Name = "txtTempoProducao"
		Me.txtTempoProducao.Size = New System.Drawing.Size(219, 20)
		Me.txtTempoProducao.TabIndex = 17
		Me.txtTempoProducao.Text = "4"
		'
		'cboTipoProduto
		'
		Me.cboTipoProduto.FormattingEnabled = True
		Me.cboTipoProduto.Location = New System.Drawing.Point(234, 38)
		Me.cboTipoProduto.Name = "cboTipoProduto"
		Me.cboTipoProduto.Size = New System.Drawing.Size(121, 21)
		Me.cboTipoProduto.TabIndex = 16
		Me.cboTipoProduto.Text = "ee"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(237, 21)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(32, 13)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "TIPO"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(493, 23)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(72, 13)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "CUSTO MDO"
		'
		'txtCustoMDO
		'
		Me.txtCustoMDO.Location = New System.Drawing.Point(493, 39)
		Me.txtCustoMDO.Name = "txtCustoMDO"
		Me.txtCustoMDO.Size = New System.Drawing.Size(98, 20)
		Me.txtCustoMDO.TabIndex = 12
		Me.txtCustoMDO.Text = "4"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(358, 61)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(98, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "VALOR UNITÁRIO"
		'
		'txtValorUnitario
		'
		Me.txtValorUnitario.Location = New System.Drawing.Point(361, 77)
		Me.txtValorUnitario.Name = "txtValorUnitario"
		Me.txtValorUnitario.Size = New System.Drawing.Size(126, 20)
		Me.txtValorUnitario.TabIndex = 10
		Me.txtValorUnitario.Text = "6"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(358, 22)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(78, 13)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "QUANTIDADE"
		'
		'txtQuantidade
		'
		Me.txtQuantidade.Location = New System.Drawing.Point(361, 38)
		Me.txtQuantidade.Name = "txtQuantidade"
		Me.txtQuantidade.Size = New System.Drawing.Size(126, 20)
		Me.txtQuantidade.TabIndex = 8
		Me.txtQuantidade.Text = "4"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(231, 61)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "UNIDADE"
		'
		'txtUnidade
		'
		Me.txtUnidade.Location = New System.Drawing.Point(234, 77)
		Me.txtUnidade.Name = "txtUnidade"
		Me.txtUnidade.Size = New System.Drawing.Size(121, 20)
		Me.txtUnidade.TabIndex = 6
		Me.txtUnidade.Text = "un"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 22)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "DESCRIÇÃO"
		'
		'txtProduto
		'
		Me.txtProduto.Location = New System.Drawing.Point(9, 38)
		Me.txtProduto.Name = "txtProduto"
		Me.txtProduto.Size = New System.Drawing.Size(219, 20)
		Me.txtProduto.TabIndex = 4
		Me.txtProduto.Text = "teste"
		'
		'btnCancelar
		'
		Me.btnCancelar.BackColor = System.Drawing.Color.White
		Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnCancelar.Location = New System.Drawing.Point(1117, 24)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(96, 73)
		Me.btnCancelar.TabIndex = 8
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnCancelar.UseVisualStyleBackColor = False
		'
		'btnSalvar
		'
		Me.btnSalvar.BackColor = System.Drawing.Color.White
		Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalvar.Location = New System.Drawing.Point(1015, 24)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(96, 73)
		Me.btnSalvar.TabIndex = 7
		Me.btnSalvar.Text = "ADICIONAR PRODUTO"
		Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalvar.UseVisualStyleBackColor = False
		'
		'FrmAdicionarProduto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1221, 599)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnCancelar)
		Me.Name = "FrmAdicionarProduto"
		Me.Text = " "
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.dgvCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnCancelar As Button
	Friend WithEvents cboTipoProduto As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents btnSalvar As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents txtCustoMDO As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtValorUnitario As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtQuantidade As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtUnidade As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtProduto As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtTempoProducao As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtCategoriaPadrao As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents txtGenero As TextBox
	Friend WithEvents chkMultiCadastro As CheckBox
	Friend WithEvents Label8 As Label
	Friend WithEvents cboEscolhaEstoque As ComboBox
	Friend WithEvents dgvCodBarras As DataGridView
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnRemCodBarra As Button
	Friend WithEvents btnAddCodBaras As Button
	Friend WithEvents txtCodBarras As TextBox
End Class
