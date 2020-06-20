Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmInformation

    Private Sub frmInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GlobalSystemName
        LoadCouncil()
        LoadRegisteredBy()
        DXLoadToComboBoxQuery("itemname", "itemname", "tblfieldname where fieldname='POSITION'", txtPosition)
        txtBirthdate.EditValue = CDate(Now)
        txtDateSurvived.EditValue = CDate(Now)
        If mode.Text = "edit" Then
            ShowInformation()
        Else
            ClearInformation()
        End If
    End Sub

    Public Sub LoadCouncil()
        LoadXgridLookupSearch("select councilcode, councilname as 'Council' from tblcouncil order by councilname asc", "tblcouncil", txtCouncil, gridCouncil)
        XgridHideColumn({"councilcode"}, gridCouncil)
    End Sub
    Private Sub txtCouncil_EditValueChanged(sender As Object, e As EventArgs) Handles txtCouncil.EditValueChanged
        LoadChapter()
    End Sub
    Public Sub LoadChapter()
        If txtCouncil.Text = "" Then Exit Sub
        LoadXgridLookupSearch("select chaptercode, chaptername as 'Chapter' from tblchapter where councilcode='" & txtCouncil.EditValue & "' order by chaptername asc", "tblchapter", txtChapter, gridChapter)
        XgridHideColumn({"chaptercode"}, gridChapter)
    End Sub

    Public Sub LoadRegisteredBy()
        LoadXgridLookupSearch("select phonenumber, username as 'Fullname' from tbluseraccounts order by username asc", "tbluseraccounts", txtRegisteredBy, gridRegisteredby)
        XgridHideColumn({"phonenumber"}, gridRegisteredby)
    End Sub

    Public Sub ShowInformation()
        dst = Nothing : dst = New DataSet
        msda = New SqlDataAdapter("select * from tblmembers where memberid='" & memberid.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtCouncil.EditValue = .Rows(cnt)("councilcode").ToString
                txtChapter.EditValue = .Rows(cnt)("chaptercode").ToString
                txtFullname.Text = .Rows(cnt)("fullname").ToString
                txtBirthdate.EditValue = .Rows(cnt)("birthdate").ToString
                txtGender.Text = .Rows(cnt)("gender").ToString
                txtPhoneNumber.Text = .Rows(cnt)("phonenumber").ToString
                txtOccupation.Text = .Rows(cnt)("occupation").ToString
                txtPosition.Text = .Rows(cnt)("position").ToString
                txtDateSurvived.EditValue = .Rows(cnt)("datesurvived").ToString
                txtBaptizedName.Text = .Rows(cnt)("baptizedname").ToString
                txtRecruiterName.Text = .Rows(cnt)("recruitername").ToString
                txtRegisteredBy.EditValue = .Rows(cnt)("registeredby").ToString
            End With
        Next
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtCouncil.Text = "" Then
            MessageBox.Show("Please select council name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCouncil.Focus()
            Exit Sub
        ElseIf txtChapter.Text = "" Then
            MessageBox.Show("Please select chapter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapter.Focus()
            Exit Sub
        ElseIf txtFullname.Text = "" Then
            MessageBox.Show("Please enter member fullname!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtGender.Text = "" Then
            MessageBox.Show("Please select gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGender.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please select position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        ElseIf txtBaptizedName.Text = "" Then
            MessageBox.Show("Please enter baptized name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBaptizedName.Focus()
            Exit Sub
        ElseIf txtRegisteredBy.Text = "" Then
            MessageBox.Show("Please select registered by name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRegisteredBy.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue this action?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Details As String = ""
            If mode.Text = "edit" Then
                com.CommandText = "update tblmembers set councilcode='" & txtCouncil.EditValue & "', " _
                    + " councilname='" & rchar(txtCouncil.Text) & "', " _
                    + " chaptercode='" & txtChapter.EditValue & "', " _
                    + " chaptername='" & rchar(txtChapter.Text) & "', " _
                    + " fullname='" & rchar(txtFullname.Text) & "', " _
                    + " birthdate='" & ConvertDate(txtBirthdate.EditValue) & "', " _
                    + " gender='" & txtGender.Text & "', " _
                    + " phonenumber='" & If(txtPhoneNumber.Text.Length > 5, "+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10), "") & "', " _
                    + " occupation='" & rchar(txtOccupation.Text) & "', " _
                    + " position='" & rchar(txtPosition.Text) & "', " _
                    + " datesurvived='" & ConvertDate(txtDateSurvived.EditValue) & "', " _
                    + " baptizedname='" & rchar(txtBaptizedName.Text) & "', " _
                    + " recruitername='" & rchar(txtRecruiterName.Text) & "', " _
                    + " registeredby='" & txtRegisteredBy.EditValue & "', synched=0 where memberid='" & memberid.Text & "'" : com.ExecuteNonQuery()
                MainWindow.LoadMember()
                MessageBox.Show("Information successfull updated", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Dim MemberID As String = txtCouncil.EditValue & "-" & getCouncilMemberSequence(txtCouncil.EditValue) & "-" & getGlobalMemberSequence()
                com.CommandText = "insert into tblmembers (memberid,councilcode,councilname,chaptercode,chaptername,fullname,birthdate,gender,phonenumber,occupation,position,datesurvived,baptizedname,recruitername,registeredby,dateregistered) " _
                    + " VALUES ('" & MemberID & "','" & txtCouncil.EditValue & "','" & rchar(txtCouncil.Text) & "','" & txtChapter.EditValue & "','" & txtChapter.Text & "','" & rchar(txtFullname.Text) & "','" & ConvertDate(txtBirthdate.EditValue) & "','" & txtGender.Text & "','" & If(txtPhoneNumber.Text.Length > 5, "+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10), "") & "','" & rchar(txtOccupation.Text) & "','" & rchar(txtPosition.Text) & "','" & ConvertDate(txtDateSurvived.EditValue) & "','" & rchar(txtBaptizedName.Text) & "','" & rchar(txtRecruiterName.Text) & "','" & txtRegisteredBy.EditValue & "',current_timestamp) " : com.ExecuteNonQuery()

                Dim Notification As String = "Member ID: " & MemberID & Environment.NewLine _
                              + "Fullname: " & rchar(txtFullname.Text) & Environment.NewLine _
                              + "Council: " & rchar(txtCouncil.Text) & Environment.NewLine _
                              + "Chapter: " & rchar(txtChapter.Text) & Environment.NewLine _
                              + "Birth Date: " & CDate(txtBirthdate.EditValue).ToString("MMMM dd, yyyy") & Environment.NewLine _
                              + "Gender: " & txtGender.Text & Environment.NewLine _
                              + "Phone #: " & If(txtPhoneNumber.Text = "", "NONE", "+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10)) & Environment.NewLine _
                              + "Occupation: " & rchar(txtOccupation.Text) & Environment.NewLine _
                              + "Date Survived: " & CDate(txtDateSurvived.EditValue).ToString("MMMM dd, yyyy") & Environment.NewLine _
                              + "Baptized Name: " & rchar(txtBaptizedName.Text) & Environment.NewLine _
                              + "Recruiter Name: " & rchar(txtRecruiterName.Text) & Environment.NewLine _
                              + "Current Position: " & rchar(txtPosition.Text) & Environment.NewLine & Environment.NewLine _
                              + "Note: You can also view registered member online at http://tyronians.org/members. Thank you."

                If txtPhoneNumber.Text <> "+630000000000" Or txtPhoneNumber.Text <> "" Then
                    SendMessageByPrefix("+63" & Microsoft.VisualBasic.Strings.Right(txtPhoneNumber.Text, 10), "Your Information Successfully Registered!" & Environment.NewLine & Environment.NewLine & Notification, False)
                End If

                MainWindow.LoadMember() : ClearInformation()
                MessageBox.Show("Information successfull saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub ClearInformation()
        mode.Text = ""
        memberid.Text = "SYSTEM GENERATED"
        'txtCouncil.EditValue = Nothing
        txtChapter.EditValue = Nothing
        txtFullname.Text = ""
        txtBirthdate.EditValue = CDate(Now)
        txtGender.SelectedIndex = -1
        txtPhoneNumber.Text = ""
        txtOccupation.Text = ""
        txtPosition.SelectedIndex = -1
        txtDateSurvived.EditValue = CDate(Now)
        txtBaptizedName.Text = ""
        txtRecruiterName.Text = ""
        txtRegisteredBy.EditValue = Nothing
        txtFullname.Focus()
    End Sub

    Public Function getCouncilMemberSequence(ByVal councilcode As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select currentseries from tyronians.dbo.tblcouncil where councilcode='" & councilcode & "'" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("currentseries").ToString.Length
            strng = Val(rst("currentseries").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
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
        com.CommandText = "update tyronians.dbo.tblcouncil set currentseries='" & newNumber & "' where councilcode='" & councilcode & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getGlobalMemberSequence()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select seriesno from tyronians.dbo.tblmemberseries" : rst = com.ExecuteReader()
        If rst.HasRows = True Then
            While rst.Read
                NumberLen = rst("seriesno").ToString.Length
                strng = Val(rst("seriesno").ToString) + 1
            End While
        Else
            NumberLen = 3
            strng = 1
        End If
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
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
        com.CommandText = "update tyronians.dbo.tblmemberseries set seriesno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function
    
End Class
