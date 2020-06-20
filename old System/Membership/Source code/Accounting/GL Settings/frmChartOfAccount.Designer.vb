<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChartOfAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChartOfAccount))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TreeviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollapseGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridmenustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(624, 588)
        Me.TreeView1.TabIndex = 649
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TreeviewToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(162, 26)
        '
        'TreeviewToolStripMenuItem
        '
        Me.TreeviewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpandGroupsToolStripMenuItem, Me.CollapseGroupsToolStripMenuItem})
        Me.TreeviewToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.folder_stand
        Me.TreeviewToolStripMenuItem.Name = "TreeviewToolStripMenuItem"
        Me.TreeviewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TreeviewToolStripMenuItem.Text = "Treeview Display"
        '
        'ExpandGroupsToolStripMenuItem
        '
        Me.ExpandGroupsToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.folder_tree
        Me.ExpandGroupsToolStripMenuItem.Name = "ExpandGroupsToolStripMenuItem"
        Me.ExpandGroupsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExpandGroupsToolStripMenuItem.Text = "Expand Groups"
        '
        'CollapseGroupsToolStripMenuItem
        '
        Me.CollapseGroupsToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.folders_stack
        Me.CollapseGroupsToolStripMenuItem.Name = "CollapseGroupsToolStripMenuItem"
        Me.CollapseGroupsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CollapseGroupsToolStripMenuItem.Text = "Collapse Groups"
        '
        'frmChartOfAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 588)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChartOfAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Accounts"
        Me.gridmenustrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TreeviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollapseGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
