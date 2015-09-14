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
        If SelectTF2Instalation.SelectedPath.Contains("tf\custom") Then
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

    End Sub
End Class
