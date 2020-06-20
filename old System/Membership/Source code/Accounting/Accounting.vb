Public Class Accounting


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmGLItem.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPostTransaction.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmTrnSettingsItems.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        frmAccountTitleLedger.Show()
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmGLGroup.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmPostingPredefineGL.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmTrialBalance.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmChartOfAccount.Show()
    End Sub
End Class
