Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient

Public Class frmCouncil

    Private Sub frmMunicipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GlobalSystemName
        ShowList()
    End Sub

    Private Sub txtIDnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCouncilName.KeyPress
        If e.KeyChar = Chr(13) Then
            SaveInfo()
        End If
    End Sub

    Public Sub SaveInfo()
        If txtCouncilName.Text = "" Then
            MessageBox.Show("Please enter council name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCouncilName.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblcouncil set councilname='" & rchar(txtCouncilName.Text) & "'  where councilcode='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcouncil (councilname,currentseries) values ('" & rchar(txtCouncilName.Text) & "','000')" : com.ExecuteNonQuery()
        End If
        txtCouncilName.Text = "" : id.Text = "" : mode.Text = "" : txtCouncilName.Focus() : ShowList()
    End Sub

    Public Sub ShowList()
        LoadXgrid("SELECT councilcode as 'Code', councilname as 'Council Name' FROM tblcouncil order by councilname asc;", "tblcouncil", Em, GridView1)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 50)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        txtCouncilName.Text = GridView1.GetFocusedRowCellValue("Council Name").ToString
        mode.Text = "edit"
        txtCouncilName.Focus()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowList()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to permanently delete selected item? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblcouncil where councilcode='" & GridView1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            ShowList()
        End If
    End Sub
   
    Private Sub SendViaTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendViaTextToolStripMenuItem.Click
        Dim details As String = ""
        For I = 0 To GridView1.SelectedRowsCount - 1
            details += GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Code").ToString & "," & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Council Name").ToString & Environment.NewLine
        Next
        frmGroupSMS.txtContent.Text = "COUNCIL MASTER LIST" & Environment.NewLine & details.Remove(details.Length - 1, 1)
        frmGroupSMS.ShowDialog(Me)
    End Sub
End Class
