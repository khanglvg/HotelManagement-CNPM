Imports System.Data.Linq
Imports System.Windows.Forms
Imports DTO
Public Class DAL_LoaiKhach


    Public Shared m_instance As DAL_LoaiKhach

    Public Shared ReadOnly Property Instance() As DAL_LoaiKhach
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_LoaiKhach()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub


    Public Function DanhSachCacLoaiKhach() As List(Of DAL.LOAIKHACHHANG)
        Dim _loaiKhachs As New List(Of DAL.LOAIKHACHHANG)()

        Dim db As New QuanLyKhachSanDataContext()

        _loaiKhachs = (From lk In db.LOAIKHACHHANGs
                       Select lk).ToList()

        Return _loaiKhachs
    End Function

    Public Function LayMaLoaiKhach(tenloaikhach As String) As String

        Dim _loaikhach As New LOAIKHACHHANG
        Dim db As New QuanLyKhachSanDataContext()

        _loaikhach = (From lk In db.LOAIKHACHHANGs
                      Where lk.TenLoaiKhachHang.CompareTo(tenloaikhach) = 0
                      Select lk).ToList().SingleOrDefault()

        Dim _maloaikhachhang As String = _loaikhach.MaLoaiKhachHang

        Return _maloaikhachhang
    End Function

    Public Sub XoaLoaiKhach(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _maloaikhach As String = data.SelectedCells(0).OwningRow.Cells("Mã_Loại_Khách").Value.ToString()

        Dim delete As LOAIKHACHHANG = db.LOAIKHACHHANGs.Where(Function(p) p.MaLoaiKhachHang.Equals(_maloaikhach)).SingleOrDefault()

        db.LOAIKHACHHANGs.DeleteOnSubmit(delete)

        Try
            db.SubmitChanges()
            MessageBox.Show("Delete Success!")
        Catch
            MessageBox.Show("Can not delete!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ThemLoaiKhach(maloaikhach As String, tenloaikhach As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim insert As New LOAIKHACHHANG
        insert.MaLoaiKhachHang = maloaikhach
        insert.TenLoaiKhachHang = tenloaikhach


        db.LOAIKHACHHANGs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SuaLoaiPhong(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _maloaikhach As String = data.SelectedCells(0).OwningRow.Cells("Mã_Loại_Khách").Value.ToString()
        Dim _tenloaikhach As String = data.SelectedCells(0).OwningRow.Cells("Tên_Loại_Khách").Value.ToString()

        Dim edit As LOAIKHACHHANG = db.LOAIKHACHHANGs.Where(Function(p) p.MaLoaiKhachHang.Equals(_maloaikhach)).SingleOrDefault()
        edit.MaLoaiKhachHang = _maloaikhach
        edit.TenLoaiKhachHang = _tenloaikhach


        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function XemTatCaCacLoaiKhach()
        Dim db As New QuanLyKhachSanDataContext()

        Dim temp = (From lp In db.LOAIKHACHHANGs
                    Select New With {Key .Mã_Loại_Khách = lp.MaLoaiKhachHang,
                         .Tên_Loại_Khách = lp.TenLoaiKhachHang}).ToList()
        Return temp
    End Function
End Class