# Operator dan Struktur Kendali

Hasil akhir praktik ini adalah aplikasi Windows Forms yang menerima nilai ujian, memeriksa input, lalu menampilkan gambar berdasarkan rentang nilai.

## Langkah 0: Membuat proyek

1. Buka Visual Studio dan pilih **Create a new project**.
2. Cari template **Windows Forms App (.NET Framework)**. Pilih bahasa **Visual Basic**, lalu pilih template tersebut.
3. Klik **Next**.
4. Isi nama proyek, misalnya **Pertemuan3-Operator-Struktur-Kendali**, pilih lokasi proyek, lalu klik **Create**.
5. Pilih **.NET Framework 4.8** atau versi .NET Framework yang tersedia.
6. Visual Studio membuat form awal bernama **Form1**. Gunakan form ini sebagai layar aplikasi.
7. Buka properti proyek melalui **Project** > **Properties**, pilih tab **Compile**, lalu ubah **Option Strict** menjadi **On**. Simpan perubahan.

Jika template Windows Forms App (.NET Framework) tidak muncul, buka Visual Studio Installer, tambahkan workload **.NET desktop development**, lalu buka ulang Visual Studio.

## Persiapan file gambar

1. Di Solution Explorer, klik kanan nama proyek, pilih **Add** > **New Folder**, lalu beri nama **Assets**.
2. Klik kanan folder **Assets** di Solution Explorer, pilih **Add** > **Existing Item**.
3. Tambahkan file **1.jpg**, **2.jpg**, dan **peter.jpg** ke folder Assets, lalu klik **Add**.

Atur properti setiap file gambar di Solution Explorer:

| Properti | Nilai |
|---|---|
| Build Action | Content |
| Copy to Output Directory | Copy if newer |

Setelan ini menempatkan gambar di folder **bin\Debug\Assets** atau **bin\Release\Assets** saat proyek dijalankan.

| File | Rentang nilai yang ditampilkan |
|---|---|
| 1.jpg | 0–50 |
| 2.jpg | 51–70 |
| peter.jpg | 91–100 |

## Praktik: Menampilkan Gambar Berdasarkan Nilai

### 1. Mengatur form

Klik area kosong pada form di Designer. Atur properti berikut di jendela Properties:

| Properti | Nilai |
|---|---|
| (Name) | Form1 |
| Text | Nilai Ujian - Struktur Kendali |
| ClientSize | 800; 450 |
| StartPosition | CenterScreen |
| FormBorderStyle | FixedSingle |
| MaximizeBox | False |

Pastikan form utama proyek adalah **Form1** melalui **Project** > **Properties** > **Application** > **Startup form**.

### 2. Menambahkan kontrol

Buka Toolbox melalui **View** > **Toolbox**. Tambahkan kontrol berikut. Susun PictureBox di bagian atas-tengah, isian nilai di bawahnya, lalu tombol Input di bawah TextBox.

| Kontrol | (Name) | Text | Location contoh | Size contoh |
|---|---|---|---|---|
| PictureBox | picImage | — | 350; 45 | 120; 120 |
| Label | lblPetunjuk | Masukkan nilai ujian (0–100): | 250; 205 | — |
| TextBox | txtNilai | (kosong) | 350; 202 | 150; 25 |
| Button | btnInput | Input | 370; 250 | 110; 34 |

Label petunjuk ditambahkan agar jelas apa yang harus diisi. Label ini tidak ada pada Designer di ZIP; jika ingin menyalin tampilan ZIP persis, label boleh tidak ditambahkan.

Atur properti kontrol berikut:

| Kontrol | Properti | Nilai |
|---|---|---|
| picImage | SizeMode | Zoom |
| picImage | BorderStyle | FixedSingle |
| txtNilai | MaxLength | 3 |
| btnInput | UseVisualStyleBackColor | True |

Properti **Zoom** membuat gambar terlihat utuh di dalam PictureBox. Sesuaikan posisi dan ukuran kontrol melalui Designer jika susunannya berbeda pada layar Anda.

### 3. Memeriksa nama kontrol

Pastikan nama kontrol di jendela Properties sama persis dengan tabel:

- TextBox: **txtNilai**
- Button: **btnInput**
- PictureBox: **picImage**

Kode mengacu pada nama-nama tersebut. Jika nama kontrol berbeda, sesuaikan nama di kode atau ubah properti **(Name)** kontrol.

### 4. Menambahkan kode validasi dan pemilihan gambar

Di Solution Explorer, buka **Form1.vb** (bukan **Form1.Designer.vb**). Ganti seluruh isi **Form1.vb** dengan kode berikut. Baris **Handles** menghubungkan setiap prosedur ke kontrol/event-nya, jadi tidak perlu membuat event yang sama dua kali melalui Designer.

