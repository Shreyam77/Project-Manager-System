<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTasks
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblPriority = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox1.CausesValidation = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select Project"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.LblPriority)
        Me.Panel1.Controls.Add(Me.LblType)
        Me.Panel1.Controls.Add(Me.LblStatus)
        Me.Panel1.Controls.Add(Me.LblDescription)
        Me.Panel1.Location = New System.Drawing.Point(195, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 393)
        Me.Panel1.TabIndex = 2
        '
        'LblPriority
        '
        Me.LblPriority.AutoSize = True
        Me.LblPriority.Location = New System.Drawing.Point(52, 127)
        Me.LblPriority.Name = "LblPriority"
        Me.LblPriority.Size = New System.Drawing.Size(52, 17)
        Me.LblPriority.TabIndex = 3
        Me.LblPriority.Text = "Priority"
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Location = New System.Drawing.Point(52, 154)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(40, 17)
        Me.LblType.TabIndex = 2
        Me.LblType.Text = "Type"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe Print", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(255, 13)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(111, 50)
        Me.LblStatus.TabIndex = 1
        Me.LblStatus.Text = "Status"
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(52, 96)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(79, 17)
        Me.LblDescription.TabIndex = 0
        Me.LblDescription.Text = "Description"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 43)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(177, 24)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Text = "Select Task"
        '
        'ViewTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(843, 420)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "ViewTasks"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDescription As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblPriority As Label
    Friend WithEvents LblType As Label
End Class
