Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_HoaDon
    Public Shared m_instance As DAL_HoaDon

    Public Shared ReadOnly Property Instance() As DAL_HoaDon
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_HoaDon()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function LayPhongsTheoMaKhachHang(makhachhang As String) As List(Of PHONG)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _phongs As New List(Of PHONG)
        Dim _phieuthues As New List(Of PHIEUTHUE)
        Dim _phong As New PHONG

        _phieuthues = (From pts In db.PHIEUTHUEs
                       Join ctpt In db.CHITIETPHIEUTHUEs On ctpt.MaPhieuThue Equals pts.MaPhieuThue
                       Where ctpt.MaKhachHang = makhachhang
                       Select pts).ToList()
        For Each phieuthue In _phieuthues
            _phong = (From p In db.PHONGs
                      Where _phong.MaPhong.CompareTo(phieuthue.MaPhong) = 0
                      Select p).ToList().SingleOrDefault()
            _phongs.Add(_phong)
        Next

        Return _phongs

    End Function

    Public Function LayMaHoaDonCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsHoaDons As New List(Of HOADON)()

        _dsHoaDons = (From dshd In db.HOADONs
                      Select dshd).ToList()

        Dim _mahoadoncuoicung As String = "HD00"
        For Each hd In _dsHoaDons
            _mahoadoncuoicung = hd.MaHoaDon

        Next
        Return _mahoadoncuoicung
    End Function

    Public Function TinhTriGiaHoaDon(makhachhang As String, ngayhoadon As DateTime, tylephuthu As Decimal, hesophuthu As Decimal) As Single

        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsPhongs = (From dsp In db.PHONGs
                         Join pt In db.PHIEUTHUEs On dsp.MaPhong Equals pt.MaPhong
                         Join ctpt In db.CHITIETPHIEUTHUEs On pt.MaPhieuThue Equals ctpt.MaPhieuThue
                         Join kh In db.KHACHHANGs On kh.MaKhachHang Equals ctpt.MaKhachHang
                         Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals dsp.MaLoaiPhong
                         Where ctpt.MaKhachHang.CompareTo(makhachhang) = 0 And pt.ThanhToan.CompareTo("Chua") = 0
                         Select New With {
                             .Mã_Phiếu_Thuê = pt.MaPhieuThue,
                             .Phòng = dsp.TenPhong,
                             .Số_Khách_Nước_Ngoài = (From dsknn In db.KHACHHANGs
                                                     Join lk In db.LOAIKHACHHANGs On dsknn.MaLoaiKhachHang Equals lk.MaLoaiKhachHang
                                                     Join ctpt1 In db.CHITIETPHIEUTHUEs On ctpt1.MaKhachHang Equals dsknn.MaKhachHang
                                                     Join pt1 In db.PHIEUTHUEs On pt1.MaPhieuThue Equals ctpt1.MaPhieuThue
                                                     Where lk.MaLoaiKhachHang.CompareTo("LK02") = 0 And pt1.MaPhieuThue.CompareTo(pt.MaPhieuThue) = 0
                                                     Select dsknn).ToList().Count,
                             .Số_Khách_Trong_Phòng = (From pt1 In db.PHIEUTHUEs
                                                      Join ctpt1 In db.CHITIETPHIEUTHUEs On pt1.MaPhieuThue Equals ctpt1.MaPhieuThue
                                                      Join kh1 In db.KHACHHANGs On kh1.MaKhachHang Equals ctpt1.MaKhachHang
                                                      Where pt1.MaPhieuThue.CompareTo(pt.MaPhieuThue) = 0
                                                      Select pt1).ToList().Count,
                             .Số_Ngày_Thuê = (ngayhoadon.Subtract(pt.NgayBatDauThue)).TotalDays,
                             .Đơn_Giá = lp.DonGia,
                             .Thành_Tiền = lp.DonGia * CDec(tylephuthu) * CDec(hesophuthu) * CDec((ngayhoadon.Subtract(pt.NgayBatDauThue)).TotalDays)}).ToList()

        Dim _triGiaHoaDon As Single = 0
        For Each phong In _dsPhongs
            _triGiaHoaDon += phong.Thành_Tiền
        Next
        Return _triGiaHoaDon
    End Function

    Public Sub ThemHoaDon(mahoadon As String, makhachhang As String, ngayhoadon As DateTime, trigiahoadon As Single)
        Dim db As New QuanLyKhachSanDataContext()

        Dim insert As New HOADON
        insert.MaHoaDon = mahoadon
        insert.MaKhachHang = makhachhang
        insert.NgayLapHoaDon = ngayhoadon
        insert.TriGiaHoaDon = trigiahoadon
        db.HOADONs.InsertOnSubmit(insert)
        Try
            db.SubmitChanges()
            MessageBox.Show("Insert HoaDon Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class