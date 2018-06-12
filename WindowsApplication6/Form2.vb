Public Class ConfirmAmendments

    Dim activityID As String
    Dim activityName As String
    Dim activityType As String
    Dim moduleID As String
    Dim day As String
    Dim time As String
    Dim roomID As String

    Dim red() As Char = {"r", "e", "d"}
    Public Sub New(ByVal activityID As String, ByVal activityName As String, ByVal activityType As String, ByVal moduleID As String, ByVal day As String, ByVal time As String, ByVal roomID As String)
        InitializeComponent()

        Me.activityID = activityID
        Me.activityName = activityName
        Me.activityType = activityType
        Me.moduleID = moduleID
        Me.day = day
        Me.time = time
        Me.roomID = roomID





    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        activityID_txtbox.Text = activityID

        If activityName.StartsWith("red") Then
            activityName_txtbox.Text = activityName.TrimStart(red)
            activityName_txtbox.BackColor = Color.OrangeRed
        Else activityName_txtbox.Text = activityName
        End If
        If activityType.StartsWith("red") Then
            activityType_txtbox.Text = activityType.TrimStart(red)
            activityType_txtbox.BackColor = Color.OrangeRed
        Else activityType_txtbox.Text = activityType

        End If
        If moduleID.StartsWith("red") Then
            moduleID_txtbox.Text = moduleID.TrimStart(red)
            moduleID_txtbox.BackColor = Color.OrangeRed
        Else moduleID_txtbox.Text = moduleID
        End If
        If day.StartsWith("red") Then
            day_txtbox.Text = day.TrimStart(red)
            day_txtbox.BackColor = Color.OrangeRed
        Else day_txtbox.Text = day
        End If
        If time.StartsWith("red") Then
            time_txtbox.Text = time.TrimStart(red)
            time_txtbox.BackColor = Color.OrangeRed
        Else time_txtbox.Text = time
        End If
        If roomID.StartsWith("red") Then
            roomID_txtbox.Text = roomID.TrimStart(red)
            roomID_txtbox.BackColor = Color.OrangeRed
        Else roomID_txtbox.Text = roomID
        End If



    End Sub

    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        DialogResult = DialogResult.OK

    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub activityID_txtbox_TextChanged(sender As Object, e As EventArgs) Handles activityID_txtbox.TextChanged

    End Sub
End Class