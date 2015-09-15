<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FullInstallBtn = New System.Windows.Forms.RadioButton()
        Me.MinimalInstallBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SelectTF2Instalation = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFolderDialog = New System.Windows.Forms.Button()
        Me.PathCorrectText = New System.Windows.Forms.Label()
        Me.PathInCorrectText = New System.Windows.Forms.Label()
        Me.ButtonInstall = New System.Windows.Forms.Button()
        Me.TimerCheckEnabled = New System.Windows.Forms.Timer(Me.components)
        Me.InstallationProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FullInstallBtn
        '
        Me.FullInstallBtn.AutoSize = True
        Me.FullInstallBtn.Location = New System.Drawing.Point(6, 20)
        Me.FullInstallBtn.Name = "FullInstallBtn"
        Me.FullInstallBtn.Size = New System.Drawing.Size(125, 17)
        Me.FullInstallBtn.TabIndex = 0
        Me.FullInstallBtn.Text = "Full (with sounds)"
        Me.FullInstallBtn.UseVisualStyleBackColor = True
        '
        'MinimalInstallBtn
        '
        Me.MinimalInstallBtn.AutoSize = True
        Me.MinimalInstallBtn.Location = New System.Drawing.Point(6, 38)
        Me.MinimalInstallBtn.Name = "MinimalInstallBtn"
        Me.MinimalInstallBtn.Size = New System.Drawing.Size(167, 17)
        Me.MinimalInstallBtn.TabIndex = 2
        Me.MinimalInstallBtn.Text = "Minimal (without sounds)"
        Me.MinimalInstallBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MinimalInstallBtn)
        Me.GroupBox1.Controls.Add(Me.FullInstallBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 67)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Installation:"
        '
        'SelectTF2Instalation
        '
        Me.SelectTF2Instalation.Description = "Select your 'custom' folder"
        Me.SelectTF2Instalation.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86
        Me.SelectTF2Instalation.SelectedPath = "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom"
        Me.SelectTF2Instalation.ShowNewFolderButton = False
        '
        'OpenFolderDialog
        '
        Me.OpenFolderDialog.Location = New System.Drawing.Point(18, 12)
        Me.OpenFolderDialog.Name = "OpenFolderDialog"
        Me.OpenFolderDialog.Size = New System.Drawing.Size(167, 23)
        Me.OpenFolderDialog.TabIndex = 4
        Me.OpenFolderDialog.Text = "Select 'custom' folder"
        Me.OpenFolderDialog.UseVisualStyleBackColor = True
        '
        'PathCorrectText
        '
        Me.PathCorrectText.AutoSize = True
        Me.PathCorrectText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.PathCorrectText.ForeColor = System.Drawing.Color.Lime
        Me.PathCorrectText.Location = New System.Drawing.Point(191, 17)
        Me.PathCorrectText.Name = "PathCorrectText"
        Me.PathCorrectText.Size = New System.Drawing.Size(102, 13)
        Me.PathCorrectText.TabIndex = 5
        Me.PathCorrectText.Text = "PATH CORRECT"
        Me.PathCorrectText.Visible = False
        '
        'PathInCorrectText
        '
        Me.PathInCorrectText.AutoSize = True
        Me.PathInCorrectText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.PathInCorrectText.ForeColor = System.Drawing.Color.Red
        Me.PathInCorrectText.Location = New System.Drawing.Point(191, 17)
        Me.PathInCorrectText.Name = "PathInCorrectText"
        Me.PathInCorrectText.Size = New System.Drawing.Size(117, 13)
        Me.PathInCorrectText.TabIndex = 6
        Me.PathInCorrectText.Text = "PATH INCORRECT"
        Me.PathInCorrectText.Visible = False
        '
        'ButtonInstall
        '
        Me.ButtonInstall.Enabled = False
        Me.ButtonInstall.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonInstall.Location = New System.Drawing.Point(13, 216)
        Me.ButtonInstall.Name = "ButtonInstall"
        Me.ButtonInstall.Size = New System.Drawing.Size(306, 33)
        Me.ButtonInstall.TabIndex = 7
        Me.ButtonInstall.Text = "INSTALL"
        Me.ButtonInstall.UseVisualStyleBackColor = True
        '
        'TimerCheckEnabled
        '
        Me.TimerCheckEnabled.Enabled = True
        '
        'InstallationProgressBar
        '
        Me.InstallationProgressBar.Location = New System.Drawing.Point(13, 147)
        Me.InstallationProgressBar.Name = "InstallationProgressBar"
        Me.InstallationProgressBar.Size = New System.Drawing.Size(306, 23)
        Me.InstallationProgressBar.TabIndex = 8
        Me.InstallationProgressBar.Visible = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 261)
        Me.Controls.Add(Me.InstallationProgressBar)
        Me.Controls.Add(Me.ButtonInstall)
        Me.Controls.Add(Me.PathInCorrectText)
        Me.Controls.Add(Me.PathCorrectText)
        Me.Controls.Add(Me.OpenFolderDialog)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TF2MLP Installer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FullInstallBtn As RadioButton
    Friend WithEvents MinimalInstallBtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SelectTF2Instalation As FolderBrowserDialog
    Friend WithEvents OpenFolderDialog As Button
    Friend WithEvents PathCorrectText As Label
    Friend WithEvents PathInCorrectText As Label
    Friend WithEvents ButtonInstall As Button
    Friend WithEvents TimerCheckEnabled As Timer
    Friend WithEvents InstallationProgressBar As ProgressBar
End Class
