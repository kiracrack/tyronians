Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmMembershipForm

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmMembershipForm()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMembershipForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        ConnectVerify()
        LoadArea()
        LoadChapters()
        txtbirthdate.Text = Format(Now)
        txtdatesurvived.Text = Format(Now)
        txtCompanyDatePeriod.Text = Format(Now)
        txtEducPeriod.Text = Format(Now)
        If mode.Text = "edit" Then
            ViewInformation()
            cmdGenerate.Visible = False

        ElseIf mode.Text = "view" Then
            ViewInformation()
            cmdGenerate.Visible = False
        Else
            cmdGenerate.Visible = True
        End If
        LoadWorkHistory()
        LoadEducation()
        txtdatesurvived.Parent = tabPersonal
        txtdatesurvived.Parent = tabMembership
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        'Declare a OpenFileDialog object
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Document files (*.*)|*.*"
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
                'Display the file contents in the TextBox
                txtDocPath.Text = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try

        End If

        'Clean up
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Public Sub LoadArea()
        txtareacode.Text = globalareacode
        txtareaname.Text = qrysingledata("areaname", "areaname", "tblchapterarea where areacode='" & globalareacode & "'")
    End Sub

    Public Sub LoadChapters()
        Dim filterqry As String = ""
        If globalpermission = 0 Then
            filterqry = ""

        ElseIf globalpermission = 1 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and (tblaccounts.regby='" & globaluserid & "' or underchapter='" & globalchaptercode & "' or trnby='" & globaluserid & "')"

        ElseIf globalpermission = 2 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and trnby='" & globaluserid & "'"

        End If
        com.CommandText = "select tblglobalchapters.*,tblaccounts.regby from tblglobalchapters inner join tblaccounts on accountid=tblglobalchapters.trnby " & filterqry & " order by chaptername asc" : rst = com.ExecuteReader()
        txtchaptername.Items.Clear()
        While rst.Read()
            txtchaptername.Items.Add(New ComboBoxItem(rst("chaptername"), rst("chaptercode")))
        End While
        rst.Close()
    End Sub

    Private Sub txtchaptername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchaptername.SelectedIndexChanged
        If txtchaptername.Text <> "" Then
            txtchaptercode.Text = DirectCast(txtchaptername.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            txtchaptercode.Text = ""
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtlastname.Text = "" Then
            MessageBox.Show("Please enter Lastname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlastname.Focus()
            Exit Sub
        ElseIf txtfirstname.Text = "" Then
            MessageBox.Show("Please enter Firstname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfirstname.Focus()
            Exit Sub
        ElseIf txtgender.Text = "" Then
            MessageBox.Show("Please enter Gender!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtgender.Focus()
            Exit Sub
        ElseIf txtbirthdate.Text = "" Then
            MessageBox.Show("Please enter Birthdate!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbirthdate.Focus()
            Exit Sub
        ElseIf txtpermanentaddress.Text = "" Then
            MessageBox.Show("Please enter Permanent address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpermanentaddress.Focus()
            Exit Sub
        ElseIf txtcurrentaddress.Text = "" Then
            MessageBox.Show("Please enter Current address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcurrentaddress.Focus()
            Exit Sub
        ElseIf txtspecialskills.Text = "" Then
            MessageBox.Show("Please enter Specialskills!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtspecialskills.Focus()
            Exit Sub
        ElseIf txtmobilenumber.Text = "" Or txtmobilenumber.Text = "+63" Then
            MessageBox.Show("Please enter valid Mobile Number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmobilenumber.Focus()
            Exit Sub
        ElseIf txtchaptername.Text = "" Then
            MessageBox.Show("Please enter Chapter Name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchaptercode.Focus()
            Exit Sub
        ElseIf txtdatesurvived.Text = "" Then
            MessageBox.Show("Please enter valid date survived!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdatesurvived.Focus()
            Exit Sub
        ElseIf txtbaptizedname.Text = "" Then
            MessageBox.Show("Please enter Baptized Name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbaptizedname.Focus()
            Exit Sub
        ElseIf txtmemberid.Text = "" Then
            MessageBox.Show("Please generate membership unique id!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 2
            cmdGenerate.Focus()
            Exit Sub
        ElseIf countqry("tblglobalmembers", "fullname like '%" & txtfullname.Text & "%'") <> 0 And mode.Text <> "edit" Then
            MessageBox.Show("This member is already exists! please review your member list and status to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtchaptername.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save this information? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            If mode.Text = "edit" Then
                com.CommandText = "update tblglobalmembers set " _
                                  + " fullname='" & txtfullname.Text & "', " _
                                  + " lastname='" & txtlastname.Text & "', " _
                                  + " firstname='" & txtfirstname.Text & "', " _
                                  + " middlename='" & txtmiddlename.Text & "', " _
                                  + " gender='" & txtgender.Text & "', " _
                                  + " nickname='" & txtnickname.Text & "', " _
                                  + " birthdate='" & txtbirthdate.Text & "', " _
                                  + " birthplace='" & txtbirthplace.Text & "', " _
                                  + " permanentaddress='" & txtpermanentaddress.Text & "', " _
                                  + " currentaddress='" & txtcurrentaddress.Text & "', " _
                                  + " specialskills='" & txtspecialskills.Text & "', " _
                                  + " mobilenumber='" & txtmobilenumber.Text & "', " _
                                  + " homenumber='" & txthomenumber.Text & "', " _
                                  + " emailadd='" & txtemailadd.Text & "', " _
                                  + " incase_contactname='" & txtincase_contactname.Text & "', " _
                                  + " incase_contact='" & txtincase_contact.Text & "', " _
                                  + " incase_address='" & txtincase_address.Text & "', " _
                                  + " areacode='" & txtareacode.Text & "', " _
                                  + " chaptercode='" & txtchaptercode.Text & "', " _
                                  + " baptizedname='" & txtbaptizedname.Text & "', " _
                                  + " datesurvived='" & txtdatesurvived.Text & "', " _
                                  + " rituals='" & txtrituals.CheckState & "', " _
                                  + " idcard='" & txtidcard.CheckState & "', " _
                                  + " dateedited=current_timestamp, " _
                                  + " editedby='" & globaluserid & "' " _
                                  + " where memberid='" & txtmemberid.Text & "';" : com.ExecuteNonQuery()
                If proFileImg = True Then
                    UpdateImage("memberid='" & txtmemberid.Text & "'", "profileimg", "tblglobalmembers", picProfile)
                Else
                    com.CommandText = "update tblglobalmembers set profileimg=null where memberid='" & txtmemberid.Text & "'" : com.ExecuteNonQuery()
                End If
                UpdateCompany()
                UpdateEducation()
                Me.Cursor = Cursors.Default
                MessageBox.Show("Member " & StrConv(txtfullname.Text, vbProperCase) & " successfully saved and updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "INSERT INTO tblglobalmembers set  " _
                                  + " memberid='" & txtmemberid.Text & "'," _
                                  + " fullname='" & txtfullname.Text & "', " _
                                  + " lastname='" & txtlastname.Text & "', " _
                                  + " firstname='" & txtfirstname.Text & "', " _
                                  + " middlename='" & txtmiddlename.Text & "', " _
                                  + " gender='" & txtgender.Text & "', " _
                                  + " nickname='" & txtnickname.Text & "', " _
                                  + " birthdate='" & txtbirthdate.Text & "', " _
                                  + " birthplace='" & txtbirthplace.Text & "', " _
                                  + " permanentaddress='" & txtpermanentaddress.Text & "', " _
                                  + " currentaddress='" & txtcurrentaddress.Text & "', " _
                                  + " specialskills='" & txtspecialskills.Text & "', " _
                                  + " mobilenumber='" & txtmobilenumber.Text & "', " _
                                  + " homenumber='" & txthomenumber.Text & "', " _
                                  + " emailadd='" & txtemailadd.Text & "', " _
                                  + " incase_contactname='" & txtincase_contactname.Text & "', " _
                                  + " incase_contact='" & txtincase_contact.Text & "', " _
                                  + " incase_address='" & txtincase_address.Text & "', " _
                                  + " areacode='" & txtareacode.Text & "', " _
                                  + " chaptercode='" & txtchaptercode.Text & "', " _
                                  + " baptizedname='" & txtbaptizedname.Text & "', " _
                                  + " datesurvived='" & txtdatesurvived.Text & "', " _
                                  + " rituals='" & txtrituals.CheckState & "', " _
                                  + " idcard='" & txtidcard.CheckState & "', " _
                                  + " registeredby='" & globaluserid & "', " _
                                  + " dateregistered=current_timestamp;" : com.ExecuteNonQuery()
                If proFileImg = True Then
                    UpdateImage("memberid='" & txtmemberid.Text & "'", "profileimg", "tblglobalmembers", picProfile)
                Else
                    com.CommandText = "update tblglobalmembers set profileimg=null where memberid='" & txtmemberid.Text & "'" : com.ExecuteNonQuery()
                End If
                UpdateCompany()
                UpdateEducation()
                Me.Cursor = Cursors.Default
                MessageBox.Show("Member " & StrConv(txtfullname.Text, vbProperCase) & " successfully registered to our system!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Public Sub ViewInformation()
        com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblglobalmembers.chaptercode) as chapter, " _
                                + " (select areaname from tblchapterarea where areacode = tblglobalmembers.areacode) as area from tblglobalmembers  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtlastname.Text = rst("lastname").ToString
            txtfirstname.Text = rst("firstname").ToString
            txtmiddlename.Text = rst("middlename").ToString
            txtgender.Text = rst("gender").ToString
            txtnickname.Text = rst("nickname").ToString
            txtbirthdate.Text = rst("birthdate").ToString
            txtbirthplace.Text = rst("birthplace").ToString
            txtpermanentaddress.Text = rst("permanentaddress").ToString
            txtcurrentaddress.Text = rst("currentaddress").ToString
            txtspecialskills.Text = rst("specialskills").ToString
            txtmobilenumber.Text = rst("mobilenumber").ToString
            txthomenumber.Text = rst("homenumber").ToString
            txtemailadd.Text = rst("emailadd").ToString
            txtincase_contactname.Text = rst("incase_contactname").ToString
            txtincase_contact.Text = rst("incase_contact").ToString
            txtincase_address.Text = rst("incase_address").ToString

            
            txtbaptizedname.Text = rst("baptizedname").ToString
            txtdatesurvived.Value = rst("datesurvived").ToString

            txtrituals.Checked = rst("rituals")
            txtidcard.Checked = rst("idcard")

            txtchaptercode.Text = rst("chaptercode").ToString
            txtchaptername.Text = rst("chapter").ToString
            txtareaname.Text = rst("area").ToString
            txtareacode.Text = rst("areacode").ToString

            ShowImage("profileimg", picProfile)
        End While
        rst.Close()
    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged, txtfirstname.TextChanged, txtmiddlename.TextChanged
        If txtmiddlename.Text = "" Then
            txtfullname.Text = txtlastname.Text + ", " & txtfirstname.Text
        Else
            txtfullname.Text = txtlastname.Text + ", " & txtfirstname.Text + " " + txtmiddlename.Text
        End If
    End Sub

    Private Sub txtmemberid_TextChanged(sender As Object, e As EventArgs) Handles txtmemberid.TextChanged
        If txtmemberid.Text = "" Then
            txtmemberid.BackColor = DefaultBackColor
        Else
            txtmemberid.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If txtfirstname.Text <> "" And txtlastname.Text <> "" And txtchaptername.Text <> "" And txtdatesurvived.Text <> "" Then
            txtmemberid.Text = createMemberID(txtfullname.Text, txtchaptername.Text, txtdatesurvived.Text)
        Else
            MessageBox.Show("Please fill up the required fields to generate membership id", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Membership unique ID is a identification of a member globally. use this as id number of ID CARD or verification of a member if he/she already registered in our system!" & Environment.NewLine & Environment.NewLine _
                            + "The Combination of Unique id, Explanation and Example: ""AB1987-0101Z-100000001""" & Environment.NewLine & Environment.NewLine _
                            + """AB"" - is combination of your Family Name and First Name" & Environment.NewLine _
                            + """1987"" - Year of Date Survived" & Environment.NewLine _
                            + """0101Z"" - Month and Day of Date Survived and First Character of Chapter" & Environment.NewLine _
                            + """100000001"" - Sequence number of registered Members World Wide", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("Sorry this service is currently not available!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MessageBox.Show("Upload Membership waiver or important document of a member! Limit Size 5MB only", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "MEMBERSHIP COMPANY"
    Public Sub LoadWorkHistory()
        With gridWork
            .Columns.Clear()
            .Columns.Add("Company Name", "Company Name")
            .Columns.Add("Position", "Position")
            .Columns.Add("Date Period", "Date Period")
            .Columns.Add("Current Company", "Current Company")
        End With
        If countqry("tblmemberswork", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridWork.Rows.Clear()
            com.CommandText = "select  *,date_format(timeperiod,'%Y-%m-%d') as dt,case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberswork  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridWork
                    .Rows.Add(rst("companyname").ToString, rst("Position").ToString, rst("dt").ToString, rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridWork, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current Company", gridWork, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

    Private Sub cmdWorkSave_Click(sender As Object, e As EventArgs) Handles cmdWorkSave.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter company name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        End If
        For i = 0 To gridWork.Rows.Count - 1
            If gridWork.Item("Company Name", i).Value = txtCompanyName.Text Then
                MessageBox.Show("Company Name already exists!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            End If
        Next
        With gridWork
            Dim current As String = ""
            If txtCompanyCurrent.Checked = True Then
                current = "YES"
            Else
                current = "NO"
            End If
            .Rows.Add(txtCompanyName.Text, txtPosition.Text, txtCompanyDatePeriod.Text, current)
            txtCompanyName.Text = ""
            txtPosition.Text = ""
            txtCompanyDatePeriod.Text = Format(Now)
            txtCompanyCurrent.Checked = False
        End With
    End Sub
    Private Sub RemoveCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCompanyToolStripMenuItem.Click
        gridWork.Rows.Remove(gridWork.CurrentRow)
    End Sub
    Public Sub UpdateCompany()
        com.CommandText = "delete from tblmemberswork where memberid='" & txtmemberid.Text & "'" : com.ExecuteNonQuery()
        For i = 0 To gridWork.Rows.Count - 1
            Dim current As Integer = 0
            If gridWork.Item("Current Company", i).Value = "YES" Then
                current = 1
            Else
                current = 0
            End If
            com.CommandText = "insert into tblmemberswork set " _
                                    + " memberid='" & txtmemberid.Text & "', " _
                                    + " companyname='" & rchar(gridWork.Item("Company Name", i).Value) & "', " _
                                    + " position='" & rchar(gridWork.Item("Position", i).Value) & "', " _
                                    + " timeperiod='" & rchar(gridWork.Item("Date Period", i).Value) & "', " _
                                    + " iscurrent='" & current & "'" : com.ExecuteNonQuery()
        Next
    End Sub
#End Region

#Region "MEMBERSHIP EDUCATION"
    Public Sub LoadEducation()
        With gridEducation
            .Columns.Clear()
            .Columns.Add("School Name", "School Name")
            .Columns.Add("Level", "Level")
            .Columns.Add("Details", "Details")
            .Columns.Add("Date Period", "Date Period")
            .Columns.Add("Current School", "Current School")
        End With
        If countqry("tblmemberseduc", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridEducation.Rows.Clear()
            com.CommandText = "select  *,date_format(timeperiod,'%Y-%m-%d') as dt,case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberseduc  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridEducation
                    .Rows.Add(rst("schoolname").ToString, rst("schoollevel").ToString, rst("details").ToString, rst("dt").ToString, rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridEducation, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current School", gridEducation, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

    Private Sub cndEduSave_Click(sender As Object, e As EventArgs) Handles cndEduSave.Click
        If txtSchoolname.Text = "" Then
            MessageBox.Show("Please enter school name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolname.Focus()
            Exit Sub
        ElseIf txtSchoolLevel.Text = "" Then
            MessageBox.Show("Please enter school level!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolLevel.Focus()
            Exit Sub
        ElseIf txtEducPeriod.Text = "" Then
            MessageBox.Show("Please enter date period!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEducPeriod.Focus()
            Exit Sub
        End If
        For i = 0 To gridEducation.Rows.Count - 1
            If gridEducation.Item("School Name", i).Value = txtSchoolname.Text Then
                MessageBox.Show("School Name already exists!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSchoolname.Focus()
                Exit Sub
            End If
        Next
        With gridEducation
            Dim current As String = ""
            If txtEducCurrent.Checked = True Then
                current = "YES"
            Else
                current = "NO"
            End If
            .Rows.Add(txtSchoolname.Text, txtSchoolLevel.Text, txtSchoolDetails.Text, txtEducPeriod.Text, current)
            txtSchoolname.Text = ""
            txtSchoolLevel.SelectedIndex = -1
            txtSchoolDetails.Text = ""
            txtEducPeriod.Text = Format(Now)
            txtEducCurrent.Checked = False
            txtSchoolname.Focus()
        End With
    End Sub
    Private Sub ContextMenuEducation_Click(sender As Object, e As EventArgs) Handles ContextMenuEducation.Click
        gridEducation.Rows.Remove(gridEducation.CurrentRow)
    End Sub
    Public Sub UpdateEducation()
        com.CommandText = "delete from tblmemberseduc where memberid='" & txtmemberid.Text & "'" : com.ExecuteNonQuery()
        For i = 0 To gridEducation.Rows.Count - 1
            Dim current As Integer = 0
            If gridEducation.Item("Current School", i).Value = "YES" Then
                current = 1
            Else
                current = 0
            End If
            com.CommandText = "insert into tblmemberseduc set " _
                                    + " memberid='" & txtmemberid.Text & "', " _
                                    + " schoolname='" & rchar(gridEducation.Item("School Name", i).Value) & "', " _
                                    + " schoollevel='" & rchar(gridEducation.Item("Level", i).Value) & "', " _
                                    + " details='" & rchar(gridEducation.Item("Details", i).Value) & "', " _
                                    + " timeperiod='" & rchar(gridEducation.Item("Date Period", i).Value) & "', " _
                                    + " iscurrent='" & current & "'" : com.ExecuteNonQuery()
        Next
    End Sub
#End Region


    Public Sub resizesignature()
        If picProfile.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(picProfile.Image)
        picProfile.Image = Original

        Dim m As Int32 = 177
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        picProfile.Image = Thumb
    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        'Declare a OpenFileDialog object
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
            .Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All files (*.*)|*.*"
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
                'Display the file contents in the TextBox
                picProfile.ImageLocation = objOpenFileDialog.FileName
                proFileImg = True
            Catch fileException As Exception
                Throw fileException
            End Try

        End If

        'Clean up
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Sub picProfile_LoadCompleted(sender As Object, e As ComponentModel.AsyncCompletedEventArgs) Handles picProfile.LoadCompleted
        resizesignature()
    End Sub

    Private Sub RemovePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePictureToolStripMenuItem.Click
        Me.picProfile.Image = Global.Tyronians.My.Resources.Resources.blankimg
        proFileImg = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Right click on the picture to display control menu", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class