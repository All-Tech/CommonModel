Imports Gwb.Common.Models.CommonBase

Public Class Utilisateur
	Inherits DTOBase

     #Region"Properties"
      Public Property UtilisateurID  As Integer
    Public Property SiteOperationID As Integer
    Public Property SiegeID As Int16
    Public Property ProfilID As Integer
    Public Property Nom  As String
      Public Property LoginUtilisateur  As String
      Public Property MotPasseHash  As String
      Public Property SelMotdePasse  As String
      Public Property Email  As String
      Public Property Matricule  As String
    Public Property Fonction As String
    Public Property EstActif As Boolean
#End Region


End Class