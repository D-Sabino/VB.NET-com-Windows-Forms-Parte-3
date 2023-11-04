Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Principal"
        lbl_Principal.Text = "Principal"

        btm_Click.Text = "Clique aqui"
        btm_TesteHeranca.Text = "Clique aqui para testar heranca"
        btm_classebase.Text = "Executa exemplo classe MyBase"
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btm_Click_Click(sender As Object, e As EventArgs) Handles btm_Click.Click
        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Gerente()
        Carlos.nome = "Carlos Emidio"
        Carlos.cpf = "543.445.434-00"
        Carlos.salario = 10000
        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor()
        Bia.nome = "Bia Antoria"
        Bia.cpf = "543.445.434-00"
        Bia.salario = 20000
        gerenciadorBonificacao.Registrar(Bia)

        MsgBox("O Salario do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " sera de " + Carlos.GetBonificacao().ToString)

        MsgBox("O Salario do " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação de " + Bia.nome + " sera de " + Bia.GetBonificacao().ToString)

        Dim totalBonificacao As Double
        totalBonificacao += Carlos.GetBonificacao
        totalBonificacao += Bia.GetBonificacao
        MsgBox("O valor total de bonificação a ser pago sera de " + totalBonificacao.ToString +
               " o valor calculado pela biblioteca foi de " + gerenciadorBonificacao.getBonificacao.ToString)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btm_TesteHeranca.Click
        Dim vDiretor As New Diretor()
        Dim vFuncionario As New Funcionario()
        Dim vDiretorFuncionario As New Funcionario()

        vDiretor.salario = 10000
        vFuncionario.salario = 10000

        vDiretorFuncionario = vDiretor

        Dim vSaida As String = ""

        vSaida = "A bonificacao de vDiretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
        vSaida += "A bonificacao de vFuncionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
        vSaida += "A bonificacao de vDiretorFuncionario é " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf
    End Sub

    Private Sub btm_classebase_Click(sender As Object, e As EventArgs) Handles btm_classebase.Click
        Dim vDiretor As New Diretor()
        vDiretor.salario = 10000

        MsgBox("A bonificacao do diretor e: " + vDiretor.GetBonificacao().ToString)
    End Sub
End Class
