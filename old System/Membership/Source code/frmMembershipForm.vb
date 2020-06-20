Imports System
Imports System.Drawing.Imaging

Public Class frmMembershipForm

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmMembershipForm()

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
    Private Sub frmMembershipForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        txtbirthdate.Text = Format(Now)
        txtdatesurvived.Text = Format(Now)
        txtSpouseBirthdate.Text = Nothing
        txtDateCompanionship.Text = Nothing
        LoadChapter()
        If mode.Text = "edit" Then
            ViewInformation()
            cmdGenerate.Text = "Update Information"
        Else
            LoadNewBeneficiaries()
            LoadWorkHistory()
            LoadEducation()
            cmdGenerate.Text = "Confirmed Your Information"
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub LoadChapter()
        LoadToComboBoxDB("select * from tblglobalchapters order by chaptername asc", "chaptername", "chaptercode", txtchaptername)
    End Sub

    Private Sub txtchaptername_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtchaptername.SelectedValueChanged
        chaptercode.Text = DirectCast(txtchaptername.SelectedItem, ComboBoxItem).HiddenValue()
        LoadLocalChapter()
    End Sub
    Public Sub LoadLocalChapter()
        LoadToComboBoxDB("select * from tbllocalchapter where chaptercode='" & chaptercode.Text & "' order by chaptername asc", "chaptername", "code", txtLocalChapter)
    End Sub
    Private Sub txtLocalChapter_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtLocalChapter.SelectedValueChanged
        localchaptercode.Text = DirectCast(txtLocalChapter.SelectedItem, ComboBoxItem).HiddenValue()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            cmdPrevious.Enabled = False
            cmdNext.Enabled = True
        ElseIf TabControl1.SelectedIndex = 1 Then
            cmdPrevious.Enabled = True
            cmdNext.Enabled = True
        ElseIf TabControl1.SelectedIndex = 2 Then
            cmdPrevious.Enabled = True
            cmdNext.Enabled = True
        ElseIf TabControl1.SelectedIndex = 3 Then
            cmdPrevious.Enabled = True
            cmdNext.Enabled = True

        ElseIf TabControl1.SelectedIndex = 4 Then
            cmdPrevious.Enabled = True
            cmdNext.Enabled = False


        End If
    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0

        ElseIf TabControl1.SelectedIndex = 2 Then
            TabControl1.SelectedIndex = 1

        ElseIf TabControl1.SelectedIndex = 3 Then
            TabControl1.SelectedIndex = 2

        ElseIf TabControl1.SelectedIndex = 4 Then
            TabControl1.SelectedIndex = 3

        ElseIf TabControl1.SelectedIndex = 5 Then
            TabControl1.SelectedIndex = 4

        End If
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If TabControl1.SelectedIndex = 0 Then
            TabControl1.SelectedIndex = 1

        ElseIf TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 2

        ElseIf TabControl1.SelectedIndex = 2 Then
            TabControl1.SelectedIndex = 3

        ElseIf TabControl1.SelectedIndex = 3 Then
            TabControl1.SelectedIndex = 4

        ElseIf TabControl1.SelectedIndex = 4 Then
            TabControl1.SelectedIndex = 5

        End If
    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged, txtfirstname.TextChanged, txtmiddlename.TextChanged
        If txtmiddlename.Text = "" Then
            txtfullname.Text = txtlastname.Text + ", " & txtfirstname.Text
        Else
            txtfullname.Text = txtlastname.Text + ", " & txtfirstname.Text + " " + txtmiddlename.Text
        End If
    End Sub

    Private Sub txtmemberid_TextChanged(sender As Object, e As EventArgs) Handles txtmemberid.TextChanged
        If txtmemberid.Text = "" Then
            txtmemberid.BackColor = DefaultBackColor
        Else
            txtmemberid.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If ConnectVerify() = True Then
            If txtlastname.Text = "" Then
                MessageBox.Show("Please enter Lastname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtlastname.Focus()
                Exit Sub
            ElseIf txtfirstname.Text = "" Then
                MessageBox.Show("Please enter Firstname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtfirstname.Focus()
                Exit Sub
            ElseIf txtgender.Text = "" Then
                MessageBox.Show("Please enter Gender!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtgender.Focus()
                Exit Sub
            ElseIf txtbirthdate.Text = "" Then
                MessageBox.Show("Please enter Birthdate!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtbirthdate.Focus()
                Exit Sub
            ElseIf txtCompleteAddress.Text = "" Then
                MessageBox.Show("Please enter complete address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtCompleteAddress.Focus()
                Exit Sub
            ElseIf txtmobilenumber.Text = "" Or txtmobilenumber.Text = "+63" Then
                MessageBox.Show("Please enter valid Mobile Number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                txtmobilenumber.Focus()
                Exit Sub
            ElseIf txtchaptername.Text = "" Then
                MessageBox.Show("Please enter Chapter Name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtchaptername.Focus()
                Exit Sub
            ElseIf txtdatesurvived.Text = "" Then
                MessageBox.Show("Please enter valid date survived!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdatesurvived.Focus()
                Exit Sub
            ElseIf txtbaptizedname.Text = "" Then
                MessageBox.Show("Please enter Baptized Name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtbaptizedname.Focus()
                Exit Sub
            ElseIf proFileImg = False Then
                MessageBox.Show("System strictly required your image profile! Please grab your picture on facebook and upload it to the system", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
                Exit Sub
            ElseIf countqry("tblglobalmembers", "fullname like '%" & txtfullname.Text & "%' and memberid<>'" & txtmemberid.Text & "'") > 0 Then
                MessageBox.Show("This member is already exists! please review your member list and status to prevent duplication..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtchaptername.Focus()
                Exit Sub
            ElseIf LCase(txtPassword.Text) <> "champion" Then
                MessageBox.Show("Your entering wrong Tyronians Password", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to continue submit your Information?" & Environment.NewLine & Environment.NewLine & "NOTE: please review your information carefully, system not allowed unregistered member to edit your data once this submitted already", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                Me.Cursor = Cursors.WaitCursor
                Dim MasterID As String = ""
                Dim relationshipstatus As String = ""


                If mode.Text = "edit" Then
                    MasterID = txtmemberid.Text
                    com.CommandText = "UPDATE tblglobalmembers set  " _
                                    + " fullname='" & rchar(Trim(txtfullname.Text)) & "', " _
                                    + " lastname='" & rchar(Trim(txtlastname.Text)) & "', " _
                                    + " firstname='" & rchar(Trim(txtfirstname.Text)) & "', " _
                                    + " middlename='" & rchar(Trim(txtmiddlename.Text)) & "', " _
                                    + " gender='" & txtgender.Text & "', " _
                                    + " nickname='" & rchar(Trim(txtnickname.Text)) & "', " _
                                    + " birthdate='" & ConvertDate(txtbirthdate.Value) & "', " _
                                    + " birthplace='" & rchar(Trim(txtbirthplace.Text)) & "', " _
                                    + " relationshipstatus='" & getRelationshipStatus() & "'," _
                                    + " completeaddress='" & rchar(Trim(txtCompleteAddress.Text)) & "', " _
                                    + " mobilenumber='" & rchar(Trim(txtmobilenumber.Text)) & "', " _
                                    + " emailadd='" & rchar(Trim(txtemailadd.Text)) & "', " _
                                    + " incase_contactname='" & rchar(Trim(txtSpouseName.Text)) & "', " _
                                    + " incase_birthdate='" & ConvertDate(txtSpouseBirthdate.Value) & "', " _
                                    + " incase_contact='" & rchar(Trim(txtSpouseNumber.Text)) & "', " _
                                    + " incase_datecompanion='" & ConvertDate(txtDateCompanionship.Value) & "', " _
                                    + " chaptercode='" & chaptercode.Text & "', " _
                                    + " localchapter='" & localchaptercode.Text & "', " _
                                    + " baptizedname='" & rchar(Trim(txtbaptizedname.Text)) & "', " _
                                    + " datesurvived='" & ConvertDate(txtdatesurvived.Text) & "', " _
                                    + " rituals='" & txtrituals.CheckState & "', " _
                                    + " idcard='" & txtidcard.CheckState & "' " _
                                    + " where memberid='" & MasterID & "'" : com.ExecuteNonQuery()
                Else
                    MasterID = GetMembershipID(txtfullname.Text, txtdatesurvived.Text)
                    com.CommandText = "INSERT INTO tblglobalmembers set  " _
                                    + " memberid='" & MasterID & "'," _
                                    + " fullname='" & rchar(Trim(txtfullname.Text)) & "', " _
                                    + " lastname='" & rchar(Trim(txtlastname.Text)) & "', " _
                                    + " firstname='" & rchar(Trim(txtfirstname.Text)) & "', " _
                                    + " middlename='" & rchar(Trim(txtmiddlename.Text)) & "', " _
                                    + " gender='" & txtgender.Text & "', " _
                                    + " nickname='" & rchar(Trim(txtnickname.Text)) & "', " _
                                    + " birthdate='" & ConvertDate(txtbirthdate.Value) & "', " _
                                    + " birthplace='" & rchar(Trim(txtbirthplace.Text)) & "', " _
                                    + " relationshipstatus='" & getRelationshipStatus() & "'," _
                                    + " completeaddress='" & rchar(Trim(txtCompleteAddress.Text)) & "', " _
                                    + " mobilenumber='" & rchar(Trim(txtmobilenumber.Text)) & "', " _
                                    + " emailadd='" & rchar(Trim(txtemailadd.Text)) & "', " _
                                    + " incase_contactname='" & rchar(Trim(txtSpouseName.Text)) & "', " _
                                    + " incase_birthdate='" & ConvertDate(txtSpouseBirthdate.Value) & "', " _
                                    + " incase_contact='" & rchar(Trim(txtSpouseNumber.Text)) & "', " _
                                    + " incase_datecompanion='" & ConvertDate(txtDateCompanionship.Value) & "', " _
                                    + " chaptercode='" & chaptercode.Text & "', " _
                                    + " localchapter='" & localchaptercode.Text & "', " _
                                    + " baptizedname='" & rchar(Trim(txtbaptizedname.Text)) & "', " _
                                    + " datesurvived='" & ConvertDate(txtdatesurvived.Text) & "', " _
                                    + " rituals='" & txtrituals.CheckState & "', " _
                                    + " idcard='" & txtidcard.CheckState & "', " _
                                    + " registeredby='" & globaluserid & "', " _
                                    + " dateregistered=current_timestamp;" : com.ExecuteNonQuery()
                End If
                If proFileImg = True Then
                    UpdateImage("memberid='" & MasterID & "'", "profileimg", "tblglobalmembers", picProfile)
                Else
                    com.CommandText = "update tblglobalmembers set profileimg=null where memberid='" & MasterID & "'" : com.ExecuteNonQuery()
                End If
                UpdateBeneficiary(MasterID)
                UpdateCompany(MasterID)
                UpdateEducation(MasterID)
                txtmemberid.Text = MasterID
                lblSuccessTitle.Visible = True
                lblMessageDescription.Visible = True
                cmdGenerate.Visible = False
                cmdDone.Visible = True
                Me.Cursor = Cursors.Default
            End If
        Else
            ConnectVerify()
        End If
    End Sub

    Public Function getRelationshipStatus()
        Dim relationshipstatus As String = ""
        If radSingle.Checked = True Then
            relationshipstatus = "SINGLE"
        ElseIf radMarried.Checked = True Then
            relationshipstatus = "MARRIED"
        ElseIf RadLivein.Checked = True Then
            relationshipstatus = "LIVE-IN"
        ElseIf radSeparated.Checked = True Then
            relationshipstatus = "SEPARATED"
        ElseIf radWidower.Checked = True Then
            relationshipstatus = "WIDOWER"
        End If
        Return relationshipstatus
    End Function

    Public Sub ShowRelationshipStatus(ByVal status As String)
        If status = "SINGLE" Then
            radSingle.Checked = True
        ElseIf status = "MARRIED" Then
            radMarried.Checked = True
        ElseIf status = "LIVE-IN" Then
            RadLivein.Checked = True
        ElseIf status = "SEPARATED" Then
            radSeparated.Checked = True
        ElseIf status = "WIDOWER" Then
            radWidower.Checked = True
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Membership unique ID is a identification of a member globally. use this as id number of ID CARD or verification of a member if he/she already registered in our system!" & Environment.NewLine & Environment.NewLine _
                            + "The Combination of Unique id, Explanation and Example: ""AB1987-0101Z-00000001""" & Environment.NewLine & Environment.NewLine _
                            + """AB"" - is combination of your Family Name and First Name" & Environment.NewLine _
                            + """1987"" - Year of Date Survived" & Environment.NewLine _
                            + """0101Z"" - Month and Day of Date Survived and First Character of Chapter" & Environment.NewLine _
                            + """01"" - Sequence number of registered Members World Wide", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        MessageBox.Show("Sorry this service is currently not available!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MessageBox.Show("Upload Membership waiver or important document of a member! Limit Size 5MB only", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "BENEFICIARIES"
    Public Sub LoadNewBeneficiaries()
        gridBenefiaciaries.Rows.Clear()
        gridBenefiaciaries.ColumnCount = 4
        gridBenefiaciaries.ColumnHeadersVisible = True

        gridBenefiaciaries.Columns(0).Name = "Beneficiaries"
        gridBenefiaciaries.Columns(1).Name = "Relationship"
        gridBenefiaciaries.Columns(2).Name = "Age"
        gridBenefiaciaries.Columns(3).Name = "Birth Date"

        GridColAlign("Relationship", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)
        GridColAlign("Age", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)
        GridColAlign("Birth Date", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)

    End Sub
    Private Sub cmdSaveBeneficiary_Click(sender As Object, e As EventArgs) Handles cmdSaveBeneficiary.Click
        If txtNameOfBeneficiary.Text = "" Then
            MessageBox.Show("Please enter beneficiary name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNameOfBeneficiary.Focus()
            Exit Sub
        ElseIf txtRelationship.Text = "" Then
            MessageBox.Show("Please select relationship!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRelationship.Focus()
            Exit Sub
        End If
        For i = 0 To gridBenefiaciaries.Rows.Count - 1
            If gridBenefiaciaries.Item("Beneficiaries", i).Value = txtNameOfBeneficiary.Text Then
                gridBenefiaciaries.Rows.Remove(gridBenefiaciaries.Rows(i))
            End If
        Next
        With gridBenefiaciaries
            .Rows.Add(Trim(txtNameOfBeneficiary.Text), Trim(txtRelationship.Text), DateDiff(DateInterval.Year, txtBeneficiaryBirthDate.Value, Now) - 1, ConvertDate(txtBeneficiaryBirthDate.Text))
            txtNameOfBeneficiary.Text = ""
            txtRelationship.SelectedIndex = -1
        End With
    End Sub

    Private Sub cmdRemoveBeneficiary_Click(sender As Object, e As EventArgs) Handles cmdRemoveBeneficiary.Click
        gridBenefiaciaries.Rows.Remove(gridBenefiaciaries.CurrentRow)
    End Sub
    Public Sub UpdateBeneficiary(ByVal memberid As String)
        com.CommandText = "delete from tblbeneficiaries where memberid='" & memberid & "'" : com.ExecuteNonQuery()
        For i = 0 To gridBenefiaciaries.Rows.Count - 1
            com.CommandText = "insert into tblbeneficiaries set " _
                                    + " memberid='" & memberid & "', " _
                                    + " beneficiaryname='" & rchar(gridBenefiaciaries.Item("Beneficiaries", i).Value) & "', " _
                                    + " relationship='" & rchar(gridBenefiaciaries.Item("Relationship", i).Value) & "', " _
                                    + " birthdate='" & rchar(gridBenefiaciaries.Item("Birth Date", i).Value) & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Private Sub cmdEditBeneficiary_Click(sender As Object, e As EventArgs) Handles cmdEditBeneficiary.Click
        txtNameOfBeneficiary.Text = gridBenefiaciaries.Item("Beneficiaries", gridBenefiaciaries.CurrentRow.Index).Value()
        txtRelationship.Text = gridBenefiaciaries.Item("Relationship", gridBenefiaciaries.CurrentRow.Index).Value()
        txtBeneficiaryBirthDate.Text = gridBenefiaciaries.Item("Birth Date", gridBenefiaciaries.CurrentRow.Index).Value()
    End Sub


#End Region

#Region "MEMBERSHIP COMPANY"
    Public Sub LoadNewWorkHistory()
        gridWork.Rows.Clear()
        gridWork.ColumnCount = 4
        gridWork.ColumnHeadersVisible = True

        gridWork.Columns(0).Name = "Company Name"
        gridWork.Columns(1).Name = "Position"
        gridWork.Columns(2).Name = "Date Period"
        gridWork.Columns(3).Name = "Current Company"

        GridColAlign("Date Period", gridWork, DataGridViewContentAlignment.MiddleCenter)
        GridColAlign("Current Company", gridWork, DataGridViewContentAlignment.MiddleCenter)

    End Sub
    Private Sub cmdWorkSave_Click(sender As Object, e As EventArgs) Handles cmdWorkSave.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter company name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompanyName.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        End If
        For i = 0 To gridWork.Rows.Count - 1
            If gridWork.Item("Company Name", i).Value = txtCompanyName.Text Then
                gridWork.Rows.Remove(gridWork.Rows(i))
            End If
        Next
        With gridWork
            Dim current As String = ""
            If txtCompanyCurrent.Checked = True Then
                current = "YES"
            Else
                current = "NO"
            End If
            .Rows.Add(Trim(txtCompanyName.Text), Trim(txtPosition.Text), txtCompanyDatePeriod.Text, current)
            txtCompanyName.Text = ""
            txtPosition.Text = ""
            txtCompanyCurrent.Checked = False
        End With
    End Sub

    Private Sub cmdRemoveWork_Click(sender As Object, e As EventArgs) Handles cmdRemoveWork.Click
        gridWork.Rows.Remove(gridWork.CurrentRow)
    End Sub
    Public Sub UpdateCompany(ByVal memberid As String)
        com.CommandText = "delete from tblmemberswork where memberid='" & memberid & "'" : com.ExecuteNonQuery()
        For i = 0 To gridWork.Rows.Count - 1
            Dim current As Integer = 0
            If gridWork.Item("Current Company", i).Value = "YES" Then
                current = 1
            Else
                current = 0
            End If
            com.CommandText = "insert into tblmemberswork set " _
                                    + " memberid='" & memberid & "', " _
                                    + " companyname='" & rchar(gridWork.Item("Company Name", i).Value) & "', " _
                                    + " position='" & rchar(gridWork.Item("Position", i).Value) & "', " _
                                    + " timeperiod='" & rchar(gridWork.Item("Date Period", i).Value) & "', " _
                                    + " iscurrent='" & current & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Private Sub EditWorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditWorkToolStripMenuItem.Click
        txtCompanyName.Text = gridWork.Item("Company Name", gridWork.CurrentRow.Index).Value()
        txtPosition.Text = gridWork.Item("Position", gridWork.CurrentRow.Index).Value()
        txtCompanyDatePeriod.Text = gridWork.Item("Date Period", gridWork.CurrentRow.Index).Value()
        txtCompanyCurrent.Checked = If(gridWork.Item("Current Company", gridWork.CurrentRow.Index).Value() = "YES", True, False)
    End Sub

    Private Sub txtCompanyCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles txtCompanyCurrent.CheckedChanged
        If txtCompanyCurrent.Checked = True Then
            txtCompanyDatePeriod.Enabled = False
            txtCompanyDatePeriod.Text = ""
        Else
            txtCompanyDatePeriod.Enabled = True
        End If
    End Sub

#End Region

#Region "MEMBERSHIP EDUCATION"
    Public Sub LoadNewEducation()
        gridEducation.Rows.Clear()
        gridEducation.ColumnCount = 5
        gridEducation.ColumnHeadersVisible = True

        gridEducation.Columns(0).Name = "School Name"
        gridEducation.Columns(1).Name = "Level"
        gridEducation.Columns(2).Name = "Details"
        gridEducation.Columns(3).Name = "Date Period"
        gridEducation.Columns(4).Name = "Current School"

        GridColAlign("Date Period", gridEducation, DataGridViewContentAlignment.MiddleCenter)
        GridColAlign("Current School", gridEducation, DataGridViewContentAlignment.MiddleCenter)

    End Sub
    Private Sub cndEduSave_Click(sender As Object, e As EventArgs) Handles cndEduSave.Click
        If txtSchoolname.Text = "" Then
            MessageBox.Show("Please enter school name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolname.Focus()
            Exit Sub
        ElseIf txtSchoolLevel.Text = "" Then
            MessageBox.Show("Please enter school level!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSchoolLevel.Focus()
            Exit Sub
        ElseIf txtEducPeriod.Text = "" Then
            MessageBox.Show("Please enter date period!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEducPeriod.Focus()
            Exit Sub
        End If
        For i = 0 To gridEducation.Rows.Count - 1
            If gridEducation.Item("School Name", i).Value = txtSchoolname.Text Then
                gridEducation.Rows.Remove(gridEducation.Rows(i))
            End If
        Next
        With gridEducation
            Dim current As String = ""
            If txtEducCurrent.Checked = True Then
                current = "YES"
            Else
                current = "NO"
            End If
            .Rows.Add(Trim(txtSchoolname.Text), Trim(txtSchoolLevel.Text), Trim(txtSchoolDetails.Text), txtEducPeriod.Text, current)
            txtSchoolname.Text = ""
            txtSchoolLevel.SelectedIndex = -1
            txtSchoolDetails.Text = ""
            txtEducPeriod.Text = Format(Now)
            txtEducCurrent.Checked = False
            txtSchoolname.Focus()
        End With
    End Sub

    Private Sub cmdRemoveSchool_Click(sender As Object, e As EventArgs) Handles cmdRemoveSchool.Click
        gridEducation.Rows.Remove(gridEducation.CurrentRow)
    End Sub
    Public Sub UpdateEducation(ByVal memberid As String)
        com.CommandText = "delete from tblmemberseduc where memberid='" & memberid & "'" : com.ExecuteNonQuery()
        For i = 0 To gridEducation.Rows.Count - 1
            Dim current As Integer = 0
            If gridEducation.Item("Current School", i).Value = "YES" Then
                current = 1
            Else
                current = 0
            End If
            com.CommandText = "insert into tblmemberseduc set " _
                                    + " memberid='" & memberid & "', " _
                                    + " schoolname='" & rchar(gridEducation.Item("School Name", i).Value) & "', " _
                                    + " schoollevel='" & rchar(gridEducation.Item("Level", i).Value) & "', " _
                                    + " details='" & rchar(gridEducation.Item("Details", i).Value) & "', " _
                                    + " timeperiod='" & rchar(gridEducation.Item("Date Period", i).Value) & "', " _
                                    + " iscurrent='" & current & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Private Sub cmdEditSchool_Click(sender As Object, e As EventArgs) Handles cmdEditSchool.Click
        txtSchoolname.Text = gridEducation.Item("School Name", gridEducation.CurrentRow.Index).Value()
        txtSchoolLevel.Text = gridEducation.Item("Level", gridEducation.CurrentRow.Index).Value()
        txtSchoolDetails.Text = gridEducation.Item("Details", gridEducation.CurrentRow.Index).Value()
        txtEducPeriod.Text = gridEducation.Item("Date Period", gridEducation.CurrentRow.Index).Value()
        txtEducCurrent.Checked = If(gridEducation.Item("Current School", gridEducation.CurrentRow.Index).Value() = "YES", True, False)
    End Sub

    Private Sub txtEducCurrent_CheckedChanged(sender As Object, e As EventArgs) Handles txtEducCurrent.CheckedChanged
        If txtEducCurrent.Checked = True Then
            txtEducPeriod.Enabled = False
            txtEducPeriod.Text = ""
        Else
            txtEducPeriod.Enabled = True
        End If
    End Sub
#End Region

    Public Sub resizesignature()
        If picProfile.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(picProfile.Image)
        picProfile.Image = Original

        Dim m As Int32 = 320
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        picProfile.Image = Thumb
    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        'Declare a OpenFileDialog object
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
            .Filter = "All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                'Read the contents of the file
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'Display the file contents in the TextBox
                picProfile.ImageLocation = objOpenFileDialog.FileName
                proFileImg = True
            Catch fileException As Exception
                Throw fileException
            End Try

        End If

        'Clean up
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Sub picProfile_LoadCompleted(sender As Object, e As ComponentModel.AsyncCompletedEventArgs) Handles picProfile.LoadCompleted
        resizesignature()
    End Sub

    Private Sub RemovePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePictureToolStripMenuItem.Click
        Me.picProfile.Image = Global.Tyronians.My.Resources.Resources.blankimg
        proFileImg = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Right click on the picture to display control menu", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmAddChapter.ShowDialog(Me)
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        Me.Close()
    End Sub

#Region "EDITING INFORMATION"
    Public Sub ViewInformation()
        Dim chapter As String = "" : Dim LocalChapter As String = ""
        com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblglobalmembers.chaptercode) as chapter,(select chaptername from tbllocalchapter where code=tblglobalmembers.localchapter) as local from tblglobalmembers  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtlastname.Text = rst("lastname").ToString
            txtfirstname.Text = rst("firstname").ToString
            txtmiddlename.Text = rst("middlename").ToString
            txtgender.Text = rst("gender").ToString
            txtnickname.Text = rst("nickname").ToString
            txtbirthdate.Text = rst("birthdate").ToString
            txtbirthplace.Text = rst("birthplace").ToString
            txtCompleteAddress.Text = rst("completeaddress").ToString
            txtmobilenumber.Text = rst("mobilenumber").ToString
            txtemailadd.Text = rst("emailadd").ToString
            txtSpouseName.Text = rst("incase_contactname").ToString
            txtSpouseBirthdate.Text = rst("incase_birthdate").ToString
            txtSpouseNumber.Text = rst("incase_contact").ToString
            txtDateCompanionship.Text = rst("incase_datecompanion").ToString
            txtbaptizedname.Text = rst("baptizedname").ToString
            txtdatesurvived.Text = rst("datesurvived").ToString
            txtrituals.Checked = rst("rituals")
            txtidcard.Checked = rst("idcard")
            chaptercode.Text = rst("chaptercode").ToString
            chapter = rst("chapter").ToString
            localchaptercode.Text = rst("localchapter").ToString
            LocalChapter = rst("local").ToString
            ShowRelationshipStatus(rst("relationshipstatus").ToString)
            ShowImage("profileimg", picProfile)
        End While
        rst.Close()
        LoadChapter()
        txtchaptername.Text = chapter
        txtLocalChapter.Text = LocalChapter
        LoadBeneficiaries()
        LoadWorkHistory()
        LoadEducation()
    End Sub

    Public Sub LoadBeneficiaries()
        With gridBenefiaciaries
            .Columns.Clear()
            .Columns.Add("Beneficiaries", "Beneficiaries")
            .Columns.Add("Relationship", "Relationship")
            .Columns.Add("Age", "Age")
            .Columns.Add("Birth Date", "Birth Date")

        End With
        If countqry("tblbeneficiaries", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridBenefiaciaries.Rows.Clear()
            com.CommandText = "select  *,TIMESTAMPDIFF(year,birthdate,current_date) as age,date_format(birthdate,'%Y-%m-%d') as bd  from tblbeneficiaries where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridBenefiaciaries
                    .Rows.Add(rst("beneficiaryname").ToString, rst("relationship").ToString, rst("age").ToString, rst("bd").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Relationship", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Age", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Birth Date", gridBenefiaciaries, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

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
            com.CommandText = "select  *, case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberswork  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridWork
                    .Rows.Add(rst("companyname").ToString, rst("Position").ToString, If(rst("cc").ToString = "YES", "-", rst("timeperiod").ToString), rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridWork, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current Company", gridWork, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

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
            com.CommandText = "select  *, case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberseduc  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridEducation
                    .Rows.Add(rst("schoolname").ToString, rst("schoollevel").ToString, rst("details").ToString, rst("timeperiod").ToString, rst("cc").ToString)
                End With
            End While
            rst.Close()
            GridColAlign("Date Period", gridEducation, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Current School", gridEducation, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub

#End Region

    Private Sub radMarried_CheckedChanged(sender As Object, e As EventArgs) Handles radMarried.CheckedChanged, RadLivein.CheckedChanged, radSingle.CheckedChanged, radSeparated.CheckedChanged, radWidower.CheckedChanged
        If radSingle.Checked = True Or radWidower.Checked = True Or radSeparated.Checked = True Then
            txtSpouseName.Enabled = False
            txtSpouseBirthdate.Enabled = False
            txtSpouseNumber.Enabled = False
            txtDateCompanionship.Enabled = False
        Else
            txtSpouseName.Enabled = True
            txtSpouseBirthdate.Enabled = True
            txtSpouseNumber.Enabled = True
            txtDateCompanionship.Enabled = True
        End If
    End Sub

     Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If txtchaptername.Text = "" Then
            MessageBox.Show("Please select chapter!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedIndex = 0
            txtchaptername.Focus()
            Exit Sub
        End If
        frmLocalChapter.chaptercode.Text = chaptercode.Text
        frmLocalChapter.ShowDialog(Me)
    End Sub
End Class