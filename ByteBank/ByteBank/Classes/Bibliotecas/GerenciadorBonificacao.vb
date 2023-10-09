Imports ByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class GerenciadorBonificacao
        Private _totalBonificacao As Double

        Public Sub Registrar(Gerente As Gerente)
            _totalBonificacao += Gerente.GetBonificacao()

        End Sub

        Public Sub Registrar(Diretor As Diretor)
            _totalBonificacao += Diretor.GetBonificacao()
        End Sub

        Public Function getBonificacao() As Double
            Return _totalBonificacao
        End Function

    End Class

End Namespace
