<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pointspanel
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
        Me.gbscoreboard = New System.Windows.Forms.GroupBox()
        Me.lblNetRunRate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblDraw = New System.Windows.Forms.Label()
        Me.lblLose = New System.Windows.Forms.Label()
        Me.lblWon = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.gbscoreboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbscoreboard
        '
        Me.gbscoreboard.Controls.Add(Me.lblNetRunRate)
        Me.gbscoreboard.Controls.Add(Me.Label1)
        Me.gbscoreboard.Controls.Add(Me.lblPoints)
        Me.gbscoreboard.Controls.Add(Me.lblDraw)
        Me.gbscoreboard.Controls.Add(Me.lblLose)
        Me.gbscoreboard.Controls.Add(Me.lblWon)
        Me.gbscoreboard.Controls.Add(Me.lblTeamName)
        Me.gbscoreboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbscoreboard.Location = New System.Drawing.Point(12, 4)
        Me.gbscoreboard.Name = "gbscoreboard"
        Me.gbscoreboard.Size = New System.Drawing.Size(802, 72)
        Me.gbscoreboard.TabIndex = 0
        Me.gbscoreboard.TabStop = False
        Me.gbscoreboard.Text = "Team Standings"
        '
        'lblNetRunRate
        '
        Me.lblNetRunRate.AutoSize = True
        Me.lblNetRunRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetRunRate.Location = New System.Drawing.Point(670, 36)
        Me.lblNetRunRate.Name = "lblNetRunRate"
        Me.lblNetRunRate.Size = New System.Drawing.Size(114, 20)
        Me.lblNetRunRate.TabIndex = 16
        Me.lblNetRunRate.Text = "Net RunRate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Match Played"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(587, 36)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(59, 20)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Points"
        '
        'lblDraw
        '
        Me.lblDraw.AutoSize = True
        Me.lblDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraw.Location = New System.Drawing.Point(332, 36)
        Me.lblDraw.Name = "lblDraw"
        Me.lblDraw.Size = New System.Drawing.Size(63, 20)
        Me.lblDraw.TabIndex = 3
        Me.lblDraw.Text = "DRAW"
        '
        'lblLose
        '
        Me.lblLose.AutoSize = True
        Me.lblLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose.Location = New System.Drawing.Point(253, 36)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(56, 20)
        Me.lblLose.TabIndex = 2
        Me.lblLose.Text = "LOSE"
        '
        'lblWon
        '
        Me.lblWon.AutoSize = True
        Me.lblWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWon.Location = New System.Drawing.Point(178, 36)
        Me.lblWon.Name = "lblWon"
        Me.lblWon.Size = New System.Drawing.Size(50, 20)
        Me.lblWon.TabIndex = 1
        Me.lblWon.Text = "WON"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(24, 36)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(124, 20)
        Me.lblTeamName.TabIndex = 0
        Me.lblTeamName.Text = "TEAMS NAME"
        '
        'pointspanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbscoreboard)
        Me.Name = "pointspanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.gbscoreboard.ResumeLayout(False)
        Me.gbscoreboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbscoreboard As System.Windows.Forms.GroupBox
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents lblDraw As System.Windows.Forms.Label
    Friend WithEvents lblLose As System.Windows.Forms.Label
    Friend WithEvents lblWon As System.Windows.Forms.Label
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNetRunRate As System.Windows.Forms.Label
End Class
