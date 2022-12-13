<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TViewTasks
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
        Me.LblPriority = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.CBoxSelectTask = New System.Windows.Forms.ComboBox()
        Me.BtnMarkasCompleted = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPriority
        '
        Me.LblPriority.AutoSize = True
        Me.LblPriority.Location = New System.Drawing.Point(12, 128)
        Me.LblPriority.Name = "LblPriority"
        Me.LblPriority.Size = New System.Drawing.Size(52, 17)
        Me.LblPriority.TabIndex = 3
        Me.LblPriority.Text = "Priority"
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Location = New System.Drawing.Point(12, 155)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(40, 17)
        Me.LblType.TabIndex = 2
        Me.LblType.Text = "Type"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe Print", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(141, 9)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(111, 50)
        Me.LblStatus.TabIndex = 1
        Me.LblStatus.Text = "Status"
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(12, 97)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(79, 17)
        Me.LblDescription.TabIndex = 0
        Me.LblDescription.Text = "Description"
        '
        'CBoxSelectTask
        '
        Me.CBoxSelectTask.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CBoxSelectTask.FormattingEnabled = True
        Me.CBoxSelectTask.Location = New System.Drawing.Point(517, 12)
        Me.CBoxSelectTask.Name = "CBoxSelectTask"
        Me.CBoxSelectTask.Size = New System.Drawing.Size(177, 24)
        Me.CBoxSelectTask.TabIndex = 4
        Me.CBoxSelectTask.Text = "Select Task"
        '
        'BtnMarkasCompleted
        '
        Me.BtnMarkasCompleted.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnMarkasCompleted.Enabled = False
        Me.BtnMarkasCompleted.Font = New System.Drawing.Font("Tempus Sans ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarkasCompleted.Location = New System.Drawing.Point(473, 447)
        Me.BtnMarkasCompleted.Name = "BtnMarkasCompleted"
        Me.BtnMarkasCompleted.Size = New System.Drawing.Size(221, 38)
        Me.BtnMarkasCompleted.TabIndex = 5
        Me.BtnMarkasCompleted.Text = "Mark as Completed"
        Me.BtnMarkasCompleted.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(219, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Mark Project as Completed"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TViewTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(706, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnMarkasCompleted)
        Me.Controls.Add(Me.CBoxSelectTask)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblPriority)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.LblDescription)
        Me.Name = "TViewTasks"
        Me.Text = "TViewTasks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPriority As Label
    Friend WithEvents LblType As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblDescription As Label
    Friend WithEvents CBoxSelectTask As ComboBox
    Friend WithEvents BtnMarkasCompleted As Button
    Friend WithEvents Button1 As Button
End Class
