 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_QualiteIHC
Inherits DTOParser
	Private  Num_QualiteIHCID As Integer
	Private  Num_ProduitID As Integer
	Private  Num_CodeQualite As Integer
	Private  Num_Libelle As Integer
	Private  Num_CodeMercuriale As Integer
	Private  Num_CodeActivite As Integer
	Private  Num_CodePlaquette As Integer
	Private  Num_CodePlaquette1 As Integer
	Private  Num_CodeIhc As Integer
	Private  Num_PrixVenteLocale As Integer
	Private  Num_PosAffic As Integer
	Private  Num_LongueurRecuperation As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_QualiteIHCID = reader.GetOrdinal("QualiteIHCID")
		Num_ProduitID = reader.GetOrdinal("ProduitID")
		Num_CodeQualite = reader.GetOrdinal("CodeQualite")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_CodeMercuriale = reader.GetOrdinal("CodeMercuriale")
		Num_CodeActivite = reader.GetOrdinal("CodeActivite")
		Num_CodePlaquette = reader.GetOrdinal("CodePlaquette")
		Num_CodePlaquette1 = reader.GetOrdinal("CodePlaquette1")
		Num_CodeIhc = reader.GetOrdinal("CodeIhc")
		Num_PrixVenteLocale = reader.GetOrdinal("PrixVenteLocale")
		Num_PosAffic = reader.GetOrdinal("PosAffic")
		Num_LongueurRecuperation = reader.GetOrdinal("LongueurRecuperation")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim qualiteihc As New QualiteIHC()
		 If Not reader.IsDBNull("QualiteIHCID") Then qualiteihc.QualiteIHCID=reader.GetValue(Num_QualiteIHCID)
		 If Not reader.IsDBNull("ProduitID") Then qualiteihc.ProduitID=reader.GetValue(Num_ProduitID)
		 If Not reader.IsDBNull("CodeQualite") Then qualiteihc.CodeQualite=reader.GetValue(Num_CodeQualite)
		 If Not reader.IsDBNull("Libelle") Then qualiteihc.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("CodeMercuriale") Then qualiteihc.CodeMercuriale=reader.GetValue(Num_CodeMercuriale)
		 If Not reader.IsDBNull("CodeActivite") Then qualiteihc.CodeActivite=reader.GetValue(Num_CodeActivite)
		 If Not reader.IsDBNull("CodePlaquette") Then qualiteihc.CodePlaquette=reader.GetValue(Num_CodePlaquette)
		 If Not reader.IsDBNull("CodePlaquette1") Then qualiteihc.CodePlaquette1=reader.GetValue(Num_CodePlaquette1)
		 If Not reader.IsDBNull("CodeIhc") Then qualiteihc.CodeIhc=reader.GetValue(Num_CodeIhc)
		 If Not reader.IsDBNull("PrixVenteLocale") Then qualiteihc.PrixVenteLocale=reader.GetValue(Num_PrixVenteLocale)
		 If Not reader.IsDBNull("PosAffic") Then qualiteihc.PosAffic=reader.GetValue(Num_PosAffic)
		 If Not reader.IsDBNull("LongueurRecuperation") Then qualiteihc.LongueurRecuperation=reader.GetValue(Num_LongueurRecuperation)
		Return qualiteihc
	End Function
End Class
