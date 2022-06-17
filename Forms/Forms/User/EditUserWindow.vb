Public Class EditUserWindow
    Private UserWindow = New UserWindow()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        UserWindow.ShowDialog()
        Me.Close()
    End Sub
End Class