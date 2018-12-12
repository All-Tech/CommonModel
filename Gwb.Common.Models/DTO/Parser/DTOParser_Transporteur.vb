 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Transporteur
Inherits DTOParser
	Private  Num_TransporteurID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_ModeTransportID As Integer
	Private  Num_ComptabiliteID As Integer
	Private  Num_Code As Integer
	Private  Num_NomTransporteur As Integer
	Private  Num_Adresse As Integer
	Private  Num_Telephone As Integer
	Private  Num_Responsable As Integer
	Private  Num_Comptabilite1 As Integer
	Private  Num_Comptabilite2 As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TransporteurID = reader.GetOrdinal("TransporteurID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_ModeTransportID = reader.GetOrdinal("ModeTransportID")
		Num_ComptabiliteID = reader.GetOrdinal("ComptabiliteID")
		Num_Code = reader.GetOrdinal("Code")
		Num_NomTransporteur = reader.GetOrdinal("NomTransporteur")
		Num_Adresse = reader.GetOrdinal("Adresse")
		Num_Telephone = reader.GetOrdinal("Telephone")
		Num_Responsable = reader.GetOrdinal("Responsable")
		Num_Comptabilite1 = reader.GetOrdinal("Comptabilite1")
		Num_Comptabilite2 = reader.GetOrdinal("Comptabilite2")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim transporteur As New Transporteur()
		 If Not reader.IsDBNull("TransporteurID") Then transporteur.TransporteurID=reader.GetValue(Num_TransporteurID)
		 If Not reader.IsDBNull("SiteOperationID") Then transporteur.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("ModeTransportID") Then transporteur.ModeTransportID=reader.GetValue(Num_ModeTransportID)
		 If Not reader.IsDBNull("ComptabiliteID") Then transporteur.ComptabiliteID=reader.GetValue(Num_ComptabiliteID)
		 If Not reader.IsDBNull("Code") Then transporteur.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("NomTransporteur") Then transporteur.NomTransporteur=reader.GetValue(Num_NomTransporteur)
		 If Not reader.IsDBNull("Adresse") Then transporteur.Adresse=reader.GetValue(Num_Adresse)
		 If Not reader.IsDBNull("Telephone") Then transporteur.Telephone=reader.GetValue(Num_Telephone)
		 If Not reader.IsDBNull("Responsable") Then transporteur.Responsable=reader.GetValue(Num_Responsable)
		 If Not reader.IsDBNull("Comptabilite1") Then transporteur.Comptabilite1=reader.GetValue(Num_Comptabilite1)
		 If Not reader.IsDBNull("Comptabilite2") Then transporteur.Comptabilite2=reader.GetValue(Num_Comptabilite2)
		Return transporteur
	End Function
End Class
