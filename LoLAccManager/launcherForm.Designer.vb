<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class launcherForm
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
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(0), CByte(0), CByte(0))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(600, 250)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(169, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 15)
        Label1.TabIndex = 4
        Label1.Text = "Please select the intall path of League of Legends."' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(238, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 23)
        Button3.TabIndex = 3
        Button3.Text = "SAVE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(413, 135)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(276, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 25)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(575, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(25, 25)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' launcherForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gangplank_lol_dreadnova_splash_art_uhdpaper_com_4K_194_wp_thumbnail
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(600, 250)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "launcherForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "launcherForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
