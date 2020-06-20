Imports System.Windows.Forms

Public Class frmPrintIDOption
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
     

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        PrintBarangayID(memberid.Text, True)
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        PrintBarangayID(memberid.Text, False)
    End Sub
End Class
