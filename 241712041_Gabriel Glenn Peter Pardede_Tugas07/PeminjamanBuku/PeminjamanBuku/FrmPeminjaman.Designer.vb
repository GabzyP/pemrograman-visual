<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
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

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents errPinjam As ErrorProvider

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
        lblKategori = New Label()
        cboKategori = New ComboBox()
        lblNamaPeminjam = New Label()
        txtNamaPeminjam = New TextBox()
        lblLamaPinjam = New Label()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        lstPeminjaman = New ListBox()
        btnEkspor = New Button()
        lblStatus = New Label()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudulForm.Location = New Point(20, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(256, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKodeBuku.Location = New Point(20, 65)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(102, 25)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(20, 93)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(331, 31)
        txtKodeBuku.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(20, 131)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(104, 25)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(20, 160)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(331, 31)
        txtJudul.TabIndex = 4
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKategori.Location = New Point(20, 194)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(83, 25)
        lblKategori.TabIndex = 5
        lblKategori.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(20, 228)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(331, 33)
        cboKategori.TabIndex = 6
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaPeminjam.Location = New Point(20, 264)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(147, 25)
        lblNamaPeminjam.TabIndex = 7
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(20, 292)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(331, 31)
        txtNamaPeminjam.TabIndex = 8
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLamaPinjam.Location = New Point(20, 335)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(165, 25)
        lblLamaPinjam.TabIndex = 9
        lblLamaPinjam.Text = "Lama Pinjam (hari)"
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(20, 363)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(331, 31)
        txtLamaPinjam.TabIndex = 10
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(20, 423)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(141, 42)
        btnPinjam.TabIndex = 11
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(218, 423)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(133, 42)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.HorizontalScrollbar = True
        lstPeminjaman.Location = New Point(411, 65)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(580, 329)
        lstPeminjaman.TabIndex = 13
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(411, 423)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(144, 42)
        btnEkspor.TabIndex = 14
        btnEkspor.Text = "Ekspor CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(20, 492)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(197, 25)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Jumlah peminjaman: 0"
        ' 
        ' errPinjam
        ' 
        errPinjam.BlinkStyle = ErrorBlinkStyle.NeverBlink
        errPinjam.ContainerControl = Me
        ' 
        ' FrmPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 546)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(lblLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPeminjaman"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
