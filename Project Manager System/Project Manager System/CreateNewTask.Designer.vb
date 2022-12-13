<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewTask
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBoxType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RTBDescription = New System.Windows.Forms.RichTextBox()
        Me.CBoxPriority = New System.Windows.Forms.ComboBox()
        Me.BtnCreateNewTask = New System.Windows.Forms.Button()
        Me.LbltID = New System.Windows.Forms.Label()
        Me.CBoxChooseProject = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose a Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'CBoxType
        '
        Me.CBoxType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBoxType.FormattingEnabled = True
        Me.CBoxType.Location = New System.Drawing.Point(46, 120)
        Me.CBoxType.Name = "CBoxType"
        Me.CBoxType.Size = New System.Drawing.Size(259, 24)
        Me.CBoxType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title"
        '
        'TBTitle
        '
        Me.TBTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBTitle.Location = New System.Drawing.Point(46, 192)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(259, 22)
        Me.TBTitle.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'RTBDescription
        '
        Me.RTBDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RTBDescription.Location = New System.Drawing.Point(43, 260)
        Me.RTBDescription.Name = "RTBDescription"
        Me.RTBDescription.Size = New System.Drawing.Size(262, 96)
        Me.RTBDescription.TabIndex = 8
        Me.RTBDescription.Text = ""
        '
        'CBoxPriority
        '
        Me.CBoxPriority.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBoxPriority.FormattingEnabled = True
        Me.CBoxPriority.Location = New System.Drawing.Point(43, 389)
        Me.CBoxPriority.Name = "CBoxPriority"
        Me.CBoxPriority.Size = New System.Drawing.Size(121, 24)
        Me.CBoxPriority.TabIndex = 9
        Me.CBoxPriority.Text = "Priority"
        '
        'BtnCreateNewTask
        '
        Me.BtnCreateNewTask.Location = New System.Drawing.Point(192, 389)
        Me.BtnCreateNewTask.Name = "BtnCreateNewTask"
        Me.BtnCreateNewTask.Size = New System.Drawing.Size(113, 23)
        Me.BtnCreateNewTask.TabIndex = 10
        Me.BtnCreateNewTask.Text = "Create Task"
        Me.BtnCreateNewTask.UseVisualStyleBackColor = True
        '
        'LbltID
        '
        Me.LbltID.AutoSize = True
        Me.LbltID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LbltID.Location = New System.Drawing.Point(85, 68)
        Me.LbltID.Name = "LbltID"
        Me.LbltID.Size = New System.Drawing.Size(16, 17)
        Me.LbltID.TabIndex = 11
        Me.LbltID.Text = "1"
        Me.LbltID.Visible = False
        '
        'CBoxChooseProject
        '
        Me.CBoxChooseProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBoxChooseProject.FormattingEnabled = True
        Me.CBoxChooseProject.Location = New System.Drawing.Point(43, 23)
        Me.CBoxChooseProject.Name = "CBoxChooseProject"
        Me.CBoxChooseProject.Size = New System.Drawing.Size(262, 24)
        Me.CBoxChooseProject.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "tID"
        '
        'CreateNewTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(367, 453)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LbltID)
        Me.Controls.Add(Me.BtnCreateNewTask)
        Me.Controls.Add(Me.CBoxPriority)
        Me.Controls.Add(Me.RTBDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBoxType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBoxChooseProject)
        Me.Name = "CreateNewTask"
        Me.Text = "CreateNewTask"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBoxType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RTBDescription As RichTextBox
    Friend WithEvents CBoxPriority As ComboBox
    Friend WithEvents BtnCreateNewTask As Button
    Friend WithEvents LbltID As Label
    Friend WithEvents CBoxChooseProject As ComboBox
    Friend WithEvents Label5 As Label
End Class
