Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_ChiTietHoaDon
    Public Shared m_instance As DAL_ChiTietHoaDon

    Public Shared ReadOnly Property Instance() As DAL_ChiTietHoaDon
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_ChiTietHoaDon()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub


    Public Function LayMaChiTietHoaDonCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dschitietHoaDons As New List(Of CHITIETHOADON)()

        _dschitietHoaDons = (From dscthd In db.CHITIETHOADONs
                             Select dscthd).ToList()

        Dim _mahoadoncuoicung As String = "CTHD00"
        For Each hd In _dschitietHoaDons
            _mahoadoncuoicung = hd.MaHoaDon

        Next
        Return _mahoadoncuoicung
    End Function

End Class