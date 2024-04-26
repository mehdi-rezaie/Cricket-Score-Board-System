Imports System.Windows.Forms

Public Class dialogTeamSelect
    Dim team1_name As String
    Dim team1_id As String
    Dim team2_name As String
    Dim team2_id As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If cmbTeam1.Text = "" And cmbTeam2.Text = "" Then
            MessageBox.Show("Select the teams to proceed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbTeam1_ID.Text = "" Or cmbTeam2_ID.Text = "" Then
            MessageBox.Show("Enter or Select the correct team names!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            setTeamNamesToTossDialog()
            setTeamNamesToCPanel()
            dialogTossSelect.Show()
            dialogTossSelect.TopMost = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'If exitForm() = True Then
        '    con.Close()
        '    con.Dispose()
        '    Me.Close()
        '    Me.Dispose()
        'End If
        con.Close()
        con.Dispose()
        Me.Close()
        Me.Dispose()
        'frmScoreControlPanel.Close()
    End Sub

    Private Sub dialogTeamSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
    End Sub

    Private Sub initialisationLoad()
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

    Private Sub setTeamNamesToCPanel()
        frmScoreControlPanel.cmbTeam1.Text = cmbTeam1.Text
        frmScoreControlPanel.cmbTeam1_ID.Text = cmbTeam1_ID.Text
        frmScoreControlPanel.cmbTeam2.Text = cmbTeam2.Text
        frmScoreControlPanel.cmbTeam2_ID.Text = cmbTeam2_ID.Text
    End Sub

    Private Sub setTeamNamesToTossDialog()
        dialogTossSelect.RBtnTeam1.Text = cmbTeam1.Text
        dialogTossSelect.RBtnTeam2.Text = cmbTeam2.Text
    End Sub

    Private Sub cmbTeam1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam1.SelectedIndexChanged
        If cmbTeam1.SelectedItem = cmbTeam2.SelectedItem Then
            MessageBox.Show("Cannot have same team on both sides!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbTeam1.SelectedIndex = -1
            cmbTeam1.Text = ""
        End If
        cmbTeam1_ID.SelectedIndex = cmbTeam1.SelectedIndex
    End Sub

    Private Sub cmbTeam2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam2.SelectedIndexChanged
        If cmbTeam2.SelectedItem = cmbTeam1.SelectedItem Then
            MessageBox.Show("Cannot have same team on both sides!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbTeam2.SelectedIndex = -1
            cmbTeam2.Text = ""
        End If

        cmbTeam2_ID.SelectedIndex = cmbTeam2.SelectedIndex
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
End Class
