Public Class EditKamarWindow
    Private SQL = New SQLControl()
    Private _editKamar As New Kamar

    Public Sub New(editKamar As Kamar)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _editKamar = editKamar
        PopulateFormFields()
    End Sub

    Private Sub PopulateFormFields()
        Me.ID.Text = _editKamar.ID
        Me.TipeKamar.Text = _editKamar.Tipe
        Me.Harga.Value = _editKamar.Harga
        Me.Jumlah.Value = _editKamar.Jumlah
        Me.Tersedia.Value = _editKamar.Tersedia

        With _editKamar
            .ID = Me.ID.Text
            .Tipe = Me.TipeKamar.Text
            .Harga = Me.Harga.Value
            .Jumlah = Me.Jumlah.Value
            .Tersedia = Me.Tersedia.Value
        End With
    End Sub

    Private Sub EditKamarWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id = Me.ID.Text
        Dim tipe = Me.TipeKamar.Text
        Dim harga = Me.Harga.Value
        Dim jumlah = Me.Jumlah.Value
        Dim tersedia = Me.Tersedia.Value

        MsgBox("Yakin mau ngedit kamar ini? :|")

        Dim IsEdited As Boolean = SQL.EditKamar(id, tipe, harga, tersedia, jumlah)

        If IsEdited Then
            MsgBox("Oke, Kamar Berhasil Diedit XD")

            Dim Main = New KamarWindow()
            Me.Hide()
            Main.ShowDialog()
            Me.Close()
        Else
            MsgBox("Yh, Kamar Gagal Diedit :(")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Keluar?", "Yakin mau keluar?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim Main = New KamarWindow()
            Me.Hide()
            Main.ShowDialog()
            Me.Close()
        End If

    End Sub
End Class