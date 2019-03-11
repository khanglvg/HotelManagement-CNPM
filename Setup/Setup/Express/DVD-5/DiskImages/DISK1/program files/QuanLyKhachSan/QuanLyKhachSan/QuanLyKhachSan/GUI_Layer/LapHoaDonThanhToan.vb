Imports GUI_Layer.LapHoaDon_ChonKhachHang
Public Class LapHoaDonThanhToan

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        LapHoaDon_ChonKhachHang.Show()
        Me.Close()
    End Sub



    Private Sub LapHoaDonThanhToan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbMaKhachHang.Text = LapHoaDon_ChonKhachHang._tbMaKhachHang.Text()
        _tbTenKhachHang.Text = BLL.BLL_KhachHang.Instance.LayThongTinKhachHangTuMaKhachHang(_tbMaKhachHang.Text())(0)
        _tbDiaChi.Text = BLL.BLL_KhachHang.Instance.LayThongTinKhachHangTuMaKhachHang(_tbMaKhachHang.Text())(1)
        _tbMaHoaDon.Text = BLL.BLL_HoaDon.Instance.TangMaHoaDon()
        '  _tbTriGiaHoaDon.Text = BLL.BLL_HoaDon.Instance.TinhTriGiaHoaDon()
        BLL.BLL_Phong.Instance.LayDSPhongTuMaKhachHang(DataGridView1, _tbMaKhachHang.Text, _dtpNgayLapHoaDon.Value.ToShortDateString(), "PT01")

    End Sub

    Private Sub _btnThanhToan_Click(sender As Object, e As EventArgs) Handles _btnThanhToan.Click
        BLL.BLL_HoaDon.Instance.ThemHoaDon(_tbMaHoaDon.Text, _tbMaKhachHang.Text, _dtpNgayLapHoaDon.Value.ToShortDateString(), CInt(_tbTriGiaHoaDon.Text))
    End Sub
End Class