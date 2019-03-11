Public Class LapBaoCaoThang
    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
    End Sub

    Private Sub _btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles _btnLapBaoCao.Click
        If (_cbTenLoaiBaoCao.Text = "Báo Cáo Doanh Thu Theo Loại Phòng" AndAlso (_cbThang.Text <> "")) Then
            BaoCaoDoanhThu.Show()
            Me.Hide()
        ElseIf ((_cbTenLoaiBaoCao.Text = "Báo Cáo Mật Độ Sử Dụng Phòng") AndAlso (_cbThang.Text <> "")) Then
            BaoCaoMatDo.Show()
            Me.Hide()
        Else
            MessageBox.Show("Vui Lòng Chọn Tên Loại Báo Cáo Và Tháng Cần Lập.")
        End If

    End Sub

    Private Sub LapBaoCaoThang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbMaBaoCao.Text = BLL.BLL_BaoCaoThang.Instance.TangMaBaoCaoThang()
    End Sub
End Class