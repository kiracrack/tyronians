<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrialBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrialBalance))
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdatetrn = New System.Windows.Forms.DateTimePicker()
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
        Me.Em.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 40)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        Me.Em.RowHeadersVisible = False
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(573, 595)
        Me.Em.TabIndex = 218
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTransactionToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(141, 54)
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.notebook__arrow
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ViewTransactionToolStripMenuItem.Text = "View Ledger"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.Tyronians.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(140, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(334, 9)
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
        'frmTrialBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 646)
        Me.Controls.Add(Me.txtdatetrn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Em)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTrialBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting Transaction"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdatetrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents ViewTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
