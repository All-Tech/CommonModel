 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Famille
Inherits DTOParser
	Private  Num_FamilleID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_FamilleID = reader.GetOrdinal("FamilleID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim famille As New Famille()
		 If Not reader.IsDBNull("FamilleID") Then famille.FamilleID=reader.GetValue(Num_FamilleID)
		 If Not reader.IsDBNull("Code") Then famille.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then famille.Libelle=reader.GetValue(Num_Libelle)
		Return famille
	End Function
End Class
