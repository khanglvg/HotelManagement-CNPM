Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_BaoCaoMatDo
    Public Shared m_instance As DAL_BaoCaoMatDo

    Public Shared ReadOnly Property Instance() As DAL_BaoCaoMatDo
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_BaoCaoMatDo()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function LayMaBaoCaoMatDoCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsBaoCaos As New List(Of CHITIETBAOCAOMATDO)()

        _dsBaoCaos = (From dsbc In db.CHITIETBAOCAOMATDOs
                      Select dsbc).ToList()

        Dim _maBaoCaoCuoiCung As String = "CTBCMD00"
        For Each bc In _dsBaoCaos
            _maBaoCaoCuoiCung = bc.MaBaoCao
        Next
        Return _maBaoCaoCuoiCung
    End Function


    Public Function LayMatDoSuDungPhongTheoThang(thang As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsPhong

        _dsPhong = (From dslp In db.LOAIPHONGs
                    Join p In db.PHONGs On p.MaLoaiPhong Equals dslp.MaLoaiPhong
                    Join pt In db.PHIEUTHUEs On pt.MaPhong Equals p.MaPhong
                    Join cthd In db.CHITIETHOADONs On cthd.MaPhieuThue Equals pt.MaPhieuThue
                    Where pt.NgayBatDauThue.Month.CompareTo(thang) = 0
                    Select New With {
                            .Ten_Phong = p.TenPhong,
                            .So_Ngay_Thue = cthd.SoNgayThue,
                            .Ty_le = 0}).ToList()

        Return _dsPhong
    End Function
End Class

