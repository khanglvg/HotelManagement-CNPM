﻿Imports System.Data.Linq
Imports System.Windows.Forms
Imports DTO
Public Class DAL_Phong


    Public Shared m_instance As DAL_Phong

    Public Shared ReadOnly Property Instance() As DAL_Phong
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_Phong()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub



    Public Function XemPhongDuocThue()
        Dim db As New QuanLyKhachSanDataContext()

        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where p.TinhTrangPhong.CompareTo("Da Thue ") = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu,
                        .Đơn_Giá = lp.DonGia}).ToList()
        Return temp
    End Function

    Public Function XemPhongConTrong()
        Dim db As New QuanLyKhachSanDataContext()

        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where p.TinhTrangPhong.CompareTo("Trong ") = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu,
                        .Đơn_Giá = lp.DonGia}).ToList()
        Return temp

    End Function

    Public Function TraVeDanhSachPhongConTrong() As List(Of PHONG)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsPhong As New List(Of PHONG)
        _dsPhong = (From p In db.PHONGs
                    Where p.TinhTrangPhong.CompareTo("Trong ") = 0
                    Select p).ToList()
        Return _dsPhong

    End Function

    Public Function TraCuuTheoMaPhong(maphong As String)

        Dim db As New QuanLyKhachSanDataContext()


        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where p.MaPhong.CompareTo(maphong) = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu,
                        .Đơn_Giá = lp.DonGia}).ToList()
        Return temp
    End Function

    Public Function TraCuuTheoTenPhong(tenphong As String)

        Dim db As New QuanLyKhachSanDataContext()
        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Where p.TenPhong.CompareTo(tenphong) = 0
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu,
                        .Đơn_Giá = lp.DonGia}).ToList()
        Return temp

    End Function

    Public Function TraCuuTheoSoKhach(soluongkhach As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsphieuthue As New List(Of PHIEUTHUE)
        _dsphieuthue = (From pt In db.PHIEUTHUEs
                        Select pt).ToList()
        Dim _dsPhongs As New List(Of PHONG)
        Dim Phong As New PHONG
        For Each phieuthue In _dsphieuthue
            Dim _dsctpts = (From ctpt In db.CHITIETPHIEUTHUEs
                            Join pt In db.PHIEUTHUEs On pt.MaPhieuThue Equals ctpt.MaPhieuThue
                            Where pt.MaPhieuThue.CompareTo(phieuthue.MaPhieuThue) = 0
                            Select ctpt).ToList()
            If _dsctpts.Count = soluongkhach Then
                Phong = (From p In db.PHONGs
                         Join pt In db.PHIEUTHUEs On pt.MaPhong Equals p.MaPhong
                         Where pt.MaPhieuThue.CompareTo(phieuthue.MaPhieuThue) = 0
                         Select p).SingleOrDefault()
                _dsPhongs.Add(Phong)

            End If

        Next

        Return _dsPhongs
    End Function

    Public Function XemTatCaCacPhong()


        Dim db As New QuanLyKhachSanDataContext()

        Dim temp = (From p In db.PHONGs
                    Join lp In db.LOAIPHONGs On lp.MaLoaiPhong Equals p.MaLoaiPhong
                    Select New With {Key .Mã_Phòng = p.MaPhong,
                         .Tên_Phòng = p.TenPhong,
                         .Loại_Phòng = lp.TenLoaiPhong,
                         .Tình_Trạng_Phòng = p.TinhTrangPhong,
                         .Ghi_Chú = p.GhiChu,
                        .Đơn_Giá = lp.DonGia}).ToList()
        Return temp


    End Function

    Public Shared Sub ThemPhong(maphong As String, tenphong As String, maloaiphong As String, tinhtrangphong As String, ghichu As String)
        Dim db As New QuanLyKhachSanDataContext()
        'Dim _maphong As String = data.SelectedCells(0).OwningRow.Cells("MaPhong").Value.ToString()
        'Dim _tenphong As String = data.SelectedCells(0).OwningRow.Cells("TenPhong").Value.ToString()
        'Dim _maloaiphong As String = data.SelectedCells(0).OwningRow.Cells("MaLoaiPhong").Value.ToString()
        'Dim _tinhtrangphong As String = data.SelectedCells(0).OwningRow.Cells("TinhTrangPhong").Value.ToString()
        'Dim _ghichu As String = data.SelectedCells(0).OwningRow.Cells("GhiChu").Value.ToString()

        Dim insert As New PHONG
        insert.MaPhong = maphong
        insert.TenPhong = tenphong
        insert.MaLoaiPhong = maloaiphong
        insert.TinhTrangPhong = tinhtrangphong
        insert.GhiChu = ghichu


        db.PHONGs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Public Shared Sub XoaPhong(data As DataGridView)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _maphong As String = data.SelectedCells(0).OwningRow.Cells("Mã_Phòng").Value.ToString()


        Dim delete As PHONG = db.PHONGs.Where(Function(p) p.MaPhong.Equals(_maphong)).SingleOrDefault()

        db.PHONGs.DeleteOnSubmit(delete)

        Try
            db.SubmitChanges()
            MessageBox.Show("Delete Success!")
        Catch
            MessageBox.Show("Can not delete!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ThayDoiTinhTrangPhong(maphong As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim phong As New PHONG()

        phong = (From p In db.PHONGs
                 Where p.MaPhong.CompareTo(maphong) = 0
                 Select p).ToList().SingleOrDefault()
        Try
            If phong.TinhTrangPhong = "Trong" Then
                phong.TinhTrangPhong = "Da Thue"
            Else
                phong.TinhTrangPhong = "Trong"
            End If

            db.SubmitChanges()
        Catch ex As Exception

        End Try


    End Sub

    Public Function LayMaPhongTuMaPhieuThue(maphieuthue As String) As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim phong = (From p In db.PHONGs
                     Join pt In db.PHIEUTHUEs On p.MaPhong Equals pt.MaPhong
                     Where pt.MaPhieuThue.CompareTo(maphieuthue) = 0
                     Select p).ToList.SingleOrDefault()
        Return phong.MaPhong

    End Function

End Class
