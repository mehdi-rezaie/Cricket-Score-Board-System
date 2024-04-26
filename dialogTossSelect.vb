Imports System.Windows.Forms

Public Class dialogTossSelect

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If RBtnTeam1.Checked = False And RBtnTeam2.Checked = False And RBtnBatFirst.Checked = False And RBtnFieldFirst.Checked = False Then
            MessageBox.Show("Enter complete toss details to proceed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            setTossWinnerAndDecisionTeamToCpanel()
            Me.Hide()
            frmScoreControlPanel.ShowDialog()
            frmScoreControlPanel.TopMost = True
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'If exitForm() = True Then
        '    Me.Dispose()
        '    Me.Close()
        '    frmScoreControlPanel.Dispose()
        '    frmScoreControlPanel.Close()
        '    Exit Sub
        'ElseIf exitForm() = False Then
        '    Me.Dispose()
        '    Me.Close()
        '    frmScoreControlPanel.Dispose()
        '    frmScoreControlPanel.Close()
        '    Exit Sub
        'End If

        If exitForm() = True Then
            con.Close()
            con.Dispose()
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub setTossWinnerAndDecisionTeamToCpanel()
        If RBtnTeam1.Checked = True And RBtnTeam2.Checked = False Then
            frmScoreControlPanel.RBtnTeam1.Checked = True
            frmScoreControlPanel.RBtnTeam2.Checked = False
        ElseIf RBtnTeam2.Checked = True And RBtnTeam1.Checked = False Then
            frmScoreControlPanel.RBtnTeam2.Checked = True
            frmScoreControlPanel.RBtnTeam1.Checked = False
        End If

        If RBtnBatFirst.Checked = True And RBtnFieldFirst.Checked = False Then
            frmScoreControlPanel.RBtnBatFirst.Checked = True
            frmScoreControlPanel.RBtnFieldFirst.Checked = False
        ElseIf RBtnFieldFirst.Checked = True And RBtnBatFirst.Checked = False Then
            frmScoreControlPanel.RBtnFieldFirst.Checked = True
            frmScoreControlPanel.RBtnBatFirst.Checked = False
        End If
    End Sub
End Class
