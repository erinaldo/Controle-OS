<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContexLancamento
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDetalhar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ControleOS.My.Resources.Resources.Imprimir
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(-1, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 44)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Imprimir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ControleOS.My.Resources.Resources.Cancelar3
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-1, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Apagar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDetalhar
        '
        Me.btnDetalhar.FlatAppearance.BorderSize = 0
        Me.btnDetalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalhar.Image = Global.ControleOS.My.Resources.Resources.Lupa
        Me.btnDetalhar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalhar.Location = New System.Drawing.Point(-1, 6)
        Me.btnDetalhar.Name = "btnDetalhar"
        Me.btnDetalhar.Size = New System.Drawing.Size(150, 38)
        Me.btnDetalhar.TabIndex = 0
        Me.btnDetalhar.Text = "Detalhamento"
        Me.btnDetalhar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetalhar.UseVisualStyleBackColor = True
        '
        'FrmContexLancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(145, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDetalhar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmContexLancamento"
        Me.Text = "FrmContexCarregarPedido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDetalhar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
