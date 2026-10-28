Validasi Input, Error Handling & Naming Convention

Pembahasan

- Naming convention kontrol
- Error dan exception
- Try...Catch...Finally
- Validasi input dengan TryParse
- ErrorProvider

## Studi Kasus: Form Pendaftaran

Sepanjang pertemuan ini kita memperbaiki satu form berisi NIM, Nama, Jurusan, Angkatan, dan IPK. Versi awalnya “asal jalan”:

- Kontrol bernama TextBox1 sampai TextBox5.
- Program berhenti saat Angkatan diisi huruf.
- IPK 7,5 diterima begitu saja.
- Nama kosong ikut tersimpan.
- NIM yang sama bisa didaftarkan dua kali.

### Teks pada contoh form

**Pendaftaran Mahasiswa**

Isian: NIM, Nama, Jurusan, Angkatan, IPK.

Tombol: Simpan, Bersihkan, Ekspor ke CSV.

Bagian daftar berjudul **Data tersimpan**, dengan contoh data:

| NIM | Nama | Jurusan | Angkatan | IPK |
|---|---|---|---:|---:|
| 231712001 | Andi Pratama | Teknik Informatika | 2023 | 3,45 |
| 231712002 | Sari Wulandari | Sistem Informasi | 2023 | 3,80 |

Contoh status: “Data Sari Wulandari tersimpan.”

## Nama Default Menyulitkan

Visual Studio memberi nama otomatis: Button1, TextBox1, TextBox2, dan seterusnya. Saat form berisi 15 kontrol, kode seperti TextBox3.Text tidak menjelaskan isinya. Pembaca harus bolak-balik ke Designer untuk mencari tahu.

Rubrik UTS, UAS, dan proyek menurunkan nilai kerapian kode untuk penamaan default.

Contoh:

- TextBox3.Text — Isinya NIM, nama, atau angkatan?
- txtNama.Text — Jelas dari namanya: isian nama.

## Pola: prefix + NamaFungsi

Nama kontrol = prefix 3 huruf kecil sesuai jenis kontrol + nama fungsi, setiap kata diawali huruf besar.

Tanpa spasi dan tidak diawali angka.

Diubah lewat properti **(Name)** di jendela **Properties**, bukan properti **Text**.

Contoh: txtNama, btnSimpan, cboJurusan.

Contoh nama pada form pendaftaran:

- Judul: lblJudul
- NIM: txtNim
- Nama: txtNama
- Jurusan: cboJurusan
- Angkatan: txtAngkatan
- IPK: txtIpk
- Tombol Simpan: btnSimpan
- Tombol Bersihkan: btnBersihkan

## Daftar Prefix Kontrol

| Kontrol | Prefix | Contoh |
|---|---|---|
| Form | frm | frmPendaftaran |
| Label | lbl | lblJudul |
| TextBox | txt | txtNama |
| Button | btn | btnSimpan |
| ComboBox | cbo | cboJurusan |
| ListBox | lst | lstMahasiswa |
| CheckBox | chk | chkSetuju |
| RadioButton | rdo | rdoLakiLaki |
| GroupBox | grp | grpDataDiri |
| DataGridView | dgv | dgvData |
| DateTimePicker | dtp | dtpTanggalLahir |
| ErrorProvider | err | errInput |

Semua kontrol diberi nama, termasuk Label yang tidak pernah dipakai di kode.

## Kesalahan Umum Penamaan

1. **Name diganti setelah double-click:** nama Sub tetap Button1_Click. Biasakan ganti Name dulu, baru double-click.
2. **Mengubah Text dikira mengubah Name.**
3. **Prefix tidak sesuai jenis kontrol**, misalnya txtJurusan untuk sebuah ComboBox.
4. **Bahasa campur dalam satu form:** btnSave dan btnHapus.

### Teks yang terlihat pada jendela Properties

Kontrol yang dipilih: txtNama — System.Windows.Forms.TextBox.

Beberapa properti yang tampak:

- Accessibility
- Appearance
- BackColor: Window
- BorderStyle: Fixed3D
- Cursor: Default
- Error on errInput
- Font: Segoe UI; 9pt
- ForeColor: WindowText
- IconAlignment on errInput: MiddleRight
- IconPadding on errInput: 0
- Lines: String[] Array
- RightToLeft: No
- ScrollBars: None
- Text
- TextAlign: Left
- UseWaitCursor: False
- Behavior
- Data
- Design
- (Name): txtNama
- GenerateMember: True
- Locked: False
- Modifiers: Friend

Keterangan properti (Name): “Indicates the name used in code to identify the object.”

## Tiga Jenis Error

### Syntax error

Salah tulis kode, misalnya Dim x As Integr. Ditandai garis merah; program tidak bisa dijalankan sampai diperbaiki.

### Runtime error

