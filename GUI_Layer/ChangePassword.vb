Public Class ChangePassword
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbUserName.Text = Login._tbUser.Text
    End Sub

    Private Sub _btnChange_Click(sender As Object, e As EventArgs) Handles _btnChange.Click
        If (BLL.BLL_Login.Instance.LayPassFromUserID(BLL.BLL_Login.Instance.GetUserIdFromUserName(_tbUserName.Text)) <> _tbOldPass.Text) Then
            MessageBox.Show("Your old password is incorrect!")
        ElseIf _tbConfirm.Text <> _tbNewPass.text Then
            MessageBox.Show("Your comfirm password is incorrect!")
        Else
            BLL.BLL_Login.Instance.ChangePassword(BLL.BLL_Login.Instance.GetUserIdFromUserName(_tbUserName.Text), _tbUserName.Text, _tbNewPass.Text, BLL.BLL_Login.Instance.GetRoleFromUserId(BLL.BLL_Login.Instance.GetUserIdFromUserName(_tbUserName.Text)))
            ToolStripStatusLabel1.Visible = True
            ToolStripStatusLabel1.Text = "Change Successful !"
        End If

    End Sub

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
        mainForm.Show()
    End Sub
End Class