# Struktur Perulangan

## Perulangan (Looping)

Perulangan adalah struktur kontrol yang menjalankan sebuah blok instruksi berulang kali selama kondisi tertentu terpenuhi (boolean true) atau sebanyak jumlah pengulangan yang ditetapkan. Tujuan utamanya adalah untuk mengautomasi tugas berulang, memproses koleksi data (array/list), dan mengurangi duplikasi kode.

Contoh kode:

```vb
For i As Integer = 1 To 5
    ListBox1.Items.Add(i)
Next
```

**Proses Berulang** — nilai yang dihasilkan: `1`, `2`, `3`, `4`, `5`.

## Fungsi dan Manfaat

- Mempermudah dan Mempercepat Pekerjaan Berulang
- Menghindari Penulisan Kode Manual
- Pengolahan Data dalam Jumlah Besar
- Meningkatkan Struktur dan Pemeliharaan Kode
- Fleksibilitas

## Tipe Perulangan

### Counted Loop

Jumlah pengulangan sudah diketahui atau terhitung, misalnya perulangan menggunakan For di mana ada batas mulai dan akhir tertentu.

### Uncounted Loop

Jumlah pengulangan tidak diketahui, perulangan dilakukan selama kondisi tertentu bernilai benar, misalnya menggunakan While atau Do Loop yang bergantung pada kondisi yang diuji selama pemrosesan.

## For-Next

For-Next digunakan untuk mengulang perintah dengan jumlah pengulangan yang sudah pasti atau telah ditentukan di awal. Ini memungkinkan pelaksanaan blok kode secara sistematis sebanyak jumlah iterasi yang diinginkan tanpa perlu menentukan kondisi secara eksplisit dalam blok perulangan.

```vb
For i As Integer = 1 To 5
    ListBox1.Items.Add(i)
Next
```

Perintah di dalam blok For-Next akan diulang sebanyak jumlah iterasi yang ditentukan.

**Hasil:** `1`, `2`, `3`, `4`, `5`.

## Penggunaan Variabel Pengontrol

Variabel pengontrol adalah variabel yang mengatur jumlah pengulangan. Penentuan nilai awal, nilai akhir, dan langkah perulangan (step) harus sesuai kebutuhan, contohnya:

- Nilai awal 1 sampai 10 dengan step 1 untuk menaikkan nilai variabel setiap iterasi.
- Nilai awal 10 sampai 1 dengan step -1 untuk menurunkan nilai variabel setiap iterasi.

### Naik (Step 1)

Nilai awal 1 sampai 10 dengan step 1.

```vb
For i As Integer = 1 To 10
    ' perintah yang diulang
Next
```

Variabel pengontrol: `i`. Properti variabel pengontrol terdiri dari nilai awal, nilai akhir, dan langkah (step).

### Turun (Step -1)

Nilai awal 10 sampai 1 dengan step -1.

```vb
For i As Integer = 10 To 1 Step -1
    ' perintah yang diulang
Next
```

## Do-Loop

Do-Loop adalah jenis perulangan yang digunakan untuk kasus pengulangan dengan jumlah iterasi tidak diketahui sebelumnya. Perulangan terus berlanjut hingga kondisi berhenti terpenuhi.

```vb
Do
    ' perintah yang diulang
    ' misalnya menambah nilai
Loop While kondisi
```

Blok perintah akan diulang selama kondisi bernilai True. Perulangan berhenti ketika kondisi bernilai False.

Alur diagram:

`Mulai` → `Lakukan perintah` → `Kondisi True?`

- `Ya` → kembali ke `Lakukan perintah`.
- `Tidak` → `Selesai`.

**Hasil (contoh):** `1`, `2`, `3`, `4`, `5`.

## While

### Kondisi Dicek di Awal (While)

Perulangan hanya dijalankan jika kondisi awal bernilai true. Jika kondisi awal false, perulangan tidak akan dijalankan sama sekali.

#### Sintaks While

```vb
Dim i As Integer = 1
While i <= 10
    ListBox1.Items.Add(i)
    i = i + 1
End While
```

Blok perintah akan dijalankan selama kondisi bernilai True.

Alur diagram:

`Mulai` → `Inisialisasi variabel` → `Kondisi True?`

- `Ya` → `Lakukan perintah` → kembali ke pemeriksaan kondisi.
- `Tidak` → `Selesai`.

**Output (contoh):** `1`, `2`, `3`, `4`, `5`, `...`, `10`.

## Do - While

### Kondisi Dicek di Akhir (Do While)

Perulangan dijalankan minimal satu kali, karena kondisi dicek setelah blok perintah dieksekusi.

#### Sintaks Do While

```vb
Do While kondisi
    ' perintah yang diulang
    ' misalnya menambah nilai
    ' update variabel
Loop
```

Blok perintah akan dijalankan selama kondisi bernilai True. Kondisi diperiksa di awal.

Alur diagram:

`Mulai` → `Kondisi True?`

- `Ya` → `Lakukan perintah` → kembali ke pemeriksaan kondisi.
- `Tidak` → `Selesai`.

**Output (contoh):** `1`, `2`, `3`, `4`, `5`.

## Nested Loop

Nested Loop adalah perulangan yang terdapat di dalam perulangan lainnya. Perulangan luar akan menjalankan perulangan dalam secara lengkap pada setiap iterasinya.

```vb
For i As Integer = 1 To 3
    For j As Integer = 1 To 3
        ListBox1.Items.Add(i & " - " & j)
    Next
Next
```

- **Perulangan Luar (i):** `i = 1` → `i = 2` → `i = 3`.
- **Perulangan Dalam (j):** untuk setiap nilai `i`, nilai `j` berulang dari `1` sampai `3`.

Perulangan dalam (inner loop) akan dijalankan secara lengkap untuk setiap iterasi perulangan luar (outer loop).

**Output (contoh):**

```text
1 - 1
1 - 2
1 - 3
2 - 1
2 - 2
2 - 3
3 - 1
3 - 2
3 - 3
```