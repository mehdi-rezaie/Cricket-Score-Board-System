<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeam_Add
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.linkBrowse = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGroupsID = New System.Windows.Forms.ComboBox()
        Me.cmbGroups = New System.Windows.Forms.ComboBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.dtpCreateDate = New System.Windows.Forms.DateTimePicker()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOrgName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAbrivation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTeamID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClearTeam = New System.Windows.Forms.Button()
        Me.btnExitTeam = New System.Windows.Forms.Button()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox.SuspendLayout()
        Me.linkBrowse.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox.Controls.Add(Me.linkBrowse)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(802, 398)
        Me.GroupBox.TabIndex = 30
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Add Team Details"
        '
        'linkBrowse
        '
        Me.linkBrowse.BackColor = System.Drawing.Color.Gainsboro
        Me.linkBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.linkBrowse.Controls.Add(Me.Label3)
        Me.linkBrowse.Controls.Add(Me.cmbGroupsID)
        Me.linkBrowse.Controls.Add(Me.cmbGroups)
        Me.linkBrowse.Controls.Add(Me.txtStatus)
        Me.linkBrowse.Controls.Add(Me.dtpCreateDate)
        Me.linkBrowse.Controls.Add(Me.txtContactNo)
        Me.linkBrowse.Controls.Add(Me.Label17)
        Me.linkBrowse.Controls.Add(Me.Label8)
        Me.linkBrowse.Controls.Add(Me.Label11)
        Me.linkBrowse.Controls.Add(Me.txtOrgName)
        Me.linkBrowse.Controls.Add(Me.Label10)
        Me.linkBrowse.Controls.Add(Me.txtOwner)
        Me.linkBrowse.Controls.Add(Me.Label7)
        Me.linkBrowse.Controls.Add(Me.txtAbrivation)
        Me.linkBrowse.Controls.Add(Me.Label2)
        Me.linkBrowse.Controls.Add(Me.txtTeamName)
        Me.linkBrowse.Controls.Add(Me.Label1)
        Me.linkBrowse.Controls.Add(Me.txtTeamID)
        Me.linkBrowse.Controls.Add(Me.Label5)
        Me.linkBrowse.Controls.Add(Me.txtAddress)
        Me.linkBrowse.Controls.Add(Me.Label12)
        Me.linkBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkBrowse.Location = New System.Drawing.Point(13, 38)
        Me.linkBrowse.Name = "linkBrowse"
        Me.linkBrowse.Size = New System.Drawing.Size(768, 340)
        Me.linkBrowse.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Group:"
        '
        'cmbGroupsID
        '
        Me.cmbGroupsID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbGroupsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupsID.FormattingEnabled = True
        Me.cmbGroupsID.Location = New System.Drawing.Point(688, 14)
        Me.cmbGroupsID.MaxLength = 20
        Me.cmbGroupsID.Name = "cmbGroupsID"
        Me.cmbGroupsID.Size = New System.Drawing.Size(45, 24)
        Me.cmbGroupsID.TabIndex = 70
        Me.cmbGroupsID.Visible = False
        '
        'cmbGroups
        '
        Me.cmbGroups.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.Location = New System.Drawing.Point(553, 14)
        Me.cmbGroups.MaxLength = 20
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(129, 24)
        Me.cmbGroups.TabIndex = 69
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(378, 298)
        Me.txtStatus.MaxLength = 30
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(95, 22)
        Me.txtStatus.TabIndex = 44
        Me.txtStatus.Text = "In"
        '
        'dtpCreateDate
        '
        Me.dtpCreateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreateDate.Location = New System.Drawing.Point(138, 298)
        Me.dtpCreateDate.Name = "dtpCreateDate"
        Me.dtpCreateDate.Size = New System.Drawing.Size(132, 22)
        Me.dtpCreateDate.TabIndex = 18
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(497, 195)
        Me.txtContactNo.MaxLength = 12
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(181, 22)
        Me.txtContactNo.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(320, 300)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 18)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Contact No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Create Date:"
        '
        'txtOrgName
        '
        Me.txtOrgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgName.Location = New System.Drawing.Point(201, 161)
        Me.txtOrgName.MaxLength = 15
        Me.txtOrgName.Name = "txtOrgName"
        Me.txtOrgName.Size = New System.Drawing.Size(283, 22)
        Me.txtOrgName.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Team Organiser Name:"
        '
        'txtOwner
        '
        Me.txtOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwner.Location = New System.Drawing.Point(179, 127)
        Me.txtOwner.MaxLength = 15
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(283, 22)
        Me.txtOwner.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Team Owner Name:"
        '
        'txtAbrivation
        '
        Me.txtAbrivation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrivation.Location = New System.Drawing.Point(123, 89)
        Me.txtAbrivation.MaxLength = 15
        Me.txtAbrivation.Name = "txtAbrivation"
        Me.txtAbrivation.Size = New System.Drawing.Size(283, 22)
        Me.txtAbrivation.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Short Name:"
        '
        'txtTeamName
        '
        Me.txtTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamName.Location = New System.Drawing.Point(123, 52)
        Me.txtTeamName.MaxLength = 15
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(283, 22)
        Me.txtTeamName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Team ID:"
        '
        'txtTeamID
        '
        Me.txtTeamID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamID.Location = New System.Drawing.Point(123, 15)
        Me.txtTeamID.MaxLength = 10
        Me.txtTeamID.Name = "txtTeamID"
        Me.txtTeamID.Size = New System.Drawing.Size(140, 22)
        Me.txtTeamID.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Team Name:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(146, 196)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(231, 67)
        Me.txtAddress.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Team Address:"
        '
        'btnClearTeam
        '
        Me.btnClearTeam.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearTeam.Location = New System.Drawing.Point(338, 427)
        Me.btnClearTeam.Name = "btnClearTeam"
        Me.btnClearTeam.Size = New System.Drawing.Size(132, 38)
        Me.btnClearTeam.TabIndex = 34
        Me.btnClearTeam.Text = "Clear"
        Me.btnClearTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearTeam.UseVisualStyleBackColor = False
        '
        'btnExitTeam
        '
        Me.btnExitTeam.AutoSize = True
        Me.btnExitTeam.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExitTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExitTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExitTeam.Location = New System.Drawing.Point(476, 427)
        Me.btnExitTeam.Name = "btnExitTeam"
        Me.btnExitTeam.Size = New System.Drawing.Size(132, 38)
        Me.btnExitTeam.TabIndex = 35
        Me.btnExitTeam.Text = "Exit"
        Me.btnExitTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExitTeam.UseVisualStyleBackColor = False
        '
        'btnAddTeam
        '
        Me.btnAddTeam.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddTeam.Location = New System.Drawing.Point(200, 426)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(132, 38)
        Me.btnAddTeam.TabIndex = 33
        Me.btnAddTeam.Text = "Add"
        Me.btnAddTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddTeam.UseVisualStyleBackColor = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmTeam_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 476)
        Me.Controls.Add(Me.btnClearTeam)
        Me.Controls.Add(Me.btnExitTeam)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.btnAddTeam)
        Me.Name = "frmTeam_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Team"
        Me.GroupBox.ResumeLayout(False)
        Me.linkBrowse.ResumeLayout(False)
        Me.linkBrowse.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents linkBrowse As System.Windows.Forms.Panel
    Friend WithEvents txtAbrivation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTeamID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOrgName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClearTeam As System.Windows.Forms.Button
    Friend WithEvents btnExitTeam As System.Windows.Forms.Button
    Friend WithEvents btnAddTeam As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents cmbGroups As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupsID As System.Windows.Forms.ComboBox
End Class
