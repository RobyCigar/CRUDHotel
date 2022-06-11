Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SQLControl
    Private SQLCON As New SqlConnection("Data Source=DESKTOP-CRJUE62\SQLEXPRESS;Initial Catalog=CRUDHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private SQLCMD As SqlCommand
    Private SQLDA As SqlDataAdapter
    Private SQLDS As DataSet
    Private myReader As SqlDataReader
    Private results As String

    Public SQLCheckConstraint As String

    Public Function IsAuthenticated(username As String, password As String) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(New SqlParameter("@username", username))
                .Parameters.Add(New SqlParameter("@password", password))
                .CommandText = "ValidateUserCredentials"
            End With

            SQLDA.Fill(SQLDS)
            Return SQLDS.Tables(0).Rows.Count() > 0
        Catch ex As Exception
            SetCheckConstraint(ex)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Public Function GetAllKamar() As DataTable
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand
            SQLDA = New SqlDataAdapter(SQLCMD)
            SQLDS = New DataSet()
            SQLCMD.CommandType = CommandType.StoredProcedure
            SQLCMD.CommandText = "GetAllKamar"
            SQLDA.Fill(SQLDS)
            Return SQLDS.Tables.Item(0)
        Catch ex As Exception
            SetCheckConstraint(ex)
            Return Nothing
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Public Function TambahKamar(id As String, tipe As String, harga As Integer, tersedia As Integer, jumlah As Integer) As Boolean
        Try
            SQLCON.Open()
            SQLCMD = SQLCON.CreateCommand

            With SQLCMD
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add(New SqlParameter("@id", id))
                    .Add(New SqlParameter("@tipe", tipe))
                    .Add(New SqlParameter("@harga", harga))
                    .Add(New SqlParameter("@tersedia", tersedia))
                    .Add(New SqlParameter("@jumlah", jumlah))
                End With
                .CommandText = "StoreKamar"
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            SetCheckConstraint(ex)
            Return False
        Finally
            If SQLCON.State = ConnectionState.Open Then SQLCON.Close()
        End Try
    End Function

    Private Sub SetCheckConstraint(ex As Exception)
        Const regexPattern As String = ".*(CHK_[A-z!]{1,}).*"
        Dim regex As Regex = New Regex(regexPattern)
        Dim exMessage As String : exMessage = Replace(ex.Message, vbLf, vbNullString)
        SQLCheckConstraint = IIf(regex.Replace(exMessage, "$1") = vbNullString, ex.Message, regex.Replace(exMessage, "$1"))
    End Sub
End Class
