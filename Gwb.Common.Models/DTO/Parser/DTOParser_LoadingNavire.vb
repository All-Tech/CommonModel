 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_LoadingNavire
Inherits DTOParser
	Private  Num_LoadingNavireID As Integer
	Private  Num_LoadingChargementID As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_LoadingNavireID = reader.GetOrdinal("LoadingNavireID")
		Num_LoadingChargementID = reader.GetOrdinal("LoadingChargementID")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim loadingnavire As New LoadingNavire()
		 If Not reader.IsDBNull("LoadingNavireID") Then loadingnavire.LoadingNavireID=reader.GetValue(Num_LoadingNavireID)
		 If Not reader.IsDBNull("LoadingChargementID") Then loadingnavire.LoadingChargementID=reader.GetValue(Num_LoadingChargementID)
		Return loadingnavire
	End Function
End Class
