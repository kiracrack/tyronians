Imports DevExpress.XtraGrid.Views.Grid

Module DXPrinting

    Public Sub DXPrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
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
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<div align='center' style='margin-bottom:20px;'><img position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/logo.png'></div>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", DXSetupTheGridviewPrinter(TableTitle, gv)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", "Ma. Editha Maguinsay"), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", "Operation Manager"), False)

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function DXSetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next

        'MsgBox(width)
        TableHeaderStart = "<table border='1' style='margin:3px 0; " & If(width < 600, "min-width:700px;", "") & "' cellpadding='4' cellspacing='0'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "IF OBJECT_ID('tempdb..#temptableprinting') IS NOT NULL DROP TABLE #temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TABLE #temptableprinting ([columnname] [varchar](50) NULL,[colindex] [int] NOT NULL,[colwidth] [float] NOT NULL) ON [PRIMARY]" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into #temptableprinting (columnname,colindex,colwidth) values ('" & gv.Columns(I).FieldName & "','" & gv.Columns(I).VisibleIndex & "','" & gv.Columns(I).Width & "')" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from #temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from #temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 Then
                    columnSize = " width='350' "
                ElseIf rst("columnname").ToString = "Date" Then
                    columnSize = " width='100' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>").Replace("|", "<br/>").Replace(vbCrLf, "<br/>").Replace(vbCr, "<br/>").Replace(vbLf, "<br/>")

                rowRowTableData += "<td " & colalignment & columnSize & ">" & CellData & "</td> "
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns

                If col.Name = "colbold" Then

                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "bold").ToString) = True Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next

        Dim SummaryRow As String = "" : Dim SummaryColumn As String = ""
        If gv.OptionsView.ShowFooter = True Then
            For Each col In gv.Columns
                If col.Visible = True Then
                    SummaryColumn += "<td align='center'>" & col.SummaryText & "</td>"
                End If

            Next

            'For Each col As String In gv.Columns
            '    If col <> "" Then
            '        For I = 0 To gv.Columns.Count - 1

            '        Next
            '    End If
            'Next
        End If
        SummaryRow = "<tr style='font-weight:bold'>" & SummaryColumn & "</tr>"
        DXSetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return DXSetupTheGridviewPrinter
    End Function
End Module
