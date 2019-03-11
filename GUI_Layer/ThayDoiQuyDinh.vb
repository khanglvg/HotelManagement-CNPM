Public Class ThayDoiQuyDinh
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub _btnThayDoiTyLePhuThu_Click(sender As Object, e As EventArgs) Handles _btnThayDoiTyLePhuThu.Click
        ThayDoiTyLePhuThu.Show()
        Me.Hide()
    End Sub

    Private Sub _btnThayDoiLoaiPhong_Click(sender As Object, e As EventArgs) Handles _btnThayDoiLoaiPhong.Click
        ThayDoiLoaiPhong.Show()
        Me.Hide()
    End Sub

    Private Sub _btnThayDoiSoLuongKhach_Click(sender As Object, e As EventArgs) Handles _btnThayDoiSoLuongKhach.Click
        ThayDoiSoLuongKhach.Show()
        Me.Hide()
    End Sub
End Class