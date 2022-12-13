<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TViewProjects
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBoxSelectProject = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnViewTasks = New System.Windows.Forms.Button()
        Me.BtnViewStats = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxSelectStudent = New System.Windows.Forms.ComboBox()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.BtnMakeChanges = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CBoxGanttChart = New System.Windows.Forms.ComboBox()
        Me.CBoxER = New System.Windows.Forms.ComboBox()
        Me.CBoxDFD = New System.Windows.Forms.ComboBox()
        Me.CBoxSynopsis = New System.Windows.Forms.ComboBox()
        Me.LblGanttChart = New System.Windows.Forms.Label()
        Me.LblER = New System.Windows.Forms.Label()
        Me.LblDFD = New System.Windows.Forms.Label()
        Me.LblSynopsis = New System.Windows.Forms.Label()
        Me.LblProjectName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(208, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(760, 591)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.CBoxSelectProject)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnViewTasks)
        Me.Panel1.Controls.Add(Me.BtnViewStats)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBoxSelectStudent)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 591)
        Me.Panel1.TabIndex = 1
        '
        'CBoxSelectProject
        '
        Me.CBoxSelectProject.BackColor = System.Drawing.Color.DarkCyan
        Me.CBoxSelectProject.FormattingEnabled = True
        Me.CBoxSelectProject.Location = New System.Drawing.Point(4, 96)
        Me.CBoxSelectProject.Name = "CBoxSelectProject"
        Me.CBoxSelectProject.Size = New System.Drawing.Size(164, 24)
        Me.CBoxSelectProject.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Project"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Location = New System.Drawing.Point(15, 174)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(150, 32)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnViewTasks
        '
        Me.BtnViewTasks.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnViewTasks.Enabled = False
        Me.BtnViewTasks.Location = New System.Drawing.Point(15, 257)
        Me.BtnViewTasks.Name = "BtnViewTasks"
        Me.BtnViewTasks.Size = New System.Drawing.Size(150, 32)
        Me.BtnViewTasks.TabIndex = 5
        Me.BtnViewTasks.Text = "View Tasks"
        Me.BtnViewTasks.UseVisualStyleBackColor = False
        '
        'BtnViewStats
        '
        Me.BtnViewStats.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnViewStats.Enabled = False
        Me.BtnViewStats.Location = New System.Drawing.Point(15, 214)
        Me.BtnViewStats.Name = "BtnViewStats"
        Me.BtnViewStats.Size = New System.Drawing.Size(150, 32)
        Me.BtnViewStats.TabIndex = 4
        Me.BtnViewStats.Text = "View Stats"
        Me.BtnViewStats.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Student"
        '
        'CBoxSelectStudent
        '
        Me.CBoxSelectStudent.BackColor = System.Drawing.Color.DarkCyan
        Me.CBoxSelectStudent.FormattingEnabled = True
        Me.CBoxSelectStudent.Location = New System.Drawing.Point(3, 36)
        Me.CBoxSelectStudent.Name = "CBoxSelectStudent"
        Me.CBoxSelectStudent.Size = New System.Drawing.Size(165, 24)
        Me.CBoxSelectStudent.TabIndex = 0
        '
        'PnlEdit
        '
        Me.PnlEdit.Controls.Add(Me.TextBox1)
        Me.PnlEdit.Controls.Add(Me.BtnMakeChanges)
        Me.PnlEdit.Controls.Add(Me.BtnCancel)
        Me.PnlEdit.Controls.Add(Me.CBoxGanttChart)
        Me.PnlEdit.Controls.Add(Me.CBoxER)
        Me.PnlEdit.Controls.Add(Me.CBoxDFD)
        Me.PnlEdit.Controls.Add(Me.CBoxSynopsis)
        Me.PnlEdit.Controls.Add(Me.LblGanttChart)
        Me.PnlEdit.Controls.Add(Me.LblER)
        Me.PnlEdit.Controls.Add(Me.LblDFD)
        Me.PnlEdit.Controls.Add(Me.LblSynopsis)
        Me.PnlEdit.Controls.Add(Me.LblProjectName)
        Me.PnlEdit.Location = New System.Drawing.Point(318, 108)
        Me.PnlEdit.Name = "PnlEdit"
        Me.PnlEdit.Size = New System.Drawing.Size(455, 365)
        Me.PnlEdit.TabIndex = 2
        Me.PnlEdit.Visible = False
        '
        'BtnMakeChanges
        '
        Me.BtnMakeChanges.Location = New System.Drawing.Point(248, 303)
        Me.BtnMakeChanges.Name = "BtnMakeChanges"
        Me.BtnMakeChanges.Size = New System.Drawing.Size(121, 33)
        Me.BtnMakeChanges.TabIndex = 11
        Me.BtnMakeChanges.Text = "Make Changes"
        Me.BtnMakeChanges.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(126, 303)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(91, 33)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'CBoxGanttChart
        '
        Me.CBoxGanttChart.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CBoxGanttChart.FormattingEnabled = True
        Me.CBoxGanttChart.Location = New System.Drawing.Point(208, 226)
        Me.CBoxGanttChart.Name = "CBoxGanttChart"
        Me.CBoxGanttChart.Size = New System.Drawing.Size(121, 24)
        Me.CBoxGanttChart.TabIndex = 9
        '
        'CBoxER
        '
        Me.CBoxER.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CBoxER.FormattingEnabled = True
        Me.CBoxER.Location = New System.Drawing.Point(208, 192)
        Me.CBoxER.Name = "CBoxER"
        Me.CBoxER.Size = New System.Drawing.Size(121, 24)
        Me.CBoxER.TabIndex = 8
        '
        'CBoxDFD
        '
        Me.CBoxDFD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CBoxDFD.FormattingEnabled = True
        Me.CBoxDFD.Location = New System.Drawing.Point(208, 158)
        Me.CBoxDFD.Name = "CBoxDFD"
        Me.CBoxDFD.Size = New System.Drawing.Size(121, 24)
        Me.CBoxDFD.TabIndex = 7
        '
        'CBoxSynopsis
        '
        Me.CBoxSynopsis.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CBoxSynopsis.FormattingEnabled = True
        Me.CBoxSynopsis.Location = New System.Drawing.Point(208, 124)
        Me.CBoxSynopsis.Name = "CBoxSynopsis"
        Me.CBoxSynopsis.Size = New System.Drawing.Size(121, 24)
        Me.CBoxSynopsis.TabIndex = 6
        '
        'LblGanttChart
        '
        Me.LblGanttChart.AutoSize = True
        Me.LblGanttChart.Location = New System.Drawing.Point(56, 229)
        Me.LblGanttChart.Name = "LblGanttChart"
        Me.LblGanttChart.Size = New System.Drawing.Size(81, 17)
        Me.LblGanttChart.TabIndex = 4
        Me.LblGanttChart.Text = "Gantt Chart"
        '
        'LblER
        '
        Me.LblER.AutoSize = True
        Me.LblER.Location = New System.Drawing.Point(56, 195)
        Me.LblER.Name = "LblER"
        Me.LblER.Size = New System.Drawing.Size(27, 17)
        Me.LblER.TabIndex = 3
        Me.LblER.Text = "ER"
        '
        'LblDFD
        '
        Me.LblDFD.AutoSize = True
        Me.LblDFD.Location = New System.Drawing.Point(56, 161)
        Me.LblDFD.Name = "LblDFD"
        Me.LblDFD.Size = New System.Drawing.Size(36, 17)
        Me.LblDFD.TabIndex = 2
        Me.LblDFD.Text = "DFD"
        '
        'LblSynopsis
        '
        Me.LblSynopsis.AutoSize = True
        Me.LblSynopsis.Location = New System.Drawing.Point(56, 127)
        Me.LblSynopsis.Name = "LblSynopsis"
        Me.LblSynopsis.Size = New System.Drawing.Size(65, 17)
        Me.LblSynopsis.TabIndex = 1
        Me.LblSynopsis.Text = "Synopsis"
        '
        'LblProjectName
        '
        Me.LblProjectName.AutoSize = True
        Me.LblProjectName.Location = New System.Drawing.Point(56, 93)
        Me.LblProjectName.Name = "LblProjectName"
        Me.LblProjectName.Size = New System.Drawing.Size(93, 17)
        Me.LblProjectName.TabIndex = 0
        Me.LblProjectName.Text = "Project Name"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox1.Location = New System.Drawing.Point(208, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 22)
        Me.TextBox1.TabIndex = 12
        '
        'TViewProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(980, 615)
        Me.Controls.Add(Me.PnlEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TViewProjects"
        Me.Text = "TViewProjects"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlEdit.ResumeLayout(False)
        Me.PnlEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CBoxSelectStudent As ComboBox
    Friend WithEvents BtnViewStats As Button
    Friend WithEvents BtnViewTasks As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents PnlEdit As Panel
    Friend WithEvents LblGanttChart As Label
    Friend WithEvents LblER As Label
    Friend WithEvents LblDFD As Label
    Friend WithEvents LblSynopsis As Label
    Friend WithEvents LblProjectName As Label
    Friend WithEvents BtnMakeChanges As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CBoxGanttChart As ComboBox
    Friend WithEvents CBoxER As ComboBox
    Friend WithEvents CBoxDFD As ComboBox
    Friend WithEvents CBoxSynopsis As ComboBox
    Friend WithEvents CBoxSelectProject As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
