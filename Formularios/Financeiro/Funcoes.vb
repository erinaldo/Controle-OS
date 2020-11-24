Module Funcoes


    'verificar informações do cliente
    Public Function VerInfoCliente(txtNome As TextBox, txtCPF As TextBox)

        If txtNome.Text <> "" And txtCPF.Text <> "" Then
            Return True
        Else
            Return False
        End If

    End Function

























End Module
