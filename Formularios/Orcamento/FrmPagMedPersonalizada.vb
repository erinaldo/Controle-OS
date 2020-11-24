Public Class FrmPagMedPersonalizada

    Private Sub FrmPagMedPersonalizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboDiaSemana.Items
            .Add("segunda-feira")
            .Add("terça-feira")
            .Add("quarta-feira")
            .Add("quinta-feira")
            .Add("sexta-feira")
            .Add("sábado")
            .Add("domingo")
        End With
    End Sub

    Private Sub btnDiaSemana_Click(sender As Object, e As EventArgs) Handles btnDiaSemana.Click
        Dim DataInicial As Date = Today.ToShortDateString
        Dim NumeroSemana As Integer = DataInicial.DayOfWeek + 1
        Dim NomeSemana As String = WeekdayName(NumeroSemana)
        Dim DataInicialProc As Date = Today.ToShortDateString
        Dim NumeroSemanaProc As Integer = DataInicialProc.DayOfWeek + 1
        Dim NomeSemanaProc As String = WeekdayName(NumeroSemanaProc)
        '\\DIA DA SEMANA
        If rdDiaSemana.Checked = True Then
            Do Until NomeSemanaProc = cboDiaSemana.Text
                If DataInicial.Month < DataInicialProc.Month Then
                End If
                DataInicialProc = DataInicialProc.AddDays(+1)
                NumeroSemanaProc = DataInicialProc.DayOfWeek + 1
                NomeSemanaProc = WeekdayName(NumeroSemanaProc)
            Loop
            DataInicialProc = DataInicialProc.AddDays(CInt(txtDiasAposFechamento.Text))
            NumeroSemanaProc = DataInicialProc.DayOfWeek + 1
            NomeSemanaProc = WeekdayName(NumeroSemanaProc)
        End If
        Dim var1 As Integer
        '\\DIA DO MES
        If rdDiaMes.Checked = True Then
            '\\COM UMA VARIAVEL NO MES
            var1 = cboDiaEsp1.Text
            Do Until cboDiaEsp1.Text = DataInicialProc.Day

                DataInicialProc = DataInicialProc.AddDays(+1)
                NumeroSemanaProc = DataInicialProc.DayOfWeek + 1
                NomeSemanaProc = WeekdayName(NumeroSemanaProc)
            Loop
            If IsNumeric(txtDiaMesApos.Text) = True Then
                DataInicialProc = DataInicialProc.AddDays(CInt(txtDiaMesApos.Text))
            End If
            NumeroSemanaProc = DataInicialProc.DayOfWeek + 1
            NomeSemanaProc = WeekdayName(NumeroSemanaProc)
        End If
        MsgBox("A proxima data de recebimento será na data: " & DataInicialProc & " (Seguindo a regras atuais)")

    End Sub

    Private Sub rdDiaSemana_Click(sender As Object, e As EventArgs) Handles rdDiaSemana.Click
        rdDiaMes.Checked = False
    End Sub

    Private Sub btnSelCliente_Click(sender As Object, e As EventArgs) Handles btnSelCliente.Click
        FrmClientes.btnConfirmar.Visible = True
        FrmClientes.ShowDialog()
        txtCodCliente.Text = MedicaoPersonalizado.ClienteID
        txtCPF.Text = MedicaoPersonalizado.CPF
        txtIE.Text = MedicaoPersonalizado.InscricaoEstadual
        txtNomeFantasia.Text = MedicaoPersonalizado.NomeFatansia
        txtRazaoSocial.Text = MedicaoPersonalizado.RazaoSocial
    End Sub

End Class