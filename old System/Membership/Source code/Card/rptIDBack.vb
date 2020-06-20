Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class rptIDBack

    Private Sub rptIDBack_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
    
        'txtDetails.Text = "This card, issued exclusively by the " & StrConv(GlobalBarangay, vbProperCase) & ", is recognized as"
        residentid.Text = residentid.Text
        PrintingSystem.ExecCommand(PrintingSystemCommand.ZoomToTextWidth)
    End Sub


End Class