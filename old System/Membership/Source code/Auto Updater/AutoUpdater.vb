Imports System.IO

Module AutoUpdater
    Dim detailsFile As StreamWriter = Nothing
    Public provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public FileProperties As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public fversion As String = FileProperties.FileVersion.ToString.Remove(FileProperties.FileVersion.ToString.Length - 2, 2)
    Public dversion As Date = Date.ParseExact(fversion, "yy.M.d", provider)
    Public GlobalApplicationName As String = "Tyronians Central"
    Public file_downloaded As String = Application.StartupPath.ToString & "\UpdateVersion\"
    Public Function AvailableNewUpdate() As Boolean
        com.CommandText = "select *, date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') as dt from tblclientsystemupdate where active=1 and server=0" : rst = com.ExecuteReader
        If rst.Read Then
            If dversion < CDate(rst("dt").ToString) Then
                If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                    MessageBox.Show("There are another system instance running, make sure all system system are completely closed then try again.", "Update error occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End
                End If
                frmWelcomeMessage.txtFileName.Text = rst("downloadurl").ToString
                frmWelcomeMessage.txtversion.Text = rst("version").ToString
                AvailableNewUpdate = True
            Else
                AvailableNewUpdate = False
            End If
        Else
            AvailableNewUpdate = False
        End If
        rst.Close()
    End Function
    Public Function ExtractSpecificZipFile(ByVal UpdateFileName As String, ByVal version As String) As Boolean
        Dim Download_location As String = Application.StartupPath.ToString & "\UpdateVersion\" & UpdateFileName
        Dim Extract_location As String = System.IO.Path.GetTempPath() & "SystemUpdater"
        Try
            If (System.IO.Directory.Exists(Extract_location)) Then
                My.Computer.FileSystem.DeleteDirectory(Extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(Extract_location)) Then
                System.IO.Directory.CreateDirectory(Extract_location)
            End If

            Dim unzip As New ICSharpCode.SharpZipLib.Zip.FastZip
            unzip.ExtractZip(Download_location, Extract_location, Nothing)

            If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\SystemUpdater.bat") = True Then
                System.IO.File.Delete(System.IO.Path.GetTempPath() & "\SystemUpdater.bat")
            End If

            Dim xstring As String = ""
            Dim addtimeout As String = "" : Dim xcopy As String = ""
            If Get_os_name() <> "Windows XP" Then
                addtimeout = "timeout 5" & Environment.NewLine
                xcopy = "xcopy /s """ & Extract_location & "\*.*"" """ & Application.StartupPath.ToString & "\"" /b/v/y/r/j"
            Else
                addtimeout = "ping -w 5000 -n 1 1.1.1.1" & Environment.NewLine
                xcopy = "xcopy /s """ & Extract_location & "\*.*"" """ & Application.StartupPath.ToString & "\"" /v/y/r"
            End If
            detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\SystemUpdater.bat", True)
            xstring = "@echo off" & Environment.NewLine _
                    + "color c" & Environment.NewLine _
                    + "@echo Updating Coffeecup Client v" & version & " in 5 seconds.." & Environment.NewLine _
                    + addtimeout _
                    + xcopy & Environment.NewLine _
                    + "echo msgbox ""Your system successfully updated!"" > %tmp%\tmp.vbs" & Environment.NewLine _
                    + "cscript /nologo %tmp%\tmp.vbs" & Environment.NewLine _
                    + "del %tmp%\tmp.vbs" & Environment.NewLine _
                    + """" & Application.ExecutablePath & """" & Environment.NewLine _
                    + "exit" & Environment.NewLine

            detailsFile.WriteLine(xstring)
            detailsFile.Close()
            Process.Start(System.IO.Path.GetTempPath() & "\SystemUpdater.bat")
            End
            Return (True)
        Catch ex As Exception
            MessageBox.Show("Message:" & ex.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
            Return False
        End Try

    End Function
#Region "GET OS NAME"
    Dim Full_Os_Name As String = My.Computer.Info.OSFullName
    Public Function Get_os_name() As String
        Get_os_name = ""
        If Full_Os_Name.Contains("Windows 7") Then
            Get_os_name = "Windows 7"
        ElseIf Full_Os_Name.Contains("Windows Vista") Then
            Get_os_name = "Windows Vista"
        ElseIf Full_Os_Name.Contains("Windows XP") Then
            Get_os_name = "Windows XP"
        Else
            Get_os_name = Full_Os_Name.ToString()
        End If
        Return Get_os_name
    End Function
#End Region
End Module
