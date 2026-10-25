<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(274, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 25)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Pendapatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(208, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 25)
        Label2.TabIndex = 1
        Label2.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(252, 187)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(226, 31)
        txtPendapatan.TabIndex = 2
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(300, 278)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 3
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(300, 351)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmPajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
