<<<<<<< HEAD
Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Imports Gwb.Common.Models.CommonBase
Imports Gwb.Common.Models.DTO

Public Class DTOParser_SousFamille
    Inherits DTOParser
    Private Num_SousFamilleID As Integer
    Private Num_FamilleID As Integer
    Private Num_Code As Integer
    Private Num_Libelle As Integer


    Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
        Num_SousFamilleID = reader.GetOrdinal("SousFamilleID")
        Num_FamilleID = reader.GetOrdinal("FamilleID")
        Num_Code = reader.GetOrdinal("Code")
        Num_Libelle = reader.GetOrdinal("Libelle")
    End Sub

    Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
        Dim sousfamille As New SousFamille()
        If Not reader.IsDBNull("SousFamilleID") Then sousfamille.SousFamilleID = reader.GetValue(Num_SousFamilleID)
        If Not reader.IsDBNull("FamilleID") Then sousfamille.FamilleID = reader.GetValue(Num_FamilleID)
        If Not reader.IsDBNull("Code") Then sousfamille.Code = reader.GetValue(Num_Code)
        If Not reader.IsDBNull("Libelle") Then sousfamille.Libelle = reader.GetValue(Num_Libelle)
        Return sousfamille
    End Function
End Class
=======
﻿Imports System.Data.Common
Imports Gwb.Common.Models.CommonBase

Namespace DTO
    Public Class DTOParser_SousFamille
        Inherits DTOParser

        Public Overrides Sub PopulateOrdinals(reader As DbDataReader)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Function PopulateDTO(reader As DbDataReader) As DTOBase
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
>>>>>>> f58ea71d3efafed6d8090d4d4c3ce604cf9c73ea
