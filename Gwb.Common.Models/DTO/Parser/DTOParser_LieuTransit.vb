 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_LieuTransit
Inherits DTOParser
	Private  Num_LieuTransitID As Integer
	Private  Num_SiteOperattionID As Integer
	Private  Num_PortID As Integer
	Private  Num_NumeroPortEmbarquement As Integer
	Private  Num_TypeSiteParc As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_LieuTransitID = reader.GetOrdinal("LieuTransitID")
		Num_SiteOperattionID = reader.GetOrdinal("SiteOperattionID")
		Num_PortID = reader.GetOrdinal("PortID")
		Num_NumeroPortEmbarquement = reader.GetOrdinal("NumeroPortEmbarquement")
		Num_TypeSiteParc = reader.GetOrdinal("TypeSiteParc")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim lieutransit As New LieuTransit()
		 If Not reader.IsDBNull("LieuTransitID") Then lieutransit.LieuTransitID=reader.GetValue(Num_LieuTransitID)
		 If Not reader.IsDBNull("SiteOperattionID") Then lieutransit.SiteOperattionID=reader.GetValue(Num_SiteOperattionID)
		 If Not reader.IsDBNull("PortID") Then lieutransit.PortID=reader.GetValue(Num_PortID)
		 If Not reader.IsDBNull("NumeroPortEmbarquement") Then lieutransit.NumeroPortEmbarquement=reader.GetValue(Num_NumeroPortEmbarquement)
		 If Not reader.IsDBNull("TypeSiteParc") Then lieutransit.TypeSiteParc=reader.GetValue(Num_TypeSiteParc)
		Return lieutransit
	End Function
End Class
