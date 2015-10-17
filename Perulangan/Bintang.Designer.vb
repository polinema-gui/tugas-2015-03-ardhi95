<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.isi_baris = New System.Windows.Forms.TextBox()
        Me.proses = New System.Windows.Forms.Button()
        Me.hasil_pola = New System.Windows.Forms.TextBox()
        Me.pola = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pola :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baris :"
        '
        'isi_baris
        '
        Me.isi_baris.Location = New System.Drawing.Point(53, 62)
        Me.isi_baris.Name = "isi_baris"
        Me.isi_baris.Size = New System.Drawing.Size(266, 20)
        Me.isi_baris.TabIndex = 3
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(325, 60)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(114, 23)
        Me.proses.TabIndex = 4
        Me.proses.Text = "Proses"
        Me.proses.UseVisualStyleBackColor = True
        '
        'hasil_pola
        '
        Me.hasil_pola.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasil_pola.Location = New System.Drawing.Point(16, 108)
        Me.hasil_pola.Multiline = True
        Me.hasil_pola.Name = "hasil_pola"
        Me.hasil_pola.Size = New System.Drawing.Size(423, 305)
        Me.hasil_pola.TabIndex = 5
        '
        'pola
        '
        Me.pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pola.FormattingEnabled = True
        Me.pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.pola.Location = New System.Drawing.Point(53, 11)
        Me.pola.Name = "pola"
        Me.pola.Size = New System.Drawing.Size(386, 21)
        Me.pola.TabIndex = 2
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.pola)
        Me.Controls.Add(Me.hasil_pola)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.isi_baris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents isi_baris As System.Windows.Forms.TextBox
    Friend WithEvents proses As System.Windows.Forms.Button
    Friend WithEvents hasil_pola As System.Windows.Forms.TextBox
    Friend WithEvents pola As System.Windows.Forms.ComboBox
End Class
