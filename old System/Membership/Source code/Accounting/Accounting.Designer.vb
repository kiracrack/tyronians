<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounting))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(24, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Accounting Transaction"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(249, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(219, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "GL Item"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(249, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 49)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Transaction Settings"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button9.Location = New System.Drawing.Point(24, 118)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(219, 49)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "GL Group"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button10.Location = New System.Drawing.Point(24, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(444, 49)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Journal Entries"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(24, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(444, 49)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Trial Balance"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(24, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(444, 49)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Chart of Accounts"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Accounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 284)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Accounting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
