Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Text
Imports Gwb.Common.Models
Imports Gwb.Common.Models.CommonBase
Imports Gwb.Common.Models.DTO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Moq

<TestClass()> Public Class DTOParserTest

    <TestInitialize()>
    Public Sub Initialize()
        Dim valeur = Nothing

    End Sub
    <TestMethod()>
    Public Sub TestMethodDTOGroupe()
        'Dim moq = New Mock(Of IDataReader)()
        'moq.Setup(Function(x) x.Read()).Returns(True)
        'moq.Setup(Function(x) x.Read()).Returns(False)
        'moq.SetupGet(Of Object)(Function(x) x("String")).Returns("DZ")

        'Dim groupe As Groupe
        'Dim reader As SqlDataReader
        'Dim parser As DTOParser = DTOParserFactory.GetParser(GetType(Groupe))
        'parser.PopulateOrdinals(DirectCast(moq.Object, DbDataReader))
        'Dim groupes As Groupe = parser.PopulateDTO(moq.Object)
        'Assert.IsNotNull(groupes)
    End Sub

    Private Function TestDataGroupe() As List(Of Groupe)
        Dim liste = New List(Of Groupe) From {New Groupe With {.GroupeID = 1, .Code = "DZ", .Libelle = "Danzer", .Ville = "Houston", .IsNew = True}}
        Return liste
    End Function
End Class



