Imports Gwb.Common.Models.CommonBase

Namespace DTO
    Public Class Societe
        Inherits DTOBase
        Public Property SocieteID As Integer
        Public Property SiegeID As Integer
        Public Property Code As String
        Public Property Libelle As String
        Public Property Description As String
        Public Property BoitePostale As String
        Public Property Adresse As String
        Public Property Ville As String
        Public Property NatureActivite As String
        Public Property Regime As String
        Public Property Pw As String
        Public Property Fsc As String
        Public Property Tltv As String
        Public Property NumIdentite As String
        Public Property LDevise As String
        Public Property Logo As Byte()
        Public Property DateCreation As DateTime
        Public Property NumeroCompte As String
    End Class
End Namespace
