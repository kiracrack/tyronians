<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembershipForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPersonal = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCompleteAddress = New System.Windows.Forms.TextBox()
        Me.txtincase_contact = New System.Windows.Forms.TextBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtbirthplace = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnickname = New System.Windows.Forms.TextBox()
        Me.txtincase_contactname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtemailadd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmobilenumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabWork = New System.Windows.Forms.TabPage()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.cmdWorkSave = New System.Windows.Forms.Button()
        Me.txtCompanyCurrent = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCompanyDatePeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gridWork = New System.Windows.Forms.DataGridView()
        Me.ContextMenuCompany = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tabEducation = New System.Windows.Forms.TabPage()
        Me.cndEduSave = New System.Windows.Forms.Button()
        Me.txtSchoolDetails = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtSchoolLevel = New System.Windows.Forms.ComboBox()
        Me.txtEducCurrent = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtEducPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtSchoolname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gridEducation = New System.Windows.Forms.DataGridView()
        Me.ContextMenuEducation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tabMembership = New System.Windows.Forms.TabPage()
        Me.txtchaptercode = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.txtmemberid = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtidcard = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtrituals = New System.Windows.Forms.CheckBox()
        Me.txtdatesurvived = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtbaptizedname = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtchaptername = New System.Windows.Forms.ComboBox()
        Me.lblMessageDescription = New System.Windows.Forms.Label()
        Me.lblSuccessTitle = New System.Windows.Forms.Label()
        Me.RemoveCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.cmdRemoveWork = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveSchool = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowsePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabPersonal.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabWork.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuCompany.SuspendLayout()
        Me.tabEducation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridEducation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuEducation.SuspendLayout()
        Me.tabMembership.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(89, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "First Name(Pangalan)"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(165, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 246
        Me.Label3.Text = "Gender"
        '
        'txtgender
        '
        Me.txtgender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgender.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtgender.ForeColor = System.Drawing.Color.Black
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.ItemHeight = 13
        Me.txtgender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.txtgender.Location = New System.Drawing.Point(219, 101)
        Me.txtgender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(181, 21)
        Me.txtgender.TabIndex = 3
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtmiddlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmiddlename.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtmiddlename.ForeColor = System.Drawing.Color.Black
        Me.txtmiddlename.Location = New System.Drawing.Point(219, 76)
        Me.txtmiddlename.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmiddlename.MaxLength = 50
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(181, 22)
        Me.txtmiddlename.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(26, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 15)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "Middle Name (Gitnang Pangalan)"
        '
        'txtlastname
        '
        Me.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtlastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlastname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.Location = New System.Drawing.Point(219, 28)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlastname.MaxLength = 50
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(181, 22)
        Me.txtlastname.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(92, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 241
        Me.Label8.Text = "Last Name(Apilyedo)"
        '
        'txtfirstname
        '
        Me.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.Location = New System.Drawing.Point(219, 52)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirstname.MaxLength = 50
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(181, 22)
        Me.txtfirstname.TabIndex = 1
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(10, 26)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(408, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "Please enter all necessary fields to complete your registration"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(334, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(7, 3)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(335, 25)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "FORM 101 - Online Membership Form"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabPersonal)
        Me.TabControl1.Controls.Add(Me.tabWork)
        Me.TabControl1.Controls.Add(Me.tabEducation)
        Me.TabControl1.Controls.Add(Me.tabMembership)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(677, 427)
        Me.TabControl1.TabIndex = 262
        '
        'tabPersonal
        '
        Me.tabPersonal.Controls.Add(Me.Label22)
        Me.tabPersonal.Controls.Add(Me.Label21)
        Me.tabPersonal.Controls.Add(Me.Label10)
        Me.tabPersonal.Controls.Add(Me.txtCompleteAddress)
        Me.tabPersonal.Controls.Add(Me.txtincase_contact)
        Me.tabPersonal.Controls.Add(Me.LinkLabel3)
        Me.tabPersonal.Controls.Add(Me.Label11)
        Me.tabPersonal.Controls.Add(Me.picProfile)
        Me.tabPersonal.Controls.Add(Me.txtbirthplace)
        Me.tabPersonal.Controls.Add(Me.Label18)
        Me.tabPersonal.Controls.Add(Me.txtbirthdate)
        Me.tabPersonal.Controls.Add(Me.Label17)
        Me.tabPersonal.Controls.Add(Me.Label14)
        Me.tabPersonal.Controls.Add(Me.txtnickname)
        Me.tabPersonal.Controls.Add(Me.txtincase_contactname)
        Me.tabPersonal.Controls.Add(Me.Label1)
        Me.tabPersonal.Controls.Add(Me.txtfirstname)
        Me.tabPersonal.Controls.Add(Me.Label13)
        Me.tabPersonal.Controls.Add(Me.Label8)
        Me.tabPersonal.Controls.Add(Me.txtlastname)
        Me.tabPersonal.Controls.Add(Me.Label9)
        Me.tabPersonal.Controls.Add(Me.txtmiddlename)
        Me.tabPersonal.Controls.Add(Me.txtgender)
        Me.tabPersonal.Controls.Add(Me.Label3)
        Me.tabPersonal.Controls.Add(Me.txtemailadd)
        Me.tabPersonal.Controls.Add(Me.Label2)
        Me.tabPersonal.Controls.Add(Me.txtmobilenumber)
        Me.tabPersonal.Controls.Add(Me.Label4)
        Me.tabPersonal.Location = New System.Drawing.Point(4, 26)
        Me.tabPersonal.Name = "tabPersonal"
        Me.tabPersonal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersonal.Size = New System.Drawing.Size(669, 397)
        Me.tabPersonal.TabIndex = 0
        Me.tabPersonal.Text = "Personal Information"
        Me.tabPersonal.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(111, 235)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(170, 15)
        Me.Label22.TabIndex = 357
        Me.Label22.Text = "Personal Contact Information"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(111, 314)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(185, 15)
        Me.Label21.TabIndex = 356
        Me.Label21.Text = "Emergency Contact Information"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(106, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 354
        Me.Label10.Text = "Complete Address"
        '
        'txtCompleteAddress
        '
        Me.txtCompleteAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompleteAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompleteAddress.ForeColor = System.Drawing.Color.Black
        Me.txtCompleteAddress.Location = New System.Drawing.Point(219, 199)
        Me.txtCompleteAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompleteAddress.MaxLength = 100
        Me.txtCompleteAddress.Name = "txtCompleteAddress"
        Me.txtCompleteAddress.Size = New System.Drawing.Size(367, 22)
        Me.txtCompleteAddress.TabIndex = 7
        '
        'txtincase_contact
        '
        Me.txtincase_contact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtincase_contact.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtincase_contact.ForeColor = System.Drawing.Color.Black
        Me.txtincase_contact.Location = New System.Drawing.Point(219, 360)
        Me.txtincase_contact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtincase_contact.MaxLength = 15
        Me.txtincase_contact.Name = "txtincase_contact"
        Me.txtincase_contact.Size = New System.Drawing.Size(367, 22)
        Me.txtincase_contact.TabIndex = 11
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel3.Location = New System.Drawing.Point(401, 10)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(117, 15)
        Me.LinkLabel3.TabIndex = 352
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Profile Picture (Help)"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(79, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 15)
        Me.Label11.TabIndex = 355
        Me.Label11.Text = "Contact Number (+63)"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowsePictureToolStripMenuItem, Me.ToolStripSeparator1, Me.RemovePictureToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 54)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'txtbirthplace
        '
        Me.txtbirthplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbirthplace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbirthplace.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbirthplace.ForeColor = System.Drawing.Color.Black
        Me.txtbirthplace.Location = New System.Drawing.Point(219, 175)
        Me.txtbirthplace.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbirthplace.MaxLength = 100
        Me.txtbirthplace.Name = "txtbirthplace"
        Me.txtbirthplace.Size = New System.Drawing.Size(181, 22)
        Me.txtbirthplace.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(147, 179)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 343
        Me.Label18.Text = "Birth Place"
        '
        'txtbirthdate
        '
        Me.txtbirthdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbirthdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtbirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtbirthdate.Location = New System.Drawing.Point(219, 150)
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(181, 22)
        Me.txtbirthdate.TabIndex = 5
        Me.txtbirthdate.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(151, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 15)
        Me.Label17.TabIndex = 341
        Me.Label17.Text = "Birth Date"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(149, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 266
        Me.Label14.Text = "Nickname"
        '
        'txtnickname
        '
        Me.txtnickname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnickname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnickname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtnickname.ForeColor = System.Drawing.Color.Black
        Me.txtnickname.Location = New System.Drawing.Point(219, 125)
        Me.txtnickname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnickname.MaxLength = 25
        Me.txtnickname.Name = "txtnickname"
        Me.txtnickname.Size = New System.Drawing.Size(181, 22)
        Me.txtnickname.TabIndex = 4
        Me.txtnickname.WordWrap = False
        '
        'txtincase_contactname
        '
        Me.txtincase_contactname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtincase_contactname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtincase_contactname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtincase_contactname.ForeColor = System.Drawing.Color.Black
        Me.txtincase_contactname.Location = New System.Drawing.Point(219, 336)
        Me.txtincase_contactname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtincase_contactname.MaxLength = 50
        Me.txtincase_contactname.Name = "txtincase_contactname"
        Me.txtincase_contactname.Size = New System.Drawing.Size(367, 22)
        Me.txtincase_contactname.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(58, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 15)
        Me.Label13.TabIndex = 351
        Me.Label13.Text = "Contact Person (Fullname)"
        '
        'txtemailadd
        '
        Me.txtemailadd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemailadd.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemailadd.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtemailadd.ForeColor = System.Drawing.Color.Black
        Me.txtemailadd.Location = New System.Drawing.Point(219, 281)
        Me.txtemailadd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemailadd.MaxLength = 45
        Me.txtemailadd.Name = "txtemailadd"
        Me.txtemailadd.Size = New System.Drawing.Size(367, 22)
        Me.txtemailadd.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(74, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 15)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "Your Cell Number (+63)"
        '
        'txtmobilenumber
        '
        Me.txtmobilenumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtmobilenumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtmobilenumber.ForeColor = System.Drawing.Color.Black
        Me.txtmobilenumber.Location = New System.Drawing.Point(219, 257)
        Me.txtmobilenumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmobilenumber.MaxLength = 15
        Me.txtmobilenumber.Name = "txtmobilenumber"
        Me.txtmobilenumber.Size = New System.Drawing.Size(367, 22)
        Me.txtmobilenumber.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(125, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 347
        Me.Label4.Text = "Email Address"
        '
        'tabWork
        '
        Me.tabWork.Controls.Add(Me.txtPosition)
        Me.tabWork.Controls.Add(Me.cmdWorkSave)
        Me.tabWork.Controls.Add(Me.txtCompanyCurrent)
        Me.tabWork.Controls.Add(Me.Label31)
        Me.tabWork.Controls.Add(Me.txtCompanyDatePeriod)
        Me.tabWork.Controls.Add(Me.Label29)
        Me.tabWork.Controls.Add(Me.Label30)
        Me.tabWork.Controls.Add(Me.txtCompanyName)
        Me.tabWork.Controls.Add(Me.GroupBox2)
        Me.tabWork.Location = New System.Drawing.Point(4, 26)
        Me.tabWork.Name = "tabWork"
        Me.tabWork.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWork.Size = New System.Drawing.Size(669, 397)
        Me.tabWork.TabIndex = 1
        Me.tabWork.Text = "Work History"
        Me.tabWork.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(198, 44)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.MaxLength = 45
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(238, 22)
        Me.txtPosition.TabIndex = 1
        '
        'cmdWorkSave
        '
        Me.cmdWorkSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdWorkSave.BackColor = System.Drawing.Color.White
        Me.cmdWorkSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdWorkSave.ForeColor = System.Drawing.Color.Black
        Me.cmdWorkSave.Location = New System.Drawing.Point(349, 98)
        Me.cmdWorkSave.Name = "cmdWorkSave"
        Me.cmdWorkSave.Size = New System.Drawing.Size(87, 23)
        Me.cmdWorkSave.TabIndex = 4
        Me.cmdWorkSave.Text = "Save"
        Me.cmdWorkSave.UseVisualStyleBackColor = False
        '
        'txtCompanyCurrent
        '
        Me.txtCompanyCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompanyCurrent.AutoSize = True
        Me.txtCompanyCurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyCurrent.Location = New System.Drawing.Point(198, 97)
        Me.txtCompanyCurrent.Name = "txtCompanyCurrent"
        Me.txtCompanyCurrent.Size = New System.Drawing.Size(116, 17)
        Me.txtCompanyCurrent.TabIndex = 3
        Me.txtCompanyCurrent.Text = "Current Company"
        Me.txtCompanyCurrent.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(94, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 15)
        Me.Label31.TabIndex = 347
        Me.Label31.Text = "Position or Rules"
        '
        'txtCompanyDatePeriod
        '
        Me.txtCompanyDatePeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompanyDatePeriod.CustomFormat = "yyyy-MM-dd"
        Me.txtCompanyDatePeriod.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyDatePeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCompanyDatePeriod.Location = New System.Drawing.Point(198, 70)
        Me.txtCompanyDatePeriod.Name = "txtCompanyDatePeriod"
        Me.txtCompanyDatePeriod.Size = New System.Drawing.Size(238, 22)
        Me.txtCompanyDatePeriod.TabIndex = 2
        Me.txtCompanyDatePeriod.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(121, 73)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 15)
        Me.Label29.TabIndex = 345
        Me.Label29.Text = "Date Period"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(95, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(94, 15)
        Me.Label30.TabIndex = 343
        Me.Label30.Text = "Company Name"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(198, 18)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.MaxLength = 100
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(368, 22)
        Me.txtCompanyName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gridWork)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(653, 263)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Work History"
        '
        'gridWork
        '
        Me.gridWork.AllowUserToAddRows = False
        Me.gridWork.AllowUserToDeleteRows = False
        Me.gridWork.AllowUserToResizeRows = False
        Me.gridWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gridWork.BackgroundColor = System.Drawing.Color.White
        Me.gridWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridWork.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridWork.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridWork.ContextMenuStrip = Me.ContextMenuCompany
        Me.gridWork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridWork.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridWork.Location = New System.Drawing.Point(3, 19)
        Me.gridWork.Margin = New System.Windows.Forms.Padding(2)
        Me.gridWork.MultiSelect = False
        Me.gridWork.Name = "gridWork"
        Me.gridWork.ReadOnly = True
        Me.gridWork.RowHeadersVisible = False
        Me.gridWork.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.gridWork.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridWork.Size = New System.Drawing.Size(647, 241)
        Me.gridWork.TabIndex = 4
        '
        'ContextMenuCompany
        '
        Me.ContextMenuCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRemoveWork})
        Me.ContextMenuCompany.Name = "ContextMenuStrip1"
        Me.ContextMenuCompany.Size = New System.Drawing.Size(149, 26)
        '
        'tabEducation
        '
        Me.tabEducation.Controls.Add(Me.cndEduSave)
        Me.tabEducation.Controls.Add(Me.txtSchoolDetails)
        Me.tabEducation.Controls.Add(Me.Label35)
        Me.tabEducation.Controls.Add(Me.txtSchoolLevel)
        Me.tabEducation.Controls.Add(Me.txtEducCurrent)
        Me.tabEducation.Controls.Add(Me.Label32)
        Me.tabEducation.Controls.Add(Me.txtEducPeriod)
        Me.tabEducation.Controls.Add(Me.Label33)
        Me.tabEducation.Controls.Add(Me.Label34)
        Me.tabEducation.Controls.Add(Me.txtSchoolname)
        Me.tabEducation.Controls.Add(Me.GroupBox1)
        Me.tabEducation.Location = New System.Drawing.Point(4, 26)
        Me.tabEducation.Name = "tabEducation"
        Me.tabEducation.Size = New System.Drawing.Size(669, 397)
        Me.tabEducation.TabIndex = 2
        Me.tabEducation.Text = "Education Attainment"
        Me.tabEducation.UseVisualStyleBackColor = True
        '
        'cndEduSave
        '
        Me.cndEduSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cndEduSave.BackColor = System.Drawing.Color.White
        Me.cndEduSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cndEduSave.ForeColor = System.Drawing.Color.Black
        Me.cndEduSave.Location = New System.Drawing.Point(349, 119)
        Me.cndEduSave.Name = "cndEduSave"
        Me.cndEduSave.Size = New System.Drawing.Size(87, 23)
        Me.cndEduSave.TabIndex = 359
        Me.cndEduSave.Text = "Save"
        Me.cndEduSave.UseVisualStyleBackColor = False
        '
        'txtSchoolDetails
        '
        Me.txtSchoolDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSchoolDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSchoolDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSchoolDetails.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolDetails.Location = New System.Drawing.Point(198, 69)
        Me.txtSchoolDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSchoolDetails.MaxLength = 45
        Me.txtSchoolDetails.Name = "txtSchoolDetails"
        Me.txtSchoolDetails.Size = New System.Drawing.Size(238, 22)
        Me.txtSchoolDetails.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(116, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 15)
        Me.Label35.TabIndex = 358
        Me.Label35.Text = "School Level"
        '
        'txtSchoolLevel
        '
        Me.txtSchoolLevel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSchoolLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSchoolLevel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSchoolLevel.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolLevel.FormattingEnabled = True
        Me.txtSchoolLevel.ItemHeight = 13
        Me.txtSchoolLevel.Items.AddRange(New Object() {"College", "Vocational", "Secondary", "Elementary", "Others"})
        Me.txtSchoolLevel.Location = New System.Drawing.Point(198, 44)
        Me.txtSchoolLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSchoolLevel.Name = "txtSchoolLevel"
        Me.txtSchoolLevel.Size = New System.Drawing.Size(238, 21)
        Me.txtSchoolLevel.TabIndex = 1
        '
        'txtEducCurrent
        '
        Me.txtEducCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEducCurrent.AutoSize = True
        Me.txtEducCurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEducCurrent.Location = New System.Drawing.Point(198, 123)
        Me.txtEducCurrent.Name = "txtEducCurrent"
        Me.txtEducCurrent.Size = New System.Drawing.Size(103, 17)
        Me.txtEducCurrent.TabIndex = 4
        Me.txtEducCurrent.Text = "Current School"
        Me.txtEducCurrent.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(114, 72)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 15)
        Me.Label32.TabIndex = 355
        Me.Label32.Text = "Other Details"
        '
        'txtEducPeriod
        '
        Me.txtEducPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEducPeriod.CustomFormat = "yyyy-MM-dd"
        Me.txtEducPeriod.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEducPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtEducPeriod.Location = New System.Drawing.Point(198, 95)
        Me.txtEducPeriod.Name = "txtEducPeriod"
        Me.txtEducPeriod.Size = New System.Drawing.Size(238, 22)
        Me.txtEducPeriod.TabIndex = 3
        Me.txtEducPeriod.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(121, 98)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 15)
        Me.Label33.TabIndex = 353
        Me.Label33.Text = "Date Period"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(111, 21)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 15)
        Me.Label34.TabIndex = 351
        Me.Label34.Text = "School Name"
        '
        'txtSchoolname
        '
        Me.txtSchoolname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSchoolname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSchoolname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSchoolname.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolname.Location = New System.Drawing.Point(198, 18)
        Me.txtSchoolname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSchoolname.MaxLength = 100
        Me.txtSchoolname.Name = "txtSchoolname"
        Me.txtSchoolname.Size = New System.Drawing.Size(368, 22)
        Me.txtSchoolname.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gridEducation)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 241)
        Me.GroupBox1.TabIndex = 349
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Education Attainment"
        '
        'gridEducation
        '
        Me.gridEducation.AllowUserToAddRows = False
        Me.gridEducation.AllowUserToDeleteRows = False
        Me.gridEducation.AllowUserToResizeRows = False
        Me.gridEducation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridEducation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gridEducation.BackgroundColor = System.Drawing.Color.White
        Me.gridEducation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEducation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridEducation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEducation.ContextMenuStrip = Me.ContextMenuEducation
        Me.gridEducation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEducation.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridEducation.Location = New System.Drawing.Point(3, 19)
        Me.gridEducation.Margin = New System.Windows.Forms.Padding(2)
        Me.gridEducation.MultiSelect = False
        Me.gridEducation.Name = "gridEducation"
        Me.gridEducation.ReadOnly = True
        Me.gridEducation.RowHeadersVisible = False
        Me.gridEducation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.gridEducation.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gridEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEducation.Size = New System.Drawing.Size(643, 219)
        Me.gridEducation.TabIndex = 5
        '
        'ContextMenuEducation
        '
        Me.ContextMenuEducation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRemoveSchool})
        Me.ContextMenuEducation.Name = "ContextMenuStrip1"
        Me.ContextMenuEducation.Size = New System.Drawing.Size(157, 26)
        '
        'tabMembership
        '
        Me.tabMembership.Controls.Add(Me.Label12)
        Me.tabMembership.Controls.Add(Me.Label5)
        Me.tabMembership.Controls.Add(Me.txtPassword)
        Me.tabMembership.Controls.Add(Me.cmdDone)
        Me.tabMembership.Controls.Add(Me.txtchaptercode)
        Me.tabMembership.Controls.Add(Me.LinkLabel2)
        Me.tabMembership.Controls.Add(Me.Label7)
        Me.tabMembership.Controls.Add(Me.LinkLabel1)
        Me.tabMembership.Controls.Add(Me.cmdGenerate)
        Me.tabMembership.Controls.Add(Me.txtmemberid)
        Me.tabMembership.Controls.Add(Me.txtfullname)
        Me.tabMembership.Controls.Add(Me.Label28)
        Me.tabMembership.Controls.Add(Me.txtidcard)
        Me.tabMembership.Controls.Add(Me.Label27)
        Me.tabMembership.Controls.Add(Me.txtrituals)
        Me.tabMembership.Controls.Add(Me.txtdatesurvived)
        Me.tabMembership.Controls.Add(Me.Label26)
        Me.tabMembership.Controls.Add(Me.Label25)
        Me.tabMembership.Controls.Add(Me.txtbaptizedname)
        Me.tabMembership.Controls.Add(Me.Label23)
        Me.tabMembership.Controls.Add(Me.txtchaptername)
        Me.tabMembership.Controls.Add(Me.lblMessageDescription)
        Me.tabMembership.Controls.Add(Me.lblSuccessTitle)
        Me.tabMembership.Location = New System.Drawing.Point(4, 26)
        Me.tabMembership.Name = "tabMembership"
        Me.tabMembership.Size = New System.Drawing.Size(669, 397)
        Me.tabMembership.TabIndex = 3
        Me.tabMembership.Text = "Membership Information"
        Me.tabMembership.UseVisualStyleBackColor = True
        '
        'txtchaptercode
        '
        Me.txtchaptercode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtchaptercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchaptercode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtchaptercode.ForeColor = System.Drawing.Color.Black
        Me.txtchaptercode.Location = New System.Drawing.Point(510, 59)
        Me.txtchaptercode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptercode.MaxLength = 45
        Me.txtchaptercode.Name = "txtchaptercode"
        Me.txtchaptercode.Size = New System.Drawing.Size(48, 22)
        Me.txtchaptercode.TabIndex = 354
        Me.txtchaptercode.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel2.Location = New System.Drawing.Point(507, 37)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(74, 15)
        Me.LinkLabel2.TabIndex = 353
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Add Chapter"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(130, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 15)
        Me.Label7.TabIndex = 270
        Me.Label7.Text = "Membership Confirmation"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(108, 228)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(124, 15)
        Me.LinkLabel1.TabIndex = 351
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Membership ID (Help)"
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGenerate.BackColor = System.Drawing.Color.White
        Me.cmdGenerate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdGenerate.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerate.Location = New System.Drawing.Point(241, 250)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(137, 32)
        Me.cmdGenerate.TabIndex = 350
        Me.cmdGenerate.Text = "Get Membership ID"
        Me.cmdGenerate.UseVisualStyleBackColor = False
        '
        'txtmemberid
        '
        Me.txtmemberid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmemberid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmemberid.ForeColor = System.Drawing.Color.Red
        Me.txtmemberid.Location = New System.Drawing.Point(241, 224)
        Me.txtmemberid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.ReadOnly = True
        Me.txtmemberid.Size = New System.Drawing.Size(242, 22)
        Me.txtmemberid.TabIndex = 9
        Me.txtmemberid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfullname
        '
        Me.txtfullname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtfullname.ForeColor = System.Drawing.Color.Black
        Me.txtfullname.Location = New System.Drawing.Point(577, 364)
        Me.txtfullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.ReadOnly = True
        Me.txtfullname.Size = New System.Drawing.Size(88, 22)
        Me.txtfullname.TabIndex = 8
        Me.txtfullname.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(110, 134)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(121, 15)
        Me.Label28.TabIndex = 347
        Me.Label28.Text = "Membership ID Card?"
        '
        'txtidcard
        '
        Me.txtidcard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtidcard.AutoSize = True
        Me.txtidcard.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtidcard.Location = New System.Drawing.Point(242, 134)
        Me.txtidcard.Name = "txtidcard"
        Me.txtidcard.Size = New System.Drawing.Size(41, 17)
        Me.txtidcard.TabIndex = 4
        Me.txtidcard.Text = "Yes"
        Me.txtidcard.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(91, 111)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(140, 15)
        Me.Label27.TabIndex = 345
        Me.Label27.Text = "Membership Ritual Burn?"
        '
        'txtrituals
        '
        Me.txtrituals.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtrituals.AutoSize = True
        Me.txtrituals.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtrituals.Location = New System.Drawing.Point(242, 111)
        Me.txtrituals.Name = "txtrituals"
        Me.txtrituals.Size = New System.Drawing.Size(41, 17)
        Me.txtrituals.TabIndex = 3
        Me.txtrituals.Text = "Yes"
        Me.txtrituals.UseVisualStyleBackColor = True
        '
        'txtdatesurvived
        '
        Me.txtdatesurvived.AllowDrop = True
        Me.txtdatesurvived.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdatesurvived.CustomFormat = "MMMM dd, yyyy"
        Me.txtdatesurvived.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdatesurvived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdatesurvived.Location = New System.Drawing.Point(242, 83)
        Me.txtdatesurvived.Name = "txtdatesurvived"
        Me.txtdatesurvived.Size = New System.Drawing.Size(181, 22)
        Me.txtdatesurvived.TabIndex = 2
        Me.txtdatesurvived.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(152, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 15)
        Me.Label26.TabIndex = 343
        Me.Label26.Text = "Date Survived"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(144, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 15)
        Me.Label25.TabIndex = 281
        Me.Label25.Text = "Baptized Name"
        '
        'txtbaptizedname
        '
        Me.txtbaptizedname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbaptizedname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbaptizedname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbaptizedname.ForeColor = System.Drawing.Color.Black
        Me.txtbaptizedname.Location = New System.Drawing.Point(242, 58)
        Me.txtbaptizedname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbaptizedname.MaxLength = 45
        Me.txtbaptizedname.Name = "txtbaptizedname"
        Me.txtbaptizedname.Size = New System.Drawing.Size(261, 22)
        Me.txtbaptizedname.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(147, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 15)
        Me.Label23.TabIndex = 276
        Me.Label23.Text = "Chapter Name"
        '
        'txtchaptername
        '
        Me.txtchaptername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtchaptername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtchaptername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtchaptername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtchaptername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtchaptername.ForeColor = System.Drawing.Color.Black
        Me.txtchaptername.FormattingEnabled = True
        Me.txtchaptername.ItemHeight = 15
        Me.txtchaptername.Location = New System.Drawing.Point(242, 32)
        Me.txtchaptername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchaptername.Name = "txtchaptername"
        Me.txtchaptername.Size = New System.Drawing.Size(261, 23)
        Me.txtchaptername.TabIndex = 0
        '
        'lblMessageDescription
        '
        Me.lblMessageDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessageDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMessageDescription.ForeColor = System.Drawing.Color.Black
        Me.lblMessageDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMessageDescription.Location = New System.Drawing.Point(243, 272)
        Me.lblMessageDescription.Name = "lblMessageDescription"
        Me.lblMessageDescription.Size = New System.Drawing.Size(358, 82)
        Me.lblMessageDescription.TabIndex = 356
        Me.lblMessageDescription.Text = "Please take a note of your membership ID above for your reference, you can inquir" & _
    "e your registration status using search global members form. thank you and have " & _
    "a nice day.."
        Me.lblMessageDescription.Visible = False
        '
        'lblSuccessTitle
        '
        Me.lblSuccessTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSuccessTitle.AutoSize = True
        Me.lblSuccessTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSuccessTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblSuccessTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSuccessTitle.Location = New System.Drawing.Point(241, 251)
        Me.lblSuccessTitle.Name = "lblSuccessTitle"
        Me.lblSuccessTitle.Size = New System.Drawing.Size(264, 21)
        Me.lblSuccessTitle.TabIndex = 355
        Me.lblSuccessTitle.Text = "Membership successfully submitted.."
        Me.lblSuccessTitle.Visible = False
        '
        'RemoveCompanyToolStripMenuItem
        '
        Me.RemoveCompanyToolStripMenuItem.Name = "RemoveCompanyToolStripMenuItem"
        Me.RemoveCompanyToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RemoveCompanyToolStripMenuItem.Text = "Remove Company"
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNext.Location = New System.Drawing.Point(348, 482)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(138, 30)
        Me.cmdNext.TabIndex = 14
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdPrevious.Enabled = False
        Me.cmdPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdPrevious.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrevious.Location = New System.Drawing.Point(204, 482)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(138, 30)
        Me.cmdPrevious.TabIndex = 336
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDone.BackColor = System.Drawing.Color.White
        Me.cmdDone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDone.ForeColor = System.Drawing.Color.Black
        Me.cmdDone.Location = New System.Drawing.Point(241, 324)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(137, 32)
        Me.cmdDone.TabIndex = 357
        Me.cmdDone.Text = "DONE"
        Me.cmdDone.UseVisualStyleBackColor = False
        Me.cmdDone.Visible = False
        '
        'picProfile
        '
        Me.picProfile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picProfile.ContextMenuStrip = Me.ContextMenuStrip1
        Me.picProfile.Image = Global.Tyronians.My.Resources.Resources.blankimg
        Me.picProfile.Location = New System.Drawing.Point(403, 28)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(183, 169)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 348
        Me.picProfile.TabStop = False
        '
        'cmdRemoveWork
        '
        Me.cmdRemoveWork.Image = Global.Tyronians.My.Resources.Resources.notebook__minus
        Me.cmdRemoveWork.Name = "cmdRemoveWork"
        Me.cmdRemoveWork.Size = New System.Drawing.Size(148, 22)
        Me.cmdRemoveWork.Text = "Remove Work"
        '
        'cmdRemoveSchool
        '
        Me.cmdRemoveSchool.Image = Global.Tyronians.My.Resources.Resources.notebook__minus
        Me.cmdRemoveSchool.Name = "cmdRemoveSchool"
        Me.cmdRemoveSchool.Size = New System.Drawing.Size(156, 22)
        Me.cmdRemoveSchool.Text = "Remove School"
        '
        'BrowsePictureToolStripMenuItem
        '
        Me.BrowsePictureToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.image
        Me.BrowsePictureToolStripMenuItem.Name = "BrowsePictureToolStripMenuItem"
        Me.BrowsePictureToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BrowsePictureToolStripMenuItem.Text = "Browse Picture"
        '
        'RemovePictureToolStripMenuItem
        '
        Me.RemovePictureToolStripMenuItem.Image = Global.Tyronians.My.Resources.Resources.image__minus
        Me.RemovePictureToolStripMenuItem.Name = "RemovePictureToolStripMenuItem"
        Me.RemovePictureToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RemovePictureToolStripMenuItem.Text = "Remove Picture"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(185, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 359
        Me.Label5.Text = "Answer"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(241, 199)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 45
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(242, 22)
        Me.txtPassword.TabIndex = 358
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(239, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(228, 15)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "Password verification: Anong yosi mo tol?"
        '
        'frmMembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(701, 523)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cmdNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMembershipForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tyronians Centralized Data Management System"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPersonal.ResumeLayout(False)
        Me.tabPersonal.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabWork.ResumeLayout(False)
        Me.tabWork.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuCompany.ResumeLayout(False)
        Me.tabEducation.ResumeLayout(False)
        Me.tabEducation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridEducation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuEducation.ResumeLayout(False)
        Me.tabMembership.ResumeLayout(False)
        Me.tabMembership.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPersonal As System.Windows.Forms.TabPage
    Friend WithEvents tabWork As System.Windows.Forms.TabPage
    Friend WithEvents tabEducation As System.Windows.Forms.TabPage
    Friend WithEvents tabMembership As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtnickname As System.Windows.Forms.TextBox
    Friend WithEvents txtbirthplace As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtmemberid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtincase_contact As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtincase_contactname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtemailadd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmobilenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtchaptername As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtidcard As System.Windows.Forms.CheckBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtrituals As System.Windows.Forms.CheckBox
    Friend WithEvents txtdatesurvived As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtbaptizedname As System.Windows.Forms.TextBox
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowsePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridWork As System.Windows.Forms.DataGridView
    Friend WithEvents txtCompanyDatePeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyCurrent As System.Windows.Forms.CheckBox
    Friend WithEvents txtSchoolDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtEducCurrent As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtEducPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridEducation As System.Windows.Forms.DataGridView
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdWorkSave As System.Windows.Forms.Button
    Friend WithEvents ContextMenuCompany As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents cndEduSave As System.Windows.Forms.Button
    Friend WithEvents ContextMenuEducation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRemoveSchool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCompleteAddress As System.Windows.Forms.TextBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtchaptercode As System.Windows.Forms.TextBox
    Friend WithEvents cmdRemoveWork As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMessageDescription As System.Windows.Forms.Label
    Friend WithEvents lblSuccessTitle As System.Windows.Forms.Label
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class
