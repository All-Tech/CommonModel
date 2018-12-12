 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_ClasseEssence
Inherits DTOParser
	Private  Num_ClasseEssenceID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ClasseEssenceID = reader.GetOrdinal("ClasseEssenceID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim classeessence As New ClasseEssence()
		 If Not reader.IsDBNull("ClasseEssenceID") Then classeessence.ClasseEssenceID=reader.GetValue(Num_ClasseEssenceID)
		 If Not reader.IsDBNull("Libelle") Then classeessence.Libelle=reader.GetValue(Num_Libelle)
		Return classeessence
	End Function
End Class
