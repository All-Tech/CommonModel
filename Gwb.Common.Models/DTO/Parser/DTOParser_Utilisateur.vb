 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Utilisateur
Inherits DTOParser
	Private  Num_UtilisateurID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_SiegeID As Integer
	Private  Num_ProfilID As Integer
	Private  Num_Nom As Integer
	Private  Num_LoginUtilisateur As Integer
	Private  Num_MotPasseHash As Integer
	Private  Num_SelMotdePasse As Integer
	Private  Num_Email As Integer
	Private  Num_Matricule As Integer
	Private  Num_Fonction As Integer
	Private  Num_EstActif As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_UtilisateurID = reader.GetOrdinal("UtilisateurID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_SiegeID = reader.GetOrdinal("SiegeID")
		Num_ProfilID = reader.GetOrdinal("ProfilID")
		Num_Nom = reader.GetOrdinal("Nom")
		Num_LoginUtilisateur = reader.GetOrdinal("LoginUtilisateur")
		Num_MotPasseHash = reader.GetOrdinal("MotPasseHash")
		Num_SelMotdePasse = reader.GetOrdinal("SelMotdePasse")
		Num_Email = reader.GetOrdinal("Email")
		Num_Matricule = reader.GetOrdinal("Matricule")
		Num_Fonction = reader.GetOrdinal("Fonction")
		Num_EstActif = reader.GetOrdinal("EstActif")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim utilisateur As New Utilisateur()
		 If Not reader.IsDBNull("UtilisateurID") Then utilisateur.UtilisateurID=reader.GetValue(Num_UtilisateurID)
		 If Not reader.IsDBNull("SiteOperationID") Then utilisateur.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("SiegeID") Then utilisateur.SiegeID=reader.GetValue(Num_SiegeID)
		 If Not reader.IsDBNull("ProfilID") Then utilisateur.ProfilID=reader.GetValue(Num_ProfilID)
		 If Not reader.IsDBNull("Nom") Then utilisateur.Nom=reader.GetValue(Num_Nom)
		 If Not reader.IsDBNull("LoginUtilisateur") Then utilisateur.LoginUtilisateur=reader.GetValue(Num_LoginUtilisateur)
		 If Not reader.IsDBNull("MotPasseHash") Then utilisateur.MotPasseHash=reader.GetValue(Num_MotPasseHash)
		 If Not reader.IsDBNull("SelMotdePasse") Then utilisateur.SelMotdePasse=reader.GetValue(Num_SelMotdePasse)
		 If Not reader.IsDBNull("Email") Then utilisateur.Email=reader.GetValue(Num_Email)
		 If Not reader.IsDBNull("Matricule") Then utilisateur.Matricule=reader.GetValue(Num_Matricule)
		 If Not reader.IsDBNull("Fonction") Then utilisateur.Fonction=reader.GetValue(Num_Fonction)
		 If Not reader.IsDBNull("EstActif") Then utilisateur.EstActif=reader.GetValue(Num_EstActif)
		Return utilisateur
	End Function
End Class
