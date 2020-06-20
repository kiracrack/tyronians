Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient

Public Class frmFieldName

    Private Sub frmFieldName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GlobalSystemName
        ShowList()
    End Sub

    Private Sub txtIDnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemName.KeyPress
        If e.KeyChar = Chr(13) Then
            SaveInfo()
        End If
    End Sub

    Public Sub SaveInfo()
        If txtFieldname.Text = "" Then
            MessageBox.Show("Please select field name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFieldname.Focus()
            Exit Sub
        ElseIf txtItemName.Text = "" Then
            MessageBox.Show("Please enter item name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtItemName.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblfieldname set itemname='" & rchar(txtItemName.Text) & "'  where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblfieldname (fieldname,itemname) values ('" & txtFieldname.Text & "','" & rchar(txtItemName.Text) & "')" : com.ExecuteNonQuery()
        End If
        txtItemName.Text = "" : id.Text = "" : mode.Text = "" : txtItemName.Focus() : ShowList()
        ' MessageBox.Show("Fielname successfuly saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ShowList()
        LoadXgrid("SELECT id, itemname as 'Field Name' FROM tblfieldname where fieldname='" & txtFieldname.Text & "' order by itemname asc;", "tblfieldname", Em, GridView1)
        XgridHideColumn({"id"}, GridView1)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        txtItemName.Text = GridView1.GetFocusedRowCellValue("Field Name").ToString
        mode.Text = "edit"
        txtItemName.Focus()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowList()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to permanently delete selected item? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblfieldname where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            ShowList()
        End If
    End Sub

    Private Sub SendViaTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendViaTextToolStripMenuItem.Click
        Dim details As String = ""
        For I = 0 To GridView1.SelectedRowsCount - 1
            details += GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Field Name").ToString & Environment.NewLine
        Next
        frmGroupSMS.txtContent.Text = txtFieldname.Text & " LIST" & Environment.NewLine & details.Remove(details.Length - 1, 1)
        frmGroupSMS.ShowDialog(Me)
    End Sub
 
    Private Sub txtFieldname_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFieldname.SelectedValueChanged
        ShowList()
    End Sub
End Class
