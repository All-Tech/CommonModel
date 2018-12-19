 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TarifIHC
Inherits DTOParser
	Private  Num_TarifIHCID As Integer
	Private  Num_SocieteID As Integer
	Private  Num_EssenceID As Integer
	Private  Num_ProduitID As Integer
	Private  Num_QualiteIHCID As Integer
	Private  Num_PrixM3Prix As Integer
	Private  Num_AncienPrixM3 As Integer
	Private  Num_DateAncienPrixm3 As Integer
	Private  Num_DatePrixM3 As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TarifIHCID = reader.GetOrdinal("TarifIHCID")
		Num_SocieteID = reader.GetOrdinal("SocieteID")
		Num_EssenceID = reader.GetOrdinal("EssenceID")
		Num_ProduitID = reader.GetOrdinal("ProduitID")
		Num_QualiteIHCID = reader.GetOrdinal("QualiteIHCID")
		Num_PrixM3Prix = reader.GetOrdinal("PrixM3Prix")
		Num_AncienPrixM3 = reader.GetOrdinal("AncienPrixM3")
		Num_DateAncienPrixm3 = reader.GetOrdinal("DateAncienPrixm3")
		Num_DatePrixM3 = reader.GetOrdinal("DatePrixM3")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim tarifihc As New TarifIHC()
		 If Not reader.IsDBNull("TarifIHCID") Then tarifihc.TarifIHCID=reader.GetValue(Num_TarifIHCID)
		 If Not reader.IsDBNull("SocieteID") Then tarifihc.SocieteID=reader.GetValue(Num_SocieteID)
		 If Not reader.IsDBNull("EssenceID") Then tarifihc.EssenceID=reader.GetValue(Num_EssenceID)
		 If Not reader.IsDBNull("ProduitID") Then tarifihc.ProduitID=reader.GetValue(Num_ProduitID)
		 If Not reader.IsDBNull("QualiteIHCID") Then tarifihc.QualiteIHCID=reader.GetValue(Num_QualiteIHCID)
		 If Not reader.IsDBNull("PrixM3Prix") Then tarifihc.PrixM3Prix=reader.GetValue(Num_PrixM3Prix)
		 If Not reader.IsDBNull("AncienPrixM3") Then tarifihc.AncienPrixM3=reader.GetValue(Num_AncienPrixM3)
		 If Not reader.IsDBNull("DateAncienPrixm3") Then tarifihc.DateAncienPrixm3=reader.GetValue(Num_DateAncienPrixm3)
		 If Not reader.IsDBNull("DatePrixM3") Then tarifihc.DatePrixM3=reader.GetValue(Num_DatePrixM3)
		Return tarifihc
	End Function
End Class
