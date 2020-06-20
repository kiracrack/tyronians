Imports System
Public Class frmMembershipProfile

#Region "Call Data Reload Function"
    Public Shared reloaddata As New frmMembershipProfile()

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
        ViewInformation()
        LoadBeneficiaries()
        LoadInsuranceTable()
        LoadWorkHistory()
        LoadEducation()
        Me.Cursor = Cursors.Default
    End Sub
    
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
       
    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs)
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
    Private Sub cmdNext_Click(sender As Object, e As EventArgs)
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

    Public Sub ViewInformation()
        Dim chaptercode As String = ""
        com.CommandText = "select *,(select chaptername from tbllocalchapter where code=tblglobalmembers.localchapter) as local  from tblglobalmembers where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            If rst("verified") = True Then
                txtStatus.BackColor = Color.GreenYellow
                txtStatus.ForeColor = Color.Black
                txtStatus.Text = "VERIFIED"
            Else
                txtStatus.BackColor = Color.Red
                txtStatus.ForeColor = Color.White
                txtStatus.Text = "UNVERIFIED"
            End If
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
            ShowRelationshipStatus(rst("relationshipstatus").ToString)
            chaptercode = rst("chaptercode").ToString
            txtLocalChapter.Text = rst("local").ToString
            ShowImage("profileimg", picProfile)
        End While
        rst.Close()

        com.CommandText = "select chaptername, (select countryname from tblcountries where countrycode=tblglobalchapters.countrycode) as country, " _
                            + " (select regionname from tblregion where regioncode=tblglobalchapters.region) as region, " _
                            + " (select provincename from tblprovince where provcode = tblglobalchapters.province) as province, " _
                            + " (select areaname from tblarea where areacode = tblglobalchapters.area) as area from tblglobalchapters where chaptercode='" & chaptercode & "'" : rst = com.ExecuteReader
        While rst.Read
            txtCountry.Text = rst("country").ToString
            txtRegion.Text = rst("region").ToString
            txtProvince.Text = rst("province").ToString
            txtArea.Text = rst("area").ToString
            txtchaptername.Text = rst("chaptername").ToString
        End While
        rst.Close()
    End Sub

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

    Public Sub LoadInsuranceTable()
        With gridInsurance
            .Columns.Clear()
            .Columns.Add("Month Coverage", "Month Coverage")
            .Columns.Add("Date", "Date")
            .Columns.Add("Receipt No.", "Receipt No.")
            .Columns.Add("Amount", "Amount")
            .Columns.Add("Date Posted", "Date Posted")
        End With
        If countqry("tblcollections", "memberid='" & txtmemberid.Text & "'") <> 0 Then
            gridInsurance.Rows.Clear() : Dim total As Double = 0 : Dim cnt As Integer = 0
            com.CommandText = "select *,date_format(postingdate,'%M') as postmonth,date_format(postingdate,'%m/%d/%Y') as postdate,date_format(datetrn,'%M %d, %Y') as trndate  from tblcollections  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                With gridInsurance
                    .Rows.Add(rst("postmonth").ToString, rst("postdate").ToString, rst("receiptno").ToString, Val(rst("amount").ToString), rst("trndate").ToString)
                    total += Val(rst("amount").ToString)
                    cnt += 1
                End With
            End While
            rst.Close()
            gridInsurance.Rows.Add("Total Payment " & cnt, "", "", total, "")
            GridTotal(gridInsurance.Rows.Count - 1, gridInsurance)

            GridCurrencyColumn(gridInsurance, {"Amount"})
            GridColAlign("Month Coverage", gridInsurance, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Date", gridInsurance, DataGridViewContentAlignment.MiddleCenter)
            GridColAlign("Receipt No.", gridInsurance, DataGridViewContentAlignment.MiddleCenter)
        End If
    End Sub
    Public Sub GridTotal(ByVal rowIndex As Integer, ByVal gridview As DataGridView)
        gridview.Rows(rowIndex).ReadOnly = True
        gridview.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
        gridview.Rows(rowIndex).DefaultCellStyle.SelectionBackColor = Color.Red
        gridview.Rows(rowIndex).DefaultCellStyle.ForeColor = Color.White
        gridview.Rows(rowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        gridview.Rows(rowIndex).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            com.CommandText = "select  *,case when iscurrent=1 then 'YES' else 'NO' end as cc from tblmemberswork  where memberid='" & txtmemberid.Text & "'" : rst = com.ExecuteReader
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPrintIDOption.memberid.Text = txtmemberid.Text
        frmPrintIDOption.Show(Me)
    End Sub
End Class