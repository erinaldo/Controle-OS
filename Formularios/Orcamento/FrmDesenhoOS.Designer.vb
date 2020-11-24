<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesenhoOS
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
        Me.components = New System.ComponentModel.Container()
        Me.cboOSID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SistemaGEDataSet = New ControleOS.SistemaGEDataSet()
        Me.TbOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbOSTableAdapter = New ControleOS.SistemaGEDataSetTableAdapters.tbOSTableAdapter()
        Me.lstPedidos = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOSID
        '
        Me.cboOSID.DataSource = Me.TbOSBindingSource
        Me.cboOSID.DisplayMember = "OSID"
        Me.cboOSID.FormattingEnabled = True
        Me.cboOSID.Location = New System.Drawing.Point(393, 193)
        Me.cboOSID.Name = "cboOSID"
        Me.cboOSID.Size = New System.Drawing.Size(121, 21)
        Me.cboOSID.TabIndex = 0
        Me.cboOSID.ValueMember = "OSID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OS"
        '
        'SistemaGEDataSet
        '
        Me.SistemaGEDataSet.DataSetName = "SistemaGEDataSet"
        Me.SistemaGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbOSBindingSource
        '
        Me.TbOSBindingSource.DataMember = "tbOS"
        Me.TbOSBindingSource.DataSource = Me.SistemaGEDataSet
        '
        'TbOSTableAdapter
        '
        Me.TbOSTableAdapter.ClearBeforeFill = True
        '
        'lstPedidos
        '
        Me.lstPedidos.HideSelection = False
        Me.lstPedidos.Location = New System.Drawing.Point(217, 77)
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.Size = New System.Drawing.Size(121, 97)
        Me.lstPedidos.TabIndex = 2
        Me.lstPedidos.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(884, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmDesenhoOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboOSID)
        Me.Name = "FrmDesenhoOS"
        Me.Text = "FrmDesenhoOS"
        CType(Me.SistemaGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOSID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SistemaGEDataSet As SistemaGEDataSet
    Friend WithEvents TbOSBindingSource As BindingSource
    Friend WithEvents TbOSTableAdapter As SistemaGEDataSetTableAdapters.tbOSTableAdapter
    Friend WithEvents lstPedidos As ListView
    Friend WithEvents Button1 As Button
End Class
