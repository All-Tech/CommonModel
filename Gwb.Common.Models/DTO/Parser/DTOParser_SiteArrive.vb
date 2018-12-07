Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase
Imports Gwb.Common.Models.DTO

Public Class DTOParser_SiteArrive
    Inherits DTOParser

    Private Num_SiteArriveID As Integer
    Private Num_PaysID As Integer
    Private Num_NatureSiteID As Integer
    Private Num_PortID As Integer
    Private Num_SocieteID As Integer
    Private Num_CodePort As Integer
    Private Num_Libelle As Integer
    Private Num_Adresse As Integer
    Private Num_Aactif As Integer
    Private Num_Phyto As Integer
    Private Num_Co As Integer
    Private Num_Eur1 As Integer

    Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
        Num_SiteArriveID = reader.GetOrdinal("SiteArriveID")
        Num_PaysID = reader.GetOrdinal("PaysID")
        Num_NatureSiteID = reader.GetOrdinal("NatureSiteID")
        Num_PortID = reader.GetOrdinal("PortID")
        Num_SocieteID = reader.GetOrdinal("SocieteID")
        Num_CodePort = reader.GetOrdinal("CodePort")
        Num_Libelle = reader.GetOrdinal("Libelle")
        Num_Adresse = reader.GetOrdinal("Adresse")
        Num_Aactif = reader.GetOrdinal("Aactif")
        Num_Phyto = reader.GetOrdinal("Phyto")
        Num_Co = reader.GetOrdinal("Co")
        Num_Eur1 = reader.GetOrdinal("Eur1")
    End Sub

    Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
        Dim siteArrive As New SiteArrive()
        If Not reader.IsDBNull(Num_SiteArriveID) Then siteArrive.SiteArriveID = Convert.ToInt32(reader.GetValue(Num_SiteArriveID))
        If Not reader.IsDBNull(Num_PaysID) Then siteArrive.PaysID = Convert.ToInt32(reader.GetValue(Num_PaysID))
        If Not reader.IsDBNull(Num_NatureSiteID) Then siteArrive.NatureSiteID = Convert.ToInt32(reader.GetValue(Num_NatureSiteID))
        If Not reader.IsDBNull(Num_PortID) Then siteArrive.PortID = Convert.ToInt32(reader.GetValue(Num_PortID))
        If Not reader.IsDBNull(Num_SocieteID) Then siteArrive.SocieteID = Convert.ToInt32(reader.GetValue(Num_SocieteID))
        If Not reader.IsDBNull(Num_CodePort) Then siteArrive.CodePort = reader.GetString(Num_CodePort)
        If Not reader.IsDBNull(Num_Libelle) Then siteArrive.Libelle = reader.GetString(Num_Libelle)
        If Not reader.IsDBNull(Num_Adresse) Then siteArrive.Adresse = reader.GetString(Num_Adresse)
        If Not reader.IsDBNull(Num_Aactif) Then siteArrive.Aactif = reader.GetString(Num_Aactif)
        If Not reader.IsDBNull(Num_Phyto) Then siteArrive.Phyto = reader.GetString(Num_Phyto)
        If Not reader.IsDBNull(Num_Co) Then siteArrive.Co = reader.GetString(Num_Co)
        If Not reader.IsDBNull(Num_Eur1) Then siteArrive.Eur1 = reader.GetString(Num_Eur1)
        Return siteArrive
    End Function
End Class
