Imports DAL
Imports System.Windows.Forms


Public Class BLL_ChiTietPhieuThue


    Public Shared m_instance As BLL_ChiTietPhieuThue

    Public Shared ReadOnly Property Instance() As BLL_ChiTietPhieuThue
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_ChiTietPhieuThue()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub ThemChiTietPhieuThue(maphieuthue As String, makhachhang As String)
        DAL.DAL_ChiTietPhieuThue.ThemChiTietPhieuThue(TangMaChiTietPhieuThue(), maphieuthue, makhachhang)
    End Sub

    Public Function TangMaChiTietPhieuThue() As String
        Dim Ma As String = LayMaChiTietPhieuThueCuoiCung()
        Ma = Ma.Replace("CTPT", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "CTPT0" + Ma
        Else
            MaMoi = "CTPT" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaChiTietPhieuThueCuoiCung() As String
        Return DAL.DAL_ChiTietPhieuThue.Instance.LayMaChiTietPhieuThueCuoiCung()
    End Function
End Class
