# DataGridView, Array & Koleksi Data

## Pembahasan

- DataGridView
- Mengisi grid dari Array
- List(Of T), DataTable, dan BindingSource
- Merapikan tampilan kolom
- Pencarian data

## Recap: Array

Ukuran tetap sejak dibuat: Dim nilai(4) As Integer berisi 5 elemen, indeks 0 sampai 4.

Semua elemen satu tipe data. Menambah elemen perlu ReDim Preserve.

## Recap: List(Of T)

Ukuran dinamis: Add menambah, Remove menghapus, Count menghitung jumlah isi.

Pertemuan ini: isi Array dan List(Of T) ditampilkan dalam bentuk tabel.

## Banyak Data, Banyak Kolom

Contoh isi ListBox:

```text
231712001 | Andi Pratama | Teknik Informatika | 2023 | 3,45
231712002 | Sari Wulandari | Sistem Informasi | 2023 | 3,80
221712015 | Budi Santoso | Teknik Informatika | 2022 | 3,12
241712007 | Dimas Siregar | Teknik Komputer | 2024 | 2,95
221712020 | Rina Marpaung | Manajemen Informatika | 2022 | 3,50
... dan 25 baris lagi
```

30 mahasiswa dengan 5 data per orang di ListBox: kolom tidak sejajar, sulit dibaca, tidak bisa diurutkan per kolom, dan untuk mengambil IPK satu mahasiswa teksnya harus dipotong-potong.

Data berbentuk tabel butuh kontrol yang juga berbentuk tabel.

## Mengenal DataGridView

DataGridView (prefix dgv, ada di Toolbox grup Data) menampilkan data dalam baris dan kolom, seperti lembar kerja Excel.

Satu sel diakses lewat Rows(1).Cells(2).Value: baris indeks 1, kolom indeks 2. Seperti Array, indeks dimulai dari 0.

Contoh tabel:

| NIM | Nama | Jurusan | Angkatan | IPK |
|---|---|---|---:|---:|
| 231712001 | Andi Pratama | Teknik Informatika | 2023 | 3,45 |
| 231712002 | Sari Wulandari | Sistem Informasi | 2023 | 3,80 |
| 221712015 | Budi Santoso | Teknik Informatika | 2022 | 3,12 |
| 241712007 | Dimas Siregar | Teknik Komputer | 2024 | 2,95 |

Bagian DataGridView:

- Row Header
- Column Header
- Row
- Column
- Cell: Rows(1).Cells(2)

## Cara 1: Manual (unbound)

Kolom dibuat sendiri, lalu baris ditambah satu per satu dengan Rows.Add. Data disimpan di grid itu sendiri. Cocok untuk data sedikit dan statis.

## Cara 2: Lewat DataSource (bound)

Grid mengikuti isi sumber data (List, DataTable) dan kolom bisa dibuat otomatis. Cocok untuk hampir semua kasus nyata.

Jangan dicampur: setelah DataSource diisi, Rows.Add memicu InvalidOperationException.

## Mengisi Grid dari Array 2D

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    dgvMahasiswa.Rows.Clear()
    For i As Integer = 0 To dataMahasiswa.GetUpperBound(0)  ' baris
        Dim indeksBaris As Integer = dgvMahasiswa.Rows.Add()
        For j As Integer = 0 To dataMahasiswa.GetUpperBound(1)  ' kolom
            dgvMahasiswa.Rows(indeksBaris).Cells(j).Value = dataMahasiswa(i, j)
        Next
    Next
    lblJumlah.Text = "Jumlah data: " & dgvMahasiswa.Rows.Count.ToString()
End Sub
```

Perulangan luar (i) = baris, perulangan dalam (j) = kolom: nested loop dari Pertemuan 4.

Rows.Add() menambah satu baris kosong dan mengembalikan indeksnya. Rows.Clear() di awal mencegah data dobel saat tombol diklik dua kali.

## Hasil dan Keterbatasan Array

1. Semua nilai String: IPK tidak bisa langsung dihitung tanpa konversi.
2. Ukuran tetap: ReDim Preserve hanya mengubah dimensi terakhir, padahal yang ingin ditambah adalah baris.
3. Data disalin ke grid: Array berubah, grid tidak ikut berubah.
4. dataMahasiswa(i, 3) itu angkatan atau IPK? Nomor kolom mudah tertukar.

Contoh tampilan form:

**Data dari Array 2 Dimensi**

| NIM | Nama | Jurusan | Angkatan | IPK |
|---|---|---|---:|---:|
| 231712001 | Andi Pratama | Teknik Informatika | 2023 | 3.45 |
| 231712002 | Sari Wulandari | Sistem Informasi | 2023 | 3.8 |
| 221712015 | Budi Santoso | Teknik Informatika | 2022 | 3.12 |
| 241712007 | Dimas Siregar | Teknik Komputer | 2024 | 2.95 |
| 221712020 | Rina Marpaung | Manajemen Informatika | 2022 | 3.5 |
| 241712011 | Putri Lubis | Sistem Informasi | 2024 | 3.91 |
| 231712019 | Fajar Nasution | Teknik Informatika | 2023 | 3.28 |
| 221712031 | Maya Sari Hasibuan | Teknik Komputer | 2022 | 3.55 |

Tombol: Tampilkan, Kosongkan.  
Jumlah data: 8

## Satu Baris = Satu Objek

```vb
Public Class Mahasiswa
    Public Property Nim As String
    Public Property Nama As String
    Public Property Jurusan As String
    Public Property Angkatan As Integer
    Public Property Ipk As Decimal

    Public Sub New(nim As String, nama As String, jurusan As String, angkatan As Integer, ipk As Decimal)
        Me.Nim = nim
        Me.Nama = nama
        Me.Jurusan = jurusan
        Me.Angkatan = angkatan
        Me.Ipk = ipk
    End Sub
