Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTrnSettingsItems
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
 
    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTrnGroup()
        loadTrnTitle()
        FilterItem()
    End Sub

    Public Sub loadTrnGroup()
        LoadToComboBoxDB("select * from tblgltransactiongroup order by groupcode asc", "groupname", "groupcode", txtTrnGroup)
    End Sub
    Public Sub loadTrnTitle()
        LoadToComboBoxDB("select * from tblgltransactionheader where trngroup='" & groupcode.Text & "' order by description asc", "description", "trncode", txtTrnTitle)
    End Sub
    Public Sub FilterItem()
        Try
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select id,(select itemname from tblglitem where itemcode=tblgltransactionitem.debititem) as Debit, (select itemname from tblglitem where itemcode=tblgltransactionitem.credititem) as Credit from tblgltransactionitem where trngroup='" & groupcode.Text & "' and trncode='" & trncode.Text & "'", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
            GridHideColumn(Em, {"id"})

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

    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete selected item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In Em.SelectedRows
                com.CommandText = "delete from tblgltransactionitem where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
            Next

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

    Private Sub txtGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtTrnGroup.SelectedValueChanged
        groupcode.Text = DirectCast(txtTrnGroup.SelectedItem, ComboBoxItem).HiddenValue()
        loadTrnTitle()
        FilterItem()

    End Sub


    Private Sub txtTrnTitle_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtTrnTitle.SelectedValueChanged
        trncode.Text = DirectCast(txtTrnTitle.SelectedItem, ComboBoxItem).HiddenValue()
        FilterItem()
    End Sub
 
    Private Sub cmdTrnGroup_Click(sender As Object, e As EventArgs) Handles cmdTrnGroup.Click
        frmTrnGroup.ShowDialog(Me)
        loadTrnGroup()
    End Sub

    Private Sub cmdTrnTitle_Click(sender As Object, e As EventArgs) Handles cmdTrnTitle.Click
        If groupcode.Text = "" Then
            MessageBox.Show("Please select transaction group", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmTrnTitle.groupcode.Text = groupcode.Text
        frmTrnTitle.ShowDialog(Me)
        loadTrnTitle()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        If groupcode.Text = "" Then
            MessageBox.Show("Please select transaction group", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf trncode.Text = "" Then
            MessageBox.Show("Please select transaction title", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmTrnAddItem.groupcode.Text = groupcode.Text
        frmTrnAddItem.trncode.Text = trncode.Text
        frmTrnAddItem.Show(Me)
    End Sub
End Class
