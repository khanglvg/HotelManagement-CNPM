Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_LoaiPhong
    Public Property strMaLoaiPhong() As String
        Get
            Return _strMaLoaiPhong
        End Get
        Set
            _strMaLoaiPhong = Value
        End Set
    End Property
    Private _strMaLoaiPhong As String

    Public Property strTenLoaiPhong() As String
        Get
            Return _strTenLoaiPhong
        End Get
        Set
            _strTenLoaiPhong = Value
        End Set
    End Property
    Private _strTenLoaiPhong As String

    Public Property iDonGia() As Double
        Get
            Return _iDonGia
        End Get
        Set
            _iDonGia = Value
        End Set
    End Property
    Private _iDonGia As Double

    Public Sub New()
        _strMaLoaiPhong = ""
        _strTenLoaiPhong = ""
        _iDonGia = 0
    End Sub

    Public Sub New(ByVal maloaiphong As String, ByVal tenloaiphong As String, ByVal dongia As Double)
        _strMaLoaiPhong = maloaiphong
        _strTenLoaiPhong = tenloaiphong
        _iDonGia = dongia
    End Sub

End Class