<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSelCaixa
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
	      Me.txtFundoCaixa = New System.Windows.Forms.TextBox()
	      Me.TextBox2 = New System.Windows.Forms.TextBox()
	      Me.txtStatus2 = New System.Windows.Forms.TextBox()
	      Me.TextBox3 = New System.Windows.Forms.TextBox()
	      Me.lblUsuario = New System.Windows.Forms.TextBox()
	      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
	      Me.btnAbrirFecharCaixa = New System.Windows.Forms.Button()
	      Me.Button2 = New System.Windows.Forms.Button()
	      Me.btnRealizarSangria = New System.Windows.Forms.Button()
	      Me.TabControl1 = New System.Windows.Forms.TabControl()
	      Me.TabPage1 = New System.Windows.Forms.TabPage()
	      Me.txtStatus3 = New System.Windows.Forms.TextBox()
	      Me.txtNumeroCaixa = New System.Windows.Forms.TextBox()
	      Me.TextBox5 = New System.Windows.Forms.TextBox()
	      Me.lblhora = New System.Windows.Forms.TextBox()
	      Me.lblData = New System.Windows.Forms.TextBox()
	      Me.Button3 = New System.Windows.Forms.Button()
	      Me.TabPage2 = New System.Windows.Forms.TabPage()
	      Me.TabControl2 = New System.Windows.Forms.TabControl()
	      Me.tbRelatorio_Historico = New System.Windows.Forms.TabPage()
	      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
	      Me.txtDataInicio = New System.Windows.Forms.TextBox()
	      Me.Button1 = New System.Windows.Forms.Button()
	      Me.txtDataFim = New System.Windows.Forms.TextBox()
	      Me.Label3 = New System.Windows.Forms.Label()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.Label2 = New System.Windows.Forms.Label()
	      Me.dgvHistAbertura = New System.Windows.Forms.DataGridView()
	      Me.tbRelatorio_ResumoDiario = New System.Windows.Forms.TabPage()
	      Me.TbHistoricoCaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataSety = New ControleOS.DataSety()
	      Me.Button5 = New System.Windows.Forms.Button()
	      Me.TbHistoricoCaixaTableAdapter = New ControleOS.DataSetyTableAdapters.tbHistoricoCaixaTableAdapter()
	      Me.TableAdapterManager = New ControleOS.DataSetyTableAdapters.TableAdapterManager()
	      Me.tmDelay = New System.Windows.Forms.Timer(Me.components)
	      Me.lblState = New System.Windows.Forms.Label()
	      Me.btnContinuar = New System.Windows.Forms.Button()
	      Me.pbSelCaixa = New System.Windows.Forms.ProgressBar()
	      Me.GroupBox1.SuspendLayout()
	      Me.TabControl1.SuspendLayout()
	      Me.TabPage1.SuspendLayout()
	      Me.TabPage2.SuspendLayout()
	      Me.TabControl2.SuspendLayout()
	      Me.tbRelatorio_Historico.SuspendLayout()
	      Me.GroupBox2.SuspendLayout()
	      CType(Me.dgvHistAbertura, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbHistoricoCaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataSety, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'txtFundoCaixa
	      '
	      Me.txtFundoCaixa.BackColor = System.Drawing.Color.Indigo
	      Me.txtFundoCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtFundoCaixa.ForeColor = System.Drawing.Color.White
	      Me.txtFundoCaixa.Location = New System.Drawing.Point(1, 311)
	      Me.txtFundoCaixa.Multiline = True
	      Me.txtFundoCaixa.Name = "txtFundoCaixa"
	      Me.txtFundoCaixa.ReadOnly = True
	      Me.txtFundoCaixa.Size = New System.Drawing.Size(786, 107)
	      Me.txtFundoCaixa.TabIndex = 1
	      Me.txtFundoCaixa.Text = "R$ 0,00"
	      Me.txtFundoCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'TextBox2
	      '
	      Me.TextBox2.BackColor = System.Drawing.Color.Indigo
	      Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.TextBox2.ForeColor = System.Drawing.Color.White
	      Me.TextBox2.Location = New System.Drawing.Point(559, 373)
	      Me.TextBox2.Name = "TextBox2"
	      Me.TextBox2.ReadOnly = True
	      Me.TextBox2.Size = New System.Drawing.Size(228, 45)
	      Me.TextBox2.TabIndex = 2
	      Me.TextBox2.Text = " EM CAIXA"
	      '
	      'txtStatus2
	      '
	      Me.txtStatus2.BackColor = System.Drawing.Color.Indigo
	      Me.txtStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtStatus2.ForeColor = System.Drawing.Color.Black
	      Me.txtStatus2.Location = New System.Drawing.Point(3, 80)
	      Me.txtStatus2.Name = "txtStatus2"
	      Me.txtStatus2.ReadOnly = True
	      Me.txtStatus2.Size = New System.Drawing.Size(118, 24)
	      Me.txtStatus2.TabIndex = 11
	      Me.txtStatus2.Text = "STATUS CAIXA "
	      Me.txtStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'TextBox3
	      '
	      Me.TextBox3.BackColor = System.Drawing.Color.Indigo
	      Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.TextBox3.ForeColor = System.Drawing.Color.White
	      Me.TextBox3.Location = New System.Drawing.Point(7, 143)
	      Me.TextBox3.Name = "TextBox3"
	      Me.TextBox3.ReadOnly = True
	      Me.TextBox3.Size = New System.Drawing.Size(101, 24)
	      Me.TextBox3.TabIndex = 13
	      Me.TextBox3.Text = "USUARIO "
	      Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'lblUsuario
	      '
	      Me.lblUsuario.BackColor = System.Drawing.Color.Indigo
	      Me.lblUsuario.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblUsuario.ForeColor = System.Drawing.Color.White
	      Me.lblUsuario.Location = New System.Drawing.Point(37, 171)
	      Me.lblUsuario.Name = "lblUsuario"
	      Me.lblUsuario.ReadOnly = True
	      Me.lblUsuario.Size = New System.Drawing.Size(116, 28)
	      Me.lblUsuario.TabIndex = 12
	      Me.lblUsuario.Text = "Nome"
	      Me.lblUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'GroupBox1
	      '
	      Me.GroupBox1.Controls.Add(Me.btnAbrirFecharCaixa)
	      Me.GroupBox1.Controls.Add(Me.Button2)
	      Me.GroupBox1.Controls.Add(Me.btnRealizarSangria)
	      Me.GroupBox1.ForeColor = System.Drawing.Color.White
	      Me.GroupBox1.Location = New System.Drawing.Point(584, 124)
	      Me.GroupBox1.Name = "GroupBox1"
	      Me.GroupBox1.Size = New System.Drawing.Size(203, 181)
	      Me.GroupBox1.TabIndex = 11
	      Me.GroupBox1.TabStop = False
	      '
	      'btnAbrirFecharCaixa
	      '
	      Me.btnAbrirFecharCaixa.BackColor = System.Drawing.Color.Indigo
	      Me.btnAbrirFecharCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnAbrirFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAbrirFecharCaixa.Location = New System.Drawing.Point(-2, 116)
	      Me.btnAbrirFecharCaixa.Name = "btnAbrirFecharCaixa"
	      Me.btnAbrirFecharCaixa.Size = New System.Drawing.Size(203, 51)
	      Me.btnAbrirFecharCaixa.TabIndex = 20
	      Me.btnAbrirFecharCaixa.Text = "ABRIR/FECHAR"
	      Me.btnAbrirFecharCaixa.UseVisualStyleBackColor = False
	      '
	      'Button2
	      '
	      Me.Button2.BackColor = System.Drawing.Color.Indigo
	      Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
	      Me.Button2.FlatAppearance.BorderSize = 0
	      Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.Button2.Location = New System.Drawing.Point(-1, 11)
	      Me.Button2.Name = "Button2"
	      Me.Button2.Size = New System.Drawing.Size(203, 51)
	      Me.Button2.TabIndex = 15
	      Me.Button2.Text = "INSERIR APOIO"
	      Me.Button2.UseVisualStyleBackColor = False
	      '
	      'btnRealizarSangria
	      '
	      Me.btnRealizarSangria.BackColor = System.Drawing.Color.Indigo
	      Me.btnRealizarSangria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnRealizarSangria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnRealizarSangria.Location = New System.Drawing.Point(-2, 63)
	      Me.btnRealizarSangria.Name = "btnRealizarSangria"
	      Me.btnRealizarSangria.Size = New System.Drawing.Size(203, 51)
	      Me.btnRealizarSangria.TabIndex = 14
	      Me.btnRealizarSangria.Text = "REALIZAR SANGRIA"
	      Me.btnRealizarSangria.UseVisualStyleBackColor = False
	      '
	      'TabControl1
	      '
	      Me.TabControl1.Controls.Add(Me.TabPage1)
	      Me.TabControl1.Controls.Add(Me.TabPage2)
	      Me.TabControl1.Location = New System.Drawing.Point(2, 22)
	      Me.TabControl1.Name = "TabControl1"
	      Me.TabControl1.SelectedIndex = 0
	      Me.TabControl1.Size = New System.Drawing.Size(802, 455)
	      Me.TabControl1.TabIndex = 16
	      '
	      'TabPage1
	      '
	      Me.TabPage1.BackColor = System.Drawing.Color.Silver
	      Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.TabPage1.Controls.Add(Me.txtStatus3)
	      Me.TabPage1.Controls.Add(Me.txtNumeroCaixa)
	      Me.TabPage1.Controls.Add(Me.TextBox5)
	      Me.TabPage1.Controls.Add(Me.lblhora)
	      Me.TabPage1.Controls.Add(Me.lblData)
	      Me.TabPage1.Controls.Add(Me.TextBox3)
	      Me.TabPage1.Controls.Add(Me.lblUsuario)
	      Me.TabPage1.Controls.Add(Me.TextBox2)
	      Me.TabPage1.Controls.Add(Me.GroupBox1)
	      Me.TabPage1.Controls.Add(Me.txtFundoCaixa)
	      Me.TabPage1.Controls.Add(Me.txtStatus2)
	      Me.TabPage1.Controls.Add(Me.Button3)
	      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
	      Me.TabPage1.Name = "TabPage1"
	      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
	      Me.TabPage1.Size = New System.Drawing.Size(794, 429)
	      Me.TabPage1.TabIndex = 0
	      Me.TabPage1.Text = "Guia Principal"
	      '
	      'txtStatus3
	      '
	      Me.txtStatus3.BackColor = System.Drawing.Color.Indigo
	      Me.txtStatus3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtStatus3.ForeColor = System.Drawing.Color.Black
	      Me.txtStatus3.Location = New System.Drawing.Point(37, 106)
	      Me.txtStatus3.Name = "txtStatus3"
	      Me.txtStatus3.ReadOnly = True
	      Me.txtStatus3.Size = New System.Drawing.Size(116, 24)
	      Me.txtStatus3.TabIndex = 23
	      Me.txtStatus3.Text = "000"
	      Me.txtStatus3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'txtNumeroCaixa
	      '
	      Me.txtNumeroCaixa.BackColor = System.Drawing.Color.Indigo
	      Me.txtNumeroCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtNumeroCaixa.ForeColor = System.Drawing.Color.White
	      Me.txtNumeroCaixa.Location = New System.Drawing.Point(37, 38)
	      Me.txtNumeroCaixa.Name = "txtNumeroCaixa"
	      Me.txtNumeroCaixa.ReadOnly = True
	      Me.txtNumeroCaixa.Size = New System.Drawing.Size(116, 24)
	      Me.txtNumeroCaixa.TabIndex = 22
	      Me.txtNumeroCaixa.Text = "000"
	      Me.txtNumeroCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'TextBox5
	      '
	      Me.TextBox5.BackColor = System.Drawing.Color.Indigo
	      Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.TextBox5.ForeColor = System.Drawing.Color.White
	      Me.TextBox5.Location = New System.Drawing.Point(6, 12)
	      Me.TextBox5.Name = "TextBox5"
	      Me.TextBox5.ReadOnly = True
	      Me.TextBox5.Size = New System.Drawing.Size(118, 24)
	      Me.TextBox5.TabIndex = 21
	      Me.TextBox5.Text = "Nº CAIXA "
	      Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'lblhora
	      '
	      Me.lblhora.BackColor = System.Drawing.Color.Indigo
	      Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblhora.ForeColor = System.Drawing.Color.White
	      Me.lblhora.Location = New System.Drawing.Point(7, 213)
	      Me.lblhora.Name = "lblhora"
	      Me.lblhora.ReadOnly = True
	      Me.lblhora.Size = New System.Drawing.Size(101, 24)
	      Me.lblhora.TabIndex = 18
	      Me.lblhora.Text = "hora"
	      Me.lblhora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'lblData
	      '
	      Me.lblData.BackColor = System.Drawing.Color.Indigo
	      Me.lblData.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblData.ForeColor = System.Drawing.Color.White
	      Me.lblData.Location = New System.Drawing.Point(37, 239)
	      Me.lblData.Name = "lblData"
	      Me.lblData.ReadOnly = True
	      Me.lblData.Size = New System.Drawing.Size(116, 28)
	      Me.lblData.TabIndex = 17
	      Me.lblData.Text = "data"
	      Me.lblData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'Button3
	      '
	      Me.Button3.BackgroundImage = Global.ControleOS.My.Resources.Resources.NLG
	      Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.Button3.Location = New System.Drawing.Point(686, 6)
	      Me.Button3.Name = "Button3"
	      Me.Button3.Size = New System.Drawing.Size(102, 105)
	      Me.Button3.TabIndex = 15
	      Me.Button3.UseVisualStyleBackColor = True
	      '
	      'TabPage2
	      '
	      Me.TabPage2.AutoScroll = True
	      Me.TabPage2.Controls.Add(Me.TabControl2)
	      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
	      Me.TabPage2.Name = "TabPage2"
	      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
	      Me.TabPage2.Size = New System.Drawing.Size(794, 429)
	      Me.TabPage2.TabIndex = 1
	      Me.TabPage2.Text = "Relatórios"
	      Me.TabPage2.UseVisualStyleBackColor = True
	      '
	      'TabControl2
	      '
	      Me.TabControl2.Controls.Add(Me.tbRelatorio_Historico)
	      Me.TabControl2.Controls.Add(Me.tbRelatorio_ResumoDiario)
	      Me.TabControl2.Location = New System.Drawing.Point(6, 6)
	      Me.TabControl2.Name = "TabControl2"
	      Me.TabControl2.SelectedIndex = 0
	      Me.TabControl2.Size = New System.Drawing.Size(780, 420)
	      Me.TabControl2.TabIndex = 0
	      '
	      'tbRelatorio_Historico
	      '
	      Me.tbRelatorio_Historico.AutoScroll = True
	      Me.tbRelatorio_Historico.BackColor = System.Drawing.Color.Silver
	      Me.tbRelatorio_Historico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.tbRelatorio_Historico.Controls.Add(Me.GroupBox2)
	      Me.tbRelatorio_Historico.Controls.Add(Me.dgvHistAbertura)
	      Me.tbRelatorio_Historico.Location = New System.Drawing.Point(4, 22)
	      Me.tbRelatorio_Historico.Name = "tbRelatorio_Historico"
	      Me.tbRelatorio_Historico.Padding = New System.Windows.Forms.Padding(3)
	      Me.tbRelatorio_Historico.Size = New System.Drawing.Size(772, 394)
	      Me.tbRelatorio_Historico.TabIndex = 0
	      Me.tbRelatorio_Historico.Text = "Historico"
	      '
	      'GroupBox2
	      '
	      Me.GroupBox2.Controls.Add(Me.txtDataInicio)
	      Me.GroupBox2.Controls.Add(Me.Button1)
	      Me.GroupBox2.Controls.Add(Me.txtDataFim)
	      Me.GroupBox2.Controls.Add(Me.Label3)
	      Me.GroupBox2.Controls.Add(Me.Label1)
	      Me.GroupBox2.Controls.Add(Me.Label2)
	      Me.GroupBox2.Location = New System.Drawing.Point(6, 8)
	      Me.GroupBox2.Name = "GroupBox2"
	      Me.GroupBox2.Size = New System.Drawing.Size(250, 93)
	      Me.GroupBox2.TabIndex = 24
	      Me.GroupBox2.TabStop = False
	      '
	      'txtDataInicio
	      '
	      Me.txtDataInicio.Location = New System.Drawing.Point(6, 35)
	      Me.txtDataInicio.Name = "txtDataInicio"
	      Me.txtDataInicio.Size = New System.Drawing.Size(100, 20)
	      Me.txtDataInicio.TabIndex = 1
	      '
	      'Button1
	      '
	      Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
	      Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
	      Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.Button1.Location = New System.Drawing.Point(7, 63)
	      Me.Button1.Name = "Button1"
	      Me.Button1.Size = New System.Drawing.Size(236, 24)
	      Me.Button1.TabIndex = 23
	      Me.Button1.Text = "APLICAR FILTRO"
	      Me.Button1.UseVisualStyleBackColor = False
	      '
	      'txtDataFim
	      '
	      Me.txtDataFim.Location = New System.Drawing.Point(143, 35)
	      Me.txtDataFim.Name = "txtDataFim"
	      Me.txtDataFim.Size = New System.Drawing.Size(100, 20)
	      Me.txtDataFim.TabIndex = 2
	      '
	      'Label3
	      '
	      Me.Label3.AutoSize = True
	      Me.Label3.Location = New System.Drawing.Point(164, 19)
	      Me.Label3.Name = "Label3"
	      Me.Label3.Size = New System.Drawing.Size(49, 13)
	      Me.Label3.TabIndex = 5
	      Me.Label3.Text = "Data Fim"
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label1.Location = New System.Drawing.Point(115, 33)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(19, 25)
	      Me.Label1.TabIndex = 3
	      Me.Label1.Text = "-"
	      '
	      'Label2
	      '
	      Me.Label2.AutoSize = True
	      Me.Label2.Location = New System.Drawing.Point(21, 19)
	      Me.Label2.Name = "Label2"
	      Me.Label2.Size = New System.Drawing.Size(58, 13)
	      Me.Label2.TabIndex = 4
	      Me.Label2.Text = "Data Inicio"
	      '
	      'dgvHistAbertura
	      '
	      Me.dgvHistAbertura.AllowUserToAddRows = False
	      Me.dgvHistAbertura.AllowUserToDeleteRows = False
	      Me.dgvHistAbertura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvHistAbertura.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
	      Me.dgvHistAbertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvHistAbertura.Location = New System.Drawing.Point(6, 107)
	      Me.dgvHistAbertura.Name = "dgvHistAbertura"
	      Me.dgvHistAbertura.ReadOnly = True
	      Me.dgvHistAbertura.RowHeadersVisible = False
	      Me.dgvHistAbertura.Size = New System.Drawing.Size(760, 284)
	      Me.dgvHistAbertura.TabIndex = 0
	      '
	      'tbRelatorio_ResumoDiario
	      '
	      Me.tbRelatorio_ResumoDiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
	      Me.tbRelatorio_ResumoDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.tbRelatorio_ResumoDiario.Location = New System.Drawing.Point(4, 22)
	      Me.tbRelatorio_ResumoDiario.Name = "tbRelatorio_ResumoDiario"
	      Me.tbRelatorio_ResumoDiario.Padding = New System.Windows.Forms.Padding(3)
	      Me.tbRelatorio_ResumoDiario.Size = New System.Drawing.Size(772, 394)
	      Me.tbRelatorio_ResumoDiario.TabIndex = 1
	      Me.tbRelatorio_ResumoDiario.Text = "Resumo Diario"
	      '
	      'TbHistoricoCaixaBindingSource
	      '
	      Me.TbHistoricoCaixaBindingSource.DataMember = "tbHistoricoCaixa"
	      Me.TbHistoricoCaixaBindingSource.DataSource = Me.DataSety
	      '
	      'DataSety
	      '
	      Me.DataSety.DataSetName = "DataSety"
	      Me.DataSety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'Button5
	      '
	      Me.Button5.BackgroundImage = Global.ControleOS.My.Resources.Resources.Cancelar
	      Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.Button5.FlatAppearance.BorderSize = 0
	      Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.Button5.Location = New System.Drawing.Point(766, 3)
	      Me.Button5.Name = "Button5"
	      Me.Button5.Size = New System.Drawing.Size(31, 26)
	      Me.Button5.TabIndex = 20
	      Me.Button5.UseVisualStyleBackColor = True
	      '
	      'TbHistoricoCaixaTableAdapter
	      '
	      Me.TbHistoricoCaixaTableAdapter.ClearBeforeFill = True
	      '
	      'TableAdapterManager
	      '
	      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
	      Me.TableAdapterManager.tbFormaPagamentoTableAdapter = Nothing
	      Me.TableAdapterManager.tbHistoricoCaixaTableAdapter = Me.TbHistoricoCaixaTableAdapter
	      Me.TableAdapterManager.tbOSTableAdapter = Nothing
	      Me.TableAdapterManager.tbPlanoContaTableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutoVendaTableAdapter = Nothing
	      Me.TableAdapterManager.UpdateOrder = ControleOS.DataSetyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'tmDelay
	      '
	      Me.tmDelay.Interval = 3000
	      '
	      'lblState
	      '
	      Me.lblState.AutoSize = True
	      Me.lblState.BackColor = System.Drawing.Color.Transparent
	      Me.lblState.Location = New System.Drawing.Point(12, 484)
	      Me.lblState.Name = "lblState"
	      Me.lblState.Size = New System.Drawing.Size(93, 13)
	      Me.lblState.TabIndex = 22
	      Me.lblState.Text = "BD ATUALIZADO"
	      '
	      'btnContinuar
	      '
	      Me.btnContinuar.BackColor = System.Drawing.Color.Indigo
	      Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
	      Me.btnContinuar.FlatAppearance.BorderSize = 0
	      Me.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
	      Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnContinuar.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnContinuar.ForeColor = System.Drawing.Color.White
	      Me.btnContinuar.Location = New System.Drawing.Point(687, 477)
	      Me.btnContinuar.Name = "btnContinuar"
	      Me.btnContinuar.Size = New System.Drawing.Size(113, 27)
	      Me.btnContinuar.TabIndex = 21
	      Me.btnContinuar.Text = "CONTINUAR"
	      Me.btnContinuar.UseVisualStyleBackColor = False
	      '
	      'pbSelCaixa
	      '
	      Me.pbSelCaixa.Location = New System.Drawing.Point(322, 479)
	      Me.pbSelCaixa.Name = "pbSelCaixa"
	      Me.pbSelCaixa.Size = New System.Drawing.Size(359, 23)
	      Me.pbSelCaixa.Style = System.Windows.Forms.ProgressBarStyle.Continuous
	      Me.pbSelCaixa.TabIndex = 24
	      '
	      'FrmSelCaixa
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.BackColor = System.Drawing.Color.White
	      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.ClientSize = New System.Drawing.Size(804, 506)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.pbSelCaixa)
	      Me.Controls.Add(Me.btnContinuar)
	      Me.Controls.Add(Me.lblState)
	      Me.Controls.Add(Me.Button5)
	      Me.Controls.Add(Me.TabControl1)
	      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
	      Me.Name = "FrmSelCaixa"
	      Me.ShowInTaskbar = False
	      Me.GroupBox1.ResumeLayout(False)
	      Me.TabControl1.ResumeLayout(False)
	      Me.TabPage1.ResumeLayout(False)
	      Me.TabPage1.PerformLayout()
	      Me.TabPage2.ResumeLayout(False)
	      Me.TabControl2.ResumeLayout(False)
	      Me.tbRelatorio_Historico.ResumeLayout(False)
	      Me.GroupBox2.ResumeLayout(False)
	      Me.GroupBox2.PerformLayout()
	      CType(Me.dgvHistAbertura, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbHistoricoCaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataSety, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)
	      Me.PerformLayout()

        End Sub

        Friend WithEvents txtFundoCaixa As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtStatus2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblUsuario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRealizarSangria As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents lblhora As TextBox
    Friend WithEvents lblData As TextBox
    Friend WithEvents btnAbrirFecharCaixa As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtNumeroCaixa As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtStatus3 As TextBox
    Friend WithEvents DataSety As DataSety
    Friend WithEvents TbHistoricoCaixaBindingSource As BindingSource
    Friend WithEvents TbHistoricoCaixaTableAdapter As DataSetyTableAdapters.tbHistoricoCaixaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetyTableAdapters.TableAdapterManager
    Friend WithEvents dgvHistAbertura As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tbRelatorio_Historico As TabPage
    Friend WithEvents tbRelatorio_ResumoDiario As TabPage
    Friend WithEvents tmDelay As Timer
    Friend WithEvents lblState As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDataInicio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDataFim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnContinuar As Button
    Friend WithEvents pbSelCaixa As ProgressBar
End Class
