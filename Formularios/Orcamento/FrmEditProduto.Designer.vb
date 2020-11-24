<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditProduto
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
        Me.txtProdutoID = New System.Windows.Forms.TextBox()
        Me.cboDescricao = New System.Windows.Forms.TextBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboGesseiro = New System.Windows.Forms.ComboBox()
        Me.TbGesseirosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalServico = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalMDO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbGesseirosTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter()
        Me.btnEditarProduto = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoProduto = New System.Windows.Forms.TextBox()
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdutoID
        '
        Me.txtProdutoID.Location = New System.Drawing.Point(52, 52)
        Me.txtProdutoID.Name = "txtProdutoID"
        Me.txtProdutoID.ReadOnly = True
        Me.txtProdutoID.Size = New System.Drawing.Size(142, 20)
        Me.txtProdutoID.TabIndex = 46
        '
        'cboDescricao
        '
        Me.cboDescricao.Location = New System.Drawing.Point(53, 95)
        Me.cboDescricao.Name = "cboDescricao"
        Me.cboDescricao.Size = New System.Drawing.Size(307, 20)
        Me.cboDescricao.TabIndex = 45
        '
        'txtLocal
        '
        Me.txtLocal.AcceptsReturn = True
        Me.txtLocal.Location = New System.Drawing.Point(52, 141)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(107, 20)
        Me.txtLocal.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(50, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Código de Venda do Produto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(162, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Prestador"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(55, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Ambiente"
        '
        'cboGesseiro
        '
        Me.cboGesseiro.DataSource = Me.TbGesseirosBindingSource
        Me.cboGesseiro.DisplayMember = "Nome"
        Me.cboGesseiro.FormattingEnabled = True
        Me.cboGesseiro.Location = New System.Drawing.Point(165, 140)
        Me.cboGesseiro.Name = "cboGesseiro"
        Me.cboGesseiro.Size = New System.Drawing.Size(174, 21)
        Me.cboGesseiro.TabIndex = 26
        '
        'TbGesseirosBindingSource
        '
        Me.TbGesseirosBindingSource.DataMember = "tbGesseiros"
        Me.TbGesseirosBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(53, 180)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.ReadOnly = True
        Me.txtUnidade.Size = New System.Drawing.Size(106, 20)
        Me.txtUnidade.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Un."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total Serviço"
        '
        'txtTotalServico
        '
        Me.txtTotalServico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalServico.Location = New System.Drawing.Point(52, 301)
        Me.txtTotalServico.Name = "txtTotalServico"
        Me.txtTotalServico.Size = New System.Drawing.Size(107, 20)
        Me.txtTotalServico.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Total MDO"
        '
        'txtTotalMDO
        '
        Me.txtTotalMDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalMDO.Location = New System.Drawing.Point(52, 262)
        Me.txtTotalMDO.Name = "txtTotalMDO"
        Me.txtTotalMDO.Size = New System.Drawing.Size(107, 20)
        Me.txtTotalMDO.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(53, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Descrição"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(53, 223)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(106, 20)
        Me.txtArea.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Area/Quantidade"
        '
        'TbGesseirosTableAdapter
        '
        Me.TbGesseirosTableAdapter.ClearBeforeFill = True
        '
        'btnEditarProduto
        '
        Me.btnEditarProduto.Location = New System.Drawing.Point(52, 362)
        Me.btnEditarProduto.Name = "btnEditarProduto"
        Me.btnEditarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarProduto.TabIndex = 47
        Me.btnEditarProduto.Text = "EDITAR"
        Me.btnEditarProduto.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(133, 362)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 48
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(213, 362)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "CANCELAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.AcceptsReturn = True
        Me.txtStatus.Location = New System.Drawing.Point(200, 52)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(107, 20)
        Me.txtStatus.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(200, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Status"
        Me.Label1.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Tipo de Produto"
        '
        'txtTipoProduto
        '
        Me.txtTipoProduto.Location = New System.Drawing.Point(165, 180)
        Me.txtTipoProduto.Name = "txtTipoProduto"
        Me.txtTipoProduto.ReadOnly = True
        Me.txtTipoProduto.Size = New System.Drawing.Size(221, 20)
        Me.txtTipoProduto.TabIndex = 54
        '
        'FrmEditProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(408, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoProduto)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditarProduto)
        Me.Controls.Add(Me.txtProdutoID)
        Me.Controls.Add(Me.cboDescricao)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboGesseiro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUnidade)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalMDO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalServico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.TbGesseirosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProdutoID As TextBox
    Friend WithEvents cboDescricao As TextBox
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cboGesseiro As ComboBox
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalServico As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalMDO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbGesseirosBindingSource As BindingSource
    Friend WithEvents TbGesseirosTableAdapter As SistemaGEDataSetTableAdapters.tbGesseirosTableAdapter
    Friend WithEvents btnEditarProduto As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipoProduto As TextBox
End Class
