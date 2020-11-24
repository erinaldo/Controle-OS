Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp

Public Class FrmRelatorioFinanceiro
        Public FocoDataInicial As Boolean
        Public FocoDataFinal As Boolean
        Public consulta As String
        Public WhereAdd As Boolean
        Public NomeDocumento As String
        Public col10, col20, col30, col40, col50, col60, col70, col80, col90, col100, col110, col120 As String


        Public Function ConverterImagem(Image As Bitmap, Format As Imaging.ImageFormat) As Byte()
                'Declare a new memory stream to write to
                Dim SaveStream As New System.IO.MemoryStream
                'Save the bitmap/image to the memory stream in the desired format
                Image.Save(SaveStream, Format)
                'Extract the file bytes from the memory stream
                Dim ConvertedImageBytes() As Byte = SaveStream.ToArray
                'Return bytes to caller
                Return ConvertedImageBytes
        End Function
        Public Sub GerarGraficos()
                chtPlano.Series.Clear()
                ListView1.Items.Clear()
                chtPlano.Titles.Clear()
                Dim QL As Double
                QL = dgvProdutoInicio.Rows.Count - 1
                Dim esteR, passadoR As Double
                Do Until QL < 0
                        esteR = esteR + dgvProdutoInicio.Rows(QL).Cells(1).Value
                        QL -= 1
                Loop
                esteR = 100 / esteR
                Do Until QL < 0
                        QL -= 1
                Loop
                passadoR = 100 / passadoR
                chtPlano.Titles.Add("Comparatorio mensal")
                QL = dgvProdutoInicio.Rows.Count - 1
                chtPlano.Series.Add("Este mes")
                Do Until QL < 0
                        ListView1.Items.Add(dgvProdutoInicio.Rows(QL).Cells(0).Value & " - " & Dinheiro(dgvProdutoInicio.Rows(QL).Cells(1).Value) & " ======== " & FormatNumber(dgvProdutoInicio.Rows(QL).Cells(1).Value * esteR, 2) & " %")
                        chtPlano.Series("Este mes").Points.AddXY(dgvProdutoInicio.Rows(QL).Cells(0).Value.ToString, FormatNumber(dgvProdutoInicio.Rows(QL).Cells(1).Value * esteR, 2)).ToString()
                        QL -= 1
                Loop
                chtPlano.Series.Add("mes passado")
                Do Until QL < 0
                        QL -= 1
                Loop
        End Sub
        Public OSDI = FrmCadastroOS.txtOSID.Text

        Private Sub RedefinirIconeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedefinirIconeToolStripMenuItem.Click
                ofdLocIcone.ShowDialog()
                My.Settings.LocIcone = ofdLocIcone.FileName
                pc1.ImageLocation = My.Settings.LocIcone
        End Sub

        Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
                Me.Close()
        End Sub

        Private Sub AtualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
                GerarPDF()
                GerarGraficos()
        End Sub

        Private Sub AtualizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AtualizarToolStripMenuItem.Click
                GerarPDF()
                GerarGraficos()
        End Sub

        Private Sub btnTeste_Click(sender As Object, e As EventArgs) Handles btnTeste.Click

        End Sub

        Public Consulta2 As String = "'OS " & OSDI & "'"
    Public ValorReceber
        Public Pago As Double
        Private Sub FrmRelatorioFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                txtDataInicial.Text = FrmNovoLancamento.txtDataInicial.Text
                txtDataFinal.Text = FrmNovoLancamento.txtDataFinal.Text
                GerarPDF()
                GerarGraficos()
                On Error Resume Next
                pc1.ImageLocation = My.Settings.LocIcone
        End Sub
        Public Sub Filtro()
                Dim DataInicial As String = txtDataInicial.Text
                Dim DataFinal As String = txtDataFinal.Text
                consulta = "SELECT PlanoContas, SUM(Valor) as Total FROM tbFinanceiro WHERE Tipo='Despesa' AND DataLancamento>#" & DataInicial & "# AND DataLancamento<#" & DataFinal & "# GROUP BY PlanoContas"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
                dgvProdutoInicio.DataSource = dsbiblio.Tables("Cliente")
        End Sub
        Public Sub Filtro2()
                Dim DataInicial As String = txtDataInicial.Text
                Dim DataFinal As String = txtDataFinal.Text
                DataInicial = CDate(DataInicial).AddMonths(-1)
                DataFinal = CDate(DataFinal).AddMonths(-1)
                consulta = "SELECT PlanoContas, SUM(Valor) as Total FROM tbFinanceiro WHERE Tipo='Despesa' AND DataLancamento>#" & DataInicial & "# AND DataLancamento<#" & DataFinal & "# GROUP BY PlanoContas"
                Dim strConn As String = sConnectionString
                Dim conexao As New OleDbConnection(strConn)
                Dim comando As New OleDbCommand(consulta, conexao)
                Dim adaptador As New OleDbDataAdapter(comando)
                Dim dsbiblio As New DataSet()
                adaptador.Fill(dsbiblio, "Cliente")
        End Sub
        Public Sub GerarPDF()
                Filtro()
                Filtro2()
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
                '\\CRIA UM NOVO DOCUMENTO
                Dim Doc As New Document



                '\\LOCAL ONDE SERA SALVO O PDF



                Dim Caminho As String = Application.LocalUserAppDataPath
                NomeDocumento = Caminho & FrmCadastroOS.txtOSID.Text & " (" & FrmCadastroOS.txtCodCliente.Text & ").pdf"

                '\\DEFINE O OBEJETO
                Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(Doc, New FileStream(NomeDocumento, FileMode.Create))

                '\\ABRE O DOCUMENTO
                Doc.Open()

                '\\INSERIR INFORMAÇÕES DENTRO DO ARQUIVO PFD
                Doc.AddAuthor(SQL.Usuario)
                Doc.AddCreator("Max Plus 3D")
                Doc.AddTitle("Orçamento do " & FrmCadastroOS.cboCliente.Text & " referente ao pedido " & FrmPDV.lblNumeroPedido.Text)

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

                '\\INICIO DO DOCUMENTO ==========================================================================================================
                Dim PedidoID As New Paragraph(FrmCadastroOS.txtOSID.Text, FontOSID)

                '\\LOGOTIPO (TOPO DA PAGINA)*****************************************************************************************************
                'Dim arquivoimagem As String = My.Resources.NLG.
                ' Dim png As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(My.Resources.NLG.ToString))
                Dim LocIcone As String
                If My.Settings.LocIcone <> "" Then
                        LocIcone = My.Settings.LocIcone.ToString
                Else
                        ofdLocIcone.ShowDialog()
                        My.Settings.LocIcone = ofdLocIcone.FileName
                End If

                Dim png As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(My.Settings.LocIcone))
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
                Dim DescCliente As New Paragraph("| DADOS DO ORÇAMENTO", FontDescricao)
                'Doc.Add(DescCliente)

                '\\FORMAÇÃO DA FRASE (PEDIDO + NUMERO DO PEDIDO)
                Dim ImagemOSID As New Paragraph
                ImagemOSID.Alignment = Element.ALIGN_BOTTOM
                ImagemOSID.Font = FontCabecalhoPage
                ImagemOSID.Add("RELATORIO MÊS DE REFERÊNCIA " & CDate(txtDataInicial.Text).Month.ToString)

                '\\SEPARADOR ------------------------------------------
                Dim Separador As New Paragraph("______________________________________________________________________________")
                Separador.Alignment = Element.ALIGN_TOP
                Separador.Font = FontSeparador
                Doc.Add(Separador)

                'FORMAÇÃO DA FRASE ( CPF ) ------------------------------
                Dim DesCPF As New Chunk("          CPF: ", FontSubDescricao)
                Dim NumCPF As New Chunk(FrmCadastroOS.txtCPF.Text, FontDescricao)
                Dim NomePedido As New Chunk("            RELATORIO MÊS DE REFERÊNCIA " & CDate(txtDataInicial.Text).Month.ToString, FontSubDescricao)
                Dim PedidoNumber As New Chunk(FrmCadastroOS.txtOSID.Text, FontDescricao)
                Dim FrasePedido As New Phrase
                'FrasePedido.Add(NomePedido)
                FrasePedido.Add(PedidoNumber)
                Doc.Add(FrasePedido)

                '\\FORMAÇÃO DA FRASE ( INFORMAÇÕES DO CLIENTE )--------------------------
                Dim DesNomeCliente As New Chunk("          CLIENTE:  ", FontSubDescricao)
                Dim SubNomeCliente As New Chunk(FrmCadastroOS.cboCliente.Text, FontDescricao)
                ' Dim FraseCliente As New Paragraph
                '  FraseCliente.Add(DesNomeCliente)
                ' FraseCliente.Add(SubNomeCliente)
                ' FraseCliente.Add(DesCPF)
                ' FraseCliente.Add(NumCPF)
                ' Doc.Add(FraseCliente)
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\ESPAÇADOR-------------------------------------
                Doc.Add(New Paragraph("  ", font:=fonteEspacador))

                '\\ADICIONAR ENDEREÇO DE ENTREGA

                '\\ESPAÇAMENTO-----------------------------------------------
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\DESCRIÇÃO DE ITENS DO PEDIDO*********************************************************************************************
                Dim ParaItens As New Paragraph
                ParaItens.Alignment = Element.ALIGN_BOTTOM
                ParaItens.Font = FontDescricao

                Dim Data, Mes, Ano, mesNome

                Data = CDate(txtDataInicial.Text)
                Mes = Month(Data)
                mesNome = MonthName(Mes)
                Ano = Year(Data)

                '  Dim MesNome As String = MonthName(Mes)

                ParaItens.Add("| RELATÓRIO MENSAL DE GASTOS         MÊS REFERÊNCIA ( " & mesNome.ToString.ToUpper & "/" & Ano & " )")
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

                '\\OCULTAR COLUNA X

                col10 = 50
                col20 = 50
                col30 = 50
                col40 = 50
                col50 = 20
                col60 = 50
                col70 = 50
                col80 = 50
                col90 = 50
                col100 = 50
                col110 = 0
                col120 = 0

                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\DATAGRID PRINCIPAL*****************************************************************************
                Dim pdfTable2 As New PdfPTable(dgvProdutoInicio.ColumnCount)

                With pdfTable2
                        .DefaultCell.Padding = 2
                        .WidthPercentage = 100
                        .DefaultCell.BorderWidth = 0.5
                        .HorizontalAlignment = Element.ALIGN_CENTER
                        Dim widths3 As Single() = New Single() {col10, col20} ', col30, col40, col50, col60, col70, col80, col90, col110}
                        pdfTable2.SetWidths(widths3)
                End With

                '\\ADICIONAR LINHAS
                For Each column As DataGridViewColumn In dgvProdutoInicio.Columns
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

                Dim limite As Double = 0
                For Each row As DataGridViewRow In dgvProdutoInicio.Rows
                        limite += 1

                        If limite > dgvProdutoInicio.Rows.Count Then
                                If dgvProdutoInicio.Rows.Count = 1 Then
                                Else

                                        GoTo sair
                                End If
                        End If

                        For Each cell As DataGridViewCell In row.Cells
                                line += 1

                                Dim texto As String

                                If line > 2 Then
                                        line = 1

                                End If

                                'texto = cell.Value.ToString

                                Select Case line

                                        Case 1
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 2
                                                texto = cell.Value
                                                pdfTable2.AddCell(FormatPhrase(Dinheiro(texto)))

                                        Case 3
                                                texto = cell.Value
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 4
                                                texto = cell.Value
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 5
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 6
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 7
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 8
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase("R$ " & texto))

                                        Case 9
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case 10
                                                texto = cell.Value.ToString
                                                pdfTable2.AddCell(FormatPhrase(texto))

                                        Case Else

                                End Select
                        Next
                Next

