Imports System.Data.OleDb



Public Class FrmListaVisita
        Private Sub FrmListaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      AtualizarGrid()
	      BloquearControles()
	      btnAtualizarcadastro.Enabled = False
	      dgvServico.Columns.Add("Tipo", "Tipo")
	      dgvServico.Columns.Add("Item", "Item")
	      dgvServico.Columns.Add("QuantMed", "QuantMed")

        End Sub


        Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
	      DesbloquearControles()
	      LimparControles()
	      btnConcluir.Enabled = True
	      picDataEnvio.Enabled = False
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
	      Dim Instrucao As String = "SELECT Nome, VisitaID as 'Identificação', DataContato as 'Data Contato', Telefone, EndOrcamento as 'Endereço Orçamento' FROM tbVisita"
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

	      txtIdentificacao.Text = dgvVisita.CurrentRow.Cells(1).Value
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

        Private Sub chkTipoServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoServico.SelectedIndexChanged

	      Dim Instrucao As String = ""

	      Select Case cboTipoServico.Text
		    Case = "MATERIAL"
			  Instrucao = "SELECT Produto FROM tbProdutoPDV"
		    Case = "SERVIÇO"
			  Instrucao = "SELECT Descricao FROM tbServico"
		    Case Else

	      End Select



	      Dim strConn As String = sConnectionString
	      Dim conexao As New OleDbConnection(strConn)
	      Dim comando As New OleDbCommand(Instrucao, conexao)
	      Dim adaptador As New OleDbDataAdapter(comando)
	      Dim dsbiblio As New DataSet()
	      adaptador.Fill(dsbiblio, "escolha")
	      dgvEscolha.DataSource = dsbiblio.Tables("escolha")
        End Sub

        Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
	      Try
		    dgvServico.Rows.Add(cboTipoServico.Text, dgvEscolha.CurrentRow.Cells(0).Value)
	      Catch
		    MsgBox("Selecione um item valido")
	      End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click







        End Sub
End Class