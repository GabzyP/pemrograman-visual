Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.SelectedIndex = 0
    End Sub

    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged
        Select Case cboRole.SelectedItem.ToString()
            Case "Staff"
                picProfile.Image = Image.FromFile("Assets\staff.png")
            Case "Manager"
                picProfile.Image = Image.FromFile("Assets\manager.png")
        End Select
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtNama.Text.Trim() = "" OrElse txtNIM.Text.Trim() = "" Then
            MessageBox.Show("Nama dan NIM wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim formPajak As New frmPajak()
        formPajak.Text = "Kalkulator Pajak" & cboRole.SelectedItem.ToString() & " (" & txtNama.Text & ")"
        formPajak.Show()
        Me.Hide()
    End Sub

End Class
