Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Modules
Inherits DTOParser
	Private  Num_ModuleID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ModuleID = reader.GetOrdinal("ModuleID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim modules As New Modules()
		 If Not reader.IsDBNull("ModuleID") Then modules.ModuleID=reader.GetValue(Num_ModuleID)
		 If Not reader.IsDBNull("Libelle") Then modules.Libelle=reader.GetValue(Num_Libelle)
		Return modules
	End Function
End Class
