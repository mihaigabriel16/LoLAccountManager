Public Class settingsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show the folder browser dialog
        Dim dialog As New FolderBrowserDialog()
        Dim result As DialogResult = dialog.ShowDialog()

        ' If the user selected a folder, save the path in project settings
        If result = DialogResult.OK Then
            My.Settings.LoLPath = dialog.SelectedPath
            TextBox2.Text = My.Settings.LoLPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = My.Settings.LoLPath
        CheckBox1.Checked = My.Settings.LocalAPI
        TextBox1.Text = My.Settings.APIKey

        If CheckBox1.Checked = False Then
            TextBox1.Enabled = False
        Else
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.LocalAPI = True
            My.Settings.Save()
            TextBox1.Enabled = True
        Else
            My.Settings.LocalAPI = False
            My.Settings.Save()
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.APIKey = TextBox1.Text
        My.Settings.Save()
    End Sub
End Class