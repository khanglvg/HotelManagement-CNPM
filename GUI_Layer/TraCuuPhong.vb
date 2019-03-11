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

        Try
            BLL_Phong.Instance.TraCuuTheoMaPhong(DataGridView1, _tbMaPhong.Text())
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Chon Ma Phong Can Tim"
        End Try
    End Sub

    Private Sub _btnTraCuuTheoTenPhong_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoTenPhong.Click

        Try
            BLL_Phong.Instance.TraCuuTheoTenPhong(DataGridView1, _tbTenPhong.Text())
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Chon Ten Phong Can Tim"
        End Try
    End Sub

    Private Sub _btnTraCuuTheoLoaiPhong_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoLoaiPhong.Click

        Try
            BLL_LoaiPhong.Instance.TraCuuTheoLoaiPhong(DataGridView1, _cbLoaiPhong.Text())
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Chon Loai Phong Can Tim"
        End Try
    End Sub

    Private Sub _btnTraCuuTheoDonGia_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoDonGia.Click
        Try
            BLL_LoaiPhong.Instance.TraCuuTheoDonGia(DataGridView1, CDbl(_cbDonGia.Text()))
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Chon Don Gia Can Tim"
        End Try

    End Sub

    Private Sub _btnTraCuuTheoSoKhach_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoSoKhach.Click
        Try
            BLL.BLL_Phong.Instance.TraCuuTheoSoKhach(DataGridView1, CInt(_cbSoLuongKhach.Text))
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Chon So Khach Can Tim"
        End Try

    End Sub

    Private Sub TraCuuPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ""
    End Sub

    'Private Sub _btnTraCuuTheoSoKhach_Click(sender As Object, e As EventArgs) Handles _btnTraCuuTheoSoKhach.Click
    '    BLL_Phong.Instance.TraCuuTheoSoKhach(DataGridView1, _cbSoLuongKhach.Text())
    'End Sub
End Class