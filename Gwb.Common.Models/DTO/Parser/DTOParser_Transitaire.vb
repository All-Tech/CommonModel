 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Transitaire
Inherits DTOParser
	Private  Num_TransitaireID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TransitaireID = reader.GetOrdinal("TransitaireID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim transitaire As New Transitaire()
		 If Not reader.IsDBNull("TransitaireID") Then transitaire.TransitaireID=reader.GetValue(Num_TransitaireID)
		 If Not reader.IsDBNull("SiteOperationID") Then transitaire.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("Libelle") Then transitaire.Libelle=reader.GetValue(Num_Libelle)
		Return transitaire
	End Function
End Class
