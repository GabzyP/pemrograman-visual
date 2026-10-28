# Perulangan

Hasil akhir praktik ini adalah satu form Windows Forms yang meminta nilai awal dan nilai akhir, kemudian menampilkan semua bilangan bulat di antara kedua nilai tersebut dalam ListBox.

| Kontrol | Fungsi |
|---|---|
| txtNilaiAwal | Isian batas awal |
| txtNilaiAkhir | Isian batas akhir |
| btnInput | Memvalidasi input dan menjalankan perulangan |
| lstHasil | Menampilkan urutan bilangan |

Aplikasi contoh menggunakan perulangan For...To. Nilai awal dan nilai akhir ikut dimasukkan jika rentangnya berurutan naik.

## Langkah 0: Membuat proyek

1. Buka Visual Studio dan pilih **Create a new project**.
2. Cari template **Windows Forms App (.NET Framework)**, pilih bahasa **Visual Basic**, lalu pilih template tersebut.
3. Klik **Next**.
4. Beri nama proyek **Pertemuan-4-Perulangan**, pilih lokasi proyek, lalu klik **Create**.
5. Pilih **.NET Framework 4.8** atau versi .NET Framework yang tersedia.
6. Buka **Project** > **Properties** > **Compile**, lalu atur **Option Strict** menjadi **On**.
7. Di Solution Explorer, klik kanan nama proyek, pilih **Add** > **Windows Form...**, beri nama **FrmPerulangan.vb**, lalu klik **Add**.
8. Buka kembali **Project** > **Properties** > **Application** dan atur **Startup form** menjadi **FrmPerulangan**.
9. Jika proyek juga memiliki **Form1** bawaan yang tidak digunakan, klik kanan Form1 di Solution Explorer dan pilih **Remove**. Jangan menghapus FrmPerulangan.

Jika template Windows Forms App (.NET Framework) tidak tersedia, buka Visual Studio Installer, pasang workload **.NET desktop development**, lalu buka kembali Visual Studio.

## Praktik: Menampilkan Rentang Bilangan

### 1. Mengatur form

Buka **FrmPerulangan.vb** di Designer. Klik area kosong pada form dan atur properti berikut melalui jendela Properties:

| Properti | Nilai |
|---|---|
| (Name) | FrmPerulangan |
| Text | Form Perulangan |
| ClientSize | 800; 450 |
| StartPosition | CenterScreen |
| FormBorderStyle | FixedSingle |
| MaximizeBox | False |

Jika properti **(Name)** masih berisi nama lain, ubah melalui jendela Properties. Pastikan nama class di **FrmPerulangan.vb** dan file Designer sama-sama **FrmPerulangan**.

### 2. Menambahkan kontrol

Buka Toolbox melalui **View** > **Toolbox**. Tambahkan dua Label, dua TextBox, satu Button, dan satu ListBox.

| Kontrol | (Name) | Text | Location contoh | Size contoh |
|---|---|---|---|---|
| Label | lblNilaiAwal | Nilai Awal : | 343; 49 | otomatis |
| TextBox | txtNilaiAwal | (kosong) | 306; 103 | 150; 31 |
| Label | lblNilaiAkhir | Nilai Akhir : | 340; 169 | otomatis |
| TextBox | txtNilaiAkhir | (kosong) | 306; 208 | 150; 31 |
| Button | btnInput | Input | 329; 261 | 112; 34 |
| ListBox | lstHasil | — | 291; 318 | 180; 129 |

Untuk setiap kontrol, klik kontrol tersebut di Designer, lalu atur properti **(Name)** dan **Text** di jendela Properties. TextBox dan ListBox dibiarkan kosong.

### 3. Memeriksa nama kontrol

Sebelum menulis kode, pastikan nama kontrol sama persis dengan yang digunakan program:

- Label batas awal: **lblNilaiAwal**
- Label batas akhir: **lblNilaiAkhir**
- TextBox batas awal: **txtNilaiAwal**
- TextBox batas akhir: **txtNilaiAkhir**
- Tombol: **btnInput**
- ListBox hasil: **lstHasil**

Properti **Text** menentukan tulisan yang terlihat pada Label atau Button. Properti **(Name)** adalah pengenal kontrol yang dipakai oleh kode.

### 4. Menulis kode tombol Input

Di Solution Explorer, buka **FrmPerulangan.vb**, bukan **FrmPerulangan.Designer.vb**. Ganti isi file code-behind dengan kode berikut:

```vb
Option Strict On

Public Class FrmPerulangan

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
```

Jangan menambahkan kode ke **FrmPerulangan.Designer.vb**. Visual Studio mengelola file Designer dan kode tersebut dapat tertimpa saat form diubah.

Jika **Option Strict On** sudah tertulis di bagian atas file, jangan menulisnya dua kali. Pengaturan Compile pada langkah pembuatan proyek juga mengaktifkan opsi ini untuk proyek.

