 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TypeEquipe
Inherits DTOParser
	Private  Num_TypeEquipeID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer
	Private  Num_Rang As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TypeEquipeID = reader.GetOrdinal("TypeEquipeID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_Rang = reader.GetOrdinal("Rang")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim typeequipe As New TypeEquipe()
		 If Not reader.IsDBNull("TypeEquipeID") Then typeequipe.TypeEquipeID=reader.GetValue(Num_TypeEquipeID)
		 If Not reader.IsDBNull("Code") Then typeequipe.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then typeequipe.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("Rang") Then typeequipe.Rang=reader.GetValue(Num_Rang)
		Return typeequipe
	End Function
End Class
