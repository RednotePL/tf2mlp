Public Class MainMenu



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullInstallBtn.Checked = True
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

        Dim pi As New ProcessStartInfo("wget.exe", "https://github.com/SuperStarPL/tf2mlp/raw/master/sspl_mlp_dir.vpk --no-check-certificate")
        Process.Start(pi)

        'Process.Start(Application.StartupPath & "wget.exe", "") As Process
    End Sub

    Public Sub MinimalInstall()

    End Sub
End Class
