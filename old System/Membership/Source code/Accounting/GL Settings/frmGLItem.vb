Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmGLItem
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
        ElseIf countqry("tblglitem", "itemname='" & rchar(txtItemName.Text) & "'") > 0 And mode.Text <> "edit" Then
            MsgBox("Item Name already exists", vbCritical, Me.Text)
            txtItemName.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "update tblglitem set groupcode='" & groupcode.Text & "', itemcode='" & itemcode.Text & "', itemname='" & rchar(txtItemName.Text) & "',parent='" & parentcode.Text & "', gl=" & gl.Checked & ", sl=" & sl.Checked & ",level='" & txtLevel.Text & "'  where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblglitem set groupcode='" & groupcode.Text & "', itemcode='" & itemcode.Text & "', itemname='" & rchar(txtItemName.Text) & "',parent='" & parentcode.Text & "', gl=" & gl.Checked & ", sl=" & sl.Checked & ",level='" & txtLevel.Text & "' " : com.ExecuteNonQuery()
        End If
        itemcode.Text = "" : txtItemName.Text = "" : mode.Text = "" : txtItemName.Focus()
        FilterItem()
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBoxDB("select * from tblglgroup order by groupcode asc", "groupname", "groupcode", txtGroup)
        LoadParentItem()
        FilterItem()
    End Sub
    Public Sub LoadParentItem()
        LoadToComboBoxDB("select * from tblglitem where glgroup=0 and level=" & txtLevel.Text & "-1 and groupcode='" & groupcode.Text & "' order by itemcode asc", "itemname", "itemcode", txtParent)
    End Sub
    Public Sub FilterItem()
        Try
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select groupcode,id,itemcode as 'Code', itemname as 'Account Title',GL,SL from tblglitem where glgroup=0 and groupcode='" & groupcode.Text & "' and (parent='" & parentcode.Text & "' or parent='" & groupcode.Text & "') order by itemcode asc", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
            GridHideColumn(Em, {"groupcode", "id"})
            GridColumnAlignment(Em, {"Code"}, DataGridViewContentAlignment.MiddleCenter)
            GridColumnWidth(Em, {"Code"}, 100)
            GridColumAutonWidth(Em, {"Account Title"})
            GridColumnWidth(Em, {"GL", "SL"}, 60)
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
        id.Text = Em.Item("id", Em.CurrentRow.Index).Value()
        Dim level As Integer = 0
        com.CommandText = "select *,(select groupname from tblglgroup where groupcode=a.groupcode) as grp,(select b.itemname from tblglitem as b where b.itemcode=a.itemcode) as prnt from tblglitem as a where a.id='" & Em.Item("id", Em.CurrentRow.Index).Value() & "' " : rst = com.ExecuteReader
        While rst.Read
            groupcode.Text = rst("groupcode").ToString
            txtGroup.Text = rst("grp").ToString
            itemcode.Text = rst("itemcode").ToString
            txtItemName.Text = rst("itemname").ToString
            parentcode.Text = rst("parent").ToString
            level = rst("level").ToString
            txtParent.Text = rst("prnt").ToString
            gl.Checked = rst("gl")
            sl.Checked = rst("sl")
        End While
        rst.Close()
        txtLevel.Text = level
        mode.Text = "edit"
    End Sub

    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete selected item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblglitem where itemcode='" & Em.Item("Code", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
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

    Private Sub txtGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGroup.SelectedValueChanged
        groupcode.Text = DirectCast(txtGroup.SelectedItem, ComboBoxItem).HiddenValue()
        FilterItem()
        LoadParentItem()
    End Sub
 

    Private Sub txtParent_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtParent.SelectedValueChanged
        parentcode.Text = DirectCast(txtParent.SelectedItem, ComboBoxItem).HiddenValue()
        FilterItem()
    End Sub

    Private Sub txtLevel_TextChanged(sender As Object, e As EventArgs) Handles txtLevel.TextChanged
        If txtLevel.Text = "0" Then
            parentcode.Text = ""
        End If
        LoadParentItem()
        FilterItem()
    End Sub

    Private Sub VewLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VewLedgerToolStripMenuItem.Click
        frmAccountTitleLedger.itemcode.Text = Em.Item("Code", Em.CurrentRow.Index).Value()
        frmAccountTitleLedger.Show(Me)
    End Sub
End Class
