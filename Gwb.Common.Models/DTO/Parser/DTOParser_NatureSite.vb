 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_NatureSite
Inherits DTOParser
	Private  Num_NatureSiteID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_NatureSiteID = reader.GetOrdinal("NatureSiteID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim naturesite As New NatureSite()
		 If Not reader.IsDBNull("NatureSiteID") Then naturesite.NatureSiteID=reader.GetValue(Num_NatureSiteID)
		 If Not reader.IsDBNull("Code") Then naturesite.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then naturesite.Libelle=reader.GetValue(Num_Libelle)
		Return naturesite
	End Function
End Class
