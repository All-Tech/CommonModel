Imports Gwb.Common.Models.CommonBase
Namespace DTO

    Public Class Produit
        Inherits DTOBase

#Region "Properties"
        Public Property ProduitID As Integer
        Public Property SocieteID As Integer?
        Public Property SousFamilleID As Integer?
        Public Property CodeProduit As String
        Public Property Libelle As String
        Public Property TypeQualite As String
        Public Property TypeGroupe As String
        Public Property CodeActivite As String
        Public Property CodePlaque As String
        Public Property PostAff As String
        Public Property CodeSig As String
        Public Property SDKDF As String
        Public Property Unites As String
#End Region


    End Class
End Namespace