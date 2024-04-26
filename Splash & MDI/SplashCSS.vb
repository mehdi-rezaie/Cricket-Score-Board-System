Public NotInheritable Class SplashCSS

    Private Sub SplashCSS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "Cricket Scoreboard System"
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub timerfrmLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerfrmLoad.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            timerfrmLoad.Stop()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        timerfrmLoad.Start()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
