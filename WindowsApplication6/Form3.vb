Public Class ConfirmDelete


    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class