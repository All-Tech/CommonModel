Imports Gwb.Common.Models.CommonBase

Public NotInheritable Class DTOParserFactory

    Private Sub New()

    End Sub

    Friend Shared Function GetParser(ByVal DTOType As System.Type) As DTOParser
        Select Case DTOType.Name
            Case "Groupe"
                Return New DTO.DTOParser_Groupe()
            Case "PostDTO"
               'Return New DTOParser_Post()
            Case "SiteProfileDTO"
                'Return New DTOParser_SiteProfile()
        End Select
        ' Si nous arrivons ici alors c'est que nous n'avons pas réussi à trouver le type correspondant. Nous levons donc Throw New Exception("Unknown Type")
        Throw New Exception("Unknown Type")
    End Function
End Class
