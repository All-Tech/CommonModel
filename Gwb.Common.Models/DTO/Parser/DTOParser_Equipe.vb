 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_Equipe
Inherits DTOParser
	Private  Num_EquipeID As Integer
	Private  Num_SiteOperationID As Integer
	Private  Num_TypeEquipeID As Integer
	Private  Num_Code As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_EquipeID = reader.GetOrdinal("EquipeID")
		Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
		Num_TypeEquipeID = reader.GetOrdinal("TypeEquipeID")
		Num_Code = reader.GetOrdinal("Code")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim equipe As New Equipe()
		 If Not reader.IsDBNull("EquipeID") Then equipe.EquipeID=reader.GetValue(Num_EquipeID)
		 If Not reader.IsDBNull("SiteOperationID") Then equipe.SiteOperationID=reader.GetValue(Num_SiteOperationID)
		 If Not reader.IsDBNull("TypeEquipeID") Then equipe.TypeEquipeID=reader.GetValue(Num_TypeEquipeID)
		 If Not reader.IsDBNull("Code") Then equipe.Code=reader.GetValue(Num_Code)
		 If Not reader.IsDBNull("Libelle") Then equipe.Libelle=reader.GetValue(Num_Libelle)
		Return equipe
	End Function
End Class
