Namespace Classes.Funcionarios
    Public Class Diretor
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"


#End Region

#Region "METODOS"
        'Overrides = Substitui
        Public Overrides Function GetBonificacao() As Double
            Return (salario * 1) + MyBase.GetBonificacao()

        End Function
#End Region
    End Class
End Namespace

