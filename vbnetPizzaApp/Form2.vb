Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class frm_gerenciadorbd

    ' Configurações do SQL Server
    ' A String de Conexão é bastante importante para se conectar ao SQL Server
    Private ConnectionString As String = ""
    Private rdr As SqlDataReader = Nothing
    Private con As SqlConnection = Nothing
    Private cmd As SqlCommand = Nothing
    Private da As SqlDataAdapter = Nothing

    ' Função que montará a string que fará a conexão com SQL
    Private Function MontaStringConexaoSQLServer(ByVal flag As String) As String
        Dim dataSource As String = ""
        Dim initialCatalog As String = ""
        Dim integratedSecurity As Boolean = False
        Dim connectionString As String = ""
        If Not String.IsNullOrWhiteSpace(txt_datasource.Text) Then
            dataSource = txt_datasource.Text
        Else
            MessageBox.Show("Informe o DataSource...")
            Return ""
        End If
        If Not String.IsNullOrWhiteSpace(txt_initialcatalog.Text) Then
            If flag = "Master" Then
                initialCatalog = txt_initialcatalog.Text
            ElseIf flag = "Tabela" Then
                initialCatalog = txt_nomebd.Text
            End If
        Else
            MessageBox.Show("Informe o Initial Catalog...")
            Return ""
        End If
        If cbo_IntegrateSecurity.Text = "true" Then
            integratedSecurity = True
        ElseIf cbo_IntegrateSecurity.Text = "false" Then
            integratedSecurity = False
        Else
            MessageBox.Show("Informe o Integrated Security...")
            Return ""
        End If

        ' essa string faz a conexão com o sql server, ela possui as configurações necessárias para conectar ao SQL SERVER
        connectionString = "Data Source=" & dataSource & ";Initial Catalog=" & initialCatalog & ";Integrated Security=" & integratedSecurity
        Return connectionString
    End Function


    Private Sub ListaTabelas(ByVal nomes As List(Of String))
        lb_dados.Items.Add("Tabelas do banco de dados")
        For Each nome In nomes
            lb_dados.Items.Add(nome)
        Next
    End Sub


    Private Function GetTabelasBancoDados(ByVal conexaoSQLServer As String) As List(Of String)
        'define as variáveis usadas 
        Dim lista_Tabelas As New List(Of String)
        Dim cn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim ds As New DataSet()
        'faz a conexão com o banco de dados e abre a conexao
        cn = New SqlConnection(conexaoSQLServer) '
        cn.Open()
        'define a consulta para retornar as tabelas
        cmd = New SqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.tables ORDER BY TABLE_NAME", cn)
        'preenche o dataset
        cmd.Fill(ds)
        'fecha a conexao
        cn.Close()
        For Each table As DataTable In ds.Tables
            For Each row As DataRow In table.Rows
                'Pega somente as tabelas e emite as Views
                If row.ItemArray(3).ToString = "BASE TABLE" Then
                    For Each col As DataColumn In table.Columns
                        If col.ToString() = "TABLE_NAME" Then
                            lista_Tabelas.Add(row(col).ToString())
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        'retorna uma lista de strings contendo as tabelas do BD
        Return lista_Tabelas
    End Function


    Private Sub btn_verificar_Click_1(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim registroView As RegistryView = If(Environment.Is64BitOperatingSystem, RegistryView.Registry64, RegistryView.Registry32)

        Using chaveRegistroLocalMachine As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registroView)

            Dim instanciaChave As RegistryKey = chaveRegistroLocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", False)

            lb_dados.Items.Add("Nome da máquina\Nome da Instância")
            If instanciaChave IsNot Nothing Then
                For Each nomeInstancia In instanciaChave.GetValueNames()
                    lb_dados.Items.Add(Environment.MachineName + "\" + nomeInstancia)
                    txt_datasource.Text = Environment.MachineName + "\" + nomeInstancia
                Next
            Else
                MessageBox.Show("SQL Server e instâncias não localizados")
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_sistema.Show()
    End Sub

    Private Sub btn_criarbanco_Click(sender As Object, e As EventArgs) Handles btn_criarbanco.Click
        'Para criar um banco de dados inicial devemos definir Initial Catalog como Master
        ' Defina a string de conexão com o SQL Server : "Data Source=;" + "Initial Catalog=;" + "Integrated Security=I;"
        ConnectionString = MontaStringConexaoSQLServer("Master")
        ' cria e inicializa a string de conexão
        Dim minhaConexaoSQLServer As SqlConnection = New SqlConnection(ConnectionString)
        ' define uma string para armazenar a consulta SQL que vai criar o BD
        Dim sql As String = "CREATE database " & txt_nomebd.Text
        ' cria o comando para execução na conexão atual
        Dim cmd As SqlCommand = New SqlCommand(sql, minhaConexaoSQLServer)
        Try
            cmd.Connection.Open()  'abre a conecao com o cmd
            cmd.ExecuteNonQuery()  'Executa a consulta
            lb_dados.Items.Add("O banco de dados " & txt_nomebd.Text & " foi criado com sucesso.")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close() 'Fecha a conexão
        End Try
    End Sub

    Private Sub btn_criartabela_Click(sender As Object, e As EventArgs) Handles btn_criartabela.Click
        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)

            ' comando sql para criar a tabela
            Dim sql As String = "CREATE TABLE " & txt_nometabela.Text &
                "(" &
                "pedidoCodigo int Identity(1,1) Primary Key," &
                "pedidoNumero nvarchar(64)," &
                "clienteNome nvarchar(128)," &
                "clienteFone nvarchar(128)," &
                "clienteEndereco nvarchar(256)," &
                "pedidoPizzas nvarchar(600)," &
                "peididoValorTotal nvarchar(128)" &
                ")"

            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'abre a conexao
            cmd.Connection.Open()
            'executa o comando
            cmd.ExecuteNonQuery()

            ' adicina um registro na tabela criada
            sql = "INSERT INTO " & txt_nometabela.Text & "(pedidoNumero, clienteNome) " &
                "VALUES ('Pedido de Teste', 'Pedido de teste' ) "
            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            lb_dados.Items.Add("A tabela " & txt_nometabela.Text & " foi criada com sucesso.")

            'lista as tabelas existentes no banco de dados para a conexão atual
            ListaTabelas(GetTabelasBancoDados(ConnectionString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub

    Private Sub btn_apagartabela_Click_1(sender As Object, e As EventArgs) Handles btn_apagartabela.Click
        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            'comando sql pra apagar a tabela
            Dim sql As String = "DROP TABLE " & txt_nometabela.Text
            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'abre a conexao
            cmd.Connection.Open()
            'executa o comando
            cmd.ExecuteNonQuery()
            lb_dados.Items.Add("A tabela " & txt_nometabela.Text & " foi excluída com sucesso.")
            'lista as tabelas existentes no banco de dados para a conexão atual
            ListaTabelas(GetTabelasBancoDados(ConnectionString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lb_dados.Items.Clear()
    End Sub

    Private Sub btn_registros_Click(sender As Object, e As EventArgs) Handles btn_registros.Click
        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            'comando sql pra consulta da tabela
            Dim sql As String = "SELECT * FROM " & txt_nometabela.Text
            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'define um dataadatper
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "tabela")

            dg_pedidos.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub

    Private Sub btn_salvarpedidobanco_Click(sender As Object, e As EventArgs) Handles btn_salvarpedidobanco.Click
        Dim PedidoTexto = "Numero do Pedido: " + pedidoNumero + vbNewLine &
            "Cliente: " + clienteFone + vbNewLine &
            "Telefone: " + clienteFone + vbNewLine &
            "Endereço: " + clienteEndereco + vbNewLine &
            "Pedido: " + pedidoPizzas + vbNewLine &
            "Valor total: " + pedidoValorTotal + vbNewLine &
            vbNewLine + vbNewLine + "Salvar este pedido no Banco de dados?"

        Dim salvarPedidoPergunta = MsgBox(PedidoTexto, MsgBoxStyle.YesNo, "Salvar pedido no BD?")

        If salvarPedidoPergunta = DialogResult.Yes Then

            'define a string de conexão com a banco de dados que foi criado
            ConnectionString = MontaStringConexaoSQLServer("Tabela")
            Try
                'cria e inicializa a string de conexão
                Dim cn As SqlConnection = New SqlConnection(ConnectionString)
                'comando sql pra inserir um novo registro na tabela
                Dim sql As String = "INSERT INTO " & txt_nometabela.Text & "(pedidoNumero, clienteNome, clienteFone," &
                    "clienteEndereco, pedidoPizzas, peididoValorTotal) " &
                    "VALUES (" &
                    "'" + pedidoNumero + "' ," &
                    "'" + clienteNome + "' ," &
                    "'" + clienteFone + "' ," &
                    "'" + clienteEndereco + "' ," &
                    "'" + pedidoPizzas + "' ," &
                    "'" + pedidoValorTotal + "'" &
                    ")"

                'cria comando na conexão para executar o comando sql
                cmd = New SqlCommand(sql, cn)
                'abre a conexao
                cmd.Connection.Open()
                'executa o comando
                cmd.ExecuteNonQuery()
                MsgBox("Pedido Salvo no Banco de Dados.", MsgBoxStyle.Information, "Pedido Salvo")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Finally
                cmd.Connection.Close()
            End Try


        End If
        If salvarPedidoPergunta = DialogResult.No Then
            MsgBox("Pedido Não Salvo no Banco de Dados!", MsgBoxStyle.Information, "Pedido não Salvo")
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_IntegrateSecurity.SelectedIndex = 0
    End Sub

    Private Sub btn_apagarultimo_Click(sender As Object, e As EventArgs) Handles btn_apagarultimo.Click

        Dim pergunta = MsgBox("Apagar último registro?", MsgBoxStyle.YesNo, "Apagar registro")

        If pergunta = DialogResult.Yes Then

            'define a string de conexão com a banco de dados que foi criado
            ConnectionString = MontaStringConexaoSQLServer("Tabela")
            Try
                'cria e inicializa a string de conexão
                Dim cn As SqlConnection = New SqlConnection(ConnectionString)
                'comando paraa apagar o ultimo registro na tabela (vai pegar o maior id)
                Dim sql As String = "DELETE FROM " & txt_nometabela.Text & " WHERE pedidoCodigo = (SELECT Max(pedidoCodigo) FROM " & txt_nometabela.Text & ")"

                'cria comando na conexão para executar o comando
                cmd = New SqlCommand(sql, cn)
                'abre a conexao
                cmd.Connection.Open()
                'executa o comando
                cmd.ExecuteNonQuery()
                MsgBox("Último registro apagado com suceseso.", MsgBoxStyle.Information, "Ação confirmada")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Finally
                cmd.Connection.Close()
            End Try


        End If
    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frm_sistema.Close()
    End Sub
End Class