Disebut juga exception. Muncul saat program berjalan, misalnya CInt("abc"). Program berhenti jika tidak ditangkap.

### Logic error

Program berjalan normal, tetapi hasilnya salah, misalnya rumus rata-rata keliru. Hanya ketahuan lewat pengujian.

Try...Catch hanya untuk runtime error. Syntax error diperbaiki sebelum program dijalankan, sedangkan logic error dicari lewat pengujian dengan data yang hasilnya sudah diketahui.

## Program Berhenti Mendadak

Angkatan diisi “dua ribu”. CInt tidak bisa mengubahnya menjadi angka, sehingga .NET melempar exception bertipe InvalidCastException. Karena tidak ada yang menangkapnya, program berhenti dan isian yang belum disimpan bisa hilang.

Contoh tanpa penanganan error:

```vb
' Tanpa penanganan error: input "abc" membuat program berhenti (InvalidCastException)
Private Sub btnCInt_Click(sender As Object, e As EventArgs) Handles btnCInt.Click
    Dim angka As Integer = CInt(txtInput.Text)
    lblHasil.Text = "CInt berhasil: " & angka.ToString()
End Sub
```

## Exception yang Sering Muncul

| Exception | Penyebab umum |
|---|---|
| FormatException | Integer.Parse("abc"): teks bukan angka |
| InvalidCastException | CInt("abc"): konversi gaya VB gagal |
| OverflowException | Angka melebihi batas tipe data |
| DivideByZeroException | Bilangan bulat dibagi 0 (operator \ atau Mod) |
| IndexOutOfRangeException | Indeks array di luar batas |
| NullReferenceException | Objek masih Nothing (belum dibuat dengan New) |
| IOException | File dipakai program lain atau tidak bisa ditulis |

Exception adalah objek: ex.Message berisi penjelasan singkat, sedangkan tipenya menunjukkan jenis masalah.

## Cara Kerja Try...Catch

Baris di blok Try dijalankan berurutan. Begitu satu baris melempar exception, sisa baris Try dilewati dan eksekusi lompat ke Catch. Jika tidak ada exception, Catch dilewati.

Setelah End Try, program tetap berjalan. Seperti jaring pengaman akrobat: tidak mencegah jatuh, tetapi pertunjukan bisa berlanjut.

| Tanpa exception | Exception di baris 2 |
|---|---|
| Baris 1 dijalankan | Baris 1 dijalankan |
| Baris 2 dijalankan | Baris 2 melempar exception |
| Baris 3 dijalankan | Baris 3 dilewati |
| Catch dilewati | Catch dijalankan |
| Lanjut setelah End Try | Lanjut setelah End Try |

## Contoh Try...Catch

Coba dengan input 25, lalu abc. Pada input abc, baris setelah Integer.Parse tidak pernah dijalankan: eksekusi langsung lompat ke Catch, lalu program tetap berjalan. Pesan untuk pengguna menjelaskan apa yang harus dilakukan, bukan sekadar pesan teknis.

```vb
Private Sub btnTryCatch_Click(sender As Object, e As EventArgs) Handles btnTryCatch.Click
    Try
        Dim angka As Integer = Integer.Parse(txtInput.Text)
        lblHasil.Text = "Berhasil dikonversi: " & angka.ToString()
    Catch ex As Exception
        lblHasil.Text = "Konversi gagal, program tetap berjalan."
        MessageBox.Show("Input harus bilangan bulat, misalnya 25." & vbCrLf &
                        "Detail: " & ex.Message, "Input Tidak Valid",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
End Sub
```

Contoh pesan dialog untuk input abc:

> Input harus bilangan bulat, misalnya 25.  
> Detail: The input string 'abc' was not in a correct format.

## Catch Bertingkat

Catch diperiksa dari atas ke bawah; hanya yang pertama cocok yang dijalankan. Letakkan yang spesifik di atas dan Exception paling bawah. Coba input: abc, 999999999999, 0, dan 25.

```vb
Private Sub btnCatchBertingkat_Click(sender As Object, e As EventArgs) Handles btnCatchBertingkat.Click
    Try
        Dim angka As Integer = Integer.Parse(txtInput.Text)
        Dim hasil As Integer = 1000 \ angka
        lblHasil.Text = "1000 \ " & angka.ToString() & " = " & hasil.ToString()
    Catch ex As FormatException
        lblHasil.Text = "Format salah: input bukan bilangan bulat."
    Catch ex As OverflowException
        lblHasil.Text = "Angka terlalu besar untuk tipe Integer."
    Catch ex As DivideByZeroException
        lblHasil.Text = "Pembagian dengan nol tidak diperbolehkan."
    Catch ex As Exception
        lblHasil.Text = "Error lain: " & ex.Message
    End Try
End Sub
```

## Finally: Selalu Dijalankan

Finally berjalan ada error atau tidak.

