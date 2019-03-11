
Public Class LapPhieuThuePhong
    ''' <summary>
    ''' thay đổi tình trạng phòng sau khi lập phiếu thuê phòng
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>



    Sub _btnThem_Click(sender As Object, e As EventArgs) Handles _btnThem.Click

        Try
            If (BLL.BLL_PhieuThue.Instance.KiemTraSoLuongKhachTrongPhong(_tbMaPhieuThue.Text) = False) Then
                BLL.BLL_KhachHang.Instance.ThemKhachHang(_tbMaKhachHang.Text, _tbKhachHang.Text, _tbMaLoaiKhachHang.Text, _tbCMND.Text, _tbDiaChi.Text)
                BLL.BLL_ChiTietPhieuThue.Instance.ThemChiTietPhieuThue(_tbMaPhieuThue.Text, _tbMaKhachHang.Text)
                _tbMaKhachHang.Text = BLL.BLL_KhachHang.Instance.TangMaKhachHang()
                BLL.BLL_KhachHang.Instance.LayThongTinKhachHangVuaThemVaoPhieuThue(DataGridView1, _tbMaPhieuThue.Text())
                _tbKhachHang.Text = ""
                _tbCMND.Text = ""
                _tbDiaChi.Text = ""
            Else
                MessageBox.Show("So luong khach toi da trong moi phong la 3")
                _btnThem.Enabled = False

            End If


        Catch ex As Exception
            MessageBox.Show("review your data input!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub _btnTroVe_Click(sender As Object, e As EventArgs) Handles _btnTroVe.Click

        Me.Close()


    End Sub

    Private Sub _tbCMND_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _tbCMND.KeyPress
        If Not [Char].IsDigit(e.KeyChar) AndAlso Not [Char].IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub _rtbGhiChu_MouseClick(sender As Object, e As MouseEventArgs) Handles _rtbGhiChu.MouseClick
        _rtbGhiChu.ResetText()
    End Sub



    Private Sub _btnThuePhong_Click(sender As Object, e As EventArgs) Handles _btnLapPhieuThuePhong.Click
        Try
            If _cbPhong.Text <> "" Then
                'luu xuong database
                _btnThem.Enabled = True
                _btnCapNhat.Enabled = True
                _tbMaPhieuThue.Text = BLL.BLL_PhieuThue.Instance.TangMaPhieuThue()
                _btnLapPhieuThuePhong.Enabled = False


                _cbPhong.Enabled = False
                _dtpNgayBatDauThue.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show("review your data input!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _cbPhong.Enabled = True
        End Try


    End Sub



    Private Sub _btnXoa_Click(sender As Object, e As EventArgs) Handles _btnCapNhat.Click



    End Sub

    Private Sub LapPhieuThuePhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me._cbPhong.Items.Clear()
        Me._cbPhong.Items.Clear()

        For i As Integer = 0 To BLL.BLL_Phong.Instance.DanhSachPhongConTrong().Count - 2

            Me._cbPhong.Items.Add(BLL.BLL_Phong.Instance.DanhSachPhongConTrong(i))
        Next

        For i As Integer = 0 To BLL.BLL_LoaiKhach.Instance.DanhSachCacLoaiKhach().Count - 2

            Me._cbLoaiKhach.Items.Add(BLL.BLL_LoaiKhach.Instance.DanhSachCacLoaiKhach(i))
        Next

        _tbMaKhachHang.Text = BLL.BLL_KhachHang.Instance.TangMaKhachHang()


    End Sub

    Private Sub _cbPhong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _cbPhong.SelectedIndexChanged
        'truyen xuong BLL 1 string (_cbPhong.tostring)  lay len 1 string
        _tbLoaiPhong.Text = BLL.BLL_LoaiPhong.Instance.LayMaLoaiPhong(_cbPhong.Text())
        _tbDonGia.Text = BLL.BLL_LoaiPhong.Instance.LayDonGia(_tbLoaiPhong.Text())

    End Sub

    Private Sub _cbLoaiKhach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _cbLoaiKhach.SelectedIndexChanged
        _tbMaLoaiKhachHang.Text = BLL.BLL_LoaiKhach.Instance.LayMaLoaiKhach(_cbLoaiKhach.Text)
    End Sub

    Private Sub _btnXong_Click(sender As Object, e As EventArgs) Handles _btnXong.Click
        _btnLapPhieuThuePhong.Enabled = True
        _btnThem.Enabled = False
        _btnCapNhat.Enabled = False
        _cbPhong.Enabled = True
        _dtpNgayBatDauThue.Enabled = True
        BLL.BLL_Phong.Instance.ThayDoiTinhTrangPhong(_cbPhong.Text)
        BLL.BLL_PhieuThue.Instance.ThemPhieuThue(_tbMaPhieuThue.Text, _cbPhong.Text, _dtpNgayBatDauThue.Text)
        LapPhieuThuePhong_Load(sender, e)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub

End Class