Public Class LapHoaDon_ChonKhachHang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BLL.BLL_KhachHang.Instance.TimKhachHangTheoTen(DataGridView1, _cbTenKhachHang.Text())

    End Sub



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        _tbMaKhachHang.Text() = (DataGridView1.SelectedCells(0).OwningRow.Cells("Mã_Khách_Hàng").Value.ToString())
    End Sub

    Private Sub _btnLapHoaDon_Click(sender As Object, e As EventArgs) Handles _btnLapHoaDon.Click
        If _tbMaKhachHang.Text <> "" Then
            LapHoaDonThanhToan.ShowDialog()

        End If

    End Sub

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
    End Sub
End Class