<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcomeMessage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtDownloadLocation = New System.Windows.Forms.TextBox()
        Me.txtversion = New System.Windows.Forms.TextBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(70, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tyronians Centralized Data Management (TCDM)"
        '
        'cmdRegister
        '
        Me.cmdRegister.BackColor = System.Drawing.Color.White
        Me.cmdRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdRegister.ForeColor = System.Drawing.Color.Black
        Me.cmdRegister.Location = New System.Drawing.Point(47, 88)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(183, 32)
        Me.cmdRegister.TabIndex = 358
        Me.cmdRegister.Text = "MEMBER REGISTRATION"
        Me.cmdRegister.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.White
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSearch.ForeColor = System.Drawing.Color.Black
        Me.cmdSearch.Location = New System.Drawing.Point(47, 54)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(183, 32)
        Me.cmdSearch.TabIndex = 359
        Me.cmdSearch.Text = "SEARCH GLOBAL MEMBERS"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(70, 342)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(267, 15)
        Me.lblVersion.TabIndex = 361
        Me.lblVersion.Text = "Application Version 16.3.24"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(137, 362)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(130, 10)
        Me.ProgressBar1.TabIndex = 362
        Me.ProgressBar1.Visible = False
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(837, 12)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtFileName.TabIndex = 363
        '
        'txtDownloadLocation
        '
        Me.txtDownloadLocation.Location = New System.Drawing.Point(837, 38)
        Me.txtDownloadLocation.Name = "txtDownloadLocation"
        Me.txtDownloadLocation.Size = New System.Drawing.Size(100, 20)
        Me.txtDownloadLocation.TabIndex = 364
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(837, 64)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(100, 20)
        Me.txtversion.TabIndex = 365
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel3.Location = New System.Drawing.Point(83, 226)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(108, 15)
        Me.LinkLabel3.TabIndex = 366
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "License Agreement"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(47, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 32)
        Me.Button1.TabIndex = 367
        Me.Button1.Text = "CONTRIBUTION COLLECTION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(47, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 32)
        Me.Button2.TabIndex = 368
        Me.Button2.Text = "ACCOUNTING SYSTEM"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(47, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(183, 32)
        Me.Button4.TabIndex = 370
        Me.Button4.Text = "DATABASE REPORTS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.cmdRegister)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(365, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 336)
        Me.GroupBox1.TabIndex = 371
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main menu option"
        '
        'picProfile
        '
        Me.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picProfile.Image = Global.Tyronians.My.Resources.Resources.tgp_logo
        Me.picProfile.Location = New System.Drawing.Point(58, 26)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(291, 289)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picProfile.TabIndex = 360
        Me.picProfile.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(47, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 32)
        Me.Button3.TabIndex = 371
        Me.Button3.Text = "FOR VERIFICATION"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmWelcomeMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(653, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtversion)
        Me.Controls.Add(Me.txtDownloadLocation)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWelcomeMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tyronians Centralized Data Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdRegister As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtDownloadLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtversion As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
