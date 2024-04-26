Public Class frmRegisterNewUser

    Private Sub btnRegisterUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisterUser.Click
        If txtNewUserName.Text = "" Then
            MessageBox.Show("Please enter a User Name!", "Register User")
            Exit Sub
        End If
        If txtNewPassword.Text = "" Then
            MessageBox.Show("Please enter a Password!", "Register User")
            Exit Sub
        End If
        If txtReenterPwd.Text = "" Then
            MessageBox.Show("Cannot be left blank!", "Register User")
        End If

        Dim max, x As Integer
        Dim cmd As New OleDb.OleDbCommand
        If txtNewPassword.Text <> txtReenterPwd.Text Then
            MessageBox.Show("Password do not match! Enter the correct password", "Register User")
            Exit Sub
        End If

        sqlstr = "SELECT * FROM LoginCSS"
        Dim dt As DataTable = getDataTable(sqlstr)
        max = dt.Rows.Count
        If max = 0 Then
            x = 1
        Else
            x = max + 1
        End If

        cmd.CommandText = "INSERT INTO LoginCSS(Login_Username,Login_Password)VALUES(@Login_Username,@Login_Password)"
        'cmd.Parameters.AddWithValue("@Login_ID", x)
        cmd.Parameters.AddWithValue("@Login_Username", txtNewUserName.Text)
        cmd.Parameters.AddWithValue("@Login_Password", txtNewPassword.Text)
        'cmd.Parameters.AddWithValue("@Login_Type", cmbLogintype.Text)
        cmd.Connection = makeConnection()

        Try
            Dim res1 As Integer = cmd.ExecuteNonQuery()
            If res1 > 0 Then
                MessageBox.Show("User added successfully!", "Register User")
            Else
                MessageBox.Show("Failed to add New User!", "Register User")
            End If
        Catch ex As Exception
            MessageBox.Show("Not Connected " + ex.Message)
        End Try
        txtNewUserName.Text = ""
        txtNewPassword.Text = ""
        txtReenterPwd.Text = ""
        cmd.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
