Public Class NavigationWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MenuKamar.Click
        Dim KamarWin = New KamarWindow()
        Me.Hide()
        KamarWin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UserWin = New UserWindow()
        Me.Hide()
        UserWin.ShowDialog()
        Me.Close()
    End Sub
End Class