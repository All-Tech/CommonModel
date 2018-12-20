 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Pays
Inherits DTOParser
	Private  Num_PaysID As Integer
	Private  Num_CodePays As Integer
	Private  Num_NomPays As Integer
	Private  Num_CodePostal As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_PaysID = reader.GetOrdinal("PaysID")
		Num_CodePays = reader.GetOrdinal("CodePays")
		Num_NomPays = reader.GetOrdinal("NomPays")
		Num_CodePostal = reader.GetOrdinal("CodePostal")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim pays As New Pays()
		 If Not reader.IsDBNull("PaysID") Then pays.PaysID=reader.GetValue(Num_PaysID)
		 If Not reader.IsDBNull("CodePays") Then pays.CodePays=reader.GetValue(Num_CodePays)
		 If Not reader.IsDBNull("NomPays") Then pays.NomPays=reader.GetValue(Num_NomPays)
		 If Not reader.IsDBNull("CodePostal") Then pays.CodePostal=reader.GetValue(Num_CodePostal)
		Return pays
	End Function
End Class
