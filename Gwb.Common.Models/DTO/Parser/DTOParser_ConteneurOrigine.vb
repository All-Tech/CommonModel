Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase
Imports Gwb.Common.Models.DTO

Public Class  DTOParser_ConteneurOrigine
Inherits DTOParser
	Private  Num_ContenaireOrigineID As Integer
	Private  Num_Libelle As Integer


	Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
		Num_ContenaireOrigineID = reader.GetOrdinal("ContenaireOrigineID")
		Num_Libelle = reader.GetOrdinal("Libelle")
	End Sub

Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
		Dim conteneurorigine As New ConteneurOrigine()
		 If Not reader.IsDBNull("ContenaireOrigineID") Then conteneurorigine.ContenaireOrigineID=reader.GetValue(Num_ContenaireOrigineID)
		 If Not reader.IsDBNull("Libelle") Then conteneurorigine.Libelle=reader.GetValue(Num_Libelle)
		Return conteneurorigine
	End Function
End Class
