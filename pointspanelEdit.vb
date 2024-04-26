Public Class pointspanelEdit

    Private Sub pointspanelEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub initialisationLoad()
        Dim max, y, y1, y2, btn_loc As Integer
        'sqlstr = "Select * from Teams"
        'sqlstr = "SELECT DISTINCT Teams.Team_Name, (Select count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID and Results=1) AS [Won], (Select Count(*) From QuickTournament Where QuickTournament.Team_ID= Teams.ID and Results=0) AS [Lose], (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID and Results=2) AS [Draw], (Select Count(*) from QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS [Played], (Select Count(*)*2 + (Select Count(*) from QuickTournament Where QuickTournament.Team_ID=Teams.ID And QuickTournament.Results=2) from QuickTournament Where QuickTournament.Team_ID=Teams.ID And QuickTournament.Results=1) AS [Points] FROM QuickTournament, Teams WHERE ((QuickTournament.Team_ID)=Teams.ID)"
        If frmScoreControlPanel.RbtnGroupAPoints.Checked = True Then
            sqlstr = "SELECT * FROM (SELECT Teams.Team_Name, (Select Count(*) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Won, (Select Count(*) From QuickTournament Where QuickTournament.Results=0 And QuickTournament.Team_ID=Teams.ID) AS Lose, (Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) AS Draw, (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS Played, (Select Count(*)*2+(Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Points FROM Teams Where Teams.Group_ID=1)  AS [%$##@_Alias] ORDER BY Points DESC"
            lblTeamName.Text = "Team A"
        ElseIf frmScoreControlPanel.RbtnGroupBPoints.Checked = True Then
            sqlstr = "SELECT * FROM (SELECT Teams.Team_Name, (Select Count(*) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Won, (Select Count(*) From QuickTournament Where QuickTournament.Results=0 And QuickTournament.Team_ID=Teams.ID) AS Lose, (Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) AS Draw, (Select Count(*) From QuickTournament Where QuickTournament.Team_ID=Teams.ID) AS Played, (Select Count(*)*2+(Select Count(*) From QuickTournament Where QuickTournament.Results=2 And QuickTournament.Team_ID=Teams.ID) From QuickTournament Where QuickTournament.Results=1 And QuickTournament.Team_ID=Teams.ID) AS Points FROM Teams Where Teams.Group_ID=2)  AS [%$##@_Alias] ORDER BY Points DESC"
            lblTeamName.Text = "Team B"
        Else
            MsgBox("Please Select the Group First", vbCritical + vbOKOnly)
            Me.Close()
            Exit Sub
        End If

        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count

        y = 72
        y1 = 72
        y2 = 180

        btn_loc = 90

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

                Dim txbxNetRunRate As New TextBox
                txbxNetRunRate.Name = "txtboxNetRunrate" + intLoopIndex.ToString
                txbxNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
                txbxNetRunRate.Size = New Point(100, 20)
                txbxNetRunRate.Location = New Point(670, y)
                Me.gbscoreboard.Controls.Add(txbxNetRunRate)

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

                Dim txbxNetRunRate As New TextBox
                txbxNetRunRate.Name = "txtboxNetRunrate" + intLoopIndex.ToString
                txbxNetRunRate.Font = New Font("Microsoft Sans Serif", 12)
                txbxNetRunRate.Size = New Point(100, 20)
                txbxNetRunRate.Location = New Point(670, y)
                Me.gbscoreboard.Controls.Add(txbxNetRunRate)


            End If

            y1 += 32
            y2 += 32
            btn_loc += 32

        Next intLoopIndex

        gbscoreboard.Size = New Point(802, y1)
        Me.btnShowOnPC.Location = New Point(304, btn_loc)
        Me.btn_Show.Location = New Point(464, btn_loc)
        Me.btn_CLose.Location = New Point(629, btn_loc)
        Me.Size = New Point(842, y2)
    End Sub

    Private Sub displayPointTableOnScreen()
        Try
            'MsgBox(CStr(Me.gbscoreboard.Controls.Item("txtboxNetRunrate1").ToString), vbCritical + vbOKOnly)
            Dim screen As Screen
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            screen = screen.AllScreens(1)
            totalWidth = screen.AllScreens(1).Bounds.Width
            totalHeight = screen.AllScreens(1).Bounds.Height
            pointspanel.StartPosition = FormStartPosition.Manual
            pointspanel.Location = screen.Bounds.Location + New Point(totalWidth * 25 / 100, totalHeight * 25 / 100)
            pointspanel.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try
       
    End Sub

    Private Sub displayPointTableOnPC()
        Try
            'MsgBox(CStr(Me.gbscoreboard.Controls.Item("txtboxNetRunrate1").ToString), vbCritical + vbOKOnly)
            Dim screen As Screen
            Dim totalWidth As Integer
            Dim totalHeight As Integer
            screen = screen.AllScreens(0)
            totalWidth = screen.AllScreens(0).Bounds.Width
            totalHeight = screen.AllScreens(0).Bounds.Height
            pointspanel.StartPosition = FormStartPosition.Manual
            pointspanel.Location = screen.Bounds.Location + New Point(totalWidth * 25 / 100, totalHeight * 25 / 100)
            pointspanel.Show()
        Catch ex As Exception
            MsgBox("Error: Check if the secondary screen is connected")
        End Try
        
    End Sub

    Private Sub btn_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Show.Click
        Call displayPointTableOnScreen()
    End Sub

    Private Sub btn_CLose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CLose.Click
        con.Close()
        con.Dispose()
        pointspanel.Dispose()
        pointspanel.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnShowOnPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowOnPC.Click
        Call displayPointTableOnPC()
    End Sub
End Class