
Public Class Login


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles _lbClient.Click
        TraCuuPhong.Show()

    End Sub

    Private Sub _btnLogin_Click(sender As Object, e As EventArgs) Handles _btnLogin.Click
        If (BLL.BLL_Login.Instance.KiemTraLogin(_tbUser.Text, _tbPass.Text)) Then
            If (BLL.BLL_Login.Instance.KiemTraVaiTroUser(_tbUser.Text) = 1) Then
                mainForm._mtLapDanhMucPhong.Enabled = True
                mainForm._mtLapPhieuThuePhong.Enabled = True
                mainForm._mtTraCuuPhong.Enabled = True
                mainForm._mtLapHoaDonThanhToan.Enabled = True
                mainForm._mtLapBaoCao.Enabled = True
                mainForm._mtThayDoiQuyDinh.Enabled = True
                mainForm._mtNewLogin.Enabled = True
                mainForm._mtChangePassword.Enabled = True
                mainForm.Show()
                Me.Hide()
            ElseIf (BLL.BLL_Login.Instance.KiemTraVaiTroUser(_tbUser.Text) = 2) Then
                mainForm._mtLapDanhMucPhong.Enabled = False
                mainForm._mtLapPhieuThuePhong.Enabled = True
                mainForm._mtTraCuuPhong.Enabled = True
                mainForm._mtLapHoaDonThanhToan.Enabled = True
                mainForm._mtLapBaoCao.Enabled = True
                mainForm._mtThayDoiQuyDinh.Enabled = False
                mainForm._mtNewLogin.Enabled = False
                mainForm._mtChangePassword.Enabled = True
                mainForm.Show()
                Me.Hide()
            ElseIf (BLL.BLL_Login.Instance.KiemTraVaiTroUser(_tbUser.Text) = 3) Then
                mainForm._mtLapDanhMucPhong.Enabled = True
                mainForm._mtLapPhieuThuePhong.Enabled = False
                mainForm._mtTraCuuPhong.Enabled = True
                mainForm._mtLapHoaDonThanhToan.Enabled = False
                mainForm._mtLapBaoCao.Enabled = False
                mainForm._mtThayDoiQuyDinh.Enabled = True
                mainForm._mtNewLogin.Enabled = False
                mainForm._mtChangePassword.Enabled = True
                mainForm.Show()
                Me.Hide()
            End If

        Else
            MessageBox.Show("User Name or Password is incorrect!")
        End If
    End Sub

    Private Sub _tbUser_TextChanged(sender As Object, e As EventArgs) Handles _tbUser.TextChanged

        _lbTemp.Text = _tbUser.Text
        _tbUser.Text = _lbTemp.Text
    End Sub
End Class