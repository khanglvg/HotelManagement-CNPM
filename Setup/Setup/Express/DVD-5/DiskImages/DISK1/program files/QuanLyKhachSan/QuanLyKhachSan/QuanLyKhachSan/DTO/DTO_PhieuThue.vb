Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_PhieuThue
    Public Property strMaPhieuThue() As String
        Get
            Return _strMaPhieuThue
        End Get
        Set
            _strMaPhieuThue = Value
        End Set
    End Property
    Private _strMaPhieuThue As String

    Public Property strMaPhong() As String
        Get
            Return _strMaPhong
        End Get
        Set
            _strMaPhong = Value
        End Set
    End Property
    Private _strMaPhong As String

    Public Property dtNgayBatDauThue() As DateTime
        Get
            Return _dtNgayBatDauThue
        End Get
        Set
            _dtNgayBatDauThue = Value
        End Set
    End Property
    Private _dtNgayBatDauThue As DateTime

    Public Sub New()
        _strMaPhieuThue = ""
        _strMaPhong = ""
        _dtNgayBatDauThue = #1/1/2000#
    End Sub

    Public Sub New(ByVal maphieuthue As String, ByVal maphong As String, ByVal ngaybatdauthue As DateTime)
        _strMaPhieuThue = maphieuthue
        _strMaPhong = maphong
        _dtNgayBatDauThue = ngaybatdauthue
    End Sub

End Class
