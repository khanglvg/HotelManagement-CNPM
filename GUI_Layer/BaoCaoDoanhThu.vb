Public Class BaoCaoDoanhThu
    Private Sub BaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbThang.Text = LapBaoCaoThang._cbThang.Text
        _tbMaBaoCao.Text = LapBaoCaoThang._tbMaBaoCao.Text
        _tbMaBaoCaoDoanhThu.Text = BLL.BLL_BaoCaoDoanhThu.Instance.TangMaBaoCaoDoanhThu()
        BLL.BLL_BaoCaoDoanhThu.Instance.LayDoanhThuLoaiPhongTheoThang(DataGridView1, _tbThang.Text)
    End Sub

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        LapBaoCaoThang.Show()
        Me.Close()
    End Sub


End Class