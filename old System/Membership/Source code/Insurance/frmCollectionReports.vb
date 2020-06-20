Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmCollectionReports
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
        LoadChapter()
    End Sub

    Public Sub LoadChapter()
        LoadToComboBoxDB("select * from tblglobalchapters order by chaptername asc", "chaptername", "chaptercode", txtchaptername)
    End Sub

    Private Sub txtchaptername_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtchaptername.SelectedValueChanged
        chaptercode.Text = DirectCast(txtchaptername.SelectedItem, ComboBoxItem).HiddenValue()
        If ckAll.Checked = True Then
            LoadYearPeriod()
        Else
            LoadLocalChapter()
        End If

        FilterItem()
    End Sub
    Public Sub LoadLocalChapter()
        LoadToComboBoxDB("select * from tbllocalchapter where chaptercode='" & chaptercode.Text & "' order by chaptername asc", "chaptername", "code", txtLocalChapter)
    End Sub
    Private Sub txtLocalChapter_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLocalChapter.SelectedValueChanged
        If txtLocalChapter.Text = "" Then Exit Sub
        localchaptercode.Text = DirectCast(txtLocalChapter.SelectedItem, ComboBoxItem).HiddenValue()
        LoadYearPeriod()
    End Sub

    Public Sub LoadYearPeriod()
        LoadToComboBoxDB("select distinct date_format(postingdate,'%Y') as yr from tblcollections where chaptercode='" & chaptercode.Text & "' " & If(ckAll.Checked = True, "", " and localchapter='" & localchaptercode.Text & "'"), "yr", "yr", txtYear)
    End Sub

    Private Sub txtYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtYear.SelectedValueChanged
        If txtYear.Text = "" Then Exit Sub
        LoadMonthPeriod()
    End Sub

    Public Sub LoadMonthPeriod()
        LoadToComboBoxDB("select distinct date_format(postingdate,'%M') as mt from tblcollections where chaptercode='" & chaptercode.Text & "' and date_format(postingdate,'%Y') ='" & txtYear.Text & "' " & If(ckAll.Checked = True, "", " and localchapter='" & localchaptercode.Text & "'"), "mt", "mt", txtMonthPosting)
    End Sub

    Private Sub txtMonthPosting_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtMonthPosting.SelectedValueChanged
        If txtMonthPosting.Text = "" Then Exit Sub
        FilterItem()
    End Sub
    Public Sub FilterItem()
        Try
            Em.DataSource = Nothing : dst = New DataSet
            Dim qry As String = "chaptercode='" & chaptercode.Text & "' and date_format(postingdate,'%Y') ='" & txtYear.Text & "' " & If(ckAll.Checked = True, "", " and localchapter='" & localchaptercode.Text & "'") & ""
            msda = New MySqlDataAdapter("select memberid as 'Member ID', accountname as 'Account Name',receiptno as 'Receipt No.', Amount, date_format(postingdate,'%Y-%m-%d') as 'Posting Date', date_format(datetrn,'%M %d, %Y %r') as 'Date Posted' from tblcollections where " & qry & " union all " _
                                        + "select '',concat('Total Payment ',count(*)),'Total',sum(amount),null,null from tblcollections where " & qry & "", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
            GridColumnAlignment(Em, {"Member ID", "Posting Date", "Posting Date", "Receipt No."}, DataGridViewContentAlignment.MiddleCenter)
            GridCurrencyColumn(Em, {"Amount"})

            If Em.Rows.Count > 0 Then
                GridTotal(Em.Rows.Count - 1)
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
    Public Sub GridTotal(ByVal rowIndex As Integer)
        Em.Rows(rowIndex).ReadOnly = True
        Em.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
        Em.Rows(rowIndex).DefaultCellStyle.SelectionBackColor = Color.Red
        Em.Rows(rowIndex).DefaultCellStyle.ForeColor = Color.White
        Em.Rows(rowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        Em.Rows(rowIndex).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterItem()
    End Sub

    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            txtLocalChapter.Enabled = False
            txtLocalChapter.SelectedIndex = -1
        Else
            txtLocalChapter.Enabled = True
        End If
        LoadYearPeriod()
        FilterItem()
    End Sub
End Class
