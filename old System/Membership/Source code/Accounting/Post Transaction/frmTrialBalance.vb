Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTrialBalance
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

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdatetrn.Value = CDate(Now)
        If ConnectVerify() = True Then
            FilterItem()
        End If
    End Sub

    Public Sub FilterItem()
        Try
            If ConnectVerify() = True Then
                Em.DataSource = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("SELECT itemcode, itemname as 'Account Title',if((SELECT debit FROM tblglgroup where groupcode=a.groupcode)=1,sum(debit)-sum(credit),sum(credit)-sum(debit)) as Balance FROM `tblglpostingitem` as a inner join tblglpostinggroup as b on a.trnno=b.trnno where b.dateposting <='" & ConvertDate(txtdatetrn.Value) & "' group by itemcode", conn)
                msda.Fill(dst, 0)
                Em.DataSource = dst.Tables(0)
                GridHideColumn(Em, {"itemcode"})
                GridCurrencyColumn(Em, {"Balance"})
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

    Private Sub txtdatetrn_ValueChanged(sender As Object, e As EventArgs) Handles txtdatetrn.ValueChanged
        FilterItem()
    End Sub

    
    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        frmAccountTitleLedger.itemcode.Text = Em.Item("itemcode", Em.CurrentRow.Index).Value()
        frmAccountTitleLedger.Show(Me)
    End Sub

    
End Class
