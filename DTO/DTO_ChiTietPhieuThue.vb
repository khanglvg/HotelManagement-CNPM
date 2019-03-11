Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_ChiTietPhieuThue
    Public Property strMaChiTietPhieuThue() As String
        Get
            Return _strMaChiTietPhieuThue
        End Get
        Set
            _strMaChiTietPhieuThue = Value
        End Set
    End Property
    Private _strMaChiTietPhieuThue As String

    Public Property strMaPhieuThue() As String
        Get
            Return _strMaPhieuThue
        End Get
        Set
            _strMaPhieuThue = Value
        End Set
    End Property
    Private _strMaPhieuThue As String

    Public Property strMaKhachHang() As String
        Get
            Return _strMaKhachHang
        End Get
        Set
            _strMaKhachHang = Value
        End Set
    End Property
    Private _strMaKhachHang As String


    Public Sub New()
        _strMaChiTietPhieuThue = ""
        _strMaPhieuThue = ""
        _strMaKhachHang = ""
    End Sub

    Public Sub New(ByVal machitietphieuthue As String, ByVal maphieuthue As String, ByVal makhachhang As String)
        _strMaChiTietPhieuThue = machitietphieuthue
        _strMaPhieuThue = maphieuthue
        _strMaKhachHang = makhachhang
    End Sub

End Class