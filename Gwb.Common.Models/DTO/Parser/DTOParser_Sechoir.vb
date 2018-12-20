 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Sechoir
Inherits DTOParser
	Private  Num_SechoirID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_Capacite As Integer
	Private  Num_LibelleChambre As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_SechoirID = reader.GetOrdinal("SechoirID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_Capacite = reader.GetOrdinal("Capacite")
		Num_LibelleChambre = reader.GetOrdinal("LibelleChambre")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim sechoir As New Sechoir()
		 If Not reader.IsDBNull("SechoirID") Then sechoir.SechoirID=reader.GetValue(Num_SechoirID)
		 If Not reader.IsDBNull("SiteOperationID") Then sechoir.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("Capacite") Then sechoir.Capacite=reader.GetValue(Num_Capacite)
		 If Not reader.IsDBNull("LibelleChambre") Then sechoir.LibelleChambre=reader.GetValue(Num_LibelleChambre)
		Return sechoir
	End Function
End Class
