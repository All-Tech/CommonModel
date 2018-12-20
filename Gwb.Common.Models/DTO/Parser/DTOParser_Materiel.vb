 Imports System.Data.Common
Imports System.Configuration
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Materiel
Inherits DTOParser
	Private  Num_MaterielID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_TypeMaterielID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_MaterielID = reader.GetOrdinal("MaterielID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_TypeMaterielID = reader.GetOrdinal("TypeMaterielID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim materiel As New Materiel()
		 If Not reader.IsDBNull("MaterielID") Then materiel.MaterielID=reader.GetValue(Num_MaterielID)
		 If Not reader.IsDBNull("SiteOperationID") Then materiel.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("TypeMaterielID") Then materiel.TypeMaterielID=reader.GetValue(Num_TypeMaterielID)
		 If Not reader.IsDBNull("Code") Then materiel.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then materiel.Libelle=reader.GetValue(Num_Libelle)
		Return materiel
	End Function
End Class
