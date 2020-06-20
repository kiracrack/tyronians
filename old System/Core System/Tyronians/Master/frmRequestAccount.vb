Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmRequestAccount

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmRequestAccount()

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
    Private Sub cmdset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        Dim permission As Integer = 2
        If txtfullname.Text = "" Then
            MessageBox.Show("Please enter fullname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter Position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
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
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter email address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
            MessageBox.Show("Please select Area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtUsername.Text.Count < 6 Then
            MessageBox.Show("Please enter username atleast 6 character long!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtpassword1.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword1.Focus()
            Exit Sub
        ElseIf txtpassword1.Text.Count < 7 Then
            MessageBox.Show("Please enter password atleast 7 character long!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        ElseIf txtMessage.Text = "" Then
            MessageBox.Show("Please your message!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMessage.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "fullname='" & rchar(txtfullname.Text) & "'") <> 0 Then
            MessageBox.Show("Your account is already registered! please contact your administrator at Email Add: " & globalOfficialEmail, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfullname.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "username='" & rchar(txtUsername.Text) & "'") <> 0 Then
            MessageBox.Show("This username is already registered! please contact your administrator at Email Add: " & globalOfficialEmail, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue send your request? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If txtEmail.Text <> "" Then
                Me.Cursor = Cursors.WaitCursor
                SendTo(0) = globalOfficialEmail
                FileAttach(0) = ""
                strSubject = "Request User Account "
                strMessage = txtMessage.Text + "<br/><br/><br/> <h2>" + txtfullname.Text + "</h2>" + txtPosition.Text + "<br/>" + txtEmail.Text
                If SendEmailMessage2(txtEmail.Text, SendTo(0), strSubject, strMessage, FileAttach) = True Then
                    com.CommandText = "insert into tblaccounts set " _
                                    + " fullname='" & rchar(txtfullname.Text) & "', " _
                                    + " position='" & rchar(txtPosition.Text) & "', " _
                                    + " address='" & rchar(txtaddress.Text) & "', " _
                                    + " contactno='" & rchar(txtcontactnumber.Text) & "', " _
                                    + " username='" & EncryptTripleDES(txtUsername.Text) & "', " _
                                    + " password='" & EncryptTripleDES(txtpassword2.Text) & "', " _
                                    + " daterequest=current_timestamp, " _
                                    + " chaptercode='" & rchar(txtchaptername.Text) & "', " _
                                    + " areacode='" & rchar(txtArea.Text) & "', " _
                                    + " emailadd='" & rchar(txtEmail.Text) & "'," _
                                    + " requestremarks='" & rchar(txtMessage.Text) & "'," _
                                    + " blocklogin=1, " _
                                    + " permission='2', isrequest=1" : com.ExecuteNonQuery()
                    MessageBox.Show("Thank you for using Tyronians Membership Management System! Your request successfully sent. Please check your email address within 24hours and maximum of 2days for your account activation.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Request account required an Email Address for you to recieved acivation responds from the Administrator!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("Enter your complete Chapter Name for chapter activation!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmRequestAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        ConnectVerify()
        Me.Cursor = Cursors.Default
    End Sub
End Class