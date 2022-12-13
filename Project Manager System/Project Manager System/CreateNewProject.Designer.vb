<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewProject
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbProjectName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RTbdescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbVersion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblPID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Name"
        '
        'TbProjectName
        '
        Me.TbProjectName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbProjectName.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProjectName.Location = New System.Drawing.Point(36, 99)
        Me.TbProjectName.Name = "TbProjectName"
        Me.TbProjectName.Size = New System.Drawing.Size(366, 28)
        Me.TbProjectName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'RTbdescription
        '
        Me.RTbdescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RTbdescription.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTbdescription.Location = New System.Drawing.Point(36, 161)
        Me.RTbdescription.Name = "RTbdescription"
        Me.RTbdescription.Size = New System.Drawing.Size(366, 96)
        Me.RTbdescription.TabIndex = 3
        Me.RTbdescription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Version"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(278, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add Project"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TbVersion
        '
        Me.TbVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbVersion.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbVersion.Location = New System.Drawing.Point(36, 305)
        Me.TbVersion.Name = "TbVersion"
        Me.TbVersion.Size = New System.Drawing.Size(100, 28)
        Me.TbVersion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PID"
        '
        'LblPID
        '
        Me.LblPID.AutoSize = True
        Me.LblPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblPID.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPID.Location = New System.Drawing.Point(80, 17)
        Me.LblPID.Name = "LblPID"
        Me.LblPID.Size = New System.Drawing.Size(40, 18)
        Me.LblPID.TabIndex = 8
        Me.LblPID.Text = "1001"
        '
        'CreateNewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(452, 370)
        Me.Controls.Add(Me.LblPID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbVersion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RTbdescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbProjectName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateNewProject"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "CreateNewProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbProjectName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RTbdescription As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TbVersion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblPID As Label
End Class
