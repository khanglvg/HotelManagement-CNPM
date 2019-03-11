Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_LoaiPhong

    Public Shared m_instance As DAL_LoaiPhong

    Public Shared ReadOnly Property Instance() As DAL_LoaiPhong
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_LoaiPhong()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function TraCuuTheoLoaiPhong(loaiphong As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where lp.MaLoaiPhong.CompareTo(loaiphong) = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu}).ToList()
        Return temp
    End Function

    Public Function TraCuuTheoDonGia(dongia As Double)

        Dim db As New QuanLyKhachSanDataContext()
        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where lp.DonGia.CompareTo(dongia) = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu}).ToList()
        Return temp
    End Function


    Public Function LayMaLoaiPhong(maphong As String) As String

        Dim phong As New PHONG
        Dim db As New QuanLyKhachSanDataContext()

        phong = (From p In db.PHONGs
                 Join lp In db.LOAIPHONGs On p.MaLoaiPhong Equals lp.MaLoaiPhong
                 Where p.MaPhong.CompareTo(maphong) = 0
                 Select p).ToList().SingleOrDefault()

        Dim _maloaiphong As String = phong.MaLoaiPhong

        Return _maloaiphong
    End Function

    Public Function LayDonGia(maloaiphong As String) As String

        Dim loaiphong As New LOAIPHONG
        Dim db As New QuanLyKhachSanDataContext()

        loaiphong = (From lp In db.LOAIPHONGs
                     Where lp.MaLoaiPhong.CompareTo(maloaiphong) = 0
                     Select lp).ToList().SingleOrDefault()

        Dim _DonGia As String = loaiphong.DonGia

        Return _DonGia
    End Function

    Public Function LayTenLoaiPhongTheoMaLoaiPhong(maloaiphong As String) As String
        Dim _loaiPhong As New LOAIPHONG
        Dim db As New QuanLyKhachSanDataContext()

        _loaiPhong = (From lp In db.LOAIPHONGs
                      Where lp.MaLoaiPhong.CompareTo(maloaiphong) = 0
                      Select lp).ToList().SingleOrDefault()

        Return _loaiPhong.TenLoaiPhong

    End Function

    Public Function LayTatCaMaLoaiPhong() As String()
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsLoaiPhong As New List(Of LOAIPHONG)


        _dsLoaiPhong = (From dslp In db.LOAIPHONGs
                        Select dslp).ToList()

        Dim _dsMaLoaiPhong As String() = New String(_dsLoaiPhong.Count) {}

        For i As Integer = 0 To _dsLoaiPhong.Count - 1
            _dsMaLoaiPhong(i) = _dsLoaiPhong(i).MaLoaiPhong
        Next

        Return _dsMaLoaiPhong

    End Function

    Public Function TraVeTongSoLoaiPhong() As Integer
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsLoaiPhong As New List(Of LOAIPHONG)


        _dsLoaiPhong = (From dslp In db.LOAIPHONGs
                        Select dslp).ToList()


        Return _dsLoaiPhong.Count
    End Function

    Public Function XemTatCaCacLoaiPhong()


        Dim db As New QuanLyKhachSanDataContext()

        Dim temp = (From lp In db.LOAIPHONGs
                    Select New With {Key .Mã_Loại_Phòng = lp.MaLoaiPhong,
                         .Tên_Loại_Phòng = lp.TenLoaiPhong,
                         .Đơn_Giá = lp.DonGia}).ToList()
        Return temp


    End Function

    Public Sub XoaLoaiPhong(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _maloaiphong As String = data.SelectedCells(0).OwningRow.Cells("Mã_Loại_Phòng").Value.ToString()

        Dim delete As LOAIPHONG = db.LOAIPHONGs.Where(Function(p) p.MaLoaiPhong.Equals(_maloaiphong)).SingleOrDefault()

        db.LOAIPHONGs.DeleteOnSubmit(delete)

        Try
            db.SubmitChanges()
            MessageBox.Show("Delete Success!")
        Catch
            MessageBox.Show("Can not delete!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Sub ThemLoaiPhong(maloaiphong As String, tenloaiphong As String, dongia As Double)
        Dim db As New QuanLyKhachSanDataContext()
        Dim insert As New LOAIPHONG
        insert.MaLoaiPhong = maloaiphong
        insert.TenLoaiPhong = tenloaiphong
        insert.DonGia = dongia

        db.LOAIPHONGs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub SuaLoaiPhong(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _maloaiphong As String = data.SelectedCells(0).OwningRow.Cells("Mã_Loại_Phòng").Value.ToString()
        Dim _tenloaiphong As String = data.SelectedCells(0).OwningRow.Cells("Tên_Loại_Phòng").Value.ToString()
        Dim _dongia As String = data.SelectedCells(0).OwningRow.Cells("Đơn_Giá").Value.ToString()

        Dim edit As LOAIPHONG = db.LOAIPHONGs.Where(Function(p) p.MaLoaiPhong.Equals(_maloaiphong)).SingleOrDefault()
        edit.MaLoaiPhong = _maloaiphong
        edit.TenLoaiPhong = _tenloaiphong
        edit.DonGia = _dongia

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
