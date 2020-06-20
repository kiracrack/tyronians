Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frmGlobalSearch
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SearchOption()
        textsearch.Focus()
    End Sub
    Public Sub SearchOption()
        MyDataGridView.Columns.Clear()
        With MyDataGridView.Columns
            .Add("memberid", "memberid")
            .Add("Fullname", "Fullname")
            .Add("Chapter", "Chapter")
        End With
        MyDataGridView.Columns("memberid").Visible = False
    End Sub
    Public Sub FilterMemberInfo()
        If textsearch.Text = "" Then Exit Sub
        If countqry("tblglobalmembers", "memberid = '" & rchar(textsearch.Text) & "' or " _
                                             + " Fullname like '%" & rchar(textsearch.Text) & "%' or " _
                                             + " (select chaptername from tblglobalchapters where chaptercode = tblglobalmembers.chaptercode) like '%" & rchar(textsearch.Text) & "%'") = 0 Then
            MessageBox.Show("No Record Found! Please try again!" & vbCrLf, _
                                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        dst = New DataSet
        MyDataGridView.Columns.Clear()
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select memberid, " _
                                             + " Fullname as 'Fullname', " _
                                             + " (select chaptername from tblglobalchapters where chaptercode = tblglobalmembers.chaptercode) as 'Chapter' " _
                                             + " From tblglobalmembers where memberid = '" & rchar(textsearch.Text) & "' or " _
                                             + " Fullname like '%" & rchar(textsearch.Text) & "%' or " _
                                             + " (select chaptername from tblglobalchapters where chaptercode = tblglobalmembers.chaptercode) like '%" & rchar(textsearch.Text) & "%' order by Fullname asc;", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, "tblglobalmembers")
        MyDataGridView.DataSource = dst.Tables("tblglobalmembers")
        MyDataGridView.Columns("memberid").Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            If textsearch.Text.Length < 3 Then Exit Sub
            FilterMemberInfo()
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterMemberInfo()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmMembershipProfile.txtmemberid.Text = MyDataGridView.Item("memberid", MyDataGridView.CurrentRow.Index).Value()
        frmMembershipProfile.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("1. Enter by SYSTEM GENERATED ID" & Environment.NewLine & "2. Enter by [Lastname] [Comma] [Space] [Firstname]" & Environment.NewLine & "3. Enter by Chapter Name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub EditProfileInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileInformationToolStripMenuItem.Click
        frmMembershipForm.mode.Text = "edit"
        frmMembershipForm.txtmemberid.Text = MyDataGridView.Item("memberid", MyDataGridView.CurrentRow.Index).Value()
        frmMembershipForm.Show()
    End Sub

    Private Sub VeriyMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VeriyMemberToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to verify this member?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblglobalmembers set verified=1,verifiedby='ADMIN',dateverified=current_timestamp" : com.ExecuteNonQuery()
            MessageBox.Show("Member successfully verified", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrintMemberIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMemberIDToolStripMenuItem.Click
        frmPrintIDOption.memberid.Text = MyDataGridView.Item("memberid", MyDataGridView.CurrentRow.Index).Value()
        frmPrintIDOption.Show(Me)
    End Sub
End Class