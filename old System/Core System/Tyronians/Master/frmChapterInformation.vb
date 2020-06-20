Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmChapterInformation

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmChapterInformation()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadArea()
        LoadChapters()
        If mode.Text <> "edit" Then
            txtdatefounded.Text = Format(Now, "yyyy-MM-dd")
        Else
            chaptercode.BackColor = Color.Yellow
            LoadContactPerson()
            LoadInformation()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub LoadArea()
        areacode.Text = globalareacode
        txtareaname.Text = qrysingledata("areaname", "areaname", "tblchapterarea where areacode='" & globalareacode & "'")
    End Sub
    Public Sub LoadChapters()
        Dim filterqry As String = ""
        If globalpermission = 0 Then
            filterqry = "where mainchapter=1"

        ElseIf globalpermission = 1 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and (tblaccounts.regby='" & globaluserid & "' or trnby='" & globaluserid & "')  and mainchapter=1"

        ElseIf globalpermission = 2 Then
            filterqry = "where tblglobalchapters.areacode='" & globalareacode & "' and (trnby='" & globalregby & "' or trnby='" & globaluserid & "')  and mainchapter=1"

        End If
        com.CommandText = "select tblglobalchapters.*,tblaccounts.regby from tblglobalchapters inner join tblaccounts on accountid=tblglobalchapters.trnby " & filterqry & " order by chaptername asc" : rst = com.ExecuteReader()
        txtUnderChapter.Items.Clear()
        While rst.Read()
            txtUnderChapter.Items.Add(New ComboBoxItem(rst("chaptername"), rst("chaptercode")))
        End While
        rst.Close()
    End Sub
    Public Sub LoadContactPerson()
        com.CommandText = "select * from tblglobalmembers where areacode='" & globalareacode & "' and chaptercode ='" & chaptercode.Text & "'" : rst = com.ExecuteReader()
        txtContactPerson.Items.Clear()
        While rst.Read()
            txtContactPerson.Items.Add(New ComboBoxItem(rst("fullname"), rst("memberid")))
        End While
        rst.Close()
        If txtContactPerson.Items.Count > 0 Then
            lblcontactperson.ForeColor = Color.Red
        Else
            lblcontactperson.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtUnderChapter.SelectedIndex = -1
            txtUnderChapter.Enabled = False
            lblunderchapter.ForeColor = Color.Black
        Else
            txtUnderChapter.SelectedIndex = -1
            txtUnderChapter.Enabled = True
            lblunderchapter.ForeColor = Color.Red
        End If
    End Sub

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        Dim chpname As String = ""
        If txtchaptername.Text.Contains("CHAPTER") = True Then
            chpname = txtchaptername.Text
        Else
            chpname = txtchaptername.Text & " CHAPTER"
        End If
        If txtchaptername.Text = "" Or txtchaptername.Text = "CHAPTER" Then
            MessageBox.Show("Please enter complete valid chapter name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtchaptername.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MessageBox.Show("Please enter complete complete address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtaddress.Focus()
            Exit Sub
        ElseIf txtdatefounded.Text = "" Then
            MessageBox.Show("Please enter valid date founded!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdatefounded.Focus()
            Exit Sub
        ElseIf CheckBox1.Checked = False And txtUnderChapter.Text = "" And mode.Text <> "edit" Then
            MessageBox.Show("Please select under chapter!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdatefounded.Focus()
            Exit Sub
        ElseIf countqry("tblglobalchapters", "chaptername='" & chpname & "'") <> 0 And mode.Text <> "edit" Then
            MessageBox.Show("This Chapter is already exists! please review your chapter list to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtchaptername.Focus()
            Exit Sub
        ElseIf txtContactPerson.Text = "" And txtContactPerson.Items.Count > 0 And mode.Text = "edit" Then
            MessageBox.Show("please select contact person", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactPerson.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save this information? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            If mode.Text = "edit" Then
                com.CommandText = "update tblglobalchapters set  " _
                                              + " areacode='" & areacode.Text & "', " _
                                              + " chaptername='" & chpname & "', " _
                                              + " address='" & txtaddress.Text & "', " _
                                              + " history='" & rchar(txtHistory.Text) & "', " _
                                              + " foundedby='" & txtfoundedby.Text & "', " _
                                              + " organizedby='" & txtorganizedby.Text & "', " _
                                              + " datefounded='" & txtdatefounded.Text & "', " _
                                              + " mainchapter='" & CheckBox1.CheckState & "', " _
                                              + " underchapter='" & underchapter.Text & "', " _
                                              + " dateedited=current_timestamp, " _
                                              + " issynch=1, " _
                                              + " editedby='" & globaluserid & "', " _
                                              + " contactperson='" & contactPersonID.Text & "'" _
                                              + " where chaptercode='" & chaptercode.Text & "'" : com.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                resetFields()
                MessageBox.Show("Chapter successfully save and updated! Please synchronize your chapter data to update your chapter list", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                com.CommandText = "insert into tblglobalchapters set chaptercode='" & createChapterID(globalareacode) & "', " _
                                               + " areacode='" & areacode.Text & "', " _
                                               + " chaptername='" & chpname & "', " _
                                               + " address='" & txtaddress.Text & "', " _
                                               + " history='" & rchar(txtHistory.Text) & "', " _
                                               + " foundedby='" & txtfoundedby.Text & "', " _
                                               + " organizedby='" & txtorganizedby.Text & "', " _
                                               + " datefounded='" & txtdatefounded.Text & "', " _
                                               + " mainchapter='" & CheckBox1.CheckState & "', " _
                                               + " underchapter='" & underchapter.Text & "', " _
                                               + " dateadded=current_timestamp, " _
                                               + " trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                resetFields()
                MessageBox.Show("Chapter successfully saved! Please synchronize your chapter data to update your chapter list", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtUnderChapter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnderChapter.SelectedValueChanged
        If txtUnderChapter.Text <> "" Then
            underchapter.Text = DirectCast(txtUnderChapter.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            underchapter.Text = ""
        End If
    End Sub
    Private Sub txtContactPerson_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtContactPerson.SelectedValueChanged
        If txtContactPerson.Text <> "" Then
            contactPersonID.Text = DirectCast(txtContactPerson.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            contactPersonID.Text = ""
        End If
    End Sub
    Private Sub cmdreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreset.Click
        resetFields()
    End Sub
    Public Sub resetFields()
        chaptercode.Text = "AUTO GENERATED"
        txtchaptername.Text = ""
        txtaddress.Text = ""
        txtHistory.Text = ""
        txtfoundedby.Text = ""
        txtorganizedby.Text = ""
        txtdatefounded.Text = Format(Now, "yyyy-MM-dd")
        CheckBox1.Checked = False
        txtUnderChapter.SelectedIndex = -1
        txtContactPerson.SelectedIndex = -1
        underchapter.Text = ""
        mode.Text = ""
    End Sub
    Public Sub LoadInformation()
        com.CommandText = "select *,(select b.chaptername from tblglobalchapters as b where b.chaptercode=tblglobalchapters.underchapter) as 'chapter', " _
                                + " (select areaname from tblchapterarea where areacode = tblglobalchapters.areacode) as area, " _
                                + " ifnull((select fullname from tblglobalmembers where memberid = tblglobalchapters.contactperson),'') as cperson  from tblglobalchapters where chaptercode='" & chaptercode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtchaptername.Text = rst("chaptername").ToString
            txtaddress.Text = rst("address").ToString
            txtHistory.Text = rst("history").ToString
            txtfoundedby.Text = rst("foundedby").ToString
            txtorganizedby.Text = rst("organizedby").ToString
            txtdatefounded.Text = rst("datefounded").ToString
            CheckBox1.Checked = rst("mainchapter")
            txtUnderChapter.Text = rst("chapter").ToString
            underchapter.Text = rst("underchapter").ToString
            txtContactPerson.Text = rst("cperson").ToString
            contactPersonID.Text = rst("contactperson").ToString
            txtareaname.Text = rst("area").ToString
            areacode.Text = rst("areacode").ToString
        End While
        rst.Close()
    End Sub


End Class