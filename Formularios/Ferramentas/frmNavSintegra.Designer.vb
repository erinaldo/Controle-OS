<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavSintegra
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
		Me.wbSintegra = New System.Windows.Forms.WebBrowser()
		Me.btnHomePage = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'wbSintegra
		'
		Me.wbSintegra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wbSintegra.Location = New System.Drawing.Point(12, 63)
		Me.wbSintegra.MinimumSize = New System.Drawing.Size(20, 20)
		Me.wbSintegra.Name = "wbSintegra"
		Me.wbSintegra.Size = New System.Drawing.Size(776, 375)
		Me.wbSintegra.TabIndex = 0
		Me.wbSintegra.Url = New System.Uri("http://e", System.UriKind.Absolute)
		'
		'btnHomePage
		'
		Me.btnHomePage.BackgroundImage = Global.ControleOS.My.Resources.Resources.house
		Me.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnHomePage.Location = New System.Drawing.Point(12, 12)
		Me.btnHomePage.Name = "btnHomePage"
		Me.btnHomePage.Size = New System.Drawing.Size(36, 31)
		Me.btnHomePage.TabIndex = 1
		Me.btnHomePage.UseVisualStyleBackColor = True
		'
		'frmNavSintegra
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnHomePage)
		Me.Controls.Add(Me.wbSintegra)
		Me.Name = "frmNavSintegra"
		Me.Text = " e"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents wbSintegra As WebBrowser
    Friend WithEvents btnHomePage As Button
End Class
