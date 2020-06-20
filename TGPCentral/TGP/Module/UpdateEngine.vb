Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemDatabaseUpdater()
        On Error Resume Next
        Dim updateVersion As String = "" : Dim updateDescription As String = ""


        'updateVersion = "2019-01-12"
        'If CBool(qrysingledata("proceedupdate", " iif(databaseversion < '" & updateVersion & "',1,0) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc ")) = True Then
        '    com.CommandText = " CREATE TABLE [dbo].[tblcollectionstatus]([id] [int] IDENTITY(1,1) NOT NULL,[usherid] [int] NULL,[datedraw] [date] NULL,[collected] [tinyint] NULL CONSTRAINT [DF_tblcollectionstatus_collected]  DEFAULT ((0)), CONSTRAINT [PK_tblcollectionstatus] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    engineupdated = True
        'End If

        
        If engineupdated = True Then
            Dim dversion As Date = updateVersion
            MessageBox.Show("Your database engine was updated to Build Version " & dversion.ToString & Environment.NewLine & "Please view update list at ""Main System Menu"" > About > What's New!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs (databaseversion,dateupdate,appliedquery) values('" & nVersions & "',current_timestamp,'" & strQuery & "')" : com.ExecuteNonQuery()
        Return 0
    End Function
End Module
