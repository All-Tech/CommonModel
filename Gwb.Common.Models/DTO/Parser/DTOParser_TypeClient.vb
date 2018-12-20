 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TypeClient
Inherits DTOParser
	Private  Num_TypeClientID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TypeClientID = reader.GetOrdinal("TypeClientID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim typeclient As New TypeClient()
		 If Not reader.IsDBNull("TypeClientID") Then typeclient.TypeClientID=reader.GetValue(Num_TypeClientID)
		 If Not reader.IsDBNull("Code") Then typeclient.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then typeclient.Libelle=reader.GetValue(Num_Libelle)
		Return typeclient
	End Function
End Class
