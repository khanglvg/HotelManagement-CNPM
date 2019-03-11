Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class DTO_ChiTietHoaDon
    Public Property strMaChiTietHoaDon() As String
        Get
            Return _strMaChiTietHoaDon
        End Get
        Set(value As String)
            _strMaChiTietHoaDon = value
        End Set
    End Property
    Private _strMaChiTietHoaDon As String


    Public Property strMaHoaDon() As String
        Get
            Return _strMaHoaDon
        End Get
        Set(value As String)
            _strMaHoaDon = value
        End Set
    End Property
    Private _strMaHoaDon As String


    Public Property strMaChiTietPhieuThue() As String
        Get
            Return _strMaChiTietPhieuThue
        End Get
        Set(value As String)
            _strMaChiTietPhieuThue = value
        End Set
    End Property
    Private _strMaChiTietPhieuThue As String



    Public Property iSoNgayThue() As Integer
        Get
            Return _iSoNgayThue
        End Get
        Set(value As Integer)
            _iSoNgayThue = value
        End Set
    End Property
    Private _iSoNgayThue As Integer


    Public Property dThanhTien() As Double
        Get
            Return _dThanhTien
        End Get
        Set(value As Double)
            _dThanhTien = value
        End Set
    End Property
    Private _dThanhTien As Double


    Public Sub New()
        _strMaChiTietHoaDon = ""
        _strMaHoaDon = ""
        _strMaChiTietPhieuThue = ""
        _iSoNgayThue = ""
        _dThanhTien = ""
    End Sub


    Public Sub New(ByVal machitiethoadon As String, ByVal mahoadon As String, ByVal machitietphieuthue As String, ByVal songaythue As Integer, ByVal thanhtien As Double)
        _strMaChiTietHoaDon = machitiethoadon
        _strMaHoaDon = mahoadon
        _strMaChiTietPhieuThue = machitietphieuthue
        _iSoNgayThue = songaythue
        _dThanhTien = thanhtien
    End Sub
End Class
