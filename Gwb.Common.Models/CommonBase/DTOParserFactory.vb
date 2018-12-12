Imports Gwb.Common.Models.CommonBase

Public NotInheritable Class DTOParserFactory

    Private Sub New()

    End Sub

    Public Shared Function GetParser(ByVal DTOType As System.Type) As DTOParser
        Select Case DTOType.Name
            Case "Groupe"
                Return New DTOParser_Groupe()
            Case "PostDTO"
               'Return New DTOParser_Post()
            Case "SiteProfileDTO"
                'Return New DTOParser_SiteProfile()
            Case "Siege"
                Return New DTOParser_Siege()
            Case "CategorieEssence"
                Return New DTOParser_CategorieEssence()
            Case "SiteOperation"
                Return New DTOParser_SiteOperation()
            Case "ClasseEssence"
                Return New DTOParser_ClasseEssence()
            Case "Comptabilite"
                Return New DTOParser_Comptabilite()
            Case "ConteneurOrigine"
                Return New DTOParser_ConteneurOrigine()
            Case "DensiteBois"
                Return New DTOParser_DensiteBois()
            Case "Equipe"
                Return New DTOParser_Equipe()
            Case "Essence"
                Return New DTOParser_Essence()
            Case "Famille"
                Return New DTOParser_Famille()
            Case "Fournisseur"
                Return New DTOParser_Fournisseur()
            Case "Groupe"
                Return New DTOParser_Groupe()
            Case "LieuTransit"
                Return New DTOParser_LieuTransit()
            Case "LoadingNavire"
                Return New DTOParser_LoadingNavire()
            Case "Materiel"
                Return New DTOParser_Materiel()
            Case "ModeTransport"
                Return New DTOParser_ModeTransport()
            Case "Modules"
                Return New DTOParser_Modules()
            Case "MoyenTransport"
                Return New DTOParser_MoyenTransport()
            Case "NatureConteneur"
                Return New DTOParser_NatureConteneur()
            Case "NatureMouvement"
                Return New DTOParser_NatureMouvement()
            Case "NatureParc"
                Return New DTOParser_NatureParc()
            Case "NaturePort"
                Return New DTOParser_NaturePort()
            Case "NatureSite"
                Return New DTOParser_NatureSite()
            Case "Parc"
                Return New DTOParser_Parc()
            Case "Pays"
                Return New DTOParser_Pays()
            Case "PileGrume"
                Return New DTOParser_PileGrume()
            Case "Port"
                Return New DTOParser_Port()
            Case "Produit"
                Return New DTOParser_Produit()
            Case "Profil"
                Return New DTOParser_Profil()
            Case "ProfilAutorise"
                Return New DTOParser_ProfilAutorise()
            Case "QualiteIHC"
                Return New DTOParser_QualiteIHC()
            Case "Rotation"
                Return New DTOParser_Rotation()
            Case "Scies"
                Return New DTOParser_Scies()
            Case "Sechoir"
                Return New DTOParser_Sechoir()
            Case "Siege"
                Return New DTOParser_Siege()
            Case "SiteOperation"
                Return New DTOParser_SiteOperation()
            Case "Societe"
                Return New DTOParser_Societe()
            Case "TarifIHC"
                Return New DTOParser_TarifIHC()
            Case "SousFamille"
                Return New DTOParser_SousFamille()
            Case "SiteOperation"
                Return New DTOParser_SiteOperation()
            Case "SousFamille"
                Return New DTOParser_SousFamille()
            Case "TrancheHoraire"
                Return New DTOParser_TrancheHoraire()
            Case "Transitaire"
                Return New DTOParser_Transitaire()
            Case "Transporteur"
                Return New DTOParser_Transporteur()
            Case "TypeClient"
                Return New DTOParser_TypeClient()
            Case "TypeEquipe"
                Return New DTOParser_TypeEquipe()
            Case "TypeFournisseur"
                Return New DTOParser_TypeFournisseur()
            Case "TypeMateriel"
                Return New DTOParser_TypeMateriel()
            Case "TypeOperateur"
                Return New DTOParser_TypeOperateur()
        End Select
        ' Si nous arrivons ici alors c'est que nous n'avons pas réussi à trouver le type correspondant. Nous levons donc Throw New Exception("Unknown Type")
        Throw New Exception("Unknown Type")
    End Function
End Class
