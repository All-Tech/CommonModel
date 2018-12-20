 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Rotation
Inherits DTOParser
	Private  Num_RotationID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_ScieID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_RotationID = reader.GetOrdinal("RotationID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_ScieID = reader.GetOrdinal("ScieID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim rotation As New Rotation()
		 If Not reader.IsDBNull("RotationID") Then rotation.RotationID=reader.GetValue(Num_RotationID)
		 If Not reader.IsDBNull("SiteOperationID") Then rotation.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("ScieID") Then rotation.ScieID=reader.GetValue(Num_ScieID)
		 If Not reader.IsDBNull("Libelle") Then rotation.Libelle=reader.GetValue(Num_Libelle)
		Return rotation
	End Function
End Class
