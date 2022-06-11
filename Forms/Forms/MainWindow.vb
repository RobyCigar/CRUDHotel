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

    ' Menampilkan halaman edit
    Private Sub DisplayEditModeForm()

        If Me.DataGridView1.SelectedRows.Count = 1 Then
            Dim editKamar As New Kamar
            SetUserPropertiesWithDataGrid(editKamar)
            Dim EditForm As New EditKamarWindow(editKamar)

            EditForm.ShowDialog()
        Else
            MsgBox("Pilih data yg mau di edit")
        End If
    End Sub

    Private Sub SetUserPropertiesWithDataGrid(ByRef currentKamar As Kamar)
        With currentKamar
            .ID = DataGridView1.SelectedRows.Item(0).Cells(0).Value
            .Tipe = DataGridView1.SelectedRows.Item(0).Cells(1).Value
            .Tersedia = DataGridView1.SelectedRows.Item(0).Cells(2).Value
            .Jumlah = DataGridView1.SelectedRows.Item(0).Cells(3).Value
            .Harga = DataGridView1.SelectedRows.Item(0).Cells(4).Value
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Close()
        TambahKamarWindow.ShowDialog()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Trigger edit btn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayEditModeForm()
    End Sub
End Class
