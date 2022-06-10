Public Class LoginWindow
    Private SQL = New SQLControl()
    Private MainWindow = New MainWindow()

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim username As String = Me.TextBox1.Text
        Dim password As String = Me.TextBox2.Text

        If SQL.IsAuthenticated(username, password) Then
            Me.Hide()
            MainWindow.ShowDialog()
            Me.Close()
        Else
            MsgBox("Username atau password salah wkwk")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class