Imports System.Data.Linq
Imports System.Windows.Forms

Public Class DAL_ThamSo
    Public Shared m_instance As DAL_ThamSo

    Public Shared ReadOnly Property Instance() As DAL_ThamSo
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_ThamSo()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub ThayDoiTyLePhuThu(tylephuthu As String)
        Dim db As New QuanLyKhachSanDataContext()

        Dim ThamSo As New THAMSO()

        ThamSo = (From ts In db.THAMSOs
                  Select ts).ToList().SingleOrDefault()
        Try
            ThamSo.TyLePhuThu = CInt(tylephuthu)
            db.SubmitChanges()
            MessageBox.Show("Change Success!")
        Catch ex As Exception
            MessageBox.Show("Can not change!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function LayTyLePhuThuCu() As Single
        Dim db As New QuanLyKhachSanDataContext()
        Dim _ThamSo

        _ThamSo = (From th In db.THAMSOs
                   Select New With {
                       .SoLuongKhachToiDa = th.SoLuongKhachHangToiDa,
                       .SoLuongKhachMoiPhong = DirectCast(th.SoLuongKhachMoiPhong, System.Nullable(Of Integer)),
                       .SoLuongKhachNuocNgoai = DirectCast(th.SoLuongKhachNuocNgoai, System.Nullable(Of Integer)),
                       .HeSo = th.HeSo,
                       .TyLePhuThu = th.TyLePhuThu}).ToList().SingleOrDefault()

        Return _ThamSo.TyLePhuThu
    End Function

    Public Function LayHeSo() As Single
        Dim db As New QuanLyKhachSanDataContext()
        Dim _ThamSo

        _ThamSo = (From th In db.THAMSOs
                   Select New With {
                       .SoLuongKhachToiDa = th.SoLuongKhachHangToiDa,
                       .SoLuongKhachMoiPhong = DirectCast(th.SoLuongKhachMoiPhong, System.Nullable(Of Integer)),
                       .SoLuongKhachNuocNgoai = DirectCast(th.SoLuongKhachNuocNgoai, System.Nullable(Of Integer)),
                       .HeSo = th.HeSo,
                       .TyLePhuThu = th.TyLePhuThu}).ToList().SingleOrDefault()

        Return _ThamSo.HeSo
    End Function

    Public Sub ThayDoiSoKhachToiDaMoiPhong(sokhachtoida As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim ThamSo As New THAMSO()

        ThamSo = (From ts In db.THAMSOs
                  Select ts).ToList().SingleOrDefault()
        Try
            ThamSo.SoLuongKhachHangToiDa = CInt(sokhachtoida)
            db.SubmitChanges()
            MessageBox.Show("Change Success!")
        Catch ex As Exception
            MessageBox.Show("Can not change!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function LaySoKhachToiDaCu() As Integer
        Dim db As New QuanLyKhachSanDataContext()
        Dim _ThamSo

        _ThamSo = (From th In db.THAMSOs
                   Select New With {
                       .SoLuongKhachToiDa = th.SoLuongKhachHangToiDa,
                       .SoLuongKhachMoiPhong = DirectCast(th.SoLuongKhachMoiPhong, System.Nullable(Of Integer)),
                       .SoLuongKhachNuocNgoai = DirectCast(th.SoLuongKhachNuocNgoai, System.Nullable(Of Integer)),
                       .HeSo = th.HeSo,
                       .TyLePhuThu = th.TyLePhuThu}).ToList().SingleOrDefault()

        Return _ThamSo.SoLuongKhachToiDa
    End Function

End Class