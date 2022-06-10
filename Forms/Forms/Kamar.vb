Public Class Kamar
    Inherits SQLControl
    Private _id As String
    Private _jenis As String
    Private _dipesan As Boolean

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Jenis() As String
        Get
            Return _jenis
        End Get
        Set(value As String)
            _jenis = value
        End Set
    End Property

    Public Property Dipesan() As Boolean
        Get
            Return _dipesan
        End Get
        Set(value As Boolean)
            _dipesan = value
        End Set
    End Property
End Class
