<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatchCollection))
        Me.chaptercode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtchaptername = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocalChapter = New System.Windows.Forms.ComboBox()
        Me.localchaptercode = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDatePosting = New System.Windows.Forms.DateTimePicker()
        Me.cmdPost = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonthPosting = New System.Windows.Forms.ComboBox()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chaptercode
        '
        Me.chaptercode.Location = New System.Drawing.Point(379, 15)
        Me.chaptercode.Name = "chaptercode"
        Me.chaptercode.ReadOnly = True
        Me.chaptercode.Size = New System.Drawing.Size(39, 22)
        Me.chaptercode.TabIndex = 263
        Me.chaptercode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chaptercode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(42, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Select Chapter"
        '
        'txtchaptername
        '
        Me.txtchaptername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtchaptername.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtchaptername.ForeColor = System.Drawing.Color.Black
        Me.txtchaptername.FormattingEnabled = True
        Me.txtchaptername.ItemHeight = 15
        Me.txtchaptername.Location = New System.Drawing.Point(132, 15)
        Me.txtchaptername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptername.Name = "txtchaptername"
        Me.txtchaptername.Size = New System.Drawing.Size(240, 23)
        Me.txtchaptername.TabIndex = 261
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(45, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 270
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
        Me.txtLocalChapter.Location = New System.Drawing.Point(132, 41)
        Me.txtLocalChapter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocalChapter.Name = "txtLocalChapter"
        Me.txtLocalChapter.Size = New System.Drawing.Size(240, 23)
        Me.txtLocalChapter.TabIndex = 269
        '
        'localchaptercode
        '
        Me.localchaptercode.Location = New System.Drawing.Point(431, 42)
        Me.localchaptercode.Name = "localchaptercode"
        Me.localchaptercode.ReadOnly = True
        Me.localchaptercode.Size = New System.Drawing.Size(39, 22)
        Me.localchaptercode.TabIndex = 271
        Me.localchaptercode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.localchaptercode.Visible = False
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
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Em.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(12, 136)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
        Me.Em.RowHeadersVisible = False
        Me.Em.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Em.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Em.Size = New System.Drawing.Size(749, 498)
        Me.Em.TabIndex = 380
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(51, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 382
        Me.Label9.Text = "Date Posting"
        '
        'txtDatePosting
        '
        Me.txtDatePosting.CustomFormat = "MMMM dd, yyyy"
        Me.txtDatePosting.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDatePosting.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDatePosting.Location = New System.Drawing.Point(132, 95)
        Me.txtDatePosting.Name = "txtDatePosting"
        Me.txtDatePosting.Size = New System.Drawing.Size(170, 22)
        Me.txtDatePosting.TabIndex = 383
        Me.txtDatePosting.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'cmdPost
        '
        Me.cmdPost.Location = New System.Drawing.Point(284, 639)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(186, 34)
        Me.cmdPost.TabIndex = 388
        Me.cmdPost.Text = "Post Transaction"
        Me.cmdPost.UseVisualStyleBackColor = True
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(686, 74)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(39, 22)
        Me.mode.TabIndex = 391
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Checked = True
        Me.ckAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckAll.Location = New System.Drawing.Point(378, 45)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(39, 17)
        Me.ckAll.TabIndex = 392
        Me.ckAll.Text = "All"
        Me.ckAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(39, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 394
        Me.Label1.Text = "Month Posting"
        '
        'txtMonthPosting
        '
        Me.txtMonthPosting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMonthPosting.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMonthPosting.ForeColor = System.Drawing.Color.Black
        Me.txtMonthPosting.FormattingEnabled = True
        Me.txtMonthPosting.ItemHeight = 15
        Me.txtMonthPosting.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "Jun", "July", "August", "September", "October", "November", "December"})
        Me.txtMonthPosting.Location = New System.Drawing.Point(132, 67)
        Me.txtMonthPosting.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonthPosting.Name = "txtMonthPosting"
        Me.txtMonthPosting.Size = New System.Drawing.Size(170, 23)
        Me.txtMonthPosting.TabIndex = 393
        '
        'frmBatchCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 685)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMonthPosting)
        Me.Controls.Add(Me.ckAll)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.txtDatePosting)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.localchaptercode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocalChapter)
        Me.Controls.Add(Me.chaptercode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtchaptername)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBatchCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Payment Collection"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chaptercode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtchaptername As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocalChapter As System.Windows.Forms.ComboBox
    Friend WithEvents localchaptercode As System.Windows.Forms.TextBox
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDatePosting As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonthPosting As System.Windows.Forms.ComboBox

End Class
