Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Acrobat
Imports AcroPDFLib
Imports AxAcroPDFLib

Public Class FrmImpPDV

        'Doc.NewPage() ==========ADICIONAR NOVA PAGINA AO DOCUMENTO
        Public AlturaLinnha As Integer = 18

        Public col1 As String = 70
        Public col2 As String = 90
        Public col3 As String = 200
        Public col4 As String = 30
        Public col5 As String = 50
        Public col6 As String = 70
        Public col7 As String = 70
        Public col8 As String = 80

        Public NomeDocumento As String
        Public ComandoDebitos As String = "SELECT * FROM tbFinanceiroSoma WHERE NumeroDocumento='Pedido " & FrmPDV.lblNumeroPedido.Text & "'"

        Private Sub FrmImpDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                '\\CRIA UM NOVO DOCUMENTO
                Dim Doc As New Document

                Dim caminhoPedido As String = My.Settings.CaminhoSalvarPedido

                If caminhoPedido = "" Then

                        Dim opfPedidos As New FolderBrowserDialog
                        opfPedidos.Description = "Selecione uma pasta para salvar seus pedidos"
                        opfPedidos.ShowNewFolderButton = True
                        opfPedidos.ShowDialog()
                        My.Settings.CaminhoSalvarPedido = opfPedidos.SelectedPath
                End If

                '\\LOCAL ONDE SERA SALVO O PDF
                NomeDocumento = caminhoPedido & FrmPDV.lblNumeroPedido.Text & " (" & FrmPDV.txtCodCliente.Text & ").pdf"

                '\\DEFINE O OBEJETO
                Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(Doc, New FileStream(NomeDocumento, FileMode.Create))

                '\\ABRE O DOCUMENTO
                Doc.Open()

                '\\INSERIR INFORMAÇÕES DENTRO DO ARQUIVO PFD
                Doc.AddAuthor(SQL.Usuario)
                Doc.AddCreator("AIO")
                Doc.AddTitle("Orçamento do " & FrmPDV.txtCliente.Text & " referente ao pedido " & FrmPDV.lblNumeroPedido.Text)

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

                'INICIO DO DOCUMENTO ==================================================================
                FrmPDV.dgvProdutos.RowTemplate.Height = AlturaLinnha

                '\\DECLARAÇÃO DE VARIAVEIS
                Dim NomeCliente As New Paragraph(FrmPDV.txtCliente.Text, fontInfoCliente)

                ''\\FORMAÇÃO DO ENDEREÇO DO CANHOTO***************************************************************************************
                Dim EnderecoCliente As New Phrase
                EnderecoCliente.Font = fontCanhoto
                Dim CanLogradouro As New Chunk(FrmPDV.txtLogradouro.Text, FontDescricao)
                Dim CanNumero As New Chunk(FrmPDV.txtEndNumero.Text, FontDescricao)
                Dim CanBairro As New Chunk(FrmPDV.txtBairro.Text, FontDescricao)
                Dim CanCidade As New Chunk(FrmPDV.txtCidade.Text, FontDescricao)
                Dim CanUF As New Chunk(FrmPDV.txtUF.Text, FontDescricao)
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

                '\\DECLARAÇÃO DE CORES
                Dim AzulClaro As New BaseColor(175, 239, 250)

                '\\CANHOTO ========================================================================
                Dim Frete As New Chunk("Frete: R$ " & FrmPDV.txtPrecoFrete.Text, fontCanhoto)
                Dim Valor As New Chunk("Valor: R$ " & FrmPDV.txtSomaPDV.Text, fontCanhoto)
                Dim Data As New Chunk(Today.ToShortDateString, fontCanhoto)
                Dim NumeroPedido As New Chunk(FrmPDV.lblNumeroPedido.Text, fontCanhoto)
                Dim PedidoFrase As New Chunk("Pedido: ", fontCanhoto)
                Dim Assinatura As New Chunk("__________________________    Carimbo: ", fontCanhoto)
                Dim Ass As New Chunk("Assinatuara do Cliente  ", fontCanhoto)
                Dim frase1 As New Phrase
                Dim frase2 As New Phrase
                Dim frase3 As New Phrase
                Dim frase4 As New Phrase
                Dim Espaco As New Phrase
                Espaco.Add(" - ")
                '====================================================================================================================
                ' Dim arquivoimagem As String = "C:\Users\Mackson\Desktop\ControleOS\Resources\NLG.png"
                ' Dim png As itextsharp.text.Image = itextsharp.text.Image.GetInstance(New Uri(arquivoimagem))
                ' png.ScaleToFit(40.0F, 40.0F)
                ' png.Alignment = Image.TEXTWRAP & Image.ALIGN_LEFT
                ' png.IndentationLeft = 7.0F
                '' png.BorderWidthTop = 36.0F
                ' png.BorderColorTop = BaseColor.WHITE
                'Doc.Add(png)
                '====================================================================================================================
                '\\COMPOSIÇÃO DA LINHA 1 DO CANHOTO
                With frase1
                        .Add(PedidoFrase)
                        .Add(NumeroPedido)
                        .Add(Espaco) '\\ESPAÇO
                        .Add(NomeCliente)
                        .Add(Espaco) '\\ESPAÇO
                        .Add(Frete)
                        .Add(Espaco) '\\ESPAÇO
                        .Add(Valor)
                        .Add("   ") '\\ESPAÇO
                        .Add(Data)
                End With

                '\\COMPOSIÇÃO DA LINHA 2 DO CANHOTO
                With frase2
                        .Add("  ")
                        .Add(EnderecoCliente)
                End With

                '\\COMPOSIÇÃO DA LINHA 3 DO CANHOTO
                With frase3
                        .Add(Assinatura)
                End With

                '\\COMPOSIÇÃO DA LINHA 4 DO CANHOTO
                With frase4
                        .Add(Ass)
                End With

                '\COMPOSIÇÃO DO PARAGRAFO DO CANHOTO
                Dim Canhoto As New Paragraph
                Canhoto.Alignment = Element.ALIGN_BOTTOM
                With Canhoto
                        .Add(frase1)
                        .Add(frase2)
                End With

                '\\ADICIONAR O PARAGRAFO "CANHOTO" AO DOCUMENTO
                Doc.Add(Canhoto)

                '\\ADICIONARA FRASE DE ASSINATURA E LOCAL DA ASSINATURA
                Doc.Add(frase4)
                Doc.Add(frase3)
                Doc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))

                '\\INICIO DO DOCUMENTO ==========================================================================================================
                Dim PedidoID As New Paragraph(FrmPDV.lblNumeroPedido.Text, FontOSID)

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
                Dim DescCliente As New Paragraph("| DADOS DO PEDIDO", FontDescricao)
                Doc.Add(DescCliente)

                '\\FORMAÇÃO DA FRASE (PEDIDO + NUMERO DO PEDIDO)
                Dim ImagemOSID As New Paragraph
                ImagemOSID.Alignment = Element.ALIGN_BOTTOM
                ImagemOSID.Font = FontCabecalhoPage
                ImagemOSID.Add("PEDIDO:  " & FrmPDV.lblNumeroPedido.Text)

                '\\SEPARADOR ------------------------------------------
                Dim Separador As New Paragraph("______________________________________________________________________________")
                Separador.Alignment = Element.ALIGN_TOP
                Separador.Font = FontSeparador
                Doc.Add(Separador)

                'FORMAÇÃO DA FRASE ( CPF ) ------------------------------
                Dim DesCPF As New Chunk("          CPF: ", FontSubDescricao)
                Dim NumCPF As New Chunk(FrmPDV.txtCPFCliente.Text, FontDescricao)
                Dim NomePedido As New Chunk("          Pedido: ", FontSubDescricao)
                Dim PedidoNumber As New Chunk(FrmPDV.lblNumeroPedido.Text, FontDescricao)
                Dim FrasePedido As New Phrase

                Dim numeroOS As New Chunk(" / Vinculado a OS: ", FontDescricao)
                Dim numberOS As New Chunk(FrmCadastroOS.txtOSID.Text, FontDescricao)

                FrasePedido.Add(NomePedido)
                FrasePedido.Add(PedidoNumber)

                If PedidoVinculado = True Then
                        FrasePedido.Add(numeroOS)
                        FrasePedido.Add(numberOS)
                End If

                Doc.Add(FrasePedido)

                '\\FORMAÇÃO DA FRASE ( INFORMAÇÕES DO CLIENTE )--------------------------
                Dim DesNomeCliente As New Chunk("          Cliente:  ", FontSubDescricao)
                Dim SubNomeCliente As New Chunk(FrmPDV.txtCliente.Text, FontDescricao)
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
                ParaEnderecoCliente.Add("| ENDEREÇO DE COBRANÇA  ")
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
                                Dim EndEntID As Integer = cdr.Item("EndID")
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
                                ParaEnderecoEntrega.Add("| ENDEREÇO DE ENTREGA  ")
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
                ParaItens.Add("| ITENS DO PEDIDO  ")
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

                '\\DATAGRID PRODUTOS(com a coluna custo)********************************************************************************************

                Dim dgvIncioPadrao As DataGridView

                If PedidoVinculado = True Then
                        dgvIncioPadrao = FrmPDV.dgvProdutosVinc
                Else
                        dgvIncioPadrao = FrmPDV.dgvProdutos
                End If

                Dim pdfTable As New PdfPTable(dgvIncioPadrao.ColumnCount)
                Dim col1, col2, col3, col4, col5, col6, col7, col8, col9 As String
                col1 = 60
                col2 = 80
                col3 = 225
                col4 = 65
                col5 = 55
                col6 = 55
                col7 = 60
                col8 = 55
                col9 = 15
                With pdfTable
                        .DefaultCell.Padding = 4
                        .WidthPercentage = 100
                        .DefaultCell.BorderWidth = 0.5
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        Dim widths3 As Single() = New Single() {col1, col2, col3, col4, col5, col6, col7, col8, col9}
                        pdfTable.SetWidths(widths3)
                End With
                '\\ADICIONAR LINHAS
                For Each column As DataGridViewColumn In dgvIncioPadrao.Columns
                        Dim TamanhoTableCabecalho As Integer = 5 '\\TAMANHO DAS FONTES DE CABEÇALHO  NA IMPRESSAO DA OS
                        Dim FontCabecalho As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.RED)
                        Dim cell As New PdfPCell(New Phrase(column.HeaderText, FontDescricao))
                        cell.HorizontalAlignment = Element.ALIGN_LEFT
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE
                        If column.HeaderText.GetTypeCode = vbString Then
                        Else
                        End If
                        pdfTable.AddCell(cell)
                Next
                Dim Col As Integer = 0
                For Each row As DataGridViewRow In dgvIncioPadrao.Rows
                        For Each cell As DataGridViewCell In row.Cells
                                Col += 1
                                Dim texto As String
                                If Col > 8 Then
                                        Col = 0
                                        pdfTable.AddCell(FormatPhrase(""))
                                Else
                                        If Col = 5 Or Col = 6 Or Col = 7 Then
                                                texto = cell.Value.ToString
                                                pdfTable.AddCell(FormatPhrase("R$ " & texto))
                                        Else
                                                texto = cell.Value.ToString
                                                pdfTable.AddCell(FormatPhrase(texto))
                                        End If
                                End If
                        Next
                Next

                '\\DATAGRID PRODUTOS(sem a coluna custo)*****************************************************************************
                Dim pdfTable2 As New PdfPTable(FrmPDV.dgvProdutosSemCusto.ColumnCount)
                Dim col10, co20, co30, co40, co50, co60, co70, co80 As String
                col10 = 60
                co20 = 80
                co30 = 280
                co40 = 65
                co50 = 55
                co60 = 60
                co70 = 55
                co80 = 15
                With pdfTable2
                        .DefaultCell.Padding = 2
                        .WidthPercentage = 100
                        .DefaultCell.BorderWidth = 0.5
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        Dim widths3 As Single() = New Single() {col10, co20, co30, co40, co50, co60, co70, co80}
                        pdfTable2.SetWidths(widths3)
                End With
                '\\ADICIONAR LINHAS
                For Each column As DataGridViewColumn In FrmPDV.dgvProdutosSemCusto.Columns
                        Dim TamanhoTableCabecalho As Integer = 5 '\\TAMANHO DAS FONTES DE CABEÇALHO  NA IMPRESSAO DA OS
                        Dim FontCabecalho As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.RED)
                        Dim cell As New PdfPCell(New Phrase(column.HeaderText, FontDescricao))
                        cell.HorizontalAlignment = Element.ALIGN_LEFT
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE
                        If column.HeaderText.GetTypeCode = vbString Then
                        Else
                        End If
                        pdfTable2.AddCell(cell)
                Next
                Dim line As Integer = 0
                For Each row As DataGridViewRow In FrmPDV.dgvProdutosSemCusto.Rows
                        For Each cell As DataGridViewCell In row.Cells
                                line += 1
                                Dim texto As String
                                If line > 7 Then
                                        line = 0
                                        pdfTable2.AddCell(FormatPhrase(""))
                                Else
                                        If line = 5 Or line = 6 Then
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase("R$ " & texto))
                                        Else
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        End If
                                End If
                        Next
                Next

                If PedidoVinculado = False Then

                        If FrmPDV.rdOcultarColCusto.Checked = False Then
                                Doc.Add(pdfTable)
                        Else
                                Doc.Add(pdfTable2)
                        End If
                Else

                        Doc.Add(pdfTable)

                End If

                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\DESCRIÇÃO PAGAMENTO**************************************************************************************************************************
                Dim ParaPagamento As New Paragraph
                ParaPagamento.Alignment = Element.ALIGN_BOTTOM
                ParaPagamento.Font = FontDescricao
                ParaPagamento.Add("| FORMA / CONDIÇÕES DE PAGAMENTO  ")
                Doc.Add(ParaPagamento)

                '\\SEPARADOR ---------------------------------
                Doc.Add(Separador5)

                '\\ESPAÇAMENTO--------------------------------
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\TABLE DE PAGAMENTO***************************************************************************************************************************
                Dim pdfTablePagamento As New PdfPTable(FrmPDV.dgvPagamento.ColumnCount)
                Dim col21, col22, col23, col24, col25, col26 As String
                col21 = 40
                col22 = 60
                col23 = 60
                col24 = 50
                col25 = 50
                col26 = 40
                With pdfTablePagamento
                        .DefaultCell.Padding = 2
                        .WidthPercentage = 75
                        .DefaultCell.BorderWidth = 0.5
                        .HorizontalAlignment = Element.ALIGN_LEFT
                        Dim widths As Single() = New Single() {col21, col22, col23, col24, col25, col26}
                        pdfTablePagamento.SetWidths(widths)
                End With
                '\\ADICIONAR LINHAS--------------------
                For Each column As DataGridViewColumn In FrmPDV.dgvPagamento.Columns
                        Dim TamanhoTableCabecalho As Integer = 5 '\\TAMANHO DAS FONTES DE CABEÇALHO  NA IMPRESSAO DA OS
                        Dim FontCabecalho As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.RED)
                        Dim cell As New PdfPCell(New Phrase(column.HeaderText, FontDescricao))
                        cell.HorizontalAlignment = Element.ALIGN_LEFT
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE
                        If column.HeaderText.GetTypeCode = vbString Then
                        Else
                        End If
                        pdfTablePagamento.AddCell(cell)
                Next
                For Each row As DataGridViewRow In FrmPDV.dgvPagamento.Rows
                        Dim lin As Integer = 0
                        For Each cell As DataGridViewCell In row.Cells
                                Dim texto As String
                                '\\CONTADOR DE COLUNAS
                                lin += 1
                                If lin > 7 Then
                                        lin = 1
                                End If
                                If lin < 7 Then
                                        If lin = 4 Or lin = 5 Then
                                                texto = "R$ " & cell.Value.ToString
                                        Else
                                                texto = cell.Value.ToString
                                        End If
                                        pdfTablePagamento.AddCell(FormatPhrase(texto))
                                Else
                                        pdfTablePagamento.AddCell(FormatPhrase(""))
                                End If
                        Next
                Next
                Doc.Add(pdfTablePagamento)

                '\\ESPAÇAMENTO--------------------------------
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\TABELA DO TOTAL********************************************************************************************************************************

                '\\BUSCAR DADOS DE PAGAMENTO------------------
                Dim Pago As Double
                Dim Restante As Double
                '  Dim ComandoDebitos As String = "SELECT * FROM tbFinanceiroSoma WHERE NumeroDocumento='Pedido " & +"'"

                ' Connect.Conectardb(ComandoDebitos)
                ' If cdr.HasRows = True Then
                ' Pago = cdr.Item("Foi Pago")
                ' Restante = cdr.Item("Não Pago")
                ' Connect.Desconectardb()
                ' Else
                ' Restante = FrmPDV.txtSomaPDV.Text
                ' Connect.Desconectardb()
                ' End If
                Dim ValorPedido As Double
                Dim Desconto As Double
                Dim TotalPago As Double
                Dim Receber As Double
                Dim TotalPedido As Double

                Connect.Conectardb("SELECT * FROM tbPedido2 WHERE PedidoID=" & FrmPDV.lblNumeroPedido.Text)
                ValorPedido = cdr.Item("ValorTotal")
                Desconto = cdr.Item("Desconto")
                Connect.Desconectardb()

                '\\BUSCAR TOTAL PAGO E A RECEBER*********************************************************************************************
                MsgBox(FrmPDV.lblNumeroPedido.Text)
                Connect.Conectardb("Select * FROM tbFinanceiroSoma WHERE NumeroDocumento='Pedido " & FrmPDV.lblNumeroPedido.Text & "'")
                If cdr.HasRows = True Then
                        On Error Resume Next
                        Pago = cdr.Item("Foi Pago")
                        'TotalReceber = cdr.Item("Não Pago")
                        TotalPago = "R$ " & FormatNumber(Pago, 2)
                        Receber = "R$ " & FormatNumber(Restante - Pago, 2)
                        Connect.Desconectardb()
                Else
                        Connect.Desconectardb()
                End If
                TotalPedido = "R$ " & FormatNumber(ValorPedido, 2)




                Dim table As New PdfPTable(4)
                Dim celula As New PdfPCell
                celula.Colspan = 2
                table.DefaultCell.Padding = 2
                table.WidthPercentage = 50
                celula.HorizontalAlignment = Element.ALIGN_CENTER
                celula.VerticalAlignment = Element.ALIGN_CENTER
                Dim widths2 As Single() = New Single() {20.0F, 20.0F, 20.0F, 20.0F}
                table.SetWidths(widths2)
                table.HorizontalAlignment = Element.ALIGN_LEFT
                ' table.AddCell(celula)
                table.AddCell(FormatPhrase2("TOTAL"))
                table.AddCell(FormatPhrase2("FRETE"))
                table.AddCell(FormatPhrase2("PAGO"))
                table.AddCell(FormatPhrase2("RESTANTE"))
                table.AddCell(FormatPhrase2(Dinheiro(TotalPedido)))
                table.AddCell(FormatPhrase2(FrmPDV.txtPrecoFrete.Text))
                table.AddCell(FormatPhrase2("R$ " & Pago))
                table.AddCell(FormatPhrase2("R$ " & Restante))

                '\\ADIÇÃO DE FRASE
                Doc.Add(table)

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
                Dim Descr As New Chunk("      Assinatura do Comprador                                                           Assinatura do Recebedor   ")
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
                Dim msgResponsabilidade As New Chunk("NÃO NOS RESPONSABILIZAMOS POR MERCADORIAS RETIRADAS E TRANSPORTADAS PELO CLIENTE", FontDescricao)
                Dim msgSubidaMaterial As New Chunk("SÓ ENTREGAMOS O MATERIAL NO PISO TÉRREO", FontDescricao)
                ParaAss1.Add(Linha)
                Doc.Add(ParaAss1)
                paraAss2.Add(Descr)
                Doc.Add(paraAss2)
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
                Doc.Add(msgResponsabilidade)
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(msgSubidaMaterial)

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

        Private Sub Button1_Click_1(sender As Object, e As EventArgs)
                Me.Close()
        End Sub

        Private Sub btnProxPag_KeyDown(sender As Object, e As KeyEventArgs)
                Dim tecla As String
                tecla = e.KeyCode
                If tecla = "P" Then
                        Me.VerticalScroll.Value = 777
                End If
        End Sub

        Public Function FormatPhrase(value As String) As Phrase
                Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.Bold, BaseColor.DARK_GRAY))
        End Function

        Public Function FormatPhrase2(value As String) As Phrase
                Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))
        End Function

        Public Sub AbrirPDF()
                OpenFileDialog1.FileName = ""
                OpenFileDialog1.Title = "Nova Litoral Gesso - AIO"
                OpenFileDialog1.ShowDialog()
                AxAcroPDF1.src = OpenFileDialog1.FileName
        End Sub

        Private Sub ABRIRPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABRIRPDFToolStripMenuItem.Click
                AbrirPDF()
        End Sub

        Private Sub SAIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem1.Click
                Me.Close()
        End Sub
        Public Sub imprirmi()

        End Sub

End Class