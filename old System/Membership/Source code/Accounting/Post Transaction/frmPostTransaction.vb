Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmPostTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.Control + (Keys.F12) Then
            If cmdVerify.Visible = True Then
                cmdVerify.Visible = False
            Else
                cmdVerify.Visible = True
            End If
        End If
        Return ProcessCmdKey
    End Function
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
 
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdatetrn.Value = CDate(Now)
        txtdatetrn2.Value = CDate(Now)
        FilterItem()
    End Sub

    Public Sub FilterItem()
        Try
            If ConnectVerify() = True Then
                Em.DataSource = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select trnno as 'Transaction No.', date_format(dateposting,'%Y-%m-%d') as 'Posting Date', ifnull((select groupname from tblgltransactiongroup where groupcode=tblglpostinggroup.trngroup),'Journal') as 'Transaction Group',ifnull((select description from tblgltransactionheader where trncode=tblglpostinggroup.trncode),'Journal') as 'Transaction Title',Reference, Details, (select sum(credit) from tblglpostingitem where trnno=tblglpostinggroup.trnno) as Amount,date_format(datetrn,'%M %d, %d %r') as 'Date Posted',if(verified=1,'VERIFIED','PENDING') as 'Status' from tblglpostinggroup where dateposting between '" & ConvertDate(txtdatetrn.Value) & "' and '" & ConvertDate(txtdatetrn2.Value) & "'  order by datetrn asc", conn)
                msda.Fill(dst, 0)
                Em.DataSource = dst.Tables(0)
                GridColumnAlignment(Em, {"Transaction No.", "Posting Date", "Status"}, DataGridViewContentAlignment.MiddleCenter)
                GridCurrencyColumn(Em, {"Amount"})

                For rowIndex As Integer = 0 To Em.Rows.Count - 1
                    If Em.Rows(rowIndex).Cells("Status").Value = "PENDING" Then
                        Em("Status", rowIndex).Style.ForeColor = Color.Red
                    Else
                        Em("Status", rowIndex).Style.ForeColor = Color.Green
                    End If
                Next
            End If
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

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterItem()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPostingPredefineGL.Show(Me)
    End Sub

    Private Sub txtdatetrn_ValueChanged(sender As Object, e As EventArgs) Handles txtdatetrn.ValueChanged
        FilterItem()
    End Sub

    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If Em.Item("Status", Em.CurrentRow.Index).Value() = "VERIFIED" Then
            MessageBox.Show("Transaction Already Verified", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblglpostinggroup where trnno='" & Em.Item("Transaction No.", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblglpostingitem where trnno='" & Em.Item("Transaction No.", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            FilterItem()
            MessageBox.Show("Item Successfully Deleted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        If Em.Item("Status", Em.CurrentRow.Index).Value() = "VERIFIED" Then
            MessageBox.Show("Transaction Already Verified", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmPostingPredefineGL.txtTrnNo.Text = Em.Item("Transaction No.", Em.CurrentRow.Index).Value()
        frmPostingPredefineGL.mode.Text = "edit"
        frmPostingPredefineGL.Show(Me)
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        frmPostingPredefineGL.txtTrnNo.Text = Em.Item("Transaction No.", Em.CurrentRow.Index).Value()
        frmPostingPredefineGL.mode.Text = "view"
        frmPostingPredefineGL.Show(Me)
    End Sub

    Private Sub cmdVerify_Click(sender As Object, e As EventArgs) Handles cmdVerify.Click
        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In Em.SelectedRows
                com.CommandText = "UPDATE tblglpostinggroup set verified=1 where trnno='" & rw.Cells("Transaction No.").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterItem()
            MessageBox.Show("Item Successfully Verfied", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
