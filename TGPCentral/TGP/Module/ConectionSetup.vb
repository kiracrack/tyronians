Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module ConectionSetup
    Public provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public li As String = Environment.NewLine
    Public Em As DataGridView

    Public GlobalEnableEmailNotification As Boolean = False
    Public GlobalSmtpHost As String
    Public GlobalSmtpPort As String
    Public GlobalSSLEnable As Boolean
    Public GlobalServerMail As String
    Public GlobalTargetMail As String
    Public GlobalServerPassword As String

    Public FileProperties As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public fversion As String = FileProperties.FileVersion.ToString.Remove(FileProperties.FileVersion.ToString.Length - 2, 2)
    Public dversion As Date = Date.ParseExact(fversion, "yy.M.d", provider)
    Public GlobalApplicationName As String = "Tyronians Management"
    Public formclose As Boolean

    'MSSQL
    Public conn As New SqlConnection
    Public msda As SqlDataAdapter
    Public dst As New DataSet
    Public com As New SqlCommand
    Public rst As SqlDataReader
    Public sqlcmd As New SqlCommand

    'MYSQL Settings
    Public onConn As New MySqlConnection
    Public onCom As New MySqlCommand
    Public OnRst As MySqlDataReader

    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"

    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String

    Public ConnectedServer As Boolean = False

    Public clientserver As String
    Public clientport As String
    Public clientuser As String
    Public clientpass As String
    Public clientdatabase As String
    Public GlobalEnableEncryption As Boolean

    Public Function OpenSQLConnection() As Boolean
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br)
        Dim connfile As String() = strSetup.Split("|")
        GlobalMSServer = connfile(0)
        GLobalMSEsername = connfile(1)
        GlobalMSPassword = connfile(2)
        GlobalMSDatabase = connfile(3)

        Try
            conn.Close()
            conn = New SqlConnection
            conn.ConnectionString = "Server=" & GlobalMSServer & ";Database=" & GlobalMSDatabase & ";User Id=" & GLobalMSEsername & ";Password=" & GlobalMSPassword & ";"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000

        Catch errMYSQL As SqlException
            Return False
        End Try
        Return True
    End Function

    Public Function ConnectMySQLOnline() As Boolean
        Try
            onConn.Close()
            onConn = New MySql.Data.MySqlClient.MySqlConnection
            onConn.ConnectionString = "server=remotemysql.com; Port=3306; user id=JAfRE1JVzV; password=sNDcgQAfcw; database=JAfRE1JVzV; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            onConn.Open()
            onCom.Connection = onConn
            onCom.CommandTimeout = 6000000

        Catch errMYSQL As MySqlException
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

    Public Class ComboBoxItem
        Private displayValue As String
        Private m_hiddenValue As String

        Public Sub New(ByVal d As String, ByVal h As String)
            displayValue = d
            m_hiddenValue = h
        End Sub

        Public ReadOnly Property HiddenValue() As String
            Get
                Return m_hiddenValue
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return displayValue
        End Function
    End Class

    Public Function getGlobalTrnid(ByVal init As String, ByVal endid As String)
        Dim finalstr As String = Now.ToString("yyyyMMddhhmmss")

        finalstr = init & "-" & finalstr & "-" & endid
        Return finalstr
    End Function
    Public Function getGlobalRequestid(ByVal init As String, ByVal endid As String)
        Dim strs As Date
        Dim finalstr As String = ""

        com.CommandText = "select current_timestamp as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
            finalstr = strs.ToString("yyyy-MM-dd")
        End While
        rst.Close()
        finalstr = init & "-" & finalstr.Replace("-", "") & "-" & endid
        Return finalstr
    End Function

    Public Function DepreciationReduce(ByVal unitcost As Double, ByVal age As Double, ByVal rate As Double) As Double
        DepreciationReduce = unitcost
        For I = 0 To age - 1
            Dim year1depn = DepreciationReduce * (rate / 100)
            DepreciationReduce = DepreciationReduce - year1depn
        Next
        Return DepreciationReduce
    End Function

    Public Function DepreciationStraight(ByVal unitcost As Double, ByVal age As Double, ByVal NumberOfYears As Double) As Double
        Dim value As Double = 0 : Dim bookValue As Double = 0
        If NumberOfYears > 0 Then
            Dim devidedRate = unitcost / NumberOfYears
            DepreciationStraight = 0
            Dim asMonth As Double = age / 12
            For I = 0 To asMonth - 1
                DepreciationStraight = DepreciationStraight + devidedRate
            Next
            value = unitcost - DepreciationStraight
            If value > 0 Then
                bookValue = value
            Else
                bookValue = 1
            End If
        Else
            bookValue = 1
        End If
        Return bookValue
    End Function

End Module
