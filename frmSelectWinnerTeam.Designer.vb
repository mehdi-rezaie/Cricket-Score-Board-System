<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectWinnerTeam
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RbtnTeam2 = New System.Windows.Forms.RadioButton()
        Me.RbtnTeam1 = New System.Windows.Forms.RadioButton()
        Me.cmbTeam2_ID = New System.Windows.Forms.ComboBox()
        Me.cmbTeam1_ID = New System.Windows.Forms.ComboBox()
        Me.cmbTeam2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTeam1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSubmitWinTeam = New System.Windows.Forms.Button()
        Me.btnMatchDrawed = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.cmbTeam2_ID)
        Me.GroupBox1.Controls.Add(Me.cmbTeam1_ID)
        Me.GroupBox1.Controls.Add(Me.cmbTeam2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTeam1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(22, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 171)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Winning Team"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RbtnTeam2)
        Me.Panel5.Controls.Add(Me.RbtnTeam1)
        Me.Panel5.Location = New System.Drawing.Point(341, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(23, 83)
        Me.Panel5.TabIndex = 83
        '
        'RbtnTeam2
        '
        Me.RbtnTeam2.AutoSize = True
        Me.RbtnTeam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnTeam2.Location = New System.Drawing.Point(4, 63)
        Me.RbtnTeam2.Name = "RbtnTeam2"
        Me.RbtnTeam2.Size = New System.Drawing.Size(14, 13)
        Me.RbtnTeam2.TabIndex = 76
        Me.RbtnTeam2.TabStop = True
        Me.RbtnTeam2.UseVisualStyleBackColor = True
        '
        'RbtnTeam1
        '
        Me.RbtnTeam1.AutoSize = True
        Me.RbtnTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnTeam1.Location = New System.Drawing.Point(4, 4)
        Me.RbtnTeam1.Name = "RbtnTeam1"
        Me.RbtnTeam1.Size = New System.Drawing.Size(14, 13)
        Me.RbtnTeam1.TabIndex = 75
        Me.RbtnTeam1.TabStop = True
        Me.RbtnTeam1.UseVisualStyleBackColor = True
        '
        'cmbTeam2_ID
        '
        Me.cmbTeam2_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTeam2_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTeam2_ID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTeam2_ID.Enabled = False
        Me.cmbTeam2_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeam2_ID.FormattingEnabled = True
        Me.cmbTeam2_ID.Location = New System.Drawing.Point(370, 109)
        Me.cmbTeam2_ID.MaxLength = 20
        Me.cmbTeam2_ID.Name = "cmbTeam2_ID"
        Me.cmbTeam2_ID.Size = New System.Drawing.Size(56, 24)
        Me.cmbTeam2_ID.TabIndex = 71
        Me.cmbTeam2_ID.Visible = False
        '
        'cmbTeam1_ID
        '
        Me.cmbTeam1_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTeam1_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTeam1_ID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTeam1_ID.Enabled = False
        Me.cmbTeam1_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeam1_ID.FormattingEnabled = True
        Me.cmbTeam1_ID.Location = New System.Drawing.Point(370, 50)
        Me.cmbTeam1_ID.MaxLength = 20
        Me.cmbTeam1_ID.Name = "cmbTeam1_ID"
        Me.cmbTeam1_ID.Size = New System.Drawing.Size(56, 24)
        Me.cmbTeam1_ID.TabIndex = 70
        Me.cmbTeam1_ID.Visible = False
        '
        'cmbTeam2
        '
        Me.cmbTeam2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTeam2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTeam2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTeam2.Enabled = False
        Me.cmbTeam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeam2.FormattingEnabled = True
        Me.cmbTeam2.Location = New System.Drawing.Point(89, 108)
        Me.cmbTeam2.MaxLength = 20
        Me.cmbTeam2.Name = "cmbTeam2"
        Me.cmbTeam2.Size = New System.Drawing.Size(246, 24)
        Me.cmbTeam2.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Team 2:"
        '
        'cmbTeam1
        '
        Me.cmbTeam1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTeam1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTeam1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTeam1.Enabled = False
        Me.cmbTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeam1.FormattingEnabled = True
        Me.cmbTeam1.Location = New System.Drawing.Point(89, 50)
        Me.cmbTeam1.MaxLength = 20
        Me.cmbTeam1.Name = "cmbTeam1"
        Me.cmbTeam1.Size = New System.Drawing.Size(246, 24)
        Me.cmbTeam1.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Team 1:"
        '
        'btnSubmitWinTeam
        '
        Me.btnSubmitWinTeam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmitWinTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitWinTeam.Location = New System.Drawing.Point(70, 206)
        Me.btnSubmitWinTeam.Name = "btnSubmitWinTeam"
        Me.btnSubmitWinTeam.Size = New System.Drawing.Size(155, 45)
        Me.btnSubmitWinTeam.TabIndex = 72
        Me.btnSubmitWinTeam.Text = "Submit Winner"
        '
        'btnMatchDrawed
        '
        Me.btnMatchDrawed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMatchDrawed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatchDrawed.Location = New System.Drawing.Point(274, 206)
        Me.btnMatchDrawed.Name = "btnMatchDrawed"
        Me.btnMatchDrawed.Size = New System.Drawing.Size(155, 45)
        Me.btnMatchDrawed.TabIndex = 75
        Me.btnMatchDrawed.Text = "Match Drawed"
        '
        'frmSelectWinnerTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 263)
        Me.Controls.Add(Me.btnMatchDrawed)
        Me.Controls.Add(Me.btnSubmitWinTeam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSelectWinnerTeam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match Result"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmitWinTeam As System.Windows.Forms.Button
    Friend WithEvents cmbTeam2_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTeam1_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTeam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTeam1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RbtnTeam2 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnTeam1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMatchDrawed As System.Windows.Forms.Button
End Class