### 5. Memahami urutan kerja kode

Saat tombol **Input** diklik, kode bekerja berurutan:

1. Mendeklarasikan dua variabel Integer untuk menampung batas awal dan akhir.
2. Memeriksa TextBox pertama dengan **Integer.TryParse**. Jika teks kosong atau bukan bilangan bulat, program menampilkan pesan, mengembalikan fokus ke TextBox awal, lalu keluar dari event dengan **Return**.
3. Memeriksa TextBox kedua dengan cara yang sama. Jika gagal, fokus dikembalikan ke TextBox akhir dan proses dihentikan.
4. Setelah kedua nilai valid, **lstHasil.Items.Clear()** menghapus hasil sebelumnya.
5. Perulangan **For i As Integer = nilaiAwal To nilaiAkhir** menjalankan blok untuk setiap bilangan dari awal sampai akhir, dengan kenaikan satu.
6. **lstHasil.Items.Add(i)** menambahkan nilai saat ini ke ListBox.
7. Ketika i mencapai nilai akhir, perulangan berhenti. Batas akhir ikut dimasukkan.

Karena ListBox dibersihkan setelah validasi berhasil, klik Input berulang kali tidak menggandakan daftar lama. Jika salah satu input tidak valid, daftar sebelumnya tetap tampil karena kode berhenti sebelum memanggil Clear().

### 6. Menjalankan dan menguji

Simpan proyek, lalu tekan **F5** atau klik **Start**.

| No. | Nilai awal | Nilai akhir | Hasil yang diharapkan |
|---:|---:|---:|---|
| 1 | 2 | 6 | ListBox berisi 2, 3, 4, 5, 6 |
| 2 | 5 | 5 | ListBox berisi satu nilai: 5 |
| 3 | -3 | 1 | ListBox berisi -3, -2, -1, 0, 1 |
| 4 | (kosong) | 6 | Pesan input angka muncul dan fokus kembali ke txtNilaiAwal |
| 5 | 2 | (kosong) | Pesan input angka muncul dan fokus kembali ke txtNilaiAkhir |
| 6 | abc | 6 | Input awal ditolak karena bukan bilangan bulat |
| 7 | 2 | 3,5 | Input akhir ditolak karena bukan bilangan bulat |
| 8 | 2 | 6, lalu klik Input lagi | Daftar tetap berisi lima angka, tidak bertambah menjadi sepuluh |
| 9 | 6 | 2 | ListBox dikosongkan dan tidak ada angka yang ditambahkan |

### 7. Perilaku dan batasan contoh

- **For...To** memproses bilangan naik satu per satu. Misalnya 2 sampai 6 menghasilkan lima item, termasuk angka 2 dan angka 6.
- Nilai awal dan akhir harus bisa dikonversi menjadi Integer. Nilai desimal seperti 3,5 dan teks seperti abc tidak diterima.
- Kode ZIP tidak membatasi bilangan negatif, jadi rentang negatif seperti -3 sampai 1 tetap dapat ditampilkan.
- Jika nilai awal lebih besar daripada nilai akhir, validasi berhasil, daftar lama dihapus, lalu loop tidak berjalan. Hasil ListBox menjadi kosong.
- Kode tidak membatasi panjang rentang. Rentang yang sangat besar akan menambahkan banyak item ke ListBox dan dapat membuat aplikasi lambat. Untuk penggunaan nyata, tambahkan batas rentang sesuai kebutuhan.
- File ZIP memiliki event Click pada Label dan KeyPress pada kedua TextBox, tetapi badan event tersebut kosong. Event kosong tidak menambah fungsi, sehingga tidak diperlukan dalam versi panduan ini. Input tetap divalidasi ketika tombol diklik.

### 8. Jika terjadi masalah

- **Event tombol tidak jalan:** pastikan deklarasi prosedur berakhir dengan **Handles btnInput.Click** dan nama Button di Properties adalah **btnInput**.
- **Nama kontrol tidak dikenal:** periksa properti **(Name)** pada TextBox dan ListBox. Nama harus sama dengan yang dipakai dalam kode.
- **Fokus tidak kembali ke isian yang salah:** pastikan pemanggilan **Focus()** berada di blok validasi yang sesuai sebelum **Return**.
- **Daftar hasil lama masih terlihat setelah input yang salah:** ini memang perilaku kode. ListBox baru dibersihkan setelah kedua input berhasil divalidasi.
- **Daftar kosong untuk rentang terbalik:** For...To hanya menghitung naik. Masukkan nilai awal yang lebih kecil atau sama dengan nilai akhir.
- **Form yang muncul bukan FrmPerulangan:** periksa pilihan **Startup form** pada **Project** > **Properties** > **Application**.
- **Designer error setelah mengedit kode:** pastikan kode form ditulis di **FrmPerulangan.vb**. Jangan mengubah file Designer secara manual.
