<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostingPredefineGL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPostingPredefineGL))
        Me.groupcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrnGroup = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTrnTitle = New System.Windows.Forms.ComboBox()
        Me.trncode = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdatetrn = New System.Windows.Forms.DateTimePicker()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.cmdPost = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrnNo = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupcode
        '
        Me.groupcode.Location = New System.Drawing.Point(686, 16)
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
        Me.Label4.Location = New System.Drawing.Point(25, 44)
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
        Me.txtTrnGroup.Location = New System.Drawing.Point(135, 41)
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
        Me.Label3.Location = New System.Drawing.Point(35, 70)
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
        Me.txtTrnTitle.Location = New System.Drawing.Point(135, 67)
        Me.txtTrnTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrnTitle.Name = "txtTrnTitle"
        Me.txtTrnTitle.Size = New System.Drawing.Size(240, 23)
        Me.txtTrnTitle.TabIndex = 269
        '
        'trncode
        '
        Me.trncode.Location = New System.Drawing.Point(686, 46)
        Me.trncode.Name = "trncode"
        Me.trncode.ReadOnly = True
        Me.trncode.Size = New System.Drawing.Size(39, 22)
        Me.trncode.TabIndex = 271
        Me.trncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trncode.Visible = False
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
        Me.Em.Location = New System.Drawing.Point(12, 243)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
        Me.Em.RowHeadersVisible = False
        Me.Em.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Em.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Em.Size = New System.Drawing.Size(749, 431)
        Me.Em.TabIndex = 380
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(55, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 382
        Me.Label9.Text = "Date Posting"
        '
        'txtdatetrn
        '
        Me.txtdatetrn.CustomFormat = "MMMM dd, yyyy"
        Me.txtdatetrn.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatetrn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdatetrn.Location = New System.Drawing.Point(135, 93)
        Me.txtdatetrn.Name = "txtdatetrn"
        Me.txtdatetrn.Size = New System.Drawing.Size(170, 22)
        Me.txtdatetrn.TabIndex = 383
        Me.txtdatetrn.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'txtReference
        '
        Me.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReference.Location = New System.Drawing.Point(135, 118)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(170, 22)
        Me.txtReference.TabIndex = 384
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(48, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 385
        Me.Label1.Text = "Reference No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(87, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 387
        Me.Label2.Text = "Details"
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(135, 143)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(338, 59)
        Me.txtDetails.TabIndex = 386
        '
        'cmdPost
        '
        Me.cmdPost.Location = New System.Drawing.Point(135, 204)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(186, 34)
        Me.cmdPost.TabIndex = 388
        Me.cmdPost.Text = "Post Transaction"
        Me.cmdPost.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(39, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 390
        Me.Label5.Text = "Transaction No."
        '
        'txtTrnNo
        '
        Me.txtTrnNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTrnNo.Location = New System.Drawing.Point(135, 16)
        Me.txtTrnNo.Name = "txtTrnNo"
        Me.txtTrnNo.ReadOnly = True
        Me.txtTrnNo.Size = New System.Drawing.Size(113, 22)
        Me.txtTrnNo.TabIndex = 389
        Me.txtTrnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'frmPostingPredefineGL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 685)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTrnNo)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.txtdatetrn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.trncode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTrnTitle)
        Me.Controls.Add(Me.groupcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTrnGroup)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPostingPredefineGL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predefined Transaction"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTrnGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTrnTitle As System.Windows.Forms.ComboBox
    Friend WithEvents trncode As System.Windows.Forms.TextBox
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdatetrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTrnNo As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox

End Class
