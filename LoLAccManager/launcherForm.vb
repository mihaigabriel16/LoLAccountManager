Imports System.Net.NetworkInformation
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class launcherForm
    Private Sub launcherForm_Load(sender As Object, e As EventArgs) Handles MyClass.Load
        If String.IsNullOrEmpty(My.Settings.LoLPath) Then
        Else
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialog As New FolderBrowserDialog()
        Dim result As DialogResult = dialog.ShowDialog()

        ' If the user selected a folder, save the path in project settings
        If result = DialogResult.OK Then
            My.Settings.LoLPath = dialog.SelectedPath
            TextBox1.Text = My.Settings.LoLPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Save()
        Form1.Show()
        Me.Hide()
    End Sub
End Class