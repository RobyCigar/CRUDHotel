Public Class TambahKamarWindow
    Private SQL = New SQLControl()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = Me.ID.Text
        Dim tipe As String = Me.TipeKamar.Text
        Dim harga As Integer = Me.Harga.Value
        Dim tersedia As Integer = Me.Tersedia.Value
        Dim jumlah As Integer = Me.Jumlah.Value

        MsgBox("Yakin mau nambahin kamar ini? :|")

        Dim IsAdded As Boolean = SQL.TambahKamar(id, tipe, harga, tersedia, jumlah)

        If IsAdded Then
            MsgBox("Oke, Kamar Berhasil Ditambahkan :D")

            Dim Main = New KamarWindow()
            Me.Hide()
            Main.ShowDialog()
            Me.Close()
        Else
            MsgBox("Yh, Kamar Gagal Ditambahkan :(")
        End If
    End Sub

    ' cancel btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Main = New KamarWindow()
        Me.Hide()
        Main.ShowDialog()
        Me.Close()
    End Sub
End Class