Public Class frmPlayer_Add
    Dim cmd As New OleDb.OleDbCommand
    Dim errmsg As String

    Private Sub frmPlayer_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initialisationLoad()
        Call incrPlayerID()
    End Sub

    Private Sub btnAddPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlayer.Click
        Call insertPlayer()
    End Sub

    Private Sub btnClearPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPlayer.Click
        Call clearAll()
    End Sub

    Private Sub cmbTeam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeam.SelectedIndexChanged
        cmbTeamID.SelectedIndex = cmbTeam.SelectedIndex
    End Sub

    Private Sub cmbTeamID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeamID.SelectedIndexChanged
        cmbTeam.SelectedIndex = cmbTeamID.SelectedIndex
    End Sub

    Private Sub btnExitPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitPlayer.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub incrPlayerID()
        Dim x, y As Integer
        Dim max As Integer

        sqlstr = "Select * from Players"
        Dim dt As DataTable = getDataTable(sqlstr)

        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If
        txtPlayerID.Text = x
        txtPlayerID.Enabled = False
    End Sub


    Private Sub initialisationLoad()
        Dim y As Integer
        Dim max As Integer

        sqlstr = "SELECT * FROM Teams"
        Dim dt1 As DataTable = getDataTable(sqlstr)
        max = dt1.Rows.Count
        For y = 0 To max - 1
            cmbTeamID.Items.Add(dt1.Rows(y).Item(0))
            cmbTeam.Items.Add(dt1.Rows(y).Item(2))
        Next

        'To auto complete Teams
        Try
            Dim dt2 As DataTable = getDataTable(sqlstr)
            Dim r As DataRow

            cmbTeam.AutoCompleteCustomSource.Clear()

            For Each r In dt2.Rows
                cmbTeam.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub insertPlayer()
        If chkData() = True Then
            MsgBox("Please Fill:- " & errmsg, vbCritical + vbOKOnly)
            Exit Sub
        ElseIf saveDialog() = True Then
            cmd.CommandText = "INSERT INTO Players(ID,Team_ID,Player_Name,Player_DOB,Pet_Name,Playing_Role,Batting_Style,Bowling_Style,Player_Profile,Phone_No,Player_State,Player_City,Player_Address,Player_Email,Create_Date,Status) Values(@ID,@Team_ID,@Player_Name,@Player_DOB,@Pet_Name,@Playing_Role,@Batting_Style,@Bowling_Style,@Player_Profile,@Phone_No,@Player_State,@Player_City,@Player_Address,@Player_Email,@Create_Date,@Status)"

            cmd.Parameters.AddWithValue("@ID", txtPlayerID.Text)
            cmd.Parameters.AddWithValue("@Team_ID", cmbTeamID.Text)
            cmd.Parameters.AddWithValue("@Player_Name", txtFullName.Text)
            cmd.Parameters.AddWithValue("@Player_DOB", dtpBirthDate.Value.Date)
            cmd.Parameters.AddWithValue("@Pet_Name", txtPetName.Text)
            cmd.Parameters.AddWithValue("@Playing_Role", cmbPlayingRole.Text)
            cmd.Parameters.AddWithValue("@Batting_Style", cmbBattingStyle.Text)
            cmd.Parameters.AddWithValue("@Bowling_Style", cmbBowlingStyle.Text)
            cmd.Parameters.AddWithValue("@Player_Profile", txtPlayerProfile.Text)
            cmd.Parameters.AddWithValue("@Phone_No", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@Player_State", txtState.Text)
            cmd.Parameters.AddWithValue("@Player_City", txtCity.Text)
            cmd.Parameters.AddWithValue("@Player_Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Player_Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Create_Date", dtpCreateDate.Value.Date)
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
            cmd.Connection = makeConnection()

            Try
                If cmd.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Player Added Successfully", "Player Add")
                    Call clearAll()
                    Call incrPlayerID()
                Else
                    MessageBox.Show("Failed to Add Player", "Player Add Error")
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected" + ex.Message)
            End Try
        End If
        cmd.Dispose()
    End Sub

    Private Sub clearAll()

        txtFullName.Clear()
        txtPetName.Clear()
        txtContactNo.Clear()
        txtContactNo.Clear()
        txtState.Clear()
        txtCity.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        cmbTeam.SelectedIndex = -1
        cmbTeam.Text = ""
        cmbBattingStyle.SelectedIndex = -1
        cmbBattingStyle.Text = ""
        cmbPlayingRole.SelectedIndex = -1
        cmbPlayingRole.Text = ""
        cmbBowlingStyle.SelectedIndex = -1
        cmbBowlingStyle.Text = ""
        txtPlayerProfile.Text = ""
        dtpCreateDate.Value = Date.Now.ToShortDateString

    End Sub

    Public Function chkData() As Boolean
        errmsg = ""

        If txtFullName.Text = "" Then
            errmsg = errmsg & "Full Name cannot be blank"
            chkData = True
        ElseIf txtPetName.Text = "" Then
            errmsg = errmsg & "Pet Name cannot be blank"
            chkData = True
        ElseIf txtContactNo.Text = "" Then
            errmsg = errmsg & "Contact No cannot be blank"
            chkData = True
        ElseIf txtState.Text = "" Then
            errmsg = errmsg & "State cannot be blank"
            chkData = True
        ElseIf txtAddress.Text = "" Then
            errmsg = errmsg & "Address cannot be blank"
            chkData = True
        ElseIf txtCity.Text = "" Then
            errmsg = errmsg & "City cannot be blank"
            chkData = True
        ElseIf txtEmail.Text = "" Then
            errmsg = errmsg & "Email cannot be blank"
            chkData = True
        ElseIf cmbTeam.Text = "" Then
            errmsg = errmsg & "Select a Team"
            chkData = True
        ElseIf cmbBattingStyle.Text = "" Then
            errmsg = errmsg & "Select a Batting Style"
            chkData = True
        ElseIf cmbBowlingStyle.Text = "" Then
            errmsg = errmsg & "Select a Bowling Style"
            chkData = True
        Else
            chkData = False
        End If
    End Function
End Class
