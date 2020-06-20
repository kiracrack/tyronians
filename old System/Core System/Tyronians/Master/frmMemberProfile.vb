Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmMemberProfile

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMembershipForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        ConnectVerify()
        LoadArea()
        ViewInformation()
        LoadWorkHistory()
        LoadEducation()
        Me.Cursor = Cursors.Default
    End Sub


    Public Sub LoadArea()
        txtareacode.Text = globalareacode
        txtareaname.Text = qrysingledata("areaname", "areaname", "tblchapterarea where areacode='" & globalareacode & "'")
    End Sub

    
    Public Sub ViewInformation()
        com.CommandText = "select *,date_format(datesurvived,'%M %d, %Y') as 'dtsurvived', date_format(birthdate,'%M %d, %Y') as 'dtbirth', (select chaptername from tblglobalchapters where chaptercode=tblglobalmembers.chaptercode) as chapter, " _
                                + " (select areaname from tblchapterarea where areacode = tblglobalmembers.areacode) as area from tblglobalmembers  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtlastname.Text = rst("lastname").ToString
            txtfirstname.Text = rst("firstname").ToString
            txtmiddlename.Text = rst("middlename").ToString
            txtgender.Text = rst("gender").ToString
            txtnickname.Text = rst("nickname").ToString
            txtbirthdate.Text = rst("dtbirth").ToString
            txtbirthplace.Text = rst("birthplace").ToString
            txtpermanentaddress.Text = rst("permanentaddress").ToString
            txtcurrentaddress.Text = rst("currentaddress").ToString
            txtspecialskills.Text = rst("specialskills").ToString
            txtmobilenumber.Text = rst("mobilenumber").ToString
            txthomenumber.Text = rst("homenumber").ToString
            txtemailadd.Text = rst("emailadd").ToString
            txtincase_contactname.Text = rst("incase_contactname").ToString
            txtincase_contact.Text = rst("incase_contact").ToString
            txtincase_address.Text = rst("incase_address").ToString

            txtbaptizedname.Text = rst("baptizedname").ToString
            txtdatesurvived.Text = rst("dtsurvived").ToString

            txtrituals.Checked = rst("rituals")
            txtidcard.Checked = rst("idcard")

            txtchaptername.Text = rst("chapter").ToString
            txtareaname.Text = rst("area").ToString
            ShowImage("profileimg", picProfile)
        End While
        rst.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub


#Region "MEMBERSHIP COMPANY"
    Public Sub LoadWorkHistory()
        With gridWork
            .Columns.Clear()
            .Columns.Add("Company Name", "Company Name")
            .Columns.Add("Position", "Position")
            .Columns.Add("Date Period", "Date Period")
            .Columns.Add("Current Company", "Current Company")
        End With
        If countqry("tblmemberswork", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridWork.Rows.Clear()
            com.CommandText = "select  *,date_format(timeperiod,'%Y-%m-%d') as dt,case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberswork  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridWork
                    .Rows.Add(rst("companyname").ToString, rst("Position").ToString, rst("dt").ToString, rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridWork, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current Company", gridWork, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

#End Region

#Region "MEMBERSHIP EDUCATION"
    Public Sub LoadEducation()
        With gridEducation
            .Columns.Clear()
            .Columns.Add("School Name", "School Name")
            .Columns.Add("Level", "Level")
            .Columns.Add("Details", "Details")
            .Columns.Add("Date Period", "Date Period")
            .Columns.Add("Current School", "Current School")
        End With
        If countqry("tblmemberseduc", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridEducation.Rows.Clear()
            com.CommandText = "select  *,date_format(timeperiod,'%Y-%m-%d') as dt,case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberseduc  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridEducation
                    .Rows.Add(rst("schoolname").ToString, rst("schoollevel").ToString, rst("details").ToString, rst("dt").ToString, rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridEducation, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current School", gridEducation, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

#End Region

    Private Sub txtmemberid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This features will be available next version. please inquire and wait for the next update version. thank you", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class