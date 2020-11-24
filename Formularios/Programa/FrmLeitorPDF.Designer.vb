<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeitorPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeitorPDF))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARQUIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABRIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdAbrirPDF = New System.Windows.Forms.OpenFileDialog()
        Me.add = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARQUIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1177, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARQUIVOToolStripMenuItem
        '
        Me.ARQUIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABRIRToolStripMenuItem})
        Me.ARQUIVOToolStripMenuItem.Name = "ARQUIVOToolStripMenuItem"
        Me.ARQUIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARQUIVOToolStripMenuItem.Text = "&ARQUIVO"
        '
        'ABRIRToolStripMenuItem
        '
        Me.ABRIRToolStripMenuItem.Name = "ABRIRToolStripMenuItem"
        Me.ABRIRToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ABRIRToolStripMenuItem.Text = "ABRIR"
        '
        'ofdAbrirPDF
        '
        Me.ofdAbrirPDF.FileName = "ofdAbrirPDF"
        Me.ofdAbrirPDF.Filter = """Arquivo PDF|*.pdf"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(264, 79)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 2
        Me.add.Text = "Adicionar"
        Me.add.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(87, 165)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(192, 192)
        Me.AxAcroPDF1.TabIndex = 3
        '
        'FrmLeitorPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 565)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmLeitorPDF"
        Me.Text = "LEITOR PDF"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ARQUIVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABRIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ofdAbrirPDF As OpenFileDialog
    Friend WithEvents add As Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
