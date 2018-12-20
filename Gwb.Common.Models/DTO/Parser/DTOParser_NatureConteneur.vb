 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_NatureConteneur
Inherits DTOParser
	Private  Num_NatureConteneurID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_NatureConteneurID = reader.GetOrdinal("NatureConteneurID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim natureconteneur As New NatureConteneur()
		 If Not reader.IsDBNull("NatureConteneurID") Then natureconteneur.NatureConteneurID=reader.GetValue(Num_NatureConteneurID)
		 If Not reader.IsDBNull("Code") Then natureconteneur.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then natureconteneur.Libelle=reader.GetValue(Num_Libelle)
		Return natureconteneur
	End Function
End Class
