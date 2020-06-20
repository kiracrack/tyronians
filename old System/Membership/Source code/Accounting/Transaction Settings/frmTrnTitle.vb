Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTrnTitle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtItemName.Text = "" Then
            MsgBox("Please enter item title", vbCritical, Me.Text)
            txtItemName.Focus()
            Exit Sub
        ElseIf countqry("tblgltransactionheader", "description='" & rchar(txtItemName.Text) & "' and trncode<>'" & trncode.Text & "'") > 0 Then
            MsgBox("Title already exists", vbCritical, Me.Text)
            txtItemName.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "update tblgltransactionheader set  trngroup='" & groupcode.Text & "', description='" & rchar(txtItemName.Text) & "'  where trncode='" & trncode.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblgltransactionheader set trngroup='" & groupcode.Text & "', description='" & rchar(txtItemName.Text) & "' " : com.ExecuteNonQuery()
        End If
        trncode.Text = "" : txtItemName.Text = "" : mode.Text = "" : txtItemName.Focus()
        FilterItem()
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterItem()
    End Sub
    Public Sub FilterItem()
        Try
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select trncode as Code,description as 'Transaction Title' from tblgltransactionheader where trngroup='" & groupcode.Text & "' and description like '%" & rchar(txtSearch.Text) & "%' order by description asc", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
            GridHideColumn(Em, {"Code"})
        Catch errMYSQL As MySqlException
            MessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        com.CommandText = "select * from tblgltransactionheader where trncode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : rst = com.ExecuteReader
        While rst.Read
            trncode.Text = rst("trncode").ToString
            txtItemName.Text = rst("description").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete selected item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblgltransactionheader where trncode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblgltransactionitem where trncode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            FilterItem()
            MessageBox.Show("Item Successfully Deleted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterItem()
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterItem()
    End Sub
End Class
