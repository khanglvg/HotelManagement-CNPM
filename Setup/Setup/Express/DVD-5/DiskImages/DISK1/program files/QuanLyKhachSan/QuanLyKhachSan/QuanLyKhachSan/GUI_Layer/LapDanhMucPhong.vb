
Public Class LapDanhMucPhong



    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
    End Sub

    Private Sub LapPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BLL.BLL_Phong.Instance.XemTatCaCacPhong(DataGridView1)
        For i As Integer = 0 To BLL.BLL_LoaiPhong.Instance.TraVeTongSoLoaiPhong() - 1

            Me._cbMaLoaiPhong.Items.Add(BLL.BLL_LoaiPhong.Instance.LayTatCaMaLoaiPhong(i))
        Next

    End Sub

    Private Sub _btnThemPhong_Click(sender As Object, e As EventArgs) Handles _btnThemPhong.Click
        BLL.BLL_Phong.Instance.ThemPhong(_tbMaPhong.Text, _tbTenPhong.Text, _cbMaLoaiPhong.Text, _cbTinhTrangPhong.Text, _rtbGhiChu.Text)
        BLL.BLL_Phong.Instance.XemTatCaCacPhong(DataGridView1)
    End Sub

    Private Sub _btnXoaPhong_Click(sender As Object, e As EventArgs) Handles _btnXoaPhong.Click
        BLL.BLL_Phong.Instance.XoaPhong(DataGridView1)
        BLL.BLL_Phong.Instance.XemTatCaCacPhong(DataGridView1)
    End Sub


    Private Sub _rtbGhiChu_MouseClick(sender As Object, e As MouseEventArgs) Handles _rtbGhiChu.MouseClick
        _rtbGhiChu.ResetText()
    End Sub

    Private Sub LapDanhMucPhong_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If (_rtbGhiChu.Text() = "") Then
            _rtbGhiChu.Text = "Không"
        End If

    End Sub

    Private Sub _cbMaLoaiPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _cbMaLoaiPhong.SelectedIndexChanged
        _tbTenLoaiPhong.Text = BLL.BLL_LoaiPhong.Instance.LayTenLoaiPhongTheoMaLoaiPhong(_cbMaLoaiPhong.Text)

    End Sub
End Class
