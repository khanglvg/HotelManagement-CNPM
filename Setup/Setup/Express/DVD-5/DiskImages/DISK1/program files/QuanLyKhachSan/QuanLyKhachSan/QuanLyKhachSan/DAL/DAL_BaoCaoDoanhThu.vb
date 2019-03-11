Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_BaoCaoDoanhThu
    Public Shared m_instance As DAL_BaoCaoDoanhThu

    Public Shared ReadOnly Property Instance() As DAL_BaoCaoDoanhThu
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_BaoCaoDoanhThu()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function LayMaBaoCaoDoanhThuCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsBaoCaos As New List(Of CHITIETBAOCAODOANHTHU)()

        _dsBaoCaos = (From dsbc In db.CHITIETBAOCAODOANHTHUs
                      Select dsbc).ToList()

        Dim _maBaoCaoCuoiCung As String = "CTBCDT00"
        For Each bc In _dsBaoCaos
            _maBaoCaoCuoiCung = bc.MaBaoCao
        Next
        Return _maBaoCaoCuoiCung
    End Function


    Public Function LayDoanhThuLoaiPhongTheoThang(thang As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsLoaiPhong

        _dsLoaiPhong = (From dslp In db.LOAIPHONGs
                        Join p In db.PHONGs On p.MaLoaiPhong Equals dslp.MaLoaiPhong
                        Join pt In db.PHIEUTHUEs On pt.MaPhong Equals p.MaPhong
                        Join cthd In db.CHITIETHOADONs On cthd.MaPhieuThue Equals pt.MaPhieuThue
                        Where pt.NgayBatDauThue.Month.CompareTo(thang) = 0
                        Select New With {
                            .Loai_Phong = dslp.MaLoaiPhong,
                            .Doanh_Thu = cthd.ThanhTienTheoTungPhong,
                            .Ty_le = 0}).ToList()
        ' ??????? '
        Return _dsLoaiPhong
    End Function
End Class
