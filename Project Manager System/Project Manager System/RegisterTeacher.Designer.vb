<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterTeacher
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
        Me.GBoxRegisterTeacher = New System.Windows.Forms.GroupBox()
        Me.TbTID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblReTypePassword = New System.Windows.Forms.Label()
        Me.TbReTypePassword = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.BtnTeacherRegister = New System.Windows.Forms.Button()
        Me.GBoxRegisterTeacher.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxRegisterTeacher
        '
        Me.GBoxRegisterTeacher.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GBoxRegisterTeacher.Controls.Add(Me.TbTID)
        Me.GBoxRegisterTeacher.Controls.Add(Me.Label1)
        Me.GBoxRegisterTeacher.Controls.Add(Me.LblReTypePassword)
        Me.GBoxRegisterTeacher.Controls.Add(Me.TbReTypePassword)
        Me.GBoxRegisterTeacher.Controls.Add(Me.TbPassword)
        Me.GBoxRegisterTeacher.Controls.Add(Me.TbUsername)
        Me.GBoxRegisterTeacher.Controls.Add(Me.LblPassword)
        Me.GBoxRegisterTeacher.Controls.Add(Me.LblUsername)
        Me.GBoxRegisterTeacher.Controls.Add(Me.BtnTeacherRegister)
        Me.GBoxRegisterTeacher.Location = New System.Drawing.Point(12, 12)
        Me.GBoxRegisterTeacher.Name = "GBoxRegisterTeacher"
        Me.GBoxRegisterTeacher.Size = New System.Drawing.Size(265, 245)
        Me.GBoxRegisterTeacher.TabIndex = 5
        Me.GBoxRegisterTeacher.TabStop = False
        Me.GBoxRegisterTeacher.Text = "Register a new Teacher"
        '
        'TbTID
        '
        Me.TbTID.Location = New System.Drawing.Point(146, 36)
        Me.TbTID.Name = "TbTID"
        Me.TbTID.Size = New System.Drawing.Size(100, 22)
        Me.TbTID.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TID"
        '
        'LblReTypePassword
        '
        Me.LblReTypePassword.AutoSize = True
        Me.LblReTypePassword.Location = New System.Drawing.Point(17, 130)
        Me.LblReTypePassword.Name = "LblReTypePassword"
        Me.LblReTypePassword.Size = New System.Drawing.Size(128, 17)
        Me.LblReTypePassword.TabIndex = 5
        Me.LblReTypePassword.Text = "Re-Type Password"
        '
        'TbReTypePassword
        '
        Me.TbReTypePassword.Location = New System.Drawing.Point(146, 126)
        Me.TbReTypePassword.Name = "TbReTypePassword"
        Me.TbReTypePassword.Size = New System.Drawing.Size(100, 22)
        Me.TbReTypePassword.TabIndex = 4
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(146, 97)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(100, 22)
        Me.TbPassword.TabIndex = 3
        '
        'TbUsername
        '
        Me.TbUsername.Location = New System.Drawing.Point(146, 68)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(100, 22)
        Me.TbUsername.TabIndex = 2
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(18, 100)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(69, 17)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(18, 71)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(73, 17)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'BtnTeacherRegister
        '
        Me.BtnTeacherRegister.Location = New System.Drawing.Point(171, 191)
        Me.BtnTeacherRegister.Name = "BtnTeacherRegister"
        Me.BtnTeacherRegister.Size = New System.Drawing.Size(75, 35)
        Me.BtnTeacherRegister.TabIndex = 10
        Me.BtnTeacherRegister.Text = "Register"
        Me.BtnTeacherRegister.UseVisualStyleBackColor = True
        '
        'RegisterTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(291, 268)
        Me.Controls.Add(Me.GBoxRegisterTeacher)
        Me.Name = "RegisterTeacher"
        Me.Text = "RegisterTeacher"
        Me.GBoxRegisterTeacher.ResumeLayout(False)
        Me.GBoxRegisterTeacher.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBoxRegisterTeacher As GroupBox
    Friend WithEvents TbTID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblReTypePassword As Label
    Friend WithEvents TbReTypePassword As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents BtnTeacherRegister As Button
End Class
