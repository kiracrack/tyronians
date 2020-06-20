Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic

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
        sb.Clear()
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString().Replace("'", "''")
    End Function
    Public Function createChapterID(ByVal areacode As String)
        Dim newid = "" : Dim currentid = "" : Dim sequenceno = "" : Dim initialno = ""
        'G01-100000002-A array.ElementAt(7)
        Dim array() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        If Rowcount("tblglobalchapters") = 0 Then
            newid = globalareacode & "-100000001-A"
        Else
            currentid = qrysingledata("newid", "mid(chaptercode,8,9) as newid", "tblglobalchapters order by mid(chaptercode,8,9) desc limit 1")
            initialno = qrysingledata("newid", "mid(chaptercode,8,1) as newid", "tblglobalchapters order by mid(chaptercode,8,9) desc limit 1")
            If Rowcount("tblglobalchapters") > 999999999 Then
                newid = globalareacode & "-100000001-" & array.ElementAt(0)
            Else
                newid = globalareacode & "-" & Val(currentid + 1) & "-" & array.ElementAt(Val(initialno) - 1)
            End If
        End If
        Return newid
    End Function

    Public Function createMemberID(ByVal fullname As String, ByVal chapter As String, ByVal datesurvive As Date)
        Dim newid = "" : Dim currentid = "" : Dim initialno = ""
        Dim initialName As String = ""
        Dim cnt As Integer = 0
        For Each strresult In fullname.Split(New Char() {" "c})
            cnt = cnt + 1
            If cnt > 0 And cnt < 3 Then
                initialName += strresult.Remove(1, strresult.Count - 1)
            End If
        Next
        'WB2003-0224D-100000001-A
        Dim array() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        If Rowcount("tblglobalmembers") = 0 Then
            newid = initialName & datesurvive.Year & "-" & Format(datesurvive, "MM") & Format(datesurvive, "dd") & chapter.Remove(1, chapter.Count - 1) & "-100000001-A"
        Else
            currentid = qrysingledata("newid", "mid(memberid,14,9) as newid", "tblglobalmembers order by mid(memberid,14,9) desc limit 1")
            initialno = qrysingledata("newid", "mid(memberid,14,1) as newid", "tblglobalmembers order by mid(memberid,14,9) desc limit 1")
            newid = initialName & datesurvive.Year & "-" & Format(datesurvive, "MM") & Format(datesurvive, "dd") & chapter.Remove(1, chapter.Count - 1) & "-" & Val(currentid + 1) & "-" & array.ElementAt(Val(initialno) - 1)
        End If
        Return newid
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
    Public Function RemoveEmptyColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() <> String.Empty Then
                        visibility = True
                        Exit For
                    End If
                Next
                grdView.Columns(clm.Index).Visible = visibility
            End If
        Next
        Return grdView
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
End Module
