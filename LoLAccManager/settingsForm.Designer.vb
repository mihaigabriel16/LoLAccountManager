<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsForm
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
        Panel1 = New Panel()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 400)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Firebrick
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(375, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(25, 25)
        Button2.TabIndex = 2
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(11, 165)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(376, 82)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "League of Legends"' 
        ' Button1
        ' 
        Button1.Location = New Point(295, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 49)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(282, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 0
        Label1.Text = "Path"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(11, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 80)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Riot API Settings"' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(6, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(364, 23)
        TextBox1.TabIndex = 1
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 22)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(115, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Use Personal Key"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' settingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 400)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "settingsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "settingsForm"
        Panel1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
