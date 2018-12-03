Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase

Namespace DTO
    Public Class DTOParser_Groupe
        Inherits DTOParser

        Private Num_GroupeID As Integer
        Private Num_Code As Integer
        Private Num_Libelle As Integer
        Private Num_Adresse As Integer
        Private Num_Ville As Integer

        Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
            Dim groupe As New Groupe()
            If Not reader.IsDBNull(Num_GroupeID) Then groupe.GroupeID = Convert.ToInt32(reader.GetValue(Num_GroupeID))
            If Not reader.IsDBNull(Num_Code) Then groupe.Code = reader.GetString(Num_Code)
            If Not reader.IsDBNull(Num_Libelle) Then groupe.Libelle = reader.GetString(Num_Libelle)
            If Not reader.IsDBNull(Num_Adresse) Then groupe.Adresse = reader.GetString(Num_Adresse)
            If Not reader.IsDBNull(Num_Ville) Then groupe.Ville = reader.GetString(Num_Ville)
            Return groupe
        End Function

        Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
            Num_GroupeID = reader.GetOrdinal("GroupeID")
            Num_Code = reader.GetOrdinal("Code")
            Num_Libelle = reader.GetOrdinal("Libelle")
            Num_Adresse = reader.GetOrdinal("Adresse")
            Num_Ville = reader.GetOrdinal("Ville")
        End Sub
    End Class
End Namespace

