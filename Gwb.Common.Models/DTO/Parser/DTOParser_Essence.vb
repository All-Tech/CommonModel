 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Essence
Inherits DTOParser
	Private  Num_EssenceID As Integer
	Private  Num_ClasseEssenceID As Integer
	Private  Num_SocieteID As Integer
	Private  Num_CategorieEssenceID As Integer
	Private  Num_Libelle As Integer
	Private  Num_NomScientifique As Integer
	Private  Num_CodeMesurage As Integer
	Private  Num_DiamExpeditionOfficielle As Integer
	Private  Num_MesurageAubier As Integer
	Private  Num_CodeActif As Integer
	Private  Num_NomSnt As Integer
	Private  Num_CodeCubagePlein As Integer
	Private  Num_CodeCubageCom As Integer
	Private  Num_CodeStat As Integer
	Private  Num_CodeCde As Integer
	Private  Num_CodeIhc As Integer
	Private  Num_Aupdate As Integer
	Private  Num_RendementProduitRC As Integer
	Private  Num_EtatIc As Integer
	Private  Num_RendementProduitRC1 As Integer
	Private  Num_SeuilLongueurEntreeScie As Integer
	Private  Num_PrixFob As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_EssenceID = reader.GetOrdinal("EssenceID")
		Num_ClasseEssenceID = reader.GetOrdinal("ClasseEssenceID")
		Num_SocieteID = reader.GetOrdinal("SocieteID")
		Num_CategorieEssenceID = reader.GetOrdinal("CategorieEssenceID")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_NomScientifique = reader.GetOrdinal("NomScientifique")
		Num_CodeMesurage = reader.GetOrdinal("CodeMesurage")
		Num_DiamExpeditionOfficielle = reader.GetOrdinal("DiamExpeditionOfficielle")
		Num_MesurageAubier = reader.GetOrdinal("MesurageAubier")
		Num_CodeActif = reader.GetOrdinal("CodeActif")
		Num_NomSnt = reader.GetOrdinal("NomSnt")
		Num_CodeCubagePlein = reader.GetOrdinal("CodeCubagePlein")
		Num_CodeCubageCom = reader.GetOrdinal("CodeCubageCom")
		Num_CodeStat = reader.GetOrdinal("CodeStat")
		Num_CodeCde = reader.GetOrdinal("CodeCde")
		Num_CodeIhc = reader.GetOrdinal("CodeIhc")
		Num_Aupdate = reader.GetOrdinal("Aupdate")
		Num_RendementProduitRC = reader.GetOrdinal("RendementProduitRC")
		Num_EtatIc = reader.GetOrdinal("EtatIc")
		Num_RendementProduitRC1 = reader.GetOrdinal("RendementProduitRC1")
		Num_SeuilLongueurEntreeScie = reader.GetOrdinal("SeuilLongueurEntreeScie")
		Num_PrixFob = reader.GetOrdinal("PrixFob")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim essence As New Essence()
		 If Not reader.IsDBNull("EssenceID") Then essence.EssenceID=reader.GetValue(Num_EssenceID)
		 If Not reader.IsDBNull("ClasseEssenceID") Then essence.ClasseEssenceID=reader.GetValue(Num_ClasseEssenceID)
		 If Not reader.IsDBNull("SocieteID") Then essence.SocieteID=reader.GetValue(Num_SocieteID)
		 If Not reader.IsDBNull("CategorieEssenceID") Then essence.CategorieEssenceID=reader.GetValue(Num_CategorieEssenceID)
		 If Not reader.IsDBNull("Libelle") Then essence.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("NomScientifique") Then essence.NomScientifique=reader.GetValue(Num_NomScientifique)
		 If Not reader.IsDBNull("CodeMesurage") Then essence.CodeMesurage=reader.GetValue(Num_CodeMesurage)
		 If Not reader.IsDBNull("DiamExpeditionOfficielle") Then essence.DiamExpeditionOfficielle=reader.GetValue(Num_DiamExpeditionOfficielle)
		 If Not reader.IsDBNull("MesurageAubier") Then essence.MesurageAubier=reader.GetValue(Num_MesurageAubier)
		 If Not reader.IsDBNull("CodeActif") Then essence.CodeActif=reader.GetValue(Num_CodeActif)
		 If Not reader.IsDBNull("NomSnt") Then essence.NomSnt=reader.GetValue(Num_NomSnt)
		 If Not reader.IsDBNull("CodeCubagePlein") Then essence.CodeCubagePlein=reader.GetValue(Num_CodeCubagePlein)
		 If Not reader.IsDBNull("CodeCubageCom") Then essence.CodeCubageCom=reader.GetValue(Num_CodeCubageCom)
		 If Not reader.IsDBNull("CodeStat") Then essence.CodeStat=reader.GetValue(Num_CodeStat)
		 If Not reader.IsDBNull("CodeCde") Then essence.CodeCde=reader.GetValue(Num_CodeCde)
		 If Not reader.IsDBNull("CodeIhc") Then essence.CodeIhc=reader.GetValue(Num_CodeIhc)
		 If Not reader.IsDBNull("Aupdate") Then essence.Aupdate=reader.GetValue(Num_Aupdate)
		 If Not reader.IsDBNull("RendementProduitRC") Then essence.RendementProduitRC=reader.GetValue(Num_RendementProduitRC)
		 If Not reader.IsDBNull("EtatIc") Then essence.EtatIc=reader.GetValue(Num_EtatIc)
		 If Not reader.IsDBNull("RendementProduitRC1") Then essence.RendementProduitRC1=reader.GetValue(Num_RendementProduitRC1)
		 If Not reader.IsDBNull("SeuilLongueurEntreeScie") Then essence.SeuilLongueurEntreeScie=reader.GetValue(Num_SeuilLongueurEntreeScie)
		 If Not reader.IsDBNull("PrixFob") Then essence.PrixFob=reader.GetValue(Num_PrixFob)
		Return essence
	End Function
End Class
