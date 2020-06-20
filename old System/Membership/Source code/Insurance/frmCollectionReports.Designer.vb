<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollectionReports))
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagAsInactiveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonthPosting = New System.Windows.Forms.ComboBox()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        Me.localchaptercode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocalChapter = New System.Windows.Forms.ComboBox()
        Me.chaptercode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtchaptername = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.ComboBox()
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
        Me.Em.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Em.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 101)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(1175, 534)
        Me.Em.TabIndex = 218
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.TagAsInactiveMemberToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(172, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__plus
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Transaction"
        '
        'TagAsInactiveMemberToolStripMenuItem
        '
        Me.TagAsInactiveMemberToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__minus
        Me.TagAsInactiveMemberToolStripMenuItem.Name = "TagAsInactiveMemberToolStripMenuItem"
        Me.TagAsInactiveMemberToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TagAsInactiveMemberToolStripMenuItem.Text = "Delete Transaction"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(168, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.Tyronians.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(171, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(935, 74)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 22)
        Me.txtSearch.TabIndex = 260
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(71, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 403
        Me.Label1.Text = "Period"
        '
        'txtMonthPosting
        '
        Me.txtMonthPosting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMonthPosting.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMonthPosting.ForeColor = System.Drawing.Color.Black
        Me.txtMonthPosting.FormattingEnabled = True
        Me.txtMonthPosting.ItemHeight = 15
        Me.txtMonthPosting.Location = New System.Drawing.Point(188, 63)
        Me.txtMonthPosting.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonthPosting.Name = "txtMonthPosting"
        Me.txtMonthPosting.Size = New System.Drawing.Size(171, 23)
        Me.txtMonthPosting.TabIndex = 402
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Checked = True
        Me.ckAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckAll.Location = New System.Drawing.Point(365, 41)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(39, 17)
        Me.ckAll.TabIndex = 401
        Me.ckAll.Text = "All"
        Me.ckAll.UseVisualStyleBackColor = True
        '
        'localchaptercode
        '
        Me.localchaptercode.Location = New System.Drawing.Point(848, 38)
        Me.localchaptercode.Name = "localchaptercode"
        Me.localchaptercode.ReadOnly = True
        Me.localchaptercode.Size = New System.Drawing.Size(39, 22)
        Me.localchaptercode.TabIndex = 400
        Me.localchaptercode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.localchaptercode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(32, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 399
        Me.Label3.Text = "Local Chapter"
        '
        'txtLocalChapter
        '
        Me.txtLocalChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtLocalChapter.Enabled = False
        Me.txtLocalChapter.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtLocalChapter.ForeColor = System.Drawing.Color.Black
        Me.txtLocalChapter.FormattingEnabled = True
        Me.txtLocalChapter.ItemHeight = 15
        Me.txtLocalChapter.Location = New System.Drawing.Point(119, 37)
        Me.txtLocalChapter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocalChapter.Name = "txtLocalChapter"
        Me.txtLocalChapter.Size = New System.Drawing.Size(240, 23)
        Me.txtLocalChapter.TabIndex = 398
        '
        'chaptercode
        '
        Me.chaptercode.Location = New System.Drawing.Point(848, 13)
        Me.chaptercode.Name = "chaptercode"
        Me.chaptercode.ReadOnly = True
        Me.chaptercode.Size = New System.Drawing.Size(39, 22)
        Me.chaptercode.TabIndex = 397
        Me.chaptercode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chaptercode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(29, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 396
        Me.Label4.Text = "Select Chapter"
        '
        'txtchaptername
        '
        Me.txtchaptername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtchaptername.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtchaptername.ForeColor = System.Drawing.Color.Black
        Me.txtchaptername.FormattingEnabled = True
        Me.txtchaptername.ItemHeight = 15
        Me.txtchaptername.Location = New System.Drawing.Point(119, 11)
        Me.txtchaptername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptername.Name = "txtchaptername"
        Me.txtchaptername.Size = New System.Drawing.Size(240, 23)
        Me.txtchaptername.TabIndex = 395
        '
        'txtYear
        '
        Me.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.ItemHeight = 15
        Me.txtYear.Location = New System.Drawing.Point(119, 63)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(65, 23)
        Me.txtYear.TabIndex = 404
        '
        'frmCollectionReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 646)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMonthPosting)
        Me.Controls.Add(Me.ckAll)
        Me.Controls.Add(Me.localchaptercode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocalChapter)
        Me.Controls.Add(Me.chaptercode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtchaptername)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Em)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCollectionReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Collection Reports"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonthPosting As System.Windows.Forms.ComboBox
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox
    Friend WithEvents localchaptercode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocalChapter As System.Windows.Forms.ComboBox
    Friend WithEvents chaptercode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtchaptername As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.ComboBox

End Class
