<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddRecebimento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.txtDataRecebimento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNumeroOS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AvisoValorObrigatorio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOME DO CLIENTE"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(15, 66)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.ReadOnly = True
        Me.txtNomeCliente.Size = New System.Drawing.Size(222, 20)
        Me.txtNomeCliente.TabIndex = 2
        '
        'txtDataRecebimento
        '
        Me.txtDataRecebimento.Location = New System.Drawing.Point(15, 105)
        Me.txtDataRecebimento.Name = "txtDataRecebimento"
        Me.txtDataRecebimento.ReadOnly = True
        Me.txtDataRecebimento.Size = New System.Drawing.Size(133, 20)
        Me.txtDataRecebimento.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DATA DO RECEBIMENTO"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(15, 144)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(133, 20)
        Me.txtValor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VALOR (R$)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(313, 66)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(15, 220)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(222, 78)
        Me.txtObs.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "OBS.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Button2
        '
        '  Me.Button2.Image = Global.ControleOS.My.Resources..ic_cancel_128_283181
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(93, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 62)
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        Me.Button2.Text = "CANCELAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        ' Me.Button1.Image = Global.ControleOS.My.Resources.Resources.Save_37110
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "SALVAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNumeroOS
        '
        Me.txtNumeroOS.Location = New System.Drawing.Point(15, 25)
        Me.txtNumeroOS.Name = "txtNumeroOS"
        Me.txtNumeroOS.ReadOnly = True
        Me.txtNumeroOS.Size = New System.Drawing.Size(133, 20)
        Me.txtNumeroOS.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nº OS"
        '
        'AvisoValorObrigatorio
        '
        Me.AvisoValorObrigatorio.AutoSize = True
        Me.AvisoValorObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.AvisoValorObrigatorio.Location = New System.Drawing.Point(12, 167)
        Me.AvisoValorObrigatorio.Name = "AvisoValorObrigatorio"
        Me.AvisoValorObrigatorio.Size = New System.Drawing.Size(180, 13)
        Me.AvisoValorObrigatorio.TabIndex = 13
        Me.AvisoValorObrigatorio.Text = "O CAMPO ACIMA É OBRIGATÓRIO"
        Me.AvisoValorObrigatorio.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AvisoValorObrigatorio.Visible = False
        '
        'FrmAddRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 372)
        Me.Controls.Add(Me.AvisoValorObrigatorio)
        Me.Controls.Add(Me.txtNumeroOS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDataRecebimento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmAddRecebimento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents txtDataRecebimento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumeroOS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AvisoValorObrigatorio As Label
End Class
