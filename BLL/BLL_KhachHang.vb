
Imports DAL
Imports System.Windows.Forms


Public Class BLL_KhachHang


    Public Shared m_instance As BLL_KhachHang

    Public Shared ReadOnly Property Instance() As BLL_KhachHang
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_KhachHang()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub


    Public Sub ThemKhachHang(makhachhang As String, tenkhachhang As String, maloaikhachhang As String, cmnd As Integer, diachi As String)

        DAL.DAL_KhachHang.ThemKhachHang(makhachhang, tenkhachhang, maloaikhachhang, cmnd, diachi)
    End Sub

    Public Sub XemTatCaCacKhachHang(data As DataGridView)
        data.DataSource = DAL.DAL_KhachHang.Instance.XemTatCaKhachHang()
    End Sub

    Public Function TangMaKhachHang() As String
        Dim Ma As String = LayMaKhachHangCuoiCung()
        Ma = Ma.replace("KH", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "KH0" + Ma
        Else
            MaMoi = "KH" + Ma
        End If

        Return MaMoi
    End Function
    Public Function LayMaKhachHangCuoiCung() As String
        Return DAL.DAL_KhachHang.Instance.LayMaKhachHangCuoiCung()
    End Function

    Public Function DanhSachMaKhachHang() As String()
        Dim _dskhachhang As List(Of KHACHHANG)
        _dskhachhang = DAL.DAL_KhachHang.Instance.XemTatCaKhachHang()

        Dim _strDSMaKhachHang As String() = New String(_dskhachhang.Count) {}

        For i As Integer = 0 To _dskhachhang.Count - 1
            _strDSMaKhachHang(i) = _dskhachhang(i).MaKhachHang
        Next

        Return _strDSMaKhachHang
    End Function

    Public Function TimKhachHangTheoTen(data As DataGridView, tenkhachhang As String)
        data.DataSource = DAL.DAL_KhachHang.Instance.TimKhachHangTheoTen(tenkhachhang)
    End Function

    Public Function LayThongTinKhachHangTuMaKhachHang(makhachhang) As String()
        Return DAL.DAL_KhachHang.Instance.LayThongTinKhachHangTuMaKhachHang(makhachhang)
    End Function

    Public Sub LayThongTinKhachHangVuaThemVaoPhieuThue(data As DataGridView, maphieuthue As String)
        data.DataSource = DAL.DAL_KhachHang.Instance.LayThongTinKhachHangVuaThemVaoPhieuThue(maphieuthue)
    End Sub
End Class
