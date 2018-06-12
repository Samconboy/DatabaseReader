<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmAmendments
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
        Me.roomID_label = New System.Windows.Forms.Label()
        Me.roomID_txtbox = New System.Windows.Forms.TextBox()
        Me.time_label = New System.Windows.Forms.Label()
        Me.time_txtbox = New System.Windows.Forms.TextBox()
        Me.day_label = New System.Windows.Forms.Label()
        Me.day_txtbox = New System.Windows.Forms.TextBox()
        Me.moduleID_label = New System.Windows.Forms.Label()
        Me.moduleID_txtbox = New System.Windows.Forms.TextBox()
        Me.activityType_label = New System.Windows.Forms.Label()
        Me.activityType_txtbox = New System.Windows.Forms.TextBox()
        Me.activityName_label = New System.Windows.Forms.Label()
        Me.activityName_txtbox = New System.Windows.Forms.TextBox()
        Me.activityID_label = New System.Windows.Forms.Label()
        Me.activityID_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confirm_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'roomID_label
        '
        Me.roomID_label.AutoSize = True
        Me.roomID_label.Location = New System.Drawing.Point(228, 290)
        Me.roomID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.roomID_label.Name = "roomID_label"
        Me.roomID_label.Size = New System.Drawing.Size(49, 13)
        Me.roomID_label.TabIndex = 28
        Me.roomID_label.Text = "Room ID"
        '
        'roomID_txtbox
        '
        Me.roomID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.roomID_txtbox.Location = New System.Drawing.Point(231, 305)
        Me.roomID_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.roomID_txtbox.Name = "roomID_txtbox"
        Me.roomID_txtbox.ReadOnly = True
        Me.roomID_txtbox.Size = New System.Drawing.Size(78, 26)
        Me.roomID_txtbox.TabIndex = 27
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Location = New System.Drawing.Point(125, 290)
        Me.time_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(30, 13)
        Me.time_label.TabIndex = 26
        Me.time_label.Text = "Time"
        '
        'time_txtbox
        '
        Me.time_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.time_txtbox.Location = New System.Drawing.Point(128, 305)
        Me.time_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.time_txtbox.Name = "time_txtbox"
        Me.time_txtbox.ReadOnly = True
        Me.time_txtbox.Size = New System.Drawing.Size(78, 26)
        Me.time_txtbox.TabIndex = 25
        '
        'day_label
        '
        Me.day_label.AutoSize = True
        Me.day_label.Location = New System.Drawing.Point(19, 290)
        Me.day_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.day_label.Name = "day_label"
        Me.day_label.Size = New System.Drawing.Size(26, 13)
        Me.day_label.TabIndex = 24
        Me.day_label.Text = "Day"
        '
        'day_txtbox
        '
        Me.day_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.day_txtbox.Location = New System.Drawing.Point(21, 305)
        Me.day_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.day_txtbox.Name = "day_txtbox"
        Me.day_txtbox.ReadOnly = True
        Me.day_txtbox.Size = New System.Drawing.Size(78, 26)
        Me.day_txtbox.TabIndex = 23
        '
        'moduleID_label
        '
        Me.moduleID_label.AutoSize = True
        Me.moduleID_label.Location = New System.Drawing.Point(19, 229)
        Me.moduleID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.moduleID_label.Name = "moduleID_label"
        Me.moduleID_label.Size = New System.Drawing.Size(56, 13)
        Me.moduleID_label.TabIndex = 22
        Me.moduleID_label.Text = "Module ID"
        '
        'moduleID_txtbox
        '
        Me.moduleID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.moduleID_txtbox.Location = New System.Drawing.Point(21, 243)
        Me.moduleID_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.moduleID_txtbox.Name = "moduleID_txtbox"
        Me.moduleID_txtbox.ReadOnly = True
        Me.moduleID_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.moduleID_txtbox.TabIndex = 21
        '
        'activityType_label
        '
        Me.activityType_label.AutoSize = True
        Me.activityType_label.Location = New System.Drawing.Point(19, 175)
        Me.activityType_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityType_label.Name = "activityType_label"
        Me.activityType_label.Size = New System.Drawing.Size(68, 13)
        Me.activityType_label.TabIndex = 20
        Me.activityType_label.Text = "Activity Type"
        '
        'activityType_txtbox
        '
        Me.activityType_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityType_txtbox.Location = New System.Drawing.Point(21, 190)
        Me.activityType_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.activityType_txtbox.Name = "activityType_txtbox"
        Me.activityType_txtbox.ReadOnly = True
        Me.activityType_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityType_txtbox.TabIndex = 19
        '
        'activityName_label
        '
        Me.activityName_label.AutoSize = True
        Me.activityName_label.Location = New System.Drawing.Point(19, 121)
        Me.activityName_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityName_label.Name = "activityName_label"
        Me.activityName_label.Size = New System.Drawing.Size(72, 13)
        Me.activityName_label.TabIndex = 18
        Me.activityName_label.Text = "Activity Name"
        '
        'activityName_txtbox
        '
        Me.activityName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityName_txtbox.Location = New System.Drawing.Point(21, 135)
        Me.activityName_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.activityName_txtbox.Name = "activityName_txtbox"
        Me.activityName_txtbox.ReadOnly = True
        Me.activityName_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityName_txtbox.TabIndex = 17
        '
        'activityID_label
        '
        Me.activityID_label.AutoSize = True
        Me.activityID_label.Location = New System.Drawing.Point(19, 66)
        Me.activityID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityID_label.Name = "activityID_label"
        Me.activityID_label.Size = New System.Drawing.Size(58, 13)
        Me.activityID_label.TabIndex = 16
        Me.activityID_label.Text = "Activity ID "
        '
        'activityID_txtbox
        '
        Me.activityID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityID_txtbox.Location = New System.Drawing.Point(21, 81)
        Me.activityID_txtbox.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.activityID_txtbox.Name = "activityID_txtbox"
        Me.activityID_txtbox.ReadOnly = True
        Me.activityID_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityID_txtbox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 37)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Confirm Amendments"
        '
        'confirm_btn
        '
        Me.confirm_btn.Location = New System.Drawing.Point(21, 341)
        Me.confirm_btn.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.Size = New System.Drawing.Size(138, 62)
        Me.confirm_btn.TabIndex = 30
        Me.confirm_btn.Text = "Confirm"
        Me.confirm_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(171, 341)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(138, 62)
        Me.cancel_btn.TabIndex = 31
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'ConfirmAmendments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(347, 423)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.confirm_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.roomID_label)
        Me.Controls.Add(Me.roomID_txtbox)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.time_txtbox)
        Me.Controls.Add(Me.day_label)
        Me.Controls.Add(Me.day_txtbox)
        Me.Controls.Add(Me.moduleID_label)
        Me.Controls.Add(Me.moduleID_txtbox)
        Me.Controls.Add(Me.activityType_label)
        Me.Controls.Add(Me.activityType_txtbox)
        Me.Controls.Add(Me.activityName_label)
        Me.Controls.Add(Me.activityName_txtbox)
        Me.Controls.Add(Me.activityID_label)
        Me.Controls.Add(Me.activityID_txtbox)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfirmAmendments"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Text = "Confirm Ammendments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roomID_label As Label
    Friend WithEvents roomID_txtbox As TextBox
    Friend WithEvents time_label As Label
    Friend WithEvents time_txtbox As TextBox
    Friend WithEvents day_label As Label
    Friend WithEvents day_txtbox As TextBox
    Friend WithEvents moduleID_label As Label
    Friend WithEvents moduleID_txtbox As TextBox
    Friend WithEvents activityType_label As Label
    Friend WithEvents activityType_txtbox As TextBox
    Friend WithEvents activityName_label As Label
    Friend WithEvents activityName_txtbox As TextBox
    Friend WithEvents activityID_label As Label
    Friend WithEvents activityID_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents confirm_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
