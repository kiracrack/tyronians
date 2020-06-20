Imports System.IO
Imports System.Data.SqlClient

Module Printing
    Public Function PrintSetupHeader()
        PrintSetupHeader += "<p align='center' >Republic of the Philippines<br/><strong>Venus Games Portal</strong></br></br>" _
                            + "<br/> "
        Return PrintSetupHeader
    End Function
    Public Sub PrintViaInternetExplorer(ByVal location As String, ByVal form As Windows.Forms.Form)
        Try
            System.Diagnostics.Process.Start(location)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!",
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DataGridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!",
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'CreateHTMLReportTemplate("StandardReports.html")
        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReports.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase("")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase("")), False)

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintDatagridviewSignatories(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DataGridView,
                                            ByVal prepare_title As String, ByVal prepare_id As String,
                                            ByVal checked_title As String, ByVal checked_id As String,
                                            ByVal approved_title As String, ByVal approved_id As String, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!",
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsSignatory.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsSignatory.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)


        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DataGridView) As String

        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        TableHeaderStart = "<table border='1' style='min-width:730px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.ColumnCount & "' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        For i = 0 To gv.ColumnCount - 1
            If gv.Columns(i).Visible = True Then
                ColumnName += "<th>" & gv.Columns(i).Name & "</th>"
            End If
        Next
        TableHeaderEnd = " </tr> "
        For i = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = ""
            For x = 0 To gv.ColumnCount - 1
                If gv.Columns(x).Visible = True Then
                    Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                    If gv.Columns(gv.Columns(x).Name).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter Then
                        colalignment = "align='center'"

                        If gv.Item(gv.Columns(x).Name, i).Value() Is Nothing Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = gv.Item(gv.Columns(x).Name, i).Value().ToString
                        End If

                    ElseIf gv.Columns(gv.Columns(x).Name).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight Then
                        colalignment = "align='center'"
                        If gv.Item(gv.Columns(x).Name, i).Value().ToString = "" Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = FormatNumber(gv.Item(gv.Columns(x).Name, i).Value().ToString, 2)
                        End If
                    Else
                        If gv.Item(gv.Columns(x).Name, i).Value() Is Nothing Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = gv.Item(gv.Columns(x).Name, i).Value().ToString
                        End If
                    End If
                    If gv.Columns(x).Width = 300 Then
                        columnSize = " width='" & gv.Columns(x).Width.ToString & "' "
                    End If

                    rowRowTableData += "<td " & colalignment & columnSize & ">" & strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>") & "</td> "
                End If
            Next
            If gv.Rows(i).DefaultCellStyle.ForeColor = Color.Red Then
                rowColor = "ff0000"
            ElseIf gv.Rows(i).DefaultCellStyle.ForeColor = Color.Blue Then
                rowColor = "001a7a"
            Else
                rowColor = "000000"
            End If
            rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
        Next
        SetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + "</table>"
        Return SetupTheGridviewPrinter
    End Function

    Public Sub PrintIndividualEvaluationResult(ByVal facultyid As String, ByVal evaluatorid As String, ByVal department As String, ByVal schoolyear As String, ByVal period As String, ByVal semester As String, ByVal form As Form)
        Dim Template As String = Application.StartupPath.ToString & "\Templates\EvaluationIndividual.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\Evaluation-" & evaluatorid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)
        Dim TableTransaction As String = ""

        Dim OverallTotal As Double = 0
        msda = Nothing : dst = New DataSet
        msda = New SqlDataAdapter("select * from tblcategory order by categoryname asc", conn)
        msda.Fill(dst, 0)
        For i = 0 To dst.Tables(0).Rows.Count - 1
            Dim Tablehead As String = "" : Dim TableRow As String = "" : Dim totalCategory As Double = 0
            Tablehead = "<table border='1' style='width:730px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " & Chr(13)
            Tablehead += "<tr><th align='left'>" & dst.Tables(0).Rows(i)("categoryname").ToString() & "</th><th>Rating</th></tr>" & Chr(13)
            com.CommandText = "select * from tblquestioner inner join tblevaluationscore on tblquestioner.id=tblevaluationscore.qid where tblquestioner.catid='" & dst.Tables(0).Rows(i)("id").ToString() & "' and facultyid='" & facultyid & "' and evaluator='" & evaluatorid & "' order by sortorder asc" : rst = com.ExecuteReader
            While rst.Read
                TableRow += "<tr style='font-size: 13px'><td width='85%'>" & rst("sortorder").ToString & ". " & rst("question").ToString & "</td> <td align='center' style='font-size: 11px'>" & Chr(13)
                For x = Val(rst("totalpoints").ToString) To 1 Step -1
                    If x = Val(rst("score").ToString) Then
                        TableRow += "<span class='circle'>" & x & "</span> &nbsp;"
                        totalCategory += Val(rst("score").ToString)
                        OverallTotal += Val(rst("score").ToString)
                    Else
                        TableRow += x & "&nbsp;"
                    End If
                Next
                TableRow += "</td> </tr>" & Chr(13)
            End While
            rst.Close()
            TableTransaction += Tablehead + TableRow + "<tr><td align='right'></td><td style='padding: 5px; font-size: 12px;'>Score: <b><u>" & totalCategory & "</u></b></td></tr></table>" & Chr(13)
        Next
        com.CommandText = "select * FROM tbluseraccounts where id='" & facultyid & "' and department='" & department & "' and id in (select facultyid from tblevaluation where schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "');" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facultyname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facultyposition]", UCase(rst("position").ToString)), False)
        End While
        rst.Close()

        com.CommandText = "select *,(select fullname from tbluseraccounts where id=tblevaluation.evaluator) as evaluatorname, " _
                            + " (select position from tbluseraccounts where id=tblevaluation.evaluator) as evaluatorposition," _
                            + " date_format(rateperiodfrom,'%M %Y') as periodfrom, date_format(rateperiodto,'%M %Y') as periodto from tblevaluation where facultyid='" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' group by facultyid;" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[period_from]", UCase(rst("periodfrom").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[period_to]", UCase(rst("periodto").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[comments]", UCase(rst("comments").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[evaluatorname]", UCase(rst("evaluatorname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[evaluatorposition]", UCase(rst("evaluatorposition").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateevaluated]", UCase(rst("datetrn").ToString)), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[table]", TableTransaction), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[OverallTotal]", FormatNumber(OverallTotal, 2)), False)
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub


    Public Sub PrintEvaluationResult(ByVal facultyid As String, ByVal department As String, ByVal schoolyear As String, ByVal period As String, ByVal semester As String, ByVal form As Form)
        Dim Template As String = Application.StartupPath.ToString & "\Templates\EvaluationResult.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dir]", Application.StartupPath.ToString.Replace("\", "/")), False)

        com.CommandText = "select * FROM tbluseraccounts where id='" & facultyid & "' and department='" & department & "' and id in (select facultyid from tblevaluation where schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "');" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facultyname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[facultyposition]", UCase(rst("position").ToString)), False)
        End While
        rst.Close()

        com.CommandText = "select *  FROM tbluseraccounts where department='" & department & "' and dean=1;" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[ratedby]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[ratedposition]", UCase(rst("position").ToString)), False)
        End While
        rst.Close()

        com.CommandText = "select *, date_format(rateperiodfrom,'%M %Y') as periodfrom, date_format(rateperiodto,'%M %Y') as periodto from tblevaluation where facultyid='" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' group by facultyid;" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[period_from]", UCase(rst("periodfrom").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[period_to]", UCase(rst("periodto").ToString)), False)
        End While
        rst.Close()

        'GET SCORE FROM DEAN
        Dim Dean_OverAllTotal As Double = 0 : Dim Dean_Rate As Double = 0
        Dim Dean_FilterString As String = " facultyid='" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' and evaluator in (select e.id from tbluseraccounts as e where e.dean=1)"
        Dim Dean_TotalEvaluator As String = "(select count(*) from tblevaluation where " & Dean_FilterString & ") "
        com.CommandText = "SELECT " _
                       + " (select sum(score) from tblevaluationscore where catid=1 and " & Dean_FilterString & ")/" & Dean_TotalEvaluator & " as 'dean_commitment', " _
                       + " (select sum(score) from tblevaluationscore where catid=2 and " & Dean_FilterString & ")/" & Dean_TotalEvaluator & "  as 'dean_knowledge', " _
                       + " (select sum(score) from tblevaluationscore where catid=3 and " & Dean_FilterString & ")/" & Dean_TotalEvaluator & "  as 'dean_teaching', " _
                       + " (select sum(score) from tblevaluationscore where catid=4 and " & Dean_FilterString & ")/" & Dean_TotalEvaluator & "  as 'dean_management' " : rst = com.ExecuteReader
        While rst.Read
            Dim dean_commitment As Double = Val(rst("dean_commitment").ToString)
            Dim dean_knowledge As Double = Val(rst("dean_knowledge").ToString)
            Dim dean_teaching As Double = Val(rst("dean_teaching").ToString)
            Dim dean_management As Double = Val(rst("dean_management").ToString)

            Dean_OverAllTotal = Val(dean_commitment + dean_knowledge + dean_teaching + dean_management)
            Dean_Rate = Dean_OverAllTotal * 0.25

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_commitment]", FormatNumber(dean_commitment, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_knowledge]", FormatNumber(dean_knowledge, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_teaching]", FormatNumber(dean_teaching, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_management]", FormatNumber(dean_management, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_total]", FormatNumber(Dean_OverAllTotal, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dean_overall]", FormatNumber(Dean_Rate, 2)), False)
        End While
        rst.Close()


        'GET SCORE FROM PEER 
        Dim Peer_OverAllTotal As Double = 0 : Dim Peer_Rate As Double = 0
        Dim Peer_FilterString As String = " facultyid='" & facultyid & "' and evaluator<>'" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' and evaluator in (select e.id from tbluseraccounts as e where e.faculty=1)"
        Dim Peer_TotalEvaluator As String = "(select count(*) from tblevaluation where " & Peer_FilterString & ") "
        com.CommandText = "SELECT " _
                       + " (select sum(score) from tblevaluationscore where catid=1 and " & Peer_FilterString & ")/" & Peer_TotalEvaluator & " as 'peer_commitment', " _
                       + " (select sum(score) from tblevaluationscore where catid=2 and " & Peer_FilterString & ")/" & Peer_TotalEvaluator & "  as 'peer_knowledge', " _
                       + " (select sum(score) from tblevaluationscore where catid=3 and " & Peer_FilterString & ")/" & Peer_TotalEvaluator & "  as 'peer_teaching', " _
                       + " (select sum(score) from tblevaluationscore where catid=4 and " & Peer_FilterString & ")/" & Peer_TotalEvaluator & "  as 'peer_management' " : rst = com.ExecuteReader
        While rst.Read
            Dim peer_commitment As Double = Val(rst("peer_commitment").ToString)
            Dim peer_knowledge As Double = Val(rst("peer_knowledge").ToString)
            Dim peer_teaching As Double = Val(rst("peer_teaching").ToString)
            Dim peer_management As Double = Val(rst("peer_management").ToString)

            Peer_OverAllTotal = Val(peer_commitment + peer_knowledge + peer_teaching + peer_management)
            Peer_Rate = Peer_OverAllTotal * 0.25

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_commitment]", FormatNumber(peer_commitment, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_knowledge]", FormatNumber(peer_knowledge, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_teaching]", FormatNumber(peer_teaching, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_management]", FormatNumber(peer_management, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_total]", FormatNumber(Peer_OverAllTotal, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[peer_overall]", FormatNumber(Peer_Rate, 2)), False)
        End While
        rst.Close()


        'GET SCORE FROM SELF
        Dim Self_OverAllTotal As Double = 0 : Dim Self_Rate As Double = 0
        Dim self_FilterString As String = " facultyid='" & facultyid & "' and evaluator='" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' and evaluator in (select e.id from tbluseraccounts as e where e.faculty=1)"
        Dim self_TotalEvaluator As String = "(select count(*) from tblevaluation where " & self_FilterString & ") "
        com.CommandText = "SELECT " _
                       + " (select sum(score) from tblevaluationscore where catid=1 and " & self_FilterString & ")/" & self_TotalEvaluator & " as 'self_commitment', " _
                       + " (select sum(score) from tblevaluationscore where catid=2 and " & self_FilterString & ")/" & self_TotalEvaluator & "  as 'self_knowledge', " _
                       + " (select sum(score) from tblevaluationscore where catid=3 and " & self_FilterString & ")/" & self_TotalEvaluator & "  as 'self_teaching', " _
                       + " (select sum(score) from tblevaluationscore where catid=4 and " & self_FilterString & ")/" & self_TotalEvaluator & "  as 'self_management' " : rst = com.ExecuteReader
        While rst.Read
            Dim self_commitment As Double = Val(rst("self_commitment").ToString)
            Dim self_knowledge As Double = Val(rst("self_knowledge").ToString)
            Dim self_teaching As Double = Val(rst("self_teaching").ToString)
            Dim self_management As Double = Val(rst("self_management").ToString)

            Self_OverAllTotal = Val(self_commitment + self_knowledge + self_teaching + self_management)
            Self_Rate = Self_OverAllTotal * 0.25

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_commitment]", FormatNumber(self_commitment, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_knowledge]", FormatNumber(self_knowledge, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_teaching]", FormatNumber(self_teaching, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_management]", FormatNumber(self_management, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_total]", FormatNumber(Self_OverAllTotal, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[self_overall]", FormatNumber(Self_Rate, 2)), False)
        End While
        rst.Close()


        'GET SCORE FROM STUDENT
        Dim Stud_OverAllTotal As Double = 0 : Dim Stud_Rate As Double = 0
        Dim stud_FilterString As String = " facultyid='" & facultyid & "' and schoolyear='" & schoolyear & "' and concat(date_format(rateperiodfrom,'%b %Y'),' - ',date_format(rateperiodto,'%b %Y'))='" & period & "' and semester='" & semester & "' and evaluator in (select e.id from tbluseraccounts as e where e.student=1)"
        Dim stud_TotalEvaluator As String = "(select count(*) from tblevaluation where " & stud_FilterString & ") "
        com.CommandText = "SELECT " _
                       + " (select sum(score) from tblevaluationscore where catid=1 and " & stud_FilterString & ")/" & stud_TotalEvaluator & " as 'stud_commitment', " _
                       + " (select sum(score) from tblevaluationscore where catid=2 and " & stud_FilterString & ")/" & stud_TotalEvaluator & "  as 'stud_knowledge', " _
                       + " (select sum(score) from tblevaluationscore where catid=3 and " & stud_FilterString & ")/" & stud_TotalEvaluator & "  as 'stud_teaching', " _
                       + " (select sum(score) from tblevaluationscore where catid=4 and " & stud_FilterString & ")/" & stud_TotalEvaluator & "  as 'stud_management' " : rst = com.ExecuteReader
        While rst.Read
            Dim stud_commitment As Double = Val(rst("stud_commitment").ToString)
            Dim stud_knowledge As Double = Val(rst("stud_knowledge").ToString)
            Dim stud_teaching As Double = Val(rst("stud_teaching").ToString)
            Dim stud_management As Double = Val(rst("stud_management").ToString)

            Stud_OverAllTotal = Val(stud_commitment + stud_knowledge + stud_teaching + stud_management)
            Stud_Rate = Stud_OverAllTotal * 0.25

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_commitment]", FormatNumber(stud_commitment, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_knowledge]", FormatNumber(stud_knowledge, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_teaching]", FormatNumber(stud_teaching, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_management]", FormatNumber(stud_management, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_total]", FormatNumber(Stud_OverAllTotal, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[stud_overall]", FormatNumber(Stud_Rate, 2)), False)
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[overallscore]", FormatNumber(Dean_Rate + Peer_Rate + Self_Rate + Stud_Rate, 2)), False)
        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

End Module