sair:

                ' *******************************************************************************************************************************

                Doc.Add(pdfTable2)

                Dim ParaItens2 As New Paragraph
                ParaItens.Alignment = Element.ALIGN_BOTTOM
                ParaItens.Font = FontDescricao
                ParaItens.Add("ADICIONAIS ")
                Doc.Add(ParaItens2)

                '\\ESPACAMENTO-------------------------------
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\DESCRIÇÃO PAGAMENTO**************************************************************************************************************************
                Dim ParaPagamento As New Paragraph
                ParaPagamento.Alignment = Element.ALIGN_BOTTOM
                ParaPagamento.Font = FontDescricao
                ParaPagamento.Add("| FORMA / CONDIÇÕES DE PAGAMENTO  ")
                '   Doc.Add(ParaPagamento)

                '\\SEPARADOR ---------------------------------

                '\\ESPAÇAMENTO--------------------------------
                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                '\\FRASE E LOCAL DE ASSINATURA DO RECEBEDOR E DO COMPRADOR*******************************************************************************************

                Connect.Conectardb("SELECT SUM(Valor) as Total FROM tbFinanceiro WHERE Tipo='Despesa' AND DataLancamento>#" & txtDataInicial.Text & "# AND DataLancamento<#" & txtDataFinal.Text & "#")

                Dim ValorTotal As Double

                On Error Resume Next
                ValorTotal = cdr("Total")

                Dim FraseValor = "Total de Gastos  " & Dinheiro(ValorTotal)

                Dim Linha As New Paragraph(FraseValor, fontCanhoto)

                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                Doc.Add(Separador5)

                Doc.Add(New Paragraph("  ", font:=FontEspaco))

                Dim Descr As New Chunk("      Assinatura do Contratante                                                           Assinatura do Contratado   ")
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
                Doc.Add(Linha)
                ' Doc.Add(ParaAss1)
                ' paraAss2.Add(Descr)
                ' Doc.Add(paraAss2)

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
                '   DataImpressao.Add("Impresso em: ")
                ' DataImpressao.Add(DataAtual)
                '  DataImpressao.Add("   ")
                '  DataImpressao.Add(HoraAtual)
                ' Doc.Add(DataImpressao)
                Dim Usuario As New Paragraph
                Usuario.Font = fontCanhotoNegrito
                Usuario.Alignment = Element.ALIGN_RIGHT
                Dim DesUsuario As New Chunk("Usuario: ")
                Dim NomeUsuario As New Chunk(ControleOS.Usuario.Nome)

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

        Public Function FormatPhrase(value As String) As Phrase
                Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, Font.Bold, BaseColor.DARK_GRAY))
        End Function

        Public Function FormatPhrase2(value As String) As Phrase
                Return New Phrase(value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))
        End Function

        Private Sub dgvProdutoInicio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProdutoInicio.CellFormatting
                dgvProdutoInicio.Columns(1).DefaultCellStyle.Format = "C2"

        End Sub

        Private Sub FrmRelatorioFinanceiro_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        End Sub
End Class