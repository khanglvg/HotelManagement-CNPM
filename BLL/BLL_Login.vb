
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

    Public Function IncreaseUserId() As String
        Dim Id As String = DAL.DAL_Login.Instance.GetLastUserId()
        Id.Replace("US", "")
        Id = Integer.Parse(Id)
        Id += 1
        Dim NewId As String
        If Id <= 9 Then
            NewId = "US0" + Id
        Else
            NewId = "US" + Id
        End If
        Return NewId
    End Function

    Public Sub InsertUserAccount(UserName As String, Pass As String, role As String)
        If role = "Admin" Then
            DAL.DAL_Login.Instance.InsertUserAccount(IncreaseUserId, UserName, Pass, "admin")
        ElseIf role = "Nhân Viên" Then
            DAL.DAL_Login.Instance.InsertUserAccount(IncreaseUserId, UserName, Pass, "nhanvien")
        ElseIf role = "Giám Đốc" Then
            DAL.DAL_Login.Instance.InsertUserAccount(IncreaseUserId, UserName, Pass, "giamdoc")
        End If

    End Sub

    Public Function GetUserIdFromUserName(UserName As String) As String
        Return DAL.DAL_Login.Instance.LayUserIDFromUserName(UserName)
    End Function

    Public Function GetRoleFromUserId(UserId As String) As String
        If DAL.DAL_Login.Instance.GetRoleFromUserId(UserId) = "admin" Then
            Return "Admin"
        ElseIf DAL.DAL_Login.Instance.GetRoleFromUserId(UserId) = "nhanvien" Then
            Return "Nhân Viên"
        ElseIf DAL.DAL_Login.Instance.GetRoleFromUserId(UserId) = "giamdoc" Then
            Return "Giám Đốc"
        End If
        Return ""
    End Function

    Public Function IsUserNameAlready(UserName As String) As Boolean
        Return DAL.DAL_Login.Instance.IsUserNameAlready(UserName)
    End Function

    Public Function LayPassFromUserID(UserID As String) As String
        Return DAL.DAL_Login.Instance.LayPassFromUserID(UserID)
    End Function

    Public Sub ChangePassword(UserId As String, UserName As String, newPass As String, Role As String)

        If Role = "Admin" Then
            DAL.DAL_Login.Instance.ChangePassword(UserId, UserName, newPass, "admin")
        ElseIf Role = "Nhân Viên" Then
            DAL.DAL_Login.Instance.ChangePassword(UserId, UserName, newPass, "nhanvien")
        ElseIf Role = "Giám Đốc" Then
            DAL.DAL_Login.Instance.ChangePassword(UserId, UserName, newPass, "giamdoc")
        End If
    End Sub
End Class