Tempat beres-beres: menutup file, menutup koneksi, mengaktifkan tombol kembali.

Coba: buka CSV di Excel, lalu klik Ekspor lagi. Muncul IOException, tetapi file tetap ditutup.

```vb
Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
    Dim penulis As StreamWriter = Nothing
    Try
        penulis = New StreamWriter(lokasiEkspor)
        For Each baris As Object In lstMahasiswa.Items
            penulis.WriteLine(baris.ToString().Replace(" | ", ";"))
        Next
        lblStatus.Text = "Data diekspor ke " & lokasiEkspor
    Catch ex As IOException
        MessageBox.Show("File sedang dipakai program lain atau tidak bisa ditulis." &
                        vbCrLf & ex.Message, "Ekspor Gagal")
    Finally
        If penulis IsNot Nothing Then penulis.Close()  ' file selalu ditutup
    End Try
End Sub
```

## Kapan Memakai Try...Catch

**Tepat dipakai:** operasi di luar kendali program, seperti membaca atau menulis file, koneksi database dan jaringan, serta konversi data dari sumber luar yang formatnya tidak bisa dijamin.

**Tidak tepat:** menggantikan pengecekan biasa (input kosong cukup dengan If), membungkus seluruh Sub dalam satu Try besar, dan Catch kosong yang menelan error sehingga masalah tersembunyi.

*Cegah dengan validasi apa yang bisa dicegah. Tangkap dengan Try...Catch apa yang tidak bisa dicegah.*

## Validasi: Cegah Sebelum Diproses

| Aturan | Penerapan di form pendaftaran |
|---|---|
| Wajib isi | Nama tidak boleh kosong |
| Tipe data | Angkatan harus bilangan bulat |
| Rentang | Angkatan 2015 s.d. tahun ini, IPK 0,00 s.d. 4,00 |
| Format | NIM tepat 9 digit angka |
| Pilihan | Jurusan dipilih dari ComboBox |
| Unik | NIM belum pernah didaftarkan |

Validasi berarti memeriksa input sebelum diproses. Untuk satu isian, periksa tipe datanya dulu, baru rentangnya: angkatan belum bisa dibandingkan dengan 2015 sebelum berhasil diubah menjadi angka.

## CInt, Val, atau TryParse?

| Input | CInt(teks) | Val(teks) | Integer.TryParse |
|---|---|---:|---|
| abc | InvalidCastException | 0 | False |
| 12abc | InvalidCastException | 12 | False |
| 3,5 | 35 atau 4 (*) | 3 | False |
| 999999999999 | OverflowException | 999999999999 | False |
| (kosong) | InvalidCastException | 0 | False |

(*) tergantung pengaturan bahasa Windows.

Val tidak pernah error, dan justru itu bahayanya: data yang salah tersimpan diam-diam. CInt melempar exception. Untuk validasi, pakai TryParse: hasilnya True atau False tanpa exception.

## Validasi Tipe Data: TryParse

TryParse tidak melempar exception. Ia mengembalikan True atau False, dan jika berhasil mengisi variabel di parameter kedua, sehingga variabel itu harus dideklarasikan lebih dulu. Tersedia juga Long.TryParse, Decimal.TryParse, Double.TryParse, dan Date.TryParse.

```vb
Private Sub btnTryParse_Click(sender As Object, e As EventArgs) Handles btnTryParse.Click
    Dim angka As Integer
    If Integer.TryParse(txtInput.Text, angka) Then
        lblHasil.Text = "Valid. Nilai angka = " & angka.ToString()
    Else
        lblHasil.Text = "Bukan bilangan bulat yang valid. Tidak ada exception."
    End If
End Sub
```

## Jebakan Desimal: Koma atau Titik

Windows berbahasa Indonesia memakai koma sebagai pemisah desimal dan titik sebagai pemisah ribuan. Akibatnya Decimal.TryParse("3.75") di komputer itu menghasilkan 375, bukan 3,75. Solusinya: terima koma maupun titik, ubah ke titik, lalu baca dengan aturan tetap (InvariantCulture).

```vb
' Mengubah teks desimal menjadi Decimal. Koma dan titik sama-sama diterima,
' sehingga hasilnya tidak bergantung pada pengaturan bahasa Windows.
Public Function CobaDesimal(teks As String, ByRef hasil As Decimal) As Boolean
    Dim teksTitik As String = teks.Trim().Replace(",", ".")
    Return Decimal.TryParse(teksTitik, NumberStyles.AllowDecimalPoint,
                            CultureInfo.InvariantCulture, hasil)
End Function
```

## ErrorProvider

Lima isian salah berarti lima MessageBox beruntun, dan setelah ditutup pengguna lupa isian mana yang salah.

ErrorProvider memasang ikon merah di samping kontrol; pesannya muncul saat kursor diarahkan. Komponen ini tampil di component tray, bukan di atas form.

