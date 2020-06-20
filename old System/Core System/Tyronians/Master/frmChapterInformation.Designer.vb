<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChapterInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChapterInformation))
        Me.mode = New System.Windows.Forms.TextBox()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Ekey = New System.Windows.Forms.TextBox()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.opt = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtContactPerson = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.txtorganizedby = New System.Windows.Forms.TextBox()
        Me.chaptercode = New System.Windows.Forms.TextBox()
        Me.txtfoundedby = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtUnderChapter = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtdatefounded = New System.Windows.Forms.DateTimePicker()
        Me.txtareaname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtchaptername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblunderchapter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblchapter = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtHistory = New System.Windows.Forms.RichTextBox()
        Me.areacode = New System.Windows.Forms.TextBox()
        Me.underchapter = New System.Windows.Forms.TextBox()
        Me.contactPersonID = New System.Windows.Forms.TextBox()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(382, 218)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(88, 20)
        Me.mode.TabIndex = 248
        Me.mode.Visible = False
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(186, 474)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(99, 30)
        Me.cmdreset.TabIndex = 8
        Me.cmdreset.Text = "Reset"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(81, 474)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(99, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Submit"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(640, 66)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 254
        Me.id.Visible = False
        '
        'Ekey
        '
        Me.Ekey.Location = New System.Drawing.Point(640, 106)
        Me.Ekey.Name = "Ekey"
        Me.Ekey.Size = New System.Drawing.Size(100, 20)
        Me.Ekey.TabIndex = 256
        Me.Ekey.Visible = False
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
        Me.lbldescription.Text = "You can use this service to add and modify chapters"
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
        Me.lbltitle.Size = New System.Drawing.Size(172, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Chapter Information Form"
        '
        'opt
        '
        Me.opt.Location = New System.Drawing.Point(640, 132)
        Me.opt.Name = "opt"
        Me.opt.Size = New System.Drawing.Size(100, 20)
        Me.opt.TabIndex = 337
        Me.opt.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(347, 404)
        Me.TabControl1.TabIndex = 260
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtContactPerson)
        Me.TabPage1.Controls.Add(Me.lblcontactperson)
        Me.TabPage1.Controls.Add(Me.txtorganizedby)
        Me.TabPage1.Controls.Add(Me.chaptercode)
        Me.TabPage1.Controls.Add(Me.txtfoundedby)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.txtUnderChapter)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.txtdatefounded)
        Me.TabPage1.Controls.Add(Me.txtareaname)
        Me.TabPage1.Controls.Add(Me.txtaddress)
        Me.TabPage1.Controls.Add(Me.txtchaptername)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblunderchapter)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lblchapter)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(339, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Chapter Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtContactPerson
        '
        Me.txtContactPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.FormattingEnabled = True
        Me.txtContactPerson.ItemHeight = 13
        Me.txtContactPerson.Location = New System.Drawing.Point(121, 271)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(207, 21)
        Me.txtContactPerson.TabIndex = 349
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(26, 274)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(88, 15)
        Me.lblcontactperson.TabIndex = 350
        Me.lblcontactperson.Text = "Contact Person"
        '
        'txtorganizedby
        '
        Me.txtorganizedby.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtorganizedby.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorganizedby.ForeColor = System.Drawing.Color.Black
        Me.txtorganizedby.Location = New System.Drawing.Point(121, 197)
        Me.txtorganizedby.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorganizedby.Name = "txtorganizedby"
        Me.txtorganizedby.Size = New System.Drawing.Size(209, 22)
        Me.txtorganizedby.TabIndex = 4
        '
        'chaptercode
        '
        Me.chaptercode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chaptercode.ForeColor = System.Drawing.Color.Black
        Me.chaptercode.Location = New System.Drawing.Point(121, 10)
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
        Me.txtfoundedby.Location = New System.Drawing.Point(121, 170)
        Me.txtfoundedby.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfoundedby.Name = "txtfoundedby"
        Me.txtfoundedby.Size = New System.Drawing.Size(209, 22)
        Me.txtfoundedby.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(121, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(214, 16)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "is this Main Chapter? (Ex. City or Municipality)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtUnderChapter
        '
        Me.txtUnderChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUnderChapter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnderChapter.ForeColor = System.Drawing.Color.Black
        Me.txtUnderChapter.FormattingEnabled = True
        Me.txtUnderChapter.ItemHeight = 13
        Me.txtUnderChapter.Location = New System.Drawing.Point(121, 243)
        Me.txtUnderChapter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnderChapter.Name = "txtUnderChapter"
        Me.txtUnderChapter.Size = New System.Drawing.Size(207, 21)
        Me.txtUnderChapter.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(121, 299)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(206, 69)
        Me.TextBox1.TabIndex = 100
        Me.TextBox1.Text = "I hereby certify that the information and History in this Chapter are true and co" & _
    "rrect to the best of my knowledge and belief."
        '
        'txtdatefounded
        '
        Me.txtdatefounded.CustomFormat = "yyyy-MM-dd"
        Me.txtdatefounded.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatefounded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdatefounded.Location = New System.Drawing.Point(121, 143)
        Me.txtdatefounded.Name = "txtdatefounded"
        Me.txtdatefounded.Size = New System.Drawing.Size(209, 22)
        Me.txtdatefounded.TabIndex = 2
        Me.txtdatefounded.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'txtareaname
        '
        Me.txtareaname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtareaname.ForeColor = System.Drawing.Color.Black
        Me.txtareaname.Location = New System.Drawing.Point(121, 37)
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
        Me.txtaddress.Location = New System.Drawing.Point(121, 91)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(209, 46)
        Me.txtaddress.TabIndex = 1
        '
        'txtchaptername
        '
        Me.txtchaptername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchaptername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchaptername.ForeColor = System.Drawing.Color.Black
        Me.txtchaptername.Location = New System.Drawing.Point(121, 64)
        Me.txtchaptername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptername.Name = "txtchaptername"
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
        Me.Label7.Location = New System.Drawing.Point(37, 200)
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
        Me.Label5.Location = New System.Drawing.Point(44, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 346
        Me.Label5.Text = "Founded by"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(36, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 343
        Me.Label4.Text = "Confirmation"
        '
        'lblunderchapter
        '
        Me.lblunderchapter.AutoSize = True
        Me.lblunderchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblunderchapter.ForeColor = System.Drawing.Color.Red
        Me.lblunderchapter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblunderchapter.Location = New System.Drawing.Point(16, 246)
        Me.lblunderchapter.Name = "lblunderchapter"
        Me.lblunderchapter.Size = New System.Drawing.Size(98, 15)
        Me.lblunderchapter.TabIndex = 343
        Me.lblunderchapter.Text = "Under Chapter of"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(33, 146)
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
        Me.Label1.Location = New System.Drawing.Point(34, 13)
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
        Me.Label13.Location = New System.Drawing.Point(34, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Area Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(10, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Complete Address"
        '
        'lblchapter
        '
        Me.lblchapter.AutoSize = True
        Me.lblchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblchapter.ForeColor = System.Drawing.Color.Red
        Me.lblchapter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblchapter.Location = New System.Drawing.Point(30, 67)
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
        Me.TabPage2.Size = New System.Drawing.Size(339, 378)
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
        Me.txtHistory.Size = New System.Drawing.Size(333, 372)
        Me.txtHistory.TabIndex = 0
        Me.txtHistory.Text = ""
        '
        'areacode
        '
        Me.areacode.Enabled = False
        Me.areacode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.areacode.ForeColor = System.Drawing.Color.Black
        Me.areacode.Location = New System.Drawing.Point(382, 245)
        Me.areacode.Margin = New System.Windows.Forms.Padding(4)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(88, 23)
        Me.areacode.TabIndex = 270
        '
        'underchapter
        '
        Me.underchapter.Enabled = False
        Me.underchapter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.underchapter.ForeColor = System.Drawing.Color.Black
        Me.underchapter.Location = New System.Drawing.Point(382, 276)
        Me.underchapter.Margin = New System.Windows.Forms.Padding(4)
        Me.underchapter.Name = "underchapter"
        Me.underchapter.Size = New System.Drawing.Size(88, 23)
        Me.underchapter.TabIndex = 348
        '
        'contactPersonID
        '
        Me.contactPersonID.Enabled = False
        Me.contactPersonID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contactPersonID.ForeColor = System.Drawing.Color.Black
        Me.contactPersonID.Location = New System.Drawing.Point(382, 307)
        Me.contactPersonID.Margin = New System.Windows.Forms.Padding(4)
        Me.contactPersonID.Name = "contactPersonID"
        Me.contactPersonID.Size = New System.Drawing.Size(88, 23)
        Me.contactPersonID.TabIndex = 349
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
        'frmChapterInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 513)
        Me.Controls.Add(Me.contactPersonID)
        Me.Controls.Add(Me.underchapter)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.opt)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Ekey)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.areacode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChapterInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chapter Information Form"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Ekey As System.Windows.Forms.TextBox
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents opt As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtchaptername As System.Windows.Forms.TextBox
    Friend WithEvents lblchapter As System.Windows.Forms.Label
    Friend WithEvents areacode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdatefounded As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtareaname As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblunderchapter As System.Windows.Forms.Label
    Friend WithEvents txtUnderChapter As System.Windows.Forms.ComboBox
    Friend WithEvents txtfoundedby As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtorganizedby As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHistory As System.Windows.Forms.RichTextBox
    Friend WithEvents chaptercode As System.Windows.Forms.TextBox
    Friend WithEvents underchapter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContactPerson As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents contactPersonID As System.Windows.Forms.TextBox
End Class
