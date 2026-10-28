# Modul, Fungsi, dan Array

Hasil akhir praktik ini adalah satu form yang menerima Panjang dan Lebar, menghitung hasil melalui fungsi di Module, serta menampilkan isi Array satu dimensi dan dua dimensi.

| Bagian | Fungsi |
|---|---|
| FrmArray | Form utama praktik |
| TxtPanjang | Menerima nilai Panjang |
| TxtLebar | Menerima nilai Lebar |
| btnTampil | Memvalidasi input, memanggil fungsi, dan menampilkan data |
| lstNilai | Menampilkan hasil fungsi serta isi Array |
| ModArray | Menyimpan fungsi hitung dan dua Array |

## Langkah 0: Membuat proyek

1. Buka Visual Studio dan pilih **Create a new project**.
2. Cari template **Windows Forms App (.NET Framework)**, pilih bahasa **Visual Basic**, lalu pilih template tersebut.
3. Klik **Next**.
4. Beri nama proyek **Pertemuan-5-Modul-Fungsi-Array**, pilih lokasi penyimpanan, lalu klik **Create**.
5. Pilih **.NET Framework 4.8** atau versi .NET Framework yang tersedia.
6. Di Solution Explorer, klik kanan nama proyek, pilih **Add** > **Windows Form...**, lalu beri nama **FrmArray.vb**.
7. Buka **Project** > **Properties** > **Compile**, lalu atur **Option Strict** menjadi **On**.
8. Buka **Project** > **Properties** > **Application** dan pilih **FrmArray** sebagai **Startup form**.
9. Jika proyek juga membuat **Form1** bawaan dan form itu tidak dipakai, klik kanan Form1 di Solution Explorer lalu pilih **Remove**.

Jika template Windows Forms App (.NET Framework) tidak muncul, buka Visual Studio Installer dan pasang workload **.NET desktop development**.

## Praktik: Fungsi dan Array

### 1. Mengatur form

Buka **FrmArray.vb** di Designer. Klik area kosong pada form dan atur properti berikut melalui jendela Properties:

| Properti | Nilai |
|---|---|
| (Name) | FrmArray |
| Text | Fungsi dan Array |
| ClientSize | 800; 737 |
| StartPosition | CenterScreen |
| FormBorderStyle | FixedSingle |
| MaximizeBox | False |

Nama class di code-behind dan file Designer harus sama, yaitu **FrmArray**.

### 2. Menambahkan kontrol

Buka Toolbox melalui **View** > **Toolbox**. Tarik dua Label, dua TextBox, satu Button, dan satu ListBox ke form.

| Kontrol | (Name) | Text | Location contoh | Size contoh |
|---|---|---|---|---|
| Label | LblPanjang | Panjang : | 316; 158 | otomatis |
| TextBox | TxtPanjang | (kosong) | 316; 195 | 150; 31 |
| Label | LblLebar | Lebar : | 316; 305 | otomatis |
| TextBox | TxtLebar | (kosong) | 316; 342 | 150; 31 |
| Button | btnTampil | Tampilkan | 331; 446 | 112; 34 |
| ListBox | lstNilai | — | 299; 523 | 180; 129 |

Atur properti berikut:

| Kontrol | Properti | Nilai |
|---|---|---|
| TxtPanjang | Text | (kosong) |
| TxtLebar | Text | (kosong) |
| lstNilai | Sorted | False |

Properti **Text** adalah tulisan yang terlihat pada kontrol. Properti **(Name)** adalah nama yang dipakai oleh kode.

### 3. Membuat Module ModArray

Di Solution Explorer, klik kanan nama proyek, lalu pilih **Add** > **Module...**. Beri nama **ModArray.vb**, kemudian isi dengan kode berikut:

```vb
Option Strict On

Public Module ModArray

    Public Function Hitung(panjang As Integer,
                           lebar As Integer,
                           ByRef jenisPerhitungan As String) As Integer
        If panjang > 50 Then
            jenisPerhitungan = "Luas"
            Return panjang * lebar
        Else
            jenisPerhitungan = "Keliling"
            Return 2 * (panjang + lebar)
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90, 100}

    Public nilai2D(,) As Integer = {
        {55, 53, 65},
        {70, 72, 78},
        {80, 85, 90}
    }

End Module
```

