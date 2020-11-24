Imports MaterialSkin

Public Class FrmConfiguracao

        Inherits Controls.MaterialForm

        Dim StyleAntes As String

        Private Sub FrmConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.TbPlanoContaTableAdapter.Fill(Me.DataSety.tbPlanoConta)
                Me.FormaPagamentoTableAdapter.Fill(Me.DataSetX.FormaPagamento)
                Me.TbFormaPagamentoTableAdapter.Fill(Me.SistemaGEDataSet.tbFormaPagamento)
                Connect.Conectardb("SELECT * FROM tbConfigUni WHERE Config='MaxDescontoPDV'")
                txtMaxDescontoPDV.Text = cdr.Item("Selecao")
                Connect.Desconectardb()

                Connect.Conectardb("SELECT * FROM tbUsuario WHERE Nome='" & Usuario.Nome & "'")
                chkShowIEalerta.Checked = cdr.Item("ConfigAlertaIE")
                Connect.Desconectardb()
                cboTema.Text = My.Settings.Tema
                StyleAntes = My.Settings.Tema
        End Sub

        Private Sub TbFormaPagamentoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbFormaPagamentoBindingNavigatorSaveItem.Click
                Me.Validate()
                Me.TbFormaPagamentoBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SistemaGEDataSet)
                SQL.Notificao("NOVA LITORAL GESSO", "OPÇÕES SALVAS COM SUCESSO")
        End Sub

        Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.FormaPagamentoBindingSource.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Me.DataSetX)
                SQL.Notificao("NOVA LITORAL GESSO", "OPÇÕES SALVAS COM SUCESSO")
        End Sub

        Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
                If StyleAntes <> My.Settings.Tema Then
                        MsgBox("A aplicação será reiniciada para aplicar a(as) alteração(ões)")
                        Application.Restart()
                End If
                Me.Close()
        End Sub

        Private Sub SalvarToolStripButton1_Click(sender As Object, e As EventArgs)
                Me.Validate()
                Me.OpcoesBindingSource.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Me.DataSetX)
                SQL.Notificao("NOVA LITORAL GESSO", "OPÇÕES SALVAS COM SUCESSO")
        End Sub

        Private Sub btnFrmMedPers_Click(sender As Object, e As EventArgs) Handles btnFrmMedPers.Click
                FrmPagMedPersonalizada.ShowDialog()
        End Sub

        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMaxDescontoPDV.TextChanged
                Dim valor As Double
                If IsNumeric(txtMaxDescontoPDV.Text) = True Then
                        valor = CDbl(txtMaxDescontoPDV.Text)
                        lSQL = "UPDATE tbConfigUni SET Selecao =""" & CDbl(txtMaxDescontoPDV.Text) & """ WHERE Config='MaxDescontoPDV'"
                        SQL.Comando()
                        '  Log("CAMPO DE CONFIGURAÇÃO (MAX DESCONTO PDV) ALTERADO PARA " & txtMaxDescontoPDV.Text)
                Else
                        MsgBox("É permitido apenas número neste cammpo")
                        txtMaxDescontoPDV.Text = 0
                        'Log("PREENCHIMENTO INCORRETO DO CAMPO DE CONFIGURAÇÃO (MAX DESCONTO PDV)")
                End If
        End Sub

        Private Sub gpFormaPagamento_MouseDown(sender As Object, e As MouseEventArgs) Handles gpFormaPagamento.MouseDown
                Select Case gpFormaPagamento.Height
                        Case > 50
                                AnimacaoMin(gpFormaPagamento, 17, 10000)
                        Case < 50
                                AnimacaoEx(gpFormaPagamento, 250, 10000)
                End Select
        End Sub

        Private Sub gpPlanoContas_MouseDown(sender As Object, e As MouseEventArgs) Handles gpPlanoContas.MouseDown
                Select Case gpPlanoContas.Height
                        Case > 50
                                AnimacaoMin(gpPlanoContas, 17, 10000)
                        Case < 50
                                AnimacaoEx(gpPlanoContas, 250, 10000)
                End Select
        End Sub

        Private Sub gpConfigPDV_MouseDown(sender As Object, e As MouseEventArgs) Handles gpConfigPDV.MouseDown
                Select Case gpConfigPDV.Height
                        Case > 50
                                AnimacaoMin(gpConfigPDV, 17, 10000)
                        Case < 50
                                AnimacaoEx(gpConfigPDV, 100, 10000)
                End Select
        End Sub

        Private Sub chkShowIEalerta_Click(sender As Object, e As EventArgs) Handles chkShowIEalerta.Click
                Select Case chkShowIEalerta.Checked
                        Case True
                                InstrucaoDireta("UPDATE tbUsuario SET ConfigAlertaIE = True WHERE (Nome = '" & Usuario.Nome & "')")
                        Case False
                                InstrucaoDireta("UPDATE tbUsuario SET ConfigAlertaIE = False WHERE (Nome = '" & Usuario.Nome & "')")
                End Select
        End Sub

        Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
                Dim linhas As Double = TbPlanoContaDataGridView.Rows.Count
                Dim valor As String

                InstrucaoDireta("DELETE * FROM tbPlanoConta")
                Me.Validate()

                Do Until linhas <= 0
                        linhas -= 1

                        valor = TbPlanoContaDataGridView.Rows(linhas).Cells(0).Value

                        If IsNothing(valor) = False Then

                                InstrucaoDireta("INSERT INTO tbPlanoConta(Nome)" & " VALUES(""" & valor.ToUpper & """)")

                                SQL.Notificao("", "Plano de contas atualizado")
                        End If

                Loop
                Me.TbPlanoContaTableAdapter.Fill(Me.DataSety.tbPlanoConta)
        End Sub

        Private Sub btnFotoCol_Click(sender As Object, e As EventArgs) Handles btnFotoCol.Click

                If Me.ofd.ShowDialog = 1 Then
                        Me.PicUsuario.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
                End If

                Dim vezes As Double = 0

                Dim cn As New OleDb.OleDbConnection
                cn.ConnectionString = sConnectionString
                Try
                        cn.Open()
                        Dim arrImage() As Byte
                        Dim strImage As String
                        Dim myMs As New IO.MemoryStream
                        '
                        If Not IsNothing(Me.PicUsuario.Image) Then
                                Me.PicUsuario.Image.Save(myMs, Me.PicUsuario.Image.RawFormat)
                                arrImage = myMs.GetBuffer
                                strImage = "?"
                        Else
                                arrImage = Nothing
                                strImage = "NULL"
                        End If
                        Dim cmd As New OleDb.OleDbCommand
                        cmd.Connection = cn

                        While vezes < 15 = True

                                cmd.CommandText = "UPDATE tbUsuario SET Imagem=" & strImage & " WHERE Código=" & Usuario.Identificacao
                                vezes += 1
                        End While

                        If strImage = "?" Then
                                cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
                        End If
                        '
                        cmd.ExecuteNonQuery()
                        MsgBox("Dados salvos com sucesso.")
                Catch ex As Exception
                        MsgBox(ex.Message)
                Finally
                        cn.Close()
                End Try
        End Sub

        Private Sub cboTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTema.SelectedIndexChanged
                Select Case cboTema.Text
                        Case = "Light"
                                My.Settings.Tema = "Light"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.LIGHT
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                CorFundo = Color.White
                                CorTexto = Color.Black

                        Case = "Dark"
                                My.Settings.Tema = "Dark"
                                Dim MaterialSkinManeger As MaterialSkinManager = MaterialSkinManager.Instance
                                MaterialSkinManeger.AddFormToManage(Me)
                                MaterialSkinManeger.Theme = MaterialSkinManager.Themes.DARK
                                MaterialSkinManeger.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
                                CorFundo = Color.FromArgb(51, 51, 51)
                                CorTexto = Color.White

                        Case Else

                End Select
        End Sub
End Class