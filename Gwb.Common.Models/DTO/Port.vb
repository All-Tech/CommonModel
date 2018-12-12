Imports Gwb.Common.Models.CommonBase

Public Class Port
	Inherits DTOBase

     #Region"Properties"
      Public Property PortID  As Integer
      Public Property SiteOperattionID  As Integer?
    Public Property NaturePortID As Integer?
    Public Property Libelle  As String
    Public Property Numerodestination As String
    Public Property EstActif As Boolean
#End Region


End Class