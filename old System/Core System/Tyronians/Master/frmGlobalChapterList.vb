Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmGlobalChapterList
    ' The class that will do the printing process.
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Private FILE_NAME As String = Application.StartupPath.ToString & "\colchapter"
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = StrConv(GlobalOrganizationName, vbProperCase) & " " & Me.Text
        ViewLocalData()
    End Sub

    Public Sub ViewOnlineData()
        Dim filterqry As String = ""
        If globalpermission = 0 Then
            filterqry = ""

        ElseIf globalpermission = 1 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and (tblaccounts.regby='" & globaluserid & "' or underchapter='" & globalchaptercode & "' or trnby='" & globaluserid & "')"

        ElseIf globalpermission = 2 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and trnby='" & globaluserid & "'"

        End If
        dst = New DataSet
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select tblglobalchapters.chaptercode as 'Chapter Code',(select areaname from tblchapterarea where areacode =  tblglobalchapters.areacode) as 'Area' , " _
                                          + " chaptername as 'Chapter Name', " _
                                          + " tblglobalchapters.address as 'Complete Address', " _
                                          + " cast(datefounded as char(25)) as 'Date Founded', " _
                                          + " foundedby as 'Founded by', " _
                                          + " organizedby as 'Organized by', " _
                                          + " ifnull((select fullname from tblglobalmembers where memberid = tblglobalchapters.contactperson),'-') as 'Contact Person'," _
                                          + " ifnull((select mobilenumber from tblglobalmembers where memberid = tblglobalchapters.contactperson),'-') as 'Contact Number'," _
                                          + " case when mainchapter = 1 then 'MAIN CHAPTER' else (select b.chaptername from tblglobalchapters as b where b.chaptercode = tblglobalchapters.underchapter and b.mainchapter=1) end as 'Main Chapter', " _
                                          + " cast(date_format(dateadded,'%M %d, %Y %r') as char(45)) as 'Date Added', " _
                                          + " (select fullname from tblaccounts where accountid = tblglobalchapters.trnby) as 'Created by'" _
                                          + " From tblglobalchapters inner join tblaccounts on accountid=tblglobalchapters.trnby " & filterqry & " order by chaptername asc", conn)

        msda.Fill(dst, "tblglobalchapters")
        dst.WriteXml(Application.StartupPath & "\glglobalchapter.xml")
        Me.Cursor = Cursors.Default

    End Sub
    Public Sub GridFilters()
        If System.IO.File.Exists(Application.StartupPath & "\colchapter") = True Then
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
        CenterDashColumns(MyDataGridView)
    End Sub
    Public Function CenterColumn(ByVal grdView As DataGridView) As DataGridView
        Dim array() As String = {"Date Founded"}
        For Each valueArr As String In array
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    GridColAlign(valueArr, grdView, DataGridViewContentAlignment.MiddleCenter)
                End If
            Next
        Next
        Return grdView
    End Function
    Public Sub ViewLocalData()
        ViewOnlineData()
        If System.IO.File.Exists(Application.StartupPath & "\glglobalchapter.xml") = True Then
            dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\glglobalchapter.xml")
            MyDataGridView.DataSource = dst
            If dst.Tables.Count <> 0 Then
                MyDataGridView.DataMember = "tblglobalchapters"
                GridFilters()
            End If
        Else
            ViewOnlineData()
        End If
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        ViewLocalData()
    End Sub

    Private Sub cmdAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddnew.Click
        frmChapterInformation.Show(Me)
    End Sub

    Private Sub textsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textsearch.TextChanged
        Dim view As New DataView
        If System.IO.File.Exists(Application.StartupPath & "\glglobalchapter.xml") = False Then
            dst.WriteXml(Application.StartupPath & "\glglobalchapter.xml")
        End If
        dst = New DataSet : MyDataGridView.DataSource = Nothing : dst.ReadXml(Application.StartupPath & "\glglobalchapter.xml")
        MyDataGridView.DataSource = dst
        If dst.Tables.Count <> 0 Then
            MyDataGridView.DataMember = "tblglobalchapters"
            view.Table = dst.Tables("tblglobalchapters")
            view.RowFilter = "[Chapter Code] like '" & textsearch.Text & "%' or " _
                          + " [Chapter Name] like '" & textsearch.Text & "%'"
            MyDataGridView.DataSource = view
            GridFilters()
        End If
    End Sub

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
        MyDataGridViewPrinter = New DataGridViewPrinter(MyDataGridView, MyPrintDocument, False, True, GlobalOrganizationName & Environment.NewLine & "Certified Chapters Report as of " & Format(Now, "MMMM dd, yyyy"), New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point), Color.Black, True)
        Return True
    End Function
    ' The PrintPage action for the PrintDocument control
    Private Sub MyPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MyPrintDocument.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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
            ViewLocalData()
        End If
    End Sub

    Private Sub cmdOnlineData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOnlineData.Click
        If MessageBox.Show("Synchronize online data may take a while, depending on the amount of data and internet connectivity. " & Environment.NewLine & "Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ViewOnlineData()
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmChapterInformation.chaptercode.Text = MyDataGridView.Item("Chapter Code", MyDataGridView.CurrentRow.Index).Value()
        frmChapterInformation.mode.Text = "edit"
        frmChapterInformation.Show(Me)
    End Sub

    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = "colchapter"
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnChooser.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If SetupThePrinting() Then
            MyPrintDocument.Print()
        End If
    End Sub
End Class