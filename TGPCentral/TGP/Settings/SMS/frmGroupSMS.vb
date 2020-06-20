Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient

Public Class frmGroupSMS

    Private Sub frmMessageBox_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContacts()
    End Sub

    Public Sub LoadContacts()
        ls.Items.Clear()
        com.CommandText = "select * from tbluseraccounts " : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add(rst("id").ToString, False)
            ls.Items.Item(rst("id").ToString).Description = rst("username").ToString
            ls.Items.Item(rst("id").ToString).Value = rst("id").ToString
        End While
        rst.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For n = 0 To ls.ItemCount - 1
            If CheckEdit1.Checked = True Then
                ls.Items.Item(n).CheckState = CheckState.Checked
            Else
                ls.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
        If ls.CheckedItems.Count = 0 Then
            cmdOK.Enabled = False
        Else
            cmdOK.Enabled = True
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If MessageBox.Show("Are you sure you want to continue this action?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For n = 0 To ls.CheckedItems.Count - 1
                SendIndividualMessage(ls.Items.Item(ls.CheckedItems.Item(n)).Value, txtContent.Text, ckEncrypted.CheckState)
            Next
            MessageBox.Show("Message successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ls_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles ls.ItemCheck
        If ls.CheckedItems.Count = 0 Then
            cmdOK.Enabled = False
        Else
            cmdOK.Enabled = True
        End If
    End Sub
End Class
