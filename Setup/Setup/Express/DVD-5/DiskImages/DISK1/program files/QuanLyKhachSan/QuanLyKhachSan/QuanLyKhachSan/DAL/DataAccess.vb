Imports System.Data.OleDb

Public Class DataAccess
    Public Shared connection As OleDbConnection = New OleDbConnection("server=DESKTOP-3HMVN5B\GIAKHANG;databases=QuanLyKhachSan")

    Shared Sub _openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()

        ElseIf connection.State = ConnectionState.Open Then
            connection.Close()
            connection.Open()
        End If
    End Sub

    Shared Sub _closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class