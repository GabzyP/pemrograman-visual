# Operator dan Struktur Pengendalian

## Pembahasan

- Menjelaskan operator dan jenis-jenisnya
- Menjelaskan ekspresi
- Menjelaskan percabangan

## Operator

Simbol khusus yang digunakan untuk melakukan operasi tertentu pada satu atau lebih nilai, yang disebut operand. Seperti yang kita ketahui operator terbagi menjadi beberapa jenis, yaitu:

1. **Operator Aritmatika** — `+`, `-`, `*`, `/`, `%`
2. **Operator Penugasan** — `=`, `+=`, `-=`, `*=`, `/=`, `%=`
3. **Operator Perbandingan** — `==`, `!=`, `>`, `<`, `>=`, `<=`
4. **Operator Logika** — `&&`, `||`, `!`
5. **Operator Increment dan Decrement** — `++`, `--`

## Operator Aritmatika

Operator aritmatika adalah simbol yang digunakan untuk melakukan operasi matematika dasar pada nilai numerik atau variabel.

| Operator | Simbol | Nama Operator | Deskripsi | Contoh |
|---|---|---|---|---|
| `+` | `+` | Penjumlahan | Menjumlahkan dua nilai | `5 + 3 = 8`<br>`a + b` |
| `-` | `-` | Pengurangan | Mengurangi nilai satu dengan nilai lain | `7 - 4 = 3`<br>`a - b` |
| `×` | `*` | Perkalian | Mengalikan dua nilai | `6 * 2 = 12`<br>`a * b` |
| `÷` | `/` | Pembagian | Membagi nilai satu dengan nilai lain | `10 / 2 = 5`<br>`a / b` |
| `%` | `%` | Modulus (Sisa Bagi) | Menghasilkan sisa pembagian | `10 % 3 = 1`<br>`a % b` |

## Operator Penugasan

Operator penugasan (assignment operator) adalah operator yang digunakan untuk memberikan nilai ke sebuah variabel.

| Simbol | Nama Operator | Deskripsi | Ekuivalen | Contoh |
|---|---|---|---|---|
| `=` | Penugasan sederhana | Memberikan nilai ke variabel. | `a = b` | `x = 10` |
| `+=` | Tambah dan tugas | Menambahkan nilai ke variabel. | `a = a + b` | `x += 5` |
| `-=` | Kurang dan tugas | Mengurangi nilai dari variabel. | `a = a - b` | `x -= 3` |
| `*=` | Kali dan tugas | Mengalikan nilai dengan variabel. | `a = a * b` | `x *= 2` |
| `/=` | Bagi dan tugas | Membagi nilai dengan variabel. | `a = a / b` | `x /= 4` |
| `%=` | Modulus dan tugas | Mengambil sisa bagi ke variabel. | `a = a % b` | `x %= 3` |

## Operator Perbandingan

Operator perbandingan adalah simbol yang digunakan untuk membandingkan dua nilai (seperti angka atau teks) dan menghasilkan nilai boolean (benar atau salah, atau true/false) sebagai hasilnya.

| Operator | Simbol | Nama Operator | Deskripsi | Contoh |
|---|---|---|---|---|
| `=` | `=` | Sama dengan | Mengecek apakah dua nilai sama. | `5 = 5 → True`<br>`a = b` |
| `<>` | `<>` | Tidak sama dengan | Mengecek apakah dua nilai tidak sama. | `5 <> 3 → True`<br>`a <> b` |
| `>` | `>` | Lebih besar dari | Mengecek apakah nilai kiri lebih besar dari nilai kanan. | `7 > 3 → True`<br>`a > b` |
| `<` | `<` | Lebih kecil dari | Mengecek apakah nilai kiri lebih kecil dari nilai kanan. | `2 < 4 → True`<br>`a < b` |
| `>=` | `>=` | Lebih besar atau sama dengan | Mengecek apakah nilai kiri lebih besar atau sama dengan nilai kanan. | `5 >= 5 → True`<br>`a >= b` |
| `<=` | `<=` | Lebih kecil atau sama dengan | Mengecek apakah nilai kiri lebih kecil atau sama dengan nilai kanan. | `3 <= 7 → True`<br>`a <= b` |

## Operator Logika

Operator logika adalah simbol atau kata yang menghubungkan beberapa ekspresi boolean (benar atau salah) untuk menghasilkan satu nilai kebenaran (boolean) berdasarkan nilai kebenaran dari ekspresi-ekspresi tersebut.

| Operator | Simbol | Nama Operator | Deskripsi |
|---|---|---|---|
| AND | And | Dan (AND) | Menghasilkan True hanya jika kedua kondisi bernilai True. |
| OR | Or | Atau (OR) | Menghasilkan True jika salah satu atau kedua kondisi bernilai True. |
| NOT | Not | Bukan (NOT) | Membalikkan nilai logika. Jika kondisi True menjadi False, dan sebaliknya. |
| XOR | Xor | Eksklusif Atau (XOR) | Menghasilkan True jika salah satu kondisi True, tetapi tidak keduanya. |
| NOR | Not (A Or B) | Bukan Atau (NOR) | Kebalikan dari OR. Menghasilkan True hanya jika kedua kondisi bernilai False. |
| NAND | Not (A And B) | Bukan Dan (NAND) | Kebalikan dari AND. Menghasilkan True kecuali jika kedua kondisi bernilai True. |

