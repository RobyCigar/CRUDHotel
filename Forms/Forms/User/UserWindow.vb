Public Class UserWindow
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TambahUserWindow = New TambahUserWindow()
        Me.Hide()
        TambahUserWindow.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EditUserWindow = New EditUserWindow()
        Me.Hide()
        EditUserWindow.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim NavigationWindow = New NavigationWindow()
        Me.Hide()
        NavigationWindow.ShowDialog()
        Me.Close()
    End Sub
End Class