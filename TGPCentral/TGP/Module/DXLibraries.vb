Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraReports.UI

Imports System.IO
Imports System.Drawing.Imaging
Imports DevExpress.XtraSplashScreen
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient


Module Libraries
    Public bmpScreenShot As Bitmap
    Public gfxScreenshot As Graphics
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

    Public Sub ShowBadgeNumber(ByVal Count As String, ByVal devControl As Control, ByVal UImanager As AdornerUIManager)
        Dim Badge = New DevExpress.Utils.VisualEffects.Badge()
        Badge.TargetElement = devControl
        Badge.TargetElementRegion = TargetElementRegion.Header
        If Count > 0 Then
            Badge.Visible = True
        Else
            Badge.Visible = False
        End If

        Badge.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
        Badge.Properties.AllowImage = DevExpress.Utils.DefaultBoolean.True
        Badge.Properties.StretchImage = DevExpress.Utils.DefaultBoolean.True
        Badge.Properties.Location = ContentAlignment.TopRight
        Badge.Properties.Text = Count
        Badge.Properties.Offset = New Point(Convert.ToInt32(0), Convert.ToInt32(0))
        Badge.Properties.TextMargin = New System.Windows.Forms.Padding(3)
        Badge.Properties.ImageStretchMargins = New System.Windows.Forms.Padding(14)
        Badge.Appearance.BackColor = Color.Red
        UImanager.Elements.Add(Badge)
        'If Count = 0 Then
        '    UImanager.Elements.Clear()
        'End If
    End Sub

    Public Function DXLoadToComboBox(ByVal fld As String, ByVal tbl As String, ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = combo.Properties.Items
        Try
            If mode = True Then
                Coll.Clear()
                com.CommandText = "Select distinct(" & fld & ") from " & tbl & " order by " & fld & " asc"
                rst = com.ExecuteReader
                Coll.BeginUpdate()
                Try
                    While rst.Read
                        Coll.Add(rst(fld))
                    End While
                    rst.Close()
                Finally
                    Coll.EndUpdate()
                End Try
            End If
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Coll
    End Function
    Public Function DXLoadToComboBoxQuery(ByVal fld As String, ByVal fquery As String, ByVal tblandQuery As String, ByVal combo As DevExpress.XtraEditors.ComboBoxEdit)
        Dim Coll As ComboBoxItemCollection = combo.Properties.Items
        Try
            Coll.Clear()
            com.CommandText = "Select " & fquery & " from " & tblandQuery
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst(fld))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Coll
    End Function
    Public Function LoadXgrid(ByVal qry As String, ByVal tbl As String, ByVal Em As DevExpress.XtraGrid.GridControl, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            Dim dst = New DataSet : dst.Clear()
            xgrid.ClearGrouping()
            Em.DataSource = Nothing
            msda = New SqlDataAdapter(qry, conn)
            msda.SelectCommand.CommandTimeout = 600000
            msda.Fill(dst, tbl)
            Em.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Em.ForceInitialize()
            xgrid.BestFitColumns()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Message: " & errMYSQL.Message & vbCrLf _
                             & "Details: " & errMYSQL.StackTrace & Environment.NewLine _
                             & "Error Code: " & errMYSQL.ErrorCode, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function LoadXgridLookupEdit(ByVal qry As String, ByVal tbl As String, ByVal Xglue As DevExpress.XtraEditors.GridLookUpEdit, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim dst As New DataSet : dst.Clear()
            msda = New SqlDataAdapter(qry, conn)
            msda.Fill(dst, tbl)
            Xglue.Properties.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Xglue.Properties.View.BestFitColumns()
            Xglue.ForceInitialize()
            xgrid.BestFitColumns()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function LoadXgridLookupSearch(ByVal qry As String, ByVal tbl As String, ByVal Xglue As DevExpress.XtraEditors.SearchLookUpEdit, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            Dim dst As New DataSet : dst.Clear()
            msda = New SqlDataAdapter(qry, conn)
            msda.Fill(dst, tbl)
            Xglue.Properties.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Xglue.Properties.View.BestFitColumns()
            Xglue.ForceInitialize()
            If xgrid.RowCount > 0 Then
                xgrid.BestFitColumns()
            End If

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Sub UpdateGridColumnSetting(ByVal formname As String, ByVal gv As GridView)
        com.CommandText = "delete from tblcolumnindex where form='" & formname & "' and gridview='" & gv.Name & "'" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into tblcolumnindex set form='" & formname & "', gridview='" & gv.Name & "', columnname='" & gv.Columns(I).FieldName & "',columnwidth='" & gv.Columns(I).Width & "', colindex='" & gv.Columns(I).VisibleIndex & "'" : com.ExecuteNonQuery()
            End If
        Next
    End Sub

    Public Function XgridColCurrencyDecimalCount(ByVal column As Array, ByVal decimalplaces As Integer, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).DisplayFormat.FormatType = FormatType.Numeric
                            xgrid.Columns(col).DisplayFormat.FormatString = "n" & decimalplaces
                            xgrid.Columns(col).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        End If
                    Next


                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColCurrency(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).DisplayFormat.FormatType = FormatType.Numeric
                            xgrid.Columns(col).DisplayFormat.FormatString = "n"
                            xgrid.Columns(col).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        End If
                    Next


                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColNumber(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            xgrid.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
            xgrid.Columns(i).DisplayFormat.FormatString = "N0"
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColAlign(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal algn As DevExpress.Utils.HorzAlignment)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).AppearanceCell.TextOptions.HAlignment = algn
                            xgrid.Columns(col).AppearanceHeader.TextOptions.HAlignment = algn
                        End If
                    Next
                End If
            Next

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function


    Public Function XgridColMemo(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).ColumnEdit = MemoEdit
                            xgrid.Columns(col).AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap
                            xgrid.Columns(col).AppearanceCell.TextOptions.VAlignment = VertAlignment.Center
                        End If
                    Next
                End If
            Next

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Sub DXRemoveRows(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim Row As DataRow : Dim Rows() As DataRow
        ReDim Rows(xgrid.SelectedRowsCount - 1)
        For I = 0 To xgrid.SelectedRowsCount - 1
            Rows(I) = xgrid.GetDataRow(xgrid.GetSelectedRows(I))
        Next
        For Each Row In Rows
            Row.Delete()
        Next
    End Sub

    Public Function XgridAllowColumnEdit(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal allowedit As Boolean)
        Try
            For Each col As String In column
                xgrid.Columns(col).OptionsColumn.AllowEdit = allowedit
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColWidth(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal size As Integer)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).Width = size
                        End If
                    Next
                End If
            Next

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridGeneralSummaryCurrency(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).Summary.Clear()
                            xgrid.Columns(col).Summary.Add(DevExpress.Data.SummaryItemType.Sum, col, "{0:n}")
                            CType(xgrid.Columns(col).View, GridView).OptionsView.ShowFooter = True
                        End If
                    Next
                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridGeneralSummaryNumber(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).Summary.Clear()
                            xgrid.Columns(col).Summary.Add(DevExpress.Data.SummaryItemType.Sum, col, "{0:n0}")
                            CType(xgrid.Columns(col).View, GridView).OptionsView.ShowFooter = True
                        End If
                    Next
                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridGroupSummaryCurrency(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                'xgrid.GroupSummary.Clear()
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            Dim item As New GridGroupSummaryItem()
                            item.FieldName = col
                            item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            item.DisplayFormat = "{0:n}"
                            item.ShowInGroupColumnFooter = xgrid.Columns(col)
                            xgrid.GroupSummary.Add(item)
                        End If
                    Next
                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridHideColumn(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).Visible = False
                        End If
                    Next
                End If
            Next
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridDisableColumn(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).OptionsColumn.AllowEdit = False
                        End If
                    Next
                End If
            Next

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridEnableColumn(ByVal column As Array, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            For Each col As String In column
                If col <> "" Then
                    For I = 0 To xgrid.Columns.Count - 1
                        If col = xgrid.Columns(I).FieldName Then
                            xgrid.Columns(col).OptionsColumn.AllowEdit = True
                            'xgrid.Columns(col).OptionsColumn.AllowFocus = True
                        End If
                    Next
                End If
            Next

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Sub DXRemoveSpecialChar(ByVal panel As DevExpress.XtraEditors.PanelControl)
        Dim Ctl As Control
        Try
            For Each Ctl In panel.Controls
                If TypeOf Ctl Is DevExpress.XtraEditors.TextEdit Or TypeOf Ctl Is DevExpress.XtraEditors.ComboBoxEdit Or TypeOf Ctl Is DevExpress.XtraEditors.MemoEdit Then
                    Ctl.Text = Ctl.Text.Replace("'", "''")
                    Ctl.Text = Ctl.Text.Replace("\", "\\")
                End If
            Next Ctl
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function DXCheckSelectedRow(ByVal col As String, ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
        Try
            If Xgrid.GetFocusedRowCellValue(col).ToString = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DXCheckSelectedRow = False
            Else
                DXCheckSelectedRow = True
            End If
        Catch errMS As Exception
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DXCheckSelectedRow = False
        End Try
    End Function
    Public Function DXRemovedNoValueColumn(ByVal col As String, ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim removeColumn As Boolean = True
            For I = 0 To Xgrid.RowCount - 1
                If Xgrid.GetRowCellValue(I, col) <> "" Then
                    removeColumn = False
                End If
            Next
            If removeColumn = True Then
                Xgrid.Columns(col).Visible = False
            End If
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function DXRemoveRow(ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer
        ReDim Rows(Xgrid.SelectedRowsCount - 1)
        For I = 0 To Xgrid.SelectedRowsCount - 1
            Rows(I) = Xgrid.GetDataRow(Xgrid.GetSelectedRows(I))
        Next
        For Each Row In Rows
            Row.Delete()
        Next
    End Function
    Public Function DXDeleteRow(ByVal col As String, ByVal fld As String, ByVal tbl As String, ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim todelete As String = ""
            ReDim Rows(Xgrid.SelectedRowsCount - 1)
            For I = 0 To Xgrid.SelectedRowsCount - 1
                Rows(I) = Xgrid.GetDataRow(Xgrid.GetSelectedRows(I))
                todelete = Xgrid.GetRowCellValue(Xgrid.GetSelectedRows(I), col)
                com.CommandText = "DELETE from " & tbl & " where " & fld & "='" & todelete & "'"
                rst = com.ExecuteReader() : rst.Close()
            Next
            For Each Row In Rows
                Row.Delete()
            Next
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Sub DXColumnViewSettings(ByVal parameter As String, ByVal gv As GridView)
        Try
            com.CommandText = "select * from tblcolumnindex where form='" & parameter & "' and gridview='" & gv.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                gv.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    gv.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If
            End While
            rst.Close()
        Catch ex As Exception
            rst.Close()
            com.CommandText = "DELETE FROM tblcolumnindex where form='" & parameter & "' and gridview='" & gv.Name & "'" : com.ExecuteNonQuery()
        End Try
    End Sub

    Public Function DXResizeImage(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal imgsize As Integer, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If Not img.Image Is Nothing Then
                Dim Original As New Bitmap(img.Image)
                img.Image = Original

                Dim m As Int32 = imgsize
                Dim n As Int32 = m * Original.Height / Original.Width

                Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
                Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

                Dim g As Graphics = Graphics.FromImage(Thumb)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

                g.DrawImage(Original, New Rectangle(0, 0, m, n))
                img.Image = Thumb
            End If
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function DXUpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        arrImage = Nothing
        sqlcmd.Dispose()
        Try
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            If countqry(tbl, qry) = 0 Then
                sql = "insert into " & tbl & " set " & fld & " = @file, " & qry
            Else
                sql = "Update " & tbl & " set " & fld & " = @file where " & qry
            End If

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function DXInsertImage(ByVal fld As String, ByVal otherField As String, ByVal tbl As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        arrImage = Nothing
        Try
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            sql = "Insert into " & tbl & " set " & fld & " = @file " & otherField

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function



    Public Function DXUpdateIcon(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal format As System.Drawing.Imaging.ImageFormat, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        arrImage = Nothing
        Try
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, format)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            sql = "Update " & tbl & " set " & fld & " = @file where " & qry

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return 0
    End Function

    Public Function DXShowImage(ByVal fld As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                Ximg.Image = img
            End If
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function DXUpdateReportTitle(ByVal Title As String, ByVal customText As String, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If countqry("tblreportsetting", "formname='" & myform.Name.ToString & "'") = 0 Then
                com.CommandText = "insert into tblreportsetting set formname='" & myform.Name.ToString & "',title='" & Title & "', customtext='" & customText & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblreportsetting set title='" & Title & "', customtext='" & customText & "' where formname='" & myform.Name.ToString & "' " : com.ExecuteNonQuery()
            End If
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Sub DXAddRowXgrid(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            Dim currentRow As Integer
            currentRow = View.FocusedRowHandle
            If currentRow < 0 Then
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow)
            End If
            View.AddNewRow()
        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetArrayList(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String) As ArrayList
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            GetArrayList.Add(rst(field).ToString)
        End While
        rst.Close()
        Return GetArrayList
    End Function


    Public Function ReadFile(ByVal path As String) As String
        Dim oReader As StreamReader
        oReader = New StreamReader(path, True)
        ReadFile = oReader.ReadToEnd
        oReader.Close()
        Return ReadFile
    End Function

    Public Function WriteFile(ByVal Value As String, ByVal filePath As String)
        If System.IO.File.Exists(filePath) = True Then
            System.IO.File.Delete(filePath)
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(filePath, True)
        detailsFile.WriteLine(Value)
        detailsFile.Close()

    End Function

    ' Call this function to remove the key from memory after it is used for security.
    Private Declare Sub ZeroMemory Lib "kernel32.dll" Alias "KiracrackWorld" (ByVal Destination As String, ByVal Length As Integer)
    ' Function to generate a key.
    Function GenerateKey() As String
        ' Create an instance of Symmetric Algorithm. The key and the IV are generated automatically.
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()

        ' Use the automatically generated key for encryption. 
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)
    End Function

    Public Sub EncryptFile(ByVal sInputFilename As String, _
                    ByVal sOutputFilename As String, _
                    ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        'Set secret key for DES algorithm.
        'A 64-bit key and an IV are required for this provider.
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the DES encryptor from this instance.
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        'Create the crypto stream that transforms the file stream by using DES encryption.
        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)

        'Read the file text to the byte array.
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        'Write out the DES encrypted file.
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub

    Public Sub DecryptFile(ByVal sInputFilename As String, _
       ByVal sOutputFilename As String, _
       ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        'A 64-bit key and an IV are required for this provider.
        'Set the secret key for the DES algorithm.
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the file stream to read the encrypted file back.
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        'Create the DES decryptor from the DES instance.
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        'Create the crypto stream set to read and to do a DES decryption transform on incoming bytes.
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        'Print out the contents of the decrypted file.
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

    Public Sub DXBandGridFormat(ByVal gv As GridView)
        gv.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        gv.Appearance.GroupFooter.Options.UseFont = True
        gv.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        gv.Appearance.GroupPanel.Options.UseFont = True
        gv.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        gv.Appearance.GroupRow.Options.UseFont = True
        gv.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        gv.Appearance.HeaderPanel.Options.UseFont = True
        gv.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        gv.Appearance.Row.Options.UseFont = True
        gv.Appearance.Row.Options.UseTextOptions = True
        gv.OptionsView.ColumnAutoWidth = False
        gv.OptionsView.RowAutoHeight = False
        gv.OptionsCustomization.AllowGroup = False
        gv.OptionsView.ShowGroupPanel = False
        gv.OptionsBehavior.Editable = False
    End Sub

    Public Sub SaveFilterColumn(ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal filterName As String)
        Dim file_conn As String = Application.StartupPath.ToString & "\Config\" & filterName
        If System.IO.File.Exists(file_conn) = True Then
            Dim sr As StreamReader = File.OpenText(file_conn)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0

                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        Xgrid.Columns(cnt).Visible = True
                    Else
                        Xgrid.Columns(cnt).Visible = False
                    End If
                    cnt = cnt + 1
                Next

                sr.Close()
            Catch errMS As Exception
                XtraMessageBox.Show("Message: Invalid column filter format! Please update your columns" & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sr.Close()
            End Try
        End If
    End Sub
    Public Function DXExportGridToExcel(ByVal filename As String, ByVal gv As GridView)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Microsoft Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = filename & ".xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            gv.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return True
    End Function

    Public Function CopyGridControl(ByVal grid As GridControl) As WinControlContainer
        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 0)
        winContainer.Size = New Size(0, 0)
        ' Set the grid as a wrapped object.
        'grid.MainView.PaintStyleName = "Web"
        grid.MainView.OptionsPrint.ShowPrintExportProgress = True
        winContainer.WinControl = grid
        Return winContainer
    End Function

    Public Function DXShowReportSignature(ByVal userid As String, ByVal Ximg As DevExpress.XtraReports.UI.XRPictureBox)
        Try
            com.CommandText = "select * from tblaccounts where accountid ='" & userid & "'" : rst = com.ExecuteReader
            While rst.Read
                If rst("digitalsign").ToString <> "" Then
                    imgBytes = CType(rst("digitalsign"), Byte())
                    stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                    img = Image.FromStream(stream)
                    Ximg.Image = img
                End If
            End While
            rst.Close()

        Catch errMYSQL As SqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
End Module
