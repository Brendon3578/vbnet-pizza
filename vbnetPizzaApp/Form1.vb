Imports System.Linq

' Criado por Brendon Gomes

Public Class frm_sistema
    ' Criação de Variaveis globais, que podem ser usadas em diferentes botões
    Dim pedidoAtual As DateTime = Now
    Dim TotalPizzas As Integer = 0
    Dim TotalValorComDesconto As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assim que o Form carregar, mostrar em tela o número do pedido
        tb_pedido.Text = pedidoAtual
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        ' Assim que o botão de salvar pizza for criado, pegar os valores dos textbox e salvar em variaveis
        Dim Nome = tb_nome.Text
        Dim Fone = tb_fone.Text
        Dim Observacao = tb_observacao.Text
        Dim Endereco = tb_endereco1.Text & " " & tb_endereco2.Text & " " & tb_endereco3.Text
        Dim Desconto = tb_desconto.Text
        Dim TamanhoPizzaValor As Integer

        ' Se não tiver desconto, já identificar que o valor é 0
        If Desconto = "" Then
            Desconto = 0
        End If
        Desconto = Desconto / 100


        ' Procurar dentro do group box o primeiro radio button que estiver marcado
        Dim TamanhoPizzaMarcado As RadioButton =
        gb_tamanhopizza.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)

        ' Pegar o Nome de Design do radio button e verificar qual que está assinado
        ' para então já atribuir o valor para a variavel tamanhopizzavalor
        Select Case TamanhoPizzaMarcado.Name
            Case "rb_tamanho1"
                TamanhoPizzaValor = 16
            Case "rb_tamanho2"
                TamanhoPizzaValor = 17
            Case "rb_tamanho3"
                TamanhoPizzaValor = 24
            Case "rb_tamanho4"
                TamanhoPizzaValor = 28
            Case "rb_tamanho5"
                TamanhoPizzaValor = 32
        End Select

        ' Criação de variaveis do valor da borda, e o nome da borda
        Dim BordaPizzaNome As String = ""
        Dim BordaPizzaValor As Integer = 2

        ' Procurar qual radio button está marcado dentro do group box bordapizza
        Dim BordaPizzaMarcado As RadioButton =
            gb_bordapizza.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)

        Select Case BordaPizzaMarcado.Name
            Case "rb_borda1"
                BordaPizzaNome = "Catupiry"
            Case "rb_borda2"
                BordaPizzaNome = "Cheddar"
            Case "rb_borda3"
                BordaPizzaNome = "Parmesão"
            Case "rb_borda4"
                BordaPizzaNome = "Requeijão"
            Case "rb_borda5"
                BordaPizzaNome = "Gergelim"
            Case "rb_borda6"
                BordaPizzaNome = "Calabresa"
        End Select

        ' Criação de um Array para guardar os ingredientes
        Dim Ingredidentes As New List(Of String)
        Dim IngredientesValorTotal As Integer = 0

        ' Pra cada checkbox marcado dentro do groupbox ingredientes
        ' adicionar dentro do array Ingredientes o nome do ingrediente
        ' e adicionar 1 real pra cada ingrediente selecionado
        For Each checkboxMarcado As CheckBox In gb_ingredientes.Controls
            If checkboxMarcado.Checked = True Then
                Ingredidentes.Add(checkboxMarcado.Text)
                IngredientesValorTotal = IngredientesValorTotal + 1
            End If
        Next

        ' Criação de uma string representativa apenas para quando for escrever na tela
        ' quais ingredientes estão selecionados
        Dim IngredienteListaString As String = ""

        ' Logica de adicionar virgula na string de ingredienteslista pra cadad ingrediente
        ' Exemplo: a vez de ficar: ", Azeitonas, Ovo, Cebola"
        '               vai ficar: "Azeitonas, Ovo, Cebola"
        For Each ingrediente In Ingredidentes
            If Ingredidentes.IndexOf(ingrediente) = 0 Then
                IngredienteListaString = String.Concat(ingrediente)
            Else
                IngredienteListaString = String.Concat(IngredienteListaString, ", ", ingrediente)
            End If
        Next

        ' Calculo do total da pizza
        Dim Total = TamanhoPizzaValor + BordaPizzaValor + IngredientesValorTotal
        ' Calculo de todas as pizzas do pedido
        TotalPizzas = TotalPizzas + Total

        ' Calculo do valor todal do pedido com desconto
        TotalValorComDesconto = TotalPizzas - TotalPizzas * Desconto

        ' Adicioanr no list box cliente os dados do cliente
        ' Comando de reset do list box
        lb_cliente.Items.Clear()
        lb_cliente.Items.Add("Cliente: " & Nome)
        lb_cliente.Items.Add("Telefone: " & Fone)
        lb_cliente.Items.Add("Endereço: " & Endereco)

        ' Adicioanr no list box do pedido a pizzza, o tamanho da pizza, a bordad, e seus ingredientes
        lb_pedido.Items.Add("-> Pizza Tamanho " & TamanhoPizzaMarcado.Text & " com borda de " & BordaPizzaNome)
        ' Aqui se aplica a logica da criação da string da lista de ingredientes
        lb_pedido.Items.Add("Com: " & IngredienteListaString)
        ' Se tiver observação de pedido, adicionar no list box
        If Observacao.Trim() <> "" Then
            lb_pedido.Items.Add("OBS: " & Observacao)
        End If

        ' Comando de reset do list box
        lb_total.Items.Clear()
        lb_total.Items.Add("PEDIDO")
        lb_total.Items.Add("> " & pedidoAtual)
        lb_total.Items.Add("")
        If tb_desconto.Text <> "" Then
            lb_total.Items.Add("Desconto (Opcional): " & (tb_desconto.Text) & "%")
        End If
        lb_total.Items.Add("TOTAL A PAGAR:")
        lb_total.Items.Add("> R$" & TotalValorComDesconto & " <")

        ' Ativar o botão de ver pedido e salvar o pedido no sistema
        btn_armazenarpedido.Enabled = True
        btn_verpedido.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        ' Fazer um novo número de pedido
        pedidoAtual = Now
        tb_pedido.Text = pedidoAtual
        ' Resetar a variavel de total das pizzas
        TotalPizzas = 0
        ' Limpar as linhas do list box
        lb_cliente.Items.Clear()
        lb_pedido.Items.Clear()
        lb_total.Items.Clear()
        ' Desativar o botão de ver pedido e salvar no sistema
        btn_armazenarpedido.Enabled = False
        btn_verpedido.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_verpedido.Click

        ' Criação de uma String mais complexa e fácil de manipulação
        ' A utilização do StringBuilder é necessária para a manipulação mais efeciente
        ' de uma string quando utilizada em um Msg Box (a notificação que aparece na tela)
        Dim SB As New System.Text.StringBuilder

        ' Pra cada Linha do list box Cliente, adicionar uma nova linha nessa String
        For Each Item As String In lb_cliente.Items
            SB.Append(Item & vbCrLf)
        Next

        ' Quebra de linha na String
        SB.Append(vbCrLf)

        ' Pra cada Linha do list box Pedido, adicionar uma nova linha nessa String
        For Each Item As String In lb_pedido.Items
            SB.Append(Item & vbCrLf)
        Next

        ' Pra cada Linha do list box Total, adicionar uma nova linha nessa String.
        For Each Item As String In lb_total.Items
            SB.Append(Item & vbCrLf)
        Next

        MsgBox(SB.ToString(), MsgBoxStyle.Information, "Pedido")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_verpedidos.Click
        Me.Hide()
        frm_gerenciadorbd.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btn_armazenarpedido.Click
        Dim SB As New System.Text.StringBuilder

        For Each Item As String In lb_pedido.Items
            SB.Append(Item & vbCrLf)
        Next

        ' Salvar nas variaveis globais do sistema (variaveis publicas) as informações
        ' do cliente, das pizzas, etc, de modo que possaa ser usado em outros window forms
        pedidoNumero = tb_pedido.Text
        clienteNome = tb_nome.Text
        clienteFone = tb_fone.Text
        clienteEndereco = tb_endereco1.Text & " " & tb_endereco2.Text & " " & tb_endereco3.Text
        pedidoPizzas = SB.ToString()
        pedidoValorTotal = "R$ " & TotalValorComDesconto.ToString()

        Dim mensagem = "Pedido armazenado no Sistema!" + vbNewLine + "Para salvar no banco de dados, clique no Botão " &
            "ADMNISTRAR BANCO DE DADOS e depois clique em SALVAR PEDIDO NO BANCO DE DADOS"
        MsgBox(mensagem, MsgBoxStyle.Information, "Pedido salvo")

    End Sub
End Class
