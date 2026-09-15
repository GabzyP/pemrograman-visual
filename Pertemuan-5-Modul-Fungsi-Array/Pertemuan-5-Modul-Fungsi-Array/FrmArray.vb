Imports System.Windows.Forms.VisualStyles

Public Class FrmArray

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        'MessageBox.Show(hitung(TxtPanjang.Text, TxtLebar.Text))

        'For i As Integer = 0 To nilai.Length - 1
        'lstNilai.Items.Add(nilai(i))
        'Next

        MessageBox.Show(nilai2D(2, 1).ToString)
    End Sub


    Private Sub TxtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPanjang.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLebar.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class
