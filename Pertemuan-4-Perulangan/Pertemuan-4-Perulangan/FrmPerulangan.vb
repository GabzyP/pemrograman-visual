Public Class FrmPerulangan
    Private Sub LblNilaiAwal_Click(sender As Object, e As EventArgs) Handles lblNilaiAwal.Click

    End Sub
    Private Sub lblNilaiAkhir_Click(sender As Object, e As EventArgs) Handles lblNilaiAkhir.Click

    End Sub

    Private Sub txtNilaiAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAwal.KeyPress

    End Sub

    Private Sub txtNilaiAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAkhir.KeyPress

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiAwal As Integer
        Dim nilaiAkhir As Integer

        If Not Integer.TryParse(txtNilaiAwal.Text, nilaiAwal) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilaiAwal.Focus()
            Return
        End If

        If Not Integer.TryParse(txtNilaiAkhir.Text, nilaiAkhir) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilaiAkhir.Focus()
            Return
        End If

        lstHasil.Items.Clear()

        For i As Integer = nilaiAwal To nilaiAkhir
            lstHasil.Items.Add(i)
        Next
    End Sub

End Class
