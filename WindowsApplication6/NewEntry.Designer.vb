<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEntry
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
        Me.components = New System.ComponentModel.Container()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.confirm_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TestDataSet = New WindowsApplication6.TestDataSet()
        Me.TblRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRoomTableAdapter = New WindowsApplication6.TestDataSetTableAdapters.tblRoomTableAdapter()
        Me.moduleID_cbox = New System.Windows.Forms.ComboBox()
        Me.time_cbox = New System.Windows.Forms.ComboBox()
        Me.day_cbox = New System.Windows.Forms.ComboBox()
        Me.roomID_cbox = New System.Windows.Forms.ComboBox()
        Me.activityType_cbox = New System.Windows.Forms.ComboBox()
        Me.roomID_label = New System.Windows.Forms.Label()
        Me.time_label = New System.Windows.Forms.Label()
        Me.day_label = New System.Windows.Forms.Label()
        Me.moduleID_label = New System.Windows.Forms.Label()
        Me.activityType_label = New System.Windows.Forms.Label()
        Me.activityName_label = New System.Windows.Forms.Label()
        Me.activityName_txtbox = New System.Windows.Forms.TextBox()
        Me.activityID_label = New System.Windows.Forms.Label()
        Me.activityID_txtbox = New System.Windows.Forms.TextBox()
        Me.TblModuleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblModuleTableAdapter = New WindowsApplication6.TestDataSetTableAdapters.tblModuleTableAdapter()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblModuleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(423, 226)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(138, 62)
        Me.cancel_btn.TabIndex = 48
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'confirm_btn
        '
        Me.confirm_btn.Location = New System.Drawing.Point(18, 226)
        Me.confirm_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.Size = New System.Drawing.Size(138, 62)
        Me.confirm_btn.TabIndex = 47
        Me.confirm_btn.Text = "Confirm"
        Me.confirm_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 37)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "New Entry"
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "TestDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRoomBindingSource
        '
        Me.TblRoomBindingSource.DataMember = "tblRoom"
        Me.TblRoomBindingSource.DataSource = Me.TestDataSet
        '
        'TblRoomTableAdapter
        '
        Me.TblRoomTableAdapter.ClearBeforeFill = True
        '
        'moduleID_cbox
        '
        Me.moduleID_cbox.DataSource = Me.TblModuleBindingSource
        Me.moduleID_cbox.DisplayMember = "ID"
        Me.moduleID_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moduleID_cbox.FormattingEnabled = True
        Me.moduleID_cbox.Location = New System.Drawing.Point(17, 174)
        Me.moduleID_cbox.Name = "moduleID_cbox"
        Me.moduleID_cbox.Size = New System.Drawing.Size(287, 28)
        Me.moduleID_cbox.TabIndex = 62
        '
        'time_cbox
        '
        Me.time_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_cbox.FormattingEnabled = True
        Me.time_cbox.Items.AddRange(New Object() {"9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.time_cbox.Location = New System.Drawing.Point(339, 170)
        Me.time_cbox.Name = "time_cbox"
        Me.time_cbox.Size = New System.Drawing.Size(94, 28)
        Me.time_cbox.TabIndex = 61
        '
        'day_cbox
        '
        Me.day_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_cbox.FormattingEnabled = True
        Me.day_cbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.day_cbox.Location = New System.Drawing.Point(339, 119)
        Me.day_cbox.Name = "day_cbox"
        Me.day_cbox.Size = New System.Drawing.Size(94, 28)
        Me.day_cbox.TabIndex = 60
        '
        'roomID_cbox
        '
        Me.roomID_cbox.DataSource = Me.TblRoomBindingSource
        Me.roomID_cbox.DisplayMember = "ID"
        Me.roomID_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomID_cbox.FormattingEnabled = True
        Me.roomID_cbox.Location = New System.Drawing.Point(467, 62)
        Me.roomID_cbox.Name = "roomID_cbox"
        Me.roomID_cbox.Size = New System.Drawing.Size(94, 28)
        Me.roomID_cbox.TabIndex = 59
        '
        'activityType_cbox
        '
        Me.activityType_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activityType_cbox.FormattingEnabled = True
        Me.activityType_cbox.Items.AddRange(New Object() {"LEC", "TUT", "SEM"})
        Me.activityType_cbox.Location = New System.Drawing.Point(339, 62)
        Me.activityType_cbox.Name = "activityType_cbox"
        Me.activityType_cbox.Size = New System.Drawing.Size(94, 28)
        Me.activityType_cbox.TabIndex = 58
        '
        'roomID_label
        '
        Me.roomID_label.AutoSize = True
        Me.roomID_label.Location = New System.Drawing.Point(464, 50)
        Me.roomID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.roomID_label.Name = "roomID_label"
        Me.roomID_label.Size = New System.Drawing.Size(49, 13)
        Me.roomID_label.TabIndex = 57
        Me.roomID_label.Text = "Room ID"
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Location = New System.Drawing.Point(336, 158)
        Me.time_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(30, 13)
        Me.time_label.TabIndex = 56
        Me.time_label.Text = "Time"
        '
        'day_label
        '
        Me.day_label.AutoSize = True
        Me.day_label.Location = New System.Drawing.Point(336, 104)
        Me.day_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.day_label.Name = "day_label"
        Me.day_label.Size = New System.Drawing.Size(26, 13)
        Me.day_label.TabIndex = 55
        Me.day_label.Text = "Day"
        '
        'moduleID_label
        '
        Me.moduleID_label.AutoSize = True
        Me.moduleID_label.Location = New System.Drawing.Point(14, 158)
        Me.moduleID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.moduleID_label.Name = "moduleID_label"
        Me.moduleID_label.Size = New System.Drawing.Size(56, 13)
        Me.moduleID_label.TabIndex = 54
        Me.moduleID_label.Text = "Module ID"
        '
        'activityType_label
        '
        Me.activityType_label.AutoSize = True
        Me.activityType_label.Location = New System.Drawing.Point(336, 50)
        Me.activityType_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityType_label.Name = "activityType_label"
        Me.activityType_label.Size = New System.Drawing.Size(68, 13)
        Me.activityType_label.TabIndex = 53
        Me.activityType_label.Text = "Activity Type"
        '
        'activityName_label
        '
        Me.activityName_label.AutoSize = True
        Me.activityName_label.Location = New System.Drawing.Point(14, 104)
        Me.activityName_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityName_label.Name = "activityName_label"
        Me.activityName_label.Size = New System.Drawing.Size(72, 13)
        Me.activityName_label.TabIndex = 52
        Me.activityName_label.Text = "Activity Name"
        '
        'activityName_txtbox
        '
        Me.activityName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityName_txtbox.Location = New System.Drawing.Point(17, 119)
        Me.activityName_txtbox.Margin = New System.Windows.Forms.Padding(1)
        Me.activityName_txtbox.Name = "activityName_txtbox"
        Me.activityName_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityName_txtbox.TabIndex = 51
        '
        'activityID_label
        '
        Me.activityID_label.AutoSize = True
        Me.activityID_label.Location = New System.Drawing.Point(15, 49)
        Me.activityID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityID_label.Name = "activityID_label"
        Me.activityID_label.Size = New System.Drawing.Size(58, 13)
        Me.activityID_label.TabIndex = 50
        Me.activityID_label.Text = "Activity ID "
        '
        'activityID_txtbox
        '
        Me.activityID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityID_txtbox.Location = New System.Drawing.Point(17, 64)
        Me.activityID_txtbox.Margin = New System.Windows.Forms.Padding(1)
        Me.activityID_txtbox.Name = "activityID_txtbox"
        Me.activityID_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityID_txtbox.TabIndex = 49
        '
        'TblModuleBindingSource
        '
        Me.TblModuleBindingSource.DataMember = "tblModule"
        Me.TblModuleBindingSource.DataSource = Me.TestDataSet
        '
        'TblModuleTableAdapter
        '
        Me.TblModuleTableAdapter.ClearBeforeFill = True
        '
        'NewEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 305)
        Me.Controls.Add(Me.moduleID_cbox)
        Me.Controls.Add(Me.time_cbox)
        Me.Controls.Add(Me.day_cbox)
        Me.Controls.Add(Me.roomID_cbox)
        Me.Controls.Add(Me.activityType_cbox)
        Me.Controls.Add(Me.roomID_label)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.day_label)
        Me.Controls.Add(Me.moduleID_label)
        Me.Controls.Add(Me.activityType_label)
        Me.Controls.Add(Me.activityName_label)
        Me.Controls.Add(Me.activityName_txtbox)
        Me.Controls.Add(Me.activityID_label)
        Me.Controls.Add(Me.activityID_txtbox)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.confirm_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewEntry"
        Me.Text = "NewEntry"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblModuleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancel_btn As Button
    Friend WithEvents confirm_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TestDataSet As TestDataSet
    Friend WithEvents TblRoomBindingSource As BindingSource
    Friend WithEvents TblRoomTableAdapter As TestDataSetTableAdapters.tblRoomTableAdapter
    Friend WithEvents moduleID_cbox As ComboBox
    Friend WithEvents time_cbox As ComboBox
    Friend WithEvents day_cbox As ComboBox
    Friend WithEvents roomID_cbox As ComboBox
    Friend WithEvents activityType_cbox As ComboBox
    Friend WithEvents roomID_label As Label
    Friend WithEvents time_label As Label
    Friend WithEvents day_label As Label
    Friend WithEvents moduleID_label As Label
    Friend WithEvents activityType_label As Label
    Friend WithEvents activityName_label As Label
    Friend WithEvents activityName_txtbox As TextBox
    Friend WithEvents activityID_label As Label
    Friend WithEvents activityID_txtbox As TextBox
    Friend WithEvents TblModuleBindingSource As BindingSource
    Friend WithEvents TblModuleTableAdapter As TestDataSetTableAdapters.tblModuleTableAdapter
End Class
