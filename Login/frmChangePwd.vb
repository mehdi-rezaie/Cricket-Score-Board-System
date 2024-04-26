Public Class frmChangePwd
    Dim index As Integer

    Private Sub frmChangePwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fnd1 As Boolean = True
        Dim max, x As Integer

        sqlstr = "SELECT * FROM LoginCSS"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count

        For x = 0 To max - 1
            cmbUserID.Items.Add(dt.Rows(x).Item(0))
            cmbUser.Items.Add(dt.Rows(x).Item(1))
        Next
    End Sub

    Private Sub btnSavePwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePwd.Click
        Dim cmd As New OleDb.OleDbCommand

        If saveDialog() = True Then
            If cmbUser.Text = "" Then
                MsgBox("Please select a User ID!")
                Exit Sub
            End If
            If txtNewPassword.Text = "" Then
                MsgBox("Please enter a New Password!")
                Exit Sub
            End If
            If txtReenterPwd.Text = "" Then
                MsgBox("Password do not match! Enter the correct password!")
                Exit Sub
            End If

            sqlstr = "SELECT * FROM LoginCSS"
            Dim dt1 As DataTable = getDataTable(sqlstr)
            If dt1.Rows(cmbUserID.SelectedIndex).Item(2) = txtOldPwd.Text Then
                checkNewPwd()
            Else
                MessageBox.Show("Wrong Password! Please try Again!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmbUserID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserID.SelectedIndexChanged
        cmbUser.SelectedIndex = cmbUserID.SelectedIndex
        index = cmbUserID.SelectedIndex
        'Call showUserType()
    End Sub

    Private Sub cmbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedIndexChanged
        cmbUserID.SelectedIndex = cmbUser.SelectedIndex
    End Sub

    'Private Sub showUserType()
    '    sqlstr = "SELECT * FROM LoginCSS"
    '    Dim dt As DataTable = getDataTable(sqlstr)
    '    lblUsertype.Text = dt.Rows(index).Item(3)
    'End Sub

    Private Sub checkNewPwd()

        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim fnd As Boolean

            Dim dt As DataTable = getDataTable(sqlstr)
            For Each drw As DataRow In dt.Rows
                If drw("Login_Username").ToString = cmbUser.Text And txtNewPassword.Text = txtReenterPwd.Text Then
                    fnd = True
                End If
            Next

            If txtNewPassword.Text <> txtReenterPwd.Text Then
                MessageBox.Show("New passwords do not match! Enter the correct password", "Change Password")
                Exit Sub
            ElseIf txtOldPwd.Text = txtNewPassword.Text = txtReenterPwd.Text Then
                MessageBox.Show("You cannot have the same password", "Change Password")
                Exit Sub

            End If

            If fnd = False Then
                MessageBox.Show("Unauthenticated User! Please try Again!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            cmd.CommandText = "UPDATE LoginCSS SET Login_ID=@Login_ID,Login_Username=@Login_Username,Login_Password=@Login_Password WHERE Login_ID=@Login_ID"
            cmd.Parameters.AddWithValue("@Login_ID", Val(cmbUserID.Text))
            cmd.Parameters.AddWithValue("@Login_Username", cmbUser.Text)
            cmd.Parameters.AddWithValue("@Login_Password", txtNewPassword.Text)
            cmd.Connection = makeConnection()

            Try
                Dim res1 As Integer = cmd.ExecuteNonQuery()
                If res1 > 0 Then
                    MessageBox.Show("Password updated successfully!", "Change Password")
                Else
                    MessageBox.Show("Failed to update password!", "Change Password")
                End If
            Catch ex As Exception
                MessageBox.Show("Not Connected " + ex.Message)
            End Try
            cmbUser.SelectedIndex = -1
            txtNewPassword.Clear()
            txtReenterPwd.Clear()
            txtOldPwd.Clear()
            cmd.Dispose()

            Exit Sub
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub
End Class
