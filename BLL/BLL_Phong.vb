
Imports DAL
Imports System.Windows.Forms


Public Class BLL_Phong


    Public Shared m_instance As BLL_Phong

    Public Shared ReadOnly Property Instance() As BLL_Phong
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_Phong()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub TraCuuTheoMaPhong(data As DataGridView, maphong As String)
        data.DataSource = DAL_Phong.Instance.TraCuuTheoMaPhong(maphong)
    End Sub

    Public Sub TraCuuTheoTenPhong(data As DataGridView, tenphong As String)
        data.DataSource = DAL_Phong.Instance.TraCuuTheoTenPhong(tenphong)
    End Sub

    Public Sub TraCuuTheoSoKhach(data As DataGridView, sokhach As Integer)
        data.DataSource = DAL_Phong.Instance.TraCuuTheoSoKhach(sokhach)
    End Sub


    Public Sub XemPhongDuocThue(data As DataGridView)
        data.DataSource = DAL_Phong.Instance.XemPhongDuocThue()
    End Sub

    Public Sub XemPhongConTrong(data As DataGridView)
        data.DataSource = DAL_Phong.Instance.XemPhongConTrong()
    End Sub


    Public Function DanhSachPhongConTrong() As String()
        Dim _dsphong As List(Of PHONG)
        _dsphong = DAL.DAL_Phong.Instance.TraVeDanhSachPhongConTrong()

        Dim _strDSPhong As String() = New String(_dsphong.Count) {}

        For i As Integer = 0 To _dsphong.Count - 1
            _strDSPhong(i) = _dsphong(i).MaPhong
        Next

        Return _strDSPhong
    End Function

    Public Sub XemTatCaCacPhong(data As DataGridView)
        data.DataSource = DAL_Phong.Instance.XemTatCaCacPhong()
    End Sub

    Public Sub ThemPhong(maphong As String, tenphong As String, maloaiphong As String, tinhtrangphong As String, ghichu As String)
        DAL.DAL_Phong.ThemPhong(maphong, tenphong, maloaiphong, tinhtrangphong, ghichu)
    End Sub

    Public Sub XoaPhong(data As DataGridView)
        DAL.DAL_Phong.XoaPhong(data)
    End Sub

    Public Sub LayDSPhongTuMaKhachHang(data As DataGridView, makhachhang As String, ngayhoadon As DateTime, maphieuthue As String)
        If (DAL.DAL_KhachHang.Instance.DemSoKhachTrongPhong(maphieuthue) >= DAL.DAL_ThamSo.Instance.LaySoKhachToiDaCu()) Then
            If (DAL.DAL_PhieuThue.Instance.TraVeSoKhachNuocNgoai(maphieuthue) <> 0) Then
                data.DataSource = DAL.DAL_PhieuThue.Instance.LayDSPhongTuMaKhachHang(makhachhang, ngayhoadon, CDbl(DAL.DAL_ThamSo.Instance.LayTyLePhuThuCu + 1), CDbl(DAL.DAL_ThamSo.Instance.LayHeSo))
            Else
                data.DataSource = DAL.DAL_PhieuThue.Instance.LayDSPhongTuMaKhachHang(makhachhang, ngayhoadon, CDbl(DAL.DAL_ThamSo.Instance.LayTyLePhuThuCu + 1), 1)
            End If

        Else
            If (DAL.DAL_PhieuThue.Instance.TraVeSoKhachNuocNgoai(maphieuthue) <> 0) Then
                data.DataSource = DAL.DAL_PhieuThue.Instance.LayDSPhongTuMaKhachHang(makhachhang, ngayhoadon, 1, CDbl(DAL.DAL_ThamSo.Instance.LayHeSo))
            Else
                data.DataSource = DAL.DAL_PhieuThue.Instance.LayDSPhongTuMaKhachHang(makhachhang, ngayhoadon, 1, 1)
            End If
        End If


    End Sub

    Public Function GetSumPhongsOfKhachHang(makhachhang As String, ngayhoadon As DateTime, tylephuthu As Decimal, hesophuthu As Decimal) As Integer
        Return DAL_PhieuThue.Instance.GetSumPhongsOfKhachHang(makhachhang, ngayhoadon, 1, 1)
    End Function


    Public Sub ThayDoiTinhTrangPhong(maphong As String)
        DAL.DAL_Phong.Instance.ThayDoiTinhTrangPhong(maphong)
    End Sub

    Public Function LayMaPhongTuMaPhieuThue(maphieuthue As String) As String
        Return DAL.DAL_Phong.Instance.LayMaPhongTuMaPhieuThue(maphieuthue)
    End Function
End Class
