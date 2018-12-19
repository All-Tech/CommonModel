 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_NatureParc
Inherits DTOParser
	Private  Num_NatureParcID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_NatureParcID = reader.GetOrdinal("NatureParcID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim natureparc As New NatureParc()
		 If Not reader.IsDBNull("NatureParcID") Then natureparc.NatureParcID=reader.GetValue(Num_NatureParcID)
		 If Not reader.IsDBNull("Libelle") Then natureparc.Libelle=reader.GetValue(Num_Libelle)
		Return natureparc
	End Function
End Class
