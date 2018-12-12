 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Port
Inherits DTOParser
	Private  Num_PortID As Integer
	Private  Num_SiteOperattionID As Integer
	Private  Num_NaturePortID As Integer
	Private  Num_Libelle As Integer
	Private  Num_Numerodestination As Integer
	Private  Num_EstActif As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_PortID = reader.GetOrdinal("PortID")
		Num_SiteOperattionID = reader.GetOrdinal("SiteOperattionID")
		Num_NaturePortID = reader.GetOrdinal("NaturePortID")
		Num_Libelle = reader.GetOrdinal("Libelle")
		Num_Numerodestination = reader.GetOrdinal("Numerodestination")
		Num_EstActif = reader.GetOrdinal("EstActif")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim port As New Port()
		 If Not reader.IsDBNull("PortID") Then port.PortID=reader.GetValue(Num_PortID)
		 If Not reader.IsDBNull("SiteOperattionID") Then port.SiteOperattionID=reader.GetValue(Num_SiteOperattionID)
		 If Not reader.IsDBNull("NaturePortID") Then port.NaturePortID=reader.GetValue(Num_NaturePortID)
		 If Not reader.IsDBNull("Libelle") Then port.Libelle=reader.GetValue(Num_Libelle)
		 If Not reader.IsDBNull("Numerodestination") Then port.Numerodestination=reader.GetValue(Num_Numerodestination)
		 If Not reader.IsDBNull("EstActif") Then port.EstActif=reader.GetValue(Num_EstActif)
		Return port
	End Function
End Class
