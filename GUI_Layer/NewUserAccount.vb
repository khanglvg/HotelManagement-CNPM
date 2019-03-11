Public Class NewUserAccount
    Private Sub NewUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim installs() As String = New String() _
           {"Admin", "Nhân Viên", "Giám Đốc"}
        Me._cbRole.Items.AddRange(installs)
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        If _tbUserName.Text <> "" AndAlso _tbPass.Text <> "" AndAlso _cbRole.Text <> "" Then

            If BLL.BLL_Login.Instance.IsUserNameAlready(_tbUserName.Text) Then
                MessageBox.Show("This account has already, please try another name :)")
            Else
                BLL.BLL_Login.Instance.InsertUserAccount(_tbUserName.Text, _tbPass.Text, _cbRole.Text)
            End If
        Else
            MessageBox.Show("Please Input All Data :)")
        End If
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        mainForm.Show()
        Me.Close()
    End Sub
End Class