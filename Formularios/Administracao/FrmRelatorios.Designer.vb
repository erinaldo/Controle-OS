<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorios
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
        Me.tvOS = New System.Windows.Forms.TreeView()
        Me.Exibir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnRetrair = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.lblTabelas = New System.Windows.Forms.Label()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'tvOS
        '
        Me.tvOS.Location = New System.Drawing.Point(12, 12)
        Me.tvOS.Name = "tvOS"
        Me.tvOS.Size = New System.Drawing.Size(499, 297)
        Me.tvOS.TabIndex = 0
        '
        'Exibir
        '
        Me.Exibir.Location = New System.Drawing.Point(566, 27)
        Me.Exibir.Name = "Exibir"
        Me.Exibir.Size = New System.Drawing.Size(75, 23)
        Me.Exibir.TabIndex = 1
        Me.Exibir.Text = "Exibir"
        Me.Exibir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(566, 114)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "btnSair "
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnRetrair
        '
        Me.btnRetrair.Location = New System.Drawing.Point(566, 85)
        Me.btnRetrair.Name = "btnRetrair"
        Me.btnRetrair.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrair.TabIndex = 3
        Me.btnRetrair.Text = "btnRetrair "
        Me.btnRetrair.UseVisualStyleBackColor = True
        '
        'btnExpandir
        '
        Me.btnExpandir.Location = New System.Drawing.Point(566, 56)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(75, 23)
        Me.btnExpandir.TabIndex = 4
        Me.btnExpandir.Text = "Expandir"
        Me.btnExpandir.UseVisualStyleBackColor = True
        '
        'lblTabelas
        '
        Me.lblTabelas.AutoSize = True
        Me.lblTabelas.Location = New System.Drawing.Point(736, 56)
        Me.lblTabelas.Name = "lblTabelas"
        Me.lblTabelas.Size = New System.Drawing.Size(58, 13)
        Me.lblTabelas.TabIndex = 5
        Me.lblTabelas.Text = "lblTabelas "
        '
        'ofd1
        '
        Me.ofd1.FileName = "OpenFileDialog1"
        '
        'FrmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 450)
        Me.Controls.Add(Me.lblTabelas)
        Me.Controls.Add(Me.btnExpandir)
        Me.Controls.Add(Me.btnRetrair)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Exibir)
        Me.Controls.Add(Me.tvOS)
        Me.Name = "FrmRelatorios"
        Me.Text = "FrmRelatorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvOS As TreeView
    Friend WithEvents Exibir As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnRetrair As Button
    Friend WithEvents btnExpandir As Button
    Friend WithEvents lblTabelas As Label
    Friend WithEvents ofd1 As OpenFileDialog
End Class
