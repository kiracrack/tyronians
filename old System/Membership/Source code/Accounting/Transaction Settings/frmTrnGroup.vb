Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTrnGroup
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
            MsgBox("Please enter item name", vbCritical, Me.Text)
            txtItemName.Focus()
            Exit Sub
        ElseIf countqry("tblgltransactiongroup", "groupname='" & rchar(txtItemName.Text) & "'") > 0 And mode.Text <> "edit" Then
            MsgBox("Item Name already exists", vbCritical, Me.Text)
            txtItemName.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "update tblgltransactiongroup set groupname='" & rchar(txtItemName.Text) & "'  where groupcode='" & groupcode.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblgltransactiongroup set groupname='" & rchar(txtItemName.Text) & "' " : com.ExecuteNonQuery()
        End If
        groupcode.Text = "" : txtItemName.Text = "" : mode.Text = "" : txtItemName.Focus()
        FilterItem()
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterItem()
    End Sub
    Public Sub FilterItem()
        Try
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select groupcode as Code, groupname as 'Group Name' from tblgltransactiongroup where groupname like '%" & rchar(txtSearch.Text) & "%' order by groupcode asc", conn)
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
        com.CommandText = "select * from tblgltransactiongroup where groupcode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : rst = com.ExecuteReader
        While rst.Read
            groupcode.Text = rst("groupcode").ToString
            txtItemName.Text = rst("groupname").ToString

        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete selected item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblgltransactiongroup where groupcode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
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
