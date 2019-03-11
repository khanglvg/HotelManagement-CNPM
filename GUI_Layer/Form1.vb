Public Class mainForm



    Private Sub _btnThoat_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub _mtLapDanhMucPhong_Click(sender As Object, e As EventArgs) Handles _mtLapDanhMucPhong.Click
        LapDanhMucPhong.ShowDialog()
    End Sub

    Private Sub _mtLapPhieuThuePhong_Click(sender As Object, e As EventArgs) Handles _mtLapPhieuThuePhong.Click
        LapPhieuThuePhong.Show()
    End Sub

    Private Sub _mtTraCuuPhong_Click(sender As Object, e As EventArgs) Handles _mtTraCuuPhong.Click
        TraCuuPhong.Show()
    End Sub

    Private Sub _mtLapHoaDonThanhToan_Click(sender As Object, e As EventArgs) Handles _mtLapHoaDonThanhToan.Click
        LapHoaDon_ChonKhachHang.Show()
    End Sub

    Private Sub _mtLapBaoCao_Click(sender As Object, e As EventArgs) Handles _mtLapBaoCao.Click
        LapBaoCaoThang.Show()
    End Sub

    Private Sub _mtThoat_Click(sender As Object, e As EventArgs) Handles _mtThoat.Click
        Application.Exit()
    End Sub

    Private Sub _mtThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles _mtThayDoiQuyDinh.Click
        ThayDoiQuyDinh.Show()
    End Sub

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lbUserId.Text = "Mã User: " + BLL.BLL_Login.Instance.GetUserIdFromUserName(Login._tbUser.Text)
        _lbRole.Text = "Vai Trò: " + BLL.BLL_Login.Instance.GetRoleFromUserId(BLL.BLL_Login.Instance.GetUserIdFromUserName(Login._tbUser.Text))
    End Sub

    Private Sub _mtNewLogin_Click(sender As Object, e As EventArgs) Handles _mtNewLogin.Click
        NewUserAccount.Show()
        Me.Hide()
    End Sub

    Private Sub _mtChangePassword_Click(sender As Object, e As EventArgs) Handles _mtChangePassword.Click
        ChangePassword.Show()
        Me.Hide()
    End Sub
End Class
