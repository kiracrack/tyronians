Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports System.Web

Public Class frmSystemDownloader
    Dim filename As String
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

#Region "AUTO UPDATE"
    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        Me.txtFileName.Enabled = True
        If cancelled Then
            Me.Label4.Text = "Cancelled"
            MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExtractSpecificZipFile(Me.txtFileName.Text.Split("/"c)(Me.txtFileName.Text.Split("/"c).Length - 1), txtversion.Text)
        End If
    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
        Me.Label3.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"
        Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"
        If speed = -1 Then
            Me.Label2.Text = "Speed: calculating..."
        Else
            Me.Label2.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If
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
 
End Class