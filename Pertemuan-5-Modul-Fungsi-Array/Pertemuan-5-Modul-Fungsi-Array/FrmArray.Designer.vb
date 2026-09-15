<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampil = New Button()
        TxtPanjang = New TextBox()
        TxtLebar = New TextBox()
        LblPanjang = New Label()
        LblLebar = New Label()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(331, 446)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(112, 34)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' TxtPanjang
        ' 
        TxtPanjang.Location = New Point(316, 195)
        TxtPanjang.Name = "TxtPanjang"
        TxtPanjang.Size = New Size(150, 31)
        TxtPanjang.TabIndex = 1
        ' 
        ' TxtLebar
        ' 
        TxtLebar.Location = New Point(316, 342)
        TxtLebar.Name = "TxtLebar"
        TxtLebar.Size = New Size(150, 31)
        TxtLebar.TabIndex = 2
        ' 
        ' LblPanjang
        ' 
        LblPanjang.AutoSize = True
        LblPanjang.Location = New Point(316, 158)
        LblPanjang.Name = "LblPanjang"
        LblPanjang.Size = New Size(83, 25)
        LblPanjang.TabIndex = 3
        LblPanjang.Text = "Panjang :"
        ' 
        ' LblLebar
        ' 
        LblLebar.AutoSize = True
        LblLebar.Location = New Point(316, 305)
        LblLebar.Name = "LblLebar"
        LblLebar.Size = New Size(64, 25)
        LblLebar.TabIndex = 4
        LblLebar.Text = "Lebar :"
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(299, 523)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(180, 129)
        lstNilai.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 737)
        Controls.Add(lstNilai)
        Controls.Add(LblLebar)
        Controls.Add(LblPanjang)
        Controls.Add(TxtLebar)
        Controls.Add(TxtPanjang)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents TxtPanjang As TextBox
    Friend WithEvents TxtLebar As TextBox
    Friend WithEvents LblPanjang As Label
    Friend WithEvents LblLebar As Label
    Friend WithEvents lstNilai As ListBox

End Class
