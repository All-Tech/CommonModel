Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase
Imports Gwb.Common.Models.DTO


Public Class  DTOParser_Comptabilite
Inherits DTOParser
	Private  Num_ComptabiliteID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ComptabiliteID = reader.GetOrdinal("ComptabiliteID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim comptabilite As New Comptabilite()
		 If Not reader.IsDBNull("ComptabiliteID") Then comptabilite.ComptabiliteID=reader.GetValue(Num_ComptabiliteID)
		 If Not reader.IsDBNull("Libelle") Then comptabilite.Libelle=reader.GetValue(Num_Libelle)
		Return comptabilite
	End Function
End Class
