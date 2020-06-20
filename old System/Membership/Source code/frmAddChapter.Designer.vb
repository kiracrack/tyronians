<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddChapter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddChapter))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCountries = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtChapter = New System.Windows.Forms.TextBox()
        Me.txtRegion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(276, 195)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please provide correct chapter information"
        '
        'txtCountries
        '
        Me.txtCountries.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCountries.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCountries.ForeColor = System.Drawing.Color.Black
        Me.txtCountries.FormattingEnabled = True
        Me.txtCountries.ItemHeight = 13
        Me.txtCountries.Location = New System.Drawing.Point(148, 51)
        Me.txtCountries.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountries.Name = "txtCountries"
        Me.txtCountries.Size = New System.Drawing.Size(274, 21)
        Me.txtCountries.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(47, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 15)
        Me.Label16.TabIndex = 362
        Me.Label16.Text = "Chapter Country"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(145, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 15)
        Me.Label8.TabIndex = 366
        Me.Label8.Text = "Please provide correct council name"
        '
        'txtChapter
        '
        Me.txtChapter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtChapter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChapter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtChapter.ForeColor = System.Drawing.Color.Black
        Me.txtChapter.Location = New System.Drawing.Point(148, 169)
        Me.txtChapter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChapter.MaxLength = 0
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Size = New System.Drawing.Size(274, 22)
        Me.txtChapter.TabIndex = 4
        '
        'txtRegion
        '
        Me.txtRegion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRegion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRegion.ForeColor = System.Drawing.Color.Black
        Me.txtRegion.FormattingEnabled = True
        Me.txtRegion.ItemHeight = 13
        Me.txtRegion.Location = New System.Drawing.Point(148, 75)
        Me.txtRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(150, 21)
        Me.txtRegion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(64, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 368
        Me.Label2.Text = "Select Region"
        '
        'txtProvince
        '
        Me.txtProvince.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProvince.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProvince.ForeColor = System.Drawing.Color.Black
        Me.txtProvince.FormattingEnabled = True
        Me.txtProvince.ItemHeight = 13
        Me.txtProvince.Location = New System.Drawing.Point(148, 99)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(274, 21)
        Me.txtProvince.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(55, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 370
        Me.Label3.Text = "Select Province"
        '
        'txtArea
        '
        Me.txtArea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtArea.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtArea.ForeColor = System.Drawing.Color.Black
        Me.txtArea.FormattingEnabled = True
        Me.txtArea.ItemHeight = 13
        Me.txtArea.Location = New System.Drawing.Point(148, 123)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(274, 21)
        Me.txtArea.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(47, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 372
        Me.Label4.Text = "Select Municipal"
        '
        'frmAddChapter
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(506, 244)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtChapter)
        Me.Controls.Add(Me.txtCountries)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddChapter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Council Registration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCountries As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtChapter As System.Windows.Forms.TextBox
    Friend WithEvents txtRegion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
