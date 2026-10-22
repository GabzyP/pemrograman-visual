<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariArray
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    Friend WithEvents lblJudul As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJumlah As Label
    Friend WithEvents colNIM As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents colIPK As DataGridViewTextBoxColumn

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        dgvMahasiswa = New DataGridView()
        colNIM = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJurusan = New DataGridViewTextBoxColumn()
        colAngkatan = New DataGridViewTextBoxColumn()
        colIPK = New DataGridViewTextBoxColumn()
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJumlah = New Label()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(20, 23)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(357, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Data dari Array 2 Dimensi"

        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNIM, colNama, colJurusan, colAngkatan, colIPK})
        dgvMahasiswa.Location = New Point(20, 80)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(658, 240)
        dgvMahasiswa.TabIndex = 1

        colNIM.HeaderText = "NIM"
        colNIM.MinimumWidth = 8
        colNIM.Name = "colNIM"
        colNIM.ReadOnly = True

        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True

        colJurusan.HeaderText = "Jurusan"
        colJurusan.MinimumWidth = 8
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True

        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.MinimumWidth = 8
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True

        colIPK.HeaderText = "IPK"
        colIPK.MinimumWidth = 8
        colIPK.Name = "colIPK"
        colIPK.ReadOnly = True

        btnTampilkan.Location = New Point(20, 338)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(118, 40)
        btnTampilkan.TabIndex = 2
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True

        btnKosongkan.Location = New Point(150, 338)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(118, 40)
        btnKosongkan.TabIndex = 3
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True

        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(460, 345)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(126, 25)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah data: 0"

        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 390)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
