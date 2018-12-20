 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Scies
Inherits DTOParser
	Private  Num_SciesID As Integer
	Private  Num_SocieteID As Integer
	Private  Num_Libelle As Integer
	Private  Num_CodeNature As Integer
	Private  Num_Sigle As Integer
	Private  Num_CodeProduction As Integer
	Private  Num_OrdreOperation As Integer
	Private  Num_OrdreActivite As Integer
	Private  Num_ScieOrg As Integer
	Private  Num_FamilleProduction As Integer
	Private  Num_ScieProduit As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_SciesID = reader.GetOrdinal("SciesID")
		Num_SocieteID = reader.GetOrdinal("SocieteID")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_CodeNature = reader.GetOrdinal("CodeNature")
		Num_Sigle = reader.GetOrdinal("Sigle")
		Num_CodeProduction = reader.GetOrdinal("CodeProduction")
		Num_OrdreOperation = reader.GetOrdinal("OrdreOperation")
		Num_OrdreActivite = reader.GetOrdinal("OrdreActivite")
		Num_ScieOrg = reader.GetOrdinal("ScieOrg")
		Num_FamilleProduction = reader.GetOrdinal("FamilleProduction")
		Num_ScieProduit = reader.GetOrdinal("ScieProduit")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim scies As New Scies()
		 If Not reader.IsDBNull("SciesID") Then scies.SciesID=reader.GetValue(Num_SciesID)
		 If Not reader.IsDBNull("SocieteID") Then scies.SocieteID=reader.GetValue(Num_SocieteID)
		 If Not reader.IsDBNull("Libelle") Then scies.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("CodeNature") Then scies.CodeNature=reader.GetValue(Num_CodeNature)
		 If Not reader.IsDBNull("Sigle") Then scies.Sigle=reader.GetValue(Num_Sigle)
		 If Not reader.IsDBNull("CodeProduction") Then scies.CodeProduction=reader.GetValue(Num_CodeProduction)
		 If Not reader.IsDBNull("OrdreOperation") Then scies.OrdreOperation=reader.GetValue(Num_OrdreOperation)
		 If Not reader.IsDBNull("OrdreActivite") Then scies.OrdreActivite=reader.GetValue(Num_OrdreActivite)
		 If Not reader.IsDBNull("ScieOrg") Then scies.ScieOrg=reader.GetValue(Num_ScieOrg)
		 If Not reader.IsDBNull("FamilleProduction") Then scies.FamilleProduction=reader.GetValue(Num_FamilleProduction)
		 If Not reader.IsDBNull("ScieProduit") Then scies.ScieProduit=reader.GetValue(Num_ScieProduit)
		Return scies
	End Function
End Class
