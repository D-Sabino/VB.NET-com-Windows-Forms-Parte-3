Public Class Funcionario
    Public Property nome As String
    Public Property cpf As String
    Public Property salario As Double

    Public Function GetBonificacao() As Double
        Return salario * 0.1
    End Function

End Class
