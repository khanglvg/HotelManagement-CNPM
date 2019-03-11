Imports System.Data.Linq
Imports System.Windows.Forms
Imports DTO
Public Class DAL_Login


    Public Shared m_instance As DAL_Login

    Public Shared ReadOnly Property Instance() As DAL_Login
        Get
            If m_instance Is Nothing Then
                m_instance = New DAL_Login()
            End If
            Return m_instance
        End Get
    End Property

    Public Sub New()
    End Sub


    Public Function LayUserIDFromUserName(User As String) As String
        Dim _idUser As String = "_fakeuser"
        Dim _login As New LOGIN
        Dim db As New QuanLyKhachSanDataContext()

        _login = (From lg In db.LOGINs
                  Where lg.UserName.CompareTo(User) = 0
                  Select lg).ToList().SingleOrDefault()
        If (KiemTraUserName(User)) Then
            _idUser = _login.UserID
        End If

        Return _idUser
    End Function



    Public Function KiemTraUserName(User As String) As Boolean

        Dim _loginArray As New List(Of LOGIN)
        Dim db As New QuanLyKhachSanDataContext()

        _loginArray = db.LOGINs.[Select](Function(p) p).ToList()

        For Each login In _loginArray
            If (login.UserName = User) Then
                Return True
            End If
        Next



        Return False
    End Function

    Public Function LayPassFromUserID(UserID As String) As String
        Dim _Pass As String
        Dim _login As New LOGIN
        Dim db As New QuanLyKhachSanDataContext()


        _login = (From lg In db.LOGINs
                  Where lg.UserID.CompareTo(UserID) = 0
                  Select lg).ToList().SingleOrDefault()
        Try
            _Pass = _login.Password
            Return _Pass
        Catch ex As Exception

        End Try
        Return "_null"
    End Function


    Public Function KiemTraVaiTroUser(User As String) As String
        Dim _login As New LOGIN
        Dim db As New QuanLyKhachSanDataContext()
        Dim _vaitroUser As String = "0"
        _login = (From lg In db.LOGINs
                  Where lg.UserName.CompareTo(User) = 0
                  Select lg).ToList().SingleOrDefault()
        If (KiemTraUserName(User)) Then
            _vaitroUser = _login.Role
        End If

        Return _vaitroUser
    End Function

    Public Sub InsertUserAccount(UserId As String, UserName As String, Pass As String, Role As String)
        Dim db As New QuanLyKhachSanDataContext()

        Dim insert As New LOGIN
        insert.UserID = UserId
        insert.UserName = UserName
        insert.Password = Pass
        insert.Role = Role

        db.LOGINs.InsertOnSubmit(insert)

        Try
            db.SubmitChanges()
        Catch
            MessageBox.Show("Review your data input!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetLastUserId() As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _users As New List(Of LOGIN)
        Dim _lastUserId As String

        _users = (From u In db.LOGINs
                  Select u).ToList()

        For Each user In _users
            _lastUserId = user.UserID
        Next

        Return _lastUserId
    End Function

    Public Sub ChangePassword(UserId As String, UserName As String, newPass As String, Role As String)
        Dim db As New QuanLyKhachSanDataContext()
        Dim edit As LOGIN = db.LOGINs.Where(Function(p) p.UserID.Equals(UserId)).SingleOrDefault()
        Dim _userid As String
        Dim _username As String
        Dim _userpass As String
        Dim _userrole As String

        _userid = UserId.Replace(" ", "")
        _username = UserName.Replace(" ", "")
        _userpass = newPass.Replace(" ", "")
        _userrole = Role.Replace(" ", "")

        edit.UserID = _userid
        edit.UserName = _username
        edit.Password = _userpass
        edit.Role = _userrole

        Try
            db.SubmitChanges()
        Catch
        End Try
    End Sub


    Public Function GetRoleFromUserId(UserId As String) As String
        Dim db As New QuanLyKhachSanDataContext()
        Dim _user As New LOGIN

        _user = (From u In db.LOGINs
                 Where u.UserID.CompareTo(UserId) = 0
                 Select u).ToList().SingleOrDefault()

        Return _user.Role.ToString()
    End Function

    Public Function IsUserNameAlready(UserName As String) As Boolean
        If (KiemTraUserName(UserName)) Then
            Return True
        Else Return False
        End If
    End Function
End Class
