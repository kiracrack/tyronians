Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmChapterProfile

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadInformation()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub
    Public Sub LoadInformation()
        com.CommandText = "select *,(select b.chaptername from tblglobalchapters as b where b.chaptercode=tblglobalchapters.underchapter) as 'chapter', " _
                                + " (select areaname from tblchapterarea where areacode = tblglobalchapters.areacode) as area, " _
                                + " case when mainchapter = 1 then 'MAIN CHAPTER' else (select b.chaptername from tblglobalchapters as b where b.chaptercode = tblglobalchapters.underchapter and b.mainchapter=1) end as mchapter, " _
                                + " ifnull((select fullname from tblglobalmembers where memberid = tblglobalchapters.contactperson),'NOT AVAILABLE') as cperson,  " _
                                + " ifnull((select mobilenumber from tblglobalmembers where memberid = tblglobalchapters.contactperson),'NOT AVAILABLE') as cnumber,  " _
                                + " ifnull((select currentaddress from tblglobalmembers where memberid = tblglobalchapters.contactperson),'NOT AVAILABLE') as caddress,  " _
                                + " ifnull((select emailadd from tblglobalmembers where memberid = tblglobalchapters.contactperson),'NOT AVAILABLE') as eaddress  " _
                                + " from tblglobalchapters where chaptercode='" & chaptercode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtchaptername.Text = rst("chaptername").ToString
            txtaddress.Text = rst("address").ToString
            txtHistory.Text = rst("history").ToString
            txtfoundedby.Text = rst("foundedby").ToString
            txtorganizedby.Text = rst("organizedby").ToString
            txtdatefounded.Text = rst("datefounded").ToString
            txtUnderChapter.Text = rst("mchapter").ToString
            txtareaname.Text = rst("area").ToString

            txtContactPerson.Text = rst("cperson").ToString
            txtContactNumber.Text = rst("cnumber").ToString
            txtCurrentAddress.Text = rst("caddress").ToString
            txtEmailAddress.Text = rst("eaddress").ToString
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This features will be available next version. please inquire and wait for the next update version. thank you", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class