 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_DensiteBois
Inherits DTOParser
	Private  Num_DensiteBoisID As Integer
	Private  Num_EssenceID As Integer
	Private  Num_ProduitID As Integer
	Private  Num_Densite As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_DensiteBoisID = reader.GetOrdinal("DensiteBoisID")
		Num_EssenceID = reader.GetOrdinal("EssenceID")
		Num_ProduitID = reader.GetOrdinal("ProduitID")
		Num_Densite = reader.GetOrdinal("Densite")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim densitebois As New DensiteBois()
		 If Not reader.IsDBNull("DensiteBoisID") Then densitebois.DensiteBoisID=reader.GetValue(Num_DensiteBoisID)
		 If Not reader.IsDBNull("EssenceID") Then densitebois.EssenceID=reader.GetValue(Num_EssenceID)
		 If Not reader.IsDBNull("ProduitID") Then densitebois.ProduitID=reader.GetValue(Num_ProduitID)
		 If Not reader.IsDBNull("Densite") Then densitebois.Densite=reader.GetValue(Num_Densite)
		Return densitebois
	End Function
End Class
