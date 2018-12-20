Imports Gwb.Common.Models.CommonBase
Namespace DTO

End Namespace

Public Class Fournisseur
	Inherits DTOBase

     #Region"Properties"
      Public Property FournisseurID  As Integer
      Public Property SiteOperationID  As Integer
      Public Property TypeFournisseur  As Integer
      Public Property Code  As Byte()
      Public Property Designation  As String
      Public Property Adresse1  As String
      Public Property Adresse2  As String
      Public Property BoitePostal  As String
      Public Property Telephone1  As String
      Public Property Telephone2  As String
      Public Property Email  As String
     #End Region


End Class