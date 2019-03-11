Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_Phong
    Public Property strMaPhong() As String
        Get
            Return _strMaPhong
        End Get
        Set
            _strMaPhong = Value
        End Set
    End Property
    Private _strMaPhong As String

    Public Property strTenPhong() As String
        Get
            Return _strTenPhong
        End Get
        Set
            _strTenPhong = Value
        End Set
    End Property
    Private _strTenPhong As String

    Public Property strMaLoaiPhong() As String
        Get
            Return _strMaLoaiPhong
        End Get
        Set
            _strMaLoaiPhong = Value
        End Set
    End Property
    Private _strMaLoaiPhong As String

    Public Property strGhiChu() As String
        Get
            Return _strGhiChu
        End Get
        Set
            _strGhiChu = Value
        End Set
    End Property
    Private _strGhiChu As String

    Public Property booTinhTrangPhong()
        Get
            Return _booTinhTrangPhong
        End Get
        Set
            _booTinhTrangPhong = Value
        End Set
    End Property
    Private _booTinhTrangPhong As Boolean

    Public Sub New()
        _strMaPhong = ""
        _strTenPhong = ""
        _strMaLoaiPhong = ""
        _strGhiChu = ""
        _booTinhTrangPhong = 0
    End Sub

    Public Sub New(ByVal maphong As String, ByVal tenphong As String, ByVal maloaiphong As String, ByVal ghichu As String, ByVal tinhtrangphong As Boolean)
        _strMaPhong = maphong
        _strTenPhong = tenphong
        _strMaLoaiPhong = maloaiphong
        _strGhiChu = ghichu
        _booTinhTrangPhong = tinhtrangphong
    End Sub


End Class