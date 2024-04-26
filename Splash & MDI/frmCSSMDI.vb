Imports System.Windows.Forms

Public Class frmCSSMDI

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = 512
            Return param
        End Get
    End Property

    'Private Sub enableMenu()
    '    If lblUserType.Text = "User" Then
    '        mnuRegisterNewUser.Enabled = False
    '        RegistrationToolStripMenuItem.Enabled = False
    '        StaffToolStripMenuItem.Enabled = False
    '        DepartmentToolStripMenuItem.Enabled = False
    '        PatientToolStripMenuItem.Enabled = False
    '        DoctorToolStripMenuItem.Enabled = False
    '        ReceiptToolStripMenuItem.Enabled = False
    '    End If
    'End Sub

    'Private Sub mnuDiagnosticRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPatRegDiagnosis.ShowDialog()
    '    frmPatRegDiagnosis.TopMost = True
    'End Sub


    'Private Sub mnuAddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmStaffAdd.ShowDialog()
    '    frmStaffAdd.TopMost = True
    'End Sub

    'Private Sub mnuUpdateStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateStaff.ShowDialog()
    '    frmUpdateStaff.TopMost = True
    'End Sub

    'Private Sub mnuViewStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmStaffView.ShowDialog()
    '    frmStaffView.TopMost = True
    'End Sub

    'Private Sub mnuSearchStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmStaffSearch.ShowDialog()
    '    frmStaffSearch.TopMost = True
    'End Sub

    'Private Sub mnuAddDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmDepartmentAdd.ShowDialog()
    '    frmDepartmentAdd.TopMost = True
    'End Sub

    'Private Sub mnuViewDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmDeptView.ShowDialog()
    '    frmDeptView.TopMost = True
    'End Sub

    'Private Sub mnuAddPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPatientAdd.ShowDialog()
    '    frmPatientAdd.TopMost = True
    'End Sub

    'Private Sub mnuUpdatePat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdatePatient.ShowDialog()
    '    frmUpdatePatient.TopMost = True
    'End Sub

    'Private Sub mnuViewPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPatientView.ShowDialog()
    '    frmPatientView.TopMost = True
    'End Sub

    'Private Sub mnuSearchPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPatientSearch.ShowDialog()
    '    frmPatientSearch.TopMost = True
    'End Sub

    'Private Sub mnuAddDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmDoctorAdd.ShowDialog()
    '    frmDoctorAdd.TopMost = True
    'End Sub

    'Private Sub UpdateDoctorDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateDoctor.ShowDialog()
    '    frmUpdateDoctor.TopMost = True
    'End Sub

    'Private Sub mnuAddBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPathoBlood.ShowDialog()
    '    frmPathoBlood.TopMost = True
    'End Sub

    'Private Sub mnuAddBiochem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmPathoBiochem.ShowDialog()
    '    frmPathoBiochem.TopMost = True
    'End Sub

    'Private Sub mnuAddUrine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmMicroUrine.ShowDialog()
    '    frmMicroUrine.TopMost = True
    'End Sub

    'Private Sub mnuAddStool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmMicroStool.ShowDialog()
    '    frmMicroStool.TopMost = True
    'End Sub

    'Private Sub mnuAddXRay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmImagXray.ShowDialog()
    '    frmImagXray.TopMost = True
    'End Sub

    'Private Sub mnuAddCTScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmImagCTScan.ShowDialog()
    '    frmImagCTScan.TopMost = True
    'End Sub

    'Private Sub mnuAddSono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmImagSonography.ShowDialog()
    '    frmImagSonography.TopMost = True
    'End Sub

    'Private Sub mnuAddEyeExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmOpthalEyeExam.ShowDialog()
    '    frmOpthalEyeExam.TopMost = True
    'End Sub

    'Private Sub mnuUpdateBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateBlood.ShowDialog()
    '    frmUpdateBlood.TopMost = True
    'End Sub

    'Private Sub mnuUpdateBiochem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateBiochem.ShowDialog()
    '    frmUpdateBiochem.TopMost = True
    'End Sub

    'Private Sub mnuUpdateUrine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateUrine.ShowDialog()
    '    frmUpdateUrine.TopMost = True
    'End Sub

    'Private Sub mnuUpdateStool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateStool.ShowDialog()
    '    frmUpdateStool.TopMost = True
    'End Sub

    'Private Sub mnuUpdateXRay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateXray.ShowDialog()
    '    frmUpdateXray.TopMost = True
    'End Sub

    'Private Sub mnuUpdateCTScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateCTScan.ShowDialog()
    '    frmUpdateCTScan.TopMost = True
    'End Sub

    'Private Sub mnuUpdateSono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateSono.ShowDialog()
    '    frmUpdateSono.TopMost = True
    'End Sub

    'Private Sub mnuUpdateEyeExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUpdateEyeExam.ShowDialog()
    '    frmUpdateEyeExam.TopMost = True
    'End Sub

    'Private Sub BloodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmBloodReport.ShowDialog()
    '    frmBiochemReport.TopMost = True
    'End Sub

    'Private Sub BiochemistryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmBiochemReport.ShowDialog()
    '    frmBiochemReport.TopMost = True
    'End Sub

    'Private Sub UrineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmUrineReport.ShowDialog()
    '    frmUrineReport.TopMost = True
    'End Sub

    Private Sub StoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmStoolReport.ShowDialog()
        'frmStoolReport.TopMost = True
    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmXRayReport.ShowDialog()
        'frmXRayReport.TopMost = True
    End Sub

    Private Sub CTScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmCTScanReport.ShowDialog()
        'frmCTScanReport.TopMost = True
    End Sub

    Private Sub SonographyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmSonographyReport.ShowDialog()
        'frmSonographyReport.TopMost = True
    End Sub

    Private Sub EyeExamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmEyeExamReport.ShowDialog()
        'frmEyeExamReport.TopMost = True
    End Sub

    Private Sub mnuRegisterNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegisterNewUser.Click
        frmRegisterNewUser.ShowDialog()
        frmRegisterNewUser.TopMost = True
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If exitForm() = True Then
            frmLogin.Close()
            SplashCSS.Close()
            con.Close()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub mnuChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangePassword.Click
        frmChangePwd.Show()
        frmChangePwd.TopMost = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel.Text = Date.Now.ToLongDateString & " " & Date.Now.ToShortTimeString
    End Sub

    Private Sub frmCSSMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblLoginName.Text = frmLogin.loginName
        sqlstr = "SELECT * FROM LoginCSS WHERE Login_UserName='" & lblLoginName.Text & "'"
        Dim dt As DataTable = getDataTable(sqlstr)
        'lblUserType.Text = dt.Rows(0).Item(3)
        'Call enableMenu()
    End Sub

    Private Sub GenerateReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmFeeCharges.ShowDialog()
    End Sub

    Private Sub mnuLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOut.Click
        If logOutDialog() = True Then
            Me.Hide()
            Me.Dispose()
            frmLogin.Show()
            frmLogin.txtUserName.Clear()
            frmLogin.txtPassword.Clear()
            frmLogin.txtUserName.Focus()
        End If
    End Sub

    Public Function logOutDialog() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you want to log out?", "Login Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        'About.ShowDialog()
        'About.TopMost = True
    End Sub

    Private Sub btnScoreControlPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreControlPanel.Click
        dialogTeamSelect.ShowDialog()
        dialogTeamSelect.TopMost = True
    End Sub

    Private Sub btnAddPlayers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlayers.Click
        frmPlayer_Add.ShowDialog()
        frmPlayer_Add.TopMost = True
    End Sub

    Private Sub btnAddTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTeams.Click
        frmTeam_Add.ShowDialog()
        frmTeam_Add.TopMost = True
    End Sub
End Class
