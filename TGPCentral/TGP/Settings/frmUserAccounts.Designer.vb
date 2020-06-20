<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccounts))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCouncil = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCouncil = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPhoneNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCouncil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCouncil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdConfirm)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCouncil)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Em)
        Me.GroupBox1.Controls.Add(Me.mode)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 478)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authorized Account"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(110, 105)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(168, 34)
        Me.cmdConfirm.TabIndex = 870
        Me.cmdConfirm.Text = "Confirm Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(56, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 869
        Me.Label6.Text = "Council"
        '
        'txtCouncil
        '
        Me.txtCouncil.EditValue = ""
        Me.txtCouncil.Location = New System.Drawing.Point(110, 24)
        Me.txtCouncil.Name = "txtCouncil"
        Me.txtCouncil.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCouncil.Properties.Appearance.Options.UseFont = True
        Me.txtCouncil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCouncil.Properties.DisplayMember = "Council"
        Me.txtCouncil.Properties.NullText = ""
        Me.txtCouncil.Properties.PopupView = Me.gridCouncil
        Me.txtCouncil.Properties.ValueMember = "councilcode"
        Me.txtCouncil.Size = New System.Drawing.Size(222, 24)
        Me.txtCouncil.TabIndex = 868
        '
        'gridCouncil
        '
        Me.gridCouncil.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCouncil.Name = "gridCouncil"
        Me.gridCouncil.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCouncil.OptionsView.ShowGroupPanel = False
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(110, 78)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhoneNumber.Properties.Appearance.Options.UseFont = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(168, 24)
        Me.txtPhoneNumber.TabIndex = 867
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(110, 51)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullname.Properties.Appearance.Options.UseFont = True
        Me.txtFullname.Size = New System.Drawing.Size(222, 24)
        Me.txtFullname.TabIndex = 866
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 865
        Me.Label1.Text = "Phone Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(48, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 864
        Me.Label12.Text = "Fullname"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(9, 149)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(432, 323)
        Me.Em.TabIndex = 828
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
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
        Me.mode.Location = New System.Drawing.Point(388, 58)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(50, 25)
        Me.mode.TabIndex = 27
        Me.mode.UseSystemPasswordChar = True
        Me.mode.Visible = False
        '
        'id
        '
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.id.Location = New System.Drawing.Point(388, 27)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(50, 25)
        Me.id.TabIndex = 26
        Me.id.UseSystemPasswordChar = True
        Me.id.Visible = False
        '
        'frmUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(450, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserAccounts"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Council Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCouncil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCouncil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mode As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents gridmenustrip As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCouncil As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCouncil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
End Class
