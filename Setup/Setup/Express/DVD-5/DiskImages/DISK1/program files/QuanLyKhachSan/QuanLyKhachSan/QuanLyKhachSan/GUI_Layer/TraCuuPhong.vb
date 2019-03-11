Imports System.Data.SqlClient
Imports BLL
Public Class TraCuuPhong


    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
    End Sub

    Public Sub _btnPhongConTrong_Click(sender As Object, e As EventArgs) Handles _btnPhongConTrong.Click
        BLL.BLL_Phong.Instance.XemPhongConTrong(DataGridView1)
    End Sub

    Public Sub _btnPhongDuocThue_Click(sender As Object, e As EventArgs) Handles _btnPhongDuocThue.Click
        BLL.BLL_Phong.Instance.XemPhongDuocThue(DataGridView1)

    End Sub

    Private Sub _btnTraCuuTheoMaPhong_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoMaPhong.Click
        BLL_Phong.Instance.TraCuuTheoMaPhong(DataGridView1, _tbMaPhong.Text())
    End Sub

    Private Sub _btnTraCuuTheoTenPhong_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoTenPhong.Click
        BLL_Phong.Instance.TraCuuTheoTenPhong(DataGridView1, _tbTenPhong.Text())
    End Sub

    Private Sub _btnTraCuuTheoLoaiPhong_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoLoaiPhong.Click
        BLL_LoaiPhong.Instance.TraCuuTheoLoaiPhong(DataGridView1, _cbLoaiPhong.Text())
    End Sub

    Private Sub _btnTraCuuTheoDonGia_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoDonGia.Click
        BLL_LoaiPhong.Instance.TraCuuTheoDonGia(DataGridView1, _cbDonGia.Text())
    End Sub

    'Private Sub _btnTraCuuTheoSoKhach_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoSoKhach.Click
    '    BLL_Phong.Instance.TraCuuTheoSoKhach(DataGridView1, _cbSoLuongKhach.Text())
    'End Sub
End Class