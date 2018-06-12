<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseViewer
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
        Me.components = New System.ComponentModel.Container()
        Me.connect_btn = New System.Windows.Forms.Button()
        Me.activityID_txtbox = New System.Windows.Forms.TextBox()
        Me.activityID_label = New System.Windows.Forms.Label()
        Me.activityName_label = New System.Windows.Forms.Label()
        Me.activityName_txtbox = New System.Windows.Forms.TextBox()
        Me.activityType_label = New System.Windows.Forms.Label()
        Me.moduleID_label = New System.Windows.Forms.Label()
        Me.day_label = New System.Windows.Forms.Label()
        Me.time_label = New System.Windows.Forms.Label()
        Me.roomID_label = New System.Windows.Forms.Label()
        Me.firstRecord_btn = New System.Windows.Forms.Button()
        Me.previousRecord_btn = New System.Windows.Forms.Button()
        Me.nextRecord_btn = New System.Windows.Forms.Button()
        Me.lastRecord_btn = New System.Windows.Forms.Button()
        Me.position_txtbox = New System.Windows.Forms.TextBox()
        Me.amend_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.slash_label = New System.Windows.Forms.Label()
        Me.Max_label = New System.Windows.Forms.Label()
        Me.activityType_cbox = New System.Windows.Forms.ComboBox()
        Me.TestDataSet = New WindowsApplication6.TestDataSet()
        Me.TblRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRoomTableAdapter = New WindowsApplication6.TestDataSetTableAdapters.tblRoomTableAdapter()
        Me.roomID_cbox = New System.Windows.Forms.ComboBox()
        Me.time_cbox = New System.Windows.Forms.ComboBox()
        Me.moduleID_cbox = New System.Windows.Forms.ComboBox()
        Me.TblModuleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActivityTableAdapter = New WindowsApplication6.TestDataSetTableAdapters.tblActivityTableAdapter()
        Me.TblActivityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.day_cbox = New System.Windows.Forms.ComboBox()
        Me.TblModuleTableAdapter = New WindowsApplication6.TestDataSetTableAdapters.tblModuleTableAdapter()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblModuleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'connect_btn
        '
        Me.connect_btn.Location = New System.Drawing.Point(9, 11)
        Me.connect_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.connect_btn.Name = "connect_btn"
        Me.connect_btn.Size = New System.Drawing.Size(91, 58)
        Me.connect_btn.TabIndex = 0
        Me.connect_btn.Text = "Connect"
        Me.connect_btn.UseVisualStyleBackColor = True
        '
        'activityID_txtbox
        '
        Me.activityID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityID_txtbox.Location = New System.Drawing.Point(18, 103)
        Me.activityID_txtbox.Margin = New System.Windows.Forms.Padding(1)
        Me.activityID_txtbox.Name = "activityID_txtbox"
        Me.activityID_txtbox.ReadOnly = True
        Me.activityID_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityID_txtbox.TabIndex = 1
        '
        'activityID_label
        '
        Me.activityID_label.AutoSize = True
        Me.activityID_label.Location = New System.Drawing.Point(16, 88)
        Me.activityID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityID_label.Name = "activityID_label"
        Me.activityID_label.Size = New System.Drawing.Size(58, 13)
        Me.activityID_label.TabIndex = 2
        Me.activityID_label.Text = "Activity ID "
        '
        'activityName_label
        '
        Me.activityName_label.AutoSize = True
        Me.activityName_label.Location = New System.Drawing.Point(15, 143)
        Me.activityName_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityName_label.Name = "activityName_label"
        Me.activityName_label.Size = New System.Drawing.Size(72, 13)
        Me.activityName_label.TabIndex = 4
        Me.activityName_label.Text = "Activity Name"
        '
        'activityName_txtbox
        '
        Me.activityName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.activityName_txtbox.Location = New System.Drawing.Point(18, 158)
        Me.activityName_txtbox.Margin = New System.Windows.Forms.Padding(1)
        Me.activityName_txtbox.Name = "activityName_txtbox"
        Me.activityName_txtbox.Size = New System.Drawing.Size(288, 26)
        Me.activityName_txtbox.TabIndex = 3
        '
        'activityType_label
        '
        Me.activityType_label.AutoSize = True
        Me.activityType_label.Location = New System.Drawing.Point(337, 89)
        Me.activityType_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.activityType_label.Name = "activityType_label"
        Me.activityType_label.Size = New System.Drawing.Size(68, 13)
        Me.activityType_label.TabIndex = 6
        Me.activityType_label.Text = "Activity Type"
        '
        'moduleID_label
        '
        Me.moduleID_label.AutoSize = True
        Me.moduleID_label.Location = New System.Drawing.Point(15, 197)
        Me.moduleID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.moduleID_label.Name = "moduleID_label"
        Me.moduleID_label.Size = New System.Drawing.Size(56, 13)
        Me.moduleID_label.TabIndex = 8
        Me.moduleID_label.Text = "Module ID"
        '
        'day_label
        '
        Me.day_label.AutoSize = True
        Me.day_label.Location = New System.Drawing.Point(337, 143)
        Me.day_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.day_label.Name = "day_label"
        Me.day_label.Size = New System.Drawing.Size(26, 13)
        Me.day_label.TabIndex = 10
        Me.day_label.Text = "Day"
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Location = New System.Drawing.Point(337, 197)
        Me.time_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(30, 13)
        Me.time_label.TabIndex = 12
        Me.time_label.Text = "Time"
        '
        'roomID_label
        '
        Me.roomID_label.AutoSize = True
        Me.roomID_label.Location = New System.Drawing.Point(465, 89)
        Me.roomID_label.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.roomID_label.Name = "roomID_label"
        Me.roomID_label.Size = New System.Drawing.Size(49, 13)
        Me.roomID_label.TabIndex = 14
        Me.roomID_label.Text = "Room ID"
        '
        'firstRecord_btn
        '
        Me.firstRecord_btn.Enabled = False
        Me.firstRecord_btn.Location = New System.Drawing.Point(102, 262)
        Me.firstRecord_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.firstRecord_btn.Name = "firstRecord_btn"
        Me.firstRecord_btn.Size = New System.Drawing.Size(60, 45)
        Me.firstRecord_btn.TabIndex = 15
        Me.firstRecord_btn.Text = "<<"
        Me.firstRecord_btn.UseVisualStyleBackColor = True
        '
        'previousRecord_btn
        '
        Me.previousRecord_btn.Enabled = False
        Me.previousRecord_btn.Location = New System.Drawing.Point(164, 262)
        Me.previousRecord_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.previousRecord_btn.Name = "previousRecord_btn"
        Me.previousRecord_btn.Size = New System.Drawing.Size(60, 45)
        Me.previousRecord_btn.TabIndex = 16
        Me.previousRecord_btn.Text = "<"
        Me.previousRecord_btn.UseVisualStyleBackColor = True
        '
        'nextRecord_btn
        '
        Me.nextRecord_btn.Location = New System.Drawing.Point(354, 262)
        Me.nextRecord_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.nextRecord_btn.Name = "nextRecord_btn"
        Me.nextRecord_btn.Size = New System.Drawing.Size(60, 45)
        Me.nextRecord_btn.TabIndex = 17
        Me.nextRecord_btn.Text = ">"
        Me.nextRecord_btn.UseVisualStyleBackColor = True
        '
        'lastRecord_btn
        '
        Me.lastRecord_btn.Location = New System.Drawing.Point(416, 262)
        Me.lastRecord_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.lastRecord_btn.Name = "lastRecord_btn"
        Me.lastRecord_btn.Size = New System.Drawing.Size(60, 45)
        Me.lastRecord_btn.TabIndex = 18
        Me.lastRecord_btn.Text = ">>"
        Me.lastRecord_btn.UseVisualStyleBackColor = True
        '
        'position_txtbox
        '
        Me.position_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.position_txtbox.Location = New System.Drawing.Point(233, 270)
        Me.position_txtbox.Margin = New System.Windows.Forms.Padding(1)
        Me.position_txtbox.Name = "position_txtbox"
        Me.position_txtbox.Size = New System.Drawing.Size(38, 26)
        Me.position_txtbox.TabIndex = 19
        Me.position_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'amend_btn
        '
        Me.amend_btn.Location = New System.Drawing.Point(229, 329)
        Me.amend_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.amend_btn.Name = "amend_btn"
        Me.amend_btn.Size = New System.Drawing.Size(121, 59)
        Me.amend_btn.TabIndex = 21
        Me.amend_btn.Text = "Amend"
        Me.amend_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(437, 329)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(125, 59)
        Me.delete_btn.TabIndex = 22
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(19, 329)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(1)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(125, 59)
        Me.add_btn.TabIndex = 23
        Me.add_btn.Text = "New"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'slash_label
        '
        Me.slash_label.AutoSize = True
        Me.slash_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slash_label.Location = New System.Drawing.Point(275, 262)
        Me.slash_label.Name = "slash_label"
        Me.slash_label.Size = New System.Drawing.Size(38, 42)
        Me.slash_label.TabIndex = 24
        Me.slash_label.Text = "/ "
        '
        'Max_label
        '
        Me.Max_label.AutoSize = True
        Me.Max_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Max_label.Location = New System.Drawing.Point(298, 270)
        Me.Max_label.Name = "Max_label"
        Me.Max_label.Size = New System.Drawing.Size(52, 29)
        Me.Max_label.TabIndex = 25
        Me.Max_label.Text = "000"
        '
        'activityType_cbox
        '
        Me.activityType_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activityType_cbox.FormattingEnabled = True
        Me.activityType_cbox.Items.AddRange(New Object() {"LEC", "TUT", "SEM"})
        Me.activityType_cbox.Location = New System.Drawing.Point(340, 101)
        Me.activityType_cbox.Name = "activityType_cbox"
        Me.activityType_cbox.Size = New System.Drawing.Size(94, 28)
        Me.activityType_cbox.TabIndex = 26
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
        'roomID_cbox
        '
        Me.roomID_cbox.DataSource = Me.TblRoomBindingSource
        Me.roomID_cbox.DisplayMember = "ID"
        Me.roomID_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomID_cbox.FormattingEnabled = True
        Me.roomID_cbox.Location = New System.Drawing.Point(468, 101)
        Me.roomID_cbox.Name = "roomID_cbox"
        Me.roomID_cbox.Size = New System.Drawing.Size(94, 28)
        Me.roomID_cbox.TabIndex = 27
        '
        'time_cbox
        '
        Me.time_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_cbox.FormattingEnabled = True
        Me.time_cbox.Items.AddRange(New Object() {"9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.time_cbox.Location = New System.Drawing.Point(340, 209)
        Me.time_cbox.Name = "time_cbox"
        Me.time_cbox.Size = New System.Drawing.Size(94, 28)
        Me.time_cbox.TabIndex = 29
        '
        'moduleID_cbox
        '
        Me.moduleID_cbox.DataSource = Me.TblModuleBindingSource
        Me.moduleID_cbox.DisplayMember = "ID"
        Me.moduleID_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moduleID_cbox.FormattingEnabled = True
        Me.moduleID_cbox.Location = New System.Drawing.Point(18, 213)
        Me.moduleID_cbox.Name = "moduleID_cbox"
        Me.moduleID_cbox.Size = New System.Drawing.Size(287, 28)
        Me.moduleID_cbox.TabIndex = 30
        '
        'TblModuleBindingSource
        '
        Me.TblModuleBindingSource.DataMember = "tblModule"
        Me.TblModuleBindingSource.DataSource = Me.TestDataSet
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.TestDataSet
        '
        'TblActivityTableAdapter
        '
        Me.TblActivityTableAdapter.ClearBeforeFill = True
        '
        'TblActivityBindingSource1
        '
        Me.TblActivityBindingSource1.DataMember = "tblActivity"
        Me.TblActivityBindingSource1.DataSource = Me.TestDataSet
        '
        'day_cbox
        '
        Me.day_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_cbox.FormattingEnabled = True
        Me.day_cbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.day_cbox.Location = New System.Drawing.Point(340, 158)
        Me.day_cbox.Name = "day_cbox"
        Me.day_cbox.Size = New System.Drawing.Size(94, 28)
        Me.day_cbox.TabIndex = 28
        '
        'TblModuleTableAdapter
        '
        Me.TblModuleTableAdapter.ClearBeforeFill = True
        '
        'DatabaseViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(575, 408)
        Me.Controls.Add(Me.moduleID_cbox)
        Me.Controls.Add(Me.time_cbox)
        Me.Controls.Add(Me.day_cbox)
        Me.Controls.Add(Me.roomID_cbox)
        Me.Controls.Add(Me.activityType_cbox)
        Me.Controls.Add(Me.Max_label)
        Me.Controls.Add(Me.position_txtbox)
        Me.Controls.Add(Me.slash_label)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.amend_btn)
        Me.Controls.Add(Me.lastRecord_btn)
        Me.Controls.Add(Me.nextRecord_btn)
        Me.Controls.Add(Me.previousRecord_btn)
        Me.Controls.Add(Me.firstRecord_btn)
        Me.Controls.Add(Me.roomID_label)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.day_label)
        Me.Controls.Add(Me.moduleID_label)
        Me.Controls.Add(Me.activityType_label)
        Me.Controls.Add(Me.activityName_label)
        Me.Controls.Add(Me.activityName_txtbox)
        Me.Controls.Add(Me.activityID_label)
        Me.Controls.Add(Me.activityID_txtbox)
        Me.Controls.Add(Me.connect_btn)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "DatabaseViewer"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Viewer"
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblModuleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connect_btn As Button
    Friend WithEvents activityID_txtbox As TextBox
    Friend WithEvents activityID_label As Label
    Friend WithEvents activityName_label As Label
    Friend WithEvents activityName_txtbox As TextBox
    Friend WithEvents activityType_label As Label
    Friend WithEvents moduleID_label As Label
    Friend WithEvents day_label As Label
    Friend WithEvents time_label As Label
    Friend WithEvents roomID_label As Label
    Friend WithEvents firstRecord_btn As Button
    Friend WithEvents previousRecord_btn As Button
    Friend WithEvents nextRecord_btn As Button
    Friend WithEvents lastRecord_btn As Button
    Friend WithEvents position_txtbox As TextBox
    Friend WithEvents amend_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents slash_label As Label
    Friend WithEvents Max_label As Label
    Friend WithEvents activityType_cbox As ComboBox
    Friend WithEvents TestDataSet As TestDataSet
    Friend WithEvents TblRoomBindingSource As BindingSource
    Friend WithEvents TblRoomTableAdapter As TestDataSetTableAdapters.tblRoomTableAdapter
    Friend WithEvents roomID_cbox As ComboBox
    Friend WithEvents time_cbox As ComboBox
    Friend WithEvents moduleID_cbox As ComboBox
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As TestDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TblActivityBindingSource1 As BindingSource
    Friend WithEvents day_cbox As ComboBox
    Friend WithEvents TblModuleBindingSource As BindingSource
    Friend WithEvents TblModuleTableAdapter As TestDataSetTableAdapters.tblModuleTableAdapter
End Class
