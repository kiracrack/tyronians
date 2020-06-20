<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdChangePassword = New System.Windows.Forms.ToolStripButton()
        Me.lineReminders = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSummary = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCouncil = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChapter = New System.Windows.Forms.ToolStripButton()
        Me.lineUserAccounts = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdUserAccounts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMaintainance = New System.Windows.Forms.ToolStripButton()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.councilcode = New System.Windows.Forms.TextBox()
        Me.txtChapter = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ckCollectionAllUsher = New System.Windows.Forms.CheckBox()
        Me.Em_member = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendViaTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridview_member = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtCouncil = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStrip.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtChapter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.gridview_member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AllowItemReorder = True
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.Black
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdChangePassword, Me.lineReminders, Me.cmdSummary, Me.ToolStripSeparator2, Me.cmdCouncil, Me.ToolStripSeparator1, Me.cmdChapter, Me.lineUserAccounts, Me.cmdUserAccounts, Me.ToolStripSeparator4, Me.cmdMaintainance})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(1232, 45)
        Me.ToolStrip.TabIndex = 351
        Me.ToolStrip.Text = "Main Menu"
        '
        'cmdChangePassword
        '
        Me.cmdChangePassword.ForeColor = System.Drawing.Color.White
        Me.cmdChangePassword.Image = Global.TGP.My.Resources.Resources.contentImages_smallPic
        Me.cmdChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChangePassword.Name = "cmdChangePassword"
        Me.cmdChangePassword.Size = New System.Drawing.Size(100, 42)
        Me.cmdChangePassword.Text = "Dashboard"
        Me.cmdChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lineReminders
        '
        Me.lineReminders.Name = "lineReminders"
        Me.lineReminders.Size = New System.Drawing.Size(6, 45)
        '
        'cmdSummary
        '
        Me.cmdSummary.ForeColor = System.Drawing.Color.White
        Me.cmdSummary.Image = Global.TGP.My.Resources.Resources.Customer_32x32__2_
        Me.cmdSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSummary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSummary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSummary.Name = "cmdSummary"
        Me.cmdSummary.Size = New System.Drawing.Size(139, 42)
        Me.cmdSummary.Text = "Member Database"
        Me.cmdSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSummary.ToolTipText = "Point of Sale"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 45)
        '
        'cmdCouncil
        '
        Me.cmdCouncil.ForeColor = System.Drawing.Color.White
        Me.cmdCouncil.Image = Global.TGP.My.Resources.Resources.Demo_Localization_Def_User_32x32
        Me.cmdCouncil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCouncil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCouncil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCouncil.Name = "cmdCouncil"
        Me.cmdCouncil.Size = New System.Drawing.Size(115, 42)
        Me.cmdCouncil.Text = "Council Table"
        Me.cmdCouncil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCouncil.ToolTipText = "Point of Sale"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'cmdChapter
        '
        Me.cmdChapter.ForeColor = System.Drawing.Color.White
        Me.cmdChapter.Image = Global.TGP.My.Resources.Resources.GeoPointMap_32x32
        Me.cmdChapter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChapter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdChapter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChapter.Name = "cmdChapter"
        Me.cmdChapter.Size = New System.Drawing.Size(116, 42)
        Me.cmdChapter.Text = "Chapter Table"
        Me.cmdChapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChapter.ToolTipText = "Point of Sale"
        '
        'lineUserAccounts
        '
        Me.lineUserAccounts.Name = "lineUserAccounts"
        Me.lineUserAccounts.Size = New System.Drawing.Size(6, 45)
        '
        'cmdUserAccounts
        '
        Me.cmdUserAccounts.ForeColor = System.Drawing.Color.White
        Me.cmdUserAccounts.Image = Global.TGP.My.Resources.Resources.PublicFix_32x32__2_
        Me.cmdUserAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUserAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdUserAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUserAccounts.Name = "cmdUserAccounts"
        Me.cmdUserAccounts.Size = New System.Drawing.Size(119, 42)
        Me.cmdUserAccounts.Text = "User Accounts"
        Me.cmdUserAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUserAccounts.ToolTipText = "Point of Sale"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 45)
        '
        'cmdMaintainance
        '
        Me.cmdMaintainance.ForeColor = System.Drawing.Color.White
        Me.cmdMaintainance.Image = Global.TGP.My.Resources.Resources.properties_32x32__3_
        Me.cmdMaintainance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMaintainance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdMaintainance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMaintainance.Name = "cmdMaintainance"
        Me.cmdMaintainance.Size = New System.Drawing.Size(115, 42)
        Me.cmdMaintainance.Text = "Maintainance"
        Me.cmdMaintainance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMaintainance.ToolTipText = "Point of Sale"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabSummary)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabControl1.Location = New System.Drawing.Point(0, 45)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1232, 592)
        Me.tabControl1.TabIndex = 355
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.SplitContainerControl1)
        Me.tabSummary.Controls.Add(Me.ToolStrip2)
        Me.tabSummary.Location = New System.Drawing.Point(4, 26)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(1224, 562)
        Me.tabSummary.TabIndex = 3
        Me.tabSummary.Text = "Summary"
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 35)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.councilcode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtChapter)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ckCollectionAllUsher)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em_member)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1218, 524)
        Me.SplitContainerControl1.SplitterPosition = 71
        Me.SplitContainerControl1.TabIndex = 830
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'councilcode
        '
        Me.councilcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.councilcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.councilcode.Location = New System.Drawing.Point(584, 23)
        Me.councilcode.Name = "councilcode"
        Me.councilcode.Size = New System.Drawing.Size(50, 25)
        Me.councilcode.TabIndex = 831
        Me.councilcode.UseSystemPasswordChar = True
        Me.councilcode.Visible = False
        '
        'txtChapter
        '
        Me.txtChapter.Enabled = False
        Me.txtChapter.Location = New System.Drawing.Point(12, 36)
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtChapter.Properties.Appearance.Options.UseFont = True
        Me.txtChapter.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtChapter.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtChapter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtChapter.Properties.UsePopupControlMinSize = True
        Me.txtChapter.Size = New System.Drawing.Size(357, 24)
        Me.txtChapter.TabIndex = 830
        '
        'ckCollectionAllUsher
        '
        Me.ckCollectionAllUsher.AutoSize = True
        Me.ckCollectionAllUsher.Checked = True
        Me.ckCollectionAllUsher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckCollectionAllUsher.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCollectionAllUsher.Location = New System.Drawing.Point(12, 12)
        Me.ckCollectionAllUsher.Name = "ckCollectionAllUsher"
        Me.ckCollectionAllUsher.Size = New System.Drawing.Size(282, 21)
        Me.ckCollectionAllUsher.TabIndex = 829
        Me.ckCollectionAllUsher.Text = "Select Chapters (Check for multiple chapter)"
        Me.ckCollectionAllUsher.UseVisualStyleBackColor = True
        '
        'Em_member
        '
        Me.Em_member.ContextMenuStrip = Me.gridmenustrip
        Me.Em_member.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_member.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_member.Location = New System.Drawing.Point(0, 0)
        Me.Em_member.MainView = Me.gridview_member
        Me.Em_member.Name = "Em_member"
        Me.Em_member.Size = New System.Drawing.Size(1218, 448)
        Me.Em_member.TabIndex = 827
        Me.Em_member.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_member})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSelectedToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.SendViaTextToolStripMenuItem, Me.ToolStripSeparator3, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 120)
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__pencil
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Selected"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__minus
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Selected"
        '
        'SendViaTextToolStripMenuItem
        '
        Me.SendViaTextToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.mail__arrow
        Me.SendViaTextToolStripMenuItem.Name = "SendViaTextToolStripMenuItem"
        Me.SendViaTextToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SendViaTextToolStripMenuItem.Text = "Send via Text"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.arrow_continue_000_top
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh List"
        '
        'gridview_member
        '
        Me.gridview_member.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridview_member.Appearance.GroupFooter.Options.UseFont = True
        Me.gridview_member.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridview_member.Appearance.GroupPanel.Options.UseFont = True
        Me.gridview_member.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridview_member.Appearance.GroupRow.Options.UseFont = True
        Me.gridview_member.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridview_member.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridview_member.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridview_member.Appearance.Row.Options.UseFont = True
        Me.gridview_member.Appearance.Row.Options.UseTextOptions = True
        Me.gridview_member.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridview_member.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gridview_member.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridview_member.GridControl = Me.Em_member
        Me.gridview_member.Name = "gridview_member"
        Me.gridview_member.OptionsBehavior.Editable = False
        Me.gridview_member.OptionsSelection.MultiSelect = True
        Me.gridview_member.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.gridview_member.OptionsView.ColumnAutoWidth = False
        Me.gridview_member.OptionsView.RowAutoHeight = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator12, Me.txtCouncil, Me.ToolStripSeparator5, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1218, 32)
        Me.ToolStrip2.TabIndex = 827
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 29)
        Me.ToolStripLabel1.Text = "Select Council"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 32)
        '
        'txtCouncil
        '
        Me.txtCouncil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCouncil.Name = "txtCouncil"
        Me.txtCouncil.Size = New System.Drawing.Size(200, 32)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.TGP.My.Resources.Resources.user__plus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(119, 29)
        Me.ToolStripButton1.Text = "Addnew Member"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1033, 462)
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView5
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1033, 462)
        Me.GridControl2.TabIndex = 827
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView5.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView5.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView5.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView5.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView5.Appearance.GroupRow.Options.UseFont = True
        Me.GridView5.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView5.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView5.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView5.Appearance.Row.Options.UseFont = True
        Me.GridView5.Appearance.Row.Options.UseTextOptions = True
        Me.GridView5.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView5.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView5.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView5.GridControl = Me.GridControl2
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.RowAutoHeight = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1232, 637)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1075, 631)
        Me.Name = "MainWindow"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtChapter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.gridview_member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolStrip As ToolStrip
    Friend WithEvents lineReminders As ToolStripSeparator
    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents cmdCouncil As ToolStripButton
    Friend WithEvents lineUserAccounts As ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSummary As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabSummary As System.Windows.Forms.TabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_member As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_member As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtChapter As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ckCollectionAllUsher As System.Windows.Forms.CheckBox
    Friend WithEvents cmdChapter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtCouncil As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdChangePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdUserAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents councilcode As System.Windows.Forms.TextBox
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendViaTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdMaintainance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