```vb
errInput.SetError(txtNama, "pesan")
errInput.SetError(txtNama, "")
errInput.Clear()
```

## Fungsi ValidasiInput()

Pola: hapus tanda lama, periksa setiap isian, pasang tanda pada yang salah, lalu kembalikan True atau False.

Semua isian tetap diperiksa, sehingga pengguna melihat semua kesalahan sekaligus.

NIM, Jurusan, dan IPK mengikuti pola yang sama. Kode lengkap ada di materi.

```vb
Private Function ValidasiInput() As Boolean
    errInput.Clear()                  ' hapus semua tanda error lama
    Dim valid As Boolean = True

    If Kosong(txtNama.Text) Then
        errInput.SetError(txtNama, "Nama wajib diisi.")
        valid = False
    End If

    Dim angkatan As Integer
    If Not Integer.TryParse(txtAngkatan.Text, angkatan) OrElse
       angkatan < 2015 OrElse angkatan > Date.Today.Year Then
        errInput.SetError(txtAngkatan, "Angkatan harus angka 2015 s.d. tahun ini.")
        valid = False
    End If
```

## Klik Tombol atau Validating?

**Klik tombol:** semua isian dicek sekaligus saat Simpan diklik. Sederhana, jadi pemeriksaan utama.

**Validating:** dicek setiap kali fokus keluar dari kontrol, umpan balik lebih cepat. Hindari e.Cancel = True: fokus terkunci dan tombol lain tidak bisa diklik, kecuali tombol itu diberi CausesValidation = False.

```vb
' Validasi per kontrol: berjalan saat fokus meninggalkan txtNim
Private Sub txtNim_Validating(sender As Object, e As CancelEventArgs) Handles txtNim.Validating
    If txtNim.Text = "" Then Return        ' kosong dicek nanti saat Simpan

    If SemuaDigit(txtNim.Text, 9) Then
        errInput.SetError(txtNim, "")
    Else
        errInput.SetError(txtNim, "NIM harus 9 digit angka.")
        ' e.Cancel = True akan menahan fokus di txtNim. Sengaja tidak dipakai.
    End If
End Sub
```

## Alur Tombol Simpan

1. Klik btnSimpan.
2. Jalankan ValidasiInput().
3. Periksa apakah semua isian valid.
   - **Ya:** konversi isian (pasti berhasil), tambahkan ke daftar, lalu jalankan BersihkanForm().
   - **Tidak:** pasang ikon merah, tampilkan status, lalu Return.

Tombol Simpan tidak memakai Try...Catch: semua input yang salah sudah dicegah oleh validasi. Try...Catch dipakai di tombol Ekspor, karena menulis file berada di luar kendali program.

## Kode Tombol Simpan

Pola “periksa dulu, keluar jika gagal”: Return menghentikan Sub saat validasi gagal. Setelah lolos, konversi pasti berhasil, jadi tidak perlu Try...Catch.

```vb
Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    If Not ValidasiInput() Then
        lblStatus.Text = "Periksa isian yang bertanda merah."
        Return
    End If

    ' Semua isian sudah valid, jadi konversi di bawah ini tidak perlu Try...Catch
    Dim ipk As Decimal
    CobaDesimal(txtIpk.Text, ipk)
    lstMahasiswa.Items.Add(txtNim.Text & " | " & txtNama.Text.Trim() & " | " &
                           cboJurusan.Text & " | " & txtAngkatan.Text & " | " &
                           ipk.ToString("0.00"))
    daftarNim.Add(txtNim.Text)
    lblStatus.Text = "Data " & txtNama.Text.Trim() & " tersimpan."
    BersihkanForm()
End Sub
```

## Kesalahan Umum

1. Catch kosong: error disembunyikan, data tidak tersimpan tanpa peringatan.
2. Memakai Val untuk validasi: "12abc" lolos sebagai 12.
3. Ikon ErrorProvider tidak dihapus setelah isian diperbaiki.
4. TryParse tanpa cek rentang: angkatan 3000 tetap lolos.
5. ex.ToString() ditampilkan apa adanya ke pengguna.
6. Catch Exception diletakkan paling atas.
7. Name kontrol diganti setelah event dibuat.

## Ringkasan

1. Nama kontrol: prefix + NamaFungsi (txtNama, btnSimpan). Ganti Name sebelum membuat event.
2. Try...Catch hanya untuk runtime error. Finally selalu dijalankan.
3. Catch yang spesifik di atas, Exception paling bawah.
4. Validasi dengan TryParse lalu cek rentang, bukan Val. Waspadai koma dan titik.
5. ErrorProvider menandai kontrol yang salah; kumpulkan pemeriksaan dalam ValidasiInput().
6. Cegah yang bisa dicegah, tangkap yang tidak bisa dicegah.