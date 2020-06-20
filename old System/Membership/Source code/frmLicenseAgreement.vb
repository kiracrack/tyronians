Imports System.Windows.Forms
Imports System.IO

Public Class frmLicenseAgreement
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmLicenseAgreement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\LicenseVerified") = True Then
            cmdDone.Visible = False
        Else
            cmdDone.Visible = True
        End If

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        Dim detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\LicenseVerified", True)
        detailsFile.WriteLine("verified")
        detailsFile.Close()
        frmWelcomeMessage.Show()
        Me.Hide()
    End Sub
End Class
