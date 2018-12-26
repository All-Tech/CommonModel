 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_SiteAutorise
Inherits DTOParser
	Private  Num_SiteAutoriseID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_UtilisateurID As Integer
	Private  Num_ProfilAutoriseID As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_SiteAutoriseID = reader.GetOrdinal("SiteAutoriseID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_UtilisateurID = reader.GetOrdinal("UtilisateurID")
		Num_ProfilAutoriseID = reader.GetOrdinal("ProfilAutoriseID")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim siteautorise As New SiteAutorise()
		 If Not reader.IsDBNull("SiteAutoriseID") Then siteautorise.SiteAutoriseID=reader.GetValue(Num_SiteAutoriseID)
		 If Not reader.IsDBNull("SiteOperationID") Then siteautorise.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("UtilisateurID") Then siteautorise.UtilisateurID=reader.GetValue(Num_UtilisateurID)
		 If Not reader.IsDBNull("ProfilAutoriseID") Then siteautorise.ProfilAutoriseID=reader.GetValue(Num_ProfilAutoriseID)
		Return siteautorise
	End Function
End Class
