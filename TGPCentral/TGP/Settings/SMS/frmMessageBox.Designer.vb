<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMessageBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageBox))
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckWriteNumber = New System.Windows.Forms.CheckBox()
        Me.txtUsherName = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtGatewayNumber = New System.Windows.Forms.TextBox()
        Me.gatewayid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSendTo = New System.Windows.Forms.TextBox()
        Me.txtGatewayName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.usherid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(88, 151)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(127, 35)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "Confirm Send"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.usherid)
        Me.GroupBox1.Controls.Add(Me.ckWriteNumber)
        Me.GroupBox1.Controls.Add(Me.txtUsherName)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtGatewayNumber)
        Me.GroupBox1.Controls.Add(Me.gatewayid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSendTo)
        Me.GroupBox1.Controls.Add(Me.txtGatewayName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContent)
        Me.GroupBox1.Controls.Add(Me.cmdOK)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 208)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compose Message"
        '
        'ckWriteNumber
        '
        Me.ckWriteNumber.AutoSize = True
        Me.ckWriteNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ckWriteNumber.Location = New System.Drawing.Point(88, 29)
        Me.ckWriteNumber.Name = "ckWriteNumber"
        Me.ckWriteNumber.Size = New System.Drawing.Size(161, 21)
        Me.ckWriteNumber.TabIndex = 834
        Me.ckWriteNumber.Text = "Write Send To Number"
        Me.ckWriteNumber.UseVisualStyleBackColor = True
        '
        'txtUsherName
        '
        Me.txtUsherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUsherName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsherName.FormattingEnabled = True
        Me.txtUsherName.Location = New System.Drawing.Point(88, 50)
        Me.txtUsherName.Name = "txtUsherName"
        Me.txtUsherName.Size = New System.Drawing.Size(236, 25)
        Me.txtUsherName.TabIndex = 833
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(284, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 21)
        Me.CheckBox1.TabIndex = 832
        Me.CheckBox1.Text = "reply"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'txtGatewayNumber
        '
        Me.txtGatewayNumber.Location = New System.Drawing.Point(407, 222)
        Me.txtGatewayNumber.Name = "txtGatewayNumber"
        Me.txtGatewayNumber.Size = New System.Drawing.Size(55, 25)
        Me.txtGatewayNumber.TabIndex = 831
        Me.txtGatewayNumber.Visible = False
        '
        'gatewayid
        '
        Me.gatewayid.Location = New System.Drawing.Point(548, 185)
        Me.gatewayid.Name = "gatewayid"
        Me.gatewayid.Size = New System.Drawing.Size(55, 25)
        Me.gatewayid.TabIndex = 830
        Me.gatewayid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 828
        Me.Label2.Text = "Send To"
        '
        'txtSendTo
        '
        Me.txtSendTo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendTo.Location = New System.Drawing.Point(88, 50)
        Me.txtSendTo.Name = "txtSendTo"
        Me.txtSendTo.Size = New System.Drawing.Size(236, 25)
        Me.txtSendTo.TabIndex = 1
        '
        'txtGatewayName
        '
        Me.txtGatewayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGatewayName.Enabled = False
        Me.txtGatewayName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGatewayName.FormattingEnabled = True
        Me.txtGatewayName.Location = New System.Drawing.Point(327, 50)
        Me.txtGatewayName.Name = "txtGatewayName"
        Me.txtGatewayName.Size = New System.Drawing.Size(113, 25)
        Me.txtGatewayName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Message"
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(88, 78)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(352, 70)
        Me.txtContent.TabIndex = 2
        '
        'usherid
        '
        Me.usherid.Location = New System.Drawing.Point(346, 222)
        Me.usherid.Name = "usherid"
        Me.usherid.Size = New System.Drawing.Size(55, 25)
        Me.usherid.TabIndex = 835
        Me.usherid.Visible = False
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(494, 224)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMessageBox"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message Box"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents txtGatewayName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSendTo As System.Windows.Forms.TextBox
    Friend WithEvents gatewayid As System.Windows.Forms.TextBox
    Friend WithEvents txtGatewayNumber As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ckWriteNumber As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsherName As System.Windows.Forms.ComboBox
    Friend WithEvents usherid As System.Windows.Forms.TextBox
End Class
