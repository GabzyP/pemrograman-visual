Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0
    End Sub
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Select Case cmbRole.SelectedItem.ToString()
            Case "Staff"
                picImage.Image = Image.FromFile("Assets\staff.png")
            Case "Manager"
                picImage.Image = Image.FromFile("Assets\manager.png")
        End Select
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()
        If nama = "" Then
            MessageBox.Show("Nama wajib diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If
        If nim = "" Then
            MessageBox.Show("NIM wajib diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If
        If (role = "Staff" AndAlso nama = "Nadya" AndAlso nim = "241712051") OrElse
           (role = "Manager" AndAlso nama = "Shata Diyaul Haq" AndAlso nim = "241712061") Then
            Dim formPajak As New FrmPajak()
            formPajak.Text = "Kalkulator Pajak " & role & " (" & nama & ")"
            formPajak.Show()
            Me.Hide()
            txtNama.Clear()
            txtNIM.Clear()
        Else
            MessageBox.Show("Nama, NIM, atau Role tidak sesuai!",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            txtNIM.Focus()
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso
           Not Char.IsWhiteSpace(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
