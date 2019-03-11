Imports System.Data.Linq
Imports System.Windows.Forms
Public Class BLL_BaoCaoThang
    Public Shared m_instance As BLL_BaoCaoThang

    Public Shared ReadOnly Property Instance() As BLL_BaoCaoThang
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_BaoCaoThang()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function TangMaBaoCaoThang() As String
        Dim Ma As String = LayMaBaoCaoThangCuoiCung()
        Ma = Ma.Replace("BC", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "BC0" + Ma
        Else
            MaMoi = "BC" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaBaoCaoThangCuoiCung() As String
        Return DAL.DAL_BaoCaoThang.Instance.LayMaBaoCaoThangCuoiCung()
    End Function
End Class
