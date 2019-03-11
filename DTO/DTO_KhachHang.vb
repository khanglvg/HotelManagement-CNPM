Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_KhachHang
    Public Property strMaKhachHang() As String
        Get
            Return _strMaKhachHang
        End Get
        Set(value As String)
            _strMaKhachHang = value
        End Set
    End Property
    Private _strMaKhachHang As String


    Public Property strTenKhachHang() As String
        Get
            Return _strTenKhachHang
        End Get
        Set(value As String)
            _strTenKhachHang = value
        End Set
    End Property
    Private _strTenKhachHang As String



    Public Property strMaLoaiKhachHang() As String
        Get
            Return _strMaLoaiKhachHang
        End Get
        Set(value As String)
            _strMaLoaiKhachHang = value
        End Set
    End Property
    Private _strMaLoaiKhachHang As String




    Public Property iCMND() As String
        Get
            Return _iCMND
        End Get
        Set(value As String)
            _iCMND = value
        End Set
    End Property
    Private _iCMND As Integer



    Public Property strDiaChi() As String
        Get
            Return _strDiaChi
        End Get
        Set(value As String)
            _strDiaChi = value
        End Set
    End Property
    Private _strDiaChi As String


    Public Sub New()
        _strMaKhachHang = ""
        _strTenKhachHang = ""
        _strMaLoaiKhachHang = ""
        _iCMND = 0
        _strDiaChi = ""
    End Sub


    Public Sub New(ByVal makhachhang As String, ByVal tenkhachhang As String, ByVal maloaikhachhang As String, ByVal cmnd As Integer, ByVal diachi As String)
        _strMaKhachHang = makhachhang
        _strTenKhachHang = tenkhachhang
        _strMaLoaiKhachHang = maloaikhachhang
        _iCMND = cmnd
        _strDiaChi = diachi
    End Sub

End Class