## Operator Increment dan Decrement

Operator increment (`++`) digunakan untuk menambahkan nilai variabel sebanyak satu, sedangkan operator decrement (`--`) digunakan untuk mengurangi nilai variabel sebanyak satu.

### Increment (+1)

Menambah nilai variabel sebesar 1.

| Operator | Nama Operator | Deskripsi | Contoh |
|---|---|---|---|
| `++x` | Pre-increment | Menambah nilai variabel terlebih dahulu, kemudian digunakan. | `x = ++x`<br>`' x = x + 1` |
| `x++` | Post-increment | Menggunakan nilai variabel dahulu, kemudian menambah nilai variabel. | `x = x++`<br>`' x = x + 1 (setelah digunakan)` |
| `x += 1` | Increment singkatan | Menambah nilai variabel sebesar 1 (bentuk singkatan). | `x += 1`<br>`' x = x + 1` |

### Decrement (-1)

Mengurangi nilai variabel sebesar 1.

| Operator | Nama Operator | Deskripsi | Contoh |
|---|---|---|---|
| `--x` | Pre-decrement | Mengurangi nilai variabel terlebih dahulu, kemudian digunakan. | `x = --x`<br>`' x = x - 1` |
| `x--` | Post-decrement | Menggunakan nilai variabel dahulu, kemudian mengurangi nilai variabel. | `x = x--`<br>`' x = x - 1 (setelah digunakan)` |
| `x -= 1` | Decrement singkatan | Mengurangi nilai variabel sebesar 1 (bentuk singkatan). | `x -= 1`<br>`' x = x - 1` |

## Ekspresi

Ekspresi adalah kombinasi dari nilai, variabel, operator, dan panggilan metode yang mengevaluasi ke satu nilai tunggal. Ekspresi adalah blok kode yang menghasilkan sebuah nilai dan dapat digunakan di mana pun nilai dibutuhkan. Dengan kata lain, ekspresi adalah potongan kode yang menghasilkan suatu nilai ketika dijalankan.

## Percabangan

Percabangan adalah struktur kontrol alur program yang digunakan untuk menentukan jalannya eksekusi berdasarkan kondisi tertentu (benar atau salah). Percabangan terbagi menjadi beberapa jenis sebagai berikut:

1. If Statement
2. If - Else Statement
3. If - Else if Statement
4. Switch Statement
5. Operator Ternary

Alur umum pada diagram percabangan:

- `START` → `KONDISI?`
- `BENAR` → `AKSI 1`
- `SALAH` → `AKSI 2`
- Jalur berlanjut ke `SELESAI`.

### If Statement

Percabangan if merupakan percabangan yang hanya memiliki satu blok pilihan saat kondisi bernilai benar.

Alur diagram:

- `START` → `KONDISI?`
- Jika `BENAR` → `BLOK KODE` → `SELESAI`
- Jika `SALAH` → `SELESAI`

### If Else Statement

Menjalankan satu blok kode jika kondisi benar, dan blok lain jika salah.

Alur diagram:

- `START` → `KONDISI`
- Jika `BENAR` → `BLOK KODE 1`
- Jika `SALAH` → `BLOK KODE 2`
- Kedua jalur berlanjut ke `SELESAI`.

### If Else if Statement

Digunakan jika ada beberapa kondisi yang harus diperiksa.

Alur diagram:

- `START` → `KONDISI 1`
- Jika `BENAR` → `BLOK KODE 1`
- Jika `SALAH` → periksa `KONDISI 2`.
- Jika kondisi berikutnya `BENAR` → `BLOK KODE 2`; jika `SALAH`, lanjutkan pemeriksaan kondisi berikutnya sampai `BLOK KODE N`.
- Jalur yang dijalankan berlanjut ke `SELESAI`.

### Switch Statement

Alternatif dari if...else yang banyak, lebih rapi jika memilih berdasarkan nilai variabel.

#### Contoh kode

```vb
Select Case nilai
    Case 1
        hasil = "Sangat Baik"
    Case 2
        hasil = "Baik"
    Case 3
        hasil = "Cukup"
    Case Else
        hasil = "Kurang"
End Select
```

#### Alur diagram

`MULAI` → `Input nilai` → `nilai = ?`

- `1` → `Sangat Baik`
- `2` → `Baik`
- `3` → `Cukup`
- `Lainnya` → `Kurang`

Semua pilihan berlanjut ke `SELESAI`.

### Operator Ternary

Percabangan singkat dalam satu baris (pengganti if...else).

#### Contoh kode

```vb
Dim nilai As Integer = 75
Dim status As String
status = If(nilai >= 75, "Lulus", "Tidak Lulus")
```

#### Alur diagram

`MULAI` → `Input nilai` → `nilai >= 75?`

- `YA (True)` → `status = "Lulus"`
- `TIDAK (False)` → `status = "Tidak Lulus"`

Kedua jalur berlanjut ke `SELESAI`.