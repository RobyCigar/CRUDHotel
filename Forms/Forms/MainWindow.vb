Public Class MainWindow
    Private SQL = New SQLControl()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        BindGrid()
    End Sub

    Private Sub BindGrid()
        DataGridView1.DataSource = SQL.GetAllKamar()
    End Sub

    Private Sub MaterialTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InputWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
