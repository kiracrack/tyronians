Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmGlobalMembers
    ' The class that will do the printing process.
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Private FILE_NAME As String = Application.StartupPath.ToString & "\colmember"

    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = StrConv(GlobalOrganizationName, vbProperCase) & " " & Me.Text
        ViewLocalActiveData()
    End Sub

    Public Sub ViewLocalActiveData()
        FilterActiveAccounts()
        If System.IO.File.Exists(Application.StartupPath & "\glmasterdata.xml") = True Then
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\glmasterdata.xml")
            MyDataGridView.DataSource = dst
            If dst.Tables.Count <> 0 Then
                MyDataGridView.DataMember = "tblglobalmembers"
                GridFilters()
            End If
        End If
    End Sub
   
    Public Sub FilterActiveAccounts()
        Dim filterqry As String = ""
        If globalpermission = 0 Then
            filterqry = ""

        ElseIf globalpermission = 1 Then
            filterqry = "where tblglobalmembers.areacode='" & globalareacode & "' and (tblaccounts.regby='" & globaluserid & "' or registeredby='" & globaluserid & "')  and isactive=1 "

        ElseIf globalpermission = 2 Then
            filterqry = "where tblglobalmembers.areacode='" & globalareacode & "' and registeredby='" & globaluserid & "'  and isactive=1 "

        End If

        dst = New DataSet
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select memberid as 'Membership ID', " _
                                             + " tblglobalmembers.Fullname as 'Fullname', " _
                                             + " Gender, " _
                                             + " Nickname, " _
                                             + " cast(date_format(birthdate,'%M %d, %Y') as char(45)) as 'Birth Date', " _
                                             + " birthplace as 'Birth Place', " _
                                             + " permanentaddress as 'Permanent Address', " _
                                             + " currentaddress as 'Current Address', " _
                                             + " specialskills as 'Special Skills', " _
                                             + " baptizedname as 'Baptized Name', " _
                                             + " cast(date_format(datesurvived,'%M %d, %Y') as char(45)) as 'Date Survived', " _
                                             + " case when rituals=1 then 'YES' else 'NO RITUAL' end as 'Ritual', " _
                                             + " case when idcard=1 then 'YES' else 'NO ID CARD' end as 'ID Card'," _
                                             + " mobilenumber as 'Mobile Number', " _
                                             + " homenumber as 'Home Number', " _
                                             + " tblglobalmembers.emailadd as 'Email', " _
                                             + " incase_contactname as 'Emergency Contact Person'," _
                                             + " incase_contact as 'Emergency Contact Number'," _
                                             + " incase_address  as 'Emergency Contact Address', " _
                                             + " (select chaptername from tblglobalchapters where chaptercode = tblglobalmembers.chaptercode) as 'Chapter', " _
                                             + " (select  areaname from tblchapterarea where areacode =  tblglobalmembers.areacode) as 'Area', " _
                                             + " (select b.fullname from tblaccounts as b where b.accountid = tblglobalmembers.registeredby) as 'Registered by', " _
                                             + " cast(date_format(dateregistered,'%M %d, %Y %r') as char(45)) as 'Date Registered', " _
                                             + " (select b.fullname from tblaccounts as b where b.accountid = tblglobalmembers.editedby) as 'Edited by', " _
                                             + " cast(date_format(dateedited,'%M %d, %Y %r') as char(45)) as 'Date Edited', " _
                                             + " case when isactive=1 then 'ACTIVE' else 'INACTIVE' end as 'Member Status' " _
                                             + " From tblglobalmembers inner join tblaccounts on accountid=tblglobalmembers.registeredby " & filterqry & " order by tblglobalmembers.Fullname asc;", conn)
        msda.Fill(dst, "tblglobalmembers")
        dst.WriteXml(Application.StartupPath & "\glmasterdata.xml")

        Me.Cursor = Cursors.Default
    End Sub
    Public Sub GridFilters()
        If System.IO.File.Exists(Application.StartupPath & "\colmember") = True Then
            Dim sr As StreamReader = File.OpenText(FILE_NAME)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0
                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        MyDataGridView.Columns(cnt).Visible = True
                    Else
                        MyDataGridView.Columns(cnt).Visible = False
                    End If
                    cnt = cnt + 1
                Next
                sr.Close()
            Catch errMS As Exception
                MessageBox.Show("Message: Invalid column choosed format! Please update your column" & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sr.Close()
                cmdColumnChooser.PerformClick()
            End Try
        End If
        CenterColumn(MyDataGridView)
        RemoveEmptyColumns(MyDataGridView)
    End Sub
    Public Function CenterColumn(ByVal grdView As DataGridView) As DataGridView
        Dim array() As String = {"Membership ID", "Gender", "Nickname", "Ritual", "ID Card", "Member Status"}
        For Each valueArr As String In array
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    GridColAlign(valueArr, grdView, DataGridViewContentAlignment.MiddleCenter)
                End If
            Next
        Next
        Return grdView
    End Function
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        ViewLocalActiveData()
    End Sub

    Private Sub cmdAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddnew.Click
        frmMembershipForm.Show(Me)
    End Sub

    Private Sub textsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textsearch.TextChanged
        Dim view As New DataView
        If System.IO.File.Exists(Application.StartupPath & "\glmasterdata.xml") = False Then
            dst.WriteXml(Application.StartupPath & "\glmasterdata.xml")
        End If
        dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\glmasterdata.xml")
        MyDataGridView.DataSource = dst
        If dst.Tables.Count <> 0 Then
            MyDataGridView.DataMember = "tblglobalmembers"
            view.Table = dst.Tables("tblglobalmembers")
            view.RowFilter = "[Membership ID] like '%" & textsearch.Text & "%' or  " _
                          + " [Fullname] like '%" & textsearch.Text & "%' or " _
                          + " [Nickname] like '%" & textsearch.Text & "%' or " _
                          + " [Permanent Address] like '%" & textsearch.Text & "%' or " _
                          + " [Current Address] like '%" & textsearch.Text & "%' or " _
                          + " [Special Skills] like '%" & textsearch.Text & "%' or " _
                          + " [Baptized Name] like '%" & textsearch.Text & "%' or " _
                          + " [Date Survived] like '%" & textsearch.Text & "%' or " _
                          + " [Mobile Number] like '%" & textsearch.Text & "%' or " _
                          + " [Chapter] like '%" & textsearch.Text & "%' or " _
                          + " [Area] like '%" & textsearch.Text & "%' or " _
                          + " [Member Status] like '%" & textsearch.Text & "%' "

            MyDataGridView.DataSource = view
            GridFilters()
        End If
    End Sub

    ' The printing setup function
    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        MyPrintDocument.DocumentName = Me.Text
        MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings
        MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        MyPrintDocument.DefaultPageSettings.Landscape = ck_Landscape.CheckState
        If ck_legall.Checked = True Then
            MyPrintDocument.DefaultPageSettings.PaperSize = New PaperSize("Legal", 850, 1400)
        End If
        MyPrintDocument.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)
        MyDataGridViewPrinter = New DataGridViewPrinter(MyDataGridView, MyPrintDocument, False, True, GlobalOrganizationName & Environment.NewLine & "Certified Members Report as of " & Format(Now, "MMMM dd, yyyy"), New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function
    ' The PrintPage action for the PrintDocument control
    Private Sub MyPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub
    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnChooser.txttype.Text = "colmember"
        frmColumnChooser.Show(Me)
    End Sub

    Private Sub cmdPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintPreview.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = MyPrintDocument
            MyPrintPreviewDialog.WindowState = FormWindowState.Maximized
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Synchronize online data may take a while, depending on the amount of data and internet connectivity. " & Environment.NewLine & "Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ViewLocalActiveData()
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmMembershipForm.txtmemberid.Text = MyDataGridView.Item("Membership ID", MyDataGridView.CurrentRow.Index).Value()
        frmMembershipForm.mode.Text = "edit"
        frmMembershipForm.Show(Me)
    End Sub


    Private Sub TagAsInactiveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagAsInactiveMemberToolStripMenuItem.Click
        If MessageBox.Show("Taging " & StrConv(MyDataGridView.Item("Fullname", MyDataGridView.CurrentRow.Index).Value(), vbProperCase) & " as inactive member!" & Environment.NewLine & "Are you sure you want to continue?" & Environment.NewLine & Environment.NewLine & "Note: Inactived accounts will not be included in a master list of global members. to activate back the inactivate accounts you must send request to the admistrator at " & globalOfficialEmail & " for the activation.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblglobalmembers set isactive=0 where memberid='" & MyDataGridView.Item("Membership ID", MyDataGridView.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            FilterActiveAccounts()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If SetupThePrinting() Then
            MyPrintDocument.Print()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class