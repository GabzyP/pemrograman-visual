# Pembuatan Aplikasi Kalkulator Pajak Gabriel

## 1 Buat Project Baru

1. Buka Visual Studio → **Create a new project**
2. Pilih **Windows Forms App (.NET Framework)** → bahasa **Visual Basic**
3. Beri nama, `PajakGabriel`, lalu **Create**

---

## 2 Masukkan Profil 

1. Simpan 2 gambar `staff.png` dan `manager.png`
2. Add folder bernama `Assets`
3. Masukkan `staff.png` dan `manager.png` ke dalam folder `Assets`
4. Di **Solution Explorer**, klik masing-masing gambar → buka **Properties**
5. **Build Action** = `Content`
6. **Copy to Output Directory** = `Copy if newer`

---

## 3 Desain Form Login 

**1. Buka Toolbox**
tekan `Ctrl+Alt+X`

**2. Ganti nama Form1 jadi frmLogin**
- Klik area kosong form → tekan `F4` untuk buka **Properties**
- Cari properti **(Name)** di paling atas ganti dari `Form1` jadi `frmLogin`
- Cari properti **Text** → ganti jadi `Login`

**3. Tambah PictureBox (foto profil)**
- Di Toolbox, cari **PictureBox** → drag ke bagian atas form
- Klik PictureBox itu → di Properties, ganti **(Name)** jadi `picProfile`
- Set **SizeMode** = `Zoom` 
- Resize kotaknya 100x100

**4. Tambah Label "Role :"**
- Drag **Label** dari Toolbox, taruh di bawah PictureBox
- Ganti properti **Text** jadi `Role :`

**5. Tambah ComboBox untuk pilihan role**
- Drag **ComboBox**, taruh di sebelah/bawah label Role
- (Name) → ganti jadi `cboRole`
- **DropDownStyle** → ganti jadi `DropDownList`
- Isi pilihan: klik properti **Items** klik tombol `...` muncul String Collection Editor ketik:
  ```
  Staff
  Manager
  ```
  klik OK

**6. Tambah Label + TextBox "Nama"**
- Drag Label, Text-nya ganti `Nama :`
- Drag TextBox di sebelahnya, (Name) → `txtNama`

**7. Tambah Label + TextBox "NIM"**
- Drag Label, Text-nya ganti `NIM :`
- Drag TextBox di sebelahnya, (Name) → `txtNIM`

**8. Tambah Button Login**
- Drag **Button** dari Toolbox, taruh di bawah semua field
- (Name) → `btnLogin`
- **Text** → `Login`

---

## 4 Coding Form Login

Double-click form kosong untuk membuka code editor, lalu isi:

```vb
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
```

klik double pada `cboRole` di form designer supaya Visual Studio otomatis membuat event `SelectedIndexChanged`
---

## 5 Desain Form Kalkulator Pajak 

1. Klik kanan project → **Add** → **Windows Form** → beri nama `frmPajak`
2. Tambahkan kontrol:

| Kontrol | Name | Keterangan |
|---|---|---|
| Label | — | "Pendapatan lebih dari 5 juta, 10% Pajak" |
| Label | — | "Pendapatan lebih dari 30 juta, 20% Pajak" |
| Label | — | "Pendapatan lebih dari 100 juta, 30% Pajak" |
| Label | — | "Masukkan Pendapatan" |
| Label | — | "Rp." |
| TextBox | `txtPendapatan` | input angka pendapatan |
| Button | `btnHitung` | teks "Hitung" |

---

## 6 Coding Form Kalkulator Pajak

Double-click `btnHitung`, lalu isi:

```vb
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
```

---

## 7 Set Startup Form & Testing

1. Klik kanan project **Properties** tab **Application**
2. Pastikan **Startup form** = `frmLogin`
3. Tekan **F5** untuk menjalankan
4. Uji coba:
   - Pilih role Staff foto berubah ke `staff.png`
   - Pilih role Manager foto berubah ke `manager.png`
   - Isi Nama & NIM kosong klik Login harus muncul peringatan
   - Isi lengkap klik Login form Pajak terbuka, form Login tersembunyi
   - Coba input `5000000`, `10000000`, `50000000`, `150000000` untuk cek tiap bracket pajak

---
