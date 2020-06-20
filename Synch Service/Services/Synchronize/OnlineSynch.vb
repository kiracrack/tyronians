Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Module OnlineSynch

    Public Class WorkerOnlineArgs
        Public id As Integer
        Public fullname As String
        Public address As String
        Public contactnumber As String
    End Class


    Public Sub StartOnlineSynch()
        Dim id As String = ""
        Try
            Dim onArgs As WorkerOnlineArgs = New WorkerOnlineArgs()
            Dim OnlineWorker As New BackgroundWorker

            OnlineWorker.WorkerReportsProgress = True
            OnlineWorker.WorkerSupportsCancellation = True
            AddHandler OnlineWorker.DoWork, AddressOf Online_DoWork
            AddHandler OnlineWorker.RunWorkerCompleted, AddressOf Online_WorkerCompleted

            Dim work_dst = New DataSet
            Dim work_da As New MySqlDataAdapter("select * from tblonlineregistration where synch=0", onConn)
            work_da.Fill(work_dst, "tblonlineregistration")
            For re = 0 To work_dst.Tables("tblonlineregistration").Rows.Count - 1
                With (work_dst.Tables("tblonlineregistration"))
                    If Not OnlineWorker.IsBusy Then
                        id = .Rows(re)("id").ToString()
                        onArgs.id = .Rows(re)("id").ToString()
                        onArgs.fullname = .Rows(re)("fullname").ToString()
                        onArgs.address = .Rows(re)("address").ToString()
                        onArgs.contactnumber = .Rows(re)("contactnumber").ToString()
                        OnlineWorker.RunWorkerAsync(onArgs)
                    End If
                End With
            Next
        Catch ex As MySqlException
            SendMessageByPrefix("+639491744457", "SQL(" & id & ") - " & ex.Message, False)
            RecordLog("StartOnlineSynch", "MySQL(" & id & ") - " & ex.Message)
            CheckMySQLOnline()

        Catch ex As Exception
            SendMessageByPrefix("+639491744457", "SQL(" & id & ") - " & ex.Message, False)
            RecordLog("StartOnlineSynch", "MySQL(" & id & ") - " & ex.Message)
            CheckMySQLOnline()
        End Try
    End Sub

    Private Sub Online_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim onArgs As WorkerOnlineArgs = e.Argument
        Try
            onCom.CommandText = "update tblonlineregistration set synch=1 where id='" & onArgs.id & "'" : onCom.ExecuteNonQuery()
            SendMessageByPrefix(onArgs.contactnumber, "Welcome " & onArgs.fullname & " to Pioneer e-Games Center. Your permanent PIN is 1234", False)

        Catch ex As SqlException
            SendMessageByPrefix("+639491744457", "SQL(" & onArgs.id & ") - " & ex.Message, False)
            RecordLog("Online_DoWork", "MySQL(" & onArgs.id & ") - " & ex.Message)
            CheckMySQLOnline()

        Catch ex As Exception
            SendMessageByPrefix("+639491744457", "SQL(" & onArgs.id & ") - " & ex.Message, False)
            RecordLog("Online_DoWork", "MySQL(" & onArgs.id & ") - " & ex.Message)
            CheckMySQLOnline()
        End Try

    End Sub

    Private Sub Online_WorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        CheckMySQLOnline()
    End Sub


End Module
