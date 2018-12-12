 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Profil
Inherits DTOParser
	Private  Num_ProfilID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ProfilID = reader.GetOrdinal("ProfilID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim profil As New Profil()
		 If Not reader.IsDBNull("ProfilID") Then profil.ProfilID=reader.GetValue(Num_ProfilID)
		 If Not reader.IsDBNull("Libelle") Then profil.Libelle=reader.GetValue(Num_Libelle)
		Return profil
	End Function
End Class
