Public Class MainMenu



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullInstallBtn.Checked = True
        MinimalInstallBtn.Enabled = False
        CustomInstallBtn.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles FullInstallBtn.CheckedChanged

    End Sub

    Private Sub OpenFolderDialog_Click(sender As Object, e As EventArgs) Handles OpenFolderDialog.Click
        SelectTF2Instalation.ShowDialog()
        If SelectTF2Instalation.SelectedPath.Contains("Team Fortress 2\tf\custom") Then
            PathInCorrectText.Visible = False
            PathCorrectText.Visible = True

            ButtonInstall.Enabled = True
        Else
            PathCorrectText.Visible = False
            PathInCorrectText.Visible = True

            ButtonInstall.Enabled = False
        End If
    End Sub

    Private Sub ButtonInstall_Click(sender As Object, e As EventArgs) Handles ButtonInstall.Click

        ButtonInstall.Enabled = False

        If (FullInstallBtn.Checked = True) Then
            FullInstall()
        End If
        If (MinimalInstallBtn.Checked = True) Then
            MinimalInstall()
        End If
    End Sub

    Public Sub FullInstall()

        'pi.Arguments = "https://github.com/SuperStarPL/tf2mlp/raw/master/sspl_mlp_dir.vpk"

        'Dim wget As New ProcessStartInfo("wget.exe", "https://github.com/SuperStarPL/tf2mlp/raw/dev/sspl_mlp_dir.vpk --no-check-certificate")
        'Dim wget2 As New ProcessStartInfo("wget.exe", "https://github.com/SuperStarPL/tf2mlp/raw/dev/Installer/7za.exe --no-check-certificate")

        Dim wget As New ProcessStartInfo("wget.exe", "http://dev.superstar.pl:82/minimal.7z --no-check-certificate")

        Dim wget2 As New ProcessStartInfo("wget.exe", "http://dev.superstar.pl:82/sound.7z --no-check-certificate")

        Dim sevenza As New ProcessStartInfo("7za.exe", "e minimal.7z -otemp -y")

        InstallationProgressBar.Visible = True
        InstallationProgressBar.Value = 10
        Process.Start(wget).WaitForExit()
        InstallationProgressBar.Value = 20
        ' Process.Start(wget2).WaitForExit()
        InstallationProgressBar.Value = 30
        Process.Start(sevenza).WaitForExit()
        InstallationProgressBar.Value = 50
        My.Computer.FileSystem.MoveDirectory(Application.StartupPath & "\temp", SelectTF2Instalation.SelectedPath)
        InstallationProgressBar.Value = 99
        DoneDialog.Show()
        InstallationProgressBar.Value = 100

    End Sub

    Public Sub MinimalInstall()

    End Sub
End Class
