Imports System.Windows.Forms
Imports System.IO
Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class MonitoringService
    Public timer As System.Timers.Timer = New System.Timers.Timer()

    Protected Overrides Sub OnStart(ByVal args() As String)
        If ConnectSMSserver() = True Then
            timer.Interval = 500
            AddHandler timer.Elapsed, AddressOf Me.OnTimer
            timer.Enabled = True
            timer.Start()

            RecordLog("SYSTEM INFO", "Synch Service Started")
        Else
            CheckConnection()
        End If
    End Sub

    Protected Overrides Sub OnStop()
        RecordLog("SYSTEM INFO", "Synch Service Stoped")
    End Sub

    Private Sub OnTimer(sender As Object, e As Timers.ElapsedEventArgs)
        Try
            Dim member_dst = New DataSet
            Dim member_msda As New SqlDataAdapter("select * from dbo.tblmembers where synched=0", msconn)
            member_msda.Fill(member_dst, "dbo.tblmembers")
            If member_dst.Tables("dbo.tblmembers").Rows.Count > 0 Then
                StartMemberSync()
            End If

            Dim trn_dst = New DataSet
            Dim trn_msda As New SqlDataAdapter("select * from dbo.tbltransaction where synched=0", msconn)
            trn_msda.Fill(trn_dst, "dbo.tbltransaction")
            If trn_dst.Tables("dbo.tbltransaction").Rows.Count > 0 Then
                StartTransactionSynch()
            End If

            Dim led_dst = New DataSet
            Dim led_msda As New SqlDataAdapter("select * from dbo.tblledger where synched=0", msconn)
            led_msda.Fill(led_dst, "dbo.tblledger")
            If led_dst.Tables("dbo.tblledger").Rows.Count > 0 Then
                StartLedgerSynch()
            End If

        Catch ex As SqlException
            'RecordLog("Synch SQL", ex.Message)
            CheckSMSConnection()
         
        Catch ex As Exception
            'RecordLog("Synch Timer", ex.Message)
            CheckSMSConnection()
        End Try
    End Sub

    Protected Overrides Sub OnContinue()
        timer.Start()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
End Class
