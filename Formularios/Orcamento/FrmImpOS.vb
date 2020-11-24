Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmImpOS

    Public NomeDocumento As String
    Public col10, col20, col30, col40, col50, col60, col70, col80, col90, col100, col110, col120 As String
    Public OSDI = FrmCadastroOS.txtOSID.Text
    Public Consulta As String = "'OS " & OSDI & "'"
    Public ValorReceber
    Public Pago As Double

    Private Sub btnGerar_Click(sender As Object, e As EventArgs)
        GerarPDF()
    End Sub

    Private Sub FrmImpOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta linha de código carrega dados na tabela 'SistemaGEDataSet.tbFinanceiro'. Você pode movê-la ou removê-la conforme necessário.

        Me.TbProdutoVendaTableAdapter2.OSeInicio(Me.DataSetX.tbProdutoVenda, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
        Me.TbProdutoVendaTableAdapter1.OSeAdicional(Me.DataSety.tbProdutoVenda, New System.Nullable(Of Integer)(CType(FrmCadastroOS.txtOSID.Text, Integer)))
        Me.TbFinanceiroTableAdapter.PorOSx(Me.SistemaGEDataSet.tbFinanceiro, "OS " & FrmCadastroOS.txtOSID.Text)

        GerarPDF()

    End Sub

    Public Sub GerarPDF()

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

        ''\\FORMAÇÃO DO ENDEREÇO DO CANHOTO***************************************************************************************
        Dim EnderecoCliente As New Phrase
        EnderecoCliente.Font = fontCanhoto
        Dim CanLogradouro As New Chunk(FrmCadastroOS.txtEndRua.Text, FontDescricao)
        Dim CanNumero As New Chunk(FrmCadastroOS.txtEndNumero.Text, FontDescricao)
        Dim CanBairro As New Chunk(FrmCadastroOS.txtEndBairro.Text, FontDescricao)
        Dim CanCidade As New Chunk(FrmCadastroOS.txtEndCidade.Text, FontDescricao)
        Dim CanUF As New Chunk(FrmCadastroOS.txtEndUF.Text, FontDescricao)
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
        Dim arquivoimagem As String = "D:\Empresa\Dev\ControleOS\Resources\NLG.png"
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
        Dim DescCliente As New Paragraph("| DADOS DO ORÇAMENTO", FontDescricao)
        Doc.Add(DescCliente)

        '\\FORMAÇÃO DA FRASE (PEDIDO + NUMERO DO PEDIDO)
        Dim ImagemOSID As New Paragraph
        ImagemOSID.Alignment = Element.ALIGN_BOTTOM
        ImagemOSID.Font = FontCabecalhoPage
        ImagemOSID.Add("ORÇAMENTO:  " & FrmCadastroOS.txtOSID.Text)

        '\\SEPARADOR ------------------------------------------
        Dim Separador As New Paragraph("______________________________________________________________________________")
        Separador.Alignment = Element.ALIGN_TOP
        Separador.Font = FontSeparador
        Doc.Add(Separador)

        'FORMAÇÃO DA FRASE ( CPF ) ------------------------------
        Dim DesCPF As New Chunk("          CPF: ", FontSubDescricao)
        Dim NumCPF As New Chunk(FrmCadastroOS.txtCPF.Text, FontDescricao)
        Dim NomePedido As New Chunk("          ORÇAMENTO: ", FontSubDescricao)
        Dim PedidoNumber As New Chunk(FrmCadastroOS.txtOSID.Text, FontDescricao)
        Dim FrasePedido As New Phrase
        FrasePedido.Add(NomePedido)
        FrasePedido.Add(PedidoNumber)
        Doc.Add(FrasePedido)

        '\\FORMAÇÃO DA FRASE ( INFORMAÇÕES DO CLIENTE )--------------------------
        Dim DesNomeCliente As New Chunk("          CLIENTE:  ", FontSubDescricao)
        Dim SubNomeCliente As New Chunk(FrmCadastroOS.cboCliente.Text, FontDescricao)
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
        ParaEnderecoCliente.Add("| ENDEREÇO DO CLIENTE  ")
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

        '\\LARGURA DA COLUNAS DO TABLE)*****************************************************************************

        '\\OCULTAR COLUNA X

        col10 = 0
        col20 = 100
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

        If chkTotalMDO.Checked = True Then
            col60 = 0
        End If

        If chkPrestador.Checked = True Then
            col80 = 0
        End If

        If chkstatus.Checked = True Then
            col90 = 0
        End If

        If chkTotalServiço.Checked = True Then
            col70 = 0
        End If

        col100 = 0

        Dim DesTableInicio As New Chunk("Serviços Iniciais (esta tabela deverá ser DESCONSIDERADA caso haja adcionais)", FontSubDescricao)
        Doc.Add(DesTableInicio)

        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\DATAGRID PRODUTOS(sem a coluna custo 1 ADICIONAL)*****************************************************************************
        Dim pdfTable2 As New PdfPTable(dgvProdutoInicio.ColumnCount)

        With pdfTable2
            .DefaultCell.Padding = 2
            .WidthPercentage = 100
            .DefaultCell.BorderWidth = 0.5
            .HorizontalAlignment = Element.ALIGN_CENTER
            Dim widths3 As Single() = New Single() {col10, col20, col30, col40, col50, col60, col70, col80, col90, col100, col110}
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
        For Each row As DataGridViewRow In dgvProdutoInicio.Rows
            For Each cell As DataGridViewCell In row.Cells
                line += 1
                Dim texto As String

                If line > 11 Then
                    line = 1

                End If

                'texto = cell.Value.ToString

                Select Case line

                    Case 1
                        texto = cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 2
                        texto = cell.Value
                        pdfTable2.AddCell(FormatPhrase(texto))

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
                        texto = "R$ " & cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 7
                        texto = "R$ " & cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 8
                        texto = cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 9
                        texto = cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 10
                        texto = cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case 11
                        texto = cell.Value.ToString
                        pdfTable2.AddCell(FormatPhrase(texto))

                    Case Else

                End Select
            Next
        Next

        ' *******************************************************************************************************************************

        Dim pdfTable3 As New PdfPTable(dgvProdutoadicional.ColumnCount)
        With pdfTable3
            .DefaultCell.Padding = 2
            .WidthPercentage = 100
            .DefaultCell.BorderWidth = 0.5
            .HorizontalAlignment = Element.ALIGN_CENTER
            Dim widths3 As Single() = New Single() {col10, col20, col30, col40, col50, col60, col70, col80, col90, col100, col110}
            pdfTable3.SetWidths(widths3)
        End With
        '\\ADICIONAR LINHAS
        For Each column As DataGridViewColumn In dgvProdutoadicional.Columns
            Dim TamanhoTableCabecalho As Integer = 5 '\\TAMANHO DAS FONTES DE CABEÇALHO  NA IMPRESSAO DA OS
            Dim FontCabecalho As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, Font.Bold, BaseColor.RED)
            Dim cell As New PdfPCell(New Phrase(column.HeaderText, FontDescricao))
            cell.HorizontalAlignment = Element.ALIGN_LEFT
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            If column.HeaderText.GetTypeCode = vbString Then
            Else
            End If
            pdfTable3.AddCell(cell)
        Next

        line = 0
        For Each row As DataGridViewRow In dgvProdutoadicional.Rows
            For Each cell As DataGridViewCell In row.Cells
                line += 1
                Dim texto As String
                If line > 11 Then
                    line = 1
                End If

                Select Case line

                    Case 1
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 2
                        texto = cell.Value
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 3
                        texto = cell.Value
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 4
                        texto = cell.Value
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 5
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 6
                        texto = "R$ " & cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 7
                        texto = "R$ " & cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 8
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 9
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 10
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case 11
                        texto = cell.Value.ToString
                        pdfTable3.AddCell(FormatPhrase(texto))

                    Case Else

                End Select

            Next
        Next

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

        If dgvProdutoadicional.Rows.Count > 0 Then
            Dim DesTableAdicional As New Paragraph("Serviços Adicionais", FontSubDescricao) '\\DESCRIÇÃO DA SEGUNDA TABELA
            Doc.Add(DesTableAdicional)
        End If

        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        If dgvProdutoadicional.Rows.Count > 0 Then
            Doc.Add(pdfTable3)
        End If

        '====================================================================================================================================================

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
        Doc.Add(Separador5)

        '\\ESPAÇAMENTO--------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        '\\TABLE DE PAGAMENTO***************************************************************************************************************************
        Dim pdfTablePagamento As New PdfPTable(dgvFinanceiro.ColumnCount)
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
            Dim widths As Single() = New Single() {col21, col22, col23, col24}
            pdfTablePagamento.SetWidths(widths)
        End With
        '\\ADICIONAR LINHAS--------------------
        For Each column As DataGridViewColumn In dgvFinanceiro.Columns
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
        For Each row As DataGridViewRow In dgvFinanceiro.Rows
            Dim lin As Integer = 0
            For Each cell As DataGridViewCell In row.Cells
                Dim texto As String
                '\\CONTADOR DE COLUNAS
                lin += 1
                If lin > 4 Then
                    lin = 1
                End If

                texto = cell.Value.ToString

                Select Case lin

                    Case 1
                        pdfTablePagamento.AddCell(FormatPhrase(texto))

                    Case 2
                        texto = cell.Value
                        pdfTablePagamento.AddCell(FormatPhrase(texto))

                    Case 3
                        texto = cell.Value
                        pdfTablePagamento.AddCell(FormatPhrase(texto))

                    Case 4
                        texto = "R$ " & cell.Value.ToString
                        pdfTablePagamento.AddCell(FormatPhrase(texto))

                    Case Else

                        '  texto = "R$ " & cell.Value.ToString
                        ' pdfTablePagamento.AddCell(FormatPhrase(texto))

                End Select

            Next
        Next
        If chkOcultarPag.Checked = False Then
            Doc.Add(pdfTablePagamento) '\\REVISAR $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            Doc.Add(ParaPagamento)
        End If

        '\\ESPAÇAMENTO--------------------------------
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))
        Doc.Add(New Paragraph("  ", font:=FontEspaco))

        If chkOcultarTotais.Checked = False Then

            '\\TABELA DO TOTAL********************************************************************************************************************************

            '\\BUSCAR DADOS DE PAGAMENTO------------------

            Dim Restante

            Dim ComandoDebitos As String = "SELECT * FROM tbFinanceiroSoma WHERE NumeroDocumento='OS " & FrmCadastroOS.txtOSID.Text & "'"

            Connect.Conectardb(ComandoDebitos)
            If cdr.HasRows = True Then
                Pago = cdr.Item("Foi Pago")
                'Restante = cdr.Item("Não Pago")
                Connect.Desconectardb()
            Else
                Restante = FrmPDV.txtSomaPDV.Text
                Connect.Desconectardb()
            End If

            '=========================================================================================================================================================================================

            If OSDI > 0 Then '\\VERIFICAR SE O NUMERO DA OS É VALIDO

                Connect.Conectardb("SELECT OSID, SUM(TotalServico) AS Total FROM tbProdutoVenda GROUP BY OSID HAVING (OSID =" & OSDI & ")")

                If cdr.HasRows = True Then '\\VERIFICAR SE EXISTE DADOS RELACIONADO A OS NO BANCO DE DADOS

                    ValorReceber = cdr.Item("Total")
                    Connect.Desconectardb()
                Else

                    SQL.Notificao("", "NÃO EXISTE DADOS RELACIONADO A ESSA OS")
                End If
            Else

                SQL.Notificao("", "O NÚMERO DA OS NÃO É VALIDO")

            End If

            Restante = "R$ " & FormatNumber(ValorReceber - Pago, 2)

            '            txtTotalPago.Text = "R$ " & FormatNumber(ValorRestante(), 2)

            '            txtValorReceber.Text = ValorReceber - ValorRestante()

            '========================================================================================================================================================================================
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
            table.AddCell(FormatPhrase2(FrmPDV.txtSomaPDV.Text))
            table.AddCell(FormatPhrase2(FrmPDV.txtPrecoFrete.Text))
            table.AddCell(FormatPhrase2("R$ " & Pago))
            table.AddCell(FormatPhrase2("R$ " & Restante))

            '\\ADIÇÃO DE FRASE
            Doc.Add(table)

        End If

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

    'Private Sub btnAbrirPDF_Click_1(sender As Object, e As EventArgs) Handles btnAbrirPDF.Click
    '    OpenFileDialog1.ShowDialog()
    '    AxAcroPDF1.src = OpenFileDialog1.FileName
    'End Sub

End Class