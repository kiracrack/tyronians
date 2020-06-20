Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.Media
Imports MySql.Data.MySqlClient

Module TransactionSynch

    Public Class TrnArgs
        Public sqlid As String
        Public memberid As String
        Public councilcode As String
        Public chaptercode As String
        Public amount As Double
        Public explaination As String
        Public contribution As Boolean
        Public expenses As Boolean
        Public datetrn As String
        Public trnby As String
    End Class

    Public Sub StartTransactionSynch()
        Try
            Dim TrnArgs As TrnArgs = New TrnArgs()
            Dim TrnWorker As New BackgroundWorker

            TrnWorker.WorkerReportsProgress = True
            TrnWorker.WorkerSupportsCancellation = True
            AddHandler TrnWorker.DoWork, AddressOf TrnWorker_DoWork
            AddHandler TrnWorker.RunWorkerCompleted, AddressOf TrnWorker_WorkerCompleted
            If Not TrnWorker.IsBusy Then
                Dim sqldst = New DataSet
                Dim sqlmsda As New SqlDataAdapter("select * from dbo.tbltransaction as a where synched=0 ", msconn)
                sqlmsda.Fill(sqldst, "dbo.tbltransaction")
                For re = 0 To sqldst.Tables("dbo.tbltransaction").Rows.Count - 1
                    With (sqldst.Tables("dbo.tbltransaction"))
                        TrnArgs.sqlid = .Rows(re)("id").ToString()
                        TrnArgs.memberid = .Rows(re)("memberid").ToString()
                        TrnArgs.councilcode = .Rows(re)("councilcode").ToString()
                        TrnArgs.chaptercode = .Rows(re)("chaptercode").ToString()
                        TrnArgs.amount = Val(.Rows(re)("amount").ToString())
                        TrnArgs.explaination = rchar(.Rows(re)("explaination").ToString())
                        TrnArgs.contribution = CBool(.Rows(re)("contribution").ToString())
                        TrnArgs.expenses = CBool(.Rows(re)("expenses").ToString())
                        TrnArgs.datetrn = ConvertDateTime(.Rows(re)("datetrn").ToString())
                        TrnArgs.trnby = .Rows(re)("trnby").ToString()

                        TrnWorker.RunWorkerAsync(TrnArgs)
                    End With
                Next
                sqldst.Dispose() : sqlmsda.Dispose()
            End If
        Catch ex As SqlException
            'RecordLog("TRANSACTION ERROR", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            ' RecordLog("WORKER ERROR", ex.Message)
            CheckSMSConnection()
        End Try
    End Sub

    Private Sub TrnWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim a As TrnArgs = e.Argument
        Try
            If CheckMySQLOnline() = True Then
                onCom.CommandText = "DELETE FROM tbltransaction where sqlid='" & a.sqlid & "'" : onCom.ExecuteNonQuery()
                onCom.CommandText = "insert into tbltransaction set sqlid='" & a.sqlid & "', " _
                    + " councilcode='" & a.councilcode & "', " _
                    + " chaptercode='" & a.chaptercode & "', " _
                    + " memberid='" & a.memberid & "', " _
                    + " amount='" & a.amount & "', " _
                    + " explaination='" & a.explaination & "', " _
                    + " contribution=" & a.contribution & ", " _
                    + " expenses=" & a.expenses & ", " _
                    + " datetrn='" & a.datetrn & "', " _
                    + " trnby='" & a.trnby & "'" : onCom.ExecuteNonQuery()
                com.CommandText = "update dbo.tbltransaction set synched=1 where id='" & a.sqlid & "'" : com.ExecuteNonQuery()
            End If

        Catch ex As MySqlException
            'RecordLog("TrnWorker_DoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As SqlException
            'RecordLog("SQLDoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            'RecordLog("DoWork", ex.Message)
            CheckConnection()
        End Try

    End Sub

    Private Sub TrnWorker_WorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        CheckSMSConnection()
    End Sub

End Module
