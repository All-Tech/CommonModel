Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase

Public Class DTOParser_SiteOperation
    Inherits DTOParser

    Private Num_SiteOperationID As Integer
    Private Num_SiegeID As Integer
    Private Num_NatureSiteID As Integer
    Private Num_PaysID As Integer
    Private Num_AcconierID As Integer
    Private Num_Code As Integer
    Private Num_Libelle As Integer
    Private Num_Adresse As Integer
    Private Num_Activite As Integer
    Private Num_PostAff As Integer
    Private Num_Trajet As Integer

    Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
        Num_SiteOperationID = reader.GetOrdinal("SiteOperationID")
        Num_SiegeID = reader.GetOrdinal("SiegeID")
        Num_NatureSiteID = reader.GetOrdinal("NatureSiteID")
        Num_PaysID = reader.GetOrdinal("PaysID")
        Num_AcconierID = reader.GetOrdinal("AcconierID")
        Num_Code = reader.GetOrdinal("Code")
        Num_Libelle = reader.GetOrdinal("Libelle")
        Num_Adresse = reader.GetOrdinal("Adresse")
        Num_Activite = reader.GetOrdinal("Activite")
        Num_PostAff = reader.GetOrdinal("PostAff")
        Num_Trajet = reader.GetOrdinal("Trajet")
    End Sub

    Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
        Dim siteOperation As New SiteOperation()
        If Not reader.IsDBNull(Num_SiteOperationID) Then siteOperation.SiteOperationID = Convert.ToInt32(reader.GetValue(Num_SiteOperationID))
        If Not reader.IsDBNull(Num_SiegeID) Then siteOperation.SiegeID = Convert.ToInt32(reader.GetValue(Num_SiegeID))
        If Not reader.IsDBNull(Num_NatureSiteID) Then siteOperation.NatureSiteID = Convert.ToInt32(reader.GetValue(Num_NatureSiteID))
        If Not reader.IsDBNull(Num_PaysID) Then siteOperation.PaysID = Convert.ToInt32(reader.GetValue(Num_PaysID))
        If Not reader.IsDBNull(Num_AcconierID) Then siteOperation.AcconierID = Convert.ToInt32(reader.GetValue(Num_AcconierID))
        If Not reader.IsDBNull(Num_Code) Then siteOperation.Code = reader.GetString(Num_Code)
        If Not reader.IsDBNull(Num_Libelle) Then siteOperation.Libelle = reader.GetString(Num_Libelle)
        If Not reader.IsDBNull(Num_Adresse) Then siteOperation.Adresse = reader.GetString(Num_Adresse)
        If Not reader.IsDBNull(Num_Activite) Then siteOperation.Activite = reader.GetString(Num_Activite)
        If Not reader.IsDBNull(Num_PostAff) Then siteOperation.PostAff = reader.GetString(Num_PostAff)
        If Not reader.IsDBNull(Num_Trajet) Then siteOperation.Trajet = reader.GetString(Num_Trajet)
        Return siteOperation
    End Function
End Class
