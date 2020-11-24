Imports System.Data.OleDb
Imports System.Threading.Thread

Public Class FrmSelCaixa

        Public CaixaID As Double
        Public Caixa As String
        Public ValorInserido As Double
        Public CaixaAberto As Boolean

        Private Sub FrmSelCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                lblUsuario.Text = SQL.Usuario
                lblhora.Text = TimeOfDay.ToShortTimeString
                lblData.Text = Today.ToShortDateString
                Me.StartPosition = FormStartPosition.CenterScreen
                Select Case CaixaLoad()
                        Case True
                                SQL.Notificao("", "Caixa Carregado com Sucesso")
                        Case False
                                Dim Valor As String = InputBox("Insira o valar inicial do fundo de caixa", "FUNDO DE CAIXA", "DIGITE")
                                InstrucaoDireta("INSERT INTO tbCaixaPDV (UsuarioID,Fundo,Status)" & " VALUES (""" & UsuarioID & """,""" & CDbl(Valor) & """,""" & "ABERTO" & """)")
                        Case Else
                End Select
                CaixaLoad()
                HistAberturaLoad("SELECT Data AS DATA,Hora AS HORA,Operacao AS OPERAÇÃO,Valor as VALOR,Fundo as FUNDO FROM tbHistoricoCaixa WHERE CaixaID=" & CaixaID, dgvHistAbertura)
        End Sub

        Public Function HistAberturaLoad(Consulta As String, DGV As DataGridView)
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(Consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "table")
                DGV.DataSource = dsbiblio.Tables("table")
        End Function

        Public Function CaixaLoad()
                Connect.Conectardb("SELECT * FROM tbCaixaPDV WHERE UsuarioID =" & UsuarioID)
                Select Case cdr.HasRows
                        Case True
                                txtNumeroCaixa.Text = cdr.Item("CaixaID")
                                CaixaID = cdr.Item("CaixaID")
                                txtStatus3.Text = cdr.Item("Status")
                                txtFundoCaixa.Text = Dinheiro(cdr.Item("Fundo"))
                                Select Case cdr.Item("Status")
                                        Case "ABERTO"
                                                'txtStatus.BackColor = Color.Lime
                                                txtStatus2.BackColor = Color.Lime
                                                txtStatus3.BackColor = Color.Lime
                                                btnAbrirFecharCaixa.Text = "FECHAR CAIXA"
                                                txtStatus3.Text = "ABERTO"
                                                CaixaAberto = True
                                                btnContinuar.Visible = True
                                                CaixaAtual.Status = "ABERTO"
                                        Case "FECHADO"
                                                'txtStatus.BackColor = Color.Red
                                                txtStatus2.BackColor = Color.Red
                                                txtStatus3.BackColor = Color.Red
                                                btnAbrirFecharCaixa.Text = "ABRIR CAIXA"
                                                txtStatus3.Text = "FECHADO"
                                                CaixaAberto = False
                                                btnContinuar.Visible = False
                                                CaixaAtual.Status = "FECHADO"
                                        Case Else
                                End Select
                End Select
                If cdr.HasRows = True Then
                        Return True
                Else
                        Return False
                End If
                Connect.Desconectardb()
        End Function

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
                Me.Close()
                ' System.Threading.Thread.Sleep(3)
                ' FrmPDV.btnVoltar.PerformClick()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAbrirFecharCaixa.Click
                pbSelCaixa.Value = 10
                Connect.Conectardb("SELECT * FROM tbCaixaPDV WHERE UsuarioID =" & UsuarioID)
                pbSelCaixa.Value = 50
                If cdr.HasRows = True Then
                        Select Case cdr.Item("Status")
                                Case "ABERTO"
                                        InstrucaoDireta("UPDATE tbCaixaPDV SET Status='FECHADO' WHERE UsuarioID=" & UsuarioID)
                                        pbSelCaixa.Value = 60
                                        Threading.Thread.Sleep(5000)
                                        InstrucaoDireta("INSERT INTO tbHistoricoCaixa (CaixaID,Data,Hora,Operacao,Fundo)" & "VALUES (""" & CaixaID & """,""" & Today.ToShortDateString &
                                        """,""" & TimeOfDay.ToShortTimeString & """,""" & "FECHAMENTO DE CAIXA" & """,""" & txtFundoCaixa.Text & """)")
                                        pbSelCaixa.Value = 80
                                        txtStatus2.BackColor = Color.Red
                                        txtStatus3.BackColor = Color.Red
                                        btnAbrirFecharCaixa.Text = "ABRIR CAIXA"
                                        txtStatus3.Text = "ABERTO"
                                        CaixaAtual.Status = "ABERTO"
                                        pbSelCaixa.Value = 90
                                Case "FECHADO"
                                        InstrucaoDireta("UPDATE tbCaixaPDV Set Status='ABERTO' WHERE UsuarioID=" & UsuarioID)
                                        pbSelCaixa.Value = 60
                                        Threading.Thread.Sleep(5000)
                                        InstrucaoDireta("INSERT INTO tbHistoricoCaixa (CaixaID,Data,Hora,Operacao,Fundo)" & "VALUES (""" & CaixaID & """,""" & Today.ToShortDateString &
                                        """,""" & TimeOfDay.ToShortTimeString & """,""" & "ABERTURA DE CAIXA" & """,""" & txtFundoCaixa.Text & """)")
                                        pbSelCaixa.Value = 80
                                        txtStatus2.BackColor = Color.Lime
                                        txtStatus3.BackColor = Color.Lime
                                        btnAbrirFecharCaixa.Text = "FECHAR CAIXA"
                                        txtStatus3.Text = "FECHADO"
                                        CaixaAtual.Status = "FECHADO"
                                        pbSelCaixa.Value = 90
                                Case Else
                        End Select
                End If
                tmDelay.Start()
                lblState.Text = "BD SENDO ATUALIZADO......"
                lblState.ForeColor = Color.Red
                pbSelCaixa.Value = 100
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
                pbSelCaixa.Value = 10
                If txtStatus3.Text = "ABERTO" Then
                        Connect.Conectardb("SELECT * FROM tbCaixaPDV WHERE UsuarioID =" & UsuarioID)
                        Dim ValorAtual As Double = cdr.Item("Fundo")
                        Dim ValorNovo As Double
                        ValorInserido = InputBox("INSIRA O VALOR DO APOIO (R$)")
                        pbSelCaixa.Value = 20
                        If ValorInserido > 0 Then
                                ValorNovo = ValorAtual + ValorInserido
                                InstrucaoDireta("UPDATE tbCaixaPDV Set Fundo=""" & ValorNovo & """ WHERE UsuarioID=" & UsuarioID)
                                txtFundoCaixa.Text = Dinheiro(ValorNovo)
                                tmDelay.Start()
                                lblState.Text = "BD SENDO ATUALIZADO......"
                                lblState.ForeColor = Color.Red
                        Else
                                SQL.Notificao("", "Valor Incorreto")
                        End If
                        pbSelCaixa.Value = 50
                Else
                        SQL.Notificao("", "Não é possivel realizar essa operação com o caixa fechado")
                End If
                InstrucaoDireta("INSERT INTO tbHistoricoCaixa (CaixaID,Data,Hora,Operacao,Fundo,Valor)" & "VALUES (""" & CaixaID & """,""" & Today.ToShortDateString &
                """,""" & TimeOfDay.ToShortTimeString & """,""" & "APOIO" & """,""" & txtFundoCaixa.Text & """,""" & ValorInserido & """)")
fim:
                pbSelCaixa.Value = 100
        End Sub

        Private Sub tmDelay_Tick(sender As Object, e As EventArgs) Handles tmDelay.Tick
                HistAberturaLoad("SELECT Data AS DATA,Hora AS HORA,Operacao AS OPERAÇÃO,Valor as VALOR,Fundo as FUNDO FROM tbHistoricoCaixa WHERE CaixaID=" & CaixaID, dgvHistAbertura)
                CaixaLoad()
                tmDelay.Stop()
                lblState.Text = "BD ATUALIZADO"
                lblState.ForeColor = Color.Green
                If txtStatus3.Text = "ABERTO" Then
                        btnContinuar.Visible = True
                Else
                        btnContinuar.Visible = False
                End If
        End Sub

        Private Sub TbHistoricoCaixaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.TbHistoricoCaixaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSety)
        End Sub

        Private Sub dgvHistAbertura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvHistAbertura.CellFormatting
                If e.ColumnIndex = 3 Then
                        dgvHistAbertura.Columns("FUNDO").DefaultCellStyle.Format = "C2"
                End If

                If e.ColumnIndex = 4 Then
                        dgvHistAbertura.Columns("VALOR").DefaultCellStyle.Format = "C2"
                End If

                If e.ColumnIndex = 2 Then
                        dgvHistAbertura.Columns("HORA").DefaultCellStyle.Format = "t"
                End If
        End Sub

        Private Sub btnRealizarSangria_Click(sender As Object, e As EventArgs) Handles btnRealizarSangria.Click
                pbSelCaixa.Value = 10
                RealizarSangria()
                pbSelCaixa.Value = 50
                InstrucaoDireta("INSERT INTO tbHistoricoCaixa (CaixaID,Data,Hora,Operacao,Fundo)" & "VALUES (""" & CaixaID & """,""" & Today.ToShortDateString &
                        """,""" & TimeOfDay.ToShortTimeString & """,""" & "SANGRIA" & """,""" & txtFundoCaixa.Text & """)")
                pbSelCaixa.Value = 100
        End Sub

        Public Sub RealizarSangria()
                If txtStatus3.Text = "ABERTO" Then
                        Connect.Conectardb("SELECT * FROM tbCaixaPDV WHERE UsuarioID =" & UsuarioID)
                        Dim ValorAtual As Double = cdr.Item("Fundo")
                        Dim ValorNovo As Double
                        ValorInserido = InputBox("INSIRA O VALOR DE SANGRIA (R$)")
                        If ValorAtual - ValorInserido > 0 Then
                                If ValorInserido > 0 Then
                                        ValorNovo = ValorAtual - ValorInserido
                                        InstrucaoDireta("UPDATE tbCaixaPDV Set Fundo=""" & ValorNovo & """  WHERE UsuarioID=" & UsuarioID)
                                        txtFundoCaixa.Text = Dinheiro(ValorNovo)
                                        tmDelay.Start()
                                        lblState.Text = "BD SENDO ATUALIZADO......"
                                        lblState.ForeColor = Color.Red
                                Else
                                        SQL.Notificao("", "Valor Incorreto")
                                End If
                        Else
                                SQL.Notificao("", "O VALOR DE SANGRIA É MAIOR QUE O SALDO EM CAIXA")
                        End If
                Else
                        SQL.Notificao("", "Não é possivel realizar essa operação com o caixa fechado")
                End If
                CaixaLoad()
        End Sub

        Private Sub btnContinuar_Click(sender As Object, e As EventArgs)
                CaixaAberto = True
                Me.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
                HistAberturaLoad("SELECT Data AS DATA,Hora AS HORA,Operacao AS OPERAÇÃO,Valor as VALOR,Fundo as FUNDO FROM tbHistoricoCaixa WHERE CaixaID=" & CaixaID, dgvHistAbertura)
        End Sub

        Public CaixaAtual As New Caixa

        Public Sub btnContinuar_Click_1(sender As Object, e As EventArgs) Handles btnContinuar.Click
                CaixaAtual.CaixaID = txtNumeroCaixa.Text
                CaixaAtual.Fundo = txtFundoCaixa.Text
                CaixaAtual.Status = txtStatus3.Text
                CaixaAtual.NomeUsuario = lblUsuario.Text
                Me.Close()
        End Sub

        Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

        End Sub
End Class