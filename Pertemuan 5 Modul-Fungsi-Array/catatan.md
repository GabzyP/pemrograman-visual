# Modul, Fungsi, Array dan Koleksi Data

## Modul

Modul adalah bagian dari program yang digunakan untuk mengelompokkan kode berdasarkan fungsi atau kebutuhan tertentu. Dengan menggunakan Module, kode program dapat dipisahkan dari kode Form sehingga program menjadi lebih terstruktur dan mudah dikelola.

Contoh susunan proyek pada Solution Explorer:

- ProjectVB
    - My Project
    - Form1.vb
    - ModPerhitungan.vb

Contoh isi file `ModPerhitungan.vb`:

```vb
Module ModPerhitungan
    ' Tempat untuk menulis fungsi, prosedur,
    ' dan variabel sesuai kebutuhan
End Module
```

## Access Modifier

Access Modifier adalah pengaturan yang menentukan tingkat akses terhadap suatu anggota program. Pada materi ini, fokus utama adalah menggunakan Public dan Private.

```vb
Module ModPerhitungan
    Public nilai As Integer = 80
    Private hasil As Integer = 100
End Module
```

### Perbedaan Public dan Private

#### Public

Dapat diakses oleh bagian program lain yang memiliki akses.

```vb
Module ModPerhitungan
    Public nilai As Integer = 80
End Module
```

```vb
' Form1.vb
MessageBox.Show(nilai.ToString())
```

Hasil akses: **Bisa Diakses**.

#### Private

Hanya dapat diakses dari dalam modul itu sendiri.

```vb
Module ModPerhitungan
    Private nilai As Integer = 80
End Module
```

```vb
' Form1.vb
MessageBox.Show(nilai.ToString())
```

Hasil akses: **Tidak Bisa Diakses**.

## Procedure

Procedure adalah sekumpulan perintah yang dibuat untuk melakukan tugas tertentu dan dapat dipanggil ketika diperlukan. Pada VB.NET, Procedure dapat dibuat menggunakan Sub.

```vb
Module ModPerhitungan
    Public Sub TampilkanPesan()
        MessageBox.Show("Halo dari Procedure!")
    End Sub
End Module
```

Procedure (Sub) `TampilkanPesan()` dipanggil ketika diperlukan.

## Fungsi

Function adalah blok kode yang digunakan untuk melakukan suatu proses dan mengembalikan nilai. Function cocok digunakan ketika hasil dari suatu proses perlu digunakan kembali oleh bagian program lain.

Contoh input parameter:

- `panjang`: 10
- `lebar`: 5

```vb
Module ModPerhitungan
    Public Function HitungLuas(
        panjang As Integer,
        lebar As Integer) As Integer
        Return panjang * lebar
    End Function
End Module
```

Proses menghitung luas mengembalikan nilai. **Hasil:** 50.

## Array

Array adalah struktur data yang digunakan untuk menyimpan beberapa nilai dalam satu variabel dengan tipe data yang sama. Setiap elemen Array memiliki index. Pada VB.NET, index Array dimulai dari 0.

### Array Satu Dimensi

Jenis array paling sederhana yang menyimpan sekumpulan data secara linier dalam satu baris. Pengaksesan elemen hanya membutuhkan satu indeks.

Contoh index dan nilai:

| Index | 0 | 1 | 2 | 3 | 4 |
|---|---:|---:|---:|---:|---:|
| Nilai | 10 | 20 | 30 | 40 | 50 |

Contoh kode (1 Dimensi):

```vb
Dim nilai() As Integer = {
    10, 20, 30, 40, 50
}
Console.WriteLine(nilai(2))
```

### Array Multi-Dimensi

Array yang memiliki dua dimensi atau lebih, membentuk struktur layaknya matriks (baris dan kolom) atau ruang 3D. Seluruh baris dalam array ini wajib memiliki jumlah kolom yang sama.

#### Array Dua Dimensi

Array dua dimensi menggunakan indeks baris (i) dan kolom (j). Contoh nilai:

| Baris (i) \ Kolom (j) | 0 | 1 | 2 |
|---:|---:|---:|---:|
| 0 | 10 | 20 | 30 |
| 1 | 40 | 50 | 60 |
| 2 | 70 | 80 | 90 |

Contoh kode (2 Dimensi):

