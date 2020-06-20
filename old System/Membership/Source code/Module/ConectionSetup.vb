Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Module ConectionSetup
    Public li As String = Environment.NewLine
    Public Em As DataGridView
    Public globalOrganizationName As String = "TYRO GYN PHI FRATERNITY"
    Public globalMailHost As String = "katipunanbank.com"
    Public globalOfficialEmail As String = "webadmin@katipunanbank.com"
    Public globalEmailPassword As String = "nonest"
    Public formclose As Boolean
    Public conn As New MySqlConnection
    Public msda As MySqlDataAdapter
    Public dst As New DataSet
    Public com As New MySqlCommand
    Public rst As MySqlDataReader

    Public sqlserver As String = "localhost"
    Public sqluser As String = "root"
    Public sqlpass As String = "12sysadmin34"
    Public sqldatabase As String = "tyronians"

    'Public sqlserver As String = "katipunanbank.com"
    'Public sqluser As String = "kbadmin_orgbase"
    'Public sqlpass As String = "v2c47"
    'Public sqldatabase As String = "kbadmin_orgbase"

    'Public sqlserver As String = "mysql1004.mochahost.com"
    'Public sqluser As String = "cisadmin_dbase"
    'Public sqlpass As String = "Nonest1200"
    'Public sqldatabase As String = "cisadmin_tyronians"


    Public Function ConnectVerify() As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            Return True
        Catch ex As Exception
            Return False
        End Try
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
End Module
