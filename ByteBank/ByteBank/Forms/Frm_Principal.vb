﻿Public Class Frm_Principal
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
        Dim Carlos As New Funcionario
        Carlos.nome = "Carlos Emidio"
        Carlos.cpf = "543.445.434-00"
        Carlos.salario = 10000

        MsgBox("O Salario do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " sera de " + Carlos.GetBonificacao().ToString)
    End Sub
End Class
