<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptIDFront
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptIDFront))
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.memberid = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtIDNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgBarangayLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtTitleResNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitleBarangay = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitleMunicipality = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitleProvince = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtChairman = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCivilStatus = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtGender = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDateSurvived = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBirthDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgPicture = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.barcode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.txtResidentName = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgBackground = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.imgpattern = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.BorderWidth = 0.0!
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.memberid, Me.txtIDNo, Me.imgBarangayLogo, Me.txtTitleResNumber, Me.txtTitleBarangay, Me.txtTitleMunicipality, Me.txtTitleProvince, Me.txtChairman, Me.txtCivilStatus, Me.txtGender, Me.txtDateSurvived, Me.txtBirthDate, Me.txtAddress, Me.imgPicture, Me.barcode, Me.txtResidentName, Me.imgBackground, Me.imgpattern})
        Me.TopMargin.HeightF = 500.7857!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBorderWidth = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(144.3968!, 184.556!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(101.0752!, 24.48979!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 21.31155!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(35.0!, 37.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel12
        '
        Me.XrLabel12.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel12.Font = New System.Drawing.Font("Old English Text MT", 11.25!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XrLabel12.KeepTogether = True
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(61.76413!, 19.31155!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(178.7079!, 22.59633!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Republic of the Philippines"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel11.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel11.KeepTogether = True
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(29.17388!, 209.8858!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(84.25665!, 8.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Signature of Bearer"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(126.7251!, 210.0751!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(121.7813!, 8.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Council GT"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(158.1937!, 166.1603!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(36.80331!, 6.395752!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Civil Status"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 166.1603!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(36.80331!, 6.395752!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Gender"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(199.997!, 145.9366!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(54.50937!, 8.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Year Survived"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 145.9366!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(54.50937!, 8.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Birth Date"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel4.KeepTogether = True
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 124.8726!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(54.50937!, 8.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Complete Address"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 4.75!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.XrLabel3.KeepTogether = True
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 109.0811!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(188.2776!, 8.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Lastname, Firstname, Middle Name"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'memberid
        '
        Me.memberid.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.memberid.KeepTogether = True
        Me.memberid.LocationFloat = New DevExpress.Utils.PointFloat(29.17388!, 181.556!)
        Me.memberid.Name = "memberid"
        Me.memberid.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.memberid.SizeF = New System.Drawing.SizeF(84.25667!, 12.32831!)
        Me.memberid.StylePriority.UseFont = False
        Me.memberid.StylePriority.UsePadding = False
        Me.memberid.StylePriority.UseTextAlignment = False
        Me.memberid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.memberid.Visible = False
        '
        'txtIDNo
        '
        Me.txtIDNo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.txtIDNo.CanGrow = False
        Me.txtIDNo.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIDNo.LocationFloat = New DevExpress.Utils.PointFloat(264.2086!, 199.0458!)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtIDNo.SizeF = New System.Drawing.SizeF(82.81467!, 12.04929!)
        Me.txtIDNo.StylePriority.UseFont = False
        Me.txtIDNo.StylePriority.UsePadding = False
        Me.txtIDNo.StylePriority.UseTextAlignment = False
        Me.txtIDNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'imgBarangayLogo
        '
        Me.imgBarangayLogo.Image = CType(resources.GetObject("imgBarangayLogo.Image"), System.Drawing.Image)
        Me.imgBarangayLogo.LocationFloat = New DevExpress.Utils.PointFloat(283.0009!, 22.0!)
        Me.imgBarangayLogo.Name = "imgBarangayLogo"
        Me.imgBarangayLogo.SizeF = New System.Drawing.SizeF(61.38394!, 59.17006!)
        Me.imgBarangayLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'txtTitleResNumber
        '
        Me.txtTitleResNumber.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtTitleResNumber.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 7.5!)
        Me.txtTitleResNumber.ForeColor = System.Drawing.Color.Maroon
        Me.txtTitleResNumber.KeepTogether = True
        Me.txtTitleResNumber.LocationFloat = New DevExpress.Utils.PointFloat(28.17387!, 75.35619!)
        Me.txtTitleResNumber.Name = "txtTitleResNumber"
        Me.txtTitleResNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtTitleResNumber.SizeF = New System.Drawing.SizeF(246.32!, 12.0!)
        Me.txtTitleResNumber.StylePriority.UseFont = False
        Me.txtTitleResNumber.StylePriority.UseForeColor = False
        Me.txtTitleResNumber.StylePriority.UsePadding = False
        Me.txtTitleResNumber.StylePriority.UseTextAlignment = False
        Me.txtTitleResNumber.Text = "FRATERNITY IDENTIFICATION CARD"
        Me.txtTitleResNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitleBarangay
        '
        Me.txtTitleBarangay.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtTitleBarangay.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.txtTitleBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTitleBarangay.KeepTogether = True
        Me.txtTitleBarangay.LocationFloat = New DevExpress.Utils.PointFloat(28.17388!, 60.31155!)
        Me.txtTitleBarangay.Name = "txtTitleBarangay"
        Me.txtTitleBarangay.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtTitleBarangay.SizeF = New System.Drawing.SizeF(246.3194!, 17.0!)
        Me.txtTitleBarangay.StylePriority.UseFont = False
        Me.txtTitleBarangay.StylePriority.UseForeColor = False
        Me.txtTitleBarangay.StylePriority.UsePadding = False
        Me.txtTitleBarangay.StylePriority.UseTextAlignment = False
        Me.txtTitleBarangay.Text = "DIPOLOG CITY CHAPTER"
        Me.txtTitleBarangay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitleMunicipality
        '
        Me.txtTitleMunicipality.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtTitleMunicipality.Font = New System.Drawing.Font("Arial Narrow", 5.75!, System.Drawing.FontStyle.Bold)
        Me.txtTitleMunicipality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTitleMunicipality.KeepTogether = True
        Me.txtTitleMunicipality.LocationFloat = New DevExpress.Utils.PointFloat(61.76413!, 47.66968!)
        Me.txtTitleMunicipality.Name = "txtTitleMunicipality"
        Me.txtTitleMunicipality.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtTitleMunicipality.SizeF = New System.Drawing.SizeF(190.92!, 10.64187!)
        Me.txtTitleMunicipality.StylePriority.UseFont = False
        Me.txtTitleMunicipality.StylePriority.UsePadding = False
        Me.txtTitleMunicipality.StylePriority.UseTextAlignment = False
        Me.txtTitleMunicipality.Text = "S.E.C. REG. NO.CN201125165"
        Me.txtTitleMunicipality.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitleProvince
        '
        Me.txtTitleProvince.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtTitleProvince.Font = New System.Drawing.Font("Tahoma", 6.25!, System.Drawing.FontStyle.Bold)
        Me.txtTitleProvince.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTitleProvince.KeepTogether = True
        Me.txtTitleProvince.LocationFloat = New DevExpress.Utils.PointFloat(61.76413!, 36.66968!)
        Me.txtTitleProvince.Name = "txtTitleProvince"
        Me.txtTitleProvince.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtTitleProvince.SizeF = New System.Drawing.SizeF(212.7292!, 12.17968!)
        Me.txtTitleProvince.StylePriority.UseFont = False
        Me.txtTitleProvince.StylePriority.UsePadding = False
        Me.txtTitleProvince.StylePriority.UseTextAlignment = False
        Me.txtTitleProvince.Text = "TYRO GYN PHI FRATERNITY AND SORORITY"
        Me.txtTitleProvince.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtChairman
        '
        Me.txtChairman.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.txtChairman.CanGrow = False
        Me.txtChairman.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtChairman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtChairman.LocationFloat = New DevExpress.Utils.PointFloat(126.7251!, 199.7061!)
        Me.txtChairman.Name = "txtChairman"
        Me.txtChairman.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtChairman.SizeF = New System.Drawing.SizeF(121.7813!, 10.36899!)
        Me.txtChairman.StylePriority.UsePadding = False
        Me.txtChairman.StylePriority.UseTextAlignment = False
        Me.txtChairman.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtCivilStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCivilStatus.LocationFloat = New DevExpress.Utils.PointFloat(158.1937!, 156.3324!)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtCivilStatus.SizeF = New System.Drawing.SizeF(39.8033!, 9.827896!)
        Me.txtCivilStatus.StylePriority.UsePadding = False
        Me.txtCivilStatus.StylePriority.UseTextAlignment = False
        Me.txtCivilStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGender.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 156.3324!)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtGender.SizeF = New System.Drawing.SizeF(36.80331!, 9.827896!)
        Me.txtGender.StylePriority.UsePadding = False
        Me.txtGender.StylePriority.UseTextAlignment = False
        Me.txtGender.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtDateSurvived
        '
        Me.txtDateSurvived.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtDateSurvived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDateSurvived.LocationFloat = New DevExpress.Utils.PointFloat(199.997!, 136.1527!)
        Me.txtDateSurvived.Name = "txtDateSurvived"
        Me.txtDateSurvived.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtDateSurvived.SizeF = New System.Drawing.SizeF(74.49632!, 9.783905!)
        Me.txtDateSurvived.StylePriority.UsePadding = False
        Me.txtDateSurvived.StylePriority.UseTextAlignment = False
        Me.txtDateSurvived.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthDate.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 136.1527!)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtBirthDate.SizeF = New System.Drawing.SizeF(79.56644!, 9.783905!)
        Me.txtBirthDate.StylePriority.UsePadding = False
        Me.txtBirthDate.StylePriority.UseTextAlignment = False
        Me.txtBirthDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtAddress
        '
        Me.txtAddress.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtAddress.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.KeepTogether = True
        Me.txtAddress.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 116.4768!)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtAddress.SizeF = New System.Drawing.SizeF(227.5927!, 8.395729!)
        Me.txtAddress.StylePriority.UsePadding = False
        Me.txtAddress.StylePriority.UseTextAlignment = False
        Me.txtAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imgPicture
        '
        Me.imgPicture.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.imgPicture.LocationFloat = New DevExpress.Utils.PointFloat(29.17387!, 90.17007!)
        Me.imgPicture.Name = "imgPicture"
        Me.imgPicture.SizeF = New System.Drawing.SizeF(84.2567!, 88.38598!)
        Me.imgPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'barcode
        '
        Me.barcode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.barcode.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.barcode.AutoModule = True
        Me.barcode.KeepTogether = False
        Me.barcode.LocationFloat = New DevExpress.Utils.PointFloat(274.1047!, 138.1527!)
        Me.barcode.Name = "barcode"
        Me.barcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.barcode.ShowText = False
        Me.barcode.SizeF = New System.Drawing.SizeF(63.02228!, 60.89311!)
        Me.barcode.StylePriority.UsePadding = False
        Me.barcode.StylePriority.UseTextAlignment = False
        QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.barcode.Symbology = QrCodeGenerator1
        Me.barcode.Text = "123456"
        Me.barcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtResidentName
        '
        Me.txtResidentName.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtResidentName.CanGrow = False
        Me.txtResidentName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtResidentName.KeepTogether = True
        Me.txtResidentName.LocationFloat = New DevExpress.Utils.PointFloat(118.4306!, 95.17007!)
        Me.txtResidentName.Name = "txtResidentName"
        Me.txtResidentName.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.txtResidentName.SizeF = New System.Drawing.SizeF(227.5927!, 13.91105!)
        Me.txtResidentName.StylePriority.UsePadding = False
        Me.txtResidentName.StylePriority.UseTextAlignment = False
        Me.txtResidentName.Text = "WINTER SEVILLA BUGAHOD"
        Me.txtResidentName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'imgBackground
        '
        Me.imgBackground.LocationFloat = New DevExpress.Utils.PointFloat(91.77557!, 36.66967!)
        Me.imgBackground.Name = "imgBackground"
        Me.imgBackground.SizeF = New System.Drawing.SizeF(182.7177!, 165.3761!)
        Me.imgBackground.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'imgpattern
        '
        Me.imgpattern.Image = CType(resources.GetObject("imgpattern.Image"), System.Drawing.Image)
        Me.imgpattern.KeepTogether = False
        Me.imgpattern.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 14.0!)
        Me.imgpattern.Name = "imgpattern"
        Me.imgpattern.SizeF = New System.Drawing.SizeF(338.0!, 212.0!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptIDFront
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 501, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.ShowPrintMarginsWarning = False
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents imgpattern As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents barcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents txtResidentName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCivilStatus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtGender As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDateSurvived As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBirthDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtChairman As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitleProvince As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitleResNumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitleBarangay As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitleMunicipality As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgBarangayLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtIDNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents memberid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgPicture As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgBackground As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
End Class
