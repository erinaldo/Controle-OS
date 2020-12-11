Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports MaterialSkin

Public Class FrmMenu

        Inherits Controls.MaterialForm


        Private Sub btnColaborador_Click(sender As Object, e As EventArgs)
        FormAcesso(FrmClientes, "FrmClientes", "mdi")
    End Sub

    Private Sub btnProduto_Click(sender As Object, e As EventArgs)
        FormAcesso(FrmProdutos, "FrmProdutos", "mdi")
    End Sub

    Private Sub CRIARNOVAOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRIARNOVAOSToolStripMenuItem.Click
        FormAcesso(FrmCadastroOS, "FrmCadastroOS", "mdi")
    End Sub

    Private Sub MEDIÇÕESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEDIÇÕESToolStripMenuItem.Click
        FormAcesso(FrmMedicoes, "FrmMedicoes", "mdi")
    End Sub

    Private Sub LANÇAMENTOSToolStripMenuItem_Click_3(sender As Object, e As EventArgs) Handles LANÇAMENTOSToolStripMenuItem.Click
        FormAcesso(FrmNovoLancamento, "FrmNovoLancamento", "mdi")
    End Sub

    Private Sub VENDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDAToolStripMenuItem.Click
        PedidoVinculado = False
        SQL.PodeEditarPedido = True
        lSQL = ""
        FormAcesso(FrmPDV, "FrmPDV", "mdi")
    End Sub

    Private Sub LISTADECLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADECLIENTESToolStripMenuItem.Click
        FormAcesso(FrmClientes, "FrmClientes", "mdi")
    End Sub

    Private Sub CONFIGURARAÇÃOBASICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONFIGURARAÇÃOBASICAToolStripMenuItem.Click
        FormAcesso(FrmConfiguracao, "FrmConfiguracao", "mdi")
    End Sub

    Private Sub ESTOQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTOQUEToolStripMenuItem.Click
                ' FormAcesso(FrmProdutos, "FrmProdutos", "mdi")
                FrmProdutos.ShowDialog()
        End Sub

    Private Sub PRESTADORESToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormAcesso(FrmPrestadores, "FrmPrestadores", "mdi")
    End Sub

    Private Sub FILADEPRODUÇÃOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILADEPRODUÇÃOToolStripMenuItem.Click
        FormAcesso(FrmFilaProducao, "FrmFilaProducao", "mdi")
    End Sub

    Private Sub AGENDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGENDAToolStripMenuItem.Click
        FormAcesso(FrmCalendario, "FrmCalendario", "mdi")
    End Sub

    Private Sub LIBERAÇÃOEMLOTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIBERAÇÃOEMLOTEToolStripMenuItem.Click
        FormAcesso(FrmLiberacaoMedicao, "FrmLiberacaoMedicao", "mdi")
    End Sub

    Private Sub PAGAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAGAMENTOToolStripMenuItem.Click
        FormAcesso(FrmPagamentos, "FrmPagamentos", "mdi")
    End Sub

    Private Sub OSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OSToolStripMenuItem.Click
        FormAcesso(FrmRelatorios, "FrmRelatorios", "mdi")
    End Sub

    Private Sub RESUMOOSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormAcesso(FrmDesenhoOS, "FrmDesenhos", "mdi")
    End Sub

    Private Sub CONFIGURAÇÕESAVANÇADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONFIGURAÇÕESAVANÇADASToolStripMenuItem.Click
        FormAcesso(FrmConfiguracaoADM, "FrmConfiguracaoADM", "mdi")
    End Sub

    Public Sub MovFinan()
        Dim WcolDescricao As Double = dgvEntrega.Width - 435

        Dim colImagem As New DataGridViewImageColumn With {
            .Name = "Imagem",
            .HeaderText = "",
            .Width = 40
        }

        Dim colData As New DataGridViewTextBoxColumn With {
            .Name = "Data",
            .HeaderText = "Data",
            .Width = 80
        }

        Dim colHora As New DataGridViewTextBoxColumn With {
            .Name = "Hora",
            .HeaderText = "Hora",
            .Width = 60
        }

        Dim colDescricao As New DataGridViewTextBoxColumn With {
            .Name = "Descricao",
            .HeaderText = "Descricao"
        }
        colDescricao.Width = WcolDescricao

        Dim colValor As New DataGridViewTextBoxColumn With {
            .Name = "Valor",
            .HeaderText = "Valor (R$)",
            .Width = 110
        }

        With dgvEntrega
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns.Add(colData)
            .Columns.Add(colHora)
            .Columns.Add(colDescricao)
            .Columns.Add(colValor)
            .Columns.Add(colImagem)
            .ShowCellToolTips = True
        End With

        conexao1("SELECT Data, Hora, Descricao, ValorMov, TipoMov FROM tbMovFinan")

        While bdr1.Read
            Dim Data As String = bdr1("Data")
            Dim Hora As String = bdr1("Hora")
            Dim Descricao As String = bdr1("Descricao")
            'Dim Valor As String = bdr1("ValorMov")
            Dim Valor As String = Dinheiro(bdr1("ValorMov"))
            Dim Situacao As String = bdr1("TipoMov")
            Dim Imagem As Object
            Select Case Situacao
                Case = "Entrada"
                    Imagem = My.Resources.seta_verde_esquerda
                    dgvEntrega.Rows.Add(Data, Hora, Descricao, Valor, Imagem)
                Case = "Saída"
                    Imagem = My.Resources.seta_vermelha
                    dgvEntrega.Rows.Add(Data, Hora, Descricao, Valor, Imagem)
                Case Else
                    Imagem = My.Resources.Cancelar
                    MsgBox("erro na codição de pagamento para imagem")
            End Select
        End While
        Desconexao1()
    End Sub

    Public Sub CarregarImagem()
        conexao1("SELECT Imagem FROM tbUsuario WHERE Nome='" & Usuario.Nome & "'")
        Progresso(30)
        bdr1.Read()

        If bdr1.HasRows = True Then
            Dim imagem = bdr1("Imagem")
            If IsDBNull(imagem) = False Then
                Dim ms As New MemoryStream(CType(imagem, Byte()))
                PicColaborador.Image = Image.FromStream(ms)
            End If
        Else
            PicColaborador.Image = Nothing
        End If
        Progresso(100)
        Desconexao1()
    End Sub

        Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                'CARREGAR TABELA DE MOVIMENTAÇÃO FINANCEIRA
                MovFinan()

                'CARREGAR IMAGEM DO USUÁRIO ATUAL
                CarregarImagem()

                'ATUALIZAR RELATÓRIOS APOS UM TEMPO X
                '----------    'QUANTIDADE DE CLIENTES CADASTRADOS
                '----------  'QUANTIDADE DE PRODUTOS EM ESTOQUE BAIXO
                tmAtualizar.Enabled = True

                Progresso(10)

                'CARREGAR INFORMAÇÃO GERAL DO USUÁRIO
                lblCargo.Text = Usuario.Cargo
                lblNomeUsuario.Text = Usuario.Nome

                'STATUS DE HORA E DATA PRINCIPAL
                lblData.Text = WeekdayName(Today.DayOfWeek) & " , " & Today.Day.ToString & " de " & MonthName(Today.Month) & " de " & Today.Year

                Dim modo As String = My.Settings.Tema
                Select Case modo
                        Case = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                ' MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                'txtUsuario.BackColor = Color.White
                        Case = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                ' MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                ' txtUsuario.BackColor = Color.Black
                        Case Else
                End Select
                With pnDockPrincipal
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

                With btnAbrirPDV
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

                With btnOrcamento
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

                With btnFinanceiro
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

                With Button1
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With

                With btnNavegador
                        .BackColor = CorFundo
                        .ForeColor = CorTexto
                End With
        End Sub

        'QUANTIDADE DE CLIENTES CADASTRADOS
        Public Function GetQuantUsuario()

        Dim Linhas As Double
        conexao1("SELECT * FROM tbClientes")
        If bdr1.HasRows = True Then
            While bdr1.Read
                Linhas += 1
            End While
            Return Linhas
        Else
            Return 0
        End If

    End Function

    Public Sub AtualizarRelatorio()

        lblQuantClientes.Text = GetQuantUsuario()

        'QUANTIDADE DE PRODUTOS EM ESTOQUE BAIXO
        Dim ProdutosCriticos As Double
        Dim NomeProduto As Object
        Dim EmEstoque As Double
        Dim EstoqueCritico As Double
        conexao1("SELECT * FROM tbProdutoPDV")

        While bdr1.Read
            EmEstoque = bdr1("SaldoEstoque")
            EstoqueCritico = bdr1("SaldoCritico")
            If EmEstoque < EstoqueCritico Then
                ProdutosCriticos += 1
            End If
        End While

        lblSaldoCritico.Text = ProdutosCriticos
        Desconexao1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNavegador.Click
        FormAcesso(FrmNavegador, "FrmNavegador", "mdi")
    End Sub

    Private Sub pctSair_Click(sender As Object, e As EventArgs)
        FrmLogin.Show()
        Me.Close()
        FrmLogin.txtUsuario.Text = ""
        FrmLogin.txtSenha.Text = ""
    End Sub

    Private Sub pctSair_Click_1(sender As Object, e As EventArgs) Handles pctSair.Click
        FrmLogin.Show()
        FrmLogin.txtSenha.Text = ""
        FrmLogin.txtUsuario.Text = ""
        Me.Close()
        FrmMdiHome.Close()
    End Sub

    Private Sub INSERIRAGENDAMENTODEVISITAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERIRAGENDAMENTODEVISITAToolStripMenuItem.Click
        FrmVisita.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAbrirPDV.Click
        PedidoVinculado = False
        SQL.PodeEditarPedido = True
        lSQL = ""
        FormAcesso(FrmPDV, "FrmPDV", "mdi")
    End Sub

    Private Sub btnOrcamento_Click(sender As Object, e As EventArgs) Handles btnOrcamento.Click
        FormAcesso(FrmCadastroOS, "FrmCadastroOS", "mdi")
    End Sub

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs) Handles btnFinanceiro.Click
        FormAcesso(FrmNovoLancamento, "FrmNovoLancamento", "mdi")
    End Sub

    Private Sub RELATÓRIOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RELATÓRIOSToolStripMenuItem1.Click
        FormAcesso(FrmRelatorios, "FrmNovoLancamento", "mdi")
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMovFinanceira.ShowDialog()
    End Sub

    Private Sub atividadeSegundoPlano_DoWork(sender As Object, e As DoWorkEventArgs) Handles atividadeSegundoPlano.DoWork
        ' AtualizarRelatorio()
    End Sub

    Private Sub FrmMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'AtualizarRelatorio()
    End Sub

    Private Sub tmAtualizar_Tick(sender As Object, e As EventArgs) Handles tmAtualizar.Tick
        AtualizarRelatorio()
        tmAtualizar.Stop()
    End Sub

    Private Sub hora_Tick(sender As Object, e As EventArgs) Handles hora.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub tmMinDock_Tick(sender As Object, e As EventArgs) Handles tmMinDock.Tick
        pnDockPrincipal.Width = 63
        tmMinDock.Stop()
    End Sub

    Private Sub btnAbrirPDV_MouseLeave(sender As Object, e As EventArgs) Handles btnAbrirPDV.MouseLeave
        tmMinDock.Start()
    End Sub

    Private Sub btnAbrirPDV_MouseEnter(sender As Object, e As EventArgs) Handles btnAbrirPDV.MouseEnter
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub btnOrcamento_MouseLeave(sender As Object, e As EventArgs) Handles btnOrcamento.MouseLeave
        tmMinDock.Start()
    End Sub

    Private Sub btnFinanceiro_MouseLeave(sender As Object, e As EventArgs) Handles btnFinanceiro.MouseLeave
        tmMinDock.Start()
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        tmMinDock.Start()
    End Sub

    Private Sub btnNavegador_MouseLeave(sender As Object, e As EventArgs) Handles btnNavegador.MouseLeave
        tmMinDock.Start()
    End Sub

    Private Sub btnOrcamento_MouseEnter(sender As Object, e As EventArgs) Handles btnOrcamento.MouseEnter
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub btnFinanceiro_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFinanceiro.MouseMove
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub btnFinanceiro_MouseEnter(sender As Object, e As EventArgs) Handles btnFinanceiro.MouseEnter
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub btnNavegador_MouseEnter(sender As Object, e As EventArgs) Handles btnNavegador.MouseEnter
        tmMinDock.Stop()
        pnDockPrincipal.Width = 200
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        dgvEntrega.Rows.Clear()

        conexao1("SELECT Data, Hora, Descricao, ValorMov, TipoMov FROM tbMovFinan")

        While bdr1.Read
            Dim Data As String = bdr1("Data")
            Dim Hora As String = bdr1("Hora")
            Dim Descricao As String = bdr1("Descricao")
            'Dim Valor As String = bdr1("ValorMov")
            Dim Valor As String = Dinheiro(bdr1("ValorMov"))
            Dim Situacao As String = bdr1("TipoMov")
            Dim Imagem As Object
            Select Case Situacao
                Case = "Entrada"
                    Imagem = My.Resources.seta_verde_esquerda
                    dgvEntrega.Rows.Add(Data, Hora, Descricao, Valor, Imagem)
                Case = "Saída"
                    Imagem = My.Resources.seta_vermelha
                    dgvEntrega.Rows.Add(Data, Hora, Descricao, Valor, Imagem)
                Case Else
                    Imagem = My.Resources.Cancelar
                    MsgBox("erro na codição de pagamento para imagem")
            End Select
        End While
        Desconexao1()
        SQL.Notificao("", "Atualizado com Sucesso")
    End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
                FrmAgendaEntrega.Show()
        End Sub

        Private Sub dgvEntrega_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEntrega.CellFormatting

        End Sub

    Private Sub AGENDAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AGENDAToolStripMenuItem1.Click
                FrmAgendaEntrega.ShowDialog()
        End Sub

        Private Sub lblHora_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub tmAtualizarRelatorio_Tick(sender As Object, e As EventArgs) Handles tmAtualizarRelatorio.Tick

        End Sub

    Private Sub CONSULTACNPJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTACNPJToolStripMenuItem.Click
                frmConsultaCNPJ.Show()
        End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
                FrmLogin.Show()
                FrmLogin.txtSenha.Text = ""
                Me.Close()
                FrmMdiHome.Close()
        End Sub

    Private Sub btnVisitas_Click(sender As Object, e As EventArgs) Handles btnVisitas.Click
                FrmListaVisita.Show()
        End Sub
End Class