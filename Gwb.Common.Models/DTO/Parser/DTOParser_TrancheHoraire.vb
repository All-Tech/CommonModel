 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TrancheHoraire
Inherits DTOParser
	Private  Num_TrancheHoraireID As Integer
	Private  Num_RotationID As Integer
	Private  Num_DateDebut As Integer
	Private  Num_Datefin As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TrancheHoraireID = reader.GetOrdinal("TrancheHoraireID")
		Num_RotationID = reader.GetOrdinal("RotationID")
		Num_DateDebut = reader.GetOrdinal("DateDebut")
		Num_Datefin = reader.GetOrdinal("Datefin")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim tranchehoraire As New TrancheHoraire()
		 If Not reader.IsDBNull("TrancheHoraireID") Then tranchehoraire.TrancheHoraireID=reader.GetValue(Num_TrancheHoraireID)
		 If Not reader.IsDBNull("RotationID") Then tranchehoraire.RotationID=reader.GetValue(Num_RotationID)
		 If Not reader.IsDBNull("DateDebut") Then tranchehoraire.DateDebut=reader.GetValue(Num_DateDebut)
		 If Not reader.IsDBNull("Datefin") Then tranchehoraire.Datefin=reader.GetValue(Num_Datefin)
		Return tranchehoraire
	End Function
End Class
