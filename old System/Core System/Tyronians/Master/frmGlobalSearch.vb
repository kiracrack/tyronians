Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmGlobalSearch
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        SearchOption()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        SearchOption()
    End Sub
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SearchOption()
        textsearch.Focus()
    End Sub
    Public Sub SearchOption()
        MyDataGridView.Columns.Clear()
        If RadioButton1.Checked = True Then
            With MyDataGridView.Columns
                .Add("memberid", "memberid")
                .Add("Fullname", "Fullname")
                .Add("Chapter", "Chapter")
            End With
            MyDataGridView.Columns("memberid").Visible = False
        Else
            With MyDataGridView.Columns
                .Add("chaptercode", "chaptercode")
                .Add("Chapter", "Chapter")
                .Add("Area", "Area")
            End With
            MyDataGridView.Columns("chaptercode").Visible = False
        End If

    End Sub
    Public Sub FilterMemberInfo()
        If textsearch.Text = "" Then Exit Sub
        If countqry("tblglobalmembers", " Fullname like '%" & rchar(textsearch.Text) & "%'") = 0 Then
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
                                             + " From tblglobalmembers where Fullname like '%" & rchar(textsearch.Text) & "%' and isactive=1 order by Fullname asc;", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, "tblglobalmembers")
        MyDataGridView.DataSource = dst.Tables("tblglobalmembers")
        MyDataGridView.Columns("memberid").Visible = False
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub FilterChapterInfo()
        If textsearch.Text = "" Then Exit Sub
        If countqry("tblglobalchapters", " chaptername like '%" & rchar(textsearch.Text) & "%'") = 0 Then
            MessageBox.Show("No Record Found! Please try again!" & vbCrLf, _
                                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        dst = New DataSet
        MyDataGridView.Columns.Clear()
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select chaptercode, " _
                                             + " chaptername as 'Chapter', " _
                                             + " (select areaname from tblchapterarea where areacode = tblglobalchapters.areacode) as 'Area' " _
                                             + " From tblglobalchapters where chaptername like '%" & rchar(textsearch.Text) & "%'  order by chaptername asc;", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, "tblglobalchapters")
        MyDataGridView.DataSource = dst.Tables("tblglobalchapters")
        MyDataGridView.Columns("chaptercode").Visible = False
        Me.Cursor = Cursors.Default
    End Sub
       Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            If textsearch.Text.Count < 3 Then Exit Sub
            If RadioButton1.Checked = True Then
                FilterMemberInfo()
            Else
                FilterChapterInfo()
            End If
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If RadioButton1.Checked = True Then
            FilterMemberInfo()
        Else
            FilterChapterInfo()
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        If RadioButton1.Checked = True Then
            frmMemberProfile.txtmemberid.Text = MyDataGridView.Item("memberid", MyDataGridView.CurrentRow.Index).Value()
            frmMemberProfile.Show(Me)
        Else
            frmChapterProfile.chaptercode.Text = MyDataGridView.Item("chaptercode", MyDataGridView.CurrentRow.Index).Value()
            frmChapterProfile.Show(Me)
        End If
    End Sub
End Class