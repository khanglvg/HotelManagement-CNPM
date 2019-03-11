Imports System.Data.Linq
Imports System.Windows.Forms
Public Class DAL_BaoCaoThang
    Public Shared m_instance As DAL_BaoCaoThang

    Public Shared ReadOnly Property Instance() As DAL_BaoCaoThang
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_BaoCaoThang()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function LayMaBaoCaoThangCuoiCung() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _dsBaoCaos As New List(Of BAOCAO)()

        _dsBaoCaos = (From dsbc In db.BAOCAOs
                      Select dsbc).ToList()

        Dim _maBaoCaoCuoiCung As String = "BC00"
        For Each bc In _dsBaoCaos
            _maBaoCaoCuoiCung = bc.MaBaoCao
        Next
        Return _maBaoCaoCuoiCung
    End Function
End Class
