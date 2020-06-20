<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrnSettingsItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrnSettingsItems))
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagAsInactiveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrnGroup = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTrnTitle = New System.Windows.Forms.ComboBox()
        Me.trncode = New System.Windows.Forms.TextBox()
        Me.cmdTrnGroup = New System.Windows.Forms.Button()
        Me.cmdTrnTitle = New System.Windows.Forms.Button()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.AllowUserToAddRows = False
        Me.Em.AllowUserToDeleteRows = False
        Me.Em.AllowUserToResizeColumns = False
        Me.Em.AllowUserToResizeRows = False
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Em.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 89)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(771, 499)
        Me.Em.TabIndex = 218
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.TagAsInactiveMemberToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(141, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image =  Global.Tyronians.My.Resources.Resources.notebook__plus
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditChapterToolStripMenuItem.Text = "Add Item"
        '
        'TagAsInactiveMemberToolStripMenuItem
        '
        Me.TagAsInactiveMemberToolStripMenuItem.Image =  Global.Tyronians.My.Resources.Resources.notebook__minus
        Me.TagAsInactiveMemberToolStripMenuItem.Name = "TagAsInactiveMemberToolStripMenuItem"
        Me.TagAsInactiveMemberToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TagAsInactiveMemberToolStripMenuItem.Text = "Delete Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image =  Global.Tyronians.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(140, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(11, 587)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(770, 22)
        Me.txtSearch.TabIndex = 260
        '
        'groupcode
        '
        Me.groupcode.Location = New System.Drawing.Point(723, 20)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.ReadOnly = True
        Me.groupcode.Size = New System.Drawing.Size(39, 22)
        Me.groupcode.TabIndex = 263
        Me.groupcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.groupcode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(24, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Transaction Group"
        '
        'txtTrnGroup
        '
        Me.txtTrnGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTrnGroup.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtTrnGroup.ForeColor = System.Drawing.Color.Black
        Me.txtTrnGroup.FormattingEnabled = True
        Me.txtTrnGroup.ItemHeight = 15
        Me.txtTrnGroup.Location = New System.Drawing.Point(135, 19)
        Me.txtTrnGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrnGroup.Name = "txtTrnGroup"
        Me.txtTrnGroup.Size = New System.Drawing.Size(240, 23)
        Me.txtTrnGroup.TabIndex = 261
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(34, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Transaction Title"
        '
        'txtTrnTitle
        '
        Me.txtTrnTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTrnTitle.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtTrnTitle.ForeColor = System.Drawing.Color.Black
        Me.txtTrnTitle.FormattingEnabled = True
        Me.txtTrnTitle.ItemHeight = 15
        Me.txtTrnTitle.Location = New System.Drawing.Point(135, 46)
        Me.txtTrnTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrnTitle.Name = "txtTrnTitle"
        Me.txtTrnTitle.Size = New System.Drawing.Size(240, 23)
        Me.txtTrnTitle.TabIndex = 269
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(723, 50)
        Me.trncode.Name = "trncode"
        Me.trncode.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(39, 22)
        Me.trncode.TabIndex = 271
        Me.trncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trncode.Visible = False
        '
        'cmdTrnGroup
        '
        Me.cmdTrnGroup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdTrnGroup.Location = New System.Drawing.Point(378, 18)
        Me.cmdTrnGroup.Name = "cmdTrnGroup"
        Me.cmdTrnGroup.Size = New System.Drawing.Size(34, 23)
        Me.cmdTrnGroup.TabIndex = 272
        Me.cmdTrnGroup.Text = "..."
        Me.cmdTrnGroup.UseVisualStyleBackColor = True
        '
        'cmdTrnTitle
        '
        Me.cmdTrnTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdTrnTitle.Location = New System.Drawing.Point(378, 45)
        Me.cmdTrnTitle.Name = "cmdTrnTitle"
        Me.cmdTrnTitle.Size = New System.Drawing.Size(34, 24)
        Me.cmdTrnTitle.TabIndex = 273
        Me.cmdTrnTitle.Text = "..."
        Me.cmdTrnTitle.UseVisualStyleBackColor = True
        '
        'frmTrnSettingsItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 617)
        Me.Controls.Add(Me.cmdTrnTitle)
        Me.Controls.Add(Me.cmdTrnGroup)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTrnTitle)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTrnGroup)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Em)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTrnSettingsItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predefined Transaction"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TagAsInactiveMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTrnGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTrnTitle As System.Windows.Forms.ComboBox
    Friend WithEvents trncode As System.Windows.Forms.TextBox
    Friend WithEvents cmdTrnGroup As System.Windows.Forms.Button
    Friend WithEvents cmdTrnTitle As System.Windows.Forms.Button

End Class
