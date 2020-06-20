Imports System.Windows.Forms
Imports System.IO

Module Library

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

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function

    Public Function ConvertServerTime(ByVal d As Date)
        Return d.ToString("HH:mm:00")
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
    Public Function CC(ByVal m As String)
        If m <> "" Then
            CC = Val(m.Replace(",", ""))
        End If
        Return CC
    End Function
    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function

    Public Function ConvertDateTime(ByVal d As DateTime)
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
    End Function

    Public Function CLearDateString(ByVal str As String)
        str = str.Replace(":", "")
        str = str.Replace("/", "")
        str = str.Replace("AM", "")
        str = str.Replace("PM", "")
        str = str.Replace(" ", "")
        Return str
    End Function
    Public Sub RecordLog(ByVal info As String, ByVal message As String)
        Dim fileName As String = CDate(Now).ToString("yyyy-MM-dd") & ".log"
        Dim path As String = Application.StartupPath.ToString & "\Log"
        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
        If Not System.IO.File.Exists(fileName) Then
            System.IO.File.Create(fileName)
        End If

        Dim sw As StreamWriter = File.AppendText(path & "\" & fileName)
        sw.WriteLine(CDate(Now).ToString("yyyy-MM-dd hh:mm:ss tt") & Chr(9) & info & " - " & message)
        sw.Close()
    End Sub
    Public Function CreateFile(ByVal filename As String)
        Dim path As String = Application.StartupPath.ToString & "\Log"
        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
        If Not System.IO.File.Exists(path & "\" & filename) Then
            System.IO.File.Create(path & "\" & filename)
        End If
        Return True
    End Function
    Public Function DeleteFile(ByVal location As String, ByVal filename As String)
        If System.IO.File.Exists(location & filename) Then
            System.IO.File.Delete(location & filename)
        End If
        Return True
    End Function


    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Return value.Count(Function(c As Char) c = ch)
    End Function
End Module
