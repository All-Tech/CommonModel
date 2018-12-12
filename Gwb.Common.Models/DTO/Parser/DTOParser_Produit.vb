 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Produit
Inherits DTOParser
	Private  Num_ProduitID As Integer
	Private  Num_SocieteID As Integer
    Private Num_SousFamilleID As Integer
    Private  Num_CodeProduit As Integer
	Private  Num_Libelle As Integer
	Private  Num_TypeQualite As Integer
	Private  Num_TypeGroupe As Integer
	Private  Num_CodeActivite As Integer
	Private  Num_CodePlaque As Integer
	Private  Num_PostAff As Integer
	Private  Num_CodeSig As Integer
	Private  Num_SDKDF As Integer
	Private  Num_Unites As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ProduitID = reader.GetOrdinal("ProduitID")
		Num_SocieteID = reader.GetOrdinal("SocieteID")
        Num_SousFamilleID = reader.GetOrdinal("Sous¬FamilleID")
        Num_CodeProduit = reader.GetOrdinal("CodeProduit")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_TypeQualite = reader.GetOrdinal("TypeQualite")
		Num_TypeGroupe = reader.GetOrdinal("TypeGroupe")
		Num_CodeActivite = reader.GetOrdinal("CodeActivite")
		Num_CodePlaque = reader.GetOrdinal("CodePlaque")
		Num_PostAff = reader.GetOrdinal("PostAff")
		Num_CodeSig = reader.GetOrdinal("CodeSig")
		Num_SDKDF = reader.GetOrdinal("SDKDF")
		Num_Unites = reader.GetOrdinal("Unites")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim produit As New Produit()
		 If Not reader.IsDBNull("ProduitID") Then produit.ProduitID=reader.GetValue(Num_ProduitID)
		 If Not reader.IsDBNull("SocieteID") Then produit.SocieteID=reader.GetValue(Num_SocieteID)
        If Not reader.IsDBNull("Sous¬FamilleID") Then produit.SousFamilleID = reader.GetValue(Num_SousFamilleID)
        If Not reader.IsDBNull("CodeProduit") Then produit.CodeProduit=reader.GetValue(Num_CodeProduit)
		 If Not reader.IsDBNull("Libelle") Then produit.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("TypeQualite") Then produit.TypeQualite=reader.GetValue(Num_TypeQualite)
		 If Not reader.IsDBNull("TypeGroupe") Then produit.TypeGroupe=reader.GetValue(Num_TypeGroupe)
		 If Not reader.IsDBNull("CodeActivite") Then produit.CodeActivite=reader.GetValue(Num_CodeActivite)
		 If Not reader.IsDBNull("CodePlaque") Then produit.CodePlaque=reader.GetValue(Num_CodePlaque)
		 If Not reader.IsDBNull("PostAff") Then produit.PostAff=reader.GetValue(Num_PostAff)
		 If Not reader.IsDBNull("CodeSig") Then produit.CodeSig=reader.GetValue(Num_CodeSig)
		 If Not reader.IsDBNull("SDKDF") Then produit.SDKDF=reader.GetValue(Num_SDKDF)
		 If Not reader.IsDBNull("Unites") Then produit.Unites=reader.GetValue(Num_Unites)
		Return produit
	End Function
End Class
