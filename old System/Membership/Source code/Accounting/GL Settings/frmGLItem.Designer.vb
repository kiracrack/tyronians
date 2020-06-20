<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGLItem))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtParent = New System.Windows.Forms.ComboBox()
        Me.parentcode = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.gl = New System.Windows.Forms.CheckBox()
        Me.sl = New System.Windows.Forms.CheckBox()
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagAsInactiveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VewLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSave.Location = New System.Drawing.Point(126, 172)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(130, 29)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(126, 69)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(347, 22)
        Me.txtItemName.TabIndex = 1
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
        Me.Em.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Em.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 219)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(771, 369)
        Me.Em.TabIndex = 218
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.TagAsInactiveMemberToolStripMenuItem, Me.VewLedgerToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(141, 98)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'itemcode
        '
        Me.itemcode.Location = New System.Drawing.Point(126, 44)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(104, 22)
        Me.itemcode.TabIndex = 0
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(679, 95)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(47, 22)
        Me.mode.TabIndex = 221
        Me.mode.Visible = False
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
        Me.groupcode.Location = New System.Drawing.Point(126, 19)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.ReadOnly = True
        Me.groupcode.Size = New System.Drawing.Size(104, 22)
        Me.groupcode.TabIndex = 263
        Me.groupcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(79, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Group"
        '
        'txtGroup
        '
        Me.txtGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGroup.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtGroup.ForeColor = System.Drawing.Color.Black
        Me.txtGroup.FormattingEnabled = True
        Me.txtGroup.ItemHeight = 15
        Me.txtGroup.Location = New System.Drawing.Point(233, 18)
        Me.txtGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(240, 23)
        Me.txtGroup.TabIndex = 261
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(57, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(53, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(78, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Parent"
        '
        'txtParent
        '
        Me.txtParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtParent.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtParent.ForeColor = System.Drawing.Color.Black
        Me.txtParent.FormattingEnabled = True
        Me.txtParent.ItemHeight = 15
        Me.txtParent.Location = New System.Drawing.Point(233, 120)
        Me.txtParent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtParent.Name = "txtParent"
        Me.txtParent.Size = New System.Drawing.Size(240, 23)
        Me.txtParent.TabIndex = 269
        '
        'parentcode
        '
        Me.parentcode.Location = New System.Drawing.Point(126, 120)
        Me.parentcode.Name = "parentcode"
        Me.parentcode.ReadOnly = True
        Me.parentcode.Size = New System.Drawing.Size(104, 22)
        Me.parentcode.TabIndex = 271
        Me.parentcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(126, 95)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(104, 22)
        Me.txtLevel.TabIndex = 272
        Me.txtLevel.Text = "0"
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(85, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 273
        Me.Label5.Text = "Level"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(679, 67)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(47, 22)
        Me.id.TabIndex = 274
        Me.id.Visible = False
        '
        'gl
        '
        Me.gl.AutoSize = True
        Me.gl.Location = New System.Drawing.Point(126, 148)
        Me.gl.Name = "gl"
        Me.gl.Size = New System.Drawing.Size(64, 17)
        Me.gl.TabIndex = 275
        Me.gl.Text = "GL Item"
        Me.gl.UseVisualStyleBackColor = True
        '
        'sl
        '
        Me.sl.AutoSize = True
        Me.sl.Location = New System.Drawing.Point(196, 148)
        Me.sl.Name = "sl"
        Me.sl.Size = New System.Drawing.Size(62, 17)
        Me.sl.TabIndex = 276
        Me.sl.Text = "SL Item"
        Me.sl.UseVisualStyleBackColor = True
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__pencil
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Item"
        '
        'TagAsInactiveMemberToolStripMenuItem
        '
        Me.TagAsInactiveMemberToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__minus
        Me.TagAsInactiveMemberToolStripMenuItem.Name = "TagAsInactiveMemberToolStripMenuItem"
        Me.TagAsInactiveMemberToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TagAsInactiveMemberToolStripMenuItem.Text = "Delete Item"
        '
        'VewLedgerToolStripMenuItem
        '
        Me.VewLedgerToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__arrow
        Me.VewLedgerToolStripMenuItem.Name = "VewLedgerToolStripMenuItem"
        Me.VewLedgerToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VewLedgerToolStripMenuItem.Text = "Vew Ledger"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.Tyronians.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(140, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'frmGLItem
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 617)
        Me.Controls.Add(Me.sl)
        Me.Controls.Add(Me.gl)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.parentcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtParent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGLItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Item"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TagAsInactiveMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtParent As System.Windows.Forms.ComboBox
    Friend WithEvents parentcode As System.Windows.Forms.TextBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents gl As System.Windows.Forms.CheckBox
    Friend WithEvents sl As System.Windows.Forms.CheckBox
    Friend WithEvents VewLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
