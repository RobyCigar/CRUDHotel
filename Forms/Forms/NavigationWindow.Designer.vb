<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NavigationWindow
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
        Me.MenuKamar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuKamar
        '
        Me.MenuKamar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuKamar.Location = New System.Drawing.Point(150, 143)
        Me.MenuKamar.Name = "MenuKamar"
        Me.MenuKamar.Size = New System.Drawing.Size(204, 151)
        Me.MenuKamar.TabIndex = 0
        Me.MenuKamar.Text = "Menu Kamar"
        Me.MenuKamar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navigasi"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(430, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 151)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Menu Pegawai"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NavigationWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuKamar)
        Me.Name = "NavigationWindow"
        Me.Text = "NavigationWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuKamar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
