<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdicionarPagamento
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
        Me.DETALHES = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDestinatario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDataPagamento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPagamentoID = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DETALHES.SuspendLayout()
        Me.SuspendLayout()
        '
        'DETALHES
        '
        Me.DETALHES.Controls.Add(Me.MonthCalendar1)
        Me.DETALHES.Controls.Add(Me.Label9)
        Me.DETALHES.Controls.Add(Me.txtDestinatario)
        Me.DETALHES.Controls.Add(Me.Label11)
        Me.DETALHES.Controls.Add(Me.txtObs)
        Me.DETALHES.Controls.Add(Me.Label15)
        Me.DETALHES.Controls.Add(Me.txtValor)
        Me.DETALHES.Controls.Add(Me.Label16)
        Me.DETALHES.Controls.Add(Me.txtDataPagamento)
        Me.DETALHES.Controls.Add(Me.Label17)
        Me.DETALHES.Controls.Add(Me.txtPagamentoID)
        Me.DETALHES.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DETALHES.Location = New System.Drawing.Point(12, 12)
        Me.DETALHES.Name = "DETALHES"
        Me.DETALHES.Size = New System.Drawing.Size(549, 338)
        Me.DETALHES.TabIndex = 2
        Me.DETALHES.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "DESTINATÁRIO"
        '
        'txtDestinatario
        '
        Me.txtDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinatario.Location = New System.Drawing.Point(6, 177)
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.Size = New System.Drawing.Size(100, 20)
        Me.txtDestinatario.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "OBS.:"
        '
        'txtObs
        '
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Location = New System.Drawing.Point(6, 219)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(196, 70)
        Me.txtObs.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "VALOR"
        '
        'txtValor
        '
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.Location = New System.Drawing.Point(7, 134)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "DATA DO PAGAMENTO"
        '
        'txtDataPagamento
        '
        Me.txtDataPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataPagamento.Location = New System.Drawing.Point(7, 92)
        Me.txtDataPagamento.Name = "txtDataPagamento"
        Me.txtDataPagamento.ReadOnly = True
        Me.txtDataPagamento.Size = New System.Drawing.Size(126, 20)
        Me.txtDataPagamento.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "ID PAGAMENTO"
        '
        'txtPagamentoID
        '
        Me.txtPagamentoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagamentoID.Location = New System.Drawing.Point(7, 51)
        Me.txtPagamentoID.Name = "txtPagamentoID"
        Me.txtPagamentoID.ReadOnly = True
        Me.txtPagamentoID.Size = New System.Drawing.Size(100, 20)
        Me.txtPagamentoID.TabIndex = 0
        '
        'Button2
        '
        '   Me.Button2.Image = Global.ControleOS..ic_cancel_128_283181
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(93, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 62)
        Me.Button2.TabIndex = 9
        Me.Button2.TabStop = False
        Me.Button2.Text = "CANCELAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        ' Me.btnSalvar.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(12, 356)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 62)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.TabStop = False
        Me.btnSalvar.Text = "SALVAR"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(291, 51)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'FrmAdicionarPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.DETALHES)
        Me.Name = "FrmAdicionarPagamento"
        Me.Text = "Form1"
        Me.DETALHES.ResumeLayout(False)
        Me.DETALHES.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DETALHES As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDestinatario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDataPagamento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPagamentoID As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
