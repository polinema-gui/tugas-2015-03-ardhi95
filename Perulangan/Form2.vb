Public Class Form2
    Dim hasil As String = ""
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(isi_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(isi_baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(isi_baris))
                Case "Hollow Inverted Pyramid"
                    hoolowInvertedPyramid(Convert.ToInt32(isi_baris))
                Case Else
                    hasil_bintang.Text = "Pilih Pola dahulu."
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class