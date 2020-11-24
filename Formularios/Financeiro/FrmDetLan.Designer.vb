<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetLan
    Inherits System.Windows.Forms.Form

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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim NumeroDocumentoLabel As System.Windows.Forms.Label
        Dim SituacaoLabel As System.Windows.Forms.Label
        Dim VencimentoLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim PlanoContasLabel As System.Windows.Forms.Label
        Dim DataLancamentoLabel As System.Windows.Forms.Label
        Dim JurosAntecipacaoLabel As System.Windows.Forms.Label
        Dim IdentificacaoLabel As System.Windows.Forms.Label
        Dim ValorPagoLabel As System.Windows.Forms.Label
        Dim FormaPagamentoLabel As System.Windows.Forms.Label
        Me.TbFinanceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetX = New ControleOS.DataSetX()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.SituacaoTextBox = New System.Windows.Forms.TextBox()
        Me.VencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanoContasTextBox = New System.Windows.Forms.TextBox()
        Me.DataLancamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JurosAntecipacaoTextBox = New System.Windows.Forms.TextBox()
        Me.txtIdentificacao = New System.Windows.Forms.TextBox()
        Me.ValorPagoTextBox = New System.Windows.Forms.TextBox()
        Me.FormaPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.TbFinanceiroTableAdapter = New ControleOS.DataSetXTableAdapters.tbFinanceiroTableAdapter()
        Me.TableAdapterManager = New ControleOS.DataSetXTableAdapters.TableAdapterManager()
        Me.DataPdv = New ControleOS.DataPdv()
        Me.TbAnexoPDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAnexoPDVTableAdapter = New ControleOS.DataPdvTableAdapters.tbAnexoPDVTableAdapter()
        Me.TableAdapterManager1 = New ControleOS.DataPdvTableAdapters.TableAdapterManager()
        Me.btnDefinirPago = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDefinirNPago = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CodigoLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        NumeroDocumentoLabel = New System.Windows.Forms.Label()
        SituacaoLabel = New System.Windows.Forms.Label()
        VencimentoLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        PlanoContasLabel = New System.Windows.Forms.Label()
        DataLancamentoLabel = New System.Windows.Forms.Label()
        JurosAntecipacaoLabel = New System.Windows.Forms.Label()
        IdentificacaoLabel = New System.Windows.Forms.Label()
        ValorPagoLabel = New System.Windows.Forms.Label()
        FormaPagamentoLabel = New System.Windows.Forms.Label()
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAnexoPDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.BackColor = System.Drawing.Color.Transparent
        CodigoLabel.ForeColor = System.Drawing.Color.White
        CodigoLabel.Location = New System.Drawing.Point(207, 29)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo:"
        CodigoLabel.Visible = False
        AddHandler CodigoLabel.Click, AddressOf Me.CodigoLabel_Click
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.BackColor = System.Drawing.Color.Transparent
        ClienteLabel.ForeColor = System.Drawing.Color.White
        ClienteLabel.Location = New System.Drawing.Point(6, 26)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 3
        ClienteLabel.Text = "Cliente:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.ForeColor = System.Drawing.Color.White
        TipoLabel.Location = New System.Drawing.Point(119, 27)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo:"
        '
        'NumeroDocumentoLabel
        '
        NumeroDocumentoLabel.AutoSize = True
        NumeroDocumentoLabel.BackColor = System.Drawing.Color.Transparent
        NumeroDocumentoLabel.ForeColor = System.Drawing.Color.White
        NumeroDocumentoLabel.Location = New System.Drawing.Point(0, 24)
        NumeroDocumentoLabel.Name = "NumeroDocumentoLabel"
        NumeroDocumentoLabel.Size = New System.Drawing.Size(105, 13)
        NumeroDocumentoLabel.TabIndex = 7
        NumeroDocumentoLabel.Text = "Numero Documento:"
        '
        'SituacaoLabel
        '
        SituacaoLabel.AutoSize = True
        SituacaoLabel.BackColor = System.Drawing.Color.Transparent
        SituacaoLabel.ForeColor = System.Drawing.Color.White
        SituacaoLabel.Location = New System.Drawing.Point(3, 26)
        SituacaoLabel.Name = "SituacaoLabel"
        SituacaoLabel.Size = New System.Drawing.Size(52, 13)
        SituacaoLabel.TabIndex = 9
        SituacaoLabel.Text = "Situacao:"
        '
        'VencimentoLabel
        '
        VencimentoLabel.AutoSize = True
        VencimentoLabel.BackColor = System.Drawing.Color.Transparent
        VencimentoLabel.ForeColor = System.Drawing.Color.White
        VencimentoLabel.Location = New System.Drawing.Point(3, 106)
        VencimentoLabel.Name = "VencimentoLabel"
        VencimentoLabel.Size = New System.Drawing.Size(66, 13)
        VencimentoLabel.TabIndex = 11
        VencimentoLabel.Text = "Vencimento:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.BackColor = System.Drawing.Color.Transparent
        DescricaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.ForeColor = System.Drawing.Color.White
        DescricaoLabel.Location = New System.Drawing.Point(21, 332)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(55, 24)
        DescricaoLabel.TabIndex = 13
        DescricaoLabel.Text = "Obs.:"
        '
        'PlanoContasLabel
        '
        PlanoContasLabel.AutoSize = True
        PlanoContasLabel.BackColor = System.Drawing.Color.Transparent
        PlanoContasLabel.ForeColor = System.Drawing.Color.White
        PlanoContasLabel.Location = New System.Drawing.Point(128, 88)
        PlanoContasLabel.Name = "PlanoContasLabel"
        PlanoContasLabel.Size = New System.Drawing.Size(73, 13)
        PlanoContasLabel.TabIndex = 17
        PlanoContasLabel.Text = "Plano Contas:"
        '
        'DataLancamentoLabel
        '
        DataLancamentoLabel.AutoSize = True
        DataLancamentoLabel.BackColor = System.Drawing.Color.Transparent
        DataLancamentoLabel.ForeColor = System.Drawing.Color.White
        DataLancamentoLabel.Location = New System.Drawing.Point(3, 66)
        DataLancamentoLabel.Name = "DataLancamentoLabel"
        DataLancamentoLabel.Size = New System.Drawing.Size(95, 13)
        DataLancamentoLabel.TabIndex = 19
        DataLancamentoLabel.Text = "Data Lancamento:"
        '
        'JurosAntecipacaoLabel
        '
        JurosAntecipacaoLabel.AutoSize = True
        JurosAntecipacaoLabel.BackColor = System.Drawing.Color.Transparent
        JurosAntecipacaoLabel.ForeColor = System.Drawing.Color.White
        JurosAntecipacaoLabel.Location = New System.Drawing.Point(3, 125)
        JurosAntecipacaoLabel.Name = "JurosAntecipacaoLabel"
        JurosAntecipacaoLabel.Size = New System.Drawing.Size(98, 13)
        JurosAntecipacaoLabel.TabIndex = 21
        JurosAntecipacaoLabel.Text = "Juros Antecipacao:"
        '
        'IdentificacaoLabel
        '
        IdentificacaoLabel.AutoSize = True
        IdentificacaoLabel.BackColor = System.Drawing.Color.Transparent
        IdentificacaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdentificacaoLabel.Location = New System.Drawing.Point(21, 21)
        IdentificacaoLabel.Name = "IdentificacaoLabel"
        IdentificacaoLabel.Size = New System.Drawing.Size(104, 20)
        IdentificacaoLabel.TabIndex = 23
        IdentificacaoLabel.Text = "Identificacao:"
        '
        'ValorPagoLabel
        '
        ValorPagoLabel.AutoSize = True
        ValorPagoLabel.BackColor = System.Drawing.Color.Transparent
        ValorPagoLabel.ForeColor = System.Drawing.Color.White
        ValorPagoLabel.Location = New System.Drawing.Point(128, 26)
        ValorPagoLabel.Name = "ValorPagoLabel"
        ValorPagoLabel.Size = New System.Drawing.Size(37, 13)
        ValorPagoLabel.TabIndex = 25
        ValorPagoLabel.Text = "Valor :"
        '
        'FormaPagamentoLabel
        '
        FormaPagamentoLabel.AutoSize = True
        FormaPagamentoLabel.BackColor = System.Drawing.Color.Transparent
        FormaPagamentoLabel.ForeColor = System.Drawing.Color.White
        FormaPagamentoLabel.Location = New System.Drawing.Point(3, 88)
        FormaPagamentoLabel.Name = "FormaPagamentoLabel"
        FormaPagamentoLabel.Size = New System.Drawing.Size(96, 13)
        FormaPagamentoLabel.TabIndex = 27
        FormaPagamentoLabel.Text = "Forma Pagamento:"
        '
        'TbFinanceiroBindingSource
        '
        Me.TbFinanceiroBindingSource.DataMember = "tbFinanceiro"
        Me.TbFinanceiroBindingSource.DataSource = Me.DataSetX
        '
        'DataSetX
        '
        Me.DataSetX.DataSetName = "DataSetX"
        Me.DataSetX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(210, 48)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CodigoTextBox.TabIndex = 2
        Me.CodigoTextBox.Visible = False
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(6, 42)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.ReadOnly = True
        Me.ClienteTextBox.Size = New System.Drawing.Size(313, 20)
        Me.ClienteTextBox.TabIndex = 4
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(119, 43)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(122, 20)
        Me.TipoTextBox.TabIndex = 6
        '
        'NumeroDocumentoTextBox
        '
        Me.NumeroDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "NumeroDocumento", True))
        Me.NumeroDocumentoTextBox.Location = New System.Drawing.Point(3, 43)
        Me.NumeroDocumentoTextBox.Name = "NumeroDocumentoTextBox"
        Me.NumeroDocumentoTextBox.ReadOnly = True
        Me.NumeroDocumentoTextBox.Size = New System.Drawing.Size(113, 20)
        Me.NumeroDocumentoTextBox.TabIndex = 8
        '
        'SituacaoTextBox
        '
        Me.SituacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Situacao", True))
        Me.SituacaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SituacaoTextBox.Location = New System.Drawing.Point(6, 42)
        Me.SituacaoTextBox.Name = "SituacaoTextBox"
        Me.SituacaoTextBox.ReadOnly = True
        Me.SituacaoTextBox.Size = New System.Drawing.Size(117, 26)
        Me.SituacaoTextBox.TabIndex = 10
        '
        'VencimentoDateTimePicker
        '
        Me.VencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbFinanceiroBindingSource, "Vencimento", True))
        Me.VencimentoDateTimePicker.Location = New System.Drawing.Point(6, 122)
        Me.VencimentoDateTimePicker.Name = "VencimentoDateTimePicker"
        Me.VencimentoDateTimePicker.Size = New System.Drawing.Size(235, 20)
        Me.VencimentoDateTimePicker.TabIndex = 12
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(22, 359)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ReadOnly = True
        Me.DescricaoTextBox.Size = New System.Drawing.Size(344, 68)
        Me.DescricaoTextBox.TabIndex = 14
        '
        'PlanoContasTextBox
        '
        Me.PlanoContasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "PlanoContas", True))
        Me.PlanoContasTextBox.Location = New System.Drawing.Point(129, 104)
        Me.PlanoContasTextBox.Name = "PlanoContasTextBox"
        Me.PlanoContasTextBox.ReadOnly = True
        Me.PlanoContasTextBox.Size = New System.Drawing.Size(117, 20)
        Me.PlanoContasTextBox.TabIndex = 18
        '
        'DataLancamentoDateTimePicker
        '
        Me.DataLancamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbFinanceiroBindingSource, "DataLancamento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.DataLancamentoDateTimePicker.Location = New System.Drawing.Point(6, 82)
        Me.DataLancamentoDateTimePicker.Name = "DataLancamentoDateTimePicker"
        Me.DataLancamentoDateTimePicker.Size = New System.Drawing.Size(235, 20)
        Me.DataLancamentoDateTimePicker.TabIndex = 20
        '
        'JurosAntecipacaoTextBox
        '
        Me.JurosAntecipacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "JurosAntecipacao", True))
        Me.JurosAntecipacaoTextBox.Location = New System.Drawing.Point(6, 141)
        Me.JurosAntecipacaoTextBox.Name = "JurosAntecipacaoTextBox"
        Me.JurosAntecipacaoTextBox.ReadOnly = True
        Me.JurosAntecipacaoTextBox.Size = New System.Drawing.Size(117, 20)
        Me.JurosAntecipacaoTextBox.TabIndex = 22
        Me.JurosAntecipacaoTextBox.Text = "EM IMPLEMENTAÇÃO"
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdentificacao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Identificacao", True))
        Me.txtIdentificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacao.Location = New System.Drawing.Point(22, 42)
        Me.txtIdentificacao.Name = "txtIdentificacao"
        Me.txtIdentificacao.ReadOnly = True
        Me.txtIdentificacao.Size = New System.Drawing.Size(149, 24)
        Me.txtIdentificacao.TabIndex = 24
        '
        'ValorPagoTextBox
        '
        Me.ValorPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ValorPagoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorPagoTextBox.ForeColor = System.Drawing.Color.Green
        Me.ValorPagoTextBox.Location = New System.Drawing.Point(129, 42)
        Me.ValorPagoTextBox.Name = "ValorPagoTextBox"
        Me.ValorPagoTextBox.ReadOnly = True
        Me.ValorPagoTextBox.Size = New System.Drawing.Size(117, 26)
        Me.ValorPagoTextBox.TabIndex = 26
        '
        'FormaPagamentoTextBox
        '
        Me.FormaPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFinanceiroBindingSource, "FormaPagamento", True))
        Me.FormaPagamentoTextBox.Location = New System.Drawing.Point(6, 104)
        Me.FormaPagamentoTextBox.Name = "FormaPagamentoTextBox"
        Me.FormaPagamentoTextBox.ReadOnly = True
        Me.FormaPagamentoTextBox.Size = New System.Drawing.Size(117, 20)
        Me.FormaPagamentoTextBox.TabIndex = 28
        '
        'TbFinanceiroTableAdapter
        '
        Me.TbFinanceiroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.OpcoesTableAdapter = Nothing
        Me.TableAdapterManager.tbAdicionalPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbCalendarioTableAdapter = Nothing
        Me.TableAdapterManager.tbEntregaTableAdapter = Nothing
        Me.TableAdapterManager.tbFinanceiroTableAdapter = Me.TbFinanceiroTableAdapter
        Me.TableAdapterManager.tbHistoricoMedicaoTableAdapter = Nothing
        Me.TableAdapterManager.tbInicialPagoTableAdapter = Nothing
        Me.TableAdapterManager.tbLancamentosTableAdapter = Nothing
        Me.TableAdapterManager.tbObservacaoTableAdapter = Nothing
        Me.TableAdapterManager.tbOSTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoVendaTableAdapter = Nothing
        Me.TableAdapterManager.tbRelatorioVisitaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControleOS.DataSetXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataPdv
        '
        Me.DataPdv.DataSetName = "DataPDV"
        Me.DataPdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbAnexoPDVBindingSource
        '
        Me.TbAnexoPDVBindingSource.DataMember = "tbAnexoPDV"
        Me.TbAnexoPDVBindingSource.DataSource = Me.DataPdv
        '
        'TbAnexoPDVTableAdapter
        '
        Me.TbAnexoPDVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EntregaTableAdapter = Nothing
        Me.TableAdapterManager1.tbAnexoPDVTableAdapter = Me.TbAnexoPDVTableAdapter
        Me.TableAdapterManager1.tbClientesTableAdapter = Nothing
        Me.TableAdapterManager1.tbContatoTableAdapter = Nothing
        Me.TableAdapterManager1.tbEndTableAdapter = Nothing
        Me.TableAdapterManager1.tbFinanceiroTableAdapter = Nothing
        Me.TableAdapterManager1.tbPedido2TableAdapter = Nothing
        Me.TableAdapterManager1.tbPedido2vincTableAdapter = Nothing
        Me.TableAdapterManager1.tbPedidosAuxTableAdapter = Nothing
        Me.TableAdapterManager1.tbPrecoTabelaTableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutoPDVTableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutoVendaPDVTableAdapter = Nothing
        Me.TableAdapterManager1.tbProdutoVendaPDVvincTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ControleOS.DataPdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnDefinirPago
        '
        Me.btnDefinirPago.BackColor = System.Drawing.Color.Transparent
        Me.btnDefinirPago.FlatAppearance.BorderSize = 0
        Me.btnDefinirPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDefinirPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDefinirPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirPago.ForeColor = System.Drawing.Color.White
        Me.btnDefinirPago.Image = Global.ControleOS.My.Resources.Resources.Confirmar
        Me.btnDefinirPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDefinirPago.Location = New System.Drawing.Point(6, 170)
        Me.btnDefinirPago.Name = "btnDefinirPago"
        Me.btnDefinirPago.Size = New System.Drawing.Size(136, 60)
        Me.btnDefinirPago.TabIndex = 32
        Me.btnDefinirPago.Text = "Definir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "como Pago"
        Me.btnDefinirPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefinirPago.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(ClienteLabel)
        Me.GroupBox1.Controls.Add(Me.ClienteTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(22, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 80)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE/COLABORADOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(DataLancamentoLabel)
        Me.GroupBox2.Controls.Add(Me.NumeroDocumentoTextBox)
        Me.GroupBox2.Controls.Add(Me.DataLancamentoDateTimePicker)
        Me.GroupBox2.Controls.Add(NumeroDocumentoLabel)
        Me.GroupBox2.Controls.Add(Me.VencimentoDateTimePicker)
        Me.GroupBox2.Controls.Add(VencimentoLabel)
        Me.GroupBox2.Controls.Add(Me.TipoTextBox)
        Me.GroupBox2.Controls.Add(TipoLabel)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(22, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 149)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sobre o Lançamento"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnDefinirNPago)
        Me.GroupBox3.Controls.Add(Me.SituacaoTextBox)
        Me.GroupBox3.Controls.Add(SituacaoLabel)
        Me.GroupBox3.Controls.Add(Me.ValorPagoTextBox)
        Me.GroupBox3.Controls.Add(Me.btnDefinirPago)
        Me.GroupBox3.Controls.Add(ValorPagoLabel)
        Me.GroupBox3.Controls.Add(Me.FormaPagamentoTextBox)
        Me.GroupBox3.Controls.Add(FormaPagamentoLabel)
        Me.GroupBox3.Controls.Add(JurosAntecipacaoLabel)
        Me.GroupBox3.Controls.Add(PlanoContasLabel)
        Me.GroupBox3.Controls.Add(Me.JurosAntecipacaoTextBox)
        Me.GroupBox3.Controls.Add(Me.PlanoContasTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(362, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 237)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'btnDefinirNPago
        '
        Me.btnDefinirNPago.BackColor = System.Drawing.Color.Transparent
        Me.btnDefinirNPago.FlatAppearance.BorderSize = 0
        Me.btnDefinirNPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDefinirNPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDefinirNPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirNPago.ForeColor = System.Drawing.Color.White
        Me.btnDefinirNPago.Image = Global.ControleOS.My.Resources.Resources.Cancelar
        Me.btnDefinirNPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDefinirNPago.Location = New System.Drawing.Point(148, 170)
        Me.btnDefinirNPago.Name = "btnDefinirNPago"
        Me.btnDefinirNPago.Size = New System.Drawing.Size(136, 60)
        Me.btnDefinirNPago.TabIndex = 33
        Me.btnDefinirNPago.Text = "Definir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "como Não Pago"
        Me.btnDefinirNPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefinirNPago.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.ControleOS.My.Resources.Resources.Imprimir1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(523, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 60)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Imprimir Lançamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(EM IMPLEMENTAÇÃO)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmDetLan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControleOS.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(773, 469)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(IdentificacaoLabel)
        Me.Controls.Add(Me.txtIdentificacao)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "FrmDetLan"
        Me.Text = "DETALHAMENTO DO LANÇAMENTO"
        CType(Me.TbFinanceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAnexoPDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetX As DataSetX
    Friend WithEvents TbFinanceiroBindingSource As BindingSource
    Friend WithEvents TbFinanceiroTableAdapter As DataSetXTableAdapters.tbFinanceiroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetXTableAdapters.TableAdapterManager
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents NumeroDocumentoTextBox As TextBox
    Friend WithEvents SituacaoTextBox As TextBox
    Friend WithEvents VencimentoDateTimePicker As DateTimePicker
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents PlanoContasTextBox As TextBox
    Friend WithEvents DataLancamentoDateTimePicker As DateTimePicker
    Friend WithEvents JurosAntecipacaoTextBox As TextBox
    Friend WithEvents txtIdentificacao As TextBox
    Friend WithEvents ValorPagoTextBox As TextBox
    Friend WithEvents FormaPagamentoTextBox As TextBox
    Friend WithEvents DataPdv As DataPdv
    Friend WithEvents TbAnexoPDVBindingSource As BindingSource
    Friend WithEvents TbAnexoPDVTableAdapter As DataPdvTableAdapters.tbAnexoPDVTableAdapter
    Friend WithEvents TableAdapterManager1 As DataPdvTableAdapters.TableAdapterManager
    Friend WithEvents btnDefinirPago As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDefinirNPago As Button
End Class
