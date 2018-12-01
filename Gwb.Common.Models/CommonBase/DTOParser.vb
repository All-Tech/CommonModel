Imports System.Data.Common
Namespace CommonBase
    Public MustInherit Class DTOParser
        Public MustOverride Sub PopulateOrdinals(ByVal reader As DbDataReader)
        Public MustOverride Function PopulateDTO(ByVal reader As DbDataReader) As DTOBase
    End Class
End Namespace

