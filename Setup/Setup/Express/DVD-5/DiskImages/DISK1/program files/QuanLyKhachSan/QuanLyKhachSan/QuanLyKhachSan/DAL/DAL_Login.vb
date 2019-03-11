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

End Class
