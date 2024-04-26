Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim fnd As Boolean = True

        If txtUserName.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please enter a User Name and a Password!", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a Password", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        sqlstr = "SELECT * FROM LoginCSS"
        Dim dt As DataTable = getDataTable(sqlstr)
        For Each drw As DataRow In dt.Rows
            If ((drw("Login_Username").ToString) = (txtUserName.Text)) And ((drw("Login_Password").ToString) = (txtPassword.Text)) Then
                fnd = False
                Me.Hide()
                frmCSSMDI.Show()
            End If
        Next

        If fnd = True Then
            MessageBox.Show("Unauthenticated User! Please try Again!", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If exitForm() = True Then
            con.Close()
            Me.Dispose()
            SplashCSS.Close()
            Me.Close()
        End If
    End Sub

    Public Function loginName() As String
        Dim username As String
        username = txtUserName.Text
        Return username
    End Function

    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
    End Sub
End Class
