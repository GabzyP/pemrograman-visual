<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        picImage = New PictureBox()
        Label1 = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        cmbRole = New ComboBox()
        btnLogin = New Button()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(351, 36)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 100)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(191, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 25)
        Label1.TabIndex = 1
        Label1.Text = "Role    :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(188, 239)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(73, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama  :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(191, 302)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(70, 25)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM    :"
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(300, 172)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(339, 377)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(301, 239)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(181, 31)
        txtNama.TabIndex = 6
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(300, 302)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(182, 31)
        txtNIM.TabIndex = 7
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(btnLogin)
        Controls.Add(cmbRole)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox

End Class
