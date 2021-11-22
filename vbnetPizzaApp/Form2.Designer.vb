<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerenciadorbd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciadorbd))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lb_dados = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbo_IntegrateSecurity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_initialcatalog = New System.Windows.Forms.TextBox()
        Me.txt_datasource = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomebd = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nometabela = New System.Windows.Forms.TextBox()
        Me.btn_apagartabela = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.btn_criarbanco = New System.Windows.Forms.Button()
        Me.btn_registros = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_criartabela = New System.Windows.Forms.Button()
        Me.dg_pedidos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_salvarpedidobanco = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_apagarultimo = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lb_dados
        '
        Me.lb_dados.FormattingEnabled = True
        Me.lb_dados.Location = New System.Drawing.Point(217, 76)
        Me.lb_dados.Name = "lb_dados"
        Me.lb_dados.ScrollAlwaysVisible = True
        Me.lb_dados.Size = New System.Drawing.Size(281, 238)
        Me.lb_dados.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbo_IntegrateSecurity)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_initialcatalog)
        Me.GroupBox2.Controls.Add(Me.txt_datasource)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 165)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SQL Server - Connection String"
        '
        'cbo_IntegrateSecurity
        '
        Me.cbo_IntegrateSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_IntegrateSecurity.FormattingEnabled = True
        Me.cbo_IntegrateSecurity.Items.AddRange(New Object() {"true", "false"})
        Me.cbo_IntegrateSecurity.Location = New System.Drawing.Point(10, 117)
        Me.cbo_IntegrateSecurity.Name = "cbo_IntegrateSecurity"
        Me.cbo_IntegrateSecurity.Size = New System.Drawing.Size(165, 21)
        Me.cbo_IntegrateSecurity.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Integrated Security"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Initial Catalog"
        '
        'txt_initialcatalog
        '
        Me.txt_initialcatalog.Location = New System.Drawing.Point(9, 78)
        Me.txt_initialcatalog.MaxLength = 256
        Me.txt_initialcatalog.Name = "txt_initialcatalog"
        Me.txt_initialcatalog.Size = New System.Drawing.Size(166, 20)
        Me.txt_initialcatalog.TabIndex = 2
        Me.txt_initialcatalog.Text = "Master"
        '
        'txt_datasource
        '
        Me.txt_datasource.Location = New System.Drawing.Point(9, 39)
        Me.txt_datasource.MaxLength = 256
        Me.txt_datasource.Name = "txt_datasource"
        Me.txt_datasource.Size = New System.Drawing.Size(181, 20)
        Me.txt_datasource.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data Source"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Banco de Dados"
        '
        'txt_nomebd
        '
        Me.txt_nomebd.Enabled = False
        Me.txt_nomebd.Location = New System.Drawing.Point(10, 43)
        Me.txt_nomebd.MaxLength = 256
        Me.txt_nomebd.Name = "txt_nomebd"
        Me.txt_nomebd.Size = New System.Drawing.Size(165, 20)
        Me.txt_nomebd.TabIndex = 1
        Me.txt_nomebd.Text = "Sistema_Pizzaria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_nometabela)
        Me.GroupBox1.Controls.Add(Me.txt_nomebd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 126)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações do BD e Tabela"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nome do Tabela"
        '
        'txt_nometabela
        '
        Me.txt_nometabela.Enabled = False
        Me.txt_nometabela.Location = New System.Drawing.Point(9, 87)
        Me.txt_nometabela.MaxLength = 256
        Me.txt_nometabela.Name = "txt_nometabela"
        Me.txt_nometabela.Size = New System.Drawing.Size(166, 20)
        Me.txt_nometabela.TabIndex = 2
        Me.txt_nometabela.Text = "tbPedidos"
        '
        'btn_apagartabela
        '
        Me.btn_apagartabela.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_apagartabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_apagartabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_apagartabela.Location = New System.Drawing.Point(403, 320)
        Me.btn_apagartabela.Name = "btn_apagartabela"
        Me.btn_apagartabela.Size = New System.Drawing.Size(93, 39)
        Me.btn_apagartabela.TabIndex = 8
        Me.btn_apagartabela.Text = "Apagar Tabela de Pedidos"
        Me.btn_apagartabela.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.vbnetPizzaApp.My.Resources.Resources.trashcan2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(444, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verificar.ForeColor = System.Drawing.Color.White
        Me.btn_verificar.Location = New System.Drawing.Point(93, 12)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(118, 39)
        Me.btn_verificar.TabIndex = 10
        Me.btn_verificar.Text = "Fazer Conexão com SQL Server"
        Me.btn_verificar.UseVisualStyleBackColor = False
        '
        'btn_criarbanco
        '
        Me.btn_criarbanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_criarbanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_criarbanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_criarbanco.ForeColor = System.Drawing.Color.Black
        Me.btn_criarbanco.Location = New System.Drawing.Point(217, 320)
        Me.btn_criarbanco.Name = "btn_criarbanco"
        Me.btn_criarbanco.Size = New System.Drawing.Size(93, 39)
        Me.btn_criarbanco.TabIndex = 11
        Me.btn_criarbanco.Text = "Criar Banco de Dados"
        Me.btn_criarbanco.UseVisualStyleBackColor = False
        '
        'btn_registros
        '
        Me.btn_registros.Location = New System.Drawing.Point(550, 320)
        Me.btn_registros.Name = "btn_registros"
        Me.btn_registros.Size = New System.Drawing.Size(99, 39)
        Me.btn_registros.TabIndex = 12
        Me.btn_registros.Text = "Listar Registros"
        Me.btn_registros.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(220, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'btn_criartabela
        '
        Me.btn_criartabela.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btn_criartabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_criartabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_criartabela.ForeColor = System.Drawing.Color.Black
        Me.btn_criartabela.Location = New System.Drawing.Point(315, 320)
        Me.btn_criartabela.Name = "btn_criartabela"
        Me.btn_criartabela.Size = New System.Drawing.Size(82, 39)
        Me.btn_criartabela.TabIndex = 14
        Me.btn_criartabela.Text = "Criar Tabela de Pedidos"
        Me.btn_criartabela.UseVisualStyleBackColor = False
        '
        'dg_pedidos
        '
        Me.dg_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pedidos.Location = New System.Drawing.Point(504, 76)
        Me.dg_pedidos.Name = "dg_pedidos"
        Me.dg_pedidos.Size = New System.Drawing.Size(393, 238)
        Me.dg_pedidos.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(507, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Registros de Pedidos"
        '
        'btn_salvarpedidobanco
        '
        Me.btn_salvarpedidobanco.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salvarpedidobanco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvarpedidobanco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_salvarpedidobanco.Location = New System.Drawing.Point(760, 320)
        Me.btn_salvarpedidobanco.Name = "btn_salvarpedidobanco"
        Me.btn_salvarpedidobanco.Size = New System.Drawing.Size(137, 43)
        Me.btn_salvarpedidobanco.TabIndex = 18
        Me.btn_salvarpedidobanco.Text = "Salvar pedido no Banco de Dados"
        Me.btn_salvarpedidobanco.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(396, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(266, 39)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "🍕 Pizza App 🍕"
        Me.Label8.UseMnemonic = False
        '
        'btn_apagarultimo
        '
        Me.btn_apagarultimo.Location = New System.Drawing.Point(655, 320)
        Me.btn_apagarultimo.Name = "btn_apagarultimo"
        Me.btn_apagarultimo.Size = New System.Drawing.Size(99, 39)
        Me.btn_apagarultimo.TabIndex = 22
        Me.btn_apagarultimo.Text = "Apagar último Registro"
        Me.btn_apagarultimo.UseVisualStyleBackColor = True
        '
        'frm_gerenciadorbd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 386)
        Me.Controls.Add(Me.btn_apagarultimo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_salvarpedidobanco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dg_pedidos)
        Me.Controls.Add(Me.btn_criartabela)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_registros)
        Me.Controls.Add(Me.btn_criarbanco)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_apagartabela)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_dados)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerenciadorbd"
        Me.Text = "Gerenciador de Banco de Dados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lb_dados As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_initialcatalog As System.Windows.Forms.TextBox
    Friend WithEvents txt_datasource As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_IntegrateSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nomebd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nometabela As System.Windows.Forms.TextBox
    Friend WithEvents btn_apagartabela As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_verificar As System.Windows.Forms.Button
    Friend WithEvents btn_criarbanco As System.Windows.Forms.Button
    Friend WithEvents btn_registros As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_criartabela As System.Windows.Forms.Button
    Friend WithEvents dg_pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_salvarpedidobanco As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_apagarultimo As System.Windows.Forms.Button
End Class
