Public Class frmPajak

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double

        If Not Double.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Masukkan angka pendapatan yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim pajak As Double = 0

        If pendapatan > 100000000 Then
            pajak = pendapatan * 0.3
        ElseIf pendapatan > 30000000 Then
            pajak = pendapatan * 0.2
        ElseIf pendapatan > 5000000 Then
            pajak = pendapatan * 0.1
        Else
            pajak = 0
        End If

        MessageBox.Show("Pajak yang perlu dibayarkan: Rp " & pajak.ToString("N0"), "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
