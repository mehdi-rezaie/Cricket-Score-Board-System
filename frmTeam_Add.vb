Imports System.Data.OleDb

Public Class frmTeam_Add

    Dim cmd As New OleDb.OleDbCommand
    Dim errmsg As String

    Private Sub frmTeam_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
        Call incrTeamID()
    End Sub

    Private Sub btnAddTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTeam.Click
        Call insertTeam()
    End Sub

    Private Sub btnClearTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTeam.Click
        Call clearAll()
    End Sub

    Private Sub btnExitTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitTeam.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub initialisationLoad()
        Dim x, y As Integer
        Dim max As Integer
        sqlstr = "Select * FROM Groups"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        For y = 0 To max - 1
            cmbGroupsID.Items.Add(dt.Rows(y).Item(0))
            cmbGroups.Items.Add(dt.Rows(y).Item(1))
        Next
    End Sub

    Private Sub incrTeamID()
        Dim x, y As Integer
        Dim max As Integer

        sqlstr = "Select * from Teams"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If

        txtTeamID.Text = x
        txtTeamID.Enabled = False

    End Sub

    Private Sub insertTeam()
        If chkData() = True Then
            MsgBox("Please Fill :- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then

            'Dim arrImage() As Byte
            'Dim strImage As String
            'Dim myMs As New IO.MemoryStream

            'If Not IsNothing(Me.logoPic.Image) Then
            '    Me.logoPic.Image.Save(myMs, Me.logoPic.Image.RawFormat)
            '    arrImage = myMs.GetBuffer
            '    strImage = "?"
            'Else
            '    arrImage = Nothing
            '    strImage = "NULL"
            'End If

            cmd.CommandText = "INSERT INTO Teams(ID,Group_ID,Team_Name,Team_Info,Team_Owners,Team_Organisers,Team_Address,Contact_No,Create_Date,Status,Team_Logo) Values(@ID,@Group_ID,@Team_Name,@Team_Info,@Team_Owners,@Team_Organisers,@Team_Address,@Contact_No,@Create_Date,Status,@Team_Logo)"

            cmd.Parameters.AddWithValue("@ID", txtTeamID.Text)
            cmd.Parameters.AddWithValue("@Group_ID", Val(cmbGroupsID.Text))
            cmd.Parameters.AddWithValue("@Team_Name", txtTeamName.Text)
            cmd.Parameters.AddWithValue("@Team_Info", txtAbrivation.Text)
            cmd.Parameters.AddWithValue("@Team_Owners", txtOwner.Text)
            cmd.Parameters.AddWithValue("@Team_Organisers", txtOrgName.Text)
            cmd.Parameters.AddWithValue("@Team_Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Contact_No", Val(txtContactNo.Text))
            cmd.Parameters.AddWithValue("@Create_Date", dtpCreateDate.Text)
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
            cmd.Parameters.AddWithValue("@Team_Logo", "NULL")
            cmd.Connection = makeConnection()

            Try

                If cmd.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Team Added Successfully", "Team Add")
                    Call clearAll()
                    Call incrTeamID()
                Else
                    MessageBox.Show("Failed to Add Team", "Team Add Error")
                End If

            Catch ex As Exception
                MessageBox.Show("Not Connected" + ex.Message)
            End Try
            'If strImage = "?" Then
            '    cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            '    cmd.Parameters.AddWithValue("@Team_Logo", strImage)
            'End If
        End If
        cmd.Dispose()
    End Sub

    Private Sub clearAll()

        txtTeamName.Clear()
        txtAbrivation.Clear()
        txtOwner.Clear()
        txtOrgName.Clear()
        txtAddress.Clear()
        txtContactNo.Clear()
        dtpCreateDate.Value = Date.Now.ToShortDateString

    End Sub

    Public Function chkData() As Boolean

        errmsg = ""

        If txtTeamName.Text = "" Then
            errmsg = errmsg & "Team Name cannot be blank"
            chkData = True
        ElseIf cmbGroups.Text = "" Then
            errmsg = errmsg & "Select group name"
            chkData = True
        ElseIf txtAbrivation.Text = "" Then
            errmsg = errmsg & "Short Name cannot be blank"
            chkData = True
        ElseIf txtOwner.Text = "" Then
            errmsg = errmsg & "Team Owner cannot be blank"
            chkData = True
        ElseIf txtOrgName.Text = "" Then
            errmsg = errmsg & "Team Organiser cannot be blank"
            chkData = True
        ElseIf txtAddress.Text = "" Then
            errmsg = errmsg & "Address cannot be blank"
            chkData = True
        Else
            chkData = False
        End If

    End Function

    Private Sub cmbGroups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroups.SelectedIndexChanged
        cmbGroupsID.SelectedIndex = cmbGroups.SelectedIndex
    End Sub

    Private Sub cmbGroupsID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroupsID.SelectedIndexChanged
        cmbGroups.SelectedIndex = cmbGroupsID.SelectedIndex
    End Sub
End Class