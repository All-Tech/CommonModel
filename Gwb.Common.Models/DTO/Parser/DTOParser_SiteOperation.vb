 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_SiteOperation
Inherits DTOParser
	Private  Num_SiteOperationID As Integer
	Private  Num_SiegeID As Integer
	Private  Num_NatureSiteID As Integer
	Private  Num_PaysID As Integer
	Private  Num_AcconierID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer
	Private  Num_Adresse As Integer
	Private  Num_Activite As Integer
	Private  Num_PostAff As Integer
	Private  Num_Trajet As Integer
	Private  Num_ComptabiliteId As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_SiegeID = reader.GetOrdinal("SiegeID")
		Num_NatureSiteID = reader.GetOrdinal("NatureSiteID")
		Num_PaysID = reader.GetOrdinal("PaysID")
		Num_AcconierID = reader.GetOrdinal("AcconierID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_Adresse = reader.GetOrdinal("Adresse")
		Num_Activite = reader.GetOrdinal("Activite")
		Num_PostAff = reader.GetOrdinal("PostAff")
		Num_Trajet = reader.GetOrdinal("Trajet")
		Num_ComptabiliteId = reader.GetOrdinal("ComptabiliteId")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim siteoperation As New SiteOperation()
		 If Not reader.IsDBNull("SiteOperationID") Then siteoperation.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("SiegeID") Then siteoperation.SiegeID=reader.GetValue(Num_SiegeID)
		 If Not reader.IsDBNull("NatureSiteID") Then siteoperation.NatureSiteID=reader.GetValue(Num_NatureSiteID)
		 If Not reader.IsDBNull("PaysID") Then siteoperation.PaysID=reader.GetValue(Num_PaysID)
		 If Not reader.IsDBNull("AcconierID") Then siteoperation.AcconierID=reader.GetValue(Num_AcconierID)
		 If Not reader.IsDBNull("Code") Then siteoperation.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then siteoperation.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("Adresse") Then siteoperation.Adresse=reader.GetValue(Num_Adresse)
		 If Not reader.IsDBNull("Activite") Then siteoperation.Activite=reader.GetValue(Num_Activite)
		 If Not reader.IsDBNull("PostAff") Then siteoperation.PostAff=reader.GetValue(Num_PostAff)
		 If Not reader.IsDBNull("Trajet") Then siteoperation.Trajet=reader.GetValue(Num_Trajet)
		 If Not reader.IsDBNull("ComptabiliteId") Then siteoperation.ComptabiliteId=reader.GetValue(Num_ComptabiliteId)
		Return siteoperation
	End Function
End Class
