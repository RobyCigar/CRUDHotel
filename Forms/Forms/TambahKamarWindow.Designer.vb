<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahKamarWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tersedia = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Jumlah = New System.Windows.Forms.NumericUpDown()
        Me.TipeKamar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Harga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tersedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Harga)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tersedia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Jumlah)
        Me.GroupBox1.Controls.Add(Me.TipeKamar)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 335)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Harga(per malam)"
        '
        'Harga
        '
        Me.Harga.Location = New System.Drawing.Point(82, 203)
        Me.Harga.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(128, 20)
        Me.Harga.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tersedia"
        '
        'Tersedia
        '
        Me.Tersedia.Location = New System.Drawing.Point(324, 139)
        Me.Tersedia.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.Tersedia.Name = "Tersedia"
        Me.Tersedia.Size = New System.Drawing.Size(128, 20)
        Me.Tersedia.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah Kamar"
        '
        'Jumlah
        '
        Me.Jumlah.Location = New System.Drawing.Point(324, 86)
        Me.Jumlah.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(128, 20)
        Me.Jumlah.TabIndex = 9
        '
        'TipeKamar
        '
        Me.TipeKamar.Location = New System.Drawing.Point(82, 139)
        Me.TipeKamar.Multiline = True
        Me.TipeKamar.Name = "TipeKamar"
        Me.TipeKamar.Size = New System.Drawing.Size(177, 26)
        Me.TipeKamar.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 33)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipe Kamar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Kamar"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(82, 85)
        Me.ID.Multiline = True
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(177, 21)
        Me.ID.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(82, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TambahKamarWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TambahKamarWindow"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Harga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tersedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipeKamar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tersedia As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Jumlah As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Harga As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
