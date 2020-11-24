<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMdiHome
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMdiHome))
		Me.dgvNotificacao = New System.Windows.Forms.DataGridView()
		Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Ordem = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TbNotificacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.NotificacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Notificacao = New ControleOS.Notificacao()
		Me.tmNotificacao = New System.Windows.Forms.Timer(Me.components)
		Me.TbNotificacaoTableAdapter = New ControleOS.NotificacaoTableAdapters.tbNotificacaoTableAdapter()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.rtxNotiExp = New System.Windows.Forms.RichTextBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.WHATSAPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FERRAMENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LeirorPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnMinimizar = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.lblContadorNotificacao = New System.Windows.Forms.Label()
		Me.pbStatus = New System.Windows.Forms.ProgressBar()
		Me.lblCaminhoDB = New System.Windows.Forms.Label()
		CType(Me.dgvNotificacao, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TbNotificacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NotificacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Notificacao, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvNotificacao
		'
		Me.dgvNotificacao.AllowUserToAddRows = False
		Me.dgvNotificacao.AllowUserToDeleteRows = False
		Me.dgvNotificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvNotificacao.AutoGenerateColumns = False
		Me.dgvNotificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvNotificacao.ColumnHeadersHeight = 15
		Me.dgvNotificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgvNotificacao.ColumnHeadersVisible = False
		Me.dgvNotificacao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescricaoDataGridViewTextBoxColumn, Me.Ordem})
		Me.dgvNotificacao.DataSource = Me.TbNotificacaoBindingSource
		Me.dgvNotificacao.Location = New System.Drawing.Point(1014, 422)
		Me.dgvNotificacao.Name = "dgvNotificacao"
		Me.dgvNotificacao.ReadOnly = True
		Me.dgvNotificacao.RowHeadersVisible = False
		Me.dgvNotificacao.Size = New System.Drawing.Size(54, 43)
		Me.dgvNotificacao.TabIndex = 11
		Me.dgvNotificacao.Visible = False
		'
		'DescricaoDataGridViewTextBoxColumn
		'
		Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
		Me.DescricaoDataGridViewTextBoxColumn.FillWeight = 194.9239!
		Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
		Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
		Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
		'
		'Ordem
		'
		Me.Ordem.DataPropertyName = "Ordem"
		Me.Ordem.FillWeight = 2.0!
		Me.Ordem.HeaderText = "Nº"
		Me.Ordem.Name = "Ordem"
		Me.Ordem.ReadOnly = True
		'
		'TbNotificacaoBindingSource
		'
		Me.TbNotificacaoBindingSource.DataMember = "tbNotificacao"
		Me.TbNotificacaoBindingSource.DataSource = Me.NotificacaoBindingSource
		'
		'NotificacaoBindingSource
		'
		Me.NotificacaoBindingSource.DataSource = Me.Notificacao
		Me.NotificacaoBindingSource.Position = 0
		'
		'Notificacao
		'
		Me.Notificacao.DataSetName = "Notificacao"
		Me.Notificacao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'tmNotificacao
		'
		Me.tmNotificacao.Interval = 6000
		'
		'TbNotificacaoTableAdapter
		'
		Me.TbNotificacaoTableAdapter.ClearBeforeFill = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1099, 22)
		Me.StatusStrip1.TabIndex = 18
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'rtxNotiExp
		'
		Me.rtxNotiExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxNotiExp.Location = New System.Drawing.Point(1014, 351)
		Me.rtxNotiExp.Name = "rtxNotiExp"
		Me.rtxNotiExp.Size = New System.Drawing.Size(54, 42)
		Me.rtxNotiExp.TabIndex = 23
		Me.rtxNotiExp.Text = ""
		Me.rtxNotiExp.Visible = False
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.Black
		Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WHATSAPPToolStripMenuItem, Me.FERRAMENTASToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.MenuStrip1.Size = New System.Drawing.Size(1099, 28)
		Me.MenuStrip1.TabIndex = 9
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'WHATSAPPToolStripMenuItem
		'
		Me.WHATSAPPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.WHATSAPPToolStripMenuItem.Image = Global.ControleOS.My.Resources.Resources.whatsapp
		Me.WHATSAPPToolStripMenuItem.Name = "WHATSAPPToolStripMenuItem"
		Me.WHATSAPPToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
		Me.WHATSAPPToolStripMenuItem.Text = "WHATSAPP"
		'
		'FERRAMENTASToolStripMenuItem
		'
		Me.FERRAMENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeirorPDFToolStripMenuItem})
		Me.FERRAMENTASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.FERRAMENTASToolStripMenuItem.Name = "FERRAMENTASToolStripMenuItem"
		Me.FERRAMENTASToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
		Me.FERRAMENTASToolStripMenuItem.Text = "&FERRAMENTAS"
		'
		'LeirorPDFToolStripMenuItem
		'
		Me.LeirorPDFToolStripMenuItem.Name = "LeirorPDFToolStripMenuItem"
		Me.LeirorPDFToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
		Me.LeirorPDFToolStripMenuItem.Text = "Leiror PDF"
		'
		'btnMinimizar
		'
		Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnMinimizar.BackColor = System.Drawing.Color.Black
		Me.btnMinimizar.BackgroundImage = Global.ControleOS.My.Resources.Resources.miniimizar23
		Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnMinimizar.FlatAppearance.BorderSize = 0
		Me.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
		Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
		Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMinimizar.Location = New System.Drawing.Point(1049, 0)
		Me.btnMinimizar.Name = "btnMinimizar"
		Me.btnMinimizar.Size = New System.Drawing.Size(19, 20)
		Me.btnMinimizar.TabIndex = 27
		Me.btnMinimizar.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.btnClose.BackgroundImage = Global.ControleOS.My.Resources.Resources._3026691
		Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClose.FlatAppearance.BorderSize = 0
		Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
		Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Location = New System.Drawing.Point(1070, 0)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(29, 20)
		Me.btnClose.TabIndex = 25
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PictureBox1.Image = Global.ControleOS.My.Resources.Resources.Notificacao
		Me.PictureBox1.Location = New System.Drawing.Point(934, 258)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 16
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.Visible = False
		'
		'lblContadorNotificacao
		'
		Me.lblContadorNotificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblContadorNotificacao.AutoSize = True
		Me.lblContadorNotificacao.BackColor = System.Drawing.Color.Transparent
		Me.lblContadorNotificacao.Image = Global.ControleOS.My.Resources.Resources.BackGround_Azul_Gradiente
		Me.lblContadorNotificacao.Location = New System.Drawing.Point(892, 293)
		Me.lblContadorNotificacao.Name = "lblContadorNotificacao"
		Me.lblContadorNotificacao.Size = New System.Drawing.Size(161, 16)
		Me.lblContadorNotificacao.TabIndex = 14
		Me.lblContadorNotificacao.Text = "Atualizando Notificações..."
		Me.lblContadorNotificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblContadorNotificacao.Visible = False
		'
		'pbStatus
		'
		Me.pbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pbStatus.Location = New System.Drawing.Point(0, 494)
		Me.pbStatus.Name = "pbStatus"
		Me.pbStatus.Size = New System.Drawing.Size(1099, 10)
		Me.pbStatus.TabIndex = 29
		'
		'lblCaminhoDB
		'
		Me.lblCaminhoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblCaminhoDB.AutoSize = True
		Me.lblCaminhoDB.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.lblCaminhoDB.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCaminhoDB.Location = New System.Drawing.Point(2, 504)
		Me.lblCaminhoDB.Name = "lblCaminhoDB"
		Me.lblCaminhoDB.Size = New System.Drawing.Size(40, 16)
		Me.lblCaminhoDB.TabIndex = 31
		Me.lblCaminhoDB.Text = "Label2"
		'
		'FrmMdiHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1099, 526)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblCaminhoDB)
		Me.Controls.Add(Me.pbStatus)
		Me.Controls.Add(Me.btnMinimizar)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.rtxNotiExp)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.lblContadorNotificacao)
		Me.Controls.Add(Me.dgvNotificacao)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.HelpButton = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "FrmMdiHome"
		Me.Text = " "
		CType(Me.dgvNotificacao, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TbNotificacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NotificacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Notificacao, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvNotificacao As DataGridView
    Friend WithEvents NotificacaoBindingSource As BindingSource
    Friend WithEvents Notificacao As Notificacao
    Friend WithEvents TbNotificacaoBindingSource As BindingSource
    Friend WithEvents TbNotificacaoTableAdapter As NotificacaoTableAdapters.tbNotificacaoTableAdapter
    Public WithEvents tmNotificacao As Timer
    Friend WithEvents lblContadorNotificacao As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents rtxNotiExp As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ordem As DataGridViewTextBoxColumn
    Friend WithEvents FERRAMENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeirorPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WHATSAPPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents pbStatus As ProgressBar
	Friend WithEvents lblCaminhoDB As Label
End Class
