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
        Dim temp As Integer = BLL.BLL_Phong.Instance.GetSumPhongsOfKhachHang(_tbMaKhachHang.Text, _dtpNgayLapHoaDon.Value.ToShortDateString(), 1, 1)
        Dim temp1 As Single
        For i As Integer = 0 To temp - 1
            temp1 += DataGridView1.Rows(i).Cells("Thành_Tiền").Value.ToString()
        Next
        _tbTriGiaHoaDon.Text = temp1
        ToolStripStatusLabel1.Text = ""
    End Sub

    Private Sub _btnThanhToan_Click(sender As Object, e As EventArgs) Handles _btnThanhToan.Click
        Dim temp As Integer = BLL.BLL_Phong.Instance.GetSumPhongsOfKhachHang(_tbMaKhachHang.Text, _dtpNgayLapHoaDon.Value.ToShortDateString(), 1, 1)
        For i As Integer = 0 To temp - 1
            BLL.BLL_Phong.Instance.ThayDoiTinhTrangPhong(BLL.BLL_Phong.Instance.LayMaPhongTuMaPhieuThue((DataGridView1.Rows(i).Cells("Mã_Phiếu_Thuê").Value.ToString())))
        Next
        BLL.BLL_HoaDon.Instance.ThemHoaDon(ToolStripStatusLabel1, _tbMaHoaDon.Text, _tbMaKhachHang.Text, _dtpNgayLapHoaDon.Value.ToShortDateString(), CInt(_tbTriGiaHoaDon.Text))
    End Sub
End Class