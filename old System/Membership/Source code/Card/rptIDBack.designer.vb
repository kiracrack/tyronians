<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptIDBack
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptIDBack))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtDetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.residentid = New DevExpress.XtraReports.UI.XRLabel()
        Me.barcode = New DevExpress.XtraReports.UI.XRBarCode()
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
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel2, Me.XrLabel3, Me.XrLabel1, Me.txtDetails, Me.residentid, Me.barcode, Me.imgpattern})
        Me.TopMargin.HeightF = 500.7857!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBorderWidth = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(32.5737!, 116.4195!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(295.7321!, 9.5!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "If found, please return to the nearest Tyro Gyn Phi Office"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel4.TextTrimming = System.Drawing.StringTrimming.None
        '
        'XrLabel2
        '
        Me.XrLabel2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(32.5737!, 101.9285!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(295.7321!, 9.5!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "governed by Fraternity rules and regulation"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel2.TextTrimming = System.Drawing.StringTrimming.None
        '
        'XrLabel3
        '
        Me.XrLabel3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(32.5737!, 92.43745!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(295.7321!, 9.499992!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "By using this card, you agree to the terms of its issuance as"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel3.TextTrimming = System.Drawing.StringTrimming.None
        '
        'XrLabel1
        '
        Me.XrLabel1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(32.5737!, 77.94634!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(295.7321!, 9.5!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "is recognized as proof of identity of the cardholder."
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrLabel1.TextTrimming = System.Drawing.StringTrimming.None
        '
        'txtDetails
        '
        Me.txtDetails.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.txtDetails.CanGrow = False
        Me.txtDetails.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.txtDetails.LocationFloat = New DevExpress.Utils.PointFloat(32.5737!, 68.4553!)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtDetails.SizeF = New System.Drawing.SizeF(295.7321!, 9.5!)
        Me.txtDetails.StylePriority.UseFont = False
        Me.txtDetails.StylePriority.UseTextAlignment = False
        Me.txtDetails.Text = "This card, issued exclusively by the Tyro Gyn Phi Dipolog City Chapter"
        Me.txtDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.txtDetails.TextTrimming = System.Drawing.StringTrimming.None
        '
        'residentid
        '
        Me.residentid.CanGrow = False
        Me.residentid.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.25!)
        Me.residentid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.residentid.LocationFloat = New DevExpress.Utils.PointFloat(144.6749!, 154.2598!)
        Me.residentid.Name = "residentid"
        Me.residentid.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.residentid.SizeF = New System.Drawing.SizeF(71.52994!, 12.04929!)
        Me.residentid.StylePriority.UseFont = False
        Me.residentid.StylePriority.UsePadding = False
        Me.residentid.StylePriority.UseTextAlignment = False
        Me.residentid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'barcode
        '
        Me.barcode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.barcode.AutoModule = True
        Me.barcode.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.barcode.BorderWidth = 0.0!
        Me.barcode.KeepTogether = False
        Me.barcode.LocationFloat = New DevExpress.Utils.PointFloat(127.0042!, 132.8011!)
        Me.barcode.Name = "barcode"
        Me.barcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.barcode.ShowText = False
        Me.barcode.SizeF = New System.Drawing.SizeF(106.8713!, 21.4586!)
        Me.barcode.StylePriority.UseBorders = False
        Me.barcode.StylePriority.UseBorderWidth = False
        Me.barcode.StylePriority.UsePadding = False
        Me.barcode.StylePriority.UseTextAlignment = False
        Me.barcode.Symbology = Code128Generator1
        Me.barcode.Text = "2999827-12002"
        Me.barcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'imgpattern
        '
        Me.imgpattern.Image = CType(resources.GetObject("imgpattern.Image"), System.Drawing.Image)
        Me.imgpattern.KeepTogether = False
        Me.imgpattern.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 14.0!)
        Me.imgpattern.Name = "imgpattern"
        Me.imgpattern.SizeF = New System.Drawing.SizeF(338.0!, 212.0!)
        Me.imgpattern.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptIDBack
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 501, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.ShowPrintMarginsWarning = False
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents barcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents residentid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtDetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgpattern As DevExpress.XtraReports.UI.XRPictureBox
End Class
