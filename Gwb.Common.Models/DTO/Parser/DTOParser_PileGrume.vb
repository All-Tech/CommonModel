 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_PileGrume
Inherits DTOParser
	Private  Num_PileGrumeID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_PileGrumeID = reader.GetOrdinal("PileGrumeID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim pilegrume As New PileGrume()
		 If Not reader.IsDBNull("PileGrumeID") Then pilegrume.PileGrumeID=reader.GetValue(Num_PileGrumeID)
		 If Not reader.IsDBNull("Code") Then pilegrume.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then pilegrume.Libelle=reader.GetValue(Num_Libelle)
		Return pilegrume
	End Function
End Class
