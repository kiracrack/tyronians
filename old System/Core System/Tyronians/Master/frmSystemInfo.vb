Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmSystemInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldescription.Text = "Developed and own by " & StrConv(globalOrganizationName, vbProperCase)
        txtversion.Text = "Build Version " & Format(fversion, "yy.M.d")
        txtdate.Text = "Date Released " & Format(fversion, "MMMM dd, yyyy")
        Me.Cursor = Cursors.WaitCursor
        com.CommandText = "select * from tblsysteminfo" : rst = com.ExecuteReader
        While rst.Read
            If rst("version").ToString = Format(fversion, "yy.M.d") Then
                txturl.Text = ""
                version.Text = ""
                cmdDownload.Text = "Download New Version"
                cmdDownload.Visible = False
                lbluptodate.Visible = True
            Else
                txturl.Text = rst("downloadurl").ToString
                version.Text = rst("version").ToString
                cmdDownload.Text = "Download New Version v" & rst("version").ToString
                cmdDownload.Visible = True
                lbluptodate.Visible = False
            End If
        End While
        rst.Close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        Me.Cursor = Cursors.WaitCursor
        com.CommandText = "insert into tblupdatedownload set chapter='" & globalchaptername & "', username='" & globalfullname & "', version='" & version.Text & "',datetime=current_timestamp" : com.ExecuteNonQuery()
        Process.Start(txturl.Text)
        Me.Cursor = Cursors.Default
    End Sub
End Class