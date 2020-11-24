<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRelatorioFinanceiro
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelatorioFinanceiro))
		Me.dgvProdutoInicio = New System.Windows.Forms.DataGridView()
		Me.chtPlano = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.txtDataFinal = New System.Windows.Forms.TextBox()
		Me.txtDataInicial = New System.Windows.Forms.TextBox()
		Me.pc1 = New System.Windows.Forms.PictureBox()
		Me.dgvProdutoadicional = New System.Windows.Forms.DataGridView()
		Me.dgvFinanceiro = New System.Windows.Forms.DataGridView()
		Me.chkOcultarTotais = New System.Windows.Forms.CheckBox()
		Me.chkOcultarPag = New System.Windows.Forms.CheckBox()
		Me.ofdLocIcone = New System.Windows.Forms.OpenFileDialog()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.AquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrefêrenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RedefinirIconeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AtualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnTeste = New System.Windows.Forms.Button()
		CType(Me.dgvProdutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chtPlano, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pc1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvProdutoadicional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvProdutoInicio
		'
		Me.dgvProdutoInicio.AllowUserToAddRows = False
		Me.dgvProdutoInicio.AllowUserToDeleteRows = False
		Me.dgvProdutoInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvProdutoInicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvProdutoInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProdutoInicio.Location = New System.Drawing.Point(776, 441)
		Me.dgvProdutoInicio.Name = "dgvProdutoInicio"
		Me.dgvProdutoInicio.ReadOnly = True
		Me.dgvProdutoInicio.Size = New System.Drawing.Size(55, 55)
		Me.dgvProdutoInicio.TabIndex = 5
		'
		'chtPlano
		'
		Me.chtPlano.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		ChartArea1.Name = "ChartArea1"
		Me.chtPlano.ChartAreas.Add(ChartArea1)
		Me.chtPlano.Cursor = System.Windows.Forms.Cursors.Default
		Legend1.Name = "Planos de Conta"
		Me.chtPlano.Legends.Add(Legend1)
		Me.chtPlano.Location = New System.Drawing.Point(656, 27)
		Me.chtPlano.Name = "chtPlano"
		Series1.ChartArea = "ChartArea1"
		Series1.LabelFormat = "%"
		Series1.Legend = "Planos de Conta"
		Series1.Name = "Series1"
		Me.chtPlano.Series.Add(Series1)
		Me.chtPlano.Size = New System.Drawing.Size(556, 349)
		Me.chtPlano.TabIndex = 94
		Me.chtPlano.Text = "Gastos"
		Title1.Name = "Lançamentos"
		Me.chtPlano.Titles.Add(Title1)
		'
		'txtDataFinal
		'
		Me.txtDataFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDataFinal.Location = New System.Drawing.Point(566, 110)
		Me.txtDataFinal.Name = "txtDataFinal"
		Me.txtDataFinal.ReadOnly = True
		Me.txtDataFinal.Size = New System.Drawing.Size(67, 20)
		Me.txtDataFinal.TabIndex = 0
		Me.txtDataFinal.Text = "30/08/2020"
		'
		'txtDataInicial
		'
		Me.txtDataInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDataInicial.Location = New System.Drawing.Point(566, 84)
		Me.txtDataInicial.Name = "txtDataInicial"
		Me.txtDataInicial.ReadOnly = True
		Me.txtDataInicial.Size = New System.Drawing.Size(67, 20)
		Me.txtDataInicial.TabIndex = 91
		Me.txtDataInicial.Text = "01/08/2020"
		'
		'pc1
		'
		Me.pc1.Image = Global.ControleOS.My.Resources.Resources.NLG
		Me.pc1.Location = New System.Drawing.Point(775, 441)
		Me.pc1.Name = "pc1"
		Me.pc1.Size = New System.Drawing.Size(56, 55)
		Me.pc1.TabIndex = 93
		Me.pc1.TabStop = False
		Me.pc1.Visible = False
		'
		'dgvProdutoadicional
		'
		Me.dgvProdutoadicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProdutoadicional.Location = New System.Drawing.Point(792, 451)
		Me.dgvProdutoadicional.Name = "dgvProdutoadicional"
		Me.dgvProdutoadicional.Size = New System.Drawing.Size(55, 33)
		Me.dgvProdutoadicional.TabIndex = 4
		'
		'dgvFinanceiro
		'
		Me.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvFinanceiro.Location = New System.Drawing.Point(792, 451)
		Me.dgvFinanceiro.Name = "dgvFinanceiro"
		Me.dgvFinanceiro.Size = New System.Drawing.Size(55, 33)
		Me.dgvFinanceiro.TabIndex = 3
		'
		'chkOcultarTotais
		'
		Me.chkOcultarTotais.AutoSize = True
		Me.chkOcultarTotais.Location = New System.Drawing.Point(556, 443)
		Me.chkOcultarTotais.Name = "chkOcultarTotais"
		Me.chkOcultarTotais.Size = New System.Drawing.Size(92, 17)
		Me.chkOcultarTotais.TabIndex = 7
		Me.chkOcultarTotais.Text = "Ocultar Totais"
		Me.chkOcultarTotais.UseVisualStyleBackColor = True
		'
		'chkOcultarPag
		'
		Me.chkOcultarPag.AutoSize = True
		Me.chkOcultarPag.Location = New System.Drawing.Point(556, 466)
		Me.chkOcultarPag.Name = "chkOcultarPag"
		Me.chkOcultarPag.Size = New System.Drawing.Size(80, 30)
		Me.chkOcultarPag.TabIndex = 6
		Me.chkOcultarPag.Text = "Ocultar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagamento"
		Me.chkOcultarPag.UseVisualStyleBackColor = True
		'
		'ofdLocIcone
		'
		Me.ofdLocIcone.FileName = "Icone"
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AquivoToolStripMenuItem, Me.PrefêrenciasToolStripMenuItem, Me.AtualizarToolStripMenuItem, Me.SairToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1224, 24)
		Me.MenuStrip1.TabIndex = 81
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'AquivoToolStripMenuItem
		'
		Me.AquivoToolStripMenuItem.Name = "AquivoToolStripMenuItem"
		Me.AquivoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.AquivoToolStripMenuItem.Text = "&Aquivo"
		'
		'PrefêrenciasToolStripMenuItem
		'
		Me.PrefêrenciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedefinirIconeToolStripMenuItem})
		Me.PrefêrenciasToolStripMenuItem.Name = "PrefêrenciasToolStripMenuItem"
		Me.PrefêrenciasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
		Me.PrefêrenciasToolStripMenuItem.Text = "&Preferências"
		'
		'RedefinirIconeToolStripMenuItem
		'
		Me.RedefinirIconeToolStripMenuItem.Name = "RedefinirIconeToolStripMenuItem"
		Me.RedefinirIconeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
		Me.RedefinirIconeToolStripMenuItem.Text = "Redefinir Icone"
		'
		'AtualizarToolStripMenuItem
		'
		Me.AtualizarToolStripMenuItem.Name = "AtualizarToolStripMenuItem"
		Me.AtualizarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
		Me.AtualizarToolStripMenuItem.Text = "&Atualizar"
		'
		'SairToolStripMenuItem
		'
		Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
		Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
		Me.SairToolStripMenuItem.Text = "&Sair"
		'
		'ListView1
		'
		Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ListView1.HideSelection = False
		Me.ListView1.Location = New System.Drawing.Point(656, 381)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(556, 189)
		Me.ListView1.TabIndex = 92
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'AxAcroPDF1
		'
		Me.AxAcroPDF1.Enabled = True
		Me.AxAcroPDF1.Location = New System.Drawing.Point(12, 27)
		Me.AxAcroPDF1.Name = "AxAcroPDF1"
		Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxAcroPDF1.Size = New System.Drawing.Size(502, 690)
		Me.AxAcroPDF1.TabIndex = 95
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(575, 68)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 13)
		Me.Label1.TabIndex = 96
		Me.Label1.Text = "Mês Ref.:"
		'
		'btnTeste
		'
		Me.btnTeste.Location = New System.Drawing.Point(561, 525)
		Me.btnTeste.Name = "btnTeste"
		Me.btnTeste.Size = New System.Drawing.Size(75, 23)
		Me.btnTeste.TabIndex = 97
		Me.btnTeste.Text = "Button1"
		Me.btnTeste.UseVisualStyleBackColor = True
		'
		'FrmRelatorioFinanceiro
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1224, 729)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnTeste)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ListView1)
		Me.Controls.Add(Me.AxAcroPDF1)
		Me.Controls.Add(Me.dgvProdutoadicional)
		Me.Controls.Add(Me.dgvFinanceiro)
		Me.Controls.Add(Me.chkOcultarTotais)
		Me.Controls.Add(Me.pc1)
		Me.Controls.Add(Me.chkOcultarPag)
		Me.Controls.Add(Me.txtDataFinal)
		Me.Controls.Add(Me.txtDataInicial)
		Me.Controls.Add(Me.chtPlano)
		Me.Controls.Add(Me.dgvProdutoInicio)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FrmRelatorioFinanceiro"
		Me.Text = "FrmRelatorioFinanceiro"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.dgvProdutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chtPlano, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pc1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvProdutoadicional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvProdutoadicional As DataGridView
	Friend WithEvents dgvFinanceiro As DataGridView
	Friend WithEvents dgvProdutoInicio As DataGridView
	Friend WithEvents chkOcultarPag As CheckBox
	Friend WithEvents chkOcultarTotais As CheckBox
	Friend WithEvents txtDataInicial As TextBox
	Friend WithEvents txtDataFinal As TextBox
	Friend WithEvents chtPlano As DataVisualization.Charting.Chart
	Friend WithEvents ofdLocIcone As OpenFileDialog
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents AquivoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PrefêrenciasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RedefinirIconeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents pc1 As PictureBox
	Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AtualizarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListView1 As ListView
	Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
	Friend WithEvents Label1 As Label
	Friend WithEvents btnTeste As Button
End Class
