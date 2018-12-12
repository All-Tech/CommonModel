 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TypeMateriel
Inherits DTOParser
	Private  Num_TypeMaterielID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TypeMaterielID = reader.GetOrdinal("TypeMaterielID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim typemateriel As New TypeMateriel()
		 If Not reader.IsDBNull("TypeMaterielID") Then typemateriel.TypeMaterielID=reader.GetValue(Num_TypeMaterielID)
		 If Not reader.IsDBNull("Libelle") Then typemateriel.Libelle=reader.GetValue(Num_Libelle)
		Return typemateriel
	End Function
End Class
