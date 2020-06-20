Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmSendMessage

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtmessage.Text.Count < 10 Then
            MessageBox.Show("Please enter message atleast 10 character long!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmessage.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue send? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            SendTo(0) = globalOfficialEmail
            FileAttach(0) = ""
            strSubject = "Tyronians Management System"
            strMessage = txtmessage.Text + "<br/><br/><br/> <h2>" + globalfullname + "</h2>" + globalposition + "<br/>" + globalemail
            If SendEmailMessage2(globalemail, SendTo(0), strSubject, strMessage, FileAttach) = True Then
                MessageBox.Show("Thank you for using Tyronians Membership Management System! Your message successfully sent. Please check your email address within 24hours and maximum of 2days for your feedback.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
            Me.Cursor = Cursors.WaitCursor
        End If
    End Sub

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class