<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpPDV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpPDV))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARQUIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABRIRPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtResumoOSTableAdapter1 = New ControleOS.DataPdvTableAdapters.dtResumoOSTableAdapter()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARQUIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1224, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARQUIVOToolStripMenuItem
        '
        Me.ARQUIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABRIRPDFToolStripMenuItem, Me.SAIRToolStripMenuItem1})
        Me.ARQUIVOToolStripMenuItem.Name = "ARQUIVOToolStripMenuItem"
        Me.ARQUIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARQUIVOToolStripMenuItem.Text = "ARQUIVO"
        '
        'ABRIRPDFToolStripMenuItem
        '
        Me.ABRIRPDFToolStripMenuItem.Name = "ABRIRPDFToolStripMenuItem"
        Me.ABRIRPDFToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ABRIRPDFToolStripMenuItem.Text = "ABRIR PDF"
        '
        'SAIRToolStripMenuItem1
        '
        Me.SAIRToolStripMenuItem1.Name = "SAIRToolStripMenuItem1"
        Me.SAIRToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.SAIRToolStripMenuItem1.Text = "SAIR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxAcroPDF1)
        Me.Panel1.Location = New System.Drawing.Point(35, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 266)
        Me.Panel1.TabIndex = 6
        '
        'DtResumoOSTableAdapter1
        '
        Me.DtResumoOSTableAdapter1.ClearBeforeFill = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(36, 35)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(192, 192)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'FrmImpPDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 768)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmImpPDV"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
	'  Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents ARQUIVOToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ABRIRPDFToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SAIRToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents Panel1 As Panel
	Friend WithEvents DtResumoOSTableAdapter1 As DataPdvTableAdapters.dtResumoOSTableAdapter
	Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