```vb
Option Strict On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        BersihkanGambar()
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        ' Izinkan angka dan tombol kontrol, seperti Backspace.
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        ' TryParse memeriksa bahwa isian dapat dibaca sebagai bilangan bulat.
        If Not Integer.TryParse(txtNilai.Text.Trim(), nilaiUjian) Then
            MessageBox.Show("Masukkan nilai dalam bentuk angka.",
                            "Input tidak valid",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtNilai.Focus()
            txtNilai.SelectAll()
            Return
        End If

        ' Nilai ujian harus berada pada rentang 0 sampai 100.
        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Masukkan nilai antara 0 dan 100.",
                            "Nilai di luar rentang",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtNilai.Focus()
            txtNilai.SelectAll()
            Return
        End If

        If nilaiUjian <= 50 Then
            TampilkanGambar("1.jpg")
        ElseIf nilaiUjian <= 70 Then
            TampilkanGambar("2.jpg")
        ElseIf nilaiUjian > 90 Then
            TampilkanGambar("peter.jpg")
        Else
            ' Kode ZIP tidak menetapkan gambar untuk nilai 71 sampai 90.
            BersihkanGambar()
            MessageBox.Show("Belum ada gambar yang ditentukan untuk nilai 71 sampai 90.",
                            "Rentang nilai",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            txtNilai.Focus()
            txtNilai.SelectAll()
        End If
    End Sub

    Private Sub TampilkanGambar(namaFile As String)
        Dim jalur As String = System.IO.Path.Combine(
            Application.StartupPath, "Assets", namaFile)

        If Not System.IO.File.Exists(jalur) Then
            BersihkanGambar()
            MessageBox.Show("File gambar tidak ditemukan:" & vbCrLf & jalur,
                            "File tidak ditemukan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Clone melepaskan file agar gambar tidak terkunci setelah dibuka.
            Using gambarSumber As Image = Image.FromFile(jalur)
                Dim gambarTampil As Image = CType(gambarSumber.Clone(), Image)
                BersihkanGambar()
                picImage.Image = gambarTampil
            End Using
        Catch ex As Exception
            BersihkanGambar()
            MessageBox.Show("Gambar tidak dapat dibuka." & vbCrLf & ex.Message,
                            "Kesalahan gambar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BersihkanGambar()
        If picImage.Image IsNot Nothing Then
            picImage.Image.Dispose()
            picImage.Image = Nothing
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BersihkanGambar()
    End Sub

End Class
```

Pastikan kode berada di **Form1.vb**, bukan di **Form1.Designer.vb**. Jangan membuat event Click kedua dengan nama yang sama. Jika Visual Studio sudah membuat kerangka btnInput_Click, isi kerangka itu dan tambahkan prosedur lainnya di bawahnya.

#### Cara membaca struktur If...ElseIf

Kondisi diperiksa dari atas ke bawah:

1. Jika nilai kurang dari atau sama dengan 50, tampilkan **1.jpg**.
2. Jika tidak, tetapi nilainya kurang dari atau sama dengan 70, tampilkan **2.jpg**.
3. Jika tidak, tetapi nilainya lebih dari 90, tampilkan **peter.jpg**.
4. Nilai 71–90 masuk ke bagian **Else**, sehingga aplikasi mengosongkan gambar lama dan memberi tahu pengguna bahwa gambar untuk rentang itu belum ditentukan.

Pengecekan batas 0–100 harus mengembalikan alur dengan **Return**. Tanpa Return, nilai yang tidak valid dapat tetap diproses oleh kondisi berikutnya.

#### Cara kerja pembatasan input angka

Event **KeyPress** menolak karakter selain angka dan tombol kontrol. Backspace tetap dapat digunakan. Pembatasan ini hanya membantu saat mengetik; input tetap diperiksa dengan **Integer.TryParse** karena teks juga dapat ditempel dari clipboard.

### 5. Menjalankan dan menguji

Simpan proyek, lalu tekan **F5** atau klik **Start**.

| No. | Nilai yang diuji | Hasil yang diharapkan |
|---:|---:|---|
| 1 | Kosong | Pesan “Masukkan nilai dalam bentuk angka”; fokus kembali ke txtNilai |
| 2 | Huruf, misalnya abc | Saat diketik, huruf ditolak; jika ditempel, TryParse menampilkan pesan input tidak valid |
| 3 | Tempel -1 ke TextBox | Pesan nilai di luar rentang; fokus kembali ke txtNilai |
| 4 | 0 | Gambar 1.jpg tampil |
| 5 | 50 | Gambar 1.jpg tampil |
| 6 | 51 | Gambar 2.jpg tampil |
| 7 | 70 | Gambar 2.jpg tampil |
| 8 | 71 | Gambar lama dikosongkan dan pesan menyebut rentang 71–90 |
| 9 | 90 | Gambar lama dikosongkan dan pesan menyebut rentang 71–90 |
| 10 | 91 | Gambar peter.jpg tampil |
| 11 | 100 | Gambar peter.jpg tampil |
| 12 | 101 | Pesan nilai di luar rentang; gambar tidak diganti |
| 13 | Klik Input beberapa kali | Gambar tetap dapat dimuat; file tidak terkunci oleh aplikasi |

### 6. Jika terjadi masalah

- **Pesan file gambar tidak ditemukan:** pastikan nama folder adalah **Assets**, nama file tepat **1.jpg**, **2.jpg**, dan **peter.jpg**, serta file disalin ke output dengan **Copy if newer**.
- **Gambar tidak berubah setelah kode diperbaiki:** klik **Build** > **Rebuild Solution**, lalu jalankan lagi.
- **PictureBox kosong:** periksa bahwa nilainya masuk ke salah satu rentang yang memiliki gambar dan file ada di **bin\Debug\Assets**.
- **Gambar terpotong:** pilih **Zoom** pada properti **SizeMode** PictureBox.
- **Event tidak berjalan:** pastikan deklarasi event berisi **Handles btnInput.Click** atau **Handles txtNilai.KeyPress** sesuai kontrolnya.
- **Nama kontrol tidak dikenal:** samakan properti **(Name)** dengan nama yang dipakai di kode.
- **Designer menampilkan error:** jangan mengedit **Form1.Designer.vb** secara manual. Tambah atau atur kontrol dari Designer dan jendela Properties.