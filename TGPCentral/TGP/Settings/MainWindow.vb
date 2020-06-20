Imports System.Security.Permissions
Imports DevExpress.XtraEditors

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)>
Public Class MainWindow
    Dim ShowEncryptedMessage As Boolean = False
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(file_conn) = False Then
            frmConnectionSetup.ShowDialog()
            Me.Close()
        Else
            If OpenSQLConnection() = True Then
                SystemDatabaseUpdater()
                Me.Text = GlobalSystemName
                LoadCouncil()
            End If
        End If
    End Sub

    Private Sub cmdUserAccounts_Click(sender As Object, e As EventArgs) Handles cmdCouncil.Click
        frmCouncil.ShowDialog(Me)
    End Sub

    Private Sub cmdSubscribers_Click(sender As Object, e As EventArgs) Handles cmdChapter.Click
        frmChapter.ShowDialog(Me)
    End Sub

    Private Sub cmdUserAccounts_Click_1(sender As Object, e As EventArgs) Handles cmdUserAccounts.Click
        frmUserAccounts.ShowDialog(Me)
    End Sub

#Region "Global Member List"
    Public Sub LoadCouncil()
        txtCouncil.Items.Clear()
        com.CommandText = "select * from tblcouncil order by councilname asc" : rst = com.ExecuteReader
        While rst.Read
            txtCouncil.Items.Add(rst("councilname").ToString)
        End While
        rst.Close()
    End Sub

    Public Sub LoadChapter(ByVal cmb As CheckedComboBoxEdit)
        cmb.Properties.Items.Clear()
        com.CommandText = "select * from tblchapter where councilcode='" & councilcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cmb.Properties.Items.Add(rst("chaptercode").ToString, False)
            cmb.Properties.Items.Item(rst("chaptercode").ToString).Description = rst("chaptername").ToString
            cmb.Properties.Items.Item(rst("chaptercode").ToString).Value = rst("chaptercode").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtCouncil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCouncil.SelectedIndexChanged
        If txtCouncil.Text = "" Then Exit Sub
        councilcode.Text = qrysingledata("councilcode", "councilcode", "tblcouncil where councilname='" & txtCouncil.Text & "'")
        LoadChapter(txtChapter)
        LoadMember()
    End Sub

    Private Sub txtChapter_EditValueChanged(sender As Object, e As EventArgs) Handles txtChapter.EditValueChanged
        LoadMember()
    End Sub

    Private Sub ckCollectionAllUsher_CheckedChanged(sender As Object, e As EventArgs) Handles ckCollectionAllUsher.CheckedChanged
        If ckCollectionAllUsher.Checked = True Then
            txtChapter.Enabled = False
        Else
            txtChapter.Enabled = True
        End If
    End Sub
    Public Sub LoadMember()
        If txtCouncil.Text = "" Then Exit Sub
        Dim checkeditem As String = ""
        For Each cmb In txtChapter.Properties.GetItems
            If cmb.CheckState = CheckState.Checked Then
                checkeditem += "chaptercode=" & cmb.Value & " or "
            End If
        Next
        If checkeditem.Length > 0 Then
            checkeditem = " and (" & checkeditem.Remove(checkeditem.Length - 3, 3) & ")"
        End If

        LoadXgrid("select councilcode, memberid as 'Member ID',councilname as 'Council',chaptername as 'Chapter',Fullname, convert(varchar, birthdate, 23) as 'Birthdate',Gender,phonenumber as 'Phone Number', Position, isnull((select sum(amount) from tbltransaction where memberid=a.memberid and contribution=1),0) as 'Total Contribution',  Occupation, convert(varchar, datesurvived, 23) as 'Date Survived',baptizedname as 'Baptized Name',recruitername as 'Recruiter Name',(select username from tbluseraccounts where phonenumber=a.registeredby) as 'Registered By',convert(varchar, dateregistered, 0) as 'Date Registered', CAST([Synched] AS Bit) as Synched from tblmembers as a where councilcode='" & councilcode.Text & "'  " & If(ckCollectionAllUsher.Checked = True, "", checkeditem) & " order by fullname asc", "tblmembers", Em_member, gridview_member)

        XgridHideColumn({"councilcode"}, gridview_member)
        XgridColAlign({"Member ID", "Council", "Chapter", "Birthdate", "Gender", "Position", "Phone Number", "Date Survived", "Baptized Name"}, gridview_member, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Contribution"}, gridview_member)
        XgridGeneralSummaryCurrency({"Total Contribution"}, gridview_member)
        XgridColWidth({"Total Contribution"}, gridview_member, 120)
    End Sub
#End Region

  
    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to permanently delete selected item? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To gridview_member.SelectedRowsCount - 1
                com.CommandText = "delete from tblmembers where memberid='" & gridview_member.GetRowCellValue(gridview_member.GetSelectedRows(I), "Member ID").ToString & "'" : com.ExecuteNonQuery()
            Next
            LoadMember()
        End If

    End Sub

    Private Sub SendViaTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendViaTextToolStripMenuItem.Click
        Dim details As String = ""
        For I = 0 To gridview_member.SelectedRowsCount - 1
            details += gridview_member.GetRowCellValue(gridview_member.GetSelectedRows(I), "councilcode").ToString & "," & gridview_member.GetRowCellValue(gridview_member.GetSelectedRows(I), "Member ID").ToString & "," & gridview_member.GetRowCellValue(gridview_member.GetSelectedRows(I), "Fullname").ToString.Replace(",", "") & Environment.NewLine
        Next
        frmGroupSMS.txtContent.Text = "MEMBERLIST" & Environment.NewLine & details.Remove(details.Length - 1, 1)
        frmGroupSMS.ShowDialog(Me)
    End Sub

    Private Sub cmdMaintainance_Click(sender As Object, e As EventArgs) Handles cmdMaintainance.Click
        frmFieldName.ShowDialog(Me)
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        frmInformation.mode.Text = ""
        frmInformation.memberid.Text = gridview_member.GetFocusedRowCellValue("Member ID").ToString
        frmInformation.mode.Text = "edit"
        frmInformation.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmInformation.ShowDialog(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadMember()
    End Sub
End Class
