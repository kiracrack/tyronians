Imports System.Windows.Forms

Public Class MainForm
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Private checkupdate As Boolean = True
#Region "Call Data Reload Function"
    Public Shared reloaddata As New MainForm()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmUserlogoff.ShowDialog()
        If formclose = False Then
            e.Cancel = True
            Exit Sub
        End If
        com.CommandText = "update tbllogin set outtime=CURRENT_TIMESTAMP where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        userexit()
        frmLogin.Show()
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        ConnectVerify()
        txtfullname.Text = globalfullname
        txtChapter.Text = globalchaptername
        txtPosition.Text = globalposition
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
        If globalpermission = 1 Or globalpermission = 0 Then
            ToolStripSeparator4.Visible = True
            cmdAccont.Visible = True
        Else
            ToolStripSeparator4.Visible = False
            cmdAccont.Visible = False
        End If
        customminform()
        PictureBox1.BackgroundImage = frmLogin.loadimage.Image
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub customminform()
        Me.Size = New Size(250, Screen.PrimaryScreen.WorkingArea.Height)
        If LCase(globalusername) = "admin" Then
            Me.MaximumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MinimumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        Else
            Me.MaximumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MinimumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        End If
        Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
    End Sub

    Dim cnt As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
        cnt = cnt + 1
        If checkupdate = True Then
            If cnt = 60 Then
                checkupdate = False
                If qrysingledata("version", "version", "tblsysteminfo") <> Format(fversion, "yy.M.d") Then
                    frmSystemInfo.Show()
                End If
            End If
        End If
        If cnt = 180 Then
            If globalpermission = 0 Then
                cmdAccont.Text = "Accounts Management (" & countqry("tblaccounts", "isrequest=1") & ")"
            End If
            cnt = 0
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChapter.Click
        If frmGlobalChapterList.Visible = False Then
            frmGlobalChapterList.Show(Me)
        Else
            frmGlobalChapterList.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogoff.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccont.Click
        If frmUserAccounts.Visible = False Then
            frmUserAccounts.Show(Me)
        Else
            frmUserAccounts.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles cmdMember.Click
        If frmGlobalMembers.Visible = False Then
            frmGlobalMembers.Show(Me)
        Else
            frmGlobalMembers.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles cmdProfile.Click
        If frmUserProfile.Visible = False Then
            frmUserProfile.Show(Me)
        Else
            frmUserProfile.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If frmGlobalSearch.Visible = False Then
            frmGlobalSearch.Show(Me)
        Else
            frmGlobalSearch.WindowState = FormWindowState.Normal
        End If
    End Sub

    Public Sub resizesignature()
        If loadimage.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(loadimage.Image)
        loadimage.Image = Original

        Dim m As Int32 = 163
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        loadimage.Image = Thumb

        loadimage.Image.Save(Application.StartupPath & "\logo.png")
        If MessageBox.Show("Please close your system to load your new logo! Are you sure you want to quit system?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            End
        End If
    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        ' (max size 163x163 png files)
        If MessageBox.Show("Please use PNG or GIF image file. (Max Resolution 163x163 Pixel size!). Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
                .Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    loadimage.ImageLocation = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try

            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub loadimage_LoadCompleted1(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles loadimage.LoadCompleted
        resizesignature()
    End Sub

    Private Sub mainname_Click(sender As Object, e As EventArgs) Handles mainname.Click
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If globalemail = "" Then
            MessageBox.Show("You cant use service, because you have no registered email address! in order to use this service please add your email address to your profile and try again. thank you", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmSendMessage.Show(Me)
    End Sub
End Class
