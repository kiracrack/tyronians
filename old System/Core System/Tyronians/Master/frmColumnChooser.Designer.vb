<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumnChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColumnChooser))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtColumn = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(6, 9)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(260, 289)
        Me.CheckedListBox1.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(6, 302)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(260, 33)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save Settings"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtColumn
        '
        Me.txtColumn.Location = New System.Drawing.Point(126, 208)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Size = New System.Drawing.Size(100, 20)
        Me.txtColumn.TabIndex = 2
        Me.txtColumn.Visible = False
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(126, 182)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(100, 20)
        Me.txttype.TabIndex = 3
        Me.txttype.Visible = False
        '
        'frmColumnChooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 340)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtColumn)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColumnChooser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Column Chooser Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtColumn As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
End Class
