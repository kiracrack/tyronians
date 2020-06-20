<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.se1 = New System.Windows.Forms.ToolStripSeparator()
        Me.se2 = New System.Windows.Forms.ToolStripSeparator()
        Me.se4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChapter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAccont = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdProfile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLogoff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtfullname = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowsePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtChapter = New System.Windows.Forms.Label()
        Me.maindescription = New System.Windows.Forms.Label()
        Me.mainname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateLogin = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.loadimage = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'se1
        '
        Me.se1.Name = "se1"
        Me.se1.Size = New System.Drawing.Size(196, 6)
        '
        'se2
        '
        Me.se2.Name = "se2"
        Me.se2.Size = New System.Drawing.Size(196, 6)
        '
        'se4
        '
        Me.se4.Name = "se4"
        Me.se4.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSearch, Me.ToolStripSeparator6, Me.cmdChapter, Me.ToolStripSeparator2, Me.cmdMember, Me.ToolStripSeparator4, Me.cmdAccont, Me.ToolStripSeparator3, Me.cmdProfile, Me.ToolStripSeparator5, Me.cmdLogoff})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(20, 260, 20, 0)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(237, 743)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'cmdSearch
        '
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Image = Global.Tyronians.My.Resources.Resources.search_48
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(196, 52)
        Me.cmdSearch.Text = "Global Search Information"
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(196, 6)
        '
        'cmdChapter
        '
        Me.cmdChapter.ForeColor = System.Drawing.Color.White
        Me.cmdChapter.Image = Global.Tyronians.My.Resources.Resources.kmines_2
        Me.cmdChapter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChapter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChapter.Name = "cmdChapter"
        Me.cmdChapter.Size = New System.Drawing.Size(196, 52)
        Me.cmdChapter.Text = "Chapter Management"
        Me.cmdChapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'cmdMember
        '
        Me.cmdMember.ForeColor = System.Drawing.Color.White
        Me.cmdMember.Image = Global.Tyronians.My.Resources.Resources.osmo
        Me.cmdMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMember.Name = "cmdMember"
        Me.cmdMember.Size = New System.Drawing.Size(196, 52)
        Me.cmdMember.Text = "Members Management"
        Me.cmdMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(196, 6)
        '
        'cmdAccont
        '
        Me.cmdAccont.ForeColor = System.Drawing.Color.White
        Me.cmdAccont.Image = Global.Tyronians.My.Resources.Resources.Business_Man_Blue
        Me.cmdAccont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAccont.Name = "cmdAccont"
        Me.cmdAccont.Size = New System.Drawing.Size(196, 52)
        Me.cmdAccont.Text = "Accounts Management"
        Me.cmdAccont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'cmdProfile
        '
        Me.cmdProfile.ForeColor = System.Drawing.Color.White
        Me.cmdProfile.Image = Global.Tyronians.My.Resources.Resources.user_info2
        Me.cmdProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProfile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProfile.Name = "cmdProfile"
        Me.cmdProfile.Size = New System.Drawing.Size(196, 52)
        Me.cmdProfile.Text = "Profile Settings"
        Me.cmdProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(196, 6)
        '
        'cmdLogoff
        '
        Me.cmdLogoff.ForeColor = System.Drawing.Color.White
        Me.cmdLogoff.Image = Global.Tyronians.My.Resources.Resources.X
        Me.cmdLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogoff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLogoff.Name = "cmdLogoff"
        Me.cmdLogoff.Size = New System.Drawing.Size(196, 52)
        Me.cmdLogoff.Text = "Logoff Account"
        Me.cmdLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtfullname.ForeColor = System.Drawing.Color.White
        Me.txtfullname.Location = New System.Drawing.Point(4, 193)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtfullname.Size = New System.Drawing.Size(222, 19)
        Me.txtfullname.TabIndex = 334
        Me.txtfullname.Text = "WINTER BUGAHOD"
        Me.txtfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPosition.Location = New System.Drawing.Point(9, 224)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(212, 15)
        Me.txtPosition.TabIndex = 339
        Me.txtPosition.Text = "President"
        Me.txtPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 190)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowsePictureToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(146, 26)
        '
        'BrowsePictureToolStripMenuItem
        '
        Me.BrowsePictureToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.images_flickr
        Me.BrowsePictureToolStripMenuItem.Name = "BrowsePictureToolStripMenuItem"
        Me.BrowsePictureToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BrowsePictureToolStripMenuItem.Text = "Change Logo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(196, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'txtChapter
        '
        Me.txtChapter.BackColor = System.Drawing.Color.Transparent
        Me.txtChapter.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtChapter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtChapter.Location = New System.Drawing.Point(9, 211)
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Size = New System.Drawing.Size(212, 15)
        Me.txtChapter.TabIndex = 340
        Me.txtChapter.Text = "DIPOLOG CHAPTER"
        Me.txtChapter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'maindescription
        '
        Me.maindescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maindescription.BackColor = System.Drawing.Color.Transparent
        Me.maindescription.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.maindescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.maindescription.Location = New System.Drawing.Point(14, 696)
        Me.maindescription.Name = "maindescription"
        Me.maindescription.Size = New System.Drawing.Size(0, 12)
        Me.maindescription.TabIndex = 343
        Me.maindescription.Text = "Developed by Bro. Winter Bugahod"
        Me.maindescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainname
        '
        Me.mainname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainname.BackColor = System.Drawing.Color.Transparent
        Me.mainname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mainname.ForeColor = System.Drawing.Color.White
        Me.mainname.Location = New System.Drawing.Point(14, 683)
        Me.mainname.Name = "mainname"
        Me.mainname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mainname.Size = New System.Drawing.Size(0, 12)
        Me.mainname.TabIndex = 342
        Me.mainname.Text = "ORGANIZATION MANAGEMENT SYSTEM"
        Me.mainname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "DIPOLOG CITY CHAPTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDateLogin
        '
        Me.txtDateLogin.BackColor = System.Drawing.Color.Transparent
        Me.txtDateLogin.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.txtDateLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDateLogin.Location = New System.Drawing.Point(9, 239)
        Me.txtDateLogin.Name = "txtDateLogin"
        Me.txtDateLogin.Size = New System.Drawing.Size(212, 15)
        Me.txtDateLogin.TabIndex = 345
        Me.txtDateLogin.Text = "July 10, 2013 11:34:32 PM"
        Me.txtDateLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'loadimage
        '
        Me.loadimage.BackColor = System.Drawing.Color.Transparent
        Me.loadimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loadimage.Location = New System.Drawing.Point(219, 239)
        Me.loadimage.Name = "loadimage"
        Me.loadimage.Size = New System.Drawing.Size(2, 2)
        Me.loadimage.TabIndex = 349
        Me.loadimage.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Location = New System.Drawing.Point(43, 666)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(153, 13)
        Me.LinkLabel2.TabIndex = 350
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Send Message to Administrator"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(240, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(0, 733)
        Me.SplitContainer1.SplitterDistance = 44
        Me.SplitContainer1.TabIndex = 351
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(0, 702)
        Me.ListView1.TabIndex = 346
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Tyronians.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(238, 733)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.loadimage)
        Me.Controls.Add(Me.txtDateLogin)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtChapter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maindescription)
        Me.Controls.Add(Me.mainname)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tyro Gyn Phi Fraternity and Sorority"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents se1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtfullname As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAccont As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtChapter As System.Windows.Forms.Label
    Friend WithEvents cmdChapter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdMember As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLogoff As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProfile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents maindescription As System.Windows.Forms.Label
    Friend WithEvents mainname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateLogin As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowsePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadimage As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
