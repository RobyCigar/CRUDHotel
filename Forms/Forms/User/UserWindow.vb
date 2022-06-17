Public Class UserWindow
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim TambahUserWin = New TambahUserWindow()
        Me.Hide()
        TambahUserWin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim EditUserWin = New EditUserWindow()
        Me.Hide()
        EditUserWin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class