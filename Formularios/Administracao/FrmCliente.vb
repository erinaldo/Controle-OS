Imports System.Data.OleDb
Imports System.IO

Public Class FrmClientes

        Public ClienteID As Double

        Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load '\\EVENTOS NO "LOAD"
                Progresso(15)
                CarregarTables()
                Progresso(50)
                TableEnd(ClienteID)
                TableCliente()
                Progresso(80)
                With cboTipoContato.Items
                        .Add("RESIDENCIAL")
                        .Add("COMERCIAL")
                        .Add("PARTICULAR")
                End With
                With cboTipo.Items
                        .Add("COBRANÇA")
                        .Add("PARTICULAR")
                        .Add("ENTREGA")
                End With
                Progresso(100)
                'CARREGAR SILGAS DOS ESTADOS
                With cboUF.Items
                        .Add("SP")
                        .Add("AC")
                        .Add("AL")
                        .Add("AP")
                        .Add("AM")
                        .Add("BA")
                        .Add("CE")
                        .Add("DF")
                        .Add("ES")
                        .Add("GO")
                        .Add("MA")
                        .Add("MT")
                        .Add("MS")
                        .Add("MG")
                        .Add("PA")
                        .Add("PB")
                        .Add("PR")
                        .Add("PE")
                        .Add("PI")
                        .Add("RJ")
                        .Add("RN")
                        .Add("RS")
                        .Add("RO")
                        .Add("RR")
                        .Add("SC")
                        .Add("SE")
                        .Add("TO")
                End With
        End Sub

        Public Sub CarregarTables()
                Me.TbEndTableAdapter.Fill(Me.SistemaGEDataSet.tbEnd)
                Me.TbContatoTableAdapter.Fill(Me.SistemaGEDataSet.tbContato)
                Me.TbOSTableAdapter.Fill(Me.SistemaGEDataSet.tbOS)
        End Sub

        Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
                Me.Close()
        End Sub

        Private Sub btnAddRecebimento_Click(sender As Object, e As EventArgs) Handles btnAddRecebimento.Click '\\ABRE UM FORMULÁRIO PARA ADICIONAR UM NOVO RECEBIMENTO
                FrmAdicionarCliente.ShowDialog()
                WindowState = System.Windows.Forms.FormWindowState.Maximized
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '\\INSERI UM NOVO ENDEREÇO VINCULADO AO CLIENTE SELECIONADO NO GRIDVIEW
                If txtCodCliente.Text <> "" Then
                        If IsNumeric(txtNumero.Text) = True Then
                                If txtCodEnd.Text = "" Then
                                        Progresso(10)
                                        lSQL = "INSERT INTO tbEnd (CodEnd,Logradouro,EndNumero,Bairro,Cidade,UF,Complemento,Tipo)" & "VALUES (""" & txtCodCliente.Text & """,""" & txtLogradouro.Text & """,""" & txtNumero.Text & """,""" & txtBairro.Text &
                                                        """,""" & txtCidade.Text & """,""" & cboUF.Text & """,""" & txtComplemento.Text & """,""" & cboTipo.Text & """)"
                                        SQL.Comando()
                                        Progresso(50)
                                        SQL.Notificao("NOVA LITORAL GESSO", "ENDEREÇO ADICIONADO COM SUCESSO")
                                        'Me.TbEndTableAdapter.Fill(Me.SistemaGEDataSet.tbEnd)
                                        TableEnd(ClienteID)
                                Else
                                        txtLogradouro.Text = ""
                                        txtNumero.Text = ""
                                        txtBairro.Text = ""
                                        txtCidade.Text = ""
                                        cboUF.Text = ""
                                        txtComplemento.Text = ""
                                        cboTipo.Text = ""
                                        txtCodEnd.Text = ""
                                        MsgBox("Preencha os campos e click no botão (ADICIONAR ENDEREÇO)")
                                End If
                        Else
                                SQL.Notificao("", "O campo (Numero) deve ser um número")
                        End If
                Else
                        SQL.Notificao("", "Nenhum cliente foi selecionado")
                End If
                Progresso(100)
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditarEndereco.Click '\\EDITA INFORMAÇÕES SOBRE O ENDEREÇO VINCULADO AO CLINETE SELECIONADO NO GRIDVIEW
                Progresso(10)
                If txtCodEnd.Text <> "" Then
                        lSQL = "UPDATE tbEnd SET Logradouro=""" & txtLogradouro.Text & """,EndNumero=""" & txtNumero.Text & """,Bairro=""" & txtBairro.Text & """,Cidade=""" & txtCidade.Text &
                                """,UF=""" & cboUF.Text & """,Complemento=""" & txtComplemento.Text & """,Tipo=""" & cboTipo.Text & """ WHERE ID=" & txtCodEnd.Text
                        SQL.Comando()
                        SQL.Notificao("NOVA LITORAL GESSO", "ENDEREÇO ATUALIZADO COM SUCESSO")
                        Me.TbEndTableAdapter.Fill(Me.SistemaGEDataSet.tbEnd)
                        Progresso(40)
                        CarregarTables()
                        Progresso(60)
                Else
                        txtLogradouro.Text = ""
                        txtNumero.Text = ""
                        cboTipo.Text = ""
                        txtBairro.Text = ""
                        txtCidade.Text = ""
                        cboUF.Text = ""
                        txtComplemento.Text = ""
                        txtCodEnd.Text = ""
                        MsgBox("Preencha os campos e click no botão (ADICIONAR ENDEREÇO)")
                End If
                TableEnd(ClienteID)
                Progresso(100)
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '\\DELETA ENDEREÇOS VINCULADOS AO CLIENTE SELECIONADO NO GRIDVIEW
                Progresso(10)
                Dim Respo As DialogResult = MsgBox("Deseja excluir o endereço?", vbYesNo, "AIO")
                If Respo = DialogResult.Yes Then
                        Progresso(30)
                        lSQL = "DELETE FROM tbEnd WHERE ID=" & txtCodEnd.Text
                        SQL.Comando()
                        SQL.Notificao("NOVA LITORAL GESSO", "ENDEREÇO EXCLUIDO COM SUCESSO")
                        Progresso(60)
                        Me.TbEndTableAdapter.Fill(Me.SistemaGEDataSet.tbEnd)
                        CarregarTables()
                        Progresso(80)
                Else
                        SQL.Notificao("", "Operação cancelada com sucesso")
                End If
                TableEnd(ClienteID)
                Progresso(100)
        End Sub

        Private Sub btnExcRecebimento_Click(sender As Object, e As EventArgs) Handles btnExcRecebimento.Click  '\\DELETA CLIENTES SELECIONADOS
                Progresso(10)
                Dim Resp As DialogResult = MsgBox("Deseja apagar o cadastro?", vbYesNo, "AIO")

                If Resp = DialogResult.Yes Then
                        Progresso(40)
                        lSQL = "DELETE FROM tbClientes WHERE Código=" & txtCodCliente.Text
                        SQL.Comando()
                        SQL.Notificao("NOVA LITORALGESSO", "CLIENTE EXCLUIDO COM SUCESSO")
                        'End If
                        Progresso(60)
                        Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
                        CarregarTables()
                Else
                        SQL.Notificao("", "Operação cancelada com sucesso")
                End If
                TableCliente()
                TableEnd(ClienteID)
                TableContato(ClienteID)
                Progresso(100)
        End Sub

        Private Sub btnEditRecebimento_Click(sender As Object, e As EventArgs) Handles btnEditRecebimento.Click  '\\EDITA INFORMAÇÕES PESSOAIS SOBRE OS CLIENTES
                Progresso(10)
                lSQL = "UPDATE tbClientes SET Nome=""" & txtNomeFantasia.Text & """,RazaoSocial=""" & txtRazaoSocial.Text & """,CPF=""" & txtCPF.Text _
                         & """,InscricaoEstadual=""" & txtIE.Text & """ WHERE Código=" & txtCodCliente.Text
                SQL.Comando()
                Progresso(50)
                Me.TbClientesTableAdapter.Fill(Me.SistemaGEDataSet.tbClientes)
                SQL.Notificao("NOVA LITORAL GESSO", "CLIENTE ATUALIZADO COM SUCESSO")
                Progresso(100)
        End Sub

        Public Function txtobrigatorio(ByVal textbox As TextBox)
                If textbox.Text = "" Then
                        textbox.BackColor = Color.Red
                        Return False
                Else
                        Return True
                End If
        End Function

        Public Function cboobrigatorio(ByVal combobox As ComboBox)
                If combobox.Text = "" Then
                        combobox.BackColor = Color.Red
                        Return False
                Else
                        Return True
                End If
        End Function

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click '\\CADASTRA UM NOVO CONTATO VINCULADO AO CÓDIGO DO CLIENTE
                Progresso(10)
                Dim PermissaoInserir As Boolean
                If txtCodContato.Text = "" Then
                        If txtobrigatorio(txtDDD) = True And txtobrigatorio(txtNumeroContato) = True And cboobrigatorio(cboTipoContato) = True Then
                                PermissaoInserir = True
                        Else
                                PermissaoInserir = False
                        End If
                        If PermissaoInserir = True Then

                                lSQL = "INSERT INTO tbContato (ContatoID,DDD,Numero,Tipo)" & "VALUES(""" & txtCodCliente.Text & """,""" & txtDDD.Text & """,""" & txtNumeroContato.Text & """,""" & cboTipoContato.Text & """)"
                                SQL.Comando()
                                Progresso(50)
                                SQL.Notificao("NOVA LITORAL GESSO", "CONTATO CADASTRADO COM SUCESSO")
                                TableContato(ClienteID)
                                Progresso(80)
                        Else
                                SQL.Notificao("", "Campos com * são obrigatórios")
                        End If
                Else
                        cboTipo.Text = ""
                        txtCodContato.Text = ""
                        txtDDD.Text = ""
                        txtNumeroContato.Text = ""
                        txtCodContato.Text = ""
                        MsgBox("Preencha os campos e click no botão (ADICIONAR CONTATO)")
                End If
                Progresso(100)
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click '\\ATUALIZA OS DADOS SOBRE CONTATO VINCULADO AO CLIENTE VINCULADO AO DATAGRIDVIEW
                Progresso(10)
                lSQL = "UPDATE tbContato SET DDD=""" & txtDDD.Text & """,Numero=""" & txtNumeroContato.Text & """,Tipo=""" & cboTipoContato.Text & """ WHERE ID=" & txtCodContato.Text
                SQL.Comando()
                Progresso(50)
                SQL.Notificao("NOVA LITORAL GESSO", "CONTATO ATUALIZA COM SUCESSO")
                Progresso(80)
                TableContato(ClienteID)
                Progresso(100)
        End Sub

        Public Sub PopularCliente(ByVal NomePesquisa As String)
                Dim consulta As String = "SELECT Código, Nome, RazaoSocial, CPF, InscricaoEstadual, InscricaoMunicipal FROM tbClientes WHERE Nome LIKE " & "'" & NomePesquisa & "%' OR RazaoSocial LIKE " & "'" & NomePesquisa & "%'"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                DataGridView1.DataSource = dsbiblio.Tables("Cliente")
        End Sub

        Public Sub TableCliente()
                Dim consulta As String = "SELECT Código, Nome, RazaoSocial, CPF, InscricaoEstadual, InscricaoMunicipal FROM tbClientes"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                DataGridView1.DataSource = dsbiblio.Tables("Cliente")
        End Sub

        Public Sub TableContato(ByVal ClienteID As Double)
                Dim consulta As String = "SELECT ID, DDD, Numero, Tipo FROM tbContato WHERE ContatoID=" & ClienteID
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                DataGridView3.DataSource = dsbiblio.Tables("Cliente")
        End Sub

        Public Sub TableEnd(ByVal ClienteID As Double)
                Dim consulta As String = "SELECT Logradouro, EndNumero as N, Bairro, Cidade, UF, Complemento as Compl, Tipo, ID FROM tbEnd WHERE CodEnd=" & ClienteID
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                DataGridView2.DataSource = dsbiblio.Tables("Cliente")
        End Sub

        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
                PopularCliente(txtPesquisa.Text)
                If txtPesquisa.Text = "" Then
                        CarregarTables()
                End If
        End Sub

        Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
                MedicaoPersonalizado.ClienteID = txtCodCliente.Text
                MedicaoPersonalizado.CPF = CLng(txtCPF.Text)
                MedicaoPersonalizado.InscricaoEstadual = CLng(txtIE.Text)
                MedicaoPersonalizado.NomeFatansia = txtNomeFantasia.Text
                MedicaoPersonalizado.RazaoSocial = txtRazaoSocial.Text
                Me.Close()
        End Sub

        Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
                txtCodCliente.Text = DataGridView1.CurrentRow.Cells(0).Value
                ClienteID = DataGridView1.CurrentRow.Cells(0).Value
                txtNomeFantasia.Text = DataGridView1.CurrentRow.Cells(1).Value
                txtFantasiaStatus.Text = DataGridView1.CurrentRow.Cells(1).Value
                On Error Resume Next
                txtRazaoSocial.Text = DataGridView1.CurrentRow.Cells(2).Value
                txtRSstatus.Text = DataGridView1.CurrentRow.Cells(3).Value
                txtCPF.Text = DataGridView1.CurrentRow.Cells(3).Value
                txtIE.Text = DataGridView1.CurrentRow.Cells(4).Value
                If ClienteID > 0 = True Then
                        conexao1("SELECT * FROM tbClientes WHERE Código=" & ClienteID)
                        bdr1.Read()
                        If bdr1.HasRows = True Then

                                Dim imagem = bdr1("Imagem")

                                Dim ms As New MemoryStream(CType(imagem, Byte()))
                                PicPessoa.Image = Image.FromStream(ms)

                                PicPessoa.Image = imagem
                        Else
                                PicPessoa.Image = Nothing
                        End If
                        Desconexao1()
                End If
                TableContato(ClienteID)
                TableEnd(ClienteID)
        End Sub

        Private Sub FrmClientes_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
                If Me.Width < 762 Then
                        btnAtualizar.ImageAlign = ContentAlignment.TopCenter
                        btnAtualizar.TextAlign = ContentAlignment.BottomCenter
                Else
                        btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft
                        btnAtualizar.TextAlign = ContentAlignment.MiddleRight
                End If

                If Me.Width < 762 Then
                        btnFechar.ImageAlign = ContentAlignment.TopCenter
                        btnFechar.TextAlign = ContentAlignment.BottomCenter
                Else
                        btnFechar.ImageAlign = ContentAlignment.MiddleLeft
                        btnFechar.TextAlign = ContentAlignment.MiddleRight
                End If
        End Sub

        Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
                Progresso(10)
                TableCliente()
                Progresso(30)
                TableEnd(ClienteID)
                Progresso(60)
                TableContato(ClienteID)
                Progresso(100)
                SQL.Notificao("", "Tabelas Atualizadas")
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
                Progresso(10)
                Dim Resp As DialogResult = MsgBox("Deseja Excluir o Contato", vbYesNo, "AIO")
                If Resp = DialogResult.Yes Then
                        Progresso(30)
                        InstrucaoDireta("DELETE * FROM tbContato WHERE ID=" & txtCodContato.Text)
                        Progresso(50)
                        CarregarTables()
                        SQL.Notificao("", "Contato Excluido")
                        Progresso(65)
                        TableContato(ClienteID)
                Else
                        SQL.Notificao("", "Operaçao Cancelada pelo usuário")
                End If
                Progresso(100)
        End Sub

        Private Sub DataGridView3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
                txtCodContato.Text = DataGridView3.CurrentRow.Cells(0).Value
                cboTipoContato.Text = DataGridView3.CurrentRow.Cells(3).Value
                txtDDD.Text = DataGridView3.CurrentRow.Cells(1).Value
                txtNumeroContato.Text = DataGridView3.CurrentRow.Cells(2).Value
        End Sub

        Private Sub txtDDD_Click(sender As Object, e As EventArgs) Handles txtDDD.Click
                txtDDD.BackColor = Color.White
        End Sub

        Private Sub txtNumeroContato_Click(sender As Object, e As EventArgs) Handles txtNumeroContato.Click
                txtNumeroContato.BackColor = Color.White
        End Sub

        Private Sub cboTipoContato_Click(sender As Object, e As EventArgs) Handles cboTipoContato.Click
                cboTipoContato.BackColor = Color.White
        End Sub

        Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
                txtLogradouro.Text = DataGridView2.CurrentRow.Cells(0).Value
                txtNumero.Text = DataGridView2.CurrentRow.Cells(1).Value
                txtBairro.Text = DataGridView2.CurrentRow.Cells(2).Value
                txtCidade.Text = DataGridView2.CurrentRow.Cells(3).Value
                cboUF.Text = DataGridView2.CurrentRow.Cells(4).Value
                txtComplemento.Text = DataGridView2.CurrentRow.Cells(5).Value
                cboTipo.Text = DataGridView2.CurrentRow.Cells(6).Value
                txtCodEnd.Text = DataGridView2.CurrentRow.Cells(7).Value
        End Sub

        Private Sub FrmClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
                Me.Dispose(True)
        End Sub

        Private Sub txtColCTPS_Click(sender As Object, e As EventArgs) Handles txtPesquisa.Enter
                AnimarText(pbPesquisar)
        End Sub

        Private Sub txtColCTPS_LostFocus(sender As Object, e As EventArgs) Handles txtPesquisa.LostFocus
                pbPesquisar.Value = 0
        End Sub

        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        End Sub
End Class