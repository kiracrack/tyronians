Imports System.Data.SqlClient


Module General_Settings
    Public GlobalDrawDate As String
    Public GlobalDrawSched As String

    Public GlobalMSServer As String = "WINTER\SQLEXPRESS"
    Public GLobalMSEsername As String = "sysad"
    Public GlobalMSPassword As String = "1234"
    Public GlobalMSDatabase As String = "SMSServer"

    Public GlobalSystemName As String = "Tyronians Database Management"

    Public GlobalColorScheme As String = ""
    Public GlobalColorDashboard As String = ""
    Public GlobalFontColor As String = ""
    Public GlobalServerName As String = ""

     
    Public Function LeftString(ByVal str As String, ByVal str_lenght As Integer)
        Return Left(str, str_lenght)
    End Function
      
    Public Sub SendMessageByPrefix(ByVal contactnumber As String, ByVal content As String, ByVal EncriptText As Boolean)
        Try
            Dim dst_blast = New DataSet
            Dim msda_blast As New SqlDataAdapter("SELECT (select top 1 concat(cellnumber,',',gatewayname) from SMSServer.dbo.tblgateway where telco=a.telco ORDER BY RAND()) as gateway FROM SMSServer.dbo.tbltelcoprefix as a where prefix='" & Left(contactnumber, 6) & "'", conn)
            msda_blast.Fill(dst_blast, "tbltelcoprefix")
            For xxx = 0 To dst_blast.Tables(0).Rows.Count - 1
                With (dst_blast.Tables(0))
                    If .Rows(xxx)("gateway").ToString().Length > 10 Then
                        Dim Split As String() = .Rows(xxx)("gateway").ToString().Split(",")
                        SendMessageGateway(contactnumber, Split(0), content, Split(1), EncriptText)
                    End If
                End With
            Next
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SendIndividualMessage(ByVal id As String, ByVal content As String, ByVal EncriptText As Boolean)
        Try
            Dim dst_blast = New DataSet
            Dim msda_blast As New SqlDataAdapter("select * from tbluseraccounts where id='" & id & "'", conn)
            msda_blast.Fill(dst_blast, "tbluseraccounts")
            For cnt = 0 To dst_blast.Tables(0).Rows.Count - 1
                With (dst_blast.Tables(0))
                    SendMessageByPrefix(.Rows(cnt)("phonenumber").ToString(), content, EncriptText)
                End With
            Next
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SendMessageGateway(ByVal MessageTo As String, ByVal MessageFrom As String, ByVal MessageText As String, ByVal Gateway As String, ByVal EncriptText As Boolean)
        com.CommandText = "insert into SMSServer.dbo.MessageOut(MessageTo,MessageFrom,MessageText,MessageType,Gateway,UserId,UserInfo,Priority,Scheduled,IsRead,IsSent,encrypted) values('" & MessageTo & "','" & MessageFrom & "','" & If(EncriptText = True, Encrypt(rchar(MessageText), "east"), rchar(MessageText)) & "','sms.text','" & Gateway & "','','',1,current_timestamp,0,0," & If(EncriptText = True, "1", "0") & ")" : com.ExecuteNonQuery()
    End Sub

End Module
