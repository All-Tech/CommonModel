 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Siege
Inherits DTOParser
	Private  Num_SiegeID As Integer
	Private  Num_GroupeID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer
	Private  Num_Adresse As Integer
	Private  Num_Pays As Integer
	Private  Num_Ville As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_SiegeID = reader.GetOrdinal("SiegeID")
		Num_GroupeID = reader.GetOrdinal("GroupeID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_Adresse = reader.GetOrdinal("Adresse")
		Num_Pays = reader.GetOrdinal("Pays")
		Num_Ville = reader.GetOrdinal("Ville")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim siege As New Siege()
		 If Not reader.IsDBNull("SiegeID") Then siege.SiegeID=reader.GetValue(Num_SiegeID)
		 If Not reader.IsDBNull("GroupeID") Then siege.GroupeID=reader.GetValue(Num_GroupeID)
		 If Not reader.IsDBNull("Code") Then siege.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then siege.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("Adresse") Then siege.Adresse=reader.GetValue(Num_Adresse)
		 If Not reader.IsDBNull("Pays") Then siege.Pays=reader.GetValue(Num_Pays)
		 If Not reader.IsDBNull("Ville") Then siege.Ville=reader.GetValue(Num_Ville)
		Return siege
	End Function
End Class
