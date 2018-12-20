 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Fournisseur
Inherits DTOParser
	Private  Num_FournisseurID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_TypeFournisseur As Integer
	Private  Num_Code As Integer
	Private  Num_Designation As Integer
	Private  Num_Adresse1 As Integer
	Private  Num_Adresse2 As Integer
	Private  Num_BoitePostal As Integer
	Private  Num_Telephone1 As Integer
	Private  Num_Telephone2 As Integer
	Private  Num_Email As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_FournisseurID = reader.GetOrdinal("FournisseurID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_TypeFournisseur = reader.GetOrdinal("TypeFournisseur")
		Num_Code = reader.GetOrdinal("Code")
		Num_Designation = reader.GetOrdinal("Designation")
		Num_Adresse1 = reader.GetOrdinal("Adresse1")
		Num_Adresse2 = reader.GetOrdinal("Adresse2")
		Num_BoitePostal = reader.GetOrdinal("BoitePostal")
		Num_Telephone1 = reader.GetOrdinal("Telephone1")
		Num_Telephone2 = reader.GetOrdinal("Telephone2")
		Num_Email = reader.GetOrdinal("Email")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim fournisseur As New Fournisseur()
		 If Not reader.IsDBNull("FournisseurID") Then fournisseur.FournisseurID=reader.GetValue(Num_FournisseurID)
		 If Not reader.IsDBNull("SiteOperationID") Then fournisseur.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("TypeFournisseur") Then fournisseur.TypeFournisseur=reader.GetValue(Num_TypeFournisseur)
		 If Not reader.IsDBNull("Code") Then fournisseur.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Designation") Then fournisseur.Designation=reader.GetValue(Num_Designation)
		 If Not reader.IsDBNull("Adresse1") Then fournisseur.Adresse1=reader.GetValue(Num_Adresse1)
		 If Not reader.IsDBNull("Adresse2") Then fournisseur.Adresse2=reader.GetValue(Num_Adresse2)
		 If Not reader.IsDBNull("BoitePostal") Then fournisseur.BoitePostal=reader.GetValue(Num_BoitePostal)
		 If Not reader.IsDBNull("Telephone1") Then fournisseur.Telephone1=reader.GetValue(Num_Telephone1)
		 If Not reader.IsDBNull("Telephone2") Then fournisseur.Telephone2=reader.GetValue(Num_Telephone2)
		 If Not reader.IsDBNull("Email") Then fournisseur.Email=reader.GetValue(Num_Email)
		Return fournisseur
	End Function
End Class
