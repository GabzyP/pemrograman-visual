<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        txtKodeBuku = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblPenulis = New Label()
        txtPenulis = New TextBox()
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblStok = New Label()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        lblFilterKategori = New Label()
        cboFilterKategori = New ComboBox()
        chkStokHabis = New CheckBox()
        lblUrut = New Label()
        cboUrut = New ComboBox()
        dgvBuku = New DataGridView()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        KodeBuku = New DataGridViewTextBoxColumn()
        Judul = New DataGridViewTextBoxColumn()
        Penulis = New DataGridViewTextBoxColumn()
        Kategori = New DataGridViewTextBoxColumn()
        Tahun = New DataGridViewTextBoxColumn()
        Stok = New DataGridViewTextBoxColumn()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(34, 30)
        lblJudulForm.Margin = New Padding(4, 0, 4, 0)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(408, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKodeBuku.Location = New Point(34, 98)
        lblKodeBuku.Margin = New Padding(4, 0, 4, 0)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(102, 25)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(34, 128)
        txtKodeBuku.Margin = New Padding(4, 5, 4, 5)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(327, 31)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(34, 184)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(104, 25)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(34, 214)
        txtJudul.Margin = New Padding(4, 5, 4, 5)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(327, 31)
        txtJudul.TabIndex = 4
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPenulis.Location = New Point(34, 273)
        lblPenulis.Margin = New Padding(4, 0, 4, 0)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(72, 25)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(34, 312)
        txtPenulis.Margin = New Padding(4, 5, 4, 5)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(327, 31)
        txtPenulis.TabIndex = 6
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKategori.Location = New Point(43, 370)
        lblKategori.Margin = New Padding(4, 0, 4, 0)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(83, 25)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(34, 414)
        cboKategori.Margin = New Padding(4, 5, 4, 5)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(327, 33)
        cboKategori.TabIndex = 8
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTahun.Location = New Point(34, 472)
        lblTahun.Margin = New Padding(4, 0, 4, 0)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(114, 25)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun Terbit"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(34, 511)
        txtTahun.Margin = New Padding(4, 5, 4, 5)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(327, 31)
        txtTahun.TabIndex = 10
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStok.Location = New Point(34, 563)
        lblStok.Margin = New Padding(4, 0, 4, 0)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(48, 25)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(34, 593)
        txtStok.Margin = New Padding(4, 5, 4, 5)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(327, 31)
        txtStok.TabIndex = 12
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(34, 651)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(147, 51)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBersihkan.Location = New Point(204, 651)
        btnBersihkan.Margin = New Padding(4, 5, 4, 5)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(157, 51)
        btnBersihkan.TabIndex = 14
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCari.Location = New Point(400, 98)
        lblCari.Margin = New Padding(4, 0, 4, 0)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(160, 25)
        lblCari.TabIndex = 15
        lblCari.Text = "Cari judul/penulis"
        ' 
        ' txtCari
        ' 
        txtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCari.Location = New Point(400, 128)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(793, 31)
        txtCari.TabIndex = 16
        ' 
        ' lblFilterKategori
        ' 
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFilterKategori.Location = New Point(400, 184)
        lblFilterKategori.Margin = New Padding(4, 0, 4, 0)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New Size(83, 25)
        lblFilterKategori.TabIndex = 17
        lblFilterKategori.Text = "Kategori"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New Point(400, 214)
        cboFilterKategori.Margin = New Padding(4, 5, 4, 5)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(313, 33)
        cboFilterKategori.TabIndex = 18
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New Point(723, 218)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(174, 29)
        chkStokHabis.TabIndex = 19
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' lblUrut
        ' 
        lblUrut.AutoSize = True
        lblUrut.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUrut.Location = New Point(903, 184)
        lblUrut.Name = "lblUrut"
        lblUrut.Size = New Size(126, 25)
        lblUrut.TabIndex = 20
        lblUrut.Text = "Urutkan buku"
        ' 
        ' cboUrut
        ' 
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New Point(903, 214)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(290, 33)
        cboUrut.TabIndex = 21
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.AutoGenerateColumns = False
        dgvBuku.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {KodeBuku, Judul, Penulis, Kategori, Tahun, Stok})
        dgvBuku.Location = New Point(399, 273)
        dgvBuku.Margin = New Padding(4, 5, 4, 5)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(794, 533)
        dgvBuku.TabIndex = 22
        ' 
        ' lblJumlah
        ' 
        lblJumlah.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJumlah.Location = New Point(399, 835)
        lblJumlah.Margin = New Padding(4, 0, 4, 0)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(239, 25)
        lblJumlah.TabIndex = 23
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTotalStok.AutoSize = True
        lblTotalStok.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalStok.Location = New Point(399, 879)
        lblTotalStok.Margin = New Padding(4, 0, 4, 0)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(214, 25)
        lblTotalStok.TabIndex = 24
        lblTotalStok.Text = "Total stok yang tampil: 0"
        ' 
        ' errBuku
        ' 
        errBuku.BlinkStyle = ErrorBlinkStyle.NeverBlink
        errBuku.ContainerControl = Me
        ' 
        ' KodeBuku
        ' 
        KodeBuku.HeaderText = "Kode Buku"
        KodeBuku.MinimumWidth = 8
        KodeBuku.Name = "KodeBuku"
        KodeBuku.ReadOnly = True
        ' 
        ' Judul
        ' 
        Judul.HeaderText = "Judul"
        Judul.MinimumWidth = 8
        Judul.Name = "Judul"
        Judul.ReadOnly = True
        ' 
        ' Penulis
        ' 
        Penulis.HeaderText = "Penulis"
        Penulis.MinimumWidth = 8
        Penulis.Name = "Penulis"
        Penulis.ReadOnly = True
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Kategori"
        Kategori.MinimumWidth = 8
        Kategori.Name = "Kategori"
        Kategori.ReadOnly = True
        ' 
        ' Tahun
        ' 
        Tahun.HeaderText = "Tahun"
        Tahun.MinimumWidth = 8
        Tahun.Name = "Tahun"
        Tahun.ReadOnly = True
        ' 
        ' Stok
        ' 
        Stok.HeaderText = "Stok"
        Stok.MinimumWidth = 8
        Stok.Name = "Stok"
        Stok.ReadOnly = True
        ' 
        ' frmInventaris
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 1033)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboUrut)
        Controls.Add(lblUrut)
        Controls.Add(chkStokHabis)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmInventaris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblFilterKategori As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents chkStokHabis As CheckBox
    Friend WithEvents lblUrut As Label
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider
    Friend WithEvents KodeBuku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents Penulis As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Tahun As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn

End Class
