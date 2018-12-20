Imports System.Data.Common
Imports Gwb.Common.Models.DTO
Imports Gwb.Common.Models.CommonBase
Public Class DTOParser_Societe
    Inherits DTOParser
    Private Num_SocieteID As Integer
    Private Num_SiegeID As Integer
    Private Num_Code As Integer
    Private Num_Libelle As Integer
    Private Num_Description As Integer
    Private Num_BoitePostale As Integer
    Private Num_Adresse As Integer
    Private Num_Ville As Integer
    Private Num_NatureActivite As Integer
    Private Num_Regime As Integer
    Private Num_Pw As Integer
    Private Num_Fsc As Integer
    Private Num_Tltv As Integer
    Private Num_NumIdentite As Integer
    Private Num_LDevise As Integer
    Private Num_Logo As Integer
    Private Num_DateCreation As Integer
    Private Num_NumeroCompte As Integer

    Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
        Num_SocieteID = reader.GetOrdinal("SocieteID")
        Num_SiegeID = reader.GetOrdinal("SiegeID")
        Num_Code = reader.GetOrdinal("Code")
        Num_Libelle = reader.GetOrdinal("Libelle")
        Num_Description = reader.GetOrdinal("Description")
        Num_BoitePostale = reader.GetOrdinal("BoitePostale")
        Num_Adresse = reader.GetOrdinal("Adresse")
        Num_Ville = reader.GetOrdinal("Ville")
        Num_NatureActivite = reader.GetOrdinal("NatureActivite")
        Num_Regime = reader.GetOrdinal("Regime")
        Num_Pw = reader.GetOrdinal("Pw")
        Num_Fsc = reader.GetOrdinal("Fsc")
        Num_Tltv = reader.GetOrdinal("Tltv")
        Num_NumIdentite = reader.GetOrdinal("NumIdentite")
        Num_LDevise = reader.GetOrdinal("LDevise")
        Num_Logo = reader.GetOrdinal("Logo")
        Num_DateCreation = reader.GetOrdinal("DateCreation")
        Num_NumeroCompte = reader.GetOrdinal("NumeroCompte")
    End Sub

    Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
        Dim societe As New Societe()
        If Not reader.IsDBNull("SocieteID") Then societe.SocieteID = reader.GetValue(Num_SocieteID)
        If Not reader.IsDBNull("SiegeID") Then societe.SiegeID = reader.GetValue(Num_SiegeID)
        If Not reader.IsDBNull("Code") Then societe.Code = reader.GetValue(Num_Code)
        If Not reader.IsDBNull("Libelle") Then societe.Libelle = reader.GetValue(Num_Libelle)
        If Not reader.IsDBNull("Description") Then societe.Description = reader.GetValue(Num_Description)
        If Not reader.IsDBNull("BoitePostale") Then societe.BoitePostale = reader.GetValue(Num_BoitePostale)
        If Not reader.IsDBNull("Adresse") Then societe.Adresse = reader.GetValue(Num_Adresse)
        If Not reader.IsDBNull("Ville") Then societe.Ville = reader.GetValue(Num_Ville)
        If Not reader.IsDBNull("NatureActivite") Then societe.NatureActivite = reader.GetValue(Num_NatureActivite)
        If Not reader.IsDBNull("Regime") Then societe.Regime = reader.GetValue(Num_Regime)
        If Not reader.IsDBNull("Pw") Then societe.Pw = reader.GetValue(Num_Pw)
        If Not reader.IsDBNull("Fsc") Then societe.Fsc = reader.GetValue(Num_Fsc)
        If Not reader.IsDBNull("Tltv") Then societe.Tltv = reader.GetValue(Num_Tltv)
        If Not reader.IsDBNull("NumIdentite") Then societe.NumIdentite = reader.GetValue(Num_NumIdentite)
        If Not reader.IsDBNull("LDevise") Then societe.LDevise = reader.GetValue(Num_LDevise)
        If Not reader.IsDBNull("Logo") Then societe.Logo = reader.GetValue(Num_Logo)
        If Not reader.IsDBNull("DateCreation") Then societe.DateCreation = reader.GetValue(Num_DateCreation)
        If Not reader.IsDBNull("NumeroCompte") Then societe.NumeroCompte = reader.GetValue(Num_NumeroCompte)
        If Not reader.IsDBNull(Num_SocieteID) Then societe.SocieteID = Convert.ToInt32(reader.GetValue(Num_SocieteID))
        If Not reader.IsDBNull(Num_SiegeID) Then societe.SiegeID = Convert.ToInt32(reader.GetValue(Num_SiegeID))
        If Not reader.IsDBNull(Num_Code) Then societe.Code = reader.GetString(Num_Code)
        If Not reader.IsDBNull(Num_Libelle) Then societe.Libelle = reader.GetString(Num_Libelle)
        If Not reader.IsDBNull(Num_Description) Then societe.Description = reader.GetString(Num_Description)
        If Not reader.IsDBNull(Num_Adresse) Then societe.Adresse = reader.GetString(Num_Adresse)
        If Not reader.IsDBNull(Num_Ville) Then societe.Ville = reader.GetString(Num_Ville)
        If Not reader.IsDBNull(Num_NatureActivite) Then societe.NatureActivite = reader.GetString(Num_NatureActivite)
        If Not reader.IsDBNull(Num_Regime) Then societe.Regime = reader.GetString(Num_Regime)
        If Not reader.IsDBNull(Num_Pw) Then societe.Pw = reader.GetString(Num_Pw)
        If Not reader.IsDBNull(Num_Fsc) Then societe.Fsc = reader.GetString(Num_Fsc)
        If Not reader.IsDBNull(Num_Tltv) Then societe.Tltv = reader.GetString(Num_Tltv)
        If Not reader.IsDBNull(Num_NumIdentite) Then societe.NumIdentite = reader.GetString(Num_NumIdentite)
        If Not reader.IsDBNull(Num_LDevise) Then societe.LDevise = reader.GetString(Num_LDevise)
        If Not reader.IsDBNull(Num_Logo) Then societe.Logo = System.Text.Encoding.Default.GetBytes(reader.GetString(Num_Logo))
        If Not reader.IsDBNull(Num_DateCreation) Then societe.DateCreation = reader.GetDateTime(Num_DateCreation)
        If Not reader.IsDBNull(Num_NumeroCompte) Then societe.NumeroCompte = reader.GetString(Num_NumeroCompte)
        Return societe
    End Function
End Class
