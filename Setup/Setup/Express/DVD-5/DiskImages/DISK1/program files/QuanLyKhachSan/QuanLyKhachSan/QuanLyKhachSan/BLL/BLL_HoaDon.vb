Imports DAL
Imports System.Windows.Forms


Public Class BLL_HoaDon


    Public Shared m_instance As BLL_HoaDon

    Public Shared ReadOnly Property Instance() As BLL_HoaDon
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_HoaDon()
            End If
            Return m_instance
        End Get
    End Property

    Public Shared Sub LayPhongsTheoMaKhachHang(data As DataGridView, makhachhang As String)
        data.DataSource = DAL.DAL_HoaDon.Instance.LayPhongsTheoMaKhachHang(makhachhang)
    End Sub

    Public Function TangMaHoaDon() As String
        Dim Ma As String = LayMaHoaDonCuoiCung()
        Ma = Ma.Replace("HD", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "HD0" + Ma
        Else
            MaMoi = "HD" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaHoaDonCuoiCung() As String
        Return DAL.DAL_HoaDon.Instance.LayMaHoaDonCuoiCung()
    End Function



    Public Function TinhTriGiaHoaDon(data As DataGridView, makhachhang As String, ngayhoadon As DateTime, tylephuthu As Decimal, hesophuthu As Decimal) As Single
        Return DAL.DAL_HoaDon.Instance.TinhTriGiaHoaDon(makhachhang, ngayhoadon, tylephuthu, hesophuthu)
    End Function

    Public Sub ThemHoaDon(mahoadon As String, makhachhang As String, ngayhoadon As DateTime, trigiahoadon As Single)
        DAL.DAL_HoaDon.Instance.ThemHoaDon(mahoadon, makhachhang, ngayhoadon, trigiahoadon)
    End Sub
End Class
