Imports System
Imports System.IO
Imports System.Data.SqlClient

Public Class frmConnectionSetup

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clientserver = ""
        clientuser = ""
        clientpass = ""
        clientdatabase = ""
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtServerhost.Text = "" Then
            MessageBox.Show("Please enter Server host!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerhost.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        clientserver = txtServerhost.Text
        clientuser = txtusername.Text
        clientpass = txtpassword.Text
        clientdatabase = txtDatabase.Text
        Try
            If System.IO.File.Exists(file_conn) = True Then
                System.IO.File.Delete(file_conn)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(file_conn, True)
            detailsFile.WriteLine(EncryptTripleDES(txtServerhost.Text & "|" & txtusername.Text & "|" & txtpassword.Text & "|" & txtDatabase.Text))
            detailsFile.Close()

            MessageBox.Show("System successfully activated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class