<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalendario
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
        Me.DataSetAgenda = New ControleOS.DataSetAgenda()
        Me.TbAgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAgendaTableAdapter = New ControleOS.DataSetAgendaTableAdapters.tbAgendaTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataSetAgendaTableAdapters.TableAdapterManager()
        Me.lstSegunda = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSetAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAgenda
        '
        Me.DataSetAgenda.DataSetName = "DataSetAgenda"
        Me.DataSetAgenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbAgendaBindingSource
        '
        Me.TbAgendaBindingSource.DataMember = "tbAgenda"
        Me.TbAgendaBindingSource.DataSource = Me.DataSetAgenda
        '
        'TbAgendaTableAdapter
        '
        Me.TbAgendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAgendaTableAdapter = Me.TbAgendaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataSetAgendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lstSegunda
        '
        Me.lstSegunda.HideSelection = False
        Me.lstSegunda.Location = New System.Drawing.Point(373, 59)
        Me.lstSegunda.Name = "lstSegunda"
        Me.lstSegunda.Size = New System.Drawing.Size(222, 409)
        Me.lstSegunda.TabIndex = 1
        Me.lstSegunda.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Segunda - Feira"
        '
        'FrmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 496)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSegunda)
        Me.Name = "FrmCalendario"
        Me.Text = "FrmCalendario"
        CType(Me.DataSetAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetAgenda As DataSetAgenda
    Friend WithEvents TbAgendaBindingSource As BindingSource
    Friend WithEvents TbAgendaTableAdapter As DataSetAgendaTableAdapters.tbAgendaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAgendaTableAdapters.TableAdapterManager
    Friend WithEvents lstSegunda As ListView
    Friend WithEvents Label1 As Label
End Class
