<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformation))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPosition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.memberid = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateSurvived = New DevExpress.XtraEditors.DateEdit()
        Me.txtBirthdate = New DevExpress.XtraEditors.DateEdit()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRegisteredBy = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridRegisteredby = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtRecruiterName = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBaptizedName = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOccupation = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChapter = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridChapter = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCouncil = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCouncil = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtGender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmd_financer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendViaTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memberid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSurvived.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateSurvived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegisteredBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRegisteredby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecruiterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBaptizedName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOccupation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChapter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridChapter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCouncil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCouncil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_financer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mode)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtPosition)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.memberid)
        Me.GroupBox2.Controls.Add(Me.txtDateSurvived)
        Me.GroupBox2.Controls.Add(Me.txtBirthdate)
        Me.GroupBox2.Controls.Add(Me.cmdConfirm)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtRegisteredBy)
        Me.GroupBox2.Controls.Add(Me.txtRecruiterName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBaptizedName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtOccupation)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFullname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtChapter)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCouncil)
        Me.GroupBox2.Controls.Add(Me.txtGender)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 463)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Member Information"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(390, 24)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(44, 24)
        Me.mode.TabIndex = 866
        Me.mode.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(51, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 15)
        Me.Label13.TabIndex = 865
        Me.Label13.Text = "Current Position"
        '
        'txtPosition
        '
        Me.txtPosition.EditValue = ""
        Me.txtPosition.Location = New System.Drawing.Point(150, 254)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPosition.Properties.Appearance.Options.UseFont = True
        Me.txtPosition.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPosition.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPosition.Size = New System.Drawing.Size(222, 24)
        Me.txtPosition.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(78, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 15)
        Me.Label12.TabIndex = 863
        Me.Label12.Text = "Member ID"
        '
        'memberid
        '
        Me.memberid.Location = New System.Drawing.Point(150, 36)
        Me.memberid.Name = "memberid"
        Me.memberid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.memberid.Properties.Appearance.Options.UseFont = True
        Me.memberid.Properties.Appearance.Options.UseTextOptions = True
        Me.memberid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.memberid.Properties.ReadOnly = True
        Me.memberid.Size = New System.Drawing.Size(173, 24)
        Me.memberid.TabIndex = 862
        '
        'txtDateSurvived
        '
        Me.txtDateSurvived.EditValue = New Date(CType(0, Long))
        Me.txtDateSurvived.EnterMoveNextControl = True
        Me.txtDateSurvived.Location = New System.Drawing.Point(150, 281)
        Me.txtDateSurvived.Name = "txtDateSurvived"
        Me.txtDateSurvived.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDateSurvived.Properties.Appearance.Options.UseFont = True
        Me.txtDateSurvived.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateSurvived.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateSurvived.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateSurvived.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateSurvived.Size = New System.Drawing.Size(173, 24)
        Me.txtDateSurvived.TabIndex = 8
        '
        'txtBirthdate
        '
        Me.txtBirthdate.EditValue = New Date(CType(0, Long))
        Me.txtBirthdate.EnterMoveNextControl = True
        Me.txtBirthdate.Location = New System.Drawing.Point(150, 146)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBirthdate.Properties.Appearance.Options.UseFont = True
        Me.txtBirthdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBirthdate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtBirthdate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBirthdate.Size = New System.Drawing.Size(173, 24)
        Me.txtBirthdate.TabIndex = 3
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(150, 390)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(173, 34)
        Me.cmdConfirm.TabIndex = 12
        Me.cmdConfirm.Text = "Confirm Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(66, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 15)
        Me.Label11.TabIndex = 860
        Me.Label11.Text = "Registered By"
        '
        'txtRegisteredBy
        '
        Me.txtRegisteredBy.EditValue = ""
        Me.txtRegisteredBy.Location = New System.Drawing.Point(150, 362)
        Me.txtRegisteredBy.Name = "txtRegisteredBy"
        Me.txtRegisteredBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRegisteredBy.Properties.Appearance.Options.UseFont = True
        Me.txtRegisteredBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRegisteredBy.Properties.DisplayMember = "Fullname"
        Me.txtRegisteredBy.Properties.NullText = ""
        Me.txtRegisteredBy.Properties.PopupView = Me.gridRegisteredby
        Me.txtRegisteredBy.Properties.ValueMember = "phonenumber"
        Me.txtRegisteredBy.Size = New System.Drawing.Size(222, 24)
        Me.txtRegisteredBy.TabIndex = 11
        '
        'gridRegisteredby
        '
        Me.gridRegisteredby.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRegisteredby.Name = "gridRegisteredby"
        Me.gridRegisteredby.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRegisteredby.OptionsView.ShowGroupPanel = False
        '
        'txtRecruiterName
        '
        Me.txtRecruiterName.Location = New System.Drawing.Point(150, 335)
        Me.txtRecruiterName.Name = "txtRecruiterName"
        Me.txtRecruiterName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRecruiterName.Properties.Appearance.Options.UseFont = True
        Me.txtRecruiterName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecruiterName.Size = New System.Drawing.Size(173, 24)
        Me.txtRecruiterName.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(55, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 15)
        Me.Label10.TabIndex = 857
        Me.Label10.Text = "Recruiter Name"
        '
        'txtBaptizedName
        '
        Me.txtBaptizedName.Location = New System.Drawing.Point(150, 308)
        Me.txtBaptizedName.Name = "txtBaptizedName"
        Me.txtBaptizedName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBaptizedName.Properties.Appearance.Options.UseFont = True
        Me.txtBaptizedName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBaptizedName.Size = New System.Drawing.Size(173, 24)
        Me.txtBaptizedName.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(57, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 15)
        Me.Label9.TabIndex = 855
        Me.Label9.Text = "Baptized Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(65, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 854
        Me.Label8.Text = "Date Survived"
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(150, 227)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtOccupation.Properties.Appearance.Options.UseFont = True
        Me.txtOccupation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOccupation.Size = New System.Drawing.Size(173, 24)
        Me.txtOccupation.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(75, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 851
        Me.Label7.Text = "Occupation"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(150, 200)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhoneNumber.Properties.Appearance.Options.UseFont = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(173, 24)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(56, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 849
        Me.Label5.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(99, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 847
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(89, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 846
        Me.Label2.Text = "Birthdate"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(150, 118)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullname.Properties.Appearance.Options.UseFont = True
        Me.txtFullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Size = New System.Drawing.Size(222, 24)
        Me.txtFullname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(88, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 843
        Me.Label3.Text = "Fullname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(95, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 841
        Me.Label1.Text = "Chapter"
        '
        'txtChapter
        '
        Me.txtChapter.EditValue = ""
        Me.txtChapter.Location = New System.Drawing.Point(150, 91)
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtChapter.Properties.Appearance.Options.UseFont = True
        Me.txtChapter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtChapter.Properties.DisplayMember = "Chapter"
        Me.txtChapter.Properties.NullText = ""
        Me.txtChapter.Properties.PopupView = Me.gridChapter
        Me.txtChapter.Properties.ValueMember = "chaptercode"
        Me.txtChapter.Size = New System.Drawing.Size(222, 24)
        Me.txtChapter.TabIndex = 1
        '
        'gridChapter
        '
        Me.gridChapter.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridChapter.Name = "gridChapter"
        Me.gridChapter.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridChapter.OptionsView.ShowGroupPanel = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(96, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 839
        Me.Label6.Text = "Council"
        '
        'txtCouncil
        '
        Me.txtCouncil.EditValue = ""
        Me.txtCouncil.Location = New System.Drawing.Point(150, 64)
        Me.txtCouncil.Name = "txtCouncil"
        Me.txtCouncil.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCouncil.Properties.Appearance.Options.UseFont = True
        Me.txtCouncil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCouncil.Properties.DisplayMember = "Council"
        Me.txtCouncil.Properties.NullText = ""
        Me.txtCouncil.Properties.PopupView = Me.gridCouncil
        Me.txtCouncil.Properties.ValueMember = "councilcode"
        Me.txtCouncil.Size = New System.Drawing.Size(222, 24)
        Me.txtCouncil.TabIndex = 0
        '
        'gridCouncil
        '
        Me.gridCouncil.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCouncil.Name = "gridCouncil"
        Me.gridCouncil.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCouncil.OptionsView.ShowGroupPanel = False
        '
        'txtGender
        '
        Me.txtGender.EditValue = ""
        Me.txtGender.Location = New System.Drawing.Point(150, 173)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGender.Properties.Appearance.Options.UseFont = True
        Me.txtGender.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGender.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txtGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGender.Properties.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.txtGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtGender.Size = New System.Drawing.Size(173, 24)
        Me.txtGender.TabIndex = 4
        '
        'cmd_financer
        '
        Me.cmd_financer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.SendViaTextToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.cmd_financer.Name = "gridmenustrip"
        Me.cmd_financer.Size = New System.Drawing.Size(165, 98)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__pencil
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditToolStripMenuItem.Text = "Edit Selected"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.notebook__minus
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Selected"
        '
        'SendViaTextToolStripMenuItem
        '
        Me.SendViaTextToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.mail__arrow
        Me.SendViaTextToolStripMenuItem.Name = "SendViaTextToolStripMenuItem"
        Me.SendViaTextToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SendViaTextToolStripMenuItem.Text = "Send via Text"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.TGP.My.Resources.Resources.arrow_continue_000_top
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh List"
        '
        'frmInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(446, 463)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInformation"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memberid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSurvived.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateSurvived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBirthdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegisteredBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRegisteredby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecruiterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBaptizedName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOccupation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChapter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridChapter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCouncil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCouncil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_financer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_financer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SendViaTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRegisteredBy As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridRegisteredby As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtRecruiterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBaptizedName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOccupation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChapter As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridChapter As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCouncil As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCouncil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtDateSurvived As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtBirthdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents memberid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
End Class
