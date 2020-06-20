Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmChapter

    Private Sub frmSystemSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSystemSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GlobalSystemName
        LoadCouncil()
        LoadChapter()
    End Sub

    Public Sub LoadCouncil()
        LoadToComboBoxDB("select * from tblcouncil order by councilname asc", "councilname", "councilcode", txtCouncil)
    End Sub

    Private Sub txtCouncil_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCouncil.SelectedValueChanged
        If txtCouncil.Text <> "" Then
            councilcode.Text = DirectCast(txtCouncil.SelectedItem, ComboBoxItem).HiddenValue()
            LoadChapter()
        Else
            councilcode.Text = ""
        End If
    End Sub

    Private Sub txtIDnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChapterName.KeyPress
        If e.KeyChar = Chr(13) Then
            SaveAreaInfo()
        End If
    End Sub

    Public Sub SaveAreaInfo()
        If txtChapterName.Text = "" Then
            MessageBox.Show("Please enter area name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapterName.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblchapter set chaptername='" & rchar(txtChapterName.Text) & "'  where chaptercode='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblchapter (councilcode,chaptername) Values('" & councilcode.Text & "','" & rchar(txtChapterName.Text) & "')" : com.ExecuteNonQuery()
        End If
        txtChapterName.Text = "" : id.Text = "" : mode.Text = "" : txtChapterName.Focus() : LoadChapter()
    End Sub

    Public Sub LoadChapter()
        LoadXgrid("SELECT  chaptercode as 'Code', chaptername as 'Chapter Name' FROM tblchapter where councilcode='" & councilcode.Text & "' order by chaptername asc;", "tblchapter", Em, GridView1)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 50)
    End Sub

    Private Sub lblClass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClass.LinkClicked
        frmCouncil.ShowDialog(Me)
        LoadCouncil()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        txtChapterName.Text = GridView1.GetFocusedRowCellValue("Chapter Name").ToString
        mode.Text = "edit"
        txtChapterName.Focus()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to permanently delete selected item? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblchapter where chaptercode='" & GridView1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            LoadChapter()
        End If
    End Sub

    Private Sub SendViaTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendViaTextToolStripMenuItem.Click
        Dim details As String = ""
        For I = 0 To GridView1.SelectedRowsCount - 1
            details += councilcode.Text & "," & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "," & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Chapter Name").ToString & Environment.NewLine
        Next
        frmGroupSMS.txtContent.Text = "CHAPTER MASTER LIST" & Environment.NewLine & details.Remove(details.Length - 1, 1)
        frmGroupSMS.ShowDialog(Me)
    End Sub
End Class
