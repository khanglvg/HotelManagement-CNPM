Imports DAL
Imports System.Windows.Forms

Public Class BLL_ThamSo
    Public Shared m_instance As BLL_ThamSo

    Public Shared ReadOnly Property Instance() As BLL_ThamSo
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_ThamSo()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub ThayDoiTyLePhuThu(tylephuthu As String)
        DAL.DAL_ThamSo.Instance.ThayDoiTyLePhuThu(tylephuthu)
    End Sub

    Public Function LayTyLePhuThuCu() As Single
        Return DAL.DAL_ThamSo.Instance.LayTyLePhuThuCu()
    End Function

    Public Sub ThayDoiSoKhachToiDaMoiPhong(sokhachtoida As String)
        DAL.DAL_ThamSo.Instance.ThayDoiSoKhachToiDaMoiPhong(sokhachtoida)
    End Sub

    Public Function LaySoKhachToiDaCu() As Integer
        Return DAL.DAL_ThamSo.Instance.LaySoKhachToiDaCu()
    End Function
End Class
