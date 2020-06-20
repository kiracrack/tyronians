<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrnAddItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrnAddItem))
        Me.txtCredit = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.trncode = New System.Windows.Forms.TextBox()
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCredit
        '
        Me.txtCredit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCredit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCredit.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtCredit.ForeColor = System.Drawing.Color.Black
        Me.txtCredit.FormattingEnabled = True
        Me.txtCredit.ItemHeight = 15
        Me.txtCredit.Items.AddRange(New Object() {"Credit Transaction", "Debit Transaction"})
        Me.txtCredit.Location = New System.Drawing.Point(21, 34)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(240, 23)
        Me.txtCredit.TabIndex = 261
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button4.Location = New System.Drawing.Point(204, 564)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 38)
        Me.Button4.TabIndex = 274
        Me.Button4.Text = "Confirm Add Item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(657, 50)
        Me.trncode.Name = "trncode"
        Me.trncode.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(39, 22)
        Me.trncode.TabIndex = 276
        Me.trncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groupcode
        '
        Me.groupcode.Location = New System.Drawing.Point(657, 20)
        Me.groupcode.Name = "groupcode"
        Me.groupcode.ReadOnly = True
        Me.groupcode.Size = New System.Drawing.Size(39, 22)
        Me.groupcode.TabIndex = 275
        Me.groupcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(18, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Select Transaction Type"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(21, 536)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(528, 22)
        Me.txtSearch.TabIndex = 278
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(21, 63)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(528, 468)
        Me.MyDataGridView.TabIndex = 380
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAll.ForeColor = System.Drawing.Color.Black
        Me.ckAll.Location = New System.Drawing.Point(472, 40)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(76, 19)
        Me.ckAll.TabIndex = 417
        Me.ckAll.Text = "Check All"
        Me.ckAll.UseVisualStyleBackColor = True
        '
        'frmTrnAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 617)
        Me.Controls.Add(Me.ckAll)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCredit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTrnAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Add Item"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCredit As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents trncode As System.Windows.Forms.TextBox
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox

End Class
