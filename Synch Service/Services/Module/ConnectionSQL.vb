Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient

Module ConnectionSQL

    Public msconn As New SqlConnection
    Public msmsda As SqlDataAdapter 'is use to update the dataset and datasource
    Public msdst As New DataSet 'miniature of your table - cache table to client
    Public mscom As New SqlCommand
    Public msrst As SqlDataReader

    Public com As New SqlCommand
 


    Public SmsActiveConnection As Boolean = False
    Public SMSwaitTimer As Integer = 0
    Public SMSSyncStarted As Boolean = False

    Public GlobalSmsServerhost As String
    Public GlobalSmsusername As String
    Public GlobalSmspassword As String
    Public GlobalSmsDatabase As String
    
    Public Function ConnectSMSserver() As Boolean
        Try
            Dim sr As StreamReader = File.OpenText(Application.StartupPath.ToString & "\Connection.conn")
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim conn As String() = br.Split(",")
            GlobalSmsServerhost = conn(0)
            GlobalSmsusername = conn(1)
            GlobalSmspassword = conn(2)
            GlobalSmsDatabase = conn(3)

            If msconn.State = ConnectionState.Open = True Then
                msconn.Close()
            End If
            msconn = New SqlConnection
            msconn.ConnectionString = "MultipleActiveResultSets=True; Server=" & GlobalSmsServerhost & ";Database=" & GlobalSmsDatabase & ";User Id=" & GlobalSmsusername & ";Password=" & GlobalSmspassword & ";"
            mscom.CommandTimeout = 6000000
            mscom.Connection = msconn

            com.CommandTimeout = 6000000
            com.Connection = msconn

            msconn.Open()

        Catch errSQL As Exception
            SmsActiveConnection = False
            RecordLog("SMS SERVER", errSQL.Message)
        End Try
        Return True
    End Function

    Public Sub CheckConnection()
        If ConnectSMSserver() = True Then
            Dim ServicesToRun() As System.ServiceProcess.ServiceBase
            ServicesToRun = New System.ServiceProcess.ServiceBase() {New MonitoringService()}
            System.ServiceProcess.ServiceBase.Run(ServicesToRun)
        Else
            Application.Restart()
            CheckConnection()
        End If
    End Sub


    Public Sub CheckSMSConnection()
        If ConnectSMSserver() = True Then
            Dim ServicesToRun() As System.ServiceProcess.ServiceBase
            ServicesToRun = New System.ServiceProcess.ServiceBase() {New MonitoringService()}
            System.ServiceProcess.ServiceBase.Run(ServicesToRun)
        Else
            Application.Restart()
            ConnectSMSserver()
        End If
    End Sub



End Module
