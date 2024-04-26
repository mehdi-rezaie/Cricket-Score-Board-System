Public Class frmSelectWinnerTeam
    Dim errmsg As String
    Dim team1_ID As String
    Dim team2_ID As String

    Private Sub initialisationLoad()
        Dim y As Integer
        Dim max As Integer

        cmbTeam1.Text = frmScoreControlPanel.cmbTeam1.Text
        cmbTeam1_ID.Text = frmScoreControlPanel.cmbTeam1_ID.Text
        cmbTeam2.Text = frmScoreControlPanel.cmbTeam2.Text
        cmbTeam2_ID.Text = frmScoreControlPanel.cmbTeam2_ID.Text

    End Sub

    Private Sub btnSubmitWinTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitWinTeam.Click

        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        End If

        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                Dim cmd1 As New OleDb.OleDbCommand

                If RbtnTeam1.Checked = True And RbtnTeam2.Checked = False Then
                    team1_ID = cmbTeam1_ID.Text
                    team2_ID = cmbTeam2_ID.Text
                    cmd.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & team1_ID
                    cmd.Parameters.AddWithValue("@Results", "1")

                    cmd1.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & team2_ID
                    cmd1.Parameters.AddWithValue("@Results", "0")
                    cmd.Connection = makeConnection()
                    cmd1.Connection = makeConnection()
                    Dim res As Integer = cmd.ExecuteNonQuery()
                    Dim res1 As Integer = cmd1.ExecuteNonQuery()
                    If (res > 0 And res1 > 0) Then
                        MessageBox.Show("Winning Team Entered successfully, Congratulations to the team from TDSCorp", "Update Status")
                        Me.Dispose()
                        Me.Close()
                       
                        frmScoreControlPanel.Dispose()
                        frmScoreControlPanel.Close()
                        scoreDisplayPanel.Dispose()
                        scoreDisplayPanel.Close()
                    Else
                        MessageBox.Show("Failed to update winning team!", "Update Status")
                    End If
                End If

                If RbtnTeam1.Checked = False And RbtnTeam2.Checked = True Then
                    team1_ID = cmbTeam1_ID.Text
                    team2_ID = cmbTeam2_ID.Text
                    cmd.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & cmbTeam1_ID.Text
                    cmd.Parameters.AddWithValue("@Results", "0")

                    cmd1.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & cmbTeam2_ID.Text
                    cmd1.Parameters.AddWithValue("@Results", "1")
                    cmd.Connection = makeConnection()
                    cmd1.Connection = makeConnection()
                    Dim res As Integer = cmd.ExecuteNonQuery()
                    Dim res1 As Integer = cmd1.ExecuteNonQuery()
                    If (res > 0 And res1 > 0) Then
                        MessageBox.Show("Winning Team Entered successfully, Congratulations to the team from TDSCorp", "Update Status")
                    Else
                        MessageBox.Show("Failed to update winning team!", "Update Status")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Not connected!! " + ex.Message)
            End Try
        End If
    End Sub

    Public Function chkData() As Boolean
        errmsg = ""
        If Not cmbTeam1.Text = "" And cmbTeam1_ID.Text = "" And cmbTeam2.Text = "" And cmbTeam2_ID.Text = "" Then
            errmsg = errmsg & "Select the winning team!"
            chkData = True
        Else
            chkData = False
        End If
    End Function

    Private Sub frmSelectWinnerTeam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub cmbTeam2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2.SelectedIndexChanged
        cmbTeam2_ID.SelectedIndex = cmbTeam2.SelectedIndex
    End Sub

    Private Sub cmbTeam1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1.SelectedIndexChanged
        cmbTeam1_ID.SelectedIndex = cmbTeam1.SelectedIndex
    End Sub

    Private Sub cmbTeam1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1.TextChanged
        If cmbTeam1.Text = "" Then
            cmbTeam1_ID.Text = ""
        End If
        cmbTeam1_ID.SelectedIndex = -1
    End Sub

    Private Sub cmbTeam2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2.TextChanged
        If cmbTeam2.Text = "" Then
            cmbTeam2_ID.Text = ""
        End If
        cmbTeam2_ID.SelectedIndex = -1
    End Sub

    Private Sub btnMatchDrawed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatchDrawed.Click
        If updateDialog() = True Then
            Try
                Dim cmd As New OleDb.OleDbCommand
                Dim cmd1 As New OleDb.OleDbCommand

                team1_ID = cmbTeam1_ID.Text
                team2_ID = cmbTeam2_ID.Text
                cmd.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & team1_ID
                cmd.Parameters.AddWithValue("@Results", "2")

                cmd1.CommandText = "UPDATE QuickTournament SET Results=@Results WHERE Team_ID=" & team2_ID
                cmd1.Parameters.AddWithValue("@Results", "2")
                cmd.Connection = makeConnection()
                cmd1.Connection = makeConnection()
                Dim res As Integer = cmd.ExecuteNonQuery()
                Dim res1 As Integer = cmd1.ExecuteNonQuery()
                If (res > 0 And res1 > 0) Then
                    MessageBox.Show("The match is a draw", "Update Status")
                    Me.Dispose()
                    Me.Close()
                    
                    frmScoreControlPanel.Dispose()
                    frmScoreControlPanel.Close()
                    scoreDisplayPanel.Dispose()
                    scoreDisplayPanel.Close()
                Else
                    MessageBox.Show("Failed to update winning team!", "Update Status")
                End If
            Catch ex As Exception

        End Try
        End If
    End Sub
End Class