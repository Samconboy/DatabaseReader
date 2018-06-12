Public Class NewEntry
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        DialogResult = DialogResult.Cancel
    End Sub
    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub roomID_txtbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.tblModule' table. You can move, or remove it, as needed.
        Me.TblModuleTableAdapter.Fill(Me.TestDataSet.tblModule)
        'TODO: This line of code loads data into the 'TestDataSet.tblRoom' table. You can move, or remove it, as needed.
        Me.TblRoomTableAdapter.Fill(Me.TestDataSet.tblRoom)

    End Sub
End Class