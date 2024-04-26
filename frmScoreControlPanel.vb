Public Class frmScoreControlPanel
    Dim overs As Double = 0.0
    Dim totalruns As Integer = 0
    Dim runrate As Double = 0.0
    Dim predictscore As Integer = 0
    Dim calruns As Double = 0.0
    Dim team1_ID As Integer
    Dim team2_ID As Integer
    Dim battingteam As String
    Dim bowlingteam As String
    Dim batsman1_shortName As String
    Dim batsman2_shortName As String
    Dim errmsg As String

    Dim totalRPO As Integer

    Private Sub displayStatsToScorePanel()
        'To display runs on scoreboard
        scoreDisplayPanel.lblRuns.Text = totalruns
        scoreDisplayPanel.lblWickets.Text = NumericUpDown_Wickets.Value
        scoreDisplayPanel.lblOverCalc.Text = txtOvers.Text
        scoreDisplayPanel.lblTotOvers.Text = txtTotalOvers.Text
        scoreDisplayPanel.lblRunRate.Text = txtRunRate.Text
        'scoreDisplayPanel.lblPredictedScore.Text = txtPredictScore.Text
        scoreDisplayPanel.lblTargetScore.Text = txtTargetScore.Text
        scoreDisplayPanel.Text = txtPopMsg.Text
        scoreDisplayPanel.lblBatsman1Runs.Text = txtBatsman1Runs.Text
        scoreDisplayPanel.lblBatsman2Runs.Text = txtBatsman2Runs.Text
        scoreDisplayPanel.lblBatsman1PlayedBalls.Text = txtBatsman1BallsPlayed.Text
        scoreDisplayPanel.lblBatsman2PlayedBalls.Text = txtBatsman2BallsPlayed.Text
    End Sub

    Private Sub displayTeamPlayerNameDetailsToScorePanel()
        Call setOnStrickBatsman()
        Call setBowlingTeamShortNameInning1()
        Call setBattingTeamShortNameInning1()
    End Sub

    Private Sub frmScoreControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Hide()
        'dialogTeamSelect.ShowDialog()
        'dialogTeamSelect.TopMost = True
        Call incrMatchID()
        Call initialisationLoad()
        If lblInnings.Text = "1st Innings" Then
            Call setBattingTeamShortNameInning1()
            Call setBowlingTeamShortNameInning1()
        Else
            Call setBattingTeamShortNameInning2()
            Call setBowlingTeamShortNameInning2()
        End If
        btnProceedToNextInnings.Enabled = True
        btnEndMatch.Enabled = False
    End Sub

    Private Sub cmbTeam1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1.SelectedIndexChanged
        If cmbTeam1.SelectedItem = cmbTeam2.SelectedItem Then
            MessageBox.Show("Cannot have same team on both sides!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbTeam1.SelectedIndex = -1
            cmbTeam1.Text = ""
        End If
        Call loadTeam1PlayersList()
        cmbTeam1_ID.SelectedIndex = cmbTeam1.SelectedIndex
    End Sub

    Private Sub cmbTeam2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2.SelectedIndexChanged
        If cmbTeam2.SelectedItem = cmbTeam1.SelectedItem Then
            MessageBox.Show("Cannot have same team on both sides!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbTeam2.SelectedIndex = -1
            cmbTeam2.Text = ""
        End If
        Call loadTeam2PlayersList()
        cmbTeam2_ID.SelectedIndex = cmbTeam2.SelectedIndex
    End Sub


    Private Sub txtRuns_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuns.TextChanged
        totalruns = Val(txtRuns.Text)
        overs = Val(txtOvers.Text)
        runrate = Val(totalruns / overs)
        txtRunRate.Text = Math.Round(runrate, 2)

        'To calculate predicted score
        calruns = (Val(txtTotalOvers.Text) - Val(txtOvers.Text)) * Val(txtRunRate.Text)
        predictscore = Val(txtRuns.Text) + Val(calruns)
        txtPredictScore.Text = predictscore

    End Sub


    Private Sub txtOvers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOvers.TextChanged
        totalruns = Val(txtRuns.Text)
        overs = Val(txtOvers.Text)
        runrate = Val(totalruns / overs)
        txtRunRate.Text = Math.Round(runrate, 2)

        'To calculate predicted score
        calruns = (Val(txtTotalOvers.Text) - Val(txtOvers.Text)) * Val(txtRunRate.Text)
        predictscore = Val(txtRuns.Text) + Val(calruns)
        txtPredictScore.Text = predictscore

        If txtOvers.Text = txtTotalOvers.Text Then
            MessageBox.Show("All overs have been played, You can proceed to next innings!", "Match Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub loadnextInnings()
        cmbBatsman1.Items.Clear()
        cmbBatsman1.Text = ""
        cmbBatsman2.Items.Clear()
        cmbBatsman2.Text = ""
        cmbBowlerName.Items.Clear()
        cmbBowlerName.Text = ""
        cmbBatsman1_ID.Items.Clear()
        cmbBatsman2_ID.Items.Clear()
        cmbBowler_ID.Items.Clear()
        'txtMatchID.Text = (Val(txtMatchID.Text) - 1)
        txtTargetScore.Enabled = True
        txtTargetScore.Text = txtRuns.Text
        lblInnings.Text = "2nd Innings"
        btnProceedToNextInnings.Enabled = False
        btnEndMatch.Enabled = True

        Dim y As Integer
        Dim max As Integer

        If RBtnTeam1.Checked = True And RBtnBatFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = True And RBtnFieldFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = False And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = True And RBtnBatFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = True And RBtnFieldFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = False And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If
    End Sub


    Private Sub incrMatchID()
        Dim x As Integer
        Dim max As Integer

        sqlstr = "Select * from QuickTournament"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = (max / 2 + 1)
        End If
        txtMatchID.Text = x
        txtMatchID.Enabled = False
    End Sub

    Private Sub initialisationLoad()
        txtRPO1.Text = 0
        txtRPO2.Text = 0
        txtRPO3.Text = 0
        txtRPO4.Text = 0
        txtRPO5.Text = 0
        txtRPO6.Text = 0
        If txtTotalOvers.Text = "" Then
            txtOvers.Enabled = False
        Else
            txtOvers.Enabled = True
        End If

        txtTargetScore.Enabled = False
        scoreDisplayPanel.panelTarget.Visible = False
        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT ID, Teams.Team_Name FROM Teams"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbTeam1_ID.Items.Add(dt.Rows(y).Item(0))
            cmbTeam1.Items.Add(dt.Rows(y).Item(1))
            cmbTeam2_ID.Items.Add(dt.Rows(y).Item(0))
            cmbTeam2.Items.Add(dt.Rows(y).Item(1))
        Next

        Try
            Dim dt1 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbTeam1.AutoCompleteCustomSource.Clear()
            cmbTeam2.AutoCompleteCustomSource.Clear()

            For Each r In dt1.Rows
                cmbTeam1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbTeam2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub loadBatsmansAndBowlers_cmb()
        cmbBatsman1.Items.Clear()
        cmbBatsman1.Text = ""
        cmbBatsman2.Items.Clear()
        cmbBatsman2.Text = ""
        cmbBowlerName.Items.Clear()
        cmbBowlerName.Text = ""
        cmbBatsman1_ID.Items.Clear()
        cmbBatsman2_ID.Items.Clear()
        cmbBowler_ID.Items.Clear()
        Dim y As Integer
        Dim max As Integer

        If RBtnTeam1.Checked = True And RBtnBatFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = True And RBtnFieldFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = False And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = True And RBtnBatFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam2.Checked = True And RBtnFieldFirst.Checked = True Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBowler_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBowlerName.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBowlerName.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBowlerName.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If

        If RBtnTeam1.Checked = False And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT DISTINCT Players.ID, Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            max = dt.Rows.Count
            For y = 0 To max - 1
                cmbBatsman1_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman1.Items.Add(dt.Rows(y).Item(1))
                cmbBatsman2_ID.Items.Add(dt.Rows(y).Item(0))
                cmbBatsman2.Items.Add(dt.Rows(y).Item(1))
            Next
            cmbBatsman1.AutoCompleteCustomSource.Clear()
            cmbBatsman2.AutoCompleteCustomSource.Clear()

            For Each r In dt.Rows
                cmbBatsman1.AutoCompleteCustomSource.Add(r.Item(1).ToString)
                cmbBatsman2.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        End If
        
    End Sub


    'To load team1 players in the listboxes
    Private Sub loadTeam1PlayersList()
        listBoxTeamPlayers1.Items.Clear()
        sqlstr = "SELECT DISTINCT Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & String.Format(cmbTeam1_ID.Text)
        Dim dt As DataTable = getDataTable(sqlstr)
        For Each r In dt.Rows
            listBoxTeamPlayers1.Items.Add(r.Item(0).ToString)
        Next
    End Sub

    'To load team2 players in the listboxes
    Private Sub loadTeam2PlayersList()
        listBoxTeamPlayers2.Items.Clear()
        sqlstr = "SELECT DISTINCT Players.Player_Name FROM Players, Teams WHERE Teams.ID=Players.Team_ID AND Teams.ID = " & String.Format(cmbTeam2_ID.Text)
        Dim dt1 As DataTable = getDataTable(sqlstr)
        For Each r In dt1.Rows
            listBoxTeamPlayers2.Items.Add(r.Item(0).ToString)
        Next
    End Sub


    'Private Sub NumericUpDown_Overs_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim overs As Double = 0
    '    Dim balls As Double = 0.6
    '    If NumericUpDown_Overs.Value >= Val(overs + balls) Then
    '        NumericUpDown_Overs.Increment = 1
    '        overs = NumericUpDown_Overs.Increment
    '        NumericUpDown_Overs.Value = overs
    '        balls = 0.0
    '    ElseIf overs > 1 Then
    '        balls = 0.6
    '    End If

    '    'While NumericUpDown_Overs.Value >= 0.6
    '    '    NumericUpDown_Overs.Increment = 1
    '    'End While

    'End Sub

    Private Sub RBtnTeam1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnTeam1.CheckedChanged
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnTeam2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnTeam2.CheckedChanged
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnBatFirst_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnBatFirst.CheckedChanged
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnFieldFirst_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnFieldFirst.CheckedChanged
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnTeam1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnTeam1.Click
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnBatFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnBatFirst.Click
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnTeam2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnTeam2.Click
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub RBtnFieldFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnFieldFirst.Click
        Call loadBatsmansAndBowlers_cmb()
    End Sub

    Private Sub cmbTeam1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1.TextChanged
        cmbTeam1_ID.SelectedIndex = -1
        'Call loadTeamPlayersList()
    End Sub

    Private Sub cmbTeam2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2.TextChanged
        cmbTeam2_ID.SelectedIndex = -1
    End Sub

    Private Sub cmbBatsman1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatsman1.TextChanged
        If cmbBatsman1.Text = "" Then
            cmbBatsman1.Text = ""
        End If
        cmbBatsman1_ID.SelectedIndex = -1
    End Sub

    Private Sub cmbBatsman2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatsman2.TextChanged
        If cmbBatsman2.Text = "" Then
            cmbBatsman2.Text = ""
        End If
        cmbBatsman2_ID.SelectedIndex = -1
    End Sub

    Private Sub cmbBowlerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBowlerName.TextChanged
        If cmbBowlerName.Text = "" Then
            cmbBowlerName.Text = ""
        End If
        cmbBowler_ID.SelectedIndex = -1
    End Sub


    'For batsman and bowlers comboboxes
    Private Sub cmbBatsman1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatsman1.SelectedIndexChanged
        If cmbBatsman1.SelectedItem = cmbBatsman2.SelectedItem Then
            MessageBox.Show("Cannot have same players!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbBatsman1.SelectedIndex = -1
            cmbBatsman1.Text = ""
        End If

        cmbBatsman1_ID.SelectedIndex = cmbBatsman1.SelectedIndex

    End Sub

    Private Sub cmbBatsman2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatsman2.SelectedIndexChanged
        If cmbBatsman2.SelectedItem = cmbBatsman1.SelectedItem Then
            MessageBox.Show("Cannot have same players!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbBatsman2.SelectedIndex = -1
            cmbBatsman2.Text = ""
        End If
        cmbBatsman2_ID.SelectedIndex = cmbBatsman2.SelectedIndex
    End Sub


    'For setting Batting team name in first inning
    Public Sub setBattingTeamShortNameInning1()

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If
        scoreDisplayPanel.lblTNBat.Text = battingteam
    End Sub


    'For setting Batting team name in second inning
    Public Sub setBattingTeamShortNameInning2()

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            battingteam = dt.Rows(0).Item(1)
        End If
        scoreDisplayPanel.lblTNBat.Text = battingteam
    End Sub



    Public Sub setBowlingTeamShortNameInning1()

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If
        scoreDisplayPanel.lblTNBowl.Text = bowlingteam
    End Sub


    Public Sub setBowlingTeamShortNameInning2()

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If

        If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            bowlingteam = dt.Rows(0).Item(1)
        End If
        scoreDisplayPanel.lblTNBowl.Text = bowlingteam
    End Sub


    Public Sub setBatsman1ShortName()
        If Not cmbBatsman1_ID.Text = "" Then
            Dim batsman1_shortName As String
            sqlstr = "SELECT Pet_Name FROM Players WHERE ID =" & cmbBatsman1_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            batsman1_shortName = dt.Rows(0).Item(0)
            scoreDisplayPanel.Labe54.Text = batsman1_shortName
        Else
            MessageBox.Show("Select batsman 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub setBatsman2ShortName()
        Try
            Dim batsman2_shortName As String
            sqlstr = "SELECT Pet_Name FROM Players WHERE ID =" & cmbBatsman2_ID.Text
            Dim dt As DataTable = getDataTable(sqlstr)
            batsman2_shortName = dt.Rows(0).Item(0)
            scoreDisplayPanel.Label45.Text = batsman2_shortName
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Public Sub setBowlerShortName()
        Dim bowler_shortName As String
        sqlstr = "SELECT Pet_Name FROM Players WHERE ID =" & cmbBowler_ID.Text
        Dim dt As DataTable = getDataTable(sqlstr)
        bowler_shortName = dt.Rows(0).Item(0)
        scoreDisplayPanel.lblBowler.Text = bowler_shortName
    End Sub

    'Public Sub setBattingTeamRuns()
    '    scoreDisplayPanel.lblRuns.Text = txtRuns.Text
    'End Sub

    'Public Sub setBattingTeamWickets()
    '    scoreDisplayPanel.lblWickets.Text = NumericUpDown_Wickets.Text
    'End Sub

    'Public Sub setOvers()
    '    scoreDisplayPanel.lblOverCalc.Text = txtOvers.Text
    'End Sub

    'Public Sub setTotalOvers()
    '    scoreDisplayPanel.lblTotOvers.Text = txtTotalOvers.Text
    'End Sub

    'Public Sub setRunRate()
    '    scoreDisplayPanel.lblRunRate.Text = txtRunRate.Text
    'End Sub

    'Public Sub setBatsmansRuns()
    '    scoreDisplayPanel.lblBatsman1Runs.Text = txtBatsman1Runs.Text
    '    scoreDisplayPanel.lblBatsman2Runs.Text = txtBatsman2Runs.Text
    'End Sub

    'Public Sub setTeamTarget()
    '    scoreDisplayPanel.lblTargetScore.Text = txtTargetScore.Text
    'End Sub



    'To get teams and player IDs
    'Public Function getBattingTeamShortName() As String

    '    If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        battingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        battingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        battingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        battingteam = dt.Rows(0).Item(1)
    '    End If
    '    Return battingteam
    'End Function


    'Public Function getBowlingTeamShortName() As String

    '    If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        bowlingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam2_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        bowlingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False And RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        bowlingteam = dt.Rows(0).Item(1)
    '    End If

    '    If RBtnTeam2.Checked = True And RBtnTeam1.Checked = False And RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
    '        sqlstr = "SELECT ID, Team_Info FROM Teams WHERE ID =" & cmbTeam1_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        bowlingteam = dt.Rows(0).Item(1)
    '    End If
    '    Return bowlingteam
    'End Function


    'Public Function getBatsman1ShortName() As String
    '    If Not cmbBatsman1_ID.Text = "" Then
    '        Dim batsman1_shortName As String
    '        sqlstr = "SELECT Pet_Name FROM Players WHERE ID =" & cmbBatsman1_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        batsman1_shortName = dt.Rows(0).Item(0)
    '    Else
    '        MessageBox.Show("Select batsman 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    '    Return batsman1_shortName
    'End Function


    'Public Function getBatsman2ShortName() As String
    '    If Not cmbBatsman2_ID.Text = "" Then
    '        Dim batsman2_shortName As String
    '        sqlstr = "SELECT Pet_Name FROM Players WHERE ID =" & cmbBatsman2_ID.Text
    '        Dim dt As DataTable = getDataTable(sqlstr)
    '        batsman2_shortName = dt.Rows(0).Item(0)
    '    Else
    '        MessageBox.Show("Select batsman 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    '    Return batsman2_shortName
    'End Function

    Private Sub cmbBowlerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBowlerName.SelectedIndexChanged
        cmbBowler_ID.SelectedIndex = cmbBowlerName.SelectedIndex
    End Sub

    Private Sub cmbTeam1_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1_ID.TextChanged
        Call loadTeam1PlayersList()
    End Sub

    Private Sub cmbTeam2_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2_ID.TextChanged
        Call loadTeam2PlayersList()
    End Sub

    Private Sub NumericUpDown_Wickets_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Wickets.ValueChanged
        If NumericUpDown_Wickets.Value = 10 Then
            MessageBox.Show("All wickets have been fallen, You can proceed to next innings!", "Match Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnShowScoreBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowScoreBoard.Click
        'If cmbBatsman1_ID.Text = "" Or cmbBatsman2_ID.Text = "" Or cmbBowler_ID.Text = "" Then
        '    MessageBox.Show("Select batsmans and bowlers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        Call setScorePanelOnSecondaryScreen()
        'End If
    End Sub

    Private Sub btnHideScoreBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideScoreBoard.Click
        'If cmbBatsman1_ID.Text = "" Or cmbBatsman2_ID.Text = "" Or cmbBowler_ID.Text = "" Then
        '    MessageBox.Show("Select batsmans and bowlers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        scoreDisplayPanel.Hide()
        'End If
    End Sub

    Private Sub btnShowScoreOnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowScoreOnMain.Click
        Call setScorePanelOnMainScreen()
    End Sub


    Private Sub setScorePanelOnSecondaryScreen()
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(1)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)

            scoreDisplayPanel.StartPosition = FormStartPosition.Manual
            'scoreDisplayPanel.Width = totalWidth - (totalWidth * 20 / 100)
            scoreDisplayPanel.Size = New System.Drawing.Size(totalWidth, scoreDisplayPanel.Size.Height)
            scoreDisplayPanel.Location = screen.Bounds.Location + New Point(0, totalHeight - 50)
            scoreDisplayPanel.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try
       
    End Sub


    Private Sub setScorePanelOnMainScreen()
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(0)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(0).Bounds.Width
            totalHeight = screen.AllScreens(0).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)

            scoreDisplayPanel.StartPosition = FormStartPosition.Manual
            scoreDisplayPanel.Width = totalWidth - (totalWidth * 20 / 100)
            scoreDisplayPanel.Size = New System.Drawing.Size(totalWidth, scoreDisplayPanel.Size.Height)
            scoreDisplayPanel.Location = screen.Bounds.Location + New Point(0, totalHeight - 50)
            scoreDisplayPanel.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'For points table
    'Private Sub setPointsTableOnSecondaryScreen()
    '    Try
    '        Dim totalWidth As Integer
    '        Dim totalHeight As Integer
    '        Dim screen As Screen
    '        screen = screen.AllScreens(1)
    '        'To get screen dimensions
    '        'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

    '        totalWidth = screen.AllScreens(1).Bounds.Width
    '        totalHeight = screen.AllScreens(1).Bounds.Height
    '        'Show the form on second screen
    '        'MsgBox(screen.AllScreens(0).Bounds.ToString)
    '        'MsgBox(totalWidth)
    '        'MsgBox(totalHeight)
    '        pointspanel.Show()
    '    Catch ex As Exception
    '        MsgBox("Error: Check if the secondary screen is connected")
    '    End Try

    'End Sub


    Private Sub setPointsTableOnMainScreen()
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(0)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(0).Bounds.Width
            totalHeight = screen.AllScreens(0).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)
            pointspanelEdit.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub txtTotalOvers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalOvers.TextChanged
        If Not txtTotalOvers.Text = "" Or txtTotalOvers.Text = "0" Then
            txtOvers.Enabled = True
        Else
            txtOvers.Enabled = False
        End If
    End Sub


    Private Sub setOnStrickBatsman()
        If RbtnOnStrikeBat1.Checked = True And RbtnOnStrikeBat2.Checked = False Then
            scoreDisplayPanel.lblOnstrike1.Text = "*"
            scoreDisplayPanel.lblOnstrike2.Text = ""
        ElseIf RbtnOnStrikeBat2.Checked = True And RbtnOnStrikeBat1.Checked = False Then
            scoreDisplayPanel.lblOnstrike2.Text = "*"
            scoreDisplayPanel.lblOnstrike1.Text = ""
        Else
            scoreDisplayPanel.lblOnstrike2.Text = ""
            scoreDisplayPanel.lblOnstrike1.Text = ""
        End If
    End Sub


    Public Function chkData() As Boolean
        errmsg = ""
        If txtOvers.Text <> txtTotalOvers.Text And NumericUpDown_Wickets.Value < 10 Then
            errmsg = errmsg & "The Match should be completed to proceed to next innings!"
            chkData = True
        Else
            chkData = False
        End If
    End Function


    Private Sub insertMatchDetailsAndProceed()
        If chkData() = True Then
            MsgBox("Error:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub

        ElseIf chkData() = False And saveProceedDialog() = True Then
            Dim cmd As New OleDb.OleDbCommand
            Dim cmd1 As New OleDb.OleDbCommand
            Try
                cmd.CommandText = "INSERT INTO QuickTournament(Match_ID,Team_ID)VALUES(@Match_ID,@Team_ID)"
                'cmd.Parameters.AddWithValue("@ID", Val(txtMatchID.Text))
                cmd.Parameters.AddWithValue("@Match_ID", Val(txtMatchID.Text))
                cmd.Parameters.AddWithValue("@Team_ID", Val(cmbTeam1_ID.Text))

                cmd1.CommandText = "INSERT INTO QuickTournament(Match_ID,Team_ID)VALUES(@Match_ID,@Team_ID)"
                'cmd.Parameters.AddWithValue("@ID", Val(txtMatchID.Text))
                cmd1.Parameters.AddWithValue("@Match_ID", Val(txtMatchID.Text))
                cmd1.Parameters.AddWithValue("@Team_ID", Val(cmbTeam2_ID.Text))

                cmd.Connection = makeConnection()
                cmd1.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()
                Dim res1 As Integer = cmd1.ExecuteNonQuery()
                If res > 0 And res1 > 0 Then
                    MessageBox.Show("Inning Registered Successfully", "Alert!")
                    Call loadnextInnings()
                    Call setBattingTeamShortNameInning2()
                    Call setBowlingTeamShortNameInning2()
                    Call clearAll()
                    'Call updatePatientRegInfo()
                    'Call ClearAll()
                    'Call incrDiagTest()
                Else
                    MessageBox.Show("Failed to Register Successfully!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected! " + ex.Message)
            End Try
            cmd.Dispose()
            cmd1.Dispose()
        End If
    End Sub

    Private Sub btnProceedToNextInnings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceedToNextInnings.Click
        Call insertMatchDetailsAndProceed()
        Call clearScorePanel()
    End Sub

    Private Sub btnEndMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndMatch.Click
        frmSelectWinnerTeam.ShowDialog()
    End Sub

    Private Sub clearAll()
        txtRuns.Clear()
        NumericUpDown_Wickets.Value = 0
        txtOvers.Text = "0.0"
        txtTotalOvers.Text = ""
        txtRunRate.Clear()
        'NumericUpDown_Extras.Value = 0
        txtPredictScore.Text = ""
        txtPopMsg.Clear()
        txtBatsman1Runs.Clear()
        txtBatsman2Runs.Clear()
        cmbBatsman1.Text = ""
        cmbBatsman1_ID.SelectedIndex = -1
        cmbBatsman2.Text = ""
        cmbBatsman2_ID.SelectedIndex = -1
        cmbBowlerName.Text = ""
        cmbBowler_ID.SelectedIndex = -1
        txtRPO1.Text = 0
        txtRPO2.Text = 0
        txtRPO3.Text = 0
        txtRPO4.Text = 0
        txtRPO5.Text = 0
        txtRPO6.Text = 0
    End Sub

    Private Sub clearScorePanel()
        scoreDisplayPanel.lblRuns.Text = "0"
        scoreDisplayPanel.lblWickets.Text = "0"
        scoreDisplayPanel.lblOverCalc.Text = "0.0"
        scoreDisplayPanel.lblRunRate.Text = "0.0"
        scoreDisplayPanel.lblBatsman1Runs.Text = "-"
        scoreDisplayPanel.lblBatsman1PlayedBalls.Text = "-"
        scoreDisplayPanel.lblBatsman2Runs.Text = "-"
        scoreDisplayPanel.lblBatsman2PlayedBalls.Text = "-"
    End Sub

    Private Sub btnShowPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPoints.Click
        Call setPointsTableOnMainScreen()
    End Sub


    'Private Sub btnShowPointsOnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call setPointsTableOnMainScreen()
    'End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If exitForm() = True Then
            con.Close()
            con.Dispose()
            dialogTossSelect.Dispose()
            dialogTeamSelect.Dispose()
            scoreDisplayPanel.Dispose()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub RbtnShowRPO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnShowRPO.CheckedChanged
        scoreDisplayPanel.panelBowler.Hide()
        scoreDisplayPanel.panelRPO.Show()
    End Sub

    Private Sub RbtnHideRPO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnHideRPO.CheckedChanged
        scoreDisplayPanel.panelBowler.Show()
        scoreDisplayPanel.panelRPO.Hide()
    End Sub


    Private Sub btnEndOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndOver.Click
        txtRPO1.Text = 0
        txtRPO2.Text = 0
        txtRPO3.Text = 0
        txtRPO4.Text = 0
        txtRPO5.Text = 0
        txtRPO6.Text = 0
        scoreDisplayPanel.lblball1.Text = "-"
        scoreDisplayPanel.lblball2.Text = "-"
        scoreDisplayPanel.lblball3.Text = "-"
        scoreDisplayPanel.lblball4.Text = "-"
        scoreDisplayPanel.lblball5.Text = "-"
        scoreDisplayPanel.lblball6.Text = "-"
    End Sub

    Private Sub txtRPO1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO1.TextChanged

        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO1.Text)
        If txtRPO1.Text = "W" Or txtRPO1.Text = "C" Or txtRPO1.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtRPO2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO2.TextChanged
        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO2.Text)
        If txtRPO2.Text = "W" Or txtRPO2.Text = "C" Or txtRPO2.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtRPO3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO3.TextChanged
        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO3.Text)
        If txtRPO3.Text = "W" Or txtRPO3.Text = "C" Or txtRPO3.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtRPO4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO4.TextChanged
        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO4.Text)
        If txtRPO4.Text = "W" Or txtRPO4.Text = "C" Or txtRPO4.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtRPO5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO5.TextChanged
        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO5.Text)
        If txtRPO5.Text = "W" Or txtRPO5.Text = "C" Or txtRPO5.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtRPO6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRPO6.TextChanged
        txtRuns.Text = Val(txtRuns.Text) + Val(txtRPO6.Text)
        If txtRPO6.Text = "W" Or txtRPO6.Text = "C" Or txtRPO6.Text = "R" Then
            NumericUpDown_Wickets.Value = NumericUpDown_Wickets.Value + 1
        End If
    End Sub

    Private Sub txtBatsman1BallsPlayed_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatsman1BallsPlayed.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
            Call displayTeamPlayerNameDetailsToScorePanel()
        End If
    End Sub

    Private Sub txtBatsman2BallsPlayed_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatsman2BallsPlayed.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
            Call displayTeamPlayerNameDetailsToScorePanel()
        End If
    End Sub

    Private Sub txtRPO1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO1.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball1.Text = txtRPO1.Text
        End If
    End Sub

    Private Sub txtRPO2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO2.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball2.Text = txtRPO2.Text
        End If
    End Sub

    Private Sub txtRPO3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO3.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball3.Text = txtRPO3.Text
        End If
    End Sub

    Private Sub txtRPO4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO4.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball4.Text = txtRPO4.Text
        End If
    End Sub

    Private Sub txtRPO5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO5.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball5.Text = txtRPO5.Text
        End If
    End Sub

    Private Sub txtRPO6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRPO6.KeyDown
        If e.KeyCode = Keys.Enter Then
            scoreDisplayPanel.lblball6.Text = txtRPO6.Text
        End If
    End Sub

    Private Sub btnDisplayFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFour.Click
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(1)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)
            splashFourRuns.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try
    End Sub

    Private Sub btnDisplaySix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplaySix.Click
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(1)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)
            splashSixRuns.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try
    End Sub

    Private Sub btnDisplayOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayOut.Click
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(1)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)
            splashOut.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try

    End Sub

    Private Sub btnDisplayNotOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayNotOut.Click
        Try
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            Dim screen As Screen
            screen = screen.AllScreens(1)
            'To get screen dimensions
            'scoreDisplayPanel.Bounds = screen.AllScreens(1).Bounds

            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            'Show the form on second screen
            'MsgBox(screen.AllScreens(0).Bounds.ToString)
            'MsgBox(totalWidth)
            'MsgBox(totalHeight)
            splashNotOut.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try

    End Sub


    'To display values in every control on scoreboard
    Private Sub txtRuns_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuns.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub NumericUpDown_Wickets_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDown_Wickets.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub txtOvers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOvers.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub txtTotalOvers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalOvers.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub txtRunRate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRunRate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub txtPredictScore_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPredictScore.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub txtPopMsg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPopMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
        End If
    End Sub

    Private Sub cmbBatsman1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBatsman1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbBatsman1_ID.Text = "" Then
                MessageBox.Show("Enter Batsmans 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call setBatsman1ShortName()
                'Call displayTeamPlayerNameDetailsToScorePanel()
            End If
        End If
    End Sub

    Private Sub cmbBatsman2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBatsman2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbBatsman2_ID.Text = "" Then
                MessageBox.Show("Enter Batsmans 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call setBatsman2ShortName()
                'Call displayTeamPlayerNameDetailsToScorePanel()
            End If
        End If
    End Sub

    Private Sub cmbBowlerName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBowlerName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbBowler_ID.Text = "" Then
                MessageBox.Show("Enter Bowler!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call setBowlerShortName()
                'Call displayTeamPlayerNameDetailsToScorePanel()
            End If
        End If
    End Sub

    Private Sub txtBatsman1Runs_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatsman1Runs.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
            'Call displayTeamPlayerNameDetailsToScorePanel()
        End If
    End Sub

    Private Sub txtBatsman2Runs_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatsman2Runs.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call displayStatsToScorePanel()
            'Call displayTeamPlayerNameDetailsToScorePanel()
        End If
    End Sub

    Private Sub RbtnOnStrikeBat1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnOnStrikeBat1.CheckedChanged
        Call setOnStrickBatsman()
    End Sub

    Private Sub RbtnOnStrikeBat2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnOnStrikeBat2.CheckedChanged
        Call setOnStrickBatsman()
    End Sub
End Class