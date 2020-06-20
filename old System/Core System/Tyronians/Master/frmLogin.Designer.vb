<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maindescription = New System.Windows.Forms.Label()
        Me.mainname = New System.Windows.Forms.Label()
        Me.loadimage = New System.Windows.Forms.PictureBox()
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.Location = New System.Drawing.Point(26, 257)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(187, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.Text = "Password"
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdlogin
        '
        Me.cmdlogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(46, 281)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(147, 27)
        Me.cmdlogin.TabIndex = 2
        Me.cmdlogin.Text = "Confirm Login"
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(26, 233)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(187, 20)
        Me.txtusername.TabIndex = 0
        Me.txtusername.Text = "Username"
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(26, 311)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(187, 13)
        Me.LinkLabel1.TabIndex = 342
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Request New Account"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 12)
        Me.Label1.TabIndex = 347
        Me.Label1.Text = "DIPOLOG CITY CHAPTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'maindescription
        '
        Me.maindescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maindescription.BackColor = System.Drawing.Color.Transparent
        Me.maindescription.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.maindescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.maindescription.Location = New System.Drawing.Point(12, 387)
        Me.maindescription.Name = "maindescription"
        Me.maindescription.Size = New System.Drawing.Size(207, 12)
        Me.maindescription.TabIndex = 346
        Me.maindescription.Text = "Developed by Bro. Winter Bugahod"
        Me.maindescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainname
        '
        Me.mainname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainname.BackColor = System.Drawing.Color.Transparent
        Me.mainname.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mainname.ForeColor = System.Drawing.Color.White
        Me.mainname.Location = New System.Drawing.Point(12, 374)
        Me.mainname.Name = "mainname"
        Me.mainname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mainname.Size = New System.Drawing.Size(207, 12)
        Me.mainname.TabIndex = 345
        Me.mainname.Text = "ORGANIZATION MANAGEMENT SYSTEM"
        Me.mainname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loadimage
        '
        Me.loadimage.BackColor = System.Drawing.Color.Transparent
        Me.loadimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loadimage.Location = New System.Drawing.Point(203, 349)
        Me.loadimage.Name = "loadimage"
        Me.loadimage.Size = New System.Drawing.Size(2, 2)
        Me.loadimage.TabIndex = 348
        Me.loadimage.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tyronians.My.Resources.Resources.login2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(233, 421)
        Me.Controls.Add(Me.loadimage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maindescription)
        Me.Controls.Add(Me.mainname)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tyronians Official"
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents maindescription As System.Windows.Forms.Label
    Friend WithEvents mainname As System.Windows.Forms.Label
    Friend WithEvents loadimage As System.Windows.Forms.PictureBox

End Class
