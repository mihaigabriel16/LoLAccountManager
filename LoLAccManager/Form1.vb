Imports System.IO
Imports System.Windows

Public Class Form1
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readCredFile()
        Label2.Text = FlowLayoutPanel1.Controls.Count
    End Sub

    Private Sub createAccButton(ByVal text)
        Dim button As New Button
        button.Size = New Size(760, 40)
        button.Text = text
        button.ForeColor = Color.White
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        FlowLayoutPanel1.Controls.Add(button)
    End Sub

    Private Sub createFormButton(ByVal text)
        Dim f As New accountForm
        f.TopLevel = False
        f.TopMost = True
        f.Show()
        f.data = text
        f.loadData()
        FlowLayoutPanel1.Controls.Add(f)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub readCredFile()
        Dim filePath As String = "file.txt"

        ' Create a StreamReader object to read the file
        Using reader As StreamReader = New StreamReader(filePath)
            ' Read each line of the file until the end is reached
            While Not reader.EndOfStream
                ' Read the current line
                Dim line As String = reader.ReadLine()

                ' Process the line (e.g. display it in a message box)
                If line.Length > 0 Then
                    createFormButton(line)
                End If
            End While
        End Using
    End Sub

End Class
