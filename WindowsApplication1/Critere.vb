Public Class Critere
    Private champs As String 'Le nom du champs
    Private valeur As Object 'La valeur correspondante au champs

    Public Sub New(ByVal cham As String, ByVal val As Object) 'Constructeur
        champs = cham
        valeur = val
    End Sub

    Public Function getChamps() As String 'Getter pour le champs
        Return champs
    End Function

    Public Function getValeur() As Object 'Getter pour la valeur
        Return valeur
    End Function

End Class
