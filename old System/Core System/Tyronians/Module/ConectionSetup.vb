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
    Public globalMailHost As String = "dipologcity.gov.ph"
    Public globalOfficialEmail As String = "tyronians@dipologcity.gov.ph"
    Public globalEmailPassword As String = "nonest"
    Public fversion As Date = System.IO.File.GetLastWriteTime(My.Application.Info.DirectoryPath).ToShortDateString()
    Public formclose As Boolean
    Public conn As New MySqlConnection
    Public msda As MySqlDataAdapter
    Public dst As New DataSet
    Public com As New MySqlCommand
    Public rst As MySqlDataReader

    'Public sqlserver As String = "localhost"
    'Public sqluser As String = "root"
    'Public sqlpass As String = "12sysadmin34"
    'Public sqldatabase As String = "orgbase"

    Public sqlserver As String = "localhost"
    Public sqluser As String = "root"
    Public sqlpass As String = "12sysadmin34"
    Public sqldatabase As String = "tyronians"

    Public Sub ConnectVerify()
        conn = New MySql.Data.MySqlClient.MySqlConnection
        conn.ConnectionString = "server=" & sqlserver & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Allow Zero Datetime=True"
        conn.Open()
        com.Connection = conn
    End Sub

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
