Imports Gwb.Common.Models.CommonBase
Namespace DTO

    Public Class Materiel
        Inherits DTOBase

#Region "Properties"
        Public Property MaterielID As Integer
        Public Property SiteOperationID As Integer?
        Public Property TypeMaterielID As Integer?
        Public Property Code As String
        Public Property Libelle As String
#End Region


    End Class
End Namespace