Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_HoaDon
    Public Property strMaHoaDon() As String
        Get
            Return _strMaHoaDon
        End Get
        Set
            _strMaHoaDon = Value
        End Set
    End Property
    Private _strMaHoaDon As String

    Public Property strMaKhachHang() As String
        Get
            Return _strMaKhachHang
        End Get
        Set
            _strMaKhachHang = Value
        End Set
    End Property
    Private _strMaKhachHang As String

    Public Property dtNgayLapHoaDon() As String
        Get
            Return _dtNgayLapHoaDon
        End Get
        Set
            _dtNgayLapHoaDon = Value
        End Set
    End Property
    Private _dtNgayLapHoaDon As DateTime

    Public Property dTriGiaHoaDon() As String
        Get
            Return _dTriGiaHoaDon
        End Get
        Set
            _dTriGiaHoaDon = Value
        End Set
    End Property
    Private _dTriGiaHoaDon As Double



    Public Sub New()
        _strMaHoaDon = ""
        _strMaKhachHang = ""
        _dtNgayLapHoaDon = ""
        _dTriGiaHoaDon = 0
    End Sub

    Public Sub New(ByVal mahoadon As String, ByVal makhachhang As String, ByVal ngaylaphoadon As String, ByVal trigiahoadon As Double)
        _strMaHoaDon = mahoadon
        _strMaKhachHang = makhachhang
        _dtNgayLapHoaDon = ngaylaphoadon
        _dTriGiaHoaDon = trigiahoadon

    End Sub

End Class