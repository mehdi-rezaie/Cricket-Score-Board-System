Public Class scoreDisplayPanel
    Dim battingteam As String
    Dim bowlingteam As String
    Dim runs As String
    Dim wickets As String
    Dim overs As String
    Dim totalovers As String
    Dim runrate As String
    Dim batsman1 As String
    Dim batsman2 As String
    Dim target As String

    Private Sub scoreDisplayPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call frmScoreControlPanel.getBatsman1ShortName()
        'Call loadTeamShortNames()
        'Call loadTeamRuns()
        'Call loadTeamWickets()
        'Call loadOvers()
        'Call loadBatsman1()
        'Call loadBatsman2()
    End Sub

    'Private Sub loadTeamShortNames()
    '    battingteam = frmScoreControlPanel.getBattingTeamShortName
    '    bowlingteam = frmScoreControlPanel.getBowlingTeamShortName
    '    lblTNBat.Text = battingteam
    '    lblTNBowl.Text = bowlingteam
    'End Sub

    'Private Sub loadTeamRuns()
    '    runs = frmScoreControlPanel.txtRuns.Text
    '    lblRuns.Text = runs
    'End Sub

    'Private Sub loadTeamWickets()
    '    wickets = frmScoreControlPanel.NumericUpDown_Wickets.Text
    '    lblWickets.Text = wickets
    'End Sub

    'Private Sub loadOvers()
    '    overs = frmScoreControlPanel.txtOvers.Text
    '    lblOverCalc.Text = overs
    '    totalovers = frmScoreControlPanel.txtTotalOvers.Text
    '    lblTotOvers.Text = totalovers
    'End Sub

    'Private Sub loadRunRate()
    '    runrate = frmScoreControlPanel.txtRunRate.Text
    '    lblRunRate.Text = runrate
    'End Sub

    'Private Sub loadBatsman1()
    '    batsman1 = frmScoreControlPanel.getBatsman1ShortName
    '    lblBatsman1Score.Text = batsman1
    'End Sub

    'Private Sub loadBatsman2()
    '    batsman2 = frmScoreControlPanel.getBatsman2ShortName
    '    lblBatsman2Score.Text = batsman2
    'End Sub

End Class