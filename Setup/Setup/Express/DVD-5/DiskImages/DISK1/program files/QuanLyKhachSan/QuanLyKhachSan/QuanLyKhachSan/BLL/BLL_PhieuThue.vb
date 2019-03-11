Imports DAL
Imports System.Windows.Forms


Public Class BLL_PhieuThue


    Public Shared m_instance As BLL_PhieuThue

    Public Shared ReadOnly Property Instance() As BLL_PhieuThue
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_PhieuThue()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub ThemPhieuThue(maphieuthue As String, maphong As String, ngaybatdauthue As DateTime)
        DAL.DAL_PhieuThue.ThemPhieuThue(maphieuthue, maphong, ngaybatdauthue)
    End Sub

    Public Function TangMaPhieuThue() As String
        Dim Ma As String = LayMaPhieuThueCuoiCung()
        Ma = Ma.Replace("PT", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "PT0" + Ma
        Else
            MaMoi = "PT" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaPhieuThueCuoiCung() As String
        Return DAL.DAL_PhieuThue.Instance.LayMaPhieuThueCuoiCung()
    End Function

    Public Function KiemTraSoLuongKhachTrongPhong(maphieuthue As String) As Boolean
        If (DAL.DAL_KhachHang.Instance.TraVeSoKhachTrongPhong(maphieuthue) >= 3) Then
            Return True
        End If
        Return False
    End Function

    Public Function KiemTraSoLuongKhachTrongPhong1(maphieuthue As String) As Integer
        Return DAL.DAL_KhachHang.Instance.TraVeSoKhachTrongPhong(maphieuthue)

    End Function


End Class
