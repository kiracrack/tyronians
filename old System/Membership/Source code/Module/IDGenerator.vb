Module IDGenerator
    Public Function GetChapterID(ByVal contrycode As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select globalchaptersequence from tblgeneralsettings" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("globalchaptersequence").ToString.Length
            strng = Val(rst("globalchaptersequence").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 7 Then
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
        com.CommandText = "UPDATE tblgeneralsettings set globalchaptersequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return contrycode & "-" & newNumber
    End Function

    Public Function GetMembershipID(ByVal fullname As String, ByVal datesurvive As Date)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select globalmembersequence from tblgeneralsettings" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("globalmembersequence").ToString.Length
            strng = Val(rst("globalmembersequence").ToString) + 1
        End While
        rst.Close()
        Dim initialName As String = ""
        Dim cnt As Integer = 0
        For Each strresult In fullname.Split(New Char() {" "c})
            cnt = cnt + 1
            If cnt > 0 And cnt < 3 Then
                initialName += strresult.Remove(1, strresult.Length - 1)
            End If
        Next
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 7 Then
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
        Dim masterID As String = initialName & datesurvive.Year & "-" & newNumber
        com.CommandText = "UPDATE tblgeneralsettings set globalmembersequence='" & newNumber & "'" : com.ExecuteNonQuery()
        Return masterID
    End Function
End Module
