Public Class TambahUserWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserWindow = New UserWindow()
        Me.Hide()
        UserWindow.ShowDialog()
        Me.Close()
    End Sub
End Class