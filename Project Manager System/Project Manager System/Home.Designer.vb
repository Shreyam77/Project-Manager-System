<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnViewTask = New System.Windows.Forms.Button()
        Me.BtnNewTask = New System.Windows.Forms.Button()
        Me.BtnNewProject = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnViewTask)
        Me.Panel1.Controls.Add(Me.BtnNewTask)
        Me.Panel1.Controls.Add(Me.BtnNewProject)
        Me.Panel1.Location = New System.Drawing.Point(13, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 556)
        Me.Panel1.TabIndex = 0
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Azure
        Me.BtnLogout.Location = New System.Drawing.Point(12, 198)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(182, 56)
        Me.BtnLogout.TabIndex = 4
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnViewTask
        '
        Me.BtnViewTask.BackColor = System.Drawing.Color.Azure
        Me.BtnViewTask.Location = New System.Drawing.Point(12, 136)
        Me.BtnViewTask.Name = "BtnViewTask"
        Me.BtnViewTask.Size = New System.Drawing.Size(182, 56)
        Me.BtnViewTask.TabIndex = 2
        Me.BtnViewTask.Text = "View Tasks by Projects"
        Me.BtnViewTask.UseVisualStyleBackColor = False
        '
        'BtnNewTask
        '
        Me.BtnNewTask.BackColor = System.Drawing.Color.Azure
        Me.BtnNewTask.Location = New System.Drawing.Point(12, 74)
        Me.BtnNewTask.Name = "BtnNewTask"
        Me.BtnNewTask.Size = New System.Drawing.Size(182, 56)
        Me.BtnNewTask.TabIndex = 1
        Me.BtnNewTask.Text = "Create a New Task"
        Me.BtnNewTask.UseVisualStyleBackColor = False
        '
        'BtnNewProject
        '
        Me.BtnNewProject.BackColor = System.Drawing.Color.Azure
        Me.BtnNewProject.Location = New System.Drawing.Point(12, 12)
        Me.BtnNewProject.Name = "BtnNewProject"
        Me.BtnNewProject.Size = New System.Drawing.Size(182, 56)
        Me.BtnNewProject.TabIndex = 0
        Me.BtnNewProject.Text = "Create a New Project"
        Me.BtnNewProject.UseVisualStyleBackColor = False
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(13, 13)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(104, 17)
        Me.LblUsername.TabIndex = 2
        Me.LblUsername.Text = "Welcome back "
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(230, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 556)
        Me.DataGridView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1483, 623)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnNewProject As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnViewTask As Button
    Friend WithEvents BtnNewTask As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
