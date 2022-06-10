Public Class User

    Inherits SQLControl

    Private _username As String
    Private _password As String

    Public Property UserName() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Function Login() As Boolean
        Return IsAuthenticated(_username, _password)
    End Function

End Class

