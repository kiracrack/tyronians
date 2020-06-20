Imports System.Windows.Forms

Public Class frmLocalChapter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
       If txtChapter.Text = "" Then
            MsgBox("Please enter chapter name!", MsgBoxStyle.Exclamation)
            txtChapter.Focus()
            Exit Sub
        ElseIf countqry("tbllocalchapter", "chaptername='" & Trim(rchar(UCase(txtChapter.Text))) & "' and  chaptercode='" & chaptercode.Text & "'") > 0 Then
            MsgBox("Chapter already exists!", MsgBoxStyle.Exclamation)
            txtChapter.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save this chapter? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ConnectVerify() = True Then
                com.CommandText = "insert into tbllocalchapter set chaptercode='" & chaptercode.Text & "', chaptername='" & Trim(rchar(UCase(txtChapter.Text))) & "'" : com.ExecuteNonQuery()
                frmMembershipForm.LoadLocalChapter()
                frmMembershipForm.txtchaptername.Text = Trim(rchar(UCase(txtChapter.Text)))
                txtChapter.Text = "" : txtChapter.Focus()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
 

End Class
