<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnsUtama = New System.Windows.Forms.MenuStrip()
        Me.mnuBerkas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataMahasiswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataJurusan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJendela = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBertumpuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertikal = New System.Windows.Forms.ToolStripMenuItem()
        Me.sepPenutupan = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTutupAktif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTutupSemua = New System.Windows.Forms.ToolStripMenuItem()
        Me.sepDaftar = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBantuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTentang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsUtama.SuspendLayout()
        Me.SuspendLayout()
        Me.mnsUtama.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBerkas, Me.mnuData, Me.mnuJendela, Me.mnuBantuan})
        Me.mnsUtama.Location = New System.Drawing.Point(0, 0)
        Me.mnsUtama.Name = "mnsUtama"
        Me.mnsUtama.MdiWindowListItem = Me.mnuJendela
        Me.mnsUtama.TabIndex = 0
        Me.mnuBerkas.Name = "mnuBerkas"
        Me.mnuBerkas.Text = "&Berkas"
        Me.mnuBerkas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuKeluar})
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.Text = "&Keluar"
        Me.mnuKeluar.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q
        Me.mnuData.Name = "mnuData"
        Me.mnuData.Text = "&Data"
        Me.mnuData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataMahasiswa, Me.mnuDataJurusan})
        Me.mnuDataMahasiswa.Name = "mnuDataMahasiswa"
        Me.mnuDataMahasiswa.Text = "&Mahasiswa"
        Me.mnuDataMahasiswa.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1
        Me.mnuDataJurusan.Name = "mnuDataJurusan"
        Me.mnuDataJurusan.Text = "&Jurusan"
        Me.mnuDataJurusan.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2
        Me.mnuJendela.Name = "mnuJendela"
        Me.mnuJendela.Text = "&Jendela"
        Me.mnuJendela.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBertumpuk, Me.mnuHorizontal, Me.mnuVertikal, Me.sepPenutupan, Me.mnuTutupAktif, Me.mnuTutupSemua, Me.sepDaftar})
        Me.mnuBertumpuk.Name = "mnuBertumpuk"
        Me.mnuBertumpuk.Text = "&Bertumpuk"
        Me.mnuBertumpuk.Enabled = False
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Text = "Berdampingan &Horizontal"
        Me.mnuHorizontal.Enabled = False
        Me.mnuVertikal.Name = "mnuVertikal"
        Me.mnuVertikal.Text = "Berdampingan &Vertikal"
        Me.mnuVertikal.Enabled = False
        Me.sepPenutupan.Name = "sepPenutupan"
        Me.mnuTutupAktif.Name = "mnuTutupAktif"
        Me.mnuTutupAktif.Text = "Tutup &Aktif"
        Me.mnuTutupAktif.ShortcutKeys = System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W
        Me.mnuTutupAktif.Enabled = False
        Me.mnuTutupSemua.Name = "mnuTutupSemua"
        Me.mnuTutupSemua.Text = "Tutup &Semua"
        Me.mnuTutupSemua.Enabled = False
        Me.sepDaftar.Name = "sepDaftar"
        Me.mnuBantuan.Name = "mnuBantuan"
        Me.mnuBantuan.Text = "B&antuan"
        Me.mnuBantuan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTentang})
        Me.mnuTentang.Name = "mnuTentang"
        Me.mnuTentang.Text = "&Tentang"
        Me.mnuTentang.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 650)
        Me.MinimumSize = New System.Drawing.Size(700, 480)
        Me.Controls.Add(Me.mnsUtama)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsUtama
        Me.Name = "FrmUtama"
        Me.Text = "Pertemuan 12 - Administrasi Mahasiswa MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mnsUtama.ResumeLayout(False)
        Me.mnsUtama.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnsUtama As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuBerkas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataMahasiswa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataJurusan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJendela As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBertumpuk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertikal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sepPenutupan As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTutupAktif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTutupSemua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sepDaftar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBantuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTentang As System.Windows.Forms.ToolStripMenuItem
End Class
