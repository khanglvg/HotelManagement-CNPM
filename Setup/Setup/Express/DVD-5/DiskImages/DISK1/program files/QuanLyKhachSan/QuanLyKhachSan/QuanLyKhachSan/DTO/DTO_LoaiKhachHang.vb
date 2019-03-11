Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_LoaiKhachHang
    Public Property strMaLoaiKhachHang() As String
        Get
            Return _strMaLoaiKhachHang
        End Get
        Set
            _strMaLoaiKhachHang = Value
        End Set
    End Property
    Private _strMaLoaiKhachHang As String

    Public Property strTenLoaiKhachHang() As String
        Get
            Return _strTenLoaiKhachHang
        End Get
        Set
            _strTenLoaiKhachHang = Value
        End Set
    End Property
    Private _strTenLoaiKhachHang As String

    Public Sub New()
        _strMaLoaiKhachHang = ""
        _strTenLoaiKhachHang = ""
    End Sub

    Public Sub New(ByVal maloaikhachhang As String, ByVal tenloaikhachhang As String)
        _strMaLoaiKhachHang = maloaikhachhang
        _strTenLoaiKhachHang = tenloaikhachhang

    End Sub

End Class