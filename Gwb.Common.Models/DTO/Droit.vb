Imports Gwb.Common.Models.CommonBase

Public Class Droit
	Inherits DTOBase

     #Region"Properties"
      Public Property DroitID  As Integer
    Public Property ModuleID As Integer
    Public Property ProfilID As Integer
    Public Property Ecriture As Boolean
    Public Property Lecture As Boolean
    Public Property Modifier As Boolean
    Public Property Suppression As Boolean
    Public Property Impression As Boolean
#End Region
End Class