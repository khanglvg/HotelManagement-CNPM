Imports System.Data.Linq
Imports System.Windows.Forms
Public Class BLL_BaoCaoDoanhThu
    Public Shared m_instance As BLL_BaoCaoDoanhThu

    Public Shared ReadOnly Property Instance() As BLL_BaoCaoDoanhThu
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_BaoCaoDoanhThu()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function TangMaBaoCaoDoanhThu() As String
        Dim Ma As String = LayMaBaoCaoDoanhThuCuoiCung()
        Ma = Ma.Replace("CTBCDT", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "CTBCDT0" + Ma
        Else
            MaMoi = "CTBCDT" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaBaoCaoDoanhThuCuoiCung() As String
        Return DAL.DAL_BaoCaoDoanhThu.Instance.LayMaBaoCaoDoanhThuCuoiCung()
    End Function

    Public Sub LayDoanhThuLoaiPhongTheoThang(data As DataGridView, thang As String)
        data.DataSource = DAL.DAL_BaoCaoDoanhThu.Instance.LayDoanhThuLoaiPhongTheoThang(thang)
    End Sub
End Class
