 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Droit
Inherits DTOParser
	Private  Num_DroitID As Integer
	Private  Num_ModuleID As Integer
	Private  Num_ProfilID As Integer
	Private  Num_Ecriture As Integer
	Private  Num_Lecture As Integer
	Private  Num_Modifier As Integer
	Private  Num_Suppression As Integer
	Private  Num_Impression As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_DroitID = reader.GetOrdinal("DroitID")
		Num_ModuleID = reader.GetOrdinal("ModuleID")
		Num_ProfilID = reader.GetOrdinal("ProfilID")
		Num_Ecriture = reader.GetOrdinal("Ecriture")
		Num_Lecture = reader.GetOrdinal("Lecture")
		Num_Modifier = reader.GetOrdinal("Modifier")
		Num_Suppression = reader.GetOrdinal("Suppression")
		Num_Impression = reader.GetOrdinal("Impression")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim droit As New Droit()
		 If Not reader.IsDBNull("DroitID") Then droit.DroitID=reader.GetValue(Num_DroitID)
		 If Not reader.IsDBNull("ModuleID") Then droit.ModuleID=reader.GetValue(Num_ModuleID)
		 If Not reader.IsDBNull("ProfilID") Then droit.ProfilID=reader.GetValue(Num_ProfilID)
		 If Not reader.IsDBNull("Ecriture") Then droit.Ecriture=reader.GetValue(Num_Ecriture)
		 If Not reader.IsDBNull("Lecture") Then droit.Lecture=reader.GetValue(Num_Lecture)
		 If Not reader.IsDBNull("Modifier") Then droit.Modifier=reader.GetValue(Num_Modifier)
		 If Not reader.IsDBNull("Suppression") Then droit.Suppression=reader.GetValue(Num_Suppression)
		 If Not reader.IsDBNull("Impression") Then droit.Impression=reader.GetValue(Num_Impression)
		Return droit
	End Function
End Class
