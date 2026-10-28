# Form Profil Mahasiswa

## Langkah 0: Membuat proyek

1. Buka Visual Studio, lalu pilih **Create a new project**.
2. Cari dan pilih **Windows Forms App (.NET Framework)**. Pastikan bahasa yang dipilih **Visual Basic**.
3. Klik **Next**, isi nama proyek **Pertemuan2-KomponenVisual**, tentukan lokasi penyimpanan, lalu klik **Create**.
4. Pada pilihan framework, pilih **.NET Framework 4.8** atau versi yang tersedia di komputer.
5. Visual Studio membuat form awal bernama **Form1**. Form ini akan menjadi form profil mahasiswa.

Jika template **Windows Forms App (.NET Framework)** tidak muncul, instal komponen pengembangan .NET desktop melalui Visual Studio Installer, lalu buka kembali Visual Studio.

## Praktik: Form Profil Mahasiswa

### 1. Mengatur form

Klik area kosong pada form di Designer. Di jendela **Properties**, atur properti berikut:

| Properti | Nilai |
|---|---|
| (Name) | Form1 |
| Text | Profil Mahasiswa |
| ClientSize | 453; 249 |
| StartPosition | CenterScreen |
| FormBorderStyle | FixedSingle |
| MaximizeBox | False |

Properti **Text** adalah judul yang terlihat pada title bar. Properti **(Name)** adalah nama form yang digunakan di kode.

### 2. Menambahkan kontrol

Buka **View** > **Toolbox** bila Toolbox belum terlihat. Tarik kontrol berikut ke form. Susun tiga pasang Label dan TextBox dari atas ke bawah, lalu letakkan tombol di bawah isian.

| Kontrol | (Name) | Text | Location | Size |
|---|---|---|---|---|
| Label | lblNama | Nama | 117; 59 | — |
| TextBox | txtNama | (kosong) | 162; 56 | 100; 23 |
| Label | lblNIM | NIM | 120; 88 | — |
| TextBox | txtNim | (kosong) | 161; 85 | 100; 23 |
| Label | lblKom | KOM | 119; 117 | — |
| TextBox | txtKom | (kosong) | 162; 114 | 100; 23 |
| Button | btnTampilkan | Tampilkan | 139; 160 | 75; 23 |
| Button | btnHapus | Hapus | 229; 160 | 75; 23 |
| Button | btnKeluar | Keluar | 187; 189 | 75; 23 |

Untuk setiap kontrol, klik kontrol tersebut dan atur **(Name)** serta **Text** melalui jendela **Properties**. TextBox dibiarkan kosong. 

### 3. Membuat event tombol

Double-click tombol **Tampilkan** di Designer. Visual Studio membuka **Form1.vb** dan membuat event Click untuk tombol tersebut.

Ulangi untuk tombol **Hapus** dan **Keluar**. Isi atau ganti isi event yang dibuat dengan kode berikut. Jangan menempelkan event yang sama dua kali; gunakan kerangka event yang dibuat Visual Studio.

```vb
Option Strict On

Public Class Form1

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang!" & vbCrLf &
                        "Nama " & txtNama.Text & vbCrLf &
                        "NIM " & txtNim.Text & vbCrLf &
                        "Kom " & txtKom.Text)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

End Class
```

Jika **Option Strict On** sudah dibuat oleh Visual Studio di bagian atas file, jangan menuliskannya untuk kedua kali. Pastikan baris itu berada sebelum **Public Class Form1**.

Event **Tampilkan** membentuk satu pesan dengan baris baru (vbCrLf) dan isi ketiga TextBox. Event **Hapus** memanggil Clear() pada setiap TextBox. Event **Keluar** menutup form aktif.

### 4. Menjalankan dan menguji

Simpan semua file, lalu tekan **F5** atau klik **Start**.

| No. | Langkah | Hasil yang diharapkan |
|---:|---|---|
| 1 | Isi Nama, NIM, dan KOM, lalu klik **Tampilkan** | MessageBox menampilkan “Halo Selamat Datang!” serta nilai Nama, NIM, dan KOM pada baris terpisah |
| 2 | Tutup MessageBox, lalu klik **Hapus** | Ketiga TextBox menjadi kosong |
| 3 | Isi kembali beberapa TextBox, lalu klik **Hapus** | Semua isian tetap dikosongkan, termasuk yang tidak diisi |
| 4 | Klik **Keluar** | Form ditutup dan aplikasi berhenti |

Contoh isi MessageBox:

```text
Halo Selamat Datang!
Nama Andi
NIM 231712001
Kom KOM-A
```

### 5. Jika terjadi masalah

- **Tombol tidak menjalankan kode:** pastikan event Click dibuat dengan double-click tombol di Designer dan deklarasi **Handles** memakai nama kontrol yang sama.
- **Muncul error nama tidak dikenal:** periksa properti **(Name)** TextBox dan tombol. Nama di kode harus sama, termasuk huruf pada **txtNama**, **txtNim**, dan **txtKom**.
- **Ada deklarasi Option Strict On ganda:** sisakan satu deklarasi di baris paling atas **Form1.vb**.
- **Form tidak muncul saat Start:** buka properti proyek bagian **Application** dan pastikan **Startup form** adalah **Form1**.
- **Tampilan tombol tidak sesuai kode:** periksa bahwa tombol Hapus dan Keluar masing-masing dinamai **btnHapus** dan **btnKeluar**, atau ubah kode agar cocok dengan nama yang Anda gunakan.

Kode Designer dikelola Visual Studio. Atur kontrol melalui Designer dan jendela Properties; jangan mengubah **Form1.Designer.vb** secara manual.
