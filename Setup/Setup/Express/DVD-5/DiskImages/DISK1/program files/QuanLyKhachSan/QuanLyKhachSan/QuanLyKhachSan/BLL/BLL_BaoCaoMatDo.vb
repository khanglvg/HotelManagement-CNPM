Imports System.Data.Linq
Imports System.Windows.Forms
Public Class BLL_BaoCaoMatDo
    Public Shared m_instance As BLL_BaoCaoMatDo

    Public Shared ReadOnly Property Instance() As BLL_BaoCaoMatDo
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_BaoCaoMatDo()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub
    Public Function TangMaBaoCaoMatDo() As String
        Dim Ma As String = LayMaBaoCaoMatDoCuoiCung()
        Ma = Ma.Replace("CTBCMD", "")
        Ma = Integer.Parse(Ma)
        Ma += 1
        Dim MaMoi As String
        If Ma.Count = 1 Then
            MaMoi = "CTBCMD0" + Ma
        Else
            MaMoi = "CTBCMD" + Ma
        End If

        Return MaMoi
    End Function

    Public Function LayMaBaoCaoMatDoCuoiCung() As String
        Return DAL.DAL_BaoCaoMatDo.Instance.LayMaBaoCaoMatDoCuoiCung()
    End Function

    Public Sub LayMatDoSuDungPhongTheoThang(data As DataGridView, thang As String)
        data.DataSource = DAL.DAL_BaoCaoMatDo.Instance.LayMatDoSuDungPhongTheoThang(thang)
    End Sub
End Class
