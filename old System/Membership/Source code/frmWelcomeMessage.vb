Imports System.Windows.Forms
Imports System.Net

Public Class frmWelcomeMessage
    Dim filename As String
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmWelcomeMessage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        conn.Close()
    End Sub

    Private Sub frmWelcomeMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConnectVerify() Then
            SystemUpdateChecker()
            If AvailableNewUpdate() = True Then
                cmdSearch.Text = "Download Update"
                cmdRegister.Visible = False
                lblVersion.Text = "New Update Available v" & txtversion.Text
                lblVersion.ForeColor = Color.Green
            Else
                lblVersion.Text = "Application Version " & fversion
                cmdSearch.Text = "SEARCH GLOBAL MEMBERS"
                cmdRegister.Visible = True
            End If
        Else
            MessageBox.Show("Cannot Connect to database sever " & sqlserver & "! Please try again later", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If cmdSearch.Text = "Download Update" Then
            cmdSearch.Text = "Downloading.."
            cmdSearch.Enabled = False
            com.CommandText = "update tblclientsystemupdate set downloadhit=downloadhit+1 where version='" & txtversion.Text & "' and server=0" : com.ExecuteNonQuery()
            Timer1.Enabled = True
            ProgressBar1.Visible = True
        Else
            frmGlobalSearch.Show()
        End If
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        frmMembershipForm.Show()
    End Sub

#Region "AUTO UPDATE"
    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        Me.txtFileName.Enabled = True
        If cancelled Then
            MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExtractSpecificZipFile(Me.txtFileName.Text.Split("/"c)(Me.txtFileName.Text.Split("/"c).Length - 1), txtversion.Text)
        End If
    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
        Me.cmdSearch.Text = "Downloading.. " & Me.ProgressBar1.Value & "%"
        Me.ProgressBar1.Value = percent
    End Sub

    Public Sub StartDownload()
        filename = file_downloaded & Me.txtFileName.Text.Split("/"c)(Me.txtFileName.Text.Split("/"c).Length - 1)
        txtDownloadLocation.Text = filename
        Me.BackgroundWorker1.RunWorkerAsync() 'Start download
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist
            theRequest = WebRequest.Create(Me.txtFileName.Text)
            theResponse = theRequest.GetResponse
        Catch ex As Exception
            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)
        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0) 'Invoke the TreadsafeDelegate
        Dim writeStream As New IO.FileStream(txtDownloadLocation.Text, IO.FileMode.Create)
        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Integer
        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do
            If BackgroundWorker1.CancellationPending Then 'If user abort download
                Exit Do
            End If
            speedtimer.Start()
            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
            nRead += bytesread
            'MsgBox(nRead &  "" &  length)
            Dim percent As Short = (nRead * 100) / length
            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)
            If bytesread = 0 Then Exit Do
            writeStream.Write(readBytes, 0, bytesread)
            speedtimer.Stop()
            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker1.CancellationPending Then
            IO.File.Delete(txtDownloadLocation.Text)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
        Me.Invoke(completeDelegate, False)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() : Timer1.Enabled = False
        StartDownload()
    End Sub
#End Region

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        frmLicenseAgreement.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Accounting.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmBatchCollection.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmCollectionReports.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
