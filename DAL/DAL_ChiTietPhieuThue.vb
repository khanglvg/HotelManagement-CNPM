Imports System.Data.Linq
Imports System.Windows.Forms

Public Class DAL_ChiTietPhieuThue
    Public Shared m_instance As DAL_ChiTietPhieuThue

    Public Shared ReadOnly Property Instance() As DAL_ChiTietPhieuThue
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_ChiTietPhieuThue()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Shared Sub ThemChiTietPhieuThue(machitietphieuthue As String, maphieuthue As String, makhachhang As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim _chitietphieuthue As New CHITIETPHIEUTHUE

        _chitietphieuthue.MaChiTietPhieuThue = machitietphieuthue
        _chitietphieuthue.MaPhieuThue = maphieuthue
        _chitietphieuthue.MaKhachHang = makhachhang


        db.CHITIETPHIEUTHUEs.InsertOnSubmit(_chitietphieuthue)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Function LayMaChiTietPhieuThueCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsChiTietPhieuThues As New List(Of CHITIETPHIEUTHUE)()

        _dsChiTietPhieuThues = (From dsctpt In db.CHITIETPHIEUTHUEs
                                Select dsctpt).ToList()

        Dim _machitietphieuthuecuoicung As String = "CTPT00"

        For Each ctpt In _dsChiTietPhieuThues
            _machitietphieuthuecuoicung = ctpt.MaChiTietPhieuThue

        Next
        Return _machitietphieuthuecuoicung
    End Function


    Public Shared Sub ThemChiTietPhieuThue(machitietphieuthue As String, maphieuthue As String, makhachhang As DateTime)
        Dim db As New QuanLyKhachSanDataContext()

        Dim insert As New CHITIETPHIEUTHUE
        insert.MaChiTietPhieuThue = machitietphieuthue
        insert.MaPhieuThue = maphieuthue
        insert.MaKhachHang = makhachhang

        db.CHITIETPHIEUTHUEs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
            MessageBox.Show("Insert Success!")
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
