Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmBatchCollection
    Dim totalIndex As Integer
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
        ColumnSetup()
        LoadChapter()
    End Sub

    Public Sub ColumnSetup()
        Em.Columns.Clear()
        PopulateGridViewControls("memberid", 0, "", Em, False, True)
        PopulateGridViewControls("chaptercode", 0, "", Em, False, True)
        PopulateGridViewControls("localchapter", 0, "", Em, False, True)
        PopulateGridViewControls("Account Name", 400, "", Em, True, True)
        PopulateGridViewControls("Receipt No.", 150, "", Em, True, False)
        PopulateGridViewControls("Amount", 150, "", Em, True, False)
    End Sub
    Public Sub EnableDisableForm(ByVal readonlyForm As Boolean)
        If readonlyForm = True Then
            txtchaptername.Enabled = False
            txtLocalChapter.Enabled = False
            txtDatePosting.Enabled = False
            cmdPost.Text = "Close"
        Else
            txtchaptername.Enabled = True
            txtLocalChapter.Enabled = True
            txtDatePosting.Enabled = True
            cmdPost.Text = "Post Transaction"
        End If
        Em.ReadOnly = readonlyForm
    End Sub
    Public Sub LoadChapter()
        LoadToComboBoxDB("select * from tblglobalchapters order by chaptername asc", "chaptername", "chaptercode", txtchaptername)
    End Sub

    Private Sub txtchaptername_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtchaptername.SelectedValueChanged
        chaptercode.Text = DirectCast(txtchaptername.SelectedItem, ComboBoxItem).HiddenValue()
        LoadLocalChapter()
        FilterItem()
    End Sub
    Public Sub LoadLocalChapter()
        LoadToComboBoxDB("select * from tbllocalchapter where chaptercode='" & chaptercode.Text & "' order by chaptername asc", "chaptername", "code", txtLocalChapter)
    End Sub
    Private Sub txtLocalChapter_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLocalChapter.SelectedValueChanged
        If txtLocalChapter.Text = "" Then Exit Sub
        localchaptercode.Text = DirectCast(txtLocalChapter.SelectedItem, ComboBoxItem).HiddenValue()
        FilterItem()
    End Sub
    Public Sub FilterItem()
        Try
            If Em.ColumnCount = 0 Then
                ColumnSetup()
            End If
            Em.Rows.Clear()
            com.CommandText = "select * From tblglobalmembers where chaptercode='" & chaptercode.Text & "' " & If(ckAll.Checked = True, "", " and localchapter='" & localchaptercode.Text & "'") & " order by fullname asc" : rst = com.ExecuteReader
            While rst.Read
                Em.Rows.Add(rst("memberid").ToString, rst("chaptercode").ToString, rst("localchapter").ToString, rst("fullname").ToString, "", 0)
            End While
            rst.Close()
            Em.Rows.Add("", "", "", "TOTAL TRANSACTION", "", 0)
            GridCurrencyColumn(Em, {"Amount"})
            GridColAlign("Receipt No.", Em, DataGridViewContentAlignment.MiddleCenter)

            GridTotal(Em.Rows.Count - 1)
            totalIndex = Em.Rows.Count - 1
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
    Private Sub Em_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Em.CellValueChanged
        Dim gv As DataGridView = DirectCast(sender, DataGridView)
        Dim Amount As Double = 0
        For i = 0 To Em.RowCount - 2
            Amount = Amount + Val(CC(gv("Amount", i).Value))
        Next
        gv("Amount", totalIndex).Value = Amount
        
    End Sub
     
    Private Sub cmdPost_Click(sender As Object, e As EventArgs) Handles cmdPost.Click
        If chaptercode.Text = "" Then
            MessageBox.Show("Please select chapter", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchaptername.Focus()
            Exit Sub
        ElseIf localchaptercode.Text = "" And ckAll.Checked = False Then
            MessageBox.Show("Please select local chapter", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLocalChapter.Focus()
            Exit Sub
        ElseIf txtMonthPosting.Text = "" Then
            MessageBox.Show("Please select posting month", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMonthPosting.Focus()
            Exit Sub
         
        End If

        If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ConnectVerify() = True Then
                For i = 0 To Em.RowCount - 2
                    If Val(CC(Em("Amount", i).Value)) > 0 Then
                        com.CommandText = "insert into tblcollections set memberid='" & Em("memberid", i).Value & "', chaptercode='" & Em("chaptercode", i).Value & "', localchapter='" & Em("localchapter", i).Value & "', accountname='" & rchar(Em("Account Name", i).Value) & "', receiptno='" & rchar(Em("Receipt No.", i).Value) & "', amount='" & Val(CC(Em("amount", i).Value)) & "', postingdate='" & ConvertDate(txtDatePosting.Value) & "',datetrn=current_timestamp" : com.ExecuteNonQuery()
                    End If
                Next
            End If
            MessageBox.Show("Transaction successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            txtLocalChapter.Enabled = False
            txtLocalChapter.SelectedIndex = -1
        Else
            txtLocalChapter.Enabled = True
        End If
        FilterItem()
    End Sub

    Private Sub txtMonthPosting_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtMonthPosting.SelectedValueChanged
        If CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy")) > txtDatePosting.MinDate Then
            txtDatePosting.MaxDate = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy")).AddMonths(1).AddDays(-1)
            txtDatePosting.MinDate = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy"))
            txtDatePosting.Value = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy")).AddMonths(1).AddDays(-1)
        Else
            txtDatePosting.MinDate = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy"))
            txtDatePosting.MaxDate = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy")).AddMonths(1).AddDays(-1)
            txtDatePosting.Value = CDate(txtMonthPosting.Text & " 1, " & CDate(Now).ToString("yyyy")).AddMonths(1).AddDays(-1)
        End If

    End Sub
End Class
