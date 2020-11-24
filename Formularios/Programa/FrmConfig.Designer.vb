<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
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
        Me.RdAprovarOS = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'RdAprovarOS
        '
        Me.RdAprovarOS.AutoSize = True
        Me.RdAprovarOS.Location = New System.Drawing.Point(12, 27)
        Me.RdAprovarOS.Name = "RdAprovarOS"
        Me.RdAprovarOS.Size = New System.Drawing.Size(156, 17)
        Me.RdAprovarOS.TabIndex = 0
        Me.RdAprovarOS.TabStop = True
        Me.RdAprovarOS.Text = "APROVAR ORÇAMENTOS"
        Me.RdAprovarOS.UseVisualStyleBackColor = True
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 773)
        Me.Controls.Add(Me.RdAprovarOS)
        Me.Name = "FrmConfig"
        Me.Text = "CONFIGURAÇÕES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RdAprovarOS As RadioButton
End Class
