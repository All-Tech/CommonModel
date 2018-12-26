 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_CategorieEssence
Inherits DTOParser
	Private  Num_CategorieEssenceID As Integer
	Private  Num_Libelle As Integer
	Private  Num_BoisRougeBoisLong As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_CategorieEssenceID = reader.GetOrdinal("CategorieEssenceID")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_BoisRougeBoisLong = reader.GetOrdinal("BoisRougeBoisLong")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
        Dim categorieessence As New CategorieEssence()
        If Not reader.IsDBNull("CategorieEssenceID") Then categorieessence.CategorieEssenceID=reader.GetValue(Num_CategorieEssenceID)
		 If Not reader.IsDBNull("Libelle") Then categorieessence.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("BoisRougeBoisLong") Then categorieessence.BoisRougeBoisLong=reader.GetValue(Num_BoisRougeBoisLong)
		Return categorieessence
	End Function
End Class
