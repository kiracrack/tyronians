<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChapterProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChapterProfile))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtdatefounded = New System.Windows.Forms.TextBox()
        Me.txtUnderChapter = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtorganizedby = New System.Windows.Forms.TextBox()
        Me.chaptercode = New System.Windows.Forms.TextBox()
        Me.txtfoundedby = New System.Windows.Forms.TextBox()
        Me.txtareaname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtchaptername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblchapter = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtHistory = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCurrentAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(365, 383)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(219, 30)
        Me.cmdreset.TabIndex = 8
        Me.cmdreset.Text = "Close Viewier"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 35)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(340, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to view chapter information"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(347, 15)
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
        Me.lbltitle.Location = New System.Drawing.Point(59, 16)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(181, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Chapter Profile Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 311)
        Me.TabControl1.TabIndex = 260
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCurrentAddress)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtEmailAddress)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtContactNumber)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtdatefounded)
        Me.TabPage1.Controls.Add(Me.txtUnderChapter)
        Me.TabPage1.Controls.Add(Me.txtContactPerson)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtorganizedby)
        Me.TabPage1.Controls.Add(Me.chaptercode)
        Me.TabPage1.Controls.Add(Me.txtfoundedby)
        Me.TabPage1.Controls.Add(Me.txtareaname)
        Me.TabPage1.Controls.Add(Me.txtaddress)
        Me.TabPage1.Controls.Add(Me.txtchaptername)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lblchapter)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(701, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Chapter Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtdatefounded
        '
        Me.txtdatefounded.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdatefounded.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatefounded.ForeColor = System.Drawing.Color.Black
        Me.txtdatefounded.Location = New System.Drawing.Point(131, 168)
        Me.txtdatefounded.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdatefounded.Name = "txtdatefounded"
        Me.txtdatefounded.ReadOnly = True
        Me.txtdatefounded.Size = New System.Drawing.Size(209, 22)
        Me.txtdatefounded.TabIndex = 353
        '
        'txtUnderChapter
        '
        Me.txtUnderChapter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnderChapter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnderChapter.ForeColor = System.Drawing.Color.Black
        Me.txtUnderChapter.Location = New System.Drawing.Point(131, 249)
        Me.txtUnderChapter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnderChapter.Name = "txtUnderChapter"
        Me.txtUnderChapter.ReadOnly = True
        Me.txtUnderChapter.Size = New System.Drawing.Size(209, 22)
        Me.txtUnderChapter.TabIndex = 352
        '
        'txtContactPerson
        '
        Me.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.Location = New System.Drawing.Point(461, 36)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.ReadOnly = True
        Me.txtContactPerson.Size = New System.Drawing.Size(209, 22)
        Me.txtContactPerson.TabIndex = 351
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(367, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "Contact Person"
        '
        'txtorganizedby
        '
        Me.txtorganizedby.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtorganizedby.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorganizedby.ForeColor = System.Drawing.Color.Black
        Me.txtorganizedby.Location = New System.Drawing.Point(131, 222)
        Me.txtorganizedby.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorganizedby.Name = "txtorganizedby"
        Me.txtorganizedby.ReadOnly = True
        Me.txtorganizedby.Size = New System.Drawing.Size(209, 22)
        Me.txtorganizedby.TabIndex = 4
        '
        'chaptercode
        '
        Me.chaptercode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chaptercode.ForeColor = System.Drawing.Color.Black
        Me.chaptercode.Location = New System.Drawing.Point(131, 36)
        Me.chaptercode.Margin = New System.Windows.Forms.Padding(4)
        Me.chaptercode.Name = "chaptercode"
        Me.chaptercode.ReadOnly = True
        Me.chaptercode.Size = New System.Drawing.Size(209, 22)
        Me.chaptercode.TabIndex = 347
        Me.chaptercode.Text = "AUTO GENERATED"
        Me.chaptercode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfoundedby
        '
        Me.txtfoundedby.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfoundedby.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtfoundedby.ForeColor = System.Drawing.Color.Black
        Me.txtfoundedby.Location = New System.Drawing.Point(131, 195)
        Me.txtfoundedby.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfoundedby.Name = "txtfoundedby"
        Me.txtfoundedby.ReadOnly = True
        Me.txtfoundedby.Size = New System.Drawing.Size(209, 22)
        Me.txtfoundedby.TabIndex = 3
        '
        'txtareaname
        '
        Me.txtareaname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtareaname.ForeColor = System.Drawing.Color.Black
        Me.txtareaname.Location = New System.Drawing.Point(131, 63)
        Me.txtareaname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtareaname.Name = "txtareaname"
        Me.txtareaname.ReadOnly = True
        Me.txtareaname.Size = New System.Drawing.Size(209, 22)
        Me.txtareaname.TabIndex = 271
        '
        'txtaddress
        '
        Me.txtaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(131, 117)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(209, 46)
        Me.txtaddress.TabIndex = 1
        '
        'txtchaptername
        '
        Me.txtchaptername.BackColor = System.Drawing.Color.Yellow
        Me.txtchaptername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchaptername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchaptername.ForeColor = System.Drawing.Color.Black
        Me.txtchaptername.Location = New System.Drawing.Point(131, 90)
        Me.txtchaptername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptername.Name = "txtchaptername"
        Me.txtchaptername.ReadOnly = True
        Me.txtchaptername.Size = New System.Drawing.Size(209, 22)
        Me.txtchaptername.TabIndex = 0
        Me.txtchaptername.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(49, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 348
        Me.Label7.Text = "Organized by"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(56, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 346
        Me.Label5.Text = "Founded by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(28, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 343
        Me.Label2.Text = "Under Chapter of"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(45, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 339
        Me.Label3.Text = "Date Founded"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(46, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Chapter Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(46, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Area Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(22, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Complete Address"
        '
        'lblchapter
        '
        Me.lblchapter.AutoSize = True
        Me.lblchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblchapter.ForeColor = System.Drawing.Color.Black
        Me.lblchapter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblchapter.Location = New System.Drawing.Point(42, 93)
        Me.lblchapter.Name = "lblchapter"
        Me.lblchapter.Size = New System.Drawing.Size(84, 15)
        Me.lblchapter.TabIndex = 263
        Me.lblchapter.Text = "Chapter Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(701, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complete Chapter History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtHistory
        '
        Me.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHistory.Location = New System.Drawing.Point(3, 3)
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.Size = New System.Drawing.Size(695, 279)
        Me.txtHistory.TabIndex = 0
        Me.txtHistory.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(368, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 15)
        Me.Label4.TabIndex = 354
        Me.Label4.Text = "Chapter Contact Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(16, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 15)
        Me.Label9.TabIndex = 354
        Me.Label9.Text = "Chapter Profile Information"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(461, 63)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(209, 22)
        Me.txtContactNumber.TabIndex = 356
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(347, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 15)
        Me.Label11.TabIndex = 355
        Me.Label11.Text = "Cellphone Number"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.Black
        Me.txtEmailAddress.Location = New System.Drawing.Point(461, 141)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.ReadOnly = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(209, 22)
        Me.txtEmailAddress.TabIndex = 358
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(374, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 357
        Me.Label12.Text = "Email Address"
        '
        'txtCurrentAddress
        '
        Me.txtCurrentAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentAddress.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentAddress.Location = New System.Drawing.Point(461, 90)
        Me.txtCurrentAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentAddress.Multiline = True
        Me.txtCurrentAddress.Name = "txtCurrentAddress"
        Me.txtCurrentAddress.ReadOnly = True
        Me.txtCurrentAddress.Size = New System.Drawing.Size(209, 46)
        Me.txtCurrentAddress.TabIndex = 361
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(363, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 362
        Me.Label15.Text = "Current Address"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(140, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 30)
        Me.Button1.TabIndex = 337
        Me.Button1.Text = "Print Profile Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.Tyronians.My.Resources.Resources.kmines_2
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 7)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(48, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmChapterProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(733, 423)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cmdreset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChapterProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chapter Profile Information"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtchaptername As System.Windows.Forms.TextBox
    Friend WithEvents lblchapter As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtareaname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfoundedby As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtorganizedby As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHistory As System.Windows.Forms.RichTextBox
    Friend WithEvents chaptercode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtUnderChapter As System.Windows.Forms.TextBox
    Friend WithEvents txtdatefounded As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
