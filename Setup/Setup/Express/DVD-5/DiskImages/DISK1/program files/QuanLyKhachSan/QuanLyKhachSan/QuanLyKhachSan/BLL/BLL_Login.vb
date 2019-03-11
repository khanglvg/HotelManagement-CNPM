
Imports DAL
Imports System.Windows.Forms


Public Class BLL_Login


    Public Shared m_instance As BLL_Login

    Public Shared ReadOnly Property Instance() As BLL_Login
        Get
            If m_instance Is Nothing Then
                m_instance = New BLL_Login()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Function KiemTraLogin(User As String, Password As String) As Boolean
        DAL.DAL_Login.Instance.LayUserIDFromUserName(User) 'dua UserName vao DAL

        If (DAL.DAL_Login.Instance.LayPassFromUserID(DAL.DAL_Login.Instance.LayUserIDFromUserName(User)) = "_null") Then
            Return False
        ElseIf (DAL.DAL_Login.Instance.LayPassFromUserID(DAL.DAL_Login.Instance.LayUserIDFromUserName(User)) = Password) Then
            Return True
        End If


        Return False

    End Function

    Public Function KiemTraVaiTroUser(user As String) As Integer
        Dim temp As Integer = 0
        If (DAL.DAL_Login.Instance.KiemTraVaiTroUser(user) = "0") Then
            Return 0
        ElseIf DAL.DAL_Login.Instance.KiemTraVaiTroUser(user) = "admin" Then
            Return 1
        ElseIf DAL.DAL_Login.Instance.KiemTraVaiTroUser(user) = "nhanvien" Then
            Return 2
        ElseIf DAL.DAL_Login.Instance.KiemTraVaiTroUser(user) = "giamdoc" Then
            Return 3
        End If
        Return 0
    End Function



End Class
