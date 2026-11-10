Option Strict On

Imports System.Globalization
Imports System.IO
Imports System.Text

Public Class FrmPeminjaman

    ' Daftar kode buku yang sedang dipinjam, dipake untuk mencegah pinjam double
    Private ReadOnly kodeDipinjam As New List(Of String)

    ' Membersihkan teks agar aman disimpan ke baris ListBox dan CSV (buang pemisah "|" dan ";")
    Private Function AmankanTeks(teks As String) As String
        Return teks.Trim().Replace("|", "/").Replace(";", ",")
    End Function

    ' Memperbarui label status dengan jumlah peminjaman saat ini
    Private Sub PerbaruiStatus()
        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
    End Sub

    ' Mengosongkan semua isian dan menghapus semua ikon ErrorProvider
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Memeriksa semua isian sekaligus memasang ikon error pada isian yang salah
    ' Mengembalikan True hanya jika semua isian valid
    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()                       ' hapus semua tanda error lama
        Dim valid As Boolean = True

        ' Kode buku format BK + 4 digit, lalu cek apakah sedang dipinjam
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode buku harus 'BK' diikuti 4 angka, contoh BK0012.")
            valid = False
        ElseIf kodeDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam")
            valid = False
        End If

        ' Judul wajib diisi
        If Kosong(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi")
            valid = False
        End If

        ' Kategori wajib dipilih
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori wajib dipilih")
            valid = False
        End If

        ' Nama peminjam minimal 3 karakter, tidak termasuk spasi di awal dan akhir
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter")
            valid = False
        End If

        ' Lama pinjam periksa tipe data dulu (TryParse), baru rentang 1 sampai 14
        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat 1 sampai 14")
            valid = False
        End If

        Return valid
    End Function

    ' memeriksa format kode buku saat fokus pindah, tanpa e.Cancel = True
    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        If kode = "" Then
            errPinjam.SetError(txtKodeBuku, "")          ' kosong baru dipersoalkan saat tombol Pinjam diklik
        ElseIf Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode buku harus 'BK' diikuti 4 angka, contoh BK0012")
        ElseIf kodeDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub

    ' Mencatat peminjaman jika semua isian valid
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah"
            Return                                       ' hentikan jika ada isian salah
        End If

        ' Setelah lolos validasi, konversi pasti berhasil
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        Dim lama As Integer
        Integer.TryParse(txtLamaPinjam.Text.Trim(), lama)

        Dim tanggalKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

        Dim baris As String = kode & " | " & AmankanTeks(txtJudul.Text) & " | " & cboKategori.Text &
                              " | " & AmankanTeks(txtNamaPeminjam.Text) & " | " & lama.ToString() &
                              " hari | kembali " & tanggalKembali

        lstPeminjaman.Items.Add(baris)
        kodeDipinjam.Add(kode)                           ' tandai buku ini sedang dipinjam

        BersihkanForm()
        PerbaruiStatus()                                 ' "Jumlah peminjaman: N"
    End Sub

    ' Mengosongkan isian dan ikon error (CausesValidation = False di Designer)
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
        PerbaruiStatus()
    End Sub

    ' Menyimpan isi lstPeminjaman ke peminjaman.csv di folder Documents
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        ' Daftar kosong: tampilkan pesan dan jangan membuat file
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor", "Ekspor CSV",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim lokasi As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")
        Dim penulis As StreamWriter = Nothing           ' dideklarasikan di luar Try agar bisa ditutup di Finally

        Try
            penulis = New StreamWriter(lokasi, False, Encoding.UTF8)
            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam (hari);Tanggal Kembali")

            For Each item As Object In lstPeminjaman.Items
                ' Pecah baris ListBox menjadi 6 kolom, lalu bersihkan kata bantu "hari" dan "kembali"
                Dim kolom As String() = item.ToString().Split(New String() {" | "}, StringSplitOptions.None)
                kolom(4) = kolom(4).Replace(" hari", "")
                kolom(5) = kolom(5).Replace("kembali ", "")
                penulis.WriteLine(String.Join(";", kolom))
            Next

            lblStatus.Text = "Berhasil diekspor ke: " & lokasi

        Catch ex As IOException
            MessageBox.Show("File peminjaman.csv tidak dapat ditulis karena sedang dibuka di program lain" &
                            vbCrLf & "Tutup file tersebut, lalu klik Ekspor lagi",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblStatus.Text = "Ekspor gagal: file sedang dipakai"

        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Program tidak memiliki izin menulis ke file atau folder Documents" &
                            vbCrLf & "Pastikan file peminjaman.csv tidak berstatus Read-only, atau jalankan ulang aplikasi dengan izin yang sesuai",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblStatus.Text = "Ekspor gagal: tidak ada izin menulis"

        Catch ex As Exception
            ' Lapisan pengaman terakhir agar program tidak pernah berhenti mendadak
            MessageBox.Show("Terjadi kesalahan saat ekspor: " & ex.Message, "Ekspor Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If penulis IsNot Nothing Then penulis.Close()   ' selalu ditutup, ada error atau tidak
        End Try
    End Sub

End Class
