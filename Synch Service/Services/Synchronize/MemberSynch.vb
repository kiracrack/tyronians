Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.Media
Imports MySql.Data.MySqlClient

Module MemberSynch

    Public Class MemberArgs
        Public memberid As String
        Public councilcode As String
        Public councilname As String
        Public chaptercode As String
        Public chaptername As String
        Public fullname As String
        Public birthdate As String
        Public gender As String
        Public phonenumber As String
        Public occupation As String
        Public datesurvived As String
        Public baptizedname As String
        Public recruitername As String
        Public position As String
        Public registeredby As String
        Public dateregistered As String
    End Class

    Public Sub StartMemberSync()
        Try
            Dim myArgs As MemberArgs = New MemberArgs()
            Dim MemberWorker As New BackgroundWorker

            MemberWorker.WorkerReportsProgress = True
            MemberWorker.WorkerSupportsCancellation = True
            AddHandler MemberWorker.DoWork, AddressOf MemberWorker_DoWork
            AddHandler MemberWorker.RunWorkerCompleted, AddressOf MemberWorker_WorkerCompleted
            If Not MemberWorker.IsBusy Then
                Dim sqldst = New DataSet
                Dim sqlmsda As New SqlDataAdapter("select *,(select councilname from tyronians.dbo.tblcouncil where councilcode=a.councilcode) as councilname,(select chaptername from tyronians.dbo.tblchapter where chaptercode=a.chaptercode) as chaptername from dbo.tblmembers as a where synched=0 ", msconn)
                sqlmsda.Fill(sqldst, "dbo.tblmembers")
                For re = 0 To sqldst.Tables("dbo.tblmembers").Rows.Count - 1
                    With (sqldst.Tables("dbo.tblmembers"))
                        myArgs.memberid = .Rows(re)("memberid").ToString()
                        myArgs.councilcode = .Rows(re)("councilcode").ToString()
                        myArgs.councilname = rchar(.Rows(re)("councilname").ToString())
                        myArgs.chaptercode = .Rows(re)("chaptercode").ToString()
                        myArgs.chaptername = rchar(.Rows(re)("chaptername").ToString())
                        myArgs.fullname = rchar(.Rows(re)("fullname").ToString())
                        myArgs.birthdate = ConvertDate(.Rows(re)("birthdate").ToString())
                        myArgs.gender = .Rows(re)("gender").ToString()
                        myArgs.phonenumber = .Rows(re)("phonenumber").ToString()
                        myArgs.occupation = rchar(.Rows(re)("occupation").ToString())
                        myArgs.datesurvived = ConvertDate(.Rows(re)("datesurvived").ToString())
                        myArgs.baptizedname = rchar(.Rows(re)("baptizedname").ToString())
                        myArgs.recruitername = rchar(.Rows(re)("recruitername").ToString())
                        myArgs.position = rchar(.Rows(re)("position").ToString())
                        myArgs.registeredby = .Rows(re)("registeredby").ToString()
                        myArgs.dateregistered = ConvertDateTime(.Rows(re)("dateregistered").ToString())
                        MemberWorker.RunWorkerAsync(myArgs)
                    End With
                Next
                sqldst.Dispose() : sqlmsda.Dispose()
            End If
        Catch ex As SqlException
            ' RecordLog("SQL ERROR", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            ' RecordLog("WORKER ERROR", ex.Message)
            CheckSMSConnection()
        End Try
    End Sub

    Private Sub MemberWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim args As MemberArgs = e.Argument
        Try
            If CheckMySQLOnline() = True Then
                onCom.CommandText = "DELETE FROM tblmembers where memberid='" & args.memberid & "'" : onCom.ExecuteNonQuery()
                onCom.CommandText = "insert into tblmembers set memberid='" & args.memberid & "', " _
                    + " councilcode='" & args.councilcode & "', " _
                    + " councilname='" & args.councilname & "', " _
                    + " chaptercode='" & args.chaptercode & "', " _
                    + " chaptername='" & args.chaptername & "', " _
                    + " fullname='" & args.fullname & "', " _
                    + " birthdate='" & args.birthdate & "', " _
                    + " gender='" & args.gender & "', " _
                    + " phonenumber='" & args.phonenumber & "', " _
                    + " occupation='" & args.occupation & "', " _
                    + " datesurvived='" & args.datesurvived & "', " _
                    + " baptizedname='" & args.baptizedname & "', " _
                    + " recruitername='" & args.recruitername & "', " _
                    + " position='" & args.position & "', " _
                    + " registeredby='" & args.registeredby & "', " _
                    + " dateregistered='" & args.dateregistered & "'" : onCom.ExecuteNonQuery()
                com.CommandText = "update dbo.tblmembers set synched=1 where memberid='" & args.memberid & "'" : com.ExecuteNonQuery()
            End If

        Catch ex As MySqlException
            'RecordLog("MYSQLDoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As SqlException
            'RecordLog("SQLDoWork", ex.Message)
            CheckSMSConnection()

        Catch ex As Exception
            'RecordLog("DoWork", ex.Message)
            CheckSMSConnection()
        End Try

    End Sub

    Private Sub MemberWorker_WorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        CheckConnection()
    End Sub

End Module
