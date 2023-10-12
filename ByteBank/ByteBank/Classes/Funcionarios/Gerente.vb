Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"

#End Region

#Region "METODOS"
        Public Function GetBonificacao() As Double
            Return salario * 0.1

        End Function
#End Region
    End Class
End Namespace

