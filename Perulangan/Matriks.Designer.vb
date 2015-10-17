<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.matrik1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmb_operasi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.matrik2 = New System.Windows.Forms.TextBox()
        Me.hasil_matrix = New System.Windows.Forms.TextBox()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Matrik1"
        '
        'matrik1
        '
        Me.matrik1.Location = New System.Drawing.Point(61, 20)
        Me.matrik1.Multiline = True
        Me.matrik1.Name = "matrik1"
        Me.matrik1.Size = New System.Drawing.Size(368, 76)
        Me.matrik1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operasi"
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_operasi.FormattingEnabled = True
        Me.Cmb_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Cmb_operasi.Location = New System.Drawing.Point(61, 118)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(368, 21)
        Me.Cmb_operasi.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matrik 2"
        '
        'matrik2
        '
        Me.matrik2.Location = New System.Drawing.Point(61, 165)
        Me.matrik2.Multiline = True
        Me.matrik2.Name = "matrik2"
        Me.matrik2.Size = New System.Drawing.Size(368, 76)
        Me.matrik2.TabIndex = 5
        '
        'hasil_matrix
        '
        Me.hasil_matrix.Location = New System.Drawing.Point(61, 260)
        Me.hasil_matrix.Multiline = True
        Me.hasil_matrix.Name = "hasil_matrix"
        Me.hasil_matrix.Size = New System.Drawing.Size(368, 76)
        Me.hasil_matrix.TabIndex = 6
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 263)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 7
        Me.Lbl_hasil.Text = "Hasil"
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(307, 351)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(122, 23)
        Me.btn_proses.TabIndex = 8
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.hasil_matrix)
        Me.Controls.Add(Me.matrik2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.matrik1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents hasil_matrix As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents btn_proses As System.Windows.Forms.Button
End Class
