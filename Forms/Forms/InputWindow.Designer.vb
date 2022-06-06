<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(266, 322)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(158, 36)
        Me.MaterialButton1.TabIndex = 0
        Me.MaterialButton1.Text = "MaterialButton1"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialTextBox1
        '
        Me.MaterialTextBox1.AnimateReadOnly = False
        Me.MaterialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox1.Depth = 0
        Me.MaterialTextBox1.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox1.LeadingIcon = Nothing
        Me.MaterialTextBox1.Location = New System.Drawing.Point(53, 77)
        Me.MaterialTextBox1.MaxLength = 50
        Me.MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox1.Multiline = False
        Me.MaterialTextBox1.Name = "MaterialTextBox1"
        Me.MaterialTextBox1.Size = New System.Drawing.Size(238, 50)
        Me.MaterialTextBox1.TabIndex = 1
        Me.MaterialTextBox1.Text = ""
        Me.MaterialTextBox1.TrailingIcon = Nothing
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(50, 44)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(50, 153)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel2.TabIndex = 4
        Me.MaterialLabel2.Text = "MaterialLabel2"
        '
        'MaterialTextBox2
        '
        Me.MaterialTextBox2.AnimateReadOnly = False
        Me.MaterialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox2.Depth = 0
        Me.MaterialTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox2.LeadingIcon = Nothing
        Me.MaterialTextBox2.Location = New System.Drawing.Point(53, 186)
        Me.MaterialTextBox2.MaxLength = 50
        Me.MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox2.Multiline = False
        Me.MaterialTextBox2.Name = "MaterialTextBox2"
        Me.MaterialTextBox2.Size = New System.Drawing.Size(238, 50)
        Me.MaterialTextBox2.TabIndex = 3
        Me.MaterialTextBox2.Text = ""
        Me.MaterialTextBox2.TrailingIcon = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialTextBox2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialTextBox1)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
End Class
