Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms

Module ConnectionMySQL
    'MYSQL Settings
    Public onConn As New MySqlConnection
    Public onCom As New MySqlCommand
    Public OnRst As MySqlDataReader

    Public sqlipaddress As String
    Public sqlPort As String
    Public sqlusername As String
    Public sqlpassword As String
    Public sqldatabase As String

    Public Function ConnectMySQLOnline() As Boolean
        Try
            Dim sr As StreamReader = File.OpenText(Application.StartupPath.ToString & "\Online.conn")
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim conn As String() = br.Split(",")
            sqlipaddress = conn(0)
            sqlPort = conn(1)
            sqlusername = conn(2)
            sqlpassword = conn(3)
            sqldatabase = conn(4)

            If onConn.State = ConnectionState.Closed Or onConn.State = ConnectionState.Broken Then
                onConn = New MySql.Data.MySqlClient.MySqlConnection
                onConn.ConnectionString = "server=" & sqlipaddress & "; Port=" & sqlPort & "; user id=" & sqlusername & "; password=" & sqlpassword & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
                onConn.Open()
                onCom.Connection = onConn
                onCom.CommandTimeout = 6000000
            End If

        Catch errMYSQL As MySqlException
            RecordLog("Synch SQL", errMYSQL.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function CheckMySQLOnline() As Boolean
        Try
            If onConn.State = ConnectionState.Open Then
                Return True
            Else
                If ConnectMySQLOnline() = True Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch errMYSQL As MySqlException
            ConnectMySQLOnline()
        End Try
        Return True
    End Function
End Module
