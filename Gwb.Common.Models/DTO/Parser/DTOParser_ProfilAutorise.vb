 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_ProfilAutorise
Inherits DTOParser
	Private  Num_ProfilAutoriseID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ProfilAutoriseID = reader.GetOrdinal("ProfilAutoriseID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim profilautorise As New ProfilAutorise()
		 If Not reader.IsDBNull("ProfilAutoriseID") Then profilautorise.ProfilAutoriseID=reader.GetValue(Num_ProfilAutoriseID)
		 If Not reader.IsDBNull("Libelle") Then profilautorise.Libelle=reader.GetValue(Num_Libelle)
		Return profilautorise
	End Function
End Class
