 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TypeFournisseur
Inherits DTOParser
	Private  Num_TypeFournisseurID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TypeFournisseurID = reader.GetOrdinal("TypeFournisseurID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim typefournisseur As New TypeFournisseur()
		 If Not reader.IsDBNull("TypeFournisseurID") Then typefournisseur.TypeFournisseurID=reader.GetValue(Num_TypeFournisseurID)
		 If Not reader.IsDBNull("Code") Then typefournisseur.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then typefournisseur.Libelle=reader.GetValue(Num_Libelle)
		Return typefournisseur
	End Function
End Class
