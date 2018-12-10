Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase

Namespace DTO
    Public Class DTOParser_SousFamille
        Inherits DTOParser

        Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
