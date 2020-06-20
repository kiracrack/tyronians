<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserProfile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.groupID = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcontactnumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.grplogin = New System.Windows.Forms.GroupBox()
        Me.txtpassword2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtpassword1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.cpass = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.groupID.SuspendLayout()
        Me.grplogin.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "User Fullname*"
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(357, 335)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(99, 30)
        Me.cmdreset.TabIndex = 10
        Me.cmdreset.Text = "Cancel"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'groupID
        '
        Me.groupID.Controls.Add(Me.LinkLabel1)
        Me.groupID.Controls.Add(Me.txtEmail)
        Me.groupID.Controls.Add(Me.Label2)
        Me.groupID.Controls.Add(Me.txtcontactnumber)
        Me.groupID.Controls.Add(Me.Label12)
        Me.groupID.Controls.Add(Me.txtPosition)
        Me.groupID.Controls.Add(Me.Label10)
        Me.groupID.Controls.Add(Me.txtaddress)
        Me.groupID.Controls.Add(Me.txtfullname)
        Me.groupID.Controls.Add(Me.Label1)
        Me.groupID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.groupID.ForeColor = System.Drawing.Color.Maroon
        Me.groupID.Location = New System.Drawing.Point(9, 69)
        Me.groupID.Name = "groupID"
        Me.groupID.Size = New System.Drawing.Size(447, 152)
        Me.groupID.TabIndex = 251
        Me.groupID.TabStop = False
        Me.groupID.Text = "Personal Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(288, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Contact Number*"
        '
        'txtcontactnumber
        '
        Me.txtcontactnumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtcontactnumber.ForeColor = System.Drawing.Color.Black
        Me.txtcontactnumber.Location = New System.Drawing.Point(288, 75)
        Me.txtcontactnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontactnumber.MaxLength = 13
        Me.txtcontactnumber.Name = "txtcontactnumber"
        Me.txtcontactnumber.Size = New System.Drawing.Size(143, 22)
        Me.txtcontactnumber.TabIndex = 3
        Me.txtcontactnumber.Text = "+63"
        Me.txtcontactnumber.WordWrap = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(289, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Position*"
        '
        'txtPosition
        '
        Me.txtPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.FormattingEnabled = True
        Me.txtPosition.ItemHeight = 13
        Me.txtPosition.Location = New System.Drawing.Point(288, 33)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(143, 21)
        Me.txtPosition.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(18, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 248
        Me.Label10.Text = "Complete Address*"
        '
        'txtaddress
        '
        Me.txtaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(21, 119)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(410, 22)
        Me.txtaddress.TabIndex = 4
        '
        'txtfullname
        '
        Me.txtfullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtfullname.ForeColor = System.Drawing.Color.Black
        Me.txtfullname.Location = New System.Drawing.Point(21, 33)
        Me.txtfullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(261, 22)
        Me.txtfullname.TabIndex = 0
        '
        'grplogin
        '
        Me.grplogin.Controls.Add(Me.txtpassword2)
        Me.grplogin.Controls.Add(Me.Label16)
        Me.grplogin.Controls.Add(Me.txtpassword1)
        Me.grplogin.Controls.Add(Me.Label15)
        Me.grplogin.Controls.Add(Me.txtUsername)
        Me.grplogin.Controls.Add(Me.Label14)
        Me.grplogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grplogin.ForeColor = System.Drawing.Color.Maroon
        Me.grplogin.Location = New System.Drawing.Point(9, 222)
        Me.grplogin.Name = "grplogin"
        Me.grplogin.Size = New System.Drawing.Size(447, 107)
        Me.grplogin.TabIndex = 252
        Me.grplogin.TabStop = False
        Me.grplogin.Text = "Login Credentials"
        '
        'txtpassword2
        '
        Me.txtpassword2.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.txtpassword2.ForeColor = System.Drawing.Color.Black
        Me.txtpassword2.Location = New System.Drawing.Point(127, 74)
        Me.txtpassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword2.Name = "txtpassword2"
        Me.txtpassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword2.ReadOnly = True
        Me.txtpassword2.Size = New System.Drawing.Size(195, 20)
        Me.txtpassword2.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(16, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 245
        Me.Label16.Text = "Confirm Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtpassword1
        '
        Me.txtpassword1.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.txtpassword1.ForeColor = System.Drawing.Color.Black
        Me.txtpassword1.Location = New System.Drawing.Point(127, 49)
        Me.txtpassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword1.Name = "txtpassword1"
        Me.txtpassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword1.ReadOnly = True
        Me.txtpassword1.Size = New System.Drawing.Size(195, 20)
        Me.txtpassword1.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(63, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 243
        Me.Label15.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(127, 21)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(195, 22)
        Me.txtUsername.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(60, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 15)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "Username"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(172, 335)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 9
        Me.cmdset.Text = "Update Profile"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'cpass
        '
        Me.cpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cpass.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cpass.Location = New System.Drawing.Point(34, 335)
        Me.cpass.Name = "cpass"
        Me.cpass.Size = New System.Drawing.Size(132, 30)
        Me.cpass.TabIndex = 8
        Me.cpass.Text = "Change Password"
        Me.cpass.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 39)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(340, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to add and modify user accounts"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(450, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(59, 20)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(160, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "User Profile Information"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.Tyronians.My.Resources.Resources.lock1
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 10)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(48, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(117, 15)
        Me.LinkLabel1.TabIndex = 259
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Email Address (Help)"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(21, 75)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 45
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(261, 22)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.WordWrap = False
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(468, 373)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cpass)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.grplogin)
        Me.Controls.Add(Me.groupID)
        Me.Controls.Add(Me.cmdreset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access Registration"
        Me.groupID.ResumeLayout(False)
        Me.groupID.PerformLayout()
        Me.grplogin.ResumeLayout(False)
        Me.grplogin.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents groupID As System.Windows.Forms.GroupBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents grplogin As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtpassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcontactnumber As System.Windows.Forms.TextBox
    Friend WithEvents cpass As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
