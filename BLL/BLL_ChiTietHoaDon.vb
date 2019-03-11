Imports DAL
Imports System.Windows.Forms


Public Class BLL_ChiTietHoaDon


    Public Shared m_instance As BLL_ChiTietHoaDon

    Public Shared ReadOnly Property Instance() As BLL_ChiTietHoaDon
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_ChiTietHoaDon()
            End If
            Return m_instance
        End Get
    End Property

    Public Function TangMaChiTietHoaDon() As String
        Dim Ma As String = LayMaChiTietHoaDonCuoiCung()
        Ma = Ma.Replace("CTHD", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "CTHD0" + Ma
        Else
            MaMoi = "CTHD" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaChiTietHoaDonCuoiCung() As String
        Return DAL.DAL_ChiTietHoaDon.Instance.LayMaChiTietHoaDonCuoiCung()
    End Function

End Class
