Imports System.Data.OleDb
Imports System.Media
Imports CefSharp.WinForms

Public Class FrmMdiHome


        Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)

        Dim ChildForm As New Form With {
            .MdiParent = Me
        }

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog With {
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        }
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Adicione aqui código para abrir o arquivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog With {
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
            .Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        }
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Feche todos os formulários filhos do pai.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmClientes.MdiParent = Me
        FrmClientes.Show()
        WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

        Private Sub FrmMdiHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                'TODO: esta linha de código carrega dados na tabela 'Notificacao.tbNotificacao'. Você pode movê-la ou removê-la conforme necessário.
                Me.TbNotificacaoTableAdapter.Fill(Me.Notificacao.tbNotificacao)
                WindowState = System.Windows.Forms.FormWindowState.Maximized
                FrmMenu.MdiParent = Me
                FrmMenu.Show()
                tmNotificacao.Start()
                lblCaminhoDB.Text = "Caminho do banco de dados atual: " & My.Settings.CaminhoDB
        End Sub


        Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmLogin.Show()
        FrmLogin.txtSenha.Text = ""
    End Sub

    Private Sub AndamentoDeObrasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAndamentoDaOS.ShowDialog()
    End Sub

    Private Sub RelatóriosDeVisitasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmRelatorioVisita.ShowDialog()
    End Sub

    Private Sub LeitorPDFToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' FrmAbrirPdf.ShowDialog()
    End Sub

    Private Sub ORÇAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCadastroOS.MdiParent = Me
        On Error Resume Next
        FrmCadastroOS.Show()
        FrmCadastroOS.txtCPF.Text = ""
        FrmCadastroOS.txtCodCliente.Text = ""
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ORÇAMENTOToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        FrmNovoLancamento.MdiParent = Me
        FrmNovoLancamento.Show()
    End Sub

    Private Sub PDVToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPDV.MdiParent = Me
        FrmPDV.Show()
    End Sub

    Private Sub PAGAMENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPagamentos.MdiParent = Me
        FrmPagamentos.Show()
    End Sub

    Private Sub tmNotificacao_Tick(sender As Object, e As EventArgs) Handles tmNotificacao.Tick
                '  If dgvNotificacao.Visible = False Then
                '         Me.TbNotificacaoTableAdapter.PorUsuarioID(Me.Notificacao.tbNotificacao, New System.Nullable(Of Integer)(CType(SQL.UsuarioID, Integer)))
                'Else
                'End If

                '        Dim linha As Integer
                '           Dim comando As String = "SELECT * FROM tbNotificacao WHERE Usuario=" & SQL.UsuarioID & " And Status='Não Lido'"
                '           objConnection.Close()
                '  objConnection.Open()
                ' Dim objcmd As New OleDbCommand(comando, objConnection)
                '          cdr = objcmd.ExecuteReader(CommandBehavior.Default)

                '          While cdr.Read

                '        linha += 1

                '         End While

                '          cdr.Close()
                '          cdr = Nothing
                '          objConn.Close()

                '          If IsNumeric(lblContadorNotificacao.Text) = True Then
                '          If CInt(lblContadorNotificacao.Text) <> linha Then
                '         Connect.Conectardb("SELECT * FROM tbNotificacao WHERE Usuario=" & SQL.UsuarioID & " ORDER BY ORDEM Desc")

                '       SQL.Popup("", "" & cdr.Item("Descricao"))

                '       Connect.Desconectardb()

                '      SystemSounds.Exclamation.Play()
                '      End If
                '  End If

                ' lblContadorNotificacao.Text = linha

                '          If linha > 0 Then
                '   lblContadorNotificacao.BackColor = Color.Red
                '   Else
                'lblContadorNotificacao.BackColor = Color.Black
                '         lblContadorNotificacao.ForeColor = Color.White
                '          End If

        End Sub

    Private Sub lblContadorNotificacao_Click(sender As Object, e As EventArgs) Handles lblContadorNotificacao.Click
        lSQL = "UPDATE tbNotificacao SET Status=""" & "Lido" & """ WHERE Usuario=" & SQL.UsuarioID
        SQL.Comando()

        If dgvNotificacao.Visible = True Then
            dgvNotificacao.Visible = False
        Else
            dgvNotificacao.Visible = True

        End If

        '  dgvNotificacao.Width = dgvNotificacao.Rows.Count * 22

    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        FrmLogin.Show()
        FrmLogin.txtSenha.Text = ""
        FrmLogin.txtUsuario.Text = ""
        Me.Close()
    End Sub

    Private Sub dgvNotificacao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotificacao.CellContentClick

    End Sub

    Private Sub dgvNotificacao_MouseLeave(sender As Object, e As EventArgs) Handles dgvNotificacao.MouseLeave
        dgvNotificacao.Visible = False
    End Sub

    Private Sub dgvNotificacao_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotificacao.CellClick

        rtxNotiExp.Text = dgvNotificacao.CurrentRow.Cells(0).Value

        rtxNotiExp.Visible = True

    End Sub

    Private Sub lstNotiExp_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstNotiExp_MouseLeave(sender As Object, e As EventArgs)
        rtxNotiExp.Visible = False
    End Sub

    Private Sub rtxNotiExp_TextChanged(sender As Object, e As EventArgs) Handles rtxNotiExp.TextChanged

    End Sub

    Private Sub rtxNotiExp_MouseLeave(sender As Object, e As EventArgs) Handles rtxNotiExp.MouseLeave
        rtxNotiExp.Visible = False
    End Sub

    Private Sub LeirorPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeirorPDFToolStripMenuItem.Click
        FrmLeitorPDF.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public aberto As Boolean


        Private Sub SAIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class