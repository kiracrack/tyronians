Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmUserAccounts
    ' The class that will do the printing process.
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If globalpermission <> 0 Then
            Me.TabControl1.TabPages.RemoveByKey("TabPage2")
        End If
        tabFilter()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is TabPage1 Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewLocalActiveData()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewLocalRequestData()
        End If
    End Sub

    Public Sub ViewLocalActiveData()
        FilterActiveAccounts()
        If System.IO.File.Exists(Application.StartupPath & "\acctActivequery.xml") = True Then
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\acctActivequery.xml")
            MyDataGridView.DataSource = dst
            If dst.Tables.Count <> 0 Then
                MyDataGridView.DataMember = "tblaccounts"
                GridColAlign("Account ID", MyDataGridView, DataGridViewContentAlignment.MiddleCenter)
            End If
        Else
            FilterActiveAccounts()
        End If
    End Sub

    Public Sub ViewLocalRequestData()
        If System.IO.File.Exists(Application.StartupPath & "\acctRequestquery.xml") = True Then
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\acctRequestquery.xml")
            MyDataGridView.DataSource = dst
            If dst.Tables.Count <> 0 Then
                MyDataGridView.DataMember = "tblaccounts"
                GridColAlign("Account ID", MyDataGridView, DataGridViewContentAlignment.MiddleCenter)
            End If
        Else
            FilterRequestAccounts()
        End If
    End Sub

    Public Sub FilterActiveAccounts()
        Dim permissionfilter As String = ""
        Dim permissionqry As String = ""
        If globalpermission = 0 Then
            permissionfilter = "case when permission=0 then 'ROOT' when permission=1 then 'ADMINISTRATOR' when permission=2 then 'STANDARED USER' end as 'Permission',"
            permissionqry = ""
        Else
            permissionfilter = ""
            permissionqry = "and areacode='" & globalareacode & "' and (regby='" & globaluserid & "' or accountid='" & globaluserid & "') and blocklogin=0 and (permission=1 or permission=2)"
        End If
        dst = New DataSet
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select accountid as 'Account ID', " _
                                             + " Fullname , " _
                                             + " Position, " _
                                             + " Address, " _
                                             + " contactno as 'Contact No.', " _
                                             + " emailadd as 'Email Address'," _
                                             + " (select ifnull(chaptername,'NOT CONFIRM') from tblglobalchapters where chaptercode = tblaccounts.chaptercode) as 'Chapter', " _
                                             + " (select ifnull(areaname,'NOT CONFIRM') from tblchapterarea where areacode =  tblaccounts.areacode) as 'Area', " _
                                             + permissionfilter _
                                             + " (select b.fullname from tblaccounts as b where b.accountid = tblaccounts.regby) as 'Registered by', " _
                                             + " cast(date_format(datereg,'%M %d, %Y %r') as char(45)) as 'Date Registered' " _
                                             + " From tblaccounts where status=0 " & permissionqry & " order by accountid asc;", conn)
        msda.Fill(dst, "tblaccounts")
        dst.WriteXml(Application.StartupPath & "\acctActivequery.xml")
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub FilterRequestAccounts()
        Dim permissionfilter As String = ""
        Dim permissionqry As String = ""
        If globalpermission = 0 Then
            permissionfilter = "case when permission=0 then 'ROOT' when permission=1 then 'ADMINISTRATOR' when permission=2 then 'STANDARED USER' end as 'Permission',"
            permissionqry = ""
        Else
            permissionfilter = ""
            permissionqry = " and areacode='" & globalareacode & "' and (regby='" & globaluserid & "' or accountid='" & globaluserid & "') and blocklogin=0 and (permission=1 or permission=2)"
        End If
        dst = New DataSet
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select accountid as 'Account ID', " _
                                             + " Fullname , " _
                                             + " Position, " _
                                             + " Address, " _
                                             + " contactno as 'Contact No.', " _
                                             + " emailadd as 'Email Address'," _
                                             + " ifnull((select chaptername from tblglobalchapters where chaptercode = tblaccounts.chaptercode),chaptercode) as 'Chapter', " _
                                             + " ifnull((select areaname from tblchapterarea where areacode =  tblaccounts.areacode),areacode) as 'Area', " _
                                             + " case when permission=0 then 'ROOT' when permission=1 then 'ADMINISTRATOR' when permission=2 then 'STANDARED USER' end as 'Permission', " _
                                             + " cast(date_format(daterequest,'%M %d, %Y %r') as char(45)) as 'Date Request'," _
                                             + " requestremarks as 'Message', " _
                                             + " case when status=1 then 'NEW REQUEST' when status=0 then 'CONFIRMED' end as 'Account Status', " _
                                             + " (select b.fullname from tblaccounts as b where b.accountid = tblaccounts.regby) as 'Registered by', " _
                                             + " cast(date_format(datereg,'%M %d, %Y %r') as char(45)) as 'Date Registered' " _
                                             + " From tblaccounts where status=1 " & permissionqry & " order by accountid asc;", conn)
        msda.Fill(dst, "tblaccounts")
        dst.WriteXml(Application.StartupPath & "\acctRequestquery.xml")
        ViewLocalRequestData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Em_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub

    Private Sub cmdAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddnew.Click
        frmUserInformation.Show(Me)
    End Sub

    Private Sub textsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textsearch.TextChanged
        Dim view As New DataView
        If TabControl1.SelectedTab Is TabPage1 Then
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\acctActivequery.xml")
        Else
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\acctRequestquery.xml")
        End If
        MyDataGridView.DataSource = dst
        If dst.Tables.Count <> 0 Then
            MyDataGridView.DataMember = "tblaccounts"
            view.Table = dst.Tables("tblaccounts")
            view.RowFilter = "[Fullname] like '" & textsearch.Text & "%' "
            MyDataGridView.DataSource = view
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
        MyDataGridViewPrinter = New DataGridViewPrinter(MyDataGridView, MyPrintDocument, False, True, GlobalOrganizationName & Environment.NewLine & Me.Text, New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function
    ' The PrintPage action for the PrintDocument control
    Private Sub MyPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If SetupThePrinting() Then
            MyPrintDocument.Print()
        End If
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
            tabFilter()
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmUserInformation.userid.Text = MyDataGridView.Item("Account ID", MyDataGridView.CurrentRow.Index).Value()
        frmUserInformation.mode.Text = "edit"
        frmUserInformation.Show(Me)
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class