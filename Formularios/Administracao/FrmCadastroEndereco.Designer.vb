<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroEndereco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroEndereco))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAvisoTipo = New System.Windows.Forms.Label()
        Me.lblavisoUF = New System.Windows.Forms.Label()
        Me.lblAvisoCidade = New System.Windows.Forms.Label()
        Me.lblAvisoBairro = New System.Windows.Forms.Label()
        Me.lblAvisoNumero = New System.Windows.Forms.Label()
        Me.lblAvisoLogradouro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCadastroPeloFrm = New System.Windows.Forms.Button()
        Me.btnCadastroPeloDialogo = New System.Windows.Forms.Button()
        Me.btnCadastroPeloPDV = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAvisoTipo)
        Me.GroupBox2.Controls.Add(Me.lblavisoUF)
        Me.GroupBox2.Controls.Add(Me.lblAvisoCidade)
        Me.GroupBox2.Controls.Add(Me.lblAvisoBairro)
        Me.GroupBox2.Controls.Add(Me.lblAvisoNumero)
        Me.GroupBox2.Controls.Add(Me.lblAvisoLogradouro)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtLogradouro)
        Me.GroupBox2.Controls.Add(Me.cboTipo)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtComplemento)
        Me.GroupBox2.Controls.Add(Me.txtCidade)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboUF)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 157)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'lblAvisoTipo
        '
        Me.lblAvisoTipo.AutoSize = True
        Me.lblAvisoTipo.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoTipo.Location = New System.Drawing.Point(355, 124)
        Me.lblAvisoTipo.Name = "lblAvisoTipo"
        Me.lblAvisoTipo.Size = New System.Drawing.Size(94, 13)
        Me.lblAvisoTipo.TabIndex = 44
        Me.lblAvisoTipo.Text = "Campo Obrigatório"
        Me.lblAvisoTipo.Visible = False
        '
        'lblavisoUF
        '
        Me.lblavisoUF.AutoSize = True
        Me.lblavisoUF.ForeColor = System.Drawing.Color.Red
        Me.lblavisoUF.Location = New System.Drawing.Point(130, 124)
        Me.lblavisoUF.Name = "lblavisoUF"
        Me.lblavisoUF.Size = New System.Drawing.Size(94, 13)
        Me.lblavisoUF.TabIndex = 42
        Me.lblavisoUF.Text = "Campo Obrigatório"
        Me.lblavisoUF.Visible = False
        '
        'lblAvisoCidade
        '
        Me.lblAvisoCidade.AutoSize = True
        Me.lblAvisoCidade.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoCidade.Location = New System.Drawing.Point(31, 123)
        Me.lblAvisoCidade.Name = "lblAvisoCidade"
        Me.lblAvisoCidade.Size = New System.Drawing.Size(94, 13)
        Me.lblAvisoCidade.TabIndex = 41
        Me.lblAvisoCidade.Text = "Campo Obrigatório"
        Me.lblAvisoCidade.Visible = False
        '
        'lblAvisoBairro
        '
        Me.lblAvisoBairro.AutoSize = True
        Me.lblAvisoBairro.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoBairro.Location = New System.Drawing.Point(318, 56)
        Me.lblAvisoBairro.Name = "lblAvisoBairro"
        Me.lblAvisoBairro.Size = New System.Drawing.Size(94, 13)
        Me.lblAvisoBairro.TabIndex = 40
        Me.lblAvisoBairro.Text = "Campo Obrigatório"
        Me.lblAvisoBairro.Visible = False
        '
        'lblAvisoNumero
        '
        Me.lblAvisoNumero.AutoSize = True
        Me.lblAvisoNumero.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoNumero.Location = New System.Drawing.Point(218, 56)
        Me.lblAvisoNumero.Name = "lblAvisoNumero"
        Me.lblAvisoNumero.Size = New System.Drawing.Size(94, 13)
        Me.lblAvisoNumero.TabIndex = 39
        Me.lblAvisoNumero.Text = "Campo Obrigatório"
        Me.lblAvisoNumero.Visible = False
        '
        'lblAvisoLogradouro
        '
        Me.lblAvisoLogradouro.AutoSize = True
        Me.lblAvisoLogradouro.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoLogradouro.Location = New System.Drawing.Point(31, 56)
        Me.lblAvisoLogradouro.Name = "lblAvisoLogradouro"
        Me.lblAvisoLogradouro.Size = New System.Drawing.Size(94, 13)
        Me.lblAvisoLogradouro.TabIndex = 38
        Me.lblAvisoLogradouro.Text = "Campo Obrigatório"
        Me.lblAvisoLogradouro.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "LOGRADOURO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(347, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "TIPO"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(9, 33)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(215, 20)
        Me.txtLogradouro.TabIndex = 25
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(350, 99)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(99, 21)
        Me.cboTipo.TabIndex = 36
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(230, 33)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(71, 20)
        Me.txtNumero.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "NÚMERO"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(307, 33)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(142, 20)
        Me.txtBairro.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "COMPLEMENTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "BAIRRO"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(202, 100)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(142, 20)
        Me.txtComplemento.TabIndex = 35
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(9, 100)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(129, 20)
        Me.txtCidade.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(142, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "CIDADE"
        '
        'cboUF
        '
        Me.cboUF.DisplayMember = "SiglaCidade"
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Location = New System.Drawing.Point(145, 100)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(51, 21)
        Me.cboUF.TabIndex = 32
        '
        'Button2
        '
        ' Me.Button2.Image = Global.ControleOS.My.Resources.Resources.ic_cancel_128_283181
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(93, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 62)
        Me.Button2.TabIndex = 41
        Me.Button2.TabStop = False
        Me.Button2.Text = "CANCELAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCadastroPeloFrm
        '
        ' Me.btnCadastroPeloFrm.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.btnCadastroPeloFrm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadastroPeloFrm.Location = New System.Drawing.Point(12, 175)
        Me.btnCadastroPeloFrm.Name = "btnCadastroPeloFrm"
        Me.btnCadastroPeloFrm.Size = New System.Drawing.Size(75, 62)
        Me.btnCadastroPeloFrm.TabIndex = 40
        Me.btnCadastroPeloFrm.TabStop = False
        Me.btnCadastroPeloFrm.Text = "SALVAR"
        Me.btnCadastroPeloFrm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCadastroPeloFrm.UseVisualStyleBackColor = True
        Me.btnCadastroPeloFrm.Visible = False
        '
        'btnCadastroPeloDialogo
        '
        '    Me.btnCadastroPeloDialogo.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.btnCadastroPeloDialogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadastroPeloDialogo.Location = New System.Drawing.Point(271, 175)
        Me.btnCadastroPeloDialogo.Name = "btnCadastroPeloDialogo"
        Me.btnCadastroPeloDialogo.Size = New System.Drawing.Size(75, 62)
        Me.btnCadastroPeloDialogo.TabIndex = 42
        Me.btnCadastroPeloDialogo.TabStop = False
        Me.btnCadastroPeloDialogo.Text = "SALVAR"
        Me.btnCadastroPeloDialogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCadastroPeloDialogo.UseVisualStyleBackColor = True
        Me.btnCadastroPeloDialogo.Visible = False
        '
        'btnCadastroPeloPDV
        '
        '     Me.btnCadastroPeloPDV.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.btnCadastroPeloPDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadastroPeloPDV.Location = New System.Drawing.Point(362, 175)
        Me.btnCadastroPeloPDV.Name = "btnCadastroPeloPDV"
        Me.btnCadastroPeloPDV.Size = New System.Drawing.Size(75, 62)
        Me.btnCadastroPeloPDV.TabIndex = 43
        Me.btnCadastroPeloPDV.TabStop = False
        Me.btnCadastroPeloPDV.Text = "SALVAR"
        Me.btnCadastroPeloPDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCadastroPeloPDV.UseVisualStyleBackColor = True
        Me.btnCadastroPeloPDV.Visible = False
        '
        'FrmCadastroEndereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 268)
        Me.Controls.Add(Me.btnCadastroPeloPDV)
        Me.Controls.Add(Me.btnCadastroPeloDialogo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCadastroPeloFrm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCadastroEndereco"
        Me.Text = "CADASTRO ENDEREÇO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboUF As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCadastroPeloFrm As Button
    Friend WithEvents btnCadastroPeloDialogo As Button
    Friend WithEvents lblAvisoLogradouro As Label
    Friend WithEvents lblAvisoTipo As Label
    Friend WithEvents lblavisoUF As Label
    Friend WithEvents lblAvisoCidade As Label
    Friend WithEvents lblAvisoBairro As Label
    Friend WithEvents lblAvisoNumero As Label
    Friend WithEvents btnCadastroPeloPDV As Button
End Class
