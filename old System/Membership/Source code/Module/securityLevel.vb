Module securityLevel
    Public screenHeight As Integer
    Public screenWidth As Integer
    Public screenres As String
    Public globallogin As Boolean
    Public globaluserid As String

    Public globalfullname As String
    Public globalposition As String
    Public globaladdress As String
    Public globalcontact As String
    Public globalusername As String

    Public globalchaptercode As String
    Public globalchaptername As String
    Public globalareacode As String
    Public globalareaname As String

    Public globalregby As String

    Public globalemail As String
    Public globalpermission As Integer

    Public Sub check_win()
        screenHeight = My.Computer.Screen.Bounds.Height
        screenWidth = My.Computer.Screen.Bounds.Width
        screenres = "236," + screenHeight
    End Sub

    Public Function LoadAccountDetails(ByVal userid As String)
        com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblaccounts.chaptercode) as chapter, " _
                                + " (select areaname from tblchapterarea where areacode = tblaccounts.areacode) as area from tblaccounts where accountid='" & userid & "'" : rst = com.ExecuteReader
        While rst.Read
            globalfullname = rst("fullname").ToString
            globalposition = StrConv(rst("position").ToString, vbProperCase)
            globaladdress = rst("address").ToString

            globalcontact = rst("contactno").ToString
            globalusername = DecryptTripleDES(rst("username").ToString)
            globalemail = rst("emailadd").ToString

            globalchaptercode = rst("chaptercode").ToString
            globalchaptername = rst("chapter").ToString

            globalareacode = rst("areacode").ToString
            globalareaname = rst("area").ToString
            globalpermission = Val(rst("permission").ToString)
            globalregby = rst("regby").ToString
        End While
        rst.Close()

        'If globalpermission = 1 Then
        '    globalicreated = qrysingledata("account", "group_concat(accountid) as account", "tblaccounts where regby='" & globaluserid & "'")
        'End If
        Return 0
    End Function
    Public Sub userexit()
        globallogin = False
        globaluserid = ""
        globalfullname = ""
        globalposition = ""
        globaladdress = ""

        globalcontact = ""
        globalusername = ""
        globalemail = ""

        globalchaptercode = ""
        globalareacode = ""
        globalpermission = 0
        conn.Close()
    End Sub
End Module

