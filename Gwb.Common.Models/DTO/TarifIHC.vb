Imports Gwb.Common.Models.CommonBase
Namespace DTO
    Public Class TarifIHC
        Inherits DTOBase

#Region "Properties"
        Public Property TarifIHCID As Integer
        Public Property SocieteID As Integer?
        Public Property EssenceID As Integer?
        Public Property ProduitID As Integer?
        Public Property QualiteIHCID As Integer?
        Public Property PrixM3Prix As Single
        Public Property AncienPrixM3 As Single
        Public Property DateAncienPrixm3 As DateTime
        Public Property DatePrixM3 As DateTime

#End Region


    End Class
End Namespace