Fungsi **Hitung** menerima Panjang dan Lebar, lalu mengembalikan Integer. Aturannya mengikuti ZIP:

- Jika Panjang lebih dari 50, jenis perhitungan diberi nilai **Luas** dan hasilnya Panjang × Lebar.
- Jika Panjang 50 atau kurang, jenis perhitungan diberi nilai **Keliling** dan hasilnya 2 × (Panjang + Lebar).

Array satu dimensi **nilai** berisi enam bilangan. Indeksnya dimulai dari 0:

| Indeks | Nilai |
|---:|---:|
| 0 | 50 |
| 1 | 60 |
| 2 | 70 |
| 3 | 80 |
| 4 | 90 |
| 5 | 100 |

Array dua dimensi **nilai2D** mempunyai 3 baris dan 3 kolom. Indeks baris dan kolom juga dimulai dari 0:

| Indeks baris | Kolom 0 | Kolom 1 | Kolom 2 |
|---:|---:|---:|---:|
| 0 | 55 | 53 | 65 |
| 1 | 70 | 72 | 78 |
| 2 | 80 | 85 | 90 |

Contohnya, **nilai2D(2, 1)** berarti baris indeks 2 dan kolom indeks 1, sehingga nilainya **85**.

### 4. Membuat event KeyPress untuk input angka

Pilih **TxtPanjang** di Designer, buka jendela Properties, klik ikon petir (**Events**), lalu double-click di samping event **KeyPress**. Visual Studio membuat prosedur event di **FrmArray.vb**.

Isi prosedur tersebut:

```vb
Private Sub TxtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPanjang.KeyPress
    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```

Ulangi langkah yang sama untuk **TxtLebar**, lalu gunakan kode berikut:

```vb
Private Sub TxtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLebar.KeyPress
    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```

Kode ini menolak huruf dan tanda baca saat diketik, tetapi mengizinkan tombol kontrol seperti Backspace. Pemeriksaan pada tombol tetap diperlukan karena teks dapat ditempel dari clipboard.

### 5. Membuat event tombol Tampilkan

Double-click **btnTampil** di Designer. Visual Studio membuat event Click. Ganti isi **FrmArray.vb** dengan versi lengkap berikut. Kode ini memvalidasi input, memanggil fungsi di Module, dan menampilkan kedua Array di ListBox.

```vb
Option Strict On

Public Class FrmArray

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Dim panjang As Integer
        Dim lebar As Integer

        If Not Integer.TryParse(TxtPanjang.Text.Trim(), panjang) Then
            MessageBox.Show("Masukkan Panjang sebagai bilangan bulat.")
            TxtPanjang.Focus()
            TxtPanjang.SelectAll()
            Return
        End If

        If Not Integer.TryParse(TxtLebar.Text.Trim(), lebar) Then
            MessageBox.Show("Masukkan Lebar sebagai bilangan bulat.")
            TxtLebar.Focus()
            TxtLebar.SelectAll()
            Return
        End If

        If panjang <= 0 OrElse lebar <= 0 Then
            MessageBox.Show("Panjang dan Lebar harus lebih besar dari 0.")
            If panjang <= 0 Then
                TxtPanjang.Focus()
                TxtPanjang.SelectAll()
            Else
                TxtLebar.Focus()
                TxtLebar.SelectAll()
            End If
            Return
        End If

        Dim jenisPerhitungan As String = ""
        Dim hasil As Integer = Hitung(panjang, lebar, jenisPerhitungan)

        lstNilai.Items.Clear()
        lstNilai.Items.Add("Perhitungan: " & jenisPerhitungan)
        lstNilai.Items.Add("Hasil: " & hasil.ToString())
        lstNilai.Items.Add("")
        lstNilai.Items.Add("Array satu dimensi:")

        For i As Integer = 0 To nilai.Length - 1
            lstNilai.Items.Add("nilai(" & i.ToString() & ") = " & nilai(i).ToString())
        Next

        lstNilai.Items.Add("")
        lstNilai.Items.Add("Array dua dimensi:")

        For baris As Integer = 0 To nilai2D.GetUpperBound(0)
            Dim isiBaris As String = ""
            For kolom As Integer = 0 To nilai2D.GetUpperBound(1)
                If kolom > 0 Then
                    isiBaris &= " | "
                End If
                isiBaris &= nilai2D(baris, kolom).ToString()
            Next
            lstNilai.Items.Add(isiBaris)
        Next

        MessageBox.Show("Jenis perhitungan: " & jenisPerhitungan & vbCrLf &
                        "Hasil: " & hasil.ToString())
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
```

