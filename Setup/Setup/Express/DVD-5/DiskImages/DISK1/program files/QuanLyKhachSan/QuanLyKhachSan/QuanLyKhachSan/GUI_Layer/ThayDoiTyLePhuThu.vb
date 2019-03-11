Public Class ThayDoiTyLePhuThu
    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
        ThayDoiQuyDinh.Show()
    End Sub

    Private Sub _btnThayDoi_Click(sender As Object, e As EventArgs) Handles _btnThayDoi.Click
        BLL.BLL_ThamSo.Instance.ThayDoiTyLePhuThu(_tbTyLeMoi.Text)
    End Sub

    Private Sub _tbTyLeMoi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _tbTyLeMoi.KeyPress
        If Not [Char].IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ThayDoiTyLePhuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbTyLeCu.Text = BLL.BLL_ThamSo.Instance.LayTyLePhuThuCu().ToString()
    End Sub
End Class