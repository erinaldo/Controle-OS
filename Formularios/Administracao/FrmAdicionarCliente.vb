Imports System.IO
Imports System.Data.OleDb
Imports System
Imports System.ComponentModel
Imports DllConsultaCNPJ.ConsultaCNPJReceita
Imports MaterialSkin
Imports System.Runtime.InteropServices

Public Class FrmAdicionarCliente

        Inherits Controls.MaterialForm

        Public listaFisica As New List(Of TextBox)
        Public listaJuridica As New List(Of TextBox)
        Public listaColaborador As New List(Of TextBox)
        Public FocoDataAdmissao As Boolean
        Public FocoDataNasc As Boolean

        Private Sub FrmAdicionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	      SQL.Notificao("", "Carregando...,aguarde")

	      SQL.Notificao("", "Carregamento Concluido")
	      pbRazaoSocial.BackColor = Color.Red

	      With txtColEstadoCivil.Items
		    .Clear()
		    .Add("Solteiro(a)")
		    .Add("Casado(a)")
		    .Add("Divorciado(a)")
		    .Add("Viúvo(a)")
		    .Add("Separado(a)")
	      End With

	      With cboColPeriodoTrabalho.Items
		    .Clear()
		    .Add(1)
		    .Add(2)
		    .Add(3)
		    .Add(4)
		    .Add(5)
		    .Add(6)
		    .Add(7)
		    .Add(8)
		    .Add(9)
		    .Add(10)
		    .Add(11)
		    .Add(12)
	      End With

	      GetCepCombo(cboNaturalidadeUF)

	      txtColDataAdmissao.Text = Today.ToShortDateString
	      LimparText()

	      GetCaptcha(picCaptcha)

	      With chkMultiCadastro
		    .BackColor = CorFundo
		    .ForeColor = CorTexto
	      End With

        End Sub

        Public Async Function GetMunicipiiosParalelo() As Task
	      Dim CidDR As OleDbDataReader = GetDR_semRead("SELECT Município FROM tbMunicipio")


	      While CidDR.Read
		    txtColNaturalidade.AutoCompleteCustomSource.Add(CidDR(0))
	      End While


        End Function

        Public Function TextPreenchido(ByVal BoxList As List(Of TextBox))

	      Dim QuantItens As Double = BoxList.Count
	      Dim Permissive As Boolean = True

	      Do Until QuantItens = 0
		    QuantItens -= 1

		    If BoxList.Item(QuantItens).Text = "" Then
			  BoxList.Item(QuantItens).BackColor = Color.Red
			  Permissive = False
		    Else
			  BoxList.Item(QuantItens).BackColor = Color.White

		    End If
	      Loop

	      Return Permissive

        End Function

        Public Sub InserirPessoaFisica()

	      Dim listControl As New List(Of Control)

	      With listControl
		    .Add(txtPFNome)
		    .Add(txtPFSobrenome)
		    .Add(txtPFCPF)
		    .Add(txtPFRG)
	      End With

	      If ControleObrigatorio(listControl) = True Then

		    Dim vezes As Double = 0
		    Dim cn As New OleDb.OleDbConnection
		    cn.ConnectionString = sConnectionString
		    Try
			  cn.Open()
			  pbProgresso.Value = 20
			  Dim arrImage() As Byte
			  Dim strImage As String
			  Dim myMs As New MemoryStream
			  '
			  If Not IsNothing(Me.picPessoaFisica.Image) Then
				Me.picPessoaFisica.Image.Save(myMs, Me.picPessoaFisica.Image.RawFormat)
				arrImage = myMs.GetBuffer
				strImage = "?"
			  Else
				pbProgresso.Value = 30
				arrImage = Nothing
				strImage = "NULL"
			  End If
			  Dim cmd As New OleDb.OleDbCommand
			  cmd.Connection = cn
			  cmd.CommandText = "INSERT INTO tbClientes (RG,Tipo,Nome,Sobrenome,CPF,Imagem)" & "VALUES (""" & txtPFRG.Text & """,""" & "Pessoa Fisica" &
		""",""" & txtPFNome.Text & """,""" & txtPFSobrenome.Text & """,""" & CDbl(txtPFCPF.Text) & """,?)"
			  pbProgresso.Value = 50
			  If strImage = "?" Then
				cmd.Parameters.Clear()
				cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
			  End If
			  cmd.ExecuteNonQuery()
		    Catch ex As Exception
			  MsgBox(ex.Message)
		    Finally
			  cn.Close()
			  pbProgresso.Value = 60
		    End Try
		    LimparTextPessoaFisica()
		    SQL.Notificao("NOVA LITORAL GESSO", "CLIENTE CADASTRADO COM SUCESSO")

		    For Each Controle In listControl
			  Controle.Text = ""
		    Next

		    FrmClientes.CarregarTables()
		    LimparTextPessoaJuridica()
		    pbProgresso.Value = 80
		    If chkMultiCadastro.Checked = False Then
			  Me.Close()
		    Else
			  LimparText()
		    End If
		    pbProgresso.Value = 100

	      End If

        End Sub

        Public Sub LimparText()
	      txtColNome.Text = ""
	      txtColSobrenome.Text = ""
	      txtColNacionalidade.Text = ""
	      txtPJRazaoSocial.Text = ""
	      txtColEstadoCivil.Text = ""
	      txtColCPF.Text = ""
	      txtColRG.Text = ""
	      txtColCNH.Text = ""
	      txtColTituloEleitor.Text = ""
	      txtColCargo.Text = ""
	      txtColSetor.Text = ""
	      txtColCTPS.Text = ""
	      txtPJIE.Text = ""
	      txtPJIM.Text = ""
	      cboColPeriodoTrabalho.Text = ""
	      txtColValorRemuneracao.Text = ""
        End Sub

        Public Sub LimparTextPessoaFisica()
	      txtPFNome.Text = ""
	      txtPFSobrenome.Text = ""
	      txtPFRG.Text = ""
	      txtPFCPF.Text = ""
	      picPessoaFisica.Image = My.Resources.Usuarios
        End Sub

        Public Sub LimparTextPessoaJuridica()
	      txtPJNomeFantasia.Text = ""
	      txtPJRazaoSocial.Text = ""
	      txtPJIE.Text = ""
	      txtPJIM.Text = ""
	      txtPJCNPJ.Text = ""
	      picPessoaJuridica.Image = My.Resources.Usuarios
        End Sub

        Public Sub InserirPessoaJuridica()

	      Dim cn As New OleDb.OleDbConnection
	      cn.ConnectionString = sConnectionString
	      Try
		    cn.Open()
		    pbProgresso.Value = 30
		    Dim arrImage() As Byte
		    Dim strImage As String
		    Dim myMs As New IO.MemoryStream
		    '
		    If Not IsNothing(Me.picPessoaJuridica.Image) Then
			  Me.picPessoaJuridica.Image.Save(myMs, Me.picPessoaJuridica.Image.RawFormat)
			  arrImage = myMs.GetBuffer
			  strImage = "?"
		    Else
			  pbProgresso.Value = 40
			  arrImage = Nothing
			  strImage = "NULL"
		    End If
		    Dim cmd As New OleDb.OleDbCommand
		    cmd.Connection = cn

		    cmd.CommandText = "INSERT INTO tbClientes (Nome,InscricaoMunicipal,InscricaoEstadual,RazaoSocial,Tipo,CPF,Imagem)" & "VALUES (""" &
		    txtPJNomeFantasia.Text & """,""" & txtPJIM.Text & """,""" & txtPJIE.Text & """,""" &
		    txtPJRazaoSocial.Text & """,""" & "Pessoa Juridica" & """,""" & CDbl(txtPJCNPJ.Text) & """,?)"

		    pbProgresso.Value = 60

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

		    pbProgresso.Value = 80

	      End Try
	      SQL.Notificao("NOVA LITORAL GESSO", "CLIENTE CADASTRADO COM SUCESSO")
	      FrmClientes.CarregarTables()
	      If chkMultiCadastro.Checked = False Then
		    Me.Close()
	      End If
        End Sub

        ''' <summary>
        ''' INSERIR COLABORADOR NO BANCO DE DADOS
        ''' </summary>
        Public Sub InserirPessoaColaborador()
	      Dim CamposObrigatorios As New List(Of Control)
	      Dim CamposPreenchidos As Boolean = True
	      Dim NomeCampoIncorreto As New List(Of String)

	      With CamposObrigatorios
		    .Add(txtColNome)
		    .Add(txtColSobrenome)
		    .Add(txtColNacionalidade)
		    .Add(txtColNaturalidade)
		    .Add(txtColCPF)
		    .Add(txtColRG)
		    .Add(txtColCargo)
		    .Add(cboNaturalidadeUF)
	      End With

	      'VERIFICAR E PINTAR BACKCOLOR CASO O CONTROLE ESTEJA INCORRETO
	      For Each controle In CamposObrigatorios
		    If controle.Text = "" Then
			  CamposPreenchidos = False
			  controle.BackColor = Color.Red
		    Else
			  controle.BackColor = Color.FromArgb(34, 36, 49)
		    End If
	      Next

	      'CONFIRMAR SE TODOS OS CAMPOS FORAM PREENCHIDOS
	      If CamposPreenchidos = True Then

		    'CONVERTER PARA NUMERO CAMPOS VAZIOS NÃO OBRIGATORIOS
		    Dim ListTxtNumber As New List(Of Control)

		    With ListTxtNumber
			  .Add(txtColCNH)
			  .Add(txtColCTPS)
			  .Add(txtColTituloEleitor)
			  .Add(txtColValorRemuneracao)
			  .Add(cboColPeriodoTrabalho)

		    End With

		    For Each Controle In ListTxtNumber
			  If IsNumeric(Controle) = False Then
				Controle.Text = 0
			  End If
		    Next

		    Dim ColCad As New Colaborador

		    With ColCad 'COLABORADOR QUE SERÁ CADASTRADO NO BANCO DE DADOS
			  .Nome = txtColNome.Text
			  .Sobrenome = txtColSobrenome.Text
			  .Nacionalidade = txtColNacionalidade.Text
			  .Naturalidade = txtColNaturalidade.Text
			  .NaturalidadeUF = cboNaturalidadeUF.Text
			  .CPF = txtColCPF.Text
			  .RG = txtColRG.Text
			  .Cargo = txtColCargo.Text
			  .Setor = txtColSetor.Text
			  .CNH = txtColCNH.Text
			  .TituloEleitor = txtColTituloEleitor.Text
			  .CTPS = txtColCTPS.Text
			  .ValorRemuneracao = txtColValorRemuneracao.Text
			  If cboColPeriodoTrabalho.Text = "" Then
				.JornadaTrabalho = 0
			  End If
			  .EstadoCivil = txtColEstadoCivil.Text
			  .DataNasc = txtColtDataNasc.Text
			  .DataAdmissao = txtColDataAdmissao.Text
		    End With

		    Dim cn As New OleDb.OleDbConnection
		    cn.ConnectionString = sConnectionString
		    Try
			  cn.Open()
			  pbProgresso.Value = 30
			  Dim arrImage() As Byte
			  Dim strImage As String
			  Dim myMs As New IO.MemoryStream
			  If Not IsNothing(Me.PicColaborador.Image) Then
				pbProgresso.Value = 40
				Me.PicColaborador.Image.Save(myMs, Me.PicColaborador.Image.RawFormat)

				arrImage = myMs.GetBuffer
				strImage = "?"
			  Else
				arrImage = Nothing
				strImage = "NULL"
			  End If
			  Dim cmd As New OleDb.OleDbCommand
			  cmd.Connection = cn
			  pbProgresso.Value = 60
			  cmd.CommandText = "INSERT INTO tbClientes (Nome,CPF,Tipo,Sobrenome,RG,EstadoCivil,Nacionalidade,Cargo,CNH,CTPS,TituloEleitor,DataAdmissao,JornadaTrabalho,ValorRemun,Imagem,NaturalidadeUF)" &
		    "VALUES (""" & ColCad.Nome & """, """ & ColCad.CPF & """,""" & "Colaborador" & """,""" & ColCad.Sobrenome & """,""" & ColCad.RG &
		    """,""" & ColCad.EstadoCivil & """,""" & ColCad.Nacionalidade & """,""" & ColCad.Cargo & """,""" & ColCad.CNH &
		    """,""" & txtColCTPS.Text & """,""" & ColCad.TituloEleitor &
		    """,""" & ColCad.DataAdmissao & """,""" & ColCad.JornadaTrabalho & """,""" & ColCad.ValorRemuneracao & """,?, """ & ColCad.NaturalidadeUF & """)"

			  If strImage = "?" Then
				cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
			  End If
			  pbProgresso.Value = 70
			  cmd.ExecuteNonQuery()
			  LimparTextColaborador()
			  SQL.Notificao("NOVA LITORAL GESSO", "CLIENTE CADASTRADO COM SUCESSO")

			  'CONTINUAR CADASTRANDO SEM FECHAR A PAGINA 
			  If chkMultiCadastro.Checked = False Then
				Me.Close()
			  End If

		    Catch ex As Exception
			  MsgBox(ex.Message)
		    Finally
			  cn.Close()
		    End Try
	      Else
		    MsgBox("Um ou mais campos obrigatórios não foram preenchidos")
	      End If
	      pbProgresso.Value = 80
	      FrmClientes.CarregarTables()
	      pbProgresso.Value = 100
	      pbProgresso.BackColor = Color.Red
        End Sub
        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	      Me.Close()
        End Sub
        Private Sub txtCPF_TextChanged(sender As Object, e As EventArgs)
	      Dim numeros As Integer

	      If txtColCPF.Text.Length < 10 Then
		    txtColCPF.ForeColor = Color.Red
	      Else
		    txtColCPF.ForeColor = Color.Black
	      End If
        End Sub

        Private Sub llbLocalizar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbLocalizar.LinkClicked
	      If Me.ofd.ShowDialog = 1 Then
		    Me.PicFoto.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
	      End If
        End Sub

        Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
	      Dim cn As New OleDb.OleDbConnection
	      cn.ConnectionString = sConnectionString
	      Try
		    cn.Open()
		    Dim arrImage() As Byte
		    Dim strImage As String
		    Dim myMs As New IO.MemoryStream
		    '
		    If Not IsNothing(Me.PicFoto.Image) Then
			  Me.PicFoto.Image.Save(myMs, Me.PicFoto.Image.RawFormat)
			  arrImage = myMs.GetBuffer
			  strImage = "?"
		    Else
			  arrImage = Nothing
			  strImage = "NULL"
		    End If
		    Dim cmd As New OleDb.OleDbCommand
		    cmd.Connection = cn
		    cmd.CommandText = "INSERT INTO tbAnexos(Foto) VALUES(" & strImage & ")"
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

        Private Sub btnLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalizar.Click
	      Dim cn As New OleDb.OleDbConnection
	      cn.ConnectionString = sConnectionString
	      Try
		    cn.Open()
		    Dim arrImage() As Byte
		    Dim myMS As New IO.MemoryStream
		    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblAlunos " &
								" WHERE Codigo=" & Me.txtAnexoID.Text, cn)
		    Dim dt As New DataTable
		    da.Fill(dt)
		    If dt.Rows.Count > 0 Then
			  Me.txtColNome.Text = dt.Rows(0).Item("Nome") & ""
			  If Not IsDBNull(dt.Rows(0).Item("Foto")) Then
				arrImage = dt.Rows(0).Item("Foto")
				For Each ar As Byte In arrImage
				        myMS.WriteByte(ar)
				Next
				Me.PicFoto.Image = System.Drawing.Image.FromStream(myMS)
			  End If
			  Me.btnAdicionar.Enabled = False
		    Else
			  MsgBox("Registro não encontrado!")
		    End If
	      Catch ex As Exception
		    MsgBox(ex.Message)
	      Finally
		    cn.Close()
	      End Try
        End Sub

        Private Sub dgvDados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellClick
	      Try
		    'obtem o valor das células do grid
		    txtAnexoID.Text = dgvDados.CurrentRow.Cells(0).Value.ToString()
		    txtColNome.Text = dgvDados.CurrentRow.Cells(1).Value.ToString()
		    Dim ms As New MemoryStream(CType(dgvDados.CurrentRow.Cells(2).Value, Byte()))
		    PicFoto.Image = Image.FromStream(ms)
	      Catch ex As Exception
		    MsgBox(ex.Message)
	      End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

	      Dim cn As New OleDb.OleDbConnection
	      cn.ConnectionString = sConnectionString
	      Try
		    Dim cmd As New OleDb.OleDbCommand
		    cmd.Connection = cn
		    cmd.CommandText = "SELECT * FROM tbAnexos"
		    cn.Open()
		    '
		    Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
		    If reader.HasRows Then
			  Dim dt As New DataTable()
			  dt.Load(reader)
			  dgvDados.DataSource = dt
		    End If
	      Finally
		    cn.Close()
	      End Try
        End Sub

        Private Sub btnAnRG_Click(sender As Object, e As EventArgs) Handles btnAnRG.Click
	      If Me.ofd.ShowDialog = 1 Then
		    Me.PicFoto.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
	      End If
        End Sub

        Public Sub InserirImg(ByVal Codigo As Double)

	      Dim vezes As Double = 0

	      Dim cn As New OleDb.OleDbConnection
	      cn.ConnectionString = sConnectionString
	      Try
		    cn.Open()
		    Dim arrImage() As Byte
		    Dim strImage As String
		    Dim myMs As New IO.MemoryStream
		    '
		    If Not IsNothing(Me.PicColaborador.Image) Then
			  Me.PicColaborador.Image.Save(myMs, Me.PicColaborador.Image.RawFormat)
			  arrImage = myMs.GetBuffer
			  strImage = "?"
		    Else
			  arrImage = Nothing
			  strImage = "NULL"
		    End If
		    Dim cmd As New OleDb.OleDbCommand
		    cmd.Connection = cn

		    While vezes < 15 = True

			  cmd.CommandText = "UPDATE tbClientes SET Imagem=" & strImage & " WHERE Código=" & Codigo
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

        Private Sub btnAddFoto_Click(sender As Object, e As EventArgs) Handles btnAddFoto.Click
	      Try
		    If Me.ofd.ShowDialog = 1 Then
			  Me.PicColaborador.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
		    End If
	      Catch ex As Exception
		    MsgBox(ex.Message)
	      Finally
	      End Try
        End Sub

        Private Sub btnAddFotoPF_Click(sender As Object, e As EventArgs) Handles btnAddFotoPF.Click
	      Try
		    If Me.ofd.ShowDialog = 1 Then
			  Me.picPessoaFisica.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
		    End If
	      Catch ex As Exception
		    MsgBox(ex.Message)
	      Finally
	      End Try
        End Sub

        Private Sub btnAddFotoPJ_Click(sender As Object, e As EventArgs) Handles btnAddFotoPJ.Click
	      Try
		    If Me.ofd.ShowDialog = 1 Then
			  Me.picPessoaJuridica.Image = System.Drawing.Image.FromFile(Me.ofd.FileName)
		    End If
	      Catch ex As Exception
		    MsgBox(ex.Message)
	      Finally
	      End Try
        End Sub

        Private Sub btnRemFoto_Click(sender As Object, e As EventArgs) Handles btnRemFoto.Click
	      MsgBox("Desculpe " & Usuario.Nome & " ainda estou em implementação")
        End Sub

        Private Sub txtRazaoSocial_LostFocus(sender As Object, e As EventArgs)
	      txtPJRazaoSocial.Text = txtPJRazaoSocial.Text.ToUpper
        End Sub

        Private Sub txtNome_LostFocus(sender As Object, e As EventArgs)
	      txtColNome.Text = txtColNome.Text.ToUpper
        End Sub

        Private Sub btnLimparText_Click(sender As Object, e As EventArgs) Handles btnLimparText.Click
	      LimparTextColaborador()
	      LimparTextPessoaFisica()
	      LimparTextPessoaJuridica()
        End Sub

        Private Sub FrmAdicionarCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
	      FrmMenu.AtualizarRelatorio()
	      With FrmClientes
		    .txtLogradouro.Text = ""
		    .txtNumero.Text = ""
		    .txtCPF.Text = ""
		    .cboUF.Text = ""
		    .txtComplemento.Text = ""
		    .txtCodEnd.Text = ""
		    .cboTipo.Text = ""
		    .txtCEP.Text = ""
	      End With
        End Sub

        Private Sub txtNome_Click(sender As Object, e As EventArgs)
	      txtColNome.BackColor = Color.White
        End Sub

        Private Sub txtSobrenome_Click(sender As Object, e As EventArgs)
	      txtColSobrenome.BackColor = Color.White
        End Sub

        Private Sub txtCPF_Click(sender As Object, e As EventArgs)
	      txtColCPF.BackColor = Color.White
        End Sub

        Private Sub txtIE_Click(sender As Object, e As EventArgs)
	      txtPJIE.BackColor = Color.White
        End Sub

        Private Sub txtIM_Click(sender As Object, e As EventArgs)
	      txtPJIM.BackColor = Color.White
        End Sub

        Private Sub txtRazaoSocial_Click(sender As Object, e As EventArgs)
	      txtPJRazaoSocial.BackColor = Color.White
        End Sub

        Private Sub FrmAdicionarCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
	      Me.Dispose(True)
        End Sub

        Private Sub btnCadPF_Click(sender As Object, e As EventArgs) Handles btnCadPF.Click
	      InserirPessoaFisica()
	      FrmClientes.btnAtualizar.PerformClick()
        End Sub

        Private Sub btnConcluirPJ_Click(sender As Object, e As EventArgs) Handles btnConcluirPJ.Click
	      InserirPessoaJuridica()
	      FrmClientes.btnAtualizar.PerformClick()
	      If RetornoCNPJ = True Then
		    Try
			  Threading.Thread.Sleep(2000)
			  Dim hr As OleDbDataReader = GetDR_semRead("SELECT Código FROM tbClientes WHERE CPF=" & Empresa.Cnpj)

			  hr.Read()

			  InstrucaoDireta("INSERT INTO tbEnd (CodEnd,Logradouro,EndNumero,Bairro,Cidade,UF,Complemento,CEP,Tipo)" & "Values (""" & hr.Item("Código") &
			  """,""" & Empresa.Endereco & """,""" & Empresa.Numero & """,""" & Empresa.Bairro & """,""" & Empresa.Cidade & """,""" & Empresa.UF &
			  """,""" & Empresa.Complemento & """,""" & Empresa.CEP & """,""" & "Comercial" & """)")

			  InstrucaoDireta("INSERT INTO tbContato (ContatoID,DDD,Numero,Tipo)" & "VALUES(""" & hr.Item("Código") & """,""" & 0 & """,""" & Empresa.Telefones & """,""" & "Comercial" & """)")

			  Threading.Thread.Sleep(2000)
			  FrmClientes.btnAtualizar.PerformClick()
		    Catch
			  MsgBox("Não foi possivel vincular dados (endereço e contato) ao clinete, por favor realize o procedimento manualmente")
		    End Try
	      End If



        End Sub

        Private Sub btnConcluirCadCol_Click(sender As Object, e As EventArgs) Handles btnConcluirCadCol.Click
	      InserirPessoaColaborador()
	      FrmClientes.btnAtualizar.PerformClick()
        End Sub

        Public Sub LimparTextColaborador()
	      txtColNome.Text = ""
	      txtColSobrenome.Text = ""
	      txtColNacionalidade.Text = ""
	      txtColNaturalidade.Text = ""
	      txtColCPF.Text = ""
	      txtColRG.Text = ""
	      txtColCargo.Text = ""
	      txtColSetor.Text = ""
	      txtColCNH.Text = ""
	      txtColTituloEleitor.Text = ""
	      txtColCTPS.Text = ""
	      txtColValorRemuneracao.Text = ""
	      cboColPeriodoTrabalho.Text = ""
	      txtColEstadoCivil.Text = ""
	      txtColtDataNasc.Value = Today.ToShortDateString
	      txtColDataAdmissao.Value = Today.ToShortDateString
	      PicColaborador.Image = My.Resources.Usuarios
        End Sub

        Private Sub txtPJRazaoSocial_Click(sender As Object, e As EventArgs) Handles txtPJRazaoSocial.Enter
	      AnimarText(pbRazaoSocial)
        End Sub

        Private Sub txtPJRazaoSocial_LostFocus(sender As Object, e As EventArgs) Handles txtPJRazaoSocial.LostFocus
	      pbRazaoSocial.Value = 0
        End Sub

        Private Sub txtPJNomeFantasia_Click(sender As Object, e As EventArgs) Handles txtPJNomeFantasia.Enter
	      AnimarText(pbPJNomeFantasia)
        End Sub

        Private Sub txtPJNomeFantasia_LostFocus(sender As Object, e As EventArgs) Handles txtPJNomeFantasia.LostFocus
	      pbPJNomeFantasia.Value = 0
        End Sub

        Private Sub txtPJIE_Click(sender As Object, e As EventArgs) Handles txtPJIE.Enter
	      AnimarText(pbPJIE)
        End Sub

        Private Sub txtPJIE_LostFocus(sender As Object, e As EventArgs) Handles txtPJIE.LostFocus
	      pbPJIE.Value = 0
        End Sub

        Private Sub txtPJIM_Click(sender As Object, e As EventArgs) Handles txtPJIM.Enter
	      AnimarText(pbPJIM)
        End Sub

        Private Sub txtPJIM_LostFocus(sender As Object, e As EventArgs) Handles txtPJIM.LostFocus
	      pbPJIM.Value = 0
        End Sub

        Private Sub txtPJCNPJ_Click(sender As Object, e As EventArgs) Handles txtPJCNPJ.Enter
	      AnimarText(pbPJCNPJ)
        End Sub

        Private Sub txtPJCNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtPJCNPJ.LostFocus
	      pbPJCNPJ.Value = 0
	      If IsNumeric(txtPJCNPJ.Text) = True Then
		    CadastradoCPF(txtPJCNPJ.Text)
	      Else
		    txtPJCNPJ.Text = ""
	      End If
        End Sub

        Private Sub txtPFNome_Click(sender As Object, e As EventArgs) Handles txtPFNome.Enter
	      AnimarText(pbPFNome)
        End Sub

        Private Sub txtPFNome_LostFocus(sender As Object, e As EventArgs) Handles txtPFNome.LostFocus
	      pbPFNome.Value = 0
	      txtPFNome.Text = txtPFNome.Text.ToUpper
        End Sub

        Private Sub txtPFSobrenome_Click(sender As Object, e As EventArgs) Handles txtPFSobrenome.Enter
	      AnimarText(pbPFSobrenome)
        End Sub

        Private Sub txtPFSobrenome_LostFocus(sender As Object, e As EventArgs) Handles txtPFSobrenome.LostFocus
	      pbPFSobrenome.Value = 0
	      txtPFSobrenome.Text = txtPFSobrenome.Text.ToUpper
        End Sub

        Private Sub txtPFCPF_Click(sender As Object, e As EventArgs) Handles txtPFCPF.Enter
	      AnimarText(pbPFCFP)
        End Sub

        Private Sub txtPFCPF_LostFocus(sender As Object, e As EventArgs) Handles txtPFCPF.LostFocus
	      pbPFCFP.Value = 0
	      If IsNumeric(txtPFCPF.Text) = True Then
		    CadastradoCPF(CDbl(txtPFCPF.Text))
	      Else
		    txtPFCPF.Text = ""
	      End If
        End Sub

        Private Sub txtPFRG_Click(sender As Object, e As EventArgs) Handles txtPFRG.Enter
	      AnimarText(pbPFRG)
        End Sub

        Private Sub txtPFRG_LostFocus(sender As Object, e As EventArgs) Handles txtPFRG.LostFocus
	      pbPFRG.Value = 0
        End Sub

        Private Sub txtColNome_Click(sender As Object, e As EventArgs) Handles txtColNome.Enter
	      AnimarText(pbColNome)
        End Sub

        Private Sub txtColNome_LostFocus(sender As Object, e As EventArgs) Handles txtColNome.LostFocus
	      pbColNome.Value = 0
	      txtColNome.Text = txtColNome.Text.ToUpper
        End Sub

        Private Sub txtColSobrenome_Click(sender As Object, e As EventArgs) Handles txtColSobrenome.Enter
	      AnimarText(pbColSobrenome)
        End Sub

        Private Sub txtColSobrenome_LostFocus(sender As Object, e As EventArgs) Handles txtColSobrenome.LostFocus
	      pbColSobrenome.Value = 0
	      txtColSobrenome.Text = txtColSobrenome.Text.ToUpper
        End Sub

        Private Sub txtColNacionalidade_Click(sender As Object, e As EventArgs) Handles txtColNacionalidade.Enter
	      AnimarText(pbColNacionalidade)
        End Sub

        Private Sub txtColNacionalidade_LostFocus(sender As Object, e As EventArgs) Handles txtColNacionalidade.LostFocus
	      pbColNacionalidade.Value = 0
        End Sub

        Private Sub txtColNaturalidade_Click(sender As Object, e As EventArgs) Handles txtColNaturalidade.Enter
	      AnimarText(pbColNaturalidade)
        End Sub

        Private Sub txtColNaturalidade_LostFocus(sender As Object, e As EventArgs) Handles txtColNaturalidade.LostFocus
	      pbColNaturalidade.Value = 0
        End Sub

        Private Sub txtColCPF_Click(sender As Object, e As EventArgs) Handles txtColCPF.Enter
	      AnimarText(pbColCPF)
        End Sub

        Private Sub txtColCPF_LostFocus(sender As Object, e As EventArgs) Handles txtColCPF.LostFocus
	      pbColCPF.Value = 0
	      If IsNumeric(txtColCPF.Text) = True Then
		    CadastradoCPF(txtColCPF.Text)
	      Else
		    SQL.Notificao("", "caracter invalido")
		    txtColCPF.Text = ""
	      End If
        End Sub

        Private Sub txtColRG_Click(sender As Object, e As EventArgs) Handles txtColRG.Enter
	      AnimarText(pbColRG)
        End Sub

        Private Sub txtColRG_LostFocus(sender As Object, e As EventArgs) Handles txtColRG.LostFocus
	      pbColRG.Value = 0
        End Sub

        Private Sub txtColCargo_Click(sender As Object, e As EventArgs) Handles txtColCargo.Enter
	      AnimarText(pbColCargo)
        End Sub

        Private Sub txtColCargo_LostFocus(sender As Object, e As EventArgs) Handles txtColCargo.LostFocus
	      pbColCargo.Value = 0
        End Sub

        Private Sub txtColSetor_Click(sender As Object, e As EventArgs) Handles txtColSetor.Enter
	      AnimarText(pbColSetor)
        End Sub

        Private Sub txtColSetor_LostFocus(sender As Object, e As EventArgs) Handles txtColSetor.LostFocus
	      pbColSetor.Value = 0
        End Sub

        Private Sub txtColCNH_Click(sender As Object, e As EventArgs) Handles txtColCNH.Enter
	      AnimarText(pbColCNH)
        End Sub

        Private Sub txtColCNH_LostFocus(sender As Object, e As EventArgs) Handles txtColCNH.LostFocus
	      pbColCNH.Value = 0
        End Sub

        Private Sub txtColTituloEleitor_Click(sender As Object, e As EventArgs) Handles txtColTituloEleitor.Enter
	      AnimarText(pbColTituloEleitor)
        End Sub

        Private Sub txtColTituloEleitor_LostFocus(sender As Object, e As EventArgs) Handles txtColTituloEleitor.LostFocus
	      pbColTituloEleitor.Value = 0
        End Sub

        Private Sub txtColCTPS_Click(sender As Object, e As EventArgs) Handles txtColCTPS.Enter
	      AnimarText(pbColCTPS)
        End Sub

        Private Sub txtColCTPS_LostFocus(sender As Object, e As EventArgs) Handles txtColCTPS.LostFocus
	      pbColCTPS.Value = 0
        End Sub

        Private Sub txtColValorRemuneracao_Click(sender As Object, e As EventArgs) Handles txtColValorRemuneracao.Enter
	      txtColValorRemuneracao.Text = ""
	      AnimarText(pbColValorRemuneracao)
        End Sub

        Private Sub txtColValorRemuneracao_LostFocus(sender As Object, e As EventArgs) Handles txtColValorRemuneracao.LostFocus
	      pbColValorRemuneracao.Value = 0
	      txtColValorRemuneracao.Text = Dinheiro(txtColValorRemuneracao.Text)
        End Sub

        Private Sub txtCap_LostFocus(sender As Object, e As EventArgs) Handles txtCap.LostFocus
	      txtCap.Text = txtCap.Text.ToUpper
        End Sub

        Public RetornoCNPJ As Boolean = False

        Private Sub btnConsultaCnpj_Click(sender As Object, e As EventArgs) Handles btnConsultaCnpj.Click

	      Try
		    If txtPJCNPJ.Text <> "" And txtCap.Text <> "" Then
			  Consulta(txtPJCNPJ.Text, txtCap.Text)
			  txtPJNomeFantasia.Text = Empresa.NomeFantasia
			  txtPJRazaoSocial.Text = Empresa.RazaoSocial
			  txtPJIE.Text = 0
			  txtPJIM.Text = 0
			  If Empresa.NomeFantasia <> "" Then
				RetornoCNPJ = True
			  Else
				RetornoCNPJ = False
			  End If
		    End If
	      Catch
		    MsgBox("possivel erro na busca")
	      End Try
        End Sub

        Private Sub btnAtualizarCap_Click(sender As Object, e As EventArgs) Handles btnAtualizarCap.Click
	      GetCaptcha(picCaptcha)
        End Sub

        Private Sub btnShowWBsintegra_Click(sender As Object, e As EventArgs)
	      frmNavSintegra.Show()
        End Sub

        Private Sub btnCadastrarColaborador_Click(sender As Object, e As EventArgs) Handles btnCadastrarColaborador.Click
	      Try
		    If CadastradoCPF(CDbl(txtPFCPF.Text)) = False Then
			  InserirPessoaColaborador()
		    Else
			  txtColCPF.Text = ""
		    End If
	      Catch
		    MsgBox("Não foi possivel concluir o cadastro")
	      End Try
        End Sub

        Private Sub btnCadastrarPJ_Click(sender As Object, e As EventArgs) Handles btnCadastrarPJ.Click
	      Try
		    If CadastradoCPF(CDbl(txtPJCNPJ.Text)) = False Then
			  InserirPessoaJuridica()
		    Else
			  txtPJCNPJ.Text = ""
		    End If
	      Catch
		    MsgBox("Não foi possivel concluir o cadastro")
	      End Try
        End Sub

        Private Sub btnCadastrarPF_Click(sender As Object, e As EventArgs) Handles btnCadastrarPF.Click
	      Try
		    If CadastradoCPF(CDbl(txtPFCPF.Text)) = False Then
			  InserirPessoaFisica()
		    Else
			  txtPFCPF.Text = 0
		    End If
	      Catch
		    MsgBox("Não foi possivel concluir o cadastro")
	      End Try
        End Sub

        Private Sub txtPFCPF_TextChanged(sender As Object, e As EventArgs) Handles txtPFCPF.TextChanged

        End Sub

        Public Function CadastradoCPF(NumeroCPF As Double)

	      Dim drCPF As OleDbDataReader = GetDR_semRead("SELECT Nome,Tipo,CPF FROM tbClientes WHERE CPF=" & NumeroCPF)
	      drCPF.Read()
	      If drCPF.HasRows = True Then
		    Dim result As DialogResult = MsgBox("*Este número de CPF ou CNPJ já está sendo usada por outro cadastro." & Chr(13) &
		    "Deseja excluir o cadastro anterior?" & Chr(13) & "Nome: " & drCPF(0).ToString & Chr(13) & "Tipo: " & drCPF(1), MsgBoxStyle.YesNo)
		    If result = DialogResult.Yes Then
			  Dim secResult As DialogResult = MsgBox("A operação não poderá ser desfeita." & Chr(13) & "Continuar?", MsgBoxStyle.YesNo)
			  If secResult = DialogResult.Yes Then
				InstrucaoDireta("DELETE FROM tbClientes WHERE CPF=" & NumeroCPF)
				SQL.Notificao("", "Cadastro excluido com sucesso")
			  End If
		    End If
		    Return True
	      Else
		    Return False
	      End If
        End Function


End Class