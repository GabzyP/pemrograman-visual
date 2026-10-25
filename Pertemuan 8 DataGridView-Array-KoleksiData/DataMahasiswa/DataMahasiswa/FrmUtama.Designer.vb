<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
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
        lblJudul = New Label()
        btnDariArray = New Button()
        btnDariList = New Button()
        btnDataTable = New Button()
        btnCariList = New Button()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(73, 21)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(289, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Contoh Pertemuan 8"
        ' 
        ' btnDariArray
        ' 
        btnDariArray.Location = New Point(73, 81)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New Size(289, 34)
        btnDariArray.TabIndex = 1
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True
        ' 
        ' btnDariList
        ' 
        btnDariList.Location = New Point(73, 133)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New Size(289, 34)
        btnDariList.TabIndex = 3
        btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        btnDariList.UseVisualStyleBackColor = True
        ' 
        ' btnDataTable
        ' 
        btnDataTable.Location = New Point(73, 187)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New Size(289, 34)
        btnDataTable.TabIndex = 4
        btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True
        ' 
        ' btnCariList
        ' 
        btnCariList.Location = New Point(73, 236)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New Size(289, 34)
        btnCariList.TabIndex = 5
        btnCariList.Text = "4. Pencarian dengan Perulangan"
        btnCariList.UseVisualStyleBackColor = True
        ' 
        ' FrmUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 300)
        Controls.Add(btnCariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnDariList)
        Controls.Add(btnDariArray)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnDariArray As Button
    Friend WithEvents btnDariList As Button
    Friend WithEvents btnDataTable As Button
    Friend WithEvents btnCariList As Button

End Class
