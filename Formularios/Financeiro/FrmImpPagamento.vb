Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmImpPagamento

    Public NomeDocumento As String
    Public col10, col20, col30, col40, col50, col60, col70, col80, col90, col100, col110, col120 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GerarPDF()
    End Sub

    Private Sub FrmImpPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GerarPDF()
    End Sub

    Public OSDI = FrmCadastroOS.txtOSID.Text
    Public Consulta As String = "'OS " & OSDI & "'"
    Public ValorReceber
    Public Pago As Double

    Public Function FormatPhrase(value As String) As Phrase
        Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.Bold, BaseColor.DARK_GRAY))
    End Function

    Public Function FormatPhrase2(value As String) As Phrase
        Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))
    End Function

    Public Sub GerarPDF()

        Connect.Conectardb("SELECT * FROM tbEndGesseiro WHERE EndID=" & FrmPagamentos.txtGesseiroID.Text)

        ' MsgBox(FrmPagamentos.txtGesseiroID.Text)

        Dim dbLogradouro As String = cdr.Item("Logradouro")
        Dim dbNumero As String = cdr("Numero")
        Dim dbCidade As String = cdr("Cidade")
        Dim dbBairro As String = cdr("Bairro")
        Dim dbUF As String = cdr("UF")

        Connect.Desconectardb()

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        '\\CRIA UM NOVO DOCUMENTO
        Dim Doc As New Document

        Dim caminhoPedido As String = My.Settings.CaminhoSalvarPagamentos

        If caminhoPedido = "" Then

            Dim opfPedidos As New FolderBrowserDialog
            opfPedidos.Description = "Selecione uma pasta para salvar seus pedidos"
            opfPedidos.ShowNewFolderButton = True
            opfPedidos.ShowDialog()
            My.Settings.CaminhoSalvarPagamentos = opfPedidos.SelectedPath
        End If

        '\\LOCAL ONDE SERA SALVO O PDF
        NomeDocumento = My.Settings.CaminhoSalvarPagamentos & "\Prestador - " & FrmPagamentos.txtNomeGesseiro.Text & ".pdf"

        '\\DEFINE O OBEJETO
        Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(Doc, New FileStream(NomeDocumento, FileMode.Create))

        '\\ABRE O DOCUMENTO
        Doc.Open()

        '\\INSERIR INFORMAÇÕES DENTRO DO ARQUIVO PFD
        Doc.AddAuthor(SQL.Usuario)
        Doc.AddCreator("All-in-One")
        Doc.AddTitle("Prestador:" & FrmPagamentos.txtNomeGesseiro.Text)

        '\\DECLARAÇÃO DE FONTES
        Dim FonteTNR As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.BLACK)
        Dim FontEspaco As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 2, Font.Bold, BaseColor.BLACK)
        Dim FontOSID As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 11, Font.Bold, BaseColor.RED)
        Dim fontInfoCliente As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.BLACK)
        Dim FontCabecalhoPage As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 9, Font.Bold, BaseColor.BLACK)
        Dim FontNomeEmpresa As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 11, Font.Bold, BaseColor.BLACK)
        Dim FontInfoPagamento As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, Font.Bold, BaseColor.BLACK)
        Dim fontCanhoto As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8)
        Dim fontCanhotoNegrito As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, Font.Bold, BaseColor.BLACK)
        Dim FontProdutos As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7)
        Dim FontDescricao As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8)
        Dim FontSubDescricao As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, Font.Bold, BaseColor.DARK_GRAY)
        Dim FontSeparador As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 1, Font.Bold, BaseColor.RED)
        Dim fonteEspacador As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5, Font.Bold, BaseColor.BLACK)

        Dim Alturalinha As Double = 3
        FrmPDV.dgvProdutos.RowTemplate.Height = Alturalinha

        ''\\FORMAÇÃO DO ENDEREÇO DO CANHOTO***************************************************************************************
        Dim EnderecoCliente As New Phrase
        EnderecoCliente.Font = fontCanhoto
        Dim CanLogradouro As New Chunk(dbLogradouro, FontDescricao)
        Dim CanNumero As New Chunk(dbNumero, FontDescricao)
        Dim CanBairro As New Chunk(dbBairro, FontDescricao)
        Dim CanCidade As New Chunk(dbCidade, FontDescricao)
        Dim CanUF As New Chunk(dbUF, FontDescricao)
        Dim CanEntEndereco As New Chunk("Endereço:   ", FontSubDescricao)
        Dim CanEntNumero As New Chunk("Número:  ", FontSubDescricao)
        Dim CanEntBairro As New Chunk("Bairro:  ", FontSubDescricao)
        Dim CanEntCidade As New Chunk("Cidade:  ", FontSubDescricao)
        Dim CanEntUF As New Chunk("UF:  ", FontSubDescricao)
        With EnderecoCliente
            .Add(CanEntEndereco)
            .Add(CanLogradouro)
            .Add("      ")
            .Add(CanEntNumero)
            .Add(CanNumero)
            .Add("      ")
            .Add(CanEntBairro)
            .Add(CanBairro)
            .Add("      ")
            .Add(CanEntCidade)
            .Add(CanCidade)
            .Add("      ")
            .Add(CanEntUF)
            .Add(CanUF)
        End With

        '\\INICIO DO DOCUMENTO ==========================================================================================================
        Dim PedidoID As New Paragraph(FrmCadastroOS.txtOSID.Text, FontOSID)

        '\\LOGOTIPO (TOPO DA PAGINA)*****************************************************************************************************
        Dim arquivoimagem As String = "C:\Users\macks\Desktop\ControleOS\Resources\NLG.png"
        Dim png As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(arquivoimagem))
        png.ScaleToFit(80.0F, 80.0F)
        png.Alignment = Image.TEXTWRAP & Image.ALIGN_LEFT
        png.IndentationLeft = 7.0F
        png.BorderWidthTop = 36.0F
        png.BorderColorTop = BaseColor.WHITE
        Doc.Add(png)

        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\NOME DA EMPRESA****************************************************************************************************************
        Dim NomeEmpresa As New Paragraph("NOVA LITORAL GESSO", FontNomeEmpresa)
        NomeEmpresa.Alignment = Element.ALIGN_CENTER
        Doc.Add(NomeEmpresa)

        '\\"PROPAGANDA" DA LOJA
        Dim Saudacao1 As New Paragraph("Servindo o melhor para servir sempre", FontCabecalhoPage)
        Saudacao1.Alignment = Element.ALIGN_CENTER
        Doc.Add(Saudacao1)
        Dim Saudacao2 As New Paragraph("Vendas - Decorações - Forros - Divisórias - Drywall - Parede 3D", FontCabecalhoPage)
        Saudacao2.Alignment = Element.ALIGN_CENTER
        ' Saudacao2.Add(png)
        Doc.Add(Saudacao2)

        '\\INFORMAÇÕES SOBRE A LOJA***********************************************************************************************
        Dim EnderecoLoja As New Paragraph("Av. Dr. Roberto de Almeida Vinhas, 4803 - Tupi/Praia Grande", FontCabecalhoPage)
        EnderecoLoja.Alignment = Element.ALIGN_CENTER
        Doc.Add(EnderecoLoja)
        Dim TelefoneLoja As New Paragraph("Telefone: (13) 3471-2674", FontCabecalhoPage)
        TelefoneLoja.Alignment = Element.ALIGN_CENTER
        Doc.Add(TelefoneLoja)
        Dim DescCliente As New Paragraph("| DADOS DO PAGAMENTO", FontDescricao)
        Doc.Add(DescCliente)

        '\\FORMAÇÃO DA FRASE (PEDIDO + NUMERO DO PEDIDO)
        Dim ImagemOSID As New Paragraph
        ImagemOSID.Alignment = Element.ALIGN_BOTTOM
        ImagemOSID.Font = FontCabecalhoPage
        ' ImagemOSID.Add("ORÇAMENTO:  " & FrmCadastroOS.txtOSID.Text)     ANALISAR (PORQUE NÃO EXISTE TABELA PARA IDENTIFICAR)

        '\\SEPARADOR ------------------------------------------
        Dim Separador As New Paragraph("______________________________________________________________________________")
        Separador.Alignment = Element.ALIGN_TOP
        Separador.Font = FontSeparador
        Doc.Add(Separador)

        'FORMAÇÃO DA FRASE ( CPF ) ------------------------------
        Dim DesCPF As New Chunk("          CPF: ", FontSubDescricao)
        Dim NumCPF As New Chunk(FrmPagamentos.txtCPF.Text, FontDescricao)
        ' Dim NomePedido As New Chunk("          PAGAMENTO REFÊRENTE AS OS : ", FontSubDescricao)
        'Dim PedidoNumber As New Chunk("372 - 373", FontDescricao)
        Dim FrasePedido As New Phrase
        ' FrasePedido.Add(NomePedido)
        'FrasePedido.Add(PedidoNumber)
        Doc.Add(FrasePedido)

        '\\FORMAÇÃO DA FRASE ( INFORMAÇÕES DO CLIENTE )--------------------------
        Dim DesNomeCliente As New Chunk("          PRESTADOR:  ", FontSubDescricao)
        Dim SubNomeCliente As New Chunk(FrmPagamentos.txtNomeGesseiro.Text & " " & FrmPagamentos.txtSobrenomeGesseiro.Text, FontDescricao)
        Dim FraseCliente As New Paragraph
        FraseCliente.Add(DesNomeCliente)
        FraseCliente.Add(SubNomeCliente)
        FraseCliente.Add(DesCPF)
        FraseCliente.Add(NumCPF)
        Doc.Add(FraseCliente)
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\DESCRIÇÃO SOBRE O ENDEREÇO DE COBRANÇA*******************************************************************
        Dim DesEndereco As New Chunk("          ", FontDescricao)
        Dim FraseEndereco As New Paragraph
        Dim ParaEnderecoCliente As New Paragraph
        ParaEnderecoCliente.Alignment = Element.ALIGN_BOTTOM
        ParaEnderecoCliente.Font = FontDescricao
        ParaEnderecoCliente.Add("| ENDEREÇO DO PRESTADOR  ")
        Doc.Add(FraseEndereco)
        Doc.Add(ParaEnderecoCliente)

        Dim Separador2 As New Paragraph("______________________________________________________________________________")
        Separador2.Alignment = Element.ALIGN_TOP
        Separador2.Font = FontSeparador
        Doc.Add(Separador2)
        FraseEndereco.Add(DesEndereco)
        FraseEndereco.Add(EnderecoCliente)
        Doc.Add(FraseEndereco)

        '\\ESPAÇADOR-------------------------------------
        Doc.Add(New Paragraph("  ", font:=fonteEspacador))

        '\\ADICIONAR ENDEREÇO DE ENTREGA

        '\\CASO O ENDEREÇO DO CLIENTE SEJA DIFERENTE DO ENDEREÇO DE ENTREGA ************************************************
        If FrmPDV.chkEntDif.Checked = True Then
            Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
            If cdr.HasRows = False Then
                MsgBox("ERRO, NÃO FOI POSSIVEL ENCONTRAR O ENDEREÇO DE ENTREGA NO BANCO DE DADOS")
                Connect.Desconectardb()
            Else
                Dim EndEntID As Integer = cdr.Item("EndEntID")
                Connect.Desconectardb()
                Connect.Conectardb("SELECT * FROM tbEnd WHERE ID=" & EndEntID)
                Dim Rua As String = cdr.Item("Logradouro")
                Dim Numero As Integer = cdr.Item("EndNumero")
                Dim Bairro As String = cdr.Item("Bairro")
                Dim Cidade As String = cdr.Item("Cidade")
                Dim Uf As String = cdr.Item("UF")
                Dim Complemento As String = cdr.Item("Complemento")
                Dim Tipo As String = cdr.Item("Tipo")
                Dim Crua As New Chunk(Rua, FontDescricao)
                Dim Cnumero As New Chunk(Numero, FontDescricao)
                Dim Cbairrro As New Chunk(Bairro, FontDescricao)
                Dim Ccidade As New Chunk(Cidade, FontDescricao)
                Dim Cuf As New Chunk(Uf, FontDescricao)
                Dim Ccomplemento As New Chunk(Complemento, FontDescricao)
                Dim Ctipo As New Chunk(Tipo, FontDescricao)
                Dim DesEntEndereco As New Chunk("          Endereço: ", FontSubDescricao)
                Dim DesEntNumero As New Chunk("Número:  ", FontSubDescricao)
                Dim DesEntBairro As New Chunk("Bairro:  ", FontSubDescricao)
                Dim DesEntCidade As New Chunk("Cidade:  ", FontSubDescricao)
                Dim DesEntUF As New Chunk("UF:  ", FontSubDescricao)
                Dim EndEnt As New Phrase

                With EndEnt
                    .Add(DesEntEndereco)
                    .Add(Crua)
                    .Add("      ")
                    .Add(DesEntNumero)
                    .Add(Cnumero)
                    .Add("      ")
                    .Add(DesEntBairro)
                    .Add(Cbairrro)
                    .Add("      ")
                    .Add(DesEntCidade)
                    .Add(Ccidade)
                    .Add("      ")
                    .Add(DesEntUF)
                    .Add(Cuf)
                End With

                Dim ParaEnderecoEntrega As New Paragraph
                ParaEnderecoEntrega.Alignment = Element.ALIGN_BOTTOM
                ParaEnderecoEntrega.Font = FontDescricao
                ParaEnderecoEntrega.Add("| ENDEREÇO DA OBRA  ")
                Doc.Add(ParaEnderecoEntrega)
                Dim Separador4 As New Paragraph("______________________________________________________________________________")
                Separador4.Alignment = Element.ALIGN_TOP
                Separador4.Font = FontSeparador
                Doc.Add(Separador4)
                Doc.Add(EndEnt)
            End If
        End If

        '\\ESPAÇAMENTO-----------------------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\DESCRIÇÃO DE ITENS DO PEDIDO*********************************************************************************************
        Dim ParaItens As New Paragraph
        ParaItens.Alignment = Element.ALIGN_BOTTOM
        ParaItens.Font = FontDescricao
        ParaItens.Add("| DESCRIÇÃO DOS PAGAMENTOS  ")
        Doc.Add(ParaItens)

        '\\SEPARADOR-----------------------------
        Dim Separador5 As New Paragraph("______________________________________________________________________________")
        Separador5.Alignment = Element.ALIGN_TOP
        Separador5.Font = FontSeparador
        Doc.Add(Separador5)

        '\\ESPACAMENTO-------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\LARGURA DA COLUNAS DO TABLE)*****************************************************************************
        col10 = 29
        col20 = 30
        col30 = 120
        col40 = 30
        col50 = 10
        col60 = 30
        col70 = 25

        Dim DesTableInicio As New Chunk("Serviços Iniciais (esta tabela deverá ser DESCONSIDERADA caso haja adcionais)", FontSubDescricao)
        '  Doc.Add(DesTableInicio)

        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        ' \\DATAGRID PRODUTOS(sem a coluna custo 1 ADICIONAL)*****************************************************************************
        ' Dim pdfTable2 As New PdfPTable(FrmPagamentos.DataGridView2.ColumnCount)

        Dim pdfTable2 As New PdfPTable(7)

        With pdfTable2
            .DefaultCell.Padding = 2
            .WidthPercentage = 100
            .DefaultCell.BorderWidth = 0.5
            .HorizontalAlignment = Element.ALIGN_CENTER
            '  Dim widths3 As Single() = New Single() {col10, col20, col30, col40, col50, col60, col70, col80, col90, col100}
            Dim widths3 As Single() = New Single() {col10, col20, col30, col40, col50, col60, col70}
            pdfTable2.SetWidths(widths3)
        End With

        '\\ADICIONAR LINHAS
        For Each column As String In FrmPagamentos.OSselecionadaCab
            Dim TamanhoTableCabecalho As Integer = 5 '\\TAMANHO DAS FONTES DE CABEÇALHO  NA IMPRESSAO DA OS
            Dim FontCabecalho As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.RED)
            Dim cell As New PdfPCell(New Phrase(column.ToString, FontDescricao))
            cell.HorizontalAlignment = Element.ALIGN_LEFT
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            If column.ToString.GetTypeCode = vbString Then
            Else
            End If
            pdfTable2.AddCell(cell)
        Next
        Dim line As Integer = 0
        For Each row In FrmPagamentos.OSselecionada
            ' For Each cell In row
            line += 1
            Dim texto As String

            If line > 9 Then
                line = 1

            End If

            'texto = cell.ToString
            Select Case line'

                Case 1
                    'texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 2
                    '           texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 3
                    ' texto = "R$ " & cell.Value.ToString
                    '           texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 4
                    '  texto = "R$ " & cell.Value.ToString
                    '            texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 5
                    '             texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 6
                    '              texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 7
                    '               texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 8
                    '               texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case 9
                    '             texto = cell.ToString
                    pdfTable2.AddCell(FormatPhrase(row))

                Case Else

            End Select
            ' Next
        Next

        Doc.Add(pdfTable2)

        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        Dim valorConvertido = "R$ " & FormatNumber(FrmPagamentos.Soma, 2)
        Dim SOMAPAGAMENTO As New Chunk("TOTAL DOS PAGAMENTOS  " & valorConvertido, FontSubDescricao)
        Doc.Add(SOMAPAGAMENTO)

        '\\ESPAÇAMENTO--------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\ESPAÇAMENTO-------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\FRASE E LOCAL DE ASSINATURA DO RECEBEDOR E DO COMPRADOR*******************************************************************************************

        Dim Linha As New Chunk("______________________________                                      ______________________________")
        Dim Descr As New Chunk("      Assinatura do Contratante                                                           Assinatura do Prestador   ")
        Dim ParaAss1 As New Paragraph
        Dim paraAss2 As New Paragraph
        With ParaAss1
            .Font = fontCanhotoNegrito
            .Alignment = Element.ALIGN_CENTER
        End With
        With paraAss2
            .Font = fontCanhotoNegrito
            .Alignment = Element.ALIGN_CENTER
        End With
        ParaAss1.Add(Linha)
        Doc.Add(ParaAss1)
        paraAss2.Add(Descr)
        Doc.Add(paraAss2)

        '\\ESPAÇAMENTO-------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\INFORMAÇÕES DA IMPRESSÃO**************************************************************************************************************************
        Dim DataImpressao As New Paragraph
        DataImpressao.Font = fontCanhotoNegrito
        Dim DataAtual As New Chunk(Today.ToShortDateString)
        Dim HoraAtual As New Chunk(TimeOfDay.ToShortTimeString)
        DataAtual.Font = fontCanhotoNegrito
        HoraAtual.Font = fontCanhotoNegrito
        DataImpressao.Alignment = Element.ALIGN_RIGHT
        DataImpressao.Add("Impresso em: ")
        DataImpressao.Add(DataAtual)
        DataImpressao.Add("   ")
        DataImpressao.Add(HoraAtual)
        Doc.Add(DataImpressao)
        Dim Usuario As New Paragraph
        Usuario.Font = fontCanhotoNegrito
        Usuario.Alignment = Element.ALIGN_RIGHT
        Dim DesUsuario As New Chunk("Usuario: ")
        Dim NomeUsuario As New Chunk(SQL.Usuario)

        '\\ADIÇÃO DE FRASE NO DOC.
        Usuario.Add(DesUsuario)
        Usuario.Add(NomeUsuario)
        Doc.Add(Usuario)

        '\\ESPAÇAMENTO-------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '********************************************************FIM DO DOCUMENTO**********************************************************************

        Doc.Close()

        AxAcroPDF1.src = NomeDocumento
    End Sub

End Class