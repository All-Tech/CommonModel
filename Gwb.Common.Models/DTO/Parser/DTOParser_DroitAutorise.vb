 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_DroitAutorise
Inherits DTOParser
	Private  Num_DroitAutoriseID As Integer
	Private  Num_ProfilAutoriseID As Integer
	Private  Num_ModuleID As Integer
	Private  Num_Ecriture As Integer
	Private  Num_Lecture As Integer
	Private  Num_Modifier As Integer
	Private  Num_Suppression As Integer
	Private  Num_Impression As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_DroitAutoriseID = reader.GetOrdinal("DroitAutoriseID")
		Num_ProfilAutoriseID = reader.GetOrdinal("ProfilAutoriseID")
		Num_ModuleID = reader.GetOrdinal("ModuleID")
		Num_Ecriture = reader.GetOrdinal("Ecriture")
		Num_Lecture = reader.GetOrdinal("Lecture")
		Num_Modifier = reader.GetOrdinal("Modifier")
		Num_Suppression = reader.GetOrdinal("Suppression")
		Num_Impression = reader.GetOrdinal("Impression")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim droitautorise As New DroitAutorise()
		 If Not reader.IsDBNull("DroitAutoriseID") Then droitautorise.DroitAutoriseID=reader.GetValue(Num_DroitAutoriseID)
		 If Not reader.IsDBNull("ProfilAutoriseID") Then droitautorise.ProfilAutoriseID=reader.GetValue(Num_ProfilAutoriseID)
		 If Not reader.IsDBNull("ModuleID") Then droitautorise.ModuleID=reader.GetValue(Num_ModuleID)
		 If Not reader.IsDBNull("Ecriture") Then droitautorise.Ecriture=reader.GetValue(Num_Ecriture)
		 If Not reader.IsDBNull("Lecture") Then droitautorise.Lecture=reader.GetValue(Num_Lecture)
		 If Not reader.IsDBNull("Modifier") Then droitautorise.Modifier=reader.GetValue(Num_Modifier)
		 If Not reader.IsDBNull("Suppression") Then droitautorise.Suppression=reader.GetValue(Num_Suppression)
		 If Not reader.IsDBNull("Impression") Then droitautorise.Impression=reader.GetValue(Num_Impression)
		Return droitautorise
	End Function
End Class
