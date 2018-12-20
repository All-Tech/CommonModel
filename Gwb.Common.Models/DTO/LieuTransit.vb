Imports Gwb.Common.Models.CommonBase
Namespace DTO

    Public Class LieuTransit
        Inherits DTOBase

#Region "Properties"
        Public Property LieuTransitID As Integer
        Public Property SiteOperattionID As Integer?
        Public Property PortID As Integer?
        Public Property NumeroPortEmbarquement As Int16?
        Public Property TypeSiteParc As String
#End Region


    End Class
End Namespace