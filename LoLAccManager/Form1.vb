Imports System.IO
Imports System.Windows

Public Class Form1
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        readCredFile()
        Label2.Text = FlowLayoutPanel1.Controls.Count
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

    Public Sub DeleteFLP()
        For Each control As Control In FlowLayoutPanel1.Controls
            FlowLayoutPanel1.Controls.Remove(control)
            control.Dispose()
        Next
    End Sub

    Public Sub readCredFile()

        Dim filePath As String = "file.txt"

        If File.Exists(filePath) Then
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
        End If
        ' Create a StreamReader object to read the file

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        settingsForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        addAccount.ShowDialog()
    End Sub

    Public Shared Sub AddAccountToList(ByVal text)
        Form1.createFormButton(text)
        Form1.Label2.Text = Form1.FlowLayoutPanel1.Controls.Count
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


End Class
