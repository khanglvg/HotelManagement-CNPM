
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DTO_ThamSo
    Public Property iSoLuongKhachHangToiDa() As Integer
        Get
            Return _iSoLuongKhachHangToiDa
        End Get
        Set
            _iSoLuongKhachHangToiDa = Value
        End Set
    End Property
    Private _iSoLuongKhachHangToiDa As Integer

    Public Sub New()
        _iSoLuongKhachHangToiDa = 0
    End Sub

    Public Sub New(ByVal soluongkhachhangtoida As Integer)
        _iSoLuongKhachHangToiDa = soluongkhachhangtoida
    End Sub
End Class