End Class
```

Class = cetakan. Setiap New Mahasiswa(...) adalah satu objek, yaitu satu baris di grid.

## Menampilkan List(Of Mahasiswa)

```vb
Private ReadOnly daftarMahasiswa As New List(Of Mahasiswa)

Private Sub FrmDariList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    daftarMahasiswa.Add(New Mahasiswa("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D))
    daftarMahasiswa.Add(New Mahasiswa("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D))
    daftarMahasiswa.Add(New Mahasiswa("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D))
    daftarMahasiswa.Add(New Mahasiswa("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D))

    bsMahasiswa.DataSource = daftarMahasiswa  ' List -> BindingSource
    dgvMahasiswa.DataSource = bsMahasiswa     ' BindingSource -> DataGridView
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
End Sub
```

Tidak ada perulangan. Setelah DataSource diisi, grid membuat satu kolom untuk setiap Public Property dan satu baris untuk setiap objek di List.

Polanya: List → BindingSource (bsMahasiswa) → DataGridView.

## Menambah Data ke List

```vb
Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    If Not ValidasiInput() Then Return
    Dim ipk As Decimal
    CobaDesimal(txtIpk.Text, ipk)
    Dim baru As New Mahasiswa(txtNim.Text, txtNama.Text.Trim(), cboJurusan.Text,
                               Integer.Parse(txtAngkatan.Text), ipk)
    ' Tambah lewat BindingSource, bukan daftarMahasiswa.Add, agar grid langsung diperbarui
    bsMahasiswa.Add(baru)
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
    BersihkanInput()
End Sub
```

List(Of T) tidak memberi tahu grid saat isinya berubah. bsMahasiswa.Add menambah objek ke List yang sama sekaligus memberi tahu grid.

Terlanjur memakai daftarMahasiswa.Add? Panggil bsMahasiswa.ResetBindings(False).

## DataTable: Tabel di Memori

```vb
Private Function BuatTabelMahasiswa() As DataTable
    Dim tabel As New DataTable("Mahasiswa")
    ' Kolom: nama dan tipe data
    tabel.Columns.Add("Nim", GetType(String))
    tabel.Columns.Add("Nama", GetType(String))
    tabel.Columns.Add("Jurusan", GetType(String))
    tabel.Columns.Add("Angkatan", GetType(Integer))
    tabel.Columns.Add("Ipk", GetType(Decimal))
    ' Baris: urutan nilai mengikuti urutan kolom
    tabel.Rows.Add("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D)
    tabel.Rows.Add("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D)
    tabel.Rows.Add("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D)
    Return tabel
End Function
```

Kolom punya nama dan tipe (Columns.Add). Baris diisi sesuai urutan kolom (Rows.Add); nilai yang tidak cocok dengan tipe kolom menghasilkan exception.

Ditampilkan dengan pola yang sama: bsMahasiswa.DataSource = tabelMahasiswa.

## BindingSource: Perantara

```text
Sumber Data                → BindingSource                 → DataGridView
List(Of T) atau DataTable    Filter, Sort, Count, Add, Current   kontrol yang menampilkan
```

Analogi: petugas meja layanan perpustakaan. Rak buku (sumber data) tetap utuh. Petugas menentukan buku mana yang ditunjukkan (Filter), urutannya (Sort), dan mencatat buku baru (Add). Pengunjung (grid) cukup berurusan dengan petugas.

Sumber data diganti? Cukup ubah satu baris: bsMahasiswa.DataSource = ...

BindingSource diambil dari Toolbox grup Data dan diberi prefix bs. Seperti ErrorProvider, komponen ini tampil di component tray, bukan di atas form.

## Memilih Sumber Data

| Aspek | Array | List(Of T) + Class | DataTable |
|---|---|---|---|
| Ukuran | Tetap | Dinamis | Dinamis |
| Tipe per kolom | Satu tipe | Sesuai Property | Sesuai kolom |
| Mengisi grid | Rows.Add | DataSource | DataSource |
| Kolom grid | Dibuat sendiri | Otomatis | Otomatis |
| Urut lewat header | Ya (sebagai teks) | Tidak | Ya |
| BindingSource.Filter | Tidak | Tidak (diabaikan) | Ya |
| Cocok untuk | Data kecil, tetap | Data diolah di kode | Butuh filter dan sort |

Catatan: Array diurutkan lewat header sebagai teks, sehingga "10" ditempatkan sebelum "9".

## Merapikan Tampilan Kolom

```vb
' Kolom dibuat otomatis saat DataSource diisi, jadi pengaturannya dilakukan sesudahnya
Private Sub AturKolom()
    dgvMahasiswa.Columns("Nim").HeaderText = "NIM"
    dgvMahasiswa.Columns("Ipk").HeaderText = "IPK"
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Format = "N2"
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    dgvMahasiswa.Columns("Angkatan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dgvMahasiswa.Columns("Nama").FillWeight = 200
    dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
End Sub
```

Pengaturan grid (ReadOnly, SelectionMode, AllowUserToAddRows) cukup diatur di Designer.

Pengaturan kolom otomatis ditulis di kode setelah DataSource diisi, karena kolomnya baru ada saat itu. Format "N2" membuat IPK selalu dua desimal: 3,80 bukan 3,8.

## Pencarian 1: BindingSource.Filter

```vb
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
    If kata = "" Then
        bsMahasiswa.RemoveFilter()  ' tampilkan semua data
    Else
        ' Ekspresi Filter milik DataTable, diproses di memori, bukan perintah SQL
        bsMahasiswa.Filter = "Nama LIKE '%" & kata & "%' OR Nim LIKE '%" & kata & "%'"
    End If
    PerbaruiJumlah()
End Sub
```

LIKE '%sari%' berarti “mengandung sari”. Ekspresi ini mirip SQL, tetapi bukan SQL: milik DataTable dan diproses di memori. Data asli tidak berubah, baris yang tidak cocok hanya disembunyikan.

AmankanTeksFilter menangani ' [ ] * % agar mencari nama seperti Ma'ruf tidak membuat error.

## Pencarian 2: Perulangan

```vb
' List(Of T) tidak mendukung BindingSource.Filter, jadi pencarian dilakukan dengan perulangan
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    Dim kata As String = txtCari.Text.Trim().ToLower()
    Dim hasil As New List(Of Mahasiswa)
    For Each mhs As Mahasiswa In daftarMahasiswa
        If mhs.Nama.ToLower().Contains(kata) OrElse mhs.Nim.Contains(kata) Then
            hasil.Add(mhs)
        End If
    Next
    bsMahasiswa.DataSource = hasil
    lblJumlah.Text = "Menampilkan " & hasil.Count.ToString() & " dari " &
                     daftarMahasiswa.Count.ToString() & " data"
End Sub
```

Filter pada List diabaikan tanpa error, jadi pencarian dibuat sendiri: objek yang cocok dikumpulkan ke List baru (hasil), data asli tidak diubah.

## Filter atau Perulangan?

| Aspek | BindingSource.Filter | Perulangan For Each |
|---|---|---|
| Sumber data | DataTable | List(Of T) |
| Panjang kode | Pendek, satu ekspresi | Lebih panjang |
| Kondisi pencarian | Terbatas sintaks ekspresi | Bebas, apa pun di If |
| Karakter khusus | Harus diamankan | Tidak perlu |
| Data asli | Tidak berubah | Tidak berubah |
| Urut lewat header | Tetap bekerja | Tidak |

Keduanya bekerja di memori, pada data yang sudah dimuat ke aplikasi.

## Kesalahan Umum

1. Rows.Add pada grid yang memakai DataSource: InvalidOperationException
2. Rows.Add pada grid tanpa kolom: InvalidOperationException
3. Columns("...") diatur sebelum DataSource diisi: NullReferenceException
4. daftar.Add tanpa bsMahasiswa.Add atau ResetBindings: grid tidak berubah
5. Filter pada BindingSource bersumber List: diabaikan tanpa error
6. Tanda kutip tidak diamankan: error saat mencari Ma'ruf
7. List(Of String) sebagai DataSource: hanya muncul kolom Length
8. AllowUserToAddRows dibiarkan True: baris kosong * ikut terhitung

## Ringkasan

1. DataGridView menampilkan baris dan kolom; pengaturan grid diatur di Designer.
2. Isi manual (Rows.Add) atau lewat DataSource, jangan dicampur.
3. Array 2D masuk grid lewat nested loop, tetapi semua String dan ukurannya tetap.
4. Class + List(Of T): satu objek satu baris, Public Property menjadi kolom.
5. DataTable: tabel di memori yang mendukung Sort dan Filter.
6. BindingSource: perantara data dan grid; tambah data lewat bsMahasiswa.Add.
7. Atur kolom setelah DataSource diisi; cari dengan Filter (DataTable) atau perulangan (List).
