<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PBTeacher = New System.Windows.Forms.PictureBox()
        Me.PBStudent = New System.Windows.Forms.PictureBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.GBoxLogin = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnLogin1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PBTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBTeacher
        '
        Me.PBTeacher.BackColor = System.Drawing.Color.Black
        Me.PBTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBTeacher.Image = CType(resources.GetObject("PBTeacher.Image"), System.Drawing.Image)
        Me.PBTeacher.InitialImage = CType(resources.GetObject("PBTeacher.InitialImage"), System.Drawing.Image)
        Me.PBTeacher.Location = New System.Drawing.Point(100, 100)
        Me.PBTeacher.Name = "PBTeacher"
        Me.PBTeacher.Size = New System.Drawing.Size(150, 150)
        Me.PBTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBTeacher.TabIndex = 0
        Me.PBTeacher.TabStop = False
        '
        'PBStudent
        '
        Me.PBStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBStudent.Image = CType(resources.GetObject("PBStudent.Image"), System.Drawing.Image)
        Me.PBStudent.Location = New System.Drawing.Point(400, 100)
        Me.PBStudent.Name = "PBStudent"
        Me.PBStudent.Size = New System.Drawing.Size(150, 150)
        Me.PBStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBStudent.TabIndex = 1
        Me.PBStudent.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLogin.Enabled = False
        Me.BtnLogin.Font = New System.Drawing.Font("Mistral", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Red
        Me.BtnLogin.Location = New System.Drawing.Point(252, 354)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(147, 59)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegister.Enabled = False
        Me.BtnRegister.Font = New System.Drawing.Font("Mistral", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.Red
        Me.BtnRegister.Location = New System.Drawing.Point(252, 447)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(147, 59)
        Me.BtnRegister.TabIndex = 3
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'GBoxLogin
        '
        Me.GBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBoxLogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GBoxLogin.Controls.Add(Me.PictureBox1)
        Me.GBoxLogin.Controls.Add(Me.BtnClear)
        Me.GBoxLogin.Controls.Add(Me.BtnLogin1)
        Me.GBoxLogin.Controls.Add(Me.TextBox2)
        Me.GBoxLogin.Controls.Add(Me.TextBox1)
        Me.GBoxLogin.Controls.Add(Me.Label2)
        Me.GBoxLogin.Controls.Add(Me.Label1)
        Me.GBoxLogin.Location = New System.Drawing.Point(139, 354)
        Me.GBoxLogin.Name = "GBoxLogin"
        Me.GBoxLogin.Size = New System.Drawing.Size(352, 216)
        Me.GBoxLogin.TabIndex = 4
        Me.GBoxLogin.TabStop = False
        Me.GBoxLogin.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClear.Font = New System.Drawing.Font("Mistral", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(34, 146)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(109, 52)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnLogin1
        '
        Me.BtnLogin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLogin1.Font = New System.Drawing.Font("Mistral", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin1.ForeColor = System.Drawing.Color.Red
        Me.BtnLogin1.Location = New System.Drawing.Point(207, 146)
        Me.BtnLogin1.Name = "BtnLogin1"
        Me.BtnLogin1.Size = New System.Drawing.Size(109, 52)
        Me.BtnLogin1.TabIndex = 4
        Me.BtnLogin1.Text = "Login"
        Me.BtnLogin1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(170, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(132, 31)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(170, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(59, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(97, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(507, 47)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Project Management System"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(632, 603)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GBoxLogin)
        Me.Controls.Add(Me.PBStudent)
        Me.Controls.Add(Me.PBTeacher)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnRegister)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PBTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxLogin.ResumeLayout(False)
        Me.GBoxLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBTeacher As PictureBox
    Friend WithEvents PBStudent As PictureBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents GBoxLogin As GroupBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnLogin1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
