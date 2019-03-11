Public Class ThayDoiSoLuongKhach
    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
        ThayDoiQuyDinh.Show()
    End Sub

    Private Sub _btnThem_Click(sender As Object, e As EventArgs) Handles _btnThem.Click
        BLL.BLL_LoaiKhach.Instance.ThemLoaiKhach(_tbMaLoaiKhachMoi.Text, _tbTenLoaiKhachMoi.Text)
        BLL.BLL_LoaiKhach.Instance.XemTatCaCacLoaiKhach(DataGridView1)
    End Sub

    Private Sub ThayDoiSoLuongKhach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbHeSoCu.Text = BLL.BLL_ThamSo.Instance.LaySoKhachToiDaCu().ToString()
        BLL.BLL_LoaiKhach.Instance.XemTatCaCacLoaiKhach(DataGridView1)
    End Sub

    Private Sub _btnXoa_Click(sender As Object, e As EventArgs) Handles _btnXoa.Click
        BLL.BLL_LoaiKhach.Instance.XoaLoaiKhach(DataGridView1)
        BLL.BLL_LoaiKhach.Instance.XemTatCaCacLoaiKhach(DataGridView1)
    End Sub

    Private Sub _btnSua_Click(sender As Object, e As EventArgs) Handles _btnSua.Click
        BLL.BLL_LoaiKhach.Instance.SuaLoaiKhach(DataGridView1)
        BLL.BLL_LoaiKhach.Instance.XemTatCaCacLoaiKhach(DataGridView1)
    End Sub

    Private Sub _btnCapNhat_Click(sender As Object, e As EventArgs) Handles _btnCapNhat.Click
        BLL.BLL_ThamSo.Instance.ThayDoiSoKhachToiDaMoiPhong(_tbHeSoMoi.Text)
    End Sub

    Private Sub _tbHeSoMoi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _tbHeSoMoi.KeyPress
        If Not [Char].IsDigit(e.KeyChar) AndAlso Not [Char].IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class