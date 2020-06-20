Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmUserProfile
    Dim editPass As Boolean = False
#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmUserProfile()

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
        LoadInformation()
    End Sub

    Private Sub cmdset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        Dim passqry As String = ""
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
        ElseIf txtcontactnumber.Text = "+63" Or txtcontactnumber.Text = "" Then
            MessageBox.Show("Please enter valid contact number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcontactnumber.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MessageBox.Show("Please enter complete complete address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtaddress.Focus()
            Exit Sub
        End If
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
            ElseIf countqry("tblaccounts", "username='" & txtUsername.Text & "'") <> 0 And txtUsername.Text = globalusername Then
                MessageBox.Show("This user is already exists! please review your user list to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                Exit Sub
            End If
            passqry = " username='" & EncryptTripleDES(txtUsername.Text) & "', " _
                                      + " password='" & EncryptTripleDES(txtpassword2.Text) & "',"
        Else
            passqry = ""
        End If
        If countqry("tblaccounts", "fullname='" & txtfullname.Text & "'") <> 0 And txtfullname.Text <> globalfullname Then
            MessageBox.Show("This user is already exists! please review your user list to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfullname.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save this information? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            com.CommandText = "update tblaccounts set fullname='" & rchar(txtfullname.Text) & "', " _
                                          + " position='" & rchar(UCase(txtPosition.Text)) & "', " _
                                          + " address='" & rchar(txtaddress.Text) & "', " _
                                          + " emailadd='" & rchar(txtEmail.Text) & "'," _
                                          + passqry _
                                          + "contactno='" & rchar(txtcontactnumber.Text) & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
            editPass = False
            Me.Cursor = Cursors.Default
            LoadAccountDetails(globaluserid)
            MessageBox.Show("Account successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub
    Public Sub LoadInformation()
        Me.Cursor = Cursors.WaitCursor
        com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblaccounts.chaptercode) as chapter, " _
                                + " (select areaname from tblchapterarea where areacode = tblaccounts.areacode) as area  from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtPosition.Text = rst("position").ToString
            txtaddress.Text = rst("address").ToString
            txtEmail.Text = rst("emailadd").ToString
            txtcontactnumber.Text = rst("contactno").ToString
            txtUsername.Text = DecryptTripleDES(rst("username").ToString)
        End While
        rst.Close()
        Me.Cursor = Cursors.Default
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