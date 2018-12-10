Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase

Namespace DTO
    Public Class DTOParser_Siege
        Inherits DTOParser

        Private Num_SiegeID As Integer
        Private Num_GroupeID As Integer
        Private Num_Code As Integer
        Private Num_Libelle As Integer
        Private Num_Adresse As Integer
        Private Num_Pays As Integer
        Private Num_Ville As Integer


        Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
            Num_SiegeID = reader.GetOrdinal("SiegeID")
            Num_GroupeID = reader.GetOrdinal("GroupeID")
            Num_Code = reader.GetOrdinal("Code")
            Num_Libelle = reader.GetOrdinal("Libelle")
            Num_Adresse = reader.GetOrdinal("Adresse")
            Num_Pays = reader.GetOrdinal("Pays")
            Num_Ville = reader.GetOrdinal("Ville")
        End Sub

        Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
            Dim siege As New Siege()
            If Not reader.IsDBNull(Num_SiegeID) Then siege.SiegeID = Convert.ToInt32(reader.GetValue(Num_SiegeID))
            If Not reader.IsDBNull(Num_GroupeID) Then siege.GroupeID = Convert.ToInt32(reader.GetValue(Num_GroupeID))
            If Not reader.IsDBNull(Num_Code) Then siege.Code = reader.GetString(Num_Code)
            If Not reader.IsDBNull(Num_Libelle) Then siege.Libelle = reader.GetString(Num_Libelle)
            If Not reader.IsDBNull(Num_Adresse) Then siege.Adresse = reader.GetString(Num_Adresse)
            If Not reader.IsDBNull(Num_Pays) Then siege.Pays = reader.GetString(Num_Pays)
            If Not reader.IsDBNull(Num_Ville) Then siege.Ville = reader.GetString(Num_Ville)
            Return siege
        End Function
    End Class
End Namespace