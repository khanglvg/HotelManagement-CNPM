Imports DAL
Imports System.Windows.Forms

Public Class BLL_LoaiPhong

    Public Shared m_instance As BLL_LoaiPhong

    Public Shared ReadOnly Property Instance() As BLL_LoaiPhong
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_LoaiPhong()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub
    Public Sub TraCuuTheoLoaiPhong(data As DataGridView, loaiphong As String)
        data.DataSource = DAL_LoaiPhong.Instance.TraCuuTheoLoaiPhong(loaiphong)
    End Sub

    Public Sub TraCuuTheoDonGia(data As DataGridView, dongia As Double)
        data.DataSource = DAL_LoaiPhong.Instance.TraCuuTheoDonGia(dongia)
    End Sub

    Public Function LayMaLoaiPhong(maphong) As String
        Return DAL.DAL_LoaiPhong.Instance.LayMaLoaiPhong(maphong)

    End Function

    Public Function LayDonGia(maloaiphong) As String
        Return DAL.DAL_LoaiPhong.Instance.LayDonGia(maloaiphong)

    End Function

    Public Function LayTenLoaiPhongTheoMaLoaiPhong(maloaiphong As String) As String
        Return DAL.DAL_LoaiPhong.Instance.LayTenLoaiPhongTheoMaLoaiPhong(maloaiphong)
    End Function

    Public Function LayTatCaMaLoaiPhong() As String()
        Return DAL.DAL_LoaiPhong.Instance.LayTatCaMaLoaiPhong()

    End Function

    Public Function TraVeTongSoLoaiPhong() As Integer
        Return DAL.DAL_LoaiPhong.Instance.TraVeTongSoLoaiPhong()
    End Function

    Public Sub XemTatCaCacLoaiPhong(data As DataGridView)
        data.DataSource = DAL.DAL_LoaiPhong.Instance.XemTatCaCacLoaiPhong()
    End Sub

    Public Sub XoaLoaiPhong(data As DataGridView)
        DAL.DAL_LoaiPhong.Instance.XoaLoaiPhong(data)
    End Sub

    Public Sub ThemLoaiPhong(maloaiphong As String, tenloaiphong As String, dongia As Double)
        DAL.DAL_LoaiPhong.ThemLoaiPhong(maloaiphong, tenloaiphong, dongia)
    End Sub

    Public Sub SuaLoaiPhong(data As DataGridView)
        DAL.DAL_LoaiPhong.SuaLoaiPhong(data)
    End Sub
End Class
