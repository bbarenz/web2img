<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_BrowseFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nud_BrowserUpdateInterval = New System.Windows.Forms.NumericUpDown()
        Me.nud_ImageupdateInterval = New System.Windows.Forms.NumericUpDown()
        Me.txt_SaveDirectory = New System.Windows.Forms.TextBox()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.chk_EnableImageTimer = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmr_ImageUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.chk_EnableBrowerUpdateTimer = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmr_BrowserUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_BrowserUpdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_ImageupdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.WebBrowser1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 482)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Web Browser"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(634, 463)
        Me.WebBrowser1.TabIndex = 0
        '
        'btn_Go
        '
        Me.btn_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Go.Location = New System.Drawing.Point(574, 516)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(75, 23)
        Me.btn_Go.TabIndex = 1
        Me.btn_Go.Text = "Navigate"
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 521)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "URL:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 554)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Save Dir:"
        '
        'btn_BrowseFile
        '
        Me.btn_BrowseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_BrowseFile.Location = New System.Drawing.Point(574, 550)
        Me.btn_BrowseFile.Name = "btn_BrowseFile"
        Me.btn_BrowseFile.Size = New System.Drawing.Size(75, 23)
        Me.btn_BrowseFile.TabIndex = 7
        Me.btn_BrowseFile.Text = "Browse"
        Me.btn_BrowseFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Image Update Interval (ms):"
        '
        'nud_BrowserUpdateInterval
        '
        Me.nud_BrowserUpdateInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nud_BrowserUpdateInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.web2img.My.MySettings.Default, "BrowserUpdateIntervalSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nud_BrowserUpdateInterval.Location = New System.Drawing.Point(271, 591)
        Me.nud_BrowserUpdateInterval.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_BrowserUpdateInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_BrowserUpdateInterval.Name = "nud_BrowserUpdateInterval"
        Me.nud_BrowserUpdateInterval.Size = New System.Drawing.Size(73, 20)
        Me.nud_BrowserUpdateInterval.TabIndex = 13
        Me.nud_BrowserUpdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nud_BrowserUpdateInterval, "Browser timer update interval in minutes")
        Me.nud_BrowserUpdateInterval.Value = Global.web2img.My.MySettings.Default.BrowserUpdateIntervalSave
        '
        'nud_ImageupdateInterval
        '
        Me.nud_ImageupdateInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nud_ImageupdateInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.web2img.My.MySettings.Default, "UpdateIntervalSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nud_ImageupdateInterval.Location = New System.Drawing.Point(98, 592)
        Me.nud_ImageupdateInterval.Maximum = New Decimal(New Integer() {120000, 0, 0, 0})
        Me.nud_ImageupdateInterval.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nud_ImageupdateInterval.Name = "nud_ImageupdateInterval"
        Me.nud_ImageupdateInterval.Size = New System.Drawing.Size(73, 20)
        Me.nud_ImageupdateInterval.TabIndex = 9
        Me.nud_ImageupdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nud_ImageupdateInterval, "Image timer update interval in miliseconds")
        Me.nud_ImageupdateInterval.Value = Global.web2img.My.MySettings.Default.UpdateIntervalSave
        '
        'txt_SaveDirectory
        '
        Me.txt_SaveDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SaveDirectory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.web2img.My.MySettings.Default, "DirSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_SaveDirectory.Location = New System.Drawing.Point(65, 550)
        Me.txt_SaveDirectory.Name = "txt_SaveDirectory"
        Me.txt_SaveDirectory.Size = New System.Drawing.Size(503, 20)
        Me.txt_SaveDirectory.TabIndex = 5
        Me.txt_SaveDirectory.Text = Global.web2img.My.MySettings.Default.DirSave
        Me.ToolTip1.SetToolTip(Me.txt_SaveDirectory, "Directory where file will be saved")
        '
        'txt_url
        '
        Me.txt_url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_url.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.web2img.My.MySettings.Default, "urlSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_url.Location = New System.Drawing.Point(65, 517)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(503, 20)
        Me.txt_url.TabIndex = 2
        Me.txt_url.Text = Global.web2img.My.MySettings.Default.urlSave
        Me.ToolTip1.SetToolTip(Me.txt_url, "Webpage URL")
        '
        'chk_EnableImageTimer
        '
        Me.chk_EnableImageTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_EnableImageTimer.AutoSize = True
        Me.chk_EnableImageTimer.Location = New System.Drawing.Point(177, 593)
        Me.chk_EnableImageTimer.Name = "chk_EnableImageTimer"
        Me.chk_EnableImageTimer.Size = New System.Drawing.Size(59, 17)
        Me.chk_EnableImageTimer.TabIndex = 10
        Me.chk_EnableImageTimer.Text = "Enable"
        Me.chk_EnableImageTimer.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SnapToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HideToolStripMenuItem.Text = "&Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'SnapToolStripMenuItem
        '
        Me.SnapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshBrowserToolStripMenuItem, Me.UpdateImageToolStripMenuItem})
        Me.SnapToolStripMenuItem.Name = "SnapToolStripMenuItem"
        Me.SnapToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SnapToolStripMenuItem.Text = "&Snap"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 70)
        Me.ContextMenuStrip1.Text = "web2img"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem1.Text = "&Show"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem2.Text = "&Hide"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem3.Text = "&Close"
        '
        'tmr_ImageUpdate
        '
        Me.tmr_ImageUpdate.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "web2img"
        Me.NotifyIcon1.Visible = True
        '
        'chk_EnableBrowerUpdateTimer
        '
        Me.chk_EnableBrowerUpdateTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_EnableBrowerUpdateTimer.AutoSize = True
        Me.chk_EnableBrowerUpdateTimer.Enabled = False
        Me.chk_EnableBrowerUpdateTimer.Location = New System.Drawing.Point(350, 592)
        Me.chk_EnableBrowerUpdateTimer.Name = "chk_EnableBrowerUpdateTimer"
        Me.chk_EnableBrowerUpdateTimer.Size = New System.Drawing.Size(59, 17)
        Me.chk_EnableBrowerUpdateTimer.TabIndex = 14
        Me.chk_EnableBrowerUpdateTimer.Text = "Enable"
        Me.chk_EnableBrowerUpdateTimer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 574)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Browser Update Interval (m):"
        '
        'tmr_BrowserUpdate
        '
        Me.tmr_BrowserUpdate.Interval = 60000
        '
        'RefreshBrowserToolStripMenuItem
        '
        Me.RefreshBrowserToolStripMenuItem.Name = "RefreshBrowserToolStripMenuItem"
        Me.RefreshBrowserToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RefreshBrowserToolStripMenuItem.Text = "&Refresh Browser"
        '
        'UpdateImageToolStripMenuItem
        '
        Me.UpdateImageToolStripMenuItem.Name = "UpdateImageToolStripMenuItem"
        Me.UpdateImageToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UpdateImageToolStripMenuItem.Text = "&Update Image"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 626)
        Me.Controls.Add(Me.chk_EnableBrowerUpdateTimer)
        Me.Controls.Add(Me.nud_BrowserUpdateInterval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_EnableImageTimer)
        Me.Controls.Add(Me.nud_ImageupdateInterval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_BrowseFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_SaveDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_url)
        Me.Controls.Add(Me.btn_Go)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "web2img"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nud_BrowserUpdateInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_ImageupdateInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btn_Go As Button
    Friend WithEvents txt_url As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_SaveDirectory As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_BrowseFile As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents nud_ImageupdateInterval As NumericUpDown
    Friend WithEvents chk_EnableImageTimer As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SnapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmr_ImageUpdate As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents chk_EnableBrowerUpdateTimer As CheckBox
    Friend WithEvents nud_BrowserUpdateInterval As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents tmr_BrowserUpdate As Timer
    Friend WithEvents RefreshBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateImageToolStripMenuItem As ToolStripMenuItem
End Class
