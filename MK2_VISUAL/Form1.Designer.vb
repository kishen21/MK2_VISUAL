<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtLogmasuk = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtIdpengguna = New TextBox()
        txtKatalaluan = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtLogmasuk
        ' 
        txtLogmasuk.AutoSize = True
        txtLogmasuk.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLogmasuk.ForeColor = SystemColors.ControlText
        txtLogmasuk.Location = New Point(66, 9)
        txtLogmasuk.Name = "txtLogmasuk"
        txtLogmasuk.Size = New Size(170, 38)
        txtLogmasuk.TabIndex = 0
        txtLogmasuk.Text = "LOG MASUK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(6, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 28)
        Label2.TabIndex = 1
        Label2.Text = "ID Pengguna : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(6, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 28)
        Label3.TabIndex = 2
        Label3.Text = "Kata Laluan  : "
        ' 
        ' txtIdpengguna
        ' 
        txtIdpengguna.Location = New Point(143, 82)
        txtIdpengguna.Name = "txtIdpengguna"
        txtIdpengguna.Size = New Size(159, 27)
        txtIdpengguna.TabIndex = 3
        ' 
        ' txtKatalaluan
        ' 
        txtKatalaluan.Location = New Point(143, 150)
        txtKatalaluan.Name = "txtKatalaluan"
        txtKatalaluan.Size = New Size(159, 27)
        txtKatalaluan.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(96, 208)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(114, 35)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(307, 246)
        Controls.Add(BtnLogin)
        Controls.Add(txtKatalaluan)
        Controls.Add(txtIdpengguna)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtLogmasuk)
        Name = "Form1"
        Text = "LOG MASUK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLogmasuk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdpengguna As TextBox
    Friend WithEvents txtKatalaluan As TextBox
    Friend WithEvents BtnLogin As Button

End Class
