Public Class Kamar
    Inherits SQLControl
    Private _id As String
    Private _tipe As String
    Private _harga As Integer
    Private _jumlah As Integer
    Private _tersedia As Integer

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Tipe() As String
        Get
            Return _tipe
        End Get
        Set(value As String)
            _tipe = value
        End Set
    End Property

    Public Property Harga() As Integer
        Get
            Return _harga
        End Get
        Set(value As Integer)
            _harga = value
        End Set
    End Property

    Public Property Jumlah() As Integer
        Get
            Return _jumlah
        End Get
        Set(value As String)
            _jumlah = value
        End Set
    End Property

    Public Property Tersedia() As Integer
        Get
            Return _tersedia
        End Get
        Set(value As Integer)
            _tersedia = value
        End Set
    End Property
End Class
