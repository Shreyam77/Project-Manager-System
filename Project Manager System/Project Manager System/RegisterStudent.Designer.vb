<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStudent
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
        Me.GBoxRegisterStudent = New System.Windows.Forms.GroupBox()
        Me.CBoxGroupID = New System.Windows.Forms.ComboBox()
        Me.TbSID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblGroupID = New System.Windows.Forms.Label()
        Me.TbGroupMember = New System.Windows.Forms.TextBox()
        Me.LblGroupMember = New System.Windows.Forms.Label()
        Me.LblReTypePassword = New System.Windows.Forms.Label()
        Me.TbReTypePassword = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.BtnStudentRegister = New System.Windows.Forms.Button()
        Me.GBoxRegisterStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxRegisterStudent
        '
        Me.GBoxRegisterStudent.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GBoxRegisterStudent.Controls.Add(Me.CBoxGroupID)
        Me.GBoxRegisterStudent.Controls.Add(Me.TbSID)
        Me.GBoxRegisterStudent.Controls.Add(Me.Label1)
        Me.GBoxRegisterStudent.Controls.Add(Me.LblGroupID)
        Me.GBoxRegisterStudent.Controls.Add(Me.TbGroupMember)
        Me.GBoxRegisterStudent.Controls.Add(Me.LblGroupMember)
        Me.GBoxRegisterStudent.Controls.Add(Me.LblReTypePassword)
        Me.GBoxRegisterStudent.Controls.Add(Me.TbReTypePassword)
        Me.GBoxRegisterStudent.Controls.Add(Me.TbPassword)
        Me.GBoxRegisterStudent.Controls.Add(Me.TbUsername)
        Me.GBoxRegisterStudent.Controls.Add(Me.LblPassword)
        Me.GBoxRegisterStudent.Controls.Add(Me.LblUsername)
        Me.GBoxRegisterStudent.Controls.Add(Me.BtnStudentRegister)
        Me.GBoxRegisterStudent.Location = New System.Drawing.Point(12, 12)
        Me.GBoxRegisterStudent.Name = "GBoxRegisterStudent"
        Me.GBoxRegisterStudent.Size = New System.Drawing.Size(284, 298)
        Me.GBoxRegisterStudent.TabIndex = 0
        Me.GBoxRegisterStudent.TabStop = False
        Me.GBoxRegisterStudent.Text = "Register a new Student"
        '
        'CBoxGroupID
        '
        Me.CBoxGroupID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBoxGroupID.FormattingEnabled = True
        Me.CBoxGroupID.Location = New System.Drawing.Point(158, 183)
        Me.CBoxGroupID.Name = "CBoxGroupID"
        Me.CBoxGroupID.Size = New System.Drawing.Size(100, 24)
        Me.CBoxGroupID.TabIndex = 26
        Me.CBoxGroupID.Visible = False
        '
        'TbSID
        '
        Me.TbSID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbSID.Location = New System.Drawing.Point(158, 36)
        Me.TbSID.Name = "TbSID"
        Me.TbSID.Size = New System.Drawing.Size(100, 22)
        Me.TbSID.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SID"
        '
        'LblGroupID
        '
        Me.LblGroupID.AutoSize = True
        Me.LblGroupID.Location = New System.Drawing.Point(30, 186)
        Me.LblGroupID.Name = "LblGroupID"
        Me.LblGroupID.Size = New System.Drawing.Size(65, 17)
        Me.LblGroupID.TabIndex = 21
        Me.LblGroupID.Text = "Group ID"
        Me.LblGroupID.Visible = False
        '
        'TbGroupMember
        '
        Me.TbGroupMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbGroupMember.Location = New System.Drawing.Point(158, 154)
        Me.TbGroupMember.Name = "TbGroupMember"
        Me.TbGroupMember.Size = New System.Drawing.Size(100, 22)
        Me.TbGroupMember.TabIndex = 20
        Me.TbGroupMember.Visible = False
        '
        'LblGroupMember
        '
        Me.LblGroupMember.AutoSize = True
        Me.LblGroupMember.Location = New System.Drawing.Point(30, 158)
        Me.LblGroupMember.Name = "LblGroupMember"
        Me.LblGroupMember.Size = New System.Drawing.Size(103, 17)
        Me.LblGroupMember.TabIndex = 19
        Me.LblGroupMember.Text = "Group Member"
        Me.LblGroupMember.Visible = False
        '
        'LblReTypePassword
        '
        Me.LblReTypePassword.AutoSize = True
        Me.LblReTypePassword.Location = New System.Drawing.Point(29, 130)
        Me.LblReTypePassword.Name = "LblReTypePassword"
        Me.LblReTypePassword.Size = New System.Drawing.Size(128, 17)
        Me.LblReTypePassword.TabIndex = 18
        Me.LblReTypePassword.Text = "Re-Type Password"
        '
        'TbReTypePassword
        '
        Me.TbReTypePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbReTypePassword.Location = New System.Drawing.Point(158, 126)
        Me.TbReTypePassword.Name = "TbReTypePassword"
        Me.TbReTypePassword.Size = New System.Drawing.Size(100, 22)
        Me.TbReTypePassword.TabIndex = 17
        '
        'TbPassword
        '
        Me.TbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPassword.Location = New System.Drawing.Point(158, 97)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(100, 22)
        Me.TbPassword.TabIndex = 16
        '
        'TbUsername
        '
        Me.TbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbUsername.Location = New System.Drawing.Point(158, 68)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(100, 22)
        Me.TbUsername.TabIndex = 15
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(30, 100)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(69, 17)
        Me.LblPassword.TabIndex = 14
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(30, 71)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(73, 17)
        Me.LblUsername.TabIndex = 13
        Me.LblUsername.Text = "Username"
        '
        'BtnStudentRegister
        '
        Me.BtnStudentRegister.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnStudentRegister.Location = New System.Drawing.Point(183, 234)
        Me.BtnStudentRegister.Name = "BtnStudentRegister"
        Me.BtnStudentRegister.Size = New System.Drawing.Size(75, 35)
        Me.BtnStudentRegister.TabIndex = 23
        Me.BtnStudentRegister.Text = "Register"
        Me.BtnStudentRegister.UseVisualStyleBackColor = False
        '
        'RegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(309, 323)
        Me.Controls.Add(Me.GBoxRegisterStudent)
        Me.Name = "RegisterStudent"
        Me.Text = "RegisterStudent"
        Me.GBoxRegisterStudent.ResumeLayout(False)
        Me.GBoxRegisterStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBoxRegisterStudent As GroupBox
    Friend WithEvents TbSID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblGroupID As Label
    Friend WithEvents TbGroupMember As TextBox
    Friend WithEvents LblGroupMember As Label
    Friend WithEvents LblReTypePassword As Label
    Friend WithEvents TbReTypePassword As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents BtnStudentRegister As Button
    Friend WithEvents CBoxGroupID As ComboBox
End Class
