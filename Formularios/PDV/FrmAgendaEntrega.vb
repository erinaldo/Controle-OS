Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb

Public Class FrmAgendaEntrega
	Private Sub FrmAgendaEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PopularCalendario(0, Today.ToShortDateString)
		SelecionData()
		cboMotorista.Items.Clear()
		GetDataCombo(cboMotorista, "SELECT Nome FROM tbClientes WHERE CNH>0")
	End Sub

	'LIMPAR A INFORMAÇÕES DAS LISTVIEW's
	Public Sub LimparCalendario()
		l1.Clear()
		l2.Clear()
		l3.Clear()
		l4.Clear()
		l5.Clear()
		l6.Clear()
		l7.Clear()
	End Sub

	'ADIANTAR OU ATRASAR AS DATAS DA SEMANA ATRAVES DO CONTROLE DESLIZANTE
	Private Sub tbData_Scroll(sender As Object, e As EventArgs) Handles tbData.Scroll
		LimparCalendario()
		PopularCalendario(tbData.Value - 250, Today.ToShortDateString)
		SelecionData()
	End Sub

	'CARREGAR OS DADOS DO BANCO DE DADOS
	Public Sub PopularCalendario(AddDays As Integer, DataInicio As Date)
		LimparCalendario()
		Dim data1, data2, data3, data4, data5, data6, data7 As Date  'DECLARAÇÃO DAS DATAS DA SEMANA
		data1 = DataInicio.AddDays(AddDays)
		data2 = data1.AddDays(1)
		data3 = data1.AddDays(2)
		data4 = data1.AddDays(3)
		data5 = data1.AddDays(4)
		data6 = data1.AddDays(5)
		data7 = data1.AddDays(6)
		Label1.Text = data1 'LABEL's COM A DATA DO RESPECTIVO
		Label2.Text = data2
		Label3.Text = data3
		Label4.Text = data4
		Label5.Text = data5
		Label6.Text = data6
		Label7.Text = data7
		sem1.Text = WeekdayName(Weekday(data1)) 'OBTER OS NOMES DA SEMANA ATRAVES DA DATA
		sem2.Text = WeekdayName(Weekday(data2))
		sem3.Text = WeekdayName(Weekday(data3))
		sem4.Text = WeekdayName(Weekday(data4))
		sem5.Text = WeekdayName(Weekday(data5))
		sem6.Text = WeekdayName(Weekday(data6))
		sem7.Text = WeekdayName(Weekday(data7))
		conexao1("SELECT * FROM tbAgendaEntregas ORDER BY HoraMarcada DESC") 'RECUPERAR AS INFORMAÇÕES DO BANCO DE DADOS
		Dim list As New List(Of Object)
		Dim subevento As New ListViewItem
		Dim QuantLembretes As Integer

		'LOOP RESPONSÁVEL POR PREENCHER OS LISTVIEW's
		Do While bdr1.Read
			Dim evento As New Lembrete
			With evento
				.Descricao = bdr1("Atividade")
				QuantLembretes += 1
				.Data = bdr1("DataPedido")
				.Hora = bdr1("HoraMarcada")
				.EntregaID = bdr1("EntregaID")
				.UsuarioID = bdr1("UsuarioID")
			End With
			With subevento
				.SubItems.Add(evento.EntregaID)
			End With
			list.Add(evento)
		Loop

		'DISTRIBUIÇÃO DOS LEMBRETES DE ACORDO COM A DATA ORDENADO POR HORARIO
		Dim L As Integer = list.Count
		While L > 0
			L -= 1
			Dim Evento As Lembrete = list(L)
			If Label1.Text = Evento.Data Then
				l1.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm"), 1).SubItems.Add(Evento.EntregaID)
			End If

			If Label2.Text = Evento.Data Then
				l2.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If

			If Label3.Text = Evento.Data Then
				l3.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If

			If Label4.Text = Evento.Data Then
				l4.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If

			If Label5.Text = Evento.Data Then
				l5.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If

			If Label6.Text = Evento.Data Then
				l6.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If

			If Label7.Text = Evento.Data Then
				l7.Items.Add(Evento.Descricao & " às " & Evento.Hora.ToString("HH:mm")).SubItems.Add(Evento.EntregaID)
			End If
		End While
		Desconexao1()
	End Sub

	'RECUPERAR ATRAVES DO ID, INFORMAÇÕES SOBRE O LOCAL DE ENTREGA, VEICULO A SER UTILIZADO E INFORMAÇÕES DO CLIENTE
	Public Function PreencherTxt(EntregaID As Double)

		'INFO ENTREGA
		Dim dr1 As OleDbDataReader = GetDR_semRead("SELECT * FROM tbAgendaEntregas WHERE EntregaID=" & EntregaID) 'INFO ENTREGA E STATUS
		dr1.Read()
		txtEntregaID.Text = dr1("EntregaID")
		txtHora.Text = dr1("HoraMarcada")
		txtData.Text = dr1("DataPedido")
		txtStatus.Text = dr1("Status")
		txtAtividade.Text = dr1("Atividade")
		txtUsuarioID.Text = dr1("UsuarioID")
		txtVeiculoID.Text = dr1("VeiculoID")
		txtPedidoID.Text = dr1("PedidoID")
		lblStatus.Text = dr1("Status")

		'INFO VEICULO
		Dim dr2 As OleDbDataReader = GetDR_semRead("SELECT * FROM tbVeiculo WHERE VeiculoID=" & bdr1("VeiculoID"))
		dr2.Read()
		txtVeiculo.Text = dr2("Nome")
		txtPlaca.Text = dr2("Placa")

		'INFO CLIENTE
		Dim dr3 As OleDbDataReader = GetDR_semRead("SELECT * FROM tbClientes WHERE Código=" & dr1("ClienteID"))
		dr3.Read()
		txtNomeCliente.Text = dr3("Nome") & " " & dr3("Sobrenome")


	End Function

	'FORMATAÇÃO DA HORA 
	Private Sub dgvAgenda_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
		If (e.ColumnIndex = 0) Then
			e.Value = String.Format("{0:t}", e.Value)
			e.FormattingApplied = True
		End If
	End Sub
	Private Sub btnFechar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	'AVANÇAR UM DIA NA SEMANA
	Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
		tbData.Value += 1
		PopularCalendario(tbData.Value - 50, Today.ToShortDateString)
		SelecionData()
		Label1.Text = mcRef.SelectionRange.Start
		Label7.Text = mcRef.SelectionRange.End
	End Sub

	'VOLTAR UM DIA NA SEMANA
	Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
		tbData.Value -= 1
		PopularCalendario(tbData.Value - 50, Today.ToShortDateString)
		SelecionData()
		Label1.Text = mcRef.SelectionRange.Start
		Label7.Text = mcRef.SelectionRange.End
	End Sub
	Private Sub l1_MouseClick(sender As Object, e As MouseEventArgs) Handles l1.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l1.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l1"
	End Sub
	Private Sub l2_MouseClick(sender As Object, e As MouseEventArgs) Handles l2.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l2.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l2"
	End Sub
	Private Sub l3_MouseClick(sender As Object, e As MouseEventArgs) Handles l3.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l3.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l3"
	End Sub
	Private Sub l4_MouseClick(sender As Object, e As MouseEventArgs) Handles l4.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l4.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l4"
	End Sub
	Private Sub l5_MouseClick(sender As Object, e As MouseEventArgs) Handles l5.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l5.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l5"
	End Sub
	Private Sub l6_MouseClick(sender As Object, e As MouseEventArgs) Handles l6.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l6.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l6"
	End Sub
	Private Sub l7_MouseClick(sender As Object, e As MouseEventArgs) Handles l7.MouseClick 'RECUPERAR INFORMAÇÕES DO LEMBRETE DE ENTREGA
		On Error Resume Next
		PreencherTxt(l7.SelectedItems(0).SubItems(1).Text)
		lstLastClick = "l7"
	End Sub
	'OBTER OS PEDIDOS DA ENTREGA SELECIONADA
	Private Sub btnShowItens_Click(sender As Object, e As EventArgs) Handles btnShowItens.Click
		dgvItensPedido.Rows.Clear()
		dgvItensPedido.Columns.Clear()
		If txtPedidoID.Text <> "" Then
			Dim dr As OleDbDataReader = GetDR_semRead("SELECT * FROM tbProdutoVendaPDV WHERE PedidoID=" & CDbl(txtPedidoID.Text))
			dgvItensPedido.Columns.Add("Item", "Item/Quant.")
			While dr.Read
				dgvItensPedido.Rows.Add("Quant.:" & dr("Quantidade") & "-" & dr("Produto"))
			End While
			pnItens.Visible = True
			dgvItensPedido.Visible = True
		End If
	End Sub

	'BTN PARA EXIBIR A JANELA DE PRODUTOS DO PEDIDO
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		pnItens.Visible = False
		dgvItensPedido.Visible = False
	End Sub

	Public lstLastClick As String

	'DEFINIR QUAL FOI O ULTIMO LISTVIEW's QUE FOI CLICADO
	Private Sub btnExcluirAgendamento_Click(sender As Object, e As EventArgs) Handles btnExcluirAgendamento.Click
		Select Case lstLastClick
			Case = "l1"
				ApagarLembrete(l1)
			Case = "l2"
				ApagarLembrete(l2)
			Case = "l3"
				ApagarLembrete(l3)
			Case = "l4"
				ApagarLembrete(l4)
			Case = "l5"
				ApagarLembrete(l5)
			Case = "l6"
				ApagarLembrete(l6)
			Case = "l7"
				ApagarLembrete(l7)
			Case Else
		End Select
	End Sub

	'EXCLUIR O LEMBRETE DO ULTIMO LISTVIEW SELECIONADO
	Public Sub ApagarLembrete(ByRef L As ListView)
		pbCalen.Value = 10
		Select Case L.SelectedIndices.Count
			Case = 0
				SQL.Notificao("", "Nenhum lembrete foi selecionado")
			Case = 1
				pbCalen.Value = 30
				InstrucaoDireta("DELETE * FROM tbAgendaEntregas WHERE EntregaID=" & CDbl(L.SelectedItems(0).SubItems(1).Text))
				pbCalen.Value = 50
				PopularCalendario(0, CDate(Label1.Text))
				pbCalen.Value = 60
			Case Else
		End Select
		pbCalen.Value = 100
	End Sub

	'EVENTO AUTOMATICO DE ATUALIZAÇÃO DO CALENDARIO
	Private Sub tmPopularCalendario_Tick(sender As Object, e As EventArgs) Handles tmPopularCalendario.Tick
		pbCalen.Value = 80
		PopularCalendario(0, CDate(Label1.Text))
		pbCalen.Value = 0
	End Sub

	'DEFINIR PRIMEIRO DIA DA SEMANA DE ACORDO COM A DATA SELECIONADA NO MONTHCALENDAR
	Private Sub mcRef_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles mcRef.DateChanged
		Label1.Text = mcRef.SelectionStart.ToShortDateString
		PopularCalendario(0, CDate(Label1.Text))
		SelecionData()
		If mcRef.SelectionStart.ToShortDateString = Today.ToShortDateString Then
			tbData.Value = tbData.Maximum / 2
		End If
	End Sub

	'REALÇA A COR DA SEMANA APRESENTADA NO PAINEL PRINCIPAL
	Public Sub SelecionData()
		mcRef.SelectionStart = Label1.Text
		mcRef.SelectionEnd = Label7.Text
	End Sub
	Private Sub btnAddLembrete_Click(sender As Object, e As EventArgs) Handles btnAddLembrete.Click
		FrmAddLembrete.ShowDialog()
	End Sub
	Private Sub btnRegistrarSaida_Click(sender As Object, e As EventArgs) Handles btnRegistrarSaida.Click
		If txtPedidoID.Text <> "" Then
			InstrucaoDireta("UPDATE tbAgendaEntregas SET HoraSaida=""" & TimeOfDay.ToString("HH: mm") & """ WHERE EntregaID=" & txtEntregaID.Text)
		End If
	End Sub
	Private Sub btnRegistrarVolta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVolta.Click
		If txtPedidoID.Text <> "" Then
			InstrucaoDireta("UPDATE tbAgendaEntregas SET HoraVolta=""" & TimeOfDay.ToString("HH: mm") & """ WHERE EntregaID=" & txtEntregaID.Text)
		End If
	End Sub
End Class