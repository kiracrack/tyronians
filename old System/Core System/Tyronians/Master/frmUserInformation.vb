Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmUserInformation
    Dim editPass As Boolean = False
#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmUserInformation()

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
    Private Sub frmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadArea()
        LoadChapters()
        If mode.Text = "edit" Then
            LoadInformation()
            cpass.Visible = True
        Else
            txtUsername.ReadOnly = False
            txtpassword1.ReadOnly = False
            txtpassword2.ReadOnly = False
            cpass.Visible = False
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub LoadArea()
        com.CommandText = "select * from tblchapterarea" : rst = com.ExecuteReader()
        txtArea.Items.Clear()
        While rst.Read()
            txtArea.Items.Add(New ComboBoxItem(rst("areaname"), rst("areacode")))
        End While
        rst.Close()
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
            chaptercode.Text = DirectCast(txtchaptername.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            chaptercode.Text = ""
        End If
    End Sub
    Private Sub txtArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.SelectedIndexChanged
        If txtArea.Text <> "" Then
            areacode.Text = DirectCast(txtArea.SelectedItem, ComboBoxItem).HiddenValue()
            LoadChapters()
        Else
            txtArea.Text = ""
        End If
    End Sub

    Private Sub cmdset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        Dim permission As Integer = 2 : Dim passqry As String = ""
        If txtfullname.Text = "" Then
            MessageBox.Show("Please enter fullname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter Position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter email address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MessageBox.Show("Please enter complete complete address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtaddress.Focus()
            Exit Sub
        ElseIf txtcontactnumber.Text = "+63" Or txtcontactnumber.Text = "" Then
            MessageBox.Show("Please enter valid contact number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcontactnumber.Focus()
            Exit Sub
        ElseIf txtchaptername.Text = "" Then
            MessageBox.Show("Please select chapter!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchaptername.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
            MessageBox.Show("Please select Area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" And mode.Text <> "edit" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtpassword1.Text = "" And mode.Text <> "edit" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword1.Focus()
            Exit Sub
        ElseIf txtpassword2.Text = "" And mode.Text <> "edit" Then
            MessageBox.Show("Please enter verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword2.Focus()
            Exit Sub
        ElseIf txtpassword1.Text <> txtpassword2.Text And mode.Text <> "edit" Then
            MessageBox.Show("Please enter password did not match!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword2.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "fullname='" & txtfullname.Text & "'") <> 0 And mode.Text <> "edit" Then
            MessageBox.Show("This user is already exists! please review your user list to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfullname.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "username='" & txtUsername.Text & "'") <> 0 And mode.Text <> "edit" Then
            MessageBox.Show("This user is already exists! please review your user list to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If
        If RadioButton1.Checked = True Then
            permission = 1
        Else
            permission = 2
        End If
        If mode.Text = "edit" Then
            If editPass = True Then
                If txtUsername.Text = "" Then
                    MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtUsername.Focus()
                    Exit Sub
                ElseIf txtpassword1.Text = "" Then
                    MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword1.Focus()
                    Exit Sub
                ElseIf txtpassword2.Text = "" Then
                    MessageBox.Show("Please enter verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword2.Focus()
                    Exit Sub
                ElseIf txtpassword1.Text <> txtpassword2.Text Then
                    MessageBox.Show("Please enter password did not match!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword2.Focus()
                    Exit Sub
                End If
                passqry = " username='" & EncryptTripleDES(txtUsername.Text) & "', " _
                                          + " password='" & EncryptTripleDES(txtpassword2.Text) & "',"
            Else
                passqry = ""
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue save this information? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            If mode.Text = "edit" Then
                If isrequest.Text = "True" Then
                    SendTo(0) = txtEmail.Text
                    FileAttach(0) = ""
                    strSubject = "User Account Confirmation"
                    strMessage = "Your account username " & txtUsername.Text & " successfully activated. you can now use our " & globalOrganizationName & " Management system. thank you<br/><br/><br/> <h2>Administrator</h2>Tyro Gyn Phi Fraternity Philippines<br/>" + globalOfficialEmail
                    If SendEmailMessage2(globalOfficialEmail, SendTo(0), strSubject, strMessage, FileAttach) = True Then
                        Me.Cursor = Cursors.WaitCursor
                        com.CommandText = "update tblaccounts set fullname='" & rchar(txtfullname.Text) & "', " _
                                       + " position='" & rchar(UCase(txtPosition.Text)) & "', " _
                                       + " address='" & rchar(txtaddress.Text) & "', " _
                                       + " contactno='" & rchar(txtcontactnumber.Text) & "', " _
                                       + " emailadd='" & rchar(txtEmail.Text) & "'," _
                                       + passqry _
                                       + " datereg=current_timestamp, " _
                                       + " chaptercode='" & chaptercode.Text & "', " _
                                       + " areacode='" & areacode.Text & "', " _
                                       + " permission='" & permission & "',regby='" & globaluserid & "',status=0,blocklogin=0,isrequest=0 where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
                        Me.Cursor = Cursors.Default
                        editPass = False
                        MessageBox.Show("User successfully saved and updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Else
                    com.CommandText = "update tblaccounts set fullname='" & rchar(txtfullname.Text) & "', " _
                                       + " position='" & rchar(UCase(txtPosition.Text)) & "', " _
                                       + " address='" & rchar(txtaddress.Text) & "', " _
                                       + " contactno='" & rchar(txtcontactnumber.Text) & "', " _
                                       + " emailadd='" & rchar(txtEmail.Text) & "'," _
                                       + passqry _
                                       + " chaptercode='" & chaptercode.Text & "', " _
                                       + " areacode='" & areacode.Text & "', " _
                                       + " permission='" & permission & "',status=0,blocklogin=0,isrequest=0 where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
                    Me.Cursor = Cursors.Default
                    editPass = False
                    MessageBox.Show("User successfully saved and updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Else
                com.CommandText = "insert into tblaccounts set fullname='" & rchar(txtfullname.Text) & "', " _
                                          + " position='" & rchar(UCase(txtPosition.Text)) & "', " _
                                          + " address='" & rchar(txtaddress.Text) & "', " _
                                          + " contactno='" & rchar(txtcontactnumber.Text) & "', " _
                                          + " emailadd='" & rchar(txtEmail.Text) & "'," _
                                          + " username='" & EncryptTripleDES(txtUsername.Text) & "', " _
                                          + " password='" & EncryptTripleDES(txtpassword2.Text) & "', " _
                                          + " datereg=current_timestamp, " _
                                          + " chaptercode='" & chaptercode.Text & "', " _
                                          + " areacode='" & areacode.Text & "', " _
                                          + " permission='" & permission & "',regby='" & globaluserid & "',status=0,isrequest=0" : com.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                editPass = False
                MessageBox.Show("User successfully created!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If

    End Sub
    Public Sub LoadInformation()
        Dim chapter As String = "" : Dim area As String = ""
        com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblaccounts.chaptercode) as chapter, " _
                                + " (select areaname from tblchapterarea where areacode = tblaccounts.areacode) as area  from tblaccounts where accountid='" & userid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtPosition.Text = rst("position").ToString
            txtaddress.Text = rst("address").ToString
            txtcontactnumber.Text = rst("contactno").ToString
            txtEmail.Text = rst("emailadd").ToString
            txtUsername.Text = DecryptTripleDES(rst("username").ToString)

            If rst("permission") = 1 Then
                RadioButton1.Checked = True
            ElseIf rst("permission") = 2 Then
                RadioButton2.Checked = True
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
            End If
            areacode.Text = rst("areacode").ToString
            area = rst("area").ToString

            chaptercode.Text = rst("chaptercode").ToString
            chapter = rst("chapter").ToString
            isrequest.Text = rst("isrequest").ToString
        End While
        rst.Close()
        LoadChapters()
        txtArea.Text = area
        txtchaptername.Text = chapter
    End Sub

    Private Sub cpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpass.Click
        editPass = True
        txtUsername.ReadOnly = False
        txtpassword1.ReadOnly = False
        txtpassword2.ReadOnly = False
    End Sub

   
    Private Sub cmdreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Request account required an Email Address for you to recieved message responds from the Administrator!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class