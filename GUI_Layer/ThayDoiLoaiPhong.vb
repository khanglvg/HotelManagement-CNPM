Public Class ThayDoiLoaiPhong
    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
        ThayDoiQuyDinh.Show()
    End Sub

    Private Sub ThayDoiLoaiPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BLL.BLL_LoaiPhong.Instance.XemTatCaCacLoaiPhong(DataGridView1)
    End Sub

    Private Sub _btnXoa_Click(sender As Object, e As EventArgs) Handles _btnXoa.Click
        BLL.BLL_LoaiPhong.Instance.XoaLoaiPhong(DataGridView1)
        BLL.BLL_LoaiPhong.Instance.XemTatCaCacLoaiPhong(DataGridView1)
    End Sub

    Private Sub _btnThem_Click(sender As Object, e As EventArgs) Handles _btnThem.Click
        BLL.BLL_LoaiPhong.Instance.ThemLoaiPhong(_tbMaLoaiPhong.Text, _tbTenLoaiPhong.Text, _tbDonGia.Text)
        BLL.BLL_LoaiPhong.Instance.XemTatCaCacLoaiPhong(DataGridView1)
    End Sub

    Private Sub _btnSua_Click(sender As Object, e As EventArgs) Handles _btnSua.Click
        BLL.BLL_LoaiPhong.Instance.SuaLoaiPhong(DataGridView1)
    End Sub
End Class