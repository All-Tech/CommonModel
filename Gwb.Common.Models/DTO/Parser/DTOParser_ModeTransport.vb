 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_ModeTransport
Inherits DTOParser
	Private  Num_ModeTransportID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ModeTransportID = reader.GetOrdinal("ModeTransportID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim modetransport As New ModeTransport()
		 If Not reader.IsDBNull("ModeTransportID") Then modetransport.ModeTransportID=reader.GetValue(Num_ModeTransportID)
		 If Not reader.IsDBNull("Code") Then modetransport.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then modetransport.Libelle=reader.GetValue(Num_Libelle)
		Return modetransport
	End Function
End Class
