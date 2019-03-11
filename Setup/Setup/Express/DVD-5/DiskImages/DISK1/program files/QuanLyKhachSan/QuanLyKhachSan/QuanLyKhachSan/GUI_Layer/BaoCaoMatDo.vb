Public Class BaoCaoMatDo
    Private Sub BaoCaoMatDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbThang.Text = LapBaoCaoThang._cbThang.Text
        _tbMaBaoCao.Text = LapBaoCaoThang._tbMaBaoCao.Text
        _tbMaBaoCaoMatDo.Text = BLL.BLL_BaoCaoMatDo.Instance.TangMaBaoCaoMatDo()
        BLL.BLL_BaoCaoMatDo.Instance.LayMatDoSuDungPhongTheoThang(DataGridView1, _tbThang.Text)
    End Sub


    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click
        Me.Close()
        LapBaoCaoThang.Show()
    End Sub


End Class