Pastikan kode berada di **FrmArray.vb**, bukan **FrmArray.Designer.vb**. Jangan menempelkan prosedur event yang sama lebih dari sekali.

### 6. Menjalankan dan menguji

Simpan semua file. Tekan **F5** atau klik **Start** untuk membuka FrmArray.

| No. | Panjang | Lebar | Hasil yang diharapkan |
|---:|---:|---:|---|
| 1 | 60 | 4 | Jenis perhitungan Luas, hasil 240 |
| 2 | 50 | 4 | Jenis perhitungan Keliling, hasil 108 |
| 3 | 20 | 5 | Jenis perhitungan Keliling, hasil 50 |
| 4 | 0 | 5 | Pesan bahwa Panjang dan Lebar harus lebih besar dari 0 |
| 5 | 5 | 0 | Pesan bahwa Panjang dan Lebar harus lebih besar dari 0 |
| 6 | (kosong) | 5 | Pesan input Panjang dan fokus kembali ke TxtPanjang |
| 7 | 5 | (kosong) | Pesan input Lebar dan fokus kembali ke TxtLebar |
| 8 | abc | 5 | Input Panjang ditolak; jika ditempel, TryParse menampilkan pesan |
| 9 | 5 | abc | Input Lebar ditolak; jika ditempel, TryParse menampilkan pesan |

Setelah input valid, ListBox menampilkan jenis dan hasil perhitungan, enam elemen Array satu dimensi, lalu tiga baris Array dua dimensi. Pesan juga menampilkan jenis perhitungan dan hasil.

### 7. Memahami batasan dan perilaku fungsi

- Kriteria hanya memeriksa apakah **panjang > 50**. Lebar tidak ikut menentukan apakah hasil disebut Luas atau Keliling.
- Panjang 50 masuk ke cabang Keliling; Panjang 51 masuk ke cabang Luas.
- Nama fungsi ditulis **hitung** dengan huruf kecil. Visual Basic tidak membedakan huruf besar dan kecil, jadi pemanggilan **Hitung** tetap merujuk ke fungsi yang sama.
- Modul dan form harus berada dalam proyek yang sama agar FrmArray dapat memanggil fungsi dan membaca Array.
- Fungsi mengembalikan Integer. Nilai input yang sangat besar dapat membuat hasil perkalian melampaui kapasitas Integer. Untuk latihan gunakan angka kecil.
- Kode KeyPress tidak mengizinkan tanda minus. Validasi TryParse tetap mengecek teks yang ditempel. Kode lengkap juga menolak nilai nol dan negatif.
- Isi ListBox dibersihkan hanya setelah semua input valid. Jika input salah, isi sebelumnya tetap ada.

### 8. Jika terjadi masalah

- **Hitung tidak dikenal:** pastikan Module bernama **ModArray.vb** ada di proyek dan nama fungsi ditulis **Public Function Hitung**.
- **nilai atau nilai2D tidak dikenal:** pastikan deklarasi Array berada di Module **ModArray**, bukan di dalam prosedur tombol.
- **Event tombol tidak berjalan:** pastikan event memiliki **Handles btnTampil.Click** dan properti **(Name)** Button adalah **btnTampil**.
- **Input huruf masih bisa ditempel:** KeyPress hanya mengatur pengetikan. TryParse di event tombol yang menolak teks hasil paste.
- **MessageBox hanya menampilkan 85:** event tombol masih menggunakan satu baris contoh awal; ganti dengan kode lengkap.
- **ListBox kosong:** pastikan input Panjang dan Lebar sudah diisi angka positif lalu klik **Tampilkan**.
- **Designer menampilkan error:** edit kontrol melalui Designer dan Properties. Jangan mengubah **FrmArray.Designer.vb** secara manual.
