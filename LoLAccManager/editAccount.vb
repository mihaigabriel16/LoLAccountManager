Public Class editAccount
    Dim data = ""
    Public Sub loadData(ByVal text)
        Dim str = text
        data = str
        Dim splitString() As String = str.Split({"|"}, StringSplitOptions.None)
        ComboBox1.Text = splitString(0)
        TextBox1.Text = splitString(1)
        TextBox2.Text = splitString(2)
        TextBox3.Text = splitString(3)
    End Sub

    Private Sub editAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filePath As String = "file.txt"
        Dim lines As String() = System.IO.File.ReadAllLines(filePath)
        Dim stringToDelete As String = data ' Replace with the string you want to delete
        Dim newLines As New List(Of String)(lines)
        For i As Integer = newLines.Count - 1 To 0 Step -1
            If newLines(i) = stringToDelete Then
                newLines.RemoveAt(i)
            End If
        Next
        System.IO.File.WriteAllLines(filePath, newLines.ToArray())
        Form1.DeleteFLP()
        Form1.readCredFile()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class