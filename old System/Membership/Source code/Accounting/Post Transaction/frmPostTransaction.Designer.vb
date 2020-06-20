<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPostTransaction))
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdVerify = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagAsInactiveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdatetrn = New System.Windows.Forms.DateTimePicker()
        Me.txtdatetrn2 = New System.Windows.Forms.DateTimePicker()
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
        Me.Em.Location = New System.Drawing.Point(11, 40)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(1175, 595)
        Me.Em.TabIndex = 218
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVerify, Me.ViewTransactionToolStripMenuItem, Me.EditChapterToolStripMenuItem, Me.TagAsInactiveMemberToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(172, 120)
        '
        'cmdVerify
        '
        Me.cmdVerify.Image = Global.Tyronians.My.Resources.Resources.tick
        Me.cmdVerify.Name = "cmdVerify"
        Me.cmdVerify.Size = New System.Drawing.Size(171, 22)
        Me.cmdVerify.Text = "Verify Transaction"
        Me.cmdVerify.Visible = False
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__arrow
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ViewTransactionToolStripMenuItem.Text = "View Transaction"
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
        Me.txtSearch.Location = New System.Drawing.Point(936, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 22)
        Me.txtSearch.TabIndex = 260
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(11, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 262
        Me.Label9.Text = "Date Transaction"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(484, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 264
        Me.Button1.Text = "Post New Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdatetrn
        '
        Me.txtdatetrn.CustomFormat = "MMMM dd, yyyy"
        Me.txtdatetrn.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatetrn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdatetrn.Location = New System.Drawing.Point(112, 10)
        Me.txtdatetrn.Name = "txtdatetrn"
        Me.txtdatetrn.Size = New System.Drawing.Size(180, 22)
        Me.txtdatetrn.TabIndex = 384
        Me.txtdatetrn.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'txtdatetrn2
        '
        Me.txtdatetrn2.CustomFormat = "MMMM dd, yyyy"
        Me.txtdatetrn2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatetrn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdatetrn2.Location = New System.Drawing.Point(298, 10)
        Me.txtdatetrn2.Name = "txtdatetrn2"
        Me.txtdatetrn2.Size = New System.Drawing.Size(180, 22)
        Me.txtdatetrn2.TabIndex = 385
        Me.txtdatetrn2.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'frmPostTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 646)
        Me.Controls.Add(Me.txtdatetrn2)
        Me.Controls.Add(Me.txtdatetrn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Em)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPostTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting Transaction"
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdatetrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdVerify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtdatetrn2 As System.Windows.Forms.DateTimePicker

End Class
