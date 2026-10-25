Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Masukkan dalam bentuk peter")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Masukkan peter 0 - 100")
            txtNilai.Focus()
        End If

        If nilaiUjian <= 50 Then
            picImage.Image = Image.FromFile("Assets\1.jpg")

        ElseIf nilaiUjian <= 70 Then
            picImage.Image = Image.FromFile("Assets\2.jpg")

        ElseIf nilaiUjian > 90 Then
            picImage.Image = Image.FromFile("Assets\peter.jpg")

                End If

    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
