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

    Private Sub SetUserPropertiesWithDataGrid(ByRef currentKamar As Kamar)
        With currentKamar
            .ID = DataGridView1.SelectedRows.Item(0).Cells(0).Value
            .tipe = DataGridView1.SelectedRows.Item(0).Cells(1).Value
            .tersedia = DataGridView1.SelectedRows.Item(0).Cells(2).Value
            .jumlah = DataGridView1.SelectedRows.Item(0).Cells(3).Value
            .harga = DataGridView1.SelectedRows.Item(0).Cells(4).Value
        End With
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Close()
        TambahKamarWindow.ShowDialog()
    End Sub
End Class
