Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class rptIDFront
    Private Sub rptID_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If ConnectVerify() = True Then
            txtChairman.Text = "WINTER SEVILLA BUGAHOD"
            PrintingSystem.ExecCommand(PrintingSystemCommand.ZoomToTextWidth)
            'Business owner information
            com.CommandText = "select *,(select chaptername from tblglobalchapters where chaptercode=tblglobalmembers.chaptercode) as chapter,date_format(birthdate,'%M %d, %Y') as dtbirth, date_format(datesurvived,'%M %d, %Y') as dtsurvived from tblglobalmembers where memberid='" & memberid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtTitleBarangay.Text = rst("chapter").ToString
                Dim fullname As String = rst("fullname").ToString
                If fullname.Length > 30 Then
                    txtResidentName.Font = New Font("Franklin Gothic Medium Cond", 10)
                Else
                    txtResidentName.Font = New Font("Franklin Gothic Medium Cond", 11.25)
                End If
                txtResidentName.Text = fullname
                txtAddress.Text = StrConv(rst("completeaddress").ToString, vbProperCase)
                Dim img As Image = ConvertImageBinary("profileimg")


                txtBirthDate.Text = UCase(rst("dtbirth").ToString)
                txtDateSurvived.Text = rst("dtsurvived").ToString
                txtGender.Text = rst("gender").ToString
                txtCivilStatus.Text = rst("relationshipstatus").ToString
                'txtInsurance.Text = rst("insurance").ToString
                barcode.Text = memberid.Text
                txtIDNo.Text = "No. " & memberid.Text
            End While
            rst.Close()

            Dim wd As Integer = 250
            Dim CropRect As New Rectangle((img.Width / 2) - (wd / 2), 0, wd, 250)
            Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
            Using grp = Graphics.FromImage(CropImage)
                grp.DrawImage(img, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                'CropImage.Save("C:\Users\Sysadmin\Pictures\test.jpg")
            End Using
            imgPicture.Image = CropImage
        End If
    End Sub


End Class