Imports System.Windows.Forms

Public Class frmAddChapter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtCountries.Text = "" Then
            MsgBox("Please select country!", MsgBoxStyle.Exclamation)
            txtCountries.Focus()
            Exit Sub
        ElseIf txtRegion.Text = "" Then
            MsgBox("Please select region!", MsgBoxStyle.Exclamation)
            txtRegion.Focus()
            Exit Sub
        ElseIf txtProvince.Text = "" Then
            MsgBox("Please select province!", MsgBoxStyle.Exclamation)
            txtProvince.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
            MsgBox("Please select area!", MsgBoxStyle.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtChapter.Text = "" Then
            MsgBox("Please enter chapter name!", MsgBoxStyle.Exclamation)
            txtChapter.Focus()
            Exit Sub
        ElseIf countqry("tblglobalchapters", "chaptername='" & Trim(rchar(UCase(txtChapter.Text))) & "'") > 0 Then
            MsgBox("Chapter already exists!", MsgBoxStyle.Exclamation)
            txtChapter.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue save this chapter? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ConnectVerify() = True Then
                com.CommandText = "insert into tblglobalchapters set chaptercode='" & GetChapterID(DirectCast(txtCountries.SelectedItem, ComboBoxItem).HiddenValue()) & "', " _
                                                     + " countrycode='" & DirectCast(txtCountries.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                                                     + " region='" & DirectCast(txtRegion.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                                                     + " province='" & DirectCast(txtProvince.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                                                     + " area='" & DirectCast(txtArea.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                                                     + " chaptername='" & Trim(rchar(UCase(txtChapter.Text))) & "',dateadded=current_timestamp" : com.ExecuteNonQuery()
                'MsgBox("Chapter successfully save", MsgBoxStyle.Information)
                frmMembershipForm.LoadChapter()
                frmMembershipForm.txtchaptername.Text = Trim(rchar(UCase(txtChapter.Text)))
                txtChapter.Text = "" : txtChapter.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmUserlogoff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCountryCity()
    End Sub
    Public Sub LoadCountryCity()
        LoadToComboBoxDB("select * from tblcountries", "countryname", "countrycode", txtCountries)
        txtCountries.Text = "Philippines"
    End Sub
 
    
    Private Sub txtCountries_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCountries.SelectedValueChanged
        LoadToComboBoxDB("select * from tblregion where country='" & DirectCast(txtCountries.SelectedItem, ComboBoxItem).HiddenValue() & "'", "regionname", "regioncode", txtRegion)
        txtProvince.Items.Clear()
        txtArea.Items.Clear()
    End Sub

    Private Sub txtRegion_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRegion.SelectedValueChanged
        LoadToComboBoxDB("select * from tblprovince where regioncode='" & DirectCast(txtRegion.SelectedItem, ComboBoxItem).HiddenValue() & "'", "provincename", "provcode", txtProvince)
    End Sub
 
    Private Sub txtProvince_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProvince.SelectedValueChanged
        LoadToComboBoxDB("select * from tblarea where province='" & DirectCast(txtProvince.SelectedItem, ComboBoxItem).HiddenValue() & "' order by areaname ", "areaname", "areacode", txtArea)
    End Sub

    
End Class
