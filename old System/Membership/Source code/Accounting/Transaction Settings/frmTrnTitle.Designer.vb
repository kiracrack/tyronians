<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrnTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrnTitle))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagAsInactiveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.trncode = New System.Windows.Forms.TextBox()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSave.Location = New System.Drawing.Point(318, 25)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(52, 24)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtItemName
        '
        Me.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemName.Location = New System.Drawing.Point(11, 25)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(305, 22)
        Me.txtItemName.TabIndex = 1
        '
        'Em
        '
        Me.Em.AllowUserToAddRows = False
        Me.Em.AllowUserToDeleteRows = False
        Me.Em.AllowUserToResizeColumns = False
        Me.Em.AllowUserToResizeRows = False
        Me.Em.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Em.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 52)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(359, 347)
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
        Me.EditChapterToolStripMenuItem.Image =  Global.Tyronians.My.Resources.Resources.notebook__pencil
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Item"
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
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(92, 175)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(47, 22)
        Me.mode.TabIndex = 221
        Me.mode.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 15)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "Complete Specific Transaction Title Name"
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(11, 398)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(358, 22)
        Me.txtSearch.TabIndex = 260
        '
        'groupcode
        '
        Me.groupcode.Location = New System.Drawing.Point(167, 203)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.Size = New System.Drawing.Size(47, 22)
        Me.groupcode.TabIndex = 261
        Me.groupcode.Visible = False
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(167, 231)
        Me.trncode.Name = "trncode"
        Me.trncode.Size = New System.Drawing.Size(47, 22)
        Me.trncode.TabIndex = 262
        Me.trncode.Visible = False
        '
        'frmTrnTitle
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 428)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrnTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Title"
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
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents trncode As System.Windows.Forms.TextBox

End Class
