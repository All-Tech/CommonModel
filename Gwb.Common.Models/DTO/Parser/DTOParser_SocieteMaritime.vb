Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase
Namespace DTO
    Public Class DTOParser_SocieteMaritime
        Inherits DTOParser

        Private Num_SocieteMaritimeID As Integer
        Private Num_SocieteID As Integer
        Private Num_NomService As Integer
        Private Num_ServiceContrat As Integer
        Private Num_Mention As Integer
        Private Num_DelaisAttenteAccostage As Integer

        Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
            Num_SocieteMaritimeID = reader.GetOrdinal("SocieteMaritimeID")
            Num_SocieteID = reader.GetOrdinal("SocieteID")
            Num_NomService = reader.GetOrdinal("NomService")
            Num_ServiceContrat = reader.GetOrdinal("ServiceContrat")
            Num_Mention = reader.GetOrdinal("Mention")
            Num_DelaisAttenteAccostage = reader.GetOrdinal("DelaisAttenteAccostage")
        End Sub

        Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
            Dim SocieteM As New SocieteMaritime()
            If Not reader.IsDBNull(Num_SocieteMaritimeID) Then SocieteM.SocieteMaritimeID = Convert.ToInt32(reader.GetValue(Num_SocieteMaritimeID))
            If Not reader.IsDBNull(Num_SocieteID) Then SocieteM.SocieteID = Convert.ToInt32(reader.GetValue(Num_SocieteID))
            If Not reader.IsDBNull(Num_NomService) Then SocieteM.NomService = reader.GetString(Num_NomService)
            If Not reader.IsDBNull(Num_ServiceContrat) Then SocieteM.ServiceContrat = reader.GetString(Num_ServiceContrat)
            If Not reader.IsDBNull(Num_Mention) Then SocieteM.Mention = reader.GetString(Num_Mention)
            If Not reader.IsDBNull(Num_DelaisAttenteAccostage) Then SocieteM.DelaisAttenteAccostage = reader.GetString(Num_DelaisAttenteAccostage)
            Return SocieteM
        End Function
    End Class
End Namespace
