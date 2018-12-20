 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_NaturePort
Inherits DTOParser
	Private  Num_NaturePortID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_NaturePortID = reader.GetOrdinal("NaturePortID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim natureport As New NaturePort()
		 If Not reader.IsDBNull("NaturePortID") Then natureport.NaturePortID=reader.GetValue(Num_NaturePortID)
		 If Not reader.IsDBNull("Code") Then natureport.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then natureport.Libelle=reader.GetValue(Num_Libelle)
		Return natureport
	End Function
End Class
