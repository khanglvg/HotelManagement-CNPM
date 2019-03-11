Imports System.Data.Linq
Imports System.Windows.Forms
Imports DTO
Public Class DAL_KhachHang


    Public Shared m_instance As DAL_KhachHang

    Public Shared ReadOnly Property Instance() As DAL_KhachHang
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_KhachHang()
            End If
            Return m_instance
        End Get
    End Property

    Public Function XemTatCaKhachHang() As List(Of DAL.KHACHHANG)
        Dim _khachhangs As New List(Of DAL.KHACHHANG)()

        Dim db As New QuanLyKhachSanDataContext()
        _khachhangs = (From kh In db.KHACHHANGs
                       Select kh).ToList()

        Return _khachhangs
    End Function

    Public Shared Sub ThemKhachHang(makhachhang As String, tenkhachhang As String, maloaikhachhang As String, CMND As Integer, diachi As String)
        Dim db As New QuanLyKhachSanDataContext()

        Dim insert As New KHACHHANG
        insert.MaKhachHang = makhachhang
        insert.TenKhachHang = tenkhachhang
        insert.MaLoaiKhachHang = maloaikhachhang
        insert.CMND = CMND
        insert.DiaChi = diachi


        db.KHACHHANGs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Sub XoaKhachHang(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _makhachhang As String = data.SelectedCells(0).OwningRow.Cells("MaKhachHang").Value.ToString()


        Dim delete As KHACHHANG = db.KHACHHANGs.Where(Function(p) p.MaKhachHang.Equals(_makhachhang)).SingleOrDefault()

        db.KHACHHANGs.DeleteOnSubmit(delete)

        Try
            db.SubmitChanges()
            MessageBox.Show("Delete Success!")
        Catch
            MessageBox.Show("Can not delete!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function LayMaKhachHangCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsKhachHangs As New List(Of KHACHHANG)()

        _dsKhachHangs = (From dskh In db.KHACHHANGs
                         Select dskh).ToList()
        Dim _makhachhangcuoicung As String = "KH00"
        For Each kh In _dsKhachHangs
            _makhachhangcuoicung = kh.MaKhachHang
        Next
        Return _makhachhangcuoicung
    End Function

    Public Function TraVeSoKhachTrongPhong(maphieuthue As String) As Integer
        Dim db As New QuanLyKhachSanDataContext()
        Dim _soLuongKhach As Integer = 0
        Dim _dsKhachTrongPhong As New List(Of KHACHHANG)

        _dsKhachTrongPhong = (From dsktp In db.KHACHHANGs
                              Join ctpt In db.CHITIETPHIEUTHUEs On dsktp.MaKhachHang Equals ctpt.MaKhachHang
                              Where ctpt.MaPhieuThue.CompareTo(maphieuthue) = 0
                              Select dsktp).ToList()

        _soLuongKhach = _dsKhachTrongPhong.Count
        Return _soLuongKhach
    End Function

    Public Function TimKhachHangTheoTen(tenkhachhang As String)
        Dim db As New QuanLyKhachSanDataContext()


        Dim _khachhangs = (From kh In db.KHACHHANGs
                           Join lkh In db.LOAIKHACHHANGs On lkh.MaLoaiKhachHang Equals kh.MaLoaiKhachHang
                           Where kh.TenKhachHang.Contains(tenkhachhang)
                           Select New With {
                         .Mã_Khách_Hàng = kh.MaKhachHang,
                         .Tên_Khách_Hàng = kh.TenKhachHang,
                         .Loại_Khách = lkh.TenLoaiKhachHang,
                         .CMND = kh.CMND,
                        .Địa_Chỉ = kh.DiaChi}).ToList()
        Return _khachhangs
    End Function

    Public Function LayThongTinKhachHangTuMaKhachHang(makhachhang) As String()
        Dim _khachhang As New KHACHHANG
        Dim db As New QuanLyKhachSanDataContext()

        _khachhang = (From kh In db.KHACHHANGs
                      Where kh.MaKhachHang.CompareTo(makhachhang) = 0
                      Select kh).ToList().SingleOrDefault()

        Dim _info As String() = New String(1) {}
        _info(0) = _khachhang.TenKhachHang
        _info(1) = _khachhang.DiaChi



        Return _info
    End Function

    Public Function LayThongTinKhachHangVuaThemVaoPhieuThue(maphieuthue As String) As List(Of KHACHHANG)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dskhachhang As New List(Of KHACHHANG)

        _dskhachhang = (From kh In db.KHACHHANGs
                        Join ctpt In db.CHITIETPHIEUTHUEs On ctpt.MaKhachHang Equals kh.MaKhachHang
                        Where ctpt.MaPhieuThue.CompareTo(maphieuthue) = 0
                        Select kh).ToList()
        Return _dskhachhang
    End Function

    Public Function DemSoKhachTrongPhong(maphieuthue As String) As Integer
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsKhach As List(Of KHACHHANG)

        _dsKhach = (From kh In db.KHACHHANGs
                    Join ctpt In db.CHITIETPHIEUTHUEs On ctpt.MaKhachHang Equals kh.MaKhachHang
                    Join pt In db.PHIEUTHUEs On pt.MaPhieuThue Equals ctpt.MaPhieuThue
                    Join p In db.PHONGs On p.MaPhong Equals pt.MaPhong
                    Where pt.MaPhieuThue.CompareTo(maphieuthue) = 0
                    Select kh).ToList()

        Return _dsKhach.Count

    End Function

End Class