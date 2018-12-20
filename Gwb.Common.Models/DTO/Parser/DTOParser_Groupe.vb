 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Groupe
Inherits DTOParser
	Private  Num_GroupeID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer
	Private  Num_Adresse As Integer
	Private  Num_Ville As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_GroupeID = reader.GetOrdinal("GroupeID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_Adresse = reader.GetOrdinal("Adresse")
		Num_Ville = reader.GetOrdinal("Ville")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim groupe As New Groupe()
		 If Not reader.IsDBNull("GroupeID") Then groupe.GroupeID=reader.GetValue(Num_GroupeID)
		 If Not reader.IsDBNull("Code") Then groupe.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then groupe.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("Adresse") Then groupe.Adresse=reader.GetValue(Num_Adresse)
		 If Not reader.IsDBNull("Ville") Then groupe.Ville=reader.GetValue(Num_Ville)
		Return groupe
	End Function
End Class
