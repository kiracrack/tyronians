Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.Media
Imports MySql.Data.MySqlClient

Module LedgerSynch

    Public Class LedgerArgs
        Public sqlid As String
        Public memberid As String
        Public councilcode As String
        Public chaptercode As String
        Public description As String
        Public debit As Double
        Public credit As Double
        Public datetrn As String
        Public trnby As String
    End Class

    Public Sub StartLedgerSynch()
        Try
            Dim LedgerArgs As LedgerArgs = New LedgerArgs()
            Dim LedgerWorker As New BackgroundWorker

            LedgerWorker.WorkerReportsProgress = True
            LedgerWorker.WorkerSupportsCancellation = True
            AddHandler LedgerWorker.DoWork, AddressOf LedgerWorker_DoWork
            AddHandler LedgerWorker.RunWorkerCompleted, AddressOf LedgerWorker_WorkerCompleted
            If Not LedgerWorker.IsBusy Then
                Dim sqldst = New DataSet
                Dim sqlmsda As New SqlDataAdapter("select * from dbo.tblledger as a where synched=0 ", msconn)
                sqlmsda.Fill(sqldst, "dbo.tblledger")
                For re = 0 To sqldst.Tables("dbo.tblledger").Rows.Count - 1
                    With (sqldst.Tables("dbo.tblledger"))
                        LedgerArgs.sqlid = .Rows(re)("id").ToString()
                        LedgerArgs.memberid = .Rows(re)("memberid").ToString()
                        LedgerArgs.councilcode = .Rows(re)("councilcode").ToString()
                        LedgerArgs.description = rchar(.Rows(re)("description").ToString())
                        LedgerArgs.debit = Val(.Rows(re)("debit").ToString())
                        LedgerArgs.credit = Val(.Rows(re)("credit").ToString())
                        LedgerArgs.datetrn = ConvertDateTime(.Rows(re)("datetrn").ToString())
                        LedgerArgs.trnby = .Rows(re)("trnby").ToString()
                        LedgerWorker.RunWorkerAsync(LedgerArgs)
                    End With
                Next
                sqldst.Dispose() : sqlmsda.Dispose()
            End If
        Catch ex As SqlException
            'RecordLog("LEDGER ERROR", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            ' RecordLog("WORKER ERROR", ex.Message)
            CheckSMSConnection()
        End Try
    End Sub

    Private Sub LedgerWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim a As LedgerArgs = e.Argument
        Try
            If CheckMySQLOnline() = True Then
                onCom.CommandText = "DELETE FROM tblledger where sqlid='" & a.sqlid & "'" : onCom.ExecuteNonQuery()
                onCom.CommandText = "insert into tblledger set sqlid='" & a.sqlid & "', " _
                    + " councilcode='" & a.councilcode & "', " _
                    + " memberid='" & a.memberid & "', " _
                    + " description='" & a.description & "', " _
                    + " debit='" & a.debit & "', " _
                    + " credit='" & a.credit & "', " _
                    + " datetrn='" & a.datetrn & "', " _
                    + " trnby='" & a.trnby & "'" : onCom.ExecuteNonQuery()
                com.CommandText = "update dbo.tblledger set synched=1 where id='" & a.sqlid & "'" : com.ExecuteNonQuery()
            End If

        Catch ex As MySqlException
            'RecordLog("LedgerWorker_DoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As SqlException
            'RecordLog("SQLDoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            'RecordLog("DoWork", ex.Message)
            CheckSMSConnection()
        End Try

    End Sub

    Private Sub LedgerWorker_WorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        CheckSMSConnection()
    End Sub

End Module
