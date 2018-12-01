Imports System.Data.Common

Namespace CommonBase
    Public MustInherit Class DTOBase
        Private _IsNew As Boolean
        Public Property IsNew() As Boolean
            Get
                Return _IsNew
            End Get
            Set
                _IsNew = Value
            End Set
        End Property
    End Class
End Namespace

