<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChapter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChapter))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cmd_financer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.councilcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.LinkLabel()
        Me.txtCouncil = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtChapterName = New System.Windows.Forms.TextBox()
        Me.SendViaTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_financer.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Em)
        Me.GroupBox2.Controls.Add(Me.mode)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.councilcode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblClass)
        Me.GroupBox2.Controls.Add(Me.txtCouncil)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.txtChapterName)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 543)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chapter Management"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.cmd_financer
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(6, 86)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(434, 452)
        Me.Em.TabIndex = 827
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cmd_financer
        '
        Me.cmd_financer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.SendViaTextToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.cmd_financer.Name = "gridmenustrip"
        Me.cmd_financer.Size = New System.Drawing.Size(165, 120)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__pencil
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditToolStripMenuItem.Text = "Edit Selected"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__minus
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.arrow_continue_000_top
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh List"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.mode.Location = New System.Drawing.Point(345, 184)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(50, 25)
        Me.mode.TabIndex = 400
        Me.mode.UseSystemPasswordChar = True
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.id.Location = New System.Drawing.Point(282, 201)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(29, 25)
        Me.id.TabIndex = 399
        Me.id.UseSystemPasswordChar = True
        Me.id.Visible = False
        '
        'councilcode
        '
        Me.councilcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.councilcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.councilcode.Location = New System.Drawing.Point(359, 215)
        Me.councilcode.Name = "councilcode"
        Me.councilcode.Size = New System.Drawing.Size(50, 25)
        Me.councilcode.TabIndex = 398
        Me.councilcode.UseSystemPasswordChar = True
        Me.councilcode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 397
        Me.Label4.Text = "Chapter Name"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(28, 27)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(88, 17)
        Me.lblClass.TabIndex = 396
        Me.lblClass.TabStop = True
        Me.lblClass.Text = "Select Council"
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCouncil
        '
        Me.txtCouncil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCouncil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCouncil.FormattingEnabled = True
        Me.txtCouncil.Location = New System.Drawing.Point(122, 24)
        Me.txtCouncil.Name = "txtCouncil"
        Me.txtCouncil.Size = New System.Drawing.Size(238, 25)
        Me.txtCouncil.TabIndex = 395
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(359, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 25)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.UseSystemPasswordChar = True
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextBox2.Location = New System.Drawing.Point(359, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 25)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.UseSystemPasswordChar = True
        Me.TextBox2.Visible = False
        '
        'txtChapterName
        '
        Me.txtChapterName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChapterName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChapterName.Location = New System.Drawing.Point(122, 53)
        Me.txtChapterName.Name = "txtChapterName"
        Me.txtChapterName.Size = New System.Drawing.Size(238, 25)
        Me.txtChapterName.TabIndex = 0
        '
        'SendViaTextToolStripMenuItem
        '
        Me.SendViaTextToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.mail__arrow
        Me.SendViaTextToolStripMenuItem.Name = "SendViaTextToolStripMenuItem"
        Me.SendViaTextToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SendViaTextToolStripMenuItem.Text = "Send via Text"
        '
        'frmChapter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(446, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChapter"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chapter Management"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_financer.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_financer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents councilcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCouncil As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtChapterName As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SendViaTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
