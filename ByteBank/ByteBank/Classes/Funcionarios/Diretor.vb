Namespace Classes.Funcionarios
    Public Class Diretor

#Region "PROPRIEDADES"
        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double
#End Region

#Region "CONSTRUTORES"


#End Region

#Region "METODOS"
        Public Function GetBonificacao() As Double
            Return salario * 1

        End Function
#End Region
    End Class
End Namespace

