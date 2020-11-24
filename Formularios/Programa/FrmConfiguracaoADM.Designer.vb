<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracaoADM
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
        Me.chkFrmCadastroOS = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkFrmCadastroOS
        '
        Me.chkFrmCadastroOS.AutoSize = True
        Me.chkFrmCadastroOS.Location = New System.Drawing.Point(37, 64)
        Me.chkFrmCadastroOS.Name = "chkFrmCadastroOS"
        Me.chkFrmCadastroOS.Size = New System.Drawing.Size(86, 17)
        Me.chkFrmCadastroOS.TabIndex = 0
        Me.chkFrmCadastroOS.Text = "Cadastro OS"
        Me.chkFrmCadastroOS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Permissões de Paginas"
        '
        'FrmConfiguracaoADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFrmCadastroOS)
        Me.Name = "FrmConfiguracaoADM"
        Me.Text = "FrmConfiguracaoADM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkFrmCadastroOS As CheckBox
    Friend WithEvents Label1 As Label
End Class
