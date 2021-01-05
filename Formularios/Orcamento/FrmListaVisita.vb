Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Win32

Public Class FrmListaVisita
        Private Sub FrmListaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      AtualizarGrid()
	      BloquearControles()
	      btnAtualizarcadastro.Enabled = False

	      Try
		    If My.Settings.CaminhoPlanilha = "" Then
			  Dim ofdCaminhoPlanilha As New FolderBrowserDialog
			  ofdCaminhoPlanilha.ShowDialog()
			  My.Settings.CaminhoPlanilha = ofdCaminhoPlanilha.SelectedPath
		    End If
	      Catch
		    MsgBox("não foi possivel localizar o caminho de arquivamento de planilhas, por favor indique a pasta.")
	      End Try

	      btnGoogleForms.PerformClick()

        End Sub


        Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
	      DesbloquearControles()
	      LimparControles()
	      btnConcluir.Enabled = True
	      picDataEnvio.Enabled = False
	      PicDataVisita.Enabled = False
        End Sub

        Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
	      InserirVisita()
	      AtualizarGrid()
	      btnConcluir.Enabled = False
	      AtualizarGrid()
        End Sub

        Public Sub InserirVisita()
	      Dim DataContato As Date = PicDataContato.Text
	      Dim DataVisita As Date = PicDataVisita.Text
	      Dim DataEnvio As Date = picDataEnvio.Text
	      Try
		    Dim comando As String = ("INSERT INTO tbVisita(DataContato,Nome,Telefone,EndOrcamento,VisitaNece,DataVisita,VisitaFeita,Eletrica,Pintura,OrcamentoFeito,FoiConferida,FoiEnvCliente,DataEnvio,ClienteFechou,FoiPreenchidoForms,FoiEnviadoResp)" &
	      " VALUES(""" & DataContato.ToString("dd/MM/yyyy") & """,""" & txtNomeCliente.Text & """,""" & CDbl(txtTelefone.Text) & """,""" & txtEndOrcamento.Text & """,""" & chkNecessitaVisita.Checked & """,""" & DataVisita.ToString("dd/MM/yyyy") & """,""" & chkVisitaFeita.Checked &
	      """,""" & chkNeceEletrica.Checked & """,""" & chkPintura.Checked & """,""" & chkOrcamentoFeito.Checked & """,""" & chkConferidoPaulo.Checked & """,""" & chkEnvCliente.Checked & """,""" & DataEnvio.ToString("dd/MM/yyyy") & """,""" & chkClienteFechou.Checked & """,""" &
	      chkFoiPreenForms.Checked & """,""" & chkFoiEnviadoResp.Checked & """)")
		    conexao1(comando)
		    btnConcluir.Enabled = False
	      Catch
		    MsgBox("Não foi possivel cadastrar a visita. Verifique os campos e tente novamente")
	      End Try

        End Sub

        Public Sub AtualizarGrid()
	      Dim Instrucao As String = "SELECT VisitaID as 'Identificação', Nome, DataContato as 'Data Contato', Telefone, EndOrcamento as 'Endereço Orçamento' FROM tbVisita"
	      Dim strConn As String = sConnectionString
	      Dim conexao As New OleDbConnection(strConn)
	      Dim comando As New OleDbCommand(Instrucao, conexao)
	      Dim adaptador As New OleDbDataAdapter(comando)
	      Dim dsbiblio As New DataSet()
	      adaptador.Fill(dsbiblio, "Visitas")
	      dgvVisita.DataSource = dsbiblio.Tables("Visitas")
        End Sub



        Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
	      AtualizarGrid()
        End Sub

        Public Sub BloquearControles()
	      chkVisitaFeita.Enabled = False
	      chkNecessitaVisita.Enabled = False
	      chkNeceEletrica.Enabled = False
	      chkPintura.Enabled = False
	      chkOrcamentoFeito.Enabled = False
	      chkEnvCliente.Enabled = False
	      chkClienteFechou.Enabled = False
	      chkFoiPreenForms.Enabled = False
	      chkFoiEnviadoResp.Enabled = False
	      chkConferidoPaulo.Enabled = False
	      txtTelefone.Enabled = False
	      txtEndOrcamento.Enabled = False
	      txtNomeCliente.Enabled = False
	      picDataEnvio.Enabled = False
	      PicDataContato.Enabled = False
	      PicDataVisita.Enabled = False
	      btnConcluir.Enabled = False
        End Sub

        Public Sub DesbloquearControles()
	      chkVisitaFeita.Enabled = True
	      chkNecessitaVisita.Enabled = True
	      chkNeceEletrica.Enabled = True
	      chkPintura.Enabled = True
	      chkOrcamentoFeito.Enabled = True
	      chkEnvCliente.Enabled = True
	      chkClienteFechou.Enabled = True
	      chkFoiPreenForms.Enabled = True
	      chkFoiEnviadoResp.Enabled = True
	      chkConferidoPaulo.Enabled = True
	      txtTelefone.Enabled = True
	      txtEndOrcamento.Enabled = True
	      txtNomeCliente.Enabled = True
	      picDataEnvio.Enabled = True
	      PicDataContato.Enabled = True
	      PicDataVisita.Enabled = True
        End Sub

        Private Sub dgvVisita_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisita.CellContentClick

        End Sub

        Private Sub dgvVisita_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisita.CellEnter

	      txtIdentificacao.Text = dgvVisita.CurrentRow.Cells(0).Value
	      BloquearControles()
	      Dim dr As OleDbDataReader = GetDR_semRead("SELECT * FROM tbVisita WHERE VisitaID=" & CDbl(txtIdentificacao.Text))
	      dr.Read()
	      txtNomeCliente.Text = dr("Nome")
	      txtTelefone.Text = dr("Telefone")
	      txtEndOrcamento.Text = dr("EndOrcamento")
	      chkNecessitaVisita.Checked = dr("VisitaNece")
	      chkVisitaFeita.Checked = dr("VisitaFeita")
	      chkNeceEletrica.Checked = dr("Eletrica")
	      chkPintura.Checked = dr("Pintura")
	      chkOrcamentoFeito.Checked = dr("OrcamentoFeito")
	      chkEnvCliente.Checked = dr("FoiEnvCliente")
	      chkClienteFechou.Checked = dr("ClienteFechou")
	      chkFoiPreenForms.Checked = dr("FoiPreenchidoForms")
	      chkFoiEnviadoResp.Checked = dr("FoiEnviadoResp")
	      chkConferidoPaulo.Checked = dr("FoiConferida")
	      PicDataContato.Text = dr("DataContato")
	      picDataEnvio.Text = dr("DataEnvio")
	      PicDataVisita.Text = dr("DataVisita")

	      Dim drPlanilha As OleDbDataReader = GetDR_semRead("SELECT * FROM tbVisita WHERE VisitaID=" & CDbl(txtIdentificacao.Text))
	      drPlanilha.Read()
	      Try
		    If drPlanilha.HasRows = True Then
			  LocalAnexoPlanilha = drPlanilha("LocalPlanilha")
			  btnAnexarExcel.Enabled = False
			  btnAbrirAnexo.Enabled = True
		    Else
			  btnAnexarExcel.Enabled = True
			  btnAbrirAnexo.Enabled = False
		    End If
	      Catch
		    btnAbrirAnexo.Enabled = False
		    btnAnexarExcel.Enabled = True
	      End Try


        End Sub

        Public Sub LimparControles()
	      chkVisitaFeita.Checked = False
	      chkNecessitaVisita.Checked = False
	      chkNeceEletrica.Checked = False
	      chkPintura.Checked = False
	      chkOrcamentoFeito.Checked = False
	      chkEnvCliente.Checked = False
	      chkClienteFechou.Checked = False
	      chkFoiPreenForms.Checked = False
	      chkFoiEnviadoResp.Checked = False
	      chkConferidoPaulo.Checked = False
	      txtTelefone.Text = ""
	      txtEndOrcamento.Text = ""
	      txtNomeCliente.Text = ""
	      picDataEnvio.Text = ""
	      PicDataContato.Enabled = True
	      PicDataVisita.Enabled = True
	      txtIdentificacao.Text = ""
        End Sub

        Private Sub btnAtualizarcadastro_Click(sender As Object, e As EventArgs) Handles btnAtualizarcadastro.Click

	      Dim DataContato As Date = PicDataContato.Text
	      Dim DataVisita As Date = PicDataVisita.Text
	      Dim DataEnvio As Date = picDataEnvio.Text



	      ' Dim comando As String = ("INSERT INTO tbVisita(,Nome,Telefone,EndOrcamento,VisitaNece,DataVisita,VisitaFeita,Eletrica,Pintura,OrcamentoFeito,FoiConferida,FoiEnvCliente,DataEnvio,ClienteFechou,FoiPreenchidoForms,FoiEnviadoResp)" &
	      ' " VALUES(,""" & txtNomeCliente.Text & """,""" & CDbl(txtTelefone.Text) & """,""" & txtEndOrcamento.Text & """,""" & chkNecessitaVisita.Checked & """,""" & DataVisita.ToString("dd/MM/yyyy") & """,""" & chkVisitaFeita.Checked &
	      '""",""" & chkNeceEletrica.Checked & """,""" & chkPintura.Checked & """,""" & chkOrcamentoFeito.Checked & """,""" & chkConferidoPaulo.Checked & """,""" & chkEnvCliente.Checked & """,""" & DataEnvio.ToString("dd/MM/yyyy") & """,""" & chkClienteFechou.Checked & """,""" &
	      ' chkFoiPreenForms.Checked & """,""" & chkFoiEnviadoResp.Checked & """)")
	      'conexao1(comando)
	      'btnConcluir.Enabled = False


	      Dim sql As String = "UPDATE tbVisita SET DataContato=""" & DataContato.ToString("dd/MM/yyyy") & """,Nome=""" & txtNomeCliente.Text & """,Telefone=""" & txtTelefone.Text &
	      """,EndOrcamento=""" & txtEndOrcamento.Text & """,VisitaNece=""" & chkNecessitaVisita.Checked & """,DataVisita=""" & DataVisita.ToString("dd/MM/yyyy") & """,VisitaFeita=""" & chkVisitaFeita.Checked & """,Eletrica=""" & chkNeceEletrica.Checked &
	      """,Pintura=""" & chkPintura.Checked & """,OrcamentoFeito=""" & chkOrcamentoFeito.Checked & """,FoiConferida=""" & chkConferidoPaulo.Checked & """,FoiEnvCliente=""" & chkEnvCliente.Checked & """,DataEnvio=""" & DataEnvio.ToString("dd/MM/yyyy") &
	      """,ClienteFechou=""" & chkClienteFechou.Checked & """,FoiPreenchidoForms=""" & chkFoiPreenForms.Checked & """,FoiEnviadoResp=""" & chkFoiEnviadoResp.Checked & """ WHERE VisitaID=" & CDbl(txtIdentificacao.Text)

	      InstrucaoDireta(sql)


	      'sql aqui====================>>
	      btnAtualizarcadastro.Enabled = False
	      BloquearControles()
	      dgvVisita.Enabled = True
	      AtualizarGrid()


        End Sub

        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
	      DesbloquearControles()
	      txtNomeCliente.Enabled = False
	      dgvVisita.Enabled = False
	      btnAtualizarcadastro.Enabled = True


	      If chkVisitaFeita.Checked = True Then
		    PicDataVisita.Enabled = True
	      Else
		    PicDataVisita.Enabled = False
	      End If

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	      Dim Resp As DialogResult = MsgBox("Deseja realmente excluir esse registro? (A operação não podera ser desfeita)", vbYesNo)
	      If Resp = DialogResult.Yes Then
		    InstrucaoDireta("DELETE FROM tbVisita WHERE VisitaID=" & CDbl(txtIdentificacao.Text))
		    SQL.Notificao("", "Registro excluido com sucesso")
		    AtualizarGrid()
	      Else
		    SQL.Notificao("", "Operaçao cancelada pelo usuario")
	      End If
	      If dgvVisita.Rows.Count <= 0 Then
		    LimparControles()
	      End If
        End Sub

        Private Sub chkEnvCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnvCliente.CheckedChanged
	      If chkEnvCliente.Checked = True Then
		    picDataEnvio.Enabled = True
	      Else
		    picDataEnvio.Enabled = False
	      End If
        End Sub

        Private Sub chkTipoServico_SelectedIndexChanged(sender As Object, e As EventArgs)



        End Sub

        Private Sub btnAddItem_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs)
	      InstrucaoDireta("DELETE FROM tbItensVisita WHERE VisitaID=" & CDbl(txtIdentificacao.Text))





        End Sub

        Private Sub btnAnexarExcel_Click(sender As Object, e As EventArgs) Handles btnAnexarExcel.Click
	      Try
		    ofdPlanilha.ShowDialog()
		    Dim Destino As String = My.Settings.CaminhoPlanilha & "\" & txtIdentificacao.Text & ".xlsx"
		    My.Computer.FileSystem.CopyFile(ofdPlanilha.FileName, Destino)
		    InstrucaoDireta("UPDATE tbVisita SET LocalPlanilha=""" & Destino & """ WHERE VisitaID=" & txtIdentificacao.Text)
		    SQL.Notificao("", "Planilha Anexada com sucesso")
	      Catch
		    MsgBox("não foi possivel salvar")
	      End Try

        End Sub

        Private Sub btnLocAnexo_Click(sender As Object, e As EventArgs) Handles btnLocAnexo.Click
	      MsgBox("ATENÇÃO, essa alteração pode causar perda de dados")
	      Try
		    Dim ofdCaminhoPlanilha As New FolderBrowserDialog
		    ofdCaminhoPlanilha.ShowDialog()
		    My.Settings.CaminhoPlanilha = ofdCaminhoPlanilha.SelectedPath
	      Catch
		    MsgBox("Erro ao salvar caminho!!! (consulta o administrador do sistema)")
	      End Try
        End Sub

        Public LocalAnexoPlanilha As String

        Private Sub btnAbrirAnexo_Click(sender As Object, e As EventArgs) Handles btnAbrirAnexo.Click
	      Process.Start(LocalAnexoPlanilha)
        End Sub

        Private Sub chkVisitaFeita_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisitaFeita.CheckedChanged
	      If chkVisitaFeita.Checked = True Then
		    PicDataVisita.Enabled = True
	      Else
		    PicDataVisita.Enabled = False
	      End If
        End Sub

        Private Sub btnGoogleForms_Click(sender As Object, e As EventArgs) Handles btnGoogleForms.Click
	      webFormsGoogle.ScriptErrorsSuppressed = False




	      Dim versaoNavegador As Integer, RegVal As Integer
	      Try
		    ' obtem a versão instalada do IE
		    Using Wb As New WebBrowser()
			  versaoNavegador = Wb.Version.Major
		    End Using
		    ' define a versão do IE
		    If versaoNavegador >= 11 Then
			  RegVal = 11001
		    ElseIf versaoNavegador = 10 Then
			  RegVal = 10001
		    ElseIf versaoNavegador = 9 Then
			  RegVal = 9999
		    ElseIf versaoNavegador = 8 Then
			  RegVal = 8888
		    Else
			  RegVal = 7000
		    End If

		    ' define a chave atual
		    Dim Key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
		    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord)
		    Key.Close()


	      Catch ex As Exception

	      End Try

	      webFormsGoogle.Url = New Uri("https://docs.google.com/forms/d/e/1FAIpQLScr6QGSy14f8qZ4G1tDBZxtSM54oyGu5XK4lP1pf7wU3n4qrQ/viewform?usp=sf_link")

	      ' webFormsGoogle.Url = New Uri("https://www.google.com.br/maps/@-24.0339177,-46.416132,13z")
        End Sub
End Class