Imports Gwb.Common.Models.CommonBase

Public Class Essence
	Inherits DTOBase

     #Region"Properties"
      Public Property EssenceID  As Integer
      Public Property ClasseEssenceID  As Integer?
      Public Property SocieteID  As Integer?
      Public Property CategorieEssenceID  As Integer?
      Public Property Libelle  As String
      Public Property NomScientifique  As String
      Public Property CodeMesurage  As String
      Public Property DiamExpeditionOfficielle  As Int16?
      Public Property MesurageAubier  As String
      Public Property NomSnt  As String
    Public Property CodeCubagePlein As String
    Public Property CodeActif As Boolean
    Public Property CodeCubageCom As String
    Public Property CodeStat  As String
      Public Property CodeCde  As String
      Public Property CodeIhc  As String
      Public Property Aupdate  As String
      Public Property RendementProduitRC  As Single
      Public Property EtatIc  As String
      Public Property RendementProduitRC1  As Single
      Public Property SeuilLongueurEntreeScie  As Single
      Public Property PrixFob  As Single
     #End Region


End Class