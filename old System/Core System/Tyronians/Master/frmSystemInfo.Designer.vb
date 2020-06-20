<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemInfo))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtversion = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.Label()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.version = New System.Windows.Forms.TextBox()
        Me.lbluptodate = New System.Windows.Forms.Label()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(357, 117)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(99, 30)
        Me.cmdreset.TabIndex = 13
        Me.cmdreset.Text = "Close"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 36)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(340, 15)
        Me.lbldescription.TabIndex = 334
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(59, 17)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(226, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Organization Management System"
        '
        'txtversion
        '
        Me.txtversion.BackColor = System.Drawing.Color.Transparent
        Me.txtversion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtversion.ForeColor = System.Drawing.Color.Gray
        Me.txtversion.Location = New System.Drawing.Point(60, 64)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(194, 15)
        Me.txtversion.TabIndex = 339
        Me.txtversion.Text = "v13.7.14"
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.Transparent
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.Gray
        Me.txtdate.Location = New System.Drawing.Point(60, 79)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(194, 15)
        Me.txtdate.TabIndex = 341
        Me.txtdate.Text = "July 14, 2013"
        '
        'cmdDownload
        '
        Me.cmdDownload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDownload.Location = New System.Drawing.Point(105, 117)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(246, 30)
        Me.cmdDownload.TabIndex = 345
        Me.cmdDownload.Text = "Download New Version v2013.7.16"
        Me.cmdDownload.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(450, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(329, 77)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(100, 20)
        Me.txturl.TabIndex = 346
        Me.txturl.Visible = False
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.Tyronians.My.Resources.Resources.tsclient
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 10)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(48, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'version
        '
        Me.version.Location = New System.Drawing.Point(329, 51)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(100, 20)
        Me.version.TabIndex = 347
        Me.version.Visible = False
        '
        'lbluptodate
        '
        Me.lbluptodate.BackColor = System.Drawing.Color.Transparent
        Me.lbluptodate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbluptodate.ForeColor = System.Drawing.Color.Gray
        Me.lbluptodate.Location = New System.Drawing.Point(60, 97)
        Me.lbluptodate.Name = "lbluptodate"
        Me.lbluptodate.Size = New System.Drawing.Size(160, 15)
        Me.lbluptodate.TabIndex = 348
        Me.lbluptodate.Text = "Your system is up to date"
        '
        'frmSystemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(468, 157)
        Me.Controls.Add(Me.lbluptodate)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtversion)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cmdreset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSystemInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Information"
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents txtversion As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.Label
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents version As System.Windows.Forms.TextBox
    Friend WithEvents lbluptodate As System.Windows.Forms.Label
End Class
