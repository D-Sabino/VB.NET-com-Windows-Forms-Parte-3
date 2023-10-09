﻿Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Principal"
        lbl_Principal.Text = "Principal"

        btm_Click.Text = "Clique aqui"
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
End Class
