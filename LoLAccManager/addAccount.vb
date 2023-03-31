Imports System.IO

Public Class addAccount
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = "file.txt"
        If String.IsNullOrEmpty(ComboBox1.Text) Or String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Then
            MsgBox("One or more values is empty.")
        Else
            Dim newLine As String = ComboBox1.Text & "|" & TextBox1.Text & "|" & TextBox2.Text & "|" & TextBox3.Text
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(newLine)
                Form1.AddAccountToList(newLine)
                Me.Close()
            End Using
        End If

    End Sub
End Class