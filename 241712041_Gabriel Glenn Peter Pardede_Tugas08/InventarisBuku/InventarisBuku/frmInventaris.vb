Option Strict On

Public Class frmInventaris

    ' Tabel inventaris di memori tanpa database
    Private tabelBuku As DataTable

    ' Membuat DataTable beserta 10 buku awal 
    Private Function BuatTabelBuku() As DataTable
        Dim tabel As New DataTable("Buku")

        ' Kolom nama dan tipe data
        tabel.Columns.Add("KodeBuku", GetType(String))
        tabel.Columns.Add("Judul", GetType(String))
        tabel.Columns.Add("Penulis", GetType(String))
        tabel.Columns.Add("Kategori", GetType(String))
        tabel.Columns.Add("Tahun", GetType(Integer))
        tabel.Columns.Add("Stok", GetType(Integer))

        ' Baris urutan nilai mengikuti urutan kolom
        tabel.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabel.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabel.Rows.Add("BK0003", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 5)
        tabel.Rows.Add("BK0004", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 6)
        tabel.Rows.Add("BK0005", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2011, 4)
        tabel.Rows.Add("BK0006", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 3)
        tabel.Rows.Add("BK0007", "Kamus Besar Bahasa Indonesia", "Badan Bahasa", "Referensi", 2016, 2)
        tabel.Rows.Add("BK0008", "Ensiklopedia Sains Populer", "Tim Redaksi", "Referensi", 2019, 1)
        tabel.Rows.Add("BK0009", "National Geographic Indonesia", "Redaksi NatGeo", "Majalah", 2023, 0)
        tabel.Rows.Add("BK0010", "Tempo Edisi Khusus", "Redaksi Tempo", "Majalah", 2024, 7)

        Return tabel
    End Function

    ' Saat form dibuka buat data, hubungkan ke grid lewat BindingSource, rapikan kolom
    Private Sub frmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelBuku = BuatTabelBuku()
        bsBuku.DataSource = tabelBuku              ' DataTable -> BindingSource
        dgvBuku.DataSource = bsBuku                ' BindingSource -> DataGridView
        AturKolom()                                ' harus setelah DataSource diisi
        cboFilterKategori.SelectedIndex = 0        ' "Semua"
        cboUrut.SelectedIndex = 0                   ' "Urutan awal"
        PerbaruiRingkasan()
    End Sub

    ' Merapikan judul, lebar, dan perataan kolom, kolom baru ada setelah DataSource diisi
    Private Sub AturKolom()
        dgvBuku.Columns("KodeBuku").DataPropertyName = "KodeBuku"
        dgvBuku.Columns("Judul").DataPropertyName = "Judul"
        dgvBuku.Columns("Penulis").DataPropertyName = "Penulis"
        dgvBuku.Columns("Kategori").DataPropertyName = "Kategori"
        dgvBuku.Columns("Tahun").DataPropertyName = "Tahun"
        dgvBuku.Columns("Stok").DataPropertyName = "Stok"

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' Memeriksa apakah kode sudah ada di tabelBuku dengan perulangan pada Rows
    Private Function KodeSudahAda(kode As String) As Boolean
        For Each baris As DataRow In tabelBuku.Rows
            If String.Equals(baris("KodeBuku").ToString(), kode, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Memeriksa semua isian sekaligus dengan ErrorProvider, True jika semuanya valid
    Private Function ValidasiInput() As Boolean
        errBuku.Clear()                            ' hapus semua tanda error lama
        Dim valid As Boolean = True

        ' Kode buku format BK + 4 digit dan harus belum ada di tabelBuku
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus 'BK' diikuti 4 angka, contoh BK0012.")
            valid = False
        ElseIf KodeSudahAda(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku sudah ada di inventaris.")
            valid = False
        End If

        ' Judul dan penulis wajib diisi
        If Kosong(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If
        If Kosong(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        ' Kategori wajib dipilih
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih.")
            valid = False
        End If

        ' Tahun bilangan bulat 1900 sampai tahun ini 
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat 1900 sampai " & Date.Today.Year.ToString() & ".")
            valid = False
        End If

        ' Stok bilangan bulat 0 atau lebih
        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih.")
            valid = False
        End If

        Return valid
    End Function

    ' Mengosongkan isian input dan menghapus ikon ErrorProvider
    Private Sub BersihkanInput()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Menambah buku baru ke tabelBuku jika semua isian valid
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return         ' ikon error sudah terpasang

        ' Setelah lolos validasi, konversi pasti berhasil
        Dim tahun As Integer
        Dim stok As Integer
        Integer.TryParse(txtTahun.Text.Trim(), tahun)
        Integer.TryParse(txtStok.Text.Trim(), stok)

        ' Tambah ke DataTable, grid ikut berubah lewat BindingSource tanpa diisi ulang
        tabelBuku.Rows.Add(txtKodeBuku.Text.Trim().ToUpperInvariant(),
                           txtJudul.Text.Trim(),
                           txtPenulis.Text.Trim(),
                           cboKategori.Text,
                           tahun,
                           stok)

        ' Reset pencarian agar buku baru pasti tampil, lalu perbarui ringkasan
        txtCari.Clear()
        cboFilterKategori.SelectedIndex = 0
        TerapkanFilter()
        bsBuku.MoveLast()                          ' sorot dan gulir ke baris terakhir (buku baru)

        BersihkanInput()
    End Sub

    ' Mengosongkan isian dan ikon error tanpa menyentuh pencarian
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanInput()
    End Sub

    ' Pencarian berjalan saat mengetik
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Pencarian ikut berubah saat kategori filter diganti
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' Pencarian dan filter ikut berubah saat opsi stok habis diganti
    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    ' Mengubah urutan data sesuai pilihan
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        Select Case cboUrut.SelectedIndex
            Case 1
                bsBuku.Sort = "Judul ASC"
            Case 2
                bsBuku.Sort = "Tahun DESC"
            Case 3
                bsBuku.Sort = "Stok DESC"
            Case Else
                bsBuku.Sort = String.Empty
        End Select
    End Sub

    ' Menyusun satu ekspresi Filter dari syarat teks, kategori, dan stok habis, lalu menerapkannya
    Private Sub TerapkanFilter()
        Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
        Dim syaratTeks As String = ""
        Dim syaratKategori As String = ""

        ' Syarat teks judul ATAU penulis mengandung kata
        If kata <> "" Then
            syaratTeks = "(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')"
        End If

        ' Syarat kategori indeks 0 adalah Semua
        If cboFilterKategori.SelectedIndex > 0 Then
            syaratKategori = "Kategori = '" & AmankanTeksFilter(cboFilterKategori.Text) & "'"
        End If

        ' Syarat stok habis
        Dim syaratStok As String = ""
        If chkStokHabis.Checked Then
            syaratStok = "Stok = 0"
        End If

        Dim syarat As New List(Of String)()
        If syaratTeks <> "" Then syarat.Add(syaratTeks)
        If syaratKategori <> "" Then syarat.Add(syaratKategori)
        If syaratStok <> "" Then syarat.Add(syaratStok)
        Dim ekspresi As String = String.Join(" AND ", syarat)

        If ekspresi = "" Then
            bsBuku.RemoveFilter()                  ' tampilkan semua buku
        Else
            bsBuku.Filter = ekspresi
        End If

        PerbaruiRingkasan()
    End Sub

    ' Menghitung jumlah buku tampil dan total stok dari baris yang sedang tampil di grid
    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            totalStok += CInt(baris.Cells("Stok").Value)
        Next

        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() & " dari " &
                         tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok: " & totalStok.ToString()
    End Sub

End Class
