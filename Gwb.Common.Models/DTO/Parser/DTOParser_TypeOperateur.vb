 Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase


Public Class  DTOParser_TypeOperateur
Inherits DTOParser
	Private  Num_TypeOperateurID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_TypeOperateurID = reader.GetOrdinal("TypeOperateurID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim typeoperateur As New TypeOperateur()
		 If Not reader.IsDBNull("TypeOperateurID") Then typeoperateur.TypeOperateurID=reader.GetValue(Num_TypeOperateurID)
		 If Not reader.IsDBNull("Libelle") Then typeoperateur.Libelle=reader.GetValue(Num_Libelle)
		Return typeoperateur
	End Function
End Class
