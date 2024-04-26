<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCSSMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCSSMDI))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.btnScoreControlPanel = New System.Windows.Forms.Button()
        Me.btnAddPlayers = New System.Windows.Forms.Button()
        Me.btnAddTeams = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 675)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1354, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogin, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuLogin
        '
        Me.mnuLogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegisterNewUser, Me.ToolStripSeparator8, Me.mnuChangePassword, Me.ToolStripSeparator9, Me.mnuLogOut, Me.ToolStripSeparator10, Me.mnuExit})
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(49, 20)
        Me.mnuLogin.Text = "&Login"
        '
        'mnuRegisterNewUser
        '
        Me.mnuRegisterNewUser.Name = "mnuRegisterNewUser"
        Me.mnuRegisterNewUser.Size = New System.Drawing.Size(169, 22)
        Me.mnuRegisterNewUser.Text = "Register New User"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(166, 6)
        '
        'mnuChangePassword
        '
        Me.mnuChangePassword.Name = "mnuChangePassword"
        Me.mnuChangePassword.Size = New System.Drawing.Size(169, 22)
        Me.mnuChangePassword.Text = "Change Password"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(166, 6)
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(169, 22)
        Me.mnuLogOut.Text = "Log Out"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(166, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(169, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(29, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Logged in as"
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginName.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblLoginName.Location = New System.Drawing.Point(29, 82)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(61, 24)
        Me.lblLoginName.TabIndex = 13
        Me.lblLoginName.Text = "Label"
        '
        'btnScoreControlPanel
        '
        Me.btnScoreControlPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnScoreControlPanel.Location = New System.Drawing.Point(84, 159)
        Me.btnScoreControlPanel.Name = "btnScoreControlPanel"
        Me.btnScoreControlPanel.Size = New System.Drawing.Size(188, 56)
        Me.btnScoreControlPanel.TabIndex = 15
        Me.btnScoreControlPanel.Text = "New Match"
        Me.btnScoreControlPanel.UseVisualStyleBackColor = True
        '
        'btnAddPlayers
        '
        Me.btnAddPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPlayers.Location = New System.Drawing.Point(84, 259)
        Me.btnAddPlayers.Name = "btnAddPlayers"
        Me.btnAddPlayers.Size = New System.Drawing.Size(188, 56)
        Me.btnAddPlayers.TabIndex = 16
        Me.btnAddPlayers.Text = "Add Players"
        Me.btnAddPlayers.UseVisualStyleBackColor = True
        '
        'btnAddTeams
        '
        Me.btnAddTeams.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTeams.Location = New System.Drawing.Point(84, 359)
        Me.btnAddTeams.Name = "btnAddTeams"
        Me.btnAddTeams.Size = New System.Drawing.Size(188, 56)
        Me.btnAddTeams.TabIndex = 17
        Me.btnAddTeams.Text = "Add Teams"
        Me.btnAddTeams.UseVisualStyleBackColor = True
        '
        'frmCSSMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 697)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddTeams)
        Me.Controls.Add(Me.btnAddPlayers)
        Me.Controls.Add(Me.btnScoreControlPanel)
        Me.Controls.Add(Me.lblLoginName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmCSSMDI"
        Me.Text = "Cricket Scoreboard System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegisterNewUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
    Friend WithEvents mnuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnScoreControlPanel As System.Windows.Forms.Button
    Friend WithEvents btnAddPlayers As System.Windows.Forms.Button
    Friend WithEvents btnAddTeams As System.Windows.Forms.Button

End Class
