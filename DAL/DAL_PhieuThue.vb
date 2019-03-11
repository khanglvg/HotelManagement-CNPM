Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_PhieuThue

    Public Shared m_instance As DAL_PhieuThue

    Public Shared ReadOnly Property Instance() As DAL_PhieuThue
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_PhieuThue()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Shared Sub ThemPhieuThue(maphieuthue As String, maphong As String, ngaybatdauthue As DateTime)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _phieuthue As New PHIEUTHUE

        _phieuthue.MaPhieuThue = maphieuthue
        _phieuthue.MaPhong = maphong
        _phieuthue.NgayBatDauThue = ngaybatdauthue
        _phieuthue.ThanhToan = "Chua"

        db.PHIEUTHUEs.InsertOnSubmit(_phieuthue)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Public Function LayMaPhieuThueCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsPhieuThues As New List(Of PHIEUTHUE)()

        _dsPhieuThues = (From dspt In db.PHIEUTHUEs
                         Select dspt).ToList()

        Dim _maphieuthuecuoicung As String = "PT00"
        For Each pt In _dsPhieuThues
            _maphieuthuecuoicung = pt.MaPhieuThue

        Next
        Return _maphieuthuecuoicung
    End Function

    Public Function LayDSPhongTuMaKhachHang(makhachhang As String, ngayhoadon As DateTime, tylephuthu As Decimal, hesophuthu As Decimal)

        Dim db As New QuanLyKhachSanDataContext()
        'Dim diff As System.TimeSpan
        'Dim date1 As New System.DateTime(1996, 6, 6)
        'diff = ngayhoadon.Subtract(date1)
        'Dim songaythue As Double
        'songaythue = diff.TotalDays



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



        Return _dsPhongs
    End Function

    Public Function TraVeSoKhachNuocNgoai(maphieuthue As String) As Integer
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsKhachNuocNgoai As New List(Of KHACHHANG)

        _dsKhachNuocNgoai = (From dsknn In db.KHACHHANGs
                             Join lk In db.LOAIKHACHHANGs On dsknn.MaLoaiKhachHang Equals lk.MaLoaiKhachHang
                             Join ctpt In db.CHITIETPHIEUTHUEs On ctpt.MaKhachHang Equals dsknn.MaKhachHang
                             Join pt In db.PHIEUTHUEs On pt.MaPhieuThue Equals ctpt.MaPhieuThue
                             Where lk.MaLoaiKhachHang.CompareTo("LK02") = 0 And pt.MaPhieuThue.CompareTo(maphieuthue) = 0
                             Select dsknn).ToList()
        Return _dsKhachNuocNgoai.Count
    End Function


    Public Function GetSumPhongsOfKhachHang(makhachhang As String, ngayhoadon As DateTime, tylephuthu As Decimal, hesophuthu As Decimal) As Integer
        Return LayDSPhongTuMaKhachHang(makhachhang, ngayhoadon, tylephuthu, hesophuthu).count
    End Function

End Class
