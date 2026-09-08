<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerulangan
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
        lblNilaiAwal = New Label()
        lblNilaiAkhir = New Label()
        txtNilaiAwal = New TextBox()
        txtNilaiAkhir = New TextBox()
        btnInput = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(343, 49)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(98, 25)
        lblNilaiAwal.TabIndex = 1
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(340, 169)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(101, 25)
        lblNilaiAkhir.TabIndex = 2
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(306, 103)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(150, 31)
        txtNilaiAwal.TabIndex = 3
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(306, 208)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(150, 31)
        txtNilaiAkhir.TabIndex = 4
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(329, 261)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(112, 34)
        btnInput.TabIndex = 5
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(291, 318)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(180, 129)
        lstHasil.TabIndex = 6
        ' 
        ' FrmPerulangan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnInput)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(lblNilaiAwal)
        Name = "FrmPerulangan"
        Text = "Form Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstHasil As ListBox

End Class
