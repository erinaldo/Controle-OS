Imports System.Data.OleDb

Public Class FrmAddLembrete
	Private Sub FrmAddLembrete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtUsuario.Text = Usuario.Nome
		GetDataCombo(cboVeiculo, "SELECT Nome FROM tbVeiculo")
		cboVeiculo.Items.Add("Não Definir")
		txtClienteID.Text = FrmPDV.txtCodCliente.Text
		txtCliente.Text = FrmPDV.txtCliente.Text
		txtPedidoID.Text = FrmPDV.lblNumeroPedido.Text
		txtRua.Text = FrmPDV.txtLogradouro.Text
		txtNumero.Text = FrmPDV.txtEndNumero.Text
		txtBairro.Text = FrmPDV.txtBairro.Text
		txtUF.Text = FrmPDV.txtBairro.Text
		txtComplemento.Text = FrmPDV.txtComplemento.Text
		txtEndID.Text = FrmPDV.txtEndID.Text
	End Sub
	Private Sub cboVeiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVeiculo.SelectedIndexChanged
	      If cboVeiculo.Text <> "Não Definir" Then
		    If cboVeiculo.Text <> "" Then
			  conexao1("SELECT * FROM tbVeiculo WHERE Nome='" & cboVeiculo.Text & "'")
			  bdr1.Read()
			  txtPlaca.Text = bdr1.Item("Placa")
			  txtVeiculoID.Text = bdr1.Item("VeiculoID")
			  Desconexao1()
		    End If
	      Else
		    txtPlaca.Text = "N/A"
		    txtVeiculoID.Text = 0
	      End If
        End Sub

	Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
		SalvarLembrete()
	End Sub
	Public Sub SalvarLembrete()
		If txtVeiculoID.Text = "" Then
			txtVeiculoID.Text = 0
		End If
		If cboStatus.Text = "" Then
			cboStatus.Text = "Pendente"
		End If

		Dim Lemb As New Lembrete
			With Lemb
			.ClienteID = txtClienteID.Text
			.Data = dtdata.Value
			.Descricao = "Entrega"
			.UsuarioID = Usuario.Identificacao
			.EnderecoID = txtEndID.Text
			.PedidoID = txtPedidoID.Text
			.VeiculoID = txtVeiculoID.Text
			.Status = cboStatus.Text
			.Hora = dtHora.Value.ToString("HH:mm")
		End With

		conexao1("INSERT INTO tbAgendaEntregas(ClienteID,UsuarioID,EnderecoID,PedidoID,VeiculoID,DataPedido,Status,Atividade,HoraMarcada)" &
		"VALUES(""" & Lemb.ClienteID & """,""" & Lemb.UsuarioID & """,""" & Lemb.EnderecoID & """,""" & Lemb.PedidoID & """,""" &
		Lemb.VeiculoID & """,""" & Lemb.Data & """,""" & Lemb.Status & """,""" & Lemb.Descricao & """,""" & Lemb.Hora & """)")

		SQL.Notificao("", "Agendamento realizado com sucesso")
		Me.Close()
	End Sub

	Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

	End Sub
End Class