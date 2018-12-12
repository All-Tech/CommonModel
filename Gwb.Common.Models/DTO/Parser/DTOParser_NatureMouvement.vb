 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_NatureMouvement
Inherits DTOParser
	Private  Num_NatureMouvementID As Integer
	Private  Num_SocieteID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_NatureMouvementID = reader.GetOrdinal("NatureMouvementID")
		Num_SocieteID = reader.GetOrdinal("SocieteID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim naturemouvement As New NatureMouvement()
		 If Not reader.IsDBNull("NatureMouvementID") Then naturemouvement.NatureMouvementID=reader.GetValue(Num_NatureMouvementID)
		 If Not reader.IsDBNull("SocieteID") Then naturemouvement.SocieteID=reader.GetValue(Num_SocieteID)
		 If Not reader.IsDBNull("Code") Then naturemouvement.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then naturemouvement.Libelle=reader.GetValue(Num_Libelle)
		Return naturemouvement
	End Function
End Class
