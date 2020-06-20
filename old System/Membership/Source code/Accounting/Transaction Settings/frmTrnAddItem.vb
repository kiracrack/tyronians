Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmTrnAddItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
  
    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConnectVerify() = True Then
            PopulateGridViewControls("Select", 20, "CHECKBOX", MyDataGridView, True, False)
            PopulateGridViewControls("Item Code", 0, "", MyDataGridView, False, True)
            PopulateGridViewControls("Item Name", 50, "", MyDataGridView, True, True)
            LoadGLItems()
        End If
    End Sub

    Public Sub LoadGLItems()
        MyDataGridView.Rows.Clear()
        com.CommandText = "select * from tblglitem where sl=1 and ((select groupname from tblglgroup where groupcode=tblglitem.groupcode) like '%" & txtSearch.Text & "%' or itemname like '%" & txtSearch.Text & "%') order by itemcode asc" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView.Rows.Add(False, rst("itemcode").ToString, rst("itemname").ToString)
        End While
        rst.Close()
    End Sub
   
 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtCredit.Text = "" Then
            MessageBox.Show("Please select transaction type", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue add selected item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ConnectVerify() = True Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Item("Select", i).Value = 1 Then
                        If txtCredit.SelectedIndex = 0 Then
                            com.CommandText = "insert into tblgltransactionitem set trngroup='" & groupcode.Text & "', trncode='" & trncode.Text & "', credititem='" & MyDataGridView.Item("Item Code", i).Value & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "insert into tblgltransactionitem set trngroup='" & groupcode.Text & "', trncode='" & trncode.Text & "', debititem='" & MyDataGridView.Item("Item Code", i).Value & "'" : com.ExecuteNonQuery()
                        End If
                    End If
                Next
            End If


            frmTrnSettingsItems.FilterItem()
            Me.Close()
        End If
    End Sub
 

    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        For I = 0 To MyDataGridView.RowCount - 1
            If ckAll.Checked = True Then
                MyDataGridView.Item("Select", I).Value = 1
            Else
                MyDataGridView.Item("Select", I).Value = 0
            End If

        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadGLItems()
    End Sub
End Class
