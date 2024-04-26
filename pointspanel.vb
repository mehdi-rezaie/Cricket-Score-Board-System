Imports System.Data.OleDb

Public Class pointspanel

    Private Sub pointspanel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub


    'Private Sub initialisationLoad()

    '    Dim max, max1, y, y1, y2 As Integer

    '    sqlstr = "Select * from Teams"
    '    Dim dt As DataTable = getDataTable(sqlstr)
    '    max = dt.Rows.Count
    '    y = 72
    '    y1 = 72
    '    y2 = y1 + 32

    '    Dim intLoopIndex As Integer
    '    For intLoopIndex = 1 To max

    '        If intLoopIndex <> 1 Then
    '            y += 30
    '            Dim lbTeam As New Label
    '            lbTeam.Name = "lblTeam" + intLoopIndex.ToString
    '            lbTeam.Font = New Font("Microsoft Sans Serif", 12)
    '            lbTeam.Size = New Point(170, 30)
    '            lbTeam.Location = New Point(6, y)
    '            Me.gbscoreboard.Controls.Add(lbTeam)
    '            lbTeam.Text = dt.Rows(intLoopIndex - 1).Item(1)

    '            Dim lbWon As New Label
    '            lbWon.Name = "lblWon" + intLoopIndex.ToString
    '            lbWon.Font = New Font("Microsoft Sans Serif", 12)
    '            lbWon.Size = New Point(18, 20)
    '            lbWon.Location = New Point(192, y)
    '            Me.gbscoreboard.Controls.Add(lbWon)
    '            sqlstr = "Select * from QuickTournament where Results = 1 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt1 As DataTable = getDataTable(sqlstr)
    '            max1 = dt1.Rows.Count
    '            lbWon.Text = max1

    '            Dim lbLose As New Label
    '            lbLose.Name = "lblLose" + intLoopIndex.ToString
    '            lbLose.Font = New Font("Microsoft Sans Serif", 12)
    '            lbLose.Size = New Point(18, 20)
    '            lbLose.Location = New Point(270, y)
    '            Me.gbscoreboard.Controls.Add(lbLose)
    '            sqlstr = "Select * from QuickTournament where Results = 0 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt2 As DataTable = getDataTable(sqlstr)
    '            max1 = dt2.Rows.Count
    '            lbLose.Text = max1

    '            Dim lbDraw As New Label
    '            lbDraw.Name = "lblDraw" + intLoopIndex.ToString
    '            lbDraw.Font = New Font("Microsoft Sans Serif", 12)
    '            lbDraw.Size = New Point(18, 20)
    '            lbDraw.Location = New Point(354, y)
    '            Me.gbscoreboard.Controls.Add(lbDraw)
    '            sqlstr = "Select * from QuickTournament where Results = 2 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt3 As DataTable = getDataTable(sqlstr)
    '            max1 = dt3.Rows.Count
    '            lbDraw.Text = max1

    '            Dim lbMatchPlayed As New Label
    '            lbMatchPlayed.Name = "lblMatchPlayed" + intLoopIndex.ToString
    '            lbMatchPlayed.Font = New Font("Microsoft Sans Serif", 12)
    '            lbMatchPlayed.Size = New Point(18, 20)
    '            lbMatchPlayed.Location = New Point(482, y)
    '            Me.gbscoreboard.Controls.Add(lbMatchPlayed)
    '            sqlstr = "Select * from QuickTournament where Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt4 As DataTable = getDataTable(sqlstr)
    '            max1 = dt4.Rows.Count
    '            lbMatchPlayed.Text = max1

    '            'Dim lbNetRunRate As New Label
    '            'lbNetRunRate.Name = "lblNetRunRate" + intLoopIndex.ToString
    '            'lbNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
    '            'lbNetRunRate.Size = New Point(18, 20)
    '            'lbNetRunRate.Location = New Point(642, y)
    '            'Me.gbscoreboard.Controls.Add(lbNetRunRate)
    '            'lbNetRunRate.Text = intLoopIndex.ToString

    '        Else
    '            Dim lbTeam As New Label
    '            lbTeam.Name = "lblTeam" + intLoopIndex.ToString
    '            lbTeam.Font = New Font("Microsoft Sans Serif", 12)
    '            lbTeam.Size = New Point(62, 20)
    '            lbTeam.Location = New Point(6, y)
    '            Me.gbscoreboard.Controls.Add(lbTeam)
    '            lbTeam.Text = dt.Rows(intLoopIndex - 1).Item(1)

    '            Dim lbWon As New Label
    '            lbWon.Name = "lblWon" + intLoopIndex.ToString
    '            lbWon.Font = New Font("Microsoft Sans Serif", 12)
    '            lbWon.Size = New Point(18, 20)
    '            lbWon.Location = New Point(192, y)
    '            Me.gbscoreboard.Controls.Add(lbWon)
    '            sqlstr = "Select * from QuickTournament where Results = 1 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt1 As DataTable = getDataTable(sqlstr)
    '            max1 = dt1.Rows.Count
    '            lbWon.Text = max1

    '            Dim lbLose As New Label
    '            lbLose.Name = "lblLose" + intLoopIndex.ToString
    '            lbLose.Font = New Font("Microsoft Sans Serif", 12)
    '            lbLose.Size = New Point(18, 20)
    '            lbLose.Location = New Point(270, y)
    '            Me.gbscoreboard.Controls.Add(lbLose)
    '            sqlstr = "Select * from QuickTournament where Results = 0 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt2 As DataTable = getDataTable(sqlstr)
    '            max1 = dt2.Rows.Count
    '            lbLose.Text = max1

    '            Dim lbDraw As New Label
    '            lbDraw.Name = "lblDraw" + intLoopIndex.ToString
    '            lbDraw.Font = New Font("Microsoft Sans Serif", 12)
    '            lbDraw.Size = New Point(18, 20)
    '            lbDraw.Location = New Point(354, y)
    '            Me.gbscoreboard.Controls.Add(lbDraw)
    '            sqlstr = "Select * from QuickTournament where Results = 2 and Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt3 As DataTable = getDataTable(sqlstr)
    '            max1 = dt3.Rows.Count
    '            lbDraw.Text = max1

    '            Dim lbMatchPlayed As New Label
    '            lbMatchPlayed.Name = "lblMatchPlayed" + intLoopIndex.ToString
    '            lbMatchPlayed.Font = New Font("Microsoft Sans Serif", 12)
    '            lbMatchPlayed.Size = New Point(18, 20)
    '            lbMatchPlayed.Location = New Point(482, y)
    '            Me.gbscoreboard.Controls.Add(lbMatchPlayed)
    '            sqlstr = "Select * from QuickTournament where Team_ID = " & dt.Rows(intLoopIndex - 1).Item(0)
    '            Dim dt4 As DataTable = getDataTable(sqlstr)
    '            max1 = dt4.Rows.Count
    '            lbMatchPlayed.Text = max1

    '            'Dim lbNetRunRate As New Label
    '            'lbNetRunRate.Name = "lblNetRunRate" + intLoopIndex.ToString
    '            'lbNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
    '            'lbNetRunRate.Size = New Point(18, 20)
    '            'lbNetRunRate.Location = New Point(642, y)
    '            'Me.gbscoreboard.Controls.Add(lbNetRunRate)
    '            'lbNetRunRate.Text = intLoopIndex.ToString
    '        End If

    '        y1 += 32
    '        y2 += 32

    '    Next intLoopIndex

    '    gbscoreboard.Size = New Point(746, y1)
    '    Me.Size = New Point(786, y2)
    'End Sub


    Private Sub initialisationLoad()
        Dim max, y, y1, y2 As Integer
        'sqlstr = "Select * from Teams"
        'sqlstr = "SELECT DISTINCT Teams.Team_Name, (Select count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID and Results=1) AS [Won], (Select Count(*) From QuickTournament Where QuickTournament.Team_ID= Teams.ID and Results=0) AS [Lose], (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID and Results=2) AS [Draw], (Select Count(*) from QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS [Played], (Select Count(*)*2 + (Select Count(*) from QuickTournament Where QuickTournament.Team_ID=Teams.ID And QuickTournament.Results=2) from QuickTournament Where QuickTournament.Team_ID=Teams.ID And QuickTournament.Results=1) AS [Points] FROM QuickTournament, Teams WHERE ((QuickTournament.Team_ID)=Teams.ID)"
        If frmScoreControlPanel.RbtnGroupAPoints.Checked = True Then
            sqlstr = "SELECT * FROM (SELECT Teams.Team_Name, (Select Count(*) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Won, (Select Count(*) From QuickTournament Where QuickTournament.Results=0 And QuickTournament.Team_ID=Teams.ID) AS Lose, (Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) AS Draw, (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS Played, (Select Count(*)*2+(Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Points FROM Teams Where Teams.Group_ID=1)  AS [%$##@_Alias] ORDER BY Points DESC"
            lblTeamName.Text = "Team A"
        ElseIf frmScoreControlPanel.RbtnGroupBPoints.Checked = True Then
            sqlstr = "SELECT * FROM (SELECT Teams.Team_Name, (Select Count(*) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Won, (Select Count(*) From QuickTournament Where QuickTournament.Results=0 And QuickTournament.Team_ID=Teams.ID) AS Lose, (Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) AS Draw, (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS Played, (Select Count(*)*2+(Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Points FROM Teams Where Teams.Group_ID=2)  AS [%$##@_Alias] ORDER BY Points DESC"
            lblTeamName.Text = "Team B"
        Else
            MsgBox("Plz Select the Group First", vbCritical + vbOKOnly)
            Exit Sub
        End If

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count

        y = 72
        y1 = 72
        y2 = y1 + 32

        'For Each r In dt.Rows
        '    listBoxTeamPlayers2.Items.Add(r.Item(0).ToString)
        'Next

        Dim intLoopIndex As Integer
        For intLoopIndex = 1 To max

            If intLoopIndex <> 1 Then
                y += 30
                Dim lbTeam As New Label
                lbTeam.Name = "lblTeam" + intLoopIndex.ToString
                lbTeam.Font = New Font("Microsoft Sans Serif", 12)
                lbTeam.Size = New Point(170, 30)
                lbTeam.Location = New Point(6, y)
                Me.gbscoreboard.Controls.Add(lbTeam)
                lbTeam.Text = dt.Rows(intLoopIndex - 1).Item(0)

                Dim lbWon As New Label
                lbWon.Name = "lblWon" + intLoopIndex.ToString
                lbWon.Font = New Font("Microsoft Sans Serif", 12)
                lbWon.Size = New Point(50, 20)
                lbWon.Location = New Point(192, y)
                Me.gbscoreboard.Controls.Add(lbWon)
                lbWon.Text = dt.Rows(intLoopIndex - 1).Item(1)

                Dim lbLose As New Label
                lbLose.Name = "lblLose" + intLoopIndex.ToString
                lbLose.Font = New Font("Microsoft Sans Serif", 12)
                lbLose.Size = New Point(50, 20)
                lbLose.Location = New Point(270, y)
                Me.gbscoreboard.Controls.Add(lbLose)
                lbLose.Text = dt.Rows(intLoopIndex - 1).Item(2)

                Dim lbDraw As New Label
                lbDraw.Name = "lblDraw" + intLoopIndex.ToString
                lbDraw.Font = New Font("Microsoft Sans Serif", 12)
                lbDraw.Size = New Point(50, 20)
                lbDraw.Location = New Point(354, y)
                Me.gbscoreboard.Controls.Add(lbDraw)
                lbDraw.Text = dt.Rows(intLoopIndex - 1).Item(3)

                Dim lbMatchPlayed As New Label
                lbMatchPlayed.Name = "lblMatchPlayed" + intLoopIndex.ToString
                lbMatchPlayed.Font = New Font("Microsoft Sans Serif", 12)
                lbMatchPlayed.Size = New Point(50, 20)
                lbMatchPlayed.Location = New Point(482, y)
                Me.gbscoreboard.Controls.Add(lbMatchPlayed)
                lbMatchPlayed.Text = dt.Rows(intLoopIndex - 1).Item(4)

                Dim lbPoints As New Label
                lbPoints.Name = "lblPoints" + intLoopIndex.ToString
                lbPoints.Font = New Font("Microsoft Sans Serif", 12)
                lbPoints.Size = New Point(60, 20)
                lbPoints.Location = New Point(606, y)
                Me.gbscoreboard.Controls.Add(lbPoints)
                lbPoints.Text = (2 * Val(lbWon.Text)) + Val(lbDraw.Text)

                Dim lbNetRunRate As New Label
                Dim txt As New TextBox
                lbNetRunRate.Name = "lblNetRunrate" + intLoopIndex.ToString
                lbNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
                lbNetRunRate.Size = New Point(100, 20)
                lbNetRunRate.Location = New Point(690, y)
                Me.gbscoreboard.Controls.Add(lbNetRunRate)
                txt = pointspanelEdit.gbscoreboard.Controls.Item("txtboxNetRunrate" + intLoopIndex.ToString)
                lbNetRunRate.Text = txt.Text

            Else
                Dim lbTeam As New Label
                lbTeam.Name = "lblTeam" + intLoopIndex.ToString
                lbTeam.Font = New Font("Microsoft Sans Serif", 12)
                lbTeam.Size = New Point(170, 30)
                lbTeam.Location = New Point(6, y)
                Me.gbscoreboard.Controls.Add(lbTeam)
                lbTeam.Text = dt.Rows(intLoopIndex - 1).Item(0)

                Dim lbWon As New Label
                lbWon.Name = "lblWon" + intLoopIndex.ToString
                lbWon.Font = New Font("Microsoft Sans Serif", 12)
                lbWon.Size = New Point(50, 20)
                lbWon.Location = New Point(192, y)
                Me.gbscoreboard.Controls.Add(lbWon)
                lbWon.Text = dt.Rows(intLoopIndex - 1).Item(1)

                Dim lbLose As New Label
                lbLose.Name = "lblLose" + intLoopIndex.ToString
                lbLose.Font = New Font("Microsoft Sans Serif", 12)
                lbLose.Size = New Point(50, 20)
                lbLose.Location = New Point(270, y)
                Me.gbscoreboard.Controls.Add(lbLose)
                lbLose.Text = dt.Rows(intLoopIndex - 1).Item(2)

                Dim lbDraw As New Label
                lbDraw.Name = "lblDraw" + intLoopIndex.ToString
                lbDraw.Font = New Font("Microsoft Sans Serif", 12)
                lbDraw.Size = New Point(50, 20)
                lbDraw.Location = New Point(354, y)
                Me.gbscoreboard.Controls.Add(lbDraw)
                lbDraw.Text = dt.Rows(intLoopIndex - 1).Item(3)

                Dim lbMatchPlayed As New Label
                lbMatchPlayed.Name = "lblMatchPlayed" + intLoopIndex.ToString
                lbMatchPlayed.Font = New Font("Microsoft Sans Serif", 12)
                lbMatchPlayed.Size = New Point(50, 20)
                lbMatchPlayed.Location = New Point(482, y)
                Me.gbscoreboard.Controls.Add(lbMatchPlayed)
                lbMatchPlayed.Text = dt.Rows(intLoopIndex - 1).Item(4)

                Dim lbPoints As New Label
                lbPoints.Name = "lblPoints" + intLoopIndex.ToString
                lbPoints.Font = New Font("Microsoft Sans Serif", 12)
                lbPoints.Size = New Point(60, 20)
                lbPoints.Location = New Point(606, y)
                Me.gbscoreboard.Controls.Add(lbPoints)
                lbPoints.Text = (2 * Val(lbWon.Text)) + Val(lbDraw.Text)

                Dim lbNetRunRate As New Label
                Dim txt As New TextBox
                lbNetRunRate.Name = "lblNetRunrate" + intLoopIndex.ToString
                lbNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
                lbNetRunRate.Size = New Point(100, 20)
                lbNetRunRate.Location = New Point(690, y)
                Me.gbscoreboard.Controls.Add(lbNetRunRate)
                txt = pointspanelEdit.gbscoreboard.Controls.Item("txtboxNetRunrate" + intLoopIndex.ToString)
                lbNetRunRate.Text = txt.Text

            End If

            y1 += 32
            y2 += 32

        Next intLoopIndex

        gbscoreboard.Size = New Point(802, y1)
        Me.Size = New Point(842, y2)
    End Sub
End Class