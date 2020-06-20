Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Module library
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sql As String
    Public arrImage() As Byte = Nothing
    Public proFileImg As Boolean
    Public TargetFile As String
    Public ico As Icon

    Public Sub ApplySystemTheme(ByVal toolstrp As ToolStrip, ByVal colorscheme As String, ByVal fontcolor As String)
        Dim RGB As String() = colorscheme.Split(",")
        Try
            toolstrp.BackgroundImage = Nothing
            toolstrp.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
            toolstrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            If fontcolor = "LIGHT" Then
                For Each ctrl In toolstrp.Items
                    If Not (TypeOf ctrl Is ToolStripComboBox) And Not (TypeOf ctrl Is ToolStripTextBox) Then
                        ctrl.ForeColor = Color.LightGray
                    End If
                Next
            Else
                For Each ctrl In toolstrp.Items
                    ctrl.ForeColor = Color.Black
                Next
            End If
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function rchar(ByVal str As String)
        If str = Nothing Then Exit Function
        str = str.Replace("'", "''")
        str = str.Replace("’", "''")
        str = str.Replace("\", "\\")
        Return str
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
        com.CommandText = "select top 1 " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field.ToString).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function qryDate(ByVal field As String, ByVal fqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry : rst = com.ExecuteReader
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

    Public Function ConvertImage(ByVal fld As String) As Image
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                ConvertImage = img
            Else
                ConvertImage = Nothing
            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ConvertImage
    End Function

    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function
    Public Function ConvertTime(ByVal d As Date)
        Return d.ToString("HH:mm:ss")
    End Function
    Public Function ConvertDateTime(ByVal d As DateTime)
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
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
        'if log login as Dean of Academic Acc ====This code is ERRORcom.CommandText = query : rst = com.ExecuteReader=====' 
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(New ComboBoxItem(rst(fields).ToString, rst(id.ToString)))
            End If
        End While
        rst.Close()
        Return 0

    End Function
    Public Function LoadToToolStripComboBox(ByVal query As String, ByVal fields As String, ByVal id As String, ByVal cb As Windows.Forms.ToolStripComboBox)
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
        Else
            gridview.Columns(ColumnName).ReadOnly = False
            gridview.Columns(ColumnName).DefaultCellStyle.BackColor = Color.White

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

    Public Function getIncrementID(ByVal tableName As String) As String
        getIncrementID = ""
        com.CommandText = "SELECT AUTO_INCREMENT as ID FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" & sqldatabase & "' AND TABLE_NAME   = '" & tableName & "';" : rst = com.ExecuteReader
        While rst.Read
            getIncrementID = rst("ID").ToString
        End While
        rst.Close()
        com.CommandText = "ALTER TABLE " & tableName & " AUTO_INCREMENT = " & Val(getIncrementID) + 1 & ";" : com.ExecuteNonQuery()
        Return getIncrementID
    End Function
    Public Function getcodeid(ByVal code As String, ByVal table As String, ByVal initialcode As String)
        Dim strng = ""
        Try
            If CInt(countrecord(table)) = 0 Then
                strng = initialcode
            Else
                com.CommandText = "select (" & code & " + 1) as code from " & table & " order by " & code & " desc limit 1" : rst = com.ExecuteReader()
                While rst.Read
                    strng = rst("code").ToString
                End While
                rst.Close()
            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return strng.ToString
    End Function
    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        If Not StringToCheck = Nothing Then
            For i = 0 To StringToCheck.Length - 1
                If Char.IsLetter(StringToCheck.Chars(i)) Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
    Public Function RGBColorConverter(ByVal RGBString As String) As Color
        Dim RGB As String() = RGBString.Split(",")
        If RGBString.Length > 0 Then
            RGBColorConverter = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        Else
            RGBColorConverter = Color.Black
        End If
    End Function
    Public Function RemoveWhiteSpaces(ByVal str As String, ByVal removeSpecialChar As Boolean)
        Dim newStrstr As String = Regex.Replace(str, " {2,}", " ")
        newStrstr = New String(newStrstr.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
        If removeSpecialChar = True Then
            newStrstr = RemoveSpecialCharacter(newStrstr)
        Else
            newStrstr = newStrstr.Replace("'", "''")
            newStrstr = newStrstr.Replace("\", "\\")
        End If

        Return newStrstr
    End Function

    Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As MemoryStream = New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Public Function ConvertDatabaseImage(ByVal fld As String, ByVal picbox As System.Windows.Forms.PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img

            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function ResizeBinaryImage(ByVal img As Image, ByVal imgsize As Integer)
        Try
            If Not img Is Nothing Then
                Dim Original As New Bitmap(img)
                img = Original

                Dim m As Int32 = imgsize
                Dim n As Int32 = m * Original.Height / Original.Width

                Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
                Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

                Dim g As Graphics = Graphics.FromImage(Thumb)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

                g.DrawImage(Original, New Rectangle(0, 0, m, n))
                img = Thumb
            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return img
    End Function

    Public Function ConvertImageBinary(ByVal fld As String)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)

            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return img
    End Function

    Public Function ShowImage(ByVal fld As String, ByVal picbox As PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img
                proFileImg = True
            Else
                picbox.Image = Global.TGP.My.Resources.Resources.blankimg
                proFileImg = False
            End If
        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
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

        Catch errMYSQL As SqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function CheckStringValue(ByVal val As String) As Boolean
        CheckStringValue = False
        Dim strCharacter As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim str As String = val
        For Each ch As Char In str
            If Array.IndexOf(strCharacter, ch) = -1 Then
                CheckStringValue = True
            End If
        Next

        Return CheckStringValue
    End Function

   
End Module
