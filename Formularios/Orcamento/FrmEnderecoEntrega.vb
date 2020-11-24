Public Class FrmEnderecoEntrega

    Private Sub TbEndBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TbEndBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbEndBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataPdv)

    End Sub

    Private Sub FrmEnderecoEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataPdv.tbEnd'. Você pode movê-la ou removê-la conforme necessário.
        ' Me.TbEndTableAdapter.Fill(Me.DataPdv.tbEnd)
        On Error Resume Next
        ' Me.TbEndTableAdapter.FillByClienteID(Me.DataPdv.tbEnd, CType(FrmPDV.txtCodCliente.Text, Integer))
        Me.TbEndTableAdapter.FillByEndID(Me.DataPdv.tbEnd, New System.Nullable(Of Integer)(CType(FrmPDV.txtCodCliente.Text, Integer)))
        lblDescricao.Text = "Endereços relacionados ao cliente: " & FrmPDV.txtCliente.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtEntregaID.Text <> "" Then
            SQL.EntregaID = txtEntregaID.Text
            Me.Close()
        Else
            SQL.Notificao("", "NÃO FOI POSSIVEL LOCALIZAR O ENDEREÇO SELECIONADO")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmCadastroEndereco.btnCadastroPeloPDV.Visible = True
        FrmCadastroEndereco.ShowDialog()
    End Sub

End Class