 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_MoyenTransport
Inherits DTOParser
	Private  Num_MoyenTransportID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_TransporteurtID As Integer
	Private  Num_NumeroTracteur As Integer
	Private  Num_NumeroRemorque As Integer
	Private  Num_Numero As Integer
	Private  Num_Chauffeur As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_MoyenTransportID = reader.GetOrdinal("MoyenTransportID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_TransporteurtID = reader.GetOrdinal("TransporteurtID")
		Num_NumeroTracteur = reader.GetOrdinal("NumeroTracteur")
		Num_NumeroRemorque = reader.GetOrdinal("NumeroRemorque")
		Num_Numero = reader.GetOrdinal("Numero")
		Num_Chauffeur = reader.GetOrdinal("Chauffeur")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim moyentransport As New MoyenTransport()
		 If Not reader.IsDBNull("MoyenTransportID") Then moyentransport.MoyenTransportID=reader.GetValue(Num_MoyenTransportID)
		 If Not reader.IsDBNull("SiteOperationID") Then moyentransport.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("TransporteurtID") Then moyentransport.TransporteurtID=reader.GetValue(Num_TransporteurtID)
		 If Not reader.IsDBNull("NumeroTracteur") Then moyentransport.NumeroTracteur=reader.GetValue(Num_NumeroTracteur)
		 If Not reader.IsDBNull("NumeroRemorque") Then moyentransport.NumeroRemorque=reader.GetValue(Num_NumeroRemorque)
		 If Not reader.IsDBNull("Numero") Then moyentransport.Numero=reader.GetValue(Num_Numero)
		 If Not reader.IsDBNull("Chauffeur") Then moyentransport.Chauffeur=reader.GetValue(Num_Chauffeur)
		Return moyentransport
	End Function
End Class
