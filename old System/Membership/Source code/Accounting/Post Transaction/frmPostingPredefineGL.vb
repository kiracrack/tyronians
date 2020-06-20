Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmPostingPredefineGL
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
        loadTrnGroup()
        loadTrnTitle()
        PopulateGridViewControls("Item Code", 0, "", Em, False, True)
        PopulateGridViewControls("Account Title", 400, "", Em, True, True)
        PopulateGridViewControls("Debit", 150, "", Em, True, False)
        PopulateGridViewControls("Credit", 150, "", Em, True, False)
        PopulateGridViewControls("creditentry", 0, "", Em, False, True)
        PopulateGridViewControls("groupcode", 0, "", Em, False, True)

        txtdatetrn.Value = CDate(Now)
        FilterItem()
        If mode.Text = "edit" Or mode.Text = "view" Then
            LoadPostingDetails()
        Else
            txtTrnNo.Text = GetSeriesGLPosting()
        End If
    End Sub

    Public Sub LoadPostingDetails()
        Dim trngroup As String = "" : Dim trntitle As String = ""
        com.CommandText = "select *, (select groupname from tblgltransactiongroup where groupcode=tblglpostinggroup.trngroup) as 'trngrp',(select description from tblgltransactionheader where trncode=tblglpostinggroup.trncode) as 'trntitle' from tblglpostinggroup where trnno='" & txtTrnNo.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            groupcode.Text = rst("trngrp").ToString
            trngroup = rst("trngrp").ToString
            trncode.Text = rst("trncode").ToString
            trntitle = rst("trntitle").ToString
            txtdatetrn.Value = rst("dateposting").ToString
            txtReference.Text = rst("reference").ToString
            txtDetails.Text = rst("details").ToString
        End While
        rst.Close()
        txtTrnGroup.Text = trngroup
        txtTrnTitle.Text = trntitle

        com.CommandText = "select * from tblglpostingitem where trnno='" & txtTrnNo.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            For i = 0 To Em.RowCount - 2
                If Em("Item Code", i).Value = rst("itemcode").ToString Then
                    Em("Credit", i).Value = rst("credit")
                    Em("Debit", i).Value = rst("Debit")
              
                End If
            Next
        End While
        rst.Close()
        If mode.Text = "edit" Then
            EnableDisableForm(False)
        Else
            EnableDisableForm(True)
        End If
    End Sub

    Public Sub EnableDisableForm(ByVal readonlyForm As Boolean)
        If readonlyForm = True Then
            txtTrnGroup.Enabled = False
            txtTrnTitle.Enabled = False
            txtdatetrn.Enabled = False
            cmdPost.Text = "Close"
        Else
            txtTrnGroup.Enabled = True
            txtTrnTitle.Enabled = True
            txtdatetrn.Enabled = True
            cmdPost.Text = "Post Transaction"
        End If
        txtReference.ReadOnly = readonlyForm
        txtDetails.ReadOnly = readonlyForm
        Em.ReadOnly = readonlyForm
    End Sub
    Public Sub loadTrnGroup()
        LoadToComboBoxDB("select * from tblgltransactiongroup order by groupcode asc", "groupname", "groupcode", txtTrnGroup)
    End Sub
    Public Sub loadTrnTitle()
        LoadToComboBoxDB("select * from tblgltransactionheader where trngroup='" & groupcode.Text & "' order by description asc", "description", "trncode", txtTrnTitle)
    End Sub
    Public Sub FilterItem()
        Try
            Em.Rows.Clear()
            com.CommandText = "SELECT (select groupcode from tblglitem where itemcode=tblgltransactionitem.debititem) as glgroup,  debititem as itemcode, 0 as creditentry, (select itemname from tblglitem where itemcode=tblgltransactionitem.debititem) as 'accttitle',0 as Credit, 0 as Debit FROM `tblgltransactionitem` where debititem<>'' " & If(mode.Text = "view", " and debititem in (select itemcode from tblglpostingitem where trnno='" & txtTrnNo.Text & "') ", "") & " and trngroup='" & groupcode.Text & "' and trncode='" & trncode.Text & "' order by (select itemname from tblglitem where itemcode=tblgltransactionitem.credititem) asc; " : rst = com.ExecuteReader
            While rst.Read
                Em.Rows.Add(rst("itemcode").ToString, rst("accttitle").ToString, rst("Debit"), rst("Credit"), rst("creditentry"), rst("glgroup").ToString)
            End While
            rst.Close()

            com.CommandText = "SELECT (select groupcode from tblglitem where itemcode=tblgltransactionitem.credititem) as glgroup, credititem as itemcode, 1 as creditentry, (select itemname from tblglitem where itemcode=tblgltransactionitem.credititem) as 'accttitle',0 as Credit, 0 as Debit FROM `tblgltransactionitem` where credititem<>'' " & If(mode.Text = "view", " and credititem in (select itemcode from tblglpostingitem where trnno='" & txtTrnNo.Text & "') ", "") & " and trngroup='" & groupcode.Text & "' and trncode='" & trncode.Text & "' order by (select itemname from tblglitem where itemcode=tblgltransactionitem.credititem) asc;" : rst = com.ExecuteReader
            While rst.Read
                Em.Rows.Add(rst("itemcode").ToString, rst("accttitle").ToString, rst("Debit"), rst("Credit"), rst("creditentry"), rst("glgroup").ToString)
            End While
            rst.Close()
            Em.Rows.Add("", "TOTAL TRANSACTION", 0, 0, 2, "")
            GridCurrencyColumn(Em, {"Credit", "Debit"})

            For rowIndex As Integer = 0 To Em.Rows.Count - 1
                If CInt(Em.Rows(rowIndex).Cells("creditentry").Value) = 0 Then
                    Em.Rows(rowIndex).Cells("Credit").ReadOnly = True
                    Em.Rows(rowIndex).Cells("Debit").ReadOnly = False

                    Em("Credit", rowIndex).Style.BackColor = Color.Linen
                    Em("Credit", rowIndex).Style.SelectionBackColor = Color.Linen

                ElseIf CInt(Em.Rows(rowIndex).Cells("creditentry").Value) = 1 Then
                    Em.Rows(rowIndex).Cells("Credit").ReadOnly = False
                    Em.Rows(rowIndex).Cells("Debit").ReadOnly = True
                    Em("Debit", rowIndex).Style.BackColor = Color.Linen
                    Em("Debit", rowIndex).Style.SelectionBackColor = Color.Linen

                ElseIf CInt(Em.Rows(rowIndex).Cells("creditentry").Value) = 2 Then
                    totalIndex = rowIndex
                    GridTotal(rowIndex)
                End If
            Next

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
        Dim totalCredit As Double = 0 : Dim totalDebit As Double = 0
        For i = 0 To Em.RowCount - 2
            totalCredit = totalCredit + Val(CC(gv("Credit", i).Value))
            totalDebit = totalDebit + Val(CC(gv("Debit", i).Value))
        Next
        gv("Credit", totalIndex).Value = totalCredit
        gv("Debit", totalIndex).Value = totalDebit

    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs)
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

    Private Sub cmdPost_Click(sender As Object, e As EventArgs) Handles cmdPost.Click
        If mode.Text = "view" Then
            Me.Close()
        Else
            If ConnectVerify() = True Then
                If groupcode.Text = "" Then
                    MessageBox.Show("Please select transaction group", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtTrnGroup.Focus()
                    Exit Sub
                ElseIf trncode.Text = "" Then
                    MessageBox.Show("Please select transaction title", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtTrnTitle.Focus()
                    Exit Sub
                ElseIf txtReference.Text = "" Then
                    MessageBox.Show("Please select transaction reference no", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtReference.Focus()
                    Exit Sub
                ElseIf txtDetails.Text = "" Then
                    MessageBox.Show("Please select transaction details", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtDetails.Focus()
                    Exit Sub
                ElseIf Val(CC(Em("Credit", totalIndex).Value)) <> Val(CC(Em("Debit", totalIndex).Value)) Then
                    MessageBox.Show("Total amount of credit and debit did not match", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                ElseIf Val(CC(Em("Credit", totalIndex).Value)) = 0 Or Val(CC(Em("Debit", totalIndex).Value)) = 0 Then
                    MessageBox.Show("Please enter amount specific transaction", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If MessageBox.Show("Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If mode.Text = "edit" Then
                        com.CommandText = "UPDATE tblglpostinggroup set trngroup='" & groupcode.Text & "', trncode='" & trncode.Text & "', dateposting='" & ConvertDate(txtdatetrn.Value) & "', reference='" & txtReference.Text & "', details='" & rchar(txtDetails.Text) & "' where trnno='" & txtTrnNo.Text & "'" : com.ExecuteNonQuery()
                    Else
                        com.CommandText = "insert into tblglpostinggroup set trnno='" & txtTrnNo.Text & "', trngroup='" & groupcode.Text & "', trncode='" & trncode.Text & "', dateposting='" & ConvertDate(txtdatetrn.Value) & "', reference='" & txtReference.Text & "', details='" & rchar(txtDetails.Text) & "',datetrn=current_timestamp" : com.ExecuteNonQuery()
                    End If

                    'com.CommandText = "delete from tblglpostingitem where trnno='" & txtTrnNo.Text & "'" : com.ExecuteNonQuery()
                    For i = 0 To Em.RowCount - 2
                        If Val(CC(Em("Credit", i).Value)) > 0 Or Val(CC(Em("Debit", i).Value)) > 0 Then
                            If countqry("tblglpostingitem", "trnno='" & txtTrnNo.Text & "' and itemcode='" & Em("Item Code", i).Value & "'") = 0 Then
                                com.CommandText = "insert into tblglpostingitem set trnno='" & txtTrnNo.Text & "', groupcode='" & Em("groupcode", i).Value & "', itemcode='" & Em("Item Code", i).Value & "', itemname='" & rchar(Em("Account Title", i).Value) & "', credit='" & Val(CC(Em("Credit", i).Value)) & "', debit='" & Val(CC(Em("Debit", i).Value)) & "'" : com.ExecuteNonQuery()
                            Else
                                com.CommandText = "UPDATE tblglpostingitem set groupcode='" & Em("groupcode", i).Value & "', itemname='" & rchar(Em("Account Title", i).Value) & "', credit='" & Val(CC(Em("Credit", i).Value)) & "', debit='" & Val(CC(Em("Debit", i).Value)) & "' where trnno='" & txtTrnNo.Text & "' and itemcode='" & Em("Item Code", i).Value & "'" : com.ExecuteNonQuery()
                            End If
                        End If
                    Next
                    frmPostTransaction.FilterItem()
                    MessageBox.Show("Transaction successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
      
    End Sub
End Class
