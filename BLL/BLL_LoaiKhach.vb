
Imports DAL
Imports System.Windows.Forms


Public Class BLL_LoaiKhach


    Public Shared m_instance As BLL_LoaiKhach

    Public Shared ReadOnly Property Instance() As BLL_LoaiKhach
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_LoaiKhach()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function DanhSachCacLoaiKhach() As String()
        Dim _dsloaikhach As List(Of LOAIKHACHHANG)
        _dsloaikhach = DAL.DAL_LoaiKhach.Instance.DanhSachCacLoaiKhach()


        Dim _strDSLoaiKhach As String() = New String(_dsloaikhach.Count) {}




        For i As Integer = 0 To _dsloaikhach.Count - 1
            _strDSLoaiKhach(i) = _dsloaikhach(i).TenLoaiKhachHang
        Next

        Return _strDSLoaiKhach
    End Function

    Public Function LayMaLoaiKhach(tenloaikhach As String) As String
        Return DAL.DAL_LoaiKhach.Instance.LayMaLoaiKhach(tenloaikhach)
    End Function


    Public Sub XoaLoaiKhach(data As DataGridView)
        DAL.DAL_LoaiKhach.Instance.XoaLoaiKhach(data)
    End Sub

    Public Sub ThemLoaiKhach(maloaikhach As String, tenloaikhach As String)
        DAL.DAL_LoaiKhach.Instance.ThemLoaiKhach(maloaikhach, tenloaikhach)
    End Sub

    Public Sub SuaLoaiKhach(data As DataGridView)
        DAL.DAL_LoaiKhach.Instance.SuaLoaiPhong(data)
    End Sub

    Public Sub XemTatCaCacLoaiKhach(data As DataGridView)
        data.DataSource = DAL.DAL_LoaiKhach.Instance.XemTatCaCacLoaiKhach()
    End Sub
End Class
