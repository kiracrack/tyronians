Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Module library
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
    Public proFileImg As Boolean

    '----------------email variables ----------------
    Public SendTo(1) As String
    Public FileAttach(1) As String
    Public strSubject As String
    Public strMessage As String

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function

    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function

    Public Function Rowcount(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "SELECT count(*) as cnt from " & tbl : rst = com.ExecuteReader()
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
        rst = com.ExecuteReader
        While rst.Read
            cnt = Val(rst("cnt").ToString)
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function GridColAlign(ByVal column As String, ByVal gridview As System.Windows.Forms.DataGridView, ByVal alignment As System.Windows.Forms.DataGridViewContentAlignment)
        gridview.Columns(column).DefaultCellStyle.Alignment = alignment
        gridview.Columns(column).HeaderCell.Style.Alignment = alignment
        Return 0
    End Function
   
    Public Function CenterDashColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() = "-" Then
                        grdView.Columns(clm.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        grdView.Columns(clm.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Exit For
                    End If
                Next
            End If
        Next
        Return grdView
    End Function
    Public Function UpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal picbox As System.Windows.Forms.PictureBox)
        arrImage = Nothing
        Try
            If Not picbox.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
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

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function ShowImage(ByVal fld As String, ByVal picbox As System.Windows.Forms.PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img
                proFileImg = True
            Else
                picbox.Image = Global.Tyronians.My.Resources.Resources.blankimg
                proFileImg = False
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function SendEmailMessage2(ByVal strFrom As String, ByVal strTo As String, ByVal strSubject As String, ByVal strMessage As String, ByVal fileList() As String) As Boolean
        Dim Host As String = globalMailHost
        Dim Port As Int16 = 587
        Dim SSL As Boolean = False

        ' Mail options
        Dim [To] As String = strTo
        Dim From As String = strFrom
        Dim Subject As String = strSubject
        Dim Body As String = strMessage

        Dim mm As New MailMessage(From, [To], Subject, Body)
        mm.IsBodyHtml = True
        Dim sc As New SmtpClient(Host, Port)
        Dim netCred As New NetworkCredential(globalOfficialEmail, globalEmailPassword)
        sc.EnableSsl = SSL
        sc.UseDefaultCredentials = False
        sc.Credentials = netCred
        Try
            Console.WriteLine("Sending e-mail message...")
            sc.Send(mm)
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: {0}", ex.ToString())
            Return False
        End Try
    End Function
   
    Public Function ConvertImageBinary(ByVal fld As String)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)

            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return img
    End Function

    Public Function PrintBarangayID(ByVal memberid As String, ByVal front As Boolean)
        If front = True Then
            Dim report As New rptIDFront()
            report.memberid.Text = memberid
            report.ShowRibbonPreviewDialog()
        Else
            Dim report As New rptIDBack()
            report.residentid.Text = memberid
            report.ShowRibbonPreviewDialog()
        End If

        Return 0
    End Function

    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function

    Public Function GridDisableColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).ReadOnly = True
                    ' MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Rate Type").ReadOnly = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridClearCell(ByVal grdView As DataGridView, ByVal column As Array, ByVal row As Integer, ByVal valuenumeric As Boolean)
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    If valuenumeric = True Then
                        grdView.Item(i, row).Value = 0
                    Else
                        grdView.Item(i, row).Value = ""
                    End If
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridCurrencyColumnDecimalCount(ByVal grdView As DataGridView, ByVal column As Array, ByVal decimalplaces As Integer) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n" & decimalplaces
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridCurrencyColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n2"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridColumnWidth(ByVal grdView As DataGridView, ByVal column As Array, ByVal width As Double) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Width = width
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridColumAutonWidth(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridNumberColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n0"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Sub GridColumnChoosed(ByVal grdView As DataGridView, ByVal file_dir As String)
        If System.IO.File.Exists(Application.StartupPath & "\Config\" & file_dir) = True Then
            Dim sr As StreamReader = File.OpenText(Application.StartupPath & "\Config\" & file_dir)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                For Each col In grdView.Columns
                    If Not DecryptTripleDES(columnChoosed).Contains(col.Name) Then
                        col.Visible = False
                    End If
                Next
                sr.Close()
            Catch errMS As Exception
                ' System.IO.File.Delete(Application.StartupPath & "\" & file_dir)
            End Try
        End If
    End Sub
    Public Function LoadToComboBox(ByVal cb As Windows.Forms.ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        Do While sr.Peek() >= 0
            Dim description As String = "" : Dim id As String = "" : Dim cnt As Integer = 0
            For Each word In sr.ReadLine().Split(New Char() {"|"c})
                If cnt = 0 Then
                    id = word
                ElseIf cnt = 1 Then
                    description = word
                End If
                cnt = cnt + 1
            Next
            If id <> "" Then
                cb.Items.Add(New ComboBoxItem(description, id))
            End If
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function ShowGridTotalSummary(ByVal captionLocation As String, ByVal totalColumn As String, ByVal grdView As DataGridView)
        grdView.AllowUserToAddRows = True
        grdView.Columns(totalColumn).Width = 200
        If grdView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To grdView.RowCount - 1
                totalsum = totalsum + grdView.Rows(i).Cells(totalColumn).Value()
            Next
            If captionLocation.Length > 0 Then
                grdView.Rows(grdView.RowCount - 1).Cells(captionLocation).Value = "Total"
            End If
            grdView.Rows(grdView.RowCount - 1).Cells(totalColumn).Value = totalsum
            grdView.Rows(grdView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            grdView.Rows(grdView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
    End Function
    Public Function LoadToComboBoxTxt(ByVal cb As Windows.Forms.ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        cb.Items.Clear()
        Do While sr.Peek() >= 0
            For Each word In sr.ReadLine().Split(New Char() {vbCrLf})
                cb.Items.Add(word)
            Next
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function LoadToComboBoxDBWithID(ByVal cb As Windows.Forms.ComboBox, ByVal path As String)
        Dim chpname As String = ""
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(path)
        cb.Items.Clear()
        Do While sr.Peek() >= 0
            For Each word In sr.ReadLine().Split(New Char() {vbCrLf})
                If word <> "" Then
                    cb.Items.Add(New ComboBoxItem(word.Split("|".ToCharArray)(0), word.Split("|".ToCharArray)(1)))
                End If
            Next
        Loop
        sr.Close()
        Return 0
    End Function
    Public Function LoadToComboBoxDB(ByVal query As String, ByVal fields As String, ByVal id As String, ByVal cb As Windows.Forms.ComboBox)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(New ComboBoxItem(rst(fields).ToString, rst(id.ToString)))
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Public Function CC(ByVal m As String)
        If m <> "" Then
            CC = Val(m.Replace(",", ""))
        End If
        Return CC
    End Function


    Public Function LoadToGridComboBox(ByVal query As String, ByVal fields As String, ByVal cb As Windows.Forms.DataGridViewComboBoxColumn)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(rst(fields).ToString)
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Public Function LoadToGridComboBoxCell(ByVal columnname As String, ByVal rowIndex As Integer, ByVal query As String, ByVal fields As String, ByVal allowBlankRow As Boolean, ByVal gridview As DataGridView)
        Dim dgvcc As New DataGridViewComboBoxCell
        dgvcc.Items.Clear()
        If allowBlankRow = True Then
            dgvcc.Items.Add("")
        End If
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                dgvcc.Items.Add(rst(fields).ToString)
            End If
        End While
        rst.Close()
        gridview.Item(columnname, rowIndex) = dgvcc
        Return 0
    End Function
     

    Public Function InputNumberOnly(ByVal textbox As System.Windows.Forms.TextBox, e As KeyPressEventArgs)
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = textbox.Text
            Dim selectionStart = textbox.SelectionStart
            Dim selectionLength = textbox.SelectionLength
            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Function
    Public Function RemoveEmptyColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            Dim visibility As Boolean = False
            For Each row As DataGridViewRow In grdView.Rows
                If row.Cells(clm.Index).Value.ToString() <> String.Empty Or Val(row.Cells(clm.Index).Value.ToString()) <> 0 Then
                    visibility = True
                    Exit For
                End If
            Next
            ' MsgBox(clm.Name)
            If clm.Name <> "id" And clm.Name <> "productid" Then
                grdView.Columns(clm.Name).Visible = visibility
            End If
        Next
        Return grdView
    End Function

    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
     
    Public Function RemoveSpecialCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*()_+-={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function RemoveFilenameCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*+={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function PopulateGridViewControls(ByVal ColumnName As String, ByVal ColumnWidth As Double, ByVal ColumnType As String, ByVal gridview As DataGridView, ByVal visible As Boolean, ByVal readonlycolumn As Boolean)
        If ColumnType = "COMBO" Then
            Dim dgcmbcol As DataGridViewComboBoxColumn
            dgcmbcol = New DataGridViewComboBoxColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.ReadOnly = False
            dgcmbcol.AutoComplete = False
            dgcmbcol.FlatStyle = FlatStyle.System
            gridview.Columns.Add(dgcmbcol)

        ElseIf ColumnType = "CHECKBOX" Then
            Dim colCheckbox As New DataGridViewCheckBoxColumn()
            colCheckbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            colCheckbox.ThreeState = False
            colCheckbox.TrueValue = 1
            colCheckbox.FalseValue = 0
            colCheckbox.IndeterminateValue = System.DBNull.Value
            colCheckbox.HeaderText = ColumnName
            colCheckbox.Width = ColumnWidth
            colCheckbox.Name = ColumnName
            colCheckbox.ReadOnly = False
            gridview.Columns.Add(colCheckbox)
        Else
            Dim dgcmbcol As DataGridViewColumn
            dgcmbcol = New DataGridViewColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.CellTemplate = New DataGridViewTextBoxCell
            gridview.Columns.Add(dgcmbcol)
        End If
        gridview.Columns(ColumnName).Visible = visible
        If readonlycolumn = True Then
            gridview.Columns(ColumnName).ReadOnly = True
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.LemonChiffon
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionBackColor = Color.LemonChiffon
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionForeColor = Color.Black
        Else
            gridview.Columns(ColumnName).ReadOnly = False
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.White
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionForeColor = Color.Black
        End If

        Return 0
    End Function


    Public Function PopulateGridViewColumns(ByVal ColumnName As String, ByVal ColumnWidth As Double, ByVal ComboBoxColumn As Boolean, ByVal gridview As DataGridView, ByVal visible As Boolean, ByVal readonlycolumn As Boolean)
        If ComboBoxColumn = True Then
            Dim dgcmbcol As DataGridViewComboBoxColumn
            dgcmbcol = New DataGridViewComboBoxColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.ReadOnly = False
            dgcmbcol.AutoComplete = False
            dgcmbcol.FlatStyle = FlatStyle.Flat
            gridview.Columns.Add(dgcmbcol)
        Else
            Dim dgcmbcol As DataGridViewColumn
            dgcmbcol = New DataGridViewColumn
            dgcmbcol.HeaderText = ColumnName
            dgcmbcol.Width = ColumnWidth
            dgcmbcol.Name = ColumnName
            dgcmbcol.CellTemplate = New DataGridViewTextBoxCell
            gridview.Columns.Add(dgcmbcol)
        End If
        gridview.Columns(ColumnName).Visible = visible
        If readonlycolumn = True Then
            gridview.Columns(ColumnName).ReadOnly = True
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.LemonChiffon
            gridview.Columns(ColumnName).DefaultCellStyle.SelectionBackColor = Color.LemonChiffon

        Else
            gridview.Columns(ColumnName).ReadOnly = False
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.White
        End If

        Return 0
    End Function

    Public Function LoadComboSuggestion(ByVal ColumnName As String, ByVal gridview As DataGridView, ByVal suggestionQuery As String, ByVal suggestionValue As String)
        Dim dgvcc As DataGridViewComboBoxColumn
        dgvcc = gridview.Columns(ColumnName)
        If suggestionQuery <> "" Then
            LoadToGridComboBox(suggestionQuery, suggestionValue, dgvcc)
        End If
        Return 0
    End Function

    Public Sub ExportGridToExcel(ByVal filename As String, ByVal dst As DataSet)
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(filename) & ".xls")
                MessageBox.Show(LCase(filename) & ".xls successfully exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Function GetSeriesGLPosting()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select glposting from tblseriesnumber" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("glposting").ToString.Length
            strng = Val(rst("glposting").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 10 Then
                newNumber = "0000000000" & strng
            ElseIf a = 9 Then
                newNumber = "000000000" & strng
            ElseIf a = 8 Then
                newNumber = "00000000" & strng
            ElseIf a = 7 Then
                newNumber = "0000000" & strng
            ElseIf a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblseriesnumber set glposting='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function
End Module
