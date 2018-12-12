 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Parc
Inherits DTOParser
	Private  Num_ParcID As Integer
	Private  Num_SiteOperattionID As Integer
	Private  Num_NatureParcID As Integer
	Private  Num_CodeParc As Integer
	Private  Num_Libelle As Integer
	Private  Num_CodeVolume As Integer
	Private  Num_CodeArbre As Integer
	Private  Num_CodeStockSechoir As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ParcID = reader.GetOrdinal("ParcID")
		Num_SiteOperattionID = reader.GetOrdinal("SiteOperattionID")
		Num_NatureParcID = reader.GetOrdinal("NatureParcID")
		Num_CodeParc = reader.GetOrdinal("CodeParc")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_CodeVolume = reader.GetOrdinal("CodeVolume")
		Num_CodeArbre = reader.GetOrdinal("CodeArbre")
		Num_CodeStockSechoir = reader.GetOrdinal("CodeStockSechoir")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim parc As New Parc()
		 If Not reader.IsDBNull("ParcID") Then parc.ParcID=reader.GetValue(Num_ParcID)
		 If Not reader.IsDBNull("SiteOperattionID") Then parc.SiteOperattionID=reader.GetValue(Num_SiteOperattionID)
		 If Not reader.IsDBNull("NatureParcID") Then parc.NatureParcID=reader.GetValue(Num_NatureParcID)
		 If Not reader.IsDBNull("CodeParc") Then parc.CodeParc=reader.GetValue(Num_CodeParc)
		 If Not reader.IsDBNull("Libelle") Then parc.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("CodeVolume") Then parc.CodeVolume=reader.GetValue(Num_CodeVolume)
		 If Not reader.IsDBNull("CodeArbre") Then parc.CodeArbre=reader.GetValue(Num_CodeArbre)
		 If Not reader.IsDBNull("CodeStockSechoir") Then parc.CodeStockSechoir=reader.GetValue(Num_CodeStockSechoir)
		Return parc
	End Function
End Class
