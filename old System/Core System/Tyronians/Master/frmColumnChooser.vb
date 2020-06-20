Imports System.IO

Public Class frmColumnChooser
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMemberColumnChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_NAME As String = Application.StartupPath.ToString & "\" & txttype.Text
        CheckedListBox1.Items.Clear()
        For Each strresult In txtColumn.Text.Split(New Char() {","c})
            CheckedListBox1.Items.Add(strresult)
        Next
        If System.IO.File.Exists(Application.StartupPath & "\" & txttype.Text) = True Then
            Dim sr As StreamReader = File.OpenText(FILE_NAME)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0
                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        CheckedListBox1.SetItemCheckState(cnt, CheckState.Checked)
                    End If
                    cnt = cnt + 1
                Next
                sr.Close()
            Catch errMS As Exception
                sr.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select atleast 1 column to continue save settings!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CheckedListBox1.Focus()
            Exit Sub
        End If

        Dim strCheckedItem As String = ""
        Dim detail As String = ""
        Dim detailsFile As StreamWriter = Nothing
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) = True Then
                strCheckedItem += 0 & ","
            Else
                strCheckedItem += 1 & ","
            End If

        Next
        If System.IO.File.Exists(Application.StartupPath & "\" & txttype.Text) = True Then
            System.IO.File.Delete(Application.StartupPath & "\" & txttype.Text)
        End If
        detailsFile = New StreamWriter(Application.StartupPath & "\" & txttype.Text, True)

        detail = strCheckedItem.Remove(strCheckedItem.Count - 1, 1)
        detailsFile.WriteLine(EncryptTripleDES(detail))
        detailsFile.Close()

        If txttype.Text = "colmember" Then
            frmGlobalMembers.ViewLocalActiveData()
        ElseIf txttype.Text = "colchapter" Then
            frmGlobalChapterList.ViewLocalData()
        End If

        MessageBox.Show("Selected column successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class