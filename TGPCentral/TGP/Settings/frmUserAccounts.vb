Imports Microsoft.VisualBasic.Strings

Public Class frmUserAccounts

    Private Sub frmMunicipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GlobalSystemName
        LoadCouncil()
        ShowList()
    End Sub

    Public Sub LoadCouncil()
        LoadXgridLookupSearch("select councilcode,councilname as Council from tblcouncil order by councilname asc", "tblcouncil", txtCouncil, gridCouncil)
        XgridHideColumn({"councilcode"}, gridCouncil)
    End Sub
    Public Sub SaveInfo()
        If txtFullname.Text = "" Then
            MessageBox.Show("Please enter account name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtPhoneNumber.Text = "" Then
            MessageBox.Show("Please enter phone number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPhoneNumber.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tbluseraccounts set councilcode='" & txtCouncil.EditValue & "', username='" & rchar(txtFullname.Text) & "',phonenumber='+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10) & "'  where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tbluseraccounts (councilcode, username,phonenumber) values ('" & txtCouncil.EditValue & "','" & rchar(txtFullname.Text) & "','+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10) & "')" : com.ExecuteNonQuery()
        End If
        txtFullname.Text = "" : id.Text = "" : txtPhoneNumber.Text = "" : mode.Text = "" : txtFullname.Focus() : ShowList()
        MessageBox.Show("account successfuly saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ShowList()
        LoadXgrid("SELECT id as 'Code', councilcode, (select councilname from tblcouncil where councilcode=a.councilcode) as 'Council', username as 'Account Name',phonenumber as 'Phone Number' FROM tbluseraccounts as a order by username asc;", "tbluseraccounts", Em, GridView1)
        XgridHideColumn({"councilcode"}, GridView1)
        XgridColAlign({"Code"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Code"}, GridView1, 50)
        XgridColWidth({"Phone Number"}, GridView1, 100)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("Code").ToString
        txtCouncil.EditValue = GridView1.GetFocusedRowCellValue("councilcode").ToString
        txtFullname.Text = GridView1.GetFocusedRowCellValue("Account Name").ToString
        txtPhoneNumber.Text = GridView1.GetFocusedRowCellValue("Phone Number").ToString
        mode.Text = "edit"
        txtFullname.Focus()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowList()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to permanently delete selected item? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tbluseraccounts where id='" & GridView1.GetFocusedRowCellValue("Code").ToString & "'" : com.ExecuteNonQuery()
            ShowList()
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        SaveInfo()

    End Sub
End Class