```vb
Dim data(,) As Integer = {
    {10, 20, 30},
    {40, 50, 60},
    {70, 80, 90}
}
Console.WriteLine(data(1, 2))
```

#### Array Multi-Dimensi (3 Dimensi)

Array tiga dimensi menggunakan indeks kedalaman (k), baris (i), dan kolom (j).

Nilai yang ditampilkan pada diagram:

- Lapisan pertama: `1`, `2`, `3`; `4`, `5`, `6`; `7`, `8`, `9`.
- Lapisan kedua: `10`, `11`, `12`; `13`, `14`, `15`; `16`, `17`, `18`.

Contoh kode (3 Dimensi):

```vb
Dim data(,,) As Integer = {
    {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}},
    {{10, 11, 12}, {13, 14, 15}, {16, 17, 18}}
}
Console.WriteLine(data(1, 2, 0))
```

## Koleksi Data

Koleksi Data adalah struktur data yang digunakan untuk menyimpan dan mengelola sekumpulan objek atau nilai. Koleksi Data menyediakan berbagai cara untuk:

- Menambahkan data.
- Menghapus data.
- Mengakses data.
- Mencari data.
- Mengiterasi data.

Berbeda dengan Array, beberapa jenis Koleksi Data dapat bertambah atau berkurang ukurannya secara dinamis.

## Jenis-jenis Koleksi Data

Koleksi data adalah struktur data yang digunakan untuk menyimpan sekumpulan nilai dalam satu variabel.

### Array

Array adalah koleksi data dengan ukuran tetap dan semua elemennya bertipe data sama.

| Index | 0 | 1 | 2 | 3 | 4 |
|---|---:|---:|---:|---:|---:|
| Nilai | 10 | 20 | 30 | 40 | 50 |

**Ciri-ciri:**

- Ukuran tetap (tidak bisa berubah).
- Elemen bertipe data sama.
- Diakses menggunakan index.
- Index dimulai dari 0.

**Contoh (VB.NET):**

```vb
Dim nilai() As Integer = {10, 20, 30, 40, 50}
Console.WriteLine(nilai(0)) ' 10
```

### List

List adalah koleksi data dinamis yang dapat bertambah atau berkurang ukurannya. Semua elemennya bertipe data sama.

| Index | [0] | [1] | [2] | [3] | [4] |
|---|---:|---:|---:|---:|---:|
| Nilai | 10 | 20 | 30 | 40 | 50 |

**Ciri-ciri:**

- Ukuran dapat berubah (dinamis).
- Elemen bertipe data sama.
- Diakses menggunakan index.
- Memiliki banyak method untuk menambah, menghapus, dll.

**Contoh (VB.NET):**

```vb
Dim angka As New List(Of Integer)
angka.Add(10)
angka.Add(20)
angka.Add(30)
Console.WriteLine(angka(0)) ' 10
```

### Dictionary

Dictionary adalah koleksi data dalam bentuk pasangan key-value. Setiap key bersifat unik dan digunakan untuk mengakses value.

| Key | Value |
|---|---|
| "NIM" | "241712051" |
| "Nama" | "Nadya" |
| "Prodi" | "Sistem Informasi" |

**Ciri-ciri:**

- Menyimpan data dalam pasangan key-value.
- Key bersifat unik (tidak boleh sama).
- Diakses menggunakan key.
- Cocok untuk data yang memiliki label atau identitas.

**Contoh (VB.NET):**

```vb
Dim mhs As New Dictionary(Of String, String)
mhs.Add("NIM", "241712051")
mhs.Add("Nama", "Nadya")
mhs.Add("Prodi", "Sistem Informasi")
Console.WriteLine(mhs("Nama")) ' Nadya
```

### Set

Set adalah koleksi data unik yang tidak mengizinkan adanya duplikasi. Setiap elemen hanya dapat muncul satu kali.

Contoh nilai pada diagram: `10`, `20`, `30`, `40`.

**Ciri-ciri:**

- Menyimpan data yang unik (tidak ada duplikasi).
- Elemen bertipe data sama.
- Tidak memiliki index.
- Cocok untuk menyimpan data dengan nilai yang tidak boleh sama.

**Contoh (VB.NET):**

```vb
Dim angka As New HashSet(Of Integer)
angka.Add(10)
angka.Add(20)
angka.Add(20) ' tidak akan ditambahkan
Console.WriteLine(angka.Count) ' 2
```