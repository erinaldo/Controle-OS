<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPDV
        'Inherits System.Windows.Forms.Form

        'Descartar substituições de formulário para limpar a lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	      Try
		    If disposing AndAlso components IsNot Nothing Then
			  components.Dispose()
		    End If
	      Finally
		    MyBase.Dispose(disposing)
	      End Try
        End Sub

        'Exigido pelo Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
        'Pode ser modificado usando o Windows Form Designer.  
        'Não o modifique usando o editor de códigos.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
	      Me.components = New System.ComponentModel.Container()
	      Dim GêneroLabel As System.Windows.Forms.Label
	      Dim CustoLabel As System.Windows.Forms.Label
	      Dim Saldo_EstoqueLabel As System.Windows.Forms.Label
	      Dim Label3 As System.Windows.Forms.Label
	      Dim Label5 As System.Windows.Forms.Label
	      Dim Categoria_PadrãoLabel As System.Windows.Forms.Label
	      Dim Label13 As System.Windows.Forms.Label
	      Dim Label7 As System.Windows.Forms.Label
	      Dim ProdutoIDLabel As System.Windows.Forms.Label
	      Dim ComplementoLabel As System.Windows.Forms.Label
	      Dim CodEndLabel As System.Windows.Forms.Label
	      Dim Label12 As System.Windows.Forms.Label
	      Dim UFLabel As System.Windows.Forms.Label
	      Dim Label10 As System.Windows.Forms.Label
	      Dim Label2 As System.Windows.Forms.Label
	      Dim TipoLabel As System.Windows.Forms.Label
	      Dim LogradouroLabel As System.Windows.Forms.Label
	      Dim CidadeLabel As System.Windows.Forms.Label
	      Dim EndNumeroLabel As System.Windows.Forms.Label
	      Dim BairroLabel As System.Windows.Forms.Label
	      Dim CPFLabel As System.Windows.Forms.Label
	      Dim Label19 As System.Windows.Forms.Label
	      Dim Label20 As System.Windows.Forms.Label
	      Dim Label23 As System.Windows.Forms.Label
	      Dim Label6 As System.Windows.Forms.Label
	      Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	      Me.TbProdutoVendaPDVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataPdv1 = New ControleOS.DataPdv()
	      Me.TbProdutoPDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataPdv = New ControleOS.DataPdv()
	      Me.TbClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.ProdutoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TbEndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbProdutoVendaPDVvincBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbPedido2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.DataPdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbProdutoVendaPDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.TbClientesTableAdapter = New ControleOS.DataPdvTableAdapters.tbClientesTableAdapter()
	      Me.TbProdutoVendaPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoVendaPDVTableAdapter()
	      Me.TbProdutoPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoPDVTableAdapter()
	      Me.TableAdapterManager = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
	      Me.TbEndTableAdapter = New ControleOS.DataPdvTableAdapters.tbEndTableAdapter()
	      Me.EntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
	      Me.EntregaTableAdapter = New ControleOS.DataPdvTableAdapters.EntregaTableAdapter()
	      Me.TbPedido2TableAdapter = New ControleOS.DataPdvTableAdapters.tbPedido2TableAdapter()
	      Me.TbFinanceiroTableAdapter = New ControleOS.DataPdvTableAdapters.tbFinanceiroTableAdapter()
	      Me.TbProdutoVendaPDVvincTableAdapter = New ControleOS.DataPdvTableAdapters.tbProdutoVendaPDVvincTableAdapter()
	      Me.tmAtualizardgv = New System.Windows.Forms.Timer(Me.components)
	      Me.txtCodCliente = New System.Windows.Forms.TextBox()
	      Me.Label18 = New System.Windows.Forms.Label()
	      Me.txtSomaPDV = New System.Windows.Forms.Label()
	      Me.Label14 = New System.Windows.Forms.Label()
	      Me.lblkPedidoVinculado = New System.Windows.Forms.Label()
	      Me.Label1 = New System.Windows.Forms.Label()
	      Me.lblRetirar = New System.Windows.Forms.Label()
	      Me.Label9 = New System.Windows.Forms.Label()
	      Me.Label11 = New System.Windows.Forms.Label()
	      Me.rdOcultarColCusto = New System.Windows.Forms.CheckBox()
	      Me.cboTabelaPagamento = New System.Windows.Forms.ComboBox()
	      Me.txtCategoriaProduto = New System.Windows.Forms.TextBox()
	      Me.cboTabela = New System.Windows.Forms.ComboBox()
	      Me.txtValorVendaTotal = New System.Windows.Forms.TextBox()
	      Me.chkRetirar = New System.Windows.Forms.ComboBox()
	      Me.txtCusto = New System.Windows.Forms.TextBox()
	      Me.txtGenero = New System.Windows.Forms.TextBox()
	      Me.txtUnidade = New System.Windows.Forms.TextBox()
	      Me.txtQuantidade = New System.Windows.Forms.TextBox()
	      Me.txtSaldoEstoque = New System.Windows.Forms.TextBox()
	      Me.txtProduto = New System.Windows.Forms.TextBox()
	      Me.dgvPagamento = New System.Windows.Forms.DataGridView()
	      Me.SituacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataLancamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.VencimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.FormaPagamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RazaoSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.InscricaoEstadualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GêneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.UnidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NumeroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SituacaoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataLancamentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.VencimentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.IdentificacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorPagoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PlanoContasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.FormaPagamentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GêneroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.UnidadeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NumeroDocumentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SituacaoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataLancamentoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.VencimentoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DescricaoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.IdentificacaoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorPagoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PlanoContasDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.FormaPagamentoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ClienteIDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.PedidoIDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoIDDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.GeneroDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SaldoEstoqueDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CustoTotalDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.NomeClienteDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.QuantidadeDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotalDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.RetiradoDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.lblNumeroPedido = New System.Windows.Forms.Label()
	      Me.txtProdutoID = New System.Windows.Forms.TextBox()
	      Me.txtCodBarras = New System.Windows.Forms.TextBox()
	      Me.Panel5 = New System.Windows.Forms.Panel()
	      Me.btnRetQuant = New System.Windows.Forms.Button()
	      Me.btnAddQuant = New System.Windows.Forms.Button()
	      Me.btnAdicionarProduto = New System.Windows.Forms.Button()
	      Me.txtCustoTotal = New System.Windows.Forms.TextBox()
	      Me.txtSoma = New System.Windows.Forms.TextBox()
	      Me.txtSomaTotal = New System.Windows.Forms.TextBox()
	      Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
	      Me.Panel3 = New System.Windows.Forms.Panel()
	      Me.lblProdutoDesc = New System.Windows.Forms.Label()
	      Me.Button1 = New System.Windows.Forms.Button()
	      Me.txtTipo = New System.Windows.Forms.TextBox()
	      Me.lblPrecoFrete = New System.Windows.Forms.Label()
	      Me.txtComplemento = New System.Windows.Forms.TextBox()
	      Me.txtLogradouro = New System.Windows.Forms.TextBox()
	      Me.txtPrecoFrete = New System.Windows.Forms.TextBox()
	      Me.txtInscEstadual = New System.Windows.Forms.TextBox()
	      Me.chkEntDif = New System.Windows.Forms.CheckBox()
	      Me.txtUF = New System.Windows.Forms.TextBox()
	      Me.txtEndNumero = New System.Windows.Forms.TextBox()
	      Me.txtContato = New System.Windows.Forms.TextBox()
	      Me.dgvCliente = New System.Windows.Forms.DataGridView()
	      Me.chkEntrega = New System.Windows.Forms.CheckBox()
	      Me.txtCidade = New System.Windows.Forms.TextBox()
	      Me.txtBairro = New System.Windows.Forms.TextBox()
	      Me.txtCPFCliente = New System.Windows.Forms.TextBox()
	      Me.txtEndID = New System.Windows.Forms.TextBox()
	      Me.txtCliente = New System.Windows.Forms.TextBox()
	      Me.btnshow1 = New System.Windows.Forms.Button()
	      Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
	      Me.PictureBox4 = New System.Windows.Forms.PictureBox()
	      Me.Label15 = New System.Windows.Forms.Label()
	      Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
	      Me.PictureBox5 = New System.Windows.Forms.PictureBox()
	      Me.Label16 = New System.Windows.Forms.Label()
	      Me.dgvEnd = New System.Windows.Forms.DataGridView()
	      Me.btnAddPessoa = New System.Windows.Forms.Button()
	      Me.btnMostraEnd = New System.Windows.Forms.Button()
	      Me.Panel2 = New System.Windows.Forms.Panel()
	      Me.btnCarregarPedido2 = New System.Windows.Forms.Button()
	      Me.btnVoltar2 = New System.Windows.Forms.Button()
	      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
	      Me.Panel13 = New System.Windows.Forms.Panel()
	      Me.Panel12 = New System.Windows.Forms.Panel()
	      Me.Panel9 = New System.Windows.Forms.Panel()
	      Me.txtItens = New System.Windows.Forms.TextBox()
	      Me.Panel8 = New System.Windows.Forms.Panel()
	      Me.Panel10 = New System.Windows.Forms.Panel()
	      Me.Label26 = New System.Windows.Forms.Label()
	      Me.btnRE = New System.Windows.Forms.Button()
	      Me.Label25 = New System.Windows.Forms.Label()
	      Me.btnAgendarEntrega = New System.Windows.Forms.Button()
	      Me.Label24 = New System.Windows.Forms.Label()
	      Me.btnPagamento = New System.Windows.Forms.Button()
	      Me.Label4 = New System.Windows.Forms.Label()
	      Me.btnImprimir = New System.Windows.Forms.Button()
	      Me.Label22 = New System.Windows.Forms.Label()
	      Me.btnVoltar = New System.Windows.Forms.Button()
	      Me.grpshow2 = New System.Windows.Forms.Button()
	      Me.Label21 = New System.Windows.Forms.Label()
	      Me.Label17 = New System.Windows.Forms.Label()
	      Me.btnCarregarPedido = New System.Windows.Forms.Button()
	      Me.Panel11 = New System.Windows.Forms.Panel()
	      Me.Panel1 = New System.Windows.Forms.Panel()
	      Me.Panel6 = New System.Windows.Forms.Panel()
	      Me.PanelProdutos = New System.Windows.Forms.Panel()
	      Me.txtAddProduto2 = New System.Windows.Forms.Button()
	      Me.Label8 = New System.Windows.Forms.Label()
	      Me.txtCodePesq = New System.Windows.Forms.TextBox()
	      Me.btnConfirmarEscolha = New System.Windows.Forms.Button()
	      Me.lblPesquisarProdutos = New System.Windows.Forms.Label()
	      Me.txtPesqProduto = New System.Windows.Forms.TextBox()
	      Me.dgvListaProduto = New System.Windows.Forms.DataGridView()
	      Me.SaldoEstoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.dgvRE = New System.Windows.Forms.DataGridView()
	      Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
	      Me.dgvProdutos = New System.Windows.Forms.DataGridView()
	      Me.ProdutoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CategoriaPadraoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorVendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.SomaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ValorCustoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.Retirado = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.x = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.dgvProdutosVinc = New System.Windows.Forms.DataGridView()
	      Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.dgvProdutosSemCusto = New System.Windows.Forms.DataGridView()
	      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.Panel4 = New System.Windows.Forms.Panel()
	      Me.CodEndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.LogradouroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.EndNumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.UFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.ComplementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.TipoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
	      Me.dgvContato = New System.Windows.Forms.DataGridView()
	      Me.btnConsulta = New System.Windows.Forms.Button()
	      Me.TextBox1 = New System.Windows.Forms.TextBox()
	      GêneroLabel = New System.Windows.Forms.Label()
	      CustoLabel = New System.Windows.Forms.Label()
	      Saldo_EstoqueLabel = New System.Windows.Forms.Label()
	      Label3 = New System.Windows.Forms.Label()
	      Label5 = New System.Windows.Forms.Label()
	      Categoria_PadrãoLabel = New System.Windows.Forms.Label()
	      Label13 = New System.Windows.Forms.Label()
	      Label7 = New System.Windows.Forms.Label()
	      ProdutoIDLabel = New System.Windows.Forms.Label()
	      ComplementoLabel = New System.Windows.Forms.Label()
	      CodEndLabel = New System.Windows.Forms.Label()
	      Label12 = New System.Windows.Forms.Label()
	      UFLabel = New System.Windows.Forms.Label()
	      Label10 = New System.Windows.Forms.Label()
	      Label2 = New System.Windows.Forms.Label()
	      TipoLabel = New System.Windows.Forms.Label()
	      LogradouroLabel = New System.Windows.Forms.Label()
	      CidadeLabel = New System.Windows.Forms.Label()
	      EndNumeroLabel = New System.Windows.Forms.Label()
	      BairroLabel = New System.Windows.Forms.Label()
	      CPFLabel = New System.Windows.Forms.Label()
	      Label19 = New System.Windows.Forms.Label()
	      Label20 = New System.Windows.Forms.Label()
	      Label23 = New System.Windows.Forms.Label()
	      Label6 = New System.Windows.Forms.Label()
	      CType(Me.TbProdutoVendaPDVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataPdv1, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbProdutoVendaPDVvincBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbPedido2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.DataPdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.TbProdutoVendaPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.EntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel5.SuspendLayout()
	      Me.Panel3.SuspendLayout()
	      CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.ToolStripContainer1.ContentPanel.SuspendLayout()
	      Me.ToolStripContainer1.SuspendLayout()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.ToolStripContainer2.ContentPanel.SuspendLayout()
	      Me.ToolStripContainer2.SuspendLayout()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvEnd, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel2.SuspendLayout()
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel13.SuspendLayout()
	      Me.Panel12.SuspendLayout()
	      Me.Panel9.SuspendLayout()
	      Me.Panel8.SuspendLayout()
	      Me.Panel10.SuspendLayout()
	      Me.Panel11.SuspendLayout()
	      Me.Panel1.SuspendLayout()
	      Me.Panel6.SuspendLayout()
	      Me.PanelProdutos.SuspendLayout()
	      CType(Me.dgvListaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvRE, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvProdutosVinc, System.ComponentModel.ISupportInitialize).BeginInit()
	      CType(Me.dgvProdutosSemCusto, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.Panel4.SuspendLayout()
	      CType(Me.dgvContato, System.ComponentModel.ISupportInitialize).BeginInit()
	      Me.SuspendLayout()
	      '
	      'GêneroLabel
	      '
	      GêneroLabel.AutoSize = True
	      GêneroLabel.BackColor = System.Drawing.Color.Transparent
	      GêneroLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      GêneroLabel.ForeColor = System.Drawing.Color.Black
	      GêneroLabel.Location = New System.Drawing.Point(131, 3)
	      GêneroLabel.Name = "GêneroLabel"
	      GêneroLabel.Size = New System.Drawing.Size(40, 15)
	      GêneroLabel.TabIndex = 28
	      GêneroLabel.Text = "Gênero:"
	      '
	      'CustoLabel
	      '
	      CustoLabel.AutoSize = True
	      CustoLabel.BackColor = System.Drawing.Color.Transparent
	      CustoLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      CustoLabel.ForeColor = System.Drawing.Color.Black
	      CustoLabel.Location = New System.Drawing.Point(254, 3)
	      CustoLabel.Name = "CustoLabel"
	      CustoLabel.Size = New System.Drawing.Size(35, 15)
	      CustoLabel.TabIndex = 36
	      CustoLabel.Text = "Custo:"
	      '
	      'Saldo_EstoqueLabel
	      '
	      Saldo_EstoqueLabel.AutoSize = True
	      Saldo_EstoqueLabel.BackColor = System.Drawing.Color.Transparent
	      Saldo_EstoqueLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Saldo_EstoqueLabel.ForeColor = System.Drawing.Color.Black
	      Saldo_EstoqueLabel.Location = New System.Drawing.Point(130, 41)
	      Saldo_EstoqueLabel.Name = "Saldo_EstoqueLabel"
	      Saldo_EstoqueLabel.Size = New System.Drawing.Size(70, 15)
	      Saldo_EstoqueLabel.TabIndex = 29
	      Saldo_EstoqueLabel.Text = "Saldo Estoque:"
	      '
	      'Label3
	      '
	      Label3.Location = New System.Drawing.Point(81, 9)
	      Label3.Name = "Label3"
	      Label3.Size = New System.Drawing.Size(48, 17)
	      Label3.TabIndex = 95
	      '
	      'Label5
	      '
	      Label5.AutoSize = True
	      Label5.BackColor = System.Drawing.Color.Transparent
	      Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label5.ForeColor = System.Drawing.Color.Black
	      Label5.Location = New System.Drawing.Point(2, 3)
	      Label5.Name = "Label5"
	      Label5.Size = New System.Drawing.Size(73, 16)
	      Label5.TabIndex = 39
	      Label5.Text = "Quantidade:"
	      '
	      'Categoria_PadrãoLabel
	      '
	      Categoria_PadrãoLabel.AutoSize = True
	      Categoria_PadrãoLabel.BackColor = System.Drawing.Color.Transparent
	      Categoria_PadrãoLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Categoria_PadrãoLabel.ForeColor = System.Drawing.Color.Black
	      Categoria_PadrãoLabel.Location = New System.Drawing.Point(3, 41)
	      Categoria_PadrãoLabel.Name = "Categoria_PadrãoLabel"
	      Categoria_PadrãoLabel.Size = New System.Drawing.Size(82, 15)
	      Categoria_PadrãoLabel.TabIndex = 27
	      Categoria_PadrãoLabel.Text = "Categoria Padrão:"
	      '
	      'Label13
	      '
	      Label13.AutoSize = True
	      Label13.BackColor = System.Drawing.Color.Transparent
	      Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label13.ForeColor = System.Drawing.Color.Black
	      Label13.Location = New System.Drawing.Point(74, 4)
	      Label13.Name = "Label13"
	      Label13.Size = New System.Drawing.Size(44, 15)
	      Label13.TabIndex = 88
	      Label13.Text = "Unidade:"
	      '
	      'Label7
	      '
	      Label7.AutoSize = True
	      Label7.BackColor = System.Drawing.Color.Transparent
	      Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label7.ForeColor = System.Drawing.Color.Black
	      Label7.Location = New System.Drawing.Point(260, 41)
	      Label7.Name = "Label7"
	      Label7.Size = New System.Drawing.Size(58, 15)
	      Label7.TabIndex = 62
	      Label7.Text = "Custo Total:"
	      '
	      'ProdutoIDLabel
	      '
	      ProdutoIDLabel.AutoSize = True
	      ProdutoIDLabel.BackColor = System.Drawing.Color.Transparent
	      ProdutoIDLabel.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      ProdutoIDLabel.ForeColor = System.Drawing.Color.Black
	      ProdutoIDLabel.Location = New System.Drawing.Point(4, 4)
	      ProdutoIDLabel.Name = "ProdutoIDLabel"
	      ProdutoIDLabel.Size = New System.Drawing.Size(56, 15)
	      ProdutoIDLabel.TabIndex = 26
	      ProdutoIDLabel.Text = "N° Produto:"
	      '
	      'ComplementoLabel
	      '
	      ComplementoLabel.AutoSize = True
	      ComplementoLabel.ForeColor = System.Drawing.Color.Black
	      ComplementoLabel.Location = New System.Drawing.Point(15, 142)
	      ComplementoLabel.Name = "ComplementoLabel"
	      ComplementoLabel.Size = New System.Drawing.Size(74, 13)
	      ComplementoLabel.TabIndex = 54
	      ComplementoLabel.Text = "Complemento:"
	      '
	      'CodEndLabel
	      '
	      CodEndLabel.AutoSize = True
	      CodEndLabel.ForeColor = System.Drawing.Color.Black
	      CodEndLabel.Location = New System.Drawing.Point(12, 63)
	      CodEndLabel.Name = "CodEndLabel"
	      CodEndLabel.Size = New System.Drawing.Size(92, 13)
	      CodEndLabel.TabIndex = 69
	      CodEndLabel.Text = "Código Endereço:"
	      '
	      'Label12
	      '
	      Label12.AutoSize = True
	      Label12.ForeColor = System.Drawing.Color.Black
	      Label12.Location = New System.Drawing.Point(296, 108)
	      Label12.Name = "Label12"
	      Label12.Size = New System.Drawing.Size(47, 13)
	      Label12.TabIndex = 75
	      Label12.Text = "Contato:"
	      '
	      'UFLabel
	      '
	      UFLabel.AutoSize = True
	      UFLabel.ForeColor = System.Drawing.Color.Black
	      UFLabel.Location = New System.Drawing.Point(379, 102)
	      UFLabel.Name = "UFLabel"
	      UFLabel.Size = New System.Drawing.Size(24, 13)
	      UFLabel.TabIndex = 52
	      UFLabel.Text = "UF:"
	      '
	      'Label10
	      '
	      Label10.AutoSize = True
	      Label10.ForeColor = System.Drawing.Color.Black
	      Label10.Location = New System.Drawing.Point(14, 106)
	      Label10.Name = "Label10"
	      Label10.Size = New System.Drawing.Size(94, 13)
	      Label10.TabIndex = 72
	      Label10.Text = "Inscrição Estadual"
	      '
	      'Label2
	      '
	      Label2.AutoSize = True
	      Label2.ForeColor = System.Drawing.Color.Black
	      Label2.Location = New System.Drawing.Point(11, 68)
	      Label2.Name = "Label2"
	      Label2.Size = New System.Drawing.Size(39, 13)
	      Label2.TabIndex = 21
	      Label2.Text = "Cliente"
	      '
	      'TipoLabel
	      '
	      TipoLabel.AutoSize = True
	      TipoLabel.ForeColor = System.Drawing.Color.Black
	      TipoLabel.Location = New System.Drawing.Point(153, 106)
	      TipoLabel.Name = "TipoLabel"
	      TipoLabel.Size = New System.Drawing.Size(31, 13)
	      TipoLabel.TabIndex = 56
	      TipoLabel.Text = "Tipo:"
	      '
	      'LogradouroLabel
	      '
	      LogradouroLabel.AutoSize = True
	      LogradouroLabel.ForeColor = System.Drawing.Color.Black
	      LogradouroLabel.Location = New System.Drawing.Point(107, 62)
	      LogradouroLabel.Name = "LogradouroLabel"
	      LogradouroLabel.Size = New System.Drawing.Size(64, 13)
	      LogradouroLabel.TabIndex = 44
	      LogradouroLabel.Text = "Logradouro:"
	      '
	      'CidadeLabel
	      '
	      CidadeLabel.AutoSize = True
	      CidadeLabel.ForeColor = System.Drawing.Color.Black
	      CidadeLabel.Location = New System.Drawing.Point(186, 102)
	      CidadeLabel.Name = "CidadeLabel"
	      CidadeLabel.Size = New System.Drawing.Size(43, 13)
	      CidadeLabel.TabIndex = 50
	      CidadeLabel.Text = "Cidade:"
	      '
	      'EndNumeroLabel
	      '
	      EndNumeroLabel.AutoSize = True
	      EndNumeroLabel.ForeColor = System.Drawing.Color.Black
	      EndNumeroLabel.Location = New System.Drawing.Point(379, 63)
	      EndNumeroLabel.Name = "EndNumeroLabel"
	      EndNumeroLabel.Size = New System.Drawing.Size(22, 13)
	      EndNumeroLabel.TabIndex = 46
	      EndNumeroLabel.Text = "Nº:"
	      '
	      'BairroLabel
	      '
	      BairroLabel.AutoSize = True
	      BairroLabel.ForeColor = System.Drawing.Color.Black
	      BairroLabel.Location = New System.Drawing.Point(12, 102)
	      BairroLabel.Name = "BairroLabel"
	      BairroLabel.Size = New System.Drawing.Size(37, 13)
	      BairroLabel.TabIndex = 48
	      BairroLabel.Text = "Bairro:"
	      '
	      'CPFLabel
	      '
	      CPFLabel.AutoSize = True
	      CPFLabel.ForeColor = System.Drawing.Color.Black
	      CPFLabel.Location = New System.Drawing.Point(295, 68)
	      CPFLabel.Name = "CPFLabel"
	      CPFLabel.Size = New System.Drawing.Size(68, 13)
	      CPFLabel.TabIndex = 25
	      CPFLabel.Text = "CPF / CNPJ:"
	      '
	      'Label19
	      '
	      Label19.AutoSize = True
	      Label19.BackColor = System.Drawing.Color.Transparent
	      Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label19.ForeColor = System.Drawing.Color.Black
	      Label19.Location = New System.Drawing.Point(4, 67)
	      Label19.Name = "Label19"
	      Label19.Size = New System.Drawing.Size(54, 16)
	      Label19.TabIndex = 103
	      Label19.Text = "Unitário:"
	      '
	      'Label20
	      '
	      Label20.AutoSize = True
	      Label20.BackColor = System.Drawing.Color.Transparent
	      Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label20.ForeColor = System.Drawing.Color.Black
	      Label20.Location = New System.Drawing.Point(122, 64)
	      Label20.Name = "Label20"
	      Label20.Size = New System.Drawing.Size(63, 16)
	      Label20.TabIndex = 105
	      Label20.Text = "Sub Total:"
	      AddHandler Label20.Click, AddressOf Me.Label20_Click
	      '
	      'Label23
	      '
	      Label23.AutoSize = True
	      Label23.BackColor = System.Drawing.Color.Transparent
	      Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label23.ForeColor = System.Drawing.Color.Black
	      Label23.Location = New System.Drawing.Point(4, 3)
	      Label23.Name = "Label23"
	      Label23.Size = New System.Drawing.Size(134, 19)
	      Label23.TabIndex = 111
	      Label23.Text = "Total de Produtos"
	      '
	      'Label6
	      '
	      Label6.AutoSize = True
	      Label6.BackColor = System.Drawing.Color.Transparent
	      Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Label6.ForeColor = System.Drawing.Color.Black
	      Label6.Location = New System.Drawing.Point(3, 5)
	      Label6.Name = "Label6"
	      Label6.Size = New System.Drawing.Size(43, 19)
	      Label6.TabIndex = 113
	      Label6.Text = "Itens"
	      '
	      'TbProdutoVendaPDVBindingSource1
	      '
	      Me.TbProdutoVendaPDVBindingSource1.DataMember = "tbProdutoVendaPDV"
	      Me.TbProdutoVendaPDVBindingSource1.DataSource = Me.DataPdv1
	      '
	      'DataPdv1
	      '
	      Me.DataPdv1.DataSetName = "DataPDV"
	      Me.DataPdv1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'TbProdutoPDVBindingSource
	      '
	      Me.TbProdutoPDVBindingSource.DataMember = "tbProdutoPDV"
	      Me.TbProdutoPDVBindingSource.DataSource = Me.DataPdv
	      '
	      'DataPdv
	      '
	      Me.DataPdv.DataSetName = "DataPDV"
	      Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
	      '
	      'TbClientesBindingSource
	      '
	      Me.TbClientesBindingSource.DataMember = "tbClientes"
	      Me.TbClientesBindingSource.DataSource = Me.DataPdv
	      '
	      'ProdutoID
	      '
	      Me.ProdutoID.DataPropertyName = "ProdutoID"
	      Me.ProdutoID.HeaderText = "Código"
	      Me.ProdutoID.Name = "ProdutoID"
	      Me.ProdutoID.Width = 136
	      '
	      'TbEndBindingSource
	      '
	      Me.TbEndBindingSource.DataMember = "tbEnd"
	      Me.TbEndBindingSource.DataSource = Me.DataPdv
	      '
	      'TbFinanceiroBindingSource
	      '
	      Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
	      Me.TbFinanceiroBindingSource.DataSource = Me.DataPdv1
	      '
	      'TbProdutoVendaPDVvincBindingSource
	      '
	      Me.TbProdutoVendaPDVvincBindingSource.DataMember = "tbProdutoVendaPDVvinc"
	      Me.TbProdutoVendaPDVvincBindingSource.DataSource = Me.DataPdv1
	      '
	      'TbPedido2BindingSource
	      '
	      Me.TbPedido2BindingSource.DataMember = "tbPedido2"
	      Me.TbPedido2BindingSource.DataSource = Me.DataPdv1
	      '
	      'DataPdvBindingSource
	      '
	      Me.DataPdvBindingSource.DataSource = Me.DataPdv
	      Me.DataPdvBindingSource.Position = 0
	      '
	      'TbProdutoVendaPDVBindingSource
	      '
	      Me.TbProdutoVendaPDVBindingSource.DataMember = "tbProdutoVendaPDV"
	      Me.TbProdutoVendaPDVBindingSource.DataSource = Me.DataPdv
	      '
	      'TbClientesTableAdapter
	      '
	      Me.TbClientesTableAdapter.ClearBeforeFill = True
	      '
	      'TbProdutoVendaPDVTableAdapter
	      '
	      Me.TbProdutoVendaPDVTableAdapter.ClearBeforeFill = True
	      '
	      'TbProdutoPDVTableAdapter
	      '
	      Me.TbProdutoPDVTableAdapter.ClearBeforeFill = True
	      '
	      'TableAdapterManager
	      '
	      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
	      Me.TableAdapterManager.EntregaTableAdapter = Nothing
	      Me.TableAdapterManager.tbAnexoPDVTableAdapter = Nothing
	      Me.TableAdapterManager.tbClientesTableAdapter = Me.TbClientesTableAdapter
	      Me.TableAdapterManager.tbContatoTableAdapter = Nothing
	      Me.TableAdapterManager.tbEndTableAdapter = Nothing
	      Me.TableAdapterManager.tbFinanceiroTableAdapter = Nothing
	      Me.TableAdapterManager.tbPedido2TableAdapter = Nothing
	      Me.TableAdapterManager.tbPedido2vincTableAdapter = Nothing
	      Me.TableAdapterManager.tbPedidosAuxTableAdapter = Nothing
	      Me.TableAdapterManager.tbPrecoTabelaTableAdapter = Nothing
	      Me.TableAdapterManager.tbProdutoPDVTableAdapter = Me.TbProdutoPDVTableAdapter
	      Me.TableAdapterManager.tbProdutoVendaPDVTableAdapter = Me.TbProdutoVendaPDVTableAdapter
	      Me.TableAdapterManager.tbProdutoVendaPDVvincTableAdapter = Nothing
	      Me.TableAdapterManager.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
	      '
	      'TbEndTableAdapter
	      '
	      Me.TbEndTableAdapter.ClearBeforeFill = True
	      '
	      'EntregaBindingSource
	      '
	      Me.EntregaBindingSource.DataMember = "Entrega"
	      Me.EntregaBindingSource.DataSource = Me.DataPdv
	      '
	      'EntregaTableAdapter
	      '
	      Me.EntregaTableAdapter.ClearBeforeFill = True
	      '
	      'TbPedido2TableAdapter
	      '
	      Me.TbPedido2TableAdapter.ClearBeforeFill = True
	      '
	      'TbFinanceiroTableAdapter
	      '
	      Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
	      '
	      'TbProdutoVendaPDVvincTableAdapter
	      '
	      Me.TbProdutoVendaPDVvincTableAdapter.ClearBeforeFill = True
	      '
	      'tmAtualizardgv
	      '
	      '
	      'txtCodCliente
	      '
	      Me.txtCodCliente.BackColor = System.Drawing.Color.White
	      Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtCodCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClientesBindingSource, "Código", True))
	      Me.txtCodCliente.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtCodCliente.ForeColor = System.Drawing.Color.Black
	      Me.txtCodCliente.Location = New System.Drawing.Point(265, 9)
	      Me.txtCodCliente.Name = "txtCodCliente"
	      Me.txtCodCliente.Size = New System.Drawing.Size(117, 25)
	      Me.txtCodCliente.TabIndex = 79
	      Me.txtCodCliente.Text = "001"
	      '
	      'Label18
	      '
	      Me.Label18.AutoSize = True
	      Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label18.ForeColor = System.Drawing.Color.Black
	      Me.Label18.Location = New System.Drawing.Point(263, 33)
	      Me.Label18.Name = "Label18"
	      Me.Label18.Size = New System.Drawing.Size(84, 16)
	      Me.Label18.TabIndex = 3
	      Me.Label18.Text = "Registro Cliente"
	      '
	      'txtSomaPDV
	      '
	      Me.txtSomaPDV.AutoSize = True
	      Me.txtSomaPDV.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtSomaPDV.ForeColor = System.Drawing.Color.Black
	      Me.txtSomaPDV.Location = New System.Drawing.Point(143, 11)
	      Me.txtSomaPDV.Name = "txtSomaPDV"
	      Me.txtSomaPDV.Size = New System.Drawing.Size(58, 24)
	      Me.txtSomaPDV.TabIndex = 2
	      Me.txtSomaPDV.Text = "0001"
	      '
	      'Label14
	      '
	      Me.Label14.AutoSize = True
	      Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label14.ForeColor = System.Drawing.Color.Black
	      Me.Label14.Location = New System.Drawing.Point(143, 33)
	      Me.Label14.Name = "Label14"
	      Me.Label14.Size = New System.Drawing.Size(60, 16)
	      Me.Label14.TabIndex = 3
	      Me.Label14.Text = "Valor Total"
	      '
	      'lblkPedidoVinculado
	      '
	      Me.lblkPedidoVinculado.AutoSize = True
	      Me.lblkPedidoVinculado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblkPedidoVinculado.ForeColor = System.Drawing.Color.Black
	      Me.lblkPedidoVinculado.Location = New System.Drawing.Point(15, 32)
	      Me.lblkPedidoVinculado.Name = "lblkPedidoVinculado"
	      Me.lblkPedidoVinculado.Size = New System.Drawing.Size(98, 16)
	      Me.lblkPedidoVinculado.TabIndex = 3
	      Me.lblkPedidoVinculado.Text = "Número do Pedido"
	      '
	      'Label1
	      '
	      Me.Label1.AutoSize = True
	      Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label1.ForeColor = System.Drawing.Color.Black
	      Me.Label1.Location = New System.Drawing.Point(15, 32)
	      Me.Label1.Name = "Label1"
	      Me.Label1.Size = New System.Drawing.Size(98, 16)
	      Me.Label1.TabIndex = 3
	      Me.Label1.Text = "Número do Pedido"
	      '
	      'lblRetirar
	      '
	      Me.lblRetirar.AutoSize = True
	      Me.lblRetirar.BackColor = System.Drawing.Color.Transparent
	      Me.lblRetirar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblRetirar.ForeColor = System.Drawing.Color.Black
	      Me.lblRetirar.Location = New System.Drawing.Point(8, 79)
	      Me.lblRetirar.Name = "lblRetirar"
	      Me.lblRetirar.Size = New System.Drawing.Size(73, 15)
	      Me.lblRetirar.TabIndex = 74
	      Me.lblRetirar.Text = "Entrega/Retirar:"
	      '
	      'Label9
	      '
	      Me.Label9.AutoSize = True
	      Me.Label9.BackColor = System.Drawing.Color.Transparent
	      Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label9.ForeColor = System.Drawing.Color.Black
	      Me.Label9.Location = New System.Drawing.Point(253, 80)
	      Me.Label9.Name = "Label9"
	      Me.Label9.Size = New System.Drawing.Size(74, 15)
	      Me.Label9.TabIndex = 78
	      Me.Label9.Text = "Tabela de Preço"
	      '
	      'Label11
	      '
	      Me.Label11.AutoSize = True
	      Me.Label11.BackColor = System.Drawing.Color.Transparent
	      Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label11.ForeColor = System.Drawing.Color.Black
	      Me.Label11.Location = New System.Drawing.Point(131, 81)
	      Me.Label11.Name = "Label11"
	      Me.Label11.Size = New System.Drawing.Size(97, 15)
	      Me.Label11.TabIndex = 79
	      Me.Label11.Text = "Forma de Pagamento"
	      '
	      'rdOcultarColCusto
	      '
	      Me.rdOcultarColCusto.AutoSize = True
	      Me.rdOcultarColCusto.Checked = True
	      Me.rdOcultarColCusto.CheckState = System.Windows.Forms.CheckState.Checked
	      Me.rdOcultarColCusto.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.rdOcultarColCusto.ForeColor = System.Drawing.Color.Black
	      Me.rdOcultarColCusto.Location = New System.Drawing.Point(244, 8)
	      Me.rdOcultarColCusto.Name = "rdOcultarColCusto"
	      Me.rdOcultarColCusto.Size = New System.Drawing.Size(89, 19)
	      Me.rdOcultarColCusto.TabIndex = 74
	      Me.rdOcultarColCusto.Text = "Ocultar Custo?"
	      Me.rdOcultarColCusto.UseVisualStyleBackColor = True
	      '
	      'cboTabelaPagamento
	      '
	      Me.cboTabelaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
	      Me.cboTabelaPagamento.FormattingEnabled = True
	      Me.cboTabelaPagamento.Location = New System.Drawing.Point(133, 97)
	      Me.cboTabelaPagamento.Name = "cboTabelaPagamento"
	      Me.cboTabelaPagamento.Size = New System.Drawing.Size(118, 21)
	      Me.cboTabelaPagamento.TabIndex = 77
	      '
	      'txtCategoriaProduto
	      '
	      Me.txtCategoriaProduto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "CategoriaPadrao", True))
	      Me.txtCategoriaProduto.Location = New System.Drawing.Point(6, 57)
	      Me.txtCategoriaProduto.Name = "txtCategoriaProduto"
	      Me.txtCategoriaProduto.ReadOnly = True
	      Me.txtCategoriaProduto.Size = New System.Drawing.Size(121, 20)
	      Me.txtCategoriaProduto.TabIndex = 28
	      '
	      'cboTabela
	      '
	      Me.cboTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
	      Me.cboTabela.FormattingEnabled = True
	      Me.cboTabela.Location = New System.Drawing.Point(257, 97)
	      Me.cboTabela.Name = "cboTabela"
	      Me.cboTabela.Size = New System.Drawing.Size(120, 21)
	      Me.cboTabela.TabIndex = 76
	      '
	      'txtValorVendaTotal
	      '
	      Me.txtValorVendaTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
	      Me.txtValorVendaTotal.Location = New System.Drawing.Point(257, 57)
	      Me.txtValorVendaTotal.Name = "txtValorVendaTotal"
	      Me.txtValorVendaTotal.ReadOnly = True
	      Me.txtValorVendaTotal.Size = New System.Drawing.Size(120, 20)
	      Me.txtValorVendaTotal.TabIndex = 63
	      '
	      'chkRetirar
	      '
	      Me.chkRetirar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
	      Me.chkRetirar.FormattingEnabled = True
	      Me.chkRetirar.Location = New System.Drawing.Point(6, 97)
	      Me.chkRetirar.Name = "chkRetirar"
	      Me.chkRetirar.Size = New System.Drawing.Size(121, 21)
	      Me.chkRetirar.TabIndex = 69
	      '
	      'txtCusto
	      '
	      Me.txtCusto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Custo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
	      Me.txtCusto.Location = New System.Drawing.Point(257, 19)
	      Me.txtCusto.Name = "txtCusto"
	      Me.txtCusto.ReadOnly = True
	      Me.txtCusto.Size = New System.Drawing.Size(120, 20)
	      Me.txtCusto.TabIndex = 37
	      '
	      'txtGenero
	      '
	      Me.txtGenero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Gênero", True))
	      Me.txtGenero.Location = New System.Drawing.Point(133, 19)
	      Me.txtGenero.Name = "txtGenero"
	      Me.txtGenero.ReadOnly = True
	      Me.txtGenero.Size = New System.Drawing.Size(118, 20)
	      Me.txtGenero.TabIndex = 29
	      '
	      'txtUnidade
	      '
	      Me.txtUnidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Unidade", True))
	      Me.txtUnidade.Location = New System.Drawing.Point(73, 19)
	      Me.txtUnidade.Name = "txtUnidade"
	      Me.txtUnidade.ReadOnly = True
	      Me.txtUnidade.Size = New System.Drawing.Size(55, 20)
	      Me.txtUnidade.TabIndex = 89
	      '
	      'txtQuantidade
	      '
	      Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.txtQuantidade.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtQuantidade.Location = New System.Drawing.Point(4, 19)
	      Me.txtQuantidade.Name = "txtQuantidade"
	      Me.txtQuantidade.Size = New System.Drawing.Size(112, 38)
	      Me.txtQuantidade.TabIndex = 40
	      Me.txtQuantidade.Text = "1"
	      Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'txtSaldoEstoque
	      '
	      Me.txtSaldoEstoque.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "SaldoEstoque", True))
	      Me.txtSaldoEstoque.Location = New System.Drawing.Point(133, 57)
	      Me.txtSaldoEstoque.Name = "txtSaldoEstoque"
	      Me.txtSaldoEstoque.ReadOnly = True
	      Me.txtSaldoEstoque.Size = New System.Drawing.Size(118, 20)
	      Me.txtSaldoEstoque.TabIndex = 30
	      '
	      'txtProduto
	      '
	      Me.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.txtProduto.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtProduto.Location = New System.Drawing.Point(388, 3)
	      Me.txtProduto.Name = "txtProduto"
	      Me.txtProduto.Size = New System.Drawing.Size(602, 50)
	      Me.txtProduto.TabIndex = 24
	      '
	      'dgvPagamento
	      '
	      Me.dgvPagamento.AllowUserToAddRows = False
	      Me.dgvPagamento.AllowUserToDeleteRows = False
	      Me.dgvPagamento.AutoGenerateColumns = False
	      Me.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvPagamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SituacaoDataGridViewTextBoxColumn, Me.DataLancamentoDataGridViewTextBoxColumn, Me.VencimentoDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn, Me.ValorPagoDataGridViewTextBoxColumn, Me.FormaPagamentoDataGridViewTextBoxColumn})
	      Me.dgvPagamento.DataSource = Me.TbFinanceiroBindingSource
	      Me.dgvPagamento.Location = New System.Drawing.Point(349, 125)
	      Me.dgvPagamento.Name = "dgvPagamento"
	      Me.dgvPagamento.ReadOnly = True
	      Me.dgvPagamento.RowHeadersVisible = False
	      Me.dgvPagamento.Size = New System.Drawing.Size(15, 22)
	      Me.dgvPagamento.TabIndex = 80
	      Me.dgvPagamento.Visible = False
	      '
	      'SituacaoDataGridViewTextBoxColumn
	      '
	      Me.SituacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao"
	      Me.SituacaoDataGridViewTextBoxColumn.HeaderText = "Situação"
	      Me.SituacaoDataGridViewTextBoxColumn.Name = "SituacaoDataGridViewTextBoxColumn"
	      Me.SituacaoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'DataLancamentoDataGridViewTextBoxColumn
	      '
	      Me.DataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn.HeaderText = "Lançamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn.Name = "DataLancamentoDataGridViewTextBoxColumn"
	      Me.DataLancamentoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'VencimentoDataGridViewTextBoxColumn
	      '
	      Me.VencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn.Name = "VencimentoDataGridViewTextBoxColumn"
	      Me.VencimentoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'ValorDataGridViewTextBoxColumn
	      '
	      Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
	      Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
	      Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
	      Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'ValorPagoDataGridViewTextBoxColumn
	      '
	      Me.ValorPagoDataGridViewTextBoxColumn.DataPropertyName = "ValorPago"
	      Me.ValorPagoDataGridViewTextBoxColumn.HeaderText = "Valor Pago"
	      Me.ValorPagoDataGridViewTextBoxColumn.Name = "ValorPagoDataGridViewTextBoxColumn"
	      Me.ValorPagoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'FormaPagamentoDataGridViewTextBoxColumn
	      '
	      Me.FormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn.HeaderText = "Pagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn.Name = "FormaPagamentoDataGridViewTextBoxColumn"
	      Me.FormaPagamentoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'CódigoDataGridViewTextBoxColumn
	      '
	      Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
	      Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
	      Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
	      Me.CódigoDataGridViewTextBoxColumn.Width = 28
	      '
	      'NomeDataGridViewTextBoxColumn1
	      '
	      Me.NomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome"
	      Me.NomeDataGridViewTextBoxColumn1.HeaderText = "Nome"
	      Me.NomeDataGridViewTextBoxColumn1.Name = "NomeDataGridViewTextBoxColumn1"
	      Me.NomeDataGridViewTextBoxColumn1.Width = 28
	      '
	      'CPFDataGridViewTextBoxColumn
	      '
	      Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
	      Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
	      Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
	      Me.CPFDataGridViewTextBoxColumn.Width = 28
	      '
	      'RazaoSocialDataGridViewTextBoxColumn
	      '
	      Me.RazaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial"
	      Me.RazaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial"
	      Me.RazaoSocialDataGridViewTextBoxColumn.Name = "RazaoSocialDataGridViewTextBoxColumn"
	      Me.RazaoSocialDataGridViewTextBoxColumn.Width = 28
	      '
	      'InscricaoEstadualDataGridViewTextBoxColumn
	      '
	      Me.InscricaoEstadualDataGridViewTextBoxColumn.DataPropertyName = "InscricaoEstadual"
	      Me.InscricaoEstadualDataGridViewTextBoxColumn.HeaderText = "InscricaoEstadual"
	      Me.InscricaoEstadualDataGridViewTextBoxColumn.Name = "InscricaoEstadualDataGridViewTextBoxColumn"
	      Me.InscricaoEstadualDataGridViewTextBoxColumn.Width = 28
	      '
	      'ProdutoDataGridViewTextBoxColumn2
	      '
	      Me.ProdutoDataGridViewTextBoxColumn2.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn2.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn2.Name = "ProdutoDataGridViewTextBoxColumn2"
	      Me.ProdutoDataGridViewTextBoxColumn2.Width = 31
	      '
	      'CustoDataGridViewTextBoxColumn
	      '
	      Me.CustoDataGridViewTextBoxColumn.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn.Name = "CustoDataGridViewTextBoxColumn"
	      Me.CustoDataGridViewTextBoxColumn.Width = 31
	      '
	      'CustoTotalDataGridViewTextBoxColumn
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn.DataPropertyName = "Custo Total"
	      Me.CustoTotalDataGridViewTextBoxColumn.HeaderText = "Custo Total"
	      Me.CustoTotalDataGridViewTextBoxColumn.Name = "CustoTotalDataGridViewTextBoxColumn"
	      Me.CustoTotalDataGridViewTextBoxColumn.Width = 32
	      '
	      'ValorVendaDataGridViewTextBoxColumn1
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn1.DataPropertyName = "Valor Venda"
	      Me.ValorVendaDataGridViewTextBoxColumn1.HeaderText = "Valor Venda"
	      Me.ValorVendaDataGridViewTextBoxColumn1.Name = "ValorVendaDataGridViewTextBoxColumn1"
	      Me.ValorVendaDataGridViewTextBoxColumn1.Width = 31
	      '
	      'ProdutoIDDataGridViewTextBoxColumn1
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn1.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn1.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn1.Name = "ProdutoIDDataGridViewTextBoxColumn1"
	      Me.ProdutoIDDataGridViewTextBoxColumn1.Width = 31
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn.Name = "SaldoEstoqueDataGridViewTextBoxColumn"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn.Width = 31
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn1
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn1.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn1.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn1.Name = "CategoriaPadraoDataGridViewTextBoxColumn1"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn1.Width = 31
	      '
	      'GêneroDataGridViewTextBoxColumn
	      '
	      Me.GêneroDataGridViewTextBoxColumn.DataPropertyName = "Gênero"
	      Me.GêneroDataGridViewTextBoxColumn.HeaderText = "Gênero"
	      Me.GêneroDataGridViewTextBoxColumn.Name = "GêneroDataGridViewTextBoxColumn"
	      Me.GêneroDataGridViewTextBoxColumn.Width = 32
	      '
	      'UnidadeDataGridViewTextBoxColumn
	      '
	      Me.UnidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade"
	      Me.UnidadeDataGridViewTextBoxColumn.HeaderText = "Unidade"
	      Me.UnidadeDataGridViewTextBoxColumn.Name = "UnidadeDataGridViewTextBoxColumn"
	      Me.UnidadeDataGridViewTextBoxColumn.Width = 31
	      '
	      'CategoriaPadrãoDataGridViewTextBoxColumn
	      '
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn.DataPropertyName = "Categoria Padrão"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn.HeaderText = "Categoria Padrão"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn.Name = "CategoriaPadrãoDataGridViewTextBoxColumn"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn.Width = 31
	      '
	      'CodigoDataGridViewTextBoxColumn
	      '
	      Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
	      Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
	      Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
	      '
	      'ClienteDataGridViewTextBoxColumn
	      '
	      Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
	      Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
	      Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
	      '
	      'TipoDataGridViewTextBoxColumn
	      '
	      Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
	      '
	      'NumeroDocumentoDataGridViewTextBoxColumn
	      '
	      Me.NumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento"
	      Me.NumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento"
	      Me.NumeroDocumentoDataGridViewTextBoxColumn.Name = "NumeroDocumentoDataGridViewTextBoxColumn"
	      '
	      'SituacaoDataGridViewTextBoxColumn1
	      '
	      Me.SituacaoDataGridViewTextBoxColumn1.DataPropertyName = "Situacao"
	      Me.SituacaoDataGridViewTextBoxColumn1.HeaderText = "Situacao"
	      Me.SituacaoDataGridViewTextBoxColumn1.Name = "SituacaoDataGridViewTextBoxColumn1"
	      '
	      'DataLancamentoDataGridViewTextBoxColumn1
	      '
	      Me.DataLancamentoDataGridViewTextBoxColumn1.DataPropertyName = "DataLancamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn1.HeaderText = "DataLancamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn1.Name = "DataLancamentoDataGridViewTextBoxColumn1"
	      '
	      'VencimentoDataGridViewTextBoxColumn1
	      '
	      Me.VencimentoDataGridViewTextBoxColumn1.DataPropertyName = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn1.HeaderText = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn1.Name = "VencimentoDataGridViewTextBoxColumn1"
	      '
	      'DescricaoDataGridViewTextBoxColumn
	      '
	      Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
	      Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descricao"
	      Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
	      '
	      'JurosAntecipacaoDataGridViewTextBoxColumn
	      '
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn.DataPropertyName = "JurosAntecipacao"
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn.HeaderText = "JurosAntecipacao"
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn.Name = "JurosAntecipacaoDataGridViewTextBoxColumn"
	      '
	      'ValorDataGridViewTextBoxColumn1
	      '
	      Me.ValorDataGridViewTextBoxColumn1.DataPropertyName = "Valor"
	      Me.ValorDataGridViewTextBoxColumn1.HeaderText = "Valor"
	      Me.ValorDataGridViewTextBoxColumn1.Name = "ValorDataGridViewTextBoxColumn1"
	      '
	      'IdentificacaoDataGridViewTextBoxColumn
	      '
	      Me.IdentificacaoDataGridViewTextBoxColumn.DataPropertyName = "Identificacao"
	      Me.IdentificacaoDataGridViewTextBoxColumn.HeaderText = "Identificacao"
	      Me.IdentificacaoDataGridViewTextBoxColumn.Name = "IdentificacaoDataGridViewTextBoxColumn"
	      '
	      'ValorPagoDataGridViewTextBoxColumn1
	      '
	      Me.ValorPagoDataGridViewTextBoxColumn1.DataPropertyName = "ValorPago"
	      Me.ValorPagoDataGridViewTextBoxColumn1.HeaderText = "ValorPago"
	      Me.ValorPagoDataGridViewTextBoxColumn1.Name = "ValorPagoDataGridViewTextBoxColumn1"
	      '
	      'PlanoContasDataGridViewTextBoxColumn
	      '
	      Me.PlanoContasDataGridViewTextBoxColumn.DataPropertyName = "PlanoContas"
	      Me.PlanoContasDataGridViewTextBoxColumn.HeaderText = "PlanoContas"
	      Me.PlanoContasDataGridViewTextBoxColumn.Name = "PlanoContasDataGridViewTextBoxColumn"
	      '
	      'FormaPagamentoDataGridViewTextBoxColumn1
	      '
	      Me.FormaPagamentoDataGridViewTextBoxColumn1.DataPropertyName = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn1.HeaderText = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn1.Name = "FormaPagamentoDataGridViewTextBoxColumn1"
	      '
	      'ClienteIDDataGridViewTextBoxColumn
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn.Name = "ClienteIDDataGridViewTextBoxColumn"
	      Me.ClienteIDDataGridViewTextBoxColumn.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn.Name = "NomeClienteDataGridViewTextBoxColumn"
	      Me.NomeClienteDataGridViewTextBoxColumn.Width = 63
	      '
	      'ProdutoIDDataGridViewTextBoxColumn2
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn2.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn2.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn2.Name = "ProdutoIDDataGridViewTextBoxColumn2"
	      Me.ProdutoIDDataGridViewTextBoxColumn2.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn.Name = "PedidoIDDataGridViewTextBoxColumn"
	      Me.PedidoIDDataGridViewTextBoxColumn.Width = 64
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn2
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn2.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn2.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn2.Name = "CategoriaPadraoDataGridViewTextBoxColumn2"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn2.Width = 64
	      '
	      'ProdutoDataGridViewTextBoxColumn3
	      '
	      Me.ProdutoDataGridViewTextBoxColumn3.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn3.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn3.Name = "ProdutoDataGridViewTextBoxColumn3"
	      Me.ProdutoDataGridViewTextBoxColumn3.Width = 63
	      '
	      'GeneroDataGridViewTextBoxColumn
	      '
	      Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
	      Me.GeneroDataGridViewTextBoxColumn.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn1
	      '
	      Me.CustoDataGridViewTextBoxColumn1.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn1.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn1.Name = "CustoDataGridViewTextBoxColumn1"
	      Me.CustoDataGridViewTextBoxColumn1.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn1
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn1.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn1.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn1.Name = "SaldoEstoqueDataGridViewTextBoxColumn1"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn1.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn1
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn1.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn1.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn1.Name = "CustoTotalDataGridViewTextBoxColumn1"
	      Me.CustoTotalDataGridViewTextBoxColumn1.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn2
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn2.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn2.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn2.Name = "ValorVendaDataGridViewTextBoxColumn2"
	      Me.ValorVendaDataGridViewTextBoxColumn2.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn.Name = "ValorCustoTotalDataGridViewTextBoxColumn"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn1
	      '
	      Me.SomaDataGridViewTextBoxColumn1.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn1.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn1.Name = "SomaDataGridViewTextBoxColumn1"
	      Me.SomaDataGridViewTextBoxColumn1.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
	      Me.QuantidadeDataGridViewTextBoxColumn.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn
	      '
	      Me.RetiradoDataGridViewTextBoxColumn.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn.Name = "RetiradoDataGridViewTextBoxColumn"
	      Me.RetiradoDataGridViewTextBoxColumn.Width = 64
	      '
	      'ClienteIDDataGridViewTextBoxColumn1
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn1.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn1.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn1.Name = "ClienteIDDataGridViewTextBoxColumn1"
	      Me.ClienteIDDataGridViewTextBoxColumn1.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn1
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn1.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn1.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn1.Name = "PedidoIDDataGridViewTextBoxColumn1"
	      Me.PedidoIDDataGridViewTextBoxColumn1.Width = 63
	      '
	      'ProdutoDataGridViewTextBoxColumn4
	      '
	      Me.ProdutoDataGridViewTextBoxColumn4.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn4.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn4.Name = "ProdutoDataGridViewTextBoxColumn4"
	      Me.ProdutoDataGridViewTextBoxColumn4.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn2
	      '
	      Me.CustoDataGridViewTextBoxColumn2.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn2.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn2.Name = "CustoDataGridViewTextBoxColumn2"
	      Me.CustoDataGridViewTextBoxColumn2.Width = 64
	      '
	      'ProdutoIDDataGridViewTextBoxColumn3
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn3.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn3.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn3.Name = "ProdutoIDDataGridViewTextBoxColumn3"
	      Me.ProdutoIDDataGridViewTextBoxColumn3.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn2
	      '
	      Me.SomaDataGridViewTextBoxColumn2.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn2.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn2.Name = "SomaDataGridViewTextBoxColumn2"
	      Me.SomaDataGridViewTextBoxColumn2.Width = 63
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn3
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn3.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn3.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn3.Name = "CategoriaPadraoDataGridViewTextBoxColumn3"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn3.Width = 64
	      '
	      'GeneroDataGridViewTextBoxColumn1
	      '
	      Me.GeneroDataGridViewTextBoxColumn1.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn1.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn1.Name = "GeneroDataGridViewTextBoxColumn1"
	      Me.GeneroDataGridViewTextBoxColumn1.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn2
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn2.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn2.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn2.Name = "SaldoEstoqueDataGridViewTextBoxColumn2"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn2.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn2
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn2.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn2.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn2.Name = "CustoTotalDataGridViewTextBoxColumn2"
	      Me.CustoTotalDataGridViewTextBoxColumn2.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn3
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn3.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn3.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn3.Name = "ValorVendaDataGridViewTextBoxColumn3"
	      Me.ValorVendaDataGridViewTextBoxColumn3.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn1
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn1.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn1.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn1.Name = "NomeClienteDataGridViewTextBoxColumn1"
	      Me.NomeClienteDataGridViewTextBoxColumn1.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn1
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn1.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn1.Name = "QuantidadeDataGridViewTextBoxColumn1"
	      Me.QuantidadeDataGridViewTextBoxColumn1.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn1
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn1.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn1.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn1.Name = "ValorCustoTotalDataGridViewTextBoxColumn1"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn1.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn1
	      '
	      Me.RetiradoDataGridViewTextBoxColumn1.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn1.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn1.Name = "RetiradoDataGridViewTextBoxColumn1"
	      Me.RetiradoDataGridViewTextBoxColumn1.Width = 64
	      '
	      'ClienteIDDataGridViewTextBoxColumn2
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn2.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn2.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn2.Name = "ClienteIDDataGridViewTextBoxColumn2"
	      Me.ClienteIDDataGridViewTextBoxColumn2.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn2
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn2.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn2.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn2.Name = "PedidoIDDataGridViewTextBoxColumn2"
	      Me.PedidoIDDataGridViewTextBoxColumn2.Width = 63
	      '
	      'ProdutoDataGridViewTextBoxColumn5
	      '
	      Me.ProdutoDataGridViewTextBoxColumn5.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn5.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn5.Name = "ProdutoDataGridViewTextBoxColumn5"
	      Me.ProdutoDataGridViewTextBoxColumn5.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn3
	      '
	      Me.CustoDataGridViewTextBoxColumn3.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn3.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn3.Name = "CustoDataGridViewTextBoxColumn3"
	      Me.CustoDataGridViewTextBoxColumn3.Width = 64
	      '
	      'ProdutoIDDataGridViewTextBoxColumn4
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn4.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn4.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn4.Name = "ProdutoIDDataGridViewTextBoxColumn4"
	      Me.ProdutoIDDataGridViewTextBoxColumn4.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn3
	      '
	      Me.SomaDataGridViewTextBoxColumn3.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn3.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn3.Name = "SomaDataGridViewTextBoxColumn3"
	      Me.SomaDataGridViewTextBoxColumn3.Width = 63
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn4
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn4.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn4.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn4.Name = "CategoriaPadraoDataGridViewTextBoxColumn4"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn4.Width = 64
	      '
	      'GeneroDataGridViewTextBoxColumn2
	      '
	      Me.GeneroDataGridViewTextBoxColumn2.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn2.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn2.Name = "GeneroDataGridViewTextBoxColumn2"
	      Me.GeneroDataGridViewTextBoxColumn2.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn3
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn3.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn3.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn3.Name = "SaldoEstoqueDataGridViewTextBoxColumn3"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn3.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn3
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn3.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn3.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn3.Name = "CustoTotalDataGridViewTextBoxColumn3"
	      Me.CustoTotalDataGridViewTextBoxColumn3.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn4
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn4.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn4.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn4.Name = "ValorVendaDataGridViewTextBoxColumn4"
	      Me.ValorVendaDataGridViewTextBoxColumn4.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn2
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn2.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn2.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn2.Name = "NomeClienteDataGridViewTextBoxColumn2"
	      Me.NomeClienteDataGridViewTextBoxColumn2.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn2
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn2.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn2.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn2.Name = "QuantidadeDataGridViewTextBoxColumn2"
	      Me.QuantidadeDataGridViewTextBoxColumn2.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn2
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn2.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn2.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn2.Name = "ValorCustoTotalDataGridViewTextBoxColumn2"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn2.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn2
	      '
	      Me.RetiradoDataGridViewTextBoxColumn2.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn2.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn2.Name = "RetiradoDataGridViewTextBoxColumn2"
	      Me.RetiradoDataGridViewTextBoxColumn2.Width = 64
	      '
	      'ProdutoDataGridViewTextBoxColumn6
	      '
	      Me.ProdutoDataGridViewTextBoxColumn6.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn6.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn6.Name = "ProdutoDataGridViewTextBoxColumn6"
	      Me.ProdutoDataGridViewTextBoxColumn6.Width = 31
	      '
	      'CustoDataGridViewTextBoxColumn4
	      '
	      Me.CustoDataGridViewTextBoxColumn4.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn4.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn4.Name = "CustoDataGridViewTextBoxColumn4"
	      Me.CustoDataGridViewTextBoxColumn4.Width = 31
	      '
	      'CustoTotalDataGridViewTextBoxColumn4
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn4.DataPropertyName = "Custo Total"
	      Me.CustoTotalDataGridViewTextBoxColumn4.HeaderText = "Custo Total"
	      Me.CustoTotalDataGridViewTextBoxColumn4.Name = "CustoTotalDataGridViewTextBoxColumn4"
	      Me.CustoTotalDataGridViewTextBoxColumn4.Width = 32
	      '
	      'ValorVendaDataGridViewTextBoxColumn5
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn5.DataPropertyName = "Valor Venda"
	      Me.ValorVendaDataGridViewTextBoxColumn5.HeaderText = "Valor Venda"
	      Me.ValorVendaDataGridViewTextBoxColumn5.Name = "ValorVendaDataGridViewTextBoxColumn5"
	      Me.ValorVendaDataGridViewTextBoxColumn5.Width = 31
	      '
	      'ProdutoIDDataGridViewTextBoxColumn5
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn5.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn5.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn5.Name = "ProdutoIDDataGridViewTextBoxColumn5"
	      Me.ProdutoIDDataGridViewTextBoxColumn5.Width = 31
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn4
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn4.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn4.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn4.Name = "SaldoEstoqueDataGridViewTextBoxColumn4"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn4.Width = 31
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn5
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn5.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn5.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn5.Name = "CategoriaPadraoDataGridViewTextBoxColumn5"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn5.Width = 31
	      '
	      'GêneroDataGridViewTextBoxColumn1
	      '
	      Me.GêneroDataGridViewTextBoxColumn1.DataPropertyName = "Gênero"
	      Me.GêneroDataGridViewTextBoxColumn1.HeaderText = "Gênero"
	      Me.GêneroDataGridViewTextBoxColumn1.Name = "GêneroDataGridViewTextBoxColumn1"
	      Me.GêneroDataGridViewTextBoxColumn1.Width = 32
	      '
	      'UnidadeDataGridViewTextBoxColumn1
	      '
	      Me.UnidadeDataGridViewTextBoxColumn1.DataPropertyName = "Unidade"
	      Me.UnidadeDataGridViewTextBoxColumn1.HeaderText = "Unidade"
	      Me.UnidadeDataGridViewTextBoxColumn1.Name = "UnidadeDataGridViewTextBoxColumn1"
	      Me.UnidadeDataGridViewTextBoxColumn1.Width = 31
	      '
	      'CategoriaPadrãoDataGridViewTextBoxColumn1
	      '
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn1.DataPropertyName = "Categoria Padrão"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn1.HeaderText = "Categoria Padrão"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn1.Name = "CategoriaPadrãoDataGridViewTextBoxColumn1"
	      Me.CategoriaPadrãoDataGridViewTextBoxColumn1.Width = 31
	      '
	      'CodigoDataGridViewTextBoxColumn1
	      '
	      Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
	      Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
	      Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
	      '
	      'ClienteDataGridViewTextBoxColumn1
	      '
	      Me.ClienteDataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
	      Me.ClienteDataGridViewTextBoxColumn1.HeaderText = "Cliente"
	      Me.ClienteDataGridViewTextBoxColumn1.Name = "ClienteDataGridViewTextBoxColumn1"
	      '
	      'TipoDataGridViewTextBoxColumn1
	      '
	      Me.TipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn1.HeaderText = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn1.Name = "TipoDataGridViewTextBoxColumn1"
	      '
	      'NumeroDocumentoDataGridViewTextBoxColumn1
	      '
	      Me.NumeroDocumentoDataGridViewTextBoxColumn1.DataPropertyName = "NumeroDocumento"
	      Me.NumeroDocumentoDataGridViewTextBoxColumn1.HeaderText = "NumeroDocumento"
	      Me.NumeroDocumentoDataGridViewTextBoxColumn1.Name = "NumeroDocumentoDataGridViewTextBoxColumn1"
	      '
	      'SituacaoDataGridViewTextBoxColumn2
	      '
	      Me.SituacaoDataGridViewTextBoxColumn2.DataPropertyName = "Situacao"
	      Me.SituacaoDataGridViewTextBoxColumn2.HeaderText = "Situacao"
	      Me.SituacaoDataGridViewTextBoxColumn2.Name = "SituacaoDataGridViewTextBoxColumn2"
	      '
	      'DataLancamentoDataGridViewTextBoxColumn2
	      '
	      Me.DataLancamentoDataGridViewTextBoxColumn2.DataPropertyName = "DataLancamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn2.HeaderText = "DataLancamento"
	      Me.DataLancamentoDataGridViewTextBoxColumn2.Name = "DataLancamentoDataGridViewTextBoxColumn2"
	      '
	      'VencimentoDataGridViewTextBoxColumn2
	      '
	      Me.VencimentoDataGridViewTextBoxColumn2.DataPropertyName = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn2.HeaderText = "Vencimento"
	      Me.VencimentoDataGridViewTextBoxColumn2.Name = "VencimentoDataGridViewTextBoxColumn2"
	      '
	      'DescricaoDataGridViewTextBoxColumn1
	      '
	      Me.DescricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao"
	      Me.DescricaoDataGridViewTextBoxColumn1.HeaderText = "Descricao"
	      Me.DescricaoDataGridViewTextBoxColumn1.Name = "DescricaoDataGridViewTextBoxColumn1"
	      '
	      'JurosAntecipacaoDataGridViewTextBoxColumn1
	      '
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn1.DataPropertyName = "JurosAntecipacao"
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn1.HeaderText = "JurosAntecipacao"
	      Me.JurosAntecipacaoDataGridViewTextBoxColumn1.Name = "JurosAntecipacaoDataGridViewTextBoxColumn1"
	      '
	      'ValorDataGridViewTextBoxColumn2
	      '
	      Me.ValorDataGridViewTextBoxColumn2.DataPropertyName = "Valor"
	      Me.ValorDataGridViewTextBoxColumn2.HeaderText = "Valor"
	      Me.ValorDataGridViewTextBoxColumn2.Name = "ValorDataGridViewTextBoxColumn2"
	      '
	      'IdentificacaoDataGridViewTextBoxColumn1
	      '
	      Me.IdentificacaoDataGridViewTextBoxColumn1.DataPropertyName = "Identificacao"
	      Me.IdentificacaoDataGridViewTextBoxColumn1.HeaderText = "Identificacao"
	      Me.IdentificacaoDataGridViewTextBoxColumn1.Name = "IdentificacaoDataGridViewTextBoxColumn1"
	      '
	      'ValorPagoDataGridViewTextBoxColumn2
	      '
	      Me.ValorPagoDataGridViewTextBoxColumn2.DataPropertyName = "ValorPago"
	      Me.ValorPagoDataGridViewTextBoxColumn2.HeaderText = "ValorPago"
	      Me.ValorPagoDataGridViewTextBoxColumn2.Name = "ValorPagoDataGridViewTextBoxColumn2"
	      '
	      'PlanoContasDataGridViewTextBoxColumn1
	      '
	      Me.PlanoContasDataGridViewTextBoxColumn1.DataPropertyName = "PlanoContas"
	      Me.PlanoContasDataGridViewTextBoxColumn1.HeaderText = "PlanoContas"
	      Me.PlanoContasDataGridViewTextBoxColumn1.Name = "PlanoContasDataGridViewTextBoxColumn1"
	      '
	      'FormaPagamentoDataGridViewTextBoxColumn2
	      '
	      Me.FormaPagamentoDataGridViewTextBoxColumn2.DataPropertyName = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn2.HeaderText = "FormaPagamento"
	      Me.FormaPagamentoDataGridViewTextBoxColumn2.Name = "FormaPagamentoDataGridViewTextBoxColumn2"
	      '
	      'ClienteIDDataGridViewTextBoxColumn3
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn3.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn3.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn3.Name = "ClienteIDDataGridViewTextBoxColumn3"
	      Me.ClienteIDDataGridViewTextBoxColumn3.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn3
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn3.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn3.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn3.Name = "NomeClienteDataGridViewTextBoxColumn3"
	      Me.NomeClienteDataGridViewTextBoxColumn3.Width = 63
	      '
	      'ProdutoIDDataGridViewTextBoxColumn6
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn6.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn6.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn6.Name = "ProdutoIDDataGridViewTextBoxColumn6"
	      Me.ProdutoIDDataGridViewTextBoxColumn6.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn3
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn3.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn3.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn3.Name = "PedidoIDDataGridViewTextBoxColumn3"
	      Me.PedidoIDDataGridViewTextBoxColumn3.Width = 64
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn6
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn6.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn6.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn6.Name = "CategoriaPadraoDataGridViewTextBoxColumn6"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn6.Width = 64
	      '
	      'ProdutoDataGridViewTextBoxColumn7
	      '
	      Me.ProdutoDataGridViewTextBoxColumn7.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn7.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn7.Name = "ProdutoDataGridViewTextBoxColumn7"
	      Me.ProdutoDataGridViewTextBoxColumn7.Width = 63
	      '
	      'GeneroDataGridViewTextBoxColumn3
	      '
	      Me.GeneroDataGridViewTextBoxColumn3.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn3.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn3.Name = "GeneroDataGridViewTextBoxColumn3"
	      Me.GeneroDataGridViewTextBoxColumn3.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn5
	      '
	      Me.CustoDataGridViewTextBoxColumn5.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn5.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn5.Name = "CustoDataGridViewTextBoxColumn5"
	      Me.CustoDataGridViewTextBoxColumn5.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn5
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn5.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn5.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn5.Name = "SaldoEstoqueDataGridViewTextBoxColumn5"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn5.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn5
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn5.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn5.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn5.Name = "CustoTotalDataGridViewTextBoxColumn5"
	      Me.CustoTotalDataGridViewTextBoxColumn5.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn6
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn6.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn6.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn6.Name = "ValorVendaDataGridViewTextBoxColumn6"
	      Me.ValorVendaDataGridViewTextBoxColumn6.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn3
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn3.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn3.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn3.Name = "ValorCustoTotalDataGridViewTextBoxColumn3"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn3.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn4
	      '
	      Me.SomaDataGridViewTextBoxColumn4.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn4.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn4.Name = "SomaDataGridViewTextBoxColumn4"
	      Me.SomaDataGridViewTextBoxColumn4.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn3
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn3.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn3.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn3.Name = "QuantidadeDataGridViewTextBoxColumn3"
	      Me.QuantidadeDataGridViewTextBoxColumn3.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn3
	      '
	      Me.RetiradoDataGridViewTextBoxColumn3.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn3.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn3.Name = "RetiradoDataGridViewTextBoxColumn3"
	      Me.RetiradoDataGridViewTextBoxColumn3.Width = 64
	      '
	      'ClienteIDDataGridViewTextBoxColumn4
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn4.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn4.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn4.Name = "ClienteIDDataGridViewTextBoxColumn4"
	      Me.ClienteIDDataGridViewTextBoxColumn4.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn4
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn4.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn4.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn4.Name = "PedidoIDDataGridViewTextBoxColumn4"
	      Me.PedidoIDDataGridViewTextBoxColumn4.Width = 63
	      '
	      'ProdutoDataGridViewTextBoxColumn8
	      '
	      Me.ProdutoDataGridViewTextBoxColumn8.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn8.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn8.Name = "ProdutoDataGridViewTextBoxColumn8"
	      Me.ProdutoDataGridViewTextBoxColumn8.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn6
	      '
	      Me.CustoDataGridViewTextBoxColumn6.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn6.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn6.Name = "CustoDataGridViewTextBoxColumn6"
	      Me.CustoDataGridViewTextBoxColumn6.Width = 64
	      '
	      'ProdutoIDDataGridViewTextBoxColumn7
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn7.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn7.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn7.Name = "ProdutoIDDataGridViewTextBoxColumn7"
	      Me.ProdutoIDDataGridViewTextBoxColumn7.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn5
	      '
	      Me.SomaDataGridViewTextBoxColumn5.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn5.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn5.Name = "SomaDataGridViewTextBoxColumn5"
	      Me.SomaDataGridViewTextBoxColumn5.Width = 63
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn7
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn7.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn7.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn7.Name = "CategoriaPadraoDataGridViewTextBoxColumn7"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn7.Width = 64
	      '
	      'GeneroDataGridViewTextBoxColumn4
	      '
	      Me.GeneroDataGridViewTextBoxColumn4.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn4.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn4.Name = "GeneroDataGridViewTextBoxColumn4"
	      Me.GeneroDataGridViewTextBoxColumn4.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn6
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn6.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn6.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn6.Name = "SaldoEstoqueDataGridViewTextBoxColumn6"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn6.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn6
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn6.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn6.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn6.Name = "CustoTotalDataGridViewTextBoxColumn6"
	      Me.CustoTotalDataGridViewTextBoxColumn6.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn7
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn7.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn7.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn7.Name = "ValorVendaDataGridViewTextBoxColumn7"
	      Me.ValorVendaDataGridViewTextBoxColumn7.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn4
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn4.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn4.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn4.Name = "NomeClienteDataGridViewTextBoxColumn4"
	      Me.NomeClienteDataGridViewTextBoxColumn4.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn4
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn4.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn4.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn4.Name = "QuantidadeDataGridViewTextBoxColumn4"
	      Me.QuantidadeDataGridViewTextBoxColumn4.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn4
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn4.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn4.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn4.Name = "ValorCustoTotalDataGridViewTextBoxColumn4"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn4.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn4
	      '
	      Me.RetiradoDataGridViewTextBoxColumn4.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn4.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn4.Name = "RetiradoDataGridViewTextBoxColumn4"
	      Me.RetiradoDataGridViewTextBoxColumn4.Width = 64
	      '
	      'ClienteIDDataGridViewTextBoxColumn5
	      '
	      Me.ClienteIDDataGridViewTextBoxColumn5.DataPropertyName = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn5.HeaderText = "ClienteID"
	      Me.ClienteIDDataGridViewTextBoxColumn5.Name = "ClienteIDDataGridViewTextBoxColumn5"
	      Me.ClienteIDDataGridViewTextBoxColumn5.Width = 64
	      '
	      'PedidoIDDataGridViewTextBoxColumn5
	      '
	      Me.PedidoIDDataGridViewTextBoxColumn5.DataPropertyName = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn5.HeaderText = "PedidoID"
	      Me.PedidoIDDataGridViewTextBoxColumn5.Name = "PedidoIDDataGridViewTextBoxColumn5"
	      Me.PedidoIDDataGridViewTextBoxColumn5.Width = 63
	      '
	      'ProdutoDataGridViewTextBoxColumn9
	      '
	      Me.ProdutoDataGridViewTextBoxColumn9.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn9.HeaderText = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn9.Name = "ProdutoDataGridViewTextBoxColumn9"
	      Me.ProdutoDataGridViewTextBoxColumn9.Width = 64
	      '
	      'CustoDataGridViewTextBoxColumn7
	      '
	      Me.CustoDataGridViewTextBoxColumn7.DataPropertyName = "Custo"
	      Me.CustoDataGridViewTextBoxColumn7.HeaderText = "Custo"
	      Me.CustoDataGridViewTextBoxColumn7.Name = "CustoDataGridViewTextBoxColumn7"
	      Me.CustoDataGridViewTextBoxColumn7.Width = 64
	      '
	      'ProdutoIDDataGridViewTextBoxColumn8
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn8.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn8.HeaderText = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn8.Name = "ProdutoIDDataGridViewTextBoxColumn8"
	      Me.ProdutoIDDataGridViewTextBoxColumn8.Width = 64
	      '
	      'SomaDataGridViewTextBoxColumn6
	      '
	      Me.SomaDataGridViewTextBoxColumn6.DataPropertyName = "Soma"
	      Me.SomaDataGridViewTextBoxColumn6.HeaderText = "Soma"
	      Me.SomaDataGridViewTextBoxColumn6.Name = "SomaDataGridViewTextBoxColumn6"
	      Me.SomaDataGridViewTextBoxColumn6.Width = 63
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn8
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn8.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn8.HeaderText = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn8.Name = "CategoriaPadraoDataGridViewTextBoxColumn8"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn8.Width = 64
	      '
	      'GeneroDataGridViewTextBoxColumn5
	      '
	      Me.GeneroDataGridViewTextBoxColumn5.DataPropertyName = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn5.HeaderText = "Genero"
	      Me.GeneroDataGridViewTextBoxColumn5.Name = "GeneroDataGridViewTextBoxColumn5"
	      Me.GeneroDataGridViewTextBoxColumn5.Width = 64
	      '
	      'SaldoEstoqueDataGridViewTextBoxColumn7
	      '
	      Me.SaldoEstoqueDataGridViewTextBoxColumn7.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn7.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn7.Name = "SaldoEstoqueDataGridViewTextBoxColumn7"
	      Me.SaldoEstoqueDataGridViewTextBoxColumn7.Width = 64
	      '
	      'CustoTotalDataGridViewTextBoxColumn7
	      '
	      Me.CustoTotalDataGridViewTextBoxColumn7.DataPropertyName = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn7.HeaderText = "CustoTotal"
	      Me.CustoTotalDataGridViewTextBoxColumn7.Name = "CustoTotalDataGridViewTextBoxColumn7"
	      Me.CustoTotalDataGridViewTextBoxColumn7.Width = 63
	      '
	      'ValorVendaDataGridViewTextBoxColumn8
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn8.DataPropertyName = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn8.HeaderText = "ValorVenda"
	      Me.ValorVendaDataGridViewTextBoxColumn8.Name = "ValorVendaDataGridViewTextBoxColumn8"
	      Me.ValorVendaDataGridViewTextBoxColumn8.Width = 64
	      '
	      'NomeClienteDataGridViewTextBoxColumn5
	      '
	      Me.NomeClienteDataGridViewTextBoxColumn5.DataPropertyName = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn5.HeaderText = "NomeCliente"
	      Me.NomeClienteDataGridViewTextBoxColumn5.Name = "NomeClienteDataGridViewTextBoxColumn5"
	      Me.NomeClienteDataGridViewTextBoxColumn5.Width = 64
	      '
	      'QuantidadeDataGridViewTextBoxColumn5
	      '
	      Me.QuantidadeDataGridViewTextBoxColumn5.DataPropertyName = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn5.HeaderText = "Quantidade"
	      Me.QuantidadeDataGridViewTextBoxColumn5.Name = "QuantidadeDataGridViewTextBoxColumn5"
	      Me.QuantidadeDataGridViewTextBoxColumn5.Width = 64
	      '
	      'ValorCustoTotalDataGridViewTextBoxColumn5
	      '
	      Me.ValorCustoTotalDataGridViewTextBoxColumn5.DataPropertyName = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn5.HeaderText = "ValorCustoTotal"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn5.Name = "ValorCustoTotalDataGridViewTextBoxColumn5"
	      Me.ValorCustoTotalDataGridViewTextBoxColumn5.Width = 63
	      '
	      'RetiradoDataGridViewTextBoxColumn5
	      '
	      Me.RetiradoDataGridViewTextBoxColumn5.DataPropertyName = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn5.HeaderText = "Retirado"
	      Me.RetiradoDataGridViewTextBoxColumn5.Name = "RetiradoDataGridViewTextBoxColumn5"
	      Me.RetiradoDataGridViewTextBoxColumn5.Width = 64
	      '
	      'lblNumeroPedido
	      '
	      Me.lblNumeroPedido.AutoSize = True
	      Me.lblNumeroPedido.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblNumeroPedido.ForeColor = System.Drawing.Color.Black
	      Me.lblNumeroPedido.Location = New System.Drawing.Point(13, 5)
	      Me.lblNumeroPedido.Name = "lblNumeroPedido"
	      Me.lblNumeroPedido.Size = New System.Drawing.Size(0, 24)
	      Me.lblNumeroPedido.TabIndex = 94
	      '
	      'txtProdutoID
	      '
	      Me.txtProdutoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "ProdutoID", True))
	      Me.txtProdutoID.Location = New System.Drawing.Point(6, 19)
	      Me.txtProdutoID.Name = "txtProdutoID"
	      Me.txtProdutoID.ReadOnly = True
	      Me.txtProdutoID.Size = New System.Drawing.Size(64, 20)
	      Me.txtProdutoID.TabIndex = 27
	      '
	      'txtCodBarras
	      '
	      Me.txtCodBarras.Location = New System.Drawing.Point(240, 31)
	      Me.txtCodBarras.Name = "txtCodBarras"
	      Me.txtCodBarras.Size = New System.Drawing.Size(100, 20)
	      Me.txtCodBarras.TabIndex = 82
	      '
	      'Panel5
	      '
	      Me.Panel5.BackColor = System.Drawing.Color.White
	      Me.Panel5.Controls.Add(Me.txtCodBarras)
	      Me.Panel5.Controls.Add(Me.btnRetQuant)
	      Me.Panel5.Controls.Add(Me.btnAddQuant)
	      Me.Panel5.Controls.Add(Me.rdOcultarColCusto)
	      Me.Panel5.Controls.Add(Label20)
	      Me.Panel5.Controls.Add(Me.btnAdicionarProduto)
	      Me.Panel5.Controls.Add(Label5)
	      Me.Panel5.Controls.Add(Me.txtCustoTotal)
	      Me.Panel5.Controls.Add(Me.txtQuantidade)
	      Me.Panel5.Controls.Add(Label19)
	      Me.Panel5.Controls.Add(Me.txtSoma)
	      Me.Panel5.Location = New System.Drawing.Point(3, 64)
	      Me.Panel5.Name = "Panel5"
	      Me.Panel5.Size = New System.Drawing.Size(382, 138)
	      Me.Panel5.TabIndex = 106
	      '
	      'btnRetQuant
	      '
	      Me.btnRetQuant.BackColor = System.Drawing.Color.Transparent
	      Me.btnRetQuant.BackgroundImage = Global.ControleOS.My.Resources.Resources.subtrair
	      Me.btnRetQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnRetQuant.FlatAppearance.BorderSize = 0
	      Me.btnRetQuant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnRetQuant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnRetQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnRetQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnRetQuant.Location = New System.Drawing.Point(117, 36)
	      Me.btnRetQuant.Name = "btnRetQuant"
	      Me.btnRetQuant.Size = New System.Drawing.Size(28, 28)
	      Me.btnRetQuant.TabIndex = 107
	      Me.btnRetQuant.UseVisualStyleBackColor = False
	      '
	      'btnAddQuant
	      '
	      Me.btnAddQuant.BackColor = System.Drawing.Color.Transparent
	      Me.btnAddQuant.BackgroundImage = Global.ControleOS.My.Resources.Resources.adicionar
	      Me.btnAddQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnAddQuant.FlatAppearance.BorderSize = 0
	      Me.btnAddQuant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnAddQuant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnAddQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAddQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnAddQuant.Location = New System.Drawing.Point(120, 9)
	      Me.btnAddQuant.Name = "btnAddQuant"
	      Me.btnAddQuant.Size = New System.Drawing.Size(24, 24)
	      Me.btnAddQuant.TabIndex = 106
	      Me.btnAddQuant.UseVisualStyleBackColor = False
	      '
	      'btnAdicionarProduto
	      '
	      Me.btnAdicionarProduto.AutoEllipsis = True
	      Me.btnAdicionarProduto.BackColor = System.Drawing.Color.Transparent
	      Me.btnAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnAdicionarProduto.DialogResult = System.Windows.Forms.DialogResult.Cancel
	      Me.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
	      Me.btnAdicionarProduto.FlatAppearance.BorderSize = 0
	      Me.btnAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnAdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAdicionarProduto.Image = Global.ControleOS.My.Resources.Resources.Adicionar1
	      Me.btnAdicionarProduto.Location = New System.Drawing.Point(329, 83)
	      Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
	      Me.btnAdicionarProduto.Size = New System.Drawing.Size(35, 38)
	      Me.btnAdicionarProduto.TabIndex = 33
	      Me.btnAdicionarProduto.UseVisualStyleBackColor = False
	      '
	      'txtCustoTotal
	      '
	      Me.txtCustoTotal.BackColor = System.Drawing.Color.White
	      Me.txtCustoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.txtCustoTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoPDVBindingSource, "Valor Venda", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
	      Me.txtCustoTotal.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtCustoTotal.Location = New System.Drawing.Point(7, 83)
	      Me.txtCustoTotal.Name = "txtCustoTotal"
	      Me.txtCustoTotal.ReadOnly = True
	      Me.txtCustoTotal.Size = New System.Drawing.Size(112, 38)
	      Me.txtCustoTotal.TabIndex = 104
	      Me.txtCustoTotal.Text = "1"
	      Me.txtCustoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'txtSoma
	      '
	      Me.txtSoma.BackColor = System.Drawing.Color.White
	      Me.txtSoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.txtSoma.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtSoma.ForeColor = System.Drawing.Color.Black
	      Me.txtSoma.Location = New System.Drawing.Point(125, 83)
	      Me.txtSoma.Name = "txtSoma"
	      Me.txtSoma.Size = New System.Drawing.Size(158, 38)
	      Me.txtSoma.TabIndex = 99
	      Me.txtSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
	      '
	      'txtSomaTotal
	      '
	      Me.txtSomaTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.txtSomaTotal.BackColor = System.Drawing.Color.White
	      Me.txtSomaTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtSomaTotal.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtSomaTotal.ForeColor = System.Drawing.Color.Black
	      Me.txtSomaTotal.Location = New System.Drawing.Point(146, 14)
	      Me.txtSomaTotal.Name = "txtSomaTotal"
	      Me.txtSomaTotal.Size = New System.Drawing.Size(202, 37)
	      Me.txtSomaTotal.TabIndex = 110
	      Me.txtSomaTotal.Text = "R$ 00,00.00"
	      '
	      'Panel3
	      '
	      Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.Panel3.BackColor = System.Drawing.Color.White
	      Me.Panel3.Controls.Add(Me.lblProdutoDesc)
	      Me.Panel3.Controls.Add(Label3)
	      Me.Panel3.Controls.Add(Me.Button1)
	      Me.Panel3.Controls.Add(Me.Label1)
	      Me.Panel3.Controls.Add(Me.lblNumeroPedido)
	      Me.Panel3.Controls.Add(Me.Label14)
	      Me.Panel3.Controls.Add(Me.Label18)
	      Me.Panel3.Controls.Add(Me.lblkPedidoVinculado)
	      Me.Panel3.Controls.Add(Me.txtCodCliente)
	      Me.Panel3.Controls.Add(Me.txtSomaPDV)
	      Me.Panel3.Controls.Add(Me.txtProduto)
	      Me.Panel3.Location = New System.Drawing.Point(3, 3)
	      Me.Panel3.Name = "Panel3"
	      Me.Panel3.Size = New System.Drawing.Size(1048, 59)
	      Me.Panel3.TabIndex = 97
	      '
	      'lblProdutoDesc
	      '
	      Me.lblProdutoDesc.AutoSize = True
	      Me.lblProdutoDesc.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblProdutoDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
	      Me.lblProdutoDesc.Location = New System.Drawing.Point(613, 9)
	      Me.lblProdutoDesc.Name = "lblProdutoDesc"
	      Me.lblProdutoDesc.Size = New System.Drawing.Size(162, 42)
	      Me.lblProdutoDesc.TabIndex = 119
	      Me.lblProdutoDesc.Text = "PRODUTO"
	      '
	      'Button1
	      '
	      Me.Button1.AccessibleDescription = "Procurar Produtos"
	      Me.Button1.BackColor = System.Drawing.Color.Transparent
	      Me.Button1.BackgroundImage = Global.ControleOS.My.Resources.Resources.lupa2
	      Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
	      Me.Button1.FlatAppearance.BorderSize = 0
	      Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
	      Me.Button1.ForeColor = System.Drawing.Color.White
	      Me.Button1.Location = New System.Drawing.Point(996, 3)
	      Me.Button1.Name = "Button1"
	      Me.Button1.Size = New System.Drawing.Size(48, 50)
	      Me.Button1.TabIndex = 109
	      Me.Button1.UseVisualStyleBackColor = False
	      '
	      'txtTipo
	      '
	      Me.txtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Tipo", True))
	      Me.txtTipo.Location = New System.Drawing.Point(154, 122)
	      Me.txtTipo.Name = "txtTipo"
	      Me.txtTipo.Size = New System.Drawing.Size(136, 20)
	      Me.txtTipo.TabIndex = 57
	      '
	      'lblPrecoFrete
	      '
	      Me.lblPrecoFrete.AutoSize = True
	      Me.lblPrecoFrete.ForeColor = System.Drawing.Color.Black
	      Me.lblPrecoFrete.Location = New System.Drawing.Point(12, 183)
	      Me.lblPrecoFrete.Name = "lblPrecoFrete"
	      Me.lblPrecoFrete.Size = New System.Drawing.Size(77, 13)
	      Me.lblPrecoFrete.TabIndex = 68
	      Me.lblPrecoFrete.Text = "Preço de Frete"
	      Me.lblPrecoFrete.Visible = False
	      '
	      'txtComplemento
	      '
	      Me.txtComplemento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Complemento", True))
	      Me.txtComplemento.Location = New System.Drawing.Point(14, 158)
	      Me.txtComplemento.Name = "txtComplemento"
	      Me.txtComplemento.Size = New System.Drawing.Size(236, 20)
	      Me.txtComplemento.TabIndex = 55
	      '
	      'txtLogradouro
	      '
	      Me.txtLogradouro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Logradouro", True))
	      Me.txtLogradouro.Location = New System.Drawing.Point(110, 78)
	      Me.txtLogradouro.Name = "txtLogradouro"
	      Me.txtLogradouro.Size = New System.Drawing.Size(263, 20)
	      Me.txtLogradouro.TabIndex = 45
	      '
	      'txtPrecoFrete
	      '
	      Me.txtPrecoFrete.Location = New System.Drawing.Point(15, 199)
	      Me.txtPrecoFrete.Name = "txtPrecoFrete"
	      Me.txtPrecoFrete.Size = New System.Drawing.Size(100, 20)
	      Me.txtPrecoFrete.TabIndex = 67
	      Me.txtPrecoFrete.Text = "0"
	      Me.txtPrecoFrete.Visible = False
	      '
	      'txtInscEstadual
	      '
	      Me.txtInscEstadual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClientesBindingSource, "InscricaoEstadual", True))
	      Me.txtInscEstadual.Location = New System.Drawing.Point(14, 122)
	      Me.txtInscEstadual.Name = "txtInscEstadual"
	      Me.txtInscEstadual.Size = New System.Drawing.Size(134, 20)
	      Me.txtInscEstadual.TabIndex = 73
	      '
	      'chkEntDif
	      '
	      Me.chkEntDif.AutoSize = True
	      Me.chkEntDif.ForeColor = System.Drawing.Color.Black
	      Me.chkEntDif.Location = New System.Drawing.Point(331, 158)
	      Me.chkEntDif.Name = "chkEntDif"
	      Me.chkEntDif.Size = New System.Drawing.Size(133, 17)
	      Me.chkEntDif.TabIndex = 71
	      Me.chkEntDif.Text = "Endereço é Diferente?"
	      Me.chkEntDif.UseVisualStyleBackColor = True
	      Me.chkEntDif.Visible = False
	      '
	      'txtUF
	      '
	      Me.txtUF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "UF", True))
	      Me.txtUF.Location = New System.Drawing.Point(379, 116)
	      Me.txtUF.Name = "txtUF"
	      Me.txtUF.Size = New System.Drawing.Size(74, 20)
	      Me.txtUF.TabIndex = 53
	      '
	      'txtEndNumero
	      '
	      Me.txtEndNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "EndNumero", True))
	      Me.txtEndNumero.Location = New System.Drawing.Point(379, 79)
	      Me.txtEndNumero.Name = "txtEndNumero"
	      Me.txtEndNumero.Size = New System.Drawing.Size(74, 20)
	      Me.txtEndNumero.TabIndex = 47
	      '
	      'txtContato
	      '
	      Me.txtContato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "ID", True))
	      Me.txtContato.Location = New System.Drawing.Point(296, 122)
	      Me.txtContato.Name = "txtContato"
	      Me.txtContato.Size = New System.Drawing.Size(138, 20)
	      Me.txtContato.TabIndex = 76
	      '
	      'dgvCliente
	      '
	      Me.dgvCliente.AllowUserToAddRows = False
	      Me.dgvCliente.AllowUserToDeleteRows = False
	      Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvCliente.BackgroundColor = System.Drawing.Color.White
	      Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvCliente.ColumnHeadersVisible = False
	      DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
	      DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
	      DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle14
	      Me.dgvCliente.GridColor = System.Drawing.Color.White
	      Me.dgvCliente.Location = New System.Drawing.Point(14, 104)
	      Me.dgvCliente.Name = "dgvCliente"
	      Me.dgvCliente.ReadOnly = True
	      Me.dgvCliente.RowHeadersVisible = False
	      Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvCliente.Size = New System.Drawing.Size(278, 82)
	      Me.dgvCliente.TabIndex = 22
	      Me.dgvCliente.Visible = False
	      '
	      'chkEntrega
	      '
	      Me.chkEntrega.AutoSize = True
	      Me.chkEntrega.ForeColor = System.Drawing.Color.Black
	      Me.chkEntrega.Location = New System.Drawing.Point(256, 158)
	      Me.chkEntrega.Name = "chkEntrega"
	      Me.chkEntrega.Size = New System.Drawing.Size(69, 17)
	      Me.chkEntrega.TabIndex = 69
	      Me.chkEntrega.Text = "Entrega?"
	      Me.chkEntrega.UseVisualStyleBackColor = True
	      '
	      'txtCidade
	      '
	      Me.txtCidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Cidade", True))
	      Me.txtCidade.Location = New System.Drawing.Point(189, 118)
	      Me.txtCidade.Name = "txtCidade"
	      Me.txtCidade.Size = New System.Drawing.Size(184, 20)
	      Me.txtCidade.TabIndex = 51
	      '
	      'txtBairro
	      '
	      Me.txtBairro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "Bairro", True))
	      Me.txtBairro.Location = New System.Drawing.Point(13, 118)
	      Me.txtBairro.Name = "txtBairro"
	      Me.txtBairro.Size = New System.Drawing.Size(170, 20)
	      Me.txtBairro.TabIndex = 49
	      '
	      'txtCPFCliente
	      '
	      Me.txtCPFCliente.Location = New System.Drawing.Point(298, 84)
	      Me.txtCPFCliente.Name = "txtCPFCliente"
	      Me.txtCPFCliente.Size = New System.Drawing.Size(136, 20)
	      Me.txtCPFCliente.TabIndex = 26
	      '
	      'txtEndID
	      '
	      Me.txtEndID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbEndBindingSource, "ID", True))
	      Me.txtEndID.Location = New System.Drawing.Point(13, 79)
	      Me.txtEndID.Name = "txtEndID"
	      Me.txtEndID.Size = New System.Drawing.Size(91, 20)
	      Me.txtEndID.TabIndex = 70
	      '
	      'txtCliente
	      '
	      Me.txtCliente.Location = New System.Drawing.Point(14, 84)
	      Me.txtCliente.Name = "txtCliente"
	      Me.txtCliente.Size = New System.Drawing.Size(278, 20)
	      Me.txtCliente.TabIndex = 23
	      '
	      'btnshow1
	      '
	      Me.btnshow1.BackColor = System.Drawing.Color.Indigo
	      Me.btnshow1.FlatAppearance.BorderSize = 0
	      Me.btnshow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnshow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnshow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnshow1.ForeColor = System.Drawing.Color.White
	      Me.btnshow1.Location = New System.Drawing.Point(890, 5)
	      Me.btnshow1.Name = "btnshow1"
	      Me.btnshow1.Size = New System.Drawing.Size(135, 47)
	      Me.btnshow1.TabIndex = 97
	      Me.btnshow1.Text = "INFO. VENDA"
	      Me.btnshow1.UseVisualStyleBackColor = False
	      '
	      'ToolStripContainer1
	      '
	      Me.ToolStripContainer1.BottomToolStripPanelVisible = False
	      '
	      'ToolStripContainer1.ContentPanel
	      '
	      Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White
	      Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.PictureBox4)
	      Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label15)
	      Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(636, 49)
	      Me.ToolStripContainer1.LeftToolStripPanelVisible = False
	      Me.ToolStripContainer1.Location = New System.Drawing.Point(14, 8)
	      Me.ToolStripContainer1.Name = "ToolStripContainer1"
	      Me.ToolStripContainer1.RightToolStripPanelVisible = False
	      Me.ToolStripContainer1.Size = New System.Drawing.Size(636, 49)
	      Me.ToolStripContainer1.TabIndex = 84
	      Me.ToolStripContainer1.Text = "ToolStripContainer1"
	      '
	      'ToolStripContainer1.TopToolStripPanel
	      '
	      Me.ToolStripContainer1.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(0, 0, 25, 25)
	      Me.ToolStripContainer1.TopToolStripPanelVisible = False
	      '
	      'PictureBox4
	      '
	      Me.PictureBox4.BackgroundImage = Global.ControleOS.My.Resources.Resources.Usuarios
	      Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox4.Location = New System.Drawing.Point(3, 7)
	      Me.PictureBox4.Name = "PictureBox4"
	      Me.PictureBox4.Size = New System.Drawing.Size(39, 35)
	      Me.PictureBox4.TabIndex = 4
	      Me.PictureBox4.TabStop = False
	      '
	      'Label15
	      '
	      Me.Label15.AutoSize = True
	      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label15.ForeColor = System.Drawing.Color.Black
	      Me.Label15.Location = New System.Drawing.Point(48, 14)
	      Me.Label15.Name = "Label15"
	      Me.Label15.Size = New System.Drawing.Size(195, 20)
	      Me.Label15.TabIndex = 4
	      Me.Label15.Text = "Informações do Cliente"
	      '
	      'ToolStripContainer2
	      '
	      Me.ToolStripContainer2.BottomToolStripPanelVisible = False
	      '
	      'ToolStripContainer2.ContentPanel
	      '
	      Me.ToolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.White
	      Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.PictureBox5)
	      Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Label16)
	      Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(634, 49)
	      Me.ToolStripContainer2.LeftToolStripPanelVisible = False
	      Me.ToolStripContainer2.Location = New System.Drawing.Point(14, 12)
	      Me.ToolStripContainer2.Name = "ToolStripContainer2"
	      Me.ToolStripContainer2.RightToolStripPanelVisible = False
	      Me.ToolStripContainer2.Size = New System.Drawing.Size(634, 49)
	      Me.ToolStripContainer2.TabIndex = 85
	      Me.ToolStripContainer2.Text = "ToolStripContainer2"
	      '
	      'ToolStripContainer2.TopToolStripPanel
	      '
	      Me.ToolStripContainer2.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(0, 0, 25, 25)
	      Me.ToolStripContainer2.TopToolStripPanelVisible = False
	      '
	      'PictureBox5
	      '
	      Me.PictureBox5.BackgroundImage = Global.ControleOS.My.Resources.Resources.Entrega
	      Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.PictureBox5.Location = New System.Drawing.Point(3, 7)
	      Me.PictureBox5.Name = "PictureBox5"
	      Me.PictureBox5.Size = New System.Drawing.Size(39, 35)
	      Me.PictureBox5.TabIndex = 4
	      Me.PictureBox5.TabStop = False
	      '
	      'Label16
	      '
	      Me.Label16.AutoSize = True
	      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label16.ForeColor = System.Drawing.Color.Black
	      Me.Label16.Location = New System.Drawing.Point(44, 14)
	      Me.Label16.Name = "Label16"
	      Me.Label16.Size = New System.Drawing.Size(203, 20)
	      Me.Label16.TabIndex = 4
	      Me.Label16.Text = "Informações de Entrega"
	      '
	      'dgvEnd
	      '
	      Me.dgvEnd.AllowUserToAddRows = False
	      Me.dgvEnd.AllowUserToDeleteRows = False
	      Me.dgvEnd.AutoGenerateColumns = False
	      Me.dgvEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvEnd.BackgroundColor = System.Drawing.Color.White
	      Me.dgvEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvEnd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodEndDataGridViewTextBoxColumn, Me.LogradouroDataGridViewTextBoxColumn, Me.EndNumeroDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.UFDataGridViewTextBoxColumn, Me.ComplementoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn2, Me.IDDataGridViewTextBoxColumn})
	      Me.dgvEnd.DataSource = Me.TbEndBindingSource
	      Me.dgvEnd.Location = New System.Drawing.Point(12, 104)
	      Me.dgvEnd.Name = "dgvEnd"
	      Me.dgvEnd.ReadOnly = True
	      Me.dgvEnd.RowHeadersVisible = False
	      Me.dgvEnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvEnd.Size = New System.Drawing.Size(634, 163)
	      Me.dgvEnd.TabIndex = 42
	      Me.dgvEnd.Visible = False
	      '
	      'btnAddPessoa
	      '
	      Me.btnAddPessoa.BackColor = System.Drawing.Color.Indigo
	      Me.btnAddPessoa.FlatAppearance.BorderSize = 0
	      Me.btnAddPessoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnAddPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnAddPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAddPessoa.ForeColor = System.Drawing.Color.White
	      Me.btnAddPessoa.Location = New System.Drawing.Point(890, 59)
	      Me.btnAddPessoa.Name = "btnAddPessoa"
	      Me.btnAddPessoa.Size = New System.Drawing.Size(135, 47)
	      Me.btnAddPessoa.TabIndex = 98
	      Me.btnAddPessoa.Text = "ADICIONAR PESSOA"
	      Me.btnAddPessoa.UseVisualStyleBackColor = False
	      '
	      'btnMostraEnd
	      '
	      Me.btnMostraEnd.BackColor = System.Drawing.Color.Indigo
	      Me.btnMostraEnd.FlatAppearance.BorderSize = 0
	      Me.btnMostraEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnMostraEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnMostraEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnMostraEnd.ForeColor = System.Drawing.Color.White
	      Me.btnMostraEnd.Location = New System.Drawing.Point(459, 79)
	      Me.btnMostraEnd.Name = "btnMostraEnd"
	      Me.btnMostraEnd.Size = New System.Drawing.Size(118, 21)
	      Me.btnMostraEnd.TabIndex = 99
	      Me.btnMostraEnd.Text = "Lista de Endereços"
	      Me.btnMostraEnd.UseVisualStyleBackColor = False
	      '
	      'Panel2
	      '
	      Me.Panel2.BackColor = System.Drawing.Color.White
	      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel2.Controls.Add(Me.btnCarregarPedido2)
	      Me.Panel2.Controls.Add(Me.btnVoltar2)
	      Me.Panel2.Controls.Add(Me.PictureBox1)
	      Me.Panel2.Controls.Add(Me.Panel13)
	      Me.Panel2.Controls.Add(Me.Panel12)
	      Me.Panel2.Controls.Add(Me.btnAddPessoa)
	      Me.Panel2.Controls.Add(Me.btnshow1)
	      Me.Panel2.Location = New System.Drawing.Point(12, 9)
	      Me.Panel2.Name = "Panel2"
	      Me.Panel2.Size = New System.Drawing.Size(1030, 489)
	      Me.Panel2.TabIndex = 94
	      '
	      'btnCarregarPedido2
	      '
	      Me.btnCarregarPedido2.BackColor = System.Drawing.Color.Indigo
	      Me.btnCarregarPedido2.FlatAppearance.BorderSize = 0
	      Me.btnCarregarPedido2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnCarregarPedido2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnCarregarPedido2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnCarregarPedido2.ForeColor = System.Drawing.Color.White
	      Me.btnCarregarPedido2.Location = New System.Drawing.Point(890, 165)
	      Me.btnCarregarPedido2.Name = "btnCarregarPedido2"
	      Me.btnCarregarPedido2.Size = New System.Drawing.Size(135, 47)
	      Me.btnCarregarPedido2.TabIndex = 107
	      Me.btnCarregarPedido2.Text = "CARREGAR PEDIDO"
	      Me.btnCarregarPedido2.UseVisualStyleBackColor = False
	      '
	      'btnVoltar2
	      '
	      Me.btnVoltar2.BackColor = System.Drawing.Color.Indigo
	      Me.btnVoltar2.FlatAppearance.BorderSize = 0
	      Me.btnVoltar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnVoltar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnVoltar2.ForeColor = System.Drawing.Color.White
	      Me.btnVoltar2.Location = New System.Drawing.Point(890, 112)
	      Me.btnVoltar2.Name = "btnVoltar2"
	      Me.btnVoltar2.Size = New System.Drawing.Size(135, 47)
	      Me.btnVoltar2.TabIndex = 106
	      Me.btnVoltar2.Text = "VOLTAR"
	      Me.btnVoltar2.UseVisualStyleBackColor = False
	      '
	      'PictureBox1
	      '
	      Me.PictureBox1.Image = Global.ControleOS.My.Resources.Resources.NLG
	      Me.PictureBox1.Location = New System.Drawing.Point(666, 5)
	      Me.PictureBox1.Name = "PictureBox1"
	      Me.PictureBox1.Size = New System.Drawing.Size(218, 209)
	      Me.PictureBox1.TabIndex = 105
	      Me.PictureBox1.TabStop = False
	      '
	      'Panel13
	      '
	      Me.Panel13.BackColor = System.Drawing.Color.Silver
	      Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel13.Controls.Add(Me.dgvEnd)
	      Me.Panel13.Controls.Add(Me.ToolStripContainer2)
	      Me.Panel13.Controls.Add(ComplementoLabel)
	      Me.Panel13.Controls.Add(Me.btnMostraEnd)
	      Me.Panel13.Controls.Add(Me.lblPrecoFrete)
	      Me.Panel13.Controls.Add(CodEndLabel)
	      Me.Panel13.Controls.Add(Me.txtComplemento)
	      Me.Panel13.Controls.Add(Me.txtLogradouro)
	      Me.Panel13.Controls.Add(Me.txtPrecoFrete)
	      Me.Panel13.Controls.Add(Me.txtEndID)
	      Me.Panel13.Controls.Add(UFLabel)
	      Me.Panel13.Controls.Add(Me.txtBairro)
	      Me.Panel13.Controls.Add(Me.chkEntDif)
	      Me.Panel13.Controls.Add(BairroLabel)
	      Me.Panel13.Controls.Add(Me.txtUF)
	      Me.Panel13.Controls.Add(Me.txtCidade)
	      Me.Panel13.Controls.Add(Me.txtEndNumero)
	      Me.Panel13.Controls.Add(EndNumeroLabel)
	      Me.Panel13.Controls.Add(LogradouroLabel)
	      Me.Panel13.Controls.Add(Me.chkEntrega)
	      Me.Panel13.Controls.Add(CidadeLabel)
	      Me.Panel13.Location = New System.Drawing.Point(7, 207)
	      Me.Panel13.Name = "Panel13"
	      Me.Panel13.Size = New System.Drawing.Size(653, 277)
	      Me.Panel13.TabIndex = 104
	      '
	      'Panel12
	      '
	      Me.Panel12.BackColor = System.Drawing.Color.Silver
	      Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel12.Controls.Add(Me.TextBox1)
	      Me.Panel12.Controls.Add(Me.btnConsulta)
	      Me.Panel12.Controls.Add(Me.dgvCliente)
	      Me.Panel12.Controls.Add(Me.ToolStripContainer1)
	      Me.Panel12.Controls.Add(Me.txtTipo)
	      Me.Panel12.Controls.Add(Label12)
	      Me.Panel12.Controls.Add(Me.txtInscEstadual)
	      Me.Panel12.Controls.Add(Label10)
	      Me.Panel12.Controls.Add(Label2)
	      Me.Panel12.Controls.Add(TipoLabel)
	      Me.Panel12.Controls.Add(Me.txtContato)
	      Me.Panel12.Controls.Add(Me.txtCliente)
	      Me.Panel12.Controls.Add(CPFLabel)
	      Me.Panel12.Controls.Add(Me.txtCPFCliente)
	      Me.Panel12.Location = New System.Drawing.Point(5, 5)
	      Me.Panel12.Name = "Panel12"
	      Me.Panel12.Size = New System.Drawing.Size(655, 196)
	      Me.Panel12.TabIndex = 103
	      '
	      'Panel9
	      '
	      Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.Panel9.BackColor = System.Drawing.Color.White
	      Me.Panel9.Controls.Add(Me.txtItens)
	      Me.Panel9.Controls.Add(Label6)
	      Me.Panel9.Location = New System.Drawing.Point(391, 444)
	      Me.Panel9.Name = "Panel9"
	      Me.Panel9.Size = New System.Drawing.Size(304, 54)
	      Me.Panel9.TabIndex = 112
	      '
	      'txtItens
	      '
	      Me.txtItens.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
	      Me.txtItens.BackColor = System.Drawing.Color.White
	      Me.txtItens.BorderStyle = System.Windows.Forms.BorderStyle.None
	      Me.txtItens.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.txtItens.ForeColor = System.Drawing.Color.Black
	      Me.txtItens.Location = New System.Drawing.Point(100, 5)
	      Me.txtItens.Name = "txtItens"
	      Me.txtItens.Size = New System.Drawing.Size(202, 41)
	      Me.txtItens.TabIndex = 112
	      '
	      'Panel8
	      '
	      Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.Panel8.BackColor = System.Drawing.Color.White
	      Me.Panel8.Controls.Add(Me.txtSomaTotal)
	      Me.Panel8.Controls.Add(Label23)
	      Me.Panel8.Location = New System.Drawing.Point(699, 444)
	      Me.Panel8.Name = "Panel8"
	      Me.Panel8.Size = New System.Drawing.Size(352, 54)
	      Me.Panel8.TabIndex = 103
	      '
	      'Panel10
	      '
	      Me.Panel10.BackColor = System.Drawing.Color.White
	      Me.Panel10.Controls.Add(Me.Label26)
	      Me.Panel10.Controls.Add(Me.btnRE)
	      Me.Panel10.Controls.Add(Me.Label25)
	      Me.Panel10.Controls.Add(Me.btnAgendarEntrega)
	      Me.Panel10.Controls.Add(Me.Label24)
	      Me.Panel10.Controls.Add(Me.btnPagamento)
	      Me.Panel10.Controls.Add(Me.Label4)
	      Me.Panel10.Controls.Add(Me.btnImprimir)
	      Me.Panel10.Controls.Add(Me.Label22)
	      Me.Panel10.Controls.Add(Me.btnVoltar)
	      Me.Panel10.Controls.Add(Me.grpshow2)
	      Me.Panel10.Controls.Add(Me.Label21)
	      Me.Panel10.Controls.Add(Me.Label17)
	      Me.Panel10.Controls.Add(Me.btnCarregarPedido)
	      Me.Panel10.Controls.Add(Me.dgvPagamento)
	      Me.Panel10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Panel10.Location = New System.Drawing.Point(3, 334)
	      Me.Panel10.Name = "Panel10"
	      Me.Panel10.Size = New System.Drawing.Size(382, 164)
	      Me.Panel10.TabIndex = 116
	      '
	      'Label26
	      '
	      Me.Label26.AutoSize = True
	      Me.Label26.BackColor = System.Drawing.Color.Transparent
	      Me.Label26.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label26.Location = New System.Drawing.Point(77, 125)
	      Me.Label26.Name = "Label26"
	      Me.Label26.Size = New System.Drawing.Size(57, 20)
	      Me.Label26.TabIndex = 127
	      Me.Label26.Text = "Retirada"
	      Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnRE
	      '
	      Me.btnRE.BackColor = System.Drawing.Color.White
	      Me.btnRE.BackgroundImage = Global.ControleOS.My.Resources.Resources.chkbox
	      Me.btnRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnRE.FlatAppearance.BorderSize = 0
	      Me.btnRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnRE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnRE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnRE.Location = New System.Drawing.Point(82, 87)
	      Me.btnRE.Name = "btnRE"
	      Me.btnRE.Size = New System.Drawing.Size(50, 36)
	      Me.btnRE.TabIndex = 126
	      Me.btnRE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnRE.UseVisualStyleBackColor = False
	      '
	      'Label25
	      '
	      Me.Label25.AutoSize = True
	      Me.Label25.BackColor = System.Drawing.Color.Transparent
	      Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label25.Location = New System.Drawing.Point(12, 125)
	      Me.Label25.Name = "Label25"
	      Me.Label25.Size = New System.Drawing.Size(57, 20)
	      Me.Label25.TabIndex = 125
	      Me.Label25.Text = "Agendar"
	      Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnAgendarEntrega
	      '
	      Me.btnAgendarEntrega.BackColor = System.Drawing.Color.White
	      Me.btnAgendarEntrega.BackgroundImage = Global.ControleOS.My.Resources.Resources.calendario
	      Me.btnAgendarEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnAgendarEntrega.FlatAppearance.BorderSize = 0
	      Me.btnAgendarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnAgendarEntrega.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnAgendarEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnAgendarEntrega.Location = New System.Drawing.Point(17, 87)
	      Me.btnAgendarEntrega.Name = "btnAgendarEntrega"
	      Me.btnAgendarEntrega.Size = New System.Drawing.Size(50, 36)
	      Me.btnAgendarEntrega.TabIndex = 124
	      Me.btnAgendarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnAgendarEntrega.UseVisualStyleBackColor = False
	      '
	      'Label24
	      '
	      Me.Label24.AutoSize = True
	      Me.Label24.BackColor = System.Drawing.Color.Transparent
	      Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label24.Location = New System.Drawing.Point(17, 49)
	      Me.Label24.Name = "Label24"
	      Me.Label24.Size = New System.Drawing.Size(50, 20)
	      Me.Label24.TabIndex = 123
	      Me.Label24.Text = "Faturar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
	      Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnPagamento
	      '
	      Me.btnPagamento.BackColor = System.Drawing.Color.White
	      Me.btnPagamento.BackgroundImage = Global.ControleOS.My.Resources.Resources.Faturar
	      Me.btnPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnPagamento.FlatAppearance.BorderSize = 0
	      Me.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnPagamento.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnPagamento.Location = New System.Drawing.Point(17, 11)
	      Me.btnPagamento.Name = "btnPagamento"
	      Me.btnPagamento.Size = New System.Drawing.Size(50, 36)
	      Me.btnPagamento.TabIndex = 66
	      Me.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnPagamento.UseVisualStyleBackColor = False
	      '
	      'Label4
	      '
	      Me.Label4.AutoSize = True
	      Me.Label4.BackColor = System.Drawing.Color.Transparent
	      Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label4.Location = New System.Drawing.Point(78, 49)
	      Me.Label4.Name = "Label4"
	      Me.Label4.Size = New System.Drawing.Size(58, 20)
	      Me.Label4.TabIndex = 119
	      Me.Label4.Text = "Carregar"
	      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnImprimir
	      '
	      Me.btnImprimir.BackColor = System.Drawing.Color.White
	      Me.btnImprimir.BackgroundImage = Global.ControleOS.My.Resources.Resources.Imprimir1
	      Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnImprimir.FlatAppearance.BorderSize = 0
	      Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
	      Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
	      Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnImprimir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnImprimir.Location = New System.Drawing.Point(296, 11)
	      Me.btnImprimir.Name = "btnImprimir"
	      Me.btnImprimir.Size = New System.Drawing.Size(57, 36)
	      Me.btnImprimir.TabIndex = 75
	      Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnImprimir.UseVisualStyleBackColor = False
	      '
	      'Label22
	      '
	      Me.Label22.AutoSize = True
	      Me.Label22.BackColor = System.Drawing.Color.Transparent
	      Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label22.Location = New System.Drawing.Point(151, 50)
	      Me.Label22.Name = "Label22"
	      Me.Label22.Size = New System.Drawing.Size(43, 20)
	      Me.Label22.TabIndex = 122
	      Me.Label22.Text = "Voltar"
	      Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnVoltar
	      '
	      Me.btnVoltar.BackColor = System.Drawing.Color.White
	      Me.btnVoltar.BackgroundImage = Global.ControleOS.My.Resources.Resources.Voltar2
	      Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnVoltar.FlatAppearance.BorderSize = 0
	      Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnVoltar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnVoltar.Location = New System.Drawing.Point(148, 11)
	      Me.btnVoltar.Name = "btnVoltar"
	      Me.btnVoltar.Size = New System.Drawing.Size(50, 36)
	      Me.btnVoltar.TabIndex = 64
	      Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnVoltar.UseVisualStyleBackColor = False
	      '
	      'grpshow2
	      '
	      Me.grpshow2.BackColor = System.Drawing.Color.White
	      Me.grpshow2.BackgroundImage = Global.ControleOS.My.Resources.Resources.Boleto2
	      Me.grpshow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.grpshow2.FlatAppearance.BorderSize = 0
	      Me.grpshow2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.grpshow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.grpshow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.grpshow2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.grpshow2.ForeColor = System.Drawing.Color.Black
	      Me.grpshow2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.grpshow2.Location = New System.Drawing.Point(218, 11)
	      Me.grpshow2.Name = "grpshow2"
	      Me.grpshow2.Size = New System.Drawing.Size(56, 36)
	      Me.grpshow2.TabIndex = 98
	      Me.grpshow2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.grpshow2.UseVisualStyleBackColor = False
	      '
	      'Label21
	      '
	      Me.Label21.AutoSize = True
	      Me.Label21.BackColor = System.Drawing.Color.Transparent
	      Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label21.Location = New System.Drawing.Point(298, 49)
	      Me.Label21.Name = "Label21"
	      Me.Label21.Size = New System.Drawing.Size(55, 20)
	      Me.Label21.TabIndex = 121
	      Me.Label21.Text = "Imprimir"
	      Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'Label17
	      '
	      Me.Label17.AutoSize = True
	      Me.Label17.BackColor = System.Drawing.Color.Transparent
	      Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label17.Location = New System.Drawing.Point(208, 49)
	      Me.Label17.Name = "Label17"
	      Me.Label17.Size = New System.Drawing.Size(74, 20)
	      Me.Label17.TabIndex = 120
	      Me.Label17.Text = "Info.Cliente"
	      Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
	      '
	      'btnCarregarPedido
	      '
	      Me.btnCarregarPedido.BackColor = System.Drawing.Color.White
	      Me.btnCarregarPedido.BackgroundImage = Global.ControleOS.My.Resources.Resources.Carregar
	      Me.btnCarregarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.btnCarregarPedido.FlatAppearance.BorderSize = 0
	      Me.btnCarregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnCarregarPedido.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.btnCarregarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnCarregarPedido.Location = New System.Drawing.Point(80, 11)
	      Me.btnCarregarPedido.Name = "btnCarregarPedido"
	      Me.btnCarregarPedido.Size = New System.Drawing.Size(55, 36)
	      Me.btnCarregarPedido.TabIndex = 61
	      Me.btnCarregarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnCarregarPedido.UseVisualStyleBackColor = False
	      Me.btnCarregarPedido.Visible = False
	      '
	      'Panel11
	      '
	      Me.Panel11.BackColor = System.Drawing.Color.White
	      Me.Panel11.Controls.Add(Me.txtProdutoID)
	      Me.Panel11.Controls.Add(Label13)
	      Me.Panel11.Controls.Add(Me.cboTabelaPagamento)
	      Me.Panel11.Controls.Add(Me.txtGenero)
	      Me.Panel11.Controls.Add(Me.txtCategoriaProduto)
	      Me.Panel11.Controls.Add(Categoria_PadrãoLabel)
	      Me.Panel11.Controls.Add(ProdutoIDLabel)
	      Me.Panel11.Controls.Add(Me.txtUnidade)
	      Me.Panel11.Controls.Add(Me.cboTabela)
	      Me.Panel11.Controls.Add(Me.txtCusto)
	      Me.Panel11.Controls.Add(Me.lblRetirar)
	      Me.Panel11.Controls.Add(Saldo_EstoqueLabel)
	      Me.Panel11.Controls.Add(Me.txtValorVendaTotal)
	      Me.Panel11.Controls.Add(CustoLabel)
	      Me.Panel11.Controls.Add(Me.Label9)
	      Me.Panel11.Controls.Add(Label7)
	      Me.Panel11.Controls.Add(Me.txtSaldoEstoque)
	      Me.Panel11.Controls.Add(GêneroLabel)
	      Me.Panel11.Controls.Add(Me.chkRetirar)
	      Me.Panel11.Controls.Add(Me.Label11)
	      Me.Panel11.Location = New System.Drawing.Point(3, 205)
	      Me.Panel11.Name = "Panel11"
	      Me.Panel11.Size = New System.Drawing.Size(382, 126)
	      Me.Panel11.TabIndex = 116
	      '
	      'Panel1
	      '
	      Me.Panel1.Controls.Add(Me.Panel8)
	      Me.Panel1.Controls.Add(Me.Panel9)
	      Me.Panel1.Controls.Add(Me.Panel6)
	      Me.Panel1.Controls.Add(Me.Panel3)
	      Me.Panel1.Controls.Add(Me.Panel11)
	      Me.Panel1.Controls.Add(Me.Panel5)
	      Me.Panel1.Controls.Add(Me.Panel10)
	      Me.Panel1.Location = New System.Drawing.Point(12, 76)
	      Me.Panel1.Name = "Panel1"
	      Me.Panel1.Size = New System.Drawing.Size(1054, 503)
	      Me.Panel1.TabIndex = 117
	      '
	      'Panel6
	      '
	      Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
	  Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.Panel6.AutoScroll = True
	      Me.Panel6.BackColor = System.Drawing.Color.White
	      Me.Panel6.BackgroundImage = Global.ControleOS.My.Resources.Resources.NLG
	      Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
	      Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.Panel6.Controls.Add(Me.PanelProdutos)
	      Me.Panel6.Controls.Add(Me.dgvProdutos)
	      Me.Panel6.Controls.Add(Me.dgvProdutosVinc)
	      Me.Panel6.Controls.Add(Me.dgvProdutosSemCusto)
	      Me.Panel6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Panel6.Location = New System.Drawing.Point(391, 64)
	      Me.Panel6.Name = "Panel6"
	      Me.Panel6.Size = New System.Drawing.Size(660, 378)
	      Me.Panel6.TabIndex = 102
	      '
	      'PanelProdutos
	      '
	      Me.PanelProdutos.BackColor = System.Drawing.Color.WhiteSmoke
	      Me.PanelProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	      Me.PanelProdutos.Controls.Add(Me.txtAddProduto2)
	      Me.PanelProdutos.Controls.Add(Me.Label8)
	      Me.PanelProdutos.Controls.Add(Me.txtCodePesq)
	      Me.PanelProdutos.Controls.Add(Me.btnConfirmarEscolha)
	      Me.PanelProdutos.Controls.Add(Me.lblPesquisarProdutos)
	      Me.PanelProdutos.Controls.Add(Me.txtPesqProduto)
	      Me.PanelProdutos.Controls.Add(Me.dgvListaProduto)
	      Me.PanelProdutos.Controls.Add(Me.dgvRE)
	      Me.PanelProdutos.Location = New System.Drawing.Point(33, 64)
	      Me.PanelProdutos.Name = "PanelProdutos"
	      Me.PanelProdutos.Size = New System.Drawing.Size(595, 267)
	      Me.PanelProdutos.TabIndex = 88
	      Me.PanelProdutos.Visible = False
	      '
	      'txtAddProduto2
	      '
	      Me.txtAddProduto2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
	      Me.txtAddProduto2.AutoEllipsis = True
	      Me.txtAddProduto2.BackColor = System.Drawing.Color.Transparent
	      Me.txtAddProduto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.txtAddProduto2.DialogResult = System.Windows.Forms.DialogResult.Cancel
	      Me.txtAddProduto2.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
	      Me.txtAddProduto2.FlatAppearance.BorderSize = 0
	      Me.txtAddProduto2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.txtAddProduto2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.txtAddProduto2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
	      Me.txtAddProduto2.Image = Global.ControleOS.My.Resources.Resources.Adicionar1
	      Me.txtAddProduto2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.txtAddProduto2.Location = New System.Drawing.Point(108, 222)
	      Me.txtAddProduto2.Name = "txtAddProduto2"
	      Me.txtAddProduto2.Size = New System.Drawing.Size(90, 39)
	      Me.txtAddProduto2.TabIndex = 108
	      Me.txtAddProduto2.Text = "Selecionar"
	      Me.txtAddProduto2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.txtAddProduto2.UseVisualStyleBackColor = False
	      '
	      'Label8
	      '
	      Me.Label8.AutoSize = True
	      Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.Label8.Location = New System.Drawing.Point(383, 8)
	      Me.Label8.Name = "Label8"
	      Me.Label8.Size = New System.Drawing.Size(48, 16)
	      Me.Label8.TabIndex = 115
	      Me.Label8.Text = "Via Code"
	      '
	      'txtCodePesq
	      '
	      Me.txtCodePesq.AutoCompleteCustomSource.AddRange(New String() {"testando a opção de auto completar"})
	      Me.txtCodePesq.Location = New System.Drawing.Point(386, 26)
	      Me.txtCodePesq.Name = "txtCodePesq"
	      Me.txtCodePesq.Size = New System.Drawing.Size(145, 20)
	      Me.txtCodePesq.TabIndex = 114
	      '
	      'btnConfirmarEscolha
	      '
	      Me.btnConfirmarEscolha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
	      Me.btnConfirmarEscolha.BackColor = System.Drawing.Color.Transparent
	      Me.btnConfirmarEscolha.FlatAppearance.BorderSize = 0
	      Me.btnConfirmarEscolha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnConfirmarEscolha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnConfirmarEscolha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
	      Me.btnConfirmarEscolha.ForeColor = System.Drawing.Color.Black
	      Me.btnConfirmarEscolha.Image = Global.ControleOS.My.Resources.Resources.Voltar
	      Me.btnConfirmarEscolha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
	      Me.btnConfirmarEscolha.Location = New System.Drawing.Point(16, 222)
	      Me.btnConfirmarEscolha.Name = "btnConfirmarEscolha"
	      Me.btnConfirmarEscolha.Size = New System.Drawing.Size(90, 39)
	      Me.btnConfirmarEscolha.TabIndex = 108
	      Me.btnConfirmarEscolha.Text = "&Voltar"
	      Me.btnConfirmarEscolha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
	      Me.btnConfirmarEscolha.UseVisualStyleBackColor = False
	      '
	      'lblPesquisarProdutos
	      '
	      Me.lblPesquisarProdutos.AutoSize = True
	      Me.lblPesquisarProdutos.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      Me.lblPesquisarProdutos.Location = New System.Drawing.Point(16, 10)
	      Me.lblPesquisarProdutos.Name = "lblPesquisarProdutos"
	      Me.lblPesquisarProdutos.Size = New System.Drawing.Size(50, 16)
	      Me.lblPesquisarProdutos.TabIndex = 111
	      Me.lblPesquisarProdutos.Text = "Pesquisar"
	      '
	      'txtPesqProduto
	      '
	      Me.txtPesqProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
	      Me.txtPesqProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
	      Me.txtPesqProduto.Location = New System.Drawing.Point(16, 26)
	      Me.txtPesqProduto.Name = "txtPesqProduto"
	      Me.txtPesqProduto.Size = New System.Drawing.Size(364, 20)
	      Me.txtPesqProduto.TabIndex = 91
	      '
	      'dgvListaProduto
	      '
	      Me.dgvListaProduto.AllowUserToAddRows = False
	      Me.dgvListaProduto.AllowUserToDeleteRows = False
	      Me.dgvListaProduto.AllowUserToResizeRows = False
	      Me.dgvListaProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
	  Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvListaProduto.BackgroundColor = System.Drawing.Color.White
	      Me.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvListaProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaldoEstoque})
	      Me.dgvListaProduto.EnableHeadersVisualStyles = False
	      Me.dgvListaProduto.Location = New System.Drawing.Point(16, 52)
	      Me.dgvListaProduto.Name = "dgvListaProduto"
	      Me.dgvListaProduto.ReadOnly = True
	      Me.dgvListaProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
	      Me.dgvListaProduto.RowHeadersVisible = False
	      Me.dgvListaProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
	      Me.dgvListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvListaProduto.Size = New System.Drawing.Size(566, 167)
	      Me.dgvListaProduto.TabIndex = 2
	      Me.dgvListaProduto.Visible = False
	      '
	      'SaldoEstoque
	      '
	      Me.SaldoEstoque.DataPropertyName = "SaldoEstoque"
	      Me.SaldoEstoque.FillWeight = 15.0!
	      Me.SaldoEstoque.HeaderText = "SaldoEstoque"
	      Me.SaldoEstoque.Name = "SaldoEstoque"
	      Me.SaldoEstoque.ReadOnly = True
	      '
	      'dgvRE
	      '
	      Me.dgvRE.AllowUserToAddRows = False
	      Me.dgvRE.AllowUserToDeleteRows = False
	      Me.dgvRE.AllowUserToOrderColumns = True
	      Me.dgvRE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvRE.AutoGenerateColumns = False
	      Me.dgvRE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvRE.BackgroundColor = System.Drawing.Color.White
	      Me.dgvRE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
	      Me.dgvRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvRE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewComboBoxColumn1})
	      Me.dgvRE.DataSource = Me.TbProdutoVendaPDVBindingSource1
	      DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
	      DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvRE.DefaultCellStyle = DataGridViewCellStyle15
	      Me.dgvRE.Location = New System.Drawing.Point(198, 88)
	      Me.dgvRE.Name = "dgvRE"
	      Me.dgvRE.RowHeadersVisible = False
	      Me.dgvRE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
	      Me.dgvRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvRE.Size = New System.Drawing.Size(289, 103)
	      Me.dgvRE.TabIndex = 89
	      Me.dgvRE.Visible = False
	      '
	      'DataGridViewTextBoxColumn26
	      '
	      Me.DataGridViewTextBoxColumn26.DataPropertyName = "Produto"
	      Me.DataGridViewTextBoxColumn26.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn26.HeaderText = "Descrição"
	      Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
	      '
	      'DataGridViewComboBoxColumn1
	      '
	      Me.DataGridViewComboBoxColumn1.DataPropertyName = "Retirado"
	      Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
	      Me.DataGridViewComboBoxColumn1.FillWeight = 109.6447!
	      Me.DataGridViewComboBoxColumn1.HeaderText = "R/E"
	      Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"RETIRAR", "ENTREGAR"})
	      Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
	      Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
	      Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
	      '
	      'dgvProdutos
	      '
	      Me.dgvProdutos.AllowUserToAddRows = False
	      Me.dgvProdutos.AllowUserToDeleteRows = False
	      Me.dgvProdutos.AllowUserToOrderColumns = True
	      Me.dgvProdutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvProdutos.AutoGenerateColumns = False
	      Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
	      Me.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
	      Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdutoIDDataGridViewTextBoxColumn, Me.CategoriaPadraoDataGridViewTextBoxColumn, Me.ProdutoDataGridViewTextBoxColumn, Me.Quantidade, Me.ValorVendaDataGridViewTextBoxColumn, Me.SomaDataGridViewTextBoxColumn, Me.ValorCustoTotal, Me.Retirado, Me.x})
	      Me.dgvProdutos.DataSource = Me.TbProdutoVendaPDVBindingSource1
	      DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
	      DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle19
	      Me.dgvProdutos.Location = New System.Drawing.Point(0, -1)
	      Me.dgvProdutos.Name = "dgvProdutos"
	      Me.dgvProdutos.ReadOnly = True
	      Me.dgvProdutos.RowHeadersVisible = False
	      Me.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
	      Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvProdutos.Size = New System.Drawing.Size(659, 26)
	      Me.dgvProdutos.TabIndex = 1
	      '
	      'ProdutoIDDataGridViewTextBoxColumn
	      '
	      Me.ProdutoIDDataGridViewTextBoxColumn.DataPropertyName = "ProdutoID"
	      Me.ProdutoIDDataGridViewTextBoxColumn.FillWeight = 228.4265!
	      Me.ProdutoIDDataGridViewTextBoxColumn.HeaderText = "Código"
	      Me.ProdutoIDDataGridViewTextBoxColumn.Name = "ProdutoIDDataGridViewTextBoxColumn"
	      Me.ProdutoIDDataGridViewTextBoxColumn.ReadOnly = True
	      Me.ProdutoIDDataGridViewTextBoxColumn.Width = 50
	      '
	      'CategoriaPadraoDataGridViewTextBoxColumn
	      '
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.DataPropertyName = "CategoriaPadrao"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.FillWeight = 93.16631!
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.HeaderText = "Categoria"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.Name = "CategoriaPadraoDataGridViewTextBoxColumn"
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.ReadOnly = True
	      Me.CategoriaPadraoDataGridViewTextBoxColumn.Width = 99
	      '
	      'ProdutoDataGridViewTextBoxColumn
	      '
	      Me.ProdutoDataGridViewTextBoxColumn.DataPropertyName = "Produto"
	      Me.ProdutoDataGridViewTextBoxColumn.FillWeight = 93.16631!
	      Me.ProdutoDataGridViewTextBoxColumn.HeaderText = "Descrição"
	      Me.ProdutoDataGridViewTextBoxColumn.Name = "ProdutoDataGridViewTextBoxColumn"
	      Me.ProdutoDataGridViewTextBoxColumn.ReadOnly = True
	      Me.ProdutoDataGridViewTextBoxColumn.Width = 99
	      '
	      'Quantidade
	      '
	      Me.Quantidade.DataPropertyName = "Quantidade"
	      Me.Quantidade.FillWeight = 93.16631!
	      Me.Quantidade.HeaderText = "Quantidade"
	      Me.Quantidade.Name = "Quantidade"
	      Me.Quantidade.ReadOnly = True
	      Me.Quantidade.Width = 99
	      '
	      'ValorVendaDataGridViewTextBoxColumn
	      '
	      Me.ValorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda"
	      DataGridViewCellStyle16.Format = "C2"
	      DataGridViewCellStyle16.NullValue = Nothing
	      Me.ValorVendaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
	      Me.ValorVendaDataGridViewTextBoxColumn.FillWeight = 93.16631!
	      Me.ValorVendaDataGridViewTextBoxColumn.HeaderText = "Valor Unit."
	      Me.ValorVendaDataGridViewTextBoxColumn.Name = "ValorVendaDataGridViewTextBoxColumn"
	      Me.ValorVendaDataGridViewTextBoxColumn.ReadOnly = True
	      Me.ValorVendaDataGridViewTextBoxColumn.Width = 99
	      '
	      'SomaDataGridViewTextBoxColumn
	      '
	      Me.SomaDataGridViewTextBoxColumn.DataPropertyName = "Soma"
	      DataGridViewCellStyle17.Format = "C2"
	      DataGridViewCellStyle17.NullValue = Nothing
	      Me.SomaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
	      Me.SomaDataGridViewTextBoxColumn.FillWeight = 93.16631!
	      Me.SomaDataGridViewTextBoxColumn.HeaderText = "Subtotal"
	      Me.SomaDataGridViewTextBoxColumn.Name = "SomaDataGridViewTextBoxColumn"
	      Me.SomaDataGridViewTextBoxColumn.ReadOnly = True
	      Me.SomaDataGridViewTextBoxColumn.Width = 99
	      '
	      'ValorCustoTotal
	      '
	      Me.ValorCustoTotal.DataPropertyName = "ValorCustoTotal"
	      DataGridViewCellStyle18.Format = "C2"
	      DataGridViewCellStyle18.NullValue = Nothing
	      Me.ValorCustoTotal.DefaultCellStyle = DataGridViewCellStyle18
	      Me.ValorCustoTotal.FillWeight = 93.16631!
	      Me.ValorCustoTotal.HeaderText = "Custo Total"
	      Me.ValorCustoTotal.Name = "ValorCustoTotal"
	      Me.ValorCustoTotal.ReadOnly = True
	      Me.ValorCustoTotal.Width = 99
	      '
	      'Retirado
	      '
	      Me.Retirado.DataPropertyName = "Retirado"
	      Me.Retirado.FillWeight = 93.16631!
	      Me.Retirado.HeaderText = "R/E"
	      Me.Retirado.Name = "Retirado"
	      Me.Retirado.ReadOnly = True
	      Me.Retirado.Width = 98
	      '
	      'x
	      '
	      Me.x.FillWeight = 19.40964!
	      Me.x.HeaderText = "x"
	      Me.x.Name = "x"
	      Me.x.ReadOnly = True
	      Me.x.Width = 21
	      '
	      'dgvProdutosVinc
	      '
	      Me.dgvProdutosVinc.AllowUserToAddRows = False
	      Me.dgvProdutosVinc.AllowUserToDeleteRows = False
	      Me.dgvProdutosVinc.AllowUserToOrderColumns = True
	      Me.dgvProdutosVinc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvProdutosVinc.AutoGenerateColumns = False
	      Me.dgvProdutosVinc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvProdutosVinc.BackgroundColor = System.Drawing.Color.White
	      Me.dgvProdutosVinc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
	      Me.dgvProdutosVinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvProdutosVinc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
	      Me.dgvProdutosVinc.DataSource = Me.TbProdutoVendaPDVvincBindingSource
	      DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle23.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
	      DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvProdutosVinc.DefaultCellStyle = DataGridViewCellStyle23
	      Me.dgvProdutosVinc.Location = New System.Drawing.Point(0, -1)
	      Me.dgvProdutosVinc.Name = "dgvProdutosVinc"
	      Me.dgvProdutosVinc.ReadOnly = True
	      Me.dgvProdutosVinc.RowHeadersVisible = False
	      Me.dgvProdutosVinc.ScrollBars = System.Windows.Forms.ScrollBars.None
	      Me.dgvProdutosVinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvProdutosVinc.Size = New System.Drawing.Size(659, 26)
	      Me.dgvProdutosVinc.TabIndex = 87
	      '
	      'DataGridViewTextBoxColumn14
	      '
	      Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProdutoID"
	      Me.DataGridViewTextBoxColumn14.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn14.HeaderText = "Código"
	      Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
	      Me.DataGridViewTextBoxColumn14.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn17
	      '
	      Me.DataGridViewTextBoxColumn17.DataPropertyName = "CategoriaPadrao"
	      Me.DataGridViewTextBoxColumn17.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn17.HeaderText = "Categoria"
	      Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
	      Me.DataGridViewTextBoxColumn17.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn18
	      '
	      Me.DataGridViewTextBoxColumn18.DataPropertyName = "Produto"
	      Me.DataGridViewTextBoxColumn18.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn18.HeaderText = "Descrição"
	      Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
	      Me.DataGridViewTextBoxColumn18.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn19
	      '
	      Me.DataGridViewTextBoxColumn19.DataPropertyName = "Quantidade"
	      Me.DataGridViewTextBoxColumn19.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn19.HeaderText = "Quantidade"
	      Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
	      Me.DataGridViewTextBoxColumn19.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn20
	      '
	      Me.DataGridViewTextBoxColumn20.DataPropertyName = "ValorVenda"
	      DataGridViewCellStyle20.Format = "C2"
	      DataGridViewCellStyle20.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle20
	      Me.DataGridViewTextBoxColumn20.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn20.HeaderText = "Valor Unit."
	      Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
	      Me.DataGridViewTextBoxColumn20.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn21
	      '
	      Me.DataGridViewTextBoxColumn21.DataPropertyName = "Soma"
	      DataGridViewCellStyle21.Format = "C2"
	      DataGridViewCellStyle21.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle21
	      Me.DataGridViewTextBoxColumn21.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn21.HeaderText = "Subtotal"
	      Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
	      Me.DataGridViewTextBoxColumn21.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn22
	      '
	      Me.DataGridViewTextBoxColumn22.DataPropertyName = "ValorCustoTotal"
	      DataGridViewCellStyle22.Format = "C2"
	      DataGridViewCellStyle22.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle22
	      Me.DataGridViewTextBoxColumn22.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn22.HeaderText = "Custo Total"
	      Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
	      Me.DataGridViewTextBoxColumn22.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn23
	      '
	      Me.DataGridViewTextBoxColumn23.DataPropertyName = "Retirado"
	      Me.DataGridViewTextBoxColumn23.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn23.HeaderText = "R/E"
	      Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
	      Me.DataGridViewTextBoxColumn23.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn24
	      '
	      Me.DataGridViewTextBoxColumn24.FillWeight = 22.84264!
	      Me.DataGridViewTextBoxColumn24.HeaderText = "x"
	      Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
	      Me.DataGridViewTextBoxColumn24.ReadOnly = True
	      '
	      'dgvProdutosSemCusto
	      '
	      Me.dgvProdutosSemCusto.AllowUserToAddRows = False
	      Me.dgvProdutosSemCusto.AllowUserToDeleteRows = False
	      Me.dgvProdutosSemCusto.AllowUserToOrderColumns = True
	      Me.dgvProdutosSemCusto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
	  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
	      Me.dgvProdutosSemCusto.AutoGenerateColumns = False
	      Me.dgvProdutosSemCusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
	      Me.dgvProdutosSemCusto.BackgroundColor = System.Drawing.Color.White
	      Me.dgvProdutosSemCusto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
	      Me.dgvProdutosSemCusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvProdutosSemCusto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
	      Me.dgvProdutosSemCusto.DataSource = Me.TbProdutoVendaPDVBindingSource1
	      DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
	      DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
	      DataGridViewCellStyle26.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	      DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
	      DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(65, Byte), Integer))
	      DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	      DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	      Me.dgvProdutosSemCusto.DefaultCellStyle = DataGridViewCellStyle26
	      Me.dgvProdutosSemCusto.Location = New System.Drawing.Point(0, 0)
	      Me.dgvProdutosSemCusto.Name = "dgvProdutosSemCusto"
	      Me.dgvProdutosSemCusto.ReadOnly = True
	      Me.dgvProdutosSemCusto.RowHeadersVisible = False
	      Me.dgvProdutosSemCusto.ScrollBars = System.Windows.Forms.ScrollBars.None
	      Me.dgvProdutosSemCusto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	      Me.dgvProdutosSemCusto.Size = New System.Drawing.Size(659, 24)
	      Me.dgvProdutosSemCusto.TabIndex = 81
	      '
	      'DataGridViewTextBoxColumn1
	      '
	      Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdutoID"
	      Me.DataGridViewTextBoxColumn1.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
	      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
	      Me.DataGridViewTextBoxColumn1.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn9
	      '
	      Me.DataGridViewTextBoxColumn9.DataPropertyName = "CategoriaPadrao"
	      Me.DataGridViewTextBoxColumn9.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn9.HeaderText = "Categoria"
	      Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
	      Me.DataGridViewTextBoxColumn9.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn10
	      '
	      Me.DataGridViewTextBoxColumn10.DataPropertyName = "Produto"
	      Me.DataGridViewTextBoxColumn10.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn10.HeaderText = "Descrição"
	      Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
	      Me.DataGridViewTextBoxColumn10.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn11
	      '
	      Me.DataGridViewTextBoxColumn11.DataPropertyName = "Quantidade"
	      Me.DataGridViewTextBoxColumn11.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn11.HeaderText = "Quantidade"
	      Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
	      Me.DataGridViewTextBoxColumn11.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn12
	      '
	      Me.DataGridViewTextBoxColumn12.DataPropertyName = "ValorVenda"
	      DataGridViewCellStyle24.Format = "C2"
	      DataGridViewCellStyle24.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle24
	      Me.DataGridViewTextBoxColumn12.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn12.HeaderText = "Valor Unit."
	      Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
	      Me.DataGridViewTextBoxColumn12.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn13
	      '
	      Me.DataGridViewTextBoxColumn13.DataPropertyName = "Soma"
	      DataGridViewCellStyle25.Format = "C2"
	      DataGridViewCellStyle25.NullValue = Nothing
	      Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle25
	      Me.DataGridViewTextBoxColumn13.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn13.HeaderText = "Subtotal"
	      Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
	      Me.DataGridViewTextBoxColumn13.ReadOnly = True
	      '
	      'DataGridViewTextBoxColumn15
	      '
	      Me.DataGridViewTextBoxColumn15.DataPropertyName = "Retirado"
	      Me.DataGridViewTextBoxColumn15.FillWeight = 109.6447!
	      Me.DataGridViewTextBoxColumn15.HeaderText = "R/E"
	      Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
	      Me.DataGridViewTextBoxColumn15.ReadOnly = True
	      Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
	      '
	      'DataGridViewTextBoxColumn16
	      '
	      Me.DataGridViewTextBoxColumn16.FillWeight = 22.84264!
	      Me.DataGridViewTextBoxColumn16.HeaderText = "x"
	      Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
	      Me.DataGridViewTextBoxColumn16.ReadOnly = True
	      '
	      'Panel4
	      '
	      Me.Panel4.Controls.Add(Me.Panel2)
	      Me.Panel4.Location = New System.Drawing.Point(1072, 76)
	      Me.Panel4.Name = "Panel4"
	      Me.Panel4.Size = New System.Drawing.Size(1054, 509)
	      Me.Panel4.TabIndex = 118
	      '
	      'CodEndDataGridViewTextBoxColumn
	      '
	      Me.CodEndDataGridViewTextBoxColumn.DataPropertyName = "CodEnd"
	      Me.CodEndDataGridViewTextBoxColumn.HeaderText = "CodEnd"
	      Me.CodEndDataGridViewTextBoxColumn.Name = "CodEndDataGridViewTextBoxColumn"
	      Me.CodEndDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'LogradouroDataGridViewTextBoxColumn
	      '
	      Me.LogradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro"
	      Me.LogradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro"
	      Me.LogradouroDataGridViewTextBoxColumn.Name = "LogradouroDataGridViewTextBoxColumn"
	      Me.LogradouroDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'EndNumeroDataGridViewTextBoxColumn
	      '
	      Me.EndNumeroDataGridViewTextBoxColumn.DataPropertyName = "EndNumero"
	      Me.EndNumeroDataGridViewTextBoxColumn.HeaderText = "EndNumero"
	      Me.EndNumeroDataGridViewTextBoxColumn.Name = "EndNumeroDataGridViewTextBoxColumn"
	      Me.EndNumeroDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'BairroDataGridViewTextBoxColumn
	      '
	      Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
	      Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
	      Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
	      Me.BairroDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'CidadeDataGridViewTextBoxColumn
	      '
	      Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade"
	      Me.CidadeDataGridViewTextBoxColumn.HeaderText = "Cidade"
	      Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
	      Me.CidadeDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'UFDataGridViewTextBoxColumn
	      '
	      Me.UFDataGridViewTextBoxColumn.DataPropertyName = "UF"
	      Me.UFDataGridViewTextBoxColumn.HeaderText = "UF"
	      Me.UFDataGridViewTextBoxColumn.Name = "UFDataGridViewTextBoxColumn"
	      Me.UFDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'ComplementoDataGridViewTextBoxColumn
	      '
	      Me.ComplementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento"
	      Me.ComplementoDataGridViewTextBoxColumn.HeaderText = "Complemento"
	      Me.ComplementoDataGridViewTextBoxColumn.Name = "ComplementoDataGridViewTextBoxColumn"
	      Me.ComplementoDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'TipoDataGridViewTextBoxColumn2
	      '
	      Me.TipoDataGridViewTextBoxColumn2.DataPropertyName = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn2.HeaderText = "Tipo"
	      Me.TipoDataGridViewTextBoxColumn2.Name = "TipoDataGridViewTextBoxColumn2"
	      Me.TipoDataGridViewTextBoxColumn2.ReadOnly = True
	      '
	      'IDDataGridViewTextBoxColumn
	      '
	      Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
	      Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
	      Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
	      Me.IDDataGridViewTextBoxColumn.ReadOnly = True
	      '
	      'dgvContato
	      '
	      Me.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	      Me.dgvContato.Location = New System.Drawing.Point(1390, 591)
	      Me.dgvContato.Name = "dgvContato"
	      Me.dgvContato.Size = New System.Drawing.Size(240, 150)
	      Me.dgvContato.TabIndex = 119
	      '
	      'btnConsulta
	      '
	      Me.btnConsulta.BackColor = System.Drawing.Color.Indigo
	      Me.btnConsulta.FlatAppearance.BorderSize = 0
	      Me.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo
	      Me.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
	      Me.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	      Me.btnConsulta.ForeColor = System.Drawing.Color.White
	      Me.btnConsulta.Location = New System.Drawing.Point(440, 121)
	      Me.btnConsulta.Name = "btnConsulta"
	      Me.btnConsulta.Size = New System.Drawing.Size(118, 21)
	      Me.btnConsulta.TabIndex = 100
	      Me.btnConsulta.Text = "Fazer Consulta"
	      Me.btnConsulta.UseVisualStyleBackColor = False
	      '
	      'TextBox1
	      '
	      Me.TextBox1.Location = New System.Drawing.Point(440, 85)
	      Me.TextBox1.Name = "TextBox1"
	      Me.TextBox1.Size = New System.Drawing.Size(100, 20)
	      Me.TextBox1.TabIndex = 101
	      '
	      'FrmPDV
	      '
	      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	      Me.AutoScroll = True
	      Me.AutoScrollMargin = New System.Drawing.Size(0, 100)
	      Me.AutoScrollMinSize = New System.Drawing.Size(600, 600)
	      Me.BackColor = System.Drawing.Color.LightGray
	      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
	      Me.ClientSize = New System.Drawing.Size(1632, 778)
	      Me.ControlBox = False
	      Me.Controls.Add(Me.dgvContato)
	      Me.Controls.Add(Me.Panel4)
	      Me.Controls.Add(Me.Panel1)
	      Me.KeyPreview = True
	      Me.Name = "FrmPDV"
	      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
	      CType(Me.TbProdutoVendaPDVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataPdv1, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbProdutoPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbEndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbProdutoVendaPDVvincBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbPedido2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.DataPdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.TbProdutoVendaPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.EntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvPagamento, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel5.ResumeLayout(False)
	      Me.Panel5.PerformLayout()
	      Me.Panel3.ResumeLayout(False)
	      Me.Panel3.PerformLayout()
	      CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
	      Me.ToolStripContainer1.ContentPanel.PerformLayout()
	      Me.ToolStripContainer1.ResumeLayout(False)
	      Me.ToolStripContainer1.PerformLayout()
	      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
	      Me.ToolStripContainer2.ContentPanel.PerformLayout()
	      Me.ToolStripContainer2.ResumeLayout(False)
	      Me.ToolStripContainer2.PerformLayout()
	      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvEnd, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel2.ResumeLayout(False)
	      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel13.ResumeLayout(False)
	      Me.Panel13.PerformLayout()
	      Me.Panel12.ResumeLayout(False)
	      Me.Panel12.PerformLayout()
	      Me.Panel9.ResumeLayout(False)
	      Me.Panel9.PerformLayout()
	      Me.Panel8.ResumeLayout(False)
	      Me.Panel8.PerformLayout()
	      Me.Panel10.ResumeLayout(False)
	      Me.Panel10.PerformLayout()
	      Me.Panel11.ResumeLayout(False)
	      Me.Panel11.PerformLayout()
	      Me.Panel1.ResumeLayout(False)
	      Me.Panel6.ResumeLayout(False)
	      Me.PanelProdutos.ResumeLayout(False)
	      Me.PanelProdutos.PerformLayout()
	      CType(Me.dgvListaProduto, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvRE, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvProdutosVinc, System.ComponentModel.ISupportInitialize).EndInit()
	      CType(Me.dgvProdutosSemCusto, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.Panel4.ResumeLayout(False)
	      CType(Me.dgvContato, System.ComponentModel.ISupportInitialize).EndInit()
	      Me.ResumeLayout(False)

        End Sub
        Friend WithEvents DataPdv As DataPdv
        Friend WithEvents TbClientesBindingSource As BindingSource
        Friend WithEvents TbClientesTableAdapter As DataPdvTableAdapters.tbClientesTableAdapter
        Friend WithEvents TbProdutoVendaPDVBindingSource As BindingSource
        Friend WithEvents TbProdutoVendaPDVTableAdapter As DataPdvTableAdapters.tbProdutoVendaPDVTableAdapter
        Friend WithEvents TbProdutoPDVBindingSource As BindingSource
        Friend WithEvents TbProdutoPDVTableAdapter As DataPdvTableAdapters.tbProdutoPDVTableAdapter
        Friend WithEvents TableAdapterManager As DataPdvTableAdapters.TableAdapterManager
        Friend WithEvents DataPdvBindingSource As BindingSource
        Friend WithEvents ProdutoID As DataGridViewTextBoxColumn
        Friend WithEvents DataPdv1 As DataPdv
        Friend WithEvents TbProdutoVendaPDVBindingSource1 As BindingSource
        Friend WithEvents TbEndBindingSource As BindingSource
        Friend WithEvents TbEndTableAdapter As DataPdvTableAdapters.tbEndTableAdapter
        Friend WithEvents EntregaBindingSource As BindingSource
        Friend WithEvents EntregaTableAdapter As DataPdvTableAdapters.EntregaTableAdapter
        Friend WithEvents TbPedido2BindingSource As BindingSource
        Friend WithEvents TbPedido2TableAdapter As DataPdvTableAdapters.tbPedido2TableAdapter
        Friend WithEvents TbFinanceiroBindingSource As BindingSource
        Friend WithEvents TbFinanceiroTableAdapter As DataPdvTableAdapters.tbFinanceiroTableAdapter
        Friend WithEvents TbProdutoVendaPDVvincBindingSource As BindingSource
        Friend WithEvents TbProdutoVendaPDVvincTableAdapter As DataPdvTableAdapters.tbProdutoVendaPDVvincTableAdapter
        Friend WithEvents tmAtualizardgv As Timer
        Friend WithEvents btnVoltar As Button
        Friend WithEvents btnCarregarPedido As Button
        Friend WithEvents btnImprimir As Button
        Friend WithEvents btnPagamento As Button
        Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents NomeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents CPFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents RazaoSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents InscricaoEstadualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents GêneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents UnidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadrãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SituacaoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataLancamentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents VencimentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents JurosAntecipacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents IdentificacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorPagoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents PlanoContasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents FormaPagamentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents dgvPagamento As DataGridView
        Friend WithEvents SituacaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents DataLancamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents VencimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents FormaPagamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents txtCategoriaProduto As TextBox
        Friend WithEvents dgvProdutosVinc As DataGridView
        Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
        Friend WithEvents btnAdicionarProduto As Button
        Friend WithEvents chkRetirar As ComboBox
        Friend WithEvents txtValorVendaTotal As TextBox
        Friend WithEvents cboTabela As ComboBox
        Friend WithEvents dgvProdutosSemCusto As DataGridView
        Friend WithEvents lblRetirar As Label
        Friend WithEvents txtCusto As TextBox
        Friend WithEvents cboTabelaPagamento As ComboBox
        Friend WithEvents txtGenero As TextBox
        Friend WithEvents txtUnidade As TextBox
        Friend WithEvents dgvProdutos As DataGridView
        Friend WithEvents txtQuantidade As TextBox
        Friend WithEvents txtProduto As TextBox
        Friend WithEvents txtSaldoEstoque As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents ProdutoDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents GêneroDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents UnidadeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadrãoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents CodigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents TipoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents SituacaoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DataLancamentoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents VencimentoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DescricaoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents JurosAntecipacaoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ValorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents IdentificacaoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents ValorPagoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents PlanoContasDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents FormaPagamentoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents ClienteIDDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents PedidoIDDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents CustoDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents GeneroDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents SaldoEstoqueDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents CustoTotalDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents NomeClienteDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents QuantidadeDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotalDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents RetiradoDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents rdOcultarColCusto As CheckBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents lblkPedidoVinculado As Label
        Friend WithEvents txtSomaPDV As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents txtCodCliente As TextBox
        Friend WithEvents lblNumeroPedido As Label
        Friend WithEvents txtProdutoID As TextBox
        Friend WithEvents grpshow2 As Button
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Panel3 As Panel
        Friend WithEvents txtSoma As TextBox
        Friend WithEvents ProdutoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CategoriaPadraoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ProdutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents Quantidade As DataGridViewTextBoxColumn
        Friend WithEvents ValorVendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SomaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorCustoTotal As DataGridViewTextBoxColumn
        Friend WithEvents Retirado As DataGridViewTextBoxColumn
        Friend WithEvents x As DataGridViewTextBoxColumn
        Friend WithEvents Panel5 As Panel
        Friend WithEvents txtCustoTotal As TextBox
        Friend WithEvents Panel6 As Panel
        Friend WithEvents txtTipo As TextBox
        Friend WithEvents lblPrecoFrete As Label
        Friend WithEvents txtComplemento As TextBox
        Friend WithEvents txtLogradouro As TextBox
        Friend WithEvents txtPrecoFrete As TextBox
        Friend WithEvents txtInscEstadual As TextBox
        Friend WithEvents txtCodBarras As TextBox
        Friend WithEvents chkEntDif As CheckBox
        Friend WithEvents txtUF As TextBox
        Friend WithEvents txtEndNumero As TextBox
        Friend WithEvents txtContato As TextBox
        Friend WithEvents dgvCliente As DataGridView
        Friend WithEvents chkEntrega As CheckBox
        Friend WithEvents txtCidade As TextBox
        Friend WithEvents txtBairro As TextBox
        Friend WithEvents txtCPFCliente As TextBox
        Friend WithEvents txtEndID As TextBox
        Friend WithEvents txtCliente As TextBox
        Friend WithEvents btnshow1 As Button
        Friend WithEvents ToolStripContainer1 As ToolStripContainer
        Friend WithEvents PictureBox4 As PictureBox
        Friend WithEvents Label15 As Label
        Friend WithEvents ToolStripContainer2 As ToolStripContainer
        Friend WithEvents PictureBox5 As PictureBox
        Friend WithEvents Label16 As Label
        Friend WithEvents dgvEnd As DataGridView
        Friend WithEvents btnAddPessoa As Button
        Friend WithEvents dgvListaProduto As DataGridView
        Friend WithEvents SaldoEstoque As DataGridViewTextBoxColumn
        Friend WithEvents btnMostraEnd As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnRetQuant As Button
        Friend WithEvents btnAddQuant As Button
        Friend WithEvents Button1 As Button
        Friend WithEvents PanelProdutos As Panel
        Friend WithEvents btnConfirmarEscolha As Button
        Friend WithEvents txtPesqProduto As TextBox
        Friend WithEvents txtSomaTotal As TextBox
        Friend WithEvents lblPesquisarProdutos As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents txtCodePesq As TextBox
        Friend WithEvents Panel8 As Panel
        Friend WithEvents txtItens As TextBox
        Friend WithEvents Panel9 As Panel
        Friend WithEvents Panel11 As Panel
        Friend WithEvents Panel10 As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents txtAddProduto2 As Button
        Friend WithEvents Panel13 As Panel
        Friend WithEvents Panel12 As Panel
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents btnVoltar2 As Button
        Friend WithEvents btnCarregarPedido2 As Button
        Friend WithEvents dgvRE As DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
        Friend WithEvents lblProdutoDesc As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label17 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents Label24 As Label
        Friend WithEvents Label26 As Label
        Friend WithEvents btnRE As Button
        Friend WithEvents Label25 As Label
        Friend WithEvents btnAgendarEntrega As Button
        Friend WithEvents CodEndDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents LogradouroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents EndNumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents BairroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents UFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ComplementoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents TipoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents dgvContato As DataGridView
        Friend WithEvents btnConsulta As Button
        Friend WithEvents TextBox1 As TextBox
End Class
