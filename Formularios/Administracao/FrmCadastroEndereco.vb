Public Class FrmCadastroEndereco

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadastroPeloFrm.Click

        '\\CADASTRO SENDO REALIZADO PELO CAMINHO (HOME,CLIENTE,CADASTRO)
        SQL.CadastroEnderecoCliente("INSERT INTO tbEnd (CodEnd, Logradouro, EndNumero, Bairro, Cidade, UF, Complemento, Tipo)" & "VALUES (""" & FrmClientes.txtCodCliente.Text &
                                    """,""" & txtLogradouro.Text & """,""" & txtNumero.Text & """,""" & txtBairro.Text & """,""" & txtCidade.Text &
                                    """,""" & cboUF.Text & """,""" & txtComplemento.Text & """,""" & cboTipo.Text & """)")
        SQL.Comando()
    End Sub

    Private Sub FrmCadastroEndereco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipo.Items.Clear()
        With cboTipo.Items
            .Add("COBRANÇA")
            .Add("PARTICULAR")
            .Add("ENTREGA")
        End With
    End Sub

    Private Sub btnCadastroPeloDialogo_Click(sender As Object, e As EventArgs) Handles btnCadastroPeloDialogo.Click

        '\\CADASTRO SENDO REALIZADO PELO DIALOGO DO CADASTRO DE OS
        If cboTipo.Text = "" Then
            lblAvisoTipo.Visible = True
            cboTipo.BackColor = Color.Red
        Else
            lblAvisoTipo.Visible = False
            cboTipo.BackColor = Color.White
        End If
        If cboUF.Text = "" Then
            lblavisoUF.Visible = True
            cboUF.BackColor = Color.Red
        Else
            lblavisoUF.Visible = False
            cboUF.BackColor = Color.White
        End If
        If txtCidade.Text = "" Then
            lblAvisoCidade.Visible = True
            txtCidade.BackColor = Color.Red
        Else
            lblAvisoCidade.Visible = False
            txtCidade.BackColor = Color.White
        End If
        If txtBairro.Text = "" Then
            lblAvisoBairro.Visible = True
            txtBairro.BackColor = Color.Red
        Else
            lblAvisoBairro.Visible = False
            txtBairro.BackColor = Color.White
        End If
        If txtNumero.Text = "" Then
            lblAvisoNumero.Visible = True
            txtNumero.BackColor = Color.Red
        Else
            lblAvisoNumero.Visible = False
            txtNumero.BackColor = Color.White
        End If
        If txtLogradouro.Text = "" Then
            lblAvisoLogradouro.Visible = True
            txtLogradouro.BackColor = Color.Red
        Else
            lblAvisoLogradouro.Visible = False
            txtLogradouro.BackColor = Color.White
        End If
        If txtLogradouro.Text = "" Or txtNumero.Text = "" Or txtBairro.Text = "" Or txtCidade.Text = "" Or cboUF.Text = "" Or cboTipo.Text = "" Then
        Else
            SQL.CadastroEnderecoCliente("INSERT INTO tbEnd (CodEnd, Logradouro, EndNumero, Bairro, Cidade, UF, Complemento, Tipo)" & "VALUES (""" & FrmCadastroOS.txtCodCliente.Text &
                            """,""" & txtLogradouro.Text & """,""" & txtNumero.Text & """,""" & txtBairro.Text & """,""" & txtCidade.Text &
                            """,""" & cboUF.Text & """,""" & txtComplemento.Text & """,""" & cboTipo.Text & """)")
            SQL.Comando()
            '\\ADICIONAR O CAMNDO SQL.COMANDO APOS O TESTE
            SQL.Notificao("NOVA LITORAL GESSO", "ENDEREÇO CADASTRADO COM SUCESSO")
            Me.Close()
        End If
LINE1:
        FrmCadastroOS.TbOSTableAdapter.Fill(FrmCadastroOS.SistemaGEDataSet1.tbOS)
        FrmCadastroOS.TbEndTableAdapter.Fill(FrmCadastroOS.SistemaGEDataSet.tbEnd)
        FrmCadastroOS.TbClientesTableAdapter.Fill(FrmCadastroOS.SistemaGEDataSet.tbClientes)
        FrmCadastroOS.TbClientesTableAdapter.Fill(FrmCadastroOS.SistemaGEDataSet.tbClientes)
        FrmCadastroOS.txtEndRua.Text = Me.txtLogradouro.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtLogradouro_TextChanged(sender As Object, e As EventArgs) Handles txtLogradouro.TextChanged

    End Sub

    Private Sub txtLogradouro_Click(sender As Object, e As EventArgs) Handles txtLogradouro.Click
        lblAvisoLogradouro.Visible = False
        txtLogradouro.BackColor = Color.White
    End Sub

    Private Sub txtNumero_Click(sender As Object, e As EventArgs)
        lblAvisoNumero.Visible = False
        txtNumero.BackColor = Color.White
    End Sub

    Private Sub txtBairro_TextChanged(sender As Object, e As EventArgs) Handles txtBairro.TextChanged

    End Sub

    Private Sub txtBairro_Click(sender As Object, e As EventArgs) Handles txtBairro.Click
        lblAvisoBairro.Visible = False
        txtBairro.BackColor = Color.White
    End Sub

    Private Sub cboUF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUF.SelectedIndexChanged

    End Sub

    Private Sub cboUF_Click(sender As Object, e As EventArgs) Handles cboUF.Click
        lblavisoUF.Visible = False
        cboUF.BackColor = Color.White
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

    End Sub

    Private Sub cboTipo_Click(sender As Object, e As EventArgs) Handles cboTipo.Click
        lblAvisoTipo.Visible = False
        cboTipo.BackColor = Color.White
    End Sub

    Private Sub txtCidade_Click(sender As Object, e As EventArgs) Handles txtCidade.Click
        lblAvisoCidade.Visible = False
        txtCidade.BackColor = Color.White
    End Sub

    Private Sub btnCadastroPeloPDV_Click(sender As Object, e As EventArgs) Handles btnCadastroPeloPDV.Click
        lSQL = "INSERT INTO tbEnd (CodEnd, Logradouro, EndNumero, Bairro, Cidade, UF, Complemento, Tipo)" & "VALUES (""" & FrmEnderecoEntrega.txtEntregaID.Text &
                            """,""" & txtLogradouro.Text & """,""" & txtNumero.Text & """,""" & txtBairro.Text & """,""" & txtCidade.Text &
                            """,""" & cboUF.Text & """,""" & txtComplemento.Text & """,""" & cboTipo.Text & """)"
        SQL.Comando()
        FrmEnderecoEntrega.lblDescricao.Text = "Endereços relacionados ao cliente: " & FrmPDV.txtCliente.Text
        SQL.Notificao("", "CADASTRO CONCLUIDO COM SUCESSO")
        FrmEnderecoEntrega.TbEndTableAdapter.FillByEndID(FrmEnderecoEntrega.DataPdv.tbEnd, New System.Nullable(Of Integer)(CType(FrmPDV.txtCodCliente.Text, Integer)))
        Me.Close()
    End Sub

End Class