Public Class Bintang
    Dim hasil As String = ""

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Try
            Select Case pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(isi_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(isi_baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(isi_baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(isi_baris.Text))
                Case Else
                    hasil_pola.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            hasil_pola.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid(batas As Integer)
        Dim batas1 As Integer = batas
        Dim batas2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batas1 Or kolom > batas2) Then
                    Me.hasil &= " 0 "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batas1 -= 1
            batas2 += 1
            Me.hasil &= vbCrLf
        Next
        hasil_pola.Text = hasil
        hasil = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim batas1 As Integer = batas
        Dim batas2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batas1 Or kolom = batas2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batas1 -= 1
            batas2 += 1
            Me.hasil &= vbCrLf
        Next
        hasil_pola.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(batas As Integer)
        Dim batas1 As Integer = 0
        Dim batas2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batas1 And kolom < batas2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batas1 += 1
            batas2 -= 1
        Next
        hasil_pola.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim batas1 As Integer = 1
        Dim batas2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batas1 Or kolom = batas2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batas1 += 1
            batas2 -= 1
            Me.hasil &= vbCrLf
        Next
        hasil_pola.Text = hasil
        Me.hasil = ""
    End Sub